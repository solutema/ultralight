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

        public partial class InputBox : Lui.Forms.Form
        {
                private InputBox()
                {
                        InitializeComponent();
                }

                /// <summary>
                /// Ejecuta InputBox.
                /// </summary>
                /// <param name="prompt">Cadena de pregunta del InputBox.</param>
                /// <returns>Devuelve cadena introducida por el usuario si DialgoResult es OK.</returns>
                public static string ShowInputBox(string prompt)
                {
                        InputBox box = new InputBox();
                        box.Text = Application.ProductName;
                        box.EtiquetaInfo.Text = prompt;
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
                        box.EtiquetaInfo.Text = prompt;
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
                        box.EtiquetaInfo.Text = prompt;
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
