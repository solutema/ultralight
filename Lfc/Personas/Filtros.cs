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

namespace Lfc.Personas
{
        public class Filtros :
            Lui.Forms.DialogForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public Filtros()
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
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.DetailBox txtTipo;
                internal Lui.Forms.DetailBox txtSituacion;
                internal Lui.Forms.DetailBox txtCiudad;
                internal Lui.Forms.DetailBox txtGrupo;
                internal Lui.Forms.ComboBox txtEstadoCredito;
                internal Label label21;
                internal System.Windows.Forms.Label Label3;

                private void InitializeComponent()
                {
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtTipo = new Lui.Forms.DetailBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtSituacion = new Lui.Forms.DetailBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtGrupo = new Lui.Forms.DetailBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtCiudad = new Lui.Forms.DetailBox();
                        this.txtEstadoCredito = new Lui.Forms.ComboBox();
                        this.label21 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(250, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(370, 8);
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(20, 20);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(88, 24);
                        this.Label4.TabIndex = 0;
                        this.Label4.Text = "Categoría";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTipo.AutoHeight = false;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.CanCreate = true;
                        this.txtTipo.DetailField = "nombre";
                        this.txtTipo.ExtraDetailFields = null;
                        this.txtTipo.Filter = "";
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTipo.FreeTextCode = "";
                        this.txtTipo.KeyField = "id_tipo_persona";
                        this.txtTipo.Location = new System.Drawing.Point(108, 20);
                        this.txtTipo.MaxLength = 200;
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.Required = false;
                        this.txtTipo.SelectOnFocus = false;
                        this.txtTipo.Size = new System.Drawing.Size(360, 24);
                        this.txtTipo.TabIndex = 1;
                        this.txtTipo.Table = "personas_tipos";
                        this.txtTipo.TeclaDespuesDeEnter = "{tab}";
                        this.txtTipo.Text = "0";
                        this.txtTipo.TextDetail = "";
                        this.txtTipo.TextInt = 0;
                        this.txtTipo.TipWhenBlank = "Todas";
                        this.txtTipo.ToolTipText = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 116);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(88, 24);
                        this.Label1.TabIndex = 6;
                        this.Label1.Text = "Ciudad";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtSituacion
                        // 
                        this.txtSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtSituacion.AutoHeight = false;
                        this.txtSituacion.AutoTab = true;
                        this.txtSituacion.CanCreate = false;
                        this.txtSituacion.DetailField = "nombre";
                        this.txtSituacion.ExtraDetailFields = null;
                        this.txtSituacion.Filter = "";
                        this.txtSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtSituacion.FreeTextCode = "";
                        this.txtSituacion.KeyField = "id_situacion";
                        this.txtSituacion.Location = new System.Drawing.Point(108, 84);
                        this.txtSituacion.MaxLength = 200;
                        this.txtSituacion.Name = "txtSituacion";
                        this.txtSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSituacion.ReadOnly = false;
                        this.txtSituacion.Required = false;
                        this.txtSituacion.SelectOnFocus = false;
                        this.txtSituacion.Size = new System.Drawing.Size(360, 24);
                        this.txtSituacion.TabIndex = 5;
                        this.txtSituacion.Table = "situaciones";
                        this.txtSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.txtSituacion.Text = "0";
                        this.txtSituacion.TextDetail = "";
                        this.txtSituacion.TextInt = 0;
                        this.txtSituacion.TipWhenBlank = "Todas";
                        this.txtSituacion.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(20, 84);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(88, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Situación";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtGrupo
                        // 
                        this.txtGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtGrupo.AutoHeight = false;
                        this.txtGrupo.AutoTab = true;
                        this.txtGrupo.CanCreate = true;
                        this.txtGrupo.DetailField = "nombre";
                        this.txtGrupo.ExtraDetailFields = null;
                        this.txtGrupo.Filter = "";
                        this.txtGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtGrupo.FreeTextCode = "";
                        this.txtGrupo.KeyField = "id_grupo";
                        this.txtGrupo.Location = new System.Drawing.Point(108, 52);
                        this.txtGrupo.MaxLength = 200;
                        this.txtGrupo.Name = "txtGrupo";
                        this.txtGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtGrupo.ReadOnly = false;
                        this.txtGrupo.Required = false;
                        this.txtGrupo.SelectOnFocus = false;
                        this.txtGrupo.Size = new System.Drawing.Size(360, 24);
                        this.txtGrupo.TabIndex = 3;
                        this.txtGrupo.Table = "personas_grupos";
                        this.txtGrupo.TeclaDespuesDeEnter = "{tab}";
                        this.txtGrupo.Text = "0";
                        this.txtGrupo.TextDetail = "";
                        this.txtGrupo.TextInt = 0;
                        this.txtGrupo.TipWhenBlank = "Todos";
                        this.txtGrupo.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(20, 52);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(88, 24);
                        this.Label3.TabIndex = 2;
                        this.Label3.Text = "Grupo";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCiudad
                        // 
                        this.txtCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCiudad.AutoHeight = false;
                        this.txtCiudad.AutoTab = true;
                        this.txtCiudad.CanCreate = false;
                        this.txtCiudad.DetailField = "nombre";
                        this.txtCiudad.ExtraDetailFields = null;
                        this.txtCiudad.Filter = "";
                        this.txtCiudad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCiudad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCiudad.FreeTextCode = "";
                        this.txtCiudad.KeyField = "id_ciudad";
                        this.txtCiudad.Location = new System.Drawing.Point(108, 116);
                        this.txtCiudad.MaxLength = 200;
                        this.txtCiudad.Name = "txtCiudad";
                        this.txtCiudad.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCiudad.ReadOnly = false;
                        this.txtCiudad.Required = false;
                        this.txtCiudad.SelectOnFocus = false;
                        this.txtCiudad.Size = new System.Drawing.Size(360, 24);
                        this.txtCiudad.TabIndex = 7;
                        this.txtCiudad.Table = "ciudades";
                        this.txtCiudad.TeclaDespuesDeEnter = "{tab}";
                        this.txtCiudad.Text = "0";
                        this.txtCiudad.TextDetail = "";
                        this.txtCiudad.TextInt = 0;
                        this.txtCiudad.TipWhenBlank = "Todas";
                        this.txtCiudad.ToolTipText = "";
                        // 
                        // txtEstadoCredito
                        // 
                        this.txtEstadoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtEstadoCredito.AutoHeight = true;
                        this.txtEstadoCredito.AutoNav = true;
                        this.txtEstadoCredito.AutoTab = true;
                        this.txtEstadoCredito.DetailField = null;
                        this.txtEstadoCredito.Filter = null;
                        this.txtEstadoCredito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtEstadoCredito.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtEstadoCredito.KeyField = null;
                        this.txtEstadoCredito.Location = new System.Drawing.Point(148, 148);
                        this.txtEstadoCredito.MaxLenght = 32767;
                        this.txtEstadoCredito.Name = "txtEstadoCredito";
                        this.txtEstadoCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEstadoCredito.ReadOnly = false;
                        this.txtEstadoCredito.SetData = new string[] {
        "Cualquiera|-1",
        "Normal|0",
        "En plan de pagos|5",
        "Suspendido|10"};
                        this.txtEstadoCredito.Size = new System.Drawing.Size(320, 24);
                        this.txtEstadoCredito.TabIndex = 9;
                        this.txtEstadoCredito.Table = null;
                        this.txtEstadoCredito.Text = "Normal";
                        this.txtEstadoCredito.TextKey = "0";
                        this.txtEstadoCredito.TextRaw = "Normal";
                        this.txtEstadoCredito.TipWhenBlank = "";
                        this.txtEstadoCredito.ToolTipText = "";
                        // 
                        // label21
                        // 
                        this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.label21.Location = new System.Drawing.Point(16, 148);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(132, 24);
                        this.label21.TabIndex = 8;
                        this.label21.Text = "Estado de crédito";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(490, 335);
                        this.Controls.Add(this.txtEstadoCredito);
                        this.Controls.Add(this.label21);
                        this.Controls.Add(this.txtCiudad);
                        this.Controls.Add(this.txtGrupo);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.txtSituacion);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.Label4);
                        this.Name = "Filtros";
                        this.Text = "Artículos: Filtros";
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.txtTipo, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.txtSituacion, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.txtGrupo, 0);
                        this.Controls.SetChildIndex(this.txtCiudad, 0);
                        this.Controls.SetChildIndex(this.label21, 0);
                        this.Controls.SetChildIndex(this.txtEstadoCredito, 0);
                        this.ResumeLayout(false);

                }

                #endregion
        }
}