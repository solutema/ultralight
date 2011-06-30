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

namespace Lfc.Personas.Grupos
{
        public partial class Editar
        {
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
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

                #region Código generado por el diseñador
                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.EntradaDescuento = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaPredet = new Lui.Forms.ComboBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EntradaDescuento
                        // 
                        this.EntradaDescuento.AutoSize = false;
                        this.EntradaDescuento.AutoNav = true;
                        this.EntradaDescuento.AutoTab = true;
                        this.EntradaDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaDescuento.DecimalPlaces = -1;
                        this.EntradaDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDescuento.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDescuento.Location = new System.Drawing.Point(120, 64);
                        this.EntradaDescuento.MaxLenght = 32767;
                        this.EntradaDescuento.MultiLine = false;
                        this.EntradaDescuento.Name = "EntradaDescuento";
                        this.EntradaDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescuento.PasswordChar = '\0';
                        this.EntradaDescuento.Prefijo = "";
                        this.EntradaDescuento.TemporaryReadOnly = false;
                        this.EntradaDescuento.SelectOnFocus = true;
                        this.EntradaDescuento.Size = new System.Drawing.Size(84, 24);
                        this.EntradaDescuento.Sufijo = "%";
                        this.EntradaDescuento.TabIndex = 5;
                        this.EntradaDescuento.Text = "0.0000";
                        this.EntradaDescuento.PlaceholderText = "";
                        this.EntradaDescuento.ToolTipText = "";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(0, 64);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(120, 24);
                        this.label4.TabIndex = 4;
                        this.label4.Text = "Descuento";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoSize = false;
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNombre.Location = new System.Drawing.Point(120, 32);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.TemporaryReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(432, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 3;
                        this.EntradaNombre.PlaceholderText = "";
                        this.EntradaNombre.ToolTipText = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(0, 32);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(120, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Nombre";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPredet
                        // 
                        this.EntradaPredet.AutoSize = false;
                        this.EntradaPredet.AutoNav = true;
                        this.EntradaPredet.AutoTab = true;
                        this.EntradaPredet.DetailField = null;
                        this.EntradaPredet.Filter = null;
                        this.EntradaPredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPredet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPredet.KeyField = null;
                        this.EntradaPredet.Location = new System.Drawing.Point(120, 96);
                        this.EntradaPredet.MaxLenght = 32767;
                        this.EntradaPredet.Name = "EntradaPredet";
                        this.EntradaPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPredet.TemporaryReadOnly = false;
                        this.EntradaPredet.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaPredet.Size = new System.Drawing.Size(84, 24);
                        this.EntradaPredet.TabIndex = 7;
                        this.EntradaPredet.Table = null;
                        this.EntradaPredet.Text = "No";
                        this.EntradaPredet.TextKey = "0";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(0, 96);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(120, 24);
                        this.label2.TabIndex = 6;
                        this.label2.Text = "Predeterminado";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaGrupo
                        // 
                        this.EntradaGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaGrupo.AutoSize = false;
                        this.EntradaGrupo.AutoNav = true;
                        this.EntradaGrupo.AutoTab = true;
                        this.EntradaGrupo.CanCreate = true;
                        this.EntradaGrupo.DataTextField = "nombre";
                        this.EntradaGrupo.ExtraDetailFields = null;
                        this.EntradaGrupo.Filter = "";
                        this.EntradaGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaGrupo.FreeTextCode = "";
                        this.EntradaGrupo.DataValueField = "id_grupo";
                        this.EntradaGrupo.Location = new System.Drawing.Point(120, 0);
                        this.EntradaGrupo.MaxLength = 200;
                        this.EntradaGrupo.Name = "EntradaGrupo";
                        this.EntradaGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGrupo.TemporaryReadOnly = false;
                        this.EntradaGrupo.Required = false;
                        this.EntradaGrupo.Size = new System.Drawing.Size(432, 24);
                        this.EntradaGrupo.TabIndex = 1;
                        this.EntradaGrupo.Table = "personas_grupos";
                        this.EntradaGrupo.Text = "0";
                        this.EntradaGrupo.TextDetail = "";
                        this.EntradaGrupo.PlaceholderText = "Ninguno";
                        this.EntradaGrupo.ToolTipText = "";
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(0, 0);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(120, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Depende de";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoSize = true;
                        this.Controls.Add(this.Label16);
                        this.Controls.Add(this.EntradaGrupo);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaPredet);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaDescuento);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaNombre);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(552, 125);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaDescuento, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.EntradaPredet, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaGrupo, 0);
                        this.Controls.SetChildIndex(this.Label16, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion


                internal System.Windows.Forms.Label label4;
                internal Lui.Forms.TextBox EntradaNombre;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaDescuento;
                internal Lui.Forms.ComboBox EntradaPredet;
                internal Label label2;
                internal Lcc.Entrada.CodigoDetalle EntradaGrupo;
                internal Label Label16;
        }
}
