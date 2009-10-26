// Copyright 2004-2009 South Bridge S.R.L.
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
	public class MasInfo :
	    Lui.Forms.DialogForm
	{
		private int m_Articulo;

		#region Código generado por el Diseñador de Windows Forms

		public MasInfo()
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
			if(disposing) {
				if(components != null) {
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
		internal System.Windows.Forms.Label Label1;
		internal Lui.Forms.TextBox txtFechaCreado;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal Lui.Forms.TextBox txtFechaPrecio;
		internal Lui.Forms.TextBox txtCostoUlt;
		internal Lui.Forms.TextBox txtCostoProm;
                internal Lui.Forms.ListView lvItems;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.ColumnHeader fecha;
		internal System.Windows.Forms.ColumnHeader costo;
		internal System.Windows.Forms.ColumnHeader pvp;
		internal System.Windows.Forms.ColumnHeader usuario;

		private void InitializeComponent()
		{
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtFechaCreado = new Lui.Forms.TextBox();
                        this.txtFechaPrecio = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtCostoUlt = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtCostoProm = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.lvItems = new Lui.Forms.ListView();
                        this.fecha = new System.Windows.Forms.ColumnHeader();
                        this.costo = new System.Windows.Forms.ColumnHeader();
                        this.pvp = new System.Windows.Forms.ColumnHeader();
                        this.usuario = new System.Windows.Forms.ColumnHeader();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(394, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(514, 8);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(12, 12);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(132, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Fecha de Creación";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFechaCreado
                        // 
                        this.txtFechaCreado.AutoNav = true;
                        this.txtFechaCreado.AutoTab = true;
                        this.txtFechaCreado.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtFechaCreado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFechaCreado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFechaCreado.Location = new System.Drawing.Point(144, 12);
                        this.txtFechaCreado.MaxLenght = 32767;
                        this.txtFechaCreado.Name = "txtFechaCreado";
                        this.txtFechaCreado.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFechaCreado.ReadOnly = true;
                        this.txtFechaCreado.Size = new System.Drawing.Size(140, 24);
                        this.txtFechaCreado.TabIndex = 51;
                        this.txtFechaCreado.TipWhenBlank = "";
                        this.txtFechaCreado.ToolTipText = "";
                        // 
                        // txtFechaPrecio
                        // 
                        this.txtFechaPrecio.AutoNav = true;
                        this.txtFechaPrecio.AutoTab = true;
                        this.txtFechaPrecio.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtFechaPrecio.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFechaPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFechaPrecio.Location = new System.Drawing.Point(144, 40);
                        this.txtFechaPrecio.MaxLenght = 32767;
                        this.txtFechaPrecio.Name = "txtFechaPrecio";
                        this.txtFechaPrecio.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFechaPrecio.ReadOnly = true;
                        this.txtFechaPrecio.Size = new System.Drawing.Size(140, 24);
                        this.txtFechaPrecio.TabIndex = 53;
                        this.txtFechaPrecio.TipWhenBlank = "";
                        this.txtFechaPrecio.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(12, 40);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(132, 24);
                        this.Label2.TabIndex = 52;
                        this.Label2.Text = "Fecha del Precio";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCostoUlt
                        // 
                        this.txtCostoUlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtCostoUlt.AutoNav = true;
                        this.txtCostoUlt.AutoTab = true;
                        this.txtCostoUlt.DataType = Lui.Forms.DataTypes.Money;
                        this.txtCostoUlt.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCostoUlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCostoUlt.Location = new System.Drawing.Point(368, 251);
                        this.txtCostoUlt.MaxLenght = 32767;
                        this.txtCostoUlt.Name = "txtCostoUlt";
                        this.txtCostoUlt.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCostoUlt.ReadOnly = false;
                        this.txtCostoUlt.Size = new System.Drawing.Size(92, 24);
                        this.txtCostoUlt.TabIndex = 55;
                        this.txtCostoUlt.Text = "0.00";
                        this.txtCostoUlt.TipWhenBlank = "";
                        this.txtCostoUlt.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label3.Location = new System.Drawing.Point(12, 251);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(356, 24);
                        this.Label3.TabIndex = 54;
                        this.Label3.Text = "Costo de la última Compra";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCostoProm
                        // 
                        this.txtCostoProm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtCostoProm.AutoNav = true;
                        this.txtCostoProm.AutoTab = true;
                        this.txtCostoProm.DataType = Lui.Forms.DataTypes.Money;
                        this.txtCostoProm.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCostoProm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCostoProm.Location = new System.Drawing.Point(368, 279);
                        this.txtCostoProm.MaxLenght = 32767;
                        this.txtCostoProm.Name = "txtCostoProm";
                        this.txtCostoProm.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCostoProm.ReadOnly = false;
                        this.txtCostoProm.Size = new System.Drawing.Size(92, 24);
                        this.txtCostoProm.TabIndex = 57;
                        this.txtCostoProm.Text = "0.00";
                        this.txtCostoProm.TipWhenBlank = "";
                        this.txtCostoProm.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label4.Location = new System.Drawing.Point(12, 279);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(356, 24);
                        this.Label4.TabIndex = 56;
                        this.Label4.Text = "Costo Promedio de las Últimas 5 Compras";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lvItems
                        // 
                        this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fecha,
            this.costo,
            this.pvp,
            this.usuario});
                        this.lvItems.FullRowSelect = true;
                        this.lvItems.GridLines = true;
                        this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvItems.LabelWrap = false;
                        this.lvItems.Location = new System.Drawing.Point(12, 96);
                        this.lvItems.MultiSelect = false;
                        this.lvItems.Name = "lvItems";
                        this.lvItems.Size = new System.Drawing.Size(612, 147);
                        this.lvItems.TabIndex = 59;
                        this.lvItems.TabStop = false;
                        this.lvItems.UseCompatibleStateImageBehavior = false;
                        this.lvItems.View = System.Windows.Forms.View.Details;
                        // 
                        // fecha
                        // 
                        this.fecha.Text = "Fecha";
                        this.fecha.Width = 89;
                        // 
                        // costo
                        // 
                        this.costo.Text = "Costo";
                        this.costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.costo.Width = 96;
                        // 
                        // pvp
                        // 
                        this.pvp.Text = "PVP";
                        this.pvp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.pvp.Width = 96;
                        // 
                        // usuario
                        // 
                        this.usuario.Text = "Usuario";
                        this.usuario.Width = 142;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(12, 72);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(612, 24);
                        this.Label5.TabIndex = 60;
                        this.Label5.Text = "Historial de Precios:";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // MasInfo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.lvItems);
                        this.Controls.Add(this.txtCostoProm);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtCostoUlt);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.txtFechaPrecio);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtFechaCreado);
                        this.Controls.Add(this.Label1);
                        this.Name = "MasInfo";
                        this.Text = "Artículo: Info";
                        this.ResumeLayout(false);

		}

		#endregion

		public int Articulo
		{
			get
			{
				return m_Articulo;
			}
			set
			{
				m_Articulo = value;

				if(m_Articulo > 0) {
					Lfx.Data.Row Art = this.Workspace.DefaultDataBase.Row("articulos", "id_articulo, fecha_creado, fecha_precio", "id_articulo", m_Articulo);
					txtFechaCreado.Text = Lfx.Types.Formatting.FormatDate(Art["fecha_creado"]);
					txtFechaPrecio.Text = Lfx.Types.Formatting.FormatDate(Art["fecha_precio"]);
					double PrecioUltComp = this.Workspace.DefaultDataBase.FieldDouble("SELECT facturas_detalle.precio FROM facturas, facturas_detalle WHERE facturas.id_factura=facturas_detalle.id_factura AND facturas.compra=1 AND facturas.tipo_fac IN ('R', 'A', 'B', 'C', 'E', 'M') AND facturas.compra=1 AND id_articulo=" + m_Articulo.ToString() + " GROUP BY facturas.id_factura ORDER BY facturas_detalle.id_factura_detalle DESC");
					txtCostoUlt.Text = Lfx.Types.Formatting.FormatCurrency(PrecioUltComp, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto);

					// Podra hacer esto con una subconsulta, pero la versión de MySql que estamos utilizando
					// no permite la cláusula LIMIT dentro de una subconsulta IN ()
					PrecioUltComp = 0;
					System.Data.DataTable UltimasCompras = this.Workspace.DefaultDataBase.Select("SELECT facturas_detalle.precio, facturas.id_factura FROM facturas, facturas_detalle WHERE facturas.id_factura=facturas_detalle.id_factura AND facturas.compra=1 AND facturas.tipo_fac IN ('R', 'A', 'B', 'C', 'E', 'M') AND facturas.compra=1 AND facturas_detalle.id_articulo=" + m_Articulo.ToString() + " ORDER BY facturas.fecha DESC LIMIT 5");

					if(UltimasCompras.Rows.Count > 0) {
						foreach(System.Data.DataRow Compra in UltimasCompras.Rows) {
							PrecioUltComp += System.Convert.ToDouble(Compra["precio"]);
						}

						PrecioUltComp = PrecioUltComp / UltimasCompras.Rows.Count;
						txtCostoProm.Text = Lfx.Types.Formatting.FormatCurrency(PrecioUltComp, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto);
					}

					System.Data.DataTable Precios = this.Workspace.DefaultDataBase.Select("SELECT fecha, costo, pvp FROM articulos_precios WHERE id_articulo=" + m_Articulo.ToString() + " ORDER BY fecha DESC LIMIT 100");
					lvItems.Items.Clear();

					foreach(System.Data.DataRow Precio in Precios.Rows) {
						ListViewItem Itm = lvItems.Items.Add(Lfx.Types.Formatting.FormatDate(Precio["fecha"]));
						Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Precio["costo"]), this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto)));
						Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Precio["pvp"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
					}
				}
			}
		}
	}
}