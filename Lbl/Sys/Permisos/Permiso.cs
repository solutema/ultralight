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
using System.Linq;
using System.Text;

namespace Lbl.Sys.Permisos
{
        /// <summary>
        /// Describe una instancia de un permiso en particular.
        /// </summary>
        public class Permiso : ElementoDeDatos
        {
                public ListaIds Item = null;
                public Lbl.Personas.Usuario Usuario = null;
                public Objeto Objeto = null;

                //Heredar constructor
		public Permiso(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Permiso(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Permiso(Lfx.Data.Connection dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

                public Permiso(Lbl.Personas.Usuario usuario, Objeto tipo, Operaciones ops, ListaIds item)
                        : this(usuario.Connection)
                {
                        this.Usuario = usuario;
                        this.Objeto = tipo;
                        this.Operaciones = ops;
                        this.Item = item;
                }

		public override string TablaDatos
		{
			get
			{
                                return "sys_permisos";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_permiso";
			}
		}

                public override void OnLoad()
                {
                        if (this.GetFieldValue<int>("id_objeto") > 0)
                                this.Objeto = new Permisos.Objeto(this.Connection, this.GetFieldValue<int>("id_objeto"));
                        else
                                this.Objeto = null;

                        if (this.GetFieldValue<string>("items") != null)
                                this.Item = new ListaIds(this.GetFieldValue<string>("items"));
                        else
                                this.Item = null;

                        base.OnLoad();
                }

                public Operaciones Operaciones
                {
                        get
                        {
                                return (Operaciones)(this.GetFieldValue<int>("ops"));
                        }
                        set
                        {
                                this.SetFieldValue("ops", (int)value);
                        }
                }

                public override string ToString()
                {
                        return this.Objeto.Nombre + ": " + this.Operaciones.ToString();
                }
        }
}
