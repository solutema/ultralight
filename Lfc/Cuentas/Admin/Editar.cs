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

namespace Lfc.Cuentas.Admin
{
	public class Editar : Lui.Forms.EditForm
	{

		private bool CustomName;

		#region Código generado por el Diseñador de Windows Forms

		public Editar()
			: base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
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
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label1;
		internal Lui.Forms.TextBox txtNumero;
		internal Lui.Forms.DetailBox txtBanco;
		internal System.Windows.Forms.Label Label7;
		internal Lui.Forms.TextBox txtNombre;
		internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox txtTipo;
		internal System.Windows.Forms.Label Label4;
		internal Lui.Forms.TextBox txtCBU;
		internal System.Windows.Forms.Label label5;
		internal Lui.Forms.TextBox txtTitular;
		internal Label label6;
                internal Lui.Forms.ComboBox txtEstado;
                internal Label label8;
		internal Lui.Forms.DetailBox txtMoneda;

		private void InitializeComponent()
		{
                        this.txtNumero = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtBanco = new Lui.Forms.DetailBox();
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.txtNombre = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtMoneda = new Lui.Forms.DetailBox();
                        this.txtCBU = new Lui.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.txtTitular = new Lui.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.txtEstado = new Lui.Forms.ComboBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(344, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(452, 8);
                        // 
                        // txtNumero
                        // 
                        this.txtNumero.AutoNav = true;
                        this.txtNumero.AutoTab = true;
                        this.txtNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtNumero.Location = new System.Drawing.Point(144, 148);
                        this.txtNumero.MaxLenght = 32767;
                        this.txtNumero.Name = "txtNumero";
                        this.txtNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.txtNumero.ReadOnly = false;
                        this.txtNumero.Size = new System.Drawing.Size(228, 24);
                        this.txtNumero.TabIndex = 9;
                        this.txtNumero.TipWhenBlank = "";
                        this.txtNumero.ToolTipText = "";
                        this.txtNumero.TextChanged += new System.EventHandler(this.NumeroBanco_TextChanged);
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(20, 148);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(120, 24);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "Número";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 116);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(120, 24);
                        this.Label1.TabIndex = 6;
                        this.Label1.Text = "Banco";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtBanco
                        // 
                        this.txtBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtBanco.AutoTab = true;
                        this.txtBanco.CanCreate = true;
                        this.txtBanco.DetailField = "nombre";
                        this.txtBanco.ExtraDetailFields = null;
                        this.txtBanco.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtBanco.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtBanco.FreeTextCode = "";
                        this.txtBanco.KeyField = "id_banco";
                        this.txtBanco.Location = new System.Drawing.Point(144, 116);
                        this.txtBanco.MaxLength = 200;
                        this.txtBanco.Name = "txtBanco";
                        this.txtBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.txtBanco.ReadOnly = false;
                        this.txtBanco.Required = false;
                        this.txtBanco.SelectOnFocus = false;
                        this.txtBanco.Size = new System.Drawing.Size(396, 24);
                        this.txtBanco.TabIndex = 7;
                        this.txtBanco.Table = "bancos";
                        this.txtBanco.TeclaDespuesDeEnter = "{tab}";
                        this.txtBanco.Text = "0";
                        this.txtBanco.TextDetail = "";
                        this.txtBanco.TextInt = 0;
                        this.txtBanco.TipWhenBlank = "";
                        this.txtBanco.ToolTipText = "";
                        this.txtBanco.TextChanged += new System.EventHandler(this.NumeroBanco_TextChanged);
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTipo.Location = new System.Drawing.Point(144, 84);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "Efectivo|0",
        "Caja de Ahorro|1",
        "Cuenta Corriente|2"};
                        this.txtTipo.Size = new System.Drawing.Size(168, 24);
                        this.txtTipo.TabIndex = 5;
                        this.txtTipo.Text = "Caja de Ahorro";
                        this.txtTipo.TextKey = "1";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "¿El producto usa control de stock?";
                        this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(20, 84);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(120, 24);
                        this.Label7.TabIndex = 4;
                        this.Label7.Text = "Tipo de Cuenta";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtNombre
                        // 
                        this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtNombre.AutoNav = true;
                        this.txtNombre.AutoTab = true;
                        this.txtNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtNombre.Location = new System.Drawing.Point(144, 20);
                        this.txtNombre.MaxLenght = 32767;
                        this.txtNombre.Name = "txtNombre";
                        this.txtNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.txtNombre.ReadOnly = false;
                        this.txtNombre.SelectOnFocus = false;
                        this.txtNombre.Size = new System.Drawing.Size(396, 24);
                        this.txtNombre.TabIndex = 1;
                        this.txtNombre.TipWhenBlank = "";
                        this.txtNombre.ToolTipText = "";
                        this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(20, 20);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(120, 24);
                        this.Label2.TabIndex = 0;
                        this.Label2.Text = "Nombre";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(20, 180);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(120, 24);
                        this.Label4.TabIndex = 10;
                        this.Label4.Text = "Moneda";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtMoneda
                        // 
                        this.txtMoneda.AutoTab = true;
                        this.txtMoneda.CanCreate = true;
                        this.txtMoneda.DetailField = "nombre";
                        this.txtMoneda.ExtraDetailFields = null;
                        this.txtMoneda.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtMoneda.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtMoneda.FreeTextCode = "";
                        this.txtMoneda.KeyField = "id_moneda";
                        this.txtMoneda.Location = new System.Drawing.Point(144, 180);
                        this.txtMoneda.MaxLength = 200;
                        this.txtMoneda.Name = "txtMoneda";
                        this.txtMoneda.Padding = new System.Windows.Forms.Padding(2);
                        this.txtMoneda.ReadOnly = false;
                        this.txtMoneda.Required = false;
                        this.txtMoneda.SelectOnFocus = false;
                        this.txtMoneda.Size = new System.Drawing.Size(228, 24);
                        this.txtMoneda.TabIndex = 11;
                        this.txtMoneda.Table = "monedas";
                        this.txtMoneda.TeclaDespuesDeEnter = "{tab}";
                        this.txtMoneda.Text = "0";
                        this.txtMoneda.TextDetail = "";
                        this.txtMoneda.TextInt = 0;
                        this.txtMoneda.TipWhenBlank = "";
                        this.txtMoneda.ToolTipText = "";
                        // 
                        // txtCBU
                        // 
                        this.txtCBU.AutoNav = true;
                        this.txtCBU.AutoTab = true;
                        this.txtCBU.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtCBU.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCBU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCBU.Location = new System.Drawing.Point(144, 212);
                        this.txtCBU.MaxLenght = 23;
                        this.txtCBU.Name = "txtCBU";
                        this.txtCBU.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCBU.ReadOnly = false;
                        this.txtCBU.SelectOnFocus = false;
                        this.txtCBU.Size = new System.Drawing.Size(228, 24);
                        this.txtCBU.TabIndex = 13;
                        this.txtCBU.TipWhenBlank = "";
                        this.txtCBU.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(20, 212);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(120, 24);
                        this.label5.TabIndex = 12;
                        this.label5.Text = "CBU";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTitular
                        // 
                        this.txtTitular.AutoNav = true;
                        this.txtTitular.AutoTab = true;
                        this.txtTitular.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtTitular.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTitular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTitular.Location = new System.Drawing.Point(144, 52);
                        this.txtTitular.MaxLenght = 32767;
                        this.txtTitular.Name = "txtTitular";
                        this.txtTitular.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTitular.ReadOnly = false;
                        this.txtTitular.Size = new System.Drawing.Size(396, 24);
                        this.txtTitular.TabIndex = 3;
                        this.txtTitular.TipWhenBlank = "";
                        this.txtTitular.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(20, 52);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(120, 24);
                        this.label6.TabIndex = 2;
                        this.label6.Text = "Titular";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtEstado
                        // 
                        this.txtEstado.AutoNav = true;
                        this.txtEstado.AutoTab = true;
                        this.txtEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtEstado.Location = new System.Drawing.Point(144, 244);
                        this.txtEstado.MaxLenght = 32767;
                        this.txtEstado.Name = "txtEstado";
                        this.txtEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEstado.ReadOnly = false;
                        this.txtEstado.SetData = new string[] {
        "Activa|1",
        "Inactiva|0"};
                        this.txtEstado.Size = new System.Drawing.Size(168, 24);
                        this.txtEstado.TabIndex = 15;
                        this.txtEstado.Text = "Activa";
                        this.txtEstado.TextKey = "1";
                        this.txtEstado.TipWhenBlank = "";
                        this.txtEstado.ToolTipText = "¿El producto usa control de stock?";
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(20, 244);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(120, 24);
                        this.label8.TabIndex = 14;
                        this.label8.Text = "Estado";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(560, 361);
                        this.Controls.Add(this.txtEstado);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.txtTitular);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.txtCBU);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtMoneda);
                        this.Controls.Add(this.txtNombre);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtBanco);
                        this.Controls.Add(this.txtNumero);
                        this.Controls.Add(this.Label3);
                        this.Name = "Editar";
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.txtNumero, 0);
                        this.Controls.SetChildIndex(this.txtBanco, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.txtTipo, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.txtNombre, 0);
                        this.Controls.SetChildIndex(this.txtMoneda, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.txtCBU, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.txtTitular, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.txtEstado, 0);
                        this.ResumeLayout(false);

		}


		#endregion

		public override Lfx.Types.OperationResult Create()
		{
			txtMoneda.Text = Lfx.Types.Currency.DefaultCurrency.ToString();
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult ValidateData()
		{
			Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();

			if (txtMoneda.TextInt == 0)
			{
				validarReturn.Success = false;
				validarReturn.Message += "Seleccione la Currency." + Environment.NewLine;
			}
			if (txtNombre.Text.Length < 2)
			{
				validarReturn.Success = false;
				validarReturn.Message += "Seleccione el Nombre de la cuenta." + Environment.NewLine;
			}
                        if (txtCBU.Text.Length > 0 && Lfx.Types.Strings.ValidCBU(txtCBU.Text) == false) {
                                validarReturn.Success = false;
                                validarReturn.Message += "La CBU es incorrecta." + Environment.NewLine;
                        }

			return validarReturn;
		}


		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row row = this.Workspace.DefaultDataBase.Row("cuentas", "id_cuenta", lId);

			if (row == null)
			{
				ResultadoEditar.Success = false;
				ResultadoEditar.Message = "El registro no existe";
			}
			else
			{
				txtTitular.Text = System.Convert.ToString(row["titular"]);
				txtTipo.TextKey = System.Convert.ToString(row["tipo"]);
				txtNumero.Text = System.Convert.ToString(row["numero"]);
				txtBanco.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_banco"]);
				txtMoneda.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_moneda"]);
				txtNombre.Text = System.Convert.ToString(row["nombre"]);
				txtCBU.Text = System.Convert.ToString(row["cbu"]);
                                txtEstado.TextKey = row["estado"].ToString();

				m_Id = lId;
				m_Nuevo = false;
				CustomName = true;

				this.Text = "Cuentas: " + txtNombre.Text;
				ResultadoEditar.Success = true;
			}

			return ResultadoEditar;
		}


		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if (ResultadoGuardar.Success == true)
			{
                                DataView.DataBase.BeginTransaction();

                                Lfx.Data.SqlTableCommandBuilder Comando;
                                if (m_Nuevo) {
                                        Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "cuentas");
                                        Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                                } else {
                                        Comando = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "cuentas");
                                        Comando.WhereClause = new Lfx.Data.SqlWhereBuilder("id_cuenta=" + m_Id.ToString());
                                }

                                Comando.Fields.AddWithValue("titular", txtTitular.Text);
				Comando.Fields.AddWithValue("id_banco", Lfx.Data.DataBase.ConvertZeroToDBNull(txtBanco.TextInt));
				Comando.Fields.AddWithValue("id_moneda", Lfx.Data.DataBase.ConvertZeroToDBNull(txtMoneda.TextInt));
				Comando.Fields.AddWithValue("numero", txtNumero.Text);
				Comando.Fields.AddWithValue("nombre", txtNombre.Text);
				Comando.Fields.AddWithValue("tipo", Lfx.Types.Parsing.ParseInt(txtTipo.TextKey));
				Comando.Fields.AddWithValue("cbu", txtCBU.Text);
                                Comando.Fields.AddWithValue("estado", Lfx.Types.Parsing.ParseInt(txtEstado.TextKey));

                                DataView.DataBase.Execute(Comando);

                                if (m_Nuevo) {
                                        m_Id = DataView.DataBase.FieldInt("SELECT MAX(id_cuenta) FROM cuentas WHERE nombre='" + DataView.DataBase.EscapeString(txtNombre.Text) + "'");
                                        m_Nuevo = false;
                                }

                                DataView.DataBase.Commit();

				ResultadoGuardar = base.Save();
			}

			return ResultadoGuardar;
		}


		private void txtNombre_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			CustomName = true;
		}


		private void NumeroBanco_TextChanged(object sender, System.EventArgs e)
		{
			if (CustomName == false)
			{
				txtNombre.Text = txtNumero.Text;
				if (txtBanco.TextDetail.Length > 0)
				{
					if (txtNumero.Text.Length > 0)
						txtNombre.Text += " de ";

					txtNombre.Text += txtBanco.TextDetail;
				}
			}
		}


		private void txtTipo_TextChanged(object sender, System.EventArgs e)
		{
			txtBanco.Enabled = Lfx.Types.Parsing.ParseInt(txtTipo.TextKey) > 0;
			txtNumero.Enabled = Lfx.Types.Parsing.ParseInt(txtTipo.TextKey) > 0;
		}
	}
}