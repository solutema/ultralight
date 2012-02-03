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

namespace Lfc.Comprobantes.Tipo
{
        partial class AgregarTipoImpresora
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
                        this.EntradaImpresora = new Lcc.Entrada.CodigoDetalle();
                        this.Label16 = new Lui.Forms.Label();
                        this.EntradaSucursal = new Lcc.Entrada.CodigoDetalle();
                        this.label1 = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.BotonSeleccionarEstacion = new Lui.Forms.Button();
                        this.EntradaEstacion = new Lui.Forms.TextBox();
                        this.EntradaPuntoDeVenta = new Lui.Forms.TextBox();
                        this.label4 = new Lui.Forms.Label();
                        this.label5 = new Lui.Forms.Label();
                        this.label6 = new Lui.Forms.Label();
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
                        // EntradaImpresora
                        // 
                        this.EntradaImpresora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaImpresora.AutoNav = true;
                        this.EntradaImpresora.CanCreate = true;
                        this.EntradaImpresora.DataTextField = "nombre";
                        this.EntradaImpresora.Filter = "";
                        this.EntradaImpresora.FreeTextCode = "";
                        this.EntradaImpresora.DataValueField = "id_impresora";
                        this.EntradaImpresora.Location = new System.Drawing.Point(152, 52);
                        this.EntradaImpresora.MaxLength = 200;
                        this.EntradaImpresora.Name = "EntradaImpresora";
                        this.EntradaImpresora.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImpresora.Required = false;
                        this.EntradaImpresora.Size = new System.Drawing.Size(456, 24);
                        this.EntradaImpresora.TabIndex = 1;
                        this.EntradaImpresora.Table = "impresoras";
                        this.EntradaImpresora.Text = "0";
                        this.EntradaImpresora.TextDetail = "";
                        this.EntradaImpresora.PlaceholderText = "Ninguno";
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(24, 52);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(128, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Impresora";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSucursal
                        // 
                        this.EntradaSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSucursal.AutoNav = true;
                        this.EntradaSucursal.CanCreate = true;
                        this.EntradaSucursal.DataTextField = "nombre";
                        this.EntradaSucursal.Filter = "";
                        this.EntradaSucursal.FreeTextCode = "";
                        this.EntradaSucursal.DataValueField = "id_sucursal";
                        this.EntradaSucursal.Location = new System.Drawing.Point(152, 120);
                        this.EntradaSucursal.MaxLength = 200;
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.Required = false;
                        this.EntradaSucursal.Size = new System.Drawing.Size(456, 24);
                        this.EntradaSucursal.TabIndex = 3;
                        this.EntradaSucursal.Table = "sucursales";
                        this.EntradaSucursal.Text = "0";
                        this.EntradaSucursal.TextDetail = "";
                        this.EntradaSucursal.PlaceholderText = "Todas";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(24, 120);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(128, 24);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "Sucursal";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(24, 152);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(128, 24);
                        this.Label3.TabIndex = 4;
                        this.Label3.Text = "Punto de Venta";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(24, 184);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(128, 24);
                        this.label2.TabIndex = 6;
                        this.label2.Text = "Estación";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // cmdEstacionSeleccionar
                        // 
                        this.BotonSeleccionarEstacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonSeleccionarEstacion.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonSeleccionarEstacion.Image = null;
                        this.BotonSeleccionarEstacion.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonSeleccionarEstacion.Location = new System.Drawing.Point(352, 184);
                        this.BotonSeleccionarEstacion.Name = "cmdEstacionSeleccionar";
                        this.BotonSeleccionarEstacion.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonSeleccionarEstacion.Size = new System.Drawing.Size(28, 24);
                        this.BotonSeleccionarEstacion.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonSeleccionarEstacion.Subtext = "";
                        this.BotonSeleccionarEstacion.TabIndex = 8;
                        this.BotonSeleccionarEstacion.Text = "...";
                        this.BotonSeleccionarEstacion.Click += new System.EventHandler(this.BotonEstacionSeleccionar_Click);
                        // 
                        // EntradaEstacion
                        // 
                        this.EntradaEstacion.AutoNav = true;
                        this.EntradaEstacion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEstacion.DecimalPlaces = -1;
                        this.EntradaEstacion.ForceCase = Lui.Forms.TextCasing.UpperCase;
                        this.EntradaEstacion.Location = new System.Drawing.Point(152, 184);
                        this.EntradaEstacion.MultiLine = false;
                        this.EntradaEstacion.Name = "EntradaEstacion";
                        this.EntradaEstacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstacion.SelectOnFocus = true;
                        this.EntradaEstacion.Size = new System.Drawing.Size(196, 24);
                        this.EntradaEstacion.TabIndex = 7;
                        // 
                        // EntradaPuntoDeVenta
                        // 
                        this.EntradaPuntoDeVenta.AutoNav = true;
                        this.EntradaPuntoDeVenta.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPuntoDeVenta.DecimalPlaces = -1;
                        this.EntradaPuntoDeVenta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPuntoDeVenta.Location = new System.Drawing.Point(152, 152);
                        this.EntradaPuntoDeVenta.MultiLine = false;
                        this.EntradaPuntoDeVenta.Name = "EntradaPuntoDeVenta";
                        this.EntradaPuntoDeVenta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPuntoDeVenta.SelectOnFocus = true;
                        this.EntradaPuntoDeVenta.Size = new System.Drawing.Size(72, 24);
                        this.EntradaPuntoDeVenta.TabIndex = 5;
                        this.EntradaPuntoDeVenta.Text = "0";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(24, 24);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(316, 24);
                        this.label4.TabIndex = 51;
                        this.label4.Text = "Este tipo de comprobante se imprimie en";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(24, 92);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(316, 24);
                        this.label5.TabIndex = 52;
                        this.label5.Text = "Dadas las siguientes condiciones";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(228, 152);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(316, 24);
                        this.label6.TabIndex = 53;
                        this.label6.Text = "(0 para todos los Puntos de Venta)";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // AgregarTipoImpresora
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(634, 372);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaPuntoDeVenta);
                        this.Controls.Add(this.EntradaSucursal);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.BotonSeleccionarEstacion);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaEstacion);
                        this.Controls.Add(this.Label16);
                        this.Controls.Add(this.EntradaImpresora);
                        this.Name = "AgregarTipoImpresora";
                        this.Text = "AgregarTipoImpresora";
                        this.Controls.SetChildIndex(this.EntradaImpresora, 0);
                        this.Controls.SetChildIndex(this.Label16, 0);
                        this.Controls.SetChildIndex(this.EntradaEstacion, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.BotonSeleccionarEstacion, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaSucursal, 0);
                        this.Controls.SetChildIndex(this.EntradaPuntoDeVenta, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lcc.Entrada.CodigoDetalle EntradaImpresora;
                internal Lui.Forms.Label Label16;
                internal Lcc.Entrada.CodigoDetalle EntradaSucursal;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.Button BotonSeleccionarEstacion;
                internal Lui.Forms.TextBox EntradaEstacion;
                internal Lui.Forms.TextBox EntradaPuntoDeVenta;
                internal Lui.Forms.Label label4;
                internal Lui.Forms.Label label5;
                internal Lui.Forms.Label label6;
        }
}
