// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lazaro
{
        public class Aplicacion
        {
                public static Principal.Inicio FormularioPrincipal;
                public static bool Flotante;
                public static bool ReinicioPendiente;
                public static string CUIT = "";

                public static string Version()
                {
                        // Obtiene la versión del ejecutable
                        return System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;
                }

                public static string BuildDate()
                {
                        // Obtiene la fecha del ejecutable
                        System.IO.FileInfo InfoArchivo = new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
                        return Lfx.Types.Formatting.FormatDateAndTime(InfoArchivo.LastWriteTime);
                }

                public static void ShowException(Exception ex, string Extra)
                {
                        FormError OFormError = new FormError();
                        OFormError.MostrarError(ex, Extra);
                        OFormError.ShowDialog();
                }

                /// <summary>
                /// Guarda registro de un error, intentando hacer un stack trace sobre el error.
                /// Guarda copia del error en el portapapeles y en el
                /// registro de sucesos de Windows NT, en un archivo de texto (mediante llamada a GLog)
                /// y también muestra el error en pantalla.
                /// </summary>   
                public static void ErrorLog(string Mensaje, string Extra)
                {
                        System.Text.StringBuilder ErrorText = new System.Text.StringBuilder();
                        ErrorText.Append("*** ERROR" + Environment.NewLine);
                        ErrorText.Append("Fecha: " + Lfx.Types.Formatting.FormatDateAndTime(System.DateTime.Now) + Environment.NewLine);
                        ErrorText.Append("Estación: " + Lfx.Environment.SystemInformation.ComputerName + Environment.NewLine);
                        ErrorText.Append("Mensaje: " + Mensaje + Environment.NewLine);
                        ErrorText.Append("Extra: " + Extra + Environment.NewLine);

                        System.Text.StringBuilder SysExtra = new System.Text.StringBuilder();

                        try {
                                // Intento ver la pila de llamadas
                                StackTrace st = new StackTrace();
                                SysExtra.Append("StackTrace:");

                                for (int i = 1; i <= st.FrameCount; i++) {
                                        StackFrame sf = st.GetFrame(i);
                                        SysExtra.Append(" " + sf.GetMethod().Name);

                                        try {
                                                SysExtra.Append("(" + sf.GetFileLineNumber().ToString() + ")");
                                        }
                                        catch {
                                                // Falló al agregar el número de línea. No lo pongo y listo
                                        }
                                }

                                SysExtra.Append(Environment.NewLine);
                        }
                        catch {
                                // Nada
                        }

                        ErrorText.Append("SysExtra: " + SysExtra.ToString() + Environment.NewLine);

                        try {
                                // Guardo en el Portapapeles
                                Clipboard.SetDataObject(ErrorText);
                                // Y en un archivo de texto
                                GLog(ErrorText.ToString());
                        }
                        catch {
                                // Nada
                        }

                        try {
                                OperatingSystem osInfo = System.Environment.OSVersion;

                                if (osInfo.Platform == PlatformID.Win32NT && osInfo.Version.Major >= 4) {
                                        // Uso el registro de sucesos sólo si es NT (4 o superior)
                                        EventLog ev = new EventLog("Application", System.Environment.MachineName, "Lazaro");
                                        ev.WriteEntry(ErrorText.ToString(), System.Diagnostics.EventLogEntryType.Error);
                                        ev.Close();
                                }
                        }
                        catch {
                                // En fin...
                        }

                        if (System.Diagnostics.Debugger.IsAttached) {
                                Lui.Forms.MessageBox.Show(ErrorText.ToString(), "Error Grave");
                        }
                }

                // Función: TareasEnCurso
                // Descripción:
                //    Devuelve la cantidad de tareas actualmente en ejecucin
                //    Por el momento, es una versión muy simplificada que simplemente cuenta
                //    la cantidad de formularios MDI abiertos.
                public static int TareasEnCurso()
                {
                        return Aplicacion.FormularioPrincipal.MdiChildren.Length;
                }

                // Sub: GLog
                // Descripción:
                //    Escribe un evento en el archivo lazaro.log en la carpeta del programa
                //    (A diferencia de GDBLog que lo hace en la tabla sys_log)
                //    Se utiliza para registrar errores y comportamentos anormales
                public static void GLog(string sCadena)
                {
                        System.IO.BinaryWriter wr = new System.IO.BinaryWriter(new System.IO.FileStream(Lfx.Environment.Folders.ApplicationDataFolder + "lazaro.log", System.IO.FileMode.Append));
                        wr.Write((System.DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " " + sCadena + Environment.NewLine).ToCharArray());
                        wr.Close();
                }


                // Función Main()
                // Descripción: Punto de entrada principal del programa
                //    Hace la conexión a la base de datos y llama a IniciarNormal o IniciarFiscal
                //    dependiente de si está en modo modo normal o servidor fiscal
                [STAThread]
                public static int Main(string[] args)
                {
                        System.Console.WriteLine("Codificación: " + System.Text.Encoding.Default.BodyName);
                        if (System.Text.Encoding.Default.BodyName != "iso-8859-1"
                                && System.Text.Encoding.Default.BodyName != "utf-8") {
                                System.Windows.Forms.MessageBox.Show("Sólo se permiten las codificaciones ISO-8859-1 (Latin-1) y UTF-8.", "Error");
                                System.Windows.Forms.Application.Exit();
                        }

                        Application.EnableVisualStyles();

                        bool ReconfigDB = false;

                        string NombreConfig = "default";

                        if (args != null) {
                                foreach (string Argumento in args) {
                                        switch (Argumento) {
                                                case "/config":
                                                        ReconfigDB = true;
                                                        break;

                                                default:
                                                        NombreConfig = System.IO.Path.GetFileNameWithoutExtension(Argumento);
                                                        break;
                                        }
                                }
                        }

                        //Si no hay espacio de trabajo predeterminado (default.lwf), presento una ventana de selección
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationDataFolder);
                        if (Dir.GetFiles(NombreConfig + ".lwf").Length == 0 && Dir.GetFiles("*.lwf").Length >= 1) {
                                Lui.Forms.WorkspaceSelectorForm SelectEspacio = new Lui.Forms.WorkspaceSelectorForm();
                                if (SelectEspacio.ShowDialog() == DialogResult.OK) {
                                        NombreConfig = SelectEspacio.WorkspaceName;
                                        if (NombreConfig == null)
                                                System.Environment.Exit(0);
                                } else {
                                        System.Environment.Exit(0);
                                }
                        }

                        Lws.Workspace.Master = new Lws.Workspace(NombreConfig, false);

                        Config.PreIniciar();

                        if (ReconfigDB) {
                                Misc.Config.ConfigBD OFormConfigBD = new Misc.Config.ConfigBD();

                                if (OFormConfigBD.ShowDialog() == DialogResult.Cancel)
                                        System.Environment.Exit(0);
                        }

                        do {
                                Lfx.Types.OperationResult Res = Datos.Iniciar();

                                // Si no pudo conectar, muestro la configuración de la base de datos
                                // Si hay DSN, muestro el error
                                if (Res.Success == false) {
                                        bool MostrarConfig = true;

                                        if (Lws.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "DataSource", null) != null) {
                                                Misc.Config.ConfigDBError OFormConfigDBError = new Misc.Config.ConfigDBError();
                                                OFormConfigDBError.ErrorText = Res.Message;

                                                switch (OFormConfigDBError.ShowDialog()) {
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

                                        if (MostrarConfig) {
                                                Misc.Config.ConfigBD OFormConfigBD = new Misc.Config.ConfigBD();

                                                if (OFormConfigBD.ShowDialog() == DialogResult.Cancel) {
                                                        MostrarConfig = false;
                                                        System.Environment.Exit(0);
                                                }
                                        }
                                } else {
                                        break;
                                }
                        } while (true);

                        //TODO: verificar la presencia de los frameworks correspondientes
                        /* 
                        if (Lfx.Environment.SystemInformation.RunTime == Lfx.Environment.SystemInformation.RunTimes.DotNet) {
                                bool TieneDotNet35 = false;
                                try {
                                        Microsoft.Win32.RegistryKey LocalMachine = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.5", false);
                                        object Installed = LocalMachine.GetValue("Install");
                                        if (System.Convert.ToInt32(Installed) == 1)
                                                TieneDotNet35 = true;
                                }
                                catch (Exception ex) {
                                        System.Console.WriteLine(ex.Message);
                                        TieneDotNet35 = false;
                                }

                                if (TieneDotNet35 == false) {
                                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("No se encontró la versión 3.5 de Microsoft .NET Framework. Este componente es necesario para utilizar el sistema Lázaro. ¿Desea descargarlo ahora?", "Componentes requeridos");
                                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                                Lfx.Environment.Shell.Execute("http://www.sistemalazaro.com.ar/aslnlwc/lazarosetup.exe", "", ProcessWindowStyle.Normal, false);
                                                return 0;
                                        }
                                }
                        }
                        */

                        Config.Iniciar();

                        Lfx.Types.OperationResult ResultadoInicio = new Lfx.Types.SuccessOperationResult();

                        Lws.Workspace.Master.RunTime.IpcEvent += new Lws.Workspace.RunTimeServices.IpcEventHandler(Workspace_IpcEvent);

                        ResultadoInicio = IniciarNormal();

                        if (ResultadoInicio.Success == false)
                                Lui.Forms.MessageBox.Show(ResultadoInicio.Message, "Error al Iniciar");

                        return 0;
                }


                public static void Workspace_IpcEvent(object sender, ref Lws.Workspace.RunTimeServices.IpcEventArgs e)
                {
                        if (e.Destination == "lazaro") {
                                switch (e.EventType) {
                                        case Lws.Workspace.RunTimeServices.IpcEventArgs.EventTypes.ActionRequest:
                                                if (e.Arguments != null)
                                                        e.ReturnValue = Exec(e.Verb + " " + string.Join(" ", (string[])e.Arguments));
                                                else
                                                        e.ReturnValue = Exec(e.Verb);
                                                break;
                                        case Lws.Workspace.RunTimeServices.IpcEventArgs.EventTypes.Information:
                                                switch (e.Verb) {
                                                        case "ITEMFOCUS":
                                                                if (Aplicacion.FormularioPrincipal != null) {
                                                                        if (e.Arguments.Length >= 3 && e.Arguments[0].ToString() == "TABLE") {
                                                                                string Tabla = e.Arguments[1].ToString();
                                                                                int ItemId = Lfx.Types.Parsing.ParseInt(e.Arguments[2].ToString());
                                                                                Aplicacion.FormularioPrincipal.MostrarItem(Tabla, ItemId);
                                                                        }
                                                                }
                                                                break;
                                                }
                                                break;
                                }
                        }
                }

                // Función: IniciarFiscal
                // Descripción:
                //    Inicia el programa en modo servidor normal (pide usuario y contraseña y
                //    crea una ventana principal, con men, etc.)
                //    Opuesto a IniciarServidorFiscal
                private static Lfx.Types.OperationResult IniciarNormal()
                {
                        if (Lfx.Environment.SystemInformation.DesignMode == false) {
                                Actualizador.Actualizador.ActualizarAplicacionDesdeBD();

                                if (Actualizador.Actualizador.ArchivosActualizados > 0) {
                                        Aplicacion.Exec("REBOOT");
                                        System.Environment.Exit(0);
                                }
                        }

                        if (Aplicacion.CUIT == null || Aplicacion.CUIT.Length == 0 || Aplicacion.CUIT == "00-00000000-0") {
                                Misc.Config.Preferencias FormConfig = new Misc.Config.Preferencias();
                                FormConfig.Workspace = Lws.Workspace.Master;
                                FormConfig.cmdSiguiente.Visible = false;
                                if (FormConfig.ShowDialog() == DialogResult.OK)
                                        Aplicacion.Exec("REBOOT");
                                else
                                        Aplicacion.Exec("QUIT");
                        }

                        System.DateTime FechaServidor = System.Convert.ToDateTime(Lws.Workspace.Master.DefaultDataBase.FirstRowFromSelect("SELECT NOW()")[0]);
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

                        Lazaro.Misc.Ingreso OFormIngreso = new Lazaro.Misc.Ingreso();

                        OFormIngreso.ShowDialog();

                        if (Lws.Workspace.Master.DefaultDataBase.SlowLink == false && Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString("Sistema", "Backup.Tipo", "0") == "2") {
                                string FechaActual = System.DateTime.Now.ToString("yyyy-MM-dd");
                                string FechaBackup = Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString("Sistema", "Backup.Ultimo", "");
                                if (FechaActual != FechaBackup) {
                                        int Articulos = Lws.Workspace.Master.DefaultDataBase.FieldInt("SELECT COUNT(id_articulo) FROM articulos");
                                        if (Articulos > 0) {
                                                //Hago un backup automático, una vez por día, siempre que haya al menos 1 artículo en la BD
                                                //Esto es para evitar hacer backup de una BD vacía
                                                Aplicacion.Exec("BACKUP NOW");
                                                Lws.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema", "Backup.Ultimo", FechaActual);
                                        }
                                }
                        }

                        if (Lws.Workspace.Master.CurrentUser.UserId > 0) {
                                // Dim Yo As Process = Process.GetCurrentProcess
                                // Yo.PriorityClass = ProcessPriorityClass.AboveNormal

                                // Mostrar el formulario
                                Aplicacion.FormularioPrincipal = new Principal.Inicio();
                                Aplicacion.FormularioPrincipal.Workspace = Lws.Workspace.Master;
                                Aplicacion.FormularioPrincipal.Show();
                                Application.Run(Aplicacion.FormularioPrincipal);
                        }

                        Config.Terminar();
                        return new Lfx.Types.SuccessOperationResult();
                }

		/// <summary>
		/// Ejecuta un comando. Se trata de un pequeño lenguaje de scripting de Lázaro.
		/// </summary>
		/// <param name="comando">
		/// El comando a ejecutar.
		/// </param>
		/// <returns>
		/// Normalmente devuelve un formulario, que es el resultado del comando.
                /// Por ejemplo, el comando "EDITAR ARTICULO 132" devuelve un formulario tipo
                /// FormArticuloEditar donde se está editando el artículo.
		/// </returns>
                public static object Exec(string comando)
                {
                        return Aplicacion.Exec(comando, null);
                }

                public static object Exec(string comando, string estacion)
                {
                        if (estacion == null || estacion.Length == 0)
                                estacion = Lfx.Environment.SystemInformation.ComputerName;

                        string SubComando = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpperInvariant();

                        switch (SubComando) {
                                case "LIC":
                                        Lfx.Sound.Lic(@"C:\Lazaro\Sistema");
                                        Lfx.Sound.Lic(@"C:\Lazaro\Lfx");
                                        Lfx.Sound.Lic(@"C:\Lazaro\Lbl");
                                        Lfx.Sound.Lic(@"C:\Lazaro\Lws");
                                        Lfx.Sound.Lic(@"C:\Lazaro\Lui");
                                        Lfx.Sound.Lic(@"C:\Lazaro\Lfc");
                                        break;

                                case "CHKDB":
                                        string SubComandoDbCheck = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpperInvariant();
					Lws.Data.DataView DataViewChk = Lws.Workspace.Master.GetDataView(true);
                                        if (SubComandoDbCheck == "DFK")
                                                DataViewChk.DataBase.EmptyConstraints();
                                        Datos.VerificarVersionDB(DataViewChk, true, false);
					DataViewChk.Dispose();
                                        break;

                                case "VER":
                                        Lazaro.Misc.AcercaDe OAcercaDe = new Lazaro.Misc.AcercaDe();
                                        OAcercaDe.Workspace = Lws.Workspace.Master;
                                        OAcercaDe.ShowDialog();
                                        break;

                                case "REBOOT":
                                        Config.Terminar();

                                        string[] ParametrosAPasar = Environment.GetCommandLineArgs();
                                        ParametrosAPasar[0] = "";
                                        string Params = string.Join(" ", ParametrosAPasar).Trim();
                                        if (Lfx.Environment.SystemInformation.RunTime == Lfx.Environment.SystemInformation.RunTimes.DotNet)
                                                Lfx.Environment.Shell.Execute(System.Reflection.Assembly.GetExecutingAssembly().Location, Params, ProcessWindowStyle.Normal, false);
                                        else
                                                Lfx.Environment.Shell.Execute("mono", @"""" + System.Reflection.Assembly.GetExecutingAssembly().Location + @""" " + Params, ProcessWindowStyle.Normal, false);
                                        System.Environment.Exit(0);
                                        break;

                                case "CALC":
                                        Lazaro.Misc.Calculadora OCalc = new Lazaro.Misc.Calculadora();
                                        OCalc.Show();
                                        break;

                                case "BACKUP":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.backup")) {
                                                string SubComandoBackup = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                switch (SubComandoBackup) {
                                                        case "MANAGER":
                                                                Misc.Backup.Manager OFormBackup = (Misc.Backup.Manager)BuscarVentana("Misc.Backup.Manager");
                                                                if (OFormBackup == null)
                                                                        OFormBackup = new Misc.Backup.Manager();
                                                                OFormBackup.Workspace = Lws.Workspace.Master;
                                                                OFormBackup.ShowDialog(Aplicacion.FormularioPrincipal);
                                                                break;

                                                        case "NOW":
                                                                //string Carpeta = "lbkp_" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + System.IO.Path.DirectorySeparatorChar;
                                                                string Carpeta = "Copia de seguridad del sistema Lázaro del " + System.DateTime.Now.ToString("dd-MM-yyyy (HH.mm).lbk") + System.IO.Path.DirectorySeparatorChar;
                                                                Misc.Backup.Services.CreateBackup(Carpeta);
                                                                break;
                                                }
                                        }
                                        break;

                                case "BUSCAR":
                                        Form OFormSuperBuscador = BuscarVentana("Misc.SuperBuscador.Inicio");
                                        if (OFormSuperBuscador == null)
                                                OFormSuperBuscador = new Misc.SuperBuscador.Inicio();
                                        if (!Aplicacion.Flotante)
                                                OFormSuperBuscador.MdiParent = Aplicacion.FormularioPrincipal;
                                        OFormSuperBuscador.Show();
                                        break;

                                case "CONFIG":
                                        Misc.Config.Preferencias OFormConfig = (Misc.Config.Preferencias)BuscarVentana("Misc.Config.Preferencias");
                                        if (OFormConfig == null)
                                                OFormConfig = new Misc.Config.Preferencias();
                                        OFormConfig.Workspace = Lws.Workspace.Master;
                                        OFormConfig.ShowDialog(Aplicacion.FormularioPrincipal);
                                        break;

                                case "ACCESSMGR":
                                        return Exec("LIST USER");

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
                                                        OFormFiscal.Workspace = Lws.Workspace.Master;
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
                                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.total")) {
                                                                Lazaro.Reportes.IngresosEgresos OFormRepRentabilidad = new Lazaro.Reportes.IngresosEgresos();
                                                                OFormRepRentabilidad.Workspace = Lws.Workspace.Master;
                                                                if (!Aplicacion.Flotante)
                                                                        OFormRepRentabilidad.MdiParent = Aplicacion.FormularioPrincipal;
                                                                OFormRepRentabilidad.Show();
                                                                return OFormRepRentabilidad;
                                                        }
                                                        break;
                                                case "PATRIMONIO":
                                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.total")) {
                                                                Lazaro.Reportes.Patrimonio RepPatr = new Lazaro.Reportes.Patrimonio();
                                                                RepPatr.Workspace = Lws.Workspace.Master;
                                                                if (!Aplicacion.Flotante)
                                                                        RepPatr.MdiParent = Aplicacion.FormularioPrincipal;
                                                                RepPatr.Show();
                                                                return RepPatr;
                                                        }
                                                        break;
                                        }

                                        break;

                                case "IMPRIMIR":
                                        string SubComandoImprimir = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                        switch (SubComandoImprimir) {
                                                case "COMPROBANTE":
                                                case "COMPROB":
                                                        int IdComprobante = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " "));

                                                        Lws.Data.DataView DataViewImprimir = Lws.Workspace.Master.GetDataView(true);
                                                        DataViewImprimir.DataBase.BeginTransaction();
                                                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = new Lbl.Comprobantes.ComprobanteConArticulos(DataViewImprimir, IdComprobante);

                                                        Lfx.Types.OperationResult ResultadoImpresion = Comprob.Imprimir();
                                                        if (ResultadoImpresion.Success)
                                                                DataViewImprimir.DataBase.Commit();
                                                        else
                                                                DataViewImprimir.DataBase.RollBack();
							DataViewImprimir.Dispose();

                                                        return ResultadoImpresion;
                                        }
                                        break;

                                case "TICKER":
                                        string SubComandoTicker = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                        switch (SubComandoTicker) {
                                                case "MOSTRADOR":
                                                        Lfc.Misc.Estaticos.FormularioTickerPresupuestos = new Lfc.Comprobantes.Ticker.TickerPresupuestos();
                                                        Lfc.Misc.Estaticos.FormularioTickerPresupuestos.Workspace = Lws.Workspace.Master;
                                                        Lfc.Misc.Estaticos.FormularioTickerPresupuestos.Workspace.RunTime.IpcEvent += new Lws.Workspace.RunTimeServices.IpcEventHandler(Lfc.Misc.Estaticos.FormularioTickerPresupuestos.Workspace_IpcEvent);
                                                        Lfc.Misc.Estaticos.FormularioTickerPresupuestos.Show();
                                                        break;
                                        }

                                        break;

                                case "ANULAR":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "documents.create") && Lui.Login.LoginData.Access(Lws.Workspace.Master.CurrentUser, "documents.write")) {
                                                string SubComandoAnular = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                Lfc.Comprobantes.Facturas.Anular OFormFacturaAnular = new Lfc.Comprobantes.Facturas.Anular();
                                                OFormFacturaAnular.Workspace = Lws.Workspace.Master;

                                                switch (SubComandoAnular) {
                                                        case "FACTURA":
                                                        case "FACT":
                                                                // Nada
                                                                break;

                                                        case "B":
                                                        case "FB":
                                                                OFormFacturaAnular.txtTipo.Text = "B";
                                                                break;

                                                        case "A":
                                                        case "FA":
                                                                OFormFacturaAnular.txtTipo.Text = "A";
                                                                break;
                                                }

                                                OFormFacturaAnular.ShowDialog(Aplicacion.FormularioPrincipal);
                                        }
                                        break;

                                case "CREAR":
                                case "CREATE":
                                case "EDITAR":
                                case "EDIT":
                                        if (SubComando == "CREAR" || SubComando == "CREATE")
                                                return ExecCrearEditar(true, comando);
                                        else
                                                return ExecCrearEditar(false, comando);

                                case "LISTADO":
                                case "LIST":
                                        return ExecListado(comando);

                                case "CAJA":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "accounts.read")) {
                                                string SubComandoCaja = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                Lfc.Cuentas.Inicio FormularioCaja = new Lfc.Cuentas.Inicio();
                                                FormularioCaja.Workspace = Lws.Workspace.Master;
                                                if (!Aplicacion.Flotante)
                                                        FormularioCaja.MdiParent = Aplicacion.FormularioPrincipal;
                                                FormularioCaja.m_Cuenta = Lws.Workspace.Master.CurrentConfig.Company.CajaDiaria;

                                                if (SubComandoCaja.Length > 0) {
                                                        DateTime? Fecha = Lfx.Types.Parsing.ParseDate(SubComandoCaja);
                                                        if (Fecha.HasValue) {
                                                                FormularioCaja.m_Fechas = new Lfx.Types.DateRange("dia");
                                                                FormularioCaja.m_Fechas.From = Fecha.Value;
                                                                FormularioCaja.m_Fechas.To = Fecha.Value;
                                                        }
                                                }

                                                FormularioCaja.RefreshList();
                                                FormularioCaja.Show();
                                                return FormularioCaja;
                                        }
                                        break;

                                case "CTACTE":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "ctacte.read")) {
                                                string SubComandoCtaCte = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                Lfc.Cuentas.Corriente.Inicio CtaCte = ((Lfc.Cuentas.Corriente.Inicio)(BuscarVentana("Lfc.Cuentas.Corriente.Inicio")));

                                                if (CtaCte == null)
                                                        CtaCte = new Lfc.Cuentas.Corriente.Inicio();

                                                CtaCte.Workspace = Lws.Workspace.Master;
                                                if (!Aplicacion.Flotante)
                                                        CtaCte.MdiParent = Aplicacion.FormularioPrincipal;
                                                CtaCte.m_Cliente = Lfx.Types.Parsing.ParseInt(SubComandoCtaCte);
                                                CtaCte.RefreshList();
                                                CtaCte.Show();
                                                return CtaCte;
                                        }
                                        break;

                                case "TARJETAS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "accounts.read")) {
                                                Lfc.Tarjetas.Cupones.Inicio OTarjetas = ((Lfc.Tarjetas.Cupones.Inicio)(BuscarVentana("Lfc.Cuentas.Tarjetas.Inicio")));

                                                if (OTarjetas == null)
                                                        OTarjetas = new Lfc.Tarjetas.Cupones.Inicio();
                                                if (!Aplicacion.Flotante)
                                                        OTarjetas.MdiParent = Aplicacion.FormularioPrincipal;
                                                OTarjetas.Workspace = Lws.Workspace.Master;
                                                OTarjetas.RefreshList();
                                                OTarjetas.Show();
                                                return OTarjetas;
                                        }
                                        break;

                                case "CUENTA":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "accounts.read")) {
                                                string SubComandoCuenta = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                Lfc.Cuentas.Inicio FormularioCuenta = new Lfc.Cuentas.Inicio();
                                                FormularioCuenta.Workspace = Lws.Workspace.Master;
                                                if (!Aplicacion.Flotante)
                                                        FormularioCuenta.MdiParent = Aplicacion.FormularioPrincipal;
                                                FormularioCuenta.m_Cuenta = Lfx.Types.Parsing.ParseInt(SubComandoCuenta);
                                                FormularioCuenta.RefreshList();
                                                FormularioCuenta.Show();
                                                return FormularioCuenta;
                                        }
                                        break;

                                case "MOVIM":
                                        string SubComandoMovim = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                        switch (SubComandoMovim) {
                                                case "ARTICULOS":
                                                        string SubComandoArticulos = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();
                                                        Lfc.Articulos.Movimiento FormularioMovimientoArticulo = new Lfc.Articulos.Movimiento();
                                                        FormularioMovimientoArticulo.Workspace = Lws.Workspace.Master;
                                                        FormularioMovimientoArticulo.EntradaArticulo.TextInt = Lfx.Types.Parsing.ParseInt(SubComandoArticulos);
                                                        FormularioMovimientoArticulo.ShowDialog(Aplicacion.FormularioPrincipal);
                                                        return FormularioMovimientoArticulo;
                                        }

                                        break;

                                case "RUNCOMPONENT":
                                        string Componente = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();
                                        string Funcion = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();
                                        Lws.Components.ComponentManager.Run(Lws.Workspace.Master, Aplicacion.Flotante ? null : Aplicacion.FormularioPrincipal, Componente, Funcion);
                                        break;

                                case "QUIT":
                                        Lws.Workspace.Master.ActionLog("QUIT", "");
                                        if (Aplicacion.FormularioPrincipal != null)
                                                Aplicacion.FormularioPrincipal.Close();
                                        Lws.Workspace.Master.CurrentConfig.WriteGlobalSetting("", "Sistema.Ingreso.UltimoEgreso", Lfx.Types.Formatting.FormatDateTimeSql(System.DateTime.Now), "");
                                        System.Environment.Exit(0);
                                        break;

                                default:
                                        if (Lfx.Environment.SystemInformation.DesignMode)
                                                throw new NotImplementedException(comando);
                                        return new Lfx.Types.OperationResult(false);
                        }

                        return null;
                }

                private static object ExecListado(string Comando)
                {
                        string SubComando = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                        Lui.Forms.ListingForm FormularioListado = null;

                        switch (SubComando) {
                                case "ALICUOTAS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lazaro.Misc.Alicuotas.Inicio");
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Alicuotas.Inicio();
                                        }
                                        break;

                                case "CHEQUERAS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "accounts.read")) {
                                                Lfc.Bancos.Chequeras.Inicio OFormChequerasInicio = new Lfc.Bancos.Chequeras.Inicio();
                                                OFormChequerasInicio.Workspace = Lws.Workspace.Master;
                                                if (!Aplicacion.Flotante)
                                                        OFormChequerasInicio.MdiParent = Aplicacion.FormularioPrincipal;
                                                OFormChequerasInicio.Show();
                                                return OFormChequerasInicio;
                                        }
                                        break;

                                case "CHEQUES":
                                        string SubSubComando = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                        switch (SubSubComando) {
                                                case "RECIBIDOS":
                                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "accounts.read")) {
                                                                Lfc.Bancos.Cheques.Inicio FormularioChequesRecibidos = new Lfc.Bancos.Cheques.Inicio();
                                                                FormularioChequesRecibidos.Workspace = Lws.Workspace.Master;
                                                                if (!Aplicacion.Flotante)
                                                                        FormularioChequesRecibidos.MdiParent = Aplicacion.FormularioPrincipal;
                                                                FormularioChequesRecibidos.Emitidos = false;
                                                                FormularioChequesRecibidos.Show();
                                                                return FormularioChequesRecibidos;
                                                        }
                                                        break;

                                                case "EMITIDOS":
                                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "accounts.read")) {
                                                                Lfc.Bancos.Cheques.Inicio FormularioChequesEmitidos = new Lfc.Bancos.Cheques.Inicio();
                                                                FormularioChequesEmitidos.Workspace = Lws.Workspace.Master;
                                                                if (!Aplicacion.Flotante)
                                                                        FormularioChequesEmitidos.MdiParent = Aplicacion.FormularioPrincipal;
                                                                FormularioChequesEmitidos.Emitidos = true;
                                                                FormularioChequesEmitidos.Show();
                                                                return FormularioChequesEmitidos;
                                                        }
                                                        break;
                                        }
                                        break;

                                case "CUENTA":
                                case "CUENTAS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "accounts.admin")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lfc.Cuentas.Admin.Inicio");
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Cuentas.Admin.Inicio();
                                        }
                                        break;

                                case "CLIENTE":
                                case "CLIENTES":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "people.read")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lfc.Personas.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Personas.Inicio();

                                                ((Lfc.Personas.Inicio)(FormularioListado)).m_Tipo = 1;
                                        }
                                        break;

                                case "personas_grupos":
                                case "PERSONAS_GRUPOS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lfc.Personas.Grupos.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Personas.Grupos.Inicio();
                                        }
                                        break;

                                case "USER":
                                case "USERS":
                                case "USUARIO":
                                case "USUARIOS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "people.read")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("FormClientesInicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Personas.Inicio();

                                                ((Lfc.Personas.Inicio)(FormularioListado)).m_Tipo = 4;
                                        }
                                        break;

                                case "SUCURSAL":
                                case "SUCURSALES":
                                case "sucursales":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lazaro.Misc.Sucursales.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Sucursales.Inicio();
                                        }
                                        break;

                                case "PLANTILLA":
                                case "PLANTILLAS":
                                case "sys_plantillas":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lfc.Comprobantes.Plantillas.Inicio");
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Comprobantes.Plantillas.Inicio();
                                        }
                                        break;

                                case "PROVEEDOR":
                                case "PROVEEDORES":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "people.read")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lfc.Personas.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Personas.Inicio();

                                                ((Lfc.Personas.Inicio)(FormularioListado)).m_Tipo = 2;
                                        }
                                        break;

                                case "PV":
                                case "PVS":
                                case "pvs":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lazaro.Misc.Pvs.Inicio");

                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Pvs.Inicio();
                                        }
                                        break;

                                case "ARTICULO":
                                case "ARTICULOS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "products.read")) {
                                                string SubComandoArticulos = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Articulos.Inicio");

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
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "products.read")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Articulos.Categorias.Inicio");
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Articulos.Categorias.Inicio();
                                        }
                                        break;

                                case "ARTICULO_RUBRO":
                                case "ARTICULO_RUBROS":
                                case "ARTICULOS_RUBRO":
                                case "ARTICULOS_RUBROS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "products.read")) {
                                                FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Articulos.Rubros.Inicio");
                                                if (FormularioListado == null)
                                                        FormularioListado = new Lfc.Articulos.Rubros.Inicio();
                                        }
                                        break;

                                case "COMPROBANTE":
                                case "COMPROBANTES":
                                        FormularioListado = new Lfc.Comprobantes.Inicio();
                                        string ListadoComprobTipo = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                        string ListadoComprobLetra = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                        if (ListadoComprobTipo.Length > 0)
                                                ((Lfc.Comprobantes.Inicio)(FormularioListado)).Tipo = ListadoComprobTipo;
                                        if (ListadoComprobLetra.Length > 0)
                                                ((Lfc.Comprobantes.Inicio)(FormularioListado)).Letra = ListadoComprobLetra;
                                        break;

                                case "RECIBOS":
                                        FormularioListado = new Lfc.Comprobantes.Recibos.Inicio();
                                        break;

                                case "MARCAS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "products.read"))
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
                                case "CUENTAS_CONCEPTOS":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioListado = new Lfc.Cuentas.Conceptos.Inicio();
                                        }
                                        break;

                                case "CIUDAD":
                                case "CIUDADES":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioListado = new Lfc.Ciudades.FormCiudadesInicio();
                                        }
                                        break;

                                case "TICKET":
                                case "TICKETS":
                                        string SubComandoTickets = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                        FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lfc.Tareas.Inicio");
                                        if (FormularioListado == null)
                                                FormularioListado = new Lfc.Tareas.Inicio();
                                        ((Lfc.Tareas.Inicio)(FormularioListado)).Tarea = Lfx.Types.Parsing.ParseInt(SubComandoTickets);
                                        break;

                                case "VENCIMIENTO":
                                case "VENCIMIENTOS":
                                        FormularioListado = (Lui.Forms.ListingForm)BuscarVentana("Lfc.Cuentas.Vencimientos.Inicio");
                                        if (FormularioListado == null)
                                                FormularioListado = new Lfc.Cuentas.Vencimientos.Inicio();
                                        break;

                                default:
                                        if (Lfx.Environment.SystemInformation.DesignMode)
                                                throw new NotImplementedException(SubComando);
                                        break;
                        }

                        if (FormularioListado == null)
                                return null;

                        FormularioListado.Workspace = Lws.Workspace.Master;
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
                        bool Interactivo = true;
                        if (SubComando == "NI") {
                                //CREAR NI FACT
                                //apago modo interactivo. tomo el siguiente token
                                Interactivo = false;
                                SubComando = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();
                        }

                        Lui.Forms.EditForm FormularioDeEdicion = new Lui.Forms.EditForm();
                        bool MdiChild = true;

                        switch (SubComando) {
                                case "ALICUOTA":
                                case "alicuotas":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioDeEdicion = new Lfc.Alicuotas.Editar();
                                                MdiChild = false;
                                        }
                                        break;

                                case "CLIENTE":
                                case "PERSONA":
                                case "personas":
                                        if (Lui.Login.LoginData.Access(Lws.Workspace.Master.CurrentUser, "people.*")) {
                                                FormularioDeEdicion = new Lfc.Personas.Editar();
                                                if (crear)
                                                        ((Lfc.Personas.Editar)(FormularioDeEdicion)).EntradaTipo.Text = "1";
                                        } else {
                                                Lui.Forms.MessageBox.Show("No tiene permiso para realizar la operación solicitada.", "Error");
                                        }
                                        break;

                                case "PROVEEDOR":
                                        if (Lui.Login.LoginData.Access(Lws.Workspace.Master.CurrentUser, "people.*")
                                                || Lui.Login.LoginData.Access(Lws.Workspace.Master.CurrentUser, "people.basicwrite")) {
                                                FormularioDeEdicion = new Lfc.Personas.Editar();
                                                FormularioDeEdicion.Workspace = Lws.Workspace.Master;
                                                if (crear)
                                                        ((Lfc.Personas.Editar)(FormularioDeEdicion)).EntradaTipo.Text = "2";
                                        } else {
                                                Lui.Forms.MessageBox.Show("No tiene permiso para realizar la operación solicitada.", "Error");
                                        }
                                        break;

                                case "PERSONAS_GRUPOS":
                                case "personas_grupos":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioDeEdicion = new Lfc.Personas.Grupos.Editar();
                                                MdiChild = false;
                                        }
                                        break;

                                case "ACCESO":
                                case "ACCESS":
                                        FormularioDeEdicion = new Lfc.Personas.EditarAccesos();
                                        break;

                                case "ARTICULO":
                                case "articulos":
                                        FormularioDeEdicion = new Lfc.Articulos.Editar();
                                        break;

                                case "RECETA":
                                case "articulos_recetas":
                                        FormularioDeEdicion = new Lfc.Articulos.Recetas.Editar();
                                        break;

                                case "ARTICULO_CATEG":
                                case "cat_articulos":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioDeEdicion = new Lfc.Articulos.Categorias.Editar();
                                        }
                                        break;

                                case "ARTICULO_RUBRO":
                                case "articulos_rubros":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioDeEdicion = new Lfc.Articulos.Rubros.Editar();
                                                MdiChild = false;
                                        }
                                        break;

                                case "MARCA":
                                case "marcas":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioDeEdicion = new Lfc.Articulos.Marcas.Editar();
                                                MdiChild = false;
                                        }
                                        break;

                                case "CHEQUES":
                                case "cheques":
                                case "bancos_cheques":
                                        FormularioDeEdicion = new Lfc.Bancos.Cheques.Editar();
                                        break;
                                
                                case "CHEQUERA":
                                case "chequeras":
                                        FormularioDeEdicion = new Lfc.Bancos.Chequeras.Editar();
                                        break;

                                case "COMPROBANTE":
                                        FormularioDeEdicion = new Lfc.Comprobantes.Editar();
                                        break;

                                case "CUENTA":
                                case "cuentas":
                                        FormularioDeEdicion = new Lfc.Cuentas.Admin.Editar();
                                        MdiChild = false;
                                        break;

                                case "CONCEPTO":
                                case "cuentas_conceptos":
                                        FormularioDeEdicion = new Lfc.Cuentas.Conceptos.Editar();
                                        MdiChild = false;
                                        break;

                                case "CIUDAD":
                                case "ciudades":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioDeEdicion = new Lfc.Ciudades.Editar();
                                                MdiChild = false;
                                        }
                                        break;

                                case "PV":
                                case "pvs":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioDeEdicion = new Lfc.Pvs.Editar();
                                                MdiChild = false;
                                        }
                                        break;

                                case "PLANTILLA":
                                case "sys_plantillas":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioDeEdicion = new Lfc.Comprobantes.Plantillas.Editar();
                                        }
                                        break;

                                case "SUCURSAL":
                                case "sucursales":
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "global.admin")) {
                                                FormularioDeEdicion = new Lfc.Sucursales.Editar();
                                                MdiChild = false;
                                        }
                                        break;

                                case "T":
                                case "B":
                                case "A":
                                case "C":
                                case "E":
                                case "M":
                                case "NC":
                                case "ND":
                                case "NCA":
                                case "NCB":
                                case "NCC":
                                case "NCE":
                                case "NCM":
                                case "NDA":
                                case "NDB":
                                case "NDC":
                                case "NDE":
                                case "NDM":
                                        FormularioDeEdicion = new Lfc.Comprobantes.Facturas.Editar(SubComando);
                                        break;

                                case "NCND":
                                case "F":
                                case "*":
                                case "FNCND":
                                        FormularioDeEdicion = new Lfc.Comprobantes.Facturas.Editar("B");
                                        break;

                                case "PS":
                                case "PRESUPUESTO":
                                        FormularioDeEdicion = new Lfc.Comprobantes.Presupuestos.Editar("PS");
                                        break;

                                case "R":
                                case "REMITO":
                                case "remitos":
                                        FormularioDeEdicion = new Lfc.Comprobantes.Editar("R");
                                        break;

                                case "RC":
                                case "RECIBO":
                                case "recibos":
                                        FormularioDeEdicion = new Lfc.Comprobantes.Recibos.Editar();
                                        break;

                                case "RCP":
                                case "RECIBO_PAGO":
                                        FormularioDeEdicion = new Lfc.Comprobantes.Recibos.Editar();
                                        ((Lfc.Comprobantes.Recibos.Editar)(FormularioDeEdicion)).CrearDePago = true;
                                        break;

                                case "RECIBO_RAPIDO":
                                        Lui.Forms.Form OFormReciboRapido = new Lfc.Comprobantes.Recibos.Rapido();
                                        OFormReciboRapido.Workspace = Lws.Workspace.Master;
                                        OFormReciboRapido.ShowDialog(Aplicacion.FormularioPrincipal);
                                        return OFormReciboRapido;

                                case "NP":
                                case "PD":
                                case "RP":
                                case "FP":
                                        FormularioDeEdicion = new Lfc.Comprobantes.Compra.Editar();
                                        if (SubComando == "RP")
                                                ((Lfc.Comprobantes.Compra.Editar)(FormularioDeEdicion)).CrearTipo = "R";
                                        else if (SubComando == "FP")
                                                ((Lfc.Comprobantes.Compra.Editar)(FormularioDeEdicion)).CrearTipo = "A";
                                        else
                                                ((Lfc.Comprobantes.Compra.Editar)(FormularioDeEdicion)).CrearTipo = SubComando;
                                        break;

                                case "TICKET":
                                case "tickets":
                                        string SubComandoTicket = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();
                                        switch (SubComandoTicket) {
                                                case "NOVEDAD":
                                                        Lui.Forms.Form OFormNovedad = new Lfc.Tareas.Novedad();
                                                        OFormNovedad.Workspace = Lws.Workspace.Master;
                                                        OFormNovedad.ShowDialog(Aplicacion.FormularioPrincipal);
                                                        return OFormNovedad;

                                                default:
                                                        // Vuelvo a poner el token que quit del comando
                                                        comando = SubComandoTicket + " " + comando;
                                                        FormularioDeEdicion = new Lfc.Tareas.Editar();
                                                        break;
                                        }
                                        break;

                                case "vencimientos":
                                case "VENCIMIENTO":
                                case "VENCIMIENTOS":
                                        FormularioDeEdicion = new Lfc.Cuentas.Vencimientos.Editar();
                                        break;

                                default:
                                        if (Lfx.Environment.SystemInformation.DesignMode)
                                                throw new NotImplementedException(comando);
                                        FormularioDeEdicion = null;
                                        return null;
                        }

                        if (FormularioDeEdicion == null)
                                return null;

                        if (FormularioDeEdicion.Workspace == null)
                                FormularioDeEdicion.Workspace = Lws.Workspace.Master;

                        if (crear) {
                                Lfx.Types.OperationResult Result = FormularioDeEdicion.Create();
                                if (Result.Success == false) {
                                        FormularioDeEdicion.Close();
                                        FormularioDeEdicion = null;
                                        Lui.Forms.MessageBox.Show(Result.Message, "Error");
                                        return null;
                                }
                        } else {
                                Lfx.Types.OperationResult Result = FormularioDeEdicion.Edit(Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " ")));

                                if (Result.Success == false) {
                                        FormularioDeEdicion.Close();
                                        FormularioDeEdicion = null;
                                        Lui.Forms.MessageBox.Show(Result.Message, "Error");
                                        return null;
                                }
                        }

                        if (MdiChild == false) {
                                FormularioDeEdicion.WindowState = FormWindowState.Normal;
                                FormularioDeEdicion.Owner = Aplicacion.FormularioPrincipal;
                                FormularioDeEdicion.MdiParent = null;
                                FormularioDeEdicion.FormBorderStyle = FormBorderStyle.FixedDialog;
                                FormularioDeEdicion.MaximizeBox = false;
                                FormularioDeEdicion.MinimizeBox = false;
                                if (Interactivo)
                                        FormularioDeEdicion.Show();
                        } else {
                                if (Aplicacion.Flotante)
                                        FormularioDeEdicion.WindowState = Aplicacion.FormularioPrincipal.WindowState;
                                else
                                        FormularioDeEdicion.MdiParent = Aplicacion.FormularioPrincipal;

                                if (Interactivo)
                                        FormularioDeEdicion.Show();
                        }
                        return FormularioDeEdicion;
                }

                // Función: BuscarVentana
                // Parámetros:
                //    sNombre     El nombre de la ventana a buscar
                // Descripción:
                //    Busca una ventana por nombre entre los MDI children del formulario principal
                private static Form BuscarVentana(string sNombre)
                {
                        foreach (System.Windows.Forms.Form TmpForm in Aplicacion.FormularioPrincipal.MdiChildren) {
                                if (TmpForm.Name == sNombre) {
                                        return TmpForm;
                                }
                        }

                        return null;
                }

                public static Form CrearItem(string Tabla, Control ControlDestino)
                {
                        try {
                                Form TmpFormularioNuevo = null;

                                switch (Tabla) {
                                        case "alicuotas":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR ALICUOTA")));
                                                break;

                                        case "personas":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR CLIENTE")));
                                                break;

                                        case "articulos":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR ARTICULO")));
                                                break;

                                        case "articulos_rubros":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR ARTICULO_RUBRO")));
                                                break;

                                        case "ciudades":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR CIUDAD")));
                                                break;

                                        case "cuentas_conceptos":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR CONCEPTO")));
                                                break;

                                        case "marcas":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR MARCA")));
                                                break;

                                        case "cat_articulos":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR ARTICULO_CATEG")));
                                                break;

                                        case "equipos":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR EQUIPO")));
                                                break;

                                        case "ticket":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR TICKET")));
                                                break;

                                        case "exped":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR EXPEDIENTE")));
                                                break;

                                        case "edicion":
                                                TmpFormularioNuevo = ((Form)(Aplicacion.Exec("CREAR EDICION")));
                                                break;

                                        default:
                                                Lfx.Sound.Beep();
                                                break;
                                }

                                if (ControlDestino != null) {
                                        ((Lui.Forms.EditForm)(TmpFormularioNuevo)).ControlDestino = ControlDestino;
                                }

                                return TmpFormularioNuevo;
                        }
                        catch {
                                return null;
                        }
                }

                public static object EditarItem(string Tabla, int Id, Control ControlDestino)
                {
                        try {
                                object TmpFormularioNuevo = null;

                                switch (Tabla) {
                                        case "alicuotas":
                                                TmpFormularioNuevo = Aplicacion.Exec("EDITAR ALICUOTA " + Id.ToString());
                                                break;

                                        case "personas":
                                                TmpFormularioNuevo = Aplicacion.Exec("EDITAR CLIENTE " + Id.ToString());
                                                break;

                                        case "articulos":
                                                TmpFormularioNuevo = Aplicacion.Exec("EDITAR ARTICULO " + Id.ToString());
                                                break;

                                        case "articulos_rubros":
                                                TmpFormularioNuevo = Aplicacion.Exec("EDITAR ARTICULO_CATEG " + Id.ToString());
                                                break;

                                        case "equipos":
                                                TmpFormularioNuevo = Aplicacion.Exec("EDITAR EQUIPO " + Id.ToString());
                                                break;

                                        case "ticket":
                                                TmpFormularioNuevo = Aplicacion.Exec("EDITAR TICKET " + Id.ToString());
                                                break;

                                        case "exped":
                                                TmpFormularioNuevo = Aplicacion.Exec("EDITAR EXPEDIENTE " + Id.ToString());
                                                break;

                                        case "edicion":
                                                TmpFormularioNuevo = Aplicacion.Exec("EDITAR EDICION " + Id.ToString());
                                                break;

                                        default:
                                                Lfx.Sound.Beep();

                                                break;
                                }

                                if (ControlDestino != null) {
                                        ((Lui.Forms.EditForm)(TmpFormularioNuevo)).ControlDestino = ControlDestino;
                                }

                                return TmpFormularioNuevo;
                        }
                        catch {
                                return null;
                        }
                }
        }
}