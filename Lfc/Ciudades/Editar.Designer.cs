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

using System.Windows.Forms;

namespace Lfc.Ciudades
{
        public partial class Editar
        {
                #region Windows Form Designer generated code

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                private System.ComponentModel.Container components = null;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.EntradaCp = new Lui.Forms.TextBox();
                        this.EntradaParent = new Lui.Forms.DetailBox();
                        this.EtiquetaParent = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.EntradaNivel = new Lui.Forms.ComboBox();
                        this.EntradaTags = new Lui.Forms.FieldTags();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(376, 10);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(484, 10);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(24, 28);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(116, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Nombre";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(24, 92);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(116, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Código Postal";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoHeight = false;
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNombre.Location = new System.Drawing.Point(140, 28);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(432, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TextRaw = "";
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
                        // 
                        // EntradaCp
                        // 
                        this.EntradaCp.AutoHeight = false;
                        this.EntradaCp.AutoNav = true;
                        this.EntradaCp.AutoTab = true;
                        this.EntradaCp.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCp.DecimalPlaces = -1;
                        this.EntradaCp.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCp.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCp.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCp.Location = new System.Drawing.Point(140, 92);
                        this.EntradaCp.MaxLenght = 32767;
                        this.EntradaCp.MultiLine = false;
                        this.EntradaCp.Name = "EntradaCp";
                        this.EntradaCp.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCp.PasswordChar = '\0';
                        this.EntradaCp.Prefijo = "";
                        this.EntradaCp.ReadOnly = false;
                        this.EntradaCp.SelectOnFocus = false;
                        this.EntradaCp.Size = new System.Drawing.Size(128, 24);
                        this.EntradaCp.Sufijo = "";
                        this.EntradaCp.TabIndex = 5;
                        this.EntradaCp.TextRaw = "";
                        this.EntradaCp.TipWhenBlank = "";
                        this.EntradaCp.ToolTipText = "";
                        // 
                        // EntradaParent
                        // 
                        this.EntradaParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaParent.AutoHeight = false;
                        this.EntradaParent.AutoTab = true;
                        this.EntradaParent.CanCreate = true;
                        this.EntradaParent.DetailField = "nombre";
                        this.EntradaParent.ExtraDetailFields = null;
                        this.EntradaParent.Filter = "parent IS NULL";
                        this.EntradaParent.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaParent.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaParent.FreeTextCode = "";
                        this.EntradaParent.KeyField = "id_ciudad";
                        this.EntradaParent.Location = new System.Drawing.Point(140, 124);
                        this.EntradaParent.MaxLength = 200;
                        this.EntradaParent.Name = "EntradaParent";
                        this.EntradaParent.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaParent.ReadOnly = false;
                        this.EntradaParent.Required = false;
                        this.EntradaParent.SelectOnFocus = false;
                        this.EntradaParent.Size = new System.Drawing.Size(432, 24);
                        this.EntradaParent.TabIndex = 7;
                        this.EntradaParent.Table = "ciudades";
                        this.EntradaParent.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaParent.Text = "0";
                        this.EntradaParent.TextDetail = "";
                        this.EntradaParent.TextInt = 0;
                        this.EntradaParent.TipWhenBlank = "Ninguna";
                        this.EntradaParent.ToolTipText = "";
                        // 
                        // EtiquetaParent
                        // 
                        this.EtiquetaParent.Location = new System.Drawing.Point(24, 124);
                        this.EtiquetaParent.Name = "EtiquetaParent";
                        this.EtiquetaParent.Size = new System.Drawing.Size(116, 24);
                        this.EtiquetaParent.TabIndex = 6;
                        this.EtiquetaParent.Text = "Provincia";
                        this.EtiquetaParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(24, 60);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(116, 24);
                        this.label3.TabIndex = 2;
                        this.label3.Text = "Tipo";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNivel
                        // 
                        this.EntradaNivel.AutoHeight = false;
                        this.EntradaNivel.AutoNav = true;
                        this.EntradaNivel.AutoTab = true;
                        this.EntradaNivel.DetailField = null;
                        this.EntradaNivel.Filter = null;
                        this.EntradaNivel.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaNivel.KeyField = null;
                        this.EntradaNivel.Location = new System.Drawing.Point(140, 60);
                        this.EntradaNivel.MaxLenght = 32767;
                        this.EntradaNivel.Name = "EntradaNivel";
                        this.EntradaNivel.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNivel.ReadOnly = false;
                        this.EntradaNivel.SetData = new string[] {
        "Provincia|0",
        "Departamento|1",
        "Localidad|2"};
                        this.EntradaNivel.Size = new System.Drawing.Size(172, 24);
                        this.EntradaNivel.TabIndex = 3;
                        this.EntradaNivel.Table = null;
                        this.EntradaNivel.Text = "Provincia";
                        this.EntradaNivel.TextKey = "0";
                        this.EntradaNivel.TextRaw = "Provincia";
                        this.EntradaNivel.TipWhenBlank = "";
                        this.EntradaNivel.ToolTipText = "";
                        this.EntradaNivel.TextChanged += new System.EventHandler(this.EntradaNivel_TextChanged);
                        // 
                        // EntradaTags
                        // 
                        this.EntradaTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaTags.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaTags.Location = new System.Drawing.Point(24, 160);
                        this.EntradaTags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaTags.Name = "EntradaTags";
                        this.EntradaTags.Size = new System.Drawing.Size(548, 136);
                        this.EntradaTags.TabIndex = 104;
                        this.EntradaTags.Text = "Atributos especiales";
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(592, 373);
                        this.Controls.Add(this.EntradaTags);
                        this.Controls.Add(this.EntradaNivel);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.EntradaParent);
                        this.Controls.Add(this.EntradaCp);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.EtiquetaParent);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.Label2);
                        this.Name = "Editar";
                        this.Text = "Editar: Ciudades";
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EtiquetaParent, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.EntradaCp, 0);
                        this.Controls.SetChildIndex(this.EntradaParent, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.EntradaNivel, 0);
                        this.Controls.SetChildIndex(this.EntradaTags, 0);
                        this.ResumeLayout(false);

                }


                #endregion

                private System.Windows.Forms.Label Label1;
                private System.Windows.Forms.Label Label2;
                private Lui.Forms.TextBox EntradaNombre;
                private Lui.Forms.DetailBox EntradaParent;
                private Label EtiquetaParent;
                private Label label3;
                private Lui.Forms.ComboBox EntradaNivel;
                private Lui.Forms.FieldTags EntradaTags;
                private Lui.Forms.TextBox EntradaCp;
        }
}
