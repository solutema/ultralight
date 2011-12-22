#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace Lfc.Sucursales
{
        public partial class Editar
        {
		protected override void Dispose(bool disposing)
		{
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private System.ComponentModel.IContainer components = null;
		internal Lui.Forms.Label Label1;
		internal Lui.Forms.Label label2;
		internal Lui.Forms.Label label3;
		internal Lcc.Entrada.CodigoDetalle EntradaLocalidad;
		internal Lui.Forms.Label Label9;
                internal Lui.Forms.TextBox EntradaDireccion;
		internal Lcc.Entrada.CodigoDetalle EntradaSituacionOrigen;
		internal Lui.Forms.Label label4;
		internal Lui.Forms.Label label5;
		internal Lui.Forms.Label label6;
		internal Lcc.Entrada.CodigoDetalle EntradaCajaDiaria;
		internal Lcc.Entrada.CodigoDetalle EntradaCajaCheques;
		internal Lui.Forms.TextBox EntradaNombre;

                #region Windows Form Designer generated code
                
                private void InitializeComponent()
		{
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.EntradaDireccion = new Lui.Forms.TextBox();
                        this.label2 = new Lui.Forms.Label();
                        this.label3 = new Lui.Forms.Label();
                        this.EntradaLocalidad = new Lcc.Entrada.CodigoDetalle();
                        this.Label9 = new Lui.Forms.Label();
                        this.EntradaSituacionOrigen = new Lcc.Entrada.CodigoDetalle();
                        this.label4 = new Lui.Forms.Label();
                        this.EntradaCajaDiaria = new Lcc.Entrada.CodigoDetalle();
                        this.label5 = new Lui.Forms.Label();
                        this.EntradaCajaCheques = new Lcc.Entrada.CodigoDetalle();
                        this.label6 = new Lui.Forms.Label();
                        this.EntradaTelefono = new Lcc.Entrada.MatrizTelefonos();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(0, 0);
                        this.Label1.Margin = new System.Windows.Forms.Padding(0);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(96, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Nombre";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.FieldName = null;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaNombre.Location = new System.Drawing.Point(96, 0);
                        this.EntradaNombre.MaxLength = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.PlaceholderText = null;
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(544, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        // 
                        // EntradaDireccion
                        // 
                        this.EntradaDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDireccion.AutoNav = true;
                        this.EntradaDireccion.AutoTab = true;
                        this.EntradaDireccion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDireccion.DecimalPlaces = -1;
                        this.EntradaDireccion.FieldName = null;
                        this.EntradaDireccion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDireccion.Location = new System.Drawing.Point(96, 32);
                        this.EntradaDireccion.MaxLength = 32767;
                        this.EntradaDireccion.MultiLine = false;
                        this.EntradaDireccion.Name = "EntradaDireccion";
                        this.EntradaDireccion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDireccion.PasswordChar = '\0';
                        this.EntradaDireccion.PlaceholderText = null;
                        this.EntradaDireccion.Prefijo = "";
                        this.EntradaDireccion.ReadOnly = false;
                        this.EntradaDireccion.SelectOnFocus = false;
                        this.EntradaDireccion.Size = new System.Drawing.Size(544, 24);
                        this.EntradaDireccion.Sufijo = "";
                        this.EntradaDireccion.TabIndex = 3;
                        // 
                        // label2
                        // 
                        this.label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label2.Location = new System.Drawing.Point(0, 32);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(96, 24);
                        this.label2.TabIndex = 2;
                        this.label2.Text = "Dirección";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label3
                        // 
                        this.label3.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label3.Location = new System.Drawing.Point(0, 96);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(96, 24);
                        this.label3.TabIndex = 6;
                        this.label3.Text = "Teléfono";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaLocalidad
                        // 
                        this.EntradaLocalidad.AutoNav = true;
                        this.EntradaLocalidad.AutoTab = true;
                        this.EntradaLocalidad.CanCreate = true;
                        this.EntradaLocalidad.DataTextField = "nombre";
                        this.EntradaLocalidad.DataValueField = "id_ciudad";
                        this.EntradaLocalidad.ExtraDetailFields = "";
                        this.EntradaLocalidad.FieldName = null;
                        this.EntradaLocalidad.Filter = "id_provincia IS NOT NULL";
                        this.EntradaLocalidad.FreeTextCode = "";
                        this.EntradaLocalidad.Location = new System.Drawing.Point(96, 64);
                        this.EntradaLocalidad.MaxLength = 200;
                        this.EntradaLocalidad.Name = "EntradaLocalidad";
                        this.EntradaLocalidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLocalidad.PlaceholderText = null;
                        this.EntradaLocalidad.ReadOnly = false;
                        this.EntradaLocalidad.Required = true;
                        this.EntradaLocalidad.Size = new System.Drawing.Size(280, 24);
                        this.EntradaLocalidad.TabIndex = 5;
                        this.EntradaLocalidad.Table = "ciudades";
                        this.EntradaLocalidad.Text = "0";
                        this.EntradaLocalidad.TextDetail = "";
                        // 
                        // Label9
                        // 
                        this.Label9.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label9.Location = new System.Drawing.Point(0, 64);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(96, 24);
                        this.Label9.TabIndex = 4;
                        this.Label9.Text = "Localidad";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSituacionOrigen
                        // 
                        this.EntradaSituacionOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSituacionOrigen.AutoNav = true;
                        this.EntradaSituacionOrigen.AutoTab = true;
                        this.EntradaSituacionOrigen.CanCreate = true;
                        this.EntradaSituacionOrigen.DataTextField = "nombre";
                        this.EntradaSituacionOrigen.DataValueField = "id_situacion";
                        this.EntradaSituacionOrigen.ExtraDetailFields = "";
                        this.EntradaSituacionOrigen.FieldName = null;
                        this.EntradaSituacionOrigen.Filter = "";
                        this.EntradaSituacionOrigen.FreeTextCode = "";
                        this.EntradaSituacionOrigen.Location = new System.Drawing.Point(148, 240);
                        this.EntradaSituacionOrigen.MaxLength = 200;
                        this.EntradaSituacionOrigen.Name = "EntradaSituacionOrigen";
                        this.EntradaSituacionOrigen.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSituacionOrigen.PlaceholderText = null;
                        this.EntradaSituacionOrigen.ReadOnly = false;
                        this.EntradaSituacionOrigen.Required = true;
                        this.EntradaSituacionOrigen.Size = new System.Drawing.Size(280, 24);
                        this.EntradaSituacionOrigen.TabIndex = 9;
                        this.EntradaSituacionOrigen.Table = "articulos_situaciones";
                        this.EntradaSituacionOrigen.Text = "0";
                        this.EntradaSituacionOrigen.TextDetail = "";
                        // 
                        // label4
                        // 
                        this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.label4.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label4.Location = new System.Drawing.Point(44, 240);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(104, 24);
                        this.label4.TabIndex = 8;
                        this.label4.Text = "Depósito";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCajaDiaria
                        // 
                        this.EntradaCajaDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCajaDiaria.AutoNav = true;
                        this.EntradaCajaDiaria.AutoTab = true;
                        this.EntradaCajaDiaria.CanCreate = true;
                        this.EntradaCajaDiaria.DataTextField = "nombre";
                        this.EntradaCajaDiaria.DataValueField = "id_caja";
                        this.EntradaCajaDiaria.ExtraDetailFields = "";
                        this.EntradaCajaDiaria.FieldName = null;
                        this.EntradaCajaDiaria.Filter = "";
                        this.EntradaCajaDiaria.FreeTextCode = "";
                        this.EntradaCajaDiaria.Location = new System.Drawing.Point(148, 268);
                        this.EntradaCajaDiaria.MaxLength = 200;
                        this.EntradaCajaDiaria.Name = "EntradaCajaDiaria";
                        this.EntradaCajaDiaria.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCajaDiaria.PlaceholderText = null;
                        this.EntradaCajaDiaria.ReadOnly = false;
                        this.EntradaCajaDiaria.Required = true;
                        this.EntradaCajaDiaria.Size = new System.Drawing.Size(280, 24);
                        this.EntradaCajaDiaria.TabIndex = 11;
                        this.EntradaCajaDiaria.Table = "cajas";
                        this.EntradaCajaDiaria.Text = "0";
                        this.EntradaCajaDiaria.TextDetail = "";
                        // 
                        // label5
                        // 
                        this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.label5.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label5.Location = new System.Drawing.Point(44, 268);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(104, 24);
                        this.label5.TabIndex = 10;
                        this.label5.Text = "Caja Efectivo";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCajaCheques
                        // 
                        this.EntradaCajaCheques.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCajaCheques.AutoNav = true;
                        this.EntradaCajaCheques.AutoTab = true;
                        this.EntradaCajaCheques.CanCreate = true;
                        this.EntradaCajaCheques.DataTextField = "nombre";
                        this.EntradaCajaCheques.DataValueField = "id_caja";
                        this.EntradaCajaCheques.ExtraDetailFields = "";
                        this.EntradaCajaCheques.FieldName = null;
                        this.EntradaCajaCheques.Filter = "";
                        this.EntradaCajaCheques.FreeTextCode = "";
                        this.EntradaCajaCheques.Location = new System.Drawing.Point(148, 296);
                        this.EntradaCajaCheques.MaxLength = 200;
                        this.EntradaCajaCheques.Name = "EntradaCajaCheques";
                        this.EntradaCajaCheques.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCajaCheques.PlaceholderText = null;
                        this.EntradaCajaCheques.ReadOnly = false;
                        this.EntradaCajaCheques.Required = true;
                        this.EntradaCajaCheques.Size = new System.Drawing.Size(280, 24);
                        this.EntradaCajaCheques.TabIndex = 13;
                        this.EntradaCajaCheques.Table = "cajas";
                        this.EntradaCajaCheques.Text = "0";
                        this.EntradaCajaCheques.TextDetail = "";
                        // 
                        // label6
                        // 
                        this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.label6.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label6.Location = new System.Drawing.Point(44, 296);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(104, 24);
                        this.label6.TabIndex = 12;
                        this.label6.Text = "Caja Cheques";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTelefono
                        // 
                        this.EntradaTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTelefono.AutoNav = true;
                        this.EntradaTelefono.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.EntradaTelefono.FieldName = null;
                        this.EntradaTelefono.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaTelefono.Location = new System.Drawing.Point(96, 96);
                        this.EntradaTelefono.Name = "EntradaTelefono";
                        this.EntradaTelefono.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTelefono.ReadOnly = false;
                        this.EntradaTelefono.Size = new System.Drawing.Size(540, 132);
                        this.EntradaTelefono.TabIndex = 7;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaCajaCheques);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.EntradaCajaDiaria);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.EntradaSituacionOrigen);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaLocalidad);
                        this.Controls.Add(this.Label9);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.EntradaDireccion);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.EntradaTelefono);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 320);
                        this.Controls.SetChildIndex(this.EntradaTelefono, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.EntradaDireccion, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.Label9, 0);
                        this.Controls.SetChildIndex(this.EntradaLocalidad, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaSituacionOrigen, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.EntradaCajaDiaria, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.EntradaCajaCheques, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

		}

		#endregion

                private Lcc.Entrada.MatrizTelefonos EntradaTelefono;

        }
}
