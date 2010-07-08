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

namespace Lbl
{
        /// <summary>
        /// Fusiona dos elementos de datos, útil para eliminar duplicados. Cambia todas las referencias de claves foráneas al nuevo elemento.
        /// </summary>
        public class Desduplicador
        {
                public Lws.Data.DataView DataView;
                public string TablaOriginal, CampoIdOriginal;
                public int IdOriginal, IdDuplicado;

                public Desduplicador(Lws.Data.DataView dataView, string tablaOriginal, string campoIdOriginal, int idOriginal, int idDuplicado)
                {
                        this.DataView = dataView;
                        this.TablaOriginal = tablaOriginal;
                        this.CampoIdOriginal = campoIdOriginal;
                        this.IdOriginal = idOriginal;
                        this.IdDuplicado = idDuplicado;
                }

                public void Desduplicar()
                {
                        bool MustCommit = false;
                        if(this.DataView.InTransaction == false) {
                                MustCommit = true;
                                this.DataView.BeginTransaction();
                        }

                        // Busco una lista de relaciones entre tablas
                        System.Collections.Generic.List<Lfx.Data.Relation> Rels = this.ListaRelaciones();
                        foreach (Lfx.Data.Relation Rel in Rels) {
                                // Cambio todas las referencias que apuntan al registro duplicado hacia el registro original
                                qGen.Update Upd = new qGen.Update(Rel.ReferenceTable);
                                Upd.Fields.AddWithValue(Rel.ReferenceColumn, +IdOriginal);
                                Upd.WhereClause = new qGen.Where(Rel.ReferenceColumn, IdDuplicado);
                                this.DataView.Execute(Upd);
                        }

                        // Ahora que no queda nada apuntando al registro duplicado, lo elimino
                        qGen.Delete Del = new qGen.Delete(this.TablaOriginal);
                        Del.WhereClause = new qGen.Where(this.CampoIdOriginal, this.IdDuplicado);
                        this.DataView.Execute(Del);

                        // Le doy tratamiento especial a algunas situaciones
                        switch (TablaOriginal) {
                                case "personas":
                                        // En personas, recalculo la cuenta corriente, ya que la nueva cuenta corriente es la fusión de las dos anteriores
                                        Lbl.Personas.Persona PersonaOriginal = new Personas.Persona(this.DataView, IdOriginal);
                                        PersonaOriginal.CuentaCorriente.Recalcular();
                                        PersonaOriginal.AgregarComentario("Desduplicador: Se fusionaron los datos del ítem " + IdDuplicado);
                                        break;
                                        // En artículos, debería recalcular el historial de movimientos y el stock actual, pedidos, etc.
                        }

                        if (MustCommit)
                                this.DataView.Commit();
                }

                public System.Collections.Generic.List<Lfx.Data.Relation> ListaRelaciones()
                {
                        System.Collections.Generic.List<Lfx.Data.Relation> Res = new List<Lfx.Data.Relation>();
                        foreach (Lfx.Data.ConstraintDefinition Cons in Lfx.Data.DataBaseCache.DefaultCache.Constraints.Values) {
                                if (Cons.ReferenceTable == TablaOriginal && Cons.ReferenceColumn == CampoIdOriginal) {
                                        Lfx.Data.Relation Rel = new Lfx.Data.Relation(CampoIdOriginal, Cons.TableName, Cons.Column, null);
                                        Res.Add(Rel);
                                }
                        }

                        foreach (Lfx.Data.TableStructure Tab in Lfx.Data.DataBaseCache.DefaultCache.TableStructures.Values) {
                                if (Tab.Name != TablaOriginal) {
                                        foreach (Lfx.Data.ColumnDefinition Col in Tab.Columns.Values) {
                                                if (Col.Name == CampoIdOriginal) {
                                                        bool Found = false;
                                                        foreach (Lfx.Data.Relation Rel in Res) {
                                                                if (Rel.ReferenceTable == Tab.Name && Rel.ReferenceColumn == Col.Name) {
                                                                        Found = true;
                                                                        break;
                                                                }
                                                        }
                                                        if (Found == false)
                                                                System.Console.WriteLine("El cammpo " + Tab.Name + "." + Col.Name + " puede ser una referencia no declarada como clave foránea.");
                                                }
                                        }
                                }
                        }

                        return Res;
                }
        }
}