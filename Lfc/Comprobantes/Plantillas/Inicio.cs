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

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Plantillas
{
	public class Inicio : Lui.Forms.ListingForm
	{
		private System.ComponentModel.IContainer components = null;

		public Inicio()
		{
			InitializeComponent();

			DataTableName = "sys_plantillas";
                        KeyField = new Lfx.Data.FormField("sys_plantillas.id_plantilla", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
			FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("sys_plantillas.codigo", "Código", Lfx.Data.InputFieldTypes.Text, 96),
				new Lfx.Data.FormField("sys_plantillas.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 160),
                                new Lfx.Data.FormField("sys_plantillas.tamanopapel", "Papel", Lfx.Data.InputFieldTypes.Text, 64),
				new Lfx.Data.FormField("sys_plantillas.copias", "Copias", Lfx.Data.InputFieldTypes.Integer, 64)
			};
			OrderBy = "sys_plantillas.codigo";

			BotonFiltrar.Visible = false;
			BotonImprimir.Visible = false;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if(disposing)
			{
				if(components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// lvItems
			// 
			this.Listado.Name = "lvItems";
			this.Listado.Size = new System.Drawing.Size(546, 466);
			// 
			// CreateButton
			// 
			this.BotonCrear.DockPadding.All = 2;
			this.BotonCrear.Name = "CreateButton";
			// 
			// FiltersButton
			// 
			this.BotonFiltrar.DockPadding.All = 2;
			this.BotonFiltrar.Name = "FiltersButton";
			// 
			// PrintButton
			// 
			this.BotonImprimir.DockPadding.All = 2;
			this.BotonImprimir.Name = "PrintButton";
			// 
			// Inicio
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(692, 473);
			this.Name = "Inicio";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

