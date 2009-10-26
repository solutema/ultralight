// Copyright 2004-2009 South Bridge S.R.L.
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

using System;
using System.Windows.Forms;

// Código desarrollado por José Miguel Torres
// jtorres_diaz@terra.es
// Mayo 2004

namespace Lui.Forms
{
        /// <summary>
        /// Clase equivalente InputBox de Visual Basic.
        /// </summary>
        /// <remarks>Devuelve DialogResult.OK en Aceptar o Intro.
        /// Devuelve DialogResult.Cancel en Cancelar o Escape.</remarks>

        public class InputBox : System.Windows.Forms.Form
        {

                #region "Atributos"
                private System.Windows.Forms.Label lblInfo;
                private Button OkButton;
                private TextBox Texto;
                private Button CancelBtn;
                private System.ComponentModel.Container components = null;
                #endregion

                #region "Constructor/InitializeComponent/Dispose"
                private InputBox()
                {
                        InitializeComponent();
                }

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
                        this.lblInfo = new System.Windows.Forms.Label();
                        this.CancelBtn = new Lui.Forms.Button();
                        this.Texto = new Lui.Forms.TextBox();
                        this.OkButton = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // lblInfo
                        // 
                        this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblInfo.Location = new System.Drawing.Point(12, 16);
                        this.lblInfo.Name = "lblInfo";
                        this.lblInfo.Size = new System.Drawing.Size(342, 214);
                        this.lblInfo.TabIndex = 3;
                        // 
                        // CancelBtn
                        // 
                        this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelBtn.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.CancelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelBtn.Image = null;
                        this.CancelBtn.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelBtn.Location = new System.Drawing.Point(364, 56);
                        this.CancelBtn.Name = "CancelBtn";
                        this.CancelBtn.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelBtn.ReadOnly = false;
                        this.CancelBtn.Size = new System.Drawing.Size(96, 32);
                        this.CancelBtn.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.CancelBtn.Subtext = "Tecla";
                        this.CancelBtn.TabIndex = 2;
                        this.CancelBtn.Text = "Cancelar";
                        this.CancelBtn.ToolTipText = "";
                        this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
                        // 
                        // Texto
                        // 
                        this.Texto.AutoNav = false;
                        this.Texto.AutoTab = false;
                        this.Texto.DataType = Lui.Forms.DataTypes.FreeText;
                        this.Texto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.Texto.Location = new System.Drawing.Point(12, 240);
                        this.Texto.MaxLenght = 32767;
                        this.Texto.Name = "Texto";
                        this.Texto.Padding = new System.Windows.Forms.Padding(2);
                        this.Texto.ReadOnly = false;
                        this.Texto.Size = new System.Drawing.Size(452, 24);
                        this.Texto.TabIndex = 0;
                        this.Texto.TipWhenBlank = "";
                        this.Texto.ToolTipText = "";
                        this.Texto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Texto_KeyDown);
                        // 
                        // OkButton
                        // 
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.OkButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(364, 16);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(96, 32);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.OkButton.Subtext = "Tecla";
                        this.OkButton.TabIndex = 1;
                        this.OkButton.Text = "Aceptar";
                        this.OkButton.ToolTipText = "";
                        this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
                        // 
                        // InputBox
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(474, 274);
                        this.ControlBox = false;
                        this.Controls.Add(this.CancelBtn);
                        this.Controls.Add(this.Texto);
                        this.Controls.Add(this.OkButton);
                        this.Controls.Add(this.lblInfo);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "InputBox";
                        this.Text = "InputBox";
                        this.ResumeLayout(false);

                }

                #endregion

                /// <summary>
                /// Ejecuta InputBox.
                /// </summary>
                /// <param name="prompt">Cadena de pregunta del InputBox.</param>
                /// <returns>Devuelve cadena introducida por el usuario si DialgoResult es OK.</returns>
                public static string ShowInputBox(string prompt)
                {
                        InputBox box = new InputBox();
                        box.Text = Application.ProductName;
                        box.lblInfo.Text = prompt;
                        box.Texto.Text = "";
                        box.StartPosition = FormStartPosition.CenterScreen;
                        box.ShowDialog();

                        if (box.DialogResult.CompareTo(DialogResult.OK) == 0)
                                return box.Texto.Text;
                        else
                                return "";
                }

                /// <summary>
                /// Ejecuta InputBox.
                /// </summary>
                /// <param name="prompt">Cadena de pregunta del InputBox.</param>
                /// <param name="title">Titulo del InputBox.</param>
                /// <param name="defaultValue">Valor por defecto en la casilla de entra de texto.</param>
                /// <returns>Devuelve cadena introducida por el usuario si DialgoResult es OK.</returns>
                public static string ShowInputBox(string prompt, string title, string defaultValue)
                {
                        InputBox box = new InputBox();
                        box.Text = title;
                        box.lblInfo.Text = prompt;
                        box.Texto.Text = defaultValue;
                        box.StartPosition = FormStartPosition.CenterScreen;
                        box.ShowDialog();

                        if (box.DialogResult.CompareTo(DialogResult.OK) == 0)
                                return box.Texto.Text;
                        else
                                return "";
                }

                /// <summary>
                /// Ejecuta InputBox.
                /// </summary>
                /// <param name="prompt">Cadena de pregunta del InputBox.</param>
                /// <param name="title">Titulo del InputBox.</param>
                /// <param name="defaultValue">Valor por defecto en la casilla de entra de texto.</param>
                /// <param name="XPos">Posiciona el InputBox en la coordenada X horizontal.</param>
                /// <param name="YPos">Posiciona el InputBox en la coordenada Y vertical.</param>
                /// <returns>Devuelve cadena introducida por el usuario si DialgoResult es OK.</returns>
                public static string ShowInputBox(string prompt, string title, string defaultValue, int XPos, int YPos)
                {
                        InputBox box = new InputBox();
                        box.Text = title;
                        box.lblInfo.Text = prompt;
                        box.Texto.Text = defaultValue;
                        box.Location = new System.Drawing.Point(XPos, YPos);
                        box.ShowDialog();

                        if (box.DialogResult.CompareTo(DialogResult.OK) == 0)
                                return box.Texto.Text;
                        else
                                return "";
                }

                private void OkButton_Click(object sender, EventArgs e)
                {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                }

                private void CancelBtn_Click(object sender, EventArgs e)
                {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                }

                private void Texto_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Enter) {
                                e.Handled = true;
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                        } else if (e.KeyCode == Keys.Escape) {
                                e.Handled = true;
                                this.DialogResult = DialogResult.Cancel;
                                this.Close();
                        }
                }
       }
}