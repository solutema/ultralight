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

namespace Lfc.Cajas.Admin
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
		internal Lcc.Entrada.CodigoDetalle txtBanco;
		internal System.Windows.Forms.Label Label7;
		internal Lui.Forms.TextBox EntradaNombre;
		internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox txtTipo;
		internal System.Windows.Forms.Label Label4;
		internal Lui.Forms.TextBox EntradaCbu;
		internal System.Windows.Forms.Label label5;
		internal Lui.Forms.TextBox txtTitular;
		internal Label label6;
                internal Lui.Forms.ComboBox txtEstado;
                internal Label label8;
		internal Lcc.Entrada.CodigoDetalle EntradaMoneda;

		private void InitializeComponent()
		{
                        this.txtNumero = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtBanco = new Lcc.Entrada.CodigoDetalle();
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaMoneda = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaCbu = new Lui.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.txtTitular = new Lui.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.txtEstado = new Lui.Forms.ComboBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
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
                        this.txtBanco.Size = new System.Drawing.Size(396, 24);
                        this.txtBanco.TabIndex = 7;
                        this.txtBanco.Table = "bancos";
                        this.txtBanco.TeclaDespuesDeEnter = "{tab}";
                        this.txtBanco.Text = "0";
                        this.txtBanco.TextDetail = "";
                        this.txtBanco.TipWhenBlank = "";
                        this.txtBanco.ToolTipText = "";
                        this.txtBanco.TextChanged += new System.EventHandler(this.NumeroBanco_TextChanged);
                        // 
                        // EntradaTipo
                        // 
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTipo.Location = new System.Drawing.Point(144, 84);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "EntradaTipo";
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
                        this.Label7.Text = "Tipo de Caja";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNombre.Location = new System.Drawing.Point(144, 20);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.Name = "txtNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(396, 24);
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
                        this.EntradaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
                        this.EntradaMoneda.AutoTab = true;
                        this.EntradaMoneda.CanCreate = true;
                        this.EntradaMoneda.DetailField = "nombre";
                        this.EntradaMoneda.ExtraDetailFields = null;
                        this.EntradaMoneda.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMoneda.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMoneda.FreeTextCode = "";
                        this.EntradaMoneda.KeyField = "id_moneda";
                        this.EntradaMoneda.Location = new System.Drawing.Point(144, 180);
                        this.EntradaMoneda.MaxLength = 200;
                        this.EntradaMoneda.Name = "txtMoneda";
                        this.EntradaMoneda.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMoneda.ReadOnly = false;
                        this.EntradaMoneda.Required = false;
                        this.EntradaMoneda.Size = new System.Drawing.Size(228, 24);
                        this.EntradaMoneda.TabIndex = 11;
                        this.EntradaMoneda.Table = "monedas";
                        this.EntradaMoneda.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaMoneda.Text = "0";
                        this.EntradaMoneda.TextDetail = "";
                        this.EntradaMoneda.TipWhenBlank = "";
                        this.EntradaMoneda.ToolTipText = "";
                        // 
                        // txtCBU
                        // 
                        this.EntradaCbu.AutoNav = true;
                        this.EntradaCbu.AutoTab = true;
                        this.EntradaCbu.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCbu.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCbu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCbu.Location = new System.Drawing.Point(144, 212);
                        this.EntradaCbu.MaxLenght = 23;
                        this.EntradaCbu.Name = "txtCBU";
                        this.EntradaCbu.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCbu.ReadOnly = false;
                        this.EntradaCbu.SelectOnFocus = false;
                        this.EntradaCbu.Size = new System.Drawing.Size(228, 24);
                        this.EntradaCbu.TabIndex = 13;
                        this.EntradaCbu.TipWhenBlank = "";
                        this.EntradaCbu.ToolTipText = "";
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
                        this.Controls.Add(this.EntradaCbu);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaMoneda);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtBanco);
                        this.Controls.Add(this.txtNumero);
                        this.Controls.Add(this.Label3);
                        this.Name = "Editar";
                        this.ResumeLayout(false);

		}


		#endregion

		public override Lfx.Types.OperationResult Create()
		{
			EntradaMoneda.Text = Lfx.Types.Currency.DefaultCurrency.ToString();
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult ValidateData()
		{
			Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();

			if (EntradaMoneda.TextInt == 0)
			{
				validarReturn.Success = false;
				validarReturn.Message += "Seleccione la Currency." + Environment.NewLine;
			}
			if (EntradaNombre.Text.Length < 2)
			{
				validarReturn.Success = false;
				validarReturn.Message += "Seleccione el Nombre de la cuenta." + Environment.NewLine;
			}
                        if (EntradaCbu.Text.Length > 0 && Lfx.Types.Strings.ValidCBU(EntradaCbu.Text) == false) {
                                validarReturn.Success = false;
                                validarReturn.Message += "La CBU es incorrecta." + Environment.NewLine;
                        }

			return validarReturn;
		}


		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row row = this.DataBase.Row("cajas", "id_caja", lId);

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
				EntradaMoneda.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_moneda"]);
				EntradaNombre.Text = System.Convert.ToString(row["nombre"]);
				EntradaCbu.Text = System.Convert.ToString(row["cbu"]);
                                txtEstado.TextKey = row["estado"].ToString();

				m_Id = lId;
				m_Nuevo = false;
				CustomName = true;

				this.Text = "Cajas: " + EntradaNombre.Text;
				ResultadoEditar.Success = true;
			}

			return ResultadoEditar;
		}


		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if (ResultadoGuardar.Success == true)
			{
                                DataBase.BeginTransaction();

                                qGen.TableCommand Comando;
                                if (m_Nuevo) {
                                        Comando = new qGen.Insert(DataBase, "cajas");
                                        Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                } else {
                                        Comando = new qGen.Update(DataBase, "cajas");
                                        Comando.WhereClause = new qGen.Where("id_caja", m_Id);
                                }

                                Comando.Fields.AddWithValue("titular", txtTitular.Text);
				Comando.Fields.AddWithValue("id_banco", Lfx.Data.DataBase.ConvertZeroToDBNull(txtBanco.TextInt));
				Comando.Fields.AddWithValue("id_moneda", Lfx.Data.DataBase.ConvertZeroToDBNull(EntradaMoneda.TextInt));
				Comando.Fields.AddWithValue("numero", txtNumero.Text);
				Comando.Fields.AddWithValue("nombre", EntradaNombre.Text);
				Comando.Fields.AddWithValue("tipo", Lfx.Types.Parsing.ParseInt(txtTipo.TextKey));
				Comando.Fields.AddWithValue("cbu", EntradaCbu.Text);
                                Comando.Fields.AddWithValue("estado", Lfx.Types.Parsing.ParseInt(txtEstado.TextKey));

                                DataBase.Execute(Comando);

                                if (m_Nuevo) {
                                        m_Id = DataBase.FieldInt("SELECT LAST_INSERT_ID()");
                                        m_Nuevo = false;
                                }

                                DataBase.Commit();

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
				EntradaNombre.Text = txtNumero.Text;
				if (txtBanco.TextDetail.Length > 0)
				{
					if (txtNumero.Text.Length > 0)
						EntradaNombre.Text += " de ";

					EntradaNombre.Text += txtBanco.TextDetail;
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