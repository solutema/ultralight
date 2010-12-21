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

namespace Lfc.Tareas
{
        public class Filtros : Lui.Forms.DialogForm
        {
                #region Código generado por el Diseñador de Windows Forms

                public Filtros()
                        : base()
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
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.ComboBox EntradaOrden;
                internal Lcc.Entrada.CodigoDetalle EntradaCliente;
                internal Lcc.Entrada.CodigoDetalle EntradaTarea;
                internal System.Windows.Forms.Label Label4;
                internal Lcc.Entrada.CodigoDetalle EntradaSucursal;
                internal System.Windows.Forms.Label label5;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lui.Forms.ComboBox EntradaEstado;

                private void InitializeComponent()
                {
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaOrden = new Lui.Forms.ComboBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaTarea = new Lcc.Entrada.CodigoDetalle();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.EntradaSucursal = new Lcc.Entrada.CodigoDetalle();
                        this.label5 = new System.Windows.Forms.Label();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
                        // txtCliente
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
                        this.EntradaCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.Location = new System.Drawing.Point(97, 33);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "txtCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.Required = false;
                        this.EntradaCliente.Size = new System.Drawing.Size(444, 24);
                        this.EntradaCliente.TabIndex = 3;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        this.EntradaCliente.TipWhenBlank = "";
                        this.EntradaCliente.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(3, 30);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(88, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Cliente";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(3, 90);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(88, 24);
                        this.Label1.TabIndex = 6;
                        this.Label1.Text = "Estado";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtOrden
                        // 
                        this.EntradaOrden.AlwaysExpanded = true;
                        this.EntradaOrden.AutoNav = true;
                        this.EntradaOrden.AutoSize = true;
                        this.EntradaOrden.AutoTab = true;
                        this.EntradaOrden.DetailField = null;
                        this.EntradaOrden.Filter = null;
                        this.EntradaOrden.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaOrden.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaOrden.KeyField = null;
                        this.EntradaOrden.Location = new System.Drawing.Point(97, 180);
                        this.EntradaOrden.MaxLenght = 32767;
                        this.EntradaOrden.Name = "txtOrden";
                        this.EntradaOrden.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaOrden.SetData = new string[] {
        "Los más nuevos primero|tickets.id_ticket DESC",
        "Los más antiguos primero|tickets.id_ticket"};
                        this.EntradaOrden.Size = new System.Drawing.Size(231, 36);
                        this.EntradaOrden.TabIndex = 9;
                        this.EntradaOrden.Table = null;
                        this.EntradaOrden.TextKey = "tickets.id_ticket DESC";
                        this.EntradaOrden.TipWhenBlank = "";
                        this.EntradaOrden.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(3, 177);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(88, 24);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "Orden";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTarea
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
                        this.EntradaTarea.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTarea.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTarea.FreeTextCode = "";
                        this.EntradaTarea.Location = new System.Drawing.Point(97, 63);
                        this.EntradaTarea.MaxLength = 200;
                        this.EntradaTarea.Name = "txtTarea";
                        this.EntradaTarea.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTarea.Required = false;
                        this.EntradaTarea.Size = new System.Drawing.Size(444, 24);
                        this.EntradaTarea.TabIndex = 5;
                        this.EntradaTarea.Table = "tickets_tipos";
                        this.EntradaTarea.Text = "0";
                        this.EntradaTarea.TextDetail = "";
                        this.EntradaTarea.TipWhenBlank = "";
                        this.EntradaTarea.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(3, 60);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(88, 24);
                        this.Label4.TabIndex = 4;
                        this.Label4.Text = "Tarea";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtEstado
                        // 
                        this.EntradaEstado.AlwaysExpanded = true;
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoSize = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.DetailField = null;
                        this.EntradaEstado.Filter = null;
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEstado.KeyField = null;
                        this.EntradaEstado.Location = new System.Drawing.Point(97, 93);
                        this.EntradaEstado.MaxLenght = 32767;
                        this.EntradaEstado.Name = "txtEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.SetData = new string[] {
        "Todos|todos",
        "Nuevos|0",
        "Activos|5",
        "Presupuestados|presupuestados",
        "Terminados|terminados",
        "Sin Terminar|sin_terminar",
        "Terminados Sin Verificar|sin_verificar",
        "Terminados Sin Entregar|sin_entregar"};
                        this.EntradaEstado.Size = new System.Drawing.Size(235, 81);
                        this.EntradaEstado.TabIndex = 7;
                        this.EntradaEstado.Table = null;
                        this.EntradaEstado.TextKey = "sin_terminar";
                        this.EntradaEstado.TipWhenBlank = "";
                        this.EntradaEstado.ToolTipText = "";
                        // 
                        // txtSucursal
                        // 
                        this.EntradaSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSucursal.AutoNav = true;
                        this.EntradaSucursal.AutoTab = true;
                        this.EntradaSucursal.CanCreate = false;
                        this.EntradaSucursal.DataTextField = "nombre";
                        this.EntradaSucursal.DataValueField = "id_sucursal";
                        this.EntradaSucursal.ExtraDetailFields = null;
                        this.EntradaSucursal.Filter = "";
                        this.EntradaSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSucursal.FreeTextCode = "";
                        this.EntradaSucursal.Location = new System.Drawing.Point(97, 3);
                        this.EntradaSucursal.MaxLength = 200;
                        this.EntradaSucursal.Name = "txtSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.Required = false;
                        this.EntradaSucursal.Size = new System.Drawing.Size(444, 24);
                        this.EntradaSucursal.TabIndex = 1;
                        this.EntradaSucursal.Table = "sucursales";
                        this.EntradaSucursal.Text = "0";
                        this.EntradaSucursal.TextDetail = "";
                        this.EntradaSucursal.TipWhenBlank = "";
                        this.EntradaSucursal.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(3, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(88, 24);
                        this.label5.TabIndex = 0;
                        this.label5.Text = "Sucursal";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaOrden, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaEstado, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaSucursal, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaTarea, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Label4, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaCliente, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label3, 0, 4);
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 24);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 5;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 280);
                        this.tableLayoutPanel1.TabIndex = 0;
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