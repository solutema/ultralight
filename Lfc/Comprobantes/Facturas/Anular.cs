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

namespace Lfc.Comprobantes.Facturas
{
	public class Anular : Lui.Forms.DialogForm
	{
		System.Collections.Hashtable ProximosNumeros = new System.Collections.Hashtable();
		
		#region Código generado por el Diseñador de Windows Forms

		public Anular()
			: base()
		{

			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
			OkButton.Text = "Anular";
			OkButton.Visible = false;
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
		internal System.Windows.Forms.Label Label1;
                public Lui.Forms.ComboBox txtTipo;
		internal Lui.Forms.TextBox txtNumero;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal Lui.Forms.TextBox txtFecha;
		internal System.Windows.Forms.Label Label5;
		internal Lui.Forms.TextBox txtCliente;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label6;
		internal Lui.Forms.TextBox txtTipoPago;
		internal System.Windows.Forms.Label lblAviso;
		internal Lui.Forms.TextBox txtImporte;
		internal System.Windows.Forms.Label lblTipoComprob;
		internal Lui.Forms.TextBox txtPV;
		internal System.Windows.Forms.Label Label7;

		private void InitializeComponent()
		{
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.txtNumero = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtFecha = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtImporte = new Lui.Forms.TextBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtCliente = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtTipoPago = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.lblAviso = new System.Windows.Forms.Label();
                        this.lblTipoComprob = new System.Windows.Forms.Label();
                        this.txtPV = new Lui.Forms.TextBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(394, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(514, 8);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 20);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(68, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Tipo";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTipo.Location = new System.Drawing.Point(88, 20);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "Comprobante A|A",
        "Comprobante B|B"};
                        this.txtTipo.Size = new System.Drawing.Size(196, 24);
                        this.txtTipo.TabIndex = 1;
                        this.txtTipo.Text = "Comprobante B";
                        this.txtTipo.TextKey = "B";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "";
                        this.txtTipo.TextChanged += new System.EventHandler(this.txtNumeroTipoPV_TextChanged);
                        // 
                        // txtNumero
                        // 
                        this.txtNumero.AutoNav = true;
                        this.txtNumero.AutoTab = true;
                        this.txtNumero.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtNumero.Location = new System.Drawing.Point(164, 48);
                        this.txtNumero.MaxLenght = 32767;
                        this.txtNumero.Name = "txtNumero";
                        this.txtNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.txtNumero.ReadOnly = false;
                        this.txtNumero.Size = new System.Drawing.Size(100, 24);
                        this.txtNumero.TabIndex = 4;
                        this.txtNumero.Text = "0";
                        this.txtNumero.TipWhenBlank = "";
                        this.txtNumero.ToolTipText = "";
                        this.txtNumero.TextChanged += new System.EventHandler(this.txtNumeroTipoPV_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(20, 48);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(68, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Número";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFecha
                        // 
                        this.txtFecha.AutoNav = true;
                        this.txtFecha.AutoTab = true;
                        this.txtFecha.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtFecha.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFecha.Location = new System.Drawing.Point(88, 112);
                        this.txtFecha.MaxLenght = 32767;
                        this.txtFecha.Name = "txtFecha";
                        this.txtFecha.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFecha.ReadOnly = true;
                        this.txtFecha.Size = new System.Drawing.Size(104, 24);
                        this.txtFecha.TabIndex = 8;
                        this.txtFecha.TabStop = false;
                        this.txtFecha.TipWhenBlank = "";
                        this.txtFecha.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(20, 112);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(68, 24);
                        this.Label3.TabIndex = 7;
                        this.Label3.Text = "Fecha";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtImporte
                        // 
                        this.txtImporte.AutoNav = true;
                        this.txtImporte.AutoTab = true;
                        this.txtImporte.DataType = Lui.Forms.DataTypes.Money;
                        this.txtImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtImporte.Location = new System.Drawing.Point(88, 140);
                        this.txtImporte.MaxLenght = 32767;
                        this.txtImporte.Name = "txtImporte";
                        this.txtImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImporte.ReadOnly = true;
                        this.txtImporte.Size = new System.Drawing.Size(104, 24);
                        this.txtImporte.TabIndex = 10;
                        this.txtImporte.TabStop = false;
                        this.txtImporte.Text = "0.00";
                        this.txtImporte.TipWhenBlank = "";
                        this.txtImporte.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(20, 140);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(68, 24);
                        this.Label5.TabIndex = 9;
                        this.Label5.Text = "Importe";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCliente
                        // 
                        this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCliente.AutoNav = true;
                        this.txtCliente.AutoTab = true;
                        this.txtCliente.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCliente.Location = new System.Drawing.Point(88, 196);
                        this.txtCliente.MaxLenght = 32767;
                        this.txtCliente.Name = "txtCliente";
                        this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCliente.ReadOnly = true;
                        this.txtCliente.Size = new System.Drawing.Size(476, 24);
                        this.txtCliente.TabIndex = 14;
                        this.txtCliente.TabStop = false;
                        this.txtCliente.TipWhenBlank = "";
                        this.txtCliente.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(20, 196);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(68, 24);
                        this.Label4.TabIndex = 13;
                        this.Label4.Text = "Cliente";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTipoPago
                        // 
                        this.txtTipoPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTipoPago.AutoNav = true;
                        this.txtTipoPago.AutoTab = true;
                        this.txtTipoPago.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtTipoPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTipoPago.Location = new System.Drawing.Point(88, 168);
                        this.txtTipoPago.MaxLenght = 32767;
                        this.txtTipoPago.Name = "txtTipoPago";
                        this.txtTipoPago.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipoPago.ReadOnly = true;
                        this.txtTipoPago.Size = new System.Drawing.Size(476, 24);
                        this.txtTipoPago.TabIndex = 12;
                        this.txtTipoPago.TabStop = false;
                        this.txtTipoPago.TipWhenBlank = "";
                        this.txtTipoPago.ToolTipText = "";
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(20, 168);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(68, 24);
                        this.Label6.TabIndex = 11;
                        this.Label6.Text = "Pago";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblAviso
                        // 
                        this.lblAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblAviso.Location = new System.Drawing.Point(92, 224);
                        this.lblAviso.Name = "lblAviso";
                        this.lblAviso.Size = new System.Drawing.Size(524, 56);
                        this.lblAviso.TabIndex = 15;
                        // 
                        // lblTipoComprob
                        // 
                        this.lblTipoComprob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblTipoComprob.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblTipoComprob.Location = new System.Drawing.Point(88, 76);
                        this.lblTipoComprob.Name = "lblTipoComprob";
                        this.lblTipoComprob.Size = new System.Drawing.Size(528, 24);
                        this.lblTipoComprob.TabIndex = 6;
                        this.lblTipoComprob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPV
                        // 
                        this.txtPV.AutoNav = true;
                        this.txtPV.AutoTab = true;
                        this.txtPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPV.Location = new System.Drawing.Point(88, 48);
                        this.txtPV.MaxLenght = 32767;
                        this.txtPV.Name = "txtPV";
                        this.txtPV.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPV.ReadOnly = false;
                        this.txtPV.Size = new System.Drawing.Size(60, 24);
                        this.txtPV.TabIndex = 3;
                        this.txtPV.Text = "1";
                        this.txtPV.TipWhenBlank = "";
                        this.txtPV.ToolTipText = "";
                        this.txtPV.TextChanged += new System.EventHandler(this.txtNumeroTipoPV_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(148, 48);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(16, 24);
                        this.Label7.TabIndex = 5;
                        this.Label7.Text = "-";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Anular
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.txtPV);
                        this.Controls.Add(this.lblTipoComprob);
                        this.Controls.Add(this.lblAviso);
                        this.Controls.Add(this.txtTipoPago);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.txtCliente);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtImporte);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.txtFecha);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.txtNumero);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.Label1);
                        this.Name = "Anular";
                        this.Text = "Anular Factura";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.txtTipo, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.txtNumero, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.txtFecha, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.txtImporte, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.txtCliente, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.txtTipoPago, 0);
                        this.Controls.SetChildIndex(this.lblAviso, 0);
                        this.Controls.SetChildIndex(this.lblTipoComprob, 0);
                        this.Controls.SetChildIndex(this.txtPV, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.ResumeLayout(false);

		}

		#endregion

		private void txtNumeroTipoPV_TextChanged(object sender, System.EventArgs e)
		{
			int PV = Lfx.Types.Parsing.ParseInt(txtPV.Text);

			if (Lfx.Types.Parsing.ParseInt(txtNumero.Text) > 0)
			{
				string TipoReal = "";

				switch (txtTipo.TextKey)
				{
					case "A":
						TipoReal = "'A', 'NCA', 'NDA'";
						break;

					case "B":
						TipoReal = "'B', 'NCB', 'NDB'";
						break;
				}

				Lfx.Data.Row row = this.Workspace.DefaultDataBase.FirstRowFromSelect("SELECT * FROM facturas WHERE tipo_fac IN (" + TipoReal + ") AND pv=" + PV.ToString() + " AND numero=" + Lfx.Types.Parsing.ParseInt(txtNumero.Text).ToString());

				if (row == null) {
					if(ProximosNumeros.ContainsKey(PV) == false)
						ProximosNumeros[PV] = this.Workspace.DefaultDataBase.FieldInt("SELECT MAX(numero) FROM facturas WHERE tipo_fac IN (" + TipoReal + ") AND impresa>0 AND pv=" + PV.ToString()) + 1;

					if (Lfx.Types.Parsing.ParseInt(txtNumero.Text) == ((int)(ProximosNumeros[PV]))) {
						lblAviso.Text = "El comprobante " + txtTipo.TextKey + " " + PV.ToString("0000") + "-" + Lfx.Types.Parsing.ParseInt(txtNumero.Text).ToString("00000000") + " aun no fue confeccionado, pero es el próximo a ser impreso. Si lo anula, el sistema salteará dicho comprobante.";
						txtFecha.Text = "";
						lblTipoComprob.Text = "";
						txtImporte.Text = "";
						txtTipoPago.Text = "";
						txtCliente.Text = "";
						OkButton.Visible = true;
					}
					else
					{
						lblAviso.Text = "El comprobante " + txtTipo.TextKey + " " + PV.ToString("0000") + "-" + Lfx.Types.Parsing.ParseInt(txtNumero.Text).ToString("00000000") + " aun no fue confeccionado y no puede anularse.";
						txtFecha.Text = "";
						lblTipoComprob.Text = "";
						txtImporte.Text = "";
						txtTipoPago.Text = "";
						txtCliente.Text = "";
						OkButton.Visible = false;
					}
				}
				else
				{
					txtFecha.Text = Lfx.Types.Formatting.FormatDate(row["fecha"]);

					switch (System.Convert.ToString(row["tipo_fac"]))
					{
						case "A":
						case "B":
							lblTipoComprob.Text = " (Factura)";
							break;

						case "NCA":
						case "NCB":
							lblTipoComprob.Text = " (Nota de Crédito)";
							break;

						case "NDA":
						case "NDB":
							lblTipoComprob.Text = " (Nota de Débito)";
							break;
					}

					txtImporte.Text = Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(row["total"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
					txtTipoPago.Text = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM formaspago WHERE id_formapago=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_formapago"]).ToString());
					txtCliente.Text = this.Workspace.DefaultDataBase.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_cliente"]).ToString());

					if (System.Convert.ToInt32(row["anulada"]) != 0)
					{
						lblAviso.Text = "El comprobante ya fue anulado y no puede anularse nuevamente.";
						OkButton.Visible = false;
					} else if (System.Convert.ToInt32(row["impresa"]) == 0) {
                                                lblAviso.Text = "El comprobante no puede anularse porque todavía no fue impreso.";
                                                OkButton.Visible = false;
                                        } else {
                                                lblAviso.Text = "Recuerde que necesitar archivar todas las copias del comprobante anulado.";
                                                OkButton.Visible = true;
                                        }
				}
			}
			else
			{
				lblAviso.Text = "";
				txtFecha.Text = "";
				lblTipoComprob.Text = "";
				txtImporte.Text = "";
				txtTipoPago.Text = "";
				txtCliente.Text = "";
				OkButton.Visible = false;
			}
		}

		public override Lfx.Types.OperationResult Ok()
		{
			Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Una vez anulado, el comprobante deberá ser archivado en todas sus copias y no podrá ser rehabilitado ni reutilizado.", "¿Está seguro de que desea anular el comprobante?");
			Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;

			if (Pregunta.ShowDialog() == DialogResult.OK)
			{
				int PV = Lfx.Types.Parsing.ParseInt(txtPV.Text);

				this.DataView.BeginTransaction();
				int m_Id = 0;
				string TipoReal = "";

				switch (txtTipo.TextKey)
				{
					case "A":
						TipoReal = "'A', 'NCA', 'NDA'";
						break;

					case "B":
						TipoReal = "'B', 'NCB', 'NDB'";
						break;
				}

				int IdFactura = DataView.DataBase.FieldInt("SELECT id_factura FROM facturas WHERE tipo_fac IN (" + TipoReal + ") AND pv=" + PV.ToString() + " AND numero=" + Lfx.Types.Parsing.ParseInt(txtNumero.Text).ToString());

                                if (IdFactura == 0) {
                                        // Es una factura que todava no existe
                                        // Tengo que crear la factura y anularla
                                        DataView.DataBase.Execute("INSERT INTO facturas (tipo_fac, id_formapago, id_sucursal, pv, fecha, id_vendedor, id_cliente, obs, impresa, anulada) VALUES ('" + txtTipo.TextKey + "', 3, " + this.Workspace.CurrentConfig.Company.CurrentBranch.ToString() + ", " + txtPV.Text + ", NOW(), " + this.Workspace.CurrentUser.UserId.ToString() + ", " + this.Workspace.CurrentUser.UserId.ToString() + ", 'Comprobante anulado antes de ser impreso.', 1, 1)");
                                        m_Id = DataView.DataBase.FieldInt("SELECT MAX(id_factura) AS id_factura FROM facturas WHERE tipo_fac='" + txtTipo.TextKey + "'");
                                        Lbl.Comprobantes.Numerador.Numerar(DataView, m_Id);
                                        Lui.Forms.MessageBox.Show("Se anuló el comprobante " + Lbl.Comprobantes.Comprobante.NumeroCompleto(DataView, m_Id) + ". Recuerde archivar ambas copias.", "Aviso");
                                } else {
                                        Lbl.Comprobantes.Factura Fac = new Lbl.Comprobantes.Factura(DataView, IdFactura);
                                        Fac.Anular();
                                        Lui.Forms.MessageBox.Show("Se anuló el comprobante " + Fac.ToString() + ". Recuerde archivar ambas copias.", "Aviso");
                                }

				this.DataView.Commit();

				txtNumero.Text = "";
				txtNumero.Focus();

				return new Lfx.Types.OperationResult(false);
			}
			else
			{
				return new Lfx.Types.FailureOperationResult("La operación fue cancelada.");
			}
		}
	}
}