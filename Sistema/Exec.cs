#region License
// Copyright 2004-2012 Ernesto N. Carrea
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

namespace Lazaro.WinMain
{
        public static class Ejecutor
        {
                /// <summary>
                /// Ejecuta un comando. Se trata de un pequeño lenguaje de scripting de Lázaro.
                /// </summary>
                /// <param name="comando">El comando a ejecutar, puede ser una tarea o una cadena.</param>
                /// <returns>Normalmente devuelve un formulario, que es el resultado del comando.
                /// Por ejemplo, el comando "EDITAR Lbl.Articulos.Articulo 132" devuelve un formulario donde se está editando el artículo código 132.
                /// También puede devolver otras cosas, como un Lfx.Types.OperationResult.
                /// </returns>
                public static object Exec(object param)
                {
                        return Exec(param, null);
                }


                public static object Exec(object param, string estacion)
                {
                        object Res;
                        
                        if (param is Lfx.Services.Task) {
                                Lfx.Services.Task Tsk = param as Lfx.Services.Task;
                                Res = ExecInternal(Tsk.Command, Tsk.CreatorComputerName);
                        } else {
                                Res = ExecInternal(param.ToString(), null);
                        }

                        if (Res != null && Aplicacion.FormularioPrincipal != null && Aplicacion.FormularioPrincipal.Visible)
                                Aplicacion.FormularioPrincipal.ProcesarObjeto(Res);

                        return Res;
                }


                private static object ExecInternal(string comando, string estacion)
                {
                        Console.WriteLine("Exec:" + comando);

                        if (estacion == null || estacion.Length == 0)
                                estacion = Lfx.Environment.SystemInformation.MachineName;

                        string SubComando = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpperInvariant();

                        switch (SubComando) {
                                case "CREAR":
                                case "CREATE":
                                        return ExecCrearEditar(true, comando);

                                case "EDITAR":
                                case "EDIT":
                                        return ExecCrearEditar(false, comando);

                                case "LISTAR":
                                case "LIST":
                                        return ExecListar(comando);

                                case "IMPRIMIR":
                                        return ExecImprimir(comando);

                                case "INSTANCIAR":
                                        return ExecInstanciar(comando);

                                /* case "REPO":
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
                                        Rep.Fields.Add(new Lazaro.Pres.Field("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 320));
                                        Rep.Fields.Add(new Lazaro.Pres.Field("comprob.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 100));
                                        Rep.Fields.Add(new Lazaro.Pres.Field("comprob.total", "Total", Lfx.Data.InputFieldTypes.Currency, 120));
                                        Rep.ExpandGroups = false;

                                        Lfc.Reportes.Reporte RepForm = new Lfc.Reportes.Reporte();
                                        RepForm.MdiParent = Aplicacion.FormularioPrincipal;
                                        RepForm.ReporteAMostrar = Rep;
                                        RepForm.Show();
                                        break; */

                                case "LIC":
                                        Lfx.Lic.Licenciar(@"..\..\");
                                        Lfx.Lic.Licenciar(@"..\..\..\Componentes\RunComponent");
                                        Lfx.Lic.Licenciar(@"..\..\..\Componentes\ServidorFiscal");
                                        Lfx.Lic.Licenciar(@"..\..\..\Lfx");
                                        Lfx.Lic.Licenciar(@"..\..\..\Lbl");
                                        Lfx.Lic.Licenciar(@"..\..\..\Lui");
                                        Lfx.Lic.Licenciar(@"..\..\..\Lcc");
                                        Lfx.Lic.Licenciar(@"..\..\..\Lfc");
                                        Lfx.Lic.Licenciar(@"..\..\..\Impresion");
                                        Lfx.Lic.Licenciar(@"..\..\..\Pres");
                                        Lfx.Lic.Licenciar(@"..\..\..\Actualizador");
                                        break;

                                case "HISTORIAL":
                                        string Tabla = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();
                                        int Id = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " "));
                                        Lfc.Log.Editar His = new Lfc.Log.Editar();
                                        His.MdiParent = Aplicacion.FormularioPrincipal;
                                        His.Mostrar(Tabla, Id);
                                        His.Show();
                                        break;

