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

namespace Lfc.Sucursales
{
	public class Editar : Lui.Forms.EditForm
	{

		#region 'Windows Form Designer generated code'

		public Editar()
			: base()
		{


			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call

		}

		// Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;

		// NOTE: The following procedure is required by the Windows Form Designer
		// It can be modified using the Windows Form Designer.  
		// Do not modify it using the code editor.
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Label label3;
		internal Lui.Forms.DetailBox txtCiudad;
		internal System.Windows.Forms.Label Label9;
		internal Lui.Forms.TextBox txtDireccion;
		internal Lui.Forms.TextBox txtTelefono;
		internal Lui.Forms.DetailBox txtSituacionOrigen;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label6;
		internal Lui.Forms.DetailBox EntradaCajaDiaria;
		internal Lui.Forms.DetailBox EntradaCajaCheques;
		internal Lui.Forms.TextBox txtNombre;

		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.txtNombre = new Lui.Forms.TextBox();
			this.txtDireccion = new Lui.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTelefono = new Lui.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCiudad = new Lui.Forms.DetailBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtSituacionOrigen = new Lui.Forms.DetailBox();
			this.label4 = new System.Windows.Forms.Label();
			this.EntradaCajaDiaria = new Lui.Forms.DetailBox();
			this.label5 = new System.Windows.Forms.Label();
			this.EntradaCajaCheques = new Lui.Forms.DetailBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.DockPadding.All = 2;
			this.SaveButton.Name = "SaveButton";
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.DockPadding.All = 2;
			this.CancelCommandButton.Name = "CancelCommandButton";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Nombre";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.AutoNav = true;
			this.txtNombre.AutoTab = true;
			this.txtNombre.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtNombre.DockPadding.All = 2;
			this.txtNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtNombre.Location = new System.Drawing.Point(112, 16);
			this.txtNombre.MaxLenght = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.ReadOnly = false;
			this.txtNombre.SelectOnFocus = false;
			this.txtNombre.Size = new System.Drawing.Size(464, 24);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.ToolTipText = "";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDireccion.AutoNav = true;
			this.txtDireccion.AutoTab = true;
			this.txtDireccion.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtDireccion.DockPadding.All = 2;
			this.txtDireccion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtDireccion.Location = new System.Drawing.Point(112, 48);
			this.txtDireccion.MaxLenght = 32767;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.ReadOnly = false;
			this.txtDireccion.SelectOnFocus = false;
			this.txtDireccion.Size = new System.Drawing.Size(464, 24);
			this.txtDireccion.TabIndex = 3;
			this.txtDireccion.ToolTipText = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Dirección";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelefono.AutoNav = true;
			this.txtTelefono.AutoTab = true;
			this.txtTelefono.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtTelefono.DockPadding.All = 2;
			this.txtTelefono.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTelefono.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtTelefono.Location = new System.Drawing.Point(112, 80);
			this.txtTelefono.MaxLenght = 32767;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.ReadOnly = false;
			this.txtTelefono.SelectOnFocus = false;
			this.txtTelefono.Size = new System.Drawing.Size(332, 24);
			this.txtTelefono.TabIndex = 5;
			this.txtTelefono.ToolTipText = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Teléfono";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCiudad
			// 
			this.txtCiudad.AutoTab = true;
			this.txtCiudad.CanCreate = true;
			this.txtCiudad.DetailField = "nombre";
			this.txtCiudad.DockPadding.All = 2;
			this.txtCiudad.ExtraDetailFields = null;
			this.txtCiudad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCiudad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCiudad.FreeTextCode = "";
			this.txtCiudad.KeyField = "id_ciudad";
			this.txtCiudad.Location = new System.Drawing.Point(112, 112);
			this.txtCiudad.MaxLength = 200;
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.ReadOnly = false;
			this.txtCiudad.Required = true;
			this.txtCiudad.Size = new System.Drawing.Size(280, 24);
			this.txtCiudad.TabIndex = 7;
			this.txtCiudad.Table = "ciudades";
			this.txtCiudad.TeclaDespuesDeEnter = "{tab}";
			this.txtCiudad.Text = "0";
			this.txtCiudad.TextDetail = "";
			this.txtCiudad.TextInt = 0;
			this.txtCiudad.ToolTipText = "";
			// 
			// Label9
			// 
			this.Label9.Location = new System.Drawing.Point(16, 112);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(96, 24);
			this.Label9.TabIndex = 6;
			this.Label9.Text = "Ciudad";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSituacionOrigen
			// 
			this.txtSituacionOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSituacionOrigen.AutoTab = true;
			this.txtSituacionOrigen.CanCreate = true;
			this.txtSituacionOrigen.DetailField = "nombre";
			this.txtSituacionOrigen.DockPadding.All = 2;
			this.txtSituacionOrigen.ExtraDetailFields = null;
			this.txtSituacionOrigen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSituacionOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtSituacionOrigen.FreeTextCode = "";
			this.txtSituacionOrigen.KeyField = "id_situacion";
			this.txtSituacionOrigen.Location = new System.Drawing.Point(228, 148);
			this.txtSituacionOrigen.MaxLength = 200;
			this.txtSituacionOrigen.Name = "txtSituacionOrigen";
			this.txtSituacionOrigen.ReadOnly = false;
			this.txtSituacionOrigen.Required = true;
			this.txtSituacionOrigen.Size = new System.Drawing.Size(280, 24);
			this.txtSituacionOrigen.TabIndex = 9;
			this.txtSituacionOrigen.Table = "articulos_situaciones";
			this.txtSituacionOrigen.TeclaDespuesDeEnter = "{tab}";
			this.txtSituacionOrigen.Text = "0";
			this.txtSituacionOrigen.TextDetail = "";
			this.txtSituacionOrigen.TextInt = 0;
			this.txtSituacionOrigen.ToolTipText = "";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(124, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "Depósito";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
                        // EntradaCajaDiaria
			// 
			this.EntradaCajaDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EntradaCajaDiaria.AutoTab = true;
			this.EntradaCajaDiaria.CanCreate = true;
			this.EntradaCajaDiaria.DetailField = "nombre";
			this.EntradaCajaDiaria.DockPadding.All = 2;
			this.EntradaCajaDiaria.ExtraDetailFields = null;
			this.EntradaCajaDiaria.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaCajaDiaria.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaCajaDiaria.FreeTextCode = "";
			this.EntradaCajaDiaria.KeyField = "id_caja";
			this.EntradaCajaDiaria.Location = new System.Drawing.Point(228, 176);
			this.EntradaCajaDiaria.MaxLength = 200;
                        this.EntradaCajaDiaria.Name = "EntradaCajaDiaria";
			this.EntradaCajaDiaria.ReadOnly = false;
			this.EntradaCajaDiaria.Required = true;
			this.EntradaCajaDiaria.Size = new System.Drawing.Size(280, 24);
			this.EntradaCajaDiaria.TabIndex = 11;
			this.EntradaCajaDiaria.Table = "cajas";
			this.EntradaCajaDiaria.TeclaDespuesDeEnter = "{tab}";
			this.EntradaCajaDiaria.Text = "0";
			this.EntradaCajaDiaria.TextDetail = "";
			this.EntradaCajaDiaria.TextInt = 0;
			this.EntradaCajaDiaria.ToolTipText = "";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(124, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 24);
			this.label5.TabIndex = 10;
			this.label5.Text = "Caja Diaria";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
                        // EntradaCajaCheques
			// 
			this.EntradaCajaCheques.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EntradaCajaCheques.AutoTab = true;
			this.EntradaCajaCheques.CanCreate = true;
			this.EntradaCajaCheques.DetailField = "nombre";
			this.EntradaCajaCheques.DockPadding.All = 2;
			this.EntradaCajaCheques.ExtraDetailFields = null;
			this.EntradaCajaCheques.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaCajaCheques.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaCajaCheques.FreeTextCode = "";
			this.EntradaCajaCheques.KeyField = "id_caja";
			this.EntradaCajaCheques.Location = new System.Drawing.Point(228, 204);
			this.EntradaCajaCheques.MaxLength = 200;
                        this.EntradaCajaCheques.Name = "EntradaCajaCheques";
			this.EntradaCajaCheques.ReadOnly = false;
			this.EntradaCajaCheques.Required = true;
			this.EntradaCajaCheques.Size = new System.Drawing.Size(280, 24);
			this.EntradaCajaCheques.TabIndex = 13;
			this.EntradaCajaCheques.Table = "cajas";
			this.EntradaCajaCheques.TeclaDespuesDeEnter = "{tab}";
			this.EntradaCajaCheques.Text = "0";
			this.EntradaCajaCheques.TextDetail = "";
			this.EntradaCajaCheques.TextInt = 0;
			this.EntradaCajaCheques.ToolTipText = "";

			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(124, 204);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "Caja Cheques";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormSucursalesEditar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(592, 373);
			this.Controls.Add(this.EntradaCajaCheques);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.EntradaCajaDiaria);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtSituacionOrigen);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCiudad);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.Label1);
			this.Name = "FormSucursalesEditar";
			this.Text = "Editar: Sucursales";
			this.ResumeLayout(false);

		}


		#endregion

		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row row = this.DataBase.Row("sucursales", "id_sucursal", lId);

			if(row == null) {
				ResultadoEditar.Success = false;
				ResultadoEditar.Message = "El registro no existe";
			} else {
				txtNombre.Text = System.Convert.ToString(row["nombre"]);
				txtDireccion.Text = System.Convert.ToString(row["direccion"]);
				txtTelefono.Text = System.Convert.ToString(row["telefono"]);
				txtCiudad.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_ciudad"]);
				txtSituacionOrigen.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["situacionorigen"]);
				EntradaCajaDiaria.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_caja_diaria"]);
				EntradaCajaCheques.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_caja_cheques"]);

				m_Id = lId;
				m_Nuevo = false;

				this.Text = "Sucursales: " + txtNombre.Text;
				ResultadoEditar.Success = true;
			}

			return ResultadoEditar;
		}


		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true) {
                                this.DataBase.BeginTransaction();

                                qGen.TableCommand Comando;
                                if (m_Nuevo) {
                                        Comando = new qGen.Insert(DataBase, "sucursales");
                                        Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                } else {
                                        Comando = new qGen.Update(DataBase, "sucursales");
                                        Comando.WhereClause = new qGen.Where("id_sucursal", m_Id);
                                }

				Comando.Fields.AddWithValue("nombre", txtNombre.Text);
				Comando.Fields.AddWithValue("direccion", txtDireccion.Text);
				Comando.Fields.AddWithValue("telefono", txtTelefono.Text);
				Comando.Fields.AddWithValue("id_ciudad", txtCiudad.TextInt);
				Comando.Fields.AddWithValue("situacionorigen", Lfx.Data.DataBase.ConvertZeroToDBNull(txtSituacionOrigen.TextInt));
				Comando.Fields.AddWithValue("id_caja_diaria", Lfx.Data.DataBase.ConvertZeroToDBNull(EntradaCajaDiaria.TextInt));
				Comando.Fields.AddWithValue("id_caja_cheques", Lfx.Data.DataBase.ConvertZeroToDBNull(EntradaCajaCheques.TextInt));

                                this.DataBase.Execute(Comando);
                                this.DataBase.Commit();

				if(m_Nuevo) {
                                        m_Id = DataBase.FieldInt("SELECT LAST_INSERT_ID()");
					m_Nuevo = false;
					if(ControlDestino != null) {
						ControlDestino.Text = m_Id.ToString();
						ControlDestino.Focus();
					}
				}

				ResultadoGuardar = base.Save();
			}

			return ResultadoGuardar;
		}
	}
}