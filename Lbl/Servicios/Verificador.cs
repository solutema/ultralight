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

namespace Lbl.Servicios
{
        public class Verificador
        {
                public Lfx.Data.Connection DataBase;

                public Verificador(Lfx.Data.Connection dataBase)
                {
                        this.DataBase = dataBase;
                }

                public void CheckDataBase()
                {
                        Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Verificando integridad de los datos", "Se está verificando la consistencia de los datos almacenados.");
                        Progreso.Advertise = true;
                        Progreso.Modal = true;
                        Progreso.Begin();

                        this.DataBase.ExecuteSql("ALTER DATABASE " + this.DataBase.DataBaseName + " charset=utf8");

                        Progreso.ChangeStatus("Recalculando existencias de artículos");
                        // Actualizo los saldos de stock, se acuerdo a stock_movim
                        this.DataBase.ExecuteSql(@"UPDATE articulos SET stock_actual=(SELECT saldo FROM articulos_movim WHERE 
	                        articulos_movim.id_articulo=articulos.id_articulo
	                        ORDER BY id_movim DESC
	                        LIMIT 1) WHERE control_stock<>0");
                        this.DataBase.ExecuteSql(@"UPDATE articulos SET stock_actual=0 WHERE control_stock=0");

                        /*
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
                        } */


                        foreach (Lfx.Data.Table Tbl in Lfx.Data.DataBaseCache.DefaultCache.Tables) {
                                CheckTable(Progreso, Tbl);
                        }

                        Progreso.End();

                        // TODO: verificar saldos de cajas
                }

                public void CheckTable(Lfx.Types.OperationProgress progreso, Lfx.Data.Table table)
                {
                        Lfx.Data.TableStructure CurrentTableDef = this.DataBase.GetTableStructure(table.Name, true);
                        progreso.ChangeStatus("Verificando tabla " + table.Name);

                        foreach (Lfx.Data.ConstraintDefinition Cons in CurrentTableDef.Constraints.Values) {
                                // Elimino valores 0 (los pongo en NULL)
                                qGen.Update PonerNullablesEnNull = new qGen.Update(table.Name);
                                PonerNullablesEnNull.Fields.AddWithValue(Cons.Column, null);
                                PonerNullablesEnNull.WhereClause = new qGen.Where(Cons.Column, 0);
                                this.DataBase.Execute(PonerNullablesEnNull);

                                // Busco problemas de integridad referencial
                                if (Cons.TableName != Cons.ReferenceTable) {
                                        qGen.Select RefValidas = new qGen.Select(Cons.ReferenceTable);
                                        RefValidas.Fields = Cons.ReferenceColumn;

                                        qGen.Update ElimRefInvalidas = new qGen.Update(table.Name);
                                        switch(Cons.ReferenceTable) {
                                                case "bancos":
                                                        // Los bancos inexistentes los remplazo por "otro banco"
                                                        ElimRefInvalidas.Fields.AddWithValue(Cons.Column, 99);
                                                        break;
                                                case "personas":
                                                        // Las personas inexistentes las paso a Administrador
                                                        ElimRefInvalidas.Fields.AddWithValue(Cons.Column, 1);
                                                        break;
                                                default:
                                                        // El resto lo pongo en null
                                                        ElimRefInvalidas.Fields.AddWithValue(Cons.Column, null);
                                                        break;
                                        }
                                        ElimRefInvalidas.WhereClause = new qGen.Where(Cons.Column, qGen.ComparisonOperators.NotIn, RefValidas);

                                        System.Console.WriteLine(ElimRefInvalidas.ToString());
                                        this.DataBase.Execute(ElimRefInvalidas);
                                }
                        }
                }
        }
}