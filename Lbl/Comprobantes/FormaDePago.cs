// Copyright 2004-2009 South Bridge S.R.L.
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
        public enum TipoFormasDePago
        {
                Efectivo = 1,
                Cheque = 2,
                CuentaCorriente = 3,
                Tarjeta = 4,
                CuentaRegular = 6
        }

        public class FormaDePago : ElementoDeDatos
        {
                private Lbl.Cuentas.CuentaRegular m_Cuenta;

                //Heredar constructor
		public FormaDePago(Lws.Data.DataView dataView) : base(dataView) { }

                public FormaDePago(Lws.Data.DataView dataView, int idFormaDePago)
			: this(dataView)
		{
                        m_ItemId = idFormaDePago;
		}

                public FormaDePago(Lws.Data.DataView dataView, TipoFormasDePago tipoFormaPago)
                        : this(dataView)
                {
                        m_ItemId = (int)tipoFormaPago;
                }

		public override string TablaDatos
		{
			get
			{
				return "formaspago";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_formapago";
			}
		}

                public override Lfx.Types.OperationResult Crear()
                {
                        m_Cuenta = null;
                        return base.Crear();
                }

                public override Lfx.Types.OperationResult Cargar()
                {
                        Lfx.Types.OperationResult Res = base.Cargar();
                        if (Res.Success) {
                                if (Registro["id_cuenta"] == null)
                                        m_Cuenta = null;
                                else
                                        m_Cuenta = new Lbl.Cuentas.CuentaRegular(this.DataView, System.Convert.ToInt32(Registro["id_cuenta"]));
                        }

                        return Res;
                }

                public TipoFormasDePago Tipo
                {
                        get
                        {
                                return ((TipoFormasDePago)(this.FieldInt("tipo")));
                        }
                        set
                        {
                                this.Registro["tipo"] = (int)value;
                        }
                }

                public double Descuento
                {
                        get
                        {
                                return this.FieldDouble("descuento");
                        }
                        set
                        {
                                this.Registro["descuento"] = value;
                        }
                }

                public double Retencion
                {
                        get
                        {
                                return this.FieldDouble("retencion");
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
                                return this.FieldInt("dias_acred");
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
                                return this.FieldInt("autoacred") == 1;
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
                                return this.FieldInt("autopres") == 1;
                        }
                        set
                        {
                                this.Registro["autopres"] = value ? 1 : 0;
                        }
                }

                public bool Pagos
                {
                        get
                        {
                                return this.FieldInt("pagos") == 1;
                        }
                        set
                        {
                                this.Registro["pagos"] = value ? 1 : 0;
                        }
                }

                public Lbl.Cuentas.CuentaRegular Cuenta
                {
                        get
                        {
                                if (m_Cuenta == null && this.FieldInt("id_cuenta") > 0)
                                        m_Cuenta = new Lbl.Cuentas.CuentaRegular(this.DataView, this.FieldInt("id_cuenta"));
                                return m_Cuenta;
                        }
                        set
                        {
                                m_Cuenta = value;
                        }
                }
        }
}
