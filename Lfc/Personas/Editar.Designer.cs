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
                        this.EntradaCuit = new Lui.Forms.TextBox();
                        this.EntradaRazonSocial = new Lui.Forms.TextBox();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.Frame1 = new Lui.Forms.Frame();
                        this.Frame2 = new Lui.Forms.Frame();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.Label12 = new System.Windows.Forms.Label();
                        this.EntradaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaTipoFac = new Lui.Forms.ComboBox();
                        this.EntradaTipo = new Lcc.Entrada.CodigoDetalle();
                        this.Label14 = new System.Windows.Forms.Label();
                        this.EntradaGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.BotonAcceso = new Lui.Forms.Button();
                        this.EntradaLimiteCredito = new Lui.Forms.TextBox();
                        this.label17 = new System.Windows.Forms.Label();
                        this.EntradaFechaNac = new Lui.Forms.TextBox();
                        this.label18 = new System.Windows.Forms.Label();
                        this.EntradaDomicilioTrabajo = new Lui.Forms.TextBox();
                        this.label19 = new System.Windows.Forms.Label();
                        this.EntradaEstadoCredito = new Lui.Forms.ComboBox();
                        this.label21 = new System.Windows.Forms.Label();
                        this.EntradaCbu = new Lui.Forms.TextBox();
                        this.label20 = new System.Windows.Forms.Label();
                        this.EntradaNumeroCuenta = new Lui.Forms.TextBox();
                        this.label22 = new System.Windows.Forms.Label();
                        this.frame3 = new Lui.Forms.Frame();
                        this.EntradaVendedor = new Lcc.Entrada.CodigoDetalle();
                        this.label23 = new System.Windows.Forms.Label();
                        this.EntradaTelefono = new Lcc.Entrada.MatrizTelefonos();
                        this.frame4 = new Lui.Forms.Frame();
                        this.EntradaSubGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.label13 = new System.Windows.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.EntradaNombreVisible = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
                        this.frame5 = new Lui.Forms.Frame();
                        this.label26 = new System.Windows.Forms.Label();
                        this.EntradaFechaBaja = new Lui.Forms.TextBox();
                        this.label25 = new System.Windows.Forms.Label();
                        this.label24 = new System.Windows.Forms.Label();
                        this.EntradaFechaAlta = new Lui.Forms.TextBox();
                        this.EntradaTags = new Lcc.Edicion.MatrizTags();
                        this.EntradaImagen = new Lcc.Entrada.Imagen();
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
                        this.EntradaEmail.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmail.DecimalPlaces = -1;
                        this.EntradaEmail.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmail.ForceCase = Lui.Forms.TextCasing.LowerCase;
                        this.EntradaEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmail.Location = new System.Drawing.Point(100, 176);
                        this.EntradaEmail.MaxLenght = 32767;
                        this.EntradaEmail.MultiLine = false;
                        this.EntradaEmail.Name = "EntradaEmail";
                        this.EntradaEmail.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmail.PasswordChar = '\0';
                        this.EntradaEmail.Prefijo = "";
                        this.EntradaEmail.SelectOnFocus = true;
                        this.EntradaEmail.Size = new System.Drawing.Size(242, 24);
                        this.EntradaEmail.Sufijo = "";
                        this.EntradaEmail.TabIndex = 7;
                        this.EntradaEmail.TipWhenBlank = "";
                        this.EntradaEmail.ToolTipText = "";
                        this.EntradaEmail.Leave += new System.EventHandler(this.EntradaEmail_Leave);
                        // 
                        // EntradaLocalidad
                        // 
                        this.EntradaLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaLocalidad.AutoNav = true;
                        this.EntradaLocalidad.AutoTab = true;
                        this.EntradaLocalidad.CanCreate = true;
                        this.EntradaLocalidad.DataTextField = "nombre";
                        this.EntradaLocalidad.DataValueField = "id_ciudad";
                        this.EntradaLocalidad.ExtraDetailFields = null;
                        this.EntradaLocalidad.Filter = "nivel=2";
                        this.EntradaLocalidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaLocalidad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaLocalidad.FreeTextCode = "";
                        this.EntradaLocalidad.Location = new System.Drawing.Point(100, 204);
                        this.EntradaLocalidad.MaxLength = 200;
                        this.EntradaLocalidad.Name = "EntradaLocalidad";
                        this.EntradaLocalidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLocalidad.Required = true;
                        this.EntradaLocalidad.Size = new System.Drawing.Size(242, 24);
                        this.EntradaLocalidad.TabIndex = 9;
                        this.EntradaLocalidad.Table = "ciudades";
                        this.EntradaLocalidad.Text = "0";
                        this.EntradaLocalidad.TextDetail = "";
                        this.EntradaLocalidad.TipWhenBlank = "Sin especificar";
                        this.EntradaLocalidad.ToolTipText = "";
                        // 
                        // EntradaDomicilio
                        // 
                        this.EntradaDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDomicilio.AutoNav = true;
                        this.EntradaDomicilio.AutoTab = true;
                        this.EntradaDomicilio.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDomicilio.DecimalPlaces = -1;
                        this.EntradaDomicilio.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDomicilio.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDomicilio.Location = new System.Drawing.Point(100, 28);
                        this.EntradaDomicilio.MaxLenght = 32767;
                        this.EntradaDomicilio.MultiLine = false;
                        this.EntradaDomicilio.Name = "EntradaDomicilio";
                        this.EntradaDomicilio.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDomicilio.PasswordChar = '\0';
                        this.EntradaDomicilio.Prefijo = "";
                        this.EntradaDomicilio.SelectOnFocus = false;
                        this.EntradaDomicilio.Size = new System.Drawing.Size(242, 24);
                        this.EntradaDomicilio.Sufijo = "";
                        this.EntradaDomicilio.TabIndex = 1;
                        this.EntradaDomicilio.TipWhenBlank = "";
                        this.EntradaDomicilio.ToolTipText = "";
                        // 
                        // EntradaNumDoc
                        // 
                        this.EntradaNumDoc.AutoNav = true;
                        this.EntradaNumDoc.AutoTab = true;
                        this.EntradaNumDoc.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumDoc.DecimalPlaces = -1;
                        this.EntradaNumDoc.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumDoc.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumDoc.Location = new System.Drawing.Point(180, 116);
                        this.EntradaNumDoc.MaxLenght = 32767;
                        this.EntradaNumDoc.MultiLine = false;
                        this.EntradaNumDoc.Name = "EntradaNumDoc";
                        this.EntradaNumDoc.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumDoc.PasswordChar = '\0';
                        this.EntradaNumDoc.Prefijo = "";
                        this.EntradaNumDoc.SelectOnFocus = true;
                        this.EntradaNumDoc.Size = new System.Drawing.Size(160, 24);
                        this.EntradaNumDoc.Sufijo = "";
                        this.EntradaNumDoc.TabIndex = 7;
                        this.EntradaNumDoc.TipWhenBlank = "";
                        this.EntradaNumDoc.ToolTipText = "";
                        // 
                        // EntradaTipoDoc
                        // 
                        this.EntradaTipoDoc.AutoNav = true;
                        this.EntradaTipoDoc.AutoTab = true;
                        this.EntradaTipoDoc.CanCreate = false;
                        this.EntradaTipoDoc.DataTextField = "nombre";
                        this.EntradaTipoDoc.DataValueField = "id_tipo_doc";
                        this.EntradaTipoDoc.ExtraDetailFields = null;
                        this.EntradaTipoDoc.Filter = "";
                        this.EntradaTipoDoc.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipoDoc.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTipoDoc.FreeTextCode = "";
                        this.EntradaTipoDoc.Location = new System.Drawing.Point(180, 88);
                        this.EntradaTipoDoc.MaxLength = 200;
                        this.EntradaTipoDoc.Name = "EntradaTipoDoc";
                        this.EntradaTipoDoc.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipoDoc.Required = true;
                        this.EntradaTipoDoc.Size = new System.Drawing.Size(160, 24);
                        this.EntradaTipoDoc.TabIndex = 5;
                        this.EntradaTipoDoc.Table = "tipo_doc";
                        this.EntradaTipoDoc.Text = "0";
                        this.EntradaTipoDoc.TextDetail = "";
                        this.EntradaTipoDoc.TipWhenBlank = "";
                        this.EntradaTipoDoc.ToolTipText = "";
                        // 
                        // EntradaApellido
                        // 
                        this.EntradaApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaApellido.AutoNav = true;
                        this.EntradaApellido.AutoTab = true;
                        this.EntradaApellido.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaApellido.DecimalPlaces = -1;
                        this.EntradaApellido.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaApellido.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaApellido.Location = new System.Drawing.Point(80, 60);
                        this.EntradaApellido.MaxLenght = 32767;
                        this.EntradaApellido.MultiLine = false;
                        this.EntradaApellido.Name = "EntradaApellido";
                        this.EntradaApellido.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaApellido.PasswordChar = '\0';
                        this.EntradaApellido.Prefijo = "";
                        this.EntradaApellido.SelectOnFocus = true;
                        this.EntradaApellido.Size = new System.Drawing.Size(262, 24);
                        this.EntradaApellido.Sufijo = "";
                        this.EntradaApellido.TabIndex = 3;
                        this.EntradaApellido.TipWhenBlank = "";
                        this.EntradaApellido.ToolTipText = "";
                        this.EntradaApellido.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNombre.Location = new System.Drawing.Point(80, 32);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.SelectOnFocus = true;
                        this.EntradaNombre.Size = new System.Drawing.Size(262, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
                        this.EntradaNombre.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // EntradaCuit
                        // 
                        this.EntradaCuit.AutoNav = true;
                        this.EntradaCuit.AutoTab = true;
                        this.EntradaCuit.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCuit.DecimalPlaces = -1;
                        this.EntradaCuit.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCuit.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCuit.Location = new System.Drawing.Point(108, 60);
                        this.EntradaCuit.MaxLenght = 32767;
                        this.EntradaCuit.MultiLine = false;
                        this.EntradaCuit.Name = "EntradaCuit";
                        this.EntradaCuit.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCuit.PasswordChar = '\0';
                        this.EntradaCuit.Prefijo = "";
                        this.EntradaCuit.SelectOnFocus = true;
                        this.EntradaCuit.Size = new System.Drawing.Size(142, 24);
                        this.EntradaCuit.Sufijo = "";
                        this.EntradaCuit.TabIndex = 3;
                        this.EntradaCuit.TipWhenBlank = "";
                        this.EntradaCuit.ToolTipText = "";
                        this.EntradaCuit.Leave += new System.EventHandler(this.EntradaCuit_Leave);
                        // 
                        // EntradaRazonSocial
                        // 
                        this.EntradaRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaRazonSocial.AutoNav = true;
                        this.EntradaRazonSocial.AutoTab = true;
                        this.EntradaRazonSocial.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaRazonSocial.DecimalPlaces = -1;
                        this.EntradaRazonSocial.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaRazonSocial.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaRazonSocial.Location = new System.Drawing.Point(108, 32);
                        this.EntradaRazonSocial.MaxLenght = 32767;
                        this.EntradaRazonSocial.MultiLine = false;
                        this.EntradaRazonSocial.Name = "EntradaRazonSocial";
                        this.EntradaRazonSocial.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRazonSocial.PasswordChar = '\0';
                        this.EntradaRazonSocial.Prefijo = "";
                        this.EntradaRazonSocial.SelectOnFocus = true;
                        this.EntradaRazonSocial.Size = new System.Drawing.Size(170, 24);
                        this.EntradaRazonSocial.Sufijo = "";
                        this.EntradaRazonSocial.TabIndex = 1;
                        this.EntradaRazonSocial.TipWhenBlank = "";
                        this.EntradaRazonSocial.ToolTipText = "";
                        this.EntradaRazonSocial.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // Label10
                        // 
                        this.Label10.Location = new System.Drawing.Point(8, 84);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(92, 24);
                        this.Label10.TabIndex = 4;
                        this.Label10.Text = "Teléfonos";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label9
                        // 
                        this.Label9.Location = new System.Drawing.Point(8, 204);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(92, 24);
                        this.Label9.TabIndex = 8;
                        this.Label9.Text = "Localidad";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label8
                        // 
                        this.Label8.Location = new System.Drawing.Point(8, 28);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(92, 24);
                        this.Label8.TabIndex = 0;
                        this.Label8.Text = "Domicilio";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(8, 116);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(172, 24);
                        this.Label6.TabIndex = 6;
                        this.Label6.Text = "Número de Documento";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(8, 88);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(172, 24);
                        this.Label5.TabIndex = 4;
                        this.Label5.Text = "Tipo de Documento";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(8, 60);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(76, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Apellido";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(8, 32);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(76, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Nombre";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(8, 60);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(100, 24);
                        this.Label7.TabIndex = 2;
                        this.Label7.Text = "CUIT";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(8, 32);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(100, 24);
                        this.Label3.TabIndex = 0;
                        this.Label3.Text = "Razón social";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(8, 176);
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
                        this.Frame1.Controls.Add(this.EntradaNombre);
                        this.Frame1.Controls.Add(this.EntradaApellido);
                        this.Frame1.Controls.Add(this.Label1);
                        this.Frame1.Controls.Add(this.Label5);
                        this.Frame1.Controls.Add(this.Label6);
                        this.Frame1.Controls.Add(this.EntradaNumDoc);
                        this.Frame1.Controls.Add(this.EntradaTipoDoc);
                        this.Frame1.Controls.Add(this.Label2);
                        this.Frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame1.Location = new System.Drawing.Point(3, 3);
                        this.Frame1.Name = "Frame1";
                        this.Frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame1.Size = new System.Drawing.Size(346, 145);
                        this.Frame1.TabIndex = 0;
                        this.Frame1.Text = "Personas Físicas";
                        this.Frame1.ToolTipText = "";
                        // 
                        // Frame2
                        // 
                        this.Frame2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Frame2.Controls.Add(this.Label3);
                        this.Frame2.Controls.Add(this.EntradaRazonSocial);
                        this.Frame2.Controls.Add(this.Label15);
                        this.Frame2.Controls.Add(this.EntradaCuit);
                        this.Frame2.Controls.Add(this.Label7);
                        this.Frame2.Controls.Add(this.Label12);
                        this.Frame2.Controls.Add(this.EntradaSituacion);
                        this.Frame2.Controls.Add(this.EntradaTipoFac);
                        this.Frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame2.Location = new System.Drawing.Point(355, 3);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.Size = new System.Drawing.Size(282, 145);
                        this.Frame2.TabIndex = 1;
                        this.Frame2.Text = "Personas Jurídicas";
                        this.Frame2.ToolTipText = "";
                        // 
                        // Label15
                        // 
                        this.Label15.Location = new System.Drawing.Point(8, 116);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(116, 24);
                        this.Label15.TabIndex = 6;
                        this.Label15.Text = "Facturación";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label12
                        // 
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
                        this.EntradaSituacion.CanCreate = false;
                        this.EntradaSituacion.DataTextField = "nombre";
                        this.EntradaSituacion.DataValueField = "id_situacion";
                        this.EntradaSituacion.ExtraDetailFields = null;
                        this.EntradaSituacion.Filter = "";
                        this.EntradaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSituacion.FreeTextCode = "";
                        this.EntradaSituacion.Location = new System.Drawing.Point(124, 88);
                        this.EntradaSituacion.MaxLength = 200;
                        this.EntradaSituacion.Name = "EntradaSituacion";
                        this.EntradaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSituacion.Required = true;
                        this.EntradaSituacion.Size = new System.Drawing.Size(154, 24);
                        this.EntradaSituacion.TabIndex = 5;
                        this.EntradaSituacion.Table = "situaciones";
                        this.EntradaSituacion.Text = "0";
                        this.EntradaSituacion.TextDetail = "";
                        this.EntradaSituacion.TipWhenBlank = "";
                        this.EntradaSituacion.ToolTipText = "";
                        this.EntradaSituacion.Leave += new System.EventHandler(this.EntradaSituacion_Leave);
                        // 
                        // EntradaTipoFac
                        // 
                        this.EntradaTipoFac.AlwaysExpanded = false;
                        this.EntradaTipoFac.AutoNav = true;
                        this.EntradaTipoFac.AutoTab = true;
                        this.EntradaTipoFac.DetailField = null;
                        this.EntradaTipoFac.Filter = null;
                        this.EntradaTipoFac.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipoFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTipoFac.KeyField = null;
                        this.EntradaTipoFac.Location = new System.Drawing.Point(124, 116);
                        this.EntradaTipoFac.MaxLenght = 32767;
                        this.EntradaTipoFac.Name = "EntradaTipoFac";
                        this.EntradaTipoFac.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipoFac.SetData = new string[] {
        "Predeterminada|*",
        "Factura A|A",
        "Factura B|B",
        "Factura C|C",
        "Factura E|E",
        "Ticket|T"};
                        this.EntradaTipoFac.Size = new System.Drawing.Size(188, 24);
                        this.EntradaTipoFac.TabIndex = 7;
                        this.EntradaTipoFac.Table = null;
                        this.EntradaTipoFac.TextKey = "*";
                        this.EntradaTipoFac.TipWhenBlank = "";
                        this.EntradaTipoFac.ToolTipText = "";
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
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTipo.FreeTextCode = "";
                        this.EntradaTipo.Location = new System.Drawing.Point(84, 84);
                        this.EntradaTipo.MaxLength = 200;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.Required = true;
                        this.EntradaTipo.Size = new System.Drawing.Size(194, 24);
                        this.EntradaTipo.TabIndex = 5;
                        this.EntradaTipo.Table = "personas_tipos";
                        this.EntradaTipo.Text = "0";
                        this.EntradaTipo.TextDetail = "";
                        this.EntradaTipo.TipWhenBlank = "Sin especificar";
                        this.EntradaTipo.ToolTipText = "";
                        // 
                        // Label14
                        // 
                        this.Label14.Location = new System.Drawing.Point(8, 84);
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
                        this.EntradaGrupo.CanCreate = true;
                        this.EntradaGrupo.DataTextField = "nombre";
                        this.EntradaGrupo.DataValueField = "id_grupo";
                        this.EntradaGrupo.ExtraDetailFields = null;
                        this.EntradaGrupo.Filter = "parent IS NULL";
                        this.EntradaGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaGrupo.FreeTextCode = "";
                        this.EntradaGrupo.Location = new System.Drawing.Point(84, 28);
                        this.EntradaGrupo.MaxLength = 200;
                        this.EntradaGrupo.Name = "EntradaGrupo";
                        this.EntradaGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGrupo.Required = false;
                        this.EntradaGrupo.Size = new System.Drawing.Size(194, 24);
                        this.EntradaGrupo.TabIndex = 1;
                        this.EntradaGrupo.Table = "personas_grupos";
                        this.EntradaGrupo.Text = "0";
                        this.EntradaGrupo.TextDetail = "";
                        this.EntradaGrupo.TipWhenBlank = "Ninguno";
                        this.EntradaGrupo.ToolTipText = "";
                        this.EntradaGrupo.TextChanged += new System.EventHandler(this.EntradaGrupo_TextChanged);
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(8, 28);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(80, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Grupo";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // BotonAcceso
                        // 
                        this.BotonAcceso.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAcceso.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonAcceso.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAcceso.Image = null;
                        this.BotonAcceso.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAcceso.Location = new System.Drawing.Point(284, 28);
                        this.BotonAcceso.Name = "BotonAcceso";
                        this.BotonAcceso.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAcceso.Size = new System.Drawing.Size(88, 44);
                        this.BotonAcceso.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonAcceso.Subtext = "F2";
                        this.BotonAcceso.TabIndex = 6;
                        this.BotonAcceso.Text = "Accesos";
                        this.BotonAcceso.ToolTipText = "";
                        this.BotonAcceso.Visible = false;
                        this.BotonAcceso.Click += new System.EventHandler(this.BotonAcceso_Click);
                        // 
                        // EntradaLimiteCredito
                        // 
                        this.EntradaLimiteCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaLimiteCredito.AutoNav = true;
                        this.EntradaLimiteCredito.AutoTab = true;
                        this.EntradaLimiteCredito.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaLimiteCredito.DecimalPlaces = -1;
                        this.EntradaLimiteCredito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaLimiteCredito.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaLimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaLimiteCredito.Location = new System.Drawing.Point(144, 112);
                        this.EntradaLimiteCredito.MaxLenght = 32767;
                        this.EntradaLimiteCredito.MultiLine = false;
                        this.EntradaLimiteCredito.Name = "EntradaLimiteCredito";
                        this.EntradaLimiteCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLimiteCredito.PasswordChar = '\0';
                        this.EntradaLimiteCredito.Prefijo = "$";
                        this.EntradaLimiteCredito.SelectOnFocus = true;
                        this.EntradaLimiteCredito.Size = new System.Drawing.Size(134, 24);
                        this.EntradaLimiteCredito.Sufijo = "";
                        this.EntradaLimiteCredito.TabIndex = 7;
                        this.EntradaLimiteCredito.Text = "0.00";
                        this.EntradaLimiteCredito.TipWhenBlank = "";
                        this.EntradaLimiteCredito.ToolTipText = "";
                        // 
                        // label17
                        // 
                        this.label17.Location = new System.Drawing.Point(8, 112);
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
                        this.EntradaFechaNac.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaNac.DecimalPlaces = -1;
                        this.EntradaFechaNac.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaNac.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaNac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaNac.Location = new System.Drawing.Point(160, 260);
                        this.EntradaFechaNac.MaxLenght = 32767;
                        this.EntradaFechaNac.MultiLine = false;
                        this.EntradaFechaNac.Name = "EntradaFechaNac";
                        this.EntradaFechaNac.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaNac.PasswordChar = '\0';
                        this.EntradaFechaNac.Prefijo = "";
                        this.EntradaFechaNac.SelectOnFocus = true;
                        this.EntradaFechaNac.Size = new System.Drawing.Size(152, 24);
                        this.EntradaFechaNac.Sufijo = "";
                        this.EntradaFechaNac.TabIndex = 13;
                        this.EntradaFechaNac.TipWhenBlank = "";
                        this.EntradaFechaNac.ToolTipText = "";
                        // 
                        // label18
                        // 
                        this.label18.Location = new System.Drawing.Point(8, 260);
                        this.label18.Name = "label18";
                        this.label18.Size = new System.Drawing.Size(152, 24);
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
                        this.EntradaDomicilioTrabajo.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDomicilioTrabajo.DecimalPlaces = -1;
                        this.EntradaDomicilioTrabajo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDomicilioTrabajo.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaDomicilioTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDomicilioTrabajo.Location = new System.Drawing.Point(100, 56);
                        this.EntradaDomicilioTrabajo.MaxLenght = 32767;
                        this.EntradaDomicilioTrabajo.MultiLine = false;
                        this.EntradaDomicilioTrabajo.Name = "EntradaDomicilioTrabajo";
                        this.EntradaDomicilioTrabajo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDomicilioTrabajo.PasswordChar = '\0';
                        this.EntradaDomicilioTrabajo.Prefijo = "";
                        this.EntradaDomicilioTrabajo.SelectOnFocus = false;
                        this.EntradaDomicilioTrabajo.Size = new System.Drawing.Size(242, 24);
                        this.EntradaDomicilioTrabajo.Sufijo = "";
                        this.EntradaDomicilioTrabajo.TabIndex = 3;
                        this.EntradaDomicilioTrabajo.TipWhenBlank = "";
                        this.EntradaDomicilioTrabajo.ToolTipText = "";
                        // 
                        // label19
                        // 
                        this.label19.Location = new System.Drawing.Point(8, 56);
                        this.label19.Name = "label19";
                        this.label19.Size = new System.Drawing.Size(92, 24);
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
                        this.EntradaEstadoCredito.DetailField = null;
                        this.EntradaEstadoCredito.Filter = null;
                        this.EntradaEstadoCredito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstadoCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEstadoCredito.KeyField = null;
                        this.EntradaEstadoCredito.Location = new System.Drawing.Point(144, 140);
                        this.EntradaEstadoCredito.MaxLenght = 32767;
                        this.EntradaEstadoCredito.Name = "EntradaEstadoCredito";
                        this.EntradaEstadoCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstadoCredito.SetData = new string[] {
        "Normal|0",
        "En Plan de Pagos|5",
        "Susp. con React. Automática|10",
        "Susp. con Reactivación Manual|100"};
                        this.EntradaEstadoCredito.Size = new System.Drawing.Size(134, 24);
                        this.EntradaEstadoCredito.TabIndex = 9;
                        this.EntradaEstadoCredito.Table = null;
                        this.EntradaEstadoCredito.TextKey = "100";
                        this.EntradaEstadoCredito.TipWhenBlank = "";
                        this.EntradaEstadoCredito.ToolTipText = "";
                        // 
                        // label21
                        // 
                        this.label21.Location = new System.Drawing.Point(8, 140);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(136, 24);
                        this.label21.TabIndex = 8;
                        this.label21.Text = "Estado de crédito";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCbu
                        // 
                        this.EntradaCbu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCbu.AutoNav = true;
                        this.EntradaCbu.AutoTab = true;
                        this.EntradaCbu.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCbu.DecimalPlaces = -1;
                        this.EntradaCbu.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCbu.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCbu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCbu.Location = new System.Drawing.Point(72, 196);
                        this.EntradaCbu.MaxLenght = 32767;
                        this.EntradaCbu.MultiLine = false;
                        this.EntradaCbu.Name = "EntradaCbu";
                        this.EntradaCbu.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCbu.PasswordChar = '\0';
                        this.EntradaCbu.Prefijo = "";
                        this.EntradaCbu.SelectOnFocus = true;
                        this.EntradaCbu.Size = new System.Drawing.Size(206, 24);
                        this.EntradaCbu.Sufijo = "";
                        this.EntradaCbu.TabIndex = 13;
                        this.EntradaCbu.TipWhenBlank = "";
                        this.EntradaCbu.ToolTipText = "";
                        // 
                        // label20
                        // 
                        this.label20.Location = new System.Drawing.Point(8, 196);
                        this.label20.Name = "label20";
                        this.label20.Size = new System.Drawing.Size(64, 24);
                        this.label20.TabIndex = 12;
                        this.label20.Text = "CBU";
                        this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNumeroCuenta
                        // 
                        this.EntradaNumeroCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNumeroCuenta.AutoNav = true;
                        this.EntradaNumeroCuenta.AutoTab = true;
                        this.EntradaNumeroCuenta.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumeroCuenta.DecimalPlaces = -1;
                        this.EntradaNumeroCuenta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumeroCuenta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumeroCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumeroCuenta.Location = new System.Drawing.Point(144, 168);
                        this.EntradaNumeroCuenta.MaxLenght = 32767;
                        this.EntradaNumeroCuenta.MultiLine = false;
                        this.EntradaNumeroCuenta.Name = "EntradaNumeroCuenta";
                        this.EntradaNumeroCuenta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumeroCuenta.PasswordChar = '\0';
                        this.EntradaNumeroCuenta.Prefijo = "";
                        this.EntradaNumeroCuenta.SelectOnFocus = true;
                        this.EntradaNumeroCuenta.Size = new System.Drawing.Size(134, 24);
                        this.EntradaNumeroCuenta.Sufijo = "";
                        this.EntradaNumeroCuenta.TabIndex = 11;
                        this.EntradaNumeroCuenta.TipWhenBlank = "";
                        this.EntradaNumeroCuenta.ToolTipText = "";
                        // 
                        // label22
                        // 
                        this.label22.Location = new System.Drawing.Point(8, 168);
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
                        this.frame3.Controls.Add(this.Label8);
                        this.frame3.Controls.Add(this.EntradaDomicilio);
                        this.frame3.Controls.Add(this.EntradaVendedor);
                        this.frame3.Controls.Add(this.label23);
                        this.frame3.Controls.Add(this.EntradaTelefono);
                        this.frame3.Controls.Add(this.label19);
                        this.frame3.Controls.Add(this.EntradaDomicilioTrabajo);
                        this.frame3.Controls.Add(this.label18);
                        this.frame3.Controls.Add(this.Label11);
                        this.frame3.Controls.Add(this.Label10);
                        this.frame3.Controls.Add(this.Label9);
                        this.frame3.Controls.Add(this.EntradaFechaNac);
                        this.frame3.Controls.Add(this.EntradaEmail);
                        this.frame3.Controls.Add(this.EntradaLocalidad);
                        this.frame3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame3.Location = new System.Drawing.Point(3, 154);
                        this.frame3.Name = "frame3";
                        this.frame3.Padding = new System.Windows.Forms.Padding(2);
                        this.frame3.Size = new System.Drawing.Size(346, 290);
                        this.frame3.TabIndex = 2;
                        this.frame3.Text = "Datos de Contacto";
                        this.frame3.ToolTipText = "";
                        // 
                        // EntradaVendedor
                        // 
                        this.EntradaVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaVendedor.AutoNav = true;
                        this.EntradaVendedor.AutoTab = true;
                        this.EntradaVendedor.CanCreate = true;
                        this.EntradaVendedor.DataTextField = "nombre_visible";
                        this.EntradaVendedor.DataValueField = "id_persona";
                        this.EntradaVendedor.ExtraDetailFields = null;
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.Location = new System.Drawing.Point(100, 232);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaVendedor.Required = false;
                        this.EntradaVendedor.Size = new System.Drawing.Size(242, 24);
                        this.EntradaVendedor.TabIndex = 11;
                        this.EntradaVendedor.Table = "personas";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
                        this.EntradaVendedor.TipWhenBlank = "Ninguno";
                        this.EntradaVendedor.ToolTipText = "";
                        // 
                        // label23
                        // 
                        this.label23.Location = new System.Drawing.Point(8, 232);
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
                        this.EntradaTelefono.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTelefono.Location = new System.Drawing.Point(8, 84);
                        this.EntradaTelefono.Name = "EntradaTelefono";
                        this.EntradaTelefono.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTelefono.Size = new System.Drawing.Size(336, 88);
                        this.EntradaTelefono.TabIndex = 5;
                        this.EntradaTelefono.ToolTipText = "";
                        // 
                        // frame4
                        // 
                        this.frame4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame4.Controls.Add(this.EntradaSubGrupo);
                        this.frame4.Controls.Add(this.EntradaGrupo);
                        this.frame4.Controls.Add(this.EntradaCbu);
                        this.frame4.Controls.Add(this.label17);
                        this.frame4.Controls.Add(this.EntradaNumeroCuenta);
                        this.frame4.Controls.Add(this.label20);
                        this.frame4.Controls.Add(this.EntradaLimiteCredito);
                        this.frame4.Controls.Add(this.label22);
                        this.frame4.Controls.Add(this.EntradaEstadoCredito);
                        this.frame4.Controls.Add(this.label21);
                        this.frame4.Controls.Add(this.EntradaTipo);
                        this.frame4.Controls.Add(this.label13);
                        this.frame4.Controls.Add(this.Label16);
                        this.frame4.Controls.Add(this.Label14);
                        this.frame4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame4.Location = new System.Drawing.Point(355, 154);
                        this.frame4.Name = "frame4";
                        this.frame4.Padding = new System.Windows.Forms.Padding(2);
                        this.frame4.Size = new System.Drawing.Size(282, 226);
                        this.frame4.TabIndex = 3;
                        this.frame4.Text = "Otros datos";
                        this.frame4.ToolTipText = "";
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
                        this.EntradaSubGrupo.Filter = "parent IS NULL";
                        this.EntradaSubGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSubGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSubGrupo.FreeTextCode = "";
                        this.EntradaSubGrupo.Location = new System.Drawing.Point(84, 56);
                        this.EntradaSubGrupo.MaxLength = 200;
                        this.EntradaSubGrupo.Name = "EntradaSubGrupo";
                        this.EntradaSubGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubGrupo.Required = false;
                        this.EntradaSubGrupo.Size = new System.Drawing.Size(194, 24);
                        this.EntradaSubGrupo.TabIndex = 3;
                        this.EntradaSubGrupo.Table = "personas_grupos";
                        this.EntradaSubGrupo.Text = "0";
                        this.EntradaSubGrupo.TextDetail = "";
                        this.EntradaSubGrupo.TipWhenBlank = "Ninguno";
                        this.EntradaSubGrupo.ToolTipText = "";
                        // 
                        // label13
                        // 
                        this.label13.Location = new System.Drawing.Point(8, 56);
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
                        this.EntradaEstado.DetailField = null;
                        this.EntradaEstado.Filter = null;
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEstado.KeyField = null;
                        this.EntradaEstado.Location = new System.Drawing.Point(120, 28);
                        this.EntradaEstado.MaxLenght = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.SetData = new string[] {
        "Inactivo|0",
        "Activo|1"};
                        this.EntradaEstado.Size = new System.Drawing.Size(131, 24);
                        this.EntradaEstado.TabIndex = 1;
                        this.EntradaEstado.Table = null;
                        this.EntradaEstado.TextKey = "1";
                        this.EntradaEstado.TipWhenBlank = "";
                        this.EntradaEstado.ToolTipText = "";
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaObs.Location = new System.Drawing.Point(355, 450);
                        this.EntradaObs.MaxLenght = 32767;
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(282, 240);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 5;
                        this.EntradaObs.TipWhenBlank = "";
                        this.EntradaObs.ToolTipText = "";
                        // 
                        // EntradaNombreVisible
                        // 
                        this.EntradaNombreVisible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombreVisible.AutoNav = true;
                        this.EntradaNombreVisible.AutoTab = true;
                        this.EntradaNombreVisible.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombreVisible.DecimalPlaces = -1;
                        this.EntradaNombreVisible.Font = new System.Drawing.Font("Bitstream Vera Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombreVisible.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombreVisible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNombreVisible.Location = new System.Drawing.Point(123, 8);
                        this.EntradaNombreVisible.MaxLenght = 32767;
                        this.EntradaNombreVisible.MultiLine = false;
                        this.EntradaNombreVisible.Name = "EntradaNombreVisible";
                        this.EntradaNombreVisible.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombreVisible.PasswordChar = '\0';
                        this.EntradaNombreVisible.Prefijo = "";
                        this.EntradaNombreVisible.SelectOnFocus = true;
                        this.EntradaNombreVisible.Size = new System.Drawing.Size(508, 28);
                        this.EntradaNombreVisible.Sufijo = "";
                        this.EntradaNombreVisible.TabIndex = 1;
                        this.EntradaNombreVisible.TabStop = false;
                        this.EntradaNombreVisible.TipWhenBlank = "";
                        this.EntradaNombreVisible.ToolTipText = "";
                        // 
                        // Label4
                        // 
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
                        this.frame5.Controls.Add(this.label26);
                        this.frame5.Controls.Add(this.BotonAcceso);
                        this.frame5.Controls.Add(this.EntradaEstado);
                        this.frame5.Controls.Add(this.EntradaFechaBaja);
                        this.frame5.Controls.Add(this.label25);
                        this.frame5.Controls.Add(this.label24);
                        this.frame5.Controls.Add(this.EntradaFechaAlta);
                        this.frame5.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame5.Location = new System.Drawing.Point(3, 450);
                        this.frame5.Name = "frame5";
                        this.frame5.Padding = new System.Windows.Forms.Padding(2);
                        this.frame5.Size = new System.Drawing.Size(346, 118);
                        this.frame5.TabIndex = 4;
                        this.frame5.Text = "Estado";
                        this.frame5.ToolTipText = "";
                        // 
                        // label26
                        // 
                        this.label26.Location = new System.Drawing.Point(4, 84);
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
                        this.EntradaFechaBaja.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaBaja.DecimalPlaces = -1;
                        this.EntradaFechaBaja.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaBaja.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaBaja.Location = new System.Drawing.Point(120, 84);
                        this.EntradaFechaBaja.MaxLenght = 32767;
                        this.EntradaFechaBaja.MultiLine = false;
                        this.EntradaFechaBaja.Name = "EntradaFechaBaja";
                        this.EntradaFechaBaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaBaja.PasswordChar = '\0';
                        this.EntradaFechaBaja.Prefijo = "";
                        this.EntradaFechaBaja.SelectOnFocus = true;
                        this.EntradaFechaBaja.Size = new System.Drawing.Size(152, 24);
                        this.EntradaFechaBaja.Sufijo = "";
                        this.EntradaFechaBaja.TabIndex = 5;
                        this.EntradaFechaBaja.TabStop = false;
                        this.EntradaFechaBaja.TipWhenBlank = "";
                        this.EntradaFechaBaja.ToolTipText = "";
                        // 
                        // label25
                        // 
                        this.label25.Location = new System.Drawing.Point(4, 56);
                        this.label25.Name = "label25";
                        this.label25.Size = new System.Drawing.Size(116, 24);
                        this.label25.TabIndex = 2;
                        this.label25.Text = "Fecha de Alta";
                        this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label24
                        // 
                        this.label24.Location = new System.Drawing.Point(4, 28);
                        this.label24.Name = "label24";
                        this.label24.Size = new System.Drawing.Size(116, 24);
                        this.label24.TabIndex = 0;
                        this.label24.Text = "Estado";
                        this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaAlta
                        // 
                        this.EntradaFechaAlta.AutoNav = true;
                        this.EntradaFechaAlta.AutoTab = true;
                        this.EntradaFechaAlta.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaAlta.DecimalPlaces = -1;
                        this.EntradaFechaAlta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaAlta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaAlta.Location = new System.Drawing.Point(120, 56);
                        this.EntradaFechaAlta.MaxLenght = 32767;
                        this.EntradaFechaAlta.MultiLine = false;
                        this.EntradaFechaAlta.Name = "EntradaFechaAlta";
                        this.EntradaFechaAlta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaAlta.PasswordChar = '\0';
                        this.EntradaFechaAlta.Prefijo = "";
                        this.EntradaFechaAlta.SelectOnFocus = true;
                        this.EntradaFechaAlta.Size = new System.Drawing.Size(152, 24);
                        this.EntradaFechaAlta.Sufijo = "";
                        this.EntradaFechaAlta.TabIndex = 3;
                        this.EntradaFechaAlta.TabStop = false;
                        this.EntradaFechaAlta.TipWhenBlank = "";
                        this.EntradaFechaAlta.ToolTipText = "";
                        // 
                        // EntradaTags
                        // 
                        this.EntradaTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTags.AutoNav = true;
                        this.EntradaTags.AutoSize = true;
                        this.EntradaTags.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaTags.Location = new System.Drawing.Point(4, 386);
                        this.EntradaTags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaTags.Name = "EntradaTags";
                        this.EntradaTags.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTags.Size = new System.Drawing.Size(418, 166);
                        this.EntradaTags.TabIndex = 4;
                        this.EntradaTags.Text = "Atributos especiales";
                        this.EntradaTags.ToolTipText = "";
                        // 
                        // EntradaImagen
                        // 
                        this.EntradaImagen.AutoNav = true;
                        this.EntradaImagen.AutoSize = true;
                        this.EntradaImagen.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.EntradaImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaImagen.Location = new System.Drawing.Point(429, 386);
                        this.EntradaImagen.Name = "EntradaImagen";
                        this.EntradaImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImagen.Size = new System.Drawing.Size(343, 166);
                        this.EntradaImagen.TabIndex = 6;
                        this.EntradaImagen.ToolTipText = "";
                        // 
                        // matrizTelefonos1
                        // 
                        this.matrizTelefonos1.AutoNav = true;
                        this.matrizTelefonos1.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.matrizTelefonos1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.matrizTelefonos1.Location = new System.Drawing.Point(0, 0);
                        this.matrizTelefonos1.Name = "matrizTelefonos1";
                        this.matrizTelefonos1.Padding = new System.Windows.Forms.Padding(2);
                        this.matrizTelefonos1.Size = new System.Drawing.Size(536, 180);
                        this.matrizTelefonos1.TabIndex = 0;
                        this.matrizTelefonos1.ToolTipText = "";
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.TableLayoutPanel);
                        this.Controls.Add(this.EntradaNombreVisible);
                        this.Controls.Add(this.Label4);
                        this.MinimumSize = new System.Drawing.Size(640, 615);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 615);
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
                internal Lui.Forms.TextBox EntradaCuit;
                internal Lui.Forms.TextBox EntradaRazonSocial;
                internal System.Windows.Forms.Label Label10;
                internal System.Windows.Forms.Label Label9;
                internal System.Windows.Forms.Label Label8;
                internal System.Windows.Forms.Label Label6;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label7;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label11;
                internal Lui.Forms.Frame Frame1;
                internal Lui.Forms.Frame Frame2;
                internal Lcc.Entrada.CodigoDetalle EntradaSituacion;
                internal System.Windows.Forms.Label Label12;
                internal System.Windows.Forms.Label Label14;
                public Lcc.Entrada.CodigoDetalle EntradaTipo;
                internal System.Windows.Forms.Label Label15;
                internal Lui.Forms.ComboBox EntradaTipoFac;
                internal System.Windows.Forms.Label Label16;
                internal Lui.Forms.Button BotonAcceso;
                internal Lui.Forms.TextBox EntradaLimiteCredito;
                internal System.Windows.Forms.Label label17;
                internal System.Windows.Forms.Label label18;
                internal Lui.Forms.TextBox EntradaFechaNac;
                internal Lui.Forms.TextBox EntradaDomicilioTrabajo;
                internal System.Windows.Forms.Label label19;
                internal Lui.Forms.ComboBox EntradaEstadoCredito;
                internal System.Windows.Forms.Label label21;
                internal Lui.Forms.TextBox EntradaNumeroCuenta;
                internal System.Windows.Forms.Label label22;
                internal Lui.Forms.TextBox EntradaCbu;
                internal Label label20;
                internal Lcc.Entrada.CodigoDetalle EntradaGrupo;
                private Lui.Forms.Frame frame3;
                private Lui.Forms.Frame frame4;
                private Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.TextBox EntradaNombreVisible;
                internal Label Label4;
                private TableLayoutPanel TableLayoutPanel;
                private Lcc.Edicion.MatrizTags EntradaTags;
                internal Lcc.Entrada.CodigoDetalle EntradaSubGrupo;
                internal Label label13;
                private Lcc.Entrada.Imagen EntradaImagen;
                internal Lcc.Entrada.CodigoDetalle EntradaVendedor;
                internal Label label23;
                private Lui.Forms.Frame frame5;
                internal Label label26;
                internal Lui.Forms.TextBox EntradaFechaBaja;
                internal Label label25;
                internal Lui.Forms.TextBox EntradaFechaAlta;
                internal Label label24;
                internal Lui.Forms.ComboBox EntradaEstado;
                private Lcc.Entrada.MatrizTelefonos matrizTelefonos1;
                private Lcc.Entrada.MatrizTelefonos EntradaTelefono;

        }
}
