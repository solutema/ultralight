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

namespace Lbl.CuentasCorrientes
{
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Movimiento de cuenta corriente", Grupo = "Cuentas")]
        [Lbl.Atributos.Datos(TablaDatos = "ctacte", CampoId = "id_movim", CampoNombre = "concepto")]
        [Lbl.Atributos.Presentacion(PanelExtendido = Lbl.Atributos.PanelExtendido.Nunca)]
        public class Movimiento : ElementoDeDatos
        {
                //Heredar constructor
		public Movimiento(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Movimiento(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Movimiento(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("fecha", this.Fecha);
                        Comando.Fields.AddWithValue("auto", this.Auto ? 1 : 0);
                        Comando.Fields.AddWithValue("concepto", this.Nombre);
                        Comando.Fields.AddWithValue("id_cliente", this.IdCliente);
                        Comando.Fields.AddWithValue("importe", this.Importe);
                        Comando.Fields.AddWithValue("comprob", this.Comprobantes);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        if (this.IdConcepto == 0)
                                Comando.Fields.AddWithValue("id_concepto", null);
                        else
                                Comando.Fields.AddWithValue("id_concepto", this.IdConcepto);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }


                protected internal int IdCliente
                {
                        get
                        {
                                return this.GetFieldValue<int>("id_cliente");
                        }
                        set
                        {
                                this.Registro["id_cliente"] = value;
                        }
                }


                protected internal int IdConcepto
                {
                        get
                        {
                                return this.GetFieldValue<int>("id_concepto");
                        }
                        set
                        {
                                this.Registro["id_concepto"] = value;
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


                public string Comprobantes
                {
                        get
                        {
                                return this.GetFieldValue<string>("comprob");
                        }
                        set
                        {
                                this.Registro["comprob"] = value;
                        }
                }

                public bool Auto
                {
                        get
                        {
                                return this.GetFieldValue<int>("auto") != 0;
                        }
                        set
                        {
                                this.Registro["auto"] = value ? 1 : 0;
                        }
                }

        }

}
