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
                        this.Label7 = new System.Windows.Forms.Label();
                        this.LabelCaja = new System.Windows.Forms.Label();
                        this.EntradaCaja = new Lui.Forms.DetailBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaBanco = new Lui.Forms.DetailBox();
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
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEstado.Location = new System.Drawing.Point(140, 20);
                        this.EntradaEstado.MaxLenght = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "Todos|-1",
        "Activas|1",
        "Fuera de uso|0"};
                        this.EntradaEstado.Size = new System.Drawing.Size(172, 24);
                        this.EntradaEstado.TabIndex = 1;
                        this.EntradaEstado.Text = "Todos";
                        this.EntradaEstado.TextKey = "-1";
                        this.EntradaEstado.TipWhenBlank = "";
                        this.EntradaEstado.ToolTipText = "Estado para esta chequera.";
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
                        this.EntradaCaja.AutoTab = true;
                        this.EntradaCaja.CanCreate = true;
                        this.EntradaCaja.DetailField = "nombre";
                        this.EntradaCaja.ExtraDetailFields = null;
                        this.EntradaCaja.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCaja.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCaja.FreeTextCode = "";
                        this.EntradaCaja.KeyField = "id_caja";
                        this.EntradaCaja.Location = new System.Drawing.Point(140, 84);
                        this.EntradaCaja.MaxLength = 200;
                        this.EntradaCaja.Name = "EntradaCaja";
                        this.EntradaCaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCaja.ReadOnly = false;
                        this.EntradaCaja.Required = false;
                        this.EntradaCaja.SelectOnFocus = false;
                        this.EntradaCaja.Size = new System.Drawing.Size(280, 24);
                        this.EntradaCaja.TabIndex = 5;
                        this.EntradaCaja.Table = "cajas";
                        this.EntradaCaja.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCaja.Text = "0";
                        this.EntradaCaja.TextDetail = "";
                        this.EntradaCaja.TextInt = 0;
                        this.EntradaCaja.TipWhenBlank = "";
                        this.EntradaCaja.ToolTipText = "";
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
                        this.EntradaBanco.AutoTab = true;
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.DetailField = "nombre";
                        this.EntradaBanco.ExtraDetailFields = null;
                        this.EntradaBanco.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBanco.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.KeyField = "id_banco";
                        this.EntradaBanco.Location = new System.Drawing.Point(140, 52);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.ReadOnly = false;
                        this.EntradaBanco.Required = true;
                        this.EntradaBanco.SelectOnFocus = false;
                        this.EntradaBanco.Size = new System.Drawing.Size(280, 24);
                        this.EntradaBanco.TabIndex = 3;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        this.EntradaBanco.TextInt = 0;
                        this.EntradaBanco.TipWhenBlank = "";
                        this.EntradaBanco.ToolTipText = "";
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
                private System.Windows.Forms.Label Label7;
                private System.Windows.Forms.Label LabelCaja;
                internal Lui.Forms.DetailBox EntradaCaja;
                private System.Windows.Forms.Label Label1;
                internal Lui.Forms.DetailBox EntradaBanco;
                private System.ComponentModel.IContainer components = null;
        }
}