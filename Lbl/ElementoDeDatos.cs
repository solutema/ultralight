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
using System.Collections.Generic;
using System.Text;

namespace Lbl
{
        /// <summary>
        /// Proporciona acceso a los datos con alto nivel de abstracción.
        /// Normalmente refleja un registro de la base de datos como un objeto con propiedades y métodos.
        /// </summary>
        [Serializable]
        public abstract class ElementoDeDatos : System.MarshalByRefObject
	{
		public Lfx.Data.DataBase DataBase = null;

		protected int m_ItemId = 0;
		protected Lfx.Data.Row m_Registro = null, m_RegistroOriginal = null;
                protected System.Drawing.Image m_Imagen = null;
                protected bool m_ImagenCambio = false;
                protected ColeccionGenerica<Etiqueta> m_Etiquetas = null, m_EtiquetasOriginal = null;

		protected ElementoDeDatos(Lfx.Data.DataBase dataBase)
		{
			this.DataBase = dataBase;
		}

                public ElementoDeDatos(Lfx.Data.DataBase dataBase, int itemId)
                        : this(dataBase)
                {
                        m_ItemId = itemId;
                }

                public ElementoDeDatos(Lfx.Data.DataBase dataBase, Lfx.Data.Row fromRow)
                        : this(dataBase)
                {
                        this.FromRow(fromRow);
                }

                protected void FromRow(Lfx.Data.Row fromRow)
                {
                        this.Cargar(fromRow);
                }

		#region Propiedades

		public int Id
		{
			get
			{
				return m_ItemId;
			}
		}

                public virtual Lfx.Data.Row RegistroOriginal
                {
                        get
                        {
                                return m_RegistroOriginal;
                        }
                }

		public virtual Lfx.Data.Row Registro
		{
			get
			{
                                if (m_Registro == null) {
                                        m_Etiquetas = null;
                                        Lfx.Data.Row Reg = null;
                                        if (this.Id != 0) {
                                                if (this.DataBase.InTransaction == false && this.CampoId == this.DataBase.Tables[this.TablaDatos].PrimaryKey
                                                                && this.DataBase.InTransaction == false)
                                                        // Si estoy accediendo a través de una clave primaria y no estoy en una transacción
                                                        // puedo usar directamente DataBase.Tables.FastRows, que es cacheable
                                                        Reg = this.DataBase.Tables[this.TablaDatos].FastRows[this.Id];
                                                else
                                                        //De lo contrario uso DataBase.Row que termina en un SELECT común
                                                        Reg = this.DataBase.Row(this.TablaDatos, this.CampoId, this.Id);
                                        }

                                        this.Cargar(Reg);
                                }
				return m_Registro;
			}
		}

                public virtual void OnLoad()
                {
                        
                }


                public virtual string TablaDatos
		{
			get
                        {
                                throw new InvalidOperationException("No se puede instanciar ElementoDeDatos");
                        }
		}

                public virtual string TablaImagenes
                {
                        get
                        {
                                return this.TablaDatos;
                        }
                }


                public virtual string CampoId
		{
                        get
                        {
                                throw new InvalidOperationException("No se puede instanciar ElementoDeDatos");
                        }
		}

                public virtual string CampoNombre
		{
			get
			{
				return "nombre";
			}
		}

		public Lfx.Workspace Workspace
		{
			get
			{
				return this.DataBase.Workspace;
			}
		}

		//Campos estándar
		
		public virtual string Nombre
		{
			get
			{
                                return this.FieldString(CampoNombre);
			}
			set
			{
				this.Registro[CampoNombre] = value;
			}
		}

