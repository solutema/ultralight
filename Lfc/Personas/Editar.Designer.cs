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
                        this.PanelI1 = new Lui.Forms.Frame();
                        this.EntradaFechaNac = new Lui.Forms.TextBox();
                        this.label18 = new Lui.Forms.Label();
                        this.PanelD1 = new Lui.Forms.Frame();
                        this.EntradaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaTipoFac = new Lui.Forms.ComboBox();
                        this.Label12 = new Lui.Forms.Label();
                        this.Label15 = new Lui.Forms.Label();
                        this.EntradaTipo = new Lcc.Entrada.CodigoDetalle();
                        this.Label14 = new Lui.Forms.Label();
                        this.EntradaGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.Label16 = new Lui.Forms.Label();
                        this.EntradaLimiteCredito = new Lui.Forms.TextBox();
                        this.label17 = new Lui.Forms.Label();
                        this.EntradaDomicilioTrabajo = new Lui.Forms.TextBox();
                        this.label19 = new Lui.Forms.Label();
                        this.EntradaEstadoCredito = new Lui.Forms.ComboBox();
                        this.label21 = new Lui.Forms.Label();
                        this.EntradaClaveBancaria = new Lui.Forms.TextBox();
                        this.EtiquetaClaveBancaria = new Lui.Forms.Label();
                        this.EntradaNumeroCuenta = new Lui.Forms.TextBox();
                        this.label22 = new Lui.Forms.Label();
                        this.PanelI2 = new Lui.Forms.Frame();
                        this.EntradaVendedor = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaTelefono = new Lcc.Entrada.MatrizTelefonos();
                        this.label23 = new Lui.Forms.Label();
                        this.PanelD2 = new Lui.Forms.Frame();
                        this.EntradaSubGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.label13 = new Lui.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.frame5 = new Lui.Forms.Frame();
                        this.EntradaFechaBaja = new Lui.Forms.TextBox();
                        this.EntradaFechaAlta = new Lui.Forms.TextBox();
                        this.label4 = new Lui.Forms.Label();
                        this.label24 = new Lui.Forms.Label();
                        this.label25 = new Lui.Forms.Label();
                        this.label26 = new Lui.Forms.Label();
                        this.matrizTelefonos1 = new Lcc.Entrada.MatrizTelefonos();
                        this.PanelI1.SuspendLayout();
                        this.PanelD1.SuspendLayout();
                        this.PanelI2.SuspendLayout();
                        this.PanelD2.SuspendLayout();
                        this.frame5.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaEmail
                        // 
                        this.EntradaEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEmail.ForceCase = Lui.Forms.TextCasing.LowerCase;
                        this.EntradaEmail.Location = new System.Drawing.Point(128, 200);
                        this.EntradaEmail.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaEmail.MaxLength = 200;
                        this.EntradaEmail.Name = "EntradaEmail";
                        this.EntradaEmail.Size = new System.Drawing.Size(212, 24);
                        this.EntradaEmail.TabIndex = 7;
                        this.EntradaEmail.Leave += new System.EventHandler(this.EntradaEmail_Leave);
                        // 
                        // EntradaLocalidad
                        // 
                        this.EntradaLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaLocalidad.AutoTab = true;
                        this.EntradaLocalidad.CanCreate = true;
                        this.EntradaLocalidad.DataTextField = "nombre";
                        this.EntradaLocalidad.DataValueField = "id_ciudad";
                        this.EntradaLocalidad.ExtraDetailFields = "";
                        this.EntradaLocalidad.Filter = "id_provincia IS NOT NULL";
                        this.EntradaLocalidad.FreeTextCode = "";
                        this.EntradaLocalidad.Location = new System.Drawing.Point(128, 232);
                        this.EntradaLocalidad.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaLocalidad.MaxLength = 200;
                        this.EntradaLocalidad.Name = "EntradaLocalidad";
                        this.EntradaLocalidad.PlaceholderText = "Sin especificar";
                        this.EntradaLocalidad.Required = true;
                        this.EntradaLocalidad.Size = new System.Drawing.Size(212, 24);
                        this.EntradaLocalidad.TabIndex = 9;
                        this.EntradaLocalidad.NombreTipo = "Lbl.Entidades.Localidad";
                        this.EntradaLocalidad.Text = "0";
                        this.EntradaLocalidad.TextDetail = "";
                        // 
                        // EntradaDomicilio
                        // 
                        this.EntradaDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDomicilio.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaDomicilio.Location = new System.Drawing.Point(128, 40);
                        this.EntradaDomicilio.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaDomicilio.MaxLength = 200;
                        this.EntradaDomicilio.Name = "EntradaDomicilio";
                        this.EntradaDomicilio.Size = new System.Drawing.Size(212, 24);
                        this.EntradaDomicilio.TabIndex = 1;
                        // 
                        // EntradaNumDoc
                        // 
                        this.EntradaNumDoc.Location = new System.Drawing.Point(208, 136);
                        this.EntradaNumDoc.MaxLength = 50;
                        this.EntradaNumDoc.Name = "EntradaNumDoc";
                        this.EntradaNumDoc.Size = new System.Drawing.Size(136, 24);
                        this.EntradaNumDoc.TabIndex = 7;
                        // 
                        // EntradaTipoDoc
                        // 
                        this.EntradaTipoDoc.AutoTab = true;
                        this.EntradaTipoDoc.CanCreate = false;
                        this.EntradaTipoDoc.DataTextField = "nombre";
                        this.EntradaTipoDoc.DataValueField = "id_tipo_doc";
                        this.EntradaTipoDoc.ExtraDetailFields = "";
                        this.EntradaTipoDoc.Filter = "";
                        this.EntradaTipoDoc.FreeTextCode = "";
                        this.EntradaTipoDoc.Location = new System.Drawing.Point(208, 104);
                        this.EntradaTipoDoc.MaximumSize = new System.Drawing.Size(200, 32);
                        this.EntradaTipoDoc.MaxLength = 200;
                        this.EntradaTipoDoc.Name = "EntradaTipoDoc";
                        this.EntradaTipoDoc.PlaceholderText = null;
                        this.EntradaTipoDoc.Required = true;
                        this.EntradaTipoDoc.Size = new System.Drawing.Size(136, 24);
                        this.EntradaTipoDoc.TabIndex = 5;
                        this.EntradaTipoDoc.NombreTipo = "Lbl.Entidades.ClaveUnica";
                        this.EntradaTipoDoc.Text = "0";
                        this.EntradaTipoDoc.TextDetail = "";
                        // 
                        // EntradaApellido
                        // 
                        this.EntradaApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaApellido.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaApellido.Location = new System.Drawing.Point(112, 72);
                        this.EntradaApellido.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaApellido.MaxLength = 200;
                        this.EntradaApellido.Name = "EntradaApellido";
                        this.EntradaApellido.Size = new System.Drawing.Size(232, 24);
                        this.EntradaApellido.TabIndex = 3;
                        this.EntradaApellido.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaNombre.Location = new System.Drawing.Point(112, 40);
                        this.EntradaNombre.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaNombre.MaxLength = 200;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Size = new System.Drawing.Size(232, 24);
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // EntradaClaveTributaria
                        // 
                        this.EntradaClaveTributaria.Location = new System.Drawing.Point(128, 72);
                        this.EntradaClaveTributaria.MaxLength = 50;
                        this.EntradaClaveTributaria.Name = "EntradaClaveTributaria";
                        this.EntradaClaveTributaria.Size = new System.Drawing.Size(142, 24);
                        this.EntradaClaveTributaria.TabIndex = 3;
                        this.EntradaClaveTributaria.Leave += new System.EventHandler(this.EntradaClaveTributaria_Leave);
                        // 
                        // EntradaRazonSocial
                        // 
                        this.EntradaRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaRazonSocial.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaRazonSocial.Location = new System.Drawing.Point(128, 40);
                        this.EntradaRazonSocial.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaRazonSocial.MaxLength = 200;
                        this.EntradaRazonSocial.Name = "EntradaRazonSocial";
                        this.EntradaRazonSocial.Size = new System.Drawing.Size(212, 24);
                        this.EntradaRazonSocial.TabIndex = 1;
                        this.EntradaRazonSocial.TextChanged += new System.EventHandler(this.GenerarNombreVisible);
                        // 
                        // Label10
                        // 
                        this.Label10.Location = new System.Drawing.Point(8, 100);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(120, 24);
                        this.Label10.TabIndex = 4;
                        this.Label10.Text = "Teléfonos";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label9
                        // 
                        this.Label9.Location = new System.Drawing.Point(8, 232);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(120, 24);
                        this.Label9.TabIndex = 8;
                        this.Label9.Text = "Localidad";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label8
                        // 
                        this.Label8.Location = new System.Drawing.Point(8, 40);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(120, 24);
                        this.Label8.TabIndex = 0;
                        this.Label8.Text = "Domicilio";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(8, 136);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(200, 24);
                        this.Label6.TabIndex = 6;
                        this.Label6.Text = "Número de documento";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(8, 104);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(200, 24);
                        this.Label5.TabIndex = 4;
                        this.Label5.Text = "Tipo de documento";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(8, 72);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(104, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Apellido";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(8, 40);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(104, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Nombre";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaClaveTributaria
                        // 
                        this.EtiquetaClaveTributaria.Location = new System.Drawing.Point(8, 72);
                        this.EtiquetaClaveTributaria.Name = "EtiquetaClaveTributaria";
                        this.EtiquetaClaveTributaria.Size = new System.Drawing.Size(120, 24);
                        this.EtiquetaClaveTributaria.TabIndex = 2;
                        this.EtiquetaClaveTributaria.Text = "Clave tributaria";
                        this.EtiquetaClaveTributaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(8, 40);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(120, 24);
                        this.Label3.TabIndex = 0;
                        this.Label3.Text = "Razón social";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(8, 200);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(120, 24);
                        this.Label11.TabIndex = 6;
                        this.Label11.Text = "E-mail";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelI1
                        // 
                        this.PanelI1.Controls.Add(this.EntradaNombre);
                        this.PanelI1.Controls.Add(this.EntradaApellido);
                        this.PanelI1.Controls.Add(this.EntradaTipoDoc);
                        this.PanelI1.Controls.Add(this.EntradaFechaNac);
                        this.PanelI1.Controls.Add(this.EntradaNumDoc);
                        this.PanelI1.Controls.Add(this.Label1);
                        this.PanelI1.Controls.Add(this.Label6);
                        this.PanelI1.Controls.Add(this.Label2);
                        this.PanelI1.Controls.Add(this.Label5);
                        this.PanelI1.Controls.Add(this.label18);
                        this.PanelI1.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.PanelI1.Location = new System.Drawing.Point(0, 0);
                        this.PanelI1.Margin = new System.Windows.Forms.Padding(6);
                        this.PanelI1.Name = "PanelI1";
                        this.PanelI1.Size = new System.Drawing.Size(344, 216);
                        this.PanelI1.TabIndex = 0;
                        this.PanelI1.Text = "Personas físicas";
                        // 
                        // EntradaFechaNac
                        // 
                        this.EntradaFechaNac.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaNac.Location = new System.Drawing.Point(208, 168);
                        this.EntradaFechaNac.MaxLength = 10;
                        this.EntradaFechaNac.Name = "EntradaFechaNac";
                        this.EntradaFechaNac.Size = new System.Drawing.Size(136, 24);
                        this.EntradaFechaNac.TabIndex = 9;
                        // 
                        // label18
                        // 
                        this.label18.Location = new System.Drawing.Point(8, 168);
                        this.label18.Name = "label18";
                        this.label18.Size = new System.Drawing.Size(200, 24);
                        this.label18.TabIndex = 8;
                        this.label18.Text = "Fecha de Nacimiento";
                        this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelD1
                        // 
                        this.PanelD1.Controls.Add(this.EntradaRazonSocial);
                        this.PanelD1.Controls.Add(this.EntradaClaveTributaria);
                        this.PanelD1.Controls.Add(this.EntradaSituacion);
                        this.PanelD1.Controls.Add(this.EntradaTipoFac);
                        this.PanelD1.Controls.Add(this.Label3);
                        this.PanelD1.Controls.Add(this.EtiquetaClaveTributaria);
                        this.PanelD1.Controls.Add(this.Label12);
                        this.PanelD1.Controls.Add(this.Label15);
                        this.PanelD1.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.PanelD1.Location = new System.Drawing.Point(360, 0);
                        this.PanelD1.Margin = new System.Windows.Forms.Padding(6);
                        this.PanelD1.Name = "PanelD1";
                        this.PanelD1.Size = new System.Drawing.Size(344, 224);
                        this.PanelD1.TabIndex = 1;
                        this.PanelD1.Text = "Personas jurídicas";
                        // 
                        // EntradaSituacion
                        // 
                        this.EntradaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSituacion.AutoTab = true;
                        this.EntradaSituacion.CanCreate = false;
                        this.EntradaSituacion.DataTextField = "nombre";
                        this.EntradaSituacion.DataValueField = "id_situacion";
                        this.EntradaSituacion.ExtraDetailFields = "";
                        this.EntradaSituacion.Filter = "";
                        this.EntradaSituacion.FreeTextCode = "";
                        this.EntradaSituacion.Location = new System.Drawing.Point(128, 104);
                        this.EntradaSituacion.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaSituacion.MaxLength = 200;
                        this.EntradaSituacion.Name = "EntradaSituacion";
                        this.EntradaSituacion.PlaceholderText = null;
                        this.EntradaSituacion.Required = true;
                        this.EntradaSituacion.Size = new System.Drawing.Size(212, 24);
                        this.EntradaSituacion.TabIndex = 5;
                        this.EntradaSituacion.NombreTipo = "Lbl.Impuestos.SituacionTributaria";
                        this.EntradaSituacion.Text = "0";
                        this.EntradaSituacion.TextDetail = "";
                        this.EntradaSituacion.Leave += new System.EventHandler(this.EntradaSituacion_Leave);
                        // 
                        // EntradaTipoFac
                        // 
                        this.EntradaTipoFac.AlwaysExpanded = true;
                        this.EntradaTipoFac.Location = new System.Drawing.Point(128, 136);
                        this.EntradaTipoFac.Name = "EntradaTipoFac";
                        this.EntradaTipoFac.SetData = new string[] {
        "Predeterminada|*",
        "Factura A|A",
        "Factura B|B",
        "Factura C|C",
        "Factura E|E",
        "Ticket|T"};
                        this.EntradaTipoFac.Size = new System.Drawing.Size(188, 80);
                        this.EntradaTipoFac.TabIndex = 7;
                        this.EntradaTipoFac.TextKey = "*";
                        // 
                        // Label12
                        // 
                        this.Label12.Location = new System.Drawing.Point(8, 104);
                        this.Label12.Name = "Label12";
                        this.Label12.Size = new System.Drawing.Size(120, 24);
                        this.Label12.TabIndex = 4;
                        this.Label12.Text = "Situación trib.";
                        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label15
                        // 
                        this.Label15.Location = new System.Drawing.Point(8, 136);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(120, 24);
                        this.Label15.TabIndex = 6;
                        this.Label15.Text = "Facturación";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.CanCreate = false;
                        this.EntradaTipo.DataTextField = "nombre";
                        this.EntradaTipo.DataValueField = "id_tipo_persona";
                        this.EntradaTipo.ExtraDetailFields = "";
                        this.EntradaTipo.Filter = "";
                        this.EntradaTipo.FreeTextCode = "";
                        this.EntradaTipo.Location = new System.Drawing.Point(112, 104);
                        this.EntradaTipo.MaximumSize = new System.Drawing.Size(320, 32);
                        this.EntradaTipo.MaxLength = 200;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.PlaceholderText = "Sin especificar";
                        this.EntradaTipo.Required = true;
                        this.EntradaTipo.Size = new System.Drawing.Size(232, 24);
                        this.EntradaTipo.TabIndex = 5;
                        this.EntradaTipo.NombreTipo = "Lbl.Personas.Tipo";
                        this.EntradaTipo.Text = "0";
                        this.EntradaTipo.TextDetail = "";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipo_TextChanged);
                        // 
                        // Label14
                        // 
                        this.Label14.Location = new System.Drawing.Point(8, 104);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(104, 24);
                        this.Label14.TabIndex = 4;
                        this.Label14.Text = "Tipo";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaGrupo
                        // 
                        this.EntradaGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaGrupo.AutoTab = true;
                        this.EntradaGrupo.CanCreate = true;
                        this.EntradaGrupo.DataTextField = "nombre";
                        this.EntradaGrupo.DataValueField = "id_grupo";
                        this.EntradaGrupo.ExtraDetailFields = "";
                        this.EntradaGrupo.Filter = "parent IS NULL";
                        this.EntradaGrupo.FreeTextCode = "";
                        this.EntradaGrupo.Location = new System.Drawing.Point(112, 40);
                        this.EntradaGrupo.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaGrupo.MaxLength = 200;
                        this.EntradaGrupo.Name = "EntradaGrupo";
                        this.EntradaGrupo.PlaceholderText = "Ninguno";
                        this.EntradaGrupo.Required = false;
                        this.EntradaGrupo.Size = new System.Drawing.Size(232, 24);
                        this.EntradaGrupo.TabIndex = 1;
                        this.EntradaGrupo.NombreTipo = "Lbl.Personas.Grupo";
                        this.EntradaGrupo.Text = "0";
                        this.EntradaGrupo.TextDetail = "";
                        this.EntradaGrupo.TextChanged += new System.EventHandler(this.EntradaGrupo_TextChanged);
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(8, 40);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(104, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Grupo";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaLimiteCredito
                        // 
                        this.EntradaLimiteCredito.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaLimiteCredito.Location = new System.Drawing.Point(176, 200);
                        this.EntradaLimiteCredito.MaxLength = 16;
                        this.EntradaLimiteCredito.Name = "EntradaLimiteCredito";
                        this.EntradaLimiteCredito.Prefijo = "$";
                        this.EntradaLimiteCredito.Size = new System.Drawing.Size(120, 24);
                        this.EntradaLimiteCredito.TabIndex = 11;
                        this.EntradaLimiteCredito.Text = "0.00";
                        // 
                        // label17
                        // 
                        this.label17.Location = new System.Drawing.Point(8, 200);
                        this.label17.Name = "label17";
                        this.label17.Size = new System.Drawing.Size(168, 24);
                        this.label17.TabIndex = 10;
                        this.label17.Text = "Límite de crédito";
                        this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDomicilioTrabajo
                        // 
                        this.EntradaDomicilioTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDomicilioTrabajo.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaDomicilioTrabajo.Location = new System.Drawing.Point(128, 72);
                        this.EntradaDomicilioTrabajo.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaDomicilioTrabajo.MaxLength = 200;
                        this.EntradaDomicilioTrabajo.Name = "EntradaDomicilioTrabajo";
                        this.EntradaDomicilioTrabajo.Size = new System.Drawing.Size(212, 24);
                        this.EntradaDomicilioTrabajo.TabIndex = 3;
                        // 
                        // label19
                        // 
                        this.label19.Location = new System.Drawing.Point(8, 72);
                        this.label19.Name = "label19";
                        this.label19.Size = new System.Drawing.Size(120, 24);
                        this.label19.TabIndex = 2;
                        this.label19.Text = "Dom. laboral";
                        this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstadoCredito
                        // 
                        this.EntradaEstadoCredito.AlwaysExpanded = true;
                        this.EntradaEstadoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstadoCredito.AutoSize = true;
                        this.EntradaEstadoCredito.Location = new System.Drawing.Point(176, 232);
                        this.EntradaEstadoCredito.Name = "EntradaEstadoCredito";
                        this.EntradaEstadoCredito.SetData = new string[] {
        "Normal|0",
        "En Plan de Pagos|5",
        "Suspendido con React. Automática|10",
        "Susp. con Reactivación Manual|100"};
                        this.EntradaEstadoCredito.Size = new System.Drawing.Size(168, 74);
                        this.EntradaEstadoCredito.TabIndex = 13;
                        this.EntradaEstadoCredito.TextKey = "100";
                        // 
                        // label21
                        // 
                        this.label21.Location = new System.Drawing.Point(8, 232);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(168, 24);
                        this.label21.TabIndex = 12;
                        this.label21.Text = "Estado de crédito";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaClaveBancaria
                        // 
                        this.EntradaClaveBancaria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaClaveBancaria.Location = new System.Drawing.Point(112, 168);
                        this.EntradaClaveBancaria.Name = "EntradaClaveBancaria";
                        this.EntradaClaveBancaria.Size = new System.Drawing.Size(232, 24);
                        this.EntradaClaveBancaria.TabIndex = 9;
                        // 
                        // EtiquetaClaveBancaria
                        // 
                        this.EtiquetaClaveBancaria.Location = new System.Drawing.Point(8, 168);
                        this.EtiquetaClaveBancaria.Name = "EtiquetaClaveBancaria";
                        this.EtiquetaClaveBancaria.Size = new System.Drawing.Size(104, 24);
                        this.EtiquetaClaveBancaria.TabIndex = 8;
                        this.EtiquetaClaveBancaria.Text = "CBU";
                        this.EtiquetaClaveBancaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNumeroCuenta
                        // 
                        this.EntradaNumeroCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNumeroCuenta.Location = new System.Drawing.Point(112, 136);
                        this.EntradaNumeroCuenta.MaxLength = 200;
                        this.EntradaNumeroCuenta.Name = "EntradaNumeroCuenta";
                        this.EntradaNumeroCuenta.Size = new System.Drawing.Size(232, 24);
                        this.EntradaNumeroCuenta.TabIndex = 7;
                        // 
                        // label22
                        // 
                        this.label22.Location = new System.Drawing.Point(8, 136);
                        this.label22.Name = "label22";
                        this.label22.Size = new System.Drawing.Size(104, 24);
                        this.label22.TabIndex = 6;
                        this.label22.Text = "Nº de cuenta";
                        this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelI2
                        // 
                        this.PanelI2.Controls.Add(this.EntradaDomicilio);
                        this.PanelI2.Controls.Add(this.EntradaVendedor);
                        this.PanelI2.Controls.Add(this.EntradaDomicilioTrabajo);
                        this.PanelI2.Controls.Add(this.EntradaEmail);
                        this.PanelI2.Controls.Add(this.EntradaLocalidad);
                        this.PanelI2.Controls.Add(this.EntradaTelefono);
                        this.PanelI2.Controls.Add(this.Label8);
                        this.PanelI2.Controls.Add(this.label19);
                        this.PanelI2.Controls.Add(this.label23);
                        this.PanelI2.Controls.Add(this.Label11);
                        this.PanelI2.Controls.Add(this.Label10);
                        this.PanelI2.Controls.Add(this.Label9);
                        this.PanelI2.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.PanelI2.Location = new System.Drawing.Point(0, 224);
                        this.PanelI2.Margin = new System.Windows.Forms.Padding(6);
                        this.PanelI2.Name = "PanelI2";
                        this.PanelI2.Size = new System.Drawing.Size(344, 304);
                        this.PanelI2.TabIndex = 2;
                        this.PanelI2.Text = "Datos de contacto";
                        // 
                        // EntradaVendedor
                        // 
                        this.EntradaVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaVendedor.AutoTab = true;
                        this.EntradaVendedor.CanCreate = true;
                        this.EntradaVendedor.DataTextField = "nombre_visible";
                        this.EntradaVendedor.DataValueField = "id_persona";
                        this.EntradaVendedor.ExtraDetailFields = "";
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.Location = new System.Drawing.Point(128, 264);
                        this.EntradaVendedor.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.PlaceholderText = "Ninguno";
                        this.EntradaVendedor.Required = false;
                        this.EntradaVendedor.Size = new System.Drawing.Size(212, 24);
                        this.EntradaVendedor.TabIndex = 11;
                        this.EntradaVendedor.NombreTipo = "Lbl.Personas.Persona";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
                        // 
                        // EntradaTelefono
                        // 
                        this.EntradaTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTelefono.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.EntradaTelefono.Location = new System.Drawing.Point(128, 104);
                        this.EntradaTelefono.Name = "EntradaTelefono";
                        this.EntradaTelefono.Size = new System.Drawing.Size(214, 88);
                        this.EntradaTelefono.TabIndex = 5;
                        // 
                        // label23
                        // 
                        this.label23.Location = new System.Drawing.Point(8, 264);
                        this.label23.Name = "label23";
                        this.label23.Size = new System.Drawing.Size(120, 24);
                        this.label23.TabIndex = 10;
                        this.label23.Text = "Vendedor";
                        this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelD2
                        // 
                        this.PanelD2.Controls.Add(this.EntradaSubGrupo);
                        this.PanelD2.Controls.Add(this.EntradaGrupo);
                        this.PanelD2.Controls.Add(this.EntradaClaveBancaria);
                        this.PanelD2.Controls.Add(this.EntradaLimiteCredito);
                        this.PanelD2.Controls.Add(this.EntradaTipo);
                        this.PanelD2.Controls.Add(this.EntradaNumeroCuenta);
                        this.PanelD2.Controls.Add(this.EtiquetaClaveBancaria);
                        this.PanelD2.Controls.Add(this.EntradaEstadoCredito);
                        this.PanelD2.Controls.Add(this.label17);
                        this.PanelD2.Controls.Add(this.label22);
                        this.PanelD2.Controls.Add(this.label21);
                        this.PanelD2.Controls.Add(this.Label16);
                        this.PanelD2.Controls.Add(this.Label14);
                        this.PanelD2.Controls.Add(this.label13);
                        this.PanelD2.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.PanelD2.Location = new System.Drawing.Point(360, 224);
                        this.PanelD2.Margin = new System.Windows.Forms.Padding(6);
                        this.PanelD2.Name = "PanelD2";
                        this.PanelD2.Size = new System.Drawing.Size(344, 304);
                        this.PanelD2.TabIndex = 3;
                        this.PanelD2.Text = "Otros datos";
                        // 
                        // EntradaSubGrupo
                        // 
                        this.EntradaSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSubGrupo.AutoTab = true;
                        this.EntradaSubGrupo.CanCreate = true;
                        this.EntradaSubGrupo.DataTextField = "nombre";
                        this.EntradaSubGrupo.DataValueField = "id_grupo";
                        this.EntradaSubGrupo.ExtraDetailFields = "";
                        this.EntradaSubGrupo.Filter = "parent IS NULL";
                        this.EntradaSubGrupo.FreeTextCode = "";
                        this.EntradaSubGrupo.Location = new System.Drawing.Point(112, 72);
                        this.EntradaSubGrupo.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaSubGrupo.MaxLength = 200;
                        this.EntradaSubGrupo.Name = "EntradaSubGrupo";
                        this.EntradaSubGrupo.PlaceholderText = "Ninguno";
                        this.EntradaSubGrupo.Required = false;
                        this.EntradaSubGrupo.Size = new System.Drawing.Size(232, 24);
                        this.EntradaSubGrupo.TabIndex = 3;
                        this.EntradaSubGrupo.NombreTipo = "Lbl.Personas.Grupo";
                        this.EntradaSubGrupo.Text = "0";
                        this.EntradaSubGrupo.TextDetail = "";
                        // 
                        // label13
                        // 
                        this.label13.Location = new System.Drawing.Point(8, 72);
                        this.label13.Name = "label13";
                        this.label13.Size = new System.Drawing.Size(104, 24);
                        this.label13.TabIndex = 2;
                        this.label13.Text = "Sub grupo";
                        this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AlwaysExpanded = true;
                        this.EntradaEstado.AutoSize = true;
                        this.EntradaEstado.Location = new System.Drawing.Point(136, 40);
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.SetData = new string[] {
        "Inactivo|0",
        "Activo|1"};
                        this.EntradaEstado.Size = new System.Drawing.Size(131, 40);
                        this.EntradaEstado.TabIndex = 1;
                        this.EntradaEstado.TextKey = "1";
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaObs.Location = new System.Drawing.Point(472, 40);
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Size = new System.Drawing.Size(232, 96);
                        this.EntradaObs.TabIndex = 7;
                        // 
                        // frame5
                        // 
                        this.frame5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame5.Controls.Add(this.EntradaEstado);
                        this.frame5.Controls.Add(this.EntradaFechaBaja);
                        this.frame5.Controls.Add(this.EntradaFechaAlta);
                        this.frame5.Controls.Add(this.EntradaObs);
                        this.frame5.Controls.Add(this.label4);
                        this.frame5.Controls.Add(this.label24);
                        this.frame5.Controls.Add(this.label25);
                        this.frame5.Controls.Add(this.label26);
                        this.frame5.Font = new System.Drawing.Font("Bitstream Vera Sans", 10F);
                        this.frame5.Location = new System.Drawing.Point(0, 528);
                        this.frame5.Margin = new System.Windows.Forms.Padding(6);
                        this.frame5.Name = "frame5";
                        this.frame5.Size = new System.Drawing.Size(704, 144);
                        this.frame5.TabIndex = 4;
                        this.frame5.Text = "Estado";
                        // 
                        // EntradaFechaBaja
                        // 
                        this.EntradaFechaBaja.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaBaja.Location = new System.Drawing.Point(136, 120);
                        this.EntradaFechaBaja.Name = "EntradaFechaBaja";
                        this.EntradaFechaBaja.ReadOnly = true;
                        this.EntradaFechaBaja.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaBaja.TabIndex = 5;
                        this.EntradaFechaBaja.TabStop = false;
                        // 
                        // EntradaFechaAlta
                        // 
                        this.EntradaFechaAlta.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaAlta.Location = new System.Drawing.Point(136, 88);
                        this.EntradaFechaAlta.Name = "EntradaFechaAlta";
                        this.EntradaFechaAlta.ReadOnly = true;
                        this.EntradaFechaAlta.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaAlta.TabIndex = 3;
                        this.EntradaFechaAlta.TabStop = false;
                        this.EntradaFechaAlta.Text = "01/01/2001";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(328, 40);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(144, 24);
                        this.label4.TabIndex = 6;
                        this.label4.Text = "Observaciones";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label24
                        // 
                        this.label24.Location = new System.Drawing.Point(8, 40);
                        this.label24.Name = "label24";
                        this.label24.Size = new System.Drawing.Size(128, 24);
                        this.label24.TabIndex = 0;
                        this.label24.Text = "Estado";
                        this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label25
                        // 
                        this.label25.Location = new System.Drawing.Point(8, 88);
                        this.label25.Name = "label25";
                        this.label25.Size = new System.Drawing.Size(128, 24);
                        this.label25.TabIndex = 2;
                        this.label25.Text = "Fecha de alta";
                        this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label26
                        // 
                        this.label26.Location = new System.Drawing.Point(8, 120);
                        this.label26.Name = "label26";
                        this.label26.Size = new System.Drawing.Size(128, 24);
                        this.label26.TabIndex = 4;
                        this.label26.Text = "Fecha de baja";
                        this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // matrizTelefonos1
                        // 
                        this.matrizTelefonos1.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.matrizTelefonos1.Location = new System.Drawing.Point(0, 0);
                        this.matrizTelefonos1.Name = "matrizTelefonos1";
                        this.matrizTelefonos1.Size = new System.Drawing.Size(536, 180);
                        this.matrizTelefonos1.TabIndex = 0;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.PanelD2);
                        this.Controls.Add(this.PanelD1);
                        this.Controls.Add(this.PanelI1);
                        this.Controls.Add(this.PanelI2);
                        this.Controls.Add(this.frame5);
                        this.MinimumSize = new System.Drawing.Size(708, 664);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(708, 664);
                        this.PanelI1.ResumeLayout(false);
                        this.PanelI1.PerformLayout();
                        this.PanelD1.ResumeLayout(false);
                        this.PanelD1.PerformLayout();
                        this.PanelI2.ResumeLayout(false);
                        this.PanelI2.PerformLayout();
                        this.PanelD2.ResumeLayout(false);
                        this.PanelD2.PerformLayout();
                        this.frame5.ResumeLayout(false);
                        this.frame5.PerformLayout();
                        this.ResumeLayout(false);

                }


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
                internal Lui.Forms.Frame PanelI1;
                internal Lui.Forms.Frame PanelD1;
                internal Lcc.Entrada.CodigoDetalle EntradaSituacion;
                internal Lui.Forms.Label Label12;
                internal Lui.Forms.Label Label14;
                public Lcc.Entrada.CodigoDetalle EntradaTipo;
                internal Lui.Forms.Label Label15;
                internal Lui.Forms.ComboBox EntradaTipoFac;
                internal Lui.Forms.Label Label16;
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
                private Lui.Forms.Frame PanelI2;
                private Lui.Forms.Frame PanelD2;
                private Lui.Forms.TextBox EntradaObs;
                internal Lcc.Entrada.CodigoDetalle EntradaSubGrupo;
                internal Lcc.Entrada.CodigoDetalle EntradaVendedor;
                private Lui.Forms.Frame frame5;
                internal Lui.Forms.TextBox EntradaFechaBaja;
                internal Lui.Forms.TextBox EntradaFechaAlta;
                internal Lui.Forms.ComboBox EntradaEstado;
                private Lcc.Entrada.MatrizTelefonos matrizTelefonos1;
                private Lcc.Entrada.MatrizTelefonos EntradaTelefono;
                internal Lui.Forms.Label EtiquetaClaveBancaria;
                internal Lui.Forms.Label label13;
                internal Lui.Forms.Label label23;
                internal Lui.Forms.Label label26;
                internal Lui.Forms.Label label25;
                internal Lui.Forms.Label label24;
                internal Lui.Forms.Label label4;
        }
}
