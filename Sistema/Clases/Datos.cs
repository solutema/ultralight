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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro
{
        public class Datos
        {
                const int VersionUltima = 23;

                /// <summary>
                /// Inicia una conexión con la base de datos y verifica si la versión de la la misma es la última disponible. En caso contrario la actualiza.
                /// </summary>
                /// <returns></returns>
                public static Lfx.Types.OperationResult Iniciar()
                {
                        Lfx.Types.OperationResult iniciarReturn = new Lfx.Types.SuccessOperationResult();

                        //Si el servidor SQL es esta misma PC, intento iniciar el servidor
                        if (Lfx.Environment.SystemInformation.Platform == Lfx.Environment.SystemInformation.Platforms.Windows && Lfx.Data.DataBaseCache.DefaultCache.ServerName.ToUpperInvariant() == "LOCALHOST") {
                                switch (Lfx.Data.DataBaseCache.DefaultCache.AccessMode) {
                                        case Lfx.Data.AccessModes.MyOdbc:
                                        case Lfx.Data.AccessModes.MySql:
                                                Lfx.Environment.Shell.Execute("net", "start mysql", ProcessWindowStyle.Hidden, true);
                                                break;
                                        case Lfx.Data.AccessModes.Npgsql:
                                                // FIXME: detectar el nombre del servicio.
                                                Lfx.Environment.Shell.Execute("net", "start postgresql-8.4", ProcessWindowStyle.Hidden, true);
                                                break;
                                }
                        }

                        try {
                                Lws.Workspace.Master.DefaultDataBase.Open();
                        } catch (Exception ex) {
                                return new Lfx.Types.FailureOperationResult(ex.Message);
                        }

                        // Verifico si tiene una base de datos
                        bool TieneDB = true;
                        try {
                                Lws.Workspace.Master.DefaultDataBase.FieldString("SELECT nombre FROM sys_config");
                        } catch (Exception ex) {
                                System.Console.WriteLine(ex.ToString());
                                TieneDB = false;
                        }

                        if (TieneDB == false) {
                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog(@"Aparentemente es la primera vez que conecta a este servidor. Antes de poder utilizarlo debe preparar el servidor con una carga inicial de datos.
Responda 'Si' sólamente si es la primera vez que utiliza el sistema Lázaro o está restaurando de una copia de seguridad.", @"¿Desea preparar el servidor """ + Lws.Workspace.Master.DefaultDataBase.ToString() + @"""?");
                                Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                                if (Pregunta.ShowDialog() == DialogResult.OK) {
                                        Lws.Data.DataView DataView = Lws.Workspace.Master.GetDataView(true);
                                        Lfx.Types.OperationResult Res = PrepararServidor(DataView);
                                        DataView.Dispose();
                                        if (Res.Success == false)
                                                return Res;
                                        else
                                                Lui.Forms.MessageBox.Show("El servidor fue preparado con éxito. Puede comenzar a utilizar el sistema.", "Preparar Servidor");
                                } else {
                                        return new Lfx.Types.FailureOperationResult("Debe preparar el servidor.");
                                }
                        }

                        // Configuro el nivel de aislación predeterminado
                        Lfx.Data.DataBaseCache.DefaultCache.DefaultIsolationLevel = (Lfx.Data.IsolationLevels)(Enum.Parse(typeof(Lfx.Data.IsolationLevels), Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString("Sistema", "Datos.Aislacion", "Serializable")));
                        
                        if (Lfx.Environment.SystemInformation.DesignMode == false) {
                                // Si es necesario, actualizo la estructura de la base de datos
                                Lws.Data.DataView DataViewVerif = Lws.Workspace.Master.GetDataView(true);
                                VerificarVersionDB(DataViewVerif, false, false);
                                DataViewVerif.Dispose();
                        }
                        return iniciarReturn;
                }


                /// <summary>
                /// Verifica la versión de la base de datos y si es necesario actualiza.
                /// </summary>
                /// <param name="dataView">Acceso a la base de datos.</param>
                /// <param name="ignorarFecha">Ignorar la fecha y actualizar siempre.</param>
                /// <param name="noTocarDatos">Actualizar sólo la estructura. No incorpora ni modifica datos.</param>
                public static void VerificarVersionDB(Lws.Data.DataView dataView, bool ignorarFecha, bool noTocarDatos)
                {
                        int VersionActual = dataView.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "DB.Version", 0);

                        if (VersionUltima < VersionActual) {
                                Lui.Forms.MessageBox.Show("Es necesario actualizar el sistema Lázaro en esta estación de trabajo. Se esperaba la versión " + VersionUltima.ToString() + " de la base de datos, pero se encontró la versión " + VersionActual.ToString() + " que es demasiado nueva.", "Aviso Importante");
                        } else if (noTocarDatos == false && VersionActual < VersionUltima && VersionActual > 0) {
                                //Actualizo desde la versión actual a la última
                                for (int i = VersionActual + 1; i <= VersionUltima; i++) {
                                        InyectarSqlDesdeRecurso(dataView, @"Data.db_upd" + i.ToString() + "_pre.sql");
                                }
                        }

                        DateTime VersionEstructura = Lfx.Types.Parsing.ParseSqlDateTime(Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString("Sistema", "DB.VersionEstructura", "2000-01-01 00:00:00"));
                        DateTime FechaLazaroExe = new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).LastWriteTime;
                        TimeSpan Diferencia = FechaLazaroExe - VersionEstructura;
                        System.Console.WriteLine("Versión estructura: " + VersionEstructura.ToString());
                        System.Console.WriteLine("Versión Lázaro    : " + FechaLazaroExe.ToString() + " (" + Diferencia.ToString() + " más nuevo)");
                        if (Diferencia.Days < -7 && ignorarFecha == false) {
                                //Lázaro es más viejo que la bd por al menos 7 días
                                Lui.Forms.MessageBox.Show("La versión de Lázaro que está utilizando es antigua. Por favor actualice su sistema urgentemente.", "Aviso");
                        } else if (ignorarFecha || Diferencia.Hours > 1) {
                                //Lázaro es más nuevo que la bd por al menos 1 hora
                                VerificarEstructuraDB(dataView, false);
                                if (noTocarDatos == false)
                                        Lws.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema", "DB.VersionEstructura", Lfx.Types.Formatting.FormatDateTimeSql(FechaLazaroExe));
                        }

                        if (noTocarDatos == false && VersionActual < VersionUltima && VersionActual > 0) {
                                for (int i = VersionActual + 1; i <= VersionUltima; i++) {
                                        InyectarSqlDesdeRecurso(dataView, @"Data.db_upd" + i.ToString() + "_post.sql");
                                        Lws.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema", "DB.Version", i.ToString(), "*");
                                }
                        }
                }

                private static void InyectarSqlDesdeRecurso(Lws.Data.DataView dataView, string archivo)
                {
                        //try {
                                System.IO.Stream RecursoActualizacion = Aplicacion.ObtenerRecurso(archivo);
                                if (RecursoActualizacion != null) {
                                        System.IO.StreamReader Lector = new System.IO.StreamReader(RecursoActualizacion, System.Text.Encoding.Default);
                                        string SqlActualizacion = dataView.DataBase.CustomizeSql(Lector.ReadToEnd());
                                        //dataView.DataBase.Execute(SqlActualizacion);
                                        do {
                                                string Comando = Datos.GetNextCommand(ref SqlActualizacion);
                                                try {
                                                        dataView.DataBase.Execute(Comando);
                                                } catch (Exception ex) {
                                                        if (Lfx.Environment.SystemInformation.DesignMode)
                                                                throw ex;
                                                        Aplicacion.GenericExceptionHandler(ex);
                                                }
                                        }
                                        while (SqlActualizacion.Length > 0);
                                        RecursoActualizacion.Close();
                                }
                        //} catch (Exception ex) {
                        //        if (Lfx.Environment.SystemInformation.DesignMode)
                        //                throw ex;
                        //        Aplicacion.GenericExceptionHandler(ex);
                        //}
                }

                /// <summary>
                /// Verifica la estructura de la base de datos actual y si es necesario modifica para que esté conforme
                /// al diseño de referencia.
                /// </summary>
                /// <param name="dataView">DataView mediante el cual se accede a la base de datos.</param>
                /// <param name="omitPreAndPostSql">Omitir la ejecución de comandos Pre- y Post-actualización de estructura. Esto es útil cuando se actualiza una estructura vacía, por ejemplo al crear una base de datos nueva.</param>
                private static void VerificarEstructuraDB(Lws.Data.DataView dataView, bool omitPreAndPostSql)
                {
                        Lui.Forms.ProgressForm Progreso = new Lui.Forms.ProgressForm();
                        Progreso.Style = ProgressBarStyle.Continuous;
                        Progreso.Titulo = "Verificando estructuras de datos";
                        Progreso.Show();

                        Progreso.Operacion = "Leyendo información de base de datos";

                        bool MustEnableConstraints = false;
                        if (dataView.DataBase.ConstraintsEnabled) {
                                dataView.DataBase.EnableConstraints(false);
                                MustEnableConstraints = true;
                        }

                        if (omitPreAndPostSql == false)
                                InyectarSqlDesdeRecurso(dataView, @"Data.db_upd_pre.sql");

                        //Primero borro claves foráneas (deleteOnly = true)
                        Progreso.Operacion = "Analizando estructura actual";
                        dataView.DataBase.SetConstraints(Lfx.Data.DataBaseCache.DefaultCache.Constraints, true);

                        Progreso.Max = Lfx.Data.DataBaseCache.DefaultCache.TableStructures.Count;
                        Progreso.Progreso = 0;
                        foreach (Lfx.Data.TableStructure Tab in Lfx.Data.DataBaseCache.DefaultCache.TableStructures.Values) {
                                Progreso.Operacion = "Actualizando " + Tab.Name;
                                dataView.DataBase.SetTableStructure(Tab);
                                Progreso.Progreso++;
                        }

                        //Ahora creo claves nuevas (deleteOnly = false)
                        Progreso.Operacion = "Creando claves foráneas";
                        dataView.DataBase.SetConstraints(Lfx.Data.DataBaseCache.DefaultCache.Constraints, false);

                        if (omitPreAndPostSql == false)
                                InyectarSqlDesdeRecurso(dataView, @"Data.db_upd_post.sql");

                        Progreso.Operacion = "Guardando modificaciones";
                        if (MustEnableConstraints)
                                dataView.DataBase.EnableConstraints(true);

                        Progreso.Dispose();
                }

                /// <summary>
                /// Prepara un servidor para ser utilizado por Lázaro. Crea estructuras y realiza una carga inicial de datos.
                /// </summary>
                /// <param name="dataView">Acceso a la base de datos.</param>
                public static Lfx.Types.OperationResult PrepararServidor(Lws.Data.DataView dataView)
                {
                        Lui.Forms.ProgressForm OProgreso = new Lui.Forms.ProgressForm();
                        OProgreso.Titulo = "Preparando Servidor...";
                        OProgreso.Texto = "Este proceso puede demorar varios minutos dependiendo de la velocidad de su servidor.";
                        OProgreso.Operacion = "Creando estructura...";
                        OProgreso.Show();

                        // Creación de tablas
                        VerificarEstructuraDB(dataView, true);

                        dataView.DataBase.EnableConstraints(false);

                        System.IO.Stream RecursoSql = null;
                        System.IO.StreamReader Lector = null;
                        string Sql = "";

                        // Carga inicial de datos
                        RecursoSql = Aplicacion.ObtenerRecurso(@"Data.dbdata.sql");
                        Lector = new System.IO.StreamReader(RecursoSql, System.Text.Encoding.UTF8);
                        Sql = dataView.DataBase.CustomizeSql(Lector.ReadToEnd());
                        Lector.Close();
                        RecursoSql.Close();

                        // Si hay archivos adicionales de datos para la carga inicial, los incluyo
                        // Estos suelen tener datos personalizados de esta instalación en partícular
                        if (System.IO.File.Exists(Lfx.Environment.Folders.ApplicationFolder + "default.alf")) {
                                Lector = new System.IO.StreamReader(Lfx.Environment.Folders.ApplicationFolder + "default.alf", System.Text.Encoding.UTF8);
                                Sql += Lfx.Types.ControlChars.CrLf;
                                Sql += dataView.DataBase.CustomizeSql(Lector.ReadToEnd());
                                Lector.Close();
                        }

                        OProgreso.Operacion = "Carga inicial de datos...";
                        OProgreso.Max = Sql.Length;
                        do {
                                string Comando = Datos.GetNextCommand(ref Sql);
                                dataView.DataBase.Execute(Comando);
                                OProgreso.Progreso = OProgreso.Max - Sql.Length;
                        }
                        while (Sql.Length > 0);

                        // Cargar TagList y volver a verificar la estructura
                        Lfx.Data.DataBaseCache.DefaultCache.TagList.Clear();
                        Lfx.Data.DataBaseCache.DefaultCache.CargarEstructuraDesdeXml(null);
                        VerificarEstructuraDB(dataView, false);

                        dataView.DataBase.EnableConstraints(true);
                        Lws.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema", "DB.Version", VersionUltima.ToString(), "*");
                        OProgreso.Dispose();
                        return new Lfx.Types.SuccessOperationResult();
                }

                /// <summary>
                /// Obtiene el primer comando SQL en una lista separada por punto y coma. Elimina el comando de la lista.
                /// </summary>
                /// <param name="Comandos">La lista de comandos.</param>
                /// <returns>El primer comando de la lista.</returns>
                public static string GetNextCommand(ref string Comandos)
                {
                        if (Comandos != null && Comandos.Length == 0)
                                return "";

                        if (Comandos.Substring(Comandos.Length - 1, 1) != ";")
                                Comandos += ";";

                        char[] Caracteres = { '\'', Lfx.Types.ControlChars.Quote, ';', '\\' };
                        char Comilla = ' ';
                        int r = 0;
                        do {
                                r = Comandos.IndexOfAny(Caracteres, r);
                                switch (Comandos[r]) {
                                        case '\\':
                                                r++;
                                                break;
                                        case ';':
                                                if (Comilla == ' ') {
                                                        string Resultado = Comandos.Substring(0, r);
                                                        Comandos = Comandos.Substring(r + 1, Comandos.Length - (r + 1));
                                                        return Resultado;
                                                }
                                                break;
                                        case '\'':
                                                if (Comilla == Lfx.Types.ControlChars.Quote) {
                                                        // Nada
                                                } else if (Comandos.Length > r && Comandos[r + 1] == '\'') {
                                                        // Comilla escapeada. Ignoro
                                                        r++;
                                                } else if (Comilla == '\'') {
                                                        Comilla = ' ';
                                                } else {
                                                        Comilla = '\'';
                                                }
                                                break;
                                        case Lfx.Types.ControlChars.Quote:
                                                if (Comilla == '\'') {
                                                        // Nada
                                                } else if (Comilla == Lfx.Types.ControlChars.Quote) {
                                                        Comilla = ' ';
                                                } else {
                                                        Comilla = Lfx.Types.ControlChars.Quote;
                                                }
                                                break;
                                }

                                r++;
                        }
                        while (true);
                }
        }
}