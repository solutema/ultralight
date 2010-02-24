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

namespace Lbl.Comprobantes
{
	public class DetalleArticulo : ElementoDeDatos
	{
		//Heredar constructor
		public DetalleArticulo(Lws.Data.DataView dataView) : base(dataView) { }

		public DetalleArticulo(Lws.Data.DataView dataView, int IdArticulo)
			: base(dataView)
		{
			m_ItemId = IdArticulo;
		}

		public override string TablaDatos
		{
			get
			{
				return "comprob_detalle";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_comprob_detalle";
			}
		}

		private Articulos.Articulo m_Articulo = null;
                public double Cantidad, Unitario, Costo, Recargo;
		public string Descripcion;
		public int Orden, IdArticulo;

                public double ImporteFinal
                {
                        get
                        {
                                return Cantidad * Unitario * (1 + Recargo / 100);
                        }
                }

                public Articulos.Articulo Articulo
                {
                        get
                        {
                                if (m_Articulo == null && this.IdArticulo != 0) {
                                        m_Articulo = new Lbl.Articulos.Articulo(this.DataView, this.IdArticulo);
                                        m_Articulo.Cargar();
                                }
                                
                                return m_Articulo;
                        }
                        set
                        {
                                if (value != null && value.Existe) {
                                        this.IdArticulo = value.Id;
                                        this.Nombre = value.Nombre;
                                        this.Descripcion = value.Descripcion;
                                }
                        }
                }

                public string Series
                {
                        get
                        {
                                return this.FieldString("series");
                        }
                        set
                        {
                                Registro["series"] = value;
                        }
                }

                public virtual DetalleArticulo Clone()
                {
                        DetalleArticulo Res = new DetalleArticulo(this.DataView, this.Id);
                        Res.m_Registro = this.m_Registro.Clone();
                        Res.Articulo = this.Articulo;
                        Res.Cantidad = this.Cantidad;
                        Res.Costo = this.Costo;
                        Res.Descripcion = this.Descripcion;
                        Res.IdArticulo = this.IdArticulo;
                        Res.Nombre = this.Nombre;
                        Res.Obs = this.Obs;
                        Res.Orden = this.Orden;
                        Res.Recargo = this.Recargo;
                        Res.Series = this.Series;
                        Res.Unitario = this.Unitario;
                        return Res;
                }

                public override string ToString()
                {
                        return this.Cantidad.ToString() + " " + this.Nombre + " a $ " + Lfx.Types.Formatting.FormatCurrency(this.Unitario, this.Workspace.CurrentConfig.Currency.DecimalPlaces) + " c/u";
                }
	}
}