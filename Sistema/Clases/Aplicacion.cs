// Copyright 2004-2010 South Bridge S.R.L.
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
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net.Mail;
using System.Security.Permissions;

namespace Lazaro
{
        public class Aplicacion
        {
                public static Principal.Inicio FormularioPrincipal;
                public static bool Flotante;
                public static bool ReinicioPendiente;
                public static string CUIT = "";

                /// <summary>
                /// Obtiene la versión del ejecutable principal.
                /// </summary>
                public static string Version()
                {
                        return System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;
                }

                /// <summary>
                /// Obtiene la fecha del ejecutable principal.
                /// </summary>
                public static string BuildDate()
                {
                        System.IO.FileInfo InfoArchivo = new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
                        return Lfx.Types.Formatting.FormatDateAndTime(InfoArchivo.LastWriteTime);
                }

                /// <summary>
                /// Obtiene un stream a un recurso.
                /// </summary>
                /// <param name="nombre">Nombre del recurso, incluyendo el espacio de nombres.</param>
                public static System.IO.Stream ObtenerRecurso(string nombre)
                {
                        string Espacio = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString();
                        return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(Espacio + "." + nombre);
                }

                /// <summary>
                /// Punto de entrada principal del programa. Hace la conexión a la base de datos y llama a IniciarNormal.
                /// </summary>
                [STAThread, SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
                public static int Main(string[] args)
                {
                        System.Console.WriteLine("RunTime: " + Lfx.Environment.SystemInformation.RunTime.ToString() + " en " + Lfx.Environment.SystemInformation.Platform.ToString());
                        System.Console.WriteLine("Codificación: " + System.Text.Encoding.Default.BodyName);

                        string[] ArchivosNuevos = System.IO.Directory.GetFiles(Lfx.Environment.Folders.ApplicationFolder, "*.new", System.IO.SearchOption.AllDirectories);
                        if (ArchivosNuevos.Length > 0) {
                                System.Console.WriteLine("Existen actualizaciones pendientes. Ejecutando Cargador");
                                Lfx.Environment.Shell.Reboot();
                        }

                        if (System.Text.Encoding.Default.BodyName != "iso-8859-1"
                                && System.Text.Encoding.Default.BodyName != "utf-8") {
                                System.Windows.Forms.MessageBox.Show("La códificación " + System.Text.Encoding.Default.BodyName.ToUpperInvariant() + " no es válida. Sólo se permiten las codificaciones ISO-8859-1 (Latin-1) y UTF-8.", "Error");
                                System.Windows.Forms.Application.Exit();
                        }

                        Application.EnableVisualStyles();
                        if (Lfx.Environment.SystemInformation.DesignMode == false) {
                                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ThreadExceptionHandler);
                                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);
                                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                        }

                        if (System.IO.File.Exists("ICSharpCode.SharpZipLib.dll") == false || System.IO.File.Exists("MySql.Data.dll") == false) {
                                Actualizador.Estado Estado = new Lazaro.Actualizador.Estado();
                                Estado.EtiquetaEstado.Text = "Se están descargando algunos archivos necesarios para el funcionamiento del sistema.";
                                Estado.Show();
                                Estado.Refresh();

                                if (System.IO.File.Exists("ICSharpCode.SharpZipLib.dll") == false)
                                        Lazaro.Actualizador.Actualizador.NetGet(@"http://www.sistemalazaro.com.ar/aslnlwc/ICSharpCode.SharpZipLib.dll", "ICSharpCode.SharpZipLib.dll");

                                if (System.IO.File.Exists("MySql.Data.dll") == false)
                                        Lazaro.Actualizador.Actualizador.NetGet(@"http://www.sistemalazaro.com.ar/aslnlwc/MySql.Data.dll", "MySql.Data.dll");

                                Estado.Dispose();
                                Estado = null;
                        }

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

                        Config.Iniciar();
                        Lws.Workspace.Master.DefaultDataBase.EnableRecover = true;

                        Lfx.Types.OperationResult ResultadoInicio = new Lfx.Types.SuccessOperationResult();

                        Lws.Workspace.Master.RunTime.IpcEvent += new Lws.Workspace.RunTimeServices.IpcEventHandler(Workspace_IpcEvent);

