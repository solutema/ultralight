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

namespace Lfc
{
        partial class FormularioListadoBase
        {
                /// <summary>
                /// Variable del diseñador requerida.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de Windows Forms

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        this.Listado = new Lui.Forms.ListView();
                        this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EtiquetaContador2 = new System.Windows.Forms.Label();
                        this.EntradaContador2 = new Lui.Forms.TextBox();
                        this.EtiquetaContador1 = new System.Windows.Forms.Label();
                        this.EntradaContador1 = new Lui.Forms.TextBox();
                        this.EtiquetaCantidad = new System.Windows.Forms.Label();
                        this.BotonImprimir = new Lui.Forms.Button();
                        this.BotonFiltrar = new Lui.Forms.Button();
                        this.BotonCancelar = new Lui.Forms.Button();
                        this.PanelContadores = new System.Windows.Forms.Panel();
                        this.EntradaContador4 = new Lui.Forms.TextBox();
                        this.EtiquetaContador4 = new System.Windows.Forms.Label();
                        this.EntradaContador3 = new Lui.Forms.TextBox();
                        this.EtiquetaContador3 = new System.Windows.Forms.Label();
                        this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
                        this.PanelContadores.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Listado
                        // 
                        this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Listado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nombre,
            this.extra1,
            this.extra2,
            this.extra3,
            this.extra4,
            this.extra5,
            this.extra6,
            this.extra7,
            this.extra8,
            this.extra9,
            this.extra10,
            this.extra11});
                        this.Listado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Listado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Listado.FullRowSelect = true;
                        this.Listado.GridLines = true;
                        this.Listado.Location = new System.Drawing.Point(228, 0);
                        this.Listado.MultiSelect = false;
                        this.Listado.Name = "Listado";
                        this.Listado.Size = new System.Drawing.Size(564, 472);
                        this.Listado.TabIndex = 3;
                        this.Listado.UseCompatibleStateImageBehavior = false;
                        this.Listado.View = System.Windows.Forms.View.Details;
                        this.Listado.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Listado_ColumnClick);
                        this.Listado.DoubleClick += new System.EventHandler(this.Listado_DoubleClick);
                        this.Listado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Listado_KeyDown);
                        // 
                        // id
                        // 
                        this.id.Text = "Cód";
                        this.id.Width = 64;
                        // 
                        // nombre
                        // 
                        this.nombre.Text = "Nombre";
                        this.nombre.Width = 220;
                        // 
                        // extra1
                        // 
                        this.extra1.Text = "";
                        this.extra1.Width = 160;
                        // 
                        // extra2
                        // 
                        this.extra2.Text = "";
                        this.extra2.Width = 160;
                        // 
                        // extra3
                        // 
                        this.extra3.Text = "";
                        // 
                        // extra4
                        // 
                        this.extra4.Text = "";
                        // 
                        // extra5
                        // 
                        this.extra5.Text = "";
                        // 
                        // extra6
                        // 
                        this.extra6.Text = "";
                        // 
                        // extra7
                        // 
                        this.extra7.Text = "";
                        // 
                        // extra8
                        // 
                        this.extra8.Text = "";
                        // 
                        // extra9
                        // 
                        this.extra9.Text = "";
                        // 
                        // extra10
                        // 
                        this.extra10.Text = "";
                        // 
                        // extra11
                        // 
                        this.extra11.Text = "";
                        // 
                        // EtiquetaContador2
                        // 
                        this.EtiquetaContador2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaContador2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaContador2.Location = new System.Drawing.Point(0, 28);
                        this.EtiquetaContador2.Name = "EtiquetaContador2";
                        this.EtiquetaContador2.Size = new System.Drawing.Size(100, 24);
                        this.EtiquetaContador2.TabIndex = 63;
                        this.EtiquetaContador2.Text = "Contador2";
                        this.EtiquetaContador2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaContador2.UseMnemonic = false;
                        this.EtiquetaContador2.Visible = false;
                        // 
                        // EntradaContador2
                        // 
                        this.EntradaContador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContador2.AutoNav = true;
                        this.EntradaContador2.AutoTab = true;
                        this.EntradaContador2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContador2.DecimalPlaces = -1;
                        this.EntradaContador2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaContador2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContador2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaContador2.Location = new System.Drawing.Point(100, 28);
                        this.EntradaContador2.MaxLenght = 32767;
                        this.EntradaContador2.MultiLine = false;
                        this.EntradaContador2.Name = "EntradaContador2";
                        this.EntradaContador2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContador2.PasswordChar = '\0';
                        this.EntradaContador2.Prefijo = "";
                        this.EntradaContador2.SelectOnFocus = true;
                        this.EntradaContador2.Size = new System.Drawing.Size(108, 24);
                        this.EntradaContador2.Sufijo = "";
                        this.EntradaContador2.TabIndex = 62;
                        this.EntradaContador2.TabStop = false;
                        this.EntradaContador2.TipWhenBlank = "";
                        this.EntradaContador2.ToolTipText = "";
                        this.EntradaContador2.Visible = false;
                        // 
                        // EtiquetaContador1
                        // 
                        this.EtiquetaContador1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaContador1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaContador1.Location = new System.Drawing.Point(0, 0);
                        this.EtiquetaContador1.Name = "EtiquetaContador1";
                        this.EtiquetaContador1.Size = new System.Drawing.Size(100, 24);
                        this.EtiquetaContador1.TabIndex = 61;
                        this.EtiquetaContador1.Text = "Contador 1";
                        this.EtiquetaContador1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaContador1.UseMnemonic = false;
                        this.EtiquetaContador1.Visible = false;
                        // 
                        // EntradaContador1
                        // 
                        this.EntradaContador1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContador1.AutoNav = true;
                        this.EntradaContador1.AutoTab = true;
                        this.EntradaContador1.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContador1.DecimalPlaces = -1;
                        this.EntradaContador1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaContador1.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContador1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaContador1.Location = new System.Drawing.Point(100, 0);
                        this.EntradaContador1.MaxLenght = 32767;
                        this.EntradaContador1.MultiLine = false;
                        this.EntradaContador1.Name = "EntradaContador1";
                        this.EntradaContador1.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContador1.PasswordChar = '\0';
                        this.EntradaContador1.Prefijo = "";
                        this.EntradaContador1.SelectOnFocus = true;
                        this.EntradaContador1.Size = new System.Drawing.Size(108, 24);
                        this.EntradaContador1.Sufijo = "";
                        this.EntradaContador1.TabIndex = 60;
                        this.EntradaContador1.TabStop = false;
                        this.EntradaContador1.TipWhenBlank = "";
                        this.EntradaContador1.ToolTipText = "";
                        this.EntradaContador1.Visible = false;
                        // 
                        // EtiquetaCantidad
                        // 
                        this.EtiquetaCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaCantidad.Location = new System.Drawing.Point(8, 204);
                        this.EtiquetaCantidad.Name = "EtiquetaCantidad";
                        this.EtiquetaCantidad.Size = new System.Drawing.Size(208, 20);
                        this.EtiquetaCantidad.TabIndex = 59;
                        this.EtiquetaCantidad.Text = "Cargando...";
                        this.EtiquetaCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // BotonImprimir
                        // 
                        this.BotonImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonImprimir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonImprimir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonImprimir.Image = null;
                        this.BotonImprimir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonImprimir.Location = new System.Drawing.Point(12, 432);
                        this.BotonImprimir.Name = "BotonImprimir";
                        this.BotonImprimir.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonImprimir.Size = new System.Drawing.Size(96, 29);
                        this.BotonImprimir.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonImprimir.Subtext = "F8";
                        this.BotonImprimir.TabIndex = 65;
                        this.BotonImprimir.Text = "Listado";
                        this.BotonImprimir.ToolTipText = "";
                        this.BotonImprimir.Click += new System.EventHandler(this.BotonImprimir_Click);
                        // 
                        // BotonFiltrar
                        // 
                        this.BotonFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonFiltrar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonFiltrar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonFiltrar.Image = null;
                        this.BotonFiltrar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonFiltrar.Location = new System.Drawing.Point(12, 236);
                        this.BotonFiltrar.Name = "BotonFiltrar";
                        this.BotonFiltrar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonFiltrar.Size = new System.Drawing.Size(96, 29);
                        this.BotonFiltrar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonFiltrar.Subtext = "F2";
                        this.BotonFiltrar.TabIndex = 64;
                        this.BotonFiltrar.Text = "Filtrar";
                        this.BotonFiltrar.ToolTipText = "";
                        this.BotonFiltrar.Visible = false;
                        this.BotonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
                        // 
                        // BotonCancelar
                        // 
                        this.BotonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCancelar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCancelar.Image = null;
                        this.BotonCancelar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCancelar.Location = new System.Drawing.Point(120, 432);
                        this.BotonCancelar.Name = "BotonCancelar";
                        this.BotonCancelar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCancelar.Size = new System.Drawing.Size(96, 29);
                        this.BotonCancelar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonCancelar.Subtext = "Esc";
                        this.BotonCancelar.TabIndex = 66;
                        this.BotonCancelar.Text = "Volver";
                        this.BotonCancelar.ToolTipText = "";
                        this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // PanelContadores
                        // 
                        this.PanelContadores.Controls.Add(this.EntradaContador4);
                        this.PanelContadores.Controls.Add(this.EtiquetaContador4);
                        this.PanelContadores.Controls.Add(this.EntradaContador3);
                        this.PanelContadores.Controls.Add(this.EtiquetaContador3);
                        this.PanelContadores.Controls.Add(this.EntradaContador1);
                        this.PanelContadores.Controls.Add(this.EntradaContador2);
                        this.PanelContadores.Controls.Add(this.EtiquetaContador1);
                        this.PanelContadores.Controls.Add(this.EtiquetaContador2);
                        this.PanelContadores.Location = new System.Drawing.Point(8, 88);
                        this.PanelContadores.Name = "PanelContadores";
                        this.PanelContadores.Size = new System.Drawing.Size(208, 108);
                        this.PanelContadores.TabIndex = 67;
                        this.PanelContadores.Visible = false;
                        // 
                        // EntradaContador4
                        // 
                        this.EntradaContador4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContador4.AutoNav = true;
                        this.EntradaContador4.AutoTab = true;
                        this.EntradaContador4.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContador4.DecimalPlaces = -1;
                        this.EntradaContador4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaContador4.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContador4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaContador4.Location = new System.Drawing.Point(100, 84);
                        this.EntradaContador4.MaxLenght = 32767;
                        this.EntradaContador4.MultiLine = false;
                        this.EntradaContador4.Name = "EntradaContador4";
                        this.EntradaContador4.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContador4.PasswordChar = '\0';
                        this.EntradaContador4.Prefijo = "";
                        this.EntradaContador4.SelectOnFocus = true;
                        this.EntradaContador4.Size = new System.Drawing.Size(108, 24);
                        this.EntradaContador4.Sufijo = "";
                        this.EntradaContador4.TabIndex = 66;
                        this.EntradaContador4.TabStop = false;
                        this.EntradaContador4.TipWhenBlank = "";
                        this.EntradaContador4.ToolTipText = "";
                        this.EntradaContador4.Visible = false;
                        // 
                        // EtiquetaContador4
                        // 
                        this.EtiquetaContador4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaContador4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaContador4.Location = new System.Drawing.Point(0, 84);
                        this.EtiquetaContador4.Name = "EtiquetaContador4";
                        this.EtiquetaContador4.Size = new System.Drawing.Size(100, 24);
                        this.EtiquetaContador4.TabIndex = 67;
                        this.EtiquetaContador4.Text = "Contador2";
                        this.EtiquetaContador4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaContador4.UseMnemonic = false;
                        this.EtiquetaContador4.Visible = false;
                        // 
                        // EntradaContador3
                        // 
                        this.EntradaContador3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContador3.AutoNav = true;
                        this.EntradaContador3.AutoTab = true;
                        this.EntradaContador3.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContador3.DecimalPlaces = -1;
                        this.EntradaContador3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaContador3.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContador3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaContador3.Location = new System.Drawing.Point(100, 56);
                        this.EntradaContador3.MaxLenght = 32767;
                        this.EntradaContador3.MultiLine = false;
                        this.EntradaContador3.Name = "EntradaContador3";
                        this.EntradaContador3.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContador3.PasswordChar = '\0';
                        this.EntradaContador3.Prefijo = "";
                        this.EntradaContador3.SelectOnFocus = true;
                        this.EntradaContador3.Size = new System.Drawing.Size(108, 24);
                        this.EntradaContador3.Sufijo = "";
                        this.EntradaContador3.TabIndex = 64;
                        this.EntradaContador3.TabStop = false;
                        this.EntradaContador3.TipWhenBlank = "";
                        this.EntradaContador3.ToolTipText = "";
                        this.EntradaContador3.Visible = false;
                        // 
                        // EtiquetaContador3
                        // 
                        this.EtiquetaContador3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaContador3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaContador3.Location = new System.Drawing.Point(0, 56);
                        this.EtiquetaContador3.Name = "EtiquetaContador3";
                        this.EtiquetaContador3.Size = new System.Drawing.Size(100, 24);
                        this.EtiquetaContador3.TabIndex = 65;
                        this.EtiquetaContador3.Text = "Contador2";
                        this.EtiquetaContador3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaContador3.UseMnemonic = false;
                        this.EtiquetaContador3.Visible = false;
                        // 
                        // RefreshTimer
                        // 
                        this.RefreshTimer.Interval = 50;
                        this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
                        // 
                        // FormularioListadoBase
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.AutoSize = true;
                        this.ClientSize = new System.Drawing.Size(792, 472);
                        this.Controls.Add(this.PanelContadores);
                        this.Controls.Add(this.BotonImprimir);
                        this.Controls.Add(this.BotonFiltrar);
                        this.Controls.Add(this.BotonCancelar);
                        this.Controls.Add(this.Listado);
                        this.Controls.Add(this.EtiquetaCantidad);
                        this.Name = "FormularioListadoBase";
                        this.Text = "FormularioListadoBase";
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioListadoBase_FormClosing);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormularioListadoBase_KeyDown);
                        this.PanelContadores.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                public Lui.Forms.ListView Listado;
                protected System.Windows.Forms.ColumnHeader id;
                protected System.Windows.Forms.ColumnHeader nombre;
                protected System.Windows.Forms.ColumnHeader extra1;
                protected System.Windows.Forms.ColumnHeader extra2;
                protected System.Windows.Forms.ColumnHeader extra3;
                protected System.Windows.Forms.ColumnHeader extra4;
                protected System.Windows.Forms.ColumnHeader extra5;
                protected System.Windows.Forms.ColumnHeader extra6;
                protected System.Windows.Forms.ColumnHeader extra7;
                protected System.Windows.Forms.ColumnHeader extra8;
                protected System.Windows.Forms.ColumnHeader extra9;
                protected System.Windows.Forms.ColumnHeader extra10;
                protected System.Windows.Forms.ColumnHeader extra11;
                protected System.Windows.Forms.Label EtiquetaContador2;
                protected Lui.Forms.TextBox EntradaContador2;
                protected System.Windows.Forms.Label EtiquetaContador1;
                protected Lui.Forms.TextBox EntradaContador1;
                protected System.Windows.Forms.Label EtiquetaCantidad;
                protected Lui.Forms.Button BotonImprimir;
                protected Lui.Forms.Button BotonFiltrar;
                protected Lui.Forms.Button BotonCancelar;
                private System.Windows.Forms.Panel PanelContadores;
                protected Lui.Forms.TextBox EntradaContador4;
                protected System.Windows.Forms.Label EtiquetaContador4;
                protected Lui.Forms.TextBox EntradaContador3;
                protected System.Windows.Forms.Label EtiquetaContador3;
                private System.Windows.Forms.Timer RefreshTimer;
        }
}