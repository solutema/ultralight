#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes
{
        public class FormComprobanteMasDatos : Lui.Forms.DialogForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public FormComprobanteMasDatos()
                        :
                        base()
                {

                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent

                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }

                        base.Dispose(disposing);
                }

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.IContainer components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label lblHaciaSituacion;
                internal Lcc.Entrada.CodigoDetalle EntradaHaciaSituacion;
                internal System.Windows.Forms.Label lblDesdeSituacion;
                internal System.Windows.Forms.Label label1;
                internal Lui.Forms.ComboBox EntradaBloqueada;
                internal Lcc.Entrada.CodigoDetalle EntradaDesdeSituacion;

                private void InitializeComponent()
                {
                        this.lblHaciaSituacion = new System.Windows.Forms.Label();
                        this.EntradaHaciaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.lblDesdeSituacion = new System.Windows.Forms.Label();
                        this.EntradaDesdeSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.label1 = new System.Windows.Forms.Label();
                        this.EntradaBloqueada = new Lui.Forms.ComboBox();
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
                        // lblHaciaSituacion
                        // 
                        this.lblHaciaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblHaciaSituacion.Location = new System.Drawing.Point(16, 48);
                        this.lblHaciaSituacion.Name = "lblHaciaSituacion";
                        this.lblHaciaSituacion.Size = new System.Drawing.Size(124, 24);
                        this.lblHaciaSituacion.TabIndex = 2;
                        this.lblHaciaSituacion.Text = "Situación Destino";
                        this.lblHaciaSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaHaciaSituacion
                        // 
                        this.EntradaHaciaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaHaciaSituacion.AutoTab = true;
                        this.EntradaHaciaSituacion.CanCreate = false;
                        this.EntradaHaciaSituacion.DataTextField = "nombre";
                        this.EntradaHaciaSituacion.ExtraDetailFields = null;
                        this.EntradaHaciaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaHaciaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaHaciaSituacion.FreeTextCode = "";
                        this.EntradaHaciaSituacion.DataValueField = "id_situacion";
                        this.EntradaHaciaSituacion.Location = new System.Drawing.Point(140, 48);
                        this.EntradaHaciaSituacion.MaxLength = 200;
                        this.EntradaHaciaSituacion.Name = "EntradaHaciaSituacion";
                        this.EntradaHaciaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaHaciaSituacion.ReadOnly = false;
                        this.EntradaHaciaSituacion.Required = true;
                        this.EntradaHaciaSituacion.Size = new System.Drawing.Size(476, 24);
                        this.EntradaHaciaSituacion.TabIndex = 3;
                        this.EntradaHaciaSituacion.Table = "articulos_situaciones";
                        this.EntradaHaciaSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaHaciaSituacion.Text = "0";
                        this.EntradaHaciaSituacion.TextDetail = "";
                        this.EntradaHaciaSituacion.TipWhenBlank = "";
                        this.EntradaHaciaSituacion.ToolTipText = "";
                        // 
                        // lblDesdeSituacion
                        // 
                        this.lblDesdeSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblDesdeSituacion.Location = new System.Drawing.Point(16, 20);
                        this.lblDesdeSituacion.Name = "lblDesdeSituacion";
                        this.lblDesdeSituacion.Size = new System.Drawing.Size(124, 24);
                        this.lblDesdeSituacion.TabIndex = 0;
                        this.lblDesdeSituacion.Text = "Situación Origen";
                        this.lblDesdeSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDesdeSituacion
                        // 
                        this.EntradaDesdeSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDesdeSituacion.AutoTab = true;
                        this.EntradaDesdeSituacion.CanCreate = false;
                        this.EntradaDesdeSituacion.DataTextField = "nombre";
                        this.EntradaDesdeSituacion.ExtraDetailFields = null;
                        this.EntradaDesdeSituacion.Filter = "facturable=1";
                        this.EntradaDesdeSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDesdeSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaDesdeSituacion.FreeTextCode = "";
                        this.EntradaDesdeSituacion.DataValueField = "id_situacion";
                        this.EntradaDesdeSituacion.Location = new System.Drawing.Point(140, 20);
                        this.EntradaDesdeSituacion.MaxLength = 200;
                        this.EntradaDesdeSituacion.Name = "EntradaDesdeSituacion";
                        this.EntradaDesdeSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDesdeSituacion.ReadOnly = false;
                        this.EntradaDesdeSituacion.Required = true;
                        this.EntradaDesdeSituacion.Size = new System.Drawing.Size(476, 24);
                        this.EntradaDesdeSituacion.TabIndex = 1;
                        this.EntradaDesdeSituacion.Table = "articulos_situaciones";
                        this.EntradaDesdeSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaDesdeSituacion.Text = "0";
                        this.EntradaDesdeSituacion.TextDetail = "";
                        this.EntradaDesdeSituacion.TipWhenBlank = "";
                        this.EntradaDesdeSituacion.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label1.Location = new System.Drawing.Point(16, 280);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(124, 24);
                        this.label1.TabIndex = 4;
                        this.label1.Text = "Accesibilidad";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaBloqueada
                        // 
                        this.EntradaBloqueada.AutoNav = true;
                        this.EntradaBloqueada.AutoTab = true;
                        this.EntradaBloqueada.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaBloqueada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaBloqueada.Location = new System.Drawing.Point(140, 280);
                        this.EntradaBloqueada.MaxLenght = 32767;
                        this.EntradaBloqueada.Name = "EntradaBloqueada";
                        this.EntradaBloqueada.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBloqueada.ReadOnly = false;
                        this.EntradaBloqueada.SetData = new string[] {
        "Editable|0",
        "Bloqueado|1"};
                        this.EntradaBloqueada.Size = new System.Drawing.Size(152, 24);
                        this.EntradaBloqueada.TabIndex = 5;
                        this.EntradaBloqueada.Text = "Editable";
                        this.EntradaBloqueada.TextKey = "0";
                        this.EntradaBloqueada.TipWhenBlank = "";
                        this.EntradaBloqueada.ToolTipText = "";
                        this.EntradaBloqueada.TextChanged += new System.EventHandler(this.EntradaBloqueada_TextChanged);
                        // 
                        // FormComprobanteMasDatos
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.EntradaBloqueada);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.lblHaciaSituacion);
                        this.Controls.Add(this.EntradaHaciaSituacion);
                        this.Controls.Add(this.lblDesdeSituacion);
                        this.Controls.Add(this.EntradaDesdeSituacion);
                        this.Name = "FormComprobanteMasDatos";
                        this.ResumeLayout(false);

                }

                #endregion

                private void EntradaBloqueada_TextChanged(object sender, System.EventArgs e)
                {
                        EntradaDesdeSituacion.ReadOnly = (EntradaBloqueada.TextKey == "1");
                        EntradaHaciaSituacion.ReadOnly = (EntradaBloqueada.TextKey == "1");
                }
        }
}