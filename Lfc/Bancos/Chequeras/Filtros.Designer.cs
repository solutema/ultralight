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

namespace Lfc.Bancos.Chequeras
{
        public partial class Filtros
        {

                #region Código generado por el diseñador
                /// <summary>
                /// Limpiar los recursos que se están utilizando.
                /// </summary>
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.Label7 = new Lui.Forms.Label();
                        this.LabelCaja = new Lui.Forms.Label();
                        this.EntradaCaja = new Lcc.Entrada.CodigoDetalle();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaBanco = new Lcc.Entrada.CodigoDetalle();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(220, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(328, 8);
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.Location = new System.Drawing.Point(140, 20);
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.SetData = new string[] {
        "Todos|-1",
        "Activas|1",
        "Fuera de uso|0"};
                        this.EntradaEstado.Size = new System.Drawing.Size(172, 24);
                        this.EntradaEstado.TabIndex = 1;
                        this.EntradaEstado.Text = "Todos";
                        this.EntradaEstado.TextKey = "-1";
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(20, 20);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(120, 24);
                        this.Label7.TabIndex = 0;
                        this.Label7.Text = "Estado";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // LabelCaja
                        // 
                        this.LabelCaja.Location = new System.Drawing.Point(20, 84);
                        this.LabelCaja.Name = "LabelCaja";
                        this.LabelCaja.Size = new System.Drawing.Size(120, 24);
                        this.LabelCaja.TabIndex = 4;
                        this.LabelCaja.Text = "Caja";
                        this.LabelCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCaja
                        // 
                        this.EntradaCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCaja.CanCreate = true;
                        this.EntradaCaja.FreeTextCode = "";
                        this.EntradaCaja.Location = new System.Drawing.Point(140, 84);
                        this.EntradaCaja.MaxLength = 200;
                        this.EntradaCaja.Name = "EntradaCaja";
                        this.EntradaCaja.Required = false;
                        this.EntradaCaja.Size = new System.Drawing.Size(280, 24);
                        this.EntradaCaja.TabIndex = 5;
                        this.EntradaCaja.NombreTipo = "Lbl.Cajas.Caja";
                        this.EntradaCaja.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCaja.Text = "0";
                        this.EntradaCaja.TextDetail = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 52);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(120, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Banco";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaBanco
                        // 
                        this.EntradaBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.Location = new System.Drawing.Point(140, 52);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Required = true;
                        this.EntradaBanco.Size = new System.Drawing.Size(280, 24);
                        this.EntradaBanco.TabIndex = 3;
                        this.EntradaBanco.NombreTipo = "Lbl.Bancos.Banco";
                        this.EntradaBanco.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(436, 331);
                        this.Controls.Add(this.LabelCaja);
                        this.Controls.Add(this.EntradaCaja);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaBanco);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.Label7);
                        this.Name = "Filtros";
                        this.Text = "Filtros";
                        this.ResumeLayout(false);

                }
                #endregion


                internal Lui.Forms.ComboBox EntradaEstado;
                private Lui.Forms.Label Label7;
                private Lui.Forms.Label LabelCaja;
                internal Lcc.Entrada.CodigoDetalle EntradaCaja;
                private Lui.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaBanco;
                private System.ComponentModel.IContainer components = null;
        }
}
