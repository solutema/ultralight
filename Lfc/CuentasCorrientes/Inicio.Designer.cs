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

namespace Lfc.CuentasCorrientes
{
        public partial class Inicio
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.BotonNotaDeb = new Lui.Forms.Button();
                        this.BotonNotaCred = new Lui.Forms.Button();
                        this.BotonAjuste = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // BotonNotaDeb
                        // 
                        this.BotonNotaDeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonNotaDeb.AutoSize = false;
                        this.BotonNotaDeb.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonNotaDeb.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonNotaDeb.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonNotaDeb.Image = null;
                        this.BotonNotaDeb.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonNotaDeb.Location = new System.Drawing.Point(12, 272);
                        this.BotonNotaDeb.Name = "BotonNotaDeb";
                        this.BotonNotaDeb.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonNotaDeb.TemporaryReadOnly = false;
                        this.BotonNotaDeb.Size = new System.Drawing.Size(96, 29);
                        this.BotonNotaDeb.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonNotaDeb.Subtext = "F4";
                        this.BotonNotaDeb.TabIndex = 61;
                        this.BotonNotaDeb.Text = "Nota Déb";
                        this.BotonNotaDeb.ToolTipText = "";
                        this.BotonNotaDeb.Click += new System.EventHandler(this.BotonNotaDeb_Click);
                        // 
                        // BotonNotaCred
                        // 
                        this.BotonNotaCred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonNotaCred.AutoSize = false;
                        this.BotonNotaCred.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonNotaCred.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonNotaCred.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonNotaCred.Image = null;
                        this.BotonNotaCred.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonNotaCred.Location = new System.Drawing.Point(120, 236);
                        this.BotonNotaCred.Name = "BotonNotaCred";
                        this.BotonNotaCred.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonNotaCred.TemporaryReadOnly = false;
                        this.BotonNotaCred.Size = new System.Drawing.Size(96, 29);
                        this.BotonNotaCred.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonNotaCred.Subtext = "F3";
                        this.BotonNotaCred.TabIndex = 60;
                        this.BotonNotaCred.Text = "Nota Créd";
                        this.BotonNotaCred.ToolTipText = "";
                        this.BotonNotaCred.Click += new System.EventHandler(this.BotonNotaCred_Click);
                        // 
                        // BotonAjuste
                        // 
                        this.BotonAjuste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAjuste.AutoSize = false;
                        this.BotonAjuste.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAjuste.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonAjuste.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAjuste.Image = null;
                        this.BotonAjuste.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAjuste.Location = new System.Drawing.Point(120, 272);
                        this.BotonAjuste.Name = "BotonAjuste";
                        this.BotonAjuste.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAjuste.TemporaryReadOnly = false;
                        this.BotonAjuste.Size = new System.Drawing.Size(96, 29);
                        this.BotonAjuste.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonAjuste.Subtext = "F5";
                        this.BotonAjuste.TabIndex = 62;
                        this.BotonAjuste.Text = "Ajuste";
                        this.BotonAjuste.ToolTipText = "";
                        this.BotonAjuste.Click += new System.EventHandler(this.BotonAjuste_Click);
                        // 
                        // Inicio
                        // 
                        this.Controls.Add(this.BotonNotaDeb);
                        this.Controls.Add(this.BotonNotaCred);
                        this.Controls.Add(this.BotonAjuste);
                        this.Name = "Inicio";
                        this.Text = "Cuenta Corriente";
                        this.Controls.SetChildIndex(this.BotonCancelar, 0);
                        this.Controls.SetChildIndex(this.BotonFiltrar, 0);
                        this.Controls.SetChildIndex(this.BotonImprimir, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.BotonAjuste, 0);
                        this.Controls.SetChildIndex(this.BotonNotaCred, 0);
                        this.Controls.SetChildIndex(this.BotonNotaDeb, 0);
                        this.ResumeLayout(false);

                }

                #endregion
                
                internal Lui.Forms.Button BotonNotaDeb;
                internal Lui.Forms.Button BotonNotaCred;
                internal Lui.Forms.Button BotonAjuste;
        }
}