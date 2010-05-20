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

namespace Lbl.Pagos
{
        public class Valor : ElementoDeDatos
        {
                public Lbl.Comprobantes.FormaDePago FormaDePago;
                public Lbl.Comprobantes.Recibo Recibo;

                //Heredar constructor
		public Valor(Lws.Data.DataView dataView) : base(dataView) { }

                public Valor(Lws.Data.DataView dataView, int idValor)
			: this(dataView)
		{
                        m_ItemId = idValor;
                        this.Cargar();
		}

                public override string TablaDatos
                {
                        get
                        {
                                return "pagos_valores";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_valor";
                        }
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (this.FieldInt("id_formapago") > 0)
                                        this.FormaDePago = new Lbl.Comprobantes.FormaDePago(this.DataView, this.FieldInt("id_formapago"));
                                else
                                        this.FormaDePago = null;

                                /* if (this.FieldInt("id_recibo") > 0)
                                        this.Recibo = new Lbl.Comprobantes.Recibo(this.DataView, this.FieldInt("id_recibo"));
                                else
                                        this.Recibo = null; */
                        }
                        base.OnLoad();
                }

                public override string ToString()
                {
                        String Res = this.FormaDePago.ToString();
                        if (this.Numero != null && this.Numero.Length > 0)
                                Res += " Nº " + this.Numero;

                        return Res;
                }

                public string Numero
                {
                        get
                        {
                                return this.FieldString("numero");
                        }
                        set
                        {
                                this.Registro["numero"] = value;
                        }
                }

                public int ItemId
                {
                        get
                        {
                                return this.FieldInt("id_item");
                        }
                        set
                        {
                                this.Registro["id_item"] = value;
                        }
                }

                public double Importe
                {
                        get
                        {
                                return this.FieldDouble("importe");
                        }
                        set
                        {
                                this.Registro["importe"] = value;
                        }
                }

                public void Anular()
                {
                        return;
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        Lfx.Data.SqlTableCommandBuilder Comando;
                        if (this.Existe) {
                                Comando = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
                        } else {
                                Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
                        }

                        Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);

                        if (this.FormaDePago == null)
                                throw new InvalidOperationException("Lbl.Pagos.Valor.Guardar: Debe especificar la forma de pago");
                        else
                                Comando.Fields.AddWithValue("id_formapago", this.FormaDePago.Id);

                        if (this.Recibo == null)
                                throw new InvalidOperationException("Lbl.Pagos.Valor.Guardar: Debe especificar el recibo");
                        else
                                Comando.Fields.AddWithValue("id_recibo", this.Recibo.Id);

                        if(this.Nombre == null || this.Nombre.Length == 0)
                                Comando.Fields.AddWithValue("nombre", this.FormaDePago.ToString() + " Nº " + this.Numero);
                        else
                                Comando.Fields.AddWithValue("nombre", this.Nombre);

                        Comando.Fields.AddWithValue("numero", this.Numero);
                        Comando.Fields.AddWithValue("id_sucursal", this.DataView.Workspace.CurrentConfig.Company.CurrentBranch);

                        Comando.Fields.AddWithValue("importe", this.Importe);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        this.AgregarTags(Comando);

                        this.DataView.Execute(Comando);

                        return base.Guardar();
                }
        }
}
