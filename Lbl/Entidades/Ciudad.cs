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

namespace Lbl.Entidades
{
        public enum TipoLocalidad
        {
                Provincia = 0,
                Departamento = 1,
                Localidad = 2
        }

	public class Localidad : ElementoDeDatos
	{
                private Localidad m_Parent = null;

		//Heredar constructor
		public Localidad(Lfx.Data.DataBase dataBase) : base(dataBase) { }

		public Localidad(Lfx.Data.DataBase dataBase, int itemId)
			: this(dataBase)
		{
			m_ItemId = itemId;
		}

		public override string TablaDatos
		{
			get
			{
				return "ciudades";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_ciudad";
			}
		}

                public int Nivel
                {
                        get
                        {
                                return this.FieldInt("nivel");
                        }
                        set
                        {
                                this.Registro["nivel"] = value;
                        }
                }

                public string CodigoPostal
                {
                        get
                        {
                                return this.FieldString("cp");
                        }
                        set
                        {
                                this.Registro["cp"] = value;
                        }
                }

                public TipoLocalidad TipoLocalidad
                {
                        get
                        {
                                return ((TipoLocalidad)(this.Nivel));
                        }
                        set
                        {
                                this.Nivel = (int)value;
                        }
                }

                public Localidad Parent
                {
                        get
                        {
                                if (m_Parent == null) {
                                        if (this.Registro["parent"] != null)
                                                m_Parent = new Localidad(this.DataBase, this.FieldInt("parent"));
                                }
                                return m_Parent;
                        }
                        set
                        {
                                m_Parent = value;
                                if (value == null)
                                        this.Registro["parent"] = null;
                                else
                                        this.Registro["parent"] = m_Parent.Id;
                        }
                }

                public Localidad Departamento
                {
                        get
                        {
                                switch (this.TipoLocalidad) {
                                        case Entidades.TipoLocalidad.Provincia:
                                                return null;
                                        case Entidades.TipoLocalidad.Departamento:
                                                return this;
                                        case Entidades.TipoLocalidad.Localidad:
                                                return this.Parent;
                                        default:
                                                throw new InvalidProgramException("Tipo de Localidad desconocido");
                                }
                        }
                        set
                        {
                                switch (this.TipoLocalidad) {
                                        case Entidades.TipoLocalidad.Provincia:
                                                throw new InvalidOperationException("No se puede establecer el Departamento de una Provincia");
                                        case Entidades.TipoLocalidad.Departamento:
                                                throw new InvalidOperationException("No se puede establecer el Departamento de un Departamento");
                                        case Entidades.TipoLocalidad.Localidad:
                                                this.Parent = value;
                                                break;
                                }
                        }
                }

                public Localidad Provincia
                {
                        get
                        {
                                switch (this.TipoLocalidad) {
                                        case Entidades.TipoLocalidad.Provincia:
                                                return this;
                                        case Entidades.TipoLocalidad.Departamento:
                                                return this.Parent;
                                        case Entidades.TipoLocalidad.Localidad:
                                                if (this.Parent == null)
                                                        return null;
                                                else
                                                        return this.Parent.Parent;
                                        default:
                                                throw new InvalidProgramException("Tipo de Localidad desconocido");
                                }
                        }
                        set
                        {
                                switch (this.TipoLocalidad) {
                                        case Entidades.TipoLocalidad.Provincia:
                                                throw new InvalidOperationException("No se puede establecer la Provincia de una Provincia");
                                        case Entidades.TipoLocalidad.Departamento:
                                                this.Parent = value;
                                                break;
                                        case Entidades.TipoLocalidad.Localidad:
                                                throw new InvalidOperationException("No se puede establecer la Provincia de una Ciudad directamente, debe establecer el Departamento");
                                }
                        }
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.DataBase, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(this.DataBase, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("cp", this.CodigoPostal);
                        if (this.Parent == null) {
                                Comando.Fields.AddWithValue("parent", null);
                                Comando.Fields.AddWithValue("nivel", 0);
                        } else {
                                Comando.Fields.AddWithValue("parent", this.Parent.Id);
                                Comando.Fields.AddWithValue("nivel", this.Parent.Nivel + 1);
                        }

                        this.AgregarTags(Comando);

                        this.DataBase.Execute(Comando);

                        return base.Guardar();
                }
	}
}
