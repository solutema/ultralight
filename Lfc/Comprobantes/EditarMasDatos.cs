// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

using System;
using System.Collections;
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
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label lblHaciaSituacion;
                internal Lui.Forms.DetailBox txtHaciaSituacion;
                internal System.Windows.Forms.Label lblDesdeSituacion;
                internal System.Windows.Forms.Label label1;
                internal Lui.Forms.ComboBox txtBloqueada;
                internal Lui.Forms.DetailBox txtDesdeSituacion;

                private void InitializeComponent()
                {
                        this.lblHaciaSituacion = new System.Windows.Forms.Label();
                        this.txtHaciaSituacion = new Lui.Forms.DetailBox();
                        this.lblDesdeSituacion = new System.Windows.Forms.Label();
                        this.txtDesdeSituacion = new Lui.Forms.DetailBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.txtBloqueada = new Lui.Forms.ComboBox();
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
                        // txtHaciaSituacion
                        // 
                        this.txtHaciaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtHaciaSituacion.AutoTab = true;
                        this.txtHaciaSituacion.CanCreate = false;
                        this.txtHaciaSituacion.DetailField = "nombre";
                        this.txtHaciaSituacion.ExtraDetailFields = null;
                        this.txtHaciaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtHaciaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtHaciaSituacion.FreeTextCode = "";
                        this.txtHaciaSituacion.KeyField = "id_situacion";
                        this.txtHaciaSituacion.Location = new System.Drawing.Point(140, 48);
                        this.txtHaciaSituacion.MaxLength = 200;
                        this.txtHaciaSituacion.Name = "txtHaciaSituacion";
                        this.txtHaciaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtHaciaSituacion.ReadOnly = false;
                        this.txtHaciaSituacion.Required = true;
                        this.txtHaciaSituacion.Size = new System.Drawing.Size(476, 24);
                        this.txtHaciaSituacion.TabIndex = 3;
                        this.txtHaciaSituacion.Table = "articulos_situaciones";
                        this.txtHaciaSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.txtHaciaSituacion.Text = "0";
                        this.txtHaciaSituacion.TextDetail = "";
                        this.txtHaciaSituacion.TextInt = 0;
                        this.txtHaciaSituacion.TipWhenBlank = "";
                        this.txtHaciaSituacion.ToolTipText = "";
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
                        // txtDesdeSituacion
                        // 
                        this.txtDesdeSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtDesdeSituacion.AutoTab = true;
                        this.txtDesdeSituacion.CanCreate = false;
                        this.txtDesdeSituacion.DetailField = "nombre";
                        this.txtDesdeSituacion.ExtraDetailFields = null;
                        this.txtDesdeSituacion.Filter = "facturable=1";
                        this.txtDesdeSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDesdeSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtDesdeSituacion.FreeTextCode = "";
                        this.txtDesdeSituacion.KeyField = "id_situacion";
                        this.txtDesdeSituacion.Location = new System.Drawing.Point(140, 20);
                        this.txtDesdeSituacion.MaxLength = 200;
                        this.txtDesdeSituacion.Name = "txtDesdeSituacion";
                        this.txtDesdeSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDesdeSituacion.ReadOnly = false;
                        this.txtDesdeSituacion.Required = true;
                        this.txtDesdeSituacion.Size = new System.Drawing.Size(476, 24);
                        this.txtDesdeSituacion.TabIndex = 1;
                        this.txtDesdeSituacion.Table = "articulos_situaciones";
                        this.txtDesdeSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.txtDesdeSituacion.Text = "0";
                        this.txtDesdeSituacion.TextDetail = "";
                        this.txtDesdeSituacion.TextInt = 0;
                        this.txtDesdeSituacion.TipWhenBlank = "";
                        this.txtDesdeSituacion.ToolTipText = "";
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
                        // txtBloqueada
                        // 
                        this.txtBloqueada.AutoNav = true;
                        this.txtBloqueada.AutoTab = true;
                        this.txtBloqueada.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtBloqueada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtBloqueada.Location = new System.Drawing.Point(140, 280);
                        this.txtBloqueada.MaxLenght = 32767;
                        this.txtBloqueada.Name = "txtBloqueada";
                        this.txtBloqueada.Padding = new System.Windows.Forms.Padding(2);
                        this.txtBloqueada.ReadOnly = false;
                        this.txtBloqueada.SetData = new string[] {
        "Editable|0",
        "Bloqueado|1"};
                        this.txtBloqueada.Size = new System.Drawing.Size(152, 24);
                        this.txtBloqueada.TabIndex = 5;
                        this.txtBloqueada.Text = "Editable";
                        this.txtBloqueada.TextKey = "0";
                        this.txtBloqueada.TipWhenBlank = "";
                        this.txtBloqueada.ToolTipText = "";
                        this.txtBloqueada.TextChanged += new System.EventHandler(this.txtBloqueada_TextChanged);
                        // 
                        // FormComprobanteMasDatos
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.txtBloqueada);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.lblHaciaSituacion);
                        this.Controls.Add(this.txtHaciaSituacion);
                        this.Controls.Add(this.lblDesdeSituacion);
                        this.Controls.Add(this.txtDesdeSituacion);
                        this.Name = "FormComprobanteMasDatos";
                        this.Controls.SetChildIndex(this.txtDesdeSituacion, 0);
                        this.Controls.SetChildIndex(this.lblDesdeSituacion, 0);
                        this.Controls.SetChildIndex(this.txtHaciaSituacion, 0);
                        this.Controls.SetChildIndex(this.lblHaciaSituacion, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.txtBloqueada, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private void txtBloqueada_TextChanged(object sender, System.EventArgs e)
                {
                        txtDesdeSituacion.ReadOnly = (txtBloqueada.TextKey == "1");
                        txtHaciaSituacion.ReadOnly = (txtBloqueada.TextKey == "1");
                }
        }
}