#region License
// Copyright 2004-2010 South Bridge S.R.L.
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
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.EntradaPendiente = new Lui.Forms.TextBox();
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
                        // EntradaTotal
                        // 
                        this.EntradaTotal.AutoHeight = false;
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTotal.Location = new System.Drawing.Point(44, 68);
                        this.EntradaTotal.MaxLenght = 32767;
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.Prefijo = "";
                        this.EntradaTotal.ReadOnly = true;
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(92, 20);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 3;
                        this.EntradaTotal.TabStop = false;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TextRaw = "0.00";
                        this.EntradaTotal.TipWhenBlank = "";
                        this.EntradaTotal.ToolTipText = "";
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
                        this.EntradaPendiente.AutoHeight = false;
                        this.EntradaPendiente.AutoNav = true;
                        this.EntradaPendiente.AutoTab = true;
                        this.EntradaPendiente.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaPendiente.DecimalPlaces = -1;
                        this.EntradaPendiente.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPendiente.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPendiente.Location = new System.Drawing.Point(44, 92);
                        this.EntradaPendiente.MaxLenght = 32767;
                        this.EntradaPendiente.MultiLine = false;
                        this.EntradaPendiente.Name = "txtPendiente";
                        this.EntradaPendiente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPendiente.PasswordChar = '\0';
                        this.EntradaPendiente.Prefijo = "";
                        this.EntradaPendiente.ReadOnly = true;
                        this.EntradaPendiente.SelectOnFocus = true;
                        this.EntradaPendiente.Size = new System.Drawing.Size(92, 20);
                        this.EntradaPendiente.Sufijo = "";
                        this.EntradaPendiente.TabIndex = 52;
                        this.EntradaPendiente.TabStop = false;
                        this.EntradaPendiente.Text = "0.00";
                        this.EntradaPendiente.TextRaw = "0.00";
                        this.EntradaPendiente.TipWhenBlank = "";
                        this.EntradaPendiente.ToolTipText = "";
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(768, 480);
                        this.Controls.Add(this.EntradaPendiente);
                        this.Controls.Add(this.EntradaTotal);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Frame);
                        this.Name = "Inicio";
                        this.Text = "Comprobantes: Listado";
                        this.WorkspaceChanged += new System.EventHandler(this.FormComprobantesInicio_WorkspaceChanged);
                        this.Frame.ResumeLayout(false);
                        this.Frame.PerformLayout();
                        this.ResumeLayout(false);

                }
                #endregion

                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.TextBox EntradaTotal;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.TextBox EntradaPendiente;
                internal Lui.Forms.Frame Frame;
                
        }
}
