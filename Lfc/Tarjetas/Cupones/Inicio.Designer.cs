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

namespace Lfc.Cupones.Cupones
{
        public partial class Inicio
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.BotonAnular = new Lui.Forms.Button();
                        this.BotonAcreditar = new Lui.Forms.Button();
                        this.BotonPresentar = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // Listado
                        // 
                        this.Listado.Size = new System.Drawing.Size(1080, 472);
                        // 
                        // BotonAnular
                        // 
                        this.BotonAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAnular.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAnular.Image = null;
                        this.BotonAnular.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAnular.Location = new System.Drawing.Point(12, 348);
                        this.BotonAnular.Name = "BotonAnular";
                        this.BotonAnular.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAnular.Size = new System.Drawing.Size(96, 29);
                        this.BotonAnular.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonAnular.Subtext = "F6";
                        this.BotonAnular.TabIndex = 7;
                        this.BotonAnular.Text = "Anular";
                        this.BotonAnular.ToolTipText = "";
                        this.BotonAnular.Click += new System.EventHandler(this.BotonAnular_Click);
                        // 
                        // BotonAcreditar
                        // 
                        this.BotonAcreditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAcreditar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAcreditar.Image = null;
                        this.BotonAcreditar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAcreditar.Location = new System.Drawing.Point(12, 312);
                        this.BotonAcreditar.Name = "BotonAcreditar";
                        this.BotonAcreditar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAcreditar.Size = new System.Drawing.Size(96, 29);
                        this.BotonAcreditar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonAcreditar.Subtext = "F4";
                        this.BotonAcreditar.TabIndex = 6;
                        this.BotonAcreditar.Text = "Acreditar";
                        this.BotonAcreditar.ToolTipText = "";
                        this.BotonAcreditar.Click += new System.EventHandler(this.BotonAcreditar_Click);
                        // 
                        // BotonPresentar
                        // 
                        this.BotonPresentar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonPresentar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonPresentar.Image = null;
                        this.BotonPresentar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonPresentar.Location = new System.Drawing.Point(12, 276);
                        this.BotonPresentar.Name = "BotonPresentar";
                        this.BotonPresentar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonPresentar.Size = new System.Drawing.Size(96, 29);
                        this.BotonPresentar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonPresentar.Subtext = "F3";
                        this.BotonPresentar.TabIndex = 5;
                        this.BotonPresentar.Text = "Presentar";
                        this.BotonPresentar.ToolTipText = "";
                        this.BotonPresentar.Click += new System.EventHandler(this.BotonPresentar_Click);
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(1284, 480);
                        this.Controls.Add(this.BotonPresentar);
                        this.Controls.Add(this.BotonAnular);
                        this.Controls.Add(this.BotonAcreditar);
                        this.Name = "Inicio";
                        this.Text = "Cobros con Cupón";
                        this.Controls.SetChildIndex(this.EtiquetaCantidad, 0);
                        this.Controls.SetChildIndex(this.BotonCrear, 0);
                        this.Controls.SetChildIndex(this.BotonCancelar, 0);
                        this.Controls.SetChildIndex(this.BotonFiltrar, 0);
                        this.Controls.SetChildIndex(this.BotonImprimir, 0);
                        this.Controls.SetChildIndex(this.BotonAcreditar, 0);
                        this.Controls.SetChildIndex(this.BotonAnular, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.BotonPresentar, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.Button BotonAcreditar;
                internal Lui.Forms.Button BotonPresentar;
                internal Lui.Forms.Button BotonAnular;
        }
}
