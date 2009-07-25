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
    public class Filtros: Lui.Forms.DialogForm
    {

        #region Código generado por el Diseñador de Windows Forms

        public Filtros()
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
            if(disposing)
            {
                if(components != null)
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
        internal System.Windows.Forms.Label Label4;
        internal Lui.Forms.DetailBox EntradaCategoria;
        internal System.Windows.Forms.Label Label1;
        internal Lui.Forms.ComboBox EntradaStock;
        internal System.Windows.Forms.Label Label2;
        internal Lui.Forms.DetailBox EntradaProveedor;
        internal Lui.Forms.DetailBox EntradaMarca;
		internal System.Windows.Forms.Label label5;
		internal Lui.Forms.DetailBox EntradaSituacion;
            internal Lui.Forms.TextBox EntradaPvpDesde;
            internal Label label6;
            internal Lui.Forms.TextBox EntradaPvpHasta;
            internal Label label7;
            private TableLayoutPanel tableLayoutPanel1;
            private Panel panel1;
            internal Label label8;
            internal Lui.Forms.ComboBox EntradaAgrupar;
            internal Label label9;
        internal System.Windows.Forms.Label Label3;

        private void InitializeComponent()
        {
                this.Label4 = new System.Windows.Forms.Label();
                this.EntradaCategoria = new Lui.Forms.DetailBox();
                this.Label1 = new System.Windows.Forms.Label();
                this.EntradaStock = new Lui.Forms.ComboBox();
                this.EntradaProveedor = new Lui.Forms.DetailBox();
                this.Label2 = new System.Windows.Forms.Label();
                this.EntradaMarca = new Lui.Forms.DetailBox();
                this.Label3 = new System.Windows.Forms.Label();
                this.EntradaSituacion = new Lui.Forms.DetailBox();
                this.label5 = new System.Windows.Forms.Label();
                this.EntradaPvpDesde = new Lui.Forms.TextBox();
                this.label6 = new System.Windows.Forms.Label();
                this.EntradaPvpHasta = new Lui.Forms.TextBox();
                this.label7 = new System.Windows.Forms.Label();
                this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                this.panel1 = new System.Windows.Forms.Panel();
                this.label8 = new System.Windows.Forms.Label();
                this.EntradaAgrupar = new Lui.Forms.ComboBox();
                this.label9 = new System.Windows.Forms.Label();
                this.tableLayoutPanel1.SuspendLayout();
                this.panel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // OkButton
                // 
                this.OkButton.Location = new System.Drawing.Point(354, 8);
                // 
                // CancelCommandButton
                // 
                this.CancelCommandButton.Location = new System.Drawing.Point(474, 8);
                // 
                // Label4
                // 
                this.Label4.Location = new System.Drawing.Point(3, 0);
                this.Label4.Name = "Label4";
                this.Label4.Size = new System.Drawing.Size(88, 24);
                this.Label4.TabIndex = 0;
                this.Label4.Text = "Categoría";
                this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // EntradaCategoria
                // 
                this.EntradaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.EntradaCategoria.AutoHeight = true;
                this.EntradaCategoria.AutoTab = true;
                this.EntradaCategoria.CanCreate = true;
                this.EntradaCategoria.DetailField = "nombre";
                this.EntradaCategoria.ExtraDetailFields = null;
                this.EntradaCategoria.Filter = "";
                this.EntradaCategoria.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.EntradaCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
                this.EntradaCategoria.FreeTextCode = "";
                this.EntradaCategoria.KeyField = "id_cat_articulo";
                this.EntradaCategoria.Location = new System.Drawing.Point(97, 3);
                this.EntradaCategoria.MaxLength = 200;
                this.EntradaCategoria.Name = "EntradaCategoria";
                this.EntradaCategoria.Padding = new System.Windows.Forms.Padding(2);
                this.EntradaCategoria.ReadOnly = false;
                this.EntradaCategoria.Required = false;
                this.EntradaCategoria.SelectOnFocus = false;
                this.EntradaCategoria.Size = new System.Drawing.Size(444, 24);
                this.EntradaCategoria.TabIndex = 1;
                this.EntradaCategoria.Table = "cat_articulos";
                this.EntradaCategoria.TeclaDespuesDeEnter = "{tab}";
                this.EntradaCategoria.Text = "0";
                this.EntradaCategoria.TextDetail = "";
                this.EntradaCategoria.TextInt = 0;
                this.EntradaCategoria.TipWhenBlank = "Todas";
                this.EntradaCategoria.ToolTipText = "";
                // 
                // Label1
                // 
                this.Label1.Location = new System.Drawing.Point(3, 90);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(88, 24);
                this.Label1.TabIndex = 6;
                this.Label1.Text = "Existencias";
                this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // EntradaStock
                // 
                this.EntradaStock.AutoHeight = true;
                this.EntradaStock.AutoNav = true;
                this.EntradaStock.AutoTab = true;
                this.EntradaStock.DetailField = null;
                this.EntradaStock.Filter = null;
                this.EntradaStock.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.EntradaStock.ForeColor = System.Drawing.SystemColors.ControlText;
                this.EntradaStock.KeyField = null;
                this.EntradaStock.Location = new System.Drawing.Point(97, 93);
                this.EntradaStock.MaxLenght = 32767;
                this.EntradaStock.Name = "EntradaStock";
                this.EntradaStock.Padding = new System.Windows.Forms.Padding(2);
                this.EntradaStock.ReadOnly = false;
                this.EntradaStock.SetData = new string[] {
        "Cualquiera|*",
        "En Existencia|cs",
        "Sin Existencia|ss",
        "Con Faltante|faltante",
        "Con Faltante (Incluyendo Pedidos)|faltanteip",
        "Con Pedidos|pedido",
        "A Pedir|apedir"};
                this.EntradaStock.Size = new System.Drawing.Size(256, 24);
                this.EntradaStock.TabIndex = 7;
                this.EntradaStock.Table = null;
                this.EntradaStock.Text = "Cualquiera";
                this.EntradaStock.TextKey = "*";
                this.EntradaStock.TextRaw = "Cualquiera";
                this.EntradaStock.TipWhenBlank = "";
                this.EntradaStock.ToolTipText = "";
                // 
                // EntradaProveedor
                // 
                this.EntradaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.EntradaProveedor.AutoHeight = true;
                this.EntradaProveedor.AutoTab = true;
                this.EntradaProveedor.CanCreate = false;
                this.EntradaProveedor.DetailField = "nombre_visible";
                this.EntradaProveedor.ExtraDetailFields = null;
                this.EntradaProveedor.Filter = "(tipo&2)=2";
                this.EntradaProveedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.EntradaProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
                this.EntradaProveedor.FreeTextCode = "";
                this.EntradaProveedor.KeyField = "id_persona";
                this.EntradaProveedor.Location = new System.Drawing.Point(97, 63);
                this.EntradaProveedor.MaxLength = 200;
                this.EntradaProveedor.Name = "EntradaProveedor";
                this.EntradaProveedor.Padding = new System.Windows.Forms.Padding(2);
                this.EntradaProveedor.ReadOnly = false;
                this.EntradaProveedor.Required = false;
                this.EntradaProveedor.SelectOnFocus = false;
                this.EntradaProveedor.Size = new System.Drawing.Size(444, 24);
                this.EntradaProveedor.TabIndex = 5;
                this.EntradaProveedor.Table = "personas";
                this.EntradaProveedor.TeclaDespuesDeEnter = "{tab}";
                this.EntradaProveedor.Text = "0";
                this.EntradaProveedor.TextDetail = "";
                this.EntradaProveedor.TextInt = 0;
                this.EntradaProveedor.TipWhenBlank = "Todos";
                this.EntradaProveedor.ToolTipText = "";
                // 
                // Label2
                // 
                this.Label2.Location = new System.Drawing.Point(3, 60);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(88, 24);
                this.Label2.TabIndex = 4;
                this.Label2.Text = "Proveedor";
                this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // EntradaMarca
                // 
                this.EntradaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.EntradaMarca.AutoHeight = true;
                this.EntradaMarca.AutoTab = true;
                this.EntradaMarca.CanCreate = true;
                this.EntradaMarca.DetailField = "nombre";
                this.EntradaMarca.ExtraDetailFields = null;
                this.EntradaMarca.Filter = "";
                this.EntradaMarca.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.EntradaMarca.ForeColor = System.Drawing.SystemColors.ControlText;
                this.EntradaMarca.FreeTextCode = "";
                this.EntradaMarca.KeyField = "id_marca";
                this.EntradaMarca.Location = new System.Drawing.Point(97, 33);
                this.EntradaMarca.MaxLength = 200;
                this.EntradaMarca.Name = "EntradaMarca";
                this.EntradaMarca.Padding = new System.Windows.Forms.Padding(2);
                this.EntradaMarca.ReadOnly = false;
                this.EntradaMarca.Required = false;
                this.EntradaMarca.SelectOnFocus = false;
                this.EntradaMarca.Size = new System.Drawing.Size(444, 24);
                this.EntradaMarca.TabIndex = 3;
                this.EntradaMarca.Table = "marcas";
                this.EntradaMarca.TeclaDespuesDeEnter = "{tab}";
                this.EntradaMarca.Text = "0";
                this.EntradaMarca.TextDetail = "";
                this.EntradaMarca.TextInt = 0;
                this.EntradaMarca.TipWhenBlank = "Todas";
                this.EntradaMarca.ToolTipText = "";
                // 
                // Label3
                // 
                this.Label3.Location = new System.Drawing.Point(3, 30);
                this.Label3.Name = "Label3";
                this.Label3.Size = new System.Drawing.Size(88, 24);
                this.Label3.TabIndex = 2;
                this.Label3.Text = "Marca";
                this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // EntradaSituacion
                // 
                this.EntradaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.EntradaSituacion.AutoHeight = true;
                this.EntradaSituacion.AutoTab = true;
                this.EntradaSituacion.CanCreate = false;
                this.EntradaSituacion.DetailField = "nombre";
                this.EntradaSituacion.ExtraDetailFields = null;
                this.EntradaSituacion.Filter = "";
                this.EntradaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.EntradaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                this.EntradaSituacion.FreeTextCode = "";
                this.EntradaSituacion.KeyField = "id_situacion";
                this.EntradaSituacion.Location = new System.Drawing.Point(97, 123);
                this.EntradaSituacion.MaxLength = 200;
                this.EntradaSituacion.Name = "EntradaSituacion";
                this.EntradaSituacion.Padding = new System.Windows.Forms.Padding(2);
                this.EntradaSituacion.ReadOnly = false;
                this.EntradaSituacion.Required = false;
                this.EntradaSituacion.SelectOnFocus = false;
                this.EntradaSituacion.Size = new System.Drawing.Size(444, 24);
                this.EntradaSituacion.TabIndex = 9;
                this.EntradaSituacion.Table = "articulos_situaciones";
                this.EntradaSituacion.TeclaDespuesDeEnter = "{tab}";
                this.EntradaSituacion.Text = "0";
                this.EntradaSituacion.TextDetail = "";
                this.EntradaSituacion.TextInt = 0;
                this.EntradaSituacion.TipWhenBlank = "Todas";
                this.EntradaSituacion.ToolTipText = "";
                // 
                // label5
                // 
                this.label5.Location = new System.Drawing.Point(3, 120);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(88, 24);
                this.label5.TabIndex = 8;
                this.label5.Text = "Situación";
                this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // EntradaPvpDesde
                // 
                this.EntradaPvpDesde.AutoHeight = false;
                this.EntradaPvpDesde.AutoNav = true;
                this.EntradaPvpDesde.AutoTab = true;
                this.EntradaPvpDesde.DataType = Lui.Forms.DataTypes.Money;
                this.EntradaPvpDesde.DecimalPlaces = -1;
                this.EntradaPvpDesde.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.EntradaPvpDesde.ForceCase = Lui.Forms.TextCasing.None;
                this.EntradaPvpDesde.ForeColor = System.Drawing.SystemColors.ControlText;
                this.EntradaPvpDesde.Location = new System.Drawing.Point(56, 0);
                this.EntradaPvpDesde.MaxLenght = 32767;
                this.EntradaPvpDesde.MultiLine = false;
                this.EntradaPvpDesde.Name = "EntradaPvpDesde";
                this.EntradaPvpDesde.Padding = new System.Windows.Forms.Padding(2);
                this.EntradaPvpDesde.PasswordChar = '\0';
                this.EntradaPvpDesde.Prefijo = "";
                this.EntradaPvpDesde.ReadOnly = false;
                this.EntradaPvpDesde.SelectOnFocus = true;
                this.EntradaPvpDesde.Size = new System.Drawing.Size(108, 24);
                this.EntradaPvpDesde.Sufijo = "";
                this.EntradaPvpDesde.TabIndex = 11;
                this.EntradaPvpDesde.Text = "0.00";
                this.EntradaPvpDesde.TextRaw = "0.00";
                this.EntradaPvpDesde.TipWhenBlank = "";
                this.EntradaPvpDesde.ToolTipText = "";
                // 
                // label6
                // 
                this.label6.Location = new System.Drawing.Point(3, 150);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(88, 24);
                this.label6.TabIndex = 10;
                this.label6.Text = "Precio";
                this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // EntradaPvpHasta
                // 
                this.EntradaPvpHasta.AutoHeight = false;
                this.EntradaPvpHasta.AutoNav = true;
                this.EntradaPvpHasta.AutoTab = true;
                this.EntradaPvpHasta.DataType = Lui.Forms.DataTypes.Money;
                this.EntradaPvpHasta.DecimalPlaces = -1;
                this.EntradaPvpHasta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.EntradaPvpHasta.ForceCase = Lui.Forms.TextCasing.None;
                this.EntradaPvpHasta.ForeColor = System.Drawing.SystemColors.ControlText;
                this.EntradaPvpHasta.Location = new System.Drawing.Point(196, 0);
                this.EntradaPvpHasta.MaxLenght = 32767;
                this.EntradaPvpHasta.MultiLine = false;
                this.EntradaPvpHasta.Name = "EntradaPvpHasta";
                this.EntradaPvpHasta.Padding = new System.Windows.Forms.Padding(2);
                this.EntradaPvpHasta.PasswordChar = '\0';
                this.EntradaPvpHasta.Prefijo = "";
                this.EntradaPvpHasta.ReadOnly = false;
                this.EntradaPvpHasta.SelectOnFocus = true;
                this.EntradaPvpHasta.Size = new System.Drawing.Size(108, 24);
                this.EntradaPvpHasta.Sufijo = "";
                this.EntradaPvpHasta.TabIndex = 13;
                this.EntradaPvpHasta.Text = "0.00";
                this.EntradaPvpHasta.TextRaw = "0.00";
                this.EntradaPvpHasta.TipWhenBlank = "";
                this.EntradaPvpHasta.ToolTipText = "";
                // 
                // label7
                // 
                this.label7.Location = new System.Drawing.Point(164, 0);
                this.label7.Name = "label7";
                this.label7.Size = new System.Drawing.Size(32, 24);
                this.label7.TabIndex = 12;
                this.label7.Text = "y";
                this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // tableLayoutPanel1
                // 
                this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.tableLayoutPanel1.ColumnCount = 2;
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 5);
                this.tableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
                this.tableLayoutPanel1.Controls.Add(this.Label3, 0, 1);
                this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 2);
                this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 3);
                this.tableLayoutPanel1.Controls.Add(this.EntradaSituacion, 1, 4);
                this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
                this.tableLayoutPanel1.Controls.Add(this.EntradaStock, 1, 3);
                this.tableLayoutPanel1.Controls.Add(this.EntradaProveedor, 1, 2);
                this.tableLayoutPanel1.Controls.Add(this.EntradaMarca, 1, 1);
                this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
                this.tableLayoutPanel1.Controls.Add(this.EntradaCategoria, 1, 0);
                this.tableLayoutPanel1.Controls.Add(this.EntradaAgrupar, 1, 6);
                this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
                this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 24);
                this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                this.tableLayoutPanel1.RowCount = 7;
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 288);
                this.tableLayoutPanel1.TabIndex = 0;
                // 
                // panel1
                // 
                this.panel1.Controls.Add(this.EntradaPvpDesde);
                this.panel1.Controls.Add(this.EntradaPvpHasta);
                this.panel1.Controls.Add(this.label8);
                this.panel1.Controls.Add(this.label7);
                this.panel1.Location = new System.Drawing.Point(97, 153);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(443, 28);
                this.panel1.TabIndex = 51;
                // 
                // label8
                // 
                this.label8.Location = new System.Drawing.Point(0, 0);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(56, 24);
                this.label8.TabIndex = 14;
                this.label8.Text = "entre";
                this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // EntradaAgrupar
                // 
                this.EntradaAgrupar.AutoHeight = true;
                this.EntradaAgrupar.AutoNav = true;
                this.EntradaAgrupar.AutoTab = true;
                this.EntradaAgrupar.DetailField = null;
                this.EntradaAgrupar.Filter = null;
                this.EntradaAgrupar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.EntradaAgrupar.ForeColor = System.Drawing.SystemColors.ControlText;
                this.EntradaAgrupar.KeyField = null;
                this.EntradaAgrupar.Location = new System.Drawing.Point(97, 187);
                this.EntradaAgrupar.MaxLenght = 32767;
                this.EntradaAgrupar.Name = "EntradaAgrupar";
                this.EntradaAgrupar.Padding = new System.Windows.Forms.Padding(2);
                this.EntradaAgrupar.ReadOnly = false;
                this.EntradaAgrupar.SetData = new string[] {
        "Sin agrupar|*",
        "Por Categoría|categoria",
        "Por Marca|marca",
        "Por Proveedor|proveedor"};
                this.EntradaAgrupar.Size = new System.Drawing.Size(256, 24);
                this.EntradaAgrupar.TabIndex = 53;
                this.EntradaAgrupar.Table = null;
                this.EntradaAgrupar.Text = "Sin agrupar";
                this.EntradaAgrupar.TextKey = "*";
                this.EntradaAgrupar.TextRaw = "Sin agrupar";
                this.EntradaAgrupar.TipWhenBlank = "";
                this.EntradaAgrupar.ToolTipText = "";
                // 
                // label9
                // 
                this.label9.Location = new System.Drawing.Point(3, 184);
                this.label9.Name = "label9";
                this.label9.Size = new System.Drawing.Size(88, 24);
                this.label9.TabIndex = 52;
                this.label9.Text = "Agrupar";
                this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // Filtros
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                this.ClientSize = new System.Drawing.Size(594, 375);
                this.Controls.Add(this.tableLayoutPanel1);
                this.Name = "Filtros";
                this.Text = "Artículos: Filtros";
                this.tableLayoutPanel1.ResumeLayout(false);
                this.panel1.ResumeLayout(false);
                this.ResumeLayout(false);

		}

        #endregion

    }
}
