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
using System.Text;

namespace Lfc.Pvs
{
        public partial class Editar
        {
		internal Lui.Forms.Label Label16;
		internal Lui.Forms.Label label1;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.ComboBox EntradaTipo;
		internal Lui.Forms.TextBox EntradaEstacion;
		internal Lui.Forms.ComboBox EntradaCarga;
		internal Lui.Forms.Button BotonEstacionSeleccionar;
		internal Lcc.Entrada.CodigoDetalle EntradaSucursal;
		internal Lui.Forms.Label label4;
		internal Lui.Forms.Label label5;
		internal Lui.Forms.Label label6;
		internal Lui.Forms.Label label7;
                internal Lui.Forms.ComboBox EntradaModelo;
                internal Lui.Forms.ComboBox EntradaPuerto;
                internal Lui.Forms.ComboBox EntradaBps;
                internal Lui.Forms.ComboBox EntradaTipoFac;
                internal Lui.Forms.Label label8;
                internal Lui.Forms.ComboBox EntradaDeTalonario;
                internal Lui.Forms.Label label9;
		private System.ComponentModel.IContainer components = null;

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                #region Designer generated code

                private void InitializeComponent()
                {
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.Label16 = new Lui.Forms.Label();
                        this.label1 = new Lui.Forms.Label();
                        this.EntradaEstacion = new Lui.Forms.TextBox();
                        this.EntradaCarga = new Lui.Forms.ComboBox();
                        this.label2 = new Lui.Forms.Label();
                        this.BotonEstacionSeleccionar = new Lui.Forms.Button();
                        this.EntradaSucursal = new Lcc.Entrada.CodigoDetalle();
                        this.label4 = new Lui.Forms.Label();
                        this.label5 = new Lui.Forms.Label();
                        this.label6 = new Lui.Forms.Label();
                        this.label7 = new Lui.Forms.Label();
                        this.EntradaModelo = new Lui.Forms.ComboBox();
                        this.EntradaPuerto = new Lui.Forms.ComboBox();
                        this.EntradaBps = new Lui.Forms.ComboBox();
                        this.EntradaTipoFac = new Lui.Forms.ComboBox();
                        this.label8 = new Lui.Forms.Label();
                        this.EntradaDeTalonario = new Lui.Forms.ComboBox();
                        this.label9 = new Lui.Forms.Label();
                        this.note2 = new Lui.Forms.Note();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.Label3 = new Lui.Forms.Label();
                        this.EntradaImpresora = new Lcc.Entrada.CodigoDetalle();
                        this.label10 = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AlwaysExpanded = true;
                        this.EntradaTipo.AutoSize = true;
                        this.EntradaTipo.Location = new System.Drawing.Point(140, 184);
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "Inactivo|0",
        "Impresora Normal|1",
        "Impresora Fiscal|2"};
                        this.EntradaTipo.Size = new System.Drawing.Size(208, 51);
                        this.EntradaTipo.TabIndex = 9;
                        this.EntradaTipo.TextKey = "1";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipo_TextChanged);
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(0, 188);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(140, 24);
                        this.Label16.TabIndex = 8;
                        this.Label16.Text = "Tipo";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(0, 244);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(140, 24);
                        this.label1.TabIndex = 10;
                        this.label1.Text = "Estación";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstacion
                        // 
                        this.EntradaEstacion.ForceCase = Lui.Forms.TextCasing.UpperCase;
                        this.EntradaEstacion.Location = new System.Drawing.Point(140, 244);
                        this.EntradaEstacion.Name = "EntradaEstacion";
                        this.EntradaEstacion.ReadOnly = false;
                        this.EntradaEstacion.Size = new System.Drawing.Size(336, 24);
                        this.EntradaEstacion.TabIndex = 11;
                        // 
                        // EntradaCarga
                        // 
                        this.EntradaCarga.AlwaysExpanded = false;
                        this.EntradaCarga.Location = new System.Drawing.Point(212, 312);
                        this.EntradaCarga.Name = "EntradaCarga";
                        this.EntradaCarga.ReadOnly = false;
                        this.EntradaCarga.SetData = new string[] {
        "Automática|0",
        "Manual|1"};
                        this.EntradaCarga.Size = new System.Drawing.Size(208, 24);
                        this.EntradaCarga.TabIndex = 16;
                        this.EntradaCarga.TextKey = "0";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(72, 312);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(140, 24);
                        this.label2.TabIndex = 15;
                        this.label2.Text = "Carga de Papel";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // BotonEstacionSeleccionar
                        // 
                        this.BotonEstacionSeleccionar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonEstacionSeleccionar.Image = null;
                        this.BotonEstacionSeleccionar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonEstacionSeleccionar.Location = new System.Drawing.Point(480, 232);
                        this.BotonEstacionSeleccionar.Name = "BotonEstacionSeleccionar";
                        this.BotonEstacionSeleccionar.ReadOnly = false;
                        this.BotonEstacionSeleccionar.Size = new System.Drawing.Size(28, 24);
                        this.BotonEstacionSeleccionar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonEstacionSeleccionar.Subtext = "";
                        this.BotonEstacionSeleccionar.TabIndex = 12;
                        this.BotonEstacionSeleccionar.Text = "...";
                        this.BotonEstacionSeleccionar.Click += new System.EventHandler(this.BotonEstacionSeleccionar_Click);
                        // 
                        // EntradaSucursal
                        // 
                        this.EntradaSucursal.CanCreate = true;
                        this.EntradaSucursal.DataTextField = "nombre";
                        this.EntradaSucursal.DataValueField = "id_sucursal";
                        this.EntradaSucursal.ExtraDetailFields = "";
                        this.EntradaSucursal.Filter = "";
                        this.EntradaSucursal.FreeTextCode = "";
                        this.EntradaSucursal.Location = new System.Drawing.Point(140, 32);
                        this.EntradaSucursal.MaxLength = 200;
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.PlaceholderText = "Sucursal";
                        this.EntradaSucursal.ReadOnly = false;
                        this.EntradaSucursal.Required = true;
                        this.EntradaSucursal.Size = new System.Drawing.Size(500, 24);
                        this.EntradaSucursal.TabIndex = 3;
                        this.EntradaSucursal.Table = "sucursales";
                        this.EntradaSucursal.Text = "0";
                        this.EntradaSucursal.TextDetail = "";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(0, 32);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(140, 24);
                        this.label4.TabIndex = 2;
                        this.label4.Text = "Sucursal";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(72, 344);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(140, 24);
                        this.label5.TabIndex = 17;
                        this.label5.Text = "Modelo";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(72, 376);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(140, 24);
                        this.label6.TabIndex = 19;
                        this.label6.Text = "Puerto";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(72, 408);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(140, 24);
                        this.label7.TabIndex = 21;
                        this.label7.Text = "Velocidad";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaModelo
                        // 
                        this.EntradaModelo.AlwaysExpanded = false;
                        this.EntradaModelo.Enabled = false;
                        this.EntradaModelo.Location = new System.Drawing.Point(212, 344);
                        this.EntradaModelo.Name = "EntradaModelo";
                        this.EntradaModelo.ReadOnly = false;
                        this.EntradaModelo.SetData = new string[] {
        "Hasar|100",
        "Epson|300",
        "Emulación|1"};
                        this.EntradaModelo.Size = new System.Drawing.Size(136, 24);
                        this.EntradaModelo.TabIndex = 18;
                        this.EntradaModelo.TextKey = "300";
                        // 
                        // EntradaPuerto
                        // 
                        this.EntradaPuerto.AlwaysExpanded = false;
                        this.EntradaPuerto.Enabled = false;
                        this.EntradaPuerto.Location = new System.Drawing.Point(212, 376);
                        this.EntradaPuerto.Name = "EntradaPuerto";
                        this.EntradaPuerto.ReadOnly = false;
                        this.EntradaPuerto.SetData = new string[] {
        "COM1|1",
        "COM2|2"};
                        this.EntradaPuerto.Size = new System.Drawing.Size(136, 24);
                        this.EntradaPuerto.TabIndex = 20;
                        this.EntradaPuerto.TextKey = "1";
                        // 
                        // EntradaBps
                        // 
                        this.EntradaBps.AlwaysExpanded = false;
                        this.EntradaBps.Enabled = false;
                        this.EntradaBps.Location = new System.Drawing.Point(212, 408);
                        this.EntradaBps.Name = "EntradaBps";
                        this.EntradaBps.ReadOnly = false;
                        this.EntradaBps.SetData = new string[] {
        "9600 bps|9600",
        "19200 bps|19200"};
                        this.EntradaBps.Size = new System.Drawing.Size(136, 24);
                        this.EntradaBps.TabIndex = 22;
                        this.EntradaBps.TextKey = "9600";
                        // 
                        // EntradaTipoFac
                        // 
                        this.EntradaTipoFac.AlwaysExpanded = true;
                        this.EntradaTipoFac.AutoSize = true;
                        this.EntradaTipoFac.Location = new System.Drawing.Point(140, 96);
                        this.EntradaTipoFac.Name = "EntradaTipoFac";
                        this.EntradaTipoFac.ReadOnly = false;
                        this.EntradaTipoFac.SetData = new string[] {
        "Facturas|F",
        "Facturas, Notas de Débito|F,ND",
        "Facturas, Notas de Crédito y Débito|F,NC,ND",
        "Remitos|R",
        "Recibos de Cobro|RC"};
                        this.EntradaTipoFac.Size = new System.Drawing.Size(336, 81);
                        this.EntradaTipoFac.TabIndex = 7;
                        this.EntradaTipoFac.TextKey = "F,NC,ND";
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(0, 96);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(140, 24);
                        this.label8.TabIndex = 6;
                        this.label8.Text = "Documentos";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDeTalonario
                        // 
                        this.EntradaDeTalonario.AlwaysExpanded = false;
                        this.EntradaDeTalonario.Location = new System.Drawing.Point(212, 280);
                        this.EntradaDeTalonario.Name = "EntradaDeTalonario";
                        this.EntradaDeTalonario.ReadOnly = false;
                        this.EntradaDeTalonario.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaDeTalonario.Size = new System.Drawing.Size(116, 24);
                        this.EntradaDeTalonario.TabIndex = 14;
                        this.EntradaDeTalonario.TextKey = "0";
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(72, 280);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(140, 24);
                        this.label9.TabIndex = 13;
                        this.label9.Text = "Usa Talonarios";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // note2
                        // 
                        this.note2.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.note2.Location = new System.Drawing.Point(2, 443);
                        this.note2.Name = "note2";
                        this.note2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.note2.ReadOnly = false;
                        this.note2.Size = new System.Drawing.Size(636, 72);
                        this.note2.TabIndex = 50;
                        this.note2.Text = "Si desea cambiar el punto de venta predeterminado para las facturas u otros docum" +
    "entos, utilice la opción Preferencias del menú Sistema.";
                        this.note2.Title = "Información";
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaNumero.Location = new System.Drawing.Point(140, 0);
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.Size = new System.Drawing.Size(72, 24);
                        this.EntradaNumero.TabIndex = 1;
                        this.EntradaNumero.Text = "0";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(0, 0);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(140, 24);
                        this.Label3.TabIndex = 0;
                        this.Label3.Text = "Punto de Venta";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaImpresora
                        // 
                        this.EntradaImpresora.CanCreate = true;
                        this.EntradaImpresora.DataTextField = "nombre";
                        this.EntradaImpresora.DataValueField = "id_impresora";
                        this.EntradaImpresora.ExtraDetailFields = "";
                        this.EntradaImpresora.Filter = "";
                        this.EntradaImpresora.FreeTextCode = "";
                        this.EntradaImpresora.Location = new System.Drawing.Point(140, 64);
                        this.EntradaImpresora.MaxLength = 200;
                        this.EntradaImpresora.Name = "EntradaImpresora";
                        this.EntradaImpresora.PlaceholderText = "Impresora";
                        this.EntradaImpresora.ReadOnly = false;
                        this.EntradaImpresora.Required = true;
                        this.EntradaImpresora.Size = new System.Drawing.Size(500, 24);
                        this.EntradaImpresora.TabIndex = 5;
                        this.EntradaImpresora.Table = "impresoras";
                        this.EntradaImpresora.Text = "0";
                        this.EntradaImpresora.TextDetail = "";
                        // 
                        // label10
                        // 
                        this.label10.Location = new System.Drawing.Point(0, 64);
                        this.label10.Name = "label10";
                        this.label10.Size = new System.Drawing.Size(140, 24);
                        this.label10.TabIndex = 4;
                        this.label10.Text = "Impresora Predet.";
                        this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.EntradaImpresora);
                        this.Controls.Add(this.label10);
                        this.Controls.Add(this.EntradaTipoFac);
                        this.Controls.Add(this.note2);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.EntradaDeTalonario);
                        this.Controls.Add(this.EntradaSucursal);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaBps);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaPuerto);
                        this.Controls.Add(this.EntradaModelo);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.Label16);
                        this.Controls.Add(this.EntradaCarga);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.BotonEstacionSeleccionar);
                        this.Controls.Add(this.EntradaEstacion);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 517);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                private Lui.Forms.Note note2;
                internal Lui.Forms.TextBox EntradaNumero;
                internal Lui.Forms.Label Label3;
                internal Lcc.Entrada.CodigoDetalle EntradaImpresora;
                internal Lui.Forms.Label label10;
        }
}
