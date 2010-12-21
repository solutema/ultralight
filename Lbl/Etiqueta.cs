#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
        /// Describe una etiqueta que se puede asociar a un ElementoDeDatos, por ejemplo "Destacado", "Nuevo", etc.
        /// Se pueden asociar cero o más etiquetas a un elemento mediante la propiedad Etiquetas y el método GuardarEtiquetas().
        /// </summary>
        public class Etiqueta : ElementoDeDatos
        {
                private static ColeccionGenerica<Etiqueta> m_Todas;

                //Heredar constructor
		public Etiqueta(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Etiqueta(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Etiqueta(Lfx.Data.Connection dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

                public override string TablaDatos
                {
                        get
                        {
                                return "sys_labels";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_label";
                        }
                }

                public static implicit operator Etiqueta(Lfx.Data.Row row)
                {
                        Etiqueta Res = new Etiqueta(((Lfx.Data.Table)(row.Table)).DataBase);
                        Res.FromRow(row);
                        return Res;
                }

                public string TablaReferencia
                {
                        get
                        {
                                return this.GetFieldValue<string>("tablas");
                        }
                }

                public static ColeccionGenerica<Etiqueta> Todas
                {
                        get
                        {
                                if (m_Todas == null) {
                                        System.Data.DataTable EtiquetasElem = Lfx.Workspace.Master.MasterConnection.Select("SELECT id_label FROM sys_labels");
                                        m_Todas = new ColeccionGenerica<Etiqueta>(Lfx.Workspace.Master.MasterConnection, EtiquetasElem);
                                }

                                return m_Todas;
                        }
                }

                public static ColeccionGenerica<Etiqueta> ObtenerPorTabla(string tablaDeDatos)
                {
                        ColeccionGenerica<Etiqueta> Res = new ColeccionGenerica<Etiqueta>();
                        foreach (Etiqueta Et in Lbl.Etiqueta.Todas) {
                                if (Et.TablaDatos == tablaDeDatos)
                                        Res.Add(Et);
                        }
                        return Res;
                }
        }
}
