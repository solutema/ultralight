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
using System.Collections.Generic;
using System.Text;

namespace Lbl
{
        /// <summary>
        /// Proporciona acceso a los datos con alto nivel de abstracción.
        /// Normalmente refleja un registro de la base de datos como un objeto con propiedades y métodos.
        /// </summary>
	public abstract class ElementoDeDatos
	{
		public Lws.Data.DataView DataView = null;

		protected int m_ItemId = 0;
		protected Lfx.Data.Row m_Registro = null, m_RegistroOriginal = null;
                protected System.Drawing.Image m_Imagen = null;
                protected bool m_ImagenCambio = false;
                protected ColeccionDeEtiquetas m_Etiquetas = null, m_EtiquetasOriginal = null;

		protected ElementoDeDatos(Lws.Data.DataView dataView)
		{
			this.DataView = dataView;
		}

                public ElementoDeDatos(Lws.Data.DataView dataView, Lfx.Data.Row fromRow)
                        : this(dataView)
                {
                        this.FromRow(fromRow);
                }

                protected void FromRow(Lfx.Data.Row fromRow)
                {
                        m_Registro = fromRow;
                        m_ItemId = System.Convert.ToInt32(m_Registro[this.CampoId]);
                        m_RegistroOriginal = m_Registro.Clone();
                        this.OnLoad();
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
                                        if (this.Id != 0) {
                                                if (this.CampoId == this.DataView.Tables[this.TablaDatos].PrimaryKey)
                                                        //Si estoy accediendo a través de una clave primaria puedo usar directamente DataView.Tables.FastRows, que es cacheable
                                                        m_Registro = this.DataView.Tables[this.TablaDatos].FastRows[this.Id];
                                                else
                                                        //De lo contrario uso DataBase.Row que termina en un SELECT común
                                                        m_Registro = this.DataView.DataBase.Row(this.TablaDatos, this.CampoId, this.Id);
                                        }

                                        if (m_Registro != null) {
                                                m_Registro.IsNew = false;
                                                m_Registro.IsModified = false;
						m_RegistroOriginal = m_Registro.Clone();
						this.OnLoad();
                                        } else {
                                                m_Registro = new Lfx.Data.Row();
						m_RegistroOriginal = m_Registro.Clone();
                                        }
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

		public Lws.Workspace Workspace
		{
			get
			{
				return DataView.Workspace;
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

                public virtual System.Drawing.Image Imagen
                {
                        get
                        {
                                if (m_Imagen == null && m_ImagenCambio == false) {
                                        // FIXME: Para los artículos sin imagen, evitar hacer esta consulta cada vez que se accede a la propiedad
                                        Lfx.Data.Row Imagen = DataView.DataBase.Row(this.TablaImagenes, "imagen", this.CampoId, this.Id);

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
                /// Guarda los cambios en la base de datos.
                /// </summary>
		public virtual Lfx.Types.OperationResult Guardar()
		{
                        // Elimino las etiquetas que ya no están.
                        ColeccionDeElementos ListaEtiquetas = this.Etiquetas.Quitados(m_EtiquetasOriginal);
                        if (ListaEtiquetas != null && ListaEtiquetas.Count > 0) {
                                Lfx.Data.SqlDeleteBuilder EliminarEtiquetas = new Lfx.Data.SqlDeleteBuilder(this.DataView.DataBase, "sys_labels_values");
                                EliminarEtiquetas.WhereClause = new Lfx.Data.SqlWhereBuilder("tabla", this.TablaDatos);
                                EliminarEtiquetas.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("item_id", this.Id));
                                EliminarEtiquetas.WhereClause.Conditions.Add("id_label IN (" + string.Join(", ", ListaEtiquetas.Ids()) + ")");
                                this.DataView.Execute(EliminarEtiquetas);
                        }

                        // Agrego las etiquetas nuevas.
                        ListaEtiquetas = this.Etiquetas.Agregados(m_EtiquetasOriginal);
                        if (ListaEtiquetas != null && ListaEtiquetas.Count > 0) {
                                foreach (ElementoDeDatos El in ListaEtiquetas) {
                                        Lfx.Data.SqlInsertBuilder CrearEtiquetas = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, "sys_labels_values");
                                        CrearEtiquetas.Fields.AddWithValue("id_label", El.Id);
                                        CrearEtiquetas.Fields.AddWithValue("item_id", this.Id);
                                        this.DataView.Execute(CrearEtiquetas);
                                }
                        }

			string Extra1 = null;
                        try {
                                //Intento generar una lista de cambios
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
                                                        Extra1 += "\'" + this.DataView.DataBase.EscapeString(ValorOriginal.ToString()) + "\'->";
                                                else
                                                        Extra1 += "NULL->";

                                                if (ValorNuevo != null)
                                                        Extra1 += "\'" + this.DataView.DataBase.EscapeString(ValorNuevo.ToString()) + "\'";
                                                else
                                                        Extra1 += "NULL";
                                        }
                                }
                        } catch {
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw;
                        }

			try
			{
				//System.Console.WriteLine(Extra1);
				this.Workspace.ActionLog("SAVE", this.TablaDatos, this.Id, Extra1);
			}
			catch
			{
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw;
			}

                        this.Workspace.NotifyTableChange(this.TablaDatos, this.Id);

                        this.m_RegistroOriginal = this.m_Registro.Clone();
                        this.m_EtiquetasOriginal = ((ColeccionDeEtiquetas)(this.m_Etiquetas.Clone()));
                        this.m_ImagenCambio = false;
			this.m_Registro.IsNew = false;
			
                        return new Lfx.Types.SuccessOperationResult();
		}

                /// <summary>
                /// Agrega los campos personalizados (tags) al comando, antes de guardar.
                /// </summary>
                /// <param name="comando">El parámetro al cual agregar los campos.</param>
		public virtual void AgregarTags(Lfx.Data.SqlCommandBuilder comando)
		{
			this.AgregarTags(comando, this.Registro, this.TablaDatos);
		}
		
                public virtual void AgregarTags(Lfx.Data.SqlCommandBuilder comando, Lfx.Data.Row registro, string tabla)
                {
                        Lws.Data.Table Tabla = this.DataView.Tables[tabla];
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

		public void BeginTransaction()
		{
			DataView.DataBase.BeginTransaction();
		}

		public void Commit()
		{
			DataView.DataBase.Commit();
		}

		public void RollBack()
		{
			DataView.DataBase.RollBack();
		}

		#endregion
                
                /// <summary>
                /// Devuelve o establece una colección de etiquetas del elemento.
                /// </summary>
                public ColeccionDeEtiquetas Etiquetas
                {
                        get
                        {
                                if (m_Etiquetas == null) {
                                        m_Etiquetas = new ColeccionDeEtiquetas();
                                        System.Data.IDataReader EtiquetasElem = this.DataView.DataBase.GetReader("SELECT id_label FROM sys_labels_values WHERE id_label IN (SELECT id_label FROM sys_labels WHERE tablas='" + this.TablaDatos + "') AND item_id=" + this.Id.ToString());
                                        while (EtiquetasElem.Read()) {
                                                m_Etiquetas.Add(new Etiqueta(this.DataView, EtiquetasElem.GetInt32(0)));
                                        }
                                        EtiquetasElem.Close();
                                        this.m_EtiquetasOriginal = ((ColeccionDeEtiquetas)(this.m_Etiquetas.Clone()));
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