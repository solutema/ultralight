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
using System.Windows.Forms;

namespace Lfc.Cajas.Admin
{
        public partial class Editar
        {
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaNumero;
                internal Lcc.Entrada.CodigoDetalle EntradaBanco;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaNombre;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox EntradaTipo;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.TextBox EntradaCbu;
                internal System.Windows.Forms.Label label5;
                internal Lui.Forms.TextBox EntradaTitular;
                internal Label label6;
                internal Lui.Forms.ComboBox EntradaEstado;
                internal Label label8;
                internal Lcc.Entrada.CodigoDetalle EntradaMoneda;

                #region Código generado por el Diseñador de Windows Forms

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
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaBanco = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaMoneda = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaCbu = new Lui.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.EntradaTitular = new Lui.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumero.Location = new System.Drawing.Point(124, 128);
                        this.EntradaNumero.MaxLenght = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.PlaceholderText = "";
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(228, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 9;
                        this.EntradaNumero.ToolTipText = "";
                        this.EntradaNumero.TextChanged += new System.EventHandler(this.NumeroBanco_TextChanged);
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(0, 128);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(120, 24);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "Número";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(0, 96);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(120, 24);
                        this.Label1.TabIndex = 6;
                        this.Label1.Text = "Banco";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaBanco
                        // 
                        this.EntradaBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaBanco.AutoNav = true;
                        this.EntradaBanco.AutoTab = true;
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.DataTextField = "nombre";
                        this.EntradaBanco.DataValueField = "id_banco";
                        this.EntradaBanco.ExtraDetailFields = null;
                        this.EntradaBanco.Filter = "";
                        this.EntradaBanco.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBanco.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.Location = new System.Drawing.Point(124, 96);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.PlaceholderText = "";
                        this.EntradaBanco.ReadOnly = false;
                        this.EntradaBanco.Required = false;
                        this.EntradaBanco.Size = new System.Drawing.Size(491, 24);
                        this.EntradaBanco.TabIndex = 7;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        this.EntradaBanco.ToolTipText = "";
                        this.EntradaBanco.TextChanged += new System.EventHandler(this.NumeroBanco_TextChanged);
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AlwaysExpanded = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTipo.Location = new System.Drawing.Point(124, 64);
                        this.EntradaTipo.MaxLenght = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.PlaceholderText = "";
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "Efectivo|0",
        "Caja de Ahorro|1",
        "Cuenta Corriente|2"};
                        this.EntradaTipo.Size = new System.Drawing.Size(168, 24);
                        this.EntradaTipo.TabIndex = 5;
                        this.EntradaTipo.TextKey = "1";
                        this.EntradaTipo.ToolTipText = "¿El producto usa control de stock?";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipo_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(0, 64);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(120, 24);
                        this.Label7.TabIndex = 4;
                        this.Label7.Text = "Tipo de Caja";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
                        this.EntradaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNombre.Location = new System.Drawing.Point(124, 0);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.PlaceholderText = "";
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(491, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.ToolTipText = "";
                        this.EntradaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaNombre_KeyPress);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(0, 0);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(120, 24);
                        this.Label2.TabIndex = 0;
                        this.Label2.Text = "Nombre";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(0, 160);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(120, 24);
                        this.Label4.TabIndex = 10;
                        this.Label4.Text = "Moneda";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaMoneda
                        // 
                        this.EntradaMoneda.AutoNav = true;
                        this.EntradaMoneda.AutoTab = true;
                        this.EntradaMoneda.CanCreate = true;
                        this.EntradaMoneda.DataTextField = "nombre";
                        this.EntradaMoneda.DataValueField = "id_moneda";
                        this.EntradaMoneda.ExtraDetailFields = null;
                        this.EntradaMoneda.Filter = "";
                        this.EntradaMoneda.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMoneda.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMoneda.FreeTextCode = "";
                        this.EntradaMoneda.Location = new System.Drawing.Point(124, 160);
                        this.EntradaMoneda.MaxLength = 200;
                        this.EntradaMoneda.Name = "EntradaMoneda";
                        this.EntradaMoneda.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMoneda.PlaceholderText = "";
                        this.EntradaMoneda.ReadOnly = false;
                        this.EntradaMoneda.Required = false;
                        this.EntradaMoneda.Size = new System.Drawing.Size(228, 24);
                        this.EntradaMoneda.TabIndex = 11;
                        this.EntradaMoneda.Table = "monedas";
                        this.EntradaMoneda.Text = "0";
                        this.EntradaMoneda.TextDetail = "";
                        this.EntradaMoneda.ToolTipText = "";
                        // 
                        // EntradaCbu
                        // 
                        this.EntradaCbu.AutoNav = true;
                        this.EntradaCbu.AutoTab = true;
                        this.EntradaCbu.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCbu.DecimalPlaces = -1;
                        this.EntradaCbu.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCbu.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCbu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCbu.Location = new System.Drawing.Point(124, 192);
                        this.EntradaCbu.MaxLenght = 23;
                        this.EntradaCbu.MultiLine = false;
                        this.EntradaCbu.Name = "EntradaCbu";
                        this.EntradaCbu.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCbu.PasswordChar = '\0';
                        this.EntradaCbu.PlaceholderText = "";
                        this.EntradaCbu.Prefijo = "";
                        this.EntradaCbu.ReadOnly = false;
                        this.EntradaCbu.SelectOnFocus = false;
                        this.EntradaCbu.Size = new System.Drawing.Size(228, 24);
                        this.EntradaCbu.Sufijo = "";
                        this.EntradaCbu.TabIndex = 13;
                        this.EntradaCbu.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(0, 192);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(120, 24);
                        this.label5.TabIndex = 12;
                        this.label5.Text = "CBU";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaTitular
                        // 
                        this.EntradaTitular.AutoNav = true;
                        this.EntradaTitular.AutoTab = true;
                        this.EntradaTitular.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaTitular.DecimalPlaces = -1;
                        this.EntradaTitular.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTitular.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTitular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTitular.Location = new System.Drawing.Point(124, 32);
                        this.EntradaTitular.MaxLenght = 32767;
                        this.EntradaTitular.MultiLine = false;
                        this.EntradaTitular.Name = "EntradaTitular";
                        this.EntradaTitular.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTitular.PasswordChar = '\0';
                        this.EntradaTitular.PlaceholderText = "";
                        this.EntradaTitular.Prefijo = "";
                        this.EntradaTitular.ReadOnly = false;
                        this.EntradaTitular.SelectOnFocus = true;
                        this.EntradaTitular.Size = new System.Drawing.Size(436, 24);
                        this.EntradaTitular.Sufijo = "";
                        this.EntradaTitular.TabIndex = 3;
                        this.EntradaTitular.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(0, 32);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(120, 24);
                        this.label6.TabIndex = 2;
                        this.label6.Text = "Titular";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AlwaysExpanded = false;
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEstado.Location = new System.Drawing.Point(124, 224);
                        this.EntradaEstado.MaxLenght = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.PlaceholderText = "";
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "Activa|1",
        "Inactiva|0"};
                        this.EntradaEstado.Size = new System.Drawing.Size(168, 24);
                        this.EntradaEstado.TabIndex = 15;
                        this.EntradaEstado.TextKey = "1";
                        this.EntradaEstado.ToolTipText = "¿El producto usa control de stock?";
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(0, 224);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(120, 24);
                        this.label8.TabIndex = 14;
                        this.label8.Text = "Estado";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Editar
                        // 
                        this.AutoSize = true;
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.EntradaTitular);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.EntradaCbu);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaMoneda);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaBanco);
                        this.Controls.Add(this.EntradaNumero);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(615, 253);
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.Controls.SetChildIndex(this.EntradaBanco, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.EntradaMoneda, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.EntradaCbu, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.EntradaTitular, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.EntradaEstado, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion
        }
}
