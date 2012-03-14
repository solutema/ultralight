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

namespace Lui.Forms.AuxForms
{
	partial class TextEdit
	{
		#region Código generado por el Diseñador de Windows Forms

		private void InitializeComponent()
		{
                        this.EntradaTexto = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // EntradaTexto
                        // 
                        this.EntradaTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTexto.Location = new System.Drawing.Point(24, 24);
                        this.EntradaTexto.MultiLine = true;
                        this.EntradaTexto.Name = "EntradaTexto";
                        this.EntradaTexto.Size = new System.Drawing.Size(576, 248);
                        this.EntradaTexto.TabIndex = 0;
                        // 
                        // TextEdit
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(624, 362);
                        this.Controls.Add(this.EntradaTexto);
                        this.ForeColor = System.Drawing.Color.Black;
                        this.Name = "TextEdit";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Editor extendido";
                        this.Controls.SetChildIndex(this.EntradaTexto, 0);
                        this.ResumeLayout(false);

		}

                protected Lui.Forms.TextBox EntradaTexto;

		#endregion
	}
}
