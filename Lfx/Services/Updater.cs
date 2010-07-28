#region License
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
#endregion

using System;
using System.Data;

namespace Lfx.Services
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
        public class Updater : IDisposable
        {
                public int UpdatedFiles;
                public string ErrorMessage = null;
                private bool IgnoreOthersUpdating = false, Updating = false, Running = false;
                public static Updater Master = null;
                System.Threading.Thread UpdaterThread = null;
                
                private Lfx.Data.DataBase m_DataBase = null;

                public Updater()
                {
                        this.UpdaterThread = new System.Threading.Thread(new System.Threading.ThreadStart(UpdateProc));
                        this.UpdaterThread.Priority = System.Threading.ThreadPriority.Lowest;
                }

                public void Start()
                {
                        this.Running = true;
                        this.UpdaterThread.Start();
                }

                private void UpdateProc()
                {
                        this.Running = true;

                        int Loop = 0;
                        while (this.Running) {
                                if (Loop++ > 3) {
                                        this.UpdateFromWeb();
                                        Loop = 0;
                                } else {
                                        this.UpdateFromDbCache();
                                }
                                System.Threading.Thread.Sleep(10 * 60 * 1000);  // Dormir 10 minutos
                        }
                }

                public void Stop()
                {
                        this.Running = false;
                        this.UpdaterThread.Abort();
                }

                public void UpdateFromWeb()
                {
                        if (Updating)
                                return;

                        Updating = true;

                        UpdateAllFromWeb();

                        Updating = false;
                }

                public void UpdateFromDbCache()
                {
                        if (Updating)
                                return;

                        Updating = true;

                        UpdateAllFromDbCache(string.Empty);

                        Updating = false;
                }

                public void Dispose()
                {
                        if (m_DataBase != null) {
                                m_DataBase.Dispose();
                                m_DataBase = null;
                        }
                }

                public bool ErrorFlag
                {
                        get
                        {
                                return ErrorMessage != null;
                        }
                }

                public bool RebootNeeded
                {
                        get
                        {
                                if (this.Running)
                                        return false;

                                if (UpdatedFiles > 0)
                                        return true;

                                return false;
                        }
                }

                private Lfx.Data.DataBase DataBase
                {
                        get
                        {
                                if (m_DataBase == null)
                                        m_DataBase = Lfx.Workspace.Master.GetDataBase("Actualizador");
                                return m_DataBase;
                        }
                }


                private int UpdateAllFromDbCache(string nombreCarpeta)
                {
                        try {
                                DataTable Archivos = this.DataBase.Select("SELECT nombre, fecha, checksum FROM sys_asl");
                                foreach (System.Data.DataRow Archivo in Archivos.Rows) {
                                        if (UpdateFileFromDbCache((Lfx.Data.Row)Archivo, false, nombreCarpeta))
                                                UpdatedFiles++;
                                }

                                return UpdatedFiles;
                        } catch (Exception ex) {
                                System.Console.WriteLine("ActualizarAplicacionDesdeBD: " + ex.Message);
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw;
                                return 0;
                        }
                }


                private void UpdateAllFromWeb()
                {
                        this.ErrorMessage = null;
                        UpdatedFiles = 0;
                        Updating = true;

                        // Me fijo si ya hay alguien descargando las actualizaciones
                        string FechaInicioActualizacion = this.DataBase.Workspace.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Actualizaciones.InicioDescarga", string.Empty);
                        string FechaInicioActualizacionMax = Lfx.Types.Formatting.FormatDateTimeSql(System.DateTime.Now.AddHours(2));

                        // Si hay alguien, pero está hace 4 horas o más, me pongo a descargar igual
                        if (this.IgnoreOthersUpdating || string.Compare(FechaInicioActualizacion, FechaInicioActualizacionMax) < 0) {
                                this.DataBase.Workspace.CurrentConfig.WriteGlobalSetting(string.Empty, "Sistema.Actualizaciones.InicioDescarga", Lfx.Types.Formatting.FormatDateTimeSql(System.DateTime.Now), "*");
                                this.DataBase.Workspace.CurrentConfig.WriteGlobalSetting(string.Empty, "Sistema.Actualizaciones.EstacionDescarga", System.Environment.MachineName.ToUpperInvariant(), "*");

                                string NivelActualizaciones = this.DataBase.Workspace.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Actualizaciones.Nivel", "stable");
                                string UrlActualizaciones = @"http://www.sistemalazaro.com.ar/aslnlwc/" + NivelActualizaciones + "/";

                                // formularioEstado.TextoOperacion = "Contactando al servidor...";

                                System.Xml.XmlDocument VersionXml = new System.Xml.XmlDocument();

                                //Creo un nodo de mentira, para descargar el archivo version.xml
                                System.Xml.XmlNode ArchivoVersion = VersionXml.CreateElement("File");
                                ArchivoVersion.Attributes.Append(VersionXml.CreateAttribute("name"));
                                ArchivoVersion.Attributes["name"].Value = "version.xml";
                                UpdateFileFromWeb(UrlActualizaciones, ArchivoVersion, true, string.Empty);

                                if (System.IO.File.Exists(Lfx.Environment.Folders.UpdatesFolder + "version.xml") == false) {
                                        Updating = false;
                                        return;
                                }

                                VersionXml.Load(Lfx.Environment.Folders.UpdatesFolder + "version.xml");
                                System.Xml.XmlNode VersionInfo = VersionXml.SelectSingleNode("/VersionInfo");

                                //Importo los nodos de los archivos {nombre_componente}.ver como si formaran parte de version.xml
                                System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
                                foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.ver")) {
                                        //Ignoro archivos ocultos
                                        if ((DirItem.Attributes & System.IO.FileAttributes.Hidden) != System.IO.FileAttributes.Hidden) {
                                                System.Xml.XmlDocument VersionComponente = new System.Xml.XmlDocument();
                                                string VerFileName = Lfx.Environment.Folders.UpdatesFolder + "Components" + System.IO.Path.DirectorySeparatorChar + DirItem.Name; ;
                                                if (System.IO.File.Exists(VerFileName))
                                                        VersionComponente.Load(VerFileName);
                                                else if (System.IO.File.Exists(Lfx.Environment.Folders.ComponentsFolder + DirItem.Name))
                                                        VersionComponente.Load(Lfx.Environment.Folders.ComponentsFolder + DirItem.Name);

                                                System.Xml.XmlNode NodoComponente = VersionComponente.SelectSingleNode("/VersionInfo/Component[@name='" + System.IO.Path.GetFileNameWithoutExtension(DirItem.Name) + "']");
                                                string URLComponente;
                                                if (NodoComponente.Attributes["url"] == null)
                                                        URLComponente = UrlActualizaciones;
                                                else
                                                        URLComponente = NodoComponente.Attributes["url"].Value;

                                                ArchivoVersion.Attributes["name"].Value = DirItem.Name;
                                                if (UpdateFileFromWeb(URLComponente, ArchivoVersion, true, "Components/")) {
                                                        VersionComponente.Load(VerFileName);
                                                        NodoComponente = VersionComponente.SelectSingleNode("/VersionInfo/Component[@name='" + System.IO.Path.GetFileNameWithoutExtension(DirItem.Name) + "']");
                                                        VersionInfo.AppendChild(VersionXml.ImportNode(NodoComponente, true));
                                                } else {
                                                        //No pude descargar. No importa, despejo el error
                                                        ErrorMessage = null;
                                                }
                                        }
                                }

                                System.Xml.XmlNodeList ListaComponentes = VersionXml.GetElementsByTagName("Component");
                                foreach (System.Xml.XmlNode Componente in ListaComponentes) {
                                        string URLComponente;
                                        string nombreComponente = Componente.Attributes["name"].Value;
                                        System.Xml.XmlNode Core = VersionXml.SelectSingleNode("/VersionInfo/Component[@name='" + nombreComponente + "']");
                                        if (Core.Attributes["url"] == null)
                                                URLComponente = UrlActualizaciones;
                                        else
                                                URLComponente = Core.Attributes["url"].Value;

                                        foreach (System.Xml.XmlNode Archivo in Core.ChildNodes) {
                                                if (Archivo.Name == "File") {
                                                        if (Archivo.Attributes["name"] != null && Archivo.Attributes["name"].Value != null) {
                                                                string nombreCarpeta = string.Empty;
                                                                if (nombreComponente != "Core")
                                                                        nombreCarpeta = "Components" + System.IO.Path.DirectorySeparatorChar;
                                                                // formularioEstado.TextoOperacion = "Descargando archivos...";
                                                                if (UpdateFileFromWeb(URLComponente, Archivo, false, nombreCarpeta))
                                                                        UpdatedFiles++;
                                                        }
                                                }
                                        }
                                }

                        }
                        this.DataBase.Workspace.CurrentConfig.WriteGlobalSetting(string.Empty, "Sistema.Actualizaciones.InicioDescarga", "0");

                        Updating = false;
                }


                private bool UpdateFileFromDbCache(Lfx.Data.Row Archivo, bool IgnorarFecha, string nombreCarpeta)
                {
                        string FechaNueva = "1901-01-02";
                        string FechaArchivo = "1901-01-01";

                        string CarpetaTrabajo = Lfx.Environment.Folders.ApplicationFolder + nombreCarpeta;
                        if (CarpetaTrabajo[CarpetaTrabajo.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                                CarpetaTrabajo += System.IO.Path.DirectorySeparatorChar;

                        string CarpetaDescarga = Lfx.Environment.Folders.UpdatesFolder + nombreCarpeta;
                        if (System.IO.Directory.Exists(CarpetaDescarga) == false)
                                System.IO.Directory.CreateDirectory(CarpetaDescarga);

                        string NombreArchivo = Archivo["nombre"].ToString();

                        if (IgnorarFecha == false) {
                                FechaNueva = System.Convert.ToString(Archivo["fecha"]);
                                try {
                                        FechaArchivo = Lfx.Types.Formatting.FormatDateTimeSql(new System.IO.FileInfo(CarpetaTrabajo + NombreArchivo).LastWriteTime);
                                } catch (Exception ex) {
                                        System.Console.WriteLine("ActualizarArchivoDesdeBD: CambiarFecha: " + ex.Message);
                                        if (Lfx.Environment.SystemInformation.DesignMode)
                                                throw;
                                        FechaArchivo = string.Empty;
                                }
                        }

                        if (string.Compare(FechaNueva, FechaArchivo) > 0) {
                                try {
                                        Lfx.Environment.Folders.EnsurePathExists(System.IO.Path.GetDirectoryName(CarpetaDescarga + NombreArchivo));

                                        if (System.IO.File.Exists(CarpetaDescarga + NombreArchivo + ".new"))
                                                System.IO.File.Delete(CarpetaDescarga + NombreArchivo + ".new");

                                        Archivo = this.DataBase.FirstRowFromSelect("SELECT nombre, fecha, contenido FROM sys_asl WHERE nombre='" + (nombreCarpeta + Archivo["nombre"]).Replace("\\", "/") + "'");

                                        if (Archivo != null && Archivo["contenido"] != null) {
                                                using (System.IO.BinaryWriter wr = new System.IO.BinaryWriter(System.IO.File.OpenWrite(CarpetaDescarga + NombreArchivo + ".new"), System.Text.Encoding.Default)) {
                                                        wr.Write(((byte[])(Archivo["contenido"])));
                                                        wr.Close();
                                                }

                                                System.Console.WriteLine("Actualización BD de " + NombreArchivo);

                                                if (string.Compare(FechaNueva, "1950-00-00 00:00:00") > 0) {
                                                        try {
                                                                System.IO.FileInfo LazaroFileInfo = new System.IO.FileInfo(CarpetaDescarga + NombreArchivo + ".new");
                                                                DateTime FechaNuevaD = Lfx.Types.Parsing.ParseSqlDateTime(FechaNueva);
                                                                LazaroFileInfo.LastWriteTime = FechaNuevaD;
                                                                LazaroFileInfo.CreationTime = FechaNuevaD;
                                                        } catch (Exception ex) {
                                                                System.Console.WriteLine("ActualizarArchivoDesdeBD: CambiarFecha: " + ex.Message);
                                                                if (Lfx.Environment.SystemInformation.DesignMode)
                                                                        throw;
                                                                // No pude poner la fecha del archivo... estoy en un problema?
                                                        }
                                                }
                                                return true;
                                        } else {
                                                return false;
                                        }
                                } catch (Exception ex) {
                                        // No se puede conectar al servidor de actualizaciones
                                        // Aplicacion.GenericExceptionHandler(ex);
                                        ErrorMessage = "Existe una nueva versión del archivo " + NombreArchivo + ", pero el sistema no puede actualizar automáticamente. Por favor actualice la aplicación manualmente.";
                                        return false;
                                }
                        }
                        return false;
                }


                private bool UpdateFileFromWeb(string aslURL, System.Xml.XmlNode Archivo, bool IgnorarFecha, string nombreCarpeta)
                {
                        bool actualizarArchivoDesdeWebReturn = false;

                        string CarpetaTrabajo = Lfx.Environment.Folders.ApplicationFolder + nombreCarpeta;
                        if (CarpetaTrabajo[CarpetaTrabajo.Length - 1] != System.IO.Path.DirectorySeparatorChar && CarpetaTrabajo[CarpetaTrabajo.Length - 1] != '/')
                                CarpetaTrabajo += System.IO.Path.DirectorySeparatorChar;

                        string CarpetaDescarga = Lfx.Environment.Folders.UpdatesFolder + nombreCarpeta;
                        if (System.IO.Directory.Exists(CarpetaDescarga) == false)
                                System.IO.Directory.CreateDirectory(CarpetaDescarga);

                        string NombreArchivo = Archivo.Attributes["name"].Value;
                        string FechaArchivo = null;
                        string FechaNueva = null;
                        if (Archivo.Attributes["version"] != null)
                                FechaNueva = Archivo.Attributes["version"].Value;

                        if (FechaNueva == null || FechaNueva.Length == 0)
                                FechaNueva = "1901-01-01 00:00:00";

                        if (System.IO.File.Exists(CarpetaTrabajo + NombreArchivo))
                                FechaArchivo = Lfx.Types.Formatting.FormatDateTimeSql(System.IO.File.GetLastWriteTime(CarpetaTrabajo + NombreArchivo));
                        else
                                FechaArchivo = string.Empty;

                        if (IgnorarFecha || string.Compare(FechaNueva, FechaArchivo) > 0) {
                                try {
                                        string Compresion = string.Empty;

                                        System.Windows.Forms.Application.DoEvents();

                                        byte[] Contenido = null;
                                        if (NombreArchivo != "version.xml" && NombreArchivo != "ICSharpCode.SharpZipLib.dll" && System.IO.Path.GetExtension(NombreArchivo).ToUpperInvariant() != ".VER") {
                                                // Intento descargar el archivo comprimido, salvo que sea version.txt o SharpZipLib o un .ver
                                                Compresion = ".bz2";
                                                Contenido = NetGet(aslURL + nombreCarpeta + NombreArchivo + Compresion);
                                        }

                                        if (Contenido == null) {
                                                // Si falló, intento descargar el archivo original
                                                Compresion = string.Empty;
                                                Contenido = NetGet(aslURL + nombreCarpeta + NombreArchivo);
                                        }

                                        if (Contenido /* still */ == null) {
                                                // Si falló, desisto
                                                ErrorMessage = "No se puede descargar " + aslURL + nombreCarpeta + NombreArchivo;
                                                return false;
                                        }

                                        string ChecksumContenido = null;
                                        string ChecksumNuevo = null;
                                        if (Archivo.Attributes["checksum"] != null)
                                                ChecksumNuevo = Archivo.Attributes["checksum"].Value;
                                        //ChecksumNuevo = Ini.ReadString(VersionTxt, NombreArchivo, "Checksum", "0");
                                        //ChecksumContenido = Funciones.MD5(Contenido);

                                        if (ChecksumNuevo == null || ChecksumNuevo == "0" || ChecksumNuevo == ChecksumContenido) {
                                                if (System.IO.File.Exists(CarpetaDescarga + NombreArchivo + ".new" + Compresion))
                                                        System.IO.File.Delete(CarpetaDescarga + NombreArchivo + ".new" + Compresion);

                                                System.Console.Write("Guardando como " + CarpetaDescarga + NombreArchivo + ".new" + Compresion + ": ");
                                                using (System.IO.BinaryWriter wr = new System.IO.BinaryWriter(System.IO.File.OpenWrite(CarpetaDescarga + NombreArchivo + ".new" + Compresion), System.Text.Encoding.Default)) {
                                                        wr.Write(Contenido);
                                                        wr.Close();
                                                }
                                                System.Console.WriteLine("ok.");

                                                if (Compresion == ".bz2") {
                                                        // Si está comprimido, descomprimo
                                                        Lfx.FileFormats.Compression.Archive ArchivoComprimido = new Lfx.FileFormats.Compression.Archive(CarpetaDescarga + NombreArchivo + ".new" + Compresion, Lfx.FileFormats.Compression.ArchiveTypes.BZip2);
                                                        System.Console.Write("Descomprimiendo " + ArchivoComprimido.ArchiveFileName + ": ");
                                                        ArchivoComprimido.Extract(NombreArchivo + ".new", CarpetaDescarga);
                                                        if (System.IO.File.Exists(CarpetaDescarga + NombreArchivo + ".new")) {
                                                                System.Console.WriteLine("ok.");
                                                                // Se descomprimí ok. Borro el .new.bz2
                                                                System.IO.File.Delete(CarpetaDescarga + NombreArchivo + ".new" + Compresion);
                                                                // Y cargo el contenido del archivo descomprimido, para tener
                                                                using (System.IO.FileStream ArchivoStream = new System.IO.FileStream(CarpetaDescarga + NombreArchivo + ".new", System.IO.FileMode.Open, System.IO.FileAccess.Read)) {
                                                                        Contenido = new byte[ArchivoStream.Length];
                                                                        ArchivoStream.Read(Contenido, 0, System.Convert.ToInt32(ArchivoStream.Length));
                                                                        ArchivoStream.Close();
                                                                }
                                                        } else {
                                                                System.Console.WriteLine("error.");
                                                                ErrorMessage = "No se puede descomprimir " + NombreArchivo;
                                                                return false;
                                                        }
                                                }

                                                if (string.Compare(FechaNueva, "1950-00-00 00:00:00") > 0) {
                                                        try {
                                                                System.IO.FileInfo LazaroFileInfo = new System.IO.FileInfo(CarpetaDescarga + NombreArchivo + ".new");
                                                                DateTime FechaNuevaD = Lfx.Types.Parsing.ParseSqlDateTime(FechaNueva);
                                                                LazaroFileInfo.LastWriteTime = FechaNuevaD;
                                                                LazaroFileInfo.CreationTime = FechaNuevaD;
                                                                LazaroFileInfo = null;
                                                        } catch (Exception ex) {
                                                                // Aplicacion.GenericExceptionHandler(ex);
                                                                // No pude poner la fecha del archivo... estoy en un problema?
                                                                if (Lfx.Environment.SystemInformation.DesignMode)
                                                                        throw;
                                                        }
                                                }
                                                actualizarArchivoDesdeWebReturn = true;

                                                // Lo publico en la BD
                                                if (IgnoreOthersUpdating == false && NombreArchivo != "version.xml" && this.DataBase.SlowLink == false && Lfx.Environment.SystemInformation.DesignMode == false) {
                                                        qGen.Delete EliminarArchivoViejo = new qGen.Delete("sys_asl");
                                                        EliminarArchivoViejo.WhereClause = new qGen.Where("nombre", (nombreCarpeta + NombreArchivo).Replace("\\", "/"));
                                                        this.DataBase.Execute(EliminarArchivoViejo);
                                                        qGen.Insert InsertarArchivoNuevo = new qGen.Insert("sys_asl");
                                                        InsertarArchivoNuevo.Fields.AddWithValue("nombre", (nombreCarpeta + NombreArchivo).Replace("\\", "/"));
                                                        InsertarArchivoNuevo.Fields.AddWithValue("fecha", FechaNueva);
                                                        InsertarArchivoNuevo.Fields.AddWithValue("checksum", ChecksumContenido);
                                                        InsertarArchivoNuevo.Fields.AddWithValue("contenido", Contenido);
                                                        this.DataBase.Execute(InsertarArchivoNuevo);
                                                }

                                                if (NombreArchivo == "version.xml" || System.IO.Path.GetExtension(NombreArchivo).ToUpperInvariant() == ".VER") {
                                                        // version.xml no queda como .new
                                                        if (System.IO.File.Exists(CarpetaDescarga + NombreArchivo))
                                                                System.IO.File.Delete(CarpetaDescarga + NombreArchivo);
                                                        System.IO.File.Move(CarpetaDescarga + NombreArchivo + ".new", CarpetaDescarga + NombreArchivo);
                                                }

                                                /* if (NombreArchivo == "version.xml" || NombreArchivo == "Cargador.exe") {
                                                        // version.xml y Cargador.exe se actualizan de inmediato
                                                        if (System.IO.File.Exists(CarpetaTrabajo + NombreArchivo))
                                                                System.IO.File.Delete(CarpetaTrabajo + NombreArchivo);
                                                        System.IO.File.Move(CarpetaDescarga + NombreArchivo + ".new", CarpetaTrabajo + NombreArchivo);
                                                } */
                                        } else {
                                                ErrorMessage = "Existe una nueva versión del archivo " + NombreArchivo + ", pero el sistema no puede actualizarlo automáticamente. Por favor actualice la aplicación manualmente." + System.Environment.NewLine + "La descripción extendida del error es: la suma de verificación no concuerda.";
                                        }
                                } catch (Exception ex) {
                                        System.Console.WriteLine("ActualizarArchivoDesdeWeb: " + ex.Message);
                                        ErrorMessage = "No se puede descargar el archivo " + NombreArchivo + ". Intente actualizar la aplicación manualmente." + System.Environment.NewLine + "La descripción extendida del error es: " + ex.Message;
                                        actualizarArchivoDesdeWebReturn = false;
                                }
                        }
                        return actualizarArchivoDesdeWebReturn;
                }


                /// <summary>
                /// Descarga un archivo desde una URI y lo guarda en el disco.
                /// </summary>
                /// <param name="uri">La URI del archivo a descargar.</param>
                /// <param name="archivo">El nombre del archivo en el disco.</param>
                public static void NetGet(string uri, string archivo)
                {
                        byte[] Contenido = NetGet(uri);

                        if (Contenido != null) {
                                using (System.IO.BinaryWriter wr = new System.IO.BinaryWriter(System.IO.File.OpenWrite(archivo), System.Text.Encoding.Default)) {
                                        wr.Write(Contenido);
                                        wr.Close();
                                }
                        }
                }

                /// <summary>
                /// Descarga un archivo desde una URI.
                /// </summary>
                /// <param name="uri">La URI del archivo a descargar.</param>
                /// <returns>Una matriz de bytes con el contenido del archivo descargado.</returns>
                private static byte[] NetGet(string uri)
                {
                        try {
                                System.Console.Write("Descargando " + uri + ": ");
                                System.Net.WebRequest Solicitud = null;
                                Solicitud = System.Net.WebRequest.CreateDefault(new System.Uri(uri));
                                System.Net.WebResponse Respuesta = Solicitud.GetResponse();
                                byte[] Contenido = new byte[Respuesta.ContentLength];
                                int ReadPos = 0;
                                System.IO.StreamReader Lector = new System.IO.StreamReader(Respuesta.GetResponseStream(), System.Text.Encoding.Default);
                                while (Lector.EndOfStream == false) {
                                        char[] BufferChar = new char[2048];
                                        int Leido = Lector.Read(BufferChar, 0, BufferChar.Length);
                                        byte[] BufferBytes = Lector.CurrentEncoding.GetBytes(BufferChar, 0, Leido);
                                        Array.Copy(BufferBytes, 0, Contenido, ReadPos, Leido);
                                        ReadPos += Leido;
                                        System.Windows.Forms.Application.DoEvents();
                                }
                                Lector.Close();
                                Respuesta.Close();
                                System.Console.WriteLine("ok.");
                                return Contenido;
                        } catch (Exception ex) {
                                System.Console.WriteLine(ex.Message);
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw;
                                return null;
                        }
                }
        }
}