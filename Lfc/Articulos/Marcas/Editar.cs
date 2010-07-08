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

namespace Lfc.Articulos.Marcas
{
	public class Editar :
	    Lui.Forms.EditForm
	{

		#region Código generado por el Diseñador de Windows Forms

		public Editar()
			:
		    base()
		{

			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent

		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if(disposing) {
				if(components != null) {
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
		internal Lui.Forms.DetailBox txtProveedor;
		internal System.Windows.Forms.Label Label14;
		internal Lui.Forms.TextBox txtURL;
		internal System.Windows.Forms.Label Label12;
		internal Lui.Forms.TextBox txtNombre;
		internal System.Windows.Forms.Label Label5;
		internal Lui.Forms.TextBox txtObs;
		internal System.Windows.Forms.Label Label13;

		private void InitializeComponent()
		{
			this.txtProveedor = new Lui.Forms.DetailBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.txtURL = new Lui.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.txtNombre = new Lui.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtObs = new Lui.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(340, 8);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Location = new System.Drawing.Point(448, 8);
			// 
			// txtProveedor
			// 
			this.txtProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtProveedor.AutoTab = true;
			this.txtProveedor.CanCreate = true;
			this.txtProveedor.DetailField = "nombre_visible";
			this.txtProveedor.ExtraDetailFields = null;
			this.txtProveedor.Filter = "(tipo&2)=2";
			this.txtProveedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtProveedor.FreeTextCode = "";
			this.txtProveedor.KeyField = "id_persona";
			this.txtProveedor.Location = new System.Drawing.Point(96, 76);
			this.txtProveedor.MaxLength = 200;
			this.txtProveedor.Name = "txtProveedor";
			this.txtProveedor.Padding = new System.Windows.Forms.Padding(2);
			this.txtProveedor.ReadOnly = false;
			this.txtProveedor.Required = false;
			this.txtProveedor.SelectOnFocus = false;
			this.txtProveedor.Size = new System.Drawing.Size(364, 24);
			this.txtProveedor.TabIndex = 5;
			this.txtProveedor.Table = "personas";
			this.txtProveedor.TeclaDespuesDeEnter = "{tab}";
			this.txtProveedor.Text = "0";
			this.txtProveedor.TextDetail = "";
			this.txtProveedor.TextInt = 0;
			this.txtProveedor.TipWhenBlank = "Sin especificar";
			this.txtProveedor.ToolTipText = "";
			// 
			// Label14
			// 
			this.Label14.Location = new System.Drawing.Point(8, 76);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(88, 24);
			this.Label14.TabIndex = 4;
			this.Label14.Text = "Proveedor";
			this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtURL
			// 
			this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtURL.AutoNav = true;
			this.txtURL.AutoTab = true;
			this.txtURL.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtURL.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtURL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtURL.Location = new System.Drawing.Point(96, 44);
			this.txtURL.MaxLenght = 32767;
			this.txtURL.Name = "txtURL";
			this.txtURL.Padding = new System.Windows.Forms.Padding(2);
			this.txtURL.ReadOnly = false;
			this.txtURL.SelectOnFocus = false;
			this.txtURL.Size = new System.Drawing.Size(444, 24);
			this.txtURL.TabIndex = 3;
			this.txtURL.TipWhenBlank = "";
			this.txtURL.ToolTipText = "Dirección de la página web del producto.";
			// 
			// Label12
			// 
			this.Label12.Location = new System.Drawing.Point(8, 44);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(88, 24);
			this.Label12.TabIndex = 2;
			this.Label12.Text = "URL";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.AutoNav = true;
			this.txtNombre.AutoTab = true;
			this.txtNombre.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtNombre.Location = new System.Drawing.Point(96, 12);
			this.txtNombre.MaxLenght = 32767;
			this.txtNombre.MultiLine = false;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Padding = new System.Windows.Forms.Padding(2);
			this.txtNombre.ReadOnly = false;
			this.txtNombre.SelectOnFocus = false;
			this.txtNombre.Size = new System.Drawing.Size(444, 24);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.TipWhenBlank = "";
			this.txtNombre.ToolTipText = "";
			// 
			// Label5
			// 
			this.Label5.Location = new System.Drawing.Point(8, 12);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(88, 24);
			this.Label5.TabIndex = 0;
			this.Label5.Text = "Nombre";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtObs
			// 
			this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtObs.AutoNav = true;
			this.txtObs.AutoTab = true;
			this.txtObs.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObs.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtObs.Location = new System.Drawing.Point(96, 108);
			this.txtObs.MaxLenght = 32767;
			this.txtObs.MultiLine = true;
			this.txtObs.Name = "txtObs";
			this.txtObs.Padding = new System.Windows.Forms.Padding(2);
			this.txtObs.ReadOnly = false;
			this.txtObs.SelectOnFocus = false;
			this.txtObs.Size = new System.Drawing.Size(444, 72);
			this.txtObs.TabIndex = 7;
			this.txtObs.TipWhenBlank = "";
			this.txtObs.ToolTipText = "";
			// 
			// Label13
			// 
			this.Label13.Location = new System.Drawing.Point(8, 108);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(88, 24);
			this.Label13.TabIndex = 6;
			this.Label13.Text = "Obs.";
			this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Editar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(556, 297);
			this.Controls.Add(this.txtObs);
			this.Controls.Add(this.Label13);
			this.Controls.Add(this.txtProveedor);
			this.Controls.Add(this.Label14);
			this.Controls.Add(this.txtURL);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.Label5);
			this.Name = "Editar";
			this.ResumeLayout(false);

		}

		#endregion

		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row Registro = this.DataBase.Row("marcas", "id_marca", lId);

			if(Registro == null) {
				ResultadoEditar.Success = false;
				ResultadoEditar.Message = "El registro no existe";
			} else {
				txtNombre.Text = System.Convert.ToString(Registro["nombre"]);
				txtURL.Text = System.Convert.ToString(Registro["url"]);
				txtProveedor.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_proveedor"]);

				txtObs.Text = System.Convert.ToString(Registro["obs"]);

				m_Id = lId;
				m_Nuevo = false;

				this.Text = "Marcas: " + txtNombre.Text;
				ResultadoEditar.Success = true;
			}

			return ResultadoEditar;
		}

		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = new Lfx.Types.SuccessOperationResult();

			ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true) {
				Lbl.Articulos.Marca Mar = new Lbl.Articulos.Marca(DataBase, m_Id);

				Mar.Nombre = txtNombre.Text;
				Mar.Url = txtURL.Text;
				if(txtProveedor.TextInt > 0)
					Mar.Proveedor = new Lbl.Personas.Persona(DataBase, txtProveedor.TextInt);
				else
					Mar.Proveedor = null;
				Mar.Obs = txtObs.Text;
				Mar.Estado = 1;
				Mar.Guardar();
				
				m_Id = Mar.Id;

				if(m_Nuevo && ControlDestino != null) {
					ControlDestino.Text = m_Id.ToString();
					ControlDestino.Focus();
				}

				m_Nuevo = false;
				return base.Save();
			} else {
				return ResultadoGuardar;
			}
		}
	}
}