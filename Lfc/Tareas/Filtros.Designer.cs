#region License
// Copyright 2004-2011 Ernesto N. Carrea
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

namespace Lfc.Tareas
{
        public partial class Filtros
        {
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

                #region Código generado por el Diseñador de Windows Forms

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.ComboBox EntradaOrden;
                internal Lcc.Entrada.CodigoDetalle EntradaCliente;
                internal Lcc.Entrada.CodigoDetalle EntradaTarea;
                internal Lui.Forms.Label Label4;
                internal Lcc.Entrada.CodigoDetalle EntradaLocalidad;
                internal Lui.Forms.Label label5;
                private TableLayoutPanel tableLayoutPanel1;
                internal Label label3;
                internal Lcc.Entrada.CodigoDetalle EntradaGrupo;
                internal Label label6;
                internal Lui.Forms.ComboBox EntradaEstado;

                private void InitializeComponent()
                {
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaOrden = new Lui.Forms.ComboBox();
                        this.EntradaTarea = new Lcc.Entrada.CodigoDetalle();
                        this.Label4 = new Lui.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.EntradaLocalidad = new Lcc.Entrada.CodigoDetalle();
                        this.label5 = new Lui.Forms.Label();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.label6 = new Lui.Forms.Label();
                        this.label3 = new Lui.Forms.Label();
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
                        // EntradaCliente
                        // 
                        this.EntradaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCliente.AutoNav = true;
                        this.EntradaCliente.AutoTab = true;
                        this.EntradaCliente.CanCreate = false;
                        this.EntradaCliente.DataTextField = "nombre_visible";
                        this.EntradaCliente.DataValueField = "id_persona";
                        this.EntradaCliente.ExtraDetailFields = null;
                        this.EntradaCliente.Filter = "(tipo&1)=1";
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.Location = new System.Drawing.Point(97, 3);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "EntradaCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.Required = false;
                        this.EntradaCliente.Size = new System.Drawing.Size(444, 24);
                        this.EntradaCliente.TabIndex = 1;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(3, 0);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(88, 24);
                        this.Label2.TabIndex = 0;
                        this.Label2.Text = "Cliente";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(3, 120);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(88, 24);
                        this.Label1.TabIndex = 8;
                        this.Label1.Text = "Estado";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaOrden
                        // 
                        this.EntradaOrden.AlwaysExpanded = true;
                        this.EntradaOrden.AutoNav = true;
                        this.EntradaOrden.AutoSize = true;
                        this.EntradaOrden.AutoTab = true;
                        this.EntradaOrden.Location = new System.Drawing.Point(97, 210);
                        this.EntradaOrden.Name = "EntradaOrden";
                        this.EntradaOrden.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaOrden.SetData = new string[] {
        "Los más nuevos primero|tickets.id_ticket DESC",
        "Los más antiguos primero|tickets.id_ticket",
        "Por nombre del Cliente|personas.nombre_visible"};
                        this.EntradaOrden.Size = new System.Drawing.Size(299, 51);
                        this.EntradaOrden.TabIndex = 11;
                        this.EntradaOrden.TextKey = "tickets.id_ticket DESC";
                        // 
                        // EntradaTarea
                        // 
                        this.EntradaTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTarea.AutoNav = true;
                        this.EntradaTarea.AutoTab = true;
                        this.EntradaTarea.CanCreate = false;
                        this.EntradaTarea.DataTextField = "nombre";
                        this.EntradaTarea.DataValueField = "id_tipo_ticket";
                        this.EntradaTarea.ExtraDetailFields = null;
                        this.EntradaTarea.Filter = "";
                        this.EntradaTarea.FreeTextCode = "";
                        this.EntradaTarea.Location = new System.Drawing.Point(97, 93);
                        this.EntradaTarea.MaxLength = 200;
                        this.EntradaTarea.Name = "EntradaTarea";
                        this.EntradaTarea.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTarea.Required = false;
                        this.EntradaTarea.Size = new System.Drawing.Size(444, 24);
                        this.EntradaTarea.TabIndex = 7;
                        this.EntradaTarea.Table = "tickets_tipos";
                        this.EntradaTarea.Text = "0";
                        this.EntradaTarea.TextDetail = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(3, 90);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(88, 24);
                        this.Label4.TabIndex = 6;
                        this.Label4.Text = "Tipo";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AlwaysExpanded = true;
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoSize = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.Location = new System.Drawing.Point(97, 123);
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.SetData = new string[] {
        "Todos|todos",
        "Sin Terminar|<30",
        "Terminados Sin Verificar|<40",
        "Terminados Sin Entregar|<50"};
                        this.EntradaEstado.Size = new System.Drawing.Size(299, 81);
                        this.EntradaEstado.TabIndex = 9;
                        this.EntradaEstado.TextKey = "<30";
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
                        this.EntradaLocalidad.Filter = "";
                        this.EntradaLocalidad.FreeTextCode = "";
                        this.EntradaLocalidad.Location = new System.Drawing.Point(97, 33);
                        this.EntradaLocalidad.MaxLength = 200;
                        this.EntradaLocalidad.Name = "EntradaLocalidad";
                        this.EntradaLocalidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLocalidad.Required = false;
                        this.EntradaLocalidad.Size = new System.Drawing.Size(444, 24);
                        this.EntradaLocalidad.TabIndex = 3;
                        this.EntradaLocalidad.Table = "ciudades";
                        this.EntradaLocalidad.Text = "0";
                        this.EntradaLocalidad.TextDetail = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(3, 30);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(88, 24);
                        this.label5.TabIndex = 2;
                        this.label5.Text = "Localidad";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaOrden, 1, 5);
                        this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaLocalidad, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaCliente, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaGrupo, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaEstado, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaTarea, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label4, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 24);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 6;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 280);
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // EntradaGrupo
                        // 
                        this.EntradaGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaGrupo.AutoNav = true;
                        this.EntradaGrupo.AutoTab = true;
                        this.EntradaGrupo.CanCreate = false;
                        this.EntradaGrupo.DataTextField = "nombre";
                        this.EntradaGrupo.DataValueField = "id_grupo";
                        this.EntradaGrupo.ExtraDetailFields = null;
                        this.EntradaGrupo.Filter = "";
                        this.EntradaGrupo.FreeTextCode = "";
                        this.EntradaGrupo.Location = new System.Drawing.Point(97, 63);
                        this.EntradaGrupo.MaxLength = 200;
                        this.EntradaGrupo.Name = "EntradaGrupo";
                        this.EntradaGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGrupo.Required = false;
                        this.EntradaGrupo.Size = new System.Drawing.Size(444, 24);
                        this.EntradaGrupo.TabIndex = 5;
                        this.EntradaGrupo.Table = "personas_grupos";
                        this.EntradaGrupo.Text = "0";
                        this.EntradaGrupo.TextDetail = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(3, 60);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(88, 24);
                        this.label6.TabIndex = 4;
                        this.label6.Text = "Grupo";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(3, 207);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(88, 24);
                        this.label3.TabIndex = 10;
                        this.label3.Text = "Orden";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(594, 375);
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Filtros";
                        this.Text = "Tickets: Filtros";
                        this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.tableLayoutPanel1.PerformLayout();
                        this.ResumeLayout(false);

                }
                #endregion
        }
}
