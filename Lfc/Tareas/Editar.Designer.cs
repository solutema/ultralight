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
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaTarea = new Lcc.Entrada.CodigoDetalle();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaTecnico = new Lcc.Entrada.CodigoDetalle();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtAsunto = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.EntradaDescripcion = new Lui.Forms.TextBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.EntradaEntregaEstimada = new Lui.Forms.TextBox();
                        this.EntradaEntregaLimite = new Lui.Forms.TextBox();
                        this.EntradaPresupuesto = new Lui.Forms.TextBox();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.Frame2 = new Lui.Forms.Frame();
                        this.lvHistorial = new Lui.Forms.ListView();
                        this.Ticket = new System.Windows.Forms.ColumnHeader();
                        this.Tecnico = new System.Windows.Forms.ColumnHeader();
                        this.Fecha = new System.Windows.Forms.ColumnHeader();
                        this.Detalle = new System.Windows.Forms.ColumnHeader();
                        this.BotonNovedad = new Lui.Forms.Button();
                        this.BotonArticulos = new Lui.Forms.Button();
                        this.EntradaEstado = new Lcc.Entrada.CodigoDetalle();
                        this.BotonFacturar = new Lui.Forms.Button();
                        this.EntradaFechaIngreso = new Lui.Forms.TextBox();
                        this.Label12 = new System.Windows.Forms.Label();
                        this.txtComprobante = new Lui.Forms.TextBox();
                        this.Label13 = new System.Windows.Forms.Label();
                        this.txtComprobanteId = new System.Windows.Forms.TextBox();
                        this.txtNumero = new Lui.Forms.TextBox();
                        this.txtPresupuesto2 = new Lui.Forms.TextBox();
                        this.EntradaPrioridad = new Lui.Forms.ComboBox();
                        this.Label14 = new System.Windows.Forms.Label();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
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
                        this.EntradaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCliente.AutoHeight = false;
                        this.EntradaCliente.AutoTab = true;
                        this.EntradaCliente.CanCreate = true;
                        this.EntradaCliente.DetailField = "nombre_visible";
                        this.EntradaCliente.ExtraDetailFields = null;
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.KeyField = "id_persona";
                        this.EntradaCliente.Location = new System.Drawing.Point(92, 8);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "txtCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.ReadOnly = false;
                        this.EntradaCliente.Required = true;
                        this.EntradaCliente.Size = new System.Drawing.Size(300, 24);
                        this.EntradaCliente.TabIndex = 1;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        this.EntradaCliente.TextInt = 0;
                        this.EntradaCliente.TipWhenBlank = "";
                        this.EntradaCliente.ToolTipText = "";
                        // 
                        // txtTarea
                        // 
                        this.EntradaTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTarea.AutoHeight = false;
                        this.EntradaTarea.AutoTab = true;
                        this.EntradaTarea.CanCreate = true;
                        this.EntradaTarea.DetailField = "nombre";
                        this.EntradaTarea.ExtraDetailFields = null;
                        this.EntradaTarea.Filter = "";
                        this.EntradaTarea.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTarea.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTarea.FreeTextCode = "";
                        this.EntradaTarea.KeyField = "id_tipo_ticket";
                        this.EntradaTarea.Location = new System.Drawing.Point(92, 36);
                        this.EntradaTarea.MaxLength = 200;
                        this.EntradaTarea.Name = "txtTarea";
                        this.EntradaTarea.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTarea.ReadOnly = false;
                        this.EntradaTarea.Required = true;
                        this.EntradaTarea.Size = new System.Drawing.Size(300, 24);
                        this.EntradaTarea.TabIndex = 3;
                        this.EntradaTarea.Table = "tickets_tipos";
                        this.EntradaTarea.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaTarea.Text = "0";
                        this.EntradaTarea.TextDetail = "";
                        this.EntradaTarea.TextInt = 0;
                        this.EntradaTarea.TipWhenBlank = "";
                        this.EntradaTarea.ToolTipText = "";
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
                        this.EntradaTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTecnico.AutoHeight = false;
                        this.EntradaTecnico.AutoTab = true;
                        this.EntradaTecnico.CanCreate = true;
                        this.EntradaTecnico.DetailField = "nombre_visible";
                        this.EntradaTecnico.ExtraDetailFields = null;
                        this.EntradaTecnico.Filter = "(tipo&4)=4";
                        this.EntradaTecnico.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTecnico.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTecnico.FreeTextCode = "";
                        this.EntradaTecnico.KeyField = "id_persona";
                        this.EntradaTecnico.Location = new System.Drawing.Point(92, 64);
                        this.EntradaTecnico.MaxLength = 200;
                        this.EntradaTecnico.Name = "txtTecnico";
                        this.EntradaTecnico.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTecnico.ReadOnly = false;
                        this.EntradaTecnico.Required = true;
                        this.EntradaTecnico.Size = new System.Drawing.Size(300, 24);
                        this.EntradaTecnico.TabIndex = 5;
                        this.EntradaTecnico.Table = "personas";
                        this.EntradaTecnico.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaTecnico.Text = "0";
                        this.EntradaTecnico.TextDetail = "";
                        this.EntradaTecnico.TextInt = 0;
                        this.EntradaTecnico.TipWhenBlank = "";
                        this.EntradaTecnico.ToolTipText = "";
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
                        this.EntradaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDescripcion.AutoHeight = false;
                        this.EntradaDescripcion.AutoNav = true;
                        this.EntradaDescripcion.AutoTab = true;
                        this.EntradaDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion.DecimalPlaces = -1;
                        this.EntradaDescripcion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDescripcion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaDescripcion.Location = new System.Drawing.Point(92, 124);
                        this.EntradaDescripcion.MaxLenght = 32767;
                        this.EntradaDescripcion.MultiLine = true;
                        this.EntradaDescripcion.Name = "txtDescripcion";
                        this.EntradaDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion.PasswordChar = '\0';
                        this.EntradaDescripcion.Prefijo = "";
                        this.EntradaDescripcion.ReadOnly = false;
                        this.EntradaDescripcion.SelectOnFocus = false;
                        this.EntradaDescripcion.Size = new System.Drawing.Size(300, 84);
                        this.EntradaDescripcion.Sufijo = "";
                        this.EntradaDescripcion.TabIndex = 9;
                        this.EntradaDescripcion.TextRaw = "";
                        this.EntradaDescripcion.TipWhenBlank = "";
                        this.EntradaDescripcion.ToolTipText = "";
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
                        this.EntradaEntregaEstimada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEntregaEstimada.AutoHeight = false;
                        this.EntradaEntregaEstimada.AutoNav = true;
                        this.EntradaEntregaEstimada.AutoTab = true;
                        this.EntradaEntregaEstimada.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaEntregaEstimada.DecimalPlaces = -1;
                        this.EntradaEntregaEstimada.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEntregaEstimada.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEntregaEstimada.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEntregaEstimada.Location = new System.Drawing.Point(552, 96);
                        this.EntradaEntregaEstimada.MaxLenght = 32767;
                        this.EntradaEntregaEstimada.MultiLine = false;
                        this.EntradaEntregaEstimada.Name = "txtEntregaEstimada";
                        this.EntradaEntregaEstimada.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEntregaEstimada.PasswordChar = '\0';
                        this.EntradaEntregaEstimada.Prefijo = "";
                        this.EntradaEntregaEstimada.ReadOnly = false;
                        this.EntradaEntregaEstimada.SelectOnFocus = true;
                        this.EntradaEntregaEstimada.Size = new System.Drawing.Size(96, 24);
                        this.EntradaEntregaEstimada.Sufijo = "";
                        this.EntradaEntregaEstimada.TabIndex = 18;
                        this.EntradaEntregaEstimada.TextRaw = "";
                        this.EntradaEntregaEstimada.TipWhenBlank = "";
                        this.EntradaEntregaEstimada.ToolTipText = "";
                        // 
                        // txtEntregaLimite
                        // 
                        this.EntradaEntregaLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEntregaLimite.AutoHeight = false;
                        this.EntradaEntregaLimite.AutoNav = true;
                        this.EntradaEntregaLimite.AutoTab = true;
                        this.EntradaEntregaLimite.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaEntregaLimite.DecimalPlaces = -1;
                        this.EntradaEntregaLimite.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEntregaLimite.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEntregaLimite.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEntregaLimite.Location = new System.Drawing.Point(552, 124);
                        this.EntradaEntregaLimite.MaxLenght = 32767;
                        this.EntradaEntregaLimite.MultiLine = false;
                        this.EntradaEntregaLimite.Name = "txtEntregaLimite";
                        this.EntradaEntregaLimite.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEntregaLimite.PasswordChar = '\0';
                        this.EntradaEntregaLimite.Prefijo = "";
                        this.EntradaEntregaLimite.ReadOnly = false;
                        this.EntradaEntregaLimite.SelectOnFocus = true;
                        this.EntradaEntregaLimite.Size = new System.Drawing.Size(96, 24);
                        this.EntradaEntregaLimite.Sufijo = "";
                        this.EntradaEntregaLimite.TabIndex = 20;
                        this.EntradaEntregaLimite.TextRaw = "";
                        this.EntradaEntregaLimite.TipWhenBlank = "";
                        this.EntradaEntregaLimite.ToolTipText = "";
                        // 
                        // txtPresupuesto
                        // 
                        this.EntradaPresupuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPresupuesto.AutoHeight = false;
                        this.EntradaPresupuesto.AutoNav = true;
                        this.EntradaPresupuesto.AutoTab = true;
                        this.EntradaPresupuesto.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaPresupuesto.DecimalPlaces = -1;
                        this.EntradaPresupuesto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPresupuesto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPresupuesto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPresupuesto.Location = new System.Drawing.Point(500, 188);
                        this.EntradaPresupuesto.MaxLenght = 32767;
                        this.EntradaPresupuesto.MultiLine = false;
                        this.EntradaPresupuesto.Name = "txtPresupuesto";
                        this.EntradaPresupuesto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPresupuesto.PasswordChar = '\0';
                        this.EntradaPresupuesto.Prefijo = "$";
                        this.EntradaPresupuesto.ReadOnly = false;
                        this.EntradaPresupuesto.SelectOnFocus = true;
                        this.EntradaPresupuesto.Size = new System.Drawing.Size(80, 24);
                        this.EntradaPresupuesto.Sufijo = "";
                        this.EntradaPresupuesto.TabIndex = 24;
                        this.EntradaPresupuesto.Text = "0.00";
                        this.EntradaPresupuesto.TextRaw = "0.00";
                        this.EntradaPresupuesto.TipWhenBlank = "";
                        this.EntradaPresupuesto.ToolTipText = "";
                        // 
                        // txtObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoHeight = false;
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaObs.Location = new System.Drawing.Point(92, 216);
                        this.EntradaObs.MaxLenght = 32767;
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "txtObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(300, 24);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 11;
                        this.EntradaObs.TextRaw = "";
                        this.EntradaObs.TipWhenBlank = "";
                        this.EntradaObs.ToolTipText = "";
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
                        // BotonNovedad
                        // 
                        this.BotonNovedad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonNovedad.AutoHeight = false;
                        this.BotonNovedad.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonNovedad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonNovedad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonNovedad.Image = null;
                        this.BotonNovedad.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonNovedad.Location = new System.Drawing.Point(228, 420);
                        this.BotonNovedad.Name = "BotonNovedad";
                        this.BotonNovedad.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonNovedad.ReadOnly = false;
                        this.BotonNovedad.Size = new System.Drawing.Size(104, 44);
                        this.BotonNovedad.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonNovedad.Subtext = "F6";
                        this.BotonNovedad.TabIndex = 52;
                        this.BotonNovedad.Text = "Novedad";
                        this.BotonNovedad.ToolTipText = "";
                        this.BotonNovedad.Click += new System.EventHandler(this.BotonNovedad_Click);
                        // 
                        // BotonArticulos
                        // 
                        this.BotonArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonArticulos.AutoHeight = false;
                        this.BotonArticulos.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonArticulos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonArticulos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonArticulos.Image = null;
                        this.BotonArticulos.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonArticulos.Location = new System.Drawing.Point(120, 420);
                        this.BotonArticulos.Name = "BotonArticulos";
                        this.BotonArticulos.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonArticulos.ReadOnly = false;
                        this.BotonArticulos.Size = new System.Drawing.Size(104, 44);
                        this.BotonArticulos.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonArticulos.Subtext = "F5";
                        this.BotonArticulos.TabIndex = 51;
                        this.BotonArticulos.Text = "Artículos";
                        this.BotonArticulos.ToolTipText = "";
                        this.BotonArticulos.Click += new System.EventHandler(this.BotonArticulos_Click);
                        // 
                        // txtEstado
                        // 
                        this.EntradaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstado.AutoHeight = false;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.CanCreate = true;
                        this.EntradaEstado.DetailField = "nombre";
                        this.EntradaEstado.ExtraDetailFields = null;
                        this.EntradaEstado.Filter = "";
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEstado.FreeTextCode = "";
                        this.EntradaEstado.KeyField = "id_ticket_estado";
                        this.EntradaEstado.Location = new System.Drawing.Point(456, 36);
                        this.EntradaEstado.MaxLength = 200;
                        this.EntradaEstado.Name = "txtEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.Required = true;
                        this.EntradaEstado.Size = new System.Drawing.Size(228, 24);
                        this.EntradaEstado.TabIndex = 14;
                        this.EntradaEstado.Table = "tickets_estados";
                        this.EntradaEstado.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaEstado.Text = "0";
                        this.EntradaEstado.TextDetail = "";
                        this.EntradaEstado.TextInt = 0;
                        this.EntradaEstado.TipWhenBlank = "";
                        this.EntradaEstado.ToolTipText = "";
                        // 
                        // BotonFacturar
                        // 
                        this.BotonFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonFacturar.AutoHeight = false;
                        this.BotonFacturar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonFacturar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonFacturar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonFacturar.Image = null;
                        this.BotonFacturar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonFacturar.Location = new System.Drawing.Point(12, 420);
                        this.BotonFacturar.Name = "BotonFacturar";
                        this.BotonFacturar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonFacturar.ReadOnly = false;
                        this.BotonFacturar.Size = new System.Drawing.Size(104, 44);
                        this.BotonFacturar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonFacturar.Subtext = "F4";
                        this.BotonFacturar.TabIndex = 50;
                        this.BotonFacturar.Text = "Facturar";
                        this.BotonFacturar.ToolTipText = "";
                        this.BotonFacturar.Click += new System.EventHandler(this.BotonFacturar_Click);
                        // 
                        // txtFechaIngreso
                        // 
                        this.EntradaFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFechaIngreso.AutoHeight = false;
                        this.EntradaFechaIngreso.AutoNav = true;
                        this.EntradaFechaIngreso.AutoTab = true;
                        this.EntradaFechaIngreso.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaFechaIngreso.DecimalPlaces = -1;
                        this.EntradaFechaIngreso.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaIngreso.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaIngreso.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFechaIngreso.Location = new System.Drawing.Point(552, 68);
                        this.EntradaFechaIngreso.MaxLenght = 32767;
                        this.EntradaFechaIngreso.MultiLine = false;
                        this.EntradaFechaIngreso.Name = "txtFechaIngreso";
                        this.EntradaFechaIngreso.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaIngreso.PasswordChar = '\0';
                        this.EntradaFechaIngreso.Prefijo = "";
                        this.EntradaFechaIngreso.ReadOnly = false;
                        this.EntradaFechaIngreso.SelectOnFocus = true;
                        this.EntradaFechaIngreso.Size = new System.Drawing.Size(132, 24);
                        this.EntradaFechaIngreso.Sufijo = "";
                        this.EntradaFechaIngreso.TabIndex = 16;
                        this.EntradaFechaIngreso.TabStop = false;
                        this.EntradaFechaIngreso.TextRaw = "";
                        this.EntradaFechaIngreso.TipWhenBlank = "";
                        this.EntradaFechaIngreso.ToolTipText = "";
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
                        this.EntradaPrioridad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPrioridad.AutoHeight = false;
                        this.EntradaPrioridad.AutoNav = true;
                        this.EntradaPrioridad.AutoTab = true;
                        this.EntradaPrioridad.DetailField = null;
                        this.EntradaPrioridad.Filter = null;
                        this.EntradaPrioridad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPrioridad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPrioridad.KeyField = null;
                        this.EntradaPrioridad.Location = new System.Drawing.Point(500, 156);
                        this.EntradaPrioridad.MaxLenght = 32767;
                        this.EntradaPrioridad.Name = "txtPrioridad";
                        this.EntradaPrioridad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPrioridad.ReadOnly = false;
                        this.EntradaPrioridad.SetData = new string[] {
        "Muy Alta|10",
        "Alta|5",
        "Normal|0",
        "Baja|-5"};
                        this.EntradaPrioridad.Size = new System.Drawing.Size(128, 24);
                        this.EntradaPrioridad.TabIndex = 22;
                        this.EntradaPrioridad.Table = null;
                        this.EntradaPrioridad.Text = "Normal";
                        this.EntradaPrioridad.TextKey = "0";
                        this.EntradaPrioridad.TextRaw = "Normal";
                        this.EntradaPrioridad.TipWhenBlank = "";
                        this.EntradaPrioridad.ToolTipText = "";
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
                        this.Label2.Location = new System.Drawing.Point(516, 4);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(32, 24);
                        this.Label2.TabIndex = 104;
                        this.Label2.Text = "Nº";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.BotonArticulos);
                        this.Controls.Add(this.BotonFacturar);
                        this.Controls.Add(this.BotonNovedad);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaPrioridad);
                        this.Controls.Add(this.Label14);
                        this.Controls.Add(this.txtPresupuesto2);
                        this.Controls.Add(this.txtNumero);
                        this.Controls.Add(this.txtComprobanteId);
                        this.Controls.Add(this.txtComprobante);
                        this.Controls.Add(this.EntradaFechaIngreso);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.lvHistorial);
                        this.Controls.Add(this.Frame2);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.EntradaPresupuesto);
                        this.Controls.Add(this.EntradaEntregaLimite);
                        this.Controls.Add(this.EntradaEntregaEstimada);
                        this.Controls.Add(this.EntradaDescripcion);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.txtAsunto);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.EntradaTecnico);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaTarea);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.EntradaCliente);
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
                        this.Controls.SetChildIndex(this.EntradaCliente, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaTarea, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EntradaTecnico, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.txtAsunto, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.EntradaDescripcion, 0);
                        this.Controls.SetChildIndex(this.EntradaEntregaEstimada, 0);
                        this.Controls.SetChildIndex(this.EntradaEntregaLimite, 0);
                        this.Controls.SetChildIndex(this.EntradaPresupuesto, 0);
                        this.Controls.SetChildIndex(this.Label11, 0);
                        this.Controls.SetChildIndex(this.EntradaObs, 0);
                        this.Controls.SetChildIndex(this.Frame2, 0);
                        this.Controls.SetChildIndex(this.lvHistorial, 0);
                        this.Controls.SetChildIndex(this.EntradaEstado, 0);
                        this.Controls.SetChildIndex(this.EntradaFechaIngreso, 0);
                        this.Controls.SetChildIndex(this.txtComprobante, 0);
                        this.Controls.SetChildIndex(this.txtComprobanteId, 0);
                        this.Controls.SetChildIndex(this.txtNumero, 0);
                        this.Controls.SetChildIndex(this.txtPresupuesto2, 0);
                        this.Controls.SetChildIndex(this.Label14, 0);
                        this.Controls.SetChildIndex(this.EntradaPrioridad, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.BotonNovedad, 0);
                        this.Controls.SetChildIndex(this.BotonFacturar, 0);
                        this.Controls.SetChildIndex(this.BotonArticulos, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaCliente;
                internal Lcc.Entrada.CodigoDetalle EntradaTarea;
                internal System.Windows.Forms.Label Label3;
                internal Lcc.Entrada.CodigoDetalle EntradaTecnico;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox txtAsunto;
                internal System.Windows.Forms.Label Label6;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaDescripcion;
                internal System.Windows.Forms.Label Label8;
                internal System.Windows.Forms.Label Label9;
                internal System.Windows.Forms.Label Label10;
                internal Lui.Forms.TextBox EntradaEntregaEstimada;
                internal Lui.Forms.TextBox EntradaEntregaLimite;
                internal Lui.Forms.TextBox EntradaPresupuesto;
                internal Lui.Forms.TextBox EntradaObs;
                internal System.Windows.Forms.Label Label11;
                internal Lui.Forms.Frame Frame2;
                internal Lui.Forms.ListView lvHistorial;
                internal System.Windows.Forms.ColumnHeader Tecnico;
                internal System.Windows.Forms.ColumnHeader Detalle;
                internal Lui.Forms.Button BotonNovedad;
                internal Lcc.Entrada.CodigoDetalle EntradaEstado;
                internal Lui.Forms.Button BotonFacturar;
                internal System.Windows.Forms.Label Label12;
                internal System.Windows.Forms.Label Label13;
                internal Lui.Forms.TextBox EntradaFechaIngreso;
                internal Lui.Forms.TextBox txtComprobante;
                internal System.Windows.Forms.TextBox txtComprobanteId;
                internal Lui.Forms.TextBox txtNumero;
                internal System.Windows.Forms.ColumnHeader Fecha;
                internal Lui.Forms.Button BotonArticulos;
                internal Lui.Forms.TextBox txtPresupuesto2;
                internal System.Windows.Forms.Label Label14;
                internal System.Windows.Forms.Label Label15;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox EntradaPrioridad;
                private System.Windows.Forms.ColumnHeader Ticket;
        }
}