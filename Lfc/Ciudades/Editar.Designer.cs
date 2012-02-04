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
                        this.Label1 = new Lui.Forms.Label();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.EntradaCp = new Lui.Forms.TextBox();
                        this.EntradaParent = new Lcc.Entrada.CodigoDetalle();
                        this.EtiquetaParent = new Lui.Forms.Label();
                        this.label3 = new Lui.Forms.Label();
                        this.EntradaNivel = new Lui.Forms.ComboBox();
                        this.EntradaIva = new Lui.Forms.ComboBox();
                        this.label4 = new Lui.Forms.Label();
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
                        this.Label2.Location = new System.Drawing.Point(0, 76);
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
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaNombre.Location = new System.Drawing.Point(116, 0);
                        this.EntradaNombre.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.Size = new System.Drawing.Size(262, 24);
                        this.EntradaNombre.TabIndex = 1;
                        // 
                        // EntradaCp
                        // 
                        this.EntradaCp.Location = new System.Drawing.Point(116, 76);
                        this.EntradaCp.Name = "EntradaCp";
                        this.EntradaCp.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCp.Size = new System.Drawing.Size(172, 24);
                        this.EntradaCp.TabIndex = 5;
                        // 
                        // EntradaParent
                        // 
                        this.EntradaParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaParent.AutoTab = true;
                        this.EntradaParent.CanCreate = true;
                        this.EntradaParent.DataTextField = "nombre";
                        this.EntradaParent.DataValueField = "id_ciudad";
                        this.EntradaParent.ExtraDetailFields = "";
                        this.EntradaParent.Filter = "id_provincia IS NULL";
                        this.EntradaParent.FreeTextCode = "";
                        this.EntradaParent.Location = new System.Drawing.Point(116, 108);
                        this.EntradaParent.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaParent.MaxLength = 200;
                        this.EntradaParent.Name = "EntradaParent";
                        this.EntradaParent.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaParent.PlaceholderText = "Ninguna";
                        this.EntradaParent.Required = false;
                        this.EntradaParent.Size = new System.Drawing.Size(262, 24);
                        this.EntradaParent.TabIndex = 7;
                        this.EntradaParent.Table = "ciudades";
                        this.EntradaParent.Text = "0";
                        this.EntradaParent.TextDetail = "";
                        // 
                        // EtiquetaParent
                        // 
                        this.EtiquetaParent.Location = new System.Drawing.Point(0, 108);
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
                        this.EntradaNivel.AlwaysExpanded = true;
                        this.EntradaNivel.AutoSize = true;
                        this.EntradaNivel.Location = new System.Drawing.Point(116, 32);
                        this.EntradaNivel.Name = "EntradaNivel";
                        this.EntradaNivel.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNivel.SetData = new string[] {
        "Provincia|0",
        "Localidad|2"};
                        this.EntradaNivel.Size = new System.Drawing.Size(172, 40);
                        this.EntradaNivel.TabIndex = 3;
                        this.EntradaNivel.TextKey = "2";
                        this.EntradaNivel.TextChanged += new System.EventHandler(this.EntradaNivel_TextChanged);
                        // 
                        // EntradaIva
                        // 
                        this.EntradaIva.AlwaysExpanded = true;
                        this.EntradaIva.AutoSize = true;
                        this.EntradaIva.Location = new System.Drawing.Point(116, 140);
                        this.EntradaIva.Name = "EntradaIva";
                        this.EntradaIva.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaIva.SetData = new string[] {
        "Predeterminado|0",
        "Exento|1"};
                        this.EntradaIva.Size = new System.Drawing.Size(172, 40);
                        this.EntradaIva.TabIndex = 9;
                        this.EntradaIva.TextKey = "0";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(0, 140);
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
                        this.MinimumSize = new System.Drawing.Size(380, 180);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(380, 185);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }


                #endregion

                private Lui.Forms.Label Label1;
                private Lui.Forms.Label Label2;
                private Lui.Forms.TextBox EntradaNombre;
                private Lcc.Entrada.CodigoDetalle EntradaParent;
                private Lui.Forms.ComboBox EntradaNivel;
                private Lui.Forms.TextBox EntradaCp;
                private Lui.Forms.ComboBox EntradaIva;
                private Lui.Forms.Label EtiquetaParent;
                private Lui.Forms.Label label3;
                private Lui.Forms.Label label4;
        }
}
