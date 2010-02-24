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

using System;
using System.Collections;
using System.Windows.Forms;

namespace Lfc.Personas
{
        public partial class Editar : Lui.Forms.EditForm
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
                private System.ComponentModel.Container components = null;

                private void InitializeComponent()
                {
                        this.EntradaEmail = new Lui.Forms.TextBox();
                        this.EntradaTelefono = new Lui.Forms.TextBox();
                        this.EntradaCiudad = new Lui.Forms.DetailBox();
                        this.EntradaDomicilio = new Lui.Forms.TextBox();
                        this.EntradaNumDoc = new Lui.Forms.TextBox();
                        this.EntradaTipoDoc = new Lui.Forms.DetailBox();
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
                        this.EntradaSituacion = new Lui.Forms.DetailBox();
                        this.EntradaTipoFac = new Lui.Forms.ComboBox();
                        this.EntradaTipo = new Lui.Forms.DetailBox();
                        this.Label14 = new System.Windows.Forms.Label();
                        this.EntradaGrupo = new Lui.Forms.DetailBox();
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
                        this.frame4 = new Lui.Forms.Frame();
                        this.EntradaSubGrupo = new Lui.Forms.DetailBox();
                        this.label13 = new System.Windows.Forms.Label();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.EntradaNombreVisible = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaTags = new Lui.Forms.FieldTags();
                        this.EntradaImagen = new Lcc.Edicion.Imagen();
                        this.ContenedorScroll = new System.Windows.Forms.Panel();
                        this.Frame1.SuspendLayout();
                        this.Frame2.SuspendLayout();
                        this.frame3.SuspendLayout();
                        this.frame4.SuspendLayout();
                        this.tableLayoutPanel1.SuspendLayout();
                        this.ContenedorScroll.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(576, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(684, 8);
                        // 
                        // EntradaEmail
                        // 
                        this.EntradaEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEmail.AutoHeight = false;
                        this.EntradaEmail.AutoNav = true;
                        this.EntradaEmail.AutoTab = true;
                        this.EntradaEmail.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmail.DecimalPlaces = -1;
                        this.EntradaEmail.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmail.ForceCase = Lui.Forms.TextCasing.LowerCase;
                        this.EntradaEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmail.Location = new System.Drawing.Point(100, 112);
                        this.EntradaEmail.MaxLenght = 32767;
                        this.EntradaEmail.MultiLine = false;
                        this.EntradaEmail.Name = "EntradaEmail";
                        this.EntradaEmail.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmail.PasswordChar = '\0';
                        this.EntradaEmail.Prefijo = "";
                        this.EntradaEmail.ReadOnly = false;
                        this.EntradaEmail.SelectOnFocus = true;
                        this.EntradaEmail.Size = new System.Drawing.Size(316, 24);
                        this.EntradaEmail.Sufijo = "";
                        this.EntradaEmail.TabIndex = 7;
                        this.EntradaEmail.TextRaw = "";
                        this.EntradaEmail.TipWhenBlank = "";
                        this.EntradaEmail.ToolTipText = "";
                        this.EntradaEmail.Leave += new System.EventHandler(this.EntradaEmail_Leave);
                        // 
                        // EntradaTelefono
                        // 
                        this.EntradaTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTelefono.AutoHeight = false;
                        this.EntradaTelefono.AutoNav = true;
                        this.EntradaTelefono.AutoTab = true;
                        this.EntradaTelefono.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaTelefono.DecimalPlaces = -1;
                        this.EntradaTelefono.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTelefono.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTelefono.Location = new System.Drawing.Point(100, 84);
                        this.EntradaTelefono.MaxLenght = 32767;
                        this.EntradaTelefono.MultiLine = false;
                        this.EntradaTelefono.Name = "EntradaTelefono";
                        this.EntradaTelefono.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTelefono.PasswordChar = '\0';
                        this.EntradaTelefono.Prefijo = "";
                        this.EntradaTelefono.ReadOnly = false;
                        this.EntradaTelefono.SelectOnFocus = true;
                        this.EntradaTelefono.Size = new System.Drawing.Size(316, 24);
                        this.EntradaTelefono.Sufijo = "";
                        this.EntradaTelefono.TabIndex = 5;
                        this.EntradaTelefono.TextRaw = "";
                        this.EntradaTelefono.TipWhenBlank = "";
                        this.EntradaTelefono.ToolTipText = "";
                        // 
                        // EntradaCiudad
                        // 
                        this.EntradaCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCiudad.AutoHeight = false;
                        this.EntradaCiudad.AutoTab = true;
                        this.EntradaCiudad.CanCreate = true;
                        this.EntradaCiudad.DetailField = "nombre";
                        this.EntradaCiudad.ExtraDetailFields = null;
                        this.EntradaCiudad.Filter = "";
                        this.EntradaCiudad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCiudad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCiudad.FreeTextCode = "";
                        this.EntradaCiudad.KeyField = "id_ciudad";
                        this.EntradaCiudad.Location = new System.Drawing.Point(100, 140);
                        this.EntradaCiudad.MaxLength = 200;
                        this.EntradaCiudad.Name = "EntradaCiudad";
                        this.EntradaCiudad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCiudad.ReadOnly = false;
                        this.EntradaCiudad.Required = true;
                        this.EntradaCiudad.SelectOnFocus = false;
                        this.EntradaCiudad.Size = new System.Drawing.Size(316, 24);
                        this.EntradaCiudad.TabIndex = 9;
                        this.EntradaCiudad.Table = "ciudades";
                        this.EntradaCiudad.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCiudad.Text = "0";
                        this.EntradaCiudad.TextDetail = "";
                        this.EntradaCiudad.TextInt = 0;
                        this.EntradaCiudad.TipWhenBlank = "Sin especificar";
                        this.EntradaCiudad.ToolTipText = "";
                        // 
                        // EntradaDomicilio
                        // 
                        this.EntradaDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDomicilio.AutoHeight = false;
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
                        this.EntradaDomicilio.ReadOnly = false;
                        this.EntradaDomicilio.SelectOnFocus = false;
                        this.EntradaDomicilio.Size = new System.Drawing.Size(316, 24);
                        this.EntradaDomicilio.Sufijo = "";
                        this.EntradaDomicilio.TabIndex = 1;
                        this.EntradaDomicilio.TextRaw = "";
                        this.EntradaDomicilio.TipWhenBlank = "";
                        this.EntradaDomicilio.ToolTipText = "";
                        // 
                        // EntradaNumDoc
                        // 
                        this.EntradaNumDoc.AutoHeight = false;
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
                        this.EntradaNumDoc.ReadOnly = false;
                        this.EntradaNumDoc.SelectOnFocus = true;
                        this.EntradaNumDoc.Size = new System.Drawing.Size(160, 24);
                        this.EntradaNumDoc.Sufijo = "";
                        this.EntradaNumDoc.TabIndex = 7;
                        this.EntradaNumDoc.TextRaw = "";
                        this.EntradaNumDoc.TipWhenBlank = "";
                        this.EntradaNumDoc.ToolTipText = "";
                        // 
                        // EntradaTipoDoc
                        // 
                        this.EntradaTipoDoc.AutoHeight = false;
                        this.EntradaTipoDoc.AutoTab = true;
                        this.EntradaTipoDoc.CanCreate = false;
                        this.EntradaTipoDoc.DetailField = "nombre";
                        this.EntradaTipoDoc.ExtraDetailFields = null;
                        this.EntradaTipoDoc.Filter = "";
                        this.EntradaTipoDoc.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipoDoc.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTipoDoc.FreeTextCode = "";
                        this.EntradaTipoDoc.KeyField = "id_tipo_doc";
                        this.EntradaTipoDoc.Location = new System.Drawing.Point(180, 88);
                        this.EntradaTipoDoc.MaxLength = 200;
                        this.EntradaTipoDoc.Name = "EntradaTipoDoc";
                        this.EntradaTipoDoc.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipoDoc.ReadOnly = false;
                        this.EntradaTipoDoc.Required = true;
                        this.EntradaTipoDoc.SelectOnFocus = false;
                        this.EntradaTipoDoc.Size = new System.Drawing.Size(160, 24);
                        this.EntradaTipoDoc.TabIndex = 5;
                        this.EntradaTipoDoc.Table = "tipo_doc";
                        this.EntradaTipoDoc.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaTipoDoc.Text = "0";
                        this.EntradaTipoDoc.TextDetail = "";
                        this.EntradaTipoDoc.TextInt = 0;
                        this.EntradaTipoDoc.TipWhenBlank = "";
                        this.EntradaTipoDoc.ToolTipText = "";
                        // 
                        // EntradaApellido
                        // 
                        this.EntradaApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaApellido.AutoHeight = false;
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
                        this.EntradaApellido.ReadOnly = false;
                        this.EntradaApellido.SelectOnFocus = true;
                        this.EntradaApellido.Size = new System.Drawing.Size(336, 24);
                        this.EntradaApellido.Sufijo = "";
                        this.EntradaApellido.TabIndex = 3;
                        this.EntradaApellido.TextRaw = "";
                        this.EntradaApellido.TipWhenBlank = "";
                        this.EntradaApellido.ToolTipText = "";
                        this.EntradaApellido.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoHeight = false;
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
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = true;
                        this.EntradaNombre.Size = new System.Drawing.Size(336, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TextRaw = "";
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
                        this.EntradaNombre.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // EntradaCuit
                        // 
                        this.EntradaCuit.AutoHeight = false;
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
                        this.EntradaCuit.ReadOnly = false;
                        this.EntradaCuit.SelectOnFocus = true;
                        this.EntradaCuit.Size = new System.Drawing.Size(142, 24);
                        this.EntradaCuit.Sufijo = "";
                        this.EntradaCuit.TabIndex = 3;
                        this.EntradaCuit.TextRaw = "";
                        this.EntradaCuit.TipWhenBlank = "";
                        this.EntradaCuit.ToolTipText = "";
                        this.EntradaCuit.Leave += new System.EventHandler(this.txtCUIT_Leave);
                        // 
                        // EntradaRazonSocial
                        // 
                        this.EntradaRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaRazonSocial.AutoHeight = false;
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
                        this.EntradaRazonSocial.ReadOnly = false;
                        this.EntradaRazonSocial.SelectOnFocus = true;
                        this.EntradaRazonSocial.Size = new System.Drawing.Size(231, 24);
                        this.EntradaRazonSocial.Sufijo = "";
                        this.EntradaRazonSocial.TabIndex = 1;
                        this.EntradaRazonSocial.TextRaw = "";
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
                        this.Label9.Location = new System.Drawing.Point(8, 140);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(92, 24);
                        this.Label9.TabIndex = 8;
                        this.Label9.Text = "Ciudad";
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
                        this.Label11.Location = new System.Drawing.Point(8, 112);
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
                        this.Frame1.AutoHeight = false;
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
                        this.Frame1.ReadOnly = false;
                        this.Frame1.Size = new System.Drawing.Size(420, 145);
                        this.Frame1.TabIndex = 0;
                        this.Frame1.Text = "Personas Físicas";
                        this.Frame1.ToolTipText = "";
                        // 
                        // Frame2
                        // 
                        this.Frame2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Frame2.AutoHeight = false;
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
                        this.Frame2.Location = new System.Drawing.Point(429, 3);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.ReadOnly = false;
                        this.Frame2.Size = new System.Drawing.Size(343, 145);
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
                        this.EntradaSituacion.Location = new System.Drawing.Point(124, 88);
                        this.EntradaSituacion.MaxLength = 200;
                        this.EntradaSituacion.Name = "EntradaSituacion";
                        this.EntradaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSituacion.ReadOnly = false;
                        this.EntradaSituacion.Required = true;
                        this.EntradaSituacion.SelectOnFocus = false;
                        this.EntradaSituacion.Size = new System.Drawing.Size(215, 24);
                        this.EntradaSituacion.TabIndex = 5;
                        this.EntradaSituacion.Table = "situaciones";
                        this.EntradaSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaSituacion.Text = "0";
                        this.EntradaSituacion.TextDetail = "";
                        this.EntradaSituacion.TextInt = 0;
                        this.EntradaSituacion.TipWhenBlank = "";
                        this.EntradaSituacion.ToolTipText = "";
                        this.EntradaSituacion.Leave += new System.EventHandler(this.txtSituacion_Leave);
                        // 
                        // EntradaTipoFac
                        // 
                        this.EntradaTipoFac.AutoHeight = false;
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
                        this.EntradaTipoFac.Table = null;
                        this.EntradaTipoFac.Text = "Predeterminada";
                        this.EntradaTipoFac.TextKey = "*";
                        this.EntradaTipoFac.TextRaw = "Predeterminada";
                        this.EntradaTipoFac.TipWhenBlank = "";
                        this.EntradaTipoFac.ToolTipText = "";
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
                        this.EntradaTipo.Location = new System.Drawing.Point(84, 84);
                        this.EntradaTipo.MaxLength = 200;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.Required = true;
                        this.EntradaTipo.SelectOnFocus = false;
                        this.EntradaTipo.Size = new System.Drawing.Size(255, 24);
                        this.EntradaTipo.TabIndex = 5;
                        this.EntradaTipo.Table = "personas_tipos";
                        this.EntradaTipo.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaTipo.Text = "0";
                        this.EntradaTipo.TextDetail = "";
                        this.EntradaTipo.TextInt = 0;
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
                        this.EntradaGrupo.AutoHeight = false;
                        this.EntradaGrupo.AutoTab = true;
                        this.EntradaGrupo.CanCreate = true;
                        this.EntradaGrupo.DetailField = "nombre";
                        this.EntradaGrupo.ExtraDetailFields = null;
                        this.EntradaGrupo.Filter = "parent IS NULL";
                        this.EntradaGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaGrupo.FreeTextCode = "";
                        this.EntradaGrupo.KeyField = "id_grupo";
                        this.EntradaGrupo.Location = new System.Drawing.Point(84, 28);
                        this.EntradaGrupo.MaxLength = 200;
                        this.EntradaGrupo.Name = "EntradaGrupo";
                        this.EntradaGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGrupo.ReadOnly = false;
                        this.EntradaGrupo.Required = false;
                        this.EntradaGrupo.SelectOnFocus = false;
                        this.EntradaGrupo.Size = new System.Drawing.Size(255, 24);
                        this.EntradaGrupo.TabIndex = 1;
                        this.EntradaGrupo.Table = "personas_grupos";
                        this.EntradaGrupo.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaGrupo.Text = "0";
                        this.EntradaGrupo.TextDetail = "";
                        this.EntradaGrupo.TextInt = 0;
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
                        this.BotonAcceso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAcceso.AutoHeight = false;
                        this.BotonAcceso.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAcceso.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonAcceso.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAcceso.Image = null;
                        this.BotonAcceso.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAcceso.Location = new System.Drawing.Point(24, 422);
                        this.BotonAcceso.Name = "BotonAcceso";
                        this.BotonAcceso.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAcceso.ReadOnly = false;
                        this.BotonAcceso.Size = new System.Drawing.Size(104, 44);
                        this.BotonAcceso.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonAcceso.Subtext = "F2";
                        this.BotonAcceso.TabIndex = 100;
                        this.BotonAcceso.Text = "Accesos";
                        this.BotonAcceso.ToolTipText = "";
                        this.BotonAcceso.Visible = false;
                        this.BotonAcceso.Click += new System.EventHandler(this.BotonAcceso_Click);
                        // 
                        // EntradaLimiteCredito
                        // 
                        this.EntradaLimiteCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaLimiteCredito.AutoHeight = false;
                        this.EntradaLimiteCredito.AutoNav = true;
                        this.EntradaLimiteCredito.AutoTab = true;
                        this.EntradaLimiteCredito.DataType = Lui.Forms.DataTypes.Money;
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
                        this.EntradaLimiteCredito.ReadOnly = false;
                        this.EntradaLimiteCredito.SelectOnFocus = true;
                        this.EntradaLimiteCredito.Size = new System.Drawing.Size(195, 24);
                        this.EntradaLimiteCredito.Sufijo = "";
                        this.EntradaLimiteCredito.TabIndex = 7;
                        this.EntradaLimiteCredito.Text = "0.00";
                        this.EntradaLimiteCredito.TextRaw = "0.00";
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
                        this.EntradaFechaNac.AutoHeight = false;
                        this.EntradaFechaNac.AutoNav = true;
                        this.EntradaFechaNac.AutoTab = true;
                        this.EntradaFechaNac.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaNac.DecimalPlaces = -1;
                        this.EntradaFechaNac.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaNac.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaNac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaNac.Location = new System.Drawing.Point(160, 168);
                        this.EntradaFechaNac.MaxLenght = 32767;
                        this.EntradaFechaNac.MultiLine = false;
                        this.EntradaFechaNac.Name = "EntradaFechaNac";
                        this.EntradaFechaNac.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaNac.PasswordChar = '\0';
                        this.EntradaFechaNac.Prefijo = "";
                        this.EntradaFechaNac.ReadOnly = false;
                        this.EntradaFechaNac.SelectOnFocus = true;
                        this.EntradaFechaNac.Size = new System.Drawing.Size(152, 24);
                        this.EntradaFechaNac.Sufijo = "";
                        this.EntradaFechaNac.TabIndex = 11;
                        this.EntradaFechaNac.TextRaw = "";
                        this.EntradaFechaNac.TipWhenBlank = "";
                        this.EntradaFechaNac.ToolTipText = "";
                        // 
                        // label18
                        // 
                        this.label18.Location = new System.Drawing.Point(8, 168);
                        this.label18.Name = "label18";
                        this.label18.Size = new System.Drawing.Size(152, 24);
                        this.label18.TabIndex = 10;
                        this.label18.Text = "Fecha de Nacimiento";
                        this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDomicilioTrabajo
                        // 
                        this.EntradaDomicilioTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDomicilioTrabajo.AutoHeight = false;
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
                        this.EntradaDomicilioTrabajo.ReadOnly = false;
                        this.EntradaDomicilioTrabajo.SelectOnFocus = false;
                        this.EntradaDomicilioTrabajo.Size = new System.Drawing.Size(316, 24);
                        this.EntradaDomicilioTrabajo.Sufijo = "";
                        this.EntradaDomicilioTrabajo.TabIndex = 3;
                        this.EntradaDomicilioTrabajo.TextRaw = "";
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
                        this.EntradaEstadoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstadoCredito.AutoHeight = false;
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
                        this.EntradaEstadoCredito.ReadOnly = false;
                        this.EntradaEstadoCredito.SetData = new string[] {
        "Normal|0",
        "En plan de pagos|5",
        "Suspendido|10",
        "Suspend. permanente|100"};
                        this.EntradaEstadoCredito.Size = new System.Drawing.Size(195, 24);
                        this.EntradaEstadoCredito.TabIndex = 9;
                        this.EntradaEstadoCredito.Table = null;
                        this.EntradaEstadoCredito.Text = "Suspend. permanente";
                        this.EntradaEstadoCredito.TextKey = "100";
                        this.EntradaEstadoCredito.TextRaw = "Suspend. permanente";
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
                        this.EntradaCbu.AutoHeight = false;
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
                        this.EntradaCbu.ReadOnly = false;
                        this.EntradaCbu.SelectOnFocus = true;
                        this.EntradaCbu.Size = new System.Drawing.Size(267, 24);
                        this.EntradaCbu.Sufijo = "";
                        this.EntradaCbu.TabIndex = 13;
                        this.EntradaCbu.TextRaw = "";
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
                        this.EntradaNumeroCuenta.AutoHeight = false;
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
                        this.EntradaNumeroCuenta.ReadOnly = false;
                        this.EntradaNumeroCuenta.SelectOnFocus = true;
                        this.EntradaNumeroCuenta.Size = new System.Drawing.Size(195, 24);
                        this.EntradaNumeroCuenta.Sufijo = "";
                        this.EntradaNumeroCuenta.TabIndex = 11;
                        this.EntradaNumeroCuenta.TextRaw = "";
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
                        this.frame3.AutoHeight = false;
                        this.frame3.Controls.Add(this.Label8);
                        this.frame3.Controls.Add(this.EntradaDomicilio);
                        this.frame3.Controls.Add(this.EntradaTelefono);
                        this.frame3.Controls.Add(this.label18);
                        this.frame3.Controls.Add(this.Label10);
                        this.frame3.Controls.Add(this.Label11);
                        this.frame3.Controls.Add(this.label19);
                        this.frame3.Controls.Add(this.Label9);
                        this.frame3.Controls.Add(this.EntradaDomicilioTrabajo);
                        this.frame3.Controls.Add(this.EntradaEmail);
                        this.frame3.Controls.Add(this.EntradaFechaNac);
                        this.frame3.Controls.Add(this.EntradaCiudad);
                        this.frame3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame3.Location = new System.Drawing.Point(3, 154);
                        this.frame3.Name = "frame3";
                        this.frame3.Padding = new System.Windows.Forms.Padding(2);
                        this.frame3.ReadOnly = false;
                        this.frame3.Size = new System.Drawing.Size(420, 198);
                        this.frame3.TabIndex = 2;
                        this.frame3.Text = "Datos de Contacto";
                        this.frame3.ToolTipText = "";
                        // 
                        // frame4
                        // 
                        this.frame4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame4.AutoHeight = false;
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
                        this.frame4.Location = new System.Drawing.Point(429, 154);
                        this.frame4.Name = "frame4";
                        this.frame4.Padding = new System.Windows.Forms.Padding(2);
                        this.frame4.ReadOnly = false;
                        this.frame4.Size = new System.Drawing.Size(343, 226);
                        this.frame4.TabIndex = 3;
                        this.frame4.Text = "Otros datos";
                        this.frame4.ToolTipText = "";
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
                        this.EntradaSubGrupo.Filter = "parent IS NULL";
                        this.EntradaSubGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSubGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSubGrupo.FreeTextCode = "";
                        this.EntradaSubGrupo.KeyField = "id_grupo";
                        this.EntradaSubGrupo.Location = new System.Drawing.Point(84, 56);
                        this.EntradaSubGrupo.MaxLength = 200;
                        this.EntradaSubGrupo.Name = "EntradaSubGrupo";
                        this.EntradaSubGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubGrupo.ReadOnly = false;
                        this.EntradaSubGrupo.Required = false;
                        this.EntradaSubGrupo.SelectOnFocus = false;
                        this.EntradaSubGrupo.Size = new System.Drawing.Size(255, 24);
                        this.EntradaSubGrupo.TabIndex = 3;
                        this.EntradaSubGrupo.Table = "personas_grupos";
                        this.EntradaSubGrupo.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaSubGrupo.Text = "0";
                        this.EntradaSubGrupo.TextDetail = "";
                        this.EntradaSubGrupo.TextInt = 0;
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
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoHeight = false;
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaObs.Location = new System.Drawing.Point(3, 558);
                        this.EntradaObs.MaxLenght = 32767;
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = true;
                        this.EntradaObs.Size = new System.Drawing.Size(420, 78);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 5;
                        this.EntradaObs.TextRaw = "";
                        this.EntradaObs.TipWhenBlank = "";
                        this.EntradaObs.ToolTipText = "";
                        // 
                        // EntradaNombreVisible
                        // 
                        this.EntradaNombreVisible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombreVisible.AutoHeight = false;
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
                        this.EntradaNombreVisible.ReadOnly = true;
                        this.EntradaNombreVisible.SelectOnFocus = true;
                        this.EntradaNombreVisible.Size = new System.Drawing.Size(660, 28);
                        this.EntradaNombreVisible.Sufijo = "";
                        this.EntradaNombreVisible.TabIndex = 1;
                        this.EntradaNombreVisible.TabStop = false;
                        this.EntradaNombreVisible.TextRaw = "";
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
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
                        this.tableLayoutPanel1.Controls.Add(this.EntradaTags, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.frame4, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.frame3, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Frame2, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Frame1, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaObs, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaImagen, 1, 2);
                        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 4;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 640);
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // EntradaTags
                        // 
                        this.EntradaTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaTags.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaTags.Location = new System.Drawing.Point(4, 386);
                        this.EntradaTags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaTags.Name = "EntradaTags";
                        this.EntradaTags.Size = new System.Drawing.Size(418, 166);
                        this.EntradaTags.TabIndex = 4;
                        this.EntradaTags.Text = "Atributos especiales";
                        // 
                        // EntradaImagen
                        // 
                        this.EntradaImagen.AutoHeight = true;
                        this.EntradaImagen.AutoNav = true;
                        this.EntradaImagen.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.EntradaImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaImagen.Location = new System.Drawing.Point(429, 386);
                        this.EntradaImagen.Name = "EntradaImagen";
                        this.EntradaImagen.ReadOnly = false;
                        this.EntradaImagen.Size = new System.Drawing.Size(343, 166);
                        this.EntradaImagen.TabIndex = 6;
                        // 
                        // ContenedorScroll
                        // 
                        this.ContenedorScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ContenedorScroll.AutoScroll = true;
                        this.ContenedorScroll.Controls.Add(this.tableLayoutPanel1);
                        this.ContenedorScroll.Location = new System.Drawing.Point(0, 41);
                        this.ContenedorScroll.Name = "ContenedorScroll";
                        this.ContenedorScroll.Size = new System.Drawing.Size(792, 372);
                        this.ContenedorScroll.TabIndex = 0;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(792, 473);
                        this.Controls.Add(this.BotonAcceso);
                        this.Controls.Add(this.EntradaNombreVisible);
                        this.Controls.Add(this.ContenedorScroll);
                        this.Controls.Add(this.Label4);
                        this.Name = "Editar";
                        this.Text = "Clientes: Editar";
                        this.WorkspaceChanged += new System.EventHandler(this.FormClientesEditar_WorkspaceChanged);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClientesEditar_KeyDown);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.ContenedorScroll, 0);
                        this.Controls.SetChildIndex(this.EntradaNombreVisible, 0);
                        this.Controls.SetChildIndex(this.BotonAcceso, 0);
                        this.Frame1.ResumeLayout(false);
                        this.Frame1.PerformLayout();
                        this.Frame2.ResumeLayout(false);
                        this.Frame2.PerformLayout();
                        this.frame3.ResumeLayout(false);
                        this.frame3.PerformLayout();
                        this.frame4.ResumeLayout(false);
                        this.frame4.PerformLayout();
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.ContenedorScroll.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.TextBox EntradaEmail;
                internal Lui.Forms.TextBox EntradaTelefono;
                internal Lui.Forms.DetailBox EntradaCiudad;
                internal Lui.Forms.TextBox EntradaDomicilio;
                internal Lui.Forms.TextBox EntradaNumDoc;
                internal Lui.Forms.DetailBox EntradaTipoDoc;
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
                internal Lui.Forms.DetailBox EntradaSituacion;
                internal System.Windows.Forms.Label Label12;
                internal System.Windows.Forms.Label Label14;
                public Lui.Forms.DetailBox EntradaTipo;
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
                internal Lui.Forms.DetailBox EntradaGrupo;
                private Lui.Forms.Frame frame3;
                private Lui.Forms.Frame frame4;
                private Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.TextBox EntradaNombreVisible;
                internal Label Label4;
                private TableLayoutPanel tableLayoutPanel1;
                private Lui.Forms.FieldTags EntradaTags;
                private Panel ContenedorScroll;
                internal Lui.Forms.DetailBox EntradaSubGrupo;
                internal Label label13;
                private Lcc.Edicion.Imagen EntradaImagen;

        }
}
