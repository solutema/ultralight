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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lfc.Articulos.Marcas
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }

                        base.Dispose(disposing);
                }

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.EntradaProveedor = new Lcc.Entrada.CodigoDetalle();
                        this.Label14 = new System.Windows.Forms.Label();
                        this.EntradaUrl = new Lui.Forms.TextBox();
                        this.Label12 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label13 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EntradaProveedor
                        // 
                        this.EntradaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaProveedor.AutoTab = true;
                        this.EntradaProveedor.CanCreate = true;
                        this.EntradaProveedor.DataTextField = "nombre_visible";
                        this.EntradaProveedor.ExtraDetailFields = null;
                        this.EntradaProveedor.Filter = "(tipo&2)=2";
                        this.EntradaProveedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaProveedor.FreeTextCode = "";
                        this.EntradaProveedor.DataValueField = "id_persona";
                        this.EntradaProveedor.Location = new System.Drawing.Point(96, 76);
                        this.EntradaProveedor.MaxLength = 200;
                        this.EntradaProveedor.Name = "EntradaProveedor";
                        this.EntradaProveedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProveedor.TemporaryReadOnly = false;
                        this.EntradaProveedor.Required = false;
                        this.EntradaProveedor.Size = new System.Drawing.Size(364, 24);
                        this.EntradaProveedor.TabIndex = 5;
                        this.EntradaProveedor.Table = "personas";
                        this.EntradaProveedor.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaProveedor.Text = "0";
                        this.EntradaProveedor.TextDetail = "";
                        this.EntradaProveedor.PlaceholderText = "Sin especificar";
                        this.EntradaProveedor.ToolTipText = "";
                        // 
                        // Label14
                        // 
                        this.Label14.Location = new System.Drawing.Point(8, 76);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(88, 24);
                        this.Label14.TabIndex = 4;
                        this.Label14.Text = "Proveedor";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaUrl
                        // 
                        this.EntradaUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaUrl.AutoNav = true;
                        this.EntradaUrl.AutoTab = true;
                        this.EntradaUrl.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaUrl.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaUrl.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaUrl.Location = new System.Drawing.Point(96, 44);
                        this.EntradaUrl.MaxLenght = 32767;
                        this.EntradaUrl.Name = "EntradaURL";
                        this.EntradaUrl.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUrl.TemporaryReadOnly = false;
                        this.EntradaUrl.SelectOnFocus = false;
                        this.EntradaUrl.Size = new System.Drawing.Size(444, 24);
                        this.EntradaUrl.TabIndex = 3;
                        this.EntradaUrl.PlaceholderText = "";
                        this.EntradaUrl.ToolTipText = "Dirección de la página web del producto.";
                        // 
                        // Label12
                        // 
                        this.Label12.Location = new System.Drawing.Point(8, 44);
                        this.Label12.Name = "Label12";
                        this.Label12.Size = new System.Drawing.Size(88, 24);
                        this.Label12.TabIndex = 2;
                        this.Label12.Text = "URL";
                        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNombre.Location = new System.Drawing.Point(96, 12);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.TemporaryReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(444, 24);
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.PlaceholderText = "";
                        this.EntradaNombre.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(8, 12);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(88, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaObs.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaObs.Location = new System.Drawing.Point(96, 108);
                        this.EntradaObs.MaxLenght = 32767;
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.TemporaryReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(444, 72);
                        this.EntradaObs.TabIndex = 7;
                        this.EntradaObs.PlaceholderText = "";
                        this.EntradaObs.ToolTipText = "";
                        // 
                        // Label13
                        // 
                        this.Label13.Location = new System.Drawing.Point(8, 108);
                        this.Label13.Name = "Label13";
                        this.Label13.Size = new System.Drawing.Size(88, 24);
                        this.Label13.TabIndex = 6;
                        this.Label13.Text = "Obs.";
                        this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.ClientSize = new System.Drawing.Size(556, 297);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.Label13);
                        this.Controls.Add(this.EntradaProveedor);
                        this.Controls.Add(this.Label14);
                        this.Controls.Add(this.EntradaUrl);
                        this.Controls.Add(this.Label12);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label5);
                        this.Name = "Editar";
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lcc.Entrada.CodigoDetalle EntradaProveedor;
                internal System.Windows.Forms.Label Label14;
                internal Lui.Forms.TextBox EntradaUrl;
                internal System.Windows.Forms.Label Label12;
                internal Lui.Forms.TextBox EntradaNombre;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaObs;
                internal System.Windows.Forms.Label Label13;
        }
}
