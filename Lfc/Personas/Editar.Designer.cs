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
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lfc.Personas
{
        public partial class Editar
        {
                #region 'Código generado por el Diseñador de Windows Forms'

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
                        this.EntradaEmail = new Lui.Forms.TextBox();
                        this.EntradaLocalidad = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaDomicilio = new Lui.Forms.TextBox();
                        this.EntradaNumDoc = new Lui.Forms.TextBox();
                        this.EntradaTipoDoc = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaApellido = new Lui.Forms.TextBox();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.EntradaClaveTributaria = new Lui.Forms.TextBox();
                        this.EntradaRazonSocial = new Lui.Forms.TextBox();
                        this.Label10 = new Lui.Forms.Label();
                        this.Label9 = new Lui.Forms.Label();
                        this.Label8 = new Lui.Forms.Label();
                        this.Label6 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label1 = new Lui.Forms.Label();
                        this.EtiquetaClaveTributaria = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.Label11 = new Lui.Forms.Label();
                        this.Frame1 = new Lui.Forms.Frame();
                        this.Frame2 = new Lui.Forms.Frame();
                        this.Label15 = new Lui.Forms.Label();
                        this.Label12 = new Lui.Forms.Label();
                        this.EntradaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaTipoFac = new Lui.Forms.ComboBox();
                        this.EntradaTipo = new Lcc.Entrada.CodigoDetalle();
                        this.Label14 = new Lui.Forms.Label();
                        this.EntradaGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.Label16 = new Lui.Forms.Label();
                        this.BotonPermisos = new Lui.Forms.Button();
                        this.EntradaLimiteCredito = new Lui.Forms.TextBox();
                        this.label17 = new Lui.Forms.Label();
                        this.EntradaFechaNac = new Lui.Forms.TextBox();
                        this.label18 = new Lui.Forms.Label();
                        this.EntradaDomicilioTrabajo = new Lui.Forms.TextBox();
                        this.label19 = new Lui.Forms.Label();
                        this.EntradaEstadoCredito = new Lui.Forms.ComboBox();
                        this.label21 = new Lui.Forms.Label();
                        this.EntradaClaveBancaria = new Lui.Forms.TextBox();
                        this.EtiquetaClaveBancaria = new Lui.Forms.Label();
                        this.EntradaNumeroCuenta = new Lui.Forms.TextBox();
                        this.label22 = new Lui.Forms.Label();
                        this.frame3 = new Lui.Forms.Frame();
                        this.EntradaVendedor = new Lcc.Entrada.CodigoDetalle();
                        this.label23 = new Lui.Forms.Label();
                        this.EntradaTelefono = new Lcc.Entrada.MatrizTelefonos();
                        this.frame4 = new Lui.Forms.Frame();
                        this.EntradaSubGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.label13 = new Lui.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.EntradaNombreVisible = new Lui.Forms.TextBox();
                        this.Label4 = new Lui.Forms.Label();
                        this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
                        this.frame5 = new Lui.Forms.Frame();
                        this.label24 = new Lui.Forms.Label();
                        this.label26 = new Lui.Forms.Label();
                        this.EntradaFechaBaja = new Lui.Forms.TextBox();
                        this.label25 = new Lui.Forms.Label();
                        this.EntradaFechaAlta = new Lui.Forms.TextBox();
                        this.matrizTelefonos1 = new Lcc.Entrada.MatrizTelefonos();
                        this.Frame1.SuspendLayout();
                        this.Frame2.SuspendLayout();
                        this.frame3.SuspendLayout();
                        this.frame4.SuspendLayout();
                        this.TableLayoutPanel.SuspendLayout();
                        this.frame5.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaEmail
                        // 
                        this.EntradaEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEmail.AutoNav = true;
                        this.EntradaEmail.AutoTab = true;
                        this.EntradaEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaEmail.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmail.DecimalPlaces = -1;
                        this.EntradaEmail.FieldName = null;
                        this.EntradaEmail.ForceCase = Lui.Forms.TextCasing.LowerCase;
                        this.EntradaEmail.Location = new System.Drawing.Point(100, 180);
                        this.EntradaEmail.MaxLength = 32767;
                        this.EntradaEmail.MultiLine = false;
                        this.EntradaEmail.Name = "EntradaEmail";
                        this.EntradaEmail.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmail.PasswordChar = '\0';
                        this.EntradaEmail.PlaceholderText = null;
                        this.EntradaEmail.Prefijo = "";
                        this.EntradaEmail.ReadOnly = false;
                        this.EntradaEmail.SelectOnFocus = true;
                        this.EntradaEmail.Size = new System.Drawing.Size(242, 24);
                        this.EntradaEmail.Sufijo = "";
                        this.EntradaEmail.TabIndex = 7;
                        this.EntradaEmail.Leave += new System.EventHandler(this.EntradaEmail_Leave);
                        // 
                        // EntradaLocalidad
                        // 
                        this.EntradaLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaLocalidad.AutoNav = true;
                        this.EntradaLocalidad.AutoTab = true;
                        this.EntradaLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaLocalidad.CanCreate = true;
                        this.EntradaLocalidad.DataTextField = "nombre";
                        this.EntradaLocalidad.DataValueField = "id_ciudad";
                        this.EntradaLocalidad.ExtraDetailFields = "";
                        this.EntradaLocalidad.FieldName = null;
                        this.EntradaLocalidad.Filter = "id_provincia IS NOT NULL";
                        this.EntradaLocalidad.FreeTextCode = "";
                        this.EntradaLocalidad.Location = new System.Drawing.Point(100, 208);
                        this.EntradaLocalidad.MaxLength = 200;
                        this.EntradaLocalidad.Name = "EntradaLocalidad";
                        this.EntradaLocalidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLocalidad.PlaceholderText = "Sin especificar";
                        this.EntradaLocalidad.ReadOnly = false;
                        this.EntradaLocalidad.Required = true;
                        this.EntradaLocalidad.Size = new System.Drawing.Size(242, 24);
                        this.EntradaLocalidad.TabIndex = 9;
                        this.EntradaLocalidad.Table = "ciudades";
                        this.EntradaLocalidad.Text = "0";
                        this.EntradaLocalidad.TextDetail = "";
                        // 
                        // EntradaDomicilio
                        // 
                        this.EntradaDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDomicilio.AutoNav = true;
                        this.EntradaDomicilio.AutoTab = true;
                        this.EntradaDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaDomicilio.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDomicilio.DecimalPlaces = -1;
                        this.EntradaDomicilio.FieldName = null;
                        this.EntradaDomicilio.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaDomicilio.Location = new System.Drawing.Point(100, 32);
                        this.EntradaDomicilio.MaxLength = 32767;
                        this.EntradaDomicilio.MultiLine = false;
                        this.EntradaDomicilio.Name = "EntradaDomicilio";
                        this.EntradaDomicilio.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDomicilio.PasswordChar = '\0';
                        this.EntradaDomicilio.PlaceholderText = null;
                        this.EntradaDomicilio.Prefijo = "";
                        this.EntradaDomicilio.ReadOnly = false;
                        this.EntradaDomicilio.SelectOnFocus = false;
                        this.EntradaDomicilio.Size = new System.Drawing.Size(242, 24);
                        this.EntradaDomicilio.Sufijo = "";
                        this.EntradaDomicilio.TabIndex = 1;
                        // 
                        // EntradaNumDoc
                        // 
                        this.EntradaNumDoc.AutoNav = true;
                        this.EntradaNumDoc.AutoTab = true;
                        this.EntradaNumDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaNumDoc.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumDoc.DecimalPlaces = -1;
                        this.EntradaNumDoc.FieldName = null;
                        this.EntradaNumDoc.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumDoc.Location = new System.Drawing.Point(180, 116);
                        this.EntradaNumDoc.MaxLength = 10;
                        this.EntradaNumDoc.MultiLine = false;
                        this.EntradaNumDoc.Name = "EntradaNumDoc";
                        this.EntradaNumDoc.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumDoc.PasswordChar = '\0';
                        this.EntradaNumDoc.PlaceholderText = null;
                        this.EntradaNumDoc.Prefijo = "";
                        this.EntradaNumDoc.ReadOnly = false;
                        this.EntradaNumDoc.SelectOnFocus = true;
                        this.EntradaNumDoc.Size = new System.Drawing.Size(160, 24);
                        this.EntradaNumDoc.Sufijo = "";
                        this.EntradaNumDoc.TabIndex = 7;
                        // 
                        // EntradaTipoDoc
                        // 
                        this.EntradaTipoDoc.AutoNav = true;
                        this.EntradaTipoDoc.AutoTab = true;
                        this.EntradaTipoDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaTipoDoc.CanCreate = false;
                        this.EntradaTipoDoc.DataTextField = "nombre";
                        this.EntradaTipoDoc.DataValueField = "id_tipo_doc";
                        this.EntradaTipoDoc.ExtraDetailFields = "";
                        this.EntradaTipoDoc.FieldName = null;
                        this.EntradaTipoDoc.Filter = "";
                        this.EntradaTipoDoc.FreeTextCode = "";
                        this.EntradaTipoDoc.Location = new System.Drawing.Point(180, 88);
                        this.EntradaTipoDoc.MaxLength = 200;
                        this.EntradaTipoDoc.Name = "EntradaTipoDoc";
                        this.EntradaTipoDoc.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipoDoc.PlaceholderText = null;
                        this.EntradaTipoDoc.ReadOnly = false;
                        this.EntradaTipoDoc.Required = true;
                        this.EntradaTipoDoc.Size = new System.Drawing.Size(160, 24);
                        this.EntradaTipoDoc.TabIndex = 5;
                        this.EntradaTipoDoc.Table = "tipo_doc";
                        this.EntradaTipoDoc.Text = "0";
                        this.EntradaTipoDoc.TextDetail = "";
                        // 
                        // EntradaApellido
                        // 
                        this.EntradaApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaApellido.AutoNav = true;
                        this.EntradaApellido.AutoTab = true;
                        this.EntradaApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaApellido.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaApellido.DecimalPlaces = -1;
                        this.EntradaApellido.FieldName = null;
                        this.EntradaApellido.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaApellido.Location = new System.Drawing.Point(80, 60);
                        this.EntradaApellido.MaxLength = 32767;
                        this.EntradaApellido.MultiLine = false;
                        this.EntradaApellido.Name = "EntradaApellido";
                        this.EntradaApellido.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaApellido.PasswordChar = '\0';
                        this.EntradaApellido.PlaceholderText = null;
                        this.EntradaApellido.Prefijo = "";
                        this.EntradaApellido.ReadOnly = false;
                        this.EntradaApellido.SelectOnFocus = true;
                        this.EntradaApellido.Size = new System.Drawing.Size(262, 24);
                        this.EntradaApellido.Sufijo = "";
                        this.EntradaApellido.TabIndex = 3;
                        this.EntradaApellido.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.FieldName = null;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaNombre.Location = new System.Drawing.Point(80, 32);
                        this.EntradaNombre.MaxLength = 200;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.PlaceholderText = null;
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = true;
                        this.EntradaNombre.Size = new System.Drawing.Size(262, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // EntradaClaveTributaria
                        // 
                        this.EntradaClaveTributaria.AutoNav = true;
                        this.EntradaClaveTributaria.AutoTab = true;
                        this.EntradaClaveTributaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaClaveTributaria.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaClaveTributaria.DecimalPlaces = -1;
                        this.EntradaClaveTributaria.FieldName = null;
                        this.EntradaClaveTributaria.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaClaveTributaria.Location = new System.Drawing.Point(108, 60);
                        this.EntradaClaveTributaria.MaxLength = 32767;
                        this.EntradaClaveTributaria.MultiLine = false;
                        this.EntradaClaveTributaria.Name = "EntradaClaveTributaria";
                        this.EntradaClaveTributaria.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaClaveTributaria.PasswordChar = '\0';
                        this.EntradaClaveTributaria.PlaceholderText = null;
                        this.EntradaClaveTributaria.Prefijo = "";
                        this.EntradaClaveTributaria.ReadOnly = false;
                        this.EntradaClaveTributaria.SelectOnFocus = true;
                        this.EntradaClaveTributaria.Size = new System.Drawing.Size(142, 24);
                        this.EntradaClaveTributaria.Sufijo = "";
                        this.EntradaClaveTributaria.TabIndex = 3;
                        this.EntradaClaveTributaria.Leave += new System.EventHandler(this.EntradaClaveTributaria_Leave);
                        // 
                        // EntradaRazonSocial
                        // 
                        this.EntradaRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaRazonSocial.AutoNav = true;
                        this.EntradaRazonSocial.AutoTab = true;
                        this.EntradaRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaRazonSocial.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaRazonSocial.DecimalPlaces = -1;
                        this.EntradaRazonSocial.FieldName = null;
                        this.EntradaRazonSocial.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaRazonSocial.Location = new System.Drawing.Point(108, 32);
                        this.EntradaRazonSocial.MaxLength = 200;
                        this.EntradaRazonSocial.MultiLine = false;
                        this.EntradaRazonSocial.Name = "EntradaRazonSocial";
                        this.EntradaRazonSocial.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRazonSocial.PasswordChar = '\0';
                        this.EntradaRazonSocial.PlaceholderText = null;
                        this.EntradaRazonSocial.Prefijo = "";
                        this.EntradaRazonSocial.ReadOnly = false;
                        this.EntradaRazonSocial.SelectOnFocus = true;
                        this.EntradaRazonSocial.Size = new System.Drawing.Size(170, 24);
                        this.EntradaRazonSocial.Sufijo = "";
                        this.EntradaRazonSocial.TabIndex = 1;
                        this.EntradaRazonSocial.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // Label10
                        // 
                        this.Label10.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label10.Location = new System.Drawing.Point(8, 88);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(92, 24);
                        this.Label10.TabIndex = 4;
                        this.Label10.Text = "Teléfonos";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label9
                        // 
                        this.Label9.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label9.Location = new System.Drawing.Point(8, 208);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(92, 24);
                        this.Label9.TabIndex = 8;
                        this.Label9.Text = "Localidad";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label8
                        // 
                        this.Label8.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label8.Location = new System.Drawing.Point(8, 32);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(96, 24);
                        this.Label8.TabIndex = 0;
                        this.Label8.Text = "Domicilio";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label6
                        // 
                        this.Label6.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label6.Location = new System.Drawing.Point(8, 116);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(172, 24);
                        this.Label6.TabIndex = 6;
                        this.Label6.Text = "Número de Documento";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(8, 88);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(172, 24);
                        this.Label5.TabIndex = 4;
                        this.Label5.Text = "Tipo de Documento";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(8, 60);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(76, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Apellido";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(8, 32);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(76, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Nombre";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaClaveTributaria
                        // 
                        this.EtiquetaClaveTributaria.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaClaveTributaria.Location = new System.Drawing.Point(8, 60);
                        this.EtiquetaClaveTributaria.Name = "EtiquetaClaveTributaria";
                        this.EtiquetaClaveTributaria.Size = new System.Drawing.Size(100, 24);
                        this.EtiquetaClaveTributaria.TabIndex = 2;
                        this.EtiquetaClaveTributaria.Text = "Clave Tributaria";
                        this.EtiquetaClaveTributaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(8, 32);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(100, 24);
                        this.Label3.TabIndex = 0;
                        this.Label3.Text = "Razón social";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label11
                        // 
                        this.Label11.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label11.Location = new System.Drawing.Point(8, 180);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(92, 24);
                        this.Label11.TabIndex = 6;
                        this.Label11.Text = "E-mail";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame1
                        // 
                        this.Frame1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.Frame1.Controls.Add(this.EntradaNombre);
                        this.Frame1.Controls.Add(this.EntradaApellido);
                        this.Frame1.Controls.Add(this.EntradaTipoDoc);
                        this.Frame1.Controls.Add(this.EntradaNumDoc);
                        this.Frame1.Controls.Add(this.Label1);
                        this.Frame1.Controls.Add(this.Label5);
                        this.Frame1.Controls.Add(this.Label6);
                        this.Frame1.Controls.Add(this.Label2);
                        this.Frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.Frame1.Location = new System.Drawing.Point(3, 3);
                        this.Frame1.Name = "Frame1";
                        this.Frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame1.ReadOnly = false;
                        this.Frame1.Size = new System.Drawing.Size(346, 145);
                        this.Frame1.TabIndex = 0;
                        this.Frame1.Text = "Personas Físicas";
                        // 
                        // Frame2
                        // 
                        this.Frame2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.Frame2.Controls.Add(this.EntradaRazonSocial);
                        this.Frame2.Controls.Add(this.EntradaClaveTributaria);
                        this.Frame2.Controls.Add(this.EntradaSituacion);
                        this.Frame2.Controls.Add(this.EntradaTipoFac);
                        this.Frame2.Controls.Add(this.Label3);
                        this.Frame2.Controls.Add(this.Label15);
                        this.Frame2.Controls.Add(this.EtiquetaClaveTributaria);
                        this.Frame2.Controls.Add(this.Label12);
                        this.Frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.Frame2.Location = new System.Drawing.Point(355, 3);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.ReadOnly = false;
                        this.Frame2.Size = new System.Drawing.Size(282, 145);
                        this.Frame2.TabIndex = 1;
                        this.Frame2.Text = "Personas Jurídicas";
                        // 
                        // Label15
                        // 
                        this.Label15.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label15.Location = new System.Drawing.Point(8, 116);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(116, 24);
                        this.Label15.TabIndex = 6;
                        this.Label15.Text = "Facturación";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label12
                        // 
                        this.Label12.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label12.Location = new System.Drawing.Point(8, 88);
                        this.Label12.Name = "Label12";
                        this.Label12.Size = new System.Drawing.Size(116, 24);
                        this.Label12.TabIndex = 4;
                        this.Label12.Text = "Situación trib.";
                        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSituacion
                        // 
                        this.EntradaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSituacion.AutoNav = true;
                        this.EntradaSituacion.AutoTab = true;
                        this.EntradaSituacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaSituacion.CanCreate = false;
                        this.EntradaSituacion.DataTextField = "nombre";
                        this.EntradaSituacion.DataValueField = "id_situacion";
                        this.EntradaSituacion.ExtraDetailFields = "";
                        this.EntradaSituacion.FieldName = null;
                        this.EntradaSituacion.Filter = "";
                        this.EntradaSituacion.FreeTextCode = "";
                        this.EntradaSituacion.Location = new System.Drawing.Point(124, 88);
                        this.EntradaSituacion.MaxLength = 200;
                        this.EntradaSituacion.Name = "EntradaSituacion";
                        this.EntradaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSituacion.PlaceholderText = null;
                        this.EntradaSituacion.ReadOnly = false;
                        this.EntradaSituacion.Required = true;
                        this.EntradaSituacion.Size = new System.Drawing.Size(154, 24);
                        this.EntradaSituacion.TabIndex = 5;
                        this.EntradaSituacion.Table = "situaciones";
                        this.EntradaSituacion.Text = "0";
                        this.EntradaSituacion.TextDetail = "";
                        this.EntradaSituacion.Leave += new System.EventHandler(this.EntradaSituacion_Leave);
                        // 
                        // EntradaTipoFac
                        // 
                        this.EntradaTipoFac.AlwaysExpanded = false;
                        this.EntradaTipoFac.AutoNav = true;
                        this.EntradaTipoFac.AutoTab = true;
                        this.EntradaTipoFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaTipoFac.FieldName = null;
                        this.EntradaTipoFac.Location = new System.Drawing.Point(124, 116);
                        this.EntradaTipoFac.MaxLength = 32767;
                        this.EntradaTipoFac.Name = "EntradaTipoFac";
                        this.EntradaTipoFac.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipoFac.PlaceholderText = null;
                        this.EntradaTipoFac.ReadOnly = false;
                        this.EntradaTipoFac.SetData = new string[] {
        "Predeterminada|*",
        "Factura A|A",
        "Factura B|B",
        "Factura C|C",
        "Factura E|E",
        "Ticket|T"};
                        this.EntradaTipoFac.Size = new System.Drawing.Size(188, 24);
                        this.EntradaTipoFac.TabIndex = 7;
                        this.EntradaTipoFac.TextKey = "*";
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaTipo.CanCreate = false;
                        this.EntradaTipo.DataTextField = "nombre";
                        this.EntradaTipo.DataValueField = "id_tipo_persona";
                        this.EntradaTipo.ExtraDetailFields = "";
                        this.EntradaTipo.FieldName = null;
                        this.EntradaTipo.Filter = "";
                        this.EntradaTipo.FreeTextCode = "";
                        this.EntradaTipo.Location = new System.Drawing.Point(84, 88);
                        this.EntradaTipo.MaxLength = 200;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.PlaceholderText = "Sin especificar";
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.Required = true;
                        this.EntradaTipo.Size = new System.Drawing.Size(194, 24);
                        this.EntradaTipo.TabIndex = 5;
                        this.EntradaTipo.Table = "personas_tipos";
                        this.EntradaTipo.Text = "0";
                        this.EntradaTipo.TextDetail = "";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipo_TextChanged);
                        // 
                        // Label14
                        // 
                        this.Label14.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label14.Location = new System.Drawing.Point(8, 88);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(80, 24);
                        this.Label14.TabIndex = 4;
                        this.Label14.Text = "Tipo";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaGrupo
                        // 
                        this.EntradaGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaGrupo.AutoNav = true;
                        this.EntradaGrupo.AutoTab = true;
                        this.EntradaGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaGrupo.CanCreate = true;
                        this.EntradaGrupo.DataTextField = "nombre";
                        this.EntradaGrupo.DataValueField = "id_grupo";
                        this.EntradaGrupo.ExtraDetailFields = "";
                        this.EntradaGrupo.FieldName = null;
                        this.EntradaGrupo.Filter = "parent IS NULL";
                        this.EntradaGrupo.FreeTextCode = "";
                        this.EntradaGrupo.Location = new System.Drawing.Point(84, 32);
                        this.EntradaGrupo.MaxLength = 200;
                        this.EntradaGrupo.Name = "EntradaGrupo";
                        this.EntradaGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGrupo.PlaceholderText = "Ninguno";
                        this.EntradaGrupo.ReadOnly = false;
                        this.EntradaGrupo.Required = false;
                        this.EntradaGrupo.Size = new System.Drawing.Size(194, 24);
                        this.EntradaGrupo.TabIndex = 1;
                        this.EntradaGrupo.Table = "personas_grupos";
                        this.EntradaGrupo.Text = "0";
                        this.EntradaGrupo.TextDetail = "";
                        this.EntradaGrupo.TextChanged += new System.EventHandler(this.EntradaGrupo_TextChanged);
                        // 
                        // Label16
                        // 
                        this.Label16.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label16.Location = new System.Drawing.Point(8, 32);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(80, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Grupo";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // BotonPermisos
                        // 
                        this.BotonPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.BotonPermisos.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonPermisos.Image = null;
                        this.BotonPermisos.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonPermisos.Location = new System.Drawing.Point(284, 32);
                        this.BotonPermisos.Name = "BotonPermisos";
                        this.BotonPermisos.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonPermisos.ReadOnly = false;
                        this.BotonPermisos.Size = new System.Drawing.Size(88, 44);
                        this.BotonPermisos.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonPermisos.Subtext = "F2";
                        this.BotonPermisos.TabIndex = 6;
                        this.BotonPermisos.Text = "Permisos";
                        this.BotonPermisos.Visible = false;
                        this.BotonPermisos.Click += new System.EventHandler(this.BotonPermisos_Click);
                        // 
                        // EntradaLimiteCredito
                        // 
                        this.EntradaLimiteCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaLimiteCredito.AutoNav = true;
                        this.EntradaLimiteCredito.AutoTab = true;
                        this.EntradaLimiteCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaLimiteCredito.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaLimiteCredito.DecimalPlaces = -1;
                        this.EntradaLimiteCredito.FieldName = null;
                        this.EntradaLimiteCredito.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaLimiteCredito.Location = new System.Drawing.Point(144, 116);
                        this.EntradaLimiteCredito.MaxLength = 16;
                        this.EntradaLimiteCredito.MultiLine = false;
                        this.EntradaLimiteCredito.Name = "EntradaLimiteCredito";
                        this.EntradaLimiteCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLimiteCredito.PasswordChar = '\0';
                        this.EntradaLimiteCredito.PlaceholderText = null;
                        this.EntradaLimiteCredito.Prefijo = "$";
                        this.EntradaLimiteCredito.ReadOnly = false;
                        this.EntradaLimiteCredito.SelectOnFocus = true;
                        this.EntradaLimiteCredito.Size = new System.Drawing.Size(134, 24);
                        this.EntradaLimiteCredito.Sufijo = "";
                        this.EntradaLimiteCredito.TabIndex = 7;
                        this.EntradaLimiteCredito.Text = "0.00";
                        // 
                        // label17
                        // 
                        this.label17.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label17.Location = new System.Drawing.Point(8, 116);
                        this.label17.Name = "label17";
                        this.label17.Size = new System.Drawing.Size(136, 24);
                        this.label17.TabIndex = 6;
                        this.label17.Text = "Límite de crédito";
                        this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaNac
                        // 
                        this.EntradaFechaNac.AutoNav = true;
                        this.EntradaFechaNac.AutoTab = true;
                        this.EntradaFechaNac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaFechaNac.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaNac.DecimalPlaces = -1;
                        this.EntradaFechaNac.FieldName = null;
                        this.EntradaFechaNac.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaNac.Location = new System.Drawing.Point(160, 264);
                        this.EntradaFechaNac.MaxLength = 32767;
                        this.EntradaFechaNac.MultiLine = false;
                        this.EntradaFechaNac.Name = "EntradaFechaNac";
                        this.EntradaFechaNac.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaNac.PasswordChar = '\0';
                        this.EntradaFechaNac.PlaceholderText = null;
                        this.EntradaFechaNac.Prefijo = "";
                        this.EntradaFechaNac.ReadOnly = false;
                        this.EntradaFechaNac.SelectOnFocus = true;
                        this.EntradaFechaNac.Size = new System.Drawing.Size(152, 24);
                        this.EntradaFechaNac.Sufijo = "";
                        this.EntradaFechaNac.TabIndex = 13;
                        // 
                        // label18
                        // 
                        this.label18.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label18.Location = new System.Drawing.Point(8, 264);
                        this.label18.Name = "label18";
                        this.label18.Size = new System.Drawing.Size(156, 24);
                        this.label18.TabIndex = 12;
                        this.label18.Text = "Fecha de Nacimiento";
                        this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDomicilioTrabajo
                        // 
                        this.EntradaDomicilioTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDomicilioTrabajo.AutoNav = true;
                        this.EntradaDomicilioTrabajo.AutoTab = true;
                        this.EntradaDomicilioTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaDomicilioTrabajo.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDomicilioTrabajo.DecimalPlaces = -1;
                        this.EntradaDomicilioTrabajo.FieldName = null;
                        this.EntradaDomicilioTrabajo.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaDomicilioTrabajo.Location = new System.Drawing.Point(100, 60);
                        this.EntradaDomicilioTrabajo.MaxLength = 200;
                        this.EntradaDomicilioTrabajo.MultiLine = false;
                        this.EntradaDomicilioTrabajo.Name = "EntradaDomicilioTrabajo";
                        this.EntradaDomicilioTrabajo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDomicilioTrabajo.PasswordChar = '\0';
                        this.EntradaDomicilioTrabajo.PlaceholderText = null;
                        this.EntradaDomicilioTrabajo.Prefijo = "";
                        this.EntradaDomicilioTrabajo.ReadOnly = false;
                        this.EntradaDomicilioTrabajo.SelectOnFocus = false;
                        this.EntradaDomicilioTrabajo.Size = new System.Drawing.Size(242, 24);
                        this.EntradaDomicilioTrabajo.Sufijo = "";
                        this.EntradaDomicilioTrabajo.TabIndex = 3;
                        // 
                        // label19
                        // 
                        this.label19.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label19.Location = new System.Drawing.Point(8, 60);
                        this.label19.Name = "label19";
                        this.label19.Size = new System.Drawing.Size(96, 24);
                        this.label19.TabIndex = 2;
                        this.label19.Text = "Dom. laboral";
                        this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstadoCredito
                        // 
                        this.EntradaEstadoCredito.AlwaysExpanded = false;
                        this.EntradaEstadoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstadoCredito.AutoNav = true;
                        this.EntradaEstadoCredito.AutoTab = true;
                        this.EntradaEstadoCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaEstadoCredito.FieldName = null;
                        this.EntradaEstadoCredito.Location = new System.Drawing.Point(144, 144);
                        this.EntradaEstadoCredito.MaxLength = 32767;
                        this.EntradaEstadoCredito.Name = "EntradaEstadoCredito";
                        this.EntradaEstadoCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstadoCredito.PlaceholderText = null;
                        this.EntradaEstadoCredito.ReadOnly = false;
                        this.EntradaEstadoCredito.SetData = new string[] {
        "Normal|0",
        "En Plan de Pagos|5",
        "Susp. con React. Automática|10",
        "Susp. con Reactivación Manual|100"};
                        this.EntradaEstadoCredito.Size = new System.Drawing.Size(134, 24);
                        this.EntradaEstadoCredito.TabIndex = 9;
                        this.EntradaEstadoCredito.TextKey = "100";
                        // 
                        // label21
                        // 
                        this.label21.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label21.Location = new System.Drawing.Point(8, 144);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(136, 24);
                        this.label21.TabIndex = 8;
                        this.label21.Text = "Estado de crédito";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaClaveBancaria
                        // 
                        this.EntradaClaveBancaria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaClaveBancaria.AutoNav = true;
                        this.EntradaClaveBancaria.AutoTab = true;
                        this.EntradaClaveBancaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaClaveBancaria.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaClaveBancaria.DecimalPlaces = -1;
                        this.EntradaClaveBancaria.FieldName = null;
                        this.EntradaClaveBancaria.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaClaveBancaria.Location = new System.Drawing.Point(72, 200);
                        this.EntradaClaveBancaria.MaxLength = 32767;
                        this.EntradaClaveBancaria.MultiLine = false;
                        this.EntradaClaveBancaria.Name = "EntradaClaveBancaria";
                        this.EntradaClaveBancaria.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaClaveBancaria.PasswordChar = '\0';
                        this.EntradaClaveBancaria.PlaceholderText = null;
                        this.EntradaClaveBancaria.Prefijo = "";
                        this.EntradaClaveBancaria.ReadOnly = false;
                        this.EntradaClaveBancaria.SelectOnFocus = true;
                        this.EntradaClaveBancaria.Size = new System.Drawing.Size(206, 24);
                        this.EntradaClaveBancaria.Sufijo = "";
                        this.EntradaClaveBancaria.TabIndex = 13;
                        // 
                        // label20
                        // 
                        this.EtiquetaClaveBancaria.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaClaveBancaria.Location = new System.Drawing.Point(8, 200);
                        this.EtiquetaClaveBancaria.Name = "label20";
                        this.EtiquetaClaveBancaria.Size = new System.Drawing.Size(64, 24);
                        this.EtiquetaClaveBancaria.TabIndex = 12;
                        this.EtiquetaClaveBancaria.Text = "CBU";
                        this.EtiquetaClaveBancaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNumeroCuenta
                        // 
                        this.EntradaNumeroCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNumeroCuenta.AutoNav = true;
                        this.EntradaNumeroCuenta.AutoTab = true;
                        this.EntradaNumeroCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaNumeroCuenta.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumeroCuenta.DecimalPlaces = -1;
                        this.EntradaNumeroCuenta.FieldName = null;
                        this.EntradaNumeroCuenta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumeroCuenta.Location = new System.Drawing.Point(144, 172);
                        this.EntradaNumeroCuenta.MaxLength = 200;
                        this.EntradaNumeroCuenta.MultiLine = false;
                        this.EntradaNumeroCuenta.Name = "EntradaNumeroCuenta";
                        this.EntradaNumeroCuenta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumeroCuenta.PasswordChar = '\0';
                        this.EntradaNumeroCuenta.PlaceholderText = null;
                        this.EntradaNumeroCuenta.Prefijo = "";
                        this.EntradaNumeroCuenta.ReadOnly = false;
                        this.EntradaNumeroCuenta.SelectOnFocus = true;
                        this.EntradaNumeroCuenta.Size = new System.Drawing.Size(134, 24);
                        this.EntradaNumeroCuenta.Sufijo = "";
                        this.EntradaNumeroCuenta.TabIndex = 11;
                        // 
                        // label22
                        // 
                        this.label22.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label22.Location = new System.Drawing.Point(8, 172);
                        this.label22.Name = "label22";
                        this.label22.Size = new System.Drawing.Size(136, 24);
                        this.label22.TabIndex = 10;
                        this.label22.Text = "Número de cuenta";
                        this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // frame3
                        // 
                        this.frame3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.frame3.Controls.Add(this.EntradaDomicilio);
                        this.frame3.Controls.Add(this.EntradaVendedor);
                        this.frame3.Controls.Add(this.EntradaDomicilioTrabajo);
                        this.frame3.Controls.Add(this.EntradaFechaNac);
                        this.frame3.Controls.Add(this.EntradaEmail);
                        this.frame3.Controls.Add(this.EntradaLocalidad);
                        this.frame3.Controls.Add(this.Label8);
                        this.frame3.Controls.Add(this.label23);
                        this.frame3.Controls.Add(this.EntradaTelefono);
                        this.frame3.Controls.Add(this.Label11);
                        this.frame3.Controls.Add(this.Label10);
                        this.frame3.Controls.Add(this.Label9);
                        this.frame3.Controls.Add(this.label18);
                        this.frame3.Controls.Add(this.label19);
                        this.frame3.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.frame3.Location = new System.Drawing.Point(3, 154);
                        this.frame3.Name = "frame3";
                        this.frame3.Padding = new System.Windows.Forms.Padding(2);
                        this.frame3.ReadOnly = false;
                        this.frame3.Size = new System.Drawing.Size(346, 290);
                        this.frame3.TabIndex = 2;
                        this.frame3.Text = "Datos de Contacto";
                        // 
                        // EntradaVendedor
                        // 
                        this.EntradaVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaVendedor.AutoNav = true;
                        this.EntradaVendedor.AutoTab = true;
                        this.EntradaVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaVendedor.CanCreate = true;
                        this.EntradaVendedor.DataTextField = "nombre_visible";
                        this.EntradaVendedor.DataValueField = "id_persona";
                        this.EntradaVendedor.ExtraDetailFields = "";
                        this.EntradaVendedor.FieldName = null;
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.Location = new System.Drawing.Point(100, 236);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaVendedor.PlaceholderText = "Ninguno";
                        this.EntradaVendedor.ReadOnly = false;
                        this.EntradaVendedor.Required = false;
                        this.EntradaVendedor.Size = new System.Drawing.Size(242, 24);
                        this.EntradaVendedor.TabIndex = 11;
                        this.EntradaVendedor.Table = "personas";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
                        // 
                        // label23
                        // 
                        this.label23.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label23.Location = new System.Drawing.Point(8, 236);
                        this.label23.Name = "label23";
                        this.label23.Size = new System.Drawing.Size(96, 24);
                        this.label23.TabIndex = 10;
                        this.label23.Text = "Vendedor";
                        this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTelefono
                        // 
                        this.EntradaTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTelefono.AutoNav = true;
                        this.EntradaTelefono.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.EntradaTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaTelefono.FieldName = null;
                        this.EntradaTelefono.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.EntradaTelefono.Location = new System.Drawing.Point(8, 88);
                        this.EntradaTelefono.Name = "EntradaTelefono";
                        this.EntradaTelefono.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTelefono.ReadOnly = false;
                        this.EntradaTelefono.Size = new System.Drawing.Size(336, 88);
                        this.EntradaTelefono.TabIndex = 5;
                        // 
                        // frame4
                        // 
                        this.frame4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.frame4.Controls.Add(this.EntradaSubGrupo);
                        this.frame4.Controls.Add(this.EntradaGrupo);
                        this.frame4.Controls.Add(this.EntradaClaveBancaria);
                        this.frame4.Controls.Add(this.EntradaNumeroCuenta);
                        this.frame4.Controls.Add(this.EntradaLimiteCredito);
                        this.frame4.Controls.Add(this.EntradaEstadoCredito);
                        this.frame4.Controls.Add(this.EntradaTipo);
                        this.frame4.Controls.Add(this.EtiquetaClaveBancaria);
                        this.frame4.Controls.Add(this.label17);
                        this.frame4.Controls.Add(this.Label14);
                        this.frame4.Controls.Add(this.label22);
                        this.frame4.Controls.Add(this.label21);
                        this.frame4.Controls.Add(this.label13);
                        this.frame4.Controls.Add(this.Label16);
                        this.frame4.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.frame4.Location = new System.Drawing.Point(355, 154);
                        this.frame4.Name = "frame4";
                        this.frame4.Padding = new System.Windows.Forms.Padding(2);
                        this.frame4.ReadOnly = false;
                        this.frame4.Size = new System.Drawing.Size(282, 234);
                        this.frame4.TabIndex = 3;
                        this.frame4.Text = "Otros datos";
                        // 
                        // EntradaSubGrupo
                        // 
                        this.EntradaSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSubGrupo.AutoNav = true;
                        this.EntradaSubGrupo.AutoTab = true;
                        this.EntradaSubGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaSubGrupo.CanCreate = true;
                        this.EntradaSubGrupo.DataTextField = "nombre";
                        this.EntradaSubGrupo.DataValueField = "id_grupo";
                        this.EntradaSubGrupo.ExtraDetailFields = "";
                        this.EntradaSubGrupo.FieldName = null;
                        this.EntradaSubGrupo.Filter = "parent IS NULL";
                        this.EntradaSubGrupo.FreeTextCode = "";
                        this.EntradaSubGrupo.Location = new System.Drawing.Point(84, 60);
                        this.EntradaSubGrupo.MaxLength = 200;
                        this.EntradaSubGrupo.Name = "EntradaSubGrupo";
                        this.EntradaSubGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubGrupo.PlaceholderText = "Ninguno";
                        this.EntradaSubGrupo.ReadOnly = false;
                        this.EntradaSubGrupo.Required = false;
                        this.EntradaSubGrupo.Size = new System.Drawing.Size(194, 24);
                        this.EntradaSubGrupo.TabIndex = 3;
                        this.EntradaSubGrupo.Table = "personas_grupos";
                        this.EntradaSubGrupo.Text = "0";
                        this.EntradaSubGrupo.TextDetail = "";
                        // 
                        // label13
                        // 
                        this.label13.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label13.Location = new System.Drawing.Point(8, 60);
                        this.label13.Name = "label13";
                        this.label13.Size = new System.Drawing.Size(80, 24);
                        this.label13.TabIndex = 2;
                        this.label13.Text = "Sub-grupo";
                        this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AlwaysExpanded = false;
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaEstado.FieldName = null;
                        this.EntradaEstado.Location = new System.Drawing.Point(120, 32);
                        this.EntradaEstado.MaxLength = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.PlaceholderText = null;
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "Inactivo|0",
        "Activo|1"};
                        this.EntradaEstado.Size = new System.Drawing.Size(131, 24);
                        this.EntradaEstado.TabIndex = 1;
                        this.EntradaEstado.TextKey = "1";
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.EntradaObs.FieldName = null;
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaObs.Location = new System.Drawing.Point(355, 450);
                        this.EntradaObs.MaxLength = 32767;
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.PlaceholderText = null;
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(282, 240);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 5;
                        // 
                        // EntradaNombreVisible
                        // 
                        this.EntradaNombreVisible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombreVisible.AutoNav = true;
                        this.EntradaNombreVisible.AutoTab = true;
                        this.EntradaNombreVisible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaNombreVisible.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombreVisible.DecimalPlaces = -1;
                        this.EntradaNombreVisible.FieldName = null;
                        this.EntradaNombreVisible.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombreVisible.Location = new System.Drawing.Point(123, 8);
                        this.EntradaNombreVisible.MaxLength = 32767;
                        this.EntradaNombreVisible.MultiLine = false;
                        this.EntradaNombreVisible.Name = "EntradaNombreVisible";
                        this.EntradaNombreVisible.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombreVisible.PasswordChar = '\0';
                        this.EntradaNombreVisible.PlaceholderText = null;
                        this.EntradaNombreVisible.Prefijo = "";
                        this.EntradaNombreVisible.ReadOnly = true;
                        this.EntradaNombreVisible.SelectOnFocus = true;
                        this.EntradaNombreVisible.Size = new System.Drawing.Size(508, 28);
                        this.EntradaNombreVisible.Sufijo = "";
                        this.EntradaNombreVisible.TabIndex = 1;
                        this.EntradaNombreVisible.TabStop = false;
                        // 
                        // Label4
                        // 
                        this.Label4.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(8, 8);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(116, 28);
                        this.Label4.TabIndex = 0;
                        this.Label4.Text = "Nombre visible";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // TableLayoutPanel
                        // 
                        this.TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.TableLayoutPanel.AutoSize = true;
                        this.TableLayoutPanel.ColumnCount = 2;
                        this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
                        this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
                        this.TableLayoutPanel.Controls.Add(this.frame4, 1, 1);
                        this.TableLayoutPanel.Controls.Add(this.Frame2, 1, 0);
                        this.TableLayoutPanel.Controls.Add(this.Frame1, 0, 0);
                        this.TableLayoutPanel.Controls.Add(this.frame5, 0, 2);
                        this.TableLayoutPanel.Controls.Add(this.EntradaObs, 1, 2);
                        this.TableLayoutPanel.Controls.Add(this.frame3, 0, 1);
                        this.TableLayoutPanel.Location = new System.Drawing.Point(0, 44);
                        this.TableLayoutPanel.Name = "TableLayoutPanel";
                        this.TableLayoutPanel.RowCount = 3;
                        this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TableLayoutPanel.Size = new System.Drawing.Size(640, 693);
                        this.TableLayoutPanel.TabIndex = 0;
                        // 
                        // frame5
                        // 
                        this.frame5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.frame5.Controls.Add(this.BotonPermisos);
                        this.frame5.Controls.Add(this.EntradaEstado);
                        this.frame5.Controls.Add(this.EntradaFechaBaja);
                        this.frame5.Controls.Add(this.EntradaFechaAlta);
                        this.frame5.Controls.Add(this.label24);
                        this.frame5.Controls.Add(this.label26);
                        this.frame5.Controls.Add(this.label25);
                        this.frame5.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.frame5.Location = new System.Drawing.Point(3, 450);
                        this.frame5.Name = "frame5";
                        this.frame5.Padding = new System.Windows.Forms.Padding(2);
                        this.frame5.ReadOnly = false;
                        this.frame5.Size = new System.Drawing.Size(346, 118);
                        this.frame5.TabIndex = 4;
                        this.frame5.Text = "Estado";
                        // 
                        // label24
                        // 
                        this.label24.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label24.Location = new System.Drawing.Point(4, 32);
                        this.label24.Name = "label24";
                        this.label24.Size = new System.Drawing.Size(116, 24);
                        this.label24.TabIndex = 0;
                        this.label24.Text = "Estado";
                        this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label26
                        // 
                        this.label26.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label26.Location = new System.Drawing.Point(4, 88);
                        this.label26.Name = "label26";
                        this.label26.Size = new System.Drawing.Size(116, 24);
                        this.label26.TabIndex = 4;
                        this.label26.Text = "Fecha de Baja";
                        this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaBaja
                        // 
                        this.EntradaFechaBaja.AutoNav = true;
                        this.EntradaFechaBaja.AutoTab = true;
                        this.EntradaFechaBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaFechaBaja.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaBaja.DecimalPlaces = -1;
                        this.EntradaFechaBaja.FieldName = null;
                        this.EntradaFechaBaja.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaBaja.Location = new System.Drawing.Point(120, 88);
                        this.EntradaFechaBaja.MaxLength = 32767;
                        this.EntradaFechaBaja.MultiLine = false;
                        this.EntradaFechaBaja.Name = "EntradaFechaBaja";
                        this.EntradaFechaBaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaBaja.PasswordChar = '\0';
                        this.EntradaFechaBaja.PlaceholderText = null;
                        this.EntradaFechaBaja.Prefijo = "";
                        this.EntradaFechaBaja.ReadOnly = true;
                        this.EntradaFechaBaja.SelectOnFocus = true;
                        this.EntradaFechaBaja.Size = new System.Drawing.Size(152, 24);
                        this.EntradaFechaBaja.Sufijo = "";
                        this.EntradaFechaBaja.TabIndex = 5;
                        this.EntradaFechaBaja.TabStop = false;
                        // 
                        // label25
                        // 
                        this.label25.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label25.Location = new System.Drawing.Point(4, 60);
                        this.label25.Name = "label25";
                        this.label25.Size = new System.Drawing.Size(116, 24);
                        this.label25.TabIndex = 2;
                        this.label25.Text = "Fecha de Alta";
                        this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaAlta
                        // 
                        this.EntradaFechaAlta.AutoNav = true;
                        this.EntradaFechaAlta.AutoTab = true;
                        this.EntradaFechaAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaFechaAlta.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaAlta.DecimalPlaces = -1;
                        this.EntradaFechaAlta.FieldName = null;
                        this.EntradaFechaAlta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaAlta.Location = new System.Drawing.Point(120, 60);
                        this.EntradaFechaAlta.MaxLength = 32767;
                        this.EntradaFechaAlta.MultiLine = false;
                        this.EntradaFechaAlta.Name = "EntradaFechaAlta";
                        this.EntradaFechaAlta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaAlta.PasswordChar = '\0';
                        this.EntradaFechaAlta.PlaceholderText = null;
                        this.EntradaFechaAlta.Prefijo = "";
                        this.EntradaFechaAlta.ReadOnly = true;
                        this.EntradaFechaAlta.SelectOnFocus = true;
                        this.EntradaFechaAlta.Size = new System.Drawing.Size(152, 24);
                        this.EntradaFechaAlta.Sufijo = "";
                        this.EntradaFechaAlta.TabIndex = 3;
                        this.EntradaFechaAlta.TabStop = false;
                        // 
                        // matrizTelefonos1
                        // 
                        this.matrizTelefonos1.AutoNav = true;
                        this.matrizTelefonos1.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.matrizTelefonos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.matrizTelefonos1.FieldName = null;
                        this.matrizTelefonos1.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.matrizTelefonos1.Location = new System.Drawing.Point(0, 0);
                        this.matrizTelefonos1.Name = "matrizTelefonos1";
                        this.matrizTelefonos1.Padding = new System.Windows.Forms.Padding(2);
                        this.matrizTelefonos1.ReadOnly = false;
                        this.matrizTelefonos1.Size = new System.Drawing.Size(536, 180);
                        this.matrizTelefonos1.TabIndex = 0;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.TableLayoutPanel);
                        this.Controls.Add(this.EntradaNombreVisible);
                        this.Controls.Add(this.Label4);
                        this.MinimumSize = new System.Drawing.Size(640, 615);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 615);
                        this.Controls.SetChildIndex(this.ControlCaption, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EntradaNombreVisible, 0);
                        this.Controls.SetChildIndex(this.TableLayoutPanel, 0);
                        this.Frame1.ResumeLayout(false);
                        this.Frame1.PerformLayout();
                        this.Frame2.ResumeLayout(false);
                        this.Frame2.PerformLayout();
                        this.frame3.ResumeLayout(false);
                        this.frame3.PerformLayout();
                        this.frame4.ResumeLayout(false);
                        this.frame4.PerformLayout();
                        this.TableLayoutPanel.ResumeLayout(false);
                        this.frame5.ResumeLayout(false);
                        this.frame5.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.TextBox EntradaEmail;
                internal Lcc.Entrada.CodigoDetalle EntradaLocalidad;
                internal Lui.Forms.TextBox EntradaDomicilio;
                internal Lui.Forms.TextBox EntradaNumDoc;
                internal Lcc.Entrada.CodigoDetalle EntradaTipoDoc;
                internal Lui.Forms.TextBox EntradaApellido;
                internal Lui.Forms.TextBox EntradaNombre;
                internal Lui.Forms.TextBox EntradaClaveTributaria;
                internal Lui.Forms.TextBox EntradaRazonSocial;
                internal Lui.Forms.Label Label10;
                internal Lui.Forms.Label Label9;
                internal Lui.Forms.Label Label8;
                internal Lui.Forms.Label Label6;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.Label EtiquetaClaveTributaria;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.Label Label11;
                internal Lui.Forms.Frame Frame1;
                internal Lui.Forms.Frame Frame2;
                internal Lcc.Entrada.CodigoDetalle EntradaSituacion;
                internal Lui.Forms.Label Label12;
                internal Lui.Forms.Label Label14;
                public Lcc.Entrada.CodigoDetalle EntradaTipo;
                internal Lui.Forms.Label Label15;
                internal Lui.Forms.ComboBox EntradaTipoFac;
                internal Lui.Forms.Label Label16;
                internal Lui.Forms.Button BotonPermisos;
                internal Lui.Forms.TextBox EntradaLimiteCredito;
                internal Lui.Forms.Label label17;
                internal Lui.Forms.Label label18;
                internal Lui.Forms.TextBox EntradaFechaNac;
                internal Lui.Forms.TextBox EntradaDomicilioTrabajo;
                internal Lui.Forms.Label label19;
                internal Lui.Forms.ComboBox EntradaEstadoCredito;
                internal Lui.Forms.Label label21;
                internal Lui.Forms.TextBox EntradaNumeroCuenta;
                internal Lui.Forms.Label label22;
                internal Lui.Forms.TextBox EntradaClaveBancaria;
                internal Lcc.Entrada.CodigoDetalle EntradaGrupo;
                private Lui.Forms.Frame frame3;
                private Lui.Forms.Frame frame4;
                private Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.TextBox EntradaNombreVisible;
                private TableLayoutPanel TableLayoutPanel;
                internal Lcc.Entrada.CodigoDetalle EntradaSubGrupo;
                internal Lcc.Entrada.CodigoDetalle EntradaVendedor;
                private Lui.Forms.Frame frame5;
                internal Lui.Forms.TextBox EntradaFechaBaja;
                internal Lui.Forms.TextBox EntradaFechaAlta;
                internal Lui.Forms.ComboBox EntradaEstado;
                private Lcc.Entrada.MatrizTelefonos matrizTelefonos1;
                private Lcc.Entrada.MatrizTelefonos EntradaTelefono;
                internal Lui.Forms.Label EtiquetaClaveBancaria;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label label13;
                internal Lui.Forms.Label label23;
                internal Lui.Forms.Label label26;
                internal Lui.Forms.Label label25;
                internal Lui.Forms.Label label24;

        }
}
