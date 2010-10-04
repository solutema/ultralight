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
using System.Collections.Generic;
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
		internal Lcc.Entrada.CodigoDetalle EntradaCiudad;
		internal System.Windows.Forms.Label Label9;
		internal Lui.Forms.TextBox EntradaDireccion;
		internal Lui.Forms.TextBox EntradaTelefono;
		internal Lcc.Entrada.CodigoDetalle EntradaSituacionOrigen;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label6;
		internal Lcc.Entrada.CodigoDetalle EntradaCajaDiaria;
		internal Lcc.Entrada.CodigoDetalle EntradaCajaCheques;
		internal Lui.Forms.TextBox EntradaNombre;

		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.EntradaNombre = new Lui.Forms.TextBox();
			this.EntradaDireccion = new Lui.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.EntradaTelefono = new Lui.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.EntradaCiudad = new Lcc.Entrada.CodigoDetalle();
			this.Label9 = new System.Windows.Forms.Label();
			this.EntradaSituacionOrigen = new Lcc.Entrada.CodigoDetalle();
			this.label4 = new System.Windows.Forms.Label();
			this.EntradaCajaDiaria = new Lcc.Entrada.CodigoDetalle();
			this.label5 = new System.Windows.Forms.Label();
			this.EntradaCajaCheques = new Lcc.Entrada.CodigoDetalle();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.EntradaNombre.AutoNav = true;
			this.EntradaNombre.AutoTab = true;
			this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
			this.EntradaNombre.DockPadding.All = 2;
			this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaNombre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaNombre.Location = new System.Drawing.Point(112, 16);
			this.EntradaNombre.MaxLenght = 32767;
			this.EntradaNombre.Name = "txtNombre";
			this.EntradaNombre.ReadOnly = false;
			this.EntradaNombre.SelectOnFocus = false;
			this.EntradaNombre.Size = new System.Drawing.Size(464, 24);
			this.EntradaNombre.TabIndex = 1;
			this.EntradaNombre.ToolTipText = "";
			// 
			// txtDireccion
			// 
			this.EntradaDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.EntradaDireccion.AutoNav = true;
			this.EntradaDireccion.AutoTab = true;
			this.EntradaDireccion.DataType = Lui.Forms.DataTypes.FreeText;
			this.EntradaDireccion.DockPadding.All = 2;
			this.EntradaDireccion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaDireccion.Location = new System.Drawing.Point(112, 48);
			this.EntradaDireccion.MaxLenght = 32767;
			this.EntradaDireccion.Name = "txtDireccion";
			this.EntradaDireccion.ReadOnly = false;
			this.EntradaDireccion.SelectOnFocus = false;
			this.EntradaDireccion.Size = new System.Drawing.Size(464, 24);
			this.EntradaDireccion.TabIndex = 3;
			this.EntradaDireccion.ToolTipText = "";
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
			this.EntradaTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.EntradaTelefono.AutoNav = true;
			this.EntradaTelefono.AutoTab = true;
			this.EntradaTelefono.DataType = Lui.Forms.DataTypes.FreeText;
			this.EntradaTelefono.DockPadding.All = 2;
			this.EntradaTelefono.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaTelefono.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaTelefono.Location = new System.Drawing.Point(112, 80);
			this.EntradaTelefono.MaxLenght = 32767;
			this.EntradaTelefono.Name = "txtTelefono";
			this.EntradaTelefono.ReadOnly = false;
			this.EntradaTelefono.SelectOnFocus = false;
			this.EntradaTelefono.Size = new System.Drawing.Size(332, 24);
			this.EntradaTelefono.TabIndex = 5;
			this.EntradaTelefono.ToolTipText = "";
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
			this.EntradaCiudad.AutoTab = true;
			this.EntradaCiudad.CanCreate = true;
			this.EntradaCiudad.DetailField = "nombre";
			this.EntradaCiudad.DockPadding.All = 2;
			this.EntradaCiudad.ExtraDetailFields = null;
			this.EntradaCiudad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaCiudad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaCiudad.FreeTextCode = "";
			this.EntradaCiudad.KeyField = "id_ciudad";
			this.EntradaCiudad.Location = new System.Drawing.Point(112, 112);
			this.EntradaCiudad.MaxLength = 200;
			this.EntradaCiudad.Name = "txtCiudad";
			this.EntradaCiudad.ReadOnly = false;
			this.EntradaCiudad.Required = true;
			this.EntradaCiudad.Size = new System.Drawing.Size(280, 24);
			this.EntradaCiudad.TabIndex = 7;
			this.EntradaCiudad.Table = "ciudades";
			this.EntradaCiudad.TeclaDespuesDeEnter = "{tab}";
			this.EntradaCiudad.Text = "0";
			this.EntradaCiudad.TextDetail = "";
			this.EntradaCiudad.ToolTipText = "";
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
			this.EntradaSituacionOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EntradaSituacionOrigen.AutoTab = true;
			this.EntradaSituacionOrigen.CanCreate = true;
			this.EntradaSituacionOrigen.DetailField = "nombre";
			this.EntradaSituacionOrigen.DockPadding.All = 2;
			this.EntradaSituacionOrigen.ExtraDetailFields = null;
			this.EntradaSituacionOrigen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaSituacionOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaSituacionOrigen.FreeTextCode = "";
			this.EntradaSituacionOrigen.KeyField = "id_situacion";
			this.EntradaSituacionOrigen.Location = new System.Drawing.Point(228, 148);
			this.EntradaSituacionOrigen.MaxLength = 200;
			this.EntradaSituacionOrigen.Name = "txtSituacionOrigen";
			this.EntradaSituacionOrigen.ReadOnly = false;
			this.EntradaSituacionOrigen.Required = true;
			this.EntradaSituacionOrigen.Size = new System.Drawing.Size(280, 24);
			this.EntradaSituacionOrigen.TabIndex = 9;
			this.EntradaSituacionOrigen.Table = "articulos_situaciones";
			this.EntradaSituacionOrigen.TeclaDespuesDeEnter = "{tab}";
			this.EntradaSituacionOrigen.Text = "0";
			this.EntradaSituacionOrigen.TextDetail = "";
			this.EntradaSituacionOrigen.ToolTipText = "";
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
			this.Controls.Add(this.EntradaSituacionOrigen);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.EntradaCiudad);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.EntradaTelefono);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.EntradaDireccion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.EntradaNombre);
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
				EntradaNombre.Text = System.Convert.ToString(row["nombre"]);
				EntradaDireccion.Text = System.Convert.ToString(row["direccion"]);
				EntradaTelefono.Text = System.Convert.ToString(row["telefono"]);
				EntradaCiudad.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_ciudad"]);
				EntradaSituacionOrigen.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["situacionorigen"]);
				EntradaCajaDiaria.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_caja_diaria"]);
				EntradaCajaCheques.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_caja_cheques"]);

				m_Id = lId;
				m_Nuevo = false;

				this.Text = "Sucursales: " + EntradaNombre.Text;
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

				Comando.Fields.AddWithValue("nombre", EntradaNombre.Text);
				Comando.Fields.AddWithValue("direccion", EntradaDireccion.Text);
				Comando.Fields.AddWithValue("telefono", EntradaTelefono.Text);
				Comando.Fields.AddWithValue("id_ciudad", EntradaCiudad.TextInt);
				Comando.Fields.AddWithValue("situacionorigen", Lfx.Data.DataBase.ConvertZeroToDBNull(EntradaSituacionOrigen.TextInt));
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