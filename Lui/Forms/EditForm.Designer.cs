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

namespace Lui.Forms
{
        partial class EditForm
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
                        this.SaveButton = new Lui.Forms.Button();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.LowerPanel = new System.Windows.Forms.Panel();
                        this.LowerPanel.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.SaveButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.SaveButton.Image = null;
                        this.SaveButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.SaveButton.Location = new System.Drawing.Point(468, 10);
                        this.SaveButton.Name = "SaveButton";
                        this.SaveButton.Padding = new System.Windows.Forms.Padding(2);
                        this.SaveButton.ReadOnly = false;
                        this.SaveButton.Size = new System.Drawing.Size(104, 44);
                        this.SaveButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.SaveButton.Subtext = "F9";
                        this.SaveButton.TabIndex = 101;
                        this.SaveButton.Text = "Guardar";
                        this.SaveButton.ToolTipText = "";
                        this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(580, 10);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(104, 44);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.CancelCommandButton.Subtext = "Esc";
                        this.CancelCommandButton.TabIndex = 102;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.ToolTipText = "";
                        this.CancelCommandButton.Click += new System.EventHandler(this.cmdCancelar_Click);
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Controls.Add(this.SaveButton);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 413);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(692, 60);
                        this.LowerPanel.TabIndex = 103;
                        // 
                        // EditForm
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.Controls.Add(this.LowerPanel);
                        this.KeyPreview = true;
                        this.Name = "EditForm";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Editar";
                        this.SizeChanged += new System.EventHandler(this.EditForm_SizeChanged);
                        this.Closing += new System.ComponentModel.CancelEventHandler(this.FormTablaEditar_Closing);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTablaEditar_KeyDown);
                        this.Load += new System.EventHandler(this.FormTablaEditar_Load);
                        this.LowerPanel.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                public Lui.Forms.Button SaveButton;
                public Lui.Forms.Button CancelCommandButton;
                internal System.Windows.Forms.Panel LowerPanel;

                #endregion
        }
}