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

using System.Windows.Forms;

namespace Lfc.Personas
{
        public partial class Filtros
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

                private void InitializeComponent()
                {
                        this.Label4 = new Lui.Forms.Label();
                        this.EntradaTipo = new Lcc.Entrada.CodigoDetalle();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.Label3 = new Lui.Forms.Label();
                        this.EntradaLocalidad = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaEstadoCredito = new Lui.Forms.ComboBox();
                        this.label21 = new Lui.Forms.Label();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaFechas = new Lcc.Entrada.RangoFechas();
                        this.EntradaFechaAUsar = new Lui.Forms.ComboBox();
                        this.label7 = new Lui.Forms.Label();
                        this.EntradaSubGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.label6 = new Lui.Forms.Label();
                        this.EntradaEtiquetas = new Lui.Forms.ComboBox();
                        this.label5 = new Lui.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.tableLayoutPanel1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(354, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(474, 8);
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
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.CanCreate = true;
                        this.EntradaTipo.DataTextField = "nombre";
                        this.EntradaTipo.DataValueField = "id_tipo_persona";
                        this.EntradaTipo.ExtraDetailFields = null;
                        this.EntradaTipo.Filter = "";
                        this.EntradaTipo.FreeTextCode = "";
                        this.EntradaTipo.Location = new System.Drawing.Point(137, 3);
                        this.EntradaTipo.MaxLength = 200;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.PlaceholderText = "Todas";
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.Required = false;
                        this.EntradaTipo.Size = new System.Drawing.Size(412, 24);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.Table = "personas_tipos";
                        this.EntradaTipo.Text = "0";
                        this.EntradaTipo.TextDetail = "";
                        this.EntradaTipo.ToolTipText = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(3, 120);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(128, 24);
                        this.Label1.TabIndex = 8;
                        this.Label1.Text = "Localidad";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSituacion
                        // 
                        this.EntradaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSituacion.AutoNav = true;
                        this.EntradaSituacion.AutoTab = true;
                        this.EntradaSituacion.CanCreate = false;
                        this.EntradaSituacion.DataTextField = "nombre";
                        this.EntradaSituacion.DataValueField = "id_situacion";
                        this.EntradaSituacion.ExtraDetailFields = null;
                        this.EntradaSituacion.Filter = "";
                        this.EntradaSituacion.FreeTextCode = "";
                        this.EntradaSituacion.Location = new System.Drawing.Point(137, 93);
                        this.EntradaSituacion.MaxLength = 200;
                        this.EntradaSituacion.Name = "EntradaSituacion";
                        this.EntradaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSituacion.PlaceholderText = "Todas";
                        this.EntradaSituacion.ReadOnly = false;
                        this.EntradaSituacion.Required = false;
                        this.EntradaSituacion.Size = new System.Drawing.Size(412, 24);
                        this.EntradaSituacion.TabIndex = 7;
                        this.EntradaSituacion.Table = "situaciones";
                        this.EntradaSituacion.Text = "0";
                        this.EntradaSituacion.TextDetail = "";
                        this.EntradaSituacion.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(3, 90);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(128, 24);
                        this.Label2.TabIndex = 6;
                        this.Label2.Text = "Situación";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaGrupo
                        // 
                        this.EntradaGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaGrupo.AutoNav = true;
                        this.EntradaGrupo.AutoTab = true;
                        this.EntradaGrupo.CanCreate = true;
                        this.EntradaGrupo.DataTextField = "nombre";
                        this.EntradaGrupo.DataValueField = "id_grupo";
                        this.EntradaGrupo.ExtraDetailFields = null;
                        this.EntradaGrupo.Filter = "";
                        this.EntradaGrupo.FreeTextCode = "";
                        this.EntradaGrupo.Location = new System.Drawing.Point(137, 33);
                        this.EntradaGrupo.MaxLength = 200;
                        this.EntradaGrupo.Name = "EntradaGrupo";
                        this.EntradaGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGrupo.PlaceholderText = "Todos";
                        this.EntradaGrupo.ReadOnly = false;
                        this.EntradaGrupo.Required = false;
                        this.EntradaGrupo.Size = new System.Drawing.Size(412, 24);
                        this.EntradaGrupo.TabIndex = 3;
                        this.EntradaGrupo.Table = "personas_grupos";
                        this.EntradaGrupo.Text = "0";
                        this.EntradaGrupo.TextDetail = "";
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
                        // EntradaLocalidad
                        // 
                        this.EntradaLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaLocalidad.AutoNav = true;
                        this.EntradaLocalidad.AutoTab = true;
                        this.EntradaLocalidad.CanCreate = false;
                        this.EntradaLocalidad.DataTextField = "nombre";
                        this.EntradaLocalidad.DataValueField = "id_ciudad";
                        this.EntradaLocalidad.ExtraDetailFields = null;
                        this.EntradaLocalidad.Filter = "nivel=2";
                        this.EntradaLocalidad.FreeTextCode = "";
                        this.EntradaLocalidad.Location = new System.Drawing.Point(137, 123);
                        this.EntradaLocalidad.MaxLength = 200;
                        this.EntradaLocalidad.Name = "EntradaLocalidad";
                        this.EntradaLocalidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLocalidad.PlaceholderText = "Todas";
                        this.EntradaLocalidad.ReadOnly = false;
                        this.EntradaLocalidad.Required = false;
                        this.EntradaLocalidad.Size = new System.Drawing.Size(412, 24);
                        this.EntradaLocalidad.TabIndex = 9;
                        this.EntradaLocalidad.Table = "ciudades";
                        this.EntradaLocalidad.Text = "0";
                        this.EntradaLocalidad.TextDetail = "";
                        this.EntradaLocalidad.ToolTipText = "";
                        // 
                        // EntradaEstadoCredito
                        // 
                        this.EntradaEstadoCredito.AlwaysExpanded = false;
                        this.EntradaEstadoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstadoCredito.AutoNav = true;
                        this.EntradaEstadoCredito.AutoSize = true;
                        this.EntradaEstadoCredito.AutoTab = true;
                        this.EntradaEstadoCredito.Location = new System.Drawing.Point(137, 184);
                        this.EntradaEstadoCredito.Name = "EntradaEstadoCredito";
                        this.EntradaEstadoCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstadoCredito.PlaceholderText = "";
                        this.EntradaEstadoCredito.ReadOnly = false;
                        this.EntradaEstadoCredito.SetData = new string[] {
        "Cualquiera|-1",
        "Normal|0",
        "En plan de pagos|5",
        "Suspendido|10"};
                        this.EntradaEstadoCredito.Size = new System.Drawing.Size(412, 25);
                        this.EntradaEstadoCredito.TabIndex = 13;
                        this.EntradaEstadoCredito.TextKey = "0";
                        this.EntradaEstadoCredito.ToolTipText = "";
                        // 
                        // label21
                        // 
                        this.label21.Location = new System.Drawing.Point(3, 181);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(128, 24);
                        this.label21.TabIndex = 12;
                        this.label21.Text = "Estado de crédito";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.Controls.Add(this.EntradaFechas, 1, 8);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaFechaAUsar, 0, 8);
                        this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaSubGrupo, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Label3, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaGrupo, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaTipo, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaLocalidad, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaSituacion, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaEtiquetas, 1, 7);
                        this.tableLayoutPanel1.Controls.Add(this.label21, 0, 6);
                        this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaEstadoCredito, 1, 6);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaEstado, 1, 5);
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 9;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 321);
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // EntradaFechas
                        // 
                        this.EntradaFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFechas.AutoSize = true;
                        this.EntradaFechas.Location = new System.Drawing.Point(137, 246);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechas.ReadOnly = false;
                        this.EntradaFechas.Size = new System.Drawing.Size(412, 31);
                        this.EntradaFechas.TabIndex = 17;
                        this.EntradaFechas.ToolTipText = "";
                        // 
                        // EntradaFechaAUsar
                        // 
                        this.EntradaFechaAUsar.AlwaysExpanded = false;
                        this.EntradaFechaAUsar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFechaAUsar.AutoNav = true;
                        this.EntradaFechaAUsar.AutoSize = true;
                        this.EntradaFechaAUsar.AutoTab = true;
                        this.EntradaFechaAUsar.Location = new System.Drawing.Point(3, 246);
                        this.EntradaFechaAUsar.Name = "EntradaFechaAUsar";
                        this.EntradaFechaAUsar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaAUsar.PlaceholderText = "";
                        this.EntradaFechaAUsar.ReadOnly = false;
                        this.EntradaFechaAUsar.SetData = new string[] {
        "Fecha de Alta|fechaalta",
        "Fecha de Baja|fechabaja"};
                        this.EntradaFechaAUsar.Size = new System.Drawing.Size(128, 25);
                        this.EntradaFechaAUsar.TabIndex = 16;
                        this.EntradaFechaAUsar.TextKey = "fechaalta";
                        this.EntradaFechaAUsar.ToolTipText = "";
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(3, 212);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(128, 24);
                        this.label7.TabIndex = 14;
                        this.label7.Text = "Etiqueta";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSubGrupo
                        // 
                        this.EntradaSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSubGrupo.AutoNav = true;
                        this.EntradaSubGrupo.AutoTab = true;
                        this.EntradaSubGrupo.CanCreate = true;
                        this.EntradaSubGrupo.DataTextField = "nombre";
                        this.EntradaSubGrupo.DataValueField = "id_grupo";
                        this.EntradaSubGrupo.ExtraDetailFields = null;
                        this.EntradaSubGrupo.Filter = "";
                        this.EntradaSubGrupo.FreeTextCode = "";
                        this.EntradaSubGrupo.Location = new System.Drawing.Point(137, 63);
                        this.EntradaSubGrupo.MaxLength = 200;
                        this.EntradaSubGrupo.Name = "EntradaSubGrupo";
                        this.EntradaSubGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubGrupo.PlaceholderText = "Todos";
                        this.EntradaSubGrupo.ReadOnly = false;
                        this.EntradaSubGrupo.Required = false;
                        this.EntradaSubGrupo.Size = new System.Drawing.Size(412, 24);
                        this.EntradaSubGrupo.TabIndex = 5;
                        this.EntradaSubGrupo.Table = "personas_grupos";
                        this.EntradaSubGrupo.Text = "0";
                        this.EntradaSubGrupo.TextDetail = "";
                        this.EntradaSubGrupo.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(3, 60);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(128, 24);
                        this.label6.TabIndex = 4;
                        this.label6.Text = "Sub-grupo";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEtiquetas
                        // 
                        this.EntradaEtiquetas.AlwaysExpanded = false;
                        this.EntradaEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEtiquetas.AutoNav = true;
                        this.EntradaEtiquetas.AutoSize = true;
                        this.EntradaEtiquetas.AutoTab = true;
                        this.EntradaEtiquetas.Location = new System.Drawing.Point(137, 215);
                        this.EntradaEtiquetas.Name = "EntradaEtiquetas";
                        this.EntradaEtiquetas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEtiquetas.PlaceholderText = "";
                        this.EntradaEtiquetas.ReadOnly = false;
                        this.EntradaEtiquetas.SetData = new string[] {
        "Todas|*",
        "Ninguna|-"};
                        this.EntradaEtiquetas.Size = new System.Drawing.Size(412, 25);
                        this.EntradaEtiquetas.TabIndex = 15;
                        this.EntradaEtiquetas.TextKey = "*";
                        this.EntradaEtiquetas.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(3, 150);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(128, 24);
                        this.label5.TabIndex = 10;
                        this.label5.Text = "Estado";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AlwaysExpanded = false;
                        this.EntradaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoSize = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.Location = new System.Drawing.Point(137, 153);
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.PlaceholderText = "";
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "Todos|-1",
        "Activos|1",
        "Inactivos|0"};
                        this.EntradaEstado.Size = new System.Drawing.Size(412, 25);
                        this.EntradaEstado.TabIndex = 11;
                        this.EntradaEstado.TextKey = "1";
                        this.EntradaEstado.ToolTipText = "";
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(594, 407);
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Filtros";
                        this.Text = "Personas: Filtros";
                        this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.tableLayoutPanel1.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.Label Label4;
                private Lui.Forms.Label Label1;
                private Lui.Forms.Label Label2;
                internal Lcc.Entrada.CodigoDetalle EntradaTipo;
                internal Lcc.Entrada.CodigoDetalle EntradaSituacion;
                internal Lcc.Entrada.CodigoDetalle EntradaLocalidad;
                internal Lcc.Entrada.CodigoDetalle EntradaGrupo;
                internal Lui.Forms.ComboBox EntradaEstadoCredito;
                private Label label21;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lui.Forms.ComboBox EntradaEtiquetas;
                private Label label5;
                internal Lcc.Entrada.CodigoDetalle EntradaSubGrupo;
                private Label label6;
                private Label label7;
                internal Lui.Forms.ComboBox EntradaEstado;
                private Lui.Forms.Label Label3;
                internal Lui.Forms.ComboBox EntradaFechaAUsar;
                internal Lcc.Entrada.RangoFechas EntradaFechas;
        }
}