		public virtual string Obs
		{
			get
			{
				if(this.Registro["obs"] == null || this.Registro["obs"] == DBNull.Value)
					return null;
				else
					return this.Registro["obs"].ToString();
			}
			set
			{
                                string NuevaObs = value;

                                if (NuevaObs != null) {
                                        if (NuevaObs.Length >= 2 && NuevaObs.Substring(NuevaObs.Length - 2, 2) == Lfx.Types.ControlChars.CrLf)
                                                //Quito el CrLf al final
                                                NuevaObs = NuevaObs.Substring(0, NuevaObs.Length - 2);
                                        else if (NuevaObs.Length >= 1 && NuevaObs.Substring(NuevaObs.Length - 1, 1) == Lfx.Types.ControlChars.Lf.ToString())
                                                //Quito el Lf al final (para Unix)
                                                NuevaObs = NuevaObs.Substring(0, NuevaObs.Length - 1);

                                        if (NuevaObs.Length > 5 && NuevaObs.Substring(0, 5) == " /// ")
                                                NuevaObs = NuevaObs.Substring(5, NuevaObs.Length - 5);
                                }

                                this.Registro["obs"] = NuevaObs;
			}
		}

		public virtual int Estado
		{
			get
			{
				return this.FieldInt("estado");
			}
			set
			{
				this.Registro["estado"] = value;
			}
		}

                /// <summary>
                /// True si la imagen fue cambiada.
                /// </summary>
                public bool ImagenCambio
                {
                        get
                        {
                                return m_ImagenCambio;
                        }
                }

                public virtual System.Drawing.Image Imagen
                {
                        get
                        {
                                if (m_Imagen == null && m_ImagenCambio == false) {
                                        // FIXME: Para los artículos sin imagen, evitar hacer esta consulta cada vez que se accede a la propiedad
                                        Lfx.Data.Row Imagen = null;
                                        if(DataBase.Tables[this.TablaImagenes].PrimaryKey == null)
                                                Imagen = DataBase.Row(this.TablaImagenes, "imagen", this.CampoId, this.Id);
                                        else
                                                Imagen = DataBase.Tables[this.TablaImagenes].FastRows[this.Id];

                                        if (Imagen != null && Imagen["imagen"] != null && ((byte[])(Imagen["imagen"])).Length > 5) {
                                                byte[] ByteArr = ((byte[])(Imagen["imagen"]));
                                                System.IO.MemoryStream loStream = new System.IO.MemoryStream(ByteArr);
                                                try {
                                                        this.m_Imagen = System.Drawing.Image.FromStream(loStream);
                                                        m_ImagenCambio = false;
                                                } catch {
                                                        this.m_Imagen = null;
                                                }
                                        }
                                }
                                return m_Imagen;
                        }
                        set
                        {
                                if (m_Imagen != value)
                                        m_ImagenCambio = true;
                                m_Imagen = value;
                        }
                }


		#endregion

		#region Métodos

                /// <summary>
                /// Crea un nuevo elemento, con sus valores predeterminados.
                /// </summary>
		public virtual Lfx.Types.OperationResult Crear()
		{
                        m_ItemId = 0;
			m_Registro = new Lfx.Data.Row();
                        m_RegistroOriginal = null;
                        m_Etiquetas = null;
                        return new Lfx.Types.SuccessOperationResult();
		}

                /// <summary>
                /// Agrega un comentario al historial de este elemento.
                /// </summary>
                /// <param name="texto">El texto del comentario.</param>
                public void AgregarComentario(string texto)
                {
                        if (this.Existe == false)
                                throw new InvalidOperationException("No se pueden agregar comentarios a un elemento que no existe en la base de datos");

                        qGen.Insert NuevoCom = new qGen.Insert("sys_comments");
                        NuevoCom.Fields.AddWithValue("tablas", this.TablaDatos);
                        NuevoCom.Fields.AddWithValue("item_id", this.Id);
                        NuevoCom.Fields.AddWithValue("id_persona", this.Workspace.CurrentUser.Id);
                        NuevoCom.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        NuevoCom.Fields.AddWithValue("obs", texto);

                        this.DataBase.Execute(NuevoCom);
                }

