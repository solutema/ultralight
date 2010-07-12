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

namespace Lui.Forms
{
	partial class AccountForm
	{
		#region Código generado por el Diseñador de Windows Forms

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


		private System.ComponentModel.Container components = null;

		internal System.Windows.Forms.Panel LowerPanel;
                internal Lui.Forms.Button PrintButton;
		internal Lui.Forms.Button CancelCommandButton;
                public Lui.Forms.ListView ItemList;
		internal System.Windows.Forms.ColumnHeader FechaCol;
		internal System.Windows.Forms.ColumnHeader ConceptoCol;
		internal System.Windows.Forms.ColumnHeader SaldoCol;
		public Lui.Forms.Button FilterButton;
		public Lui.Forms.TextBox EtiquetaIngresos;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		public Lui.Forms.TextBox EtiquetaEgresos;
		public Lui.Forms.TextBox EtiquetaSaldo;
		public Lui.Forms.TextBox EtiquetaTransporte;
		internal System.Windows.Forms.ColumnHeader UsuarioCol;
		internal System.Windows.Forms.ColumnHeader extra1;
		internal System.Windows.Forms.ColumnHeader extra2;
		public System.Windows.Forms.Label EtiquetaTitulo;
		internal System.Windows.Forms.ColumnHeader id;
		public System.Windows.Forms.ColumnHeader ColIngreso;
		public System.Windows.Forms.ColumnHeader ColEgreso;

