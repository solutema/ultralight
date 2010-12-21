#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Articulos.Rubros
{
        public partial class Editar
        {
                internal System.Windows.Forms.Label label9;
                internal Lui.Forms.TextBox EntradaNombre;
                internal System.Windows.Forms.Label Label5;
                private Lcc.Entrada.CodigoDetalle EntradaAlicuota;

                #region Código generado por el diseñador

                private System.ComponentModel.IContainer components = null;

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                private void InitializeComponent()
                {
                        this.label9 = new System.Windows.Forms.Label();
                        this.EntradaAlicuota = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(12, 48);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(104, 24);
                        this.label9.TabIndex = 2;
                        this.label9.Text = "Alícuota";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAlicuota
                        // 
                        this.EntradaAlicuota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaAlicuota.AutoNav = true;
                        this.EntradaAlicuota.AutoTab = true;
                        this.EntradaAlicuota.CanCreate = true;
                        this.EntradaAlicuota.DataTextField = "nombre";
                        this.EntradaAlicuota.ExtraDetailFields = "";
                        this.EntradaAlicuota.Filter = "";
                        this.EntradaAlicuota.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaAlicuota.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaAlicuota.FreeTextCode = "";
                        this.EntradaAlicuota.DataValueField = "id_alicuota";
                        this.EntradaAlicuota.Location = new System.Drawing.Point(116, 48);
                        this.EntradaAlicuota.MaxLength = 200;
                        this.EntradaAlicuota.Name = "EntradaAlicuota";
                        this.EntradaAlicuota.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAlicuota.Required = true;
                        this.EntradaAlicuota.Size = new System.Drawing.Size(356, 24);
                        this.EntradaAlicuota.TabIndex = 3;
                        this.EntradaAlicuota.Table = "alicuotas";
                        this.EntradaAlicuota.Text = "0";
                        this.EntradaAlicuota.TextDetail = "";
                        this.EntradaAlicuota.TipWhenBlank = "Sin especificar";
                        this.EntradaAlicuota.ToolTipText = "";
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNombre.Location = new System.Drawing.Point(116, 16);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(356, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(12, 16);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(104, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.EntradaAlicuota);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label5);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(488, 237);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.EntradaAlicuota, 0);
                        this.Controls.SetChildIndex(this.label9, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion
        }
}
