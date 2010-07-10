#region License
// Copyright 2004-2010 South Bridge S.R.L.
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
using System.Collections;
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
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.ComboBox txtOrden;
                internal Lui.Forms.DetailBox txtCliente;
                internal Lui.Forms.DetailBox txtTarea;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.DetailBox txtSucursal;
                internal System.Windows.Forms.Label label5;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lui.Forms.ComboBox txtEstado;

                private void InitializeComponent()
                {
                        this.txtCliente = new Lui.Forms.DetailBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtOrden = new Lui.Forms.ComboBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtTarea = new Lui.Forms.DetailBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtEstado = new Lui.Forms.ComboBox();
                        this.txtSucursal = new Lui.Forms.DetailBox();
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
                        this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCliente.AutoHeight = true;
                        this.txtCliente.AutoTab = true;
                        this.txtCliente.CanCreate = false;
                        this.txtCliente.DetailField = "nombre_visible";
                        this.txtCliente.ExtraDetailFields = null;
                        this.txtCliente.Filter = "(tipo&1)=1";
                        this.txtCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCliente.FreeTextCode = "";
                        this.txtCliente.KeyField = "id_persona";
                        this.txtCliente.Location = new System.Drawing.Point(97, 33);
                        this.txtCliente.MaxLength = 200;
                        this.txtCliente.Name = "txtCliente";
                        this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCliente.ReadOnly = false;
                        this.txtCliente.Required = false;
                        this.txtCliente.SelectOnFocus = true;
                        this.txtCliente.Size = new System.Drawing.Size(444, 24);
                        this.txtCliente.TabIndex = 3;
                        this.txtCliente.Table = "personas";
                        this.txtCliente.TeclaDespuesDeEnter = "{tab}";
                        this.txtCliente.Text = "0";
                        this.txtCliente.TextDetail = "";
                        this.txtCliente.TextInt = 0;
                        this.txtCliente.TipWhenBlank = "";
                        this.txtCliente.ToolTipText = "";
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
                        this.txtOrden.AutoHeight = true;
                        this.txtOrden.AutoNav = true;
                        this.txtOrden.AutoTab = true;
                        this.txtOrden.DetailField = null;
                        this.txtOrden.Filter = null;
                        this.txtOrden.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtOrden.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtOrden.KeyField = null;
                        this.txtOrden.Location = new System.Drawing.Point(97, 123);
                        this.txtOrden.MaxLenght = 32767;
                        this.txtOrden.Name = "txtOrden";
                        this.txtOrden.Padding = new System.Windows.Forms.Padding(2);
                        this.txtOrden.ReadOnly = false;
                        this.txtOrden.SetData = new string[] {
        "Los más nuevos primero|tickets.id_ticket DESC",
        "Los más antiguos primero|tickets.id_ticket"};
                        this.txtOrden.Size = new System.Drawing.Size(231, 25);
                        this.txtOrden.TabIndex = 9;
                        this.txtOrden.Table = null;
                        this.txtOrden.Text = "Los más nuevos primero";
                        this.txtOrden.TextKey = "tickets.id_ticket DESC";
                        this.txtOrden.TextRaw = "Los más nuevos primero";
                        this.txtOrden.TipWhenBlank = "";
                        this.txtOrden.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(3, 120);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(88, 24);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "Orden";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTarea
                        // 
                        this.txtTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTarea.AutoHeight = true;
                        this.txtTarea.AutoTab = true;
                        this.txtTarea.CanCreate = false;
                        this.txtTarea.DetailField = "nombre";
                        this.txtTarea.ExtraDetailFields = null;
                        this.txtTarea.Filter = "";
                        this.txtTarea.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTarea.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTarea.FreeTextCode = "";
                        this.txtTarea.KeyField = "id_tipo_ticket";
                        this.txtTarea.Location = new System.Drawing.Point(97, 63);
                        this.txtTarea.MaxLength = 200;
                        this.txtTarea.Name = "txtTarea";
                        this.txtTarea.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTarea.ReadOnly = false;
                        this.txtTarea.Required = false;
                        this.txtTarea.SelectOnFocus = true;
                        this.txtTarea.Size = new System.Drawing.Size(444, 24);
                        this.txtTarea.TabIndex = 5;
                        this.txtTarea.Table = "tickets_tipos";
                        this.txtTarea.TeclaDespuesDeEnter = "{tab}";
                        this.txtTarea.Text = "0";
                        this.txtTarea.TextDetail = "";
                        this.txtTarea.TextInt = 0;
                        this.txtTarea.TipWhenBlank = "";
                        this.txtTarea.ToolTipText = "";
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
                        this.txtEstado.AutoHeight = true;
                        this.txtEstado.AutoNav = true;
                        this.txtEstado.AutoTab = true;
                        this.txtEstado.DetailField = null;
                        this.txtEstado.Filter = null;
                        this.txtEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtEstado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtEstado.KeyField = null;
                        this.txtEstado.Location = new System.Drawing.Point(97, 93);
                        this.txtEstado.MaxLenght = 32767;
                        this.txtEstado.Name = "txtEstado";
                        this.txtEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEstado.ReadOnly = false;
                        this.txtEstado.SetData = new string[] {
        "Todos|todos",
        "Nuevos|0",
        "Activos|5",
        "Presupuestados|presupuestados",
        "Terminados|terminados",
        "Sin Terminar|sin_terminar",
        "Terminados Sin Verificar|sin_verificar",
        "Terminados Sin Entregar|sin_entregar"};
                        this.txtEstado.Size = new System.Drawing.Size(235, 24);
                        this.txtEstado.TabIndex = 7;
                        this.txtEstado.Table = null;
                        this.txtEstado.Text = "Sin Terminar";
                        this.txtEstado.TextKey = "sin_terminar";
                        this.txtEstado.TextRaw = "Sin Terminar";
                        this.txtEstado.TipWhenBlank = "";
                        this.txtEstado.ToolTipText = "";
                        // 
                        // txtSucursal
                        // 
                        this.txtSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtSucursal.AutoHeight = true;
                        this.txtSucursal.AutoTab = true;
                        this.txtSucursal.CanCreate = false;
                        this.txtSucursal.DetailField = "nombre";
                        this.txtSucursal.ExtraDetailFields = null;
                        this.txtSucursal.Filter = "";
                        this.txtSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtSucursal.FreeTextCode = "";
                        this.txtSucursal.KeyField = "id_sucursal";
                        this.txtSucursal.Location = new System.Drawing.Point(97, 3);
                        this.txtSucursal.MaxLength = 200;
                        this.txtSucursal.Name = "txtSucursal";
                        this.txtSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSucursal.ReadOnly = false;
                        this.txtSucursal.Required = false;
                        this.txtSucursal.SelectOnFocus = true;
                        this.txtSucursal.Size = new System.Drawing.Size(444, 24);
                        this.txtSucursal.TabIndex = 1;
                        this.txtSucursal.Table = "sucursales";
                        this.txtSucursal.TeclaDespuesDeEnter = "{tab}";
                        this.txtSucursal.Text = "0";
                        this.txtSucursal.TextDetail = "";
                        this.txtSucursal.TextInt = 0;
                        this.txtSucursal.TipWhenBlank = "";
                        this.txtSucursal.ToolTipText = "";
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
                        this.tableLayoutPanel1.Controls.Add(this.txtOrden, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.txtEstado, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.txtSucursal, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.txtTarea, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Label4, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.txtCliente, 1, 1);
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
                        this.ResumeLayout(false);

                }
                #endregion
        }
}