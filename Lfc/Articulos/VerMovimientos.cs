// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Articulos
{
	public class VerMovimientos : TablaDetalles
	{
		private System.Collections.Hashtable SituacionCache = new System.Collections.Hashtable();

		#region Código generado por el Diseñador de Windows Forms

		public VerMovimientos()
			:
		    base()
		{

			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent

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
		internal System.Windows.Forms.ListView lvItems;
		internal System.Windows.Forms.ColumnHeader id;
		internal System.Windows.Forms.ColumnHeader fecha;
		internal System.Windows.Forms.ColumnHeader cantidad;
		internal System.Windows.Forms.ColumnHeader obs;
		internal System.Windows.Forms.ColumnHeader saldo;
		internal System.Windows.Forms.ListView lvPedidos;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader desde;
		internal System.Windows.Forms.ColumnHeader hacia;

		private void InitializeComponent()
		{
                        this.lvItems = new System.Windows.Forms.ListView();
                        this.id = new System.Windows.Forms.ColumnHeader();
                        this.fecha = new System.Windows.Forms.ColumnHeader();
                        this.cantidad = new System.Windows.Forms.ColumnHeader();
                        this.desde = new System.Windows.Forms.ColumnHeader();
                        this.hacia = new System.Windows.Forms.ColumnHeader();
                        this.saldo = new System.Windows.Forms.ColumnHeader();
                        this.obs = new System.Windows.Forms.ColumnHeader();
                        this.lvPedidos = new System.Windows.Forms.ListView();
                        this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // lvItems
                        // 
                        this.lvItems.AllowColumnReorder = true;
                        this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.fecha,
            this.cantidad,
            this.desde,
            this.hacia,
            this.saldo,
            this.obs});
                        this.lvItems.FullRowSelect = true;
                        this.lvItems.GridLines = true;
                        this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvItems.HideSelection = false;
                        this.lvItems.Location = new System.Drawing.Point(8, 28);
                        this.lvItems.MultiSelect = false;
                        this.lvItems.Name = "lvItems";
                        this.lvItems.Size = new System.Drawing.Size(608, 135);
                        this.lvItems.TabIndex = 52;
                        this.lvItems.UseCompatibleStateImageBehavior = false;
                        this.lvItems.View = System.Windows.Forms.View.Details;
                        // 
                        // id
                        // 
                        this.id.Text = "Cód";
                        this.id.Width = 0;
                        // 
                        // fecha
                        // 
                        this.fecha.Text = "Fecha";
                        this.fecha.Width = 136;
                        // 
                        // cantidad
                        // 
                        this.cantidad.Text = "Cantidad";
                        this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.cantidad.Width = 80;
                        // 
                        // desde
                        // 
                        this.desde.Text = "Origen";
                        this.desde.Width = 100;
                        // 
                        // hacia
                        // 
                        this.hacia.Text = "Destino";
                        this.hacia.Width = 100;
                        // 
                        // saldo
                        // 
                        this.saldo.Text = "Saldo";
                        this.saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.saldo.Width = 80;
                        // 
                        // obs
                        // 
                        this.obs.Text = "Obs.";
                        this.obs.Width = 480;
                        // 
                        // lvPedidos
                        // 
                        this.lvPedidos.AllowColumnReorder = true;
                        this.lvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader6,
            this.ColumnHeader4,
            this.ColumnHeader5});
                        this.lvPedidos.FullRowSelect = true;
                        this.lvPedidos.GridLines = true;
                        this.lvPedidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvPedidos.HideSelection = false;
                        this.lvPedidos.Location = new System.Drawing.Point(8, 191);
                        this.lvPedidos.MultiSelect = false;
                        this.lvPedidos.Name = "lvPedidos";
                        this.lvPedidos.Size = new System.Drawing.Size(608, 104);
                        this.lvPedidos.TabIndex = 53;
                        this.lvPedidos.UseCompatibleStateImageBehavior = false;
                        this.lvPedidos.View = System.Windows.Forms.View.Details;
                        this.lvPedidos.DoubleClick += new System.EventHandler(this.lvPedidos_DoubleClick);
                        // 
                        // ColumnHeader1
                        // 
                        this.ColumnHeader1.Text = "Cód";
                        this.ColumnHeader1.Width = 0;
                        // 
                        // ColumnHeader2
                        // 
                        this.ColumnHeader2.Text = "Proveedor";
                        this.ColumnHeader2.Width = 240;
                        // 
                        // ColumnHeader3
                        // 
                        this.ColumnHeader3.Text = "Pedido";
                        this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader3.Width = 126;
                        // 
                        // ColumnHeader6
                        // 
                        this.ColumnHeader6.Text = "Fecha";
                        this.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader6.Width = 120;
                        // 
                        // ColumnHeader4
                        // 
                        this.ColumnHeader4.Text = "Cantidad";
                        this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader4.Width = 96;
                        // 
                        // ColumnHeader5
                        // 
                        this.ColumnHeader5.Text = "Precio";
                        this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader5.Width = 96;
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label1.Location = new System.Drawing.Point(8, 8);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(608, 20);
                        this.Label1.TabIndex = 54;
                        this.Label1.Text = "Listado de Movimientos de Stock para este Artículo";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label2.Location = new System.Drawing.Point(8, 171);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(608, 20);
                        this.Label2.TabIndex = 55;
                        this.Label2.Text = "Pedidos Activos";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // VerMovimientos
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(624, 364);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.lvPedidos);
                        this.Controls.Add(this.lvItems);
                        this.Name = "VerMovimientos";
                        this.Text = "Artículos: Detalle de Entrada y Salida";
                        this.Activated += new System.EventHandler(this.FormArticulosMovimDetalles_Activated);
                        this.Controls.SetChildIndex(this.lvItems, 0);
                        this.Controls.SetChildIndex(this.lvPedidos, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.ResumeLayout(false);

		}

		#endregion

		public void Mostrar(int ArticuloId)
		{
			lvItems.BeginUpdate();
			lvItems.Items.Clear();

			System.Data.DataTable Detalles = this.Workspace.DefaultDataBase.Select("SELECT id_movim, id_articulo, desdesituacion, haciasituacion, cantidad, fecha, saldo, obs FROM articulos_movim WHERE id_articulo=" + ArticuloId.ToString() + " ORDER BY fecha");

			ListViewItem itm = null;
			foreach (System.Data.DataRow Detalle in Detalles.Rows)
			{
				string DesdeSituacion = "Público";
				string HaciaSituacion = "Público";

				Detalle["desdesituacion"] = Lfx.Data.DataBase.ConvertDBNullToZero(Detalle["desdesituacion"]);
				Detalle["haciasituacion"] = Lfx.Data.DataBase.ConvertDBNullToZero(Detalle["haciasituacion"]);

				if ((int)Detalle["desdesituacion"] != 0)
				{
					if (SituacionCache[Detalle["desdesituacion"]] == null)
						SituacionCache[Detalle["desdesituacion"]] = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM articulos_situaciones WHERE id_situacion=" + Detalle["desdesituacion"].ToString());
					DesdeSituacion = (string)SituacionCache[(int)Detalle["desdesituacion"]];
				}

				if ((int)Detalle["haciasituacion"] != 0)
				{
					if (SituacionCache[Detalle["haciasituacion"]] == null)
						SituacionCache[Detalle["haciasituacion"]] = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM articulos_situaciones WHERE id_situacion=" + Detalle["haciasituacion"].ToString());
					HaciaSituacion = (string)SituacionCache[(int)Detalle["haciasituacion"]];
				}

				itm = lvItems.Items.Add(System.Convert.ToString(Detalle["id_movim"]));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatDateAndTime(System.Convert.ToDateTime(Detalle["fecha"]))));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Detalle["cantidad"]), this.Workspace.CurrentConfig.Products.StockDecimalPlaces)));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, DesdeSituacion));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, HaciaSituacion));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Detalle["saldo"]), this.Workspace.CurrentConfig.Products.StockDecimalPlaces)));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Detalle["obs"])));
			}
			lvItems.EndUpdate();
			if (itm != null)
			{
				itm.Selected = true;
				itm.Focused = true;
				itm.EnsureVisible();
			}

			lvPedidos.BeginUpdate();
			lvPedidos.Items.Clear();
			System.Data.DataTable Pedidos = this.Workspace.DefaultDataBase.Select(@"SELECT facturas.id_factura, facturas.fecha, facturas.id_cliente, facturas.tipo_fac, facturas.numero, facturas_detalle.cantidad, facturas_detalle.precio, facturas.estado
				FROM facturas, facturas_detalle
				WHERE facturas.id_factura=facturas_detalle.id_factura
					AND facturas.compra=1
					AND facturas.tipo_fac='PD'
				    AND facturas.estado=50
					AND facturas_detalle.id_articulo=" + ArticuloId.ToString() + @"
				ORDER BY facturas.fecha");

			itm = null;
			foreach (System.Data.DataRow Pedido in Pedidos.Rows)
			{
				itm = lvPedidos.Items.Add(System.Convert.ToString(Pedido["id_factura"]));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, this.Workspace.DefaultDataBase.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + Lfx.Data.DataBase.ConvertDBNullToZero(Pedido["id_cliente"]).ToString())));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Pedido["numero"])));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatDateAndTime(System.Convert.ToDateTime(Pedido["fecha"]))));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Pedido["cantidad"]), this.Workspace.CurrentConfig.Products.StockDecimalPlaces)));
				itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Pedido["precio"]), this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto)));
				switch (System.Convert.ToInt32(Pedido["estado"]))
				{
					case 50:
						itm.ForeColor = System.Drawing.Color.DarkOrange;
						break;
					case 100:
						itm.ForeColor = System.Drawing.Color.DarkGreen;
						break;
					case 200:
						itm.ForeColor = System.Drawing.Color.DarkRed;
						itm.Font = new Font(itm.Font, System.Drawing.FontStyle.Strikeout);
						break;
				}
			}
			lvPedidos.EndUpdate();
			if (itm != null)
			{
				itm.Selected = true;
				itm.Focused = true;
				itm.EnsureVisible();
			}
		}

		private void lvPedidos_DoubleClick(object sender, System.EventArgs e)
		{
			if (lvPedidos.SelectedItems.Count > 0)
			{
				ListViewItem Itm = lvPedidos.SelectedItems[0];
				this.Workspace.RunTime.Execute("EDITAR PD " + Itm.Text);
			}
		}

		private void FormArticulosMovimDetalles_Activated(object sender, System.EventArgs e)
		{
			if (lvItems.SelectedItems.Count > 0)
			{
				lvItems.SelectedItems[0].Selected = true;
				lvItems.SelectedItems[0].Focused = true;
				lvItems.SelectedItems[0].EnsureVisible();
			}
		}
	}
}