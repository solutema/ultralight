#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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
	public partial class Inicio : Lfc.FormularioListado
	{
		protected internal Lfx.Types.DateRange m_Fecha = new Lfx.Types.DateRange("mes-0");
		protected internal int m_Sucursal, m_Cliente;
		protected internal int m_Vendedor;

                public Inicio()
                {
                        this.Definicion = new Lazaro.Pres.Listings.Listing()
                        {
                                ElementoTipo = typeof(Lbl.Comprobantes.Recibo),

                                TableName = "recibos",
                                Joins = new qGen.JoinCollection() { new qGen.Join("personas", "recibos.id_cliente=personas.id_persona") },
                                KeyColumnName = new Lazaro.Pres.Field("recibos.id_recibo", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                OrderBy = "recibos.fecha DESC",
                                Columns = new Lazaro.Pres.FieldCollection()
			        {
                                        new Lazaro.Pres.Field("recibos.pv", "PV", Lfx.Data.InputFieldTypes.Integer, 28),
				        new Lazaro.Pres.Field("recibos.numero", "Número", Lfx.Data.InputFieldTypes.Integer, 96),
				        new Lazaro.Pres.Field("recibos.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 96),
				        new Lazaro.Pres.Field("recibos.total", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
				        new Lazaro.Pres.Field("0", "Facturas", Lfx.Data.InputFieldTypes.Text, 160),
				        new Lazaro.Pres.Field("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 240),
				        new Lazaro.Pres.Field("recibos.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 320),
				        new Lazaro.Pres.Field("recibos.obs", "Obs.", Lfx.Data.InputFieldTypes.Memo, 320),
                                        new Lazaro.Pres.Field("recibos.estado", "Estado", Lfx.Data.InputFieldTypes.Integer, 0)
			        }
                        };

                        this.Contadores.Add(new Contador("Total", Lui.Forms.DataTypes.Currency, "$", null));

                        this.HabilitarFiltrar = true;
                }

                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
		{
                        this.Contadores[0].AddValue(row.Fields["total"].ValueDecimal);

                        if (this.Workspace.SlowLink || this.Listado.Items.Count > 300)
                                item.SubItems["0"].Text = "";
                        else
                                item.SubItems["0"].Text = Lbl.Comprobantes.Comprobante.FacturasDeUnRecibo(this.Connection, row.Fields["id_recibo"].ValueInt);

                        if (row.Fields["estado"].ValueInt == 90)
                                item.Font = new Font(item.Font, FontStyle.Strikeout);
		}


                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfx.Types.OperationResult filtrarReturn = base.OnFilter();

                        if (filtrarReturn.Success == true) {
                                using (Comprobantes.Recibos.Filtros FormFiltros = new Comprobantes.Recibos.Filtros()) {
                                        FormFiltros.Connection = this.Connection;
                                        FormFiltros.EntradaSucursal.TextInt = m_Sucursal;
                                        FormFiltros.EntradaCliente.TextInt = m_Cliente;
                                        FormFiltros.EntradaVendedor.TextInt = m_Vendedor;
                                        FormFiltros.EntradaFechas.Rango = m_Fecha;
                                        FormFiltros.Owner = this;
                                        FormFiltros.ShowDialog();

                                        if (FormFiltros.DialogResult == DialogResult.OK) {
                                                m_Sucursal = FormFiltros.EntradaSucursal.TextInt;
                                                m_Cliente = FormFiltros.EntradaCliente.TextInt;
                                                m_Vendedor = FormFiltros.EntradaVendedor.TextInt;
                                                m_Fecha = FormFiltros.EntradaFechas.Rango;

                                                this.RefreshList();
                                                filtrarReturn.Success = true;
                                        } else {
                                                filtrarReturn.Success = false;
                                        }
                                }
                        }

                        return filtrarReturn;
                }

                public override Lfx.Types.OperationResult OnDelete(Lbl.ListaIds itemIds)
                {
                        this.Workspace.RunTime.Execute("INSTANCIAR Lfc.Comprobantes.Recibos.Anular " + itemIds[0].ToString());
                        return base.OnDelete(itemIds);
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

		protected override void OnBeginRefreshList()
		{
                        this.CustomFilters.Clear();

                        if (this.Definicion.ElementoTipo == typeof(Lbl.Comprobantes.ReciboDeCobro))
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
                                        this.CustomFilters.AddWithValue("(recibos.fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.To) + " 23:59:59')");
                        }

                        base.OnBeginRefreshList();
		}
	}
}