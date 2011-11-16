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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lui.Forms
{
	public partial class WorkstationSelectorForm : Lui.Forms.DialogForm
	{
		private System.Windows.Forms.ColumnHeader NombreEstacion;
		private System.Windows.Forms.ColumnHeader Nombre;
                private Lui.Forms.ListView Listado;
		public string Estacion;

                public WorkstationSelectorForm()
		{
			InitializeComponent();

                        if (this.HasWorkspace)
                                this.MostrarDatos();
		}

                public override Lfx.Types.OperationResult Ok()
                {
                        if (Listado.SelectedItems != null)
                                this.Estacion = Listado.SelectedItems[0].Text;
                        return base.Ok();
                }


		private void MostrarDatos()
		{
			Listado.Items.Clear();
			ListViewItem itm = Listado.Items.Add(new ListViewItem (new string[] {System.Environment.MachineName.ToUpperInvariant(), "Este equipo"}));
			itm.Selected = (this.Estacion == System.Environment.MachineName.ToUpperInvariant());

			System.Data.DataTable Estaciones = this.Connection.Select("SELECT DISTINCT estacion FROM sys_config ORDER BY estacion");
			foreach(System.Data.DataRow RowEstacion in Estaciones.Rows)
			{
				if((string)RowEstacion["estacion"] != "*" && (string)RowEstacion["estacion"] != System.Environment.MachineName.ToUpperInvariant())
				{
					itm = Listado.Items.Add(new ListViewItem (new string[] {(string)RowEstacion["estacion"], (string)RowEstacion["estacion"]}));
					itm.Selected = (this.Estacion == (string)RowEstacion["estacion"]);
				}
			}		
		}
	}
}

