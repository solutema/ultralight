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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Tareas
{
        public partial class Editar 
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
                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaTarea = new Lcc.Entrada.CodigoDetalle();
                        this.Label3 = new Lui.Forms.Label();
                        this.EntradaTecnico = new Lcc.Entrada.CodigoDetalle();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaAsunto = new Lui.Forms.TextBox();
                        this.Label6 = new Lui.Forms.Label();
                        this.Label7 = new Lui.Forms.Label();
                        this.EntradaDescripcion = new Lui.Forms.TextBox();
                        this.Label8 = new Lui.Forms.Label();
                        this.Label9 = new Lui.Forms.Label();
                        this.Label10 = new Lui.Forms.Label();
                        this.EntradaEntregaEstimada = new Lui.Forms.TextBox();
                        this.EntradaEntregaLimite = new Lui.Forms.TextBox();
                        this.EntradaPresupuesto = new Lui.Forms.TextBox();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label11 = new Lui.Forms.Label();
                        this.Frame2 = new Lui.Forms.Frame();
                        this.ListaHistorial = new Lui.Forms.ListView();
                        this.Ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Tecnico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Detalle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EntradaEstado = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaFechaIngreso = new Lui.Forms.TextBox();
                        this.Label12 = new Lui.Forms.Label();
                        this.EntradaComprobante = new Lui.Forms.TextBox();
                        this.Label13 = new Lui.Forms.Label();
                        this.EntradaComprobanteId = new System.Windows.Forms.TextBox();
                        this.EntradaPresupuesto2 = new Lui.Forms.TextBox();
                        this.EntradaPrioridad = new Lui.Forms.ComboBox();
                        this.Label14 = new Lui.Forms.Label();
                        this.Label15 = new Lui.Forms.Label();
                        this.Frame2.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(0, 0);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(84, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Cliente";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCliente
                        // 
                        this.EntradaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCliente.AutoNav = true;
                        this.EntradaCliente.CanCreate = true;
                        this.EntradaCliente.DataTextField = "nombre_visible";
                        this.EntradaCliente.DataValueField = "id_persona";
                        this.EntradaCliente.ExtraDetailFields = "";
                        this.EntradaCliente.FieldName = null;
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.Location = new System.Drawing.Point(84, 0);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "EntradaCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.PlaceholderText = null;
                        this.EntradaCliente.ReadOnly = false;
                        this.EntradaCliente.Required = true;
                        this.EntradaCliente.Size = new System.Drawing.Size(348, 24);
                        this.EntradaCliente.TabIndex = 1;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        // 
                        // EntradaTarea
                        // 
                        this.EntradaTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTarea.AutoNav = true;
                        this.EntradaTarea.CanCreate = true;
                        this.EntradaTarea.DataTextField = "nombre";
                        this.EntradaTarea.DataValueField = "id_tipo_ticket";
                        this.EntradaTarea.ExtraDetailFields = "";
                        this.EntradaTarea.FieldName = null;
                        this.EntradaTarea.Filter = "";
                        this.EntradaTarea.FreeTextCode = "";
                        this.EntradaTarea.Location = new System.Drawing.Point(84, 32);
                        this.EntradaTarea.MaxLength = 200;
                        this.EntradaTarea.Name = "EntradaTarea";
                        this.EntradaTarea.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTarea.PlaceholderText = null;
                        this.EntradaTarea.ReadOnly = false;
                        this.EntradaTarea.Required = true;
                        this.EntradaTarea.Size = new System.Drawing.Size(348, 24);
                        this.EntradaTarea.TabIndex = 3;
                        this.EntradaTarea.Table = "tickets_tipos";
                        this.EntradaTarea.Text = "0";
                        this.EntradaTarea.TextDetail = "";
                        // 
                        // Label3
                        // 
                        this.Label3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(0, 32);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(84, 24);
                        this.Label3.TabIndex = 2;
                        this.Label3.Text = "Tarea";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTecnico
                        // 
                        this.EntradaTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTecnico.AutoNav = true;
                        this.EntradaTecnico.CanCreate = false;
                        this.EntradaTecnico.DataTextField = "nombre_visible";
                        this.EntradaTecnico.DataValueField = "id_persona";
                        this.EntradaTecnico.ExtraDetailFields = "";
                        this.EntradaTecnico.FieldName = null;
                        this.EntradaTecnico.Filter = "(tipo&4)=4";
                        this.EntradaTecnico.FreeTextCode = "";
                        this.EntradaTecnico.Location = new System.Drawing.Point(84, 64);
                        this.EntradaTecnico.MaxLength = 200;
                        this.EntradaTecnico.Name = "EntradaTecnico";
                        this.EntradaTecnico.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTecnico.PlaceholderText = null;
                        this.EntradaTecnico.ReadOnly = false;
                        this.EntradaTecnico.Required = true;
                        this.EntradaTecnico.Size = new System.Drawing.Size(348, 24);
                        this.EntradaTecnico.TabIndex = 5;
                        this.EntradaTecnico.Table = "personas";
                        this.EntradaTecnico.Text = "0";
                        this.EntradaTecnico.TextDetail = "";
                        // 
                        // Label4
                        // 
                        this.Label4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(0, 64);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(84, 24);
                        this.Label4.TabIndex = 4;
                        this.Label4.Text = "Encargado";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(0, 96);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(84, 24);
                        this.Label5.TabIndex = 6;
                        this.Label5.Text = "Asunto";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAsunto
                        // 
                        this.EntradaAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaAsunto.AutoNav = true;
                        this.EntradaAsunto.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaAsunto.DecimalPlaces = -1;
                        this.EntradaAsunto.FieldName = null;
                        this.EntradaAsunto.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaAsunto.Location = new System.Drawing.Point(84, 96);
                        this.EntradaAsunto.MaxLength = 32767;
                        this.EntradaAsunto.MultiLine = false;
                        this.EntradaAsunto.Name = "EntradaAsunto";
                        this.EntradaAsunto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAsunto.PasswordChar = '\0';
                        this.EntradaAsunto.PlaceholderText = null;
                        this.EntradaAsunto.Prefijo = "";
                        this.EntradaAsunto.ReadOnly = false;
                        this.EntradaAsunto.SelectOnFocus = false;
                        this.EntradaAsunto.Size = new System.Drawing.Size(348, 24);
                        this.EntradaAsunto.Sufijo = "";
                        this.EntradaAsunto.TabIndex = 7;
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label6.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label6.Location = new System.Drawing.Point(456, 0);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(56, 24);
                        this.Label6.TabIndex = 13;
                        this.Label6.Text = "Estado";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label7.Location = new System.Drawing.Point(0, 128);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(88, 24);
                        this.Label7.TabIndex = 8;
                        this.Label7.Text = "Descripción";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDescripcion
                        // 
                        this.EntradaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDescripcion.AutoNav = true;
                        this.EntradaDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion.DecimalPlaces = -1;
                        this.EntradaDescripcion.FieldName = null;
                        this.EntradaDescripcion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescripcion.Location = new System.Drawing.Point(84, 128);
                        this.EntradaDescripcion.MaxLength = 32767;
                        this.EntradaDescripcion.MultiLine = true;
                        this.EntradaDescripcion.Name = "EntradaDescripcion";
                        this.EntradaDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion.PasswordChar = '\0';
                        this.EntradaDescripcion.PlaceholderText = null;
                        this.EntradaDescripcion.Prefijo = "";
                        this.EntradaDescripcion.ReadOnly = false;
                        this.EntradaDescripcion.SelectOnFocus = false;
                        this.EntradaDescripcion.Size = new System.Drawing.Size(348, 88);
                        this.EntradaDescripcion.Sufijo = "";
                        this.EntradaDescripcion.TabIndex = 9;
                        // 
                        // Label8
                        // 
                        this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label8.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label8.Location = new System.Drawing.Point(456, 64);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(156, 24);
                        this.Label8.TabIndex = 17;
                        this.Label8.Text = "Fecha Final. Estimada";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label9
                        // 
                        this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label9.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label9.Location = new System.Drawing.Point(456, 96);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(156, 24);
                        this.Label9.TabIndex = 19;
                        this.Label9.Text = "Fecha Final. Límite";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label10
                        // 
                        this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label10.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label10.Location = new System.Drawing.Point(456, 160);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(100, 24);
                        this.Label10.TabIndex = 23;
                        this.Label10.Text = "Presupuesto";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEntregaEstimada
                        // 
                        this.EntradaEntregaEstimada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEntregaEstimada.AutoNav = true;
                        this.EntradaEntregaEstimada.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaEntregaEstimada.DecimalPlaces = -1;
                        this.EntradaEntregaEstimada.FieldName = null;
                        this.EntradaEntregaEstimada.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEntregaEstimada.Location = new System.Drawing.Point(608, 64);
                        this.EntradaEntregaEstimada.MaxLength = 32767;
                        this.EntradaEntregaEstimada.MultiLine = false;
                        this.EntradaEntregaEstimada.Name = "EntradaEntregaEstimada";
                        this.EntradaEntregaEstimada.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEntregaEstimada.PasswordChar = '\0';
                        this.EntradaEntregaEstimada.PlaceholderText = null;
                        this.EntradaEntregaEstimada.Prefijo = "";
                        this.EntradaEntregaEstimada.ReadOnly = false;
                        this.EntradaEntregaEstimada.SelectOnFocus = true;
                        this.EntradaEntregaEstimada.Size = new System.Drawing.Size(112, 24);
                        this.EntradaEntregaEstimada.Sufijo = "";
                        this.EntradaEntregaEstimada.TabIndex = 18;
                        // 
                        // EntradaEntregaLimite
                        // 
                        this.EntradaEntregaLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEntregaLimite.AutoNav = true;
                        this.EntradaEntregaLimite.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaEntregaLimite.DecimalPlaces = -1;
                        this.EntradaEntregaLimite.FieldName = null;
                        this.EntradaEntregaLimite.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEntregaLimite.Location = new System.Drawing.Point(608, 96);
                        this.EntradaEntregaLimite.MaxLength = 32767;
                        this.EntradaEntregaLimite.MultiLine = false;
                        this.EntradaEntregaLimite.Name = "EntradaEntregaLimite";
                        this.EntradaEntregaLimite.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEntregaLimite.PasswordChar = '\0';
                        this.EntradaEntregaLimite.PlaceholderText = null;
                        this.EntradaEntregaLimite.Prefijo = "";
                        this.EntradaEntregaLimite.ReadOnly = false;
                        this.EntradaEntregaLimite.SelectOnFocus = true;
                        this.EntradaEntregaLimite.Size = new System.Drawing.Size(112, 24);
                        this.EntradaEntregaLimite.Sufijo = "";
                        this.EntradaEntregaLimite.TabIndex = 20;
                        // 
                        // EntradaPresupuesto
                        // 
                        this.EntradaPresupuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPresupuesto.AutoNav = true;
                        this.EntradaPresupuesto.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaPresupuesto.DecimalPlaces = -1;
                        this.EntradaPresupuesto.FieldName = null;
                        this.EntradaPresupuesto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPresupuesto.Location = new System.Drawing.Point(556, 160);
                        this.EntradaPresupuesto.MaxLength = 32767;
                        this.EntradaPresupuesto.MultiLine = false;
                        this.EntradaPresupuesto.Name = "EntradaPresupuesto";
                        this.EntradaPresupuesto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPresupuesto.PasswordChar = '\0';
                        this.EntradaPresupuesto.PlaceholderText = null;
                        this.EntradaPresupuesto.Prefijo = "$";
                        this.EntradaPresupuesto.ReadOnly = false;
                        this.EntradaPresupuesto.SelectOnFocus = true;
                        this.EntradaPresupuesto.Size = new System.Drawing.Size(80, 24);
                        this.EntradaPresupuesto.Sufijo = "";
                        this.EntradaPresupuesto.TabIndex = 24;
                        this.EntradaPresupuesto.Text = "0.00";
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.FieldName = null;
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaObs.Location = new System.Drawing.Point(84, 224);
                        this.EntradaObs.MaxLength = 32767;
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.PlaceholderText = null;
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(348, 24);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 11;
                        // 
                        // Label11
                        // 
                        this.Label11.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label11.Location = new System.Drawing.Point(0, 224);
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
                        this.Frame2.Controls.Add(this.ListaHistorial);
                        this.Frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Frame2.Location = new System.Drawing.Point(0, 264);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.Size = new System.Drawing.Size(768, 217);
                        this.Frame2.TabIndex = 29;
                        this.Frame2.TabStop = false;
                        this.Frame2.Text = "Historial del Cliente";
                        // 
                        // ListaHistorial
                        // 
                        this.ListaHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaHistorial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ticket,
            this.Tecnico,
            this.Fecha,
            this.Detalle});
                        this.ListaHistorial.FullRowSelect = true;
                        this.ListaHistorial.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaHistorial.Location = new System.Drawing.Point(8, 40);
                        this.ListaHistorial.MultiSelect = false;
                        this.ListaHistorial.Name = "ListaHistorial";
                        this.ListaHistorial.Size = new System.Drawing.Size(760, 177);
                        this.ListaHistorial.TabIndex = 30;
                        this.ListaHistorial.UseCompatibleStateImageBehavior = false;
                        this.ListaHistorial.View = System.Windows.Forms.View.Details;
                        this.ListaHistorial.SelectedIndexChanged += new System.EventHandler(this.ListaHistorial_SelectedIndexChanged);
                        this.ListaHistorial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvHistorial_KeyDown);
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
                        // EntradaEstado
                        // 
                        this.EntradaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.CanCreate = true;
                        this.EntradaEstado.DataTextField = "nombre";
                        this.EntradaEstado.DataValueField = "id_ticket_estado";
                        this.EntradaEstado.ExtraDetailFields = "";
                        this.EntradaEstado.FieldName = null;
                        this.EntradaEstado.Filter = "";
                        this.EntradaEstado.FreeTextCode = "";
                        this.EntradaEstado.Location = new System.Drawing.Point(512, 0);
                        this.EntradaEstado.MaxLength = 200;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.PlaceholderText = null;
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.Required = true;
                        this.EntradaEstado.Size = new System.Drawing.Size(256, 24);
                        this.EntradaEstado.TabIndex = 14;
                        this.EntradaEstado.Table = "tickets_estados";
                        this.EntradaEstado.Text = "0";
                        this.EntradaEstado.TextDetail = "";
                        // 
                        // EntradaFechaIngreso
                        // 
                        this.EntradaFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFechaIngreso.AutoNav = true;
                        this.EntradaFechaIngreso.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaFechaIngreso.DecimalPlaces = -1;
                        this.EntradaFechaIngreso.FieldName = null;
                        this.EntradaFechaIngreso.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaIngreso.Location = new System.Drawing.Point(608, 32);
                        this.EntradaFechaIngreso.MaxLength = 32767;
                        this.EntradaFechaIngreso.MultiLine = false;
                        this.EntradaFechaIngreso.Name = "EntradaFechaIngreso";
                        this.EntradaFechaIngreso.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaIngreso.PasswordChar = '\0';
                        this.EntradaFechaIngreso.PlaceholderText = null;
                        this.EntradaFechaIngreso.Prefijo = "";
                        this.EntradaFechaIngreso.ReadOnly = false;
                        this.EntradaFechaIngreso.SelectOnFocus = true;
                        this.EntradaFechaIngreso.Size = new System.Drawing.Size(160, 24);
                        this.EntradaFechaIngreso.Sufijo = "";
                        this.EntradaFechaIngreso.TabIndex = 16;
                        this.EntradaFechaIngreso.TabStop = false;
                        // 
                        // Label12
                        // 
                        this.Label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label12.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label12.Location = new System.Drawing.Point(456, 32);
                        this.Label12.Name = "Label12";
                        this.Label12.Size = new System.Drawing.Size(156, 24);
                        this.Label12.TabIndex = 15;
                        this.Label12.Text = "Fecha Ingreso";
                        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaComprobante
                        // 
                        this.EntradaComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaComprobante.AutoNav = true;
                        this.EntradaComprobante.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaComprobante.DecimalPlaces = -1;
                        this.EntradaComprobante.FieldName = null;
                        this.EntradaComprobante.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaComprobante.Location = new System.Drawing.Point(556, 192);
                        this.EntradaComprobante.MaxLength = 32767;
                        this.EntradaComprobante.MultiLine = false;
                        this.EntradaComprobante.Name = "EntradaComprobante";
                        this.EntradaComprobante.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComprobante.PasswordChar = '\0';
                        this.EntradaComprobante.PlaceholderText = null;
                        this.EntradaComprobante.Prefijo = "";
                        this.EntradaComprobante.ReadOnly = false;
                        this.EntradaComprobante.SelectOnFocus = true;
                        this.EntradaComprobante.Size = new System.Drawing.Size(184, 24);
                        this.EntradaComprobante.Sufijo = "";
                        this.EntradaComprobante.TabIndex = 28;
                        this.EntradaComprobante.TabStop = false;
                        // 
                        // Label13
                        // 
                        this.Label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label13.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label13.Location = new System.Drawing.Point(456, 192);
                        this.Label13.Name = "Label13";
                        this.Label13.Size = new System.Drawing.Size(100, 24);
                        this.Label13.TabIndex = 27;
                        this.Label13.Text = "Comprobante";
                        this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaComprobanteId
                        // 
                        this.EntradaComprobanteId.Location = new System.Drawing.Point(0, 148);
                        this.EntradaComprobanteId.Name = "EntradaComprobanteId";
                        this.EntradaComprobanteId.Size = new System.Drawing.Size(28, 23);
                        this.EntradaComprobanteId.TabIndex = 34;
                        this.EntradaComprobanteId.Visible = false;
                        this.EntradaComprobanteId.TextChanged += new System.EventHandler(this.EntradaComprobanteId_TextChanged);
                        // 
                        // EntradaPresupuesto2
                        // 
                        this.EntradaPresupuesto2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPresupuesto2.AutoNav = true;
                        this.EntradaPresupuesto2.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaPresupuesto2.DecimalPlaces = -1;
                        this.EntradaPresupuesto2.FieldName = null;
                        this.EntradaPresupuesto2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPresupuesto2.Location = new System.Drawing.Point(652, 160);
                        this.EntradaPresupuesto2.MaxLength = 32767;
                        this.EntradaPresupuesto2.MultiLine = false;
                        this.EntradaPresupuesto2.Name = "EntradaPresupuesto2";
                        this.EntradaPresupuesto2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPresupuesto2.PasswordChar = '\0';
                        this.EntradaPresupuesto2.PlaceholderText = null;
                        this.EntradaPresupuesto2.Prefijo = "$";
                        this.EntradaPresupuesto2.ReadOnly = false;
                        this.EntradaPresupuesto2.SelectOnFocus = true;
                        this.EntradaPresupuesto2.Size = new System.Drawing.Size(88, 24);
                        this.EntradaPresupuesto2.Sufijo = "";
                        this.EntradaPresupuesto2.TabIndex = 26;
                        this.EntradaPresupuesto2.TabStop = false;
                        this.EntradaPresupuesto2.Text = "0.00";
                        // 
                        // EntradaPrioridad
                        // 
                        this.EntradaPrioridad.AlwaysExpanded = false;
                        this.EntradaPrioridad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPrioridad.AutoNav = true;
                        this.EntradaPrioridad.AutoSize = true;
                        this.EntradaPrioridad.FieldName = null;
                        this.EntradaPrioridad.Location = new System.Drawing.Point(556, 128);
                        this.EntradaPrioridad.MaxLength = 32767;
                        this.EntradaPrioridad.Name = "EntradaPrioridad";
                        this.EntradaPrioridad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPrioridad.PlaceholderText = null;
                        this.EntradaPrioridad.ReadOnly = false;
                        this.EntradaPrioridad.SetData = new string[] {
        "Muy Alta|10",
        "Alta|5",
        "Normal|0",
        "Baja|-5"};
                        this.EntradaPrioridad.Size = new System.Drawing.Size(164, 25);
                        this.EntradaPrioridad.TabIndex = 22;
                        this.EntradaPrioridad.TextKey = "0";
                        // 
                        // Label14
                        // 
                        this.Label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label14.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label14.Location = new System.Drawing.Point(456, 128);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(100, 24);
                        this.Label14.TabIndex = 21;
                        this.Label14.Text = "Prioridad";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label15
                        // 
                        this.Label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label15.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label15.Location = new System.Drawing.Point(636, 160);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(16, 24);
                        this.Label15.TabIndex = 25;
                        this.Label15.Text = "+";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Editar
                        // 
                        this.AutoSize = true;
                        this.Controls.Add(this.EntradaPrioridad);
                        this.Controls.Add(this.Label14);
                        this.Controls.Add(this.EntradaPresupuesto2);
                        this.Controls.Add(this.EntradaComprobanteId);
                        this.Controls.Add(this.EntradaComprobante);
                        this.Controls.Add(this.EntradaFechaIngreso);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.Frame2);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.EntradaPresupuesto);
                        this.Controls.Add(this.EntradaEntregaLimite);
                        this.Controls.Add(this.EntradaEntregaEstimada);
                        this.Controls.Add(this.EntradaDescripcion);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.EntradaAsunto);
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
                        this.Size = new System.Drawing.Size(768, 486);
                        this.Frame2.ResumeLayout(false);
                        this.Frame2.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaCliente;
                internal Lcc.Entrada.CodigoDetalle EntradaTarea;
                internal Lui.Forms.Label Label3;
                internal Lcc.Entrada.CodigoDetalle EntradaTecnico;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaAsunto;
                internal Lui.Forms.Label Label6;
                internal Lui.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaDescripcion;
                internal Lui.Forms.Label Label8;
                internal Lui.Forms.Label Label9;
                internal Lui.Forms.Label Label10;
                internal Lui.Forms.TextBox EntradaEntregaEstimada;
                internal Lui.Forms.TextBox EntradaEntregaLimite;
                internal Lui.Forms.TextBox EntradaPresupuesto;
                internal Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.Label Label11;
                internal Lui.Forms.Frame Frame2;
                internal Lui.Forms.ListView ListaHistorial;
                internal System.Windows.Forms.ColumnHeader Tecnico;
                internal System.Windows.Forms.ColumnHeader Detalle;
                internal Lcc.Entrada.CodigoDetalle EntradaEstado;
                internal Lui.Forms.Label Label12;
                internal Lui.Forms.Label Label13;
                internal Lui.Forms.TextBox EntradaFechaIngreso;
                internal Lui.Forms.TextBox EntradaComprobante;
                internal System.Windows.Forms.TextBox EntradaComprobanteId;
                internal System.Windows.Forms.ColumnHeader Fecha;
                internal Lui.Forms.TextBox EntradaPresupuesto2;
                internal Lui.Forms.Label Label14;
                internal Lui.Forms.Label Label15;
                internal Lui.Forms.ComboBox EntradaPrioridad;
                private System.Windows.Forms.ColumnHeader Ticket;
        }
}
