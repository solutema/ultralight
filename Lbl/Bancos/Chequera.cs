#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace Lbl.Bancos
{
        public class Chequera : ElementoDeDatos
        {
                public Bancos.Banco Banco;
                public Lbl.Cajas.Caja Caja;
                public Lbl.Entidades.Sucursal Sucursal;

                //Heredar constructor
                public Chequera(Lfx.Data.Connection dataBase)
                        : base(dataBase)
                {
                        this.Estado = 1;
                }

                public Chequera(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Chequera(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public override string TablaDatos
                {
                        get
                        {
                                return "chequeras";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_chequera";
                        }
                }

                public string Titular
                {
                        get
                        {
                                return this.GetFieldValue<string>("titular");
                        }
                        set
                        {
                                this.Registro["titular"] = value;
                        }
                }

                public int Prefijo
                {
                        get
                        {
                                return this.GetFieldValue<int>("prefijo");
                        }
                        set
                        {
                                this.Registro["prefijo"] = value;
                        }
                }

                public int Desde
                {
                        get
                        {
                                return this.GetFieldValue<int>("desde");
                        }
                        set
                        {
                                this.Registro["desde"] = value;
                        }
                }

                public int Hasta
                {
                        get
                        {
                                return this.GetFieldValue<int>("hasta");
                        }
                        set
                        {
                                this.Registro["hasta"] = value;
                        }
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (this.GetFieldValue<int>("id_banco") > 0)
                                        this.Banco = new Bancos.Banco(this.Connection, this.GetFieldValue<int>("id_banco"));
                                else
                                        this.Banco = null;

                                if (this.GetFieldValue<int>("id_caja") > 0)
                                        this.Caja = new Cajas.Caja(this.Connection, this.GetFieldValue<int>("id_caja"));
                                else
                                        this.Caja = null;

                                if (this.GetFieldValue<int>("id_sucursal") > 0)
                                        this.Sucursal = new Lbl.Entidades.Sucursal(this.Connection, this.GetFieldValue<int>("id_sucursal"));
                                else
                                        this.Sucursal = null;
                        }
                        base.OnLoad();
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;
                        if (this.Existe == false) {
                                Comando = new qGen.Insert(Connection, "chequeras");
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(Connection, "chequeras");
                                Comando.WhereClause = new qGen.Where("id_chequera", m_ItemId);
                        }

                        if (this.Banco == null)
                                Comando.Fields.AddWithValue("id_banco", null);
                        else
                                Comando.Fields.AddWithValue("id_banco", this.Banco.Id);
                        Comando.Fields.AddWithValue("prefijo", this.Prefijo);
                        Comando.Fields.AddWithValue("desde", this.Desde);
                        Comando.Fields.AddWithValue("hasta", this.Hasta);
                        if (this.Caja == null)
                                Comando.Fields.AddWithValue("id_caja", null);
                        else
                                Comando.Fields.AddWithValue("id_caja", this.Caja.Id);
                        if (this.Sucursal == null)
                                Comando.Fields.AddWithValue("id_sucursal", null);
                        else
                                Comando.Fields.AddWithValue("id_sucursal", this.Sucursal.Id);
                        Comando.Fields.AddWithValue("titular", this.Titular);
                        Comando.Fields.AddWithValue("estado", this.Estado);

                        Connection.Execute(Comando);
                        this.ActualizarId();

                        if (this.Desde > 0 && this.Hasta > 0 && this.Hasta > this.Desde) {
				qGen.Update Actua = new qGen.Update("bancos_cheques");
				Actua.Fields.AddWithValue("id_chequera", this.Id);
				Actua.WhereClause = new qGen.Where();
                                Actua.WhereClause.AddWithValue("emitido", 1);
                                Actua.WhereClause.AddWithValue("id_banco", this.Banco.Id);
                                Actua.WhereClause.AddWithValue("numero", this.Desde, this.Hasta);
				Connection.Execute(Actua);
				
				Actua = new qGen.Update("bancos_cheques");
				Actua.Fields.Add(new Lfx.Data.Field("id_chequera", Lfx.Data.DbTypes.Integer, null));
				Actua.WhereClause = new qGen.Where();
                                Actua.WhereClause.AddWithValue("emitido", 1);
                                Actua.WhereClause.AddWithValue("id_banco", this.Banco.Id);
                                Actua.WhereClause.AddWithValue("id_chequera", this.Id);
                                qGen.Where Numeros = new qGen.Where(qGen.AndOr.Or);
                                Numeros.AddWithValue("numero", qGen.ComparisonOperators.LessThan, this.Desde);
                                Numeros.AddWithValue("numero", qGen.ComparisonOperators.GreaterThan, this.Hasta);
                                Actua.WhereClause.AddWithValue(Numeros);
				Connection.Execute(Actua);

                        }

                        return base.Guardar();
                }

                public override string ToString()
                {
                        String Res = "Chequera ";
                        if (Banco != null)
                                Res += " del " + Banco.ToString();
                        return Res;
                }
        }
}
