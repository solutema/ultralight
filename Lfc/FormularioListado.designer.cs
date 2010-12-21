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

namespace Lfc
{
        partial class FormularioListado
        {
                #region Código generado por el Diseñador de Windows Forms

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.IContainer components = null;

                // Limpiar los recursos que se estén utilizando.
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
                        this.EntradaBuscar = new Lui.Forms.TextBox();
                        this.BotonCrear = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // Listado
                        // 
                        this.Listado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Listado_KeyDown);
                        // 
                        // EntradaBuscar
                        // 
                        this.EntradaBuscar.AutoNav = true;
                        this.EntradaBuscar.AutoTab = false;
                        this.EntradaBuscar.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaBuscar.DecimalPlaces = -1;
                        this.EntradaBuscar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBuscar.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaBuscar.Location = new System.Drawing.Point(8, 8);
                        this.EntradaBuscar.MaxLenght = 32767;
                        this.EntradaBuscar.MultiLine = false;
                        this.EntradaBuscar.Name = "EntradaBuscar";
                        this.EntradaBuscar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBuscar.PasswordChar = '\0';
                        this.EntradaBuscar.Prefijo = "";
                        this.EntradaBuscar.SelectOnFocus = true;
                        this.EntradaBuscar.Size = new System.Drawing.Size(212, 24);
                        this.EntradaBuscar.Sufijo = "";
                        this.EntradaBuscar.TabIndex = 1;
                        this.EntradaBuscar.TipWhenBlank = "buscar";
                        this.EntradaBuscar.ToolTipText = "Escriba el texto o parte del texto a buscar y pulse <Intro>";
                        this.EntradaBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaBuscar_KeyDown);
                        // 
                        // BotonCrear
                        // 
                        this.BotonCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonCrear.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCrear.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonCrear.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCrear.Image = null;
                        this.BotonCrear.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCrear.Location = new System.Drawing.Point(120, 236);
                        this.BotonCrear.Name = "BotonCrear";
                        this.BotonCrear.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCrear.Size = new System.Drawing.Size(96, 28);
                        this.BotonCrear.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonCrear.Subtext = "F6";
                        this.BotonCrear.TabIndex = 3;
                        this.BotonCrear.Text = "Crear";
                        this.BotonCrear.ToolTipText = "";
                        this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
                        // 
                        // FormularioListado
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoSize = true;
                        this.ClientSize = new System.Drawing.Size(792, 472);
                        this.Controls.Add(this.BotonCrear);
                        this.Controls.Add(this.EntradaBuscar);
                        this.Name = "FormularioListado";
                        this.Text = "Listado";
                        this.Controls.SetChildIndex(this.EntradaBuscar, 0);
                        this.Controls.SetChildIndex(this.EtiquetaCantidad, 0);
                        this.Controls.SetChildIndex(this.BotonCrear, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.BotonCancelar, 0);
                        this.Controls.SetChildIndex(this.BotonFiltrar, 0);
                        this.Controls.SetChildIndex(this.BotonImprimir, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.TextBox EntradaBuscar;
                protected internal Lui.Forms.Button BotonCrear;

        }
}