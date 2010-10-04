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
using System.Windows.Forms;

namespace Lfc.Pvs
{
	public class Inicio : Lui.Forms.ListingForm
	{
		private System.ComponentModel.IContainer components = null;

		public Inicio()
		{
			InitializeComponent();

			DataTableName = "pvs";
                        KeyField = new Lfx.Data.FormField("pvs.id_pv", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        this.Joins.Add(new qGen.Join("sucursales", "pvs.id_sucursal=sucursales.id_sucursal"));
			FormFields = new List<Lfx.Data.FormField>()
			{
				new Lfx.Data.FormField("pvs.id_pv", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                new Lfx.Data.FormField("pvs.tipo_fac", "Comprobantes", Lfx.Data.InputFieldTypes.Text, 180),
                                new Lfx.Data.FormField("pvs.numero", "PV", Lfx.Data.InputFieldTypes.Integer, 96),
				new Lfx.Data.FormField("sucursales.nombre", "Sucursal", Lfx.Data.InputFieldTypes.Text, 160),
				new Lfx.Data.FormField("pvs.tipo", "Tipo", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("pvs.estacion", "Estacion", Lfx.Data.InputFieldTypes.Text, 160),
				new Lfx.Data.FormField("pvs.carga", "Carga", Lfx.Data.InputFieldTypes.Text, 120),
                                new Lfx.Data.FormField("pvs.detalonario", "Usa Talonario", Lfx.Data.InputFieldTypes.Bool, 120)
			};

			BotonFiltrar.Visible = false;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion

                public override void ItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        switch (row.Fields["tipo_fac"].ValueString) {
                                case "F":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Facturas";
                                        break;
                                case "F,ND":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Facturas, Notas de Débito";
                                        break;
                                case "F,NC,ND":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Facturas, Notas de Crédito y Débito";
                                        break;
                                case "R":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Remitos";
                                        break;
                                case "RC":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Recibos de Cobro";
                                        break;
                                case "RP":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Recibos de Pago";
                                        break;
                        }

                        int TipoPv = row.Fields["tipo"].ValueInt;
                        if (TipoPv == 0)
                                item.SubItems[Listado.Columns["pvs.tipo"].Index].Text = "Inactivo";
                        if (TipoPv == 1)
                                item.SubItems[Listado.Columns["pvs.tipo"].Index].Text = "Normal";
                        else if (TipoPv == 2)
                                item.SubItems[Listado.Columns["pvs.tipo"].Index].Text = "Fiscal";

                        if (item.SubItems[Listado.Columns["pvs.carga"].Index].Text == "0")
                                item.SubItems[Listado.Columns["pvs.carga"].Index].Text = "Automática";
                        else if (item.SubItems[Listado.Columns["pvs.carga"].Index].Text == "1")
                                item.SubItems[Listado.Columns["pvs.carga"].Index].Text = "Manual";
                }

		public override Lfx.Types.OperationResult OnCreate()
		{
			this.Workspace.RunTime.Execute("CREAR PV");
			return new Lfx.Types.SuccessOperationResult();
		}

		public override Lfx.Types.OperationResult OnEdit(int lCodigo)
		{
                        this.Workspace.RunTime.Execute("EDITAR PV " + lCodigo.ToString());
			return new Lfx.Types.SuccessOperationResult();
		}
	}
}