                                case "VENTRE":
                                        Lfx.Data.Connection ConexionFiltro = Lfx.Workspace.Master.GetNewConnection("Importar datos");

                                        string Opciones = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpperInvariant();
                                        Lbl.Servicios.Importar.Opciones OpcionesFiltro = new Lbl.Servicios.Importar.Opciones();
                                        OpcionesFiltro.ImportarClientes = Opciones.IndexOf('C') >= 0;
                                        OpcionesFiltro.ImportarArticulos = Opciones.IndexOf('A') >= 0;
                                        OpcionesFiltro.ImportarFacturas = Opciones.IndexOf('F') >= 0;
                                        OpcionesFiltro.ImportarCtasCtes = Opciones.IndexOf('E') >= 0;

                                        OpcionesFiltro.ActualizarRegistros = SubComando.IndexOf('+') >= 0;

                                        Lbl.Servicios.Importar.FiltroEscorpion Fil = new Lbl.Servicios.Importar.FiltroEscorpion(ConexionFiltro, OpcionesFiltro);
                                        Fil.Dsn = "ventre";

                                        System.Threading.ThreadStart ThreadFiltro = delegate { Fil.Importar(); };
                                        System.Threading.Thread Thr = new System.Threading.Thread(ThreadFiltro);
                                        Thr.IsBackground = true;
                                        Thr.Start();
                                        
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
                                                        System.Threading.ThreadStart ThreadVerif = delegate { Lfx.Workspace.Master.CheckAndUpdateDataBaseVersion(true, false); };
                                                        System.Threading.Thread ThrVerif = new System.Threading.Thread(ThreadVerif);
                                                        ThrVerif.IsBackground = true;
                                                        ThrVerif.Start();
                                                        break;
                                        }
                                        break;

                                case "VER":
                                        Lazaro.WinMain.Misc.AcercaDe OAcercaDe = new Lazaro.WinMain.Misc.AcercaDe();
                                        OAcercaDe.ShowDialog();
                                        break;

                                case "REBOOT":
                                        try {
                                                int EstacionFiscal = Lfx.Workspace.Master.MasterConnection.FieldInt("SELECT id_pv FROM pvs WHERE estacion='" + Lfx.Environment.SystemInformation.MachineName + "' AND tipo=2 AND id_sucursal=" + Lfx.Workspace.Master.CurrentConfig.Empresa.SucursalActual.ToString());
                                                if (EstacionFiscal > 0) {
                                                        Lfx.Workspace.Master.DefaultScheduler.AddTask("REBOOT", "fiscal" + EstacionFiscal);
                                                        System.Threading.Thread.Sleep(100);
                                                }
                                        } catch {
                                                // Nada
                                        }

                                        Lfx.Environment.Shell.Reboot();
                                        break;

                                case "CALC":
                                        Lazaro.WinMain.Misc.Calculadora OCalc = new Lazaro.WinMain.Misc.Calculadora();
                                        OCalc.Show();
                                        break;

                                case "BACKUP":
                                        if (Lui.LogOn.LogOnData.ValidateAccess("Global.Backup", Lbl.Sys.Permisos.Operaciones.Administrar)) {
                                                string SubComandoBackup = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();
                                                switch (SubComandoBackup) {
                                                        case "MANAGER":
                                                                WinMain.Backup.Manager FormBackup = (WinMain.Backup.Manager)BuscarVentana("WinMain.Misc.Backup.Manager");
                                                                if (FormBackup == null)
                                                                        FormBackup = new WinMain.Backup.Manager();
                                                                FormBackup.MdiParent = Aplicacion.FormularioPrincipal;
                                                                FormBackup.Show();
                                                                break;

                                                        case "NOW":
                                                                Lfx.Backups.BackupInfo Bkp = new Lfx.Backups.BackupInfo();
                                                                Bkp.Name = System.DateTime.Now.ToString(Lfx.Types.Formatting.DateTime.LongDatePattern + @" ""a las"" HH.mm.ss");
                                                                Bkp.CompanyName = Lbl.Sys.Config.Empresa.Nombre;
                                                                Bkp.UserName = Lbl.Sys.Config.Actual.UsuarioConectado.Persona.Nombre;
                                                                Bkp.ProgramVersion = Aplicacion.Version() + " del " + Aplicacion.BuildDate();

                                                                Lfx.Backups.Manager BackupManager = new Lfx.Backups.Manager();
                                                                BackupManager.BackupPath = System.IO.Path.Combine(Lbl.Sys.Config.CarpetaEmpresa, "Copias de seguridad" + System.IO.Path.DirectorySeparatorChar);
                                                                BackupManager.StartBackup(Bkp);
                                                                break;
                                                }
                                        }
                                        break;

