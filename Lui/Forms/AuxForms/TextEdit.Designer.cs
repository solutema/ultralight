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

namespace Lui.Forms.AuxForms
{
	partial class TextEdit
	{
		#region Código generado por el Diseñador de Windows Forms

		public TextEdit()
			: base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			EntradaTexto.MenuItemEditor.Visible = false;
		}

		internal Lui.Forms.Button BotonAceptar;
		public Lui.Forms.TextBox EntradaTexto;
		internal Lui.Forms.Button BotonCancelar;

		private void InitializeComponent()
		{
                        this.EntradaTexto = new Lui.Forms.TextBox();
                        this.BotonAceptar = new Lui.Forms.Button();
                        this.BotonCancelar = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // txtText
                        // 
                        this.EntradaTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTexto.AutoNav = false;
                        this.EntradaTexto.AutoTab = true;
                        this.EntradaTexto.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaTexto.Location = new System.Drawing.Point(4, 4);
                        this.EntradaTexto.MultiLine = true;
                        this.EntradaTexto.Name = "txtText";
                        this.EntradaTexto.Padding = new System.Windows.Forms.Padding(1);
                        this.EntradaTexto.SelectOnFocus = false;
                        this.EntradaTexto.Size = new System.Drawing.Size(456, 199);
                        this.EntradaTexto.TabIndex = 0;
                        this.EntradaTexto.PlaceholderText = "";
                        this.EntradaTexto.ToolTipText = "";
                        // 
                        // BotonAceptar
                        // 
                        this.BotonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAceptar.Image = null;
                        this.BotonAceptar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAceptar.Location = new System.Drawing.Point(252, 211);
                        this.BotonAceptar.Name = "BotonAceptar";
                        this.BotonAceptar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAceptar.Size = new System.Drawing.Size(96, 44);
                        this.BotonAceptar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonAceptar.Subtext = "F9";
                        this.BotonAceptar.TabIndex = 1;
                        this.BotonAceptar.Text = "Aceptar";
                        this.BotonAceptar.ToolTipText = "";
                        this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
                        // 
                        // BotonCancelar
                        // 
                        this.BotonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCancelar.Image = null;
                        this.BotonCancelar.ImagePos = Lui.Forms.ImagePositions.Middle;
                        this.BotonCancelar.Location = new System.Drawing.Point(356, 211);
                        this.BotonCancelar.Name = "BotonCancelar";
                        this.BotonCancelar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCancelar.Size = new System.Drawing.Size(96, 44);
                        this.BotonCancelar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonCancelar.Subtext = "Esc";
                        this.BotonCancelar.TabIndex = 2;
                        this.BotonCancelar.Text = "Cancelar";
                        this.BotonCancelar.ToolTipText = "";
                        this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // TextEdit
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
                        this.ClientSize = new System.Drawing.Size(464, 264);
                        this.ControlBox = false;
                        this.Controls.Add(this.BotonCancelar);
                        this.Controls.Add(this.BotonAceptar);
                        this.Controls.Add(this.EntradaTexto);
                        this.KeyPreview = true;
                        this.Name = "TextEdit";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Editor Extendido";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_KeyDown);
                        this.ResumeLayout(false);

		}

		#endregion
	}
}
