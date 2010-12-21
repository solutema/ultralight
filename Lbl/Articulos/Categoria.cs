#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lbl.Articulos
{
        [Lbl.Atributos.NombreItem("Categoría")]
        public class Categoria : ElementoDeDatos, IElementoConImagen
	{
                protected Rubro m_Rubro = null;
                protected Impuestos.Alicuota m_Alicuota = null;

		public Categoria(Lfx.Data.Connection dataBase) : base(dataBase) { }

		public Categoria(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Categoria(Lfx.Data.Connection dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

		public override string TablaDatos
		{
			get
			{
				return "articulos_categorias";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_categoria";
			}
		}

		public virtual string NombreSingular
		{
			get
			{
				return this.GetFieldValue<string>("nombresing");
			}
			set
			{
				this.Registro["nombresing"] = value;
			}
		}

		public decimal StockMinimo
		{
			get
			{
				return this.GetFieldValue<decimal>("stock_minimo");
			}
			set
			{
				this.Registro["stock_minimo"] = value;
			}
		}

                public int Garantia
                {
                        get
                        {
                                return this.GetFieldValue<int>("garantia");
                        }
                        set
                        {
                                Registro["garantia"] = value;
                        }
                }

		public int PublicacionWeb
		{
			get
			{
				return System.Convert.ToInt32(this.Registro["web"]);
			}
			set
			{
				this.Registro["web"] = value;
			}
		}

                public Seguimientos Seguimiento
                {
                        get
                        {
                                return ((Seguimientos)(this.GetFieldValue<int>("requierens")));
                        }
                        set
                        {
                                this.Registro["requierens"] = (int)value;
                        }
                }

                public Rubro Rubro
                {
                        get
                        {
                                if (m_Rubro == null && this.GetFieldValue<int>("id_rubro") != 0)
                                        m_Rubro = new Rubro(this.Connection, this.GetFieldValue<int>("id_rubro"));

                                return m_Rubro;
                        }
                        set
                        {
                                m_Rubro = value;
                                this.SetFieldValue("id_rubro", value);
                        }
                }

                public Lbl.Impuestos.Alicuota Alicuota
                {
                        get
                        {
                                if (m_Alicuota == null && this.GetFieldValue<int>("id_alicuota") != 0)
                                        m_Alicuota = new Impuestos.Alicuota(this.Connection, this.GetFieldValue<int>("id_alicuota"));

                                return m_Alicuota;
                        }
                        set
                        {
                                m_Alicuota = value;
                                this.SetFieldValue("id_alicuota", value);
                        }
                }

                public Lbl.Impuestos.Alicuota ObtenerAlicuota()
                {
                        if (this.Alicuota != null)
                                return this.Alicuota;
                        else if (this.Rubro != null && this.Rubro.Alicuota != null)
                                return this.Rubro.Alicuota;
                        else
                                return Lbl.Sys.Config.Actual.Empresa.AlicuotaPredeterminada;
                }

		public override Lfx.Types.OperationResult Guardar()
                {
			qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("nombresing", this.NombreSingular);
                        Comando.Fields.AddWithValue("stock_minimo", this.StockMinimo);
                        Comando.Fields.AddWithValue("web", this.PublicacionWeb);
                        Comando.Fields.AddWithValue("requierens", ((int)(this.Seguimiento)));
                        Comando.Fields.AddWithValue("obs", this.Obs);
                        if (this.Rubro == null)
                                Comando.Fields.AddWithValue("id_rubro", null);
                        else
                                Comando.Fields.AddWithValue("id_rubro", this.Rubro.Id);
                        if (this.Alicuota == null)
                                Comando.Fields.AddWithValue("id_alicuota", null);
                        else
                                Comando.Fields.AddWithValue("id_alicuota", this.Alicuota.Id);
                        Comando.Fields.AddWithValue("garantia", this.Garantia);

			this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

			return base.Guardar();
		}

	}
}
