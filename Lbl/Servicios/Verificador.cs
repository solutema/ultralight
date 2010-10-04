#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Lbl.Servicios
{
        public class Verificador
        {
                public Lfx.Data.DataBase DataBase;

                public Verificador(Lfx.Data.DataBase dataBase)
                {
                        this.DataBase = dataBase;
                }

                public void CheckDataBase()
                {
                        this.DataBase.Execute("ALTER DATABASE " + this.DataBase.DataBaseName + " charset=utf8");

                        foreach (string Tabla in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
                                this.DataBase.Execute("ALTER TABLE " + Tabla + " CONVERT TO CHARACTER SET utf8");
                                CheckTable(Tabla);
                        }

                        // Actualizo los saldos de stock, se acuerdo a stock_movim
                        this.DataBase.Execute(@"UPDATE articulos SET stock_actual=(SELECT saldo FROM articulos_movim WHERE 
	                        articulos_movim.id_articulo=articulos.id_articulo
	                        ORDER BY id_movim DESC
	                        LIMIT 1) WHERE control_stock<>0");
                        this.DataBase.Execute(@"UPDATE articulos SET stock_actual=0 WHERE control_stock=0");

                        // Verificar saldos de cuentas corrientes
                        string Sql = @"SELECT personas.id_persona
FROM personas LEFT JOIN ctacte ON personas.id_persona=ctacte.id_cliente 
GROUP BY personas.id_persona
HAVING SUM(ctacte.importe)<>(SELECT saldo FROM ctacte WHERE ctacte.id_cliente=personas.id_persona ORDER BY id_movim DESC LIMIT 1)";
                        System.Data.DataTable CuentasMal = this.DataBase.Select(Sql);
                        foreach (System.Data.DataRow Cuenta in CuentasMal.Rows) {
                                int IdCliente = System.Convert.ToInt32(Cuenta["id_persona"]);
                                Lbl.Personas.Persona Cliente = new Lbl.Personas.Persona(this.DataBase, IdCliente);
                                Cliente.CuentaCorriente.Recalcular();
                        }

                        // TODO: verificar saldos de cajas
                }

                public void CheckTable(string tableName)
                {
                        Lfx.Data.TableStructure CurrentTableDef = this.DataBase.GetTableStructure(tableName, true);
                        foreach (Lfx.Data.ColumnDefinition Col in CurrentTableDef.Columns.Values) {
                                if (Col.FieldType == Lfx.Data.DbTypes.VarChar || Col.FieldType == Lfx.Data.DbTypes.Text) {
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã¡', 'á')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã©', 'é')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã­', 'í')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã³', 'ó')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ãº', 'ú')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã¼', 'ü')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã±', 'ñ')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã‰', 'É')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã“', 'Ó')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ãš', 'Ú')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã\\‘', 'Ñ')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Âº', 'º')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Â¿', '¿')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'ÃƒÂ©', 'é')");

                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'Ã‚º', 'º')");
                                        this.DataBase.Execute("UPDATE " + CurrentTableDef.Name + " SET " + Col.Name + "=REPLACE(" + Col.Name + ", 'ÃƒÂ±', 'ñ')");
                                        //a=Ã¡, e=Ã©, i=Ã­, o=Ã³, u=Ãº, N=Ã‘, ?=Â¿, u=Ã¼, A=Ã, E=Ã‰, I=Ã, O=Ã“, U=Ãš, Ã‚º=º
                                }
                        }

                        foreach (Lfx.Data.ConstraintDefinition Cons in CurrentTableDef.Constraints.Values) {
                                // Elimino valores 0 (los pongo en NULL)
                                qGen.Update PonerNullablesEnNull = new qGen.Update(tableName);
                                PonerNullablesEnNull.Fields.AddWithValue(Cons.Column, null);
                                PonerNullablesEnNull.WhereClause = new qGen.Where(Cons.Column, 0);
                                this.DataBase.Execute(PonerNullablesEnNull);
                        }
                }
        }
}