#region License
// Copyright 2004-2011 Ernesto N. Carrea
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
using System.Linq;
using System.Text;

namespace Lbl.Componentes
{
        /// <summary>
        /// Representa un componente.
        /// </summary>
        [Lbl.Atributos.NombreItem("Componente")]
        public class Componente : ElementoDeDatos
        {
                //Heredar constructor
		public Componente(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Componente(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Componente(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

		public override string TablaDatos
		{
			get
			{
				return "sys_components";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_component";
			}
		}


                /// <summary>
                /// Espacio de nombres bajo el cual opera el componente.
                /// </summary>
                public string EspacioNombres
                {
                        get
                        {
                                return this.GetFieldValue<string>("espacio");
                        }
                        set
                        {
                                this.SetFieldValue("epacio", value);
                        }
                }


                /// <summary>
                /// Versión instalada del componente.
                /// </summary>
                public DateTime Version
                {
                        get
                        {
                                return this.GetFieldValue<DateTime>("version");
                        }
                        set
                        {
                                this.SetFieldValue("version", value);
                        }
                }


                /// <summary>
                /// Estructura adicional de base de datos requerida por este componente.
                /// </summary>
                public string Estructura
                {
                        get
                        {
                                return this.GetFieldValue<string>("estructura");
                        }
                        set
                        {
                                this.SetFieldValue("estructura", value);
                        }
                }


                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        Comando.Fields.AddWithValue("espacio", this.EspacioNombres);
                        Comando.Fields.AddWithValue("version", this.Version);
                        Comando.Fields.AddWithValue("estructura", this.Estructura);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }

                private static ColeccionGenerica<Componente> m_Todos = null;
                public static ColeccionGenerica<Componente> Todos()
                {
                        if (m_Todos == null) {
                                System.Data.DataTable Comps = Lfx.Workspace.Master.MasterConnection.Select("SELECT * FROM sys_components");
                                m_Todos = new ColeccionGenerica<Componente>(Lfx.Workspace.Master.MasterConnection, Comps);
                        }
                        return m_Todos;
                }
        }
}
