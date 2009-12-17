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

namespace Lbl.Tarjetas
{
        public enum TipoTarjeta
        {
                Ninguno = 0,
                Credito = 1,
                Debito = 2,
                Otra = 3
        }

	public class Tarjeta : ElementoDeDatos
	{
                public Lbl.Cuentas.CuentaRegular Cuenta;

		//Heredar constructor
		public Tarjeta(Lws.Data.DataView dataView) : base(dataView) { }

		public Tarjeta(Lws.Data.DataView dataView, int IdTarjeta)
			: base(dataView)
		{
			m_ItemId = IdTarjeta;
		}

                public override string TablaDatos
		{
			get
			{
				return "tarjetas";
			}
		}

                public override string CampoId
		{
			get
			{
				return "id_tarjeta";
			}
		}


                public double Comision
                {
                        get
                        {
                                return System.Convert.ToDouble(this.Registro["comision"]);
                        }
                        set
                        {
                                this.Registro["comision"] = value;
                        }
                }

                public int DiasNormal
                {
                        get
                        {
                                return this.FieldInt("dias_normal");
                        }
                        set
                        {
                                this.Registro["dias_normal"] = value;
                        }
                }

                public int DiasAnticipada
                {
                        get
                        {
                                return this.FieldInt("dias_anticipada");
                        }
                        set
                        {
                                this.Registro["dias_anticipada"] = value;
                        }
                }

                public bool AutoAcreditacion
                {
                        get
                        {
                                return System.Convert.ToBoolean(this.FieldInt("autoacred"));
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
                                return System.Convert.ToBoolean(this.FieldInt("autopres"));
                        }
                        set
                        {
                                this.Registro["autopres"] = value ? 1 : 0;
                        }
                }


                public TipoTarjeta Tipo
                {
                        get
                        {
                                return ((TipoTarjeta)(System.Convert.ToInt32(this.Registro["credeb"])));
                        }
                        set
                        {
                                this.Registro["credeb"] = (TipoTarjeta)value;
                        }
                }

                public override Lfx.Types.OperationResult Cargar()
                {
                        Lfx.Types.OperationResult Res = base.Cargar();
                        if (Res.Success) {
                                if (Registro["id_cuenta"] == null)
                                        this.Cuenta = null;
                                else
                                        this.Cuenta = new Lbl.Cuentas.CuentaRegular(this.DataView, System.Convert.ToInt32(Registro["id_cuenta"]));
                        }
                        return base.Cargar();
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        Lfx.Data.SqlTableCommandBuilder Comando;

                        if (this.Existe == false) {
                                Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
                        } else {
                                Comando = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("credeb", ((int)(this.Tipo)));
                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("comision", this.Comision);
                        if (this.Cuenta == null)
                                Comando.Fields.AddWithValue("id_cuenta", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_cuenta", this.Cuenta.Id);

			this.AgregarTags(Comando);

                        this.DataView.Execute(Comando);

                        if (this.Existe == false)
                                m_ItemId = this.DataView.DataBase.FieldInt("SELECT MAX(id_tarjeta) FROM artitarjetasculos");

                        return base.Guardar();
                }


	}
}
