#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// Este programa es software libre; puede distribuirlo y/o moficiarlo de
// acuerdo a los términos de la Licencia Pública General de GNU (GNU
// General Public License), como la publica la Fundación para el Software
// Libre (Free Software Foundation), tanto la versión 3 de la Licencia
// como (a su elección) cualquier versión posterior.
//
// Este programa se distribuye con la esperanza de que sea útil, pero SIN
// GARANTÍA ALGUNA; ni siquiera la garantía MERCANTIL implícita y sin
// garantizar su CONVENIENCIA PARA UN PROPÓSITO PARTICULAR. Véase la
// Licencia Pública General de GNU para más detalles. 
//
// Debería haber recibido una copia de la Licencia Pública General junto
// con este programa. Si no ha sido así, vea <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Lazaro
{
        public class Aplicacion
        {
                public static Principal.Inicio FormularioPrincipal;
                public static Lui.Forms.ProgressForm FormularioProgreso;
                public static IList<Lfx.Types.OperationProgress> Operaciones = new List<Lfx.Types.OperationProgress>();
                public static bool Flotante;

                /// <summary>
                /// Obtiene la versión del ejecutable principal.
                /// </summary>
                [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
                public static string Version()
                {
                        System.Diagnostics.FileVersionInfo Ver = System.Diagnostics.FileVersionInfo.GetVersionInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe");
                        return Ver.ProductVersion.ToString();
                }

                /// <summary>
                /// Obtiene la fecha del ejecutable principal.
                /// </summary>
                public static DateTime BuildDate()
                {
                        System.IO.FileInfo InfoArchivo = new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
                        return InfoArchivo.LastWriteTime;
                }

                /// <summary>
                /// Punto de entrada principal del programa. Hace la conexión a la base de datos y llama a IniciarNormal.
                /// </summary>
                [STAThread, SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
                public static int Main(string[] args)
                {
                        System.Threading.Thread.CurrentThread.Name = "Lazaro";

                        bool ReconfigDB = false, DebugMode = false, IgnoreUpdates = false;
                        bool MostrarAsistenteConfig = false, ClearCache = false;

                        string NombreConfig = "default";

                        if (args != null) {
                                foreach (string Argumento in args) {
                                        switch (Argumento) {
                                                case "/config":
                                                case "--config":
                                                        ReconfigDB = true;
                                                        break;

                                                case "/wizard":
                                                case "--wizard":
                                                        MostrarAsistenteConfig = true;
                                                        break;

                                                case "/ignoreupdates":
                                                case "--ignoreupdates":
                                                        IgnoreUpdates = true;
                                                        break;

                                                case "/clearcache":
                                                case "--clearcache":
                                                        ClearCache = true;
                                                        break;

                                                case "/help":
                                                case "--help":
                                                case "/?":
                                                        if (Lfx.Environment.SystemInformation.Platform == Lfx.Environment.SystemInformation.Platforms.Windows)
                                                                System.Windows.Forms.MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + @" [/config] [/ignoreupdates] [/debug] [/clearcache] [/ignoreupdates] [EspacioTrabajo]", "Ayuda");
                                                        else
                                                                System.Windows.Forms.MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + @" [--config] [--ignoreupdates] [--debug] [--clearcache] [--ignoreupdates] [EspacioTrabajo]", "Ayuda");
                                                        System.Environment.Exit(0);
                                                        break;

                                                case "/debug":
                                                case "--debug":
                                                        DebugMode = true;
                                                        IgnoreUpdates = true;
                                                        break;

                                                default:
                                                        NombreConfig = System.IO.Path.GetFileNameWithoutExtension(Argumento);
                                                        break;
                                        }
                                }
                        }

                        // Manejadores de excepciones
                        Application.EnableVisualStyles();
                        if (DebugMode == false) {
                                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ThreadExceptionHandler);
                                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);
                                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                        }

                        if (System.IO.File.Exists(Lfx.Environment.Folders.ApplicationDataFolder + "clear.txt"))
                                ClearCache = true;


                        // Busco actualización en la caché
                        if (ClearCache) {
                                try {
                                        Lfx.Environment.Folders.DeleteWithWildcards(Lfx.Environment.Folders.TemporaryFolder, "*.*");
                                } catch {
                                        // Si algún archivo no se puede borrar, no importa
                                }

                                try {
                                        Lfx.Environment.Folders.DeleteWithWildcards(Lfx.Environment.Folders.UpdatesFolder, "*.*");
                                        Lfx.Environment.Folders.DeleteWithWildcards(Lfx.Environment.Folders.UpdatesFolder + "Components" + System.IO.Path.DirectorySeparatorChar, "*.*");
                                } catch {
                                        // Si algún archivo no se puede borrar, no importa
                                }

                                try {
                                        Lfx.Environment.Folders.DeleteWithWildcards(Lfx.Environment.Folders.ApplicationDataFolder, "clear.txt");
                                } catch {
                                        // Si algún archivo no se puede borrar, no importa
                                }

                        }


                        if (IgnoreUpdates == false) {
                                // Si hay actualizaciones pendientes, reinicio para que ActualizadorLazaro se encargue de ellas.
                                string[] ArchivosNuevos = System.IO.Directory.GetFiles(Lfx.Environment.Folders.ApplicationFolder, "*.new", System.IO.SearchOption.AllDirectories);
                                if (ArchivosNuevos.Length > 0) {
                                        System.Console.WriteLine("Existen actualizaciones pendientes. Ejecutando ActualizadorLazaro");
                                        if (Lfx.Environment.SystemInformation.IsUacActive)
                                                Lui.Forms.MessageBox.Show("A continuación se van a instalar actualizaciones del programa. Es posible que el sistema le solicite autorización para continuar con la instalación. Luego de la actualización el sistema iniciará nuevamente.", "Lázaro");
                                        else
                                                Lui.Forms.MessageBox.Show("A continuación se van a instalar actualizaciones del programa. Luego de la actualización el sistema iniciará nuevamente.", "Lázaro");
                                        Lfx.Environment.Shell.Reboot();
                                }
                        }


                        // Verifico estar utilizando un Encoding compatible (ISO-8859-1 o UTF-8)
                        if (System.Text.Encoding.Default.BodyName != "iso-8859-1"
                                && System.Text.Encoding.Default.BodyName != "utf-8") {
                                System.Windows.Forms.MessageBox.Show("La códificación " + System.Text.Encoding.Default.BodyName.ToUpperInvariant() + " no es válida. Sólo se permiten las codificaciones ISO-8859-1 (Latin-1) y UTF-8.", "Error");
                                System.Windows.Forms.Application.Exit();
                        }


                        DescargarArchivosNecesarios();

                        //Si no hay espacio de trabajo predeterminado (default.lwf), presento una ventana de selección
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationDataFolder);
                        if (Dir.GetFiles(NombreConfig + ".lwf").Length == 0 && Dir.GetFiles("*.lwf").Length >= 1) {
                                using (Lui.Forms.WorkspaceSelectorForm SelectEspacio = new Lui.Forms.WorkspaceSelectorForm()) {
                                        if (SelectEspacio.ShowDialog() == DialogResult.OK) {
                                                NombreConfig = SelectEspacio.WorkspaceName;
                                                if (NombreConfig == null)
                                                        System.Environment.Exit(0);
                                        } else {
                                                System.Environment.Exit(0);
                                        }
                                }
                        }

                        // Inicio el espacio de trabajo
                        Lfx.Workspace.Master = new Lfx.Workspace(NombreConfig, false, false);
                        Lfx.Workspace.Master.DebugMode = DebugMode;
                        Lfx.Workspace.Master.RunTime.IpcEvent += new Lfx.RunTimeServices.IpcEventHandler(Workspace_IpcEvent);
                        
                        // Asigno a la aplicación WinForms la misma cultura que se está usando en el espacio de trabajo
                        System.Windows.Forms.Application.CurrentCulture = Lfx.Workspace.Master.CultureInfo;

                        // Si no hay datos de configuración, voy a presentar el asistente
                        if (Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "DataSource", null) == null)
                                MostrarAsistenteConfig = true;

                        if (MostrarAsistenteConfig) {
                                // Presento el asistente de configurar almacén de datos
                                using (Misc.Config.Inicial AsistenteInicial = new Misc.Config.Inicial()) {
                                        if (AsistenteInicial.ShowDialog() == DialogResult.Cancel)
                                                System.Environment.Exit(0);
                                }
                        } else if (ReconfigDB) {
                                // Presento la ventana de configuración del almacén de datos
                                using (Misc.Config.ConfigurarBd ConfigBD = new Misc.Config.ConfigurarBd()) {
                                        if (ConfigBD.ShowDialog() == DialogResult.Cancel)
                                                System.Environment.Exit(0);
                                }
                        }

                        IniciarDatos();

                        Lfx.Workspace.Master.InitUpdater();

                        CargarComponentes();

                        if (IgnoreUpdates == false) {
                                // Verifico la versión de Lázaro requerida por la BD
                                DateTime FechaLazaroExe = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location);
                                DateTime MinVersion = DateTime.ParseExact(Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<string>("Sistema", "DB.VersionMinima", "2000-01-01 00:00:00"), Lfx.Types.Formatting.DateTime.SqlDateTimeFormat, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.AssumeUniversal);
                                if (FechaLazaroExe < MinVersion) {
                                        Misc.ActualizarAhora Act = new Misc.ActualizarAhora();
                                        DialogResult Res = Act.ShowDialog();
                                        switch (Res) {
                                                case DialogResult.OK:
                                                        Lfx.Environment.Shell.Reboot();
                                                        break;
                                                default:
                                                        Lfx.Workspace.Master.RunTime.Message("La versión de Lázaro que está utilizando es demasiado antigua. Descargue e instale la última versión para continuar. Si desea más información ingrese a la página web www.sistemalazaro.com.ar");
                                                        break;
                                        }
                                        System.Environment.Exit(1);
                                } else {
                                        // Cumple con la versión requerida, pero de todos modos verifico si es necesario actualizar Lázaro
                                        DateTime VersionEstructura = DateTime.ParseExact(Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<string>("Sistema", "DB.VersionEstructura", "2000-01-01 00:00:00"), Lfx.Types.Formatting.DateTime.SqlDateTimeFormat, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.AssumeUniversal);
                                        TimeSpan Diferencia = FechaLazaroExe - VersionEstructura;

                                        if (Diferencia.TotalHours < -12) {
                                                // Lázaro es más viejo que la bd por al menos 12 horas
                                                Misc.ActualizarAhora Act = new Misc.ActualizarAhora();
                                                DialogResult Res = Act.ShowDialog();
                                                switch (Res) {
                                                        case DialogResult.OK:
                                                                Lfx.Environment.Shell.Reboot();
                                                                break;
                                                        default:
                                                                Lfx.Workspace.Master.RunTime.Message("La versión de Lázaro que está utilizando es demasiado antigua. Puede continuar trabajando, pero es recomendable que descargue e instale la última versión.");
                                                                break;
                                                }
                                        }
                                }
                        }

                        if (Lfx.Environment.SystemInformation.DesignMode == false) {
                                // Si es necesario, actualizo la estructura de la base de datos
                                Lfx.Workspace.Master.CheckAndUpdateDataBaseVersion(false, false);
                        }

                        Lfx.Types.OperationResult ResultadoInicio = IniciarGui();

                        if (ResultadoInicio.Success == false)
                                Lui.Forms.MessageBox.Show(ResultadoInicio.Message, "Error al Iniciar");

                        return 0;
                }


                /// <summary>
                /// Carga en memoria los componentes registrados en la base de datos
                /// </summary>
                private static void CargarComponentes()
                {
                        // Cargo el componente Core
                        Lbl.Componentes.Componente CoreComp = new Lbl.Componentes.Componente(Lfx.Workspace.Master.MasterConnection);
                        CoreComp.Crear();

                        CoreComp.Nombre = "Core";
                        CoreComp.EspacioNombres = "Lfc";
                        CoreComp.Assembly = System.Reflection.Assembly.LoadFrom("Lfc.dll");
                        Lfx.Components.Manager.ComponentesCargados.Add("Core", CoreComp);

                        Lfx.Components.Manager.RegisterComponent(CoreComp);

                        if (Lfx.Workspace.Master.MasterConnection.Tables.ContainsKey("sys_components")) {
                                Lbl.ColeccionGenerica<Lbl.Componentes.Componente> Comps = Lbl.Componentes.Componente.Todos();
                                foreach (Lbl.Componentes.Componente Comp in Comps) {
                                        // Cargar todos los componentes en memoria
                                        Comp.UrlActualizaciones = Comp.UrlActualizaciones;
                                        try {
                                                Lfx.Components.Manager.RegisterComponent(Comp);
                                                if (Comp.Estructura != null) {
                                                        System.Xml.XmlDocument Doc = new System.Xml.XmlDocument();
                                                        Doc.LoadXml(Comp.Estructura);
                                                        Lfx.Workspace.Master.Structure.AddToBuiltIn(Doc);
                                                }
                                                if (Lfx.Environment.SystemInformation.DesignMode == false && Comp.ObtenerVersionActual() > Comp.Version) {
                                                        // Actualizo el CIF y la estrucutra en la BD
                                                        Comp.Version = Comp.ObtenerVersionActual();
                                                        Comp.Guardar();
                                                }

                                                Lfx.Updates.Package Pkg = new Lfx.Updates.Package();
                                                Pkg.Name = Comp.EspacioNombres;
                                                Pkg.RelativePath = "Components" + System.IO.Path.DirectorySeparatorChar + Comp.EspacioNombres + System.IO.Path.DirectorySeparatorChar;
                                                Pkg.Url = Comp.UrlActualizaciones;

                                                if (Lfx.Updates.Updater.Master != null)
                                                        Lfx.Updates.Updater.Master.Packages.Add(Pkg);
                                        } catch (Exception ex) {
                                                if (Lfx.Workspace.Master != null) {
                                                        Lfx.Workspace.Master.RunTime.Message("No se puede registrar el componente " + Comp.Nombre + "." + ex.Message);
                                                        UnknownExceptionHandler(ex);
                                                }
                                        }
                                }
                        }
                }


                /// <summary>
                /// Descarga en caso de que haga falta algunos ensamblados necesarios para el funcionamiento del programa.
                /// </summary>
                private static void DescargarArchivosNecesarios()
                {
                        IList<string> ArchivosNecesarios = new List<string>()
                        {
                                "Interop.WIA.dll",
                                "MySql.Data.dll",
                                "ICSharpCode.SharpZipLib.dll"
                        };
                        IList<string> ArchivosFaltantes = new List<string>();

                        foreach (string Arch in ArchivosNecesarios) {
                                if (System.IO.File.Exists(Arch) == false)
                                        ArchivosFaltantes.Add(Arch);
                        }

                        if (ArchivosFaltantes.Count > 0) {
                                Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Descargando archivos adicionales", "Se van a descargar algunos archivos necesarios para el funcionamiento de Lázaro");
                                Progreso.Max = ArchivosFaltantes.Count;
                                Progreso.Begin();
                                
                                bool CanWriteToAppFolder = Lfx.Environment.SystemInformation.CanWriteToAppFolder;
                                using (WebClient Cliente = new WebClient()) {
                                        foreach (string Arch in ArchivosFaltantes) {
                                                Progreso.ChangeStatus("Descargando " + Arch);
                                                string ArchDestino;
                                                if (CanWriteToAppFolder)
                                                        // Lo descargo directamente a la carpeta de la aplicación
                                                        ArchDestino = Lfx.Environment.Folders.ApplicationFolder + Arch;
                                                else
                                                        // Tengo UAC, lo descargo a la carpeta de actualizaciones y luego tengo que iniciar el ActualizadorLazaro.exe
                                                        ArchDestino = Lfx.Environment.Folders.UpdatesFolder + Arch + ".new";
                                                
                                                try {
                                                        Cliente.DownloadFile(@"http://www.sistemalazaro.com.ar/aslnlwc/" + Arch, ArchDestino);
                                                } catch {

                                                }
                                                Progreso.Advance(1);
                                        }
                                }
                                Progreso.End();

                                if (CanWriteToAppFolder == false)
                                        Lfx.Environment.Shell.Reboot();
                        }
                }

                /// <summary>
                /// Maneja eventos disparados por el (mal llamado) IPC (comunicación inter-proceso) del espacio de trabajo.
                /// </summary>
                public static void Workspace_IpcEvent(object sender, ref Lfx.RunTimeServices.IpcEventArgs e)
                {
                        if (e.Destination == "lazaro") {
                                switch (e.EventType) {
                                        case Lfx.RunTimeServices.IpcEventArgs.EventTypes.ActionRequest:
                                                if (e.Arguments != null)
                                                        e.ReturnValue = Exec(e.Verb + " " + string.Join(" ", (string[])e.Arguments));
                                                else
                                                        e.ReturnValue = Exec(e.Verb);
                                                break;
                                        case Lfx.RunTimeServices.IpcEventArgs.EventTypes.Progress:
                                                Lfx.Types.OperationProgress Prog = (Lfx.Types.OperationProgress)(e.Arguments[0]);
                                                if (Operaciones.Contains(Prog) == false)
                                                        // Agrego a la lista de operaciones en progreso
                                                        Operaciones.Add(Prog);

                                                if (Prog.Advertise) {
                                                        if (Aplicacion.FormularioPrincipal == null || Prog.Blocking) {
                                                                if (Aplicacion.FormularioProgreso == null) {
                                                                        Aplicacion.FormularioProgreso = new Lui.Forms.ProgressForm();
                                                                        Aplicacion.FormularioProgreso.Show();
                                                                }
                                                                Aplicacion.FormularioProgreso.MostrarProgreso(Operaciones, Prog);
                                                        } else {
                                                                if (FormularioPrincipal.InvokeRequired) {
                                                                        MethodInvoker Mi = delegate { FormularioPrincipal.ShowProgress(Prog); };
                                                                        FormularioPrincipal.Invoke(Mi);
                                                                } else {
                                                                        FormularioPrincipal.ShowProgress(Prog);
                                                                }
                                                        }
                                                }

                                                if (Prog.IsDone) {
                                                        if (Operaciones.Contains(Prog))
                                                                Operaciones.Remove(Prog);

                                                        if (Operaciones.Count == 0) {
                                                                // Si no quedan más operaciones en progreso, deshecho el formulario
                                                                if (Aplicacion.FormularioProgreso != null) {
                                                                        Aplicacion.FormularioProgreso.Dispose();
                                                                        Aplicacion.FormularioProgreso = null;
                                                                }
                                                        }
                                                }
                                                System.Windows.Forms.Application.DoEvents();
                                                break;
                                        case Lfx.RunTimeServices.IpcEventArgs.EventTypes.Information:
                                                switch (e.Verb) {
                                                        case "ITEMFOCUS":
                                                                if (Aplicacion.FormularioPrincipal != null) {
                                                                        if (e.Arguments.Length >= 3 && e.Arguments[0].ToString() == "TABLE") {
                                                                                string Tabla = e.Arguments[1].ToString();
                                                                                int ItemId = e.Arguments[2].ToString().ParseInt();
                                                                                Aplicacion.FormularioPrincipal.MostrarItem(Tabla, ItemId);
                                                                        }
                                                                }
                                                                break;
                                                        case "MESSAGE":
                                                                Lui.Forms.MessageBox.Show(e.Arguments[0].ToString(), "Aviso");
                                                                break;
                                                }
                                                break;
                                }
                        }
                }

                /// <summary>
                /// Inicia el acceso al almacén de datos.
                /// </summary>
                private static void IniciarDatos()
                {
                        do {
                                Lfx.Types.OperationResult Res = AbrirConexion();

                                // Si no pudo conectar, muestro la configuración de la base de datos
                                // Si hay DSN, muestro el error
                                if (Res.Success == false) {
                                        bool MostrarConfig = true;

                                        if (Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "DataSource", null) != null) {
                                                using (Misc.Config.ErrorConexion FormError = new Misc.Config.ErrorConexion()) {
                                                        if (Res.Message.IndexOf("Unable to connect to any of the specified MySQL hosts") >= 0) {
                                                                if (Lfx.Data.DataBaseCache.DefaultCache.ServerName.ToLowerInvariant() == "localhost") {
                                                                        string TipoServidor = "";
                                                                        switch (Lfx.Data.DataBaseCache.DefaultCache.AccessMode) {
                                                                                case Lfx.Data.AccessModes.MySql:
                                                                                        TipoServidor = "MySQL";
                                                                                        break;
                                                                                case Lfx.Data.AccessModes.MSSql:
                                                                                        TipoServidor = "SQL Server";
                                                                                        break;
                                                                                case Lfx.Data.AccessModes.Npgsql:
                                                                                        TipoServidor = "PostgreSQL";
                                                                                        break;
                                                                                case Lfx.Data.AccessModes.Oracle:
                                                                                        TipoServidor = "Oracle";
                                                                                        break;
                                                                        }
                                                                        FormError.Ayuda = @"No se puede conectar con el servidor local. Verifique que el servidor " + TipoServidor + @" se encuentra instalado y funcionando en este equipo.
Si necesita información sobre cómo instalar o configurar un servidor SQL para Lázaro, consulte la ayuda en línea en www.sistemalazaro.com.ar";
                                                                } else {
                                                                        FormError.Ayuda = "No se puede conectar con el servidor remoto. Verifique que el servidor en el equipo remoto '" + Lfx.Data.DataBaseCache.DefaultCache.ServerName + @"' se encuentre funcionando y que su conexión de red esté activa.";
                                                                }
                                                        } else if (Res.Message.IndexOf("Access denied for user") >= 0) {
                                                                FormError.Ayuda = "El servidor impidió el acceso debido a que el nombre de usuario o la contraseña son incorrectos. Haga clic en 'Configurarción' y luego en 'Vista Avanzada' y verifique la configuración proporcionada.";
                                                        } else {
                                                                FormError.Ayuda = "No se dispone de información extendida sobre el error. Por favor lea el mensaje de error original a continuación:";
                                                        }

                                                        FormError.ErrorOriginal = Res.Message;

                                                        switch (FormError.ShowDialog()) {
                                                                case DialogResult.Cancel:
                                                                        MostrarConfig = false;
                                                                        System.Environment.Exit(0);
                                                                        break;

                                                                case DialogResult.Retry:
                                                                        MostrarConfig = false;
                                                                        break;

                                                                case DialogResult.Yes:
                                                                        MostrarConfig = true;
                                                                        break;
                                                        }
                                                }
                                        }

                                        if (MostrarConfig) {
                                                using (Misc.Config.ConfigurarBd ConfigBD = new Misc.Config.ConfigurarBd()) {
                                                        if (ConfigBD.ShowDialog() == DialogResult.Cancel) {
                                                                MostrarConfig = false;
                                                                System.Environment.Exit(0);
                                                        }
                                                }
                                        }
                                } else {
                                        break;
                                }
                        } while (true);

                        // Habilito el gestor de configuración
                        Lbl.Sys.Config.Actual = new Lbl.Sys.Configuracion.Global(Lfx.Workspace.Master);

                        // Habilito la recuperación de conexiones
                        Lfx.Workspace.Master.MasterConnection.EnableRecover = true;
                }

                /// <summary>
                /// Inicia una conexión con la base de datos y verifica si la versión de la la misma es la última disponible. En caso contrario la actualiza.
                /// </summary>
                internal static Lfx.Types.OperationResult AbrirConexion()
                {
                        Lfx.Types.OperationResult iniciarReturn = new Lfx.Types.SuccessOperationResult();

                        //Si el servidor SQL es esta misma PC, intento iniciar el servidor
                        if (Lfx.Environment.SystemInformation.Platform == Lfx.Environment.SystemInformation.Platforms.Windows && Lfx.Data.DataBaseCache.DefaultCache.ServerName.ToUpperInvariant() == "LOCALHOST") {
                                switch (Lfx.Data.DataBaseCache.DefaultCache.AccessMode) {
                                        case Lfx.Data.AccessModes.MySql:
                                                Lfx.Environment.Shell.Execute("net", "start mysql", ProcessWindowStyle.Hidden, true);
                                                break;
                                        case Lfx.Data.AccessModes.Npgsql:
                                                // FIXME: detectar el nombre del servicio.
                                                Lfx.Environment.Shell.Execute("net", "start postgresql-9.0", ProcessWindowStyle.Hidden, true);
                                                break;
                                }
                        }

                        try {
                                Lfx.Workspace.Master.MasterConnection.Open();
                        } catch (Exception ex) {
                                return new Lfx.Types.FailureOperationResult(ex.Message);
                        }

                        if (Lfx.Workspace.Master.IsPrepared() == false) {
                                using (Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog(@"Aparentemente es la primera vez que conecta a este servidor. Antes de poder utilizarlo debe preparar el servidor con una carga inicial de datos.
Responda 'Si' sólamente si es la primera vez que utiliza Lázaro o está restaurando desde una copia de seguridad.", @"¿Desea preparar el servidor """ + Lfx.Workspace.Master.MasterConnection.ToString() + @"""?")) {
                                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                                Lfx.Types.OperationResult Res;
                                                using (Lfx.Data.Connection DataBase = Lfx.Workspace.Master.GetNewConnection("Preparar servidor")) {
                                                        DataBase.RequiresTransaction = false;
                                                        Res = Lfx.Workspace.Master.Prepare();
                                                }
                                                if (Res.Success == false)
                                                        return Res;
                                                else
                                                        Lui.Forms.MessageBox.Show("El servidor fue preparado con éxito. Puede comenzar a utilizar el sistema. La primera vez que ingrese al sistema, utilice el usuario Nº 1 (Administrador) y la contraseña 'admin' (sin las comillas).", "Preparar Servidor");
                                        } else {
                                                return new Lfx.Types.FailureOperationResult("Debe preparar el servidor.");
                                        }
                                }
                        }

                        // Configuro el nivel de aislación predeterminado
                        Lfx.Data.DataBaseCache.DefaultCache.DefaultIsolationLevel = (System.Data.IsolationLevel)(Enum.Parse(typeof(System.Data.IsolationLevel), Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Datos.Aislacion", "Serializable")));

                        return iniciarReturn;
                }

                /// <summary>
                /// Inicia la interfaz gráfica del programa.
                /// </summary>
                private static Lfx.Types.OperationResult IniciarGui()
                {
                        Lbl.Personas.IIdentificadorUnico Cuit = Lbl.Sys.Config.Actual.Empresa.Cuit;
                        if (Cuit == null || Cuit.EsValido() == false) {
                                Misc.Config.Preferencias FormConfig = new Misc.Config.Preferencias();
                                FormConfig.BotonSiguiente.Visible = false;
                                if (FormConfig.ShowDialog() == DialogResult.OK)
                                        Aplicacion.Exec("REBOOT");
                                else
                                        Aplicacion.Exec("QUIT");
                        } else if (Lbl.Sys.Config.Actual.Empresa.Email.Length <= 5) {
                                string Email = Lui.Forms.InputBox.ShowInputBox("Por favor escriba la dirección de correo electrónico (e-mail) de la empresa. Si desea ingresar al sistema sin escribir la dirección ahora, haga clic en Cancelar.", Lbl.Sys.Config.Actual.Empresa.Nombre, "");
                                if (Email != null && Email.Length > 5)
                                        Lbl.Sys.Config.Actual.Empresa.Email = Email;
                        }


                        System.DateTime FechaServidor = System.Convert.ToDateTime(Lfx.Workspace.Master.MasterConnection.FirstRowFromSelect("SELECT NOW()")[0]);
                        System.TimeSpan Diferencia = FechaServidor - System.DateTime.Now;
                        if (Math.Abs(Diferencia.TotalMinutes) > 10) {
                                string DiferenciaExplicada = "";
                                if (Math.Abs(Diferencia.TotalDays) >= 2)
                                        DiferenciaExplicada = Math.Ceiling(Math.Abs(Diferencia.TotalDays)).ToString() + " días";
                                else if (Math.Abs(Diferencia.TotalHours) >= 2)
                                        DiferenciaExplicada = Math.Ceiling(Math.Abs(Diferencia.TotalHours)).ToString() + " horas";
                                else
                                        DiferenciaExplicada = Math.Ceiling(Math.Abs(Diferencia.TotalMinutes)).ToString() + " minutos";

                                Lui.Forms.MessageBox.Show("Existe una diferencia de " + DiferenciaExplicada + " entre el reloj del servidor SQL y el reloj de este equipo. Es necesario que revise y ajuste el reloj de ambos equipos a la brevedad.", "Error de fecha y hora");
                        }

                        Lazaro.Misc.Ingreso FormIngreso = new Lazaro.Misc.Ingreso();
                        FormIngreso.Connection = Lfx.Workspace.Master.MasterConnection;
                        FormIngreso.ShowDialog();
                        FormIngreso.Dispose();
                        FormIngreso = null;

                        if (Lbl.Sys.Config.Actual.UsuarioConectado.Id > 0) {
                                if (Lfx.Workspace.Master.MasterConnection.SlowLink == false && Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Backup.Tipo", "0") == "2") {
                                        string FechaActual = System.DateTime.Now.ToString("yyyy-MM-dd");
                                        string FechaBackup = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Backup.Ultimo", "");
                                        if (FechaActual != FechaBackup) {
                                                int Articulos = Lfx.Workspace.Master.MasterConnection.FieldInt("SELECT COUNT(id_articulo) FROM articulos");
                                                if (Articulos > 0) {
                                                        //Hago un backup automático, una vez por día, siempre que haya al menos 1 artículo en la BD
                                                        //Esto es para evitar hacer backup de una BD vacía
                                                        Aplicacion.Exec("BACKUP NOW");
                                                        Lfx.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema", "Backup.Ultimo", FechaActual);
                                                }
                                        }
                                }

                                // Mostrar qué hay de nuevo
                                string FechaWhatsnew = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<string>("Usuario." + Lbl.Sys.Config.Actual.UsuarioConectado.Id.ToString(), "Whatsnew.Ultimo", "firsttime");
                                if (FechaWhatsnew == "firsttime") {
                                        // Primera vez que entra. No muestro qué hay de nuevo (TODO: pero podría darle una bienvenida)
                                        Lfx.Workspace.Master.CurrentConfig.WriteGlobalSetting("Usuario." + Lbl.Sys.Config.Actual.UsuarioConectado.Id.ToString(), "Whatsnew.Ultimo", System.DateTime.Now.ToString("yyyy-MM-dd"));
                                } else {
                                        // Veo si hay novedades para mostrar
                                        string FechaWhatsnewOriginal = FechaWhatsnew;
                                        System.IO.StreamReader Whatsnew = new System.IO.StreamReader(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Lazaro.whatsnew.txt"));
                                        System.Text.StringBuilder Mostrar = null;
                                        bool Mostrando = false;
                                        while (Whatsnew.EndOfStream == false) {
                                                string Linea = Whatsnew.ReadLine();
                                                if (Linea.Length > 4 && Linea.Substring(0, 4) == "*** ") {
                                                        string FechaLinea = Linea.Substring(4, Linea.Length - 4);
                                                        if (string.Compare(FechaLinea, FechaWhatsnew) > 0) {
                                                                FechaWhatsnew = FechaLinea;
                                                                Linea = Lfx.Types.Parsing.ParseDate(FechaLinea).Value.ToString(Lfx.Types.Formatting.DateTime.LongDatePattern) + ":";
                                                                Mostrando = true;
                                                        }
                                                }

                                                if (Mostrando) {
                                                        if (Mostrar == null) {
                                                                Mostrar = new System.Text.StringBuilder();
                                                                Mostrar.AppendLine("Por favor tómese un momento para leer sobre las novedades incorporadas recientemente en Lázaro:");
                                                                Mostrar.AppendLine("");
                                                        }
                                                        Mostrar.AppendLine(Linea.Replace("* ", "• "));
                                                }
                                        }
                                        Whatsnew.BaseStream.Close();
                                        Whatsnew.Close();
                                        if (Mostrar != null && Mostrar.Length > 0) {
                                                Lui.Forms.MessageBox.Show(Mostrar.ToString(), "Novedades");
                                                Lfx.Workspace.Master.CurrentConfig.WriteGlobalSetting("Usuario." + Lbl.Sys.Config.Actual.UsuarioConectado.Id.ToString(), "Whatsnew.Ultimo", FechaWhatsnew);
                                        }
                                }

                                // Mostrar el formulario
                                Aplicacion.FormularioPrincipal = new Principal.Inicio();
                                Aplicacion.FormularioPrincipal.Show();
                                Application.Run(Aplicacion.FormularioPrincipal);
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

                /// <summary>
                /// Envía datos anónimos sobre el equipo en el que se está ejecutando Lázaro.
                /// </summary>
                [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
                public static void EnviarEstadisticas()
                {
                        try {
                                string[] Vars = new string[] {
                                                                "estacion=" + System.Uri.EscapeUriString(System.Environment.MachineName),
                                                                "so=" + System.Uri.EscapeUriString(Lfx.Environment.SystemInformation.PlatformName),
                                                                "runtime=" + System.Uri.EscapeUriString(Lfx.Environment.SystemInformation.RuntimeName),
                                                                "empresa=" + System.Uri.EscapeUriString(Lbl.Sys.Config.Actual.Empresa.Nombre),
                                                                "email=" + System.Uri.EscapeUriString(Lbl.Sys.Config.Actual.Empresa.Email),
                                                                "build=" + System.Uri.EscapeUriString(Aplicacion.BuildDate().ToString(Lfx.Types.Formatting.DateTime.SqlDateTimeFormat)),
                                                                "version=" + System.Uri.EscapeUriString(Aplicacion.Version())
                                                        };
                                System.Net.WebRequest webRequest = System.Net.WebRequest.Create(new System.Uri("http://www.sistemalazaro.com.ar/stats/index.php"));
                                webRequest.ContentType = "application/x-www-form-urlencoded";
                                webRequest.Method = "POST";
                                byte[] PostData = System.Text.Encoding.Default.GetBytes(string.Join("&", Vars));
                                webRequest.ContentLength = PostData.Length;
                                using (System.IO.Stream ReqStream = webRequest.GetRequestStream()) {
                                        //Escribimos los datos
                                        ReqStream.Write(PostData, 0, PostData.Length);
                                        ReqStream.Close();
                                }
                        } catch {
                                // Nada
                        }
                }


		/// <summary>
		/// Ejecuta un comando. Se trata de un pequeño lenguaje de scripting de Lázaro.
		/// </summary>
		/// <param name="comando">El comando a ejecutar, puede ser una tarea o una cadena.</param>
		/// <returns>Normalmente devuelve un formulario, que es el resultado del comando.
                /// Por ejemplo, el comando "EDITAR ARTICULO 132" devuelve un formulario tipo Lfc.Articulos.Editar donde se está editando el artículo.
                /// También puede devolver otras cosas, como un Lfx.Types.OperationResult.
		/// </returns>
                public static object Exec(object param)
                {
                        if (param is Lfx.Services.Task) {
                                Lfx.Services.Task Tsk = param as Lfx.Services.Task;
                                return Exec(Tsk.Command, Tsk.CreatorComputerName);
                        } else {
                                return Exec(param.ToString(), null);
                        }
                }


                public static object Exec(string comando, string estacion)
                {
                        Console.WriteLine("Exec:" + comando);

                        if (estacion == null || estacion.Length == 0)
                                estacion = System.Environment.MachineName.ToUpperInvariant();

                        string SubComando = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpperInvariant();

                        switch (SubComando) {
                                case "REPO":
                                        qGen.Select Sel = new qGen.Select("comprob_detalle");
                                        Sel.Fields = "personas.id_persona,personas.nombre_visible,comprob.fecha,comprob.total";
                                        Sel.Joins.Add(new qGen.Join("comprob", "comprob_detalle.id_comprob=comprob.id_comprob"));
                                        Sel.Joins.Add(new qGen.Join("personas", "comprob.id_cliente=personas.id_persona"));
                                        Sel.WhereClause = new qGen.Where();
                                        Sel.WhereClause.AddWithValue("comprob.fecha", "'2009-09-01'", "'2009-09-30'");
                                        Sel.WhereClause.AddWithValue("comprob.compra", 0);
                                        Sel.WhereClause.AddWithValue("comprob.numero", qGen.ComparisonOperators.GreaterThan, 0);
                                        Sel.WhereClause.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "FA", "FB", "FC", "FM", "FE" });

                                        Lbl.Reportes.Reporte Rep = new Lbl.Reportes.Reporte(Lfx.Workspace.Master.GetNewConnection("REPO"), Sel);
                                        Rep.Grouping = new Lfx.Data.Grouping("personas.nombre_visible");
                                        Rep.Aggregates.Add(new Lfx.Data.Aggregate(Lfx.Data.AggregationFunctions.Count, "comprob.fecha"));
                                        Rep.Aggregates.Add(new Lfx.Data.Aggregate(Lfx.Data.AggregationFunctions.Sum, "comprob.total"));
                                        Rep.Fields.Add(new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 320));
                                        Rep.Fields.Add(new Lfx.Data.FormField("comprob.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 100));
                                        Rep.Fields.Add(new Lfx.Data.FormField("comprob.total", "Total", Lfx.Data.InputFieldTypes.Currency, 120));
                                        Rep.ExpandGroups = false;

                                        Lfc.Reportes.Reporte RepForm = new Lfc.Reportes.Reporte();
                                        RepForm.MdiParent = FormularioPrincipal;
                                        RepForm.ReporteAMostrar = Rep;
                                        RepForm.Show();
                                        break;

                                case "DESDUP":
                                        Lfc.Misc.Desduplicar DesDup = new Lfc.Misc.Desduplicar();
                                        DesDup.ShowDialog();
                                        break;

                                case "LIC":
                                        Lfx.Lic.Licenciar(@"..\");
                                        Lfx.Lic.Licenciar(@"..\..\Componentes\RunComponent");
                                        Lfx.Lic.Licenciar(@"..\..\Componentes\ServidorFiscal");
                                        Lfx.Lic.Licenciar(@"..\..\Lfx");
                                        Lfx.Lic.Licenciar(@"..\..\Lbl");
                                        Lfx.Lic.Licenciar(@"..\..\Lui");
                                        Lfx.Lic.Licenciar(@"..\..\Lcc");
                                        Lfx.Lic.Licenciar(@"..\..\Lfc");
                                        Lfx.Lic.Licenciar(@"..\..\Impresion");
                                        Lfx.Lic.Licenciar(@"..\..\Forms");
                                        Lfx.Lic.Licenciar(@"..\..\Actualizador");
                                        break;

                                case "HISTORIAL":
                                        string Tabla = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();
                                        int Id = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " "));
                                        Lfc.Log.Editar His = new Lfc.Log.Editar();
                                        His.MdiParent = FormularioPrincipal;
                                        His.Mostrar(Tabla, Id);
                                        His.Show();
                                        break;

                                case "ERROR":
                                        throw new InvalidOperationException("Error de Prueba");

                                case "VENTRE":
                                        Lbl.Servicios.Importar.FiltroEscorpion Fil = new Lbl.Servicios.Importar.FiltroEscorpion(Lfx.Workspace.Master.MasterConnection);
                                        Fil.Carpeta = @"C:\Ventre\";
                                        Fil.Cargar();
                                        Fil.Fusionar();
                                        break;

                                case "CHECK":
                                        string SubComandoDbCheck = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpperInvariant();
                                        switch (SubComandoDbCheck) {
                                                case "ALL":
                                                case "":
                                                        Exec("CHECK STRUCT", estacion);
                                                        Exec("CHECK DATA", estacion);
                                                        break;
                                                case "DATA":
                                                        Lbl.Servicios.Verificador Ver = new Lbl.Servicios.Verificador(Lfx.Workspace.Master.MasterConnection);
                                                        Ver.CheckDataBase();
                                                        break;
                                                case "STRUCT":
                                                        System.Threading.ThreadStart ParamInicioVerif = delegate { Lfx.Workspace.Master.CheckAndUpdateDataBaseVersion(true, false); };
                                                        new System.Threading.Thread(ParamInicioVerif).Start();
                                                        break;
                                        }
                                        break;

                                case "VER":
                                        Lazaro.Misc.AcercaDe OAcercaDe = new Lazaro.Misc.AcercaDe();
                                        OAcercaDe.ShowDialog();
                                        break;

                                case "REBOOT":
                                        int EstacionFiscal = Lfx.Workspace.Master.MasterConnection.FieldInt("SELECT id_pv FROM pvs WHERE estacion='" + System.Environment.MachineName.ToUpperInvariant() + "' AND tipo=2 AND id_sucursal=" + Lfx.Workspace.Master.CurrentConfig.Empresa.SucursalPredeterminada.ToString());
                                        if (EstacionFiscal > 0) {
                                                Lfx.Workspace.Master.DefaultScheduler.AddTask("REBOOT", "fiscal" + EstacionFiscal.ToString(), "*");
                                                System.Threading.Thread.Sleep(100);
                                        }

                                        Lfx.Environment.Shell.Reboot();
                                        break;

                                case "RECIBO_RAPIDO":
                                        Lui.Forms.Form OFormReciboRapido = new Lfc.Comprobantes.Recibos.Rapido();
                                        OFormReciboRapido.ShowDialog(Aplicacion.FormularioPrincipal);
                                        break;

                                case "CALC":
                                        Lazaro.Misc.Calculadora OCalc = new Lazaro.Misc.Calculadora();
                                        OCalc.Show();
                                        break;

                                case "BACKUP":
                                        if (Lui.LogOn.LogOnData.ValidateAccess("Global.Backup", Lbl.Sys.Permisos.Operaciones.Administrar)) {
                                                string SubComandoBackup = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                switch (SubComandoBackup) {
                                                        case "MANAGER":
                                                                Misc.Backup.Manager OFormBackup = (Misc.Backup.Manager)BuscarVentana("Misc.Backup.Manager");
                                                                if (OFormBackup == null)
                                                                        OFormBackup = new Misc.Backup.Manager();
                                                                OFormBackup.ShowDialog(Aplicacion.FormularioPrincipal);
                                                                break;

                                                        case "NOW":
                                                                //string Carpeta = "lbkp_" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + System.IO.Path.DirectorySeparatorChar;
                                                                string Carpeta = "Copia de seguridad de Lázaro del " + System.DateTime.Now.ToString("dd-MM-yyyy (HH.mm).lbk") + System.IO.Path.DirectorySeparatorChar;
                                                                Misc.Backup.Services.CreateBackup(Carpeta);
                                                                break;
                                                }
                                        }
                                        break;

                                case "CONFIG":
                                        Misc.Config.Preferencias FormConfig = new Misc.Config.Preferencias();
                                        FormConfig.ShowDialog(Aplicacion.FormularioPrincipal);
                                        break;

                                case "ACCESSMGR":
                                        return Exec("LIST USER");

                                case "CHANGEPWD":
                                        Misc.CambioContrasena FormCambio = new Misc.CambioContrasena();
                                        FormCambio.ShowDialog();
                                        break;

                                case "FISCAL":
                                        string SubComandoFiscal = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                        switch (SubComandoFiscal) {
                                                case "INICIAR":
                                                        Lfx.Environment.Shell.Execute("ServidorFiscal.exe", null, System.Diagnostics.ProcessWindowStyle.Normal, false);
                                                        break;
                                                case "PANEL":
                                                        Lazaro.Misc.Fiscal OFormFiscal = (Lazaro.Misc.Fiscal)BuscarVentana("Lazaro.Misc.Fiscal");
                                                        if (OFormFiscal == null)
                                                                OFormFiscal = new Lazaro.Misc.Fiscal();
                                                        OFormFiscal.ShowDialog();
                                                        break;
                                        }
                                        break;

                                case "MENSAJE":
                                case "MESSAGE":
                                        Lui.Forms.MessageBox.Show(comando, "Mensaje remoto de " + estacion);
                                        return null;

                                case "REPORTE":
                                        string SubComandoReporte = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                        switch (SubComandoReporte) {
                                                case "RENTABILIDAD":
                                                        if (Lui.LogOn.LogOnData.ValidateAccess("Global", Lbl.Sys.Permisos.Operaciones.Total)) {
                                                                Lazaro.Reportes.IngresosEgresos OFormRepRentabilidad = new Lazaro.Reportes.IngresosEgresos();
                                                                if (!Aplicacion.Flotante)
                                                                        OFormRepRentabilidad.MdiParent = Aplicacion.FormularioPrincipal;
                                                                OFormRepRentabilidad.Show();
                                                                return OFormRepRentabilidad;
                                                        }
                                                        break;
                                                case "PATRIMONIO":
                                                        if (Lui.LogOn.LogOnData.ValidateAccess("Global", Lbl.Sys.Permisos.Operaciones.Total)) {
                                                                Lazaro.Reportes.Patrimonio RepPatr = new Lazaro.Reportes.Patrimonio();
                                                                if (!Aplicacion.Flotante)
                                                                        RepPatr.MdiParent = Aplicacion.FormularioPrincipal;
                                                                RepPatr.Show();
                                                                return RepPatr;
                                                        }
                                                        break;
                                        }

                                        break;

                                case "IMPRIMIR":
                                        string SubComandoImprimir = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();

                                        switch (SubComandoImprimir.ToUpperInvariant()) {
                                                case "COMPROBANTE":
                                                case "COMPROB":
                                                        int IdComprobante = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " "));

                                                        Lfx.Types.OperationResult ResultadoImpresion;

                                                        using (Lfx.Data.Connection DataBaseImprimir = Lfx.Workspace.Master.GetNewConnection("Imprimir comprobante")) {
                                                                IDbTransaction Trans = DataBaseImprimir.BeginTransaction(IsolationLevel.Serializable);
                                                                Lbl.Comprobantes.ComprobanteConArticulos Comprob = new Lbl.Comprobantes.ComprobanteConArticulos(DataBaseImprimir, IdComprobante);
                                                                Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos Impresor = new Impresion.Comprobantes.ImpresorComprobanteConArticulos(Comprob, Trans);
                                                                ResultadoImpresion = Impresor.Imprimir();
                                                                if (ResultadoImpresion.Success)
                                                                        Trans.Commit();
                                                                else
                                                                        Trans.Rollback();
                                                                Trans.Dispose();
                                                                DataBaseImprimir.Dispose();
                                                        }

                                                        return ResultadoImpresion;
                                                default:
                                                        int itemId = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim());
                                                        Type TipoElem = Lbl.Instanciador.InferirTipo(SubComandoImprimir);
                                                        if (TipoElem != null && itemId > 0) {
                                                                using (Lfx.Data.Connection DbImprimir = Lfx.Workspace.Master.GetNewConnection("Imprimir " + TipoElem.ToString() + " " + itemId.ToString())) {
                                                                        Lbl.IElementoDeDatos Elem = Lbl.Instanciador.Instanciar(TipoElem, DbImprimir, itemId);
                                                                        IDbTransaction Trans = DbImprimir.BeginTransaction();
                                                                        Lazaro.Impresion.ImpresorElemento Impresor = Lazaro.Impresion.Instanciador.InstanciarImpresor(Elem, Trans);

                                                                        string ImprimirEn = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpperInvariant();
                                                                        if (ImprimirEn == "EN") {
                                                                                // El nombre de la impresora es lo que resta del comando
                                                                                // No lo puedo separar con GetNextToken porque puede contener espacios
                                                                                string NombreImpresora = comando;
                                                                                Impresor.Impresora = Lbl.Impresion.Impresora.InstanciarImpresoraLocal(DbImprimir, NombreImpresora);
                                                                        }

                                                                        Lfx.Types.OperationResult Res = Impresor.Imprimir();
                                                                        if (Res.Success) {
                                                                                Trans.Commit();
                                                                        } else {
                                                                                Trans.Rollback();
                                                                        }
                                                                        Trans.Dispose();
                                                                        return Res;
                                                                }
                                                        }
                                                        break;
                                        }
                                        break;

                                case "REIMPRIMIR":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Comprobantes.ComprobanteFacturable), Lbl.Sys.Permisos.Operaciones.Imprimir)) {
                                                string SubComandoAnular = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                int IdComprobanteAnular = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " "));

                                                switch (SubComandoAnular) {
                                                        case "FACTURA":
                                                        case "FACT":
                                                                Lfc.Comprobantes.Facturas.Reimprimir FormularioFacturaReimprimir = new Lfc.Comprobantes.Facturas.Reimprimir();
                                                                if (!Aplicacion.Flotante)
                                                                        FormularioFacturaReimprimir.MdiParent = Aplicacion.FormularioPrincipal;
                                                                FormularioFacturaReimprimir.Show();
                                                                break;
                                                }
                                        }
                                        break;

                                case "INICIAR_TALONARIO":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Comprobantes.Comprobante), Lbl.Sys.Permisos.Operaciones.Administrar)) {
                                                string TipoIniciar = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                Lfc.Comprobantes.IniciarNumeracion FormularioIniciarNumeracion = new Lfc.Comprobantes.IniciarNumeracion();
                                                if (!Aplicacion.Flotante)
                                                        FormularioIniciarNumeracion.MdiParent = Aplicacion.FormularioPrincipal;
                                                if (TipoIniciar.Length > 0)
                                                        FormularioIniciarNumeracion.EntradaTipo.TextKey = TipoIniciar;

                                                FormularioIniciarNumeracion.Show();
                                                break;
                                        }
                                        break;

                                case "ANULAR":
                                        string SubComandoAnularComprob = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                        int IdComprobanteAnularComprob = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " "));

                                        switch (SubComandoAnularComprob) {
                                                case "FACTURA":
                                                case "FACT":
                                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Comprobantes.ComprobanteFacturable), Lbl.Sys.Permisos.Operaciones.Eliminar)) {
                                                                Lfc.Comprobantes.Facturas.Anular FormularioFacturaAnular = new Lfc.Comprobantes.Facturas.Anular();
                                                                if (!Aplicacion.Flotante)
                                                                        FormularioFacturaAnular.MdiParent = Aplicacion.FormularioPrincipal;
                                                                FormularioFacturaAnular.Show();
                                                        } else {
                                                                return new Lfx.Types.NoAccessOperationResult();
                                                        }
                                                        break;

                                                case "RECIBO":
                                                case "RCP":
                                                case "RC":
                                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Comprobantes.Recibo), Lbl.Sys.Permisos.Operaciones.Eliminar)) {
                                                                Lfc.Comprobantes.Recibos.Anular FormularioReciboAnular = new Lfc.Comprobantes.Recibos.Anular();
                                                                FormularioReciboAnular.Cargar(IdComprobanteAnularComprob);
                                                                FormularioReciboAnular.ShowDialog(Aplicacion.FormularioPrincipal);
                                                        } else {
                                                                return new Lfx.Types.NoAccessOperationResult();
                                                        }
                                                        break;
                                        }
                                        break;

                                case "CREAR":
                                case "CREATE":
                                        return ExecCrearEditar(true, comando);
                                case "EDITAR":
                                case "EDIT":
                                        return ExecCrearEditar(false, comando);

                                case "LISTADO":
                                case "LIST":
                                        return ExecListado(comando);

                                case "CAJA_DIARIA":
                                case "CAJA_EFECTIVO":
                                        // Por el momento, muestro la caja de efectivo
                                        Lbl.Cajas.Caja Caja = Lbl.Sys.Config.Actual.Empresa.SucursalPredeterminada.CajaDiaria;
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(Caja, Lbl.Sys.Permisos.Operaciones.Ver)) {
                                                string SubComandoCaja = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                Lfc.Cajas.Movimientos FormularioCaja = new Lfc.Cajas.Movimientos();
                                                if (!Aplicacion.Flotante)
                                                        FormularioCaja.MdiParent = Aplicacion.FormularioPrincipal;
                                                FormularioCaja.Caja = Caja;

                                                if (SubComandoCaja.Length > 0) {
                                                        NullableDateTime Fecha = Lfx.Types.Parsing.ParseDate(SubComandoCaja);
                                                        if (Fecha != null) {
                                                                FormularioCaja.Fechas = new Lfx.Types.DateRange("dia");
                                                                FormularioCaja.Fechas.From = Fecha;
                                                                FormularioCaja.Fechas.To = Fecha;
                                                        }
                                                }

                                                FormularioCaja.Show();
                                                return FormularioCaja;
                                        }
                                        break;

                                case "CTACTE":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.CuentasCorrientes.CuentaCorriente), Lbl.Sys.Permisos.Operaciones.Ver)) {
                                                string SubComandoCtaCte = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                Lfc.CuentasCorrientes.Inicio CtaCte = ((Lfc.CuentasCorrientes.Inicio)(BuscarVentana("Lfc.Cajas.Corriente.Inicio")));

                                                if (CtaCte == null)
                                                        CtaCte = new Lfc.CuentasCorrientes.Inicio();

                                                if (!Aplicacion.Flotante)
                                                        CtaCte.MdiParent = Aplicacion.FormularioPrincipal;

                                                int ClienteId = Lfx.Types.Parsing.ParseInt(SubComandoCtaCte);
                                                if (ClienteId > 0)
                                                        CtaCte.Cliente = new Lbl.Personas.Persona(CtaCte.Connection, ClienteId);
                                                CtaCte.Show();
                                                return CtaCte;
                                        }
                                        break;

                                case "CUPONES":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Cajas.Caja), Lbl.Sys.Permisos.Operaciones.Ver)) {
                                                Lfc.Cupones.Cupones.Inicio OTarjetas = ((Lfc.Cupones.Cupones.Inicio)(BuscarVentana("Lfc.Cajas.Tarjetas.Inicio")));

                                                if (OTarjetas == null)
                                                        OTarjetas = new Lfc.Cupones.Cupones.Inicio();
                                                if (!Aplicacion.Flotante)
                                                        OTarjetas.MdiParent = Aplicacion.FormularioPrincipal;
                                                OTarjetas.RefreshList();
                                                OTarjetas.Show();
                                                return OTarjetas;
                                        }
                                        break;

                                case "CAJA":
                                        string SubComandoVerCaja = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();
                                        Lbl.Cajas.Caja VerCaja = new Lbl.Cajas.Caja(Lfx.Workspace.Master.MasterConnection, Lfx.Types.Parsing.ParseInt(SubComandoVerCaja));
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(VerCaja, Lbl.Sys.Permisos.Operaciones.Ver)) {
                                                Lfc.Cajas.Movimientos FormularioCaja = new Lfc.Cajas.Movimientos();
                                                if (!Aplicacion.Flotante)
                                                        FormularioCaja.MdiParent = Aplicacion.FormularioPrincipal;
                                                FormularioCaja.Caja = VerCaja;
                                                FormularioCaja.RefreshList();
                                                FormularioCaja.Show();
                                                return FormularioCaja;
                                        }
                                        break;

                                case "MOVIM":
                                        string SubComandoMovim = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                        switch (SubComandoMovim) {
                                                case "ARTICULOS":
                                                        string SubComandoArticulos = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();
                                                        Lfc.Articulos.Movimiento FormularioMovimientoArticulo = new Lfc.Articulos.Movimiento();
                                                        FormularioMovimientoArticulo.EntradaArticulo.TextInt = Lfx.Types.Parsing.ParseInt(SubComandoArticulos);
                                                        FormularioMovimientoArticulo.ShowDialog(Aplicacion.FormularioPrincipal);
                                                        return FormularioMovimientoArticulo;
                                        }

                                        break;

                                case "RUN":
                                        string Componente = Lfx.Types.Strings.GetNextToken(ref comando, ".").Trim();
                                        string Funcion = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();
                                        Lfx.Components.Manager.Run(Aplicacion.Flotante ? null : Aplicacion.FormularioPrincipal, Componente, Funcion);
                                        break;

                                case "QUIT":
                                        Lbl.Sys.Config.ActionLog(Lfx.Workspace.Master.MasterConnection, Lbl.Sys.Log.Acciones.LogOff, Lbl.Sys.Config.Actual.UsuarioConectado.Usuario, null);
                                        if (Aplicacion.FormularioPrincipal != null)
                                                Aplicacion.FormularioPrincipal.Close();
                                        break;

                                default:
                                        if (Lfx.Workspace.Master.DebugMode)
                                                throw new NotImplementedException(comando);
                                        else
                                                return new Lfx.Types.OperationResult(false);
                        }

                        return null;
                }

                private static object ExecListado(string Comando)
                {
                        string SubComando = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim();
                        Lfc.FormularioListado FormularioListado = null;

                        switch (SubComando) {
                                case "IvaVentas":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Comprobantes.Factura), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Comprobantes.Facturas.IvaVentas();
                                        }
                                        break;

                                case "ALICUOTAS":
                                case "Lbl.Impuestos.ObtenerAlicuota":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Impuestos.Alicuota), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Alicuotas.Inicio();
                                        }
                                        break;

                                case "CHEQUERAS":
                                case "Lbl.Bancos.Chequera":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Bancos.Chequera), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                Lfc.Bancos.Chequeras.Inicio OFormChequerasInicio = new Lfc.Bancos.Chequeras.Inicio();
                                                if (!Aplicacion.Flotante)
                                                        OFormChequerasInicio.MdiParent = Aplicacion.FormularioPrincipal;
                                                OFormChequerasInicio.Show();
                                                return OFormChequerasInicio;
                                        }
                                        break;

                                case "CHEQUES":
                                case "Lbl.Bancos.Cheque":
                                        string SubSubComando = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                        switch (SubSubComando) {
                                                case "RECIBIDOS":
                                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Bancos.Cheque), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                                Lfc.Bancos.Cheques.Inicio FormularioChequesRecibidos = new Lfc.Bancos.Cheques.Inicio();
                                                                if (!Aplicacion.Flotante)
                                                                        FormularioChequesRecibidos.MdiParent = Aplicacion.FormularioPrincipal;
                                                                FormularioChequesRecibidos.Emitidos = false;
                                                                FormularioChequesRecibidos.Show();
                                                                return FormularioChequesRecibidos;
                                                        }
                                                        break;

                                                case "EMITIDOS":
                                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Bancos.Cheque), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                                Lfc.Bancos.Cheques.Inicio FormularioChequesEmitidos = new Lfc.Bancos.Cheques.Inicio();
                                                                if (!Aplicacion.Flotante)
                                                                        FormularioChequesEmitidos.MdiParent = Aplicacion.FormularioPrincipal;
                                                                FormularioChequesEmitidos.Emitidos = true;
                                                                FormularioChequesEmitidos.Show();
                                                                return FormularioChequesEmitidos;
                                                        }
                                                        break;
                                        }
                                        break;

                                case "CAJA":
                                case "CAJAS":
                                case "Lbl.Cajas.Caja":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Cajas.Caja), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lfc.Cajas.Inicio");
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Cajas.Inicio();
                                        }
                                        break;

                                case "CLIENTE":
                                case "CLIENTES":
                                case "Lbl.Personas.Persona":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Personas.Persona), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lfc.Personas.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Personas.Inicio();

                                                ((Lfc.Personas.Inicio)(FormularioListado)).m_Tipo = 1;
                                        }
                                        break;

                                case "personas_grupos":
                                case "PERSONAS_GRUPOS":
                                case "Lbl.Personas.Grupo":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Personas.Grupo), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lfc.Personas.Grupos.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Personas.Grupos.Inicio();
                                        }
                                        break;

                                case "USER":
                                case "USERS":
                                case "USUARIO":
                                case "USUARIOS":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Personas.Usuario), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("FormClientesInicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Personas.Inicio();

                                                ((Lfc.Personas.Inicio)(FormularioListado)).m_Tipo = 4;
                                        }
                                        break;

                                case "SUCURSAL":
                                case "SUCURSALES":
                                case "sucursales":
                                case "Lbl.Entidades.Sucursal":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Entidades.Sucursal), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lazaro.Misc.Sucursales.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Sucursales.Inicio();
                                        }
                                        break;

                                case "PLANTILLA":
                                case "PLANTILLAS":
                                case "sys_plantillas":
                                case "Lbl.Impresion.Plantilla":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Impresion.Plantilla), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lfc.Comprobantes.Plantillas.Inicio");
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Comprobantes.Plantillas.Inicio();
                                        }
                                        break;

                                case "PROVEEDOR":
                                case "PROVEEDORES":
                                case "Lbl.Personas.Proveedor":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Personas.Persona), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lfc.Personas.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Personas.Inicio();

                                                ((Lfc.Personas.Inicio)(FormularioListado)).m_Tipo = 2;
                                        }
                                        break;

                                case "PV":
                                case "PVS":
                                case "pvs":
                                case "Lbl.Comprobantes.PuntoDeVenta":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Comprobantes.PuntoDeVenta), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lazaro.Misc.Pvs.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Pvs.Inicio();
                                        }
                                        break;

                                case "ARTICULO":
                                case "ARTICULOS":
                                case "Lbl.Articulos.Articulo":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Articulos.Articulo), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                string SubComandoArticulos = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Articulos.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Articulos.Inicio();

                                                switch (SubComandoArticulos) {
                                                        case "PEDIDOS":
                                                                ((Lfc.Articulos.Inicio)(FormularioListado)).m_Stock = "pedido";
                                                                break;

                                                        case "APEDIR":
                                                                ((Lfc.Articulos.Inicio)(FormularioListado)).m_Stock = "apedir";
                                                                break;
                                                }
                                        }
                                        break;

                                case "ARTICULO_CATEG":
                                case "ARTICULOS_CATEG":
                                case "Lbl.Articulos.Categoria":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Articulos.Categoria), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Articulos.Categorias.Inicio");
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Articulos.Categorias.Inicio();
                                        }
                                        break;

                                case "ARTICULO_RUBRO":
                                case "ARTICULO_RUBROS":
                                case "ARTICULOS_RUBRO":
                                case "ARTICULOS_RUBROS":
                                case "Lbl.Articulos.Rubro":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Articulos.Rubro), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = (Lfc.FormularioListado)BuscarVentana("Articulos.Rubros.Inicio");
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Articulos.Rubros.Inicio();
                                        }
                                        break;

                                case "COMPROBANTE":
                                case "COMPROBANTES":
                                case "Lbl.Comprobantes.ComprobanteConArticulos":
                                case "Lbl.Comprobantes.ComprobanteFacturable":
                                case "Lbl.Comprobantes.Factura":
                                case "Lbl.Comprobantes.Presupuesto":
                                case "Lbl.Comprobantes.NotaDeCredito":
                                case "Lbl.Comprobantes.NotaDeDebito":
                                        FormularioListado = new Lfc.Comprobantes.Inicio();
                                        FormularioListado.Definicion.ElementoTipo = Lbl.Instanciador.InferirTipo(SubComando);
                                        string ListadoComprobLetra = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                        if (ListadoComprobLetra.Length > 0)
                                                ((Lfc.Comprobantes.Inicio)(FormularioListado)).Letra = ListadoComprobLetra;
                                        break;

                                case "Lbl.Comprobantes.Remito":
                                        FormularioListado = new Lfc.Comprobantes.Inicio();
                                        FormularioListado.Definicion.ElementoTipo = Lbl.Instanciador.InferirTipo(SubComando);
                                        break;

                                case "Lbl.Comprobantes.ComprobanteDeCompra":
                                        FormularioListado = new Lfc.Comprobantes.Compra.Inicio();
                                        FormularioListado.Definicion.ElementoTipo = Lbl.Instanciador.InferirTipo(SubComando);
                                        string ListadoComprobCompraTipo = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                        if (ListadoComprobCompraTipo.Length > 0)
                                                ((Lfc.Comprobantes.Compra.Inicio)(FormularioListado)).Tipo = ListadoComprobCompraTipo;
                                        break;

                                case "RECIBOS":
                                case "Lbl.Comprobantes.Recibo":
                                case "Lbl.Comprobantes.ReciboDeCobro":
                                        FormularioListado = new Lfc.Comprobantes.Recibos.Inicio();
                                        FormularioListado.Definicion.ElementoTipo = typeof(Lbl.Comprobantes.ReciboDeCobro);
                                        break;

                                case "Lbl.Comprobantes.ReciboDePago":
                                        FormularioListado = new Lfc.Comprobantes.Recibos.Inicio();
                                        FormularioListado.Definicion.ElementoTipo = typeof(Lbl.Comprobantes.ReciboDePago);
                                        break;

                                case "Lbl.Comprobantes.Tipo":
                                        FormularioListado = new Lfc.Comprobantes.Tipo.Inicio();
                                        break;
                                
                                case "impresoras":
                                case "Lbl.Impresion.Impresora":
                                        FormularioListado = new Lfc.Comprobantes.Impresoras.Inicio();
                                        break;

                                case "MARCAS":
                                case "Lbl.Articulos.Marca":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Articulos.Marca), Lbl.Sys.Permisos.Operaciones.Listar))
                                                FormularioListado = new Lfc.Articulos.Marcas.Inicio();
                                        break;

                                case "PD":
                                case "NP":
                                case "FP":
                                case "RP":
                                case "PEDIDOS":
                                        string SubComandoPedidos = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();

                                        FormularioListado = new Lfc.Comprobantes.Compra.Inicio();
                                        if (!Aplicacion.Flotante)
                                                FormularioListado.MdiParent = Aplicacion.FormularioPrincipal;

                                        switch (SubComando) {
                                                case "PEDIDOS":
                                                        ((Lfc.Comprobantes.Compra.Inicio)FormularioListado).m_Tipo = "PD";
                                                        break;
                                                default:
                                                        ((Lfc.Comprobantes.Compra.Inicio)FormularioListado).m_Tipo = SubComando;
                                                        break;
                                        }

                                        ((Lfc.Comprobantes.Compra.Inicio)FormularioListado).m_Proveedor = Lfx.Types.Parsing.ParseInt(SubComandoPedidos);
                                        break;

                                case "CONCEPTO":
                                case "CONCEPTOS":
                                case "CAJAS_CONCEPTOS":
                                case "Lbl.Cajas.Concepto":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Cajas.Concepto), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = new Lfc.Cajas.Conceptos.Inicio();
                                        }
                                        break;

                                case "CIUDAD":
                                case "CIUDADES":
                                case "Lbl.Entidades.Localidad":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Entidades.Localidad), Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                FormularioListado = new Lfc.Ciudades.Inicio();
                                        }
                                        break;

                                case "TICKET":
                                case "TICKETS":
                                case "Lbl.Tareas.Tarea":
                                        string SubComandoTickets = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                        FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lfc.Tareas.Inicio");
                                        if (FormularioListado == null)
                                                FormularioListado = new Lfc.Tareas.Inicio();
                                        ((Lfc.Tareas.Inicio)(FormularioListado)).Tipo = Lfx.Types.Parsing.ParseInt(SubComandoTickets);
                                        break;

                                case "Lbl.Tareas.Estado":
                                        FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lfc.Tareas.Estados.Inicio");
                                        if (FormularioListado == null)
                                                FormularioListado = new Lfc.Tareas.Estados.Inicio();
                                        break;

                                case "Lbl.Tareas.Tipo":
                                        FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lfc.Tareas.Tipos.Inicio");
                                        if (FormularioListado == null)
                                                FormularioListado = new Lfc.Tareas.Tipos.Inicio();
                                        break;

                                case "VENCIMIENTO":
                                case "VENCIMIENTOS":
                                case "Lbl.Cajas.Vencimiento":
                                        FormularioListado = (Lfc.FormularioListado)BuscarVentana("Lfc.Cajas.Vencimientos.Inicio");
                                        if (FormularioListado == null)
                                                FormularioListado = new Lfc.Cajas.Vencimientos.Inicio();
                                        break;

                                default:
                                        Type TipoLbl = Lbl.Instanciador.InferirTipo(SubComando);
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(TipoLbl, Lbl.Sys.Permisos.Operaciones.Listar)) {
                                                Type TipoListado = Lfc.Instanciador.InferirFormularioListado(TipoLbl);
                                                if (TipoListado == null && Lfx.Workspace.Master.DebugMode)
                                                        throw new NotImplementedException("LISTADO " + SubComando);
                                                else
                                                        FormularioListado = Lfc.Instanciador.InstanciarFormularioListado(TipoListado);
                                                break;
                                        } else {
                                                return new Lfx.Types.NoAccessOperationResult();
                                        }
                        }

                        if (FormularioListado == null)
                                return null;

                        if (Aplicacion.Flotante)
                                FormularioListado.WindowState = Aplicacion.FormularioPrincipal.WindowState;
                        else
                                FormularioListado.MdiParent = Aplicacion.FormularioPrincipal;

                        FormularioListado.Show();
                        FormularioListado.BringToFront();

                        return FormularioListado;
                }

                private static object ExecCrearEditar(bool crear, string comando)
                {
                        string SubComando = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();

                        System.Type TipoElemento = Lbl.Instanciador.InferirTipo(SubComando);
                        Lbl.Atributos.NombreItem AtrNombre = TipoElemento.GetAttribute<Lbl.Atributos.NombreItem>();

                        Lfx.Data.Connection DataBase = Lfx.Workspace.Master.GetNewConnection("Editar " + (AtrNombre == null ? SubComando : AtrNombre.Nombre));
                        Lbl.IElementoDeDatos Elemento = null;
                        if(crear) {
                                Elemento = Lbl.Instanciador.Instanciar(TipoElemento, DataBase);
                                Elemento.Crear();
                        } else { 
                                int ItemId = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " "));
                                Elemento = Lbl.Instanciador.Instanciar(TipoElemento, DataBase, ItemId);
                        }

                        bool MdiChild = true;

                        Lfc.FormularioEdicion FormularioDeEdicion = Lfc.Instanciador.InstanciarFormularioEdicion(Elemento);
                        FormularioDeEdicion.DisposeConnection = true;

                        if (FormularioDeEdicion == null)
                                return null;
                        
                        if (MdiChild == false) {
                                FormularioDeEdicion.WindowState = FormWindowState.Normal;
                                FormularioDeEdicion.Owner = Aplicacion.FormularioPrincipal;
                                FormularioDeEdicion.MdiParent = null;
                                FormularioDeEdicion.FormBorderStyle = FormBorderStyle.FixedDialog;
                                FormularioDeEdicion.MaximizeBox = false;
                                FormularioDeEdicion.MinimizeBox = false;
                                FormularioDeEdicion.Show();
                        } else {
                                if (Aplicacion.Flotante)
                                        FormularioDeEdicion.WindowState = Aplicacion.FormularioPrincipal.WindowState;
                                else
                                        FormularioDeEdicion.MdiParent = Aplicacion.FormularioPrincipal;

                                FormularioDeEdicion.Show();
                        }
                        return FormularioDeEdicion;
                }

                /// <summary>
                /// Busca una ventana por nombre entre los MDI children del formulario principal
                /// </summary>
                /// <param name="nombre">El nombre de la ventana a buscar.</param>
                /// <returns>Una referencia a la ventana, o null si no se encontró.</returns>
                private static Form BuscarVentana(string nombre)
                {
                        foreach (System.Windows.Forms.Form TmpForm in Aplicacion.FormularioPrincipal.MdiChildren) {
                                if (TmpForm.Name == nombre) {
                                        return TmpForm;
                                }
                        }

                        return null;
                }

                
                private static void ThreadExceptionHandler(object sender, System.Threading.ThreadExceptionEventArgs e)
                {
                        GenericExceptionHandler(e.Exception);
                }

                private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs args)
                {
                        GenericExceptionHandler(args.ExceptionObject as Exception);
                        Application.Exit();
                }

                private static void GenericExceptionHandler(Exception ex)
                {
                        if (ex is System.Drawing.Printing.InvalidPrinterException) {
                                KnownExceptionHandler(ex);
                        } else if (ex.Source == "MySql.Data") {
                                Exception ex2 = ex;
                                bool Found = false;
                                while (ex2 != null) {
                                        if (string.Compare(ex2.Message,"Reading from the stream has failed.", true) == 0
                                                || string.Compare(ex2.Message, "Unable to connect to any of the specified MySQL hosts.", true) == 0
                                                || string.Compare(ex2.Message, "Connection unexpectedly terminated.", true) == 0
                                                || string.Compare(ex2.Message, "error connecting: Timeout expired.", true) == 0
                                                || string.Compare(ex2.Message, "No se pueden leer los datos de la conexión de transporte: Se ha forzado la interrupción de una conexión existente por el host remoto.", true) == 0) {
                                                KnownExceptionHandler(ex, "Error de comunicación con el servidor");
                                                Found = true;
                                                break;
                                        }
                                        ex2 = ex2.InnerException;
                                }
                                if(Found == false)
                                        UnknownExceptionHandler(ex);
                        } else if (string.Compare(ex.Message, "El servidor RPC no está disponible", true) == 0) {
                                KnownExceptionHandler(ex, "La impresora no está disponible");
                        } else {
                                UnknownExceptionHandler(ex);
                        }
                }


                private static void KnownExceptionHandler(Exception ex)
                {
                        KnownExceptionHandler(ex, null);
                }

                /// <summary>
                /// Manejador de excepciones conocidas. Presenta una ventana con el error. Se utiliza para excepciones como InvalidPrinterException.
                /// No genera un reporte por correo electrónico.
                /// </summary>
                /// <param name="ex">La excepción a reportar.</param>
                /// <param name="mensajeDescriptivo">Una mejor descripción de la excepción que el mensaje orginal.</param>
                public static void KnownExceptionHandler(Exception ex, string mensajeDescriptivo)
                {
                        Errores.ExcepcionControlada FormularioError = new Errores.ExcepcionControlada();
                        if (mensajeDescriptivo == null)
                                FormularioError.EtiquetaDescripcion.Text = ex.Message;
                        else
                                FormularioError.EtiquetaDescripcion.Text = mensajeDescriptivo;
                        FormularioError.EtiquetaMasInformacion.Text = ex.ToString();
                        FormularioError.Show();
                        FormularioError.Refresh();
                }

                /// <summary>
                /// Manejador de excepciones desconocidas. Presenta una ventana con el error y envía un informe por correo electrónico.
                /// </summary>
                /// <param name="ex">La excepción a reportar.</param>
                [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
                private static void UnknownExceptionHandler(Exception ex)
                {
                        Errores.ExcepcionNoControlada FormularioError = new Errores.ExcepcionNoControlada();
                        FormularioError.Show();
                        FormularioError.Refresh();
                        System.Windows.Forms.Application.DoEvents();

                        System.Text.StringBuilder Texto = new System.Text.StringBuilder();
                        Texto.AppendLine("Lugar   : " + ex.Source);
                        try {
                                System.Diagnostics.StackTrace Traza = new System.Diagnostics.StackTrace(ex, true);
                                Texto.AppendLine("Línea   : " + Traza.GetFrame(0).GetFileLineNumber());
                                Texto.AppendLine("Columna : " + Traza.GetFrame(0).GetFileColumnNumber());
                        }
                        catch {
                                //Nada
                        }
                        Texto.AppendLine("Equipo  : " + System.Environment.MachineName.ToUpperInvariant());
                        Texto.AppendLine("Plataf. : " + Lfx.Environment.SystemInformation.PlatformName);
                        Texto.AppendLine("RunTime : " + Lfx.Environment.SystemInformation.RuntimeName);
                        Texto.AppendLine("Excepción no controlada: " + ex.ToString());
                        Texto.AppendLine("");

                        Texto.AppendLine("Lazaro versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").ProductVersion + " del " + new System.IO.FileInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                Texto.AppendLine(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                        }

                        Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                Texto.AppendLine(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                        }

                        Texto.AppendLine("Traza:");
                        Texto.AppendLine(ex.StackTrace);

                        MailMessage Mensaje = new MailMessage();
                        Mensaje.To.Add(new MailAddress("error@sistemalazaro.com.ar"));
                        Mensaje.From = new MailAddress(Lbl.Sys.Config.Actual.Empresa.Email, Lbl.Sys.Config.Actual.UsuarioConectado.Nombre + " en " + Lbl.Sys.Config.Actual.Empresa.Nombre);
                        try {
                                //No sé por qué, pero una vez dió un error al poner el asunto
                                Mensaje.Subject = ex.Message;
                        }
                        catch {
                                Mensaje.Subject = "Excepción no controlada";
                                Texto.Insert(0, ex.Message + System.Environment.NewLine);
                        }

                        Mensaje.Body = Texto.ToString();

                        SmtpClient Cliente = new SmtpClient("mail.sistemalazaro.com.ar");
                        try {
                                Cliente.Send(Mensaje);
                                FormularioError.EtiquetaDescripcion.Text = "Se envió un reporte de error. Haga clic en Continuar.";
                        }
                        catch (Exception ExSnd) {
                                FormularioError.EtiquetaDescripcion.Text = "No se puedo enviar el reporte de error (" + ExSnd.Message + "). Haga clic en Continuar.";
                        }

                        FormularioError.BotonCerrar.Visible = true;
                        FormularioError.BotonCerrar.Enabled = true;
                        FormularioError.Refresh();
                        System.Windows.Forms.Application.DoEvents();
                }
        }
}