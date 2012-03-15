#region License
// Copyright 2004-2012 Ernesto N. Carrea
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

namespace Lfc.Inicio
{
        partial class Inicio
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
                        this.BotonWebInicio = new Lui.Forms.LinkLabel();
                        this.BotonWebContacto = new Lui.Forms.LinkLabel();
                        this.BotonWebComo = new Lui.Forms.LinkLabel();
                        this.label1 = new Lui.Forms.Label();
                        this.BotonWebPrimerosPasos = new Lui.Forms.LinkLabel();
                        this.BotonWebAltaArticulo = new Lui.Forms.LinkLabel();
                        this.BotonWebComoFactura = new Lui.Forms.LinkLabel();
                        this.PanelWeb = new Lui.Forms.Panel();
                        this.PanelComprobantes = new Lfc.Inicio.ControlComprobantes();
                        this.PanelPersonas = new Lfc.Inicio.ControlPersonas();
                        this.PanelArticulos = new Lfc.Inicio.ControlArticulos();
                        this.PanelConsejo = new Lfc.Inicio.Consejo();
                        this.PanelWeb.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // BotonWebInicio
                        // 
                        this.BotonWebInicio.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
                        this.BotonWebInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonWebInicio.AutoSize = true;
                        this.BotonWebInicio.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonWebInicio.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        this.BotonWebInicio.Location = new System.Drawing.Point(792, 616);
                        this.BotonWebInicio.Name = "BotonWebInicio";
                        this.BotonWebInicio.Size = new System.Drawing.Size(161, 17);
                        this.BotonWebInicio.TabIndex = 3;
                        this.BotonWebInicio.TabStop = true;
                        this.BotonWebInicio.Text = "www.sistemalazaro.com.ar";
                        this.BotonWebInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonWebInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonWebInicio_LinkClicked);
                        // 
                        // BotonWebContacto
                        // 
                        this.BotonWebContacto.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
                        this.BotonWebContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonWebContacto.AutoSize = true;
                        this.BotonWebContacto.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonWebContacto.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        this.BotonWebContacto.Location = new System.Drawing.Point(648, 616);
                        this.BotonWebContacto.Name = "BotonWebContacto";
                        this.BotonWebContacto.Size = new System.Drawing.Size(124, 17);
                        this.BotonWebContacto.TabIndex = 4;
                        this.BotonWebContacto.TabStop = true;
                        this.BotonWebContacto.Text = "¿Tiene sugerencias?";
                        this.BotonWebContacto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonWebContacto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonWebContacto_LinkClicked);
                        // 
                        // BotonWebComo
                        // 
                        this.BotonWebComo.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
                        this.BotonWebComo.AutoSize = true;
                        this.BotonWebComo.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonWebComo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        this.BotonWebComo.Location = new System.Drawing.Point(240, 72);
                        this.BotonWebComo.Name = "BotonWebComo";
                        this.BotonWebComo.Size = new System.Drawing.Size(144, 17);
                        this.BotonWebComo.TabIndex = 5;
                        this.BotonWebComo.TabStop = true;
                        this.BotonWebComo.Text = "Otras tareas frecuentes";
                        this.BotonWebComo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonWebComo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonWebComo_LinkClicked);
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(16, 12);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(173, 30);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Ayuda en la web";
                        this.label1.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.MainHeader;
                        // 
                        // BotonWebPrimerosPasos
                        // 
                        this.BotonWebPrimerosPasos.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
                        this.BotonWebPrimerosPasos.AutoSize = true;
                        this.BotonWebPrimerosPasos.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonWebPrimerosPasos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        this.BotonWebPrimerosPasos.Location = new System.Drawing.Point(48, 48);
                        this.BotonWebPrimerosPasos.Name = "BotonWebPrimerosPasos";
                        this.BotonWebPrimerosPasos.Size = new System.Drawing.Size(99, 17);
                        this.BotonWebPrimerosPasos.TabIndex = 6;
                        this.BotonWebPrimerosPasos.TabStop = true;
                        this.BotonWebPrimerosPasos.Text = "Primeros pasos";
                        this.BotonWebPrimerosPasos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonWebPrimerosPasos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonWebPrimerosPasos_LinkClicked);
                        // 
                        // BotonWebAltaArticulo
                        // 
                        this.BotonWebAltaArticulo.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
                        this.BotonWebAltaArticulo.AutoSize = true;
                        this.BotonWebAltaArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonWebAltaArticulo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        this.BotonWebAltaArticulo.Location = new System.Drawing.Point(48, 72);
                        this.BotonWebAltaArticulo.Name = "BotonWebAltaArticulo";
                        this.BotonWebAltaArticulo.Size = new System.Drawing.Size(138, 17);
                        this.BotonWebAltaArticulo.TabIndex = 7;
                        this.BotonWebAltaArticulo.TabStop = true;
                        this.BotonWebAltaArticulo.Text = "Dar de alta un artículo";
                        this.BotonWebAltaArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonWebAltaArticulo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonWebAltaArticulo_LinkClicked);
                        // 
                        // BotonWebComoFactura
                        // 
                        this.BotonWebComoFactura.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
                        this.BotonWebComoFactura.AutoSize = true;
                        this.BotonWebComoFactura.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonWebComoFactura.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        this.BotonWebComoFactura.Location = new System.Drawing.Point(240, 48);
                        this.BotonWebComoFactura.Name = "BotonWebComoFactura";
                        this.BotonWebComoFactura.Size = new System.Drawing.Size(126, 17);
                        this.BotonWebComoFactura.TabIndex = 8;
                        this.BotonWebComoFactura.TabStop = true;
                        this.BotonWebComoFactura.Text = "Imprimir una factura";
                        this.BotonWebComoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonWebComoFactura.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonWebComoFactura_LinkClicked);
                        // 
                        // PanelWeb
                        // 
                        this.PanelWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.PanelWeb.BackColor = System.Drawing.Color.White;
                        this.PanelWeb.Controls.Add(this.label1);
                        this.PanelWeb.Controls.Add(this.BotonWebComoFactura);
                        this.PanelWeb.Controls.Add(this.BotonWebComo);
                        this.PanelWeb.Controls.Add(this.BotonWebAltaArticulo);
                        this.PanelWeb.Controls.Add(this.BotonWebPrimerosPasos);
                        this.PanelWeb.Location = new System.Drawing.Point(48, 448);
                        this.PanelWeb.Name = "PanelWeb";
                        this.PanelWeb.Size = new System.Drawing.Size(480, 104);
                        this.PanelWeb.TabIndex = 9;
                        // 
                        // PanelComprobantes
                        // 
                        this.PanelComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                        this.PanelComprobantes.BackColor = System.Drawing.Color.OrangeRed;
                        this.PanelComprobantes.Descripcion = "Administre diferentes tipos de comprobantes, como ser facturas y tickets, recibos" +
    ", remitos y presupuestos.";
                        this.PanelComprobantes.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PanelComprobantes.ForeColor = System.Drawing.Color.White;
                        this.PanelComprobantes.Image = ((System.Drawing.Image)(resources.GetObject("PanelComprobantes.Image")));
                        this.PanelComprobantes.Location = new System.Drawing.Point(544, 224);
                        this.PanelComprobantes.MinimumSize = new System.Drawing.Size(416, 300);
                        this.PanelComprobantes.Name = "PanelComprobantes";
                        this.PanelComprobantes.Size = new System.Drawing.Size(416, 377);
                        this.PanelComprobantes.TabIndex = 2;
                        this.PanelComprobantes.Text = "Comprobantes";
                        // 
                        // PanelPersonas
                        // 
                        this.PanelPersonas.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.PanelPersonas.BackColor = System.Drawing.Color.SeaGreen;
                        this.PanelPersonas.Descripcion = "Administre los clientes, proveedores y usuarios del sistema. Puede dar de alta nu" +
    "evos clientes o proveedores si lo necesita.";
                        this.PanelPersonas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PanelPersonas.ForeColor = System.Drawing.Color.White;
                        this.PanelPersonas.Image = ((System.Drawing.Image)(resources.GetObject("PanelPersonas.Image")));
                        this.PanelPersonas.Location = new System.Drawing.Point(48, 272);
                        this.PanelPersonas.Name = "PanelPersonas";
                        this.PanelPersonas.Size = new System.Drawing.Size(480, 160);
                        this.PanelPersonas.TabIndex = 1;
                        this.PanelPersonas.Text = "Personas";
                        // 
                        // PanelArticulos
                        // 
                        this.PanelArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.PanelArticulos.BackColor = System.Drawing.Color.SteelBlue;
                        this.PanelArticulos.Descripcion = "Administre los productos o servicios que vende en su empresa.";
                        this.PanelArticulos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PanelArticulos.ForeColor = System.Drawing.Color.White;
                        this.PanelArticulos.Image = ((System.Drawing.Image)(resources.GetObject("PanelArticulos.Image")));
                        this.PanelArticulos.Location = new System.Drawing.Point(48, 48);
                        this.PanelArticulos.Name = "PanelArticulos";
                        this.PanelArticulos.Size = new System.Drawing.Size(480, 208);
                        this.PanelArticulos.TabIndex = 0;
                        this.PanelArticulos.Text = "Artículos";
                        // 
                        // PanelConsejo
                        // 
                        this.PanelConsejo.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.PanelConsejo.BackColor = System.Drawing.Color.DarkOrchid;
                        this.PanelConsejo.Descripcion = "...puede hacer cuentas al escribir números en Lázaro? Al ingresar datos en cualqu" +
    "ier campo numérico puede hacer cálculos como 2+2 o 7*5 y Lázaro calculará automá" +
    "ticamente el resultado.";
                        this.PanelConsejo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PanelConsejo.Image = ((System.Drawing.Image)(resources.GetObject("PanelConsejo.Image")));
                        this.PanelConsejo.Location = new System.Drawing.Point(544, 48);
                        this.PanelConsejo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
                        this.PanelConsejo.Name = "PanelConsejo";
                        this.PanelConsejo.Size = new System.Drawing.Size(416, 160);
                        this.PanelConsejo.TabIndex = 10;
                        this.PanelConsejo.Text = "Consejo del día";
                        this.PanelConsejo.DoubleClick += new System.EventHandler(this.PanelConsejo_DoubleClick);
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.BackColor = System.Drawing.Color.White;
                        this.ClientSize = new System.Drawing.Size(984, 642);
                        this.Controls.Add(this.PanelConsejo);
                        this.Controls.Add(this.PanelWeb);
                        this.Controls.Add(this.PanelComprobantes);
                        this.Controls.Add(this.PanelPersonas);
                        this.Controls.Add(this.PanelArticulos);
                        this.Controls.Add(this.BotonWebContacto);
                        this.Controls.Add(this.BotonWebInicio);
                        this.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Name = "Inicio";
                        this.Padding = new System.Windows.Forms.Padding(32);
                        this.Text = "Inicio";
                        this.PanelWeb.ResumeLayout(false);
                        this.PanelWeb.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private ControlArticulos PanelArticulos;
                private ControlPersonas PanelPersonas;
                private ControlComprobantes PanelComprobantes;
                private Lui.Forms.LinkLabel BotonWebInicio;
                private Lui.Forms.LinkLabel BotonWebContacto;
                private Lui.Forms.LinkLabel BotonWebComo;
                private Lui.Forms.Label label1;
                private Lui.Forms.LinkLabel BotonWebPrimerosPasos;
                private Lui.Forms.LinkLabel BotonWebAltaArticulo;
                private Lui.Forms.LinkLabel BotonWebComoFactura;
                private Lui.Forms.Panel PanelWeb;
                private Consejo PanelConsejo;

        }
}
