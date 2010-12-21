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

namespace Lbl.Comprobantes
{
	public class DetalleArticulo : ElementoDeDatos
	{
                public Lbl.Comprobantes.ComprobanteConArticulos Comprobante = null;

		//Heredar constructor
                public DetalleArticulo(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public DetalleArticulo(Lbl.Comprobantes.ComprobanteConArticulos comprobante)
                        : base(comprobante.Connection)
                {
                        this.Comprobante = comprobante;
                }

                public DetalleArticulo(Lbl.Comprobantes.ComprobanteConArticulos comprobante, int itemId)
                        : base(comprobante.Connection, itemId)
                {
                        this.Comprobante = comprobante;
                }

                public DetalleArticulo(Lbl.Comprobantes.ComprobanteConArticulos comprobante, Lfx.Data.Row fromRow)
                        : base(comprobante.Connection, fromRow)
                {
                        this.Comprobante = comprobante;
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

                public decimal Unitario
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("precio");
                        }
                        set
                        {
                                this.Registro["precio"] = value;
                        }
                }

                public decimal Cantidad
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("cantidad");
                        }
                        set
                        {
                                this.Registro["cantidad"] = value;
                        }
                }

                public decimal Costo
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("costo");
                        }
                        set
                        {
                                this.Registro["costo"] = value;
                        }
                }


                public string Descripcion
                {
                        get
                        {
                                return this.GetFieldValue<string>("descripcion");
                        }
                        set
                        {
                                this.Registro["descripcion"] = value;
                        }
                }

                /// <summary>
                /// Devuelve el importe final a facturar (precio unitario multiplicado por la cantidad, más descuentos y recargos).
                /// </summary>
                public decimal Importe
                {
                        get
                        {
                                return this.Cantidad * this.Unitario * (1 + Recargo / 100);
                        }
                }

                /// <summary>
                /// Devuelve el precio unitario a facturar, según la discriminación de IVA del comprobante.
                /// </summary>
                public decimal UnitarioAFacturar
                {
                        get
                        {
                                if (this.Comprobante == null) {
                                        return this.Unitario;
                                } else {
                                        if(this.Comprobante.Cliente.PagaIva == Impuestos.SituacionIva.Exento)
                                                return this.Unitario;
                                        else if (this.Comprobante.DiscriminaIva) {
                                                return this.Unitario;
                                        } else {
                                                decimal IvaPct = this.ObtenerAlicuota().Porcentaje;
                                                return Math.Round(this.Unitario * (1 + IvaPct / 100), this.Workspace.CurrentConfig.Moneda.Decimales);
                                        }
                                }
                        }
                }

                /// <summary>
                /// Devuelve el importe de IVA que corresponde a este artículo.
                /// </summary>
                public decimal ImporteIva
                {
                        get
                        {
                                if (this.Comprobante == null) {
                                        return 0;
                                } else {
                                        if (this.Comprobante.Cliente.PagaIva != Impuestos.SituacionIva.Exento) {
                                                decimal IvaPct = this.ObtenerAlicuota().Porcentaje;
                                                return Math.Round(this.Importe * (IvaPct / 100), this.Workspace.CurrentConfig.Moneda.Decimales);
                                        } else {
                                                return 0;
                                        }
                                }
                        }
                }

                /// <summary>
                /// Devuelve la cantidad de IVA que fue discriminado para este artículo, o 0 si no se discriminó IVA.
                /// </summary>
                public decimal IvaDiscriminado
                {
                        get
                        {
                                if (this.Comprobante == null) {
                                        return 0;
                                } else {
                                        if (this.Comprobante.DiscriminaIva) {
                                                return this.ImporteIva;
                                        } else {
                                                return 0;
                                        }
                                }
                        }
                }

                protected internal int IdArticulo
                {
                        get
                        {
                                return this.GetFieldValue<int>("id_articulo");
                        }
                        set
                        {
                                this.Registro["id_articulo"] = value;
                        }
                }

                public int Orden
                {
                        get
                        {
                                return this.GetFieldValue<int>("orden");
                        }
                        set
                        {
                                this.Registro["orden"] = value;
                        }
                }

                public Lbl.Impuestos.Alicuota ObtenerAlicuota()
                {
                        if (this.Articulo == null)
                                return Lbl.Sys.Config.Actual.Empresa.AlicuotaPredeterminada;
                        else
                                return this.Articulo.ObtenerAlicuota();
                }

                public Articulos.Articulo Articulo
                {
                        get
                        {
                                if (m_Articulo == null && this.IdArticulo != 0)
                                        m_Articulo = new Lbl.Articulos.Articulo(this.Connection, this.IdArticulo);
                                
                                return m_Articulo;
                        }
                        set
                        {
                                if (value != null && value.Existe) {
                                        this.IdArticulo = value.Id;
                                        this.Nombre = value.Nombre;
                                        this.Descripcion = value.Descripcion;
                                } else {
                                        this.IdArticulo = 0;
                                }
                        }
                }

                public string Series
                {
                        get
                        {
                                return this.GetFieldValue<string>("series");
                        }
                        set
                        {
                                Registro["series"] = value;
                        }
                }

                public decimal Recargo
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("recargo");
                        }
                        set
                        {
                                Registro["recargo"] = value;
                        }
                }

                public virtual DetalleArticulo Clone()
                {
                        DetalleArticulo Res;
                        if (this.Comprobante == null || this.Id == 0)
                                Res = new DetalleArticulo(this.Connection);
                        else
                                Res = new DetalleArticulo(this.Comprobante, this.Id);
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
                        return this.Cantidad.ToString() + " " + this.Nombre + " a $ " + Lfx.Types.Formatting.FormatCurrency(this.Unitario, this.Workspace.CurrentConfig.Moneda.Decimales) + " c/u";
                }
	}
}