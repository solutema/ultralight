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

using System.Text.RegularExpressions;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.Misc.Backup
{
	public class Services
	{

		private static string m_BackupPath;

		public static string DefaultBackupPath()
		{
			return Lfx.Environment.Folders.ApplicationDataFolder + "Backup" + System.IO.Path.DirectorySeparatorChar;
		}


		public static string BackupPath
		{
			get
			{
				if(m_BackupPath == null) {
					return DefaultBackupPath();
				} else {
					return m_BackupPath;
				}
			}
			set
			{
				m_BackupPath = value;
			}
		}

		public static void ExportBlobs(Lfx.Data.SqlSelectBuilder ComandoSelect, string Carpeta)
		{
			if(char.Parse(Carpeta.Substring(Carpeta.Length - 1, 1)) != System.IO.Path.DirectorySeparatorChar)
				Carpeta += System.Convert.ToString(System.IO.Path.DirectorySeparatorChar);

			System.Data.DataTable Tabla = Lws.Workspace.Master.DefaultDataBase.Select(ComandoSelect.ToString());
			foreach(System.Data.DataRow Registro in Tabla.Rows) {
				foreach(System.Data.DataColumn Campo in Tabla.Columns) {
					if(Campo.DataType.Name == "Byte[]" && Registro[Campo.ColumnName] != DBNull.Value && ((byte[])(Registro[Campo.ColumnName])).Length > 5) {
						byte[] Contenido = ((byte[])(Registro[Campo.ColumnName]));
						string NombreArchivo = ComandoSelect.Tables + "_" + Campo.ColumnName + "_" + Registro[0].ToString() + ".blb";
						System.IO.FileStream Archivo = new System.IO.FileStream(Carpeta + NombreArchivo, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
						Archivo.Write(Contenido, 0, Contenido.Length);
						Archivo.Close();

						Archivo = new System.IO.FileStream(Carpeta + "blobs.lst", System.IO.FileMode.Append, System.IO.FileAccess.Write);
						System.IO.StreamWriter Escribidor = new System.IO.StreamWriter(Archivo);
						Escribidor.WriteLine(ComandoSelect.Tables + "," + Campo.ColumnName + "," + Tabla.Columns[0].ColumnName + "='" + Registro[0].ToString() + "'," + NombreArchivo);
						Escribidor.Close();
						Archivo.Close();
					}
				}
			}
		}

                
                /// <summary>
                /// Nueva rutina para exportar una tabla a un formato binario propietario, incluyendo BLOBs.
                /// </summary>
                public static void ExportTableBin(Lfx.Data.SqlSelectBuilder Comando, bool ExportarBlobs, System.IO.StreamWriter writer)
                {
                        System.Data.IDataReader Tabla = Lws.Workspace.Master.DefaultDataBase.GetReader(Comando.ToString());
                        while (Tabla.Read()) {

                        }
                        Tabla.Close();
                }

		public static void ExportTable(Lfx.Data.SqlSelectBuilder Comando, bool ExportarBlobs, System.IO.StreamWriter writer)
		{
			System.Data.DataTable Tabla = Lws.Workspace.Master.DefaultDataBase.Select(Comando);

			string NombresCampos = null;
			// Hago un dump de los campos
			foreach(System.Data.DataColumn Campo in Tabla.Columns) {
				if(NombresCampos == null)
					NombresCampos = Campo.ColumnName;
				else
					NombresCampos += ", " + Campo.ColumnName;
			}

			foreach(System.Data.DataRow Registro in Tabla.Rows) {
				string Valores = "";
				foreach(System.Data.DataColumn Campo in Tabla.Columns) {
					string Valor = "";
					if(Registro[Campo.ColumnName] == DBNull.Value) {
						Valor = "NULL";
					} else {
						switch(Campo.DataType.Name) {
							case "Byte[]":
								if(ExportarBlobs) {
									//TODO: exportar BLOBS
								} else {
									Valor = "NULL";
								}
								break;
							case "Byte":
							case "Int16":
							case "Int32":
							case "Int64":
								Valor = Registro[Campo.ColumnName].ToString();
								break;
							case "Decimal":
							case "Single":
							case "Double":
								Valor = System.Convert.ToDouble(Registro[Campo.ColumnName]).ToString(System.Globalization.CultureInfo.InvariantCulture);
								break;
							case "DateTime":
								Valor = "'" + Lfx.Types.Formatting.FormatDateTimeSql(System.Convert.ToDateTime(Registro[Campo.ColumnName])) + "'";
								break;
							case "String":
								Valor = "'" + Lws.Workspace.Master.DefaultDataBase.EscapeString(System.Convert.ToString(Registro[Campo.ColumnName])).Replace("\r", @"\r").Replace("\n", @"\n") + "'";
								break;
							default:
								MessageBox.Show(Campo.DataType.Name);
								Valor = "'" + Lws.Workspace.Master.DefaultDataBase.EscapeString(Registro[Campo.ColumnName].ToString()) + "'";
								break;
						}
					}
					//Quito el primer ", "
					Valores += ", " + Valor;
				}
				Valores = Valores.Substring(2, Valores.Length - 2);
                                writer.WriteLine("$INSERTORREPLACE$ " + Comando.Tables + " (" + NombresCampos + ") VALUES (" + Valores + ")" + ";");
			}
                        writer.WriteLine("");
                        writer.WriteLine("");
			return;
		}

		public static Lfx.Types.OperationResult CreateBackup(string Carpeta)
		{
			return CreateBackup(Carpeta, BackupPath);
		}

		public static Lfx.Types.OperationResult CreateBackup(string workFolder, string storeFolder)
		{
                        Lfx.Environment.Folders.EnsurePathExists(BackupPath);

			if(!System.IO.Directory.Exists(Lfx.Environment.Folders.TemporaryFolder + workFolder))
				System.IO.Directory.CreateDirectory(Lfx.Environment.Folders.TemporaryFolder + workFolder);

			if(char.Parse(workFolder.Substring(workFolder.Length - 1, 1)) != System.IO.Path.DirectorySeparatorChar)
				workFolder += System.Convert.ToString(System.IO.Path.DirectorySeparatorChar);

			Lui.Forms.ProgressForm OProgreso = new Lui.Forms.ProgressForm();
			OProgreso.Titulo = "Creando Copia de Respaldo";
			OProgreso.Texto = "Este proceso puede demorar varios minutos.";
			OProgreso.ProgressBar.Style = ProgressBarStyle.Continuous;
			OProgreso.Progreso = 0;
			OProgreso.Show();

			OProgreso.Operacion = "Exportando estructura...";
			System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
			doc.AppendChild(Lws.Workspace.Master.DefaultDataBase.GetXmlStructure(doc));
			doc.Save(Lfx.Environment.Folders.TemporaryFolder + workFolder + "dbstruct.xml");

			/*
			if (Lws.Workspace.Master.DefaultDataBase.AccessMode == Lfx.Data.AccessModes.MySql && System.IO.File.Exists(Lfx.Environment.Folders.ApplicationFolder + "mysqldump.exe"))
			{
			    //Si es un servidor MySql y tengo mysqldump.exe, lo uso
			    OProgreso.Operacion = "Volcado completo...";
			    MySqlDump(workFolder);
			}
			else
			{
			    //De lo contrario, el viejo volcado manual
			    OProgreso.Operacion = "Volcado manual...";
			    ManualDump(workFolder);
			}
			*/

			OProgreso.Operacion = "Volcado manual...";
			ManualDump(workFolder);

			System.IO.FileStream Archivo = new System.IO.FileStream(Lfx.Environment.Folders.TemporaryFolder + workFolder + "info.txt", System.IO.FileMode.Append, System.IO.FileAccess.Write);
			System.IO.StreamWriter Escribidor = new System.IO.StreamWriter(Archivo, System.Text.Encoding.Default);
			Escribidor.WriteLine("Copia de seguridad del sistema Lázaro");
			Escribidor.WriteLine("");
			Escribidor.WriteLine("Empresa=" + Lws.Workspace.Master.CurrentConfig.Company.Name);
			Escribidor.WriteLine("EspacioTrabajo=" + Lws.Workspace.Master.Name);
			Escribidor.WriteLine("FechaYHora=" + System.DateTime.Now.ToString("dd-MM-yyyy") + " a las " + System.DateTime.Now.ToString("HH:mm:ss"));
			Escribidor.WriteLine("Usuario=" + Lws.Workspace.Master.CurrentUser.UserCompleteName);
			Escribidor.WriteLine("Estación=" + Lfx.Environment.SystemInformation.ComputerName);
			Escribidor.WriteLine("Versión Aplic=" + Aplicacion.Version() + " del " + Aplicacion.BuildDate());
			Escribidor.WriteLine("");
			Escribidor.WriteLine("Por favor no modifique ni elimine este archivo.");
			Escribidor.Close();
			Archivo.Close();

			OProgreso.Operacion = "Comprimiendo los datos...";
			Lfx.FileFormats.Compression.Archive ArchivoComprimido = new Lfx.FileFormats.Compression.Archive(Lfx.Environment.Folders.TemporaryFolder + workFolder + "backup.7z");
			ArchivoComprimido.Add(Lfx.Environment.Folders.TemporaryFolder + workFolder + "*");
			if(System.IO.File.Exists(Lfx.Environment.Folders.TemporaryFolder + workFolder + "backup.7z")) {
				OProgreso.Operacion = "Eliminando archivos temporales...";
				// Borrar los archivos que acabo de comprimir
				System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.TemporaryFolder + workFolder);
				foreach(System.IO.FileInfo DirItem in Dir.GetFiles()) {
					if(DirItem.Name != "backup.7z" && DirItem.Name != "info.txt") {
						System.IO.File.Delete(Lfx.Environment.Folders.TemporaryFolder + workFolder + DirItem.Name);
					}
				}
			}

			OProgreso.Operacion = "Almacenando...";
			OProgreso.Progreso++;
			System.IO.Directory.Move(Lfx.Environment.Folders.TemporaryFolder + workFolder, storeFolder + workFolder);

			int GuardarBackups = Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingInt("", "Sisteam.Backup.CantMax", 7);
			if(GuardarBackups > 0) {
				System.Collections.ArrayList ListaDeBackups = ListaBackups();
				if(ListaDeBackups.Count > GuardarBackups) {
					OProgreso.Operacion = "Eliminando copias de respaldo antiguas...";
					System.Windows.Forms.Application.DoEvents();
					int BorrarBackups = ListaDeBackups.Count - GuardarBackups;
					if(BorrarBackups < ListaDeBackups.Count) {
						for(int i = 1; i <= BorrarBackups; i++) {
							DeleteBackup(BackupMasViejo());
						}
					}
				}
			}

			OProgreso.Dispose();
			return new Lfx.Types.SuccessOperationResult();
		}

		private static void MySqlDump(string workFolder)
		{
			string Arguments = "--compatible=ansi --complete-insert --force --ignore-table=%.sys_asl --no-create-info --single-transaction --hex-blob";
                        Arguments += " --host=" + Lfx.Data.DataBaseCache.DefaultCache.ServerName;
                        Arguments += " -u " + Lfx.Data.DataBaseCache.DefaultCache.UserName;
                        if (Lfx.Data.DataBaseCache.DefaultCache.Password.Length > 0)
                                Arguments += " --password=" + Lfx.Data.DataBaseCache.DefaultCache.Password;
			Arguments += " --result-file=\"" + Lfx.Environment.Folders.TemporaryFolder + workFolder + "tablas.sql\"";
			Arguments += " " + Lws.Workspace.Master.DefaultDataBase.DataBaseName;
			Lfx.Environment.Shell.Execute(Lfx.Environment.Folders.ApplicationFolder + "mysqldump.exe", Arguments, ProcessWindowStyle.Hidden, true);
		}

		private static void ManualDump(string workFolder)
		{
			System.IO.StreamWriter Writer = new System.IO.StreamWriter(Lfx.Environment.Folders.TemporaryFolder + workFolder + "tablas.sql", false, System.Text.Encoding.Default);
			foreach(string Tabla in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
				if(Tabla != "sys_asl") {
					Lfx.Data.SqlSelectBuilder Comando = new Lfx.Data.SqlSelectBuilder();
					Comando.Tables = Tabla;
					//OProgreso.Progreso++;
                                        ExportTable(Comando, false, Writer);
					ExportBlobs(Comando, Lfx.Environment.Folders.TemporaryFolder + workFolder);
					//OProgreso.Progreso++;
					System.Windows.Forms.Application.DoEvents();
				}
			}
			Writer.Close();
		}


		public static void DeleteBackup(string Carpeta)
		{
			if(Carpeta.Length > 0 && System.IO.Directory.Exists(BackupPath + Carpeta)) {
				System.IO.Directory.Delete(BackupPath + Carpeta, true);
			}
		}


		public static string BackupMasViejo()
		{
			System.Collections.ArrayList Lista = ListaBackups();
			string MasViejo = "";
			System.DateTime FechaMasViejo = System.DateTime.MaxValue;
			foreach(string Backup in Lista) {
				System.IO.DirectoryInfo BackupInfo = new System.IO.DirectoryInfo(BackupPath + Backup);
				if(BackupInfo.CreationTime < FechaMasViejo) {
					MasViejo = Backup;
					FechaMasViejo = BackupInfo.CreationTime;
				}
			}
			return MasViejo;
		}


		public static string BackupMasNuevo()
		{
			System.Collections.ArrayList Lista = ListaBackups();
			string MasNuevo = "";
			System.DateTime FechaMasNuevo = System.DateTime.MinValue;
			foreach(string Backup in Lista) {
				System.IO.DirectoryInfo BackupInfo = new System.IO.DirectoryInfo(BackupPath + Backup);
				if(BackupInfo.CreationTime > FechaMasNuevo) {
					MasNuevo = Backup;
					FechaMasNuevo = BackupInfo.CreationTime;
				}
			}
			return MasNuevo;
		}


		public static System.Collections.ArrayList ListaBackups()
		{
                        Lfx.Environment.Folders.EnsurePathExists(BackupPath);

			System.Collections.ArrayList Lista = new System.Collections.ArrayList();
			System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(BackupPath);
			foreach(System.IO.DirectoryInfo DirItem in Dir.GetDirectories("*.lbk")) {
				Lista.Add(DirItem.Name);
			}
			//TODO: eliminar las carpetas lbkp_*
			foreach(System.IO.DirectoryInfo DirItem in Dir.GetDirectories("lbkp_*")) {
				Lista.Add(DirItem.Name);
			}
			return Lista;
		}


		public static void Restore(string Carpeta)
		{
                        Lfx.Environment.Folders.EnsurePathExists(BackupPath);

			if(Carpeta != null && Carpeta.Length > 0 && System.IO.Directory.Exists(BackupPath + Carpeta)) {
				if(char.Parse(Carpeta.Substring(Carpeta.Length - 1, 1)) != System.IO.Path.DirectorySeparatorChar)
					Carpeta += System.Convert.ToString(System.IO.Path.DirectorySeparatorChar);

				bool UsandoArchivoComprimido = false;

				Lui.Forms.ProgressForm OProgreso = new Lui.Forms.ProgressForm();
				OProgreso.Titulo = "Restaurando Copia de Respaldo";
				OProgreso.Style = ProgressBarStyle.Continuous;
				OProgreso.Texto = "Este proceso va a demorar varios minutos. Por favor no lo interrumpa.";

				OProgreso.Operacion = "Descomprimiendo...";
				// Descomprimir backup si está comprimido
				if(System.IO.File.Exists(BackupPath + Carpeta + "backup.7z")) {
					Lfx.FileFormats.Compression.Archive ArchivoComprimido = new Lfx.FileFormats.Compression.Archive(BackupPath + Carpeta + "backup.7z");
					ArchivoComprimido.ExtractAll(BackupPath + Carpeta);
					UsandoArchivoComprimido = true;
				}

				OProgreso.Operacion = "Eliminando datos actuales...";
                                Lws.Data.DataView DataView = Lws.Workspace.Master.GetDataView(true);
                                DataView.DataBase.BeginTransaction();
                                DataView.DataBase.EnableConstraints(false);

				// Vaciar todas las tablas
                                foreach (string Tabla in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
					//No uso TRUNCATE porque tiene problemas con las transacciones en MySql
                                        DataView.DataBase.Execute("DELETE FROM " + Tabla);
				}

                                OProgreso.Operacion = "Acomodando estructuras...";
                                Lfx.Data.DataBaseCache.DefaultCache.CargarEstructuraDesdeXml(BackupPath + Carpeta + "dbstruct.xml");
                                Datos.VerificarVersionDB(DataView, true, true);

                                // Vuelvo a vaciar todas las tablas, por si VerificarVersionDB() volvió a escribir cosas
                                foreach (string Tabla in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
                                        DataView.DataBase.Execute("DELETE FROM " + Tabla);
                                }

				OProgreso.Operacion = "Incorporando tablas de datos...";
				System.IO.StreamReader Lector = new System.IO.StreamReader(BackupPath + Carpeta + "tablas.sql", System.Text.Encoding.Default);

                                //En tiempo de diseño cargamos línea por línea, en tiempo de ejecución, cargamos de a 1 MB
                                int TamanoMax = Lfx.Environment.SystemInformation.DesignMode ? 1 : 1024 * 1024;
				bool FinArchivo = false;

				OProgreso.Max = (int)Lector.BaseStream.Length;
				do {
					System.Text.StringBuilder Buffer = new System.Text.StringBuilder();
					// Cargo un poco de datos en el buffer
					do {
						string Linea = Lector.ReadLine();
						if(Linea == null) {
							FinArchivo = true;
							break;
						} else {
							Buffer.AppendLine(Linea);
						}
					}
					while(Buffer.Length < TamanoMax);
					OProgreso.Progreso = (int)Lector.BaseStream.Position;
					System.Windows.Forms.Application.DoEvents();
                                        try {
                                                DataView.DataBase.Execute(DataView.DataBase.CustomizeSql(Buffer.ToString()));
                                        }
                                        catch {
                                                if (Lfx.Environment.SystemInformation.DesignMode)
                                                        throw;
                                        }
				}
				while(FinArchivo == false);
				Lector.Close();

				if(Lws.Workspace.Master.DefaultDataBase.SqlMode == Lfx.Data.SqlModes.PostgreSql) {
					// PostgreSql: Tengo que actualizar las secuencias
					OProgreso.Operacion = "Actualizando secuencias...";
					string PatronSecuencia = @"nextval\(\'(.+)\'(.*)\)";
                                        foreach (string Tabla in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
                                                string OID = DataView.DataBase.FieldString("SELECT c.oid FROM pg_catalog.pg_class c LEFT JOIN pg_catalog.pg_namespace n ON n.oid=c.relnamespace WHERE pg_catalog.pg_table_is_visible(c.oid) AND c.relname ~ '^" + Tabla + "$'");
                                                System.Data.DataTable Campos = DataView.DataBase.Select("SELECT a.attname,pg_catalog.format_type(a.atttypid, a.atttypmod),(SELECT substring(d.adsrc for 128) FROM pg_catalog.pg_attrdef d WHERE d.adrelid = a.attrelid AND d.adnum = a.attnum AND a.atthasdef), a.attnotnull, a.attnum FROM pg_catalog.pg_attribute a WHERE a.attrelid = '" + OID + "' AND a.attnum > 0 AND NOT a.attisdropped ORDER BY a.attnum");
						foreach(System.Data.DataRow Campo in Campos.Rows) {
							if(Campo[2] != DBNull.Value) {
								string DefaultCampo = System.Convert.ToString(Campo[2]);
								if(Regex.IsMatch(DefaultCampo, PatronSecuencia)) {
									string NombreCampo = System.Convert.ToString(Campo[0]);
									foreach(System.Text.RegularExpressions.Match Ocurrencia in Regex.Matches(DefaultCampo, PatronSecuencia)) {
										string Secuencia = Ocurrencia.Groups[1].ToString();
                                                                                int MaxId = DataView.DataBase.FieldInt("SELECT MAX(" + NombreCampo + ") FROM " + Tabla) + 1;
                                                                                DataView.DataBase.Execute("ALTER SEQUENCE " + Secuencia + " RESTART WITH " + MaxId.ToString());
									}
								}
							}
						}
					}
				}

				if(System.IO.File.Exists(BackupPath + Carpeta + "blobs.lst")) {
					// Incorporar Blobs
					OProgreso.Operacion = "Incorporando imgenes...";
					Lector = new System.IO.StreamReader(BackupPath + Carpeta + "blobs.lst", System.Text.Encoding.Default);
					string InfoImagen = null;
					do {
						InfoImagen = Lector.ReadLine();
						if(InfoImagen != null && InfoImagen.Length > 0) {
							string Tabla = Lfx.Types.Strings.GetNextToken(ref InfoImagen, ",");
							string Campo = Lfx.Types.Strings.GetNextToken(ref InfoImagen, ",");
							string CampoId = Lfx.Types.Strings.GetNextToken(ref InfoImagen, ",");
							string NombreArchivoImagen = Lfx.Types.Strings.GetNextToken(ref InfoImagen, ",");

							// Guardar blob nuevo
                                                        Lfx.Data.SqlUpdateBuilder ActualizarBlob = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, Tabla);
                                                        ActualizarBlob.WhereClause = new Lfx.Data.SqlWhereBuilder(Campo, CampoId);

							System.IO.FileStream ArchivoImagen = new System.IO.FileStream(BackupPath + Carpeta + NombreArchivoImagen, System.IO.FileMode.Open, System.IO.FileAccess.Read);
							byte[] Contenido = new byte[System.Convert.ToInt32(ArchivoImagen.Length) - 1 + 1];
							ArchivoImagen.Read(Contenido, 0, System.Convert.ToInt32(ArchivoImagen.Length));
							ArchivoImagen.Close();

                                                        ActualizarBlob.Fields.AddWithValue(Campo, Contenido);
                                                        DataView.Execute(ActualizarBlob);
						}
					}
					while(InfoImagen != null);
					Lector.Close();
				}

				if(UsandoArchivoComprimido) {
					OProgreso.Operacion = "Eliminando archivos temporales...";
					// Borrar los archivos que descomprim temporalmente
					System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(BackupPath + Carpeta);
					foreach(System.IO.FileInfo DirItem in Dir.GetFiles()) {
						if(DirItem.Name != "backup.7z" && DirItem.Name != "info.txt") {
							System.IO.File.Delete(BackupPath + Carpeta + DirItem.Name);
						}
					}
				}
				OProgreso.Operacion = "Terminando transacción...";
                                DataView.DataBase.Commit();
				DataView.Dispose();
				OProgreso.Close();

				Lui.Forms.MessageBox.Show("La copia de seguridad se restauró con éxito. A continuación se va a reiniciar la aplicación.", "Copia Restaurada");
				Aplicacion.Exec("REBOOT");
			}
		}
	}
}