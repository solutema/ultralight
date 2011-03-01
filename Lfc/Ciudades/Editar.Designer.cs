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

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.EntradaCp = new Lui.Forms.TextBox();
                        this.EntradaParent = new Lcc.Entrada.CodigoDetalle();
                        this.EtiquetaParent = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.EntradaNivel = new Lui.Forms.ComboBox();
                        this.EntradaIva = new Lui.Forms.ComboBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(0, 0);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(120, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Nombre";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(0, 64);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(120, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Código Postal";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNombre.Location = new System.Drawing.Point(116, 0);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(670, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
                        // 
                        // EntradaCp
                        // 
                        this.EntradaCp.AutoNav = true;
                        this.EntradaCp.AutoTab = true;
                        this.EntradaCp.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCp.DecimalPlaces = -1;
                        this.EntradaCp.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCp.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCp.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCp.Location = new System.Drawing.Point(116, 64);
                        this.EntradaCp.MaxLenght = 32767;
                        this.EntradaCp.MultiLine = false;
                        this.EntradaCp.Name = "EntradaCp";
                        this.EntradaCp.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCp.PasswordChar = '\0';
                        this.EntradaCp.Prefijo = "";
                        this.EntradaCp.SelectOnFocus = false;
                        this.EntradaCp.Size = new System.Drawing.Size(172, 24);
                        this.EntradaCp.Sufijo = "";
                        this.EntradaCp.TabIndex = 5;
                        this.EntradaCp.TipWhenBlank = "";
                        this.EntradaCp.ToolTipText = "";
                        // 
                        // EntradaParent
                        // 
                        this.EntradaParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaParent.AutoNav = true;
                        this.EntradaParent.AutoTab = true;
                        this.EntradaParent.CanCreate = true;
                        this.EntradaParent.DataTextField = "nombre";
                        this.EntradaParent.ExtraDetailFields = null;
                        this.EntradaParent.Filter = "parent IS NULL";
                        this.EntradaParent.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaParent.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaParent.FreeTextCode = "";
                        this.EntradaParent.DataValueField = "id_ciudad";
                        this.EntradaParent.Location = new System.Drawing.Point(116, 96);
                        this.EntradaParent.MaxLength = 200;
                        this.EntradaParent.Name = "EntradaParent";
                        this.EntradaParent.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaParent.Required = false;
                        this.EntradaParent.Size = new System.Drawing.Size(670, 24);
                        this.EntradaParent.TabIndex = 7;
                        this.EntradaParent.Table = "ciudades";
                        this.EntradaParent.Text = "0";
                        this.EntradaParent.TextDetail = "";
                        this.EntradaParent.TipWhenBlank = "Ninguna";
                        this.EntradaParent.ToolTipText = "";
                        // 
                        // EtiquetaParent
                        // 
                        this.EtiquetaParent.Location = new System.Drawing.Point(0, 96);
                        this.EtiquetaParent.Name = "EtiquetaParent";
                        this.EtiquetaParent.Size = new System.Drawing.Size(120, 24);
                        this.EtiquetaParent.TabIndex = 6;
                        this.EtiquetaParent.Text = "Provincia";
                        this.EtiquetaParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(0, 32);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(120, 24);
                        this.label3.TabIndex = 2;
                        this.label3.Text = "Tipo";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNivel
                        // 
                        this.EntradaNivel.AutoNav = true;
                        this.EntradaNivel.AutoTab = true;
                        this.EntradaNivel.DetailField = null;
                        this.EntradaNivel.Filter = null;
                        this.EntradaNivel.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaNivel.KeyField = null;
                        this.EntradaNivel.Location = new System.Drawing.Point(116, 32);
                        this.EntradaNivel.MaxLenght = 32767;
                        this.EntradaNivel.Name = "EntradaNivel";
                        this.EntradaNivel.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNivel.SetData = new string[] {
        "Provincia|0",
        "Departamento|1",
        "Localidad|2"};
                        this.EntradaNivel.Size = new System.Drawing.Size(172, 24);
                        this.EntradaNivel.TabIndex = 3;
                        this.EntradaNivel.Table = null;
                        this.EntradaNivel.Text = "Provincia";
                        this.EntradaNivel.TextKey = "0";
                        this.EntradaNivel.TipWhenBlank = "";
                        this.EntradaNivel.ToolTipText = "";
                        this.EntradaNivel.TextChanged += new System.EventHandler(this.EntradaNivel_TextChanged);
                        // 
                        // EntradaIva
                        // 
                        this.EntradaIva.AutoNav = true;
                        this.EntradaIva.AutoTab = true;
                        this.EntradaIva.DetailField = null;
                        this.EntradaIva.Filter = null;
                        this.EntradaIva.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaIva.KeyField = null;
                        this.EntradaIva.Location = new System.Drawing.Point(116, 128);
                        this.EntradaIva.MaxLenght = 32767;
                        this.EntradaIva.Name = "EntradaIva";
                        this.EntradaIva.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaIva.SetData = new string[] {
        "Predeterminado|0",
        "Exento|1"};
                        this.EntradaIva.Size = new System.Drawing.Size(172, 24);
                        this.EntradaIva.TabIndex = 9;
                        this.EntradaIva.Table = null;
                        this.EntradaIva.TextKey = "0";
                        this.EntradaIva.ToolTipText = "";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(0, 128);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(120, 24);
                        this.label4.TabIndex = 8;
                        this.label4.Text = "IVA";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoSize = true;
                        this.Controls.Add(this.EntradaIva);
                        this.Controls.Add(this.EntradaNivel);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.EntradaParent);
                        this.Controls.Add(this.EntradaCp);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.EtiquetaParent);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.Label2);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(788, 157);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EtiquetaParent, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaCp, 0);
                        this.Controls.SetChildIndex(this.EntradaParent, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.EntradaNivel, 0);
                        this.Controls.SetChildIndex(this.EntradaIva, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }


                #endregion

                private System.Windows.Forms.Label Label1;
                private System.Windows.Forms.Label Label2;
                private Lui.Forms.TextBox EntradaNombre;
                private Lcc.Entrada.CodigoDetalle EntradaParent;
                private Label EtiquetaParent;
                private Label label3;
                private Lui.Forms.ComboBox EntradaNivel;
                private Lui.Forms.TextBox EntradaCp;
                private Lui.Forms.ComboBox EntradaIva;
                private Label label4;
        }
}