                                case "CONFIG":
                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TieneAccesoGlobal()) {
                                                Config.Preferencias FormConfig = new Config.Preferencias();
                                                FormConfig.ShowDialog(Aplicacion.FormularioPrincipal);
                                        } else {
                                                Lfx.Workspace.Master.RunTime.Toast("No tiene permiso para cambiar las preferencias del programa.", "Error");
                                        }
                                        break;

                                case "CHANGEPWD":
                                        Misc.CambioContrasena FormCambio = new Misc.CambioContrasena();
                                        FormCambio.ShowDialog();
                                        break;

                                case "FISCAL":
                                        string SubComandoFiscal = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpper();

                                        switch (SubComandoFiscal) {
                                                case "INICIAR":
                                                        Lfx.Environment.Shell.Execute(Lfx.Environment.Folders.ApplicationFolder + "ServidorFiscal.exe", null, System.Diagnostics.ProcessWindowStyle.Normal, false);
                                                        break;
                                                case "PANEL":
                                                        Lazaro.WinMain.Misc.Fiscal OFormFiscal = (Lazaro.WinMain.Misc.Fiscal)BuscarVentana("Lazaro.Misc.Fiscal");
                                                        if (OFormFiscal == null)
                                                                OFormFiscal = new Lazaro.WinMain.Misc.Fiscal();
                                                        OFormFiscal.ShowDialog();
                                                        break;
                                        }
                                        break;

                                case "MENSAJE":
                                case "MESSAGE":
                                        Lfx.Workspace.Master.RunTime.Toast(comando, "Mensaje remoto de " + estacion);
                                        return null;

                                case "RUN":
                                        string NombreComponente = Lfx.Types.Strings.GetNextToken(ref comando, ".").Trim();
                                        string NombreFuncion = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();

                                        if (Lfx.Components.Manager.ComponentesCargados.ContainsKey(NombreComponente) == false)
                                                NombreComponente += "." + Lfx.Types.Strings.GetNextToken(ref NombreFuncion, ".").Trim();

                                        if (Lfx.Components.Manager.ComponentesCargados.ContainsKey(NombreComponente) == false) {
                                                return new Lfx.Types.FailureOperationResult("No se encuentra el componente " + NombreComponente);
                                        } else {
                                                Lfx.Components.IComponent Componente = Lfx.Components.Manager.ComponentesCargados[NombreComponente];
                                                if (Componente.Funciones.ContainsKey(NombreFuncion) == false) {
                                                        return new Lfx.Types.FailureOperationResult("No se encuentra el la función " + NombreComponente + "." + NombreFuncion);
                                                } else {
                                                        Lfx.Components.FunctionInfo Funcion = Componente.Funciones[NombreFuncion];
                                                        object RunResult = Funcion.Run();

                                                        if (RunResult is System.Windows.Forms.Form) {
                                                                if (Funcion.Instancia.FunctionType == Lfx.Components.FunctionTypes.MdiChildren)
                                                                        ((System.Windows.Forms.Form)(RunResult)).MdiParent = Aplicacion.Flotante ? null : Aplicacion.FormularioPrincipal;
                                                                ((System.Windows.Forms.Form)(RunResult)).Show();
                                                        } else if (RunResult is Lfx.Types.OperationResult) {
                                                                Lfx.Types.OperationResult OpeResult = RunResult as Lfx.Types.OperationResult;
                                                                if (OpeResult.Message != null && OpeResult.Message.Length > 0)
                                                                        Lfx.Workspace.Master.RunTime.Toast(OpeResult.Message, OpeResult.Success ? "Aviso" : "Error");
                                                        }

                                                }
                                        }
                                        break;

