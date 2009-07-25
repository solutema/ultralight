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
                internal Lui.Forms.DetailBox EntradaTipo;
                internal Lui.Forms.DetailBox EntradaSituacion;
                internal Lui.Forms.DetailBox EntradaCiudad;
                internal Lui.Forms.DetailBox EntradaGrupo;
                internal Lui.Forms.ComboBox EntradaEstadoCredito;
                internal Label label21;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lui.Forms.ComboBox EntradaEtiquetas;
                internal Label label5;
                internal Lui.Forms.DetailBox EntradaSubGrupo;
                internal Label label6;
                internal System.Windows.Forms.Label Label3;

                private void InitializeComponent()
                {
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaTipo = new Lui.Forms.DetailBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaSituacion = new Lui.Forms.DetailBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaGrupo = new Lui.Forms.DetailBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaCiudad = new Lui.Forms.DetailBox();
                        this.EntradaEstadoCredito = new Lui.Forms.ComboBox();
                        this.label21 = new System.Windows.Forms.Label();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaSubGrupo = new Lui.Forms.DetailBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.EntradaEtiquetas = new Lui.Forms.ComboBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.tableLayoutPanel1.SuspendLayout();
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
                        this.Label4.Location = new System.Drawing.Point(3, 0);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(128, 24);
                        this.Label4.TabIndex = 0;
                        this.Label4.Text = "Categoría";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTipo.AutoHeight = false;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.CanCreate = true;
                        this.EntradaTipo.DetailField = "nombre";
                        this.EntradaTipo.ExtraDetailFields = null;
                        this.EntradaTipo.Filter = "";
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTipo.FreeTextCode = "";
                        this.EntradaTipo.KeyField = "id_tipo_persona";
                        this.EntradaTipo.Location = new System.Drawing.Point(137, 3);
                        this.EntradaTipo.MaxLength = 200;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.Required = false;
                        this.EntradaTipo.SelectOnFocus = false;
                        this.EntradaTipo.Size = new System.Drawing.Size(308, 24);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.Table = "personas_tipos";
                        this.EntradaTipo.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaTipo.Text = "0";
                        this.EntradaTipo.TextDetail = "";
                        this.EntradaTipo.TextInt = 0;
                        this.EntradaTipo.TipWhenBlank = "Todas";
                        this.EntradaTipo.ToolTipText = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(3, 120);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(128, 24);
                        this.Label1.TabIndex = 6;
                        this.Label1.Text = "Ciudad";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSituacion
                        // 
                        this.EntradaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSituacion.AutoHeight = false;
                        this.EntradaSituacion.AutoTab = true;
                        this.EntradaSituacion.CanCreate = false;
                        this.EntradaSituacion.DetailField = "nombre";
                        this.EntradaSituacion.ExtraDetailFields = null;
                        this.EntradaSituacion.Filter = "";
                        this.EntradaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSituacion.FreeTextCode = "";
                        this.EntradaSituacion.KeyField = "id_situacion";
                        this.EntradaSituacion.Location = new System.Drawing.Point(137, 93);
                        this.EntradaSituacion.MaxLength = 200;
                        this.EntradaSituacion.Name = "EntradaSituacion";
                        this.EntradaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSituacion.ReadOnly = false;
                        this.EntradaSituacion.Required = false;
                        this.EntradaSituacion.SelectOnFocus = false;
                        this.EntradaSituacion.Size = new System.Drawing.Size(308, 24);
                        this.EntradaSituacion.TabIndex = 5;
                        this.EntradaSituacion.Table = "situaciones";
                        this.EntradaSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaSituacion.Text = "0";
                        this.EntradaSituacion.TextDetail = "";
                        this.EntradaSituacion.TextInt = 0;
                        this.EntradaSituacion.TipWhenBlank = "Todas";
                        this.EntradaSituacion.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(3, 90);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(128, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Situación";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaGrupo
                        // 
                        this.EntradaGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaGrupo.AutoHeight = false;
                        this.EntradaGrupo.AutoTab = true;
                        this.EntradaGrupo.CanCreate = true;
                        this.EntradaGrupo.DetailField = "nombre";
                        this.EntradaGrupo.ExtraDetailFields = null;
                        this.EntradaGrupo.Filter = "";
                        this.EntradaGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaGrupo.FreeTextCode = "";
                        this.EntradaGrupo.KeyField = "id_grupo";
                        this.EntradaGrupo.Location = new System.Drawing.Point(137, 33);
                        this.EntradaGrupo.MaxLength = 200;
                        this.EntradaGrupo.Name = "EntradaGrupo";
                        this.EntradaGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGrupo.ReadOnly = false;
                        this.EntradaGrupo.Required = false;
                        this.EntradaGrupo.SelectOnFocus = false;
                        this.EntradaGrupo.Size = new System.Drawing.Size(308, 24);
                        this.EntradaGrupo.TabIndex = 3;
                        this.EntradaGrupo.Table = "personas_grupos";
                        this.EntradaGrupo.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaGrupo.Text = "0";
                        this.EntradaGrupo.TextDetail = "";
                        this.EntradaGrupo.TextInt = 0;
                        this.EntradaGrupo.TipWhenBlank = "Todos";
                        this.EntradaGrupo.ToolTipText = "";
                        this.EntradaGrupo.TextChanged += new System.EventHandler(this.EntradaGrupo_TextChanged);
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(3, 30);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(128, 24);
                        this.Label3.TabIndex = 2;
                        this.Label3.Text = "Grupo";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCiudad
                        // 
                        this.EntradaCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCiudad.AutoHeight = false;
                        this.EntradaCiudad.AutoTab = true;
                        this.EntradaCiudad.CanCreate = false;
                        this.EntradaCiudad.DetailField = "nombre";
                        this.EntradaCiudad.ExtraDetailFields = null;
                        this.EntradaCiudad.Filter = "";
                        this.EntradaCiudad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCiudad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCiudad.FreeTextCode = "";
                        this.EntradaCiudad.KeyField = "id_ciudad";
                        this.EntradaCiudad.Location = new System.Drawing.Point(137, 123);
                        this.EntradaCiudad.MaxLength = 200;
                        this.EntradaCiudad.Name = "EntradaCiudad";
                        this.EntradaCiudad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCiudad.ReadOnly = false;
                        this.EntradaCiudad.Required = false;
                        this.EntradaCiudad.SelectOnFocus = false;
                        this.EntradaCiudad.Size = new System.Drawing.Size(308, 24);
                        this.EntradaCiudad.TabIndex = 7;
                        this.EntradaCiudad.Table = "ciudades";
                        this.EntradaCiudad.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCiudad.Text = "0";
                        this.EntradaCiudad.TextDetail = "";
                        this.EntradaCiudad.TextInt = 0;
                        this.EntradaCiudad.TipWhenBlank = "Todas";
                        this.EntradaCiudad.ToolTipText = "";
                        // 
                        // EntradaEstadoCredito
                        // 
                        this.EntradaEstadoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstadoCredito.AutoHeight = true;
                        this.EntradaEstadoCredito.AutoNav = true;
                        this.EntradaEstadoCredito.AutoTab = true;
                        this.EntradaEstadoCredito.DetailField = null;
                        this.EntradaEstadoCredito.Filter = null;
                        this.EntradaEstadoCredito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstadoCredito.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEstadoCredito.KeyField = null;
                        this.EntradaEstadoCredito.Location = new System.Drawing.Point(137, 153);
                        this.EntradaEstadoCredito.MaxLenght = 32767;
                        this.EntradaEstadoCredito.Name = "EntradaEstadoCredito";
                        this.EntradaEstadoCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstadoCredito.ReadOnly = false;
                        this.EntradaEstadoCredito.SetData = new string[] {
        "Cualquiera|-1",
        "Normal|0",
        "En plan de pagos|5",
        "Suspendido|10"};
                        this.EntradaEstadoCredito.Size = new System.Drawing.Size(308, 24);
                        this.EntradaEstadoCredito.TabIndex = 9;
                        this.EntradaEstadoCredito.Table = null;
                        this.EntradaEstadoCredito.Text = "Normal";
                        this.EntradaEstadoCredito.TextKey = "0";
                        this.EntradaEstadoCredito.TextRaw = "Normal";
                        this.EntradaEstadoCredito.TipWhenBlank = "";
                        this.EntradaEstadoCredito.ToolTipText = "";
                        // 
                        // label21
                        // 
                        this.label21.Location = new System.Drawing.Point(3, 150);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(128, 24);
                        this.label21.TabIndex = 8;
                        this.label21.Text = "Estado de crédito";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.Controls.Add(this.EntradaSubGrupo, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Label3, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaGrupo, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaTipo, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaEtiquetas, 1, 6);
                        this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
                        this.tableLayoutPanel1.Controls.Add(this.label21, 0, 5);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaEstadoCredito, 1, 5);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaCiudad, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaSituacion, 1, 3);
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 7;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 252);
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // EntradaSubGrupo
                        // 
                        this.EntradaSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSubGrupo.AutoHeight = false;
                        this.EntradaSubGrupo.AutoTab = true;
                        this.EntradaSubGrupo.CanCreate = true;
                        this.EntradaSubGrupo.DetailField = "nombre";
                        this.EntradaSubGrupo.ExtraDetailFields = null;
                        this.EntradaSubGrupo.Filter = "";
                        this.EntradaSubGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSubGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSubGrupo.FreeTextCode = "";
                        this.EntradaSubGrupo.KeyField = "id_grupo";
                        this.EntradaSubGrupo.Location = new System.Drawing.Point(137, 63);
                        this.EntradaSubGrupo.MaxLength = 200;
                        this.EntradaSubGrupo.Name = "EntradaSubGrupo";
                        this.EntradaSubGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubGrupo.ReadOnly = false;
                        this.EntradaSubGrupo.Required = false;
                        this.EntradaSubGrupo.SelectOnFocus = false;
                        this.EntradaSubGrupo.Size = new System.Drawing.Size(308, 24);
                        this.EntradaSubGrupo.TabIndex = 51;
                        this.EntradaSubGrupo.Table = "personas_grupos";
                        this.EntradaSubGrupo.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaSubGrupo.Text = "0";
                        this.EntradaSubGrupo.TextDetail = "";
                        this.EntradaSubGrupo.TextInt = 0;
                        this.EntradaSubGrupo.TipWhenBlank = "Todos";
                        this.EntradaSubGrupo.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(3, 60);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(128, 24);
                        this.label6.TabIndex = 51;
                        this.label6.Text = "Sub-grupo";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEtiquetas
                        // 
                        this.EntradaEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEtiquetas.AutoHeight = true;
                        this.EntradaEtiquetas.AutoNav = true;
                        this.EntradaEtiquetas.AutoTab = true;
                        this.EntradaEtiquetas.DetailField = null;
                        this.EntradaEtiquetas.Filter = null;
                        this.EntradaEtiquetas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEtiquetas.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEtiquetas.KeyField = null;
                        this.EntradaEtiquetas.Location = new System.Drawing.Point(137, 183);
                        this.EntradaEtiquetas.MaxLenght = 32767;
                        this.EntradaEtiquetas.Name = "EntradaEtiquetas";
                        this.EntradaEtiquetas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEtiquetas.ReadOnly = false;
                        this.EntradaEtiquetas.SetData = new string[] {
        "Todas|*",
        "Ninguna|-"};
                        this.EntradaEtiquetas.Size = new System.Drawing.Size(308, 24);
                        this.EntradaEtiquetas.TabIndex = 11;
                        this.EntradaEtiquetas.Table = null;
                        this.EntradaEtiquetas.Text = "Todas";
                        this.EntradaEtiquetas.TextKey = "*";
                        this.EntradaEtiquetas.TextRaw = "Todas";
                        this.EntradaEtiquetas.TipWhenBlank = "";
                        this.EntradaEtiquetas.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(3, 180);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(128, 24);
                        this.label5.TabIndex = 10;
                        this.label5.Text = "Etiqueta";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(490, 335);
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Filtros";
                        this.Text = "Artículos: Filtros";
                        this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                private void EntradaGrupo_TextChanged(object sender, EventArgs e)
                {
                        if (EntradaGrupo.TextInt != 0) {
                                EntradaSubGrupo.Filter = "parent=" + EntradaGrupo.TextInt;
                        } else {
                                EntradaSubGrupo.Filter = "0";
                                EntradaSubGrupo.TextInt = 0;
                        }
                }
        }
}