// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cuentas.Conceptos
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal Lui.Forms.TextBox txtNombre;
                internal Lui.Forms.ComboBox txtDireccion;
		internal System.Windows.Forms.Label label4;
		internal Lui.Forms.TextBox txtCodigo;
                internal Lui.Forms.ComboBox txtTipo;

		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtNombre = new Lui.Forms.TextBox();
                        this.txtDireccion = new Lui.Forms.ComboBox();
                        this.txtTipo = new Lui.Forms.ComboBox();
			this.txtCodigo = new Lui.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.DockPadding.All = 2;
			this.SaveButton.Location = new System.Drawing.Point(344, 8);
			this.SaveButton.Name = "SaveButton";
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.DockPadding.All = 2;
			this.CancelCommandButton.Location = new System.Drawing.Point(452, 8);
			this.CancelCommandButton.Name = "CancelCommandButton";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(16, 48);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(84, 24);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Nombre";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(16, 80);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(84, 24);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Dirección";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(16, 112);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(84, 24);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Tipo";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.txtNombre.Location = new System.Drawing.Point(100, 48);
			this.txtNombre.MaxLenght = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.ReadOnly = false;
			this.txtNombre.SelectOnFocus = false;
			this.txtNombre.Size = new System.Drawing.Size(440, 24);
			this.txtNombre.TabIndex = 5;
			this.txtNombre.ToolTipText = "";
			// 
			// txtDireccion
			// 
			this.txtDireccion.AutoNav = true;
			this.txtDireccion.AutoTab = true;
			this.txtDireccion.DockPadding.All = 2;
			this.txtDireccion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtDireccion.Location = new System.Drawing.Point(100, 80);
			this.txtDireccion.MaxLenght = 32767;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.ReadOnly = false;
			this.txtDireccion.SetData = new string[] {
														 "Ambas|0",
														 "Entrada|1",
														 "Salida|2"};
			this.txtDireccion.Size = new System.Drawing.Size(180, 24);
			this.txtDireccion.TabIndex = 7;
			this.txtDireccion.Text = "Ambas";
			this.txtDireccion.TextKey = "0";
			this.txtDireccion.ToolTipText = "";
			// 
			// txtTipo
			// 
			this.txtTipo.AutoNav = true;
			this.txtTipo.AutoTab = true;
			this.txtTipo.DockPadding.All = 2;
			this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTipo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtTipo.Location = new System.Drawing.Point(100, 112);
			this.txtTipo.MaxLenght = 32767;
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.ReadOnly = false;
			this.txtTipo.SetData = new string[] {
													"Ninguno|0",
													"Cobros|110",
													"Otros ingresos|100",
													"Gastos fijos|230",
													"Gastos variables|240",
													"Otros gastos|200",
													"Pérdida|260",
													"Reinversión|250",
													"Costo materiales|210",
													"Costo capital|220",
													"Sueldos y salarios|231",
													"Movimientos y ajustes|300"};
			this.txtTipo.Size = new System.Drawing.Size(284, 24);
			this.txtTipo.TabIndex = 9;
			this.txtTipo.Text = "Otros gastos";
			this.txtTipo.TextKey = "200";
			this.txtTipo.ToolTipText = "";
			// 
			// txtCodigo
			// 
			this.txtCodigo.AutoNav = true;
			this.txtCodigo.AutoTab = true;
			this.txtCodigo.DataType = Lui.Forms.DataTypes.Integer;
			this.txtCodigo.DockPadding.All = 2;
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCodigo.Location = new System.Drawing.Point(100, 16);
			this.txtCodigo.MaxLenght = 32767;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = false;
			this.txtCodigo.Size = new System.Drawing.Size(76, 24);
			this.txtCodigo.TabIndex = 3;
			this.txtCodigo.Text = "0";
			this.txtCodigo.ToolTipText = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "Código";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormCuentaConceptosEditar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(560, 277);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTipo);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Name = "FormCuentaConceptosEditar";
			this.Text = "Editar: Conceptos";
			this.Controls.SetChildIndex(this.Label1, 0);
			this.Controls.SetChildIndex(this.Label2, 0);
			this.Controls.SetChildIndex(this.Label3, 0);
			this.Controls.SetChildIndex(this.txtNombre, 0);
			this.Controls.SetChildIndex(this.txtDireccion, 0);
			this.Controls.SetChildIndex(this.txtTipo, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.txtCodigo, 0);
			this.ResumeLayout(false);

		}


		#endregion

		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("cuentas_conceptos", "id_concepto", lId);

			if(Registro == null) {
				ResultadoEditar.Success = false;
				ResultadoEditar.Message = "El registro no existe";
			} else if(System.Convert.ToInt32(Registro["fijo"]) != 0) {
				ResultadoEditar.Success = false;
				ResultadoEditar.Message = "El registro no puede ser modificado";
			} else {
				txtCodigo.Text = System.Convert.ToString(Registro["id_concepto"]);
				txtNombre.Text = System.Convert.ToString(Registro["nombre"]);
				txtDireccion.TextKey = System.Convert.ToString(Registro["es"]);
				txtTipo.TextKey = Lfx.Data.DataBase.ConvertDBNullToZero(Registro["grupo"]).ToString();

				m_Id = lId;
				m_Nuevo = false;

				this.Text = "Conceptos: " + txtNombre.Text;
				ResultadoEditar.Success = true;
			}
			return ResultadoEditar;
		}

		public override Lfx.Types.OperationResult ValidateData()
		{
			if(txtNombre.Text.Length < 2)
				return new Lfx.Types.FailureOperationResult("Escriba un nombre para el concepto");
			return new Lfx.Types.SuccessOperationResult();
		}

		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true) {
				if(m_Nuevo && Lfx.Types.Parsing.ParseInt(txtCodigo.Text) == 0) {
					this.txtCodigo.Text = this.Workspace.DefaultDataBase.FieldInt("SELECT MAX(id_concepto)+1 FROM cuentas_conceptos WHERE id_concepto<10000").ToString();
					if(Lfx.Types.Parsing.ParseInt(this.txtCodigo.Text) == 0)
						this.txtCodigo.Text = "1";
				}

                                DataView.DataBase.BeginTransaction();

                                Lfx.Data.SqlTableCommandBuilder Comando;
                                if (m_Nuevo) {
                                        Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "cuentas_conceptos");
                                } else {
                                        Comando = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "cuentas_conceptos");
                                	Comando.WhereClause = new Lfx.Data.SqlWhereBuilder("id_concepto=" + m_Id.ToString());        
                                }

				Comando.Fields.AddWithValue("id_concepto", Lfx.Types.Parsing.ParseInt(txtCodigo.Text));
				Comando.Fields.AddWithValue("nombre", txtNombre.Text);
				Comando.Fields.AddWithValue("es", Lfx.Types.Parsing.ParseInt(txtDireccion.TextKey));
				Comando.Fields.AddWithValue("grupo", Lfx.Data.DataBase.ConvertZeroToDBNull(Lfx.Types.Parsing.ParseInt(txtTipo.TextKey)));

                                DataView.DataBase.Execute(Comando);
                                DataView.DataBase.Commit();

				m_Id = Lfx.Types.Parsing.ParseInt(txtCodigo.Text);

				if(m_Nuevo && ControlDestino != null) {
					ControlDestino.Text = m_Id.ToString();
					ControlDestino.Focus();
				}
				m_Nuevo = false;

				ResultadoGuardar = base.Save();
			}
			return ResultadoGuardar;
		}
	}
}