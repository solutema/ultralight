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

namespace Lazaro.Actualizador
{

	/// <summary>
	/// Actualizador de sistema Lázaro (actualiza desde web o base de datos).
	/// Desde web:
	/// Descarga el archivo version.xml que contiene información sobre
	/// los archivos que hay que actualizar y sus versiones actuales
	/// Utiliza la variable "Sistema.Actualizaciones.URLNLWC" de la tabla "sys_config"
	/// para saber de dénde descargar.
	/// Para que dos estaciones no descarguen a la vez, utiliza las variables
	/// "Sistema.Actualizaciones.InicioDescarga" para saber cuándo comenzó la última
	/// descarga (fecha y hora) y "Sistema.Actualizaciones.Estacion" para saber el
	/// nombre de la estación que inició la descarga.
	/// Guarda las actualizaciones bajadas en la BD.
	/// Desde BD:
	/// Actualiza desde la tabla "sys_asl", que es el caché de las últimas
	/// versiones descargadas de la web.
	/// </summary>
	public class Actualizador
	{
		public static int ArchivosActualizados;
		public static string MensajeError = null;
                protected internal static Lws.Data.DataView m_DataView = null;

		public static void DescargarActualizaciones()
		{
			ActualizarAplicacionDesdeWeb(false, null);
		}


		public static bool HuboError()
		{
			return MensajeError != null;
		}


		public static int ActualizarAplicacionDesdeBD()
		{
                        return ActualizarAplicacionDesdeBD(string.Empty);
		}

                public static Lws.Data.DataView GetDataView()
                {
                        if (m_DataView == null)
                                m_DataView = Lws.Workspace.Master.GetDataView(false);
                        return m_DataView;
                }

		public static int ActualizarAplicacionDesdeBD(string nombreCarpeta)
		{
			try
			{
				DataTable Archivos = GetDataView().DataBase.Select("SELECT nombre, fecha, checksum FROM sys_asl");
				foreach (System.Data.DataRow Archivo in Archivos.Rows)
				{
					if(ActualizarArchivoDesdeBD((Lfx.Data.Row)Archivo, false, nombreCarpeta))
						ArchivosActualizados++;
				}
				if (ArchivosActualizados > 0)
					Aplicacion.ReinicioPendiente = true;

				return ArchivosActualizados;
			}
			catch (Exception ex)
			{
				System.Console.WriteLine("ActualizarAplicacionDesdeBD: " + ex.Message);
				return 0;
			}
		}

