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

namespace Lfc.Comprobantes
{
        public partial class Inicio
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.Frame = new Lui.Forms.Frame();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtTotal = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.txtPendiente = new Lui.Forms.TextBox();
                        this.Frame.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Frame
                        // 
                        this.Frame.AutoHeight = false;
                        this.Frame.Controls.Add(this.Label5);
                        this.Frame.Controls.Add(this.Label3);
                        this.Frame.Controls.Add(this.Label4);
                        this.Frame.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame.Location = new System.Drawing.Point(12, 120);
                        this.Frame.Name = "Frame";
                        this.Frame.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame.ReadOnly = false;
                        this.Frame.Size = new System.Drawing.Size(120, 76);
                        this.Frame.TabIndex = 53;
                        this.Frame.TabStop = false;
                        this.Frame.Text = "Referencia";
                        this.Frame.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label5.ForeColor = System.Drawing.Color.Maroon;
                        this.Label5.Location = new System.Drawing.Point(9, 48);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(89, 9);
                        this.Label5.TabIndex = 16;
                        this.Label5.Text = "Impago";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label3.ForeColor = System.Drawing.Color.Gray;
                        this.Label3.Location = new System.Drawing.Point(9, 24);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(89, 9);
                        this.Label3.TabIndex = 14;
                        this.Label3.Text = "No impreso";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label4.Location = new System.Drawing.Point(9, 36);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(89, 9);
                        this.Label4.TabIndex = 15;
                        this.Label4.Text = "Anulado";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTotal
                        // 
                        this.txtTotal.AutoHeight = false;
                        this.txtTotal.AutoNav = true;
                        this.txtTotal.AutoTab = true;
                        this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtTotal.DecimalPlaces = -1;
                        this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTotal.Location = new System.Drawing.Point(44, 68);
                        this.txtTotal.MaxLenght = 32767;
                        this.txtTotal.MultiLine = false;
                        this.txtTotal.Name = "txtTotal";
                        this.txtTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTotal.PasswordChar = '\0';
                        this.txtTotal.Prefijo = "";
                        this.txtTotal.ReadOnly = true;
                        this.txtTotal.SelectOnFocus = true;
                        this.txtTotal.Size = new System.Drawing.Size(92, 20);
                        this.txtTotal.Sufijo = "";
                        this.txtTotal.TabIndex = 3;
                        this.txtTotal.TabStop = false;
                        this.txtTotal.Text = "0.00";
                        this.txtTotal.TextRaw = "0.00";
                        this.txtTotal.TipWhenBlank = "";
                        this.txtTotal.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label2.Location = new System.Drawing.Point(8, 68);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(44, 20);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Total";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label6
                        // 
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.Location = new System.Drawing.Point(8, 92);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(44, 20);
                        this.Label6.TabIndex = 51;
                        this.Label6.Text = "Pend.";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPendiente
                        // 
                        this.txtPendiente.AutoHeight = false;
                        this.txtPendiente.AutoNav = true;
                        this.txtPendiente.AutoTab = true;
                        this.txtPendiente.DataType = Lui.Forms.DataTypes.Money;
                        this.txtPendiente.DecimalPlaces = -1;
                        this.txtPendiente.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPendiente.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPendiente.Location = new System.Drawing.Point(44, 92);
                        this.txtPendiente.MaxLenght = 32767;
                        this.txtPendiente.MultiLine = false;
                        this.txtPendiente.Name = "txtPendiente";
                        this.txtPendiente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPendiente.PasswordChar = '\0';
                        this.txtPendiente.Prefijo = "";
                        this.txtPendiente.ReadOnly = true;
                        this.txtPendiente.SelectOnFocus = true;
                        this.txtPendiente.Size = new System.Drawing.Size(92, 20);
                        this.txtPendiente.Sufijo = "";
                        this.txtPendiente.TabIndex = 52;
                        this.txtPendiente.TabStop = false;
                        this.txtPendiente.Text = "0.00";
                        this.txtPendiente.TextRaw = "0.00";
                        this.txtPendiente.TipWhenBlank = "";
                        this.txtPendiente.ToolTipText = "";
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(768, 480);
                        this.Controls.Add(this.txtPendiente);
                        this.Controls.Add(this.txtTotal);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Frame);
                        this.Name = "Inicio";
                        this.Text = "Comprobantes: Listado";
                        this.WorkspaceChanged += new System.EventHandler(this.FormComprobantesInicio_WorkspaceChanged);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.Frame, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.txtTotal, 0);
                        this.Controls.SetChildIndex(this.txtPendiente, 0);
                        this.Frame.ResumeLayout(false);
                        this.Frame.PerformLayout();
                        this.ResumeLayout(false);

                }
                #endregion

                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.TextBox txtTotal;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.TextBox txtPendiente;
                internal Lui.Forms.Frame Frame;
                
        }
}
