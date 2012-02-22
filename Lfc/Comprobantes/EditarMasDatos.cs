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
                internal Lui.Forms.Label lblHaciaSituacion;
                internal Lcc.Entrada.CodigoDetalle EntradaHaciaSituacion;
                internal Lui.Forms.Label lblDesdeSituacion;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.ComboBox EntradaBloqueada;
                internal Lcc.Entrada.CodigoDetalle EntradaDesdeSituacion;

                private void InitializeComponent()
                {
                        this.lblHaciaSituacion = new Lui.Forms.Label();
                        this.EntradaHaciaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.lblDesdeSituacion = new Lui.Forms.Label();
                        this.EntradaDesdeSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.label1 = new Lui.Forms.Label();
                        this.EntradaBloqueada = new Lui.Forms.ComboBox();
                        this.SuspendLayout();
                        // 
                        // lblHaciaSituacion
                        // 
                        this.lblHaciaSituacion.Location = new System.Drawing.Point(24, 52);
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
                        this.EntradaHaciaSituacion.DataValueField = "id_situacion";
                        this.EntradaHaciaSituacion.ExtraDetailFields = "";
                        this.EntradaHaciaSituacion.Filter = "";
                        this.EntradaHaciaSituacion.FreeTextCode = "";
                        this.EntradaHaciaSituacion.Location = new System.Drawing.Point(148, 52);
                        this.EntradaHaciaSituacion.MaxLength = 200;
                        this.EntradaHaciaSituacion.Name = "EntradaHaciaSituacion";
                        this.EntradaHaciaSituacion.PlaceholderText = null;
                        this.EntradaHaciaSituacion.Required = true;
                        this.EntradaHaciaSituacion.Size = new System.Drawing.Size(460, 24);
                        this.EntradaHaciaSituacion.TabIndex = 3;
                        this.EntradaHaciaSituacion.Table = "articulos_situaciones";
                        this.EntradaHaciaSituacion.Text = "0";
                        this.EntradaHaciaSituacion.TextDetail = "";
                        // 
                        // lblDesdeSituacion
                        // 
                        this.lblDesdeSituacion.Location = new System.Drawing.Point(24, 24);
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
                        this.EntradaDesdeSituacion.DataValueField = "id_situacion";
                        this.EntradaDesdeSituacion.ExtraDetailFields = "";
                        this.EntradaDesdeSituacion.Filter = "facturable=1";
                        this.EntradaDesdeSituacion.FreeTextCode = "";
                        this.EntradaDesdeSituacion.Location = new System.Drawing.Point(148, 24);
                        this.EntradaDesdeSituacion.MaxLength = 200;
                        this.EntradaDesdeSituacion.Name = "EntradaDesdeSituacion";
                        this.EntradaDesdeSituacion.PlaceholderText = null;
                        this.EntradaDesdeSituacion.Required = true;
                        this.EntradaDesdeSituacion.Size = new System.Drawing.Size(460, 24);
                        this.EntradaDesdeSituacion.TabIndex = 1;
                        this.EntradaDesdeSituacion.Table = "articulos_situaciones";
                        this.EntradaDesdeSituacion.Text = "0";
                        this.EntradaDesdeSituacion.TextDetail = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(24, 80);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(124, 24);
                        this.label1.TabIndex = 4;
                        this.label1.Text = "Accesibilidad";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaBloqueada
                        // 
                        this.EntradaBloqueada.AlwaysExpanded = true;
                        this.EntradaBloqueada.AutoSize = true;
                        this.EntradaBloqueada.Location = new System.Drawing.Point(148, 80);
                        this.EntradaBloqueada.Name = "EntradaBloqueada";
                        this.EntradaBloqueada.SetData = new string[] {
        "Editable|0",
        "Bloqueado|1"};
                        this.EntradaBloqueada.Size = new System.Drawing.Size(152, 40);
                        this.EntradaBloqueada.TabIndex = 5;
                        this.EntradaBloqueada.TextKey = "0";
                        this.EntradaBloqueada.TextChanged += new System.EventHandler(this.EntradaBloqueada_TextChanged);
                        // 
                        // FormComprobanteMasDatos
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.lblHaciaSituacion);
                        this.Controls.Add(this.EntradaBloqueada);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaHaciaSituacion);
                        this.Controls.Add(this.lblDesdeSituacion);
                        this.Controls.Add(this.EntradaDesdeSituacion);
                        this.Name = "FormComprobanteMasDatos";
                        this.Text = "Más datos del comprobante";
                        this.Controls.SetChildIndex(this.EntradaDesdeSituacion, 0);
                        this.Controls.SetChildIndex(this.lblDesdeSituacion, 0);
                        this.Controls.SetChildIndex(this.EntradaHaciaSituacion, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.EntradaBloqueada, 0);
                        this.Controls.SetChildIndex(this.lblHaciaSituacion, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private void EntradaBloqueada_TextChanged(object sender, System.EventArgs e)
                {
                        EntradaDesdeSituacion.TemporaryReadOnly = (EntradaBloqueada.TextKey == "1");
                        EntradaHaciaSituacion.TemporaryReadOnly = (EntradaBloqueada.TextKey == "1");
                }
        }
}
