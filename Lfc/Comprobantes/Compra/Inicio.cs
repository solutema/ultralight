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

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Compra
{
	public partial class Inicio : Lfc.FormularioListado
	{
                public string m_Tipo = "FP", m_Letra = "*";
		public int m_Proveedor, m_Estado = -1;
		private Lfx.Types.DateRange m_Fecha = new Lfx.Types.DateRange("mes-0");

        	public Inicio()
		{
                        this.ElementoTipo = typeof(Lbl.Comprobantes.ComprobanteDeCompra);

			// agregar código de constructor después de llamar a InitializeComponent
                        this.NombreTabla = "comprob";
			this.Joins.Add(new qGen.Join("comprob_detalle", "comprob.id_comprob=comprob_detalle.id_comprob"));
                        this.KeyField = new Lfx.Data.FormField("comprob.id_comprob", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        this.GroupBy = KeyField;
                        this.OrderBy = "comprob.fecha DESC";
                        this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("comprob.tipo_fac", "Tipo", Lfx.Data.InputFieldTypes.Text, 48),
				new Lfx.Data.FormField("comprob.pv", "PV", Lfx.Data.InputFieldTypes.Integer, 80),
				new Lfx.Data.FormField("comprob.numero", "Número", Lfx.Data.InputFieldTypes.Integer, 120),
				new Lfx.Data.FormField("comprob.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("comprob.id_cliente", "Proveedor", Lfx.Data.InputFieldTypes.Relation, 160),
				new Lfx.Data.FormField("comprob.total", "Total", Lfx.Data.InputFieldTypes.Currency, 96),
                                new Lfx.Data.FormField("comprob.total-comprob.cancelado AS pendiente", "Pendiente", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("comprob.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 0),
                                new Lfx.Data.FormField("comprob.id_formapago", "Pago", Lfx.Data.InputFieldTypes.Text, 0)
			};
                        this.ExtraSearchFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("comprob_detalle.series", "Números de Serie", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("comprob.obs", "Observaciones", Lfx.Data.InputFieldTypes.Memo, 0)
			};

                        this.Contadores.Add(new Contador("Total", Lui.Forms.DataTypes.Currency));

                        this.HabilitarFiltrar = true;
                        this.HabilitarImprimir = true;
                }


                public override Lbl.IElementoDeDatos Crear()
                {
                        Lbl.IElementoDeDatos Res = base.Crear();
                        if (Res is Lbl.Comprobantes.ComprobanteDeCompra) {
                                Lbl.Comprobantes.ComprobanteDeCompra Comprob = Res as Lbl.Comprobantes.ComprobanteDeCompra;
                                string Tipo = this.m_Tipo;
                                if (Tipo == "FP")
                                        Tipo = "FA";
                                Comprob.Tipo = Lbl.Comprobantes.Tipo.TodosPorLetra[Tipo];
                        }
                        return Res;
                }


                protected override void OnItemAdded(ListViewItem itm, Lfx.Data.Row row)
                {
                        itm.SubItems["pv"].Text = row.Fields["pv"].ValueInt.ToString("0000");
                        itm.SubItems["numero"].Text = row.Fields["numero"].ValueInt.ToString("00000000");

                        Lfx.Data.Row Persona = this.Connection.Tables["personas"].FastRows[row.Fields["id_cliente"].ValueInt];
                        if (Persona != null)
                                itm.SubItems["id_cliente"].Text = Persona.Fields["nombre_visible"].ToString();

                        switch (row.Fields["estado"].ValueInt) {
                                case 50:
                                        itm.ForeColor = System.Drawing.Color.DarkOrange;
                                        this.Contadores[0].AddValue(row.Fields["total"].ValueDecimal);
                                        break;
                                case 100:
                                        itm.ForeColor = System.Drawing.Color.DarkGreen;
                                        this.Contadores[0].AddValue(row.Fields["total"].ValueDecimal);
                                        break;
                                case 200:
                                        itm.ForeColor = System.Drawing.Color.DarkRed;
                                        itm.Font = new Font(itm.Font, System.Drawing.FontStyle.Strikeout);
                                        break;
                        }

                        if (row.Fields["id_formapago"] != null) {
                                switch (row.Fields["id_formapago"].ValueInt) {
                                        case 3:
                                                //Controla Pago
                                                break;
                                        default:
                                                itm.SubItems["pendiente"].Text = "";
                                                break;
                                }
                        }
                }

		public override Lfx.Types.OperationResult OnPrint(bool selectPrinter)
		{
			Lfc.Comprobantes.Compra.Listado OFormListado = new Lfc.Comprobantes.Compra.Listado();
                        OFormListado.MdiParent = this.MdiParent;
			OFormListado.m_Tipo = m_Tipo;
                        OFormListado.m_Tipo = m_Letra;
			OFormListado.m_Proveedor = m_Proveedor;
			OFormListado.m_Fecha = m_Fecha;
			OFormListado.Show();
			OFormListado.RefreshList();
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult OnFilter()
		{
			Lfx.Types.OperationResult filtrarReturn = new Lfx.Types.SuccessOperationResult();
			filtrarReturn = base.OnFilter();
			if (filtrarReturn.Success == true)
			{
                                using (Lfc.Comprobantes.Compra.Filtros FormFiltros = new Lfc.Comprobantes.Compra.Filtros()) {
                                        FormFiltros.Connection = this.Connection;
                                        FormFiltros.EntradaTipo.TextKey = m_Tipo;
                                        FormFiltros.EntradaProveedor.Text = m_Proveedor.ToString();
                                        FormFiltros.EntradaFechas.Rango = m_Fecha;
                                        FormFiltros.EntradaEstado.TextKey = m_Estado.ToString();
                                        FormFiltros.ShowDialog();
                                        if (FormFiltros.DialogResult == DialogResult.OK) {
                                                m_Tipo = FormFiltros.EntradaTipo.TextKey;
                                                m_Proveedor = FormFiltros.EntradaProveedor.TextInt;
                                                m_Fecha = FormFiltros.EntradaFechas.Rango;
                                                m_Estado = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaEstado.TextKey);
                                                this.RefreshList();
                                                filtrarReturn.Success = true;
                                        } else {
                                                filtrarReturn.Success = false;
                                        }
                                }
			}
			return filtrarReturn;
		}

                protected override void OnBeginRefreshList()
                {
                        this.CustomFilters.Clear();
                        this.CustomFilters.AddWithValue("compra", 1);
                        switch (m_Tipo) {
                                case "NP":
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", "NP");
                                        if (m_Estado == -1)
                                                this.CustomFilters.AddWithValue("(comprob.estado<=50)");
                                        break;

                                case "PD":
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", "PD");
                                        if (m_Estado == -1)
                                                this.CustomFilters.AddWithValue("(comprob.estado<=50)");
                                        break;

                                case "FP":
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM')");
                                        break;

                                case "RP":
                                case "FA":
                                case "FB":
                                case "FC":
                                case "FE":
                                case "FM":
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", m_Tipo);
                                        break;
                                default:
                                        // Nada
                                        break;
                        }

                        if (m_Proveedor > 0)
                                this.CustomFilters.AddWithValue("comprob.id_cliente", m_Proveedor);

                        if (m_Estado >= 0)
                                this.CustomFilters.AddWithValue("comprob.estado", m_Estado);

                        if (m_Fecha.HasRange)
                                this.CustomFilters.AddWithValue("(comprob.fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.To) + " 23:59:59')");
                }


                public string Tipo
                {
                        get
                        {
                                return m_Tipo;
                        }
                        set
                        {
                                m_Tipo = value;
                        }
                }
	}
}