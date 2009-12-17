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

namespace Lfc.Comprobantes.Compra
{
	public partial class Inicio : Lui.Forms.ListingForm
	{
                private double EnVerde = 0;
                private double EnNaranja = 0;

		public string m_Tipo = "PD";
		public int m_Proveedor, m_Estado = -1;
		private Lfx.Types.DateRange m_Fecha = new Lfx.Types.DateRange("mes-0");

        	public Inicio()
		{
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
			DataTableName = "facturas";
			this.Joins.Add(new Lfx.Data.Join("facturas_detalle", "facturas.id_factura=facturas_detalle.id_factura"));
                        KeyField = new Lfx.Data.FormField("facturas.id_factura", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
			GroupBy = KeyField;
			OrderBy = "facturas.fecha DESC";
			FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("facturas.tipo_fac", "Tipo", Lfx.Data.InputFieldTypes.Text, 28),
				new Lfx.Data.FormField("facturas.pv", "PV", Lfx.Data.InputFieldTypes.Integer, 32),
				new Lfx.Data.FormField("facturas.numero", "Número", Lfx.Data.InputFieldTypes.Integer, 100),
				new Lfx.Data.FormField("facturas.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("facturas.id_cliente", "Proveedor", Lfx.Data.InputFieldTypes.Relation, 160),
				new Lfx.Data.FormField("facturas.total", "Total", Lfx.Data.InputFieldTypes.Currency, 96),
                                new Lfx.Data.FormField("facturas.total-facturas.cancelado", "Pendiente", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("facturas.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 0),
                                new Lfx.Data.FormField("facturas.id_formapago", "Pago", Lfx.Data.InputFieldTypes.Text, 0)
			};
			ExtraSearchFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("facturas_detalle.series", "Números de Serie", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("facturas.obs", "Observaciones", Lfx.Data.InputFieldTypes.Memo, 0)
			};

			BotonFiltrar.Visible = true;
			BotonImprimir.Visible = true;

                }


                public override void ItemAdded(ListViewItem itm)
                {
                        itm.SubItems[2].Text = Lfx.Types.Parsing.ParseInt(itm.SubItems[2].Text).ToString("0000");
                        itm.SubItems[3].Text = Lfx.Types.Parsing.ParseInt(itm.SubItems[3].Text).ToString("00000000");

                        Lfx.Data.Row Persona = this.DataView.Tables["personas"].FastRows[Lfx.Types.Parsing.ParseInt(itm.SubItems[5].Text)];
                        if (Persona != null)
                                itm.SubItems[5].Text = Persona.Fields["nombre_visible"].ToString();

                        switch (Lfx.Types.Parsing.ParseInt(itm.SubItems[8].Text)) {
                                case 50:
                                        itm.ForeColor = System.Drawing.Color.DarkOrange;
                                        EnNaranja += Lfx.Types.Parsing.ParseCurrency(itm.SubItems[6].Text);
                                        break;
                                case 100:
                                        itm.ForeColor = System.Drawing.Color.DarkGreen;
                                        EnVerde += Lfx.Types.Parsing.ParseCurrency(itm.SubItems[6].Text);
                                        break;
                                case 200:
                                        itm.ForeColor = System.Drawing.Color.DarkRed;
                                        itm.Font = new Font(itm.Font, System.Drawing.FontStyle.Strikeout);
                                        break;
                        }

                        switch (Lfx.Types.Parsing.ParseInt(itm.SubItems[9].Text)) {
                                case 3:
                                        //Controla Pago
                                        break;
                                default:
                                        itm.SubItems[7].Text = "";
                                        break;
                        }
                }

		public override Lfx.Types.OperationResult OnPrint(bool selectPrinter)
		{
			Lfc.Comprobantes.Compra.Listado OFormListado = new Lfc.Comprobantes.Compra.Listado();
                        OFormListado.Workspace = this.Workspace;
                        OFormListado.MdiParent = this.MdiParent;
			OFormListado.m_Tipo = m_Tipo;
			OFormListado.m_Proveedor = m_Proveedor;
			OFormListado.m_Fecha = m_Fecha;
			OFormListado.Show();
			OFormListado.RefreshList();
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult OnCreate()
		{
			Lfc.Comprobantes.Compra.Crear OFormPedidosCrear = new Lfc.Comprobantes.Compra.Crear();
			OFormPedidosCrear.TipoComprob = m_Tipo;
			if (OFormPedidosCrear.ShowDialog() == DialogResult.OK)
			{
				string Tipo = OFormPedidosCrear.TipoComprob;
				OFormPedidosCrear = null;
				this.Workspace.RunTime.Execute("CREAR " + Tipo);
			}
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult OnEdit(int lCodigo)
		{
			this.Workspace.RunTime.Execute("EDITAR NP " + lCodigo.ToString());
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult OnFilter()
		{
			Lfx.Types.OperationResult filtrarReturn = new Lfx.Types.SuccessOperationResult();
			filtrarReturn = base.OnFilter();
			if (filtrarReturn.Success == true)
			{
                                Lfc.Comprobantes.Compra.Filtros OFiltros = new Lfc.Comprobantes.Compra.Filtros();
				OFiltros.Workspace = this.Workspace;
				OFiltros.txtTipo.TextKey = m_Tipo;
				OFiltros.txtProveedor.Text = m_Proveedor.ToString();
				OFiltros.EntradaFechas.Rango = m_Fecha;
				OFiltros.txtEstado.TextKey = m_Estado.ToString();
				OFiltros.ShowDialog();
				if (OFiltros.DialogResult == DialogResult.OK)
				{
					m_Tipo = OFiltros.txtTipo.TextKey;
					m_Proveedor = OFiltros.txtProveedor.TextInt;
					m_Fecha = OFiltros.EntradaFechas.Rango;
					m_Estado = Lfx.Types.Parsing.ParseInt(OFiltros.txtEstado.TextKey);
					this.RefreshList();
					filtrarReturn.Success = true;
				}
				else
				{
					filtrarReturn.Success = false;
				}
			}
			return filtrarReturn;
		}

		public override void RefreshList()
		{
                        EnNaranja = EnVerde = 0;

			string FiltroTemp = "compra=1";
			switch (m_Tipo)
			{
				case "NP":
					FiltroTemp += " AND facturas.tipo_fac='NP'";
                                        if (m_Estado == -1)
                                                FiltroTemp += " AND (facturas.estado<=50)";
					break;
				case "PD":
					FiltroTemp += " AND facturas.tipo_fac='PD'";
                                        if (m_Estado == -1)
                                                FiltroTemp += " AND (facturas.estado<=50)";
					break;
				
				case "FP":
                                        FiltroTemp += " AND facturas.tipo_fac IN ('A', 'B', 'C', 'E')";
                                        break;
                                case "R":
                                case "A":
                                case "B":
                                case "C":
                                case "E":
                                case "M":
                                        FiltroTemp += " AND facturas.tipo_fac='" + m_Tipo +"'";
                                        break;
                                default:
					// Nada
					break;
			}

			if (m_Proveedor > 0)
				FiltroTemp += " AND (facturas.id_cliente=" + m_Proveedor.ToString() + ")";

			if (m_Estado >= 0)
				FiltroTemp += " AND (facturas.estado=" + m_Estado.ToString() + ")";

                        if (m_Fecha.HasRange)
                                FiltroTemp += " AND (facturas.fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.To) + " 23:59:59')";

			this.CurrentFilter = FiltroTemp;
			base.RefreshList();

                        txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(EnVerde + EnNaranja, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        txtPendiente.Text = Lfx.Types.Formatting.FormatCurrency(EnNaranja, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
		}

	}
}