                        if (Lws.Workspace.Master.CurrentConfig.Company.Email.Length <= 5) {
                                string Email = Lui.Forms.InputBox.ShowInputBox("Por favor escriba la dirección de correo electrónico (e-mail) de la empresa. Si desea ingresar al sistema sin escribir la dirección ahora, haga clic en Cancelar.", Lws.Workspace.Master.CurrentConfig.Company.Name, "");
                                if (Email != null && Email.Length > 5)
                                        Lws.Workspace.Master.CurrentConfig.Company.Email = Email;
                        }

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

                /// <summary>
                /// Inicia el programa
                /// </summary>
                private static Lfx.Types.OperationResult IniciarNormal()
                {
                        if (Lfx.Environment.SystemInformation.DesignMode == false) {
                                Actualizador.Actualizador.ActualizarAplicacionDesdeBD();

                                if (Actualizador.Actualizador.ArchivosActualizados > 0) {
                                        Aplicacion.Exec("REBOOT");
                                        System.Environment.Exit(0);
                                }
                        //} else {
                        //        Actualizador.Actualizador.ActualizarAplicacionDesdeBD();
                        }

                        if (Aplicacion.CUIT == null || Aplicacion.CUIT.Length == 0 || Aplicacion.CUIT == "00-00000000-0") {
                                Misc.Config.Preferencias FormConfig = new Misc.Config.Preferencias();
                                FormConfig.Workspace = Lws.Workspace.Master;
                                FormConfig.BotonSiguiente.Visible = false;
                                if (FormConfig.ShowDialog() == DialogResult.OK)
                                        Aplicacion.Exec("REBOOT");
                                else
                                        Aplicacion.Exec("QUIT");
                        } else if (Lws.Workspace.Master.CurrentConfig.Company.Email.Length <= 5) {
                                string Email = Lui.Forms.InputBox.ShowInputBox("Por favor escriba la dirección de correo electrónico (e-mail) de la empresa. Si desea ingresar al sistema sin escribir la dirección ahora, haga clic en Cancelar.", Lws.Workspace.Master.CurrentConfig.Company.Name, "");
                                if (Email != null && Email.Length > 5)
                                        Lws.Workspace.Master.CurrentConfig.Company.Email = Email;
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

                        /**** Esta runtina hace que los saldos de los resumenes reflejen los saldos en cta. cte.
                        Lws.Data.DataView Dat = Lws.Workspace.Master.GetDataView(true);
                        Dat.BeginTransaction();
                        System.Data.DataTable Personas = Dat.DataBase.Select(@"SELECT id_persona,nombre_visible,(SELECT ctacte.saldo FROM ctacte WHERE id_cliente=personas.id_persona ORDER BY id_movim DESC LIMIT 1) AS sal 
                                FROM personas
                                WHERE id_grupo=1
                                AND (SELECT ctacte.saldo FROM ctacte WHERE id_cliente=personas.id_persona ORDER BY id_movim DESC LIMIT 1)>0");
                        foreach (System.Data.DataRow Pers in Personas.Rows) {
                                int ClienteId = System.Convert.ToInt32(Pers["id_persona"]);
                                double Saldo = System.Convert.ToDouble(Pers["sal"]);
                                System.Data.DataTable Resumenes = Dat.DataBase.Select(@"SELECT id_resumen, id_persona, tipo, importe, cancelado
                                                FROM ventas_resumenes
                                                WHERE tipo=1 AND id_persona=" + ClienteId.ToString() + @"
                                                        AND obs NOT LIKE 'Resumen extra%'
                                                ORDER BY id_resumen DESC");
                                foreach(System.Data.DataRow Resu in Resumenes.Rows) {
                                        int ResumenId = System.Convert.ToInt32(Resu["id_resumen"]);
                                        double Importe = System.Convert.ToDouble(Resu["importe"]);
                                        double Cancelado = System.Convert.ToDouble(Resu["cancelado"]);
                                        if (Cancelado >= Saldo) {
                                                Cancelado -= Saldo;
                                                Dat.DataBase.Execute("UPDATE ventas_resumenes SET cancelado=" + Lfx.Types.Formatting.FormatCurrencySql(Cancelado) + " WHERE id_resumen=" + ResumenId.ToString());
                                                break;
                                        } else {
                                                Saldo -= Cancelado;
                                                Cancelado = 0;
                                                Dat.DataBase.Execute("UPDATE ventas_resumenes SET cancelado=0" + " WHERE id_resumen=" + ResumenId.ToString());
                                        }
                                }
                        }
                        Dat.Commit(); */

                        if (Lws.Workspace.Master.CurrentUser.Id > 0) {
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
                /// Lfc.Articulos.Editar donde se está editando el artículo.
		/// </returns>
                public static object Exec(string comando)
                {
                        return Aplicacion.Exec(comando, null);
                }

                public static object Exec(string comando, string estacion)
                {
                        if (estacion == null || estacion.Length == 0)
                                estacion = System.Environment.MachineName.ToUpperInvariant();

                        string SubComando = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpperInvariant();

                        switch (SubComando) {
                                case "REPO":
                                        Lfx.Data.SqlSelectBuilder Sel = new Lfx.Data.SqlSelectBuilder("facturas_detalle");
                                        Sel.Fields = "personas.id_persona,personas.nombre_visible,facturas.fecha,facturas.total";
                                        Sel.Joins.Add(new Lfx.Data.Join("facturas", "facturas_detalle.id_factura=facturas.id_factura"));
                                        Sel.Joins.Add(new Lfx.Data.Join("personas", "facturas.id_cliente=personas.id_persona"));
                                        Sel.WhereClause = new Lfx.Data.SqlWhereBuilder("facturas.fecha BETWEEN '2009-09-01' AND '2009-09-30' AND facturas.compra=0 AND facturas.numero>0 AND facturas.tipo_fac IN ('A', 'B', 'C', 'M', 'E')");

                                        Lbl.Reportes.Reporte Rep = new Lbl.Reportes.Reporte(Lws.Workspace.Master.GetDataView(false), Sel);
                                        Rep.Grouping = new Lfx.Data.Grouping("personas.nombre_visible");
                                        Rep.Aggregates.Add(new Lfx.Data.Aggregate(Lfx.Data.AggregationFunctions.Count, "facturas.fecha"));
                                        Rep.Aggregates.Add(new Lfx.Data.Aggregate(Lfx.Data.AggregationFunctions.Sum, "facturas.total"));
                                        Rep.Fields.Add(new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 320));
                                        Rep.Fields.Add(new Lfx.Data.FormField("facturas.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 100));
                                        Rep.Fields.Add(new Lfx.Data.FormField("facturas.total", "Total", Lfx.Data.InputFieldTypes.Currency, 120));
                                        Rep.ExpandGroups = false;

                                        Lfc.Reportes.Reporte RepForm = new Lfc.Reportes.Reporte();
                                        RepForm.MdiParent = FormularioPrincipal;
                                        RepForm.ReporteAMostrar = Rep;
                                        RepForm.Show();
                                        break;

                                case "LIC":
                                        Lfx.Lic.Licenciar(@"C:\Lazaro\Sistema");
                                        Lfx.Lic.Licenciar(@"C:\Lazaro\Componentes\RunComponent");
                                        Lfx.Lic.Licenciar(@"C:\Lazaro\Componentes\ServidorFiscal");
                                        Lfx.Lic.Licenciar(@"C:\Lazaro\Lfx");
                                        Lfx.Lic.Licenciar(@"C:\Lazaro\Lbl");
                                        Lfx.Lic.Licenciar(@"C:\Lazaro\Lws");
                                        Lfx.Lic.Licenciar(@"C:\Lazaro\Lui");
                                        Lfx.Lic.Licenciar(@"C:\Lazaro\Lfc");
                                        Lfx.Lic.Licenciar(@"C:\Lazaro\Cargador");
                                        break;

                                case "ERROR":
                                        throw new InvalidOperationException("Error de Prueba");

                                case "TEST":
                                        Misc.Form1 Frm = new Lazaro.Misc.Form1();
                                        Frm.Workspace = Lws.Workspace.Master;
                                        Frm.MdiParent = FormularioPrincipal;
                                        Frm.Show();
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
                                                        Lws.Workspace.Master.DefaultDataBase.CheckDataBase();
                                                        break;
                                                case "STRUCT":
                                                        Lws.Data.DataView DataViewChk = Lws.Workspace.Master.GetDataView(true);
                                                        if (SubComandoDbCheck == "DFK")
                                                                DataViewChk.DataBase.EmptyConstraints();
                                                        Datos.VerificarVersionDB(DataViewChk, true, false);
                                                        DataViewChk.Dispose();
                                                        break;
                                        }
                                        break;

                                case "VER":
                                        Lazaro.Misc.AcercaDe OAcercaDe = new Lazaro.Misc.AcercaDe();
                                        OAcercaDe.Workspace = Lws.Workspace.Master;
                                        OAcercaDe.ShowDialog();
                                        break;

                                case "REBOOT":
                                        Config.Terminar();
                                        Lfx.Environment.Shell.Reboot();
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
                                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "documents.delete")) {
                                                string SubComandoAnular = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                                switch (SubComandoAnular) {
                                                        case "FACTURA":
                                                        case "FACT":
                                                                Lfc.Comprobantes.Facturas.Anular FormularioFacturaAnular = new Lfc.Comprobantes.Facturas.Anular();
                                                                FormularioFacturaAnular.Workspace = Lws.Workspace.Master;
                                                                if (!Aplicacion.Flotante)
                                                                        FormularioFacturaAnular.MdiParent = Aplicacion.FormularioPrincipal;
                                                                FormularioFacturaAnular.Show();
                                                                break;

                                                        case "RECIBO":
                                                                Lfc.Comprobantes.Recibos.Anular FormularioReciboAnular = new Lfc.Comprobantes.Recibos.Anular();
                                                                FormularioReciboAnular.Workspace = Lws.Workspace.Master;
                                                                FormularioReciboAnular.ShowDialog(Aplicacion.FormularioPrincipal);
                                                                break;
                                                }
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
                                                        Lfx.Types.LDateTime Fecha = Lfx.Types.Parsing.ParseDate(SubComandoCaja);
                                                        if (Fecha != null) {
                                                                FormularioCaja.m_Fechas = new Lfx.Types.DateRange("dia");
                                                                FormularioCaja.m_Fechas.From = Fecha;
                                                                FormularioCaja.m_Fechas.To = Fecha;
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
                                case "NC*":
                                case "ND":
                                case "ND*":
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
                                                        // Vuelvo a poner el token que quité del comando
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
                                }

                                if (ControlDestino != null) {
                                        ((Lui.Forms.EditForm)(TmpFormularioNuevo)).ControlDestino = ControlDestino;
                                }

                                return TmpFormularioNuevo;
                        }
                        catch (Exception ex) {
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw ex;
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
                                }

                                if (ControlDestino != null) {
                                        ((Lui.Forms.EditForm)(TmpFormularioNuevo)).ControlDestino = ControlDestino;
                                }

                                return TmpFormularioNuevo;
                        }
                        catch (Exception ex) {
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw ex;
                                return null;
                        }
                }

                public static void ThreadExceptionHandler(object sender, System.Threading.ThreadExceptionEventArgs e)
                {
                        GenericExceptionHandler(e.Exception);
                }

                private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs args)
                {
                        GenericExceptionHandler(args.ExceptionObject as Exception);
                        Application.Exit();
                }

