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

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Recibos
{
	public partial class Inicio : Lui.Forms.ListingForm
	{
		protected internal Lfx.Types.DateRange m_Fecha = new Lfx.Types.DateRange("mes-0");
		protected internal int m_Sucursal, m_Cliente, m_Tipo = 0;
		protected internal double Total = 0;
                protected internal Label Label2;
                protected internal Lui.Forms.TextBox EntradaTotal;
		protected internal int m_Vendedor;

                public Inicio()
                {
                        InitializeComponent();

                        DataTableName = "recibos";
                        this.Joins.Add(new qGen.Join("personas", "recibos.id_cliente=personas.id_persona"));
                        KeyField = new Lfx.Data.FormField("recibos.id_recibo", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        OrderBy = "recibos.fecha DESC";
                        FormFields = new List<Lfx.Data.FormField>()
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

                public override void ItemAdded(ListViewItem itm, Lfx.Data.Row row)
		{
			Total += row.Fields["total"].ValueDouble;
                        if (this.Workspace.SlowLink || this.Listado.Items.Count > 300)
                                itm.SubItems["0"].Text = "";
                        else
                                itm.SubItems["0"].Text = Lbl.Comprobantes.Comprobante.FacturasDeUnRecibo(this.DataBase, row.Fields["id_recibo"].ValueInt);

                        if (row.Fields["estado"].ValueInt == 90)
                                itm.Font = new Font(itm.Font, FontStyle.Strikeout);
		}

		public override void EndRefreshList()
		{
			EntradaTotal.Text = Lfx.Types.Formatting.FormatCurrency(Total, this.Workspace.CurrentConfig.Moneda.Decimales);
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

                public override Lfx.Types.OperationResult OnDelete(int[] itemIds)
                {
                        if (Lui.Login.LoginData.ValidateAccess(Lfx.Workspace.Master.CurrentUser, "documents.delete")) {
                                this.Workspace.RunTime.Execute("ANULAR RC " + itemIds[0].ToString());
                                return base.OnDelete(itemIds);
                        } else {
                                return new Lfx.Types.NoAccessOperationResult();
                        }
                }

                public override string SearchText
                {
                        get
                        {
                                return base.SearchText;
                        }
                        set
                        {
                                if (value == null) {
                                        base.SearchText = null;
                                } else if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[0-3]\d(-|/)[0-1]\d(-|/)(\d{2}|\d{4})$")) {
                                        this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(value).ToString();
                                } else if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[0-3]\d(-|/)[0-1]\d$")) {
                                        this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(value + System.DateTime.Now.ToString("yyyy")).ToString();
                                } else {
                                        base.SearchText = value;
                                }
                        }
                }

		public override void BeginRefreshList()
		{
			this.Total = 0;
                        this.CustomFilters.Clear();

                        if (m_Tipo == 0)
                                this.CustomFilters.AddWithValue("recibos.tipo_fac", "RC");
                        else
                                this.CustomFilters.AddWithValue("recibos.tipo_fac", "RCP");

                        if (SearchText == null) {
                                if (m_Sucursal > 0)
                                        this.CustomFilters.AddWithValue("recibos.id_sucursal", m_Sucursal);

                                if (m_Cliente > 0)
                                        this.CustomFilters.AddWithValue("recibos.id_cliente", m_Cliente);

                                if (m_Vendedor > 0)
                                        this.CustomFilters.AddWithValue("recibos.id_vendedor", m_Vendedor);

                                if (m_Fecha.HasRange)
                                        this.CustomFilters.AddWithValue("(fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.To) + " 23:59:59')");
                        }
		}
	}
}