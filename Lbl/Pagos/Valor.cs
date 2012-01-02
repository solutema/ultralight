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
        [Lbl.Atributos.Datos(NombreSingular = "Valor de Pago",
                TablaDatos = "pagos_valores",
                CampoId = "id_valor")]
        [Lbl.Atributos.Presentacion()]
        public class Valor : ElementoDeDatos
        {
                public Lbl.Pagos.FormaDePago FormaDePago;
                public Lbl.Comprobantes.Recibo Recibo;

                //Heredar constructor
		public Valor(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Valor(Lfx.Data.Connection dataBase, int idValor)
			: this(dataBase)
		{
                        m_ItemId = idValor;
                        this.Cargar();
		}

                public Valor(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (this.GetFieldValue<int>("id_formapago") > 0)
                                        this.FormaDePago = new Lbl.Pagos.FormaDePago(this.Connection, this.GetFieldValue<int>("id_formapago"));
                                else
                                        this.FormaDePago = null;
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
                                return this.GetFieldValue<string>("numero");
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
                                return this.GetFieldValue<int>("id_item");
                        }
                        set
                        {
                                this.Registro["id_item"] = value;
                        }
                }

                public decimal Importe
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("importe");
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
                        qGen.TableCommand Comando;
                        if (this.Existe) {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        } else {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                        }

                        Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);

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
                        Comando.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada);

                        Comando.Fields.AddWithValue("importe", this.Importe);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }
        }
}
