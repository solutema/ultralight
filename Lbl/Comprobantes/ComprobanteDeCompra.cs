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
using System.Linq;
using System.Text;

namespace Lbl.Comprobantes
{
        [Lbl.Atributos.NombreItem("Comprobante de Compra"),
                Lbl.Atributos.MuestraMensajeAlCrear(false),
                Lbl.Atributos.MuestraPanelExtendido(true)]
        public class ComprobanteDeCompra : ComprobanteConArticulos, Lbl.IElementoConImagen
        {
                //Heredar constructor
                public ComprobanteDeCompra(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public ComprobanteDeCompra(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
			: base(dataBase, row) { }

                public ComprobanteDeCompra(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public override void Crear()
                {
                        base.Crear();
                        this.Compra = true;

                        this.Compra = true;
                        this.Fecha = DateTime.Now;

                        if (this.SituacionOrigen == null)
                                this.SituacionOrigen = new Lbl.Articulos.Situacion(this.Connection, 998); //Proveedor
                        if (this.SituacionDestino == null)
                                this.SituacionDestino = new Lbl.Articulos.Situacion(this.Connection, this.Workspace.CurrentConfig.Productos.DepositoPredeterminado);
                }

                public override Tipo Tipo
                {
                        get
                        {
                                return base.Tipo;
                        }
                        set
                        {
                                base.Tipo = value;

                                if (this.Tipo.EsFacturaNCoND && this.FormaDePago == null)
                                        this.FormaDePago = new Lbl.Pagos.FormaDePago(this.Connection, Lbl.Pagos.TiposFormasDePago.CuentaCorriente);

                                if (this.Tipo.Nomenclatura == "PD" || this.Tipo.Nomenclatura == "NP")
                                        this.Estado = 50;
                        }
                }

                new public Lbl.Comprobantes.ComprobanteDeCompra ConvertirEn(Tipo tipo)
                {
                        return base.ConvertirEn(tipo) as Lbl.Comprobantes.ComprobanteDeCompra;
                }
        }
}
