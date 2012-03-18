#region License
// Copyright 2004-2012 Ernesto N. Carrea
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lui.Forms
{
        public partial class MessageBox : Lui.Forms.Form
        {
                public MessageBox()
                {
                        this.DisplayStyle = Lazaro.Pres.DisplayStyles.Template.Current.White;
                        InitializeComponent();
                }


                public static void Show(string message, string caption)
                {
                        using (Lui.Forms.MessageBox FormMessageBox = new Lui.Forms.MessageBox()) {
                                FormMessageBox.Text = caption;
                                FormMessageBox.EtiquetaTitulo.Text = caption;
                                FormMessageBox.MessageText.Text = message;
                                FormMessageBox.ShowDialog();
                                FormMessageBox.Close();
                        }
                }


                private void OkButton_Click(object sender, EventArgs e)
                {
                        this.Close();
                }

                private void MessageBoxForm_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == true && e.KeyCode == Keys.C) {
                                System.Windows.Forms.Clipboard.SetData(System.Windows.Forms.DataFormats.StringFormat, MessageText.Text);
                                e.Handled = true;
                        } else if (e.Alt == false && e.Control == false && e.KeyCode == Keys.Escape) {
                                e.Handled = true;
                                this.Close();
                        }
                }


                protected override void OnResize(System.EventArgs e)
                {
                        base.OnResize(e);
                        if (this.Created) {
                                this.MessageText.MaximumSize = new Size(EtiquetaTitulo.Right - MessageText.Left, 0);
                                this.MessageText.AutoSize = true;
                                this.Height = this.MessageText.Bottom + this.LowerPanel.Height + 32 + (this.Height - this.ClientRectangle.Height);
                        }
                }


                protected override void OnLoad(System.EventArgs e)
                {
                        base.OnLoad(e);
                        this.Size = new Size(480, 320);
                        this.CenterToParent();
                }
        }
}