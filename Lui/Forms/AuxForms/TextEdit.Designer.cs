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

			txtText.MenuItemEditor.Visible = false;
		}

		internal Lui.Forms.Button cmdAceptar;
		public Lui.Forms.TextBox txtText;
		internal Lui.Forms.Button cmdCancelar;

		private void InitializeComponent()
		{
                        this.txtText = new Lui.Forms.TextBox();
                        this.cmdAceptar = new Lui.Forms.Button();
                        this.cmdCancelar = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // txtText
                        // 
                        this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtText.AutoNav = false;
                        this.txtText.AutoTab = true;
                        this.txtText.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtText.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtText.Location = new System.Drawing.Point(4, 4);
                        this.txtText.MaxLenght = 32767;
                        this.txtText.MultiLine = true;
                        this.txtText.Name = "txtText";
                        this.txtText.Padding = new System.Windows.Forms.Padding(1);
                        this.txtText.ReadOnly = false;
                        this.txtText.SelectOnFocus = false;
                        this.txtText.Size = new System.Drawing.Size(456, 199);
                        this.txtText.TabIndex = 0;
                        this.txtText.TipWhenBlank = "";
                        this.txtText.ToolTipText = "";
                        // 
                        // cmdAceptar
                        // 
                        this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdAceptar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdAceptar.Image = null;
                        this.cmdAceptar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdAceptar.Location = new System.Drawing.Point(252, 211);
                        this.cmdAceptar.Name = "cmdAceptar";
                        this.cmdAceptar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdAceptar.ReadOnly = false;
                        this.cmdAceptar.Size = new System.Drawing.Size(96, 44);
                        this.cmdAceptar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdAceptar.Subtext = "F9";
                        this.cmdAceptar.TabIndex = 1;
                        this.cmdAceptar.Text = "Aceptar";
                        this.cmdAceptar.ToolTipText = "";
                        this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
                        // 
                        // cmdCancelar
                        // 
                        this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdCancelar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdCancelar.Image = null;
                        this.cmdCancelar.ImagePos = Lui.Forms.ImagePositions.Middle;
                        this.cmdCancelar.Location = new System.Drawing.Point(356, 211);
                        this.cmdCancelar.Name = "cmdCancelar";
                        this.cmdCancelar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdCancelar.ReadOnly = false;
                        this.cmdCancelar.Size = new System.Drawing.Size(96, 44);
                        this.cmdCancelar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdCancelar.Subtext = "Esc";
                        this.cmdCancelar.TabIndex = 2;
                        this.cmdCancelar.Text = "Cancelar";
                        this.cmdCancelar.ToolTipText = "";
                        this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
                        // 
                        // TextEdit
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
                        this.ClientSize = new System.Drawing.Size(464, 264);
                        this.ControlBox = false;
                        this.Controls.Add(this.cmdCancelar);
                        this.Controls.Add(this.cmdAceptar);
                        this.Controls.Add(this.txtText);
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
