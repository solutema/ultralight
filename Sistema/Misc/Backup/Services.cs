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
using System.Text.RegularExpressions;

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

                /// <summary>
                /// Exporta los campos binarios de una tabla en archivos.
                /// </summary>
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
                /// Exporta una tabla en un formato binario propietario, incluyendo BLOBs.
                /// </summary>
                public static void ExportTableBin(string nombreTabla, BackupStreamWriter writer)
                {
                        Lfx.Data.SqlSelectBuilder Comando = new Lfx.Data.SqlSelectBuilder(nombreTabla);
                        System.Data.IDataReader Tabla = Lws.Workspace.Master.DefaultDataBase.GetReader(Comando);
                        
                        bool EmitiTabla = false;
                        string[] Fields = null;
                        while (Tabla.Read()) {
                                if (EmitiTabla == false) {
                                        Fields = new string[Tabla.FieldCount];
                                        for (int i = 0; i < Tabla.FieldCount; i++) {
                                                Fields[i] = Tabla.GetName(i);
                                        }
                                        string FieldList = string.Join(",", Fields);
                                        writer.Write(":TBL" + Comando.Tables.Length.ToString("0000") + Comando.Tables);
                                        writer.Write(":FDL" + FieldList.Length.ToString("0000") + FieldList);
                                        EmitiTabla = true;
                                }
                                writer.Write(":ROW");

                                for (int i = 0; i < Tabla.FieldCount; i++) {
                                        object ValorOrigen = Tabla[Fields[i]];
                                        string TipoCampoOrigen = ValorOrigen.GetType().ToString().Replace("System.", "");
                                        string TipoCampoDestino;
                                        switch (TipoCampoOrigen) {
                                                case "Byte[]":
                                                        TipoCampoDestino = "B";
                                                        break;
                                                case "SByte":
                                                case "Byte":
                                                case "Int16":
                                                case "Int32":
                                                case "Int64":
                                                        ValorOrigen = ValorOrigen.ToString();
                                                        TipoCampoDestino = "I";
                                                        break;
                                                case "Decimal":
                                                case "Single":
                                                case "Double":
                                                        double ValDouble = System.Convert.ToDouble(ValorOrigen);
                                                        ValorOrigen = ValDouble.ToString(System.Globalization.CultureInfo.InvariantCulture);
                                                        TipoCampoDestino = "N";
                                                        break;
                                                case "DateTime":
                                                        ValorOrigen = ((DateTime)ValorOrigen).ToString(Lfx.Types.Formatting.DateTime.SqlDateTimeFormat);
                                                        TipoCampoDestino = "D";
                                                        break;
                                                case "String":
                                                        TipoCampoDestino = "S";
                                                        break;
                                                case "DBNull":
                                                        TipoCampoDestino = "U";
                                                        ValorOrigen = "";
                                                        break;
                                                default:
                                                        TipoCampoDestino = "S";
                                                        ValorOrigen = ValorOrigen.ToString();
                                                        break;
                                        }

                                        byte[] ValorDestino;

                                        if (ValorOrigen is byte[])
                                                ValorDestino = (byte[])ValorOrigen;
                                        else if (ValorOrigen is string)
                                                ValorDestino = System.Text.Encoding.UTF8.GetBytes((string)ValorOrigen);
                                        else
                                                throw new NotImplementedException();

                                        writer.Write(":FLD" + TipoCampoDestino + ValorDestino.Length.ToString("00000000"));
                                        if (ValorDestino.Length > 0)
                                                writer.Write(ValorDestino);
                                }
                                writer.Write(".ROW");
                                //writer.Write(":REM0002" + Lfx.Types.ControlChars.CrLf);
                        }

                        writer.Write(".TBL");
                        Tabla.Close();
                }

                /// <summary>
                /// Exporta una tabla a un archivo de texto con una secuencia de comandos SQL.
                /// </summary>
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
                                                                        // FIXME: exportar BLOBS
								} else {
									Valor = "NULL";
								}
								break;
                                                        case "SByte":
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
                        OProgreso.Max = Lfx.Data.DataBaseCache.DefaultCache.TableList.Count + 1;
			OProgreso.Show();

			OProgreso.Operacion = "Exportando estructura...";
                        OProgreso.Progreso += 1;
			System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
			doc.AppendChild(Lws.Workspace.Master.DefaultDataBase.GetXmlStructure(doc));
			doc.Save(Lfx.Environment.Folders.TemporaryFolder + workFolder + "dbstruct.xml");

                        BackupStreamWriter Writer = new BackupStreamWriter(Lfx.Environment.Folders.TemporaryFolder + workFolder + "dbdata.lbd", false);
                        Writer.Write(":BKP");
                        
                        foreach (string Tabla in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
                                if (Tabla != "sys_asl") {
                                        OProgreso.Operacion = "Volcando " + Tabla;
                                        OProgreso.Progreso += 1;
                                        ExportTableBin(Tabla, Writer);
                                        System.Windows.Forms.Application.DoEvents();
                                }
                        }
                        Writer.Close();

			System.IO.FileStream Archivo = new System.IO.FileStream(Lfx.Environment.Folders.TemporaryFolder + workFolder + "info.txt", System.IO.FileMode.Append, System.IO.FileAccess.Write);
			System.IO.StreamWriter Escribidor = new System.IO.StreamWriter(Archivo, System.Text.Encoding.Default);
			Escribidor.WriteLine("Copia de seguridad del sistema Lázaro");
			Escribidor.WriteLine("");
			Escribidor.WriteLine("Empresa=" + Lws.Workspace.Master.CurrentConfig.Company.Name);
			Escribidor.WriteLine("EspacioTrabajo=" + Lws.Workspace.Master.Name);
			Escribidor.WriteLine("FechaYHora=" + System.DateTime.Now.ToString("dd-MM-yyyy") + " a las " + System.DateTime.Now.ToString("HH:mm:ss"));
			Escribidor.WriteLine("Usuario=" + Lws.Workspace.Master.CurrentUser.UserCompleteName);
			Escribidor.WriteLine("Estación=" + System.Environment.MachineName.ToUpperInvariant());
			Escribidor.WriteLine("Versión Aplic=" + Aplicacion.Version() + " del " + Aplicacion.BuildDate());
			Escribidor.WriteLine("");
			Escribidor.WriteLine("Por favor no modifique ni elimine este archivo.");
			Escribidor.Close();
			Archivo.Close();

                        if (Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingInt("Sistema", "ComprimirCopiasDeRespaldo", 0) != 0) {
                                OProgreso.Operacion = "Comprimiendo los datos...";
                                Lfx.FileFormats.Compression.Archive ArchivoComprimido = new Lfx.FileFormats.Compression.Archive(Lfx.Environment.Folders.TemporaryFolder + workFolder + "backup.7z");
                                ArchivoComprimido.Add(Lfx.Environment.Folders.TemporaryFolder + workFolder + "*");
                                if (System.IO.File.Exists(Lfx.Environment.Folders.TemporaryFolder + workFolder + "backup.7z")) {
                                        OProgreso.Operacion = "Eliminando archivos temporales...";
                                        // Borrar los archivos que acabo de comprimir
                                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.TemporaryFolder + workFolder);
                                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles()) {
                                                if (DirItem.Name != "backup.7z" && DirItem.Name != "info.txt") {
                                                        System.IO.File.Delete(Lfx.Environment.Folders.TemporaryFolder + workFolder + DirItem.Name);
                                                }
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
                        // FIXME: eliminar las carpetas lbkp_*
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

				Lui.Forms.ProgressForm FormularioProgreso = new Lui.Forms.ProgressForm();
				FormularioProgreso.Titulo = "Restaurando Copia de Respaldo";
				FormularioProgreso.Style = ProgressBarStyle.Continuous;
				FormularioProgreso.Texto = "Este proceso va a demorar varios minutos. Por favor no lo interrumpa.";

				FormularioProgreso.Operacion = "Descomprimiendo...";
				// Descomprimir backup si está comprimido
				if(System.IO.File.Exists(BackupPath + Carpeta + "backup.7z")) {
					Lfx.FileFormats.Compression.Archive ArchivoComprimido = new Lfx.FileFormats.Compression.Archive(BackupPath + Carpeta + "backup.7z");
					ArchivoComprimido.ExtractAll(BackupPath + Carpeta);
					UsandoArchivoComprimido = true;
				}

				FormularioProgreso.Operacion = "Eliminando datos actuales...";
                                Lws.Data.DataView DataView = Lws.Workspace.Master.GetDataView(true);
                                DataView.DataBase.BeginTransaction();
                                DataView.DataBase.EnableConstraints(false);

				// Vaciar todas las tablas
                                foreach (string Tabla in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
                                        Lfx.Data.SqlDeleteBuilder DelCmd = new Lfx.Data.SqlDeleteBuilder(Tabla);
                                        DelCmd.Truncate = true;
                                        DataView.Execute(DelCmd);
				}

                                FormularioProgreso.Operacion = "Acomodando estructuras...";
                                Lfx.Data.DataBaseCache.DefaultCache.TagList.Clear();
                                Lfx.Data.DataBaseCache.DefaultCache.TableList.Clear();
                                Lfx.Data.DataBaseCache.DefaultCache.CargarEstructuraDesdeXml(BackupPath + Carpeta + "dbstruct.xml");
                                Datos.VerificarVersionDB(DataView, true, true);

                                // Vuelvo a vaciar todas las tablas, por si VerificarVersionDB() volvió a escribir cosas
                                foreach (string Tabla in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
                                        Lfx.Data.SqlDeleteBuilder DelCmd = new Lfx.Data.SqlDeleteBuilder(Tabla);
                                        DelCmd.Truncate = true;
                                        DataView.Execute(DelCmd);
                                }

				FormularioProgreso.Operacion = "Incorporando tablas de datos...";
                                BackupStreamReader Lector = new BackupStreamReader(BackupPath + Carpeta + "dbdata.lbd");

				FormularioProgreso.Max = (int)Lector.Length;
                                string TablaActual = null;
                                string[] ListaCampos = null;
                                object[] ValoresCampos = null;
                                int CampoActual = 0, RenglonActual = 0;
                                bool EndTable = false;
                                Lfx.Data.SqlBuilkInsertBuilder Insertador = new Lfx.Data.SqlBuilkInsertBuilder();
                                do {
                                        string Comando = Lector.ReadString(4);
                                        switch (Comando) {
                                                case ":TBL":
                                                        TablaActual = Lector.ReadPrefixedString4();
                                                        EndTable = false;
                                                        FormularioProgreso.Operacion = "Cargando " + TablaActual;
                                                        break;
                                                case ":FDL":
                                                        ListaCampos = Lector.ReadPrefixedString4().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                                                        ValoresCampos = new object[ListaCampos.Length];
                                                        CampoActual = 0;
                                                        break;
                                                case ":FLD":
                                                        ValoresCampos[CampoActual++] = Lector.ReadField();
                                                        break;
                                                case ".ROW":
                                                        Lfx.Data.SqlInsertBuilder Insertar = new Lfx.Data.SqlInsertBuilder(TablaActual);
                                                        for (int i = 0; i < ListaCampos.Length; i++) {
                                                                Insertar.Fields.AddWithValue(ListaCampos[i], ValoresCampos[i]);
                                                        }
                                                        Insertador.Add(Insertar);

                                                        ValoresCampos = new object[ListaCampos.Length];
                                                        CampoActual = 0;
                                                        break;
                                                case ":REM":
                                                        Lector.ReadPrefixedString4();
                                                        break;
                                                case ".TBL":
                                                        EndTable = true;
                                                        break;
                                        }
                                        if (EndTable || Insertador.Count >= 1000) {
                                                DataView.DataBase.Execute(Insertador.ToString());
                                                Insertador.Clear();
                                                FormularioProgreso.Progreso = (int)Lector.Position;
                                                System.Windows.Forms.Application.DoEvents();
                                        }
                                } while (Lector.Position < Lector.Length);
				Lector.Close();

				if(Lws.Workspace.Master.DefaultDataBase.SqlMode == Lfx.Data.SqlModes.PostgreSql) {
					// PostgreSql: Tengo que actualizar las secuencias
					FormularioProgreso.Operacion = "Actualizando secuencias...";
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
					FormularioProgreso.Operacion = "Incorporando imgenes...";
					System.IO.StreamReader LectorBlobs = new System.IO.StreamReader(BackupPath + Carpeta + "blobs.lst", System.Text.Encoding.Default);
					string InfoImagen = null;
					do {
                                                InfoImagen = LectorBlobs.ReadLine();
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
                                        LectorBlobs.Close();
				}

				if(UsandoArchivoComprimido) {
					FormularioProgreso.Operacion = "Eliminando archivos temporales...";
					// Borrar los archivos que descomprim temporalmente
					System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(BackupPath + Carpeta);
					foreach(System.IO.FileInfo DirItem in Dir.GetFiles()) {
						if(DirItem.Name != "backup.7z" && DirItem.Name != "info.txt") {
							System.IO.File.Delete(BackupPath + Carpeta + DirItem.Name);
						}
					}
				}
				FormularioProgreso.Operacion = "Terminando transacción...";
                                DataView.DataBase.Commit();
				DataView.Dispose();
				FormularioProgreso.Close();

				Lui.Forms.MessageBox.Show("La copia de seguridad se restauró con éxito. A continuación se va a reiniciar la aplicación.", "Copia Restaurada");
				Aplicacion.Exec("REBOOT");
			}
		}
	}

        public class BackupStreamWriter
        {
                public System.IO.Stream outputStream;

                public BackupStreamWriter(string path, bool compress)
                {
                        //if (compress) {
                        //        System.IO.FileStream fileStream = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                        //        outputStream = new ICSharpCode.SharpZipLib.BZip2.BZip2OutputStream(fileStream, 9);
                        //} else {
                                outputStream = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                        //}
                }

                public void Close()
                {
                        outputStream.Close();
                }

                public void Write(string text)
                {
                        this.Write(System.Text.Encoding.UTF8.GetBytes(text));
                }

                public void Write(byte[] bytes)
                {
                        outputStream.Write(bytes, 0, bytes.Length);
                }
        }

        public class BackupStreamReader
        {
                System.IO.Stream inputStream;
                public BackupStreamReader(string path)
                {
                        System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        int FirstPos = fs.ReadByte();
                        //if (FirstPos == 58) {
                        //        //Archivo plano
                                inputStream = fs;
                        //} else {
                        //        //Archivo comprimido, asumo BZip2
                        //        inputStream = new ICSharpCode.SharpZipLib.BZip2.BZip2InputStream(fs);
                        //}
                        inputStream.Seek(0, System.IO.SeekOrigin.Begin);
                }

                public string ReadString(int length)
                {
                        byte[] Res = new byte[length];
                        inputStream.Read(Res, 0, length);
                        return System.Text.Encoding.UTF8.GetString(Res);
                }

                public string ReadPrefixedString4()
                {
                        int Len = int.Parse(this.ReadString(4));
                        return this.ReadString(Len);
                }

                public object ReadField()
                {
                        string Type = this.ReadString(1);
                        string StrLen = this.ReadString(8);
                        int Len = int.Parse(StrLen);
                        switch(Type) {
                                case "I":
                                        return int.Parse(this.ReadString(Len));
                                case "N":
                                        return Lfx.Types.Parsing.ParseDouble(this.ReadString(Len));
                                case "D":
                                        string FldVal = this.ReadString(Len);
                                        return DateTime.ParseExact(FldVal, Lfx.Types.Formatting.DateTime.SqlDateTimeFormat, null);
                                case "B":
                                        byte[] Res = new byte[Len];
                                        inputStream.Read(Res, 0, Len);
                                        return Res;
                                case "U":
                                        return DBNull.Value;
                                default:
                                        return this.ReadString(Len);

                        }
                }

                public void Close()
                {
                        inputStream.Close();
                }

                public long Length
                {
                        get
                        {
                                return inputStream.Length;
                        }
                }

                public long Position
                {
                        get
                        {
                                return inputStream.Position;
                        }
                }
        }
}