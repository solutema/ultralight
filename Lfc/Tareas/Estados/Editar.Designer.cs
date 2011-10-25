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
using System.Collections.Generic;
using System.Text;

namespace Lfc.Tareas.Estados
{
        public partial class Editar
        {
		private System.ComponentModel.IContainer components = null;

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                #region Designer generated code

                private void InitializeComponent()
                {
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label13 = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.Location = new System.Drawing.Point(116, 0);
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PlaceholderText = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(524, 24);
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.ToolTipText = "";
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
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.Location = new System.Drawing.Point(116, 28);
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PlaceholderText = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(524, 72);
                        this.EntradaObs.TabIndex = 3;
                        this.EntradaObs.ToolTipText = "Descripción larga";
                        // 
                        // Label13
                        // 
                        this.Label13.Location = new System.Drawing.Point(0, 28);
                        this.Label13.Name = "Label13";
                        this.Label13.Size = new System.Drawing.Size(116, 24);
                        this.Label13.TabIndex = 2;
                        this.Label13.Text = "Observaciones";
                        this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.Label13);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label1);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 400);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.Label13, 0);
                        this.Controls.SetChildIndex(this.EntradaObs, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                private Lui.Forms.TextBox EntradaNombre;
                private Lui.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.Label Label13;

        }
}
