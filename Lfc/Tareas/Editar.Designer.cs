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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Tareas
{
        public partial class Editar : Lui.Forms.EditForm
        {
                #region Código generado por el Diseñador de Windows Forms

                // Limpiar los recursos que se están utilizando.
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

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtCliente = new Lui.Forms.DetailBox();
                        this.txtTarea = new Lui.Forms.DetailBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtTecnico = new Lui.Forms.DetailBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtAsunto = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.txtDescripcion = new Lui.Forms.TextBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.txtEntregaEstimada = new Lui.Forms.TextBox();
                        this.txtEntregaLimite = new Lui.Forms.TextBox();
                        this.txtPresupuesto = new Lui.Forms.TextBox();
                        this.txtObs = new Lui.Forms.TextBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.Frame2 = new Lui.Forms.Frame();
                        this.lvHistorial = new Lui.Forms.ListView();
                        this.Ticket = new System.Windows.Forms.ColumnHeader();
                        this.Tecnico = new System.Windows.Forms.ColumnHeader();
                        this.Fecha = new System.Windows.Forms.ColumnHeader();
                        this.Detalle = new System.Windows.Forms.ColumnHeader();
                        this.cmdNovedad = new Lui.Forms.Button();
                        this.cmdArticulos = new Lui.Forms.Button();
                        this.txtEstado = new Lui.Forms.DetailBox();
                        this.cmdFacturar = new Lui.Forms.Button();
                        this.txtFechaIngreso = new Lui.Forms.TextBox();
                        this.Label12 = new System.Windows.Forms.Label();
                        this.txtComprobante = new Lui.Forms.TextBox();
                        this.Label13 = new System.Windows.Forms.Label();
                        this.txtComprobanteId = new System.Windows.Forms.TextBox();
                        this.txtNumero = new Lui.Forms.TextBox();
                        this.txtPresupuesto2 = new Lui.Forms.TextBox();
                        this.txtPrioridad = new Lui.Forms.ComboBox();
                        this.Label14 = new System.Windows.Forms.Label();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(476, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(584, 8);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(8, 8);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(84, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Cliente";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCliente
                        // 
                        this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCliente.AutoHeight = false;
                        this.txtCliente.AutoTab = true;
                        this.txtCliente.CanCreate = true;
                        this.txtCliente.DetailField = "nombre_visible";
                        this.txtCliente.ExtraDetailFields = null;
                        this.txtCliente.Filter = "";
                        this.txtCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCliente.FreeTextCode = "";
                        this.txtCliente.KeyField = "id_persona";
                        this.txtCliente.Location = new System.Drawing.Point(92, 8);
                        this.txtCliente.MaxLength = 200;
                        this.txtCliente.Name = "txtCliente";
                        this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCliente.ReadOnly = false;
                        this.txtCliente.Required = true;
                        this.txtCliente.SelectOnFocus = true;
                        this.txtCliente.Size = new System.Drawing.Size(300, 24);
                        this.txtCliente.TabIndex = 1;
                        this.txtCliente.Table = "personas";
                        this.txtCliente.TeclaDespuesDeEnter = "{tab}";
                        this.txtCliente.Text = "0";
                        this.txtCliente.TextDetail = "";
                        this.txtCliente.TextInt = 0;
                        this.txtCliente.TipWhenBlank = "";
                        this.txtCliente.ToolTipText = "";
                        // 
                        // txtTarea
                        // 
                        this.txtTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTarea.AutoHeight = false;
                        this.txtTarea.AutoTab = true;
                        this.txtTarea.CanCreate = true;
                        this.txtTarea.DetailField = "nombre";
                        this.txtTarea.ExtraDetailFields = null;
                        this.txtTarea.Filter = "";
                        this.txtTarea.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTarea.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTarea.FreeTextCode = "";
                        this.txtTarea.KeyField = "id_tipo_ticket";
                        this.txtTarea.Location = new System.Drawing.Point(92, 36);
                        this.txtTarea.MaxLength = 200;
                        this.txtTarea.Name = "txtTarea";
                        this.txtTarea.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTarea.ReadOnly = false;
                        this.txtTarea.Required = true;
                        this.txtTarea.SelectOnFocus = true;
                        this.txtTarea.Size = new System.Drawing.Size(300, 24);
                        this.txtTarea.TabIndex = 3;
                        this.txtTarea.Table = "tickets_tipos";
                        this.txtTarea.TeclaDespuesDeEnter = "{tab}";
                        this.txtTarea.Text = "0";
                        this.txtTarea.TextDetail = "";
                        this.txtTarea.TextInt = 0;
                        this.txtTarea.TipWhenBlank = "";
                        this.txtTarea.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(8, 36);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(84, 24);
                        this.Label3.TabIndex = 2;
                        this.Label3.Text = "Tarea";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTecnico
                        // 
                        this.txtTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTecnico.AutoHeight = false;
                        this.txtTecnico.AutoTab = true;
                        this.txtTecnico.CanCreate = true;
                        this.txtTecnico.DetailField = "nombre_visible";
                        this.txtTecnico.ExtraDetailFields = null;
                        this.txtTecnico.Filter = "(tipo&4)=4";
                        this.txtTecnico.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTecnico.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTecnico.FreeTextCode = "";
                        this.txtTecnico.KeyField = "id_persona";
                        this.txtTecnico.Location = new System.Drawing.Point(92, 64);
                        this.txtTecnico.MaxLength = 200;
                        this.txtTecnico.Name = "txtTecnico";
                        this.txtTecnico.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTecnico.ReadOnly = false;
                        this.txtTecnico.Required = true;
                        this.txtTecnico.SelectOnFocus = true;
                        this.txtTecnico.Size = new System.Drawing.Size(300, 24);
                        this.txtTecnico.TabIndex = 5;
                        this.txtTecnico.Table = "personas";
                        this.txtTecnico.TeclaDespuesDeEnter = "{tab}";
                        this.txtTecnico.Text = "0";
                        this.txtTecnico.TextDetail = "";
                        this.txtTecnico.TextInt = 0;
                        this.txtTecnico.TipWhenBlank = "";
                        this.txtTecnico.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(8, 64);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(84, 24);
                        this.Label4.TabIndex = 4;
                        this.Label4.Text = "Encargado";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(8, 96);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(84, 24);
                        this.Label5.TabIndex = 6;
                        this.Label5.Text = "Asunto";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtAsunto
                        // 
                        this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtAsunto.AutoHeight = false;
                        this.txtAsunto.AutoNav = true;
                        this.txtAsunto.AutoTab = true;
                        this.txtAsunto.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtAsunto.DecimalPlaces = -1;
                        this.txtAsunto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtAsunto.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtAsunto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtAsunto.Location = new System.Drawing.Point(92, 96);
                        this.txtAsunto.MaxLenght = 32767;
                        this.txtAsunto.MultiLine = false;
                        this.txtAsunto.Name = "txtAsunto";
                        this.txtAsunto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtAsunto.PasswordChar = '\0';
                        this.txtAsunto.Prefijo = "";
                        this.txtAsunto.ReadOnly = false;
                        this.txtAsunto.SelectOnFocus = false;
                        this.txtAsunto.Size = new System.Drawing.Size(300, 24);
                        this.txtAsunto.Sufijo = "";
                        this.txtAsunto.TabIndex = 7;
                        this.txtAsunto.TextRaw = "";
                        this.txtAsunto.TipWhenBlank = "";
                        this.txtAsunto.ToolTipText = "";
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label6.Location = new System.Drawing.Point(400, 36);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(56, 24);
                        this.Label6.TabIndex = 13;
                        this.Label6.Text = "Estado";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(8, 124);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(88, 24);
                        this.Label7.TabIndex = 8;
                        this.Label7.Text = "Descripción";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtDescripcion
                        // 
                        this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtDescripcion.AutoHeight = false;
                        this.txtDescripcion.AutoNav = true;
                        this.txtDescripcion.AutoTab = true;
                        this.txtDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtDescripcion.DecimalPlaces = -1;
                        this.txtDescripcion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDescripcion.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtDescripcion.Location = new System.Drawing.Point(92, 124);
                        this.txtDescripcion.MaxLenght = 32767;
                        this.txtDescripcion.MultiLine = true;
                        this.txtDescripcion.Name = "txtDescripcion";
                        this.txtDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDescripcion.PasswordChar = '\0';
                        this.txtDescripcion.Prefijo = "";
                        this.txtDescripcion.ReadOnly = false;
                        this.txtDescripcion.SelectOnFocus = false;
                        this.txtDescripcion.Size = new System.Drawing.Size(300, 84);
                        this.txtDescripcion.Sufijo = "";
                        this.txtDescripcion.TabIndex = 9;
                        this.txtDescripcion.TextRaw = "";
                        this.txtDescripcion.TipWhenBlank = "";
                        this.txtDescripcion.ToolTipText = "";
                        // 
                        // Label8
                        // 
                        this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label8.Location = new System.Drawing.Point(400, 96);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(156, 24);
                        this.Label8.TabIndex = 17;
                        this.Label8.Text = "Fecha Final. Estimada";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label9
                        // 
                        this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label9.Location = new System.Drawing.Point(400, 124);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(156, 24);
                        this.Label9.TabIndex = 19;
                        this.Label9.Text = "Fecha Final. Límite";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label10
                        // 
                        this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label10.Location = new System.Drawing.Point(400, 188);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(100, 24);
                        this.Label10.TabIndex = 23;
                        this.Label10.Text = "Presupuesto";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtEntregaEstimada
                        // 
                        this.txtEntregaEstimada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtEntregaEstimada.AutoHeight = false;
                        this.txtEntregaEstimada.AutoNav = true;
                        this.txtEntregaEstimada.AutoTab = true;
                        this.txtEntregaEstimada.DataType = Lui.Forms.DataTypes.Date;
                        this.txtEntregaEstimada.DecimalPlaces = -1;
                        this.txtEntregaEstimada.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtEntregaEstimada.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtEntregaEstimada.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtEntregaEstimada.Location = new System.Drawing.Point(552, 96);
                        this.txtEntregaEstimada.MaxLenght = 32767;
                        this.txtEntregaEstimada.MultiLine = false;
                        this.txtEntregaEstimada.Name = "txtEntregaEstimada";
                        this.txtEntregaEstimada.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEntregaEstimada.PasswordChar = '\0';
                        this.txtEntregaEstimada.Prefijo = "";
                        this.txtEntregaEstimada.ReadOnly = false;
                        this.txtEntregaEstimada.SelectOnFocus = true;
                        this.txtEntregaEstimada.Size = new System.Drawing.Size(96, 24);
                        this.txtEntregaEstimada.Sufijo = "";
                        this.txtEntregaEstimada.TabIndex = 18;
                        this.txtEntregaEstimada.TextRaw = "";
                        this.txtEntregaEstimada.TipWhenBlank = "";
                        this.txtEntregaEstimada.ToolTipText = "";
                        // 
                        // txtEntregaLimite
                        // 
                        this.txtEntregaLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtEntregaLimite.AutoHeight = false;
                        this.txtEntregaLimite.AutoNav = true;
                        this.txtEntregaLimite.AutoTab = true;
                        this.txtEntregaLimite.DataType = Lui.Forms.DataTypes.Date;
                        this.txtEntregaLimite.DecimalPlaces = -1;
                        this.txtEntregaLimite.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtEntregaLimite.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtEntregaLimite.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtEntregaLimite.Location = new System.Drawing.Point(552, 124);
                        this.txtEntregaLimite.MaxLenght = 32767;
                        this.txtEntregaLimite.MultiLine = false;
                        this.txtEntregaLimite.Name = "txtEntregaLimite";
                        this.txtEntregaLimite.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEntregaLimite.PasswordChar = '\0';
                        this.txtEntregaLimite.Prefijo = "";
                        this.txtEntregaLimite.ReadOnly = false;
                        this.txtEntregaLimite.SelectOnFocus = true;
                        this.txtEntregaLimite.Size = new System.Drawing.Size(96, 24);
                        this.txtEntregaLimite.Sufijo = "";
                        this.txtEntregaLimite.TabIndex = 20;
                        this.txtEntregaLimite.TextRaw = "";
                        this.txtEntregaLimite.TipWhenBlank = "";
                        this.txtEntregaLimite.ToolTipText = "";
                        // 
                        // txtPresupuesto
                        // 
                        this.txtPresupuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtPresupuesto.AutoHeight = false;
                        this.txtPresupuesto.AutoNav = true;
                        this.txtPresupuesto.AutoTab = true;
                        this.txtPresupuesto.DataType = Lui.Forms.DataTypes.Money;
                        this.txtPresupuesto.DecimalPlaces = -1;
                        this.txtPresupuesto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPresupuesto.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPresupuesto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPresupuesto.Location = new System.Drawing.Point(500, 188);
                        this.txtPresupuesto.MaxLenght = 32767;
                        this.txtPresupuesto.MultiLine = false;
                        this.txtPresupuesto.Name = "txtPresupuesto";
                        this.txtPresupuesto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPresupuesto.PasswordChar = '\0';
                        this.txtPresupuesto.Prefijo = "$";
                        this.txtPresupuesto.ReadOnly = false;
                        this.txtPresupuesto.SelectOnFocus = true;
                        this.txtPresupuesto.Size = new System.Drawing.Size(80, 24);
                        this.txtPresupuesto.Sufijo = "";
                        this.txtPresupuesto.TabIndex = 24;
                        this.txtPresupuesto.Text = "0.00";
                        this.txtPresupuesto.TextRaw = "0.00";
                        this.txtPresupuesto.TipWhenBlank = "";
                        this.txtPresupuesto.ToolTipText = "";
                        // 
                        // txtObs
                        // 
                        this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtObs.AutoHeight = false;
                        this.txtObs.AutoNav = true;
                        this.txtObs.AutoTab = true;
                        this.txtObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtObs.DecimalPlaces = -1;
                        this.txtObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtObs.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtObs.Location = new System.Drawing.Point(92, 216);
                        this.txtObs.MaxLenght = 32767;
                        this.txtObs.MultiLine = true;
                        this.txtObs.Name = "txtObs";
                        this.txtObs.Padding = new System.Windows.Forms.Padding(2);
                        this.txtObs.PasswordChar = '\0';
                        this.txtObs.Prefijo = "";
                        this.txtObs.ReadOnly = false;
                        this.txtObs.SelectOnFocus = false;
                        this.txtObs.Size = new System.Drawing.Size(300, 24);
                        this.txtObs.Sufijo = "";
                        this.txtObs.TabIndex = 11;
                        this.txtObs.TextRaw = "";
                        this.txtObs.TipWhenBlank = "";
                        this.txtObs.ToolTipText = "";
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(8, 216);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(84, 24);
                        this.Label11.TabIndex = 10;
                        this.Label11.Text = "Observac.";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame2
                        // 
                        this.Frame2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Frame2.AutoHeight = false;
                        this.Frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame2.Location = new System.Drawing.Point(8, 248);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.ReadOnly = false;
                        this.Frame2.Size = new System.Drawing.Size(676, 156);
                        this.Frame2.TabIndex = 29;
                        this.Frame2.TabStop = false;
                        this.Frame2.Text = "Historial del Cliente";
                        this.Frame2.ToolTipText = "";
                        // 
                        // lvHistorial
                        // 
                        this.lvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvHistorial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ticket,
            this.Tecnico,
            this.Fecha,
            this.Detalle});
                        this.lvHistorial.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lvHistorial.FullRowSelect = true;
                        this.lvHistorial.GridLines = true;
                        this.lvHistorial.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvHistorial.Location = new System.Drawing.Point(8, 272);
                        this.lvHistorial.MultiSelect = false;
                        this.lvHistorial.Name = "lvHistorial";
                        this.lvHistorial.Size = new System.Drawing.Size(676, 132);
                        this.lvHistorial.TabIndex = 30;
                        this.lvHistorial.UseCompatibleStateImageBehavior = false;
                        this.lvHistorial.View = System.Windows.Forms.View.Details;
                        this.lvHistorial.SelectedIndexChanged += new System.EventHandler(this.lvHistorial_SelectedIndexChanged);
                        this.lvHistorial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvHistorial_KeyDown);
                        // 
                        // Ticket
                        // 
                        this.Ticket.Text = "Ticket";
                        // 
                        // Tecnico
                        // 
                        this.Tecnico.Text = "Técnico";
                        this.Tecnico.Width = 113;
                        // 
                        // Fecha
                        // 
                        this.Fecha.Text = "Fecha";
                        this.Fecha.Width = 80;
                        // 
                        // Detalle
                        // 
                        this.Detalle.Text = "Detalle";
                        this.Detalle.Width = 650;
                        // 
                        // cmdNovedad
                        // 
                        this.cmdNovedad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdNovedad.AutoHeight = false;
                        this.cmdNovedad.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdNovedad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdNovedad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdNovedad.Image = null;
                        this.cmdNovedad.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdNovedad.Location = new System.Drawing.Point(228, 420);
                        this.cmdNovedad.Name = "cmdNovedad";
                        this.cmdNovedad.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdNovedad.ReadOnly = false;
                        this.cmdNovedad.Size = new System.Drawing.Size(104, 44);
                        this.cmdNovedad.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdNovedad.Subtext = "F6";
                        this.cmdNovedad.TabIndex = 52;
                        this.cmdNovedad.Text = "Novedad";
                        this.cmdNovedad.ToolTipText = "";
                        this.cmdNovedad.Click += new System.EventHandler(this.cmdNovedad_Click);
                        // 
                        // cmdArticulos
                        // 
                        this.cmdArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdArticulos.AutoHeight = false;
                        this.cmdArticulos.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdArticulos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdArticulos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdArticulos.Image = null;
                        this.cmdArticulos.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdArticulos.Location = new System.Drawing.Point(120, 420);
                        this.cmdArticulos.Name = "cmdArticulos";
                        this.cmdArticulos.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdArticulos.ReadOnly = false;
                        this.cmdArticulos.Size = new System.Drawing.Size(104, 44);
                        this.cmdArticulos.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdArticulos.Subtext = "F5";
                        this.cmdArticulos.TabIndex = 51;
                        this.cmdArticulos.Text = "Artículos";
                        this.cmdArticulos.ToolTipText = "";
                        this.cmdArticulos.Click += new System.EventHandler(this.cmdArticulos_Click);
                        // 
                        // txtEstado
                        // 
                        this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtEstado.AutoHeight = false;
                        this.txtEstado.AutoTab = true;
                        this.txtEstado.CanCreate = true;
                        this.txtEstado.DetailField = "nombre";
                        this.txtEstado.ExtraDetailFields = null;
                        this.txtEstado.Filter = "";
                        this.txtEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtEstado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtEstado.FreeTextCode = "";
                        this.txtEstado.KeyField = "id_ticket_estado";
                        this.txtEstado.Location = new System.Drawing.Point(456, 36);
                        this.txtEstado.MaxLength = 200;
                        this.txtEstado.Name = "txtEstado";
                        this.txtEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEstado.ReadOnly = false;
                        this.txtEstado.Required = true;
                        this.txtEstado.SelectOnFocus = true;
                        this.txtEstado.Size = new System.Drawing.Size(228, 24);
                        this.txtEstado.TabIndex = 14;
                        this.txtEstado.Table = "tickets_estados";
                        this.txtEstado.TeclaDespuesDeEnter = "{tab}";
                        this.txtEstado.Text = "0";
                        this.txtEstado.TextDetail = "";
                        this.txtEstado.TextInt = 0;
                        this.txtEstado.TipWhenBlank = "";
                        this.txtEstado.ToolTipText = "";
                        // 
                        // cmdFacturar
                        // 
                        this.cmdFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdFacturar.AutoHeight = false;
                        this.cmdFacturar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdFacturar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdFacturar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdFacturar.Image = null;
                        this.cmdFacturar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdFacturar.Location = new System.Drawing.Point(12, 420);
                        this.cmdFacturar.Name = "cmdFacturar";
                        this.cmdFacturar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdFacturar.ReadOnly = false;
                        this.cmdFacturar.Size = new System.Drawing.Size(104, 44);
                        this.cmdFacturar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdFacturar.Subtext = "F4";
                        this.cmdFacturar.TabIndex = 50;
                        this.cmdFacturar.Text = "Facturar";
                        this.cmdFacturar.ToolTipText = "";
                        this.cmdFacturar.Click += new System.EventHandler(this.cmdFacturar_Click);
                        // 
                        // txtFechaIngreso
                        // 
                        this.txtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtFechaIngreso.AutoHeight = false;
                        this.txtFechaIngreso.AutoNav = true;
                        this.txtFechaIngreso.AutoTab = true;
                        this.txtFechaIngreso.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtFechaIngreso.DecimalPlaces = -1;
                        this.txtFechaIngreso.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFechaIngreso.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtFechaIngreso.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFechaIngreso.Location = new System.Drawing.Point(552, 68);
                        this.txtFechaIngreso.MaxLenght = 32767;
                        this.txtFechaIngreso.MultiLine = false;
                        this.txtFechaIngreso.Name = "txtFechaIngreso";
                        this.txtFechaIngreso.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFechaIngreso.PasswordChar = '\0';
                        this.txtFechaIngreso.Prefijo = "";
                        this.txtFechaIngreso.ReadOnly = false;
                        this.txtFechaIngreso.SelectOnFocus = true;
                        this.txtFechaIngreso.Size = new System.Drawing.Size(132, 24);
                        this.txtFechaIngreso.Sufijo = "";
                        this.txtFechaIngreso.TabIndex = 16;
                        this.txtFechaIngreso.TabStop = false;
                        this.txtFechaIngreso.TextRaw = "";
                        this.txtFechaIngreso.TipWhenBlank = "";
                        this.txtFechaIngreso.ToolTipText = "";
                        // 
                        // Label12
                        // 
                        this.Label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label12.Location = new System.Drawing.Point(400, 68);
                        this.Label12.Name = "Label12";
                        this.Label12.Size = new System.Drawing.Size(156, 24);
                        this.Label12.TabIndex = 15;
                        this.Label12.Text = "Fecha Ingreso";
                        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtComprobante
                        // 
                        this.txtComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtComprobante.AutoHeight = false;
                        this.txtComprobante.AutoNav = true;
                        this.txtComprobante.AutoTab = true;
                        this.txtComprobante.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtComprobante.DecimalPlaces = -1;
                        this.txtComprobante.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtComprobante.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtComprobante.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtComprobante.Location = new System.Drawing.Point(500, 216);
                        this.txtComprobante.MaxLenght = 32767;
                        this.txtComprobante.MultiLine = false;
                        this.txtComprobante.Name = "txtComprobante";
                        this.txtComprobante.Padding = new System.Windows.Forms.Padding(2);
                        this.txtComprobante.PasswordChar = '\0';
                        this.txtComprobante.Prefijo = "";
                        this.txtComprobante.ReadOnly = true;
                        this.txtComprobante.SelectOnFocus = true;
                        this.txtComprobante.Size = new System.Drawing.Size(184, 24);
                        this.txtComprobante.Sufijo = "";
                        this.txtComprobante.TabIndex = 28;
                        this.txtComprobante.TabStop = false;
                        this.txtComprobante.TextRaw = "";
                        this.txtComprobante.TipWhenBlank = "";
                        this.txtComprobante.ToolTipText = "";
                        // 
                        // Label13
                        // 
                        this.Label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label13.Location = new System.Drawing.Point(400, 216);
                        this.Label13.Name = "Label13";
                        this.Label13.Size = new System.Drawing.Size(100, 24);
                        this.Label13.TabIndex = 27;
                        this.Label13.Text = "Comprobante";
                        this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtComprobanteId
                        // 
                        this.txtComprobanteId.Location = new System.Drawing.Point(0, 152);
                        this.txtComprobanteId.Name = "txtComprobanteId";
                        this.txtComprobanteId.Size = new System.Drawing.Size(28, 23);
                        this.txtComprobanteId.TabIndex = 34;
                        this.txtComprobanteId.Visible = false;
                        this.txtComprobanteId.TextChanged += new System.EventHandler(this.txtComprobanteId_TextChanged);
                        // 
                        // txtNumero
                        // 
                        this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtNumero.AutoHeight = false;
                        this.txtNumero.AutoNav = true;
                        this.txtNumero.AutoTab = true;
                        this.txtNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtNumero.DecimalPlaces = -1;
                        this.txtNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtNumero.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtNumero.Location = new System.Drawing.Point(548, 4);
                        this.txtNumero.MaxLenght = 32767;
                        this.txtNumero.MultiLine = false;
                        this.txtNumero.Name = "txtNumero";
                        this.txtNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.txtNumero.PasswordChar = '\0';
                        this.txtNumero.Prefijo = "";
                        this.txtNumero.ReadOnly = true;
                        this.txtNumero.SelectOnFocus = true;
                        this.txtNumero.Size = new System.Drawing.Size(136, 24);
                        this.txtNumero.Sufijo = "";
                        this.txtNumero.TabIndex = 12;
                        this.txtNumero.TabStop = false;
                        this.txtNumero.TextRaw = "";
                        this.txtNumero.TipWhenBlank = "";
                        this.txtNumero.ToolTipText = "";
                        // 
                        // txtPresupuesto2
                        // 
                        this.txtPresupuesto2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtPresupuesto2.AutoHeight = false;
                        this.txtPresupuesto2.AutoNav = true;
                        this.txtPresupuesto2.AutoTab = true;
                        this.txtPresupuesto2.DataType = Lui.Forms.DataTypes.Money;
                        this.txtPresupuesto2.DecimalPlaces = -1;
                        this.txtPresupuesto2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPresupuesto2.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPresupuesto2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPresupuesto2.Location = new System.Drawing.Point(596, 188);
                        this.txtPresupuesto2.MaxLenght = 32767;
                        this.txtPresupuesto2.MultiLine = false;
                        this.txtPresupuesto2.Name = "txtPresupuesto2";
                        this.txtPresupuesto2.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPresupuesto2.PasswordChar = '\0';
                        this.txtPresupuesto2.Prefijo = "$";
                        this.txtPresupuesto2.ReadOnly = true;
                        this.txtPresupuesto2.SelectOnFocus = true;
                        this.txtPresupuesto2.Size = new System.Drawing.Size(88, 24);
                        this.txtPresupuesto2.Sufijo = "";
                        this.txtPresupuesto2.TabIndex = 26;
                        this.txtPresupuesto2.TabStop = false;
                        this.txtPresupuesto2.Text = "0.00";
                        this.txtPresupuesto2.TextRaw = "0.00";
                        this.txtPresupuesto2.TipWhenBlank = "";
                        this.txtPresupuesto2.ToolTipText = "";
                        // 
                        // txtPrioridad
                        // 
                        this.txtPrioridad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtPrioridad.AutoHeight = false;
                        this.txtPrioridad.AutoNav = true;
                        this.txtPrioridad.AutoTab = true;
                        this.txtPrioridad.DetailField = null;
                        this.txtPrioridad.Filter = null;
                        this.txtPrioridad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPrioridad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPrioridad.KeyField = null;
                        this.txtPrioridad.Location = new System.Drawing.Point(500, 156);
                        this.txtPrioridad.MaxLenght = 32767;
                        this.txtPrioridad.Name = "txtPrioridad";
                        this.txtPrioridad.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPrioridad.ReadOnly = false;
                        this.txtPrioridad.SetData = new string[] {
        "Muy Alta|10",
        "Alta|5",
        "Normal|0",
        "Baja|-5"};
                        this.txtPrioridad.Size = new System.Drawing.Size(128, 24);
                        this.txtPrioridad.TabIndex = 22;
                        this.txtPrioridad.Table = null;
                        this.txtPrioridad.Text = "Normal";
                        this.txtPrioridad.TextKey = "0";
                        this.txtPrioridad.TextRaw = "Normal";
                        this.txtPrioridad.TipWhenBlank = "";
                        this.txtPrioridad.ToolTipText = "";
                        // 
                        // Label14
                        // 
                        this.Label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label14.Location = new System.Drawing.Point(400, 156);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(100, 24);
                        this.Label14.TabIndex = 21;
                        this.Label14.Text = "Prioridad";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label15
                        // 
                        this.Label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label15.Location = new System.Drawing.Point(580, 188);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(16, 24);
                        this.Label15.TabIndex = 25;
                        this.Label15.Text = "+";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label2.Location = new System.Drawing.Point(520, 4);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(28, 24);
                        this.Label2.TabIndex = 104;
                        this.Label2.Text = "Nº";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtPrioridad);
                        this.Controls.Add(this.Label14);
                        this.Controls.Add(this.txtPresupuesto2);
                        this.Controls.Add(this.txtNumero);
                        this.Controls.Add(this.txtComprobanteId);
                        this.Controls.Add(this.txtComprobante);
                        this.Controls.Add(this.txtFechaIngreso);
                        this.Controls.Add(this.cmdFacturar);
                        this.Controls.Add(this.txtEstado);
                        this.Controls.Add(this.cmdArticulos);
                        this.Controls.Add(this.cmdNovedad);
                        this.Controls.Add(this.lvHistorial);
                        this.Controls.Add(this.Frame2);
                        this.Controls.Add(this.txtObs);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.txtPresupuesto);
                        this.Controls.Add(this.txtEntregaLimite);
                        this.Controls.Add(this.txtEntregaEstimada);
                        this.Controls.Add(this.txtDescripcion);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.txtAsunto);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.txtTecnico);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtTarea);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.txtCliente);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.Label13);
                        this.Controls.Add(this.Label12);
                        this.Controls.Add(this.Label10);
                        this.Controls.Add(this.Label9);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.Label15);
                        this.Name = "Editar";
                        this.Text = "Tareas: Editar";
                        this.Activated += new System.EventHandler(this.FormTicketsEditar_Activated);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTicketsEditar_KeyDown);
                        this.Controls.SetChildIndex(this.Label15, 0);
                        this.Controls.SetChildIndex(this.Label8, 0);
                        this.Controls.SetChildIndex(this.Label9, 0);
                        this.Controls.SetChildIndex(this.Label10, 0);
                        this.Controls.SetChildIndex(this.Label12, 0);
                        this.Controls.SetChildIndex(this.Label13, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.txtCliente, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.txtTarea, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.txtTecnico, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.txtAsunto, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.txtDescripcion, 0);
                        this.Controls.SetChildIndex(this.txtEntregaEstimada, 0);
                        this.Controls.SetChildIndex(this.txtEntregaLimite, 0);
                        this.Controls.SetChildIndex(this.txtPresupuesto, 0);
                        this.Controls.SetChildIndex(this.Label11, 0);
                        this.Controls.SetChildIndex(this.txtObs, 0);
                        this.Controls.SetChildIndex(this.Frame2, 0);
                        this.Controls.SetChildIndex(this.lvHistorial, 0);
                        this.Controls.SetChildIndex(this.cmdNovedad, 0);
                        this.Controls.SetChildIndex(this.cmdArticulos, 0);
                        this.Controls.SetChildIndex(this.txtEstado, 0);
                        this.Controls.SetChildIndex(this.cmdFacturar, 0);
                        this.Controls.SetChildIndex(this.txtFechaIngreso, 0);
                        this.Controls.SetChildIndex(this.txtComprobante, 0);
                        this.Controls.SetChildIndex(this.txtComprobanteId, 0);
                        this.Controls.SetChildIndex(this.txtNumero, 0);
                        this.Controls.SetChildIndex(this.txtPresupuesto2, 0);
                        this.Controls.SetChildIndex(this.Label14, 0);
                        this.Controls.SetChildIndex(this.txtPrioridad, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.DetailBox txtCliente;
                internal Lui.Forms.DetailBox txtTarea;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.DetailBox txtTecnico;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox txtAsunto;
                internal System.Windows.Forms.Label Label6;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox txtDescripcion;
                internal System.Windows.Forms.Label Label8;
                internal System.Windows.Forms.Label Label9;
                internal System.Windows.Forms.Label Label10;
                internal Lui.Forms.TextBox txtEntregaEstimada;
                internal Lui.Forms.TextBox txtEntregaLimite;
                internal Lui.Forms.TextBox txtPresupuesto;
                internal Lui.Forms.TextBox txtObs;
                internal System.Windows.Forms.Label Label11;
                internal Lui.Forms.Frame Frame2;
                internal Lui.Forms.ListView lvHistorial;
                internal System.Windows.Forms.ColumnHeader Tecnico;
                internal System.Windows.Forms.ColumnHeader Detalle;
                internal Lui.Forms.Button cmdNovedad;
                internal Lui.Forms.DetailBox txtEstado;
                internal Lui.Forms.Button cmdFacturar;
                internal System.Windows.Forms.Label Label12;
                internal System.Windows.Forms.Label Label13;
                internal Lui.Forms.TextBox txtFechaIngreso;
                internal Lui.Forms.TextBox txtComprobante;
                internal System.Windows.Forms.TextBox txtComprobanteId;
                internal Lui.Forms.TextBox txtNumero;
                internal System.Windows.Forms.ColumnHeader Fecha;
                internal Lui.Forms.Button cmdArticulos;
                internal Lui.Forms.TextBox txtPresupuesto2;
                internal System.Windows.Forms.Label Label14;
                internal System.Windows.Forms.Label Label15;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox txtPrioridad;
                private System.Windows.Forms.ColumnHeader Ticket;
        }
}