		public static int ActualizarAplicacionDesdeWeb(bool ignorarControlDeColisiones, Estado formularioEstado)
		{
			// Me fijo si ya hay alguien descargando las actualizaciones
                        string FechaInicioActualizacion = Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Actualizaciones.InicioDescarga", string.Empty);
			string FechaInicioActualizacionMax = Lfx.Types.Formatting.FormatDateTimeSql(System.DateTime.Now.AddHours(2));

			// Si hay alguien, pero está hace 4 horas o más, me pongo a descargar igual
			if (ignorarControlDeColisiones || string.Compare(FechaInicioActualizacion, FechaInicioActualizacionMax) < 0)
			{
                                Lws.Workspace.Master.CurrentConfig.WriteGlobalSetting(string.Empty, "Sistema.Actualizaciones.InicioDescarga", Lfx.Types.Formatting.FormatDateTimeSql(System.DateTime.Now), "*");
                                Lws.Workspace.Master.CurrentConfig.WriteGlobalSetting(string.Empty, "Sistema.Actualizaciones.EstacionDescarga", Lfx.Environment.SystemInformation.ComputerName, "*");

				string aslURL = Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Actualizaciones.URLNLWC", "http://www.sistemalazaro.com.ar/aslnlwc/");
				if (aslURL.Length == 0)
					return 0;

				if (aslURL.Substring(aslURL.Length - 1, 1) != "/" && aslURL.Substring(aslURL.Length - 1, 1) != @"\")
					aslURL += "/";

				if (formularioEstado != null)
					formularioEstado.lblOperacion.Text = "Contactando al servidor...";

				if (formularioEstado != null)
					formularioEstado.lblOperacion.Text = "Descargando información de versiones...";

				System.Xml.XmlDocument VersionXml = new System.Xml.XmlDocument();

				//Creo un nodo de mentira, para descargar el archivo version.xml
				System.Xml.XmlNode ArchivoVersion = VersionXml.CreateElement("File");
				ArchivoVersion.Attributes.Append(VersionXml.CreateAttribute("name"));
				ArchivoVersion.Attributes["name"].Value = "version.xml";
                                ActualizarArchivoDesdeWeb(aslURL, ArchivoVersion, true, string.Empty);

				if(System.IO.File.Exists(Lfx.Environment.Folders.ApplicationFolder + "version.xml") == false)
					return 0;

				VersionXml.Load(Lfx.Environment.Folders.ApplicationFolder + "version.xml");
				System.Xml.XmlNode VersionInfo = VersionXml.SelectSingleNode("/VersionInfo");

				//Importo los nodos de los archivos {nombre_componente}.ver como si formaran parte de version.xml
				System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
                                foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.ver"))
				{
                                        //Ignoro archivos ocultos
                                        if ((DirItem.Attributes & System.IO.FileAttributes.Hidden) != System.IO.FileAttributes.Hidden)
                                        {
                                                System.Xml.XmlDocument VersionComponente = new System.Xml.XmlDocument();
                                                VersionComponente.Load(Lfx.Environment.Folders.ComponentsFolder + DirItem.Name);
                                                System.Xml.XmlNode NodoComponente = VersionComponente.SelectSingleNode("/VersionInfo/Component[@name='" + System.IO.Path.GetFileNameWithoutExtension(DirItem.Name) + "']");
                                                string URLComponente;
                                                if (NodoComponente.Attributes["url"] == null)
                                                        URLComponente = aslURL;
                                                else
                                                        URLComponente = NodoComponente.Attributes["url"].Value;

                                                ArchivoVersion.Attributes["name"].Value = DirItem.Name;
                                                if (ActualizarArchivoDesdeWeb(URLComponente, ArchivoVersion, true, "Components/"))
                                                {
                                                        VersionComponente.Load(Lfx.Environment.Folders.ComponentsFolder + DirItem.Name);
                                                        NodoComponente = VersionComponente.SelectSingleNode("/VersionInfo/Component[@name='" + System.IO.Path.GetFileNameWithoutExtension(DirItem.Name) + "']");
                                                        VersionInfo.AppendChild(VersionXml.ImportNode(NodoComponente, true));
                                                }
                                                else
                                                {
                                                        //No pude descargar. No importa, despejo el error
                                                        MensajeError = null;
                                                }
                                        }
				}

				System.Xml.XmlNodeList ListaComponentes = VersionXml.GetElementsByTagName("Component");
				foreach (System.Xml.XmlNode Componente in ListaComponentes)
				{
					string URLComponente;
					string nombreComponente = Componente.Attributes["name"].Value;
					System.Xml.XmlNode Core = VersionXml.SelectSingleNode("/VersionInfo/Component[@name='" + nombreComponente + "']");
					if (Core.Attributes["url"] == null)
						URLComponente = aslURL;
					else
						URLComponente = Core.Attributes["url"].Value;

					foreach (System.Xml.XmlNode Archivo in Core.ChildNodes)
					{
						if (Archivo.Name == "File")
						{
							if (Archivo.Attributes["name"] != null && Archivo.Attributes["name"].Value != null)
							{
                                                                string nombreCarpeta = string.Empty;
								if (nombreComponente != "Core")
									nombreCarpeta = "Components/";
								if (formularioEstado != null)
									formularioEstado.lblOperacion.Text = "Descargando archivos...";
								if (ActualizarArchivoDesdeWeb(URLComponente, Archivo, false, nombreCarpeta))
									ArchivosActualizados++;
							}
						}
					}
				}

			}
                        Lws.Workspace.Master.CurrentConfig.WriteGlobalSetting(string.Empty, "Sistema.Actualizaciones.InicioDescarga", "0");

			if (ArchivosActualizados > 0)
				Aplicacion.ReinicioPendiente = true;

                        return ArchivosActualizados;
		}

		public static bool ActualizarArchivoDesdeBD(Lfx.Data.Row Archivo, bool IgnorarFecha, string nombreCarpeta)
		{
			string FechaNueva = "1901-01-02";
			string FechaArchivo = "1901-01-01";
			string CarpetaTrabajo = Lfx.Environment.Folders.ApplicationFolder + nombreCarpeta;

			if (CarpetaTrabajo[CarpetaTrabajo.Length - 1] != System.IO.Path.DirectorySeparatorChar)
				CarpetaTrabajo += System.IO.Path.DirectorySeparatorChar;

			if (IgnorarFecha == false)
			{
				FechaNueva = System.Convert.ToString(Archivo["fecha"]);
				try
				{
					FechaArchivo = Lfx.Types.Formatting.FormatDateTimeSql(new System.IO.FileInfo(CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"])).LastWriteTime);
				}
				catch (Exception ex)
				{
					System.Console.WriteLine("ActualizarArchivoDesdeBD: CambiarFecha: " + ex.Message);
                                        FechaArchivo = string.Empty;
				}
			}

			if (string.Compare(FechaNueva, FechaArchivo) > 0)
			{
				try
				{
                                        Lfx.Environment.Folders.EnsurePathExists(System.IO.Path.GetDirectoryName(CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"])));

					if (System.IO.File.Exists(CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"]) + ".new"))
						System.IO.File.Delete(CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"]) + ".new");

                                        Archivo = GetDataView().DataBase.FirstRowFromSelect("SELECT nombre, fecha, contenido FROM sys_asl WHERE nombre='" + nombreCarpeta + Archivo["nombre"] + "'");

					System.IO.BinaryWriter wr = new System.IO.BinaryWriter(System.IO.File.OpenWrite(CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"]) + ".new"), System.Text.Encoding.Default);
					wr.Write(((byte[])(Archivo["contenido"])));
					wr.Close();

					string ArchivoBak = CarpetaTrabajo + Archivo["nombre"].ToString() + ".bak." + System.DateTime.Now.ToString("yyyyMMddHHmmss");
					BorrarBaksViejos(CarpetaTrabajo, System.Convert.ToString(Archivo["nombre"]));
					if (System.IO.File.Exists(CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"])))
						System.IO.File.Move(CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"]), ArchivoBak);

					System.IO.File.Move(CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"]) + ".new", CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"]));
                                        System.Console.WriteLine("Actualización BD de " + System.Convert.ToString(Archivo["nombre"]));
					if (string.Compare(FechaNueva, "1950-00-00 00:00:00") > 0)
					{
						try
						{
							System.IO.FileInfo LazaroFileInfo = new System.IO.FileInfo(CarpetaTrabajo + System.Convert.ToString(Archivo["nombre"]));
							DateTime FechaNuevaD = Lfx.Types.Parsing.ParseSqlDateTime(FechaNueva);
							LazaroFileInfo.LastWriteTime = FechaNuevaD;
							LazaroFileInfo.CreationTime = FechaNuevaD;
						}
						catch (Exception ex)
						{
							System.Console.WriteLine("ActualizarArchivoDesdeBD: CambiarFecha: " + ex.Message);
							// No pude poner la fecha del archivo... estoy en un problema?
						}
					}

                                        if (Archivo["nombre"].ToString() == "Upgrade.exe")
                                                Lfx.Environment.Shell.Execute(CarpetaTrabajo + Archivo["nombre"].ToString(), "/verysilent", ProcessWindowStyle.Normal, false);

					return true;
				}
				catch (Exception ex)
				{
					// No se puede conectar al servidor de actualizaciones
					// OFormActualizador.Close()
					Aplicacion.ShowException(ex, string.Empty);
					MensajeError = "Existe una nueva versión del archivo " + System.Convert.ToString(Archivo["nombre"]) + ", pero el sistema no puede actualizarlo automáticamente. Por favor actualice la aplicación manualmente.";
					return false;
				}
			}
			return false;
		}


		public static bool ActualizarArchivoDesdeWeb(string aslURL, System.Xml.XmlNode Archivo, bool IgnorarFecha, string nombreCarpeta)
		{
			bool actualizarArchivoDesdeWebReturn = false;

			string CarpetaTrabajo = Lfx.Environment.Folders.ApplicationFolder + nombreCarpeta;

			if(CarpetaTrabajo[CarpetaTrabajo.Length - 1] != System.IO.Path.DirectorySeparatorChar && CarpetaTrabajo[CarpetaTrabajo.Length - 1] != '/')
				CarpetaTrabajo += System.IO.Path.DirectorySeparatorChar;

			string NombreArchivo = Archivo.Attributes["name"].Value;
			string FechaArchivo = null;
			string FechaNueva = null;
			if (Archivo.Attributes["version"] != null)
				FechaNueva = Archivo.Attributes["version"].Value;

			if (FechaNueva == null || FechaNueva.Length == 0)
				FechaNueva = "1901-01-01 00:00:00";

			try
			{
				FechaArchivo = Lfx.Types.Formatting.FormatDateTimeSql(System.IO.File.GetLastWriteTime(CarpetaTrabajo + NombreArchivo));
			}
			catch
			{
                                FechaArchivo = string.Empty;
			}

			if (IgnorarFecha || string.Compare(FechaNueva, FechaArchivo) > 0)
			{
				try
				{
                                        string Compresion = string.Empty;

					System.Windows.Forms.Application.DoEvents();

					byte[] Contenido = null;
					if (NombreArchivo != "version.xml")
					{
						// Intento descargar el archivo comprimido, salvo que sea version.txt
						Compresion = ".bz2";
                                                Contenido = NetGet(aslURL + nombreCarpeta + NombreArchivo + Compresion);
					}
					if (Contenido == null)
					{
						// Si falló, intento descargar el archivo original
                                                Compresion = string.Empty;
						Contenido = NetGet(aslURL + nombreCarpeta + NombreArchivo);
					}
					if (Contenido /* still */ == null)
					{
						// Si falló, desisto
						MensajeError = "No se puede descargar " + aslURL + nombreCarpeta + NombreArchivo;
						return false;
					}

					string ChecksumContenido = null;
					string ChecksumNuevo = null;
					if (Archivo.Attributes["checksum"] != null)
						ChecksumNuevo = Archivo.Attributes["checksum"].Value;
					//ChecksumNuevo = Ini.ReadString(VersionTxt, NombreArchivo, "Checksum", "0");
					//ChecksumContenido = Funciones.MD5(Contenido);

					if (ChecksumNuevo == null || ChecksumNuevo == "0" || ChecksumNuevo == ChecksumContenido)
					{
						if (System.IO.File.Exists(CarpetaTrabajo + NombreArchivo + ".new"))
							System.IO.File.Delete(CarpetaTrabajo + NombreArchivo + ".new");

						System.Console.Write("Guardando como " + CarpetaTrabajo + NombreArchivo + ".new: ");
						System.IO.BinaryWriter wr = new System.IO.BinaryWriter(System.IO.File.OpenWrite(CarpetaTrabajo + NombreArchivo + ".new"), System.Text.Encoding.Default);
						wr.Write(Contenido);
						wr.Close();
						System.Console.WriteLine("ok.");

						string ArchivoBak = CarpetaTrabajo + NombreArchivo + ".bak." + System.DateTime.Now.ToString("yyyyMMddHHmmss");
						BorrarBaksViejos(CarpetaTrabajo, NombreArchivo);
						if (System.IO.File.Exists(CarpetaTrabajo + NombreArchivo)) {
							System.Console.Write("Renombrando archivo viejo: ");
							System.IO.File.Move(CarpetaTrabajo + NombreArchivo, ArchivoBak);
							System.Console.WriteLine(ArchivoBak);
						}

						if (Compresion == ".bz2")
						{
							// Si está comprimido, descomprimo
							Lfx.FileFormats.Compression.Archive ArchivoComprimido = new Lfx.FileFormats.Compression.Archive(CarpetaTrabajo + NombreArchivo + ".new", Lfx.FileFormats.Compression.ArchiveTypes.BZip2);
							System.Console.Write("Descomprimiendo " + ArchivoComprimido.ArchiveFileName);
							ArchivoComprimido.Extract(NombreArchivo, CarpetaTrabajo);
							if (System.IO.File.Exists(CarpetaTrabajo + NombreArchivo))
							{
								System.Console.WriteLine("ok.");
                                                                // Se descomprimí ok. Borro el .new
								System.IO.File.Delete(CarpetaTrabajo + NombreArchivo + ".new");
								// Y cargo el contenido del archivo descomprimido, para tener
								System.IO.FileStream ArchivoStream = new System.IO.FileStream(CarpetaTrabajo + NombreArchivo, System.IO.FileMode.Open, System.IO.FileAccess.Read);
								Contenido = new byte[ArchivoStream.Length];
								ArchivoStream.Read(Contenido, 0, System.Convert.ToInt32(ArchivoStream.Length));
								ArchivoStream.Close();
							}
							else
							{
								System.Console.WriteLine("error.");
								// Vulevo al .bak
								System.IO.File.Move(ArchivoBak, CarpetaTrabajo + NombreArchivo);
								// System.IO.File.Delete(CarpetaTrabajo & sArchivo & ".new")
								MensajeError = "No se puede descomprimir " + NombreArchivo;
								return false;
							}
						}
						else
						{
							// De lo contrario, renombro
							System.IO.File.Move(CarpetaTrabajo + NombreArchivo + ".new", CarpetaTrabajo + NombreArchivo);
						}

						if (string.Compare(FechaNueva, "1950-00-00 00:00:00") > 0)
						{
							try
							{
								System.IO.FileInfo LazaroFileInfo = new System.IO.FileInfo(CarpetaTrabajo + NombreArchivo);
								DateTime FechaNuevaD = Lfx.Types.Parsing.ParseSqlDateTime(FechaNueva);
								LazaroFileInfo.LastWriteTime = FechaNuevaD;
								LazaroFileInfo.CreationTime = FechaNuevaD;
								LazaroFileInfo = null;
							}
							catch (Exception ex)
							{
								Aplicacion.ShowException(ex, "Cambiar Fecha: " + FechaNueva);
								// No pude poner la fecha del archivo... estoy en un problema?
							}
						}
						actualizarArchivoDesdeWebReturn = true;

						// Lo publico en la BD
						if (Lws.Workspace.Master.SlowLink == false && Lfx.Environment.SystemInformation.DesignMode == false)
						{
                                                        Lws.Workspace.Master.DefaultDataView.DataBase.Execute("DELETE FROM sys_asl WHERE nombre='" + nombreCarpeta + NombreArchivo.ToLower() + "'");
                                                        Lfx.Data.SqlInsertBuilder InsertarArchivo = new Lfx.Data.SqlInsertBuilder(GetDataView().DataBase, "sys_asl");
                                                        InsertarArchivo.Fields.AddWithValue("nombre", nombreCarpeta + NombreArchivo);
                                                        InsertarArchivo.Fields.AddWithValue("fecha", FechaNueva);
                                                        InsertarArchivo.Fields.AddWithValue("checksum", ChecksumContenido);
                                                        InsertarArchivo.Fields.AddWithValue("contenido", Contenido);
                                                        Lws.Workspace.Master.DefaultDataView.Execute(InsertarArchivo);
						}

                                                if (NombreArchivo == "Upgrade.exe")
                                                        Lfx.Environment.Shell.Execute(CarpetaTrabajo + NombreArchivo, "/verysilent", ProcessWindowStyle.Normal, false);
					}
					else
					{
						MensajeError = "Existe una nueva versión del archivo " + NombreArchivo + ", pero el sistema no puede actualizarlo automáticamente. Por favor actualice la aplicación manualmente." + Environment.NewLine + "La descripción extendida del error es: la suma de verificación no concuerda.";
					}
				}
				catch (Exception ex)
				{
					System.Console.WriteLine("ActualizarArchivoDesdeWeb: " + ex.Message);
					MensajeError = "No se puede descargar el archivo " + NombreArchivo + ". Intente actualizar la aplicación manualmente." + Environment.NewLine + "La descripción extendida del error es: " + ex.Message;
					actualizarArchivoDesdeWebReturn = false;
				}
			}
			return actualizarArchivoDesdeWebReturn;
		}

		private static void BorrarBaksViejos(string carpeta, string nombreArchivo)
		{
			string ArchivoBakMasViejoADejar = nombreArchivo + ".bak." + System.DateTime.Now.AddDays(-1).ToString("yyyyMMddHHmmss");
			string[] ArchivosBak = System.IO.Directory.GetFiles(carpeta, "*.bak.*");
			foreach (string Archivo in ArchivosBak)
			{
				if (System.IO.Path.GetFileName(Archivo).CompareTo(ArchivoBakMasViejoADejar) < 0)
					try
					{
						System.IO.File.Delete(Archivo);
					}
					catch
					{
						//No pude borrar el bak. No pasa nada
					}
			}
		}

		private static byte[] NetGet(string Archivo)
		{
			try
			{
				System.Console.Write("Descargando " + Archivo + ": ");
				System.Net.WebRequest Solicitud = null;
				Solicitud = System.Net.WebRequest.CreateDefault(new System.Uri(Archivo));
				System.Net.WebResponse Respuesta = Solicitud.GetResponse();
				byte[] Contenido = new byte[Respuesta.ContentLength];
				System.IO.StreamReader Lector = new System.IO.StreamReader(Respuesta.GetResponseStream(), System.Text.Encoding.Default);
				Contenido = System.Text.Encoding.Default.GetBytes(Lector.ReadToEnd());
				Lector.Close();
				Respuesta.Close();
				System.Console.WriteLine("ok.");
				return Contenido;
			}
			catch (Exception ex)
			{
				System.Console.WriteLine(ex.Message);
				return null;
			}
		}
	}
}