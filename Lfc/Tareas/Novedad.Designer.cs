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

namespace Lfc.Tareas
{
        public partial class Novedad
        {

                #region Código generado por el Diseñador de Windows Forms

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

                internal Lui.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaTecnico;
                internal Lui.Forms.TextBox EntradaDescripcion;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.TextBox EntradaMinutos;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.ComboBox EntradaCondicion;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label Label5;
                internal Lcc.Entrada.CodigoDetalle EntradaTicket;

                private void InitializeComponent()
                {
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaTecnico = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaDescripcion = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaMinutos = new Lui.Forms.TextBox();
                        this.EntradaCondicion = new Lui.Forms.ComboBox();
                        this.Label3 = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.EntradaTicket = new Lcc.Entrada.CodigoDetalle();
                        this.Label5 = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(394, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(514, 8);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 240);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(88, 24);
                        this.Label1.TabIndex = 8;
                        this.Label1.Text = "Persona";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTecnico
                        // 
                        this.EntradaTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTecnico.AutoNav = true;
                        this.EntradaTecnico.CanCreate = true;
                        this.EntradaTecnico.DataTextField = "nombre_visible";
                        this.EntradaTecnico.Filter = "(tipo&4)=4";
                        this.EntradaTecnico.FreeTextCode = "";
                        this.EntradaTecnico.DataValueField = "id_persona";
                        this.EntradaTecnico.Location = new System.Drawing.Point(96, 240);
                        this.EntradaTecnico.MaxLength = 200;
                        this.EntradaTecnico.Name = "EntradaTecnico";
                        this.EntradaTecnico.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTecnico.Required = true;
                        this.EntradaTecnico.Size = new System.Drawing.Size(516, 24);
                        this.EntradaTecnico.TabIndex = 9;
                        this.EntradaTecnico.Table = "personas";
                        this.EntradaTecnico.Text = "0";
                        this.EntradaTecnico.TextDetail = "";
                        // 
                        // EntradaDescripcion
                        // 
                        this.EntradaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDescripcion.AutoNav = true;
                        this.EntradaDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion.DecimalPlaces = -1;
                        this.EntradaDescripcion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescripcion.Location = new System.Drawing.Point(96, 56);
                        this.EntradaDescripcion.MultiLine = true;
                        this.EntradaDescripcion.Name = "EntradaDescripcion";
                        this.EntradaDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion.SelectOnFocus = true;
                        this.EntradaDescripcion.Size = new System.Drawing.Size(516, 124);
                        this.EntradaDescripcion.TabIndex = 3;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(276, 192);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(68, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Tiempo";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaMinutos
                        // 
                        this.EntradaMinutos.AutoNav = true;
                        this.EntradaMinutos.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaMinutos.DecimalPlaces = -1;
                        this.EntradaMinutos.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaMinutos.Location = new System.Drawing.Point(344, 192);
                        this.EntradaMinutos.MultiLine = false;
                        this.EntradaMinutos.Name = "EntradaMinutos";
                        this.EntradaMinutos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMinutos.SelectOnFocus = true;
                        this.EntradaMinutos.Size = new System.Drawing.Size(76, 24);
                        this.EntradaMinutos.TabIndex = 5;
                        // 
                        // EntradaCondicion
                        // 
                        this.EntradaCondicion.AlwaysExpanded = true;
                        this.EntradaCondicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCondicion.AutoNav = true;
                        this.EntradaCondicion.AutoSize = true;
                        this.EntradaCondicion.Location = new System.Drawing.Point(96, 192);
                        this.EntradaCondicion.Name = "EntradaCondicion";
                        this.EntradaCondicion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCondicion.SetData = new string[] {
        "Publica|0",
        "Interna|1"};
                        this.EntradaCondicion.Size = new System.Drawing.Size(164, 36);
                        this.EntradaCondicion.TabIndex = 7;
                        this.EntradaCondicion.TextKey = "0";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(20, 192);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(88, 24);
                        this.Label3.TabIndex = 6;
                        this.Label3.Text = "Novedad";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(20, 56);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(88, 24);
                        this.Label4.TabIndex = 2;
                        this.Label4.Text = "Asunto";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTicket
                        // 
                        this.EntradaTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTicket.AutoNav = true;
                        this.EntradaTicket.CanCreate = true;
                        this.EntradaTicket.DataTextField = "nombre";
                        this.EntradaTicket.Filter = "";
                        this.EntradaTicket.FreeTextCode = "";
                        this.EntradaTicket.DataValueField = "id_ticket";
                        this.EntradaTicket.Location = new System.Drawing.Point(96, 24);
                        this.EntradaTicket.MaxLength = 200;
                        this.EntradaTicket.Name = "EntradaTicket";
                        this.EntradaTicket.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTicket.Required = true;
                        this.EntradaTicket.Size = new System.Drawing.Size(516, 24);
                        this.EntradaTicket.TabIndex = 1;
                        this.EntradaTicket.Table = "tickets";
                        this.EntradaTicket.Text = "0";
                        this.EntradaTicket.TextDetail = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(20, 24);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(88, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Tarea";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Novedad
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.EntradaMinutos);
                        this.Controls.Add(this.EntradaTicket);
                        this.Controls.Add(this.EntradaCondicion);
                        this.Controls.Add(this.EntradaDescripcion);
                        this.Controls.Add(this.EntradaTecnico);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label1);
                        this.Name = "Novedad";
                        this.Text = "Novedad: Cargar";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.EntradaTecnico, 0);
                        this.Controls.SetChildIndex(this.EntradaDescripcion, 0);
                        this.Controls.SetChildIndex(this.EntradaCondicion, 0);
                        this.Controls.SetChildIndex(this.EntradaTicket, 0);
                        this.Controls.SetChildIndex(this.EntradaMinutos, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion
        }
}