                /// <summary>
                /// Guarda los cambios en la base de datos.
                /// </summary>
		public virtual Lfx.Types.OperationResult Guardar()
		{
                        if (this.Id == 0) {
                                // Acabo de insertar, averiguo mi propio id
                                m_ItemId = this.DataBase.FieldInt("SELECT LAST_INSERT_ID()");
                        } else {
                                // Es un registro antiguo, lo elimino de la caché
                                this.DataBase.Tables[this.TablaDatos].FastRows.RemoveFromCache(this.Id);
                        }

                        if (this.m_ImagenCambio) {
                                // Hay cambios en el campo imagen
                                if (this.Imagen == null) {
                                        // Eliminó la imagen
                                        if (this.TablaImagenes == this.TablaDatos) {
                                                // La imagen reside en un campo de la misma tabla
                                                qGen.Update ActualizarImagen = new qGen.Update(this.TablaImagenes);
                                                ActualizarImagen.Fields.AddWithValue("imagen", null);
                                                ActualizarImagen.WhereClause = new qGen.Where(this.CampoId, this.Id);
                                                this.DataBase.Execute(ActualizarImagen);
                                        } else {
                                                // Usa una tabla separada para las imágenes
                                                qGen.Delete EliminarImagen = new qGen.Delete(this.TablaImagenes);
                                                EliminarImagen.WhereClause = new qGen.Where(this.CampoId, this.Id);
                                                this.DataBase.Execute(EliminarImagen);
                                        }
                                        this.Workspace.ActionLog("SAVE", this.TablaDatos, this.Id, "Se eliminó la imagen");
                                } else {
                                        // Cargar imagen nueva
                                        using (System.IO.MemoryStream ByteStream = new System.IO.MemoryStream()) {
                                                System.Drawing.Imaging.ImageCodecInfo CodecInfo = null;
                                                System.Drawing.Imaging.ImageCodecInfo[] Codecs = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders();
                                                foreach (System.Drawing.Imaging.ImageCodecInfo Codec in Codecs) {
                                                        if (Codec.MimeType == "image/jpeg")
                                                                CodecInfo = Codec;
                                                }

                                                if (CodecInfo == null) {
                                                        this.Imagen.Save(ByteStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                } else {
                                                        System.Drawing.Imaging.Encoder QualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                                                        using (System.Drawing.Imaging.EncoderParameters EncoderParams = new System.Drawing.Imaging.EncoderParameters(1)) {
                                                                EncoderParams.Param[0] = new System.Drawing.Imaging.EncoderParameter(QualityEncoder, 33L);

                                                                this.Imagen.Save(ByteStream, CodecInfo, EncoderParams);
                                                        }
                                                }
                                                byte[] ImagenBytes = ByteStream.ToArray();

                                                qGen.TableCommand CambiarImagen;
                                                if (this.TablaImagenes != this.TablaDatos) {
                                                        qGen.Delete EliminarImagen = new qGen.Delete(this.TablaImagenes);
                                                        EliminarImagen.WhereClause = new qGen.Where(this.CampoId, this.Id);
                                                        this.DataBase.Execute(EliminarImagen);

                                                        CambiarImagen = new qGen.Insert(DataBase, this.TablaImagenes);
                                                        CambiarImagen.Fields.AddWithValue(this.CampoId, this.Id);
                                                } else {
                                                        CambiarImagen = new qGen.Update(DataBase, this.TablaImagenes);
                                                        CambiarImagen.WhereClause = new qGen.Where(this.CampoId, this.Id);
                                                }

                                                CambiarImagen.Fields.AddWithValue("imagen", ImagenBytes);
                                                this.DataBase.Execute(CambiarImagen);
                                                this.Workspace.ActionLog("SAVE", this.TablaDatos, this.Id, "Se cargó una imagen nueva");
                                        }
                                }
                        }

                        // Elimino las etiquetas que ya no están.
                        ColeccionGenerica<Etiqueta> ListaEtiquetas = this.Etiquetas.Quitados(m_EtiquetasOriginal);
                        if (ListaEtiquetas != null && ListaEtiquetas.Count > 0) {
                                qGen.Delete EliminarEtiquetas = new qGen.Delete(this.DataBase, "sys_labels_values");
                                EliminarEtiquetas.WhereClause = new qGen.Where("item_id", this.Id);
                                EliminarEtiquetas.WhereClause.Add(new qGen.ComparisonCondition("id_label", qGen.ComparisonOperators.In, ListaEtiquetas.GetAllIds()));
                                this.DataBase.Execute(EliminarEtiquetas);
                        }

                        // Agrego las etiquetas nuevas.
                        ListaEtiquetas = this.Etiquetas.Agregados(m_EtiquetasOriginal);
                        if (ListaEtiquetas != null && ListaEtiquetas.Count > 0) {
                                foreach (ElementoDeDatos El in ListaEtiquetas.List) {
                                        qGen.Insert CrearEtiquetas = new qGen.Insert(this.DataBase, "sys_labels_values");
                                        CrearEtiquetas.Fields.AddWithValue("id_label", El.Id);
                                        CrearEtiquetas.Fields.AddWithValue("item_id", this.Id);
                                        this.DataBase.Execute(CrearEtiquetas);
                                }
                        }

                        this.GuardarLog();
                        this.Workspace.NotifyTableChange(this.TablaDatos, this.Id);

                        this.m_RegistroOriginal = this.m_Registro.Clone();
                        this.m_EtiquetasOriginal = this.m_Etiquetas.Clone();
                        this.m_ImagenCambio = false;
			this.m_Registro.IsNew = false;
			
                        return new Lfx.Types.SuccessOperationResult();
		}

                private void GuardarLog()
                {
                        string Extra1 = null;
                        try {
                                // Genero una lista de cambios
                                foreach (Lfx.Data.Field Fl in this.m_Registro.Fields) {
                                        object ValorOriginal = null, ValorNuevo = this.m_Registro[Fl.ColumnName];
                                        if (this.m_RegistroOriginal != null && this.m_RegistroOriginal.Fields != null)
                                                ValorOriginal = this.m_RegistroOriginal[Fl.ColumnName];

                                        if (Lfx.Types.Object.ObjectsEqualByValue(ValorOriginal, ValorNuevo) == false) {
                                                if (Extra1 == null)
                                                        Extra1 = "";
                                                else
                                                        Extra1 += "; ";

                                                Extra1 += Fl.ColumnName + "=";
                                                if (ValorOriginal != null)
                                                        Extra1 += "\'" + this.DataBase.EscapeString(ValorOriginal.ToString()) + "\'->";
                                                else
                                                        Extra1 += "NULL->";

                                                if (ValorNuevo != null)
                                                        Extra1 += "\'" + this.DataBase.EscapeString(ValorNuevo.ToString()) + "\'";
                                                else
                                                        Extra1 += "NULL";
                                        }
                                }
                        } catch {
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw;
                        }

                        try {
                                //System.Console.WriteLine(Extra1);
                                this.Workspace.ActionLog("SAVE", this.TablaDatos, this.Id, Extra1);
                        } catch {
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw;
                        }
                }

                /// <summary>
                /// Agrega los campos personalizados (tags) al comando, antes de guardar.
                /// </summary>
                /// <param name="comando">El parámetro al cual agregar los campos.</param>
		public virtual void AgregarTags(qGen.Command comando)
		{
			this.AgregarTags(comando, this.Registro, this.TablaDatos);
		}
		
                public virtual void AgregarTags(qGen.Command comando, Lfx.Data.Row registro, string tabla)
                {
                        Lfx.Data.Table Tabla = this.DataBase.Tables[tabla];
                        if (Tabla.Tags != null) {
                                foreach (Lfx.Data.Tag Tg in Tabla.Tags) {
                                        if (Tg.Nullable == false && registro[Tg.FieldName] == null) {
                                                switch (Tg.FieldType) {
                                                        case Lfx.Data.DbTypes.Currency:
                                                        case Lfx.Data.DbTypes.Integer:
                                                        case Lfx.Data.DbTypes.SmallInt:
                                                        case Lfx.Data.DbTypes.Numeric:
                                                                comando.Fields.AddWithValue(Tg.FieldName, 0);
                                                                break;
                                                        default:
                                                                comando.Fields.AddWithValue(Tg.FieldName, "");
                                                                break;
                                                }
                                        } else {
                                                comando.Fields.AddWithValue(Tg.FieldName, registro[Tg.FieldName]);
                                        }
                                }
                        }
                }

                /// <summary>
                /// Devuelve Verdadero si el elemento existe en la base de datos.
                /// </summary>
		public bool Existe
		{
                        get
                        {
                                return !Registro.IsNew;
                        }
		}

		protected string FieldString(string fieldName)
		{
			if(this.Registro[fieldName] == null)
				return null;
			else
				return this.Registro[fieldName].ToString();
		}

		protected int FieldInt(string fieldName)
		{
                        if (this.Registro[fieldName] == null || this.Registro[fieldName] == DBNull.Value)
                                return 0;
                        else
                                return System.Convert.ToInt32(this.Registro[fieldName]);
		}

		protected double FieldDouble(string fieldName)
		{
                        if (this.Registro[fieldName] == null)
                                return 0;
                        else
			        return System.Convert.ToDouble(this.Registro[fieldName]);
		}

                protected Lfx.Types.LDateTime FieldDateTime(string fieldName)
		{
			if(this.Registro[fieldName] == null)
				return null;
                        if (this.Registro[fieldName] is Lfx.Types.LDateTime)
                                return this.Registro[fieldName] as Lfx.Types.LDateTime;
			else
				return new Lfx.Types.LDateTime(System.Convert.ToDateTime(this.Registro[fieldName]));
		}

		public override string ToString()
		{
			return this.Registro[this.CampoNombre].ToString();
		}

                /// <summary>
                /// Carga el elemento desde la base de datos.
                /// </summary>
		public virtual Lfx.Types.OperationResult Cargar()
		{
			if(m_ItemId == 0)
				return this.Crear();

			this.m_Registro = null;
                        this.m_RegistroOriginal = null;
                        this.m_Etiquetas = null;
                        this.m_ImagenCambio = false;
                        this.m_Imagen = null;
                        Lfx.Data.Row Dummy = this.Registro;

			if (Dummy == null)
                                return new Lfx.Types.FailureOperationResult("No se pudo cargar el registro");
                        else
				return new Lfx.Types.SuccessOperationResult();
		}

                /// <summary>
                /// Carga un elemento por su Id desde la base de datos.
                /// </summary>
		public Lfx.Types.OperationResult Cargar(int itemId)
		{
			m_ItemId = itemId;
			return this.Cargar();
		}

                /// <summary>
                /// Carga un elemento por su Id desde un registro
                /// </summary>
                public Lfx.Types.OperationResult Cargar(Lfx.Data.Row row)
                {
                        this.m_Etiquetas = null;
                        this.m_ImagenCambio = false;
                        this.m_Imagen = null;

                        m_Registro = row;
                        if (m_Registro != null) {
                                m_ItemId = System.Convert.ToInt32(m_Registro[this.CampoId]);
                                m_Registro.IsNew = row.IsNew;
                                m_Registro.IsModified = row.IsModified;
                                m_RegistroOriginal = m_Registro.Clone();
                                this.OnLoad();
                        } else {
                                m_ItemId = 0;
                                m_Registro = new Lfx.Data.Row();
                                m_RegistroOriginal = m_Registro.Clone();
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

		#endregion
                
                /// <summary>
                /// Devuelve o establece una colección de etiquetas del elemento.
                /// </summary>
                public ColeccionGenerica<Etiqueta> Etiquetas
                {
                        get
                        {
                                if (m_Etiquetas == null) {
                                        m_Etiquetas = new ColeccionGenerica<Etiqueta>();
                                        System.Data.DataTable EtiquetasElem = this.DataBase.Select("SELECT id_label FROM sys_labels_values WHERE id_label IN (SELECT id_label FROM sys_labels WHERE tablas='" + this.TablaDatos + "') AND item_id=" + this.Id.ToString());
                                        foreach(System.Data.DataRow TagRow in EtiquetasElem.Rows) {
                                                m_Etiquetas.Add(new Etiqueta(this.DataBase, (Lfx.Data.Row)TagRow));
                                        }
                                        this.m_EtiquetasOriginal = m_Etiquetas.Clone();
                                }
                                return m_Etiquetas;
                        }
                        set
                        {
                                m_Etiquetas = value;
                        }
                }
	}
}