		private void InitializeComponent()
		{
                        this.LowerPanel = new System.Windows.Forms.Panel();
                        this.FilterButton = new Lui.Forms.Button();
                        this.PrintButton = new Lui.Forms.Button();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.ItemList = new Lui.Forms.ListView();
                        this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FechaCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ConceptoCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColIngreso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColEgreso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.SaldoCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.UsuarioCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EtiquetaIngresos = new Lui.Forms.TextBox();
                        this.EtiquetaEgresos = new Lui.Forms.TextBox();
                        this.EtiquetaSaldo = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EtiquetaTransporte = new Lui.Forms.TextBox();
                        this.EtiquetaTitulo = new System.Windows.Forms.Label();
                        this.extra3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.LowerPanel.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.LowerPanel.Controls.Add(this.FilterButton);
                        this.LowerPanel.Controls.Add(this.PrintButton);
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Location = new System.Drawing.Point(0, 208);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(132, 272);
                        this.LowerPanel.TabIndex = 50;
                        // 
                        // FilterButton
                        // 
                        this.FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.FilterButton.AutoHeight = false;
                        this.FilterButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.FilterButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FilterButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FilterButton.Image = null;
                        this.FilterButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.FilterButton.Location = new System.Drawing.Point(12, 12);
                        this.FilterButton.Name = "FilterButton";
                        this.FilterButton.Padding = new System.Windows.Forms.Padding(2);
                        this.FilterButton.ReadOnly = false;
                        this.FilterButton.Size = new System.Drawing.Size(108, 32);
                        this.FilterButton.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.FilterButton.Subtext = "F2";
                        this.FilterButton.TabIndex = 4;
                        this.FilterButton.Text = "Filtros";
                        this.FilterButton.ToolTipText = "";
                        this.FilterButton.Visible = false;
                        this.FilterButton.Click += new System.EventHandler(this.cmdFiltros_Click);
                        // 
                        // PrintButton
                        // 
                        this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PrintButton.AutoHeight = false;
                        this.PrintButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.PrintButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PrintButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.PrintButton.Image = null;
                        this.PrintButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.PrintButton.Location = new System.Drawing.Point(12, 180);
                        this.PrintButton.Name = "PrintButton";
                        this.PrintButton.Padding = new System.Windows.Forms.Padding(2);
                        this.PrintButton.ReadOnly = false;
                        this.PrintButton.Size = new System.Drawing.Size(108, 32);
                        this.PrintButton.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.PrintButton.Subtext = "F8";
                        this.PrintButton.TabIndex = 0;
                        this.PrintButton.Text = "Listado";
                        this.PrintButton.ToolTipText = "";
                        this.PrintButton.Click += new System.EventHandler(this.cmdImprimir_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.CancelCommandButton.AutoHeight = false;
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(12, 220);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(108, 40);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.CancelCommandButton.Subtext = "Esc";
                        this.CancelCommandButton.TabIndex = 2;
                        this.CancelCommandButton.Text = "Volver";
                        this.CancelCommandButton.ToolTipText = "";
                        this.CancelCommandButton.Click += new System.EventHandler(this.cmdCancelar_Click);
                        // 
                        // ItemList
                        // 
                        this.ItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.FechaCol,
            this.ConceptoCol,
            this.ColIngreso,
            this.ColEgreso,
            this.SaldoCol,
            this.UsuarioCol,
            this.extra1,
            this.extra2,
            this.extra3});
                        this.ItemList.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ItemList.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.ItemList.FullRowSelect = true;
                        this.ItemList.GridLines = true;
                        this.ItemList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ItemList.Location = new System.Drawing.Point(208, 4);
                        this.ItemList.MultiSelect = false;
                        this.ItemList.Name = "ItemList";
                        this.ItemList.Size = new System.Drawing.Size(560, 480);
                        this.ItemList.TabIndex = 9;
                        this.ItemList.UseCompatibleStateImageBehavior = false;
                        this.ItemList.View = System.Windows.Forms.View.Details;
                        this.ItemList.DoubleClick += new System.EventHandler(this.lvItems_DoubleClick);
                        this.ItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvItems_KeyDown);
                        this.ItemList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvItems_KeyPress);
                        // 
                        // id
                        // 
                        this.id.Text = "Cód";
                        this.id.Width = 0;
                        // 
                        // FechaCol
                        // 
                        this.FechaCol.Text = "Fecha";
                        this.FechaCol.Width = 86;
                        // 
                        // ConceptoCol
                        // 
                        this.ConceptoCol.Text = "Concepto";
                        this.ConceptoCol.Width = 240;
                        // 
                        // ColIngreso
                        // 
                        this.ColIngreso.Text = "Ingreso";
                        this.ColIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColIngreso.Width = 86;
                        // 
                        // ColEgreso
                        // 
                        this.ColEgreso.Text = "Egreso";
                        this.ColEgreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColEgreso.Width = 86;
                        // 
                        // SaldoCol
                        // 
                        this.SaldoCol.Text = "Saldo";
                        this.SaldoCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.SaldoCol.Width = 86;
                        // 
                        // UsuarioCol
                        // 
                        this.UsuarioCol.Text = "Usuario";
                        this.UsuarioCol.Width = 160;
                        // 
                        // extra1
                        // 
                        this.extra1.Text = "Persona";
                        this.extra1.Width = 120;
                        // 
                        // extra2
                        // 
                        this.extra2.Text = "Obs.";
                        this.extra2.Width = 240;
                        // 
                        // EtiquetaIngresos
                        // 
                        this.EtiquetaIngresos.AutoHeight = false;
                        this.EtiquetaIngresos.AutoNav = true;
                        this.EtiquetaIngresos.AutoTab = true;
                        this.EtiquetaIngresos.DataType = Lui.Forms.DataTypes.Money;
                        this.EtiquetaIngresos.DecimalPlaces = -1;
                        this.EtiquetaIngresos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaIngresos.ForceCase = Lui.Forms.TextCasing.None;
                        this.EtiquetaIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaIngresos.Location = new System.Drawing.Point(88, 100);
                        this.EtiquetaIngresos.MaxLenght = 32767;
                        this.EtiquetaIngresos.MultiLine = false;
                        this.EtiquetaIngresos.Name = "EtiquetaIngresos";
                        this.EtiquetaIngresos.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaIngresos.PasswordChar = '\0';
                        this.EtiquetaIngresos.Prefijo = "$";
                        this.EtiquetaIngresos.ReadOnly = true;
                        this.EtiquetaIngresos.SelectOnFocus = true;
                        this.EtiquetaIngresos.Size = new System.Drawing.Size(108, 24);
                        this.EtiquetaIngresos.Sufijo = "";
                        this.EtiquetaIngresos.TabIndex = 4;
                        this.EtiquetaIngresos.TabStop = false;
                        this.EtiquetaIngresos.Text = "0.00";
                        this.EtiquetaIngresos.TextRaw = "0.00";
                        this.EtiquetaIngresos.TipWhenBlank = "";
                        this.EtiquetaIngresos.ToolTipText = "";
                        // 
                        // EtiquetaEgresos
                        // 
                        this.EtiquetaEgresos.AutoHeight = false;
                        this.EtiquetaEgresos.AutoNav = true;
                        this.EtiquetaEgresos.AutoTab = true;
                        this.EtiquetaEgresos.DataType = Lui.Forms.DataTypes.Money;
                        this.EtiquetaEgresos.DecimalPlaces = -1;
                        this.EtiquetaEgresos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaEgresos.ForceCase = Lui.Forms.TextCasing.None;
                        this.EtiquetaEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaEgresos.Location = new System.Drawing.Point(88, 132);
                        this.EtiquetaEgresos.MaxLenght = 32767;
                        this.EtiquetaEgresos.MultiLine = false;
                        this.EtiquetaEgresos.Name = "EtiquetaEgresos";
                        this.EtiquetaEgresos.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaEgresos.PasswordChar = '\0';
                        this.EtiquetaEgresos.Prefijo = "$";
                        this.EtiquetaEgresos.ReadOnly = true;
                        this.EtiquetaEgresos.SelectOnFocus = true;
                        this.EtiquetaEgresos.Size = new System.Drawing.Size(108, 24);
                        this.EtiquetaEgresos.Sufijo = "";
                        this.EtiquetaEgresos.TabIndex = 6;
                        this.EtiquetaEgresos.TabStop = false;
                        this.EtiquetaEgresos.Text = "0.00";
                        this.EtiquetaEgresos.TextRaw = "0.00";
                        this.EtiquetaEgresos.TipWhenBlank = "";
                        this.EtiquetaEgresos.ToolTipText = "";
                        // 
                        // EtiquetaSaldo
                        // 
                        this.EtiquetaSaldo.AutoHeight = false;
                        this.EtiquetaSaldo.AutoNav = true;
                        this.EtiquetaSaldo.AutoTab = true;
                        this.EtiquetaSaldo.DataType = Lui.Forms.DataTypes.Money;
                        this.EtiquetaSaldo.DecimalPlaces = -1;
                        this.EtiquetaSaldo.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaSaldo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EtiquetaSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaSaldo.Location = new System.Drawing.Point(56, 176);
                        this.EtiquetaSaldo.MaxLenght = 32767;
                        this.EtiquetaSaldo.MultiLine = false;
                        this.EtiquetaSaldo.Name = "EtiquetaSaldo";
                        this.EtiquetaSaldo.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaSaldo.PasswordChar = '\0';
                        this.EtiquetaSaldo.Prefijo = "$";
                        this.EtiquetaSaldo.ReadOnly = true;
                        this.EtiquetaSaldo.SelectOnFocus = true;
                        this.EtiquetaSaldo.Size = new System.Drawing.Size(140, 28);
                        this.EtiquetaSaldo.Sufijo = "";
                        this.EtiquetaSaldo.TabIndex = 8;
                        this.EtiquetaSaldo.TabStop = false;
                        this.EtiquetaSaldo.Text = "0.00";
                        this.EtiquetaSaldo.TextRaw = "0.00";
                        this.EtiquetaSaldo.TipWhenBlank = "";
                        this.EtiquetaSaldo.ToolTipText = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(8, 100);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(84, 24);
                        this.Label1.TabIndex = 3;
                        this.Label1.Text = "Ingresos";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(8, 132);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(84, 24);
                        this.Label2.TabIndex = 5;
                        this.Label2.Text = "Egresos";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(8, 176);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(48, 28);
                        this.Label3.TabIndex = 7;
                        this.Label3.Text = "Saldo";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(8, 60);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(80, 24);
                        this.Label4.TabIndex = 1;
                        this.Label4.Text = "Transporte";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaTransporte
                        // 
                        this.EtiquetaTransporte.AutoHeight = false;
                        this.EtiquetaTransporte.AutoNav = true;
                        this.EtiquetaTransporte.AutoTab = true;
                        this.EtiquetaTransporte.DataType = Lui.Forms.DataTypes.Money;
                        this.EtiquetaTransporte.DecimalPlaces = -1;
                        this.EtiquetaTransporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaTransporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.EtiquetaTransporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaTransporte.Location = new System.Drawing.Point(88, 60);
                        this.EtiquetaTransporte.MaxLenght = 32767;
                        this.EtiquetaTransporte.MultiLine = false;
                        this.EtiquetaTransporte.Name = "EtiquetaTransporte";
                        this.EtiquetaTransporte.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaTransporte.PasswordChar = '\0';
                        this.EtiquetaTransporte.Prefijo = "$";
                        this.EtiquetaTransporte.ReadOnly = true;
                        this.EtiquetaTransporte.SelectOnFocus = true;
                        this.EtiquetaTransporte.Size = new System.Drawing.Size(108, 24);
                        this.EtiquetaTransporte.Sufijo = "";
                        this.EtiquetaTransporte.TabIndex = 2;
                        this.EtiquetaTransporte.TabStop = false;
                        this.EtiquetaTransporte.Text = "0.00";
                        this.EtiquetaTransporte.TextRaw = "0.00";
                        this.EtiquetaTransporte.TipWhenBlank = "";
                        this.EtiquetaTransporte.ToolTipText = "";
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(8, 8);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(188, 44);
                        this.EtiquetaTitulo.TabIndex = 0;
                        this.EtiquetaTitulo.Text = "Caja";
                        this.EtiquetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // extra3
                        // 
                        this.extra3.Text = "Comprob";
                        this.extra3.Width = 160;
                        // 
                        // AccountForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(768, 480);
                        this.Controls.Add(this.ItemList);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EtiquetaTransporte);
                        this.Controls.Add(this.EtiquetaSaldo);
                        this.Controls.Add(this.EtiquetaEgresos);
                        this.Controls.Add(this.EtiquetaIngresos);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.LowerPanel);
                        this.KeyPreview = true;
                        this.Name = "AccountForm";
                        this.Text = "Caja";
                        this.Activated += new System.EventHandler(this.AccountForm_Activated);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountForm_KeyDown);
                        this.LowerPanel.ResumeLayout(false);
                        this.ResumeLayout(false);

		}


		#endregion

                private System.Windows.Forms.ColumnHeader extra3;
	}
}
