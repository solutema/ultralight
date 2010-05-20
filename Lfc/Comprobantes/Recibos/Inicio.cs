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

namespace Lfc.Comprobantes.Recibos
{
	public class Inicio : Lui.Forms.ListingForm
	{
		protected internal Lfx.Types.DateRange m_Fecha = new Lfx.Types.DateRange("mes-0");
		protected internal int m_Sucursal, m_Cliente, m_Tipo = 0;
		protected internal double Total = 0;
                protected internal Label Label2;
                protected internal Lui.Forms.TextBox txtTotal;
		protected internal int m_Vendedor;

		#region Código generado por el Diseñador de Windows Forms

		public Inicio()
			: base()
		{


			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
			DataTableName = "recibos";
			this.Joins.Add(new Lfx.Data.Join("personas", "recibos.id_cliente=personas.id_persona"));
                        KeyField = new Lfx.Data.FormField("recibos.id_recibo", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
			OrderBy = "recibos.fecha DESC";
			FormFields = new Lfx.Data.FormField[]
			{
                                new Lfx.Data.FormField("recibos.pv", "PV", Lfx.Data.InputFieldTypes.Integer, 28),
				new Lfx.Data.FormField("recibos.numero", "Número", Lfx.Data.InputFieldTypes.Integer, 96),
				new Lfx.Data.FormField("recibos.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("recibos.total", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("0", "Facturas", Lfx.Data.InputFieldTypes.Text, 160),
				new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("recibos.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("recibos.obs", "Obs.", Lfx.Data.InputFieldTypes.Memo, 320),
                                new Lfx.Data.FormField("recibos.estado", "Estado", Lfx.Data.InputFieldTypes.Integer, 0)
			};
		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.Container components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.

		private void InitializeComponent()
		{
			this.Label2 = new System.Windows.Forms.Label();
			this.txtTotal = new Lui.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lvItems
			// 
			this.Listado.Size = new System.Drawing.Size(546, 466);
			// 
			// FiltersButton
			// 
			this.BotonFiltrar.Visible = true;
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(8, 60);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(40, 20);
			this.Label2.TabIndex = 53;
			this.Label2.Text = "Total";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EntradaTotal
			// 
			this.txtTotal.AutoNav = true;
			this.txtTotal.AutoTab = true;
			this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
			this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtTotal.Location = new System.Drawing.Point(44, 60);
			this.txtTotal.MaxLenght = 32767;
			this.txtTotal.Name = "EntradaTotal";
			this.txtTotal.Padding = new System.Windows.Forms.Padding(2);
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(88, 20);
			this.txtTotal.TabIndex = 54;
			this.txtTotal.TabStop = false;
			this.txtTotal.Text = "0.00";
			this.txtTotal.TipWhenBlank = "";
			this.txtTotal.ToolTipText = "";
			// 
			// Inicio
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(692, 473);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.Label2);
			this.Name = "Inicio";
			this.Text = "Recibos: Listado";
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		public override void ItemAdded(ListViewItem itm)
		{
			Total += Lfx.Types.Parsing.ParseCurrency(itm.SubItems[4].Text);
                        if (this.Workspace.SlowLink)
                                itm.SubItems[5].Text = "";
                        else
                                itm.SubItems[5].Text = Lbl.Comprobantes.Comprobante.FacturasDeUnRecibo(this.DataView, Lfx.Types.Parsing.ParseInt(itm.Text));

                        if (itm.SubItems[9].Text == "90")
                                itm.Font = new Font(itm.Font, FontStyle.Strikeout);
		}

		public override void EndRefreshList()
		{
			txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
			base.EndRefreshList();
		}


		public override Lfx.Types.OperationResult OnCreate()
		{
			this.Workspace.RunTime.Execute("CREAR RC");
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult OnEdit(int lCodigo)
		{
			this.Workspace.RunTime.Execute("EDITAR RC " + lCodigo.ToString());
			return new Lfx.Types.SuccessOperationResult();
		}


                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfx.Types.OperationResult filtrarReturn = base.OnFilter();

                        if (filtrarReturn.Success == true) {
                                Comprobantes.Recibos.Filtros OFiltros = new Comprobantes.Recibos.Filtros();
                                OFiltros.EntradaTipo.TextKey = m_Tipo.ToString();
                                OFiltros.txtSucursal.TextInt = m_Sucursal;
                                OFiltros.txtCliente.TextInt = m_Cliente;
                                OFiltros.txtVendedor.TextInt = m_Vendedor;
                                OFiltros.EntradaFechas.Rango = m_Fecha;
                                OFiltros.Owner = this;
                                OFiltros.ShowDialog();

                                if (OFiltros.DialogResult == DialogResult.OK) {
                                        m_Tipo = Lfx.Types.Parsing.ParseInt(OFiltros.EntradaTipo.TextKey);
                                        m_Sucursal = OFiltros.txtSucursal.TextInt;
                                        m_Cliente = OFiltros.txtCliente.TextInt;
                                        m_Vendedor = OFiltros.txtVendedor.TextInt;
                                        m_Fecha = OFiltros.EntradaFechas.Rango;

                                        this.RefreshList();
                                        filtrarReturn.Success = true;
                                } else {
                                        filtrarReturn.Success = false;
                                }
                                OFiltros = null;
                        }

                        return filtrarReturn;
                }

		public override void BeginRefreshList()
		{
			this.Total = 0;
			string FiltroTemp = "1";

			if(System.Text.RegularExpressions.Regex.IsMatch(SearchText, @"^[0-3]\d(-|/)[0-1]\d(-|/)(\d{2}|\d{4})$")) {
				this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(SearchText).ToString();
			} else if(System.Text.RegularExpressions.Regex.IsMatch(SearchText, @"^[0-3]\d(-|/)[0-1]\d$")) {
				this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(SearchText + System.DateTime.Now.ToString("yyyy")).ToString();
			}

			if(SearchText != null && SearchText.Length == 0)
			{
				if (m_Sucursal > 0)
					FiltroTemp += " AND recibos.id_sucursal=" + m_Sucursal.ToString();

				if (m_Cliente > 0)
					FiltroTemp += " AND recibos.id_cliente=" + m_Cliente.ToString();

				if (m_Vendedor > 0)
					FiltroTemp += " AND recibos.id_vendedor=" + m_Vendedor.ToString();

                                if (m_Tipo == 0)
                                        FiltroTemp += " AND recibos.tipo_fac='RC'";
                                else
                                        FiltroTemp += " AND recibos.tipo_fac='RCP'";

                                if (m_Fecha.HasRange)
                                        FiltroTemp += " AND (fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.To) + " 23:59:59')";
			}

			this.CurrentFilter = FiltroTemp;
		}
	}
}