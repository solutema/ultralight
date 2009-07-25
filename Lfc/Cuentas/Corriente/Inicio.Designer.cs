// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Cuentas.Corriente
{
        public partial class Inicio : Lui.Forms.AccountForm
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.cmdNotaDeb = new Lui.Forms.Button();
                        this.cmdNotaCred = new Lui.Forms.Button();
                        this.cmdAjuste = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // ItemList
                        // 
                        this.ItemList.Location = new System.Drawing.Point(208, 0);
                        this.ItemList.Size = new System.Drawing.Size(484, 476);
                        // 
                        // cmdNotaDeb
                        // 
                        this.cmdNotaDeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdNotaDeb.AutoHeight = false;
                        this.cmdNotaDeb.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdNotaDeb.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdNotaDeb.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdNotaDeb.Image = null;
                        this.cmdNotaDeb.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdNotaDeb.Location = new System.Drawing.Point(12, 304);
                        this.cmdNotaDeb.Name = "cmdNotaDeb";
                        this.cmdNotaDeb.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdNotaDeb.ReadOnly = false;
                        this.cmdNotaDeb.Size = new System.Drawing.Size(108, 32);
                        this.cmdNotaDeb.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdNotaDeb.Subtext = "F4";
                        this.cmdNotaDeb.TabIndex = 61;
                        this.cmdNotaDeb.Text = "Nota Déb";
                        this.cmdNotaDeb.ToolTipText = "";
                        this.cmdNotaDeb.Click += new System.EventHandler(this.cmdNotaDeb_Click);
                        // 
                        // cmdNotaCred
                        // 
                        this.cmdNotaCred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdNotaCred.AutoHeight = false;
                        this.cmdNotaCred.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdNotaCred.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdNotaCred.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdNotaCred.Image = null;
                        this.cmdNotaCred.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdNotaCred.Location = new System.Drawing.Point(12, 264);
                        this.cmdNotaCred.Name = "cmdNotaCred";
                        this.cmdNotaCred.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdNotaCred.ReadOnly = false;
                        this.cmdNotaCred.Size = new System.Drawing.Size(108, 32);
                        this.cmdNotaCred.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdNotaCred.Subtext = "F3";
                        this.cmdNotaCred.TabIndex = 60;
                        this.cmdNotaCred.Text = "Nota Créd";
                        this.cmdNotaCred.ToolTipText = "";
                        this.cmdNotaCred.Click += new System.EventHandler(this.cmdNotaCred_Click);
                        // 
                        // cmdAjuste
                        // 
                        this.cmdAjuste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdAjuste.AutoHeight = false;
                        this.cmdAjuste.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdAjuste.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdAjuste.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdAjuste.Image = null;
                        this.cmdAjuste.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdAjuste.Location = new System.Drawing.Point(12, 344);
                        this.cmdAjuste.Name = "cmdAjuste";
                        this.cmdAjuste.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdAjuste.ReadOnly = false;
                        this.cmdAjuste.Size = new System.Drawing.Size(108, 32);
                        this.cmdAjuste.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdAjuste.Subtext = "F5";
                        this.cmdAjuste.TabIndex = 62;
                        this.cmdAjuste.Text = "Ajuste";
                        this.cmdAjuste.ToolTipText = "";
                        this.cmdAjuste.Click += new System.EventHandler(this.cmdAjuste_Click);
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.cmdNotaDeb);
                        this.Controls.Add(this.cmdNotaCred);
                        this.Controls.Add(this.cmdAjuste);
                        this.Name = "Inicio";
                        this.Text = "Cuenta Corriente";
                        this.WorkspaceChanged += new System.EventHandler(this.FormCuentaCorriente_WorkspaceChanged);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCuentaCorriente_KeyDown);
                        this.Controls.SetChildIndex(this.EtiquetaIngresos, 0);
                        this.Controls.SetChildIndex(this.EtiquetaEgresos, 0);
                        this.Controls.SetChildIndex(this.EtiquetaSaldo, 0);
                        this.Controls.SetChildIndex(this.EtiquetaTransporte, 0);
                        this.Controls.SetChildIndex(this.EtiquetaTitulo, 0);
                        this.Controls.SetChildIndex(this.ItemList, 0);
                        this.Controls.SetChildIndex(this.cmdAjuste, 0);
                        this.Controls.SetChildIndex(this.cmdNotaCred, 0);
                        this.Controls.SetChildIndex(this.cmdNotaDeb, 0);
                        this.ResumeLayout(false);

                }

                #endregion
                
                internal Lui.Forms.Button cmdNotaDeb;
                internal Lui.Forms.Button cmdNotaCred;
                internal Lui.Forms.Button cmdAjuste;
        }
}