                                case "QUIT":
                                        if (Aplicacion.FormularioPrincipal != null)
                                                Aplicacion.FormularioPrincipal.Close();
                                        System.Threading.Thread.Sleep(200);
                                        Lfx.Workspace.Master.Dispose();
                                        System.Environment.Exit(0);
                                        break;

                                case "ERROR":
                                        throw new Exception("Error de prueba.");

                                default:
                                        if (Lfx.Workspace.Master.DebugMode)
                                                throw new NotImplementedException(comando);
                                        else
                                                return new Lfx.Types.OperationResult(false);
                        }

                        return null;
                }


                private static object ExecInstanciar(string comando)
                {
                        string SubComando = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();

                        string Prefijo = Lfx.Types.Strings.GetNextToken(ref SubComando, ".").Trim();
                        
                        if (Lfx.Components.Manager.ComponentesCargados.ContainsKey(Prefijo) == false)
                                // Intento cargar una segunda parte del prefijo (P. Ej. Lazaro.Mensajeria)
                                Prefijo += "." + Lfx.Types.Strings.GetNextToken(ref SubComando, ".").Trim();

                        if (Lfx.Components.Manager.ComponentesCargados.ContainsKey(Prefijo) == false)
                                return new Lfx.Types.FailureOperationResult("No se reconoce el prefijo " + Prefijo);

                        Lfx.Components.IComponent Comp = Lfx.Components.Manager.ComponentesCargados[Prefijo];
                        Type Tipo = Comp.Assembly.GetType(Prefijo + "." + SubComando);

                        object Res = null;

                        if (comando != null && comando.Length > 0) {
                                try {
                                        // Intento pasarle los parámetros
                                        Res = System.Activator.CreateInstance(Tipo, comando);
                                } catch {
                                        // Si no funciona, intento llamar sin parámetros
                                        Res = System.Activator.CreateInstance(Tipo);
                                }
                        } else {
                                Res = System.Activator.CreateInstance(Tipo);
                        }

                        return Res;
                }


                private static object ExecImprimir(string comando)
                {
                        string SubComandoImprimir = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();

                        switch (SubComandoImprimir.ToUpperInvariant()) {
                                case "COMPROBANTE":
                                case "COMPROB":
                                        int IdComprobante = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " "));

                                        Lfx.Types.OperationResult ResultadoImpresion;

                                        using (Lfx.Data.Connection DataBaseImprimir = Lfx.Workspace.Master.GetNewConnection("Imprimir comprobante"))
                                        using (System.Data.IDbTransaction Trans = DataBaseImprimir.BeginTransaction()) {
                                                Lbl.Comprobantes.ComprobanteConArticulos Comprob = new Lbl.Comprobantes.ComprobanteConArticulos(DataBaseImprimir, IdComprobante);
                                                Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos Impresor = new Impresion.Comprobantes.ImpresorComprobanteConArticulos(Comprob, Trans);
                                                ResultadoImpresion = Impresor.Imprimir();
                                                if (ResultadoImpresion.Success)
                                                        Trans.Commit();
                                                else
                                                        Trans.Rollback();
                                        }

                                        return ResultadoImpresion;
                                default:
                                        int itemId = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim());
                                        Type TipoElem = Lbl.Instanciador.InferirTipo(SubComandoImprimir);
                                        if (TipoElem != null && itemId > 0) {
                                                using (Lfx.Data.Connection DbImprimir = Lfx.Workspace.Master.GetNewConnection("Imprimir " + TipoElem.ToString() + " " + itemId.ToString())) {
                                                        Lbl.IElementoDeDatos Elem = Lbl.Instanciador.Instanciar(TipoElem, DbImprimir, itemId);
                                                        Lfx.Types.OperationResult Res;
                                                        using (System.Data.IDbTransaction Trans = DbImprimir.BeginTransaction()) {
                                                                Lazaro.Impresion.ImpresorElemento Impresor = Lazaro.Impresion.Instanciador.InstanciarImpresor(Elem, Trans);

                                                                string ImprimirEn = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim().ToUpperInvariant();
                                                                if (ImprimirEn == "EN") {
                                                                        // El nombre de la impresora es lo que resta del comando
                                                                        // No lo puedo separar con GetNextToken porque puede contener espacios
                                                                        string NombreImpresora = comando;
                                                                        Impresor.Impresora = Lbl.Impresion.Impresora.InstanciarImpresoraLocal(DbImprimir, NombreImpresora);
                                                                }

                                                                Res = Impresor.Imprimir();
                                                                if (Res.Success) {
                                                                        Trans.Commit();
                                                                } else {
                                                                        Trans.Rollback();
                                                                }
                                                        }
                                                        return Res;
                                                }
                                        }
                                        break;
                        }

                        return null;
                }


                private static object ExecListar(string comando)
                {
                        string SubComandoListado = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();
                        Lfc.FormularioListado FormularioListado = null;

                        Type TipoLbl = Lbl.Instanciador.InferirTipo(SubComandoListado);
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(TipoLbl, Lbl.Sys.Permisos.Operaciones.Listar)) {
                                Type TipoListado = Lfc.Instanciador.InferirFormularioListado(TipoLbl);
                                if (TipoListado == null)
                                        throw new NotImplementedException("LISTAR " + SubComandoListado);
                                else
                                        FormularioListado = Lfc.Instanciador.InstanciarFormularioListado(TipoListado, comando.Length > 0 ? comando : null);
                        } else {
                                return new Lfx.Types.NoAccessOperationResult();
                        }

                        return FormularioListado;
                }


                private static object ExecCrearEditar(bool crear, string comando)
                {
                        string SubComando = Lfx.Types.Strings.GetNextToken(ref comando, " ").Trim();

                        System.Type TipoLbl = Lbl.Instanciador.InferirTipo(SubComando);
                        Lbl.Atributos.Nomenclatura AtrNombre = TipoLbl.GetAttribute<Lbl.Atributos.Nomenclatura>();

                        if (crear && Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(TipoLbl, Lbl.Sys.Permisos.Operaciones.Crear) == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(TipoLbl, Lbl.Sys.Permisos.Operaciones.Ver) == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        Lfx.Data.Connection DataBase = Lfx.Workspace.Master.GetNewConnection("Editar " + (AtrNombre == null ? SubComando : AtrNombre.NombreSingular));
                        Lbl.IElementoDeDatos Elemento = null;
                        if (crear) {
                                Elemento = Lbl.Instanciador.Instanciar(TipoLbl, DataBase);
                                Elemento.Crear();
                        } else {
                                int ItemId = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref comando, " "));
                                Elemento = Lbl.Instanciador.Instanciar(TipoLbl, DataBase, ItemId);
                        }

                        Lfc.FormularioEdicion FormularioDeEdicion = Lfc.Instanciador.InstanciarFormularioEdicion(Elemento);
                        FormularioDeEdicion.DisposeConnection = true;

                        if (FormularioDeEdicion == null)
                                return null;

                        return FormularioDeEdicion;
                }


                /// <summary>
                /// Busca una ventana por nombre entre los MDI children del formulario principal
                /// </summary>
                /// <param name="nombre">El nombre de la ventana a buscar.</param>
                /// <returns>Una referencia a la ventana, o null si no se encontró.</returns>
                private static System.Windows.Forms.Form BuscarVentana(string nombre)
                {
                        foreach (System.Windows.Forms.Form TmpForm in Aplicacion.FormularioPrincipal.MdiChildren) {
                                if (TmpForm.Name == nombre) {
                                        return TmpForm;
                                }
                        }

                        return null;
                }
        }
}
