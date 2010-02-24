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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cajas.Conceptos
{
	public class Inicio : Lui.Forms.ListingForm
	{

		#region 'Windows Form Designer generated code'

		public Inicio()
			: base()
		{


			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
			DataTableName = "conceptos";
                        KeyField = new Lfx.Data.FormField("conceptos.id_concepto", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
			FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("conceptos.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("conceptos.es", "Tipo", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("conceptos.grupo", "Grupo", Lfx.Data.InputFieldTypes.Text, 120)
			};
		}

		// Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;

		// NOTE: The following procedure is required by the Windows Form Designer
		// It can be modified using the Windows Form Designer.  
		// Do not modify it using the code editor.

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// lvItems
			// 
			this.Listado.Name = "lvItems";
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
			this.Text = "Listado: Conceptos";
			this.ResumeLayout(false);

		}


		#endregion

		public override void ItemAdded(ListViewItem itm)
		{
			string Codigo = itm.Text;
			if(Codigo.Substring(2, 1) != "0")
				itm.SubItems[1].Text = "    " + itm.SubItems[1].Text;
			if(Codigo.Substring(3, 1) != "0")
				itm.SubItems[1].Text = "    " + itm.SubItems[1].Text;

			switch(Lfx.Types.Parsing.ParseInt(itm.SubItems[2].Text)) {
				case 1:
					itm.SubItems[2].Text = "Entrada";
					break;
				case 2:
					itm.SubItems[2].Text = "Salida";
					break;
				case 0:
					itm.SubItems[2].Text = "Entrada/Salida";
					break;
				default:
					itm.SubItems[2].Text = "???";
					break;
			}

			switch(Lfx.Types.Parsing.ParseInt(itm.SubItems[3].Text)) {
				case 0:
					itm.SubItems[3].Text = "-";
					break;
				case 110:
					itm.SubItems[3].Text = "Cobros";
					break;
				case 100:
					itm.SubItems[3].Text = "Otros ingresos";
					break;
				case 230:
					itm.SubItems[3].Text = "Gastos fijos";
					break;
				case 240:
					itm.SubItems[3].Text = "Gastos variables";
					break;
				case 200:
					itm.SubItems[3].Text = "Otros gastos";
					break;
				case 260:
					itm.SubItems[3].Text = "Pérdida";
					break;
				case 250:
					itm.SubItems[3].Text = "Reinversión";
					break;
				case 210:
					itm.SubItems[3].Text = "Costo materiales";
					break;
				case 220:
					itm.SubItems[3].Text = "Costo capital";
					break;
				case 231:
					itm.SubItems[3].Text = "Sueldos y salarios";
					break;
				case 300:
					itm.SubItems[3].Text = "Movimientos y ajustes";
					break;
				default:
					itm.SubItems[3].Text = "???";
					break;
			}

		}


		public override Lfx.Types.OperationResult OnCreate()
		{
			this.Workspace.RunTime.Execute("CREAR CONCEPTO");
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult OnEdit(int lCodigo)
		{
			this.Workspace.RunTime.Execute("EDITAR CONCEPTO " + lCodigo.ToString());
			return new Lfx.Types.SuccessOperationResult();
		}
	}
}