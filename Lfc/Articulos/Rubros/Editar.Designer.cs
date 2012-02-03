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
using System.Text;

namespace Lfc.Articulos.Rubros
{
        public partial class Editar
        {
                internal Lui.Forms.Label label9;
                internal Lui.Forms.TextBox EntradaNombre;
                internal Lui.Forms.Label Label5;
                private Lcc.Entrada.CodigoDetalle EntradaAlicuota;

                #region Código generado por el diseñador

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

                private void InitializeComponent()
                {
                        this.label9 = new Lui.Forms.Label();
                        this.EntradaAlicuota = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label5 = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // label9
                        // 
                        this.label9.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label9.Location = new System.Drawing.Point(0, 32);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(116, 24);
                        this.label9.TabIndex = 2;
                        this.label9.Text = "Alícuota";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAlicuota
                        // 
                        this.EntradaAlicuota.CanCreate = true;
                        this.EntradaAlicuota.DataTextField = "nombre";
                        this.EntradaAlicuota.DataValueField = "id_alicuota";
                        this.EntradaAlicuota.ExtraDetailFields = "";
                        this.EntradaAlicuota.Filter = "";
                        this.EntradaAlicuota.FreeTextCode = "";
                        this.EntradaAlicuota.Location = new System.Drawing.Point(116, 32);
                        this.EntradaAlicuota.MaxLength = 200;
                        this.EntradaAlicuota.Name = "EntradaAlicuota";
                        this.EntradaAlicuota.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAlicuota.PlaceholderText = "Sin especificar";
                        this.EntradaAlicuota.ReadOnly = false;
                        this.EntradaAlicuota.Required = true;
                        this.EntradaAlicuota.Size = new System.Drawing.Size(388, 24);
                        this.EntradaAlicuota.TabIndex = 3;
                        this.EntradaAlicuota.Table = "alicuotas";
                        this.EntradaAlicuota.Text = "0";
                        this.EntradaAlicuota.TextDetail = "";
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaNombre.Location = new System.Drawing.Point(116, 0);
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(388, 24);
                        this.EntradaNombre.TabIndex = 1;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(0, 0);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(116, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.EntradaAlicuota);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label5);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(488, 237);
                        this.ResumeLayout(false);

                }

                #endregion
        }
}
