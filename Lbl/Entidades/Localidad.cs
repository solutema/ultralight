#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

        /// <summary>
        /// Representa una Provincia, Departamento o Localidad.
        /// </summary>
        [Lbl.Atributos.NombreItem("Localidad")]
	public class Localidad : ElementoDeDatos
	{
                private Localidad m_Parent = null;

		//Heredar constructor
		public Localidad(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Localidad(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Localidad(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

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
                                return this.GetFieldValue<int>("nivel");
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
                                return this.GetFieldValue<string>("cp");
                        }
                        set
                        {
                                this.Registro["cp"] = value;
                        }
                }

                public TiposLocalidad TipoLocalidad
                {
                        get
                        {
                                return ((TiposLocalidad)(this.Nivel));
                        }
                        set
                        {
                                this.Nivel = (int)value;
                        }
                }

                public Localidad Provincia
                {
                        get
                        {
                                if (m_Parent == null) {
                                        if (this.Registro["id_provincia"] != null)
                                                m_Parent = new Localidad(this.Connection, this.GetFieldValue<int>("id_provincia"));
                                }
                                return m_Parent;
                        }
                        set
                        {
                                m_Parent = value;
                                this.SetFieldValue("id_provincia", value);
                        }
                }

                public Impuestos.SituacionIva Iva
                {
                        get
                        {
                                if (this.GetFieldValue<int>("iva") == 1)
                                        return Impuestos.SituacionIva.Exento;
                                else if (this.Provincia != null)
                                        return this.Provincia.Iva;
                                else
                                        return Impuestos.SituacionIva.Predeterminado;
                        }
                        set
                        {
                                this.Registro["iva"] = (int)value;
                        }
                }


                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("cp", this.CodigoPostal);
                        if (this.Provincia == null) {
                                Comando.Fields.AddWithValue("id_provincia", null);
                                Comando.Fields.AddWithValue("nivel", (int)(TiposLocalidad.Provincia));
                        } else {
                                Comando.Fields.AddWithValue("id_provincia", this.Provincia.Id);
                                Comando.Fields.AddWithValue("nivel", (int)(TiposLocalidad.Localidad));
                        }
                        Comando.Fields.AddWithValue("iva", (int)this.Iva);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }
	}
}