                public static void GenericExceptionHandler(Exception ex)
                {
                        if (ex is System.Drawing.Printing.InvalidPrinterException) {
                                KnownExceptionHandler(ex);
                        } else if (ex.Source == "MySql.Data") {
                                Exception ex2 = ex;
                                bool Found = false;
                                while (ex2 != null) {
                                        if (string.Compare(ex2.Message,"Reading from the stream has failed.", true) == 0
                                                || string.Compare(ex2.Message, "Connection unexpectedly terminated.", true) == 0
                                                || string.Compare(ex2.Message, "Se ha forzado la interrupción de una conexión existente por el host remoto", true) == 0) {
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


                public static void KnownExceptionHandler(Exception ex)
                {
                        KnownExceptionHandler(ex, null);
                }

                /// <summary>
                /// Manejador de excepciones conocidas. Presenta una ventana con el error. Se utiliza para excepciones como InvalidPrinterException.
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
                public static void UnknownExceptionHandler(Exception ex)
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
                        Texto.AppendLine("Plataf. : " + Lfx.Environment.SystemInformation.Platform);
                        Texto.AppendLine("RunTime : " + Lfx.Environment.SystemInformation.RunTime);
                        Texto.AppendLine("Excepción no controlada: " + ex.ToString());
                        Texto.AppendLine("");

                        Texto.AppendLine("Lazaro versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").ProductVersion + " del " + new System.IO.FileInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                Texto.AppendLine(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
                        }

                        Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                Texto.AppendLine(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
                        }

                        Texto.AppendLine("Traza:");
                        Texto.AppendLine(ex.StackTrace);

                        MailMessage Mensaje = new MailMessage();
                        Mensaje.To.Add(new MailAddress("error@sistemalazaro.com.ar"));
                        Mensaje.From = new MailAddress(Lws.Workspace.Master.CurrentConfig.Company.Email, Lws.Workspace.Master.CurrentUser.CompleteName + " en " + Lws.Workspace.Master.CurrentConfig.Company.Name);
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