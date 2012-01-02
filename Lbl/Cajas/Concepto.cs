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

namespace Lbl.Cajas
{
        [Lbl.Atributos.Datos(NombreSingular = "Concepto",
                       Grupo = "Cajas",
                       TablaDatos = "conceptos",
                       CampoId = "id_concepto")]
        [Lbl.Atributos.Presentacion()]
        public class Concepto : ElementoDeDatos
        {
                private static Concepto m_IngresosPorFacturacion = null, m_AjustesYMovimientos = null;

                //Heredar constructor
                public Concepto(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Concepto(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Concepto(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public int Direccion
                {
                        get
                        {
                                return this.GetFieldValue<int>("es");
                        }
                        set
                        {
                                this.Registro["es"] = value;
                        }
                }

                public int Grupo
                {
                        get
                        {
                                return this.GetFieldValue<int>("grupo");
                        }
                        set
                        {
                                this.Registro["grupo"] = value;
                        }
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;
                        if (this.Existe == false) {
                                Comando = new qGen.Insert(Connection, "conceptos");
                        } else {
                                Comando = new qGen.Update(Connection, "conceptos");
                                Comando.WhereClause = new qGen.Where("id_concepto", this.Id);
                        }

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("es", this.Direccion);
                        if (this.Grupo == 0)
                                Comando.Fields.AddWithValue("grupo", null);
                        else
                                Comando.Fields.AddWithValue("grupo", this.Grupo);

                        Connection.Execute(Comando);

                        return base.Guardar();
                }

                public static Cajas.Concepto IngresosPorFacturacion
                {
                        get
                        {
                                if (m_IngresosPorFacturacion == null)
                                        m_IngresosPorFacturacion = new Concepto(Lfx.Workspace.Master.MasterConnection, 11000);

                                return m_IngresosPorFacturacion;
                        }
                }

                public static Cajas.Concepto AjustesYMovimientos
                {
                        get
                        {
                                if (m_AjustesYMovimientos == null)
                                        m_AjustesYMovimientos = new Concepto(Lfx.Workspace.Master.MasterConnection, 30000);

                                return m_AjustesYMovimientos;
                        }
                }
        }
}
