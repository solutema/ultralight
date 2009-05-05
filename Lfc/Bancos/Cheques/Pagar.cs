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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Bancos.Cheques
{
	public class Pagar : Lui.Forms.DialogForm
	{
		System.Collections.ArrayList Cheques = null;
		private string ChequesIds = null;

		internal System.Windows.Forms.Label label7;
		internal Lui.Forms.TextBox txtImpuestos;
		internal System.Windows.Forms.Label label4;
		internal Lui.Forms.TextBox txtSubTotal;
		internal System.Windows.Forms.Label Label1;
		internal Lui.Forms.TextBox txtCantidad;
		internal System.Windows.Forms.Label lblLabel1;
		internal System.Windows.Forms.Label Label3;
		internal Lui.Forms.TextBox txtTotal;
                internal System.Windows.Forms.Label Label8;
                public Lui.Forms.DetailBox EntradaCuentaOrigen;
		private System.ComponentModel.IContainer components = null;

		public Pagar()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if(disposing)
			{
				if(components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
                        this.label7 = new System.Windows.Forms.Label();
                        this.txtImpuestos = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.txtSubTotal = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtCantidad = new Lui.Forms.TextBox();
                        this.lblLabel1 = new System.Windows.Forms.Label();
                        this.EntradaCuentaOrigen = new Lui.Forms.DetailBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtTotal = new Lui.Forms.TextBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(378, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(486, 8);
                        // 
                        // label7
                        // 
                        this.label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label7.Location = new System.Drawing.Point(20, 16);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(556, 36);
                        this.label7.TabIndex = 0;
                        this.label7.Text = "Asentará el pago de un cheque emitido.";
                        // 
                        // txtImpuestos
                        // 
                        this.txtImpuestos.AutoNav = true;
                        this.txtImpuestos.AutoTab = true;
                        this.txtImpuestos.DataType = Lui.Forms.DataTypes.Money;
                        this.txtImpuestos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImpuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtImpuestos.Location = new System.Drawing.Point(412, 100);
                        this.txtImpuestos.MaxLenght = 32767;
                        this.txtImpuestos.Name = "txtImpuestos";
                        this.txtImpuestos.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImpuestos.Prefijo = "$";
                        this.txtImpuestos.ReadOnly = false;
                        this.txtImpuestos.Size = new System.Drawing.Size(108, 24);
                        this.txtImpuestos.TabIndex = 8;
                        this.txtImpuestos.Text = "0.00";
                        this.txtImpuestos.TipWhenBlank = "";
                        this.txtImpuestos.ToolTipText = "";
                        this.txtImpuestos.TextChanged += new System.EventHandler(this.Importes_TextChanged);
                        // 
                        // label4
                        // 
                        this.label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label4.Location = new System.Drawing.Point(276, 100);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(132, 24);
                        this.label4.TabIndex = 7;
                        this.label4.Text = "+ Otros gastos";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtSubTotal
                        // 
                        this.txtSubTotal.AutoNav = true;
                        this.txtSubTotal.AutoTab = true;
                        this.txtSubTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtSubTotal.Location = new System.Drawing.Point(412, 68);
                        this.txtSubTotal.MaxLenght = 32767;
                        this.txtSubTotal.Name = "txtSubTotal";
                        this.txtSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSubTotal.Prefijo = "$";
                        this.txtSubTotal.ReadOnly = true;
                        this.txtSubTotal.Size = new System.Drawing.Size(108, 24);
                        this.txtSubTotal.TabIndex = 4;
                        this.txtSubTotal.TabStop = false;
                        this.txtSubTotal.Text = "0.00";
                        this.txtSubTotal.TipWhenBlank = "";
                        this.txtSubTotal.ToolTipText = "";
                        this.txtSubTotal.TextChanged += new System.EventHandler(this.Importes_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label1.Location = new System.Drawing.Point(236, 68);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(176, 24);
                        this.Label1.TabIndex = 3;
                        this.Label1.Text = "cheque(s) por un total de";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCantidad
                        // 
                        this.txtCantidad.AutoNav = true;
                        this.txtCantidad.AutoTab = true;
                        this.txtCantidad.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCantidad.Location = new System.Drawing.Point(172, 68);
                        this.txtCantidad.MaxLenght = 32767;
                        this.txtCantidad.Name = "txtCantidad";
                        this.txtCantidad.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCantidad.ReadOnly = true;
                        this.txtCantidad.Size = new System.Drawing.Size(56, 24);
                        this.txtCantidad.TabIndex = 2;
                        this.txtCantidad.TabStop = false;
                        this.txtCantidad.Text = "0";
                        this.txtCantidad.TipWhenBlank = "";
                        this.txtCantidad.ToolTipText = "";
                        // 
                        // lblLabel1
                        // 
                        this.lblLabel1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblLabel1.Location = new System.Drawing.Point(60, 68);
                        this.lblLabel1.Name = "lblLabel1";
                        this.lblLabel1.Size = new System.Drawing.Size(112, 24);
                        this.lblLabel1.TabIndex = 1;
                        this.lblLabel1.Text = "Pago de";
                        this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCuentaOrigen
                        // 
                        this.EntradaCuentaOrigen.AutoTab = true;
                        this.EntradaCuentaOrigen.CanCreate = false;
                        this.EntradaCuentaOrigen.DetailField = "nombre";
                        this.EntradaCuentaOrigen.ExtraDetailFields = null;
                        this.EntradaCuentaOrigen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCuentaOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCuentaOrigen.FreeTextCode = "";
                        this.EntradaCuentaOrigen.KeyField = "id_cuenta";
                        this.EntradaCuentaOrigen.Location = new System.Drawing.Point(212, 232);
                        this.EntradaCuentaOrigen.MaxLength = 200;
                        this.EntradaCuentaOrigen.Name = "EntradaCuentaOrigen";
                        this.EntradaCuentaOrigen.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCuentaOrigen.ReadOnly = false;
                        this.EntradaCuentaOrigen.Required = true;
                        this.EntradaCuentaOrigen.SelectOnFocus = false;
                        this.EntradaCuentaOrigen.Size = new System.Drawing.Size(308, 24);
                        this.EntradaCuentaOrigen.TabIndex = 12;
                        this.EntradaCuentaOrigen.Table = "cuentas";
                        this.EntradaCuentaOrigen.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCuentaOrigen.Text = "0";
                        this.EntradaCuentaOrigen.TextDetail = "";
                        this.EntradaCuentaOrigen.TextInt = 0;
                        this.EntradaCuentaOrigen.TipWhenBlank = "";
                        this.EntradaCuentaOrigen.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label3.Location = new System.Drawing.Point(60, 232);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(160, 24);
                        this.Label3.TabIndex = 11;
                        this.Label3.Text = "De la siguiente cuenta";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTotal
                        // 
                        this.txtTotal.AutoNav = true;
                        this.txtTotal.AutoTab = true;
                        this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTotal.Location = new System.Drawing.Point(212, 196);
                        this.txtTotal.MaxLenght = 32767;
                        this.txtTotal.Name = "txtTotal";
                        this.txtTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTotal.Prefijo = "$";
                        this.txtTotal.ReadOnly = false;
                        this.txtTotal.Size = new System.Drawing.Size(136, 28);
                        this.txtTotal.TabIndex = 10;
                        this.txtTotal.Text = "0.00";
                        this.txtTotal.TipWhenBlank = "";
                        this.txtTotal.ToolTipText = "";
                        // 
                        // Label8
                        // 
                        this.Label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label8.Location = new System.Drawing.Point(60, 196);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(160, 28);
                        this.Label8.TabIndex = 9;
                        this.Label8.Text = "Se van a descontar";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Pagar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(594, 375);
                        this.Controls.Add(this.EntradaCuentaOrigen);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.txtTotal);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.txtImpuestos);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.txtSubTotal);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtCantidad);
                        this.Controls.Add(this.lblLabel1);
                        this.Controls.Add(this.label7);
                        this.Name = "Pagar";
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.lblLabel1, 0);
                        this.Controls.SetChildIndex(this.txtCantidad, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.txtSubTotal, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.txtImpuestos, 0);
                        this.Controls.SetChildIndex(this.Label8, 0);
                        this.Controls.SetChildIndex(this.txtTotal, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaCuentaOrigen, 0);
                        this.ResumeLayout(false);

		}
		#endregion

		private void Importes_TextChanged(object sender, System.EventArgs e)
		{
			txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text) + Lfx.Types.Parsing.ParseCurrency(txtImpuestos.Text), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
		}

		public System.Windows.Forms.DialogResult Mostrar(System.Collections.ArrayList ChequesAPagar)
		{
			this.Cheques = ChequesAPagar;

			foreach(string ChequeId in Cheques)
			{
				if(ChequesIds == null)
					ChequesIds = ChequeId;
				else
					ChequesIds += "," + ChequeId;
			}

			if(ChequesIds != null)
			{
				double Total = this.Workspace.DefaultDataBase.FieldDouble("SELECT SUM(importe) FROM bancos_cheques WHERE id_cheque IN (" + ChequesIds + ")");

				txtCantidad.Text = Cheques.Count.ToString();
				txtSubTotal.Text = Lfx.Types.Formatting.FormatCurrency(Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
				return this.ShowDialog();
			}
			else
			{
				return DialogResult.Cancel;
			}
		}

		public override Lfx.Types.OperationResult Ok()
		{
			Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();
			if(EntradaCuentaOrigen.TextInt <= 0)
			{
				aceptarReturn.Success = false;
				aceptarReturn.Message += "Debe especificar la cuenta de origen." + Environment.NewLine;
			}
			if(Lfx.Types.Parsing.ParseCurrency(txtTotal.Text) <= 0)
			{
				aceptarReturn.Success = false;
				aceptarReturn.Message += "El importe total debe ser mayor o igual a cero." + Environment.NewLine;
			}
			if(aceptarReturn.Success == true)
			{
				//double ImporteOrigen = Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text);
				//double ImporteDestino = Lfx.Types.Parsing.ParseCurrency(txtTotal.Text);
				double Impuestos = Lfx.Types.Parsing.ParseCurrency(txtImpuestos.Text);

				this.DataView.BeginTransaction();
				
				string ChequesNum = null;
				System.Data.DataTable TablaCheques = DataView.DataBase.Select("SELECT * FROM bancos_cheques WHERE id_cheque IN (" + ChequesIds + ")");
				Lbl.Cuentas.CuentaRegular CuentaOrigen = new Lbl.Cuentas.CuentaRegular(DataView, EntradaCuentaOrigen.TextInt);
				foreach(System.Data.DataRow Cheque in TablaCheques.Rows)
				{
                                        string NumeroCheque = Cheque["numero"].ToString();
                                        if (Lfx.Types.Parsing.ParseInt(Cheque["prefijo"].ToString()) > 0)
                                                NumeroCheque = Cheque["prefijo"].ToString() + "-" + NumeroCheque;

                                        if(ChequesNum == null)
                                                ChequesNum = NumeroCheque;
					else
                                                ChequesNum += ", " + NumeroCheque;

                                        CuentaOrigen.Movimiento(true, System.Convert.ToInt32(Cheque["id_concepto"]), Cheque["concepto"].ToString(), 0, -System.Convert.ToDouble(Cheque["importe"]), "Pago de cheque Nº " + NumeroCheque, 0, 0, "");
					DataView.DataBase.Execute("UPDATE bancos_cheques SET estado=10 WHERE id_cheque=" + System.Convert.ToInt32(Cheque["id_cheque"]).ToString());
				}                

				if(Impuestos != 0)
					CuentaOrigen.Movimiento(true, 23030, "Impuestos Cheques", 0, -Impuestos, "Cheques Nº " + ChequesNum, 0, 0, "");

				this.DataView.Commit();
			}
			return aceptarReturn;
		}
	}
}

