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