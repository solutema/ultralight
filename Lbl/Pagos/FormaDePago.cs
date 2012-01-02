#region License
// Copyright 2004-2012 Ernesto N. Carrea
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

namespace Lbl.Pagos
{
        /// <summary>
        /// Representa una forma de pago. Tanto para emitir pagos como para recibir pagos.
        /// </summary>
        [Lbl.Atributos.Datos(NombreSingular = "Forma de Pago",
                TablaDatos = "formaspago",
                CampoId = "id_formapago")]
        [Lbl.Atributos.Presentacion()]
        public class FormaDePago : ElementoDeDatos
        {
                private Lbl.Cajas.Caja m_Caja;

                //Heredar constructor
		public FormaDePago(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public FormaDePago(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public FormaDePago(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public FormaDePago(Lfx.Data.Connection dataBase, TiposFormasDePago tipoFormaPago)
                        : this(dataBase)
                {
                        m_ItemId = (int)tipoFormaPago;
                }

		
                public override void Crear()
                {
                        base.Crear();
                        m_Caja = null;
                }

                public override Lfx.Types.OperationResult Cargar()
                {
                        Lfx.Types.OperationResult Res = base.Cargar();
                        if (Res.Success) {
                                if (Registro["id_caja"] == null)
                                        m_Caja = null;
                                else
                                        m_Caja = new Lbl.Cajas.Caja(this.Connection, System.Convert.ToInt32(Registro["id_caja"]));
                        }

                        return Res;
                }

                public TiposFormasDePago Tipo
                {
                        get
                        {
                                return ((TiposFormasDePago)(this.GetFieldValue<int>("tipo")));
                        }
                        set
                        {
                                this.Registro["tipo"] = (int)value;
                        }
                }

                public decimal Descuento
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("descuento");
                        }
                        set
                        {
                                this.Registro["descuento"] = value;
                        }
                }

                public decimal Retencion
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("retencion");
                        }
                        set
                        {
                                this.Registro["retencion"] = value;
                        }
                }

                public int DiasAcreditacion
                {
                        get
                        {
                                return this.GetFieldValue<int>("dias_acred");
                        }
                        set
                        {
                                this.Registro["dias_acred"] = value;
                        }
                }

                public bool AutoAcreditacion
                {
                        get
                        {
                                return this.GetFieldValue<int>("autoacred") == 1;
                        }
                        set
                        {
                                this.Registro["autoacred"] = value ? 1 : 0;
                        }
                }

                public bool AutoPresentacion
                {
                        get
                        {
                                return this.GetFieldValue<int>("autopres") == 1;
                        }
                        set
                        {
                                this.Registro["autopres"] = value ? 1 : 0;
                        }
                }

                public bool PuedeHacerPagos
                {
                        get
                        {
                                return this.GetFieldValue<int>("pagos") == 1;
                        }
                        set
                        {
                                this.Registro["pagos"] = value ? 1 : 0;
                        }
                }

                public bool PuedeHacerCobros
                {
                        get
                        {
                                return this.GetFieldValue<int>("cobros") == 1;
                        }
                        set
                        {
                                this.Registro["cobros"] = value ? 1 : 0;
                        }
                }

                public Lbl.Cajas.Caja Caja
                {
                        get
                        {
                                if (m_Caja == null && this.GetFieldValue<int>("id_caja") > 0)
                                        m_Caja = new Lbl.Cajas.Caja(this.Connection, this.GetFieldValue<int>("id_caja"));
                                return m_Caja;
                        }
                        set
                        {
                                m_Caja = value;
                        }
                }
        }
}
