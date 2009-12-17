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

namespace Lfc.Comprobantes.Ticker
{
        public class TickerPresupuestos : System.Windows.Forms.Form
        {

                private Modos m_Modo = Modos.Inicio;

                public enum Modos
                {
                        Inicio = 0,
                        Articulo = 1,
                        Articulos2 = 2,
                        Articulos4 = 4,
                        Presupuesto = 99,
                }

                public Size ImagenTamano = new Size(100, 72);
                public Size ImagenSeparacion = new Size(16, 16);
                public int ImagenNombreAlto = 36, NumeroItem;
                private System.Data.DataTable TablaArticulos = null;
                private System.Windows.Forms.PictureBox pictureBox1;
                private System.Windows.Forms.Label label5;
                internal System.Windows.Forms.Label label6;
                private System.Windows.Forms.Label lblRestore;
                internal Panel pnlPresupuestoArticulos;
                public Lws.Workspace Workspace = null;

                #region Código generado por el Diseñador de Windows Forms

                public TickerPresupuestos()
                        : base()
                {
                        InitializeComponent();
                }

                // Limpiar los recursos que se están utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                private System.ComponentModel.IContainer components;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label lblArticuloNombre;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Panel pnlArticulo;
                internal System.Windows.Forms.PictureBox pctArticuloImagen;
                internal System.Windows.Forms.Label lblArticuloDescripcion;
                internal System.Windows.Forms.Panel pnlPresupuesto;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label lblPresupuestoNombre;
                internal System.Windows.Forms.Panel pnlInicio;
                internal System.Windows.Forms.PictureBox pctPubli;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label lblDescuento;
                internal System.Windows.Forms.Label lblSubTotal;
                internal System.Windows.Forms.Label Label8;
                internal System.Windows.Forms.PictureBox pctCaja;
                internal System.Windows.Forms.Timer Timer1;
                internal System.Windows.Forms.Panel Panel1;
                internal System.Windows.Forms.Label lblTotal;

                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TickerPresupuestos));
                        this.pnlArticulo = new System.Windows.Forms.Panel();
                        this.label6 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.lblArticuloDescripcion = new System.Windows.Forms.Label();
                        this.lblArticuloNombre = new System.Windows.Forms.Label();
                        this.pctArticuloImagen = new System.Windows.Forms.PictureBox();
                        this.pnlPresupuesto = new System.Windows.Forms.Panel();
                        this.label5 = new System.Windows.Forms.Label();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.lblDescuento = new System.Windows.Forms.Label();
                        this.lblSubTotal = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.lblPresupuestoNombre = new System.Windows.Forms.Label();
                        this.Panel1 = new System.Windows.Forms.Panel();
                        this.lblTotal = new System.Windows.Forms.Label();
                        this.pictureBox1 = new System.Windows.Forms.PictureBox();
                        this.pnlInicio = new System.Windows.Forms.Panel();
                        this.pctCaja = new System.Windows.Forms.PictureBox();
                        this.pctPubli = new System.Windows.Forms.PictureBox();
                        this.Timer1 = new System.Windows.Forms.Timer(this.components);
                        this.lblRestore = new System.Windows.Forms.Label();
                        this.pnlPresupuestoArticulos = new System.Windows.Forms.Panel();
                        this.pnlArticulo.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.pctArticuloImagen)).BeginInit();
                        this.pnlPresupuesto.SuspendLayout();
                        this.Panel1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                        this.pnlInicio.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.pctCaja)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.pctPubli)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // pnlArticulo
                        // 
                        this.pnlArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.pnlArticulo.Controls.Add(this.label6);
                        this.pnlArticulo.Controls.Add(this.Label3);
                        this.pnlArticulo.Controls.Add(this.lblArticuloDescripcion);
                        this.pnlArticulo.Controls.Add(this.lblArticuloNombre);
                        this.pnlArticulo.Controls.Add(this.pctArticuloImagen);
                        this.pnlArticulo.Location = new System.Drawing.Point(0, 0);
                        this.pnlArticulo.Name = "pnlArticulo";
                        this.pnlArticulo.Size = new System.Drawing.Size(652, 444);
                        this.pnlArticulo.TabIndex = 1;
                        this.pnlArticulo.Visible = false;
                        // 
                        // label6
                        // 
                        this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label6.BackColor = System.Drawing.Color.Brown;
                        this.label6.Location = new System.Drawing.Point(52, 360);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(1, 84);
                        this.label6.TabIndex = 6;
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label3.BackColor = System.Drawing.Color.Brown;
                        this.Label3.Location = new System.Drawing.Point(0, 52);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(652, 3);
                        this.Label3.TabIndex = 5;
                        // 
                        // lblArticuloDescripcion
                        // 
                        this.lblArticuloDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblArticuloDescripcion.Font = new System.Drawing.Font("Bitstream Vera Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblArticuloDescripcion.ForeColor = System.Drawing.Color.Black;
                        this.lblArticuloDescripcion.Location = new System.Drawing.Point(60, 372);
                        this.lblArticuloDescripcion.Name = "lblArticuloDescripcion";
                        this.lblArticuloDescripcion.Size = new System.Drawing.Size(584, 68);
                        this.lblArticuloDescripcion.TabIndex = 3;
                        this.lblArticuloDescripcion.Text = "Video GeForce 4 MX 128 MB con salida de TV. Slot AGP 8X libre. Sonido. Red 10/100" +
                            ". 2 slots DDR dual-channel, 3 PCI, 6 USB 2.0, FSB 400, Socket A/462. Chipset nVi" +
                            "dia nForce2 IGP.";
                        // 
                        // lblArticuloNombre
                        // 
                        this.lblArticuloNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblArticuloNombre.BackColor = System.Drawing.Color.PapayaWhip;
                        this.lblArticuloNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblArticuloNombre.ForeColor = System.Drawing.Color.SaddleBrown;
                        this.lblArticuloNombre.Location = new System.Drawing.Point(0, 0);
                        this.lblArticuloNombre.Name = "lblArticuloNombre";
                        this.lblArticuloNombre.Size = new System.Drawing.Size(652, 52);
                        this.lblArticuloNombre.TabIndex = 2;
                        this.lblArticuloNombre.Text = "Placa Madre Asus A7N8X-VM/400 (GeForce 4)";
                        this.lblArticuloNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // pctArticuloImagen
                        // 
                        this.pctArticuloImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.pctArticuloImagen.Image = ((System.Drawing.Image)(resources.GetObject("pctArticuloImagen.Image")));
                        this.pctArticuloImagen.Location = new System.Drawing.Point(112, 72);
                        this.pctArticuloImagen.Name = "pctArticuloImagen";
                        this.pctArticuloImagen.Size = new System.Drawing.Size(416, 284);
                        this.pctArticuloImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.pctArticuloImagen.TabIndex = 1;
                        this.pctArticuloImagen.TabStop = false;
                        // 
                        // pnlPresupuesto
                        // 
                        this.pnlPresupuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.pnlPresupuesto.BackColor = System.Drawing.Color.White;
                        this.pnlPresupuesto.Controls.Add(this.label5);
                        this.pnlPresupuesto.Controls.Add(this.Label8);
                        this.pnlPresupuesto.Controls.Add(this.lblDescuento);
                        this.pnlPresupuesto.Controls.Add(this.lblSubTotal);
                        this.pnlPresupuesto.Controls.Add(this.Label4);
                        this.pnlPresupuesto.Controls.Add(this.Label2);
                        this.pnlPresupuesto.Controls.Add(this.pnlPresupuestoArticulos);
                        this.pnlPresupuesto.Controls.Add(this.Label1);
                        this.pnlPresupuesto.Controls.Add(this.lblPresupuestoNombre);
                        this.pnlPresupuesto.Controls.Add(this.Panel1);
                        this.pnlPresupuesto.Controls.Add(this.pictureBox1);
                        this.pnlPresupuesto.Location = new System.Drawing.Point(0, 0);
                        this.pnlPresupuesto.Name = "pnlPresupuesto";
                        this.pnlPresupuesto.Size = new System.Drawing.Size(652, 448);
                        this.pnlPresupuesto.TabIndex = 2;
                        this.pnlPresupuesto.Visible = false;
                        // 
                        // label5
                        // 
                        this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
                        this.label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label5.Location = new System.Drawing.Point(508, 40);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(136, 19);
                        this.label5.TabIndex = 18;
                        this.label5.Text = "Lázaro versión 1.0";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label8
                        // 
                        this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label8.BackColor = System.Drawing.Color.White;
                        this.Label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label8.Location = new System.Drawing.Point(412, 416);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(56, 24);
                        this.Label8.TabIndex = 14;
                        this.Label8.Text = "Total";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblDescuento
                        // 
                        this.lblDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.lblDescuento.Font = new System.Drawing.Font("Bitstream Vera Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblDescuento.Location = new System.Drawing.Point(100, 416);
                        this.lblDescuento.Name = "lblDescuento";
                        this.lblDescuento.Size = new System.Drawing.Size(104, 20);
                        this.lblDescuento.TabIndex = 13;
                        this.lblDescuento.Text = "0.00";
                        this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblSubTotal
                        // 
                        this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.lblSubTotal.Font = new System.Drawing.Font("Bitstream Vera Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblSubTotal.Location = new System.Drawing.Point(100, 392);
                        this.lblSubTotal.Name = "lblSubTotal";
                        this.lblSubTotal.Size = new System.Drawing.Size(104, 20);
                        this.lblSubTotal.TabIndex = 12;
                        this.lblSubTotal.Text = "0.00";
                        this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label4.Location = new System.Drawing.Point(12, 416);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(88, 20);
                        this.Label4.TabIndex = 11;
                        this.Label4.Text = "Descuento";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label2.Location = new System.Drawing.Point(12, 392);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(88, 20);
                        this.Label2.TabIndex = 10;
                        this.Label2.Text = "Subtotal";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label1.BackColor = System.Drawing.Color.Brown;
                        this.Label1.Location = new System.Drawing.Point(0, 60);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(652, 3);
                        this.Label1.TabIndex = 7;
                        // 
                        // lblPresupuestoNombre
                        // 
                        this.lblPresupuestoNombre.BackColor = System.Drawing.Color.AntiqueWhite;
                        this.lblPresupuestoNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblPresupuestoNombre.ForeColor = System.Drawing.Color.SaddleBrown;
                        this.lblPresupuestoNombre.Location = new System.Drawing.Point(12, 12);
                        this.lblPresupuestoNombre.Name = "lblPresupuestoNombre";
                        this.lblPresupuestoNombre.Size = new System.Drawing.Size(244, 44);
                        this.lblPresupuestoNombre.TabIndex = 6;
                        this.lblPresupuestoNombre.Text = "Presupuesto";
                        this.lblPresupuestoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Panel1
                        // 
                        this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.Panel1.BackColor = System.Drawing.Color.Tan;
                        this.Panel1.Controls.Add(this.lblTotal);
                        this.Panel1.Font = new System.Drawing.Font("Bitstream Vera Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Panel1.Location = new System.Drawing.Point(472, 396);
                        this.Panel1.Name = "Panel1";
                        this.Panel1.Size = new System.Drawing.Size(168, 44);
                        this.Panel1.TabIndex = 16;
                        // 
                        // lblTotal
                        // 
                        this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblTotal.BackColor = System.Drawing.Color.AntiqueWhite;
                        this.lblTotal.Font = new System.Drawing.Font("Bitstream Vera Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblTotal.ForeColor = System.Drawing.Color.SaddleBrown;
                        this.lblTotal.Location = new System.Drawing.Point(0, 0);
                        this.lblTotal.Name = "lblTotal";
                        this.lblTotal.Size = new System.Drawing.Size(166, 42);
                        this.lblTotal.TabIndex = 16;
                        this.lblTotal.Text = "$ 0.00";
                        this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // pictureBox1
                        // 
                        this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.pictureBox1.BackColor = System.Drawing.Color.AntiqueWhite;
                        this.pictureBox1.Location = new System.Drawing.Point(0, 0);
                        this.pictureBox1.Name = "pictureBox1";
                        this.pictureBox1.Size = new System.Drawing.Size(652, 64);
                        this.pictureBox1.TabIndex = 17;
                        this.pictureBox1.TabStop = false;
                        // 
                        // pnlInicio
                        // 
                        this.pnlInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.pnlInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        this.pnlInicio.Controls.Add(this.pctCaja);
                        this.pnlInicio.Controls.Add(this.pctPubli);
                        this.pnlInicio.Location = new System.Drawing.Point(0, 0);
                        this.pnlInicio.Name = "pnlInicio";
                        this.pnlInicio.Size = new System.Drawing.Size(652, 448);
                        this.pnlInicio.TabIndex = 3;
                        // 
                        // pctCaja
                        // 
                        this.pctCaja.Image = ((System.Drawing.Image)(resources.GetObject("pctCaja.Image")));
                        this.pctCaja.Location = new System.Drawing.Point(8, 8);
                        this.pctCaja.Name = "pctCaja";
                        this.pctCaja.Size = new System.Drawing.Size(72, 48);
                        this.pctCaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.pctCaja.TabIndex = 2;
                        this.pctCaja.TabStop = false;
                        this.pctCaja.Visible = false;
                        // 
                        // pctPubli
                        // 
                        this.pctPubli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.pctPubli.Image = ((System.Drawing.Image)(resources.GetObject("pctPubli.Image")));
                        this.pctPubli.Location = new System.Drawing.Point(64, 76);
                        this.pctPubli.Name = "pctPubli";
                        this.pctPubli.Size = new System.Drawing.Size(260, 232);
                        this.pctPubli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.pctPubli.TabIndex = 1;
                        this.pctPubli.TabStop = false;
                        // 
                        // Timer1
                        // 
                        this.Timer1.Enabled = true;
                        this.Timer1.Interval = 30000;
                        this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
                        // 
                        // lblRestore
                        // 
                        this.lblRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblRestore.BackColor = System.Drawing.SystemColors.Control;
                        this.lblRestore.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblRestore.Location = new System.Drawing.Point(636, 4);
                        this.lblRestore.Name = "lblRestore";
                        this.lblRestore.Size = new System.Drawing.Size(12, 8);
                        this.lblRestore.TabIndex = 8;
                        this.lblRestore.Text = "..";
                        this.lblRestore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.lblRestore.Visible = false;
                        this.lblRestore.VisibleChanged += new System.EventHandler(this.lblRestore_VisibleChanged);
                        this.lblRestore.Click += new System.EventHandler(this.lblRestore_Click);
                        // 
                        // pnlPresupuestoArticulos
                        // 
                        this.pnlPresupuestoArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.pnlPresupuestoArticulos.BackColor = System.Drawing.Color.White;
                        this.pnlPresupuestoArticulos.Location = new System.Drawing.Point(8, 68);
                        this.pnlPresupuestoArticulos.Name = "pnlPresupuestoArticulos";
                        this.pnlPresupuestoArticulos.Size = new System.Drawing.Size(636, 324);
                        this.pnlPresupuestoArticulos.TabIndex = 8;
                        // 
                        // TickerMostrador
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.BackColor = System.Drawing.Color.White;
                        this.ClientSize = new System.Drawing.Size(650, 446);
                        this.Controls.Add(this.lblRestore);
                        this.Controls.Add(this.pnlPresupuesto);
                        this.Controls.Add(this.pnlInicio);
                        this.Controls.Add(this.pnlArticulo);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "TickerMostrador";
                        this.ShowInTaskbar = false;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Ticker: Mostrador";
                        this.Load += new System.EventHandler(this.FormTickerMostrador_Load);
                        this.SizeChanged += new System.EventHandler(this.TickerMostrador_SizeChanged);
                        this.Closing += new System.ComponentModel.CancelEventHandler(this.FormTickerMostrador_Closing);
                        this.pnlArticulo.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.pctArticuloImagen)).EndInit();
                        this.pnlPresupuesto.ResumeLayout(false);
                        this.Panel1.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                        this.pnlInicio.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.pctCaja)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.pctPubli)).EndInit();
                        this.ResumeLayout(false);

                }


                #endregion

                public Modos Modo
                {
                        get
                        {
                                return m_Modo;
                        }
                        set
                        {
                                m_Modo = value;
                                pnlArticulo.Visible = m_Modo == Modos.Articulo;
                                pnlPresupuesto.Visible = m_Modo != Modos.Inicio;
                                pnlInicio.Visible = m_Modo == Modos.Inicio;
                        }
                }

                private System.Data.DataRow Articulo(int idArticulo)
                {
                        if (TablaArticulos == null)
                                TablaArticulos = this.Workspace.DefaultDataBase.Select("SELECT id_articulo, id_cat_articulo, nombre, descripcion FROM articulos");

                        if (TablaArticulos != null) {
                                System.Data.DataRow[] Articulos = TablaArticulos.Select("id_articulo=" + idArticulo.ToString());
                                if (Articulos.Length > 0)
                                        return Articulos[0];
                                else
                                        return null;
                        } else {
                                return null;
                        }
                }

                public void MostrarArticulo(int iArticulo)
                {
                        if (iArticulo > 0) {
                                this.Modo = Lfc.Comprobantes.Ticker.TickerPresupuestos.Modos.Articulo;
                                DataRow Articulo = this.Articulo(iArticulo);
                                if (Articulo != null) {
                                        lblArticuloNombre.Text = System.Convert.ToString(Articulo["nombre"]);
                                        lblArticuloDescripcion.Text = System.Convert.ToString(Articulo["descripcion"]);
                                        pctArticuloImagen.Image = Lbl.Articulos.Stock.ProductImage(this.Workspace.DefaultDataView, iArticulo);
                                        if (pctArticuloImagen.Image == null) {
                                                try {
                                                        pctArticuloImagen.Image = pctCaja.Image;
                                                }
                                                catch {
                                                        pctArticuloImagen.Image = null;
                                                }
                                        }
                                }
                        }
                }


                public void MostrarPresupuesto(Comprobantes.Presupuestos.Editar Presupuesto)
                {
                        NumeroItem = 0;

                        if (Presupuesto == null || Presupuesto.ProductArray == null)
                                return;

                        if (Presupuesto.ProductArray.Count == 1) {
                                // Si hay un sólo artículo, lo muestro
                                this.Modo = Modos.Articulo;
                                MostrarArticulo(Presupuesto.ProductArray.ChildControls[0].TextInt);
                                return;
                        } else if (Presupuesto.ProductArray.Count <= 4) {
                                ImagenTamano = new Size(100, 72);
                                this.Modo = Modos.Articulos4;
                        } else if (Presupuesto.ProductArray.Count <= 15) {
                                ImagenTamano = new Size(100, 72);
                                this.Modo = Modos.Presupuesto;
                        } else {
                                ImagenTamano = new Size(80, 60);
                                this.Modo = Modos.Presupuesto;
                        }

                        pnlPresupuestoArticulos.SuspendLayout();
                        pnlPresupuestoArticulos.Controls.Clear();
                        for (int i = 0; i <= Presupuesto.ProductArray.Count - 1; i++) {
                                if (Presupuesto.ProductArray.ChildControls[i].Cantidad == 1 || Presupuesto.ProductArray.ChildControls[i].Cantidad > 3) {
                                        //Es uno solo o más de 3. Muestro 1
                                        AgregarArticulo(Presupuesto.ProductArray.ChildControls[i].TextInt);
                                } else {
                                        //Cantidad de 2 o 3, muestro duplicado o triplicado
                                        for (int c = 0; c < Presupuesto.ProductArray.ChildControls[i].Cantidad; c++) {
                                                AgregarArticulo(Presupuesto.ProductArray.ChildControls[i].TextInt);
                                        }
                                }
                        }
                        MostrarPresupuestoValores(Presupuesto);
                        pnlPresupuestoArticulos.ResumeLayout();
                }


                public void MostrarPresupuestoValores(Comprobantes.Editar Presupuesto)
                {
                        lblSubTotal.Text = Lfx.Types.Currency.CurrencySymbol + " " + Presupuesto.txtSubTotal.Text;
                        if (Lfx.Types.Parsing.ParseDouble(Presupuesto.txtDescuento.Text) > 0)
                                lblDescuento.Text = Presupuesto.txtDescuento.Text + "%";
                        else
                                lblDescuento.Text = "-";
                        lblTotal.Text = Lfx.Types.Currency.CurrencySymbol + " " + Presupuesto.EntradaTotal.Text;
                }


                public void AgregarArticulo(int iArticulo)
                {
                        if (iArticulo > 0) {
                                DataRow Articulo = this.Articulo(iArticulo);
                                PictureBox Imagen = new PictureBox();
                                Label Nombre = new Label();

                                Rectangle TamanoArticulo = PosicionArticulo(System.Convert.ToInt32((pnlPresupuestoArticulos.Controls.Count / 2) + 1), Articulo);
                                Imagen.Location = TamanoArticulo.Location;
                                Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                                Imagen.Image = Lbl.Articulos.Stock.ProductImage(this.Workspace.DefaultDataView, System.Convert.ToInt32(Articulo["id_articulo"]));
                                if (Imagen.Image == null)
                                        Imagen.Image = pctCaja.Image;

                                switch (TamanoArticulo.Height) {
                                        case 1:
                                                Imagen.Size = new System.Drawing.Size(TamanoArticulo.Width, System.Convert.ToInt32(TamanoArticulo.Width * .66));

                                                Nombre.Size = new Size(System.Convert.ToInt32(Imagen.Size.Width + ImagenSeparacion.Width / 2), ImagenNombreAlto);
                                                Nombre.TextAlign = ContentAlignment.TopCenter;
                                                Nombre.Font = new Font("Bitstream Vera Sans", 10);
                                                Nombre.Location = new Point(System.Convert.ToInt32(Imagen.Location.X - ImagenSeparacion.Width / 2), Imagen.Location.Y + Imagen.Height + 4);
                                                break;

                                        case 2:
                                                Imagen.Size = new System.Drawing.Size(TamanoArticulo.Width, System.Convert.ToInt32(TamanoArticulo.Width * .66));

                                                Nombre.Size = new Size(System.Convert.ToInt32(Imagen.Size.Width * 20), Imagen.Size.Height);
                                                Nombre.TextAlign = ContentAlignment.MiddleLeft;
                                                Nombre.Font = new Font("Bitstream Vera Sans", 10);
                                                Nombre.Location = new Point(System.Convert.ToInt32(Imagen.Location.X + Imagen.Size.Width + 4), Imagen.Location.Y);
                                                break;

                                        default:
                                                Imagen.Size = ImagenTamano;
                                                Nombre.Size = new Size(System.Convert.ToInt32(Imagen.Size.Width + ImagenSeparacion.Width / 2), ImagenNombreAlto);
                                                Nombre.TextAlign = ContentAlignment.TopCenter;
                                                Nombre.Font = new Font("Bitstream Vera Sans", 10);
                                                Nombre.Location = new Point(System.Convert.ToInt32(Imagen.Location.X - ImagenSeparacion.Width / 2), Imagen.Location.Y + Imagen.Height + 4);
                                                break;
                                }

                                Nombre.Text = System.Convert.ToString(Articulo["nombre"]);
                                Nombre.Tag = Articulo["id_articulo"];
                                pnlPresupuestoArticulos.Controls.Add(Imagen);
                                pnlPresupuestoArticulos.Controls.Add(Nombre);
                                Imagen.Visible = true;
                                Nombre.Visible = true;
                        }
                }


                private Rectangle PosicionArticulo(int iNumero, System.Data.DataRow Articulo)
                {
                        Rectangle res = new Rectangle();
                        if (m_Modo == Modos.Articulos2 || m_Modo == Modos.Articulos4) {
                                switch (iNumero) {
                                        case 1:
                                                res.X = System.Convert.ToInt32(pnlPresupuestoArticulos.Width * .05);
                                                res.Y = System.Convert.ToInt32(pnlPresupuestoArticulos.Height * .05);
                                                res.Height = 1;
                                                res.Width = System.Convert.ToInt32(pnlPresupuestoArticulos.Width * .3);
                                                break;
                                        case 2:
                                                res.X = System.Convert.ToInt32(pnlPresupuestoArticulos.Width * .05);
                                                res.Y = System.Convert.ToInt32(pnlPresupuestoArticulos.Height * .55);
                                                res.Height = 1;
                                                res.Width = System.Convert.ToInt32(pnlPresupuestoArticulos.Width * .3);
                                                break;
                                        case 3:
                                                res.X = System.Convert.ToInt32(pnlPresupuestoArticulos.Width * .55);
                                                res.Y = System.Convert.ToInt32(pnlPresupuestoArticulos.Height * .05);
                                                res.Height = 1;
                                                res.Width = System.Convert.ToInt32(pnlPresupuestoArticulos.Width * .3);
                                                break;
                                        case 4:
                                                res.X = System.Convert.ToInt32(pnlPresupuestoArticulos.Width * .55);
                                                res.Y = System.Convert.ToInt32(pnlPresupuestoArticulos.Height * .55);
                                                res.Height = 1;
                                                res.Width = System.Convert.ToInt32(pnlPresupuestoArticulos.Width * .3);
                                                break;
                                }
                        } else {
                                int iArtsPorRenglon = System.Convert.ToInt32(Math.Floor((double)(pnlPresupuestoArticulos.Width / (ImagenTamano.Width + ImagenSeparacion.Width))));
                                int iRenglon = System.Convert.ToInt32(Math.Floor((double)((iNumero - 1) / iArtsPorRenglon) + 1));
                                int iColumna = iNumero - ((iRenglon - 1) * iArtsPorRenglon);
                                int iMargenX = System.Convert.ToInt32((pnlPresupuestoArticulos.Width - ((ImagenTamano.Width + ImagenSeparacion.Width) * iArtsPorRenglon)) / 2);
                                res.X = (iColumna - 1) * (ImagenTamano.Width + ImagenSeparacion.Width) + iMargenX;
                                res.Y = (iRenglon - 1) * (ImagenTamano.Height + ImagenSeparacion.Height + ImagenNombreAlto) + 8;
                                res.Width = 1;
                        }
                        return res;
                }


                private void Timer1_Tick(System.Object sender, System.EventArgs e)
                {
                        if (m_Modo == Modos.Inicio) {
                                // Hago 15 intentos de encontrar un artículo con imagen
                                int IdArticulo = this.Workspace.DefaultDataBase.FieldInt("SELECT articulos.id_articulo FROM articulos LEFT JOIN articulos_imagenes ON articulos.id_articulo=articulos_imagenes.id_articulo WHERE articulos.web=1 OR (articulos.web=2 AND articulos.stock_actual>0) ORDER BY RAND()");
                                if (IdArticulo > 0) {
                                        MostrarArticulo(IdArticulo);
                                        m_Modo = Modos.Inicio;
                                }
                        }
                }

                public void Workspace_IpcEvent(object sender, ref Lws.Workspace.RunTimeServices.IpcEventArgs e)
                {
                        if (e.Verb == "TABLECHANGE" && e.Arguments[0].ToString() == "articulos") {
                                //Hubo un cambio en la tabla articulos, vacio la cache
                                TablaArticulos = null;
                        }
                }

                private void FormTickerMostrador_Closing(object sender, System.ComponentModel.CancelEventArgs e)
                {
                        this.Workspace.RunTime.IpcEvent += new Lws.Workspace.RunTimeServices.IpcEventHandler(this.Workspace_IpcEvent);
                }

                private void FormTickerMostrador_Load(object sender, System.EventArgs e)
                {
                        pctPubli.Location = new Point(0, 0);
                        pctPubli.Size = pnlInicio.Size;
                }

                private void TickerMostrador_SizeChanged(object sender, System.EventArgs e)
                {
                        if (this.WindowState == FormWindowState.Maximized)
                                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        else
                                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

                        lblRestore.Visible = (this.WindowState == FormWindowState.Maximized);
                }

                private void lblRestore_Click(object sender, System.EventArgs e)
                {
                        if (this.WindowState == FormWindowState.Maximized)
                                this.WindowState = FormWindowState.Normal;
                        else
                                this.WindowState = FormWindowState.Maximized;
                }

                private void lblRestore_VisibleChanged(object sender, System.EventArgs e)
                {
                        if (lblRestore.Visible)
                                lblRestore.BringToFront();
                }

        }
}