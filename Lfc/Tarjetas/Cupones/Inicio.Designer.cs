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

namespace Lfc.Tarjetas.Cupones
{
        public partial class Inicio
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.LowerPanel = new System.Windows.Forms.Panel();
                        this.cmdAnular = new Lui.Forms.Button();
                        this.cmdAcreditar = new Lui.Forms.Button();
                        this.cmdPresentar = new Lui.Forms.Button();
                        this.FilterButton = new Lui.Forms.Button();
                        this.PrintButton = new Lui.Forms.Button();
                        this.cmdMostrar = new Lui.Forms.Button();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.ItemList = new Lui.Forms.ListView();
                        this.ChId = new System.Windows.Forms.ColumnHeader();
                        this.ChFecha = new System.Windows.Forms.ColumnHeader();
                        this.ChConcepto = new System.Windows.Forms.ColumnHeader();
                        this.ChTarjeta = new System.Windows.Forms.ColumnHeader();
                        this.ChCupon = new System.Windows.Forms.ColumnHeader();
                        this.ChImporte = new System.Windows.Forms.ColumnHeader();
                        this.ChEstado = new System.Windows.Forms.ColumnHeader();
                        this.ChPlan = new System.Windows.Forms.ColumnHeader();
                        this.EtiquetaTitulo = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EtiquetaImporteSinPresentar = new Lui.Forms.TextBox();
                        this.EtiquetaImporteAcreditados = new Lui.Forms.TextBox();
                        this.EtiquetaImportePresentados = new Lui.Forms.TextBox();
                        this.frame1 = new Lui.Forms.Frame();
                        this.EtiquetaCantidadSinPresentar = new Lui.Forms.TextBox();
                        this.frame2 = new Lui.Forms.Frame();
                        this.EtiquetaCantidadPresentados = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.frame3 = new Lui.Forms.Frame();
                        this.EtiquetaCantidadAcreditados = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.LowerPanel.SuspendLayout();
                        this.frame1.SuspendLayout();
                        this.frame2.SuspendLayout();
                        this.frame3.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.cmdAnular);
                        this.LowerPanel.Controls.Add(this.cmdAcreditar);
                        this.LowerPanel.Controls.Add(this.cmdPresentar);
                        this.LowerPanel.Controls.Add(this.FilterButton);
                        this.LowerPanel.Controls.Add(this.PrintButton);
                        this.LowerPanel.Controls.Add(this.cmdMostrar);
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 417);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(692, 56);
                        this.LowerPanel.TabIndex = 50;
                        // 
                        // cmdAnular
                        // 
                        this.cmdAnular.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdAnular.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdAnular.Image = null;
                        this.cmdAnular.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdAnular.Location = new System.Drawing.Point(304, 8);
                        this.cmdAnular.Name = "cmdAnular";
                        this.cmdAnular.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdAnular.ReadOnly = false;
                        this.cmdAnular.Size = new System.Drawing.Size(100, 44);
                        this.cmdAnular.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdAnular.Subtext = "F6";
                        this.cmdAnular.TabIndex = 7;
                        this.cmdAnular.Text = "Anular";
                        this.cmdAnular.ToolTipText = "";
                        this.cmdAnular.Click += new System.EventHandler(this.cmdAnular_Click);
                        // 
                        // cmdAcreditar
                        // 
                        this.cmdAcreditar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdAcreditar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdAcreditar.Image = null;
                        this.cmdAcreditar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdAcreditar.Location = new System.Drawing.Point(200, 8);
                        this.cmdAcreditar.Name = "cmdAcreditar";
                        this.cmdAcreditar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdAcreditar.ReadOnly = false;
                        this.cmdAcreditar.Size = new System.Drawing.Size(100, 44);
                        this.cmdAcreditar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdAcreditar.Subtext = "F4";
                        this.cmdAcreditar.TabIndex = 6;
                        this.cmdAcreditar.Text = "Acreditación";
                        this.cmdAcreditar.ToolTipText = "";
                        this.cmdAcreditar.Visible = false;
                        this.cmdAcreditar.Click += new System.EventHandler(this.BotonAcreditar_Click);
                        // 
                        // cmdPresentar
                        // 
                        this.cmdPresentar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdPresentar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdPresentar.Image = null;
                        this.cmdPresentar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdPresentar.Location = new System.Drawing.Point(96, 8);
                        this.cmdPresentar.Name = "cmdPresentar";
                        this.cmdPresentar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdPresentar.ReadOnly = false;
                        this.cmdPresentar.Size = new System.Drawing.Size(100, 44);
                        this.cmdPresentar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdPresentar.Subtext = "F3";
                        this.cmdPresentar.TabIndex = 5;
                        this.cmdPresentar.Text = "Presentación";
                        this.cmdPresentar.ToolTipText = "";
                        this.cmdPresentar.Visible = false;
                        this.cmdPresentar.Click += new System.EventHandler(this.BotonPresentar_Click);
                        // 
                        // FilterButton
                        // 
                        this.FilterButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FilterButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FilterButton.Image = null;
                        this.FilterButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.FilterButton.Location = new System.Drawing.Point(8, 8);
                        this.FilterButton.Name = "FilterButton";
                        this.FilterButton.Padding = new System.Windows.Forms.Padding(2);
                        this.FilterButton.ReadOnly = false;
                        this.FilterButton.Size = new System.Drawing.Size(84, 44);
                        this.FilterButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.FilterButton.Subtext = "F2";
                        this.FilterButton.TabIndex = 4;
                        this.FilterButton.Text = "Filtros";
                        this.FilterButton.ToolTipText = "";
                        this.FilterButton.Click += new System.EventHandler(this.cmdFiltros_Click);
                        // 
                        // PrintButton
                        // 
                        this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.PrintButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PrintButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.PrintButton.Image = null;
                        this.PrintButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.PrintButton.Location = new System.Drawing.Point(428, 8);
                        this.PrintButton.Name = "PrintButton";
                        this.PrintButton.Padding = new System.Windows.Forms.Padding(2);
                        this.PrintButton.ReadOnly = false;
                        this.PrintButton.Size = new System.Drawing.Size(84, 44);
                        this.PrintButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.PrintButton.Subtext = "F8";
                        this.PrintButton.TabIndex = 0;
                        this.PrintButton.Text = "Imprimir";
                        this.PrintButton.ToolTipText = "";
                        this.PrintButton.Click += new System.EventHandler(this.cmdImprimir_Click);
                        // 
                        // cmdMostrar
                        // 
                        this.cmdMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdMostrar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdMostrar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdMostrar.Image = null;
                        this.cmdMostrar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdMostrar.Location = new System.Drawing.Point(516, 8);
                        this.cmdMostrar.Name = "cmdMostrar";
                        this.cmdMostrar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdMostrar.ReadOnly = false;
                        this.cmdMostrar.Size = new System.Drawing.Size(84, 44);
                        this.cmdMostrar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdMostrar.Subtext = "F9";
                        this.cmdMostrar.TabIndex = 1;
                        this.cmdMostrar.Text = "Mostrar";
                        this.cmdMostrar.ToolTipText = "";
                        this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(604, 8);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(84, 44);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.CancelCommandButton.Subtext = "Esc";
                        this.CancelCommandButton.TabIndex = 2;
                        this.CancelCommandButton.Text = "Volver";
                        this.CancelCommandButton.ToolTipText = "";
                        this.CancelCommandButton.Click += new System.EventHandler(this.cmdCancelar_Click);
                        // 
                        // ItemList
                        // 
                        this.ItemList.AllowColumnReorder = true;
                        this.ItemList.AllowDrop = true;
                        this.ItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ItemList.CheckBoxes = true;
                        this.ItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChId,
            this.ChFecha,
            this.ChConcepto,
            this.ChTarjeta,
            this.ChCupon,
            this.ChImporte,
            this.ChEstado,
            this.ChPlan});
                        this.ItemList.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ItemList.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.ItemList.FullRowSelect = true;
                        this.ItemList.GridLines = true;
                        this.ItemList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ItemList.Location = new System.Drawing.Point(216, 4);
                        this.ItemList.MultiSelect = false;
                        this.ItemList.Name = "ItemList";
                        this.ItemList.Size = new System.Drawing.Size(472, 408);
                        this.ItemList.TabIndex = 0;
                        this.ItemList.UseCompatibleStateImageBehavior = false;
                        this.ItemList.View = System.Windows.Forms.View.Details;
                        this.ItemList.DoubleClick += new System.EventHandler(this.lvItems_DoubleClick);
                        this.ItemList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvItems_KeyPress);
                        // 
                        // ChId
                        // 
                        this.ChId.Text = "";
                        this.ChId.Width = 20;
                        // 
                        // ChFecha
                        // 
                        this.ChFecha.Text = "Fecha";
                        this.ChFecha.Width = 86;
                        // 
                        // ChConcepto
                        // 
                        this.ChConcepto.Text = "Concepto";
                        this.ChConcepto.Width = 320;
                        // 
                        // ChTarjeta
                        // 
                        this.ChTarjeta.Text = "Tarjeta";
                        this.ChTarjeta.Width = 100;
                        // 
                        // ChCupon
                        // 
                        this.ChCupon.Text = "Cupón";
                        this.ChCupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ChCupon.Width = 80;
                        // 
                        // ChImporte
                        // 
                        this.ChImporte.Text = "Importe";
                        this.ChImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ChImporte.Width = 80;
                        // 
                        // ChEstado
                        // 
                        this.ChEstado.Text = "Estado";
                        this.ChEstado.Width = 96;
                        // 
                        // ChPlan
                        // 
                        this.ChPlan.Text = "Plan";
                        this.ChPlan.Width = 96;
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(8, 8);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(200, 44);
                        this.EtiquetaTitulo.TabIndex = 0;
                        this.EtiquetaTitulo.Text = "Tarjetas";
                        this.EtiquetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(60, 28);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(96, 24);
                        this.Label4.TabIndex = 1;
                        this.Label4.Text = "cupones por";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaImporteSinPresentar
                        // 
                        this.EtiquetaImporteSinPresentar.AccessibleName = "e";
                        this.EtiquetaImporteSinPresentar.AutoNav = true;
                        this.EtiquetaImporteSinPresentar.AutoTab = true;
                        this.EtiquetaImporteSinPresentar.DataType = Lui.Forms.DataTypes.Money;
                        this.EtiquetaImporteSinPresentar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EtiquetaImporteSinPresentar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaImporteSinPresentar.Location = new System.Drawing.Point(88, 56);
                        this.EtiquetaImporteSinPresentar.MaxLenght = 32767;
                        this.EtiquetaImporteSinPresentar.Name = "EtiquetaImporteSinPresentar";
                        this.EtiquetaImporteSinPresentar.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaImporteSinPresentar.Prefijo = "$";
                        this.EtiquetaImporteSinPresentar.ReadOnly = true;
                        this.EtiquetaImporteSinPresentar.Size = new System.Drawing.Size(100, 24);
                        this.EtiquetaImporteSinPresentar.TabIndex = 2;
                        this.EtiquetaImporteSinPresentar.TabStop = false;
                        this.EtiquetaImporteSinPresentar.Text = "0.00";
                        this.EtiquetaImporteSinPresentar.TipWhenBlank = "";
                        this.EtiquetaImporteSinPresentar.ToolTipText = "";
                        // 
                        // EtiquetaImporteAcreditados
                        // 
                        this.EtiquetaImporteAcreditados.AutoNav = true;
                        this.EtiquetaImporteAcreditados.AutoTab = true;
                        this.EtiquetaImporteAcreditados.DataType = Lui.Forms.DataTypes.Money;
                        this.EtiquetaImporteAcreditados.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EtiquetaImporteAcreditados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaImporteAcreditados.Location = new System.Drawing.Point(84, 60);
                        this.EtiquetaImporteAcreditados.MaxLenght = 32767;
                        this.EtiquetaImporteAcreditados.Name = "EtiquetaImporteAcreditados";
                        this.EtiquetaImporteAcreditados.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaImporteAcreditados.Prefijo = "$";
                        this.EtiquetaImporteAcreditados.ReadOnly = true;
                        this.EtiquetaImporteAcreditados.Size = new System.Drawing.Size(100, 24);
                        this.EtiquetaImporteAcreditados.TabIndex = 2;
                        this.EtiquetaImporteAcreditados.TabStop = false;
                        this.EtiquetaImporteAcreditados.Text = "0.00";
                        this.EtiquetaImporteAcreditados.TipWhenBlank = "";
                        this.EtiquetaImporteAcreditados.ToolTipText = "";
                        // 
                        // EtiquetaImportePresentados
                        // 
                        this.EtiquetaImportePresentados.AutoNav = true;
                        this.EtiquetaImportePresentados.AutoTab = true;
                        this.EtiquetaImportePresentados.DataType = Lui.Forms.DataTypes.Money;
                        this.EtiquetaImportePresentados.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EtiquetaImportePresentados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaImportePresentados.Location = new System.Drawing.Point(88, 56);
                        this.EtiquetaImportePresentados.MaxLenght = 32767;
                        this.EtiquetaImportePresentados.Name = "EtiquetaImportePresentados";
                        this.EtiquetaImportePresentados.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaImportePresentados.Prefijo = "$";
                        this.EtiquetaImportePresentados.ReadOnly = true;
                        this.EtiquetaImportePresentados.Size = new System.Drawing.Size(100, 24);
                        this.EtiquetaImportePresentados.TabIndex = 2;
                        this.EtiquetaImportePresentados.TabStop = false;
                        this.EtiquetaImportePresentados.Text = "0.00";
                        this.EtiquetaImportePresentados.TipWhenBlank = "";
                        this.EtiquetaImportePresentados.ToolTipText = "";
                        // 
                        // frame1
                        // 
                        this.frame1.Controls.Add(this.EtiquetaCantidadSinPresentar);
                        this.frame1.Controls.Add(this.Label4);
                        this.frame1.Controls.Add(this.EtiquetaImporteSinPresentar);
                        this.frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame1.Location = new System.Drawing.Point(8, 64);
                        this.frame1.Name = "frame1";
                        this.frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.frame1.ReadOnly = false;
                        this.frame1.Size = new System.Drawing.Size(192, 84);
                        this.frame1.TabIndex = 1;
                        this.frame1.TabStop = false;
                        this.frame1.Text = "Sin Presentar";
                        this.frame1.ToolTipText = "";
                        // 
                        // EtiquetaCantidadSinPresentar
                        // 
                        this.EtiquetaCantidadSinPresentar.AutoNav = true;
                        this.EtiquetaCantidadSinPresentar.AutoTab = true;
                        this.EtiquetaCantidadSinPresentar.DataType = Lui.Forms.DataTypes.Integer;
                        this.EtiquetaCantidadSinPresentar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EtiquetaCantidadSinPresentar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaCantidadSinPresentar.Location = new System.Drawing.Point(8, 28);
                        this.EtiquetaCantidadSinPresentar.MaxLenght = 32767;
                        this.EtiquetaCantidadSinPresentar.Name = "EtiquetaCantidadSinPresentar";
                        this.EtiquetaCantidadSinPresentar.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaCantidadSinPresentar.ReadOnly = true;
                        this.EtiquetaCantidadSinPresentar.Size = new System.Drawing.Size(50, 24);
                        this.EtiquetaCantidadSinPresentar.TabIndex = 0;
                        this.EtiquetaCantidadSinPresentar.TabStop = false;
                        this.EtiquetaCantidadSinPresentar.Text = "0";
                        this.EtiquetaCantidadSinPresentar.TipWhenBlank = "";
                        this.EtiquetaCantidadSinPresentar.ToolTipText = "";
                        // 
                        // frame2
                        // 
                        this.frame2.Controls.Add(this.EtiquetaCantidadPresentados);
                        this.frame2.Controls.Add(this.label1);
                        this.frame2.Controls.Add(this.EtiquetaImportePresentados);
                        this.frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame2.Location = new System.Drawing.Point(8, 156);
                        this.frame2.Name = "frame2";
                        this.frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.frame2.ReadOnly = false;
                        this.frame2.Size = new System.Drawing.Size(192, 88);
                        this.frame2.TabIndex = 2;
                        this.frame2.TabStop = false;
                        this.frame2.Text = "Presentados";
                        this.frame2.ToolTipText = "";
                        // 
                        // EtiquetaCantidadPresentados
                        // 
                        this.EtiquetaCantidadPresentados.AutoNav = true;
                        this.EtiquetaCantidadPresentados.AutoTab = true;
                        this.EtiquetaCantidadPresentados.DataType = Lui.Forms.DataTypes.Integer;
                        this.EtiquetaCantidadPresentados.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EtiquetaCantidadPresentados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaCantidadPresentados.Location = new System.Drawing.Point(8, 28);
                        this.EtiquetaCantidadPresentados.MaxLenght = 32767;
                        this.EtiquetaCantidadPresentados.Name = "EtiquetaCantidadPresentados";
                        this.EtiquetaCantidadPresentados.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaCantidadPresentados.ReadOnly = true;
                        this.EtiquetaCantidadPresentados.Size = new System.Drawing.Size(50, 24);
                        this.EtiquetaCantidadPresentados.TabIndex = 0;
                        this.EtiquetaCantidadPresentados.TabStop = false;
                        this.EtiquetaCantidadPresentados.Text = "0";
                        this.EtiquetaCantidadPresentados.TipWhenBlank = "";
                        this.EtiquetaCantidadPresentados.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(60, 28);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(96, 24);
                        this.label1.TabIndex = 1;
                        this.label1.Text = "cupones por";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // frame3
                        // 
                        this.frame3.Controls.Add(this.EtiquetaCantidadAcreditados);
                        this.frame3.Controls.Add(this.label2);
                        this.frame3.Controls.Add(this.EtiquetaImporteAcreditados);
                        this.frame3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame3.Location = new System.Drawing.Point(8, 252);
                        this.frame3.Name = "frame3";
                        this.frame3.Padding = new System.Windows.Forms.Padding(2);
                        this.frame3.ReadOnly = false;
                        this.frame3.Size = new System.Drawing.Size(192, 92);
                        this.frame3.TabIndex = 3;
                        this.frame3.TabStop = false;
                        this.frame3.Text = "Acreditados";
                        this.frame3.ToolTipText = "";
                        // 
                        // EtiquetaCantidadAcreditados
                        // 
                        this.EtiquetaCantidadAcreditados.AutoNav = true;
                        this.EtiquetaCantidadAcreditados.AutoTab = true;
                        this.EtiquetaCantidadAcreditados.DataType = Lui.Forms.DataTypes.Integer;
                        this.EtiquetaCantidadAcreditados.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EtiquetaCantidadAcreditados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaCantidadAcreditados.Location = new System.Drawing.Point(8, 28);
                        this.EtiquetaCantidadAcreditados.MaxLenght = 32767;
                        this.EtiquetaCantidadAcreditados.Name = "EtiquetaCantidadAcreditados";
                        this.EtiquetaCantidadAcreditados.Padding = new System.Windows.Forms.Padding(2);
                        this.EtiquetaCantidadAcreditados.ReadOnly = true;
                        this.EtiquetaCantidadAcreditados.Size = new System.Drawing.Size(50, 24);
                        this.EtiquetaCantidadAcreditados.TabIndex = 0;
                        this.EtiquetaCantidadAcreditados.TabStop = false;
                        this.EtiquetaCantidadAcreditados.Text = "0";
                        this.EtiquetaCantidadAcreditados.TipWhenBlank = "";
                        this.EtiquetaCantidadAcreditados.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(60, 28);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(96, 24);
                        this.label2.TabIndex = 1;
                        this.label2.Text = "cupones por";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.frame3);
                        this.Controls.Add(this.frame2);
                        this.Controls.Add(this.frame1);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Controls.Add(this.ItemList);
                        this.Controls.Add(this.LowerPanel);
                        this.KeyPreview = true;
                        this.Name = "Inicio";
                        this.Text = "Tarjetas de Crédito y Débito";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inicio_KeyDown);
                        this.LowerPanel.ResumeLayout(false);
                        this.frame1.ResumeLayout(false);
                        this.frame1.PerformLayout();
                        this.frame2.ResumeLayout(false);
                        this.frame2.PerformLayout();
                        this.frame3.ResumeLayout(false);
                        this.frame3.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                internal System.Windows.Forms.Panel LowerPanel;
                internal Lui.Forms.Button FilterButton;
                internal Lui.Forms.Button PrintButton;
                internal Lui.Forms.Button cmdMostrar;
                internal Lui.Forms.Button CancelCommandButton;
                internal Lui.Forms.ListView ItemList;
                internal System.Windows.Forms.Label EtiquetaTitulo;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.TextBox EtiquetaImporteSinPresentar;
                internal Lui.Forms.TextBox EtiquetaImporteAcreditados;
                internal Lui.Forms.TextBox EtiquetaImportePresentados;
                internal System.Windows.Forms.ColumnHeader ChId;
                internal System.Windows.Forms.ColumnHeader ChFecha;
                internal System.Windows.Forms.ColumnHeader ChTarjeta;
                internal System.Windows.Forms.ColumnHeader ChCupon;
                internal System.Windows.Forms.ColumnHeader ChImporte;
                internal System.Windows.Forms.ColumnHeader ChEstado;
                internal System.Windows.Forms.ColumnHeader ChPlan;
                internal System.Windows.Forms.ColumnHeader ChConcepto;
                internal Lui.Forms.Button cmdAcreditar;
                internal Lui.Forms.Button cmdPresentar;
                internal Lui.Forms.Button cmdAnular;
                private Lui.Forms.Frame frame1;
                internal Lui.Forms.TextBox EtiquetaCantidadSinPresentar;
                private Lui.Forms.Frame frame2;
                internal Lui.Forms.TextBox EtiquetaCantidadPresentados;
                internal System.Windows.Forms.Label label1;
                private Lui.Forms.Frame frame3;
                internal Lui.Forms.TextBox EtiquetaCantidadAcreditados;
                internal System.Windows.Forms.Label label2;
        }
}