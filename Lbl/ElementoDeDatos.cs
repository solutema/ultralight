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
using System.Collections.Generic;
using System.Text;

namespace Lbl
{
        /// <summary>
        /// Proporciona acceso a los datos con alto nivel de abstracción.
        /// Normalmente refleja un registro de la base de datos como un objeto con propiedades y métodos.
        /// </summary>
	abstract public class ElementoDeDatos
	{
		public Lws.Data.DataView DataView = null;

		protected int m_ItemId = 0;
		protected Lfx.Data.Row m_Registro = null, m_RegistroOriginal = null;
                protected System.Drawing.Image m_Imagen = null;
                protected bool m_ImagenCambio = false;

		protected ElementoDeDatos(Lws.Data.DataView dataView)
		{
			this.DataView = dataView;
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
                                        } else {
                                                m_Registro = new Lfx.Data.Row();
                                        }
                                        m_RegistroOriginal = m_Registro.Clone();

                                        if (m_Registro != null)
                                                this.OnLoad();
                                }
				return m_Registro;
			}
		}

                public virtual void OnLoad()
                {
                        
                }


		public abstract string TablaDatos
		{
			get;
		}

                public virtual string TablaImagenes
                {
                        get
                        {
                                return this.TablaDatos;
                        }
                }


                public abstract string CampoId
		{
			get;
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
                                if (value != null && value.Length >= 2 && value.Substring(value.Length - 2, 2) == Lfx.Types.ControlChars.CrLf)
                                        //Quito el CrLf al final
                                        this.Registro["obs"] = value.Substring(0, value.Length - 2);
                                else
                                        this.Registro["obs"] = value;
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
                                        // TODO: Para los artículos sin imagen, evitar hacer esta consulta cada vez que se accede a la propiedad
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

		public virtual Lfx.Types.OperationResult Crear()
		{
                        m_ItemId = 0;
			m_Registro = new Lfx.Data.Row();
                        m_RegistroOriginal = null;
			return new Lfx.Types.SuccessOperationResult();
		}

		public virtual Lfx.Types.OperationResult Guardar()
		{
			string Extra1 = null;
                        try {
                                //Intento generar una lista de cambios
                                foreach (Lfx.Data.Field Fl in this.m_Registro.Fields) {
                                        object ValorOriginal = null, ValorNuevo = this.m_Registro[Fl.ColumnName];
                                        if (this.m_RegistroOriginal != null && this.m_RegistroOriginal.Fields != null)
                                                ValorOriginal = this.m_RegistroOriginal[Fl.ColumnName];

                                        if (ObjectEquals(ValorOriginal, ValorNuevo) == false) {
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
                        this.m_ImagenCambio = false;
			this.m_Registro.IsNew = false;
			
                        return new Lfx.Types.SuccessOperationResult();
		}

				
		private bool ObjectEquals(object val1, object val2)
		{

			object a = val1, b = val2;

			//Convierto booleanos a enteros para poder comparar False == 0
			//Convierto enums a enteros, por la misma razón

                        if (val1 == null)
                                return val2 == null;

                        if (val2 == null)
                                return val1 == null;

			if (val1 is bool)
				a = (bool)val1 ? 1 : 0;
			else if (val1.GetType().IsEnum)
				a = (int)val1;
			
			if (val2 is bool)
				b = (bool)val2 ? 1 : 0;
			else if (val2.GetType().IsEnum)
				b = (int)val2;
			
			if((a is short || a is int || a is long)
			   && (b is short || b is int || b is long)) {
				return System.Convert.ToInt64(a) == System.Convert.ToInt64(b);
			} else if(b is double && a is double) {
				return System.Convert.ToDouble(a) == System.Convert.ToDouble(b);
			} else if(b is decimal && a is decimal) {
				return System.Convert.ToDecimal(a) == System.Convert.ToDecimal(b);
                        } else if ((b is decimal && a is double) || (b is double && a is decimal)) {
                                return System.Convert.ToDecimal(a) == System.Convert.ToDecimal(b);
			} else if(a is DateTime && b is DateTime) {
				return System.Convert.ToDateTime(a) == System.Convert.ToDateTime(b);
			} else {
				return System.Convert.ToString(a) == System.Convert.ToString(b);
			}
		}

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

		protected DateTime? FieldDateTime(string fieldName)
		{
			if(this.Registro[fieldName] == null)
				return null;
			else
				return System.Convert.ToDateTime(this.Registro[fieldName]);
		}

		public override string ToString()
		{
			return this.Registro[this.CampoNombre].ToString();
		}

		public virtual Lfx.Types.OperationResult Cargar()
		{
			if(m_ItemId == 0)
				return this.Crear();

			this.m_Registro = null;
                        this.m_RegistroOriginal = null;
                        this.m_ImagenCambio = false;
                        this.m_Imagen = null;
			Lfx.Data.Row Dummy = this.Registro;

			if (Dummy == null)
                                return new Lfx.Types.FailureOperationResult("No se pudo cargar el registro");
                        else
				return new Lfx.Types.SuccessOperationResult();
		}

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

	}
}