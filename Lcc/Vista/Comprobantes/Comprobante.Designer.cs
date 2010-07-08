﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lcc.Vista.Comprobantes
{
        public partial class Comprobante
        {
                private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
                private System.Windows.Forms.Panel panel1;
                private System.Windows.Forms.Label EtiquetaCuit;
                private System.Windows.Forms.Label EtiquetaNombreEmpresa;
                private System.Windows.Forms.Panel panel2;
                private System.Windows.Forms.Label EtiquetaTipoLeyenda;
                private System.Windows.Forms.Label EtiquetaFecha;
                private System.Windows.Forms.Label EtiquetaNumero;
                private System.Windows.Forms.Panel panel3;
                private System.Windows.Forms.Label EtiquetaClienteDomicilio;
                private System.Windows.Forms.Label EtiquetaClienteNombre;
                private System.Windows.Forms.Panel panel4;
                private System.Windows.Forms.Label EtiquetaClienteSituacion;
                private System.Windows.Forms.Label EtiquetaClienteCuit;
                private System.Windows.Forms.Label EtiquetaTotal;
                private System.Windows.Forms.Label EtiquetaSubtotal;
                private System.Windows.Forms.Label label10;
                private System.Windows.Forms.Label label11;
                private System.Windows.Forms.Label EtiquetaDescuento;
                private System.Windows.Forms.Label EtiquetaTipo;

                private void InitializeComponent()
                {
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.EtiquetaCuit = new System.Windows.Forms.Label();
                        this.EtiquetaNombreEmpresa = new System.Windows.Forms.Label();
                        this.panel2 = new System.Windows.Forms.Panel();
                        this.EtiquetaTipoLeyenda = new System.Windows.Forms.Label();
                        this.EtiquetaFecha = new System.Windows.Forms.Label();
                        this.EtiquetaNumero = new System.Windows.Forms.Label();
                        this.panel3 = new System.Windows.Forms.Panel();
                        this.EtiquetaClienteDomicilio = new System.Windows.Forms.Label();
                        this.EtiquetaClienteNombre = new System.Windows.Forms.Label();
                        this.panel4 = new System.Windows.Forms.Panel();
                        this.EtiquetaClienteSituacion = new System.Windows.Forms.Label();
                        this.EtiquetaClienteCuit = new System.Windows.Forms.Label();
                        this.EtiquetaTipo = new System.Windows.Forms.Label();
                        this.EtiquetaTotal = new System.Windows.Forms.Label();
                        this.EtiquetaSubtotal = new System.Windows.Forms.Label();
                        this.label10 = new System.Windows.Forms.Label();
                        this.label11 = new System.Windows.Forms.Label();
                        this.EtiquetaDescuento = new System.Windows.Forms.Label();
                        this.EtiquetaAnulado = new Lui.Forms.OrientedTextLabel();
                        this.tableLayoutPanel1.SuspendLayout();
                        this.panel1.SuspendLayout();
                        this.panel2.SuspendLayout();
                        this.panel3.SuspendLayout();
                        this.panel4.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                        this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
                        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 2;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.44444F));
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.55556F));
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 180);
                        this.tableLayoutPanel1.TabIndex = 1;
                        // 
                        // panel1
                        // 
                        this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.panel1.Controls.Add(this.EtiquetaCuit);
                        this.panel1.Controls.Add(this.EtiquetaNombreEmpresa);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panel1.Location = new System.Drawing.Point(3, 3);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(301, 100);
                        this.panel1.TabIndex = 0;
                        // 
                        // EtiquetaCuit
                        // 
                        this.EtiquetaCuit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaCuit.Location = new System.Drawing.Point(16, 76);
                        this.EtiquetaCuit.Name = "EtiquetaCuit";
                        this.EtiquetaCuit.Size = new System.Drawing.Size(265, 20);
                        this.EtiquetaCuit.TabIndex = 1;
                        this.EtiquetaCuit.Text = "00-00000000-0";
                        this.EtiquetaCuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaCuit.UseMnemonic = false;
                        // 
                        // EtiquetaNombreEmpresa
                        // 
                        this.EtiquetaNombreEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaNombreEmpresa.Location = new System.Drawing.Point(16, 52);
                        this.EtiquetaNombreEmpresa.Name = "EtiquetaNombreEmpresa";
                        this.EtiquetaNombreEmpresa.Size = new System.Drawing.Size(265, 20);
                        this.EtiquetaNombreEmpresa.TabIndex = 0;
                        this.EtiquetaNombreEmpresa.Text = "Nombre de la Empresa";
                        this.EtiquetaNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaNombreEmpresa.UseMnemonic = false;
                        // 
                        // panel2
                        // 
                        this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.panel2.Controls.Add(this.EtiquetaTipoLeyenda);
                        this.panel2.Controls.Add(this.EtiquetaFecha);
                        this.panel2.Controls.Add(this.EtiquetaNumero);
                        this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panel2.Location = new System.Drawing.Point(310, 3);
                        this.panel2.Name = "panel2";
                        this.panel2.Size = new System.Drawing.Size(301, 100);
                        this.panel2.TabIndex = 1;
                        // 
                        // EtiquetaTipoLeyenda
                        // 
                        this.EtiquetaTipoLeyenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaTipoLeyenda.Location = new System.Drawing.Point(56, 44);
                        this.EtiquetaTipoLeyenda.Name = "EtiquetaTipoLeyenda";
                        this.EtiquetaTipoLeyenda.Size = new System.Drawing.Size(230, 20);
                        this.EtiquetaTipoLeyenda.TabIndex = 3;
                        this.EtiquetaTipoLeyenda.Text = "Nota de Crédito";
                        this.EtiquetaTipoLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaTipoLeyenda.UseMnemonic = false;
                        // 
                        // EtiquetaFecha
                        // 
                        this.EtiquetaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaFecha.Location = new System.Drawing.Point(56, 76);
                        this.EtiquetaFecha.Name = "EtiquetaFecha";
                        this.EtiquetaFecha.Size = new System.Drawing.Size(229, 20);
                        this.EtiquetaFecha.TabIndex = 2;
                        this.EtiquetaFecha.Text = "01-01-2009";
                        this.EtiquetaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaFecha.UseMnemonic = false;
                        // 
                        // EtiquetaNumero
                        // 
                        this.EtiquetaNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaNumero.Location = new System.Drawing.Point(56, 12);
                        this.EtiquetaNumero.Name = "EtiquetaNumero";
                        this.EtiquetaNumero.Size = new System.Drawing.Size(230, 29);
                        this.EtiquetaNumero.TabIndex = 1;
                        this.EtiquetaNumero.Text = "0000-00000000";
                        this.EtiquetaNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaNumero.UseMnemonic = false;
                        // 
                        // panel3
                        // 
                        this.panel3.Controls.Add(this.EtiquetaClienteDomicilio);
                        this.panel3.Controls.Add(this.EtiquetaClienteNombre);
                        this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panel3.Location = new System.Drawing.Point(3, 109);
                        this.panel3.Name = "panel3";
                        this.panel3.Size = new System.Drawing.Size(301, 68);
                        this.panel3.TabIndex = 2;
                        // 
                        // EtiquetaClienteDomicilio
                        // 
                        this.EtiquetaClienteDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaClienteDomicilio.Location = new System.Drawing.Point(9, 38);
                        this.EtiquetaClienteDomicilio.Name = "EtiquetaClienteDomicilio";
                        this.EtiquetaClienteDomicilio.Size = new System.Drawing.Size(283, 23);
                        this.EtiquetaClienteDomicilio.TabIndex = 3;
                        this.EtiquetaClienteDomicilio.Text = "Domicilio";
                        this.EtiquetaClienteDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaClienteDomicilio.UseMnemonic = false;
                        // 
                        // EtiquetaClienteNombre
                        // 
                        this.EtiquetaClienteNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaClienteNombre.Location = new System.Drawing.Point(8, 9);
                        this.EtiquetaClienteNombre.Name = "EtiquetaClienteNombre";
                        this.EtiquetaClienteNombre.Size = new System.Drawing.Size(283, 23);
                        this.EtiquetaClienteNombre.TabIndex = 2;
                        this.EtiquetaClienteNombre.Text = "Cliente";
                        this.EtiquetaClienteNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaClienteNombre.UseMnemonic = false;
                        // 
                        // panel4
                        // 
                        this.panel4.Controls.Add(this.EtiquetaClienteSituacion);
                        this.panel4.Controls.Add(this.EtiquetaClienteCuit);
                        this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panel4.Location = new System.Drawing.Point(310, 109);
                        this.panel4.Name = "panel4";
                        this.panel4.Size = new System.Drawing.Size(301, 68);
                        this.panel4.TabIndex = 3;
                        // 
                        // EtiquetaClienteSituacion
                        // 
                        this.EtiquetaClienteSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaClienteSituacion.Location = new System.Drawing.Point(8, 40);
                        this.EtiquetaClienteSituacion.Name = "EtiquetaClienteSituacion";
                        this.EtiquetaClienteSituacion.Size = new System.Drawing.Size(283, 23);
                        this.EtiquetaClienteSituacion.TabIndex = 5;
                        this.EtiquetaClienteSituacion.Text = "Situación";
                        this.EtiquetaClienteSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaClienteSituacion.UseMnemonic = false;
                        // 
                        // EtiquetaClienteCuit
                        // 
                        this.EtiquetaClienteCuit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaClienteCuit.Location = new System.Drawing.Point(8, 8);
                        this.EtiquetaClienteCuit.Name = "EtiquetaClienteCuit";
                        this.EtiquetaClienteCuit.Size = new System.Drawing.Size(283, 23);
                        this.EtiquetaClienteCuit.TabIndex = 4;
                        this.EtiquetaClienteCuit.Text = "CUIT";
                        this.EtiquetaClienteCuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaClienteCuit.UseMnemonic = false;
                        // 
                        // EtiquetaTipo
                        // 
                        this.EtiquetaTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaTipo.Location = new System.Drawing.Point(283, 12);
                        this.EtiquetaTipo.Name = "EtiquetaTipo";
                        this.EtiquetaTipo.Size = new System.Drawing.Size(49, 28);
                        this.EtiquetaTipo.TabIndex = 2;
                        this.EtiquetaTipo.Text = "T";
                        this.EtiquetaTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaTipo.UseMnemonic = false;
                        // 
                        // EtiquetaTotal
                        // 
                        this.EtiquetaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.EtiquetaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaTotal.Location = new System.Drawing.Point(476, 356);
                        this.EtiquetaTotal.Name = "EtiquetaTotal";
                        this.EtiquetaTotal.Size = new System.Drawing.Size(132, 36);
                        this.EtiquetaTotal.TabIndex = 3;
                        this.EtiquetaTotal.Text = "0.00";
                        this.EtiquetaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EtiquetaSubtotal
                        // 
                        this.EtiquetaSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaSubtotal.Location = new System.Drawing.Point(8, 368);
                        this.EtiquetaSubtotal.Name = "EtiquetaSubtotal";
                        this.EtiquetaSubtotal.Size = new System.Drawing.Size(92, 24);
                        this.EtiquetaSubtotal.TabIndex = 4;
                        this.EtiquetaSubtotal.Text = "0.00";
                        this.EtiquetaSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // label10
                        // 
                        this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label10.Location = new System.Drawing.Point(8, 348);
                        this.label10.Name = "label10";
                        this.label10.Size = new System.Drawing.Size(92, 20);
                        this.label10.TabIndex = 5;
                        this.label10.Text = "Sub total";
                        this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label11
                        // 
                        this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label11.Location = new System.Drawing.Point(112, 348);
                        this.label11.Name = "label11";
                        this.label11.Size = new System.Drawing.Size(80, 20);
                        this.label11.TabIndex = 7;
                        this.label11.Text = "Descuento";
                        this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EtiquetaDescuento
                        // 
                        this.EtiquetaDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaDescuento.Location = new System.Drawing.Point(112, 368);
                        this.EtiquetaDescuento.Name = "EtiquetaDescuento";
                        this.EtiquetaDescuento.Size = new System.Drawing.Size(80, 24);
                        this.EtiquetaDescuento.TabIndex = 6;
                        this.EtiquetaDescuento.Text = "0%";
                        this.EtiquetaDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EtiquetaAnulado
                        // 
                        this.EtiquetaAnulado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaAnulado.BackColor = System.Drawing.Color.Transparent;
                        this.EtiquetaAnulado.Font = new System.Drawing.Font("Bitstream Vera Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaAnulado.ForeColor = System.Drawing.Color.Firebrick;
                        this.EtiquetaAnulado.Location = new System.Drawing.Point(16, 200);
                        this.EtiquetaAnulado.Name = "EtiquetaAnulado";
                        this.EtiquetaAnulado.RotationAngle = -20;
                        this.EtiquetaAnulado.Size = new System.Drawing.Size(580, 132);
                        this.EtiquetaAnulado.TabIndex = 9;
                        this.EtiquetaAnulado.Text = "ANULADO";
                        this.EtiquetaAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaAnulado.TextDirection = Lui.Forms.Direction.Clockwise;
                        this.EtiquetaAnulado.TextOrientation = Lui.Forms.Orientation.Rotate;
                        this.EtiquetaAnulado.UseMnemonic = false;
                        this.EtiquetaAnulado.Visible = false;
                        // 
                        // Comprobante
                        // 
                        this.Controls.Add(this.EtiquetaAnulado);
                        this.Controls.Add(this.label11);
                        this.Controls.Add(this.EtiquetaDescuento);
                        this.Controls.Add(this.label10);
                        this.Controls.Add(this.EtiquetaSubtotal);
                        this.Controls.Add(this.EtiquetaTotal);
                        this.Controls.Add(this.EtiquetaTipo);
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Comprobante";
                        this.Size = new System.Drawing.Size(614, 398);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.panel1.ResumeLayout(false);
                        this.panel2.ResumeLayout(false);
                        this.panel3.ResumeLayout(false);
                        this.panel4.ResumeLayout(false);
                        this.ResumeLayout(false);

                }
                private Lui.Forms.OrientedTextLabel EtiquetaAnulado;
        }
}