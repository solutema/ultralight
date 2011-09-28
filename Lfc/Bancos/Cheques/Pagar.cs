#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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
using System.Windows.Forms;

namespace Lfc.Bancos.Cheques
{
        public class Pagar : Lui.Forms.DialogForm
        {
                IList<string> Cheques = null;
                private string ChequesIds = null;

                internal System.Windows.Forms.Label label7;
                internal Lui.Forms.TextBox EntradaImpuestos;
                internal System.Windows.Forms.Label label4;
                internal Lui.Forms.TextBox EntradaSubTotal;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaCantidad;
                internal System.Windows.Forms.Label lblLabel1;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.TextBox EntradaTotal;
                internal System.Windows.Forms.Label Label8;
                public Lcc.Entrada.CodigoDetalle EntradaCajaOrigen;
                private System.ComponentModel.IContainer components = null;

                public Pagar()
                {
                        InitializeComponent();
                }

                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
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
                        this.EntradaImpuestos = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaSubTotal = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaCantidad = new Lui.Forms.TextBox();
                        this.lblLabel1 = new System.Windows.Forms.Label();
                        this.EntradaCajaOrigen = new Lcc.Entrada.CodigoDetalle();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(354, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(474, 8);
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
                        // EntradaImpuestos
                        // 
                        this.EntradaImpuestos.AutoSize = false;
                        this.EntradaImpuestos.AutoNav = true;
                        this.EntradaImpuestos.AutoTab = true;
                        this.EntradaImpuestos.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImpuestos.DecimalPlaces = -1;
                        this.EntradaImpuestos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaImpuestos.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImpuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaImpuestos.Location = new System.Drawing.Point(412, 100);
                        this.EntradaImpuestos.MaxLenght = 32767;
                        this.EntradaImpuestos.MultiLine = false;
                        this.EntradaImpuestos.Name = "EntradaImpuestos";
                        this.EntradaImpuestos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImpuestos.PasswordChar = '\0';
                        this.EntradaImpuestos.Prefijo = "$";
                        this.EntradaImpuestos.TemporaryReadOnly = false;
                        this.EntradaImpuestos.SelectOnFocus = true;
                        this.EntradaImpuestos.Size = new System.Drawing.Size(108, 24);
                        this.EntradaImpuestos.Sufijo = "";
                        this.EntradaImpuestos.TabIndex = 8;
                        this.EntradaImpuestos.Text = "0.00";
                        this.EntradaImpuestos.PlaceholderText = "";
                        this.EntradaImpuestos.ToolTipText = "";
                        this.EntradaImpuestos.TextChanged += new System.EventHandler(this.Importes_TextChanged);
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
                        // EntradaSubTotal
                        // 
                        this.EntradaSubTotal.AutoSize = false;
                        this.EntradaSubTotal.AutoNav = true;
                        this.EntradaSubTotal.AutoTab = true;
                        this.EntradaSubTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaSubTotal.DecimalPlaces = -1;
                        this.EntradaSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSubTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaSubTotal.Location = new System.Drawing.Point(412, 68);
                        this.EntradaSubTotal.MaxLenght = 32767;
                        this.EntradaSubTotal.MultiLine = false;
                        this.EntradaSubTotal.Name = "EntradaSubTotal";
                        this.EntradaSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubTotal.PasswordChar = '\0';
                        this.EntradaSubTotal.Prefijo = "$";
                        this.EntradaSubTotal.TemporaryReadOnly = true;
                        this.EntradaSubTotal.SelectOnFocus = true;
                        this.EntradaSubTotal.Size = new System.Drawing.Size(108, 24);
                        this.EntradaSubTotal.Sufijo = "";
                        this.EntradaSubTotal.TabIndex = 4;
                        this.EntradaSubTotal.TabStop = false;
                        this.EntradaSubTotal.Text = "0.00";
                        this.EntradaSubTotal.PlaceholderText = "";
                        this.EntradaSubTotal.ToolTipText = "";
                        this.EntradaSubTotal.TextChanged += new System.EventHandler(this.Importes_TextChanged);
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
                        // EntradaCantidad
                        // 
                        this.EntradaCantidad.AutoSize = false;
                        this.EntradaCantidad.AutoNav = true;
                        this.EntradaCantidad.AutoTab = true;
                        this.EntradaCantidad.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaCantidad.DecimalPlaces = -1;
                        this.EntradaCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCantidad.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCantidad.Location = new System.Drawing.Point(172, 68);
                        this.EntradaCantidad.MaxLenght = 32767;
                        this.EntradaCantidad.MultiLine = false;
                        this.EntradaCantidad.Name = "EntradaCantidad";
                        this.EntradaCantidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCantidad.PasswordChar = '\0';
                        this.EntradaCantidad.Prefijo = "";
                        this.EntradaCantidad.TemporaryReadOnly = true;
                        this.EntradaCantidad.SelectOnFocus = true;
                        this.EntradaCantidad.Size = new System.Drawing.Size(56, 24);
                        this.EntradaCantidad.Sufijo = "";
                        this.EntradaCantidad.TabIndex = 2;
                        this.EntradaCantidad.TabStop = false;
                        this.EntradaCantidad.Text = "0";
                        this.EntradaCantidad.PlaceholderText = "";
                        this.EntradaCantidad.ToolTipText = "";
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
                        // EntradaCajaOrigen
                        // 
                        this.EntradaCajaOrigen.AutoSize = false;
                        this.EntradaCajaOrigen.AutoNav = true;
                        this.EntradaCajaOrigen.AutoTab = true;
                        this.EntradaCajaOrigen.CanCreate = false;
                        this.EntradaCajaOrigen.DataTextField = "nombre";
                        this.EntradaCajaOrigen.ExtraDetailFields = null;
                        this.EntradaCajaOrigen.Filter = "";
                        this.EntradaCajaOrigen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCajaOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCajaOrigen.FreeTextCode = "";
                        this.EntradaCajaOrigen.DataValueField = "id_caja";
                        this.EntradaCajaOrigen.Location = new System.Drawing.Point(212, 232);
                        this.EntradaCajaOrigen.MaxLength = 200;
                        this.EntradaCajaOrigen.Name = "EntradaCajaOrigen";
                        this.EntradaCajaOrigen.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCajaOrigen.TemporaryReadOnly = false;
                        this.EntradaCajaOrigen.Required = true;
                        this.EntradaCajaOrigen.Size = new System.Drawing.Size(308, 24);
                        this.EntradaCajaOrigen.TabIndex = 12;
                        this.EntradaCajaOrigen.Table = "cajas";
                        this.EntradaCajaOrigen.Text = "0";
                        this.EntradaCajaOrigen.TextDetail = "";
                        this.EntradaCajaOrigen.PlaceholderText = "";
                        this.EntradaCajaOrigen.ToolTipText = "";
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
                        // EntradaTotal
                        // 
                        this.EntradaTotal.AutoSize = false;
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTotal.Location = new System.Drawing.Point(212, 196);
                        this.EntradaTotal.MaxLenght = 32767;
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.TemporaryReadOnly = false;
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(136, 28);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 10;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.PlaceholderText = "";
                        this.EntradaTotal.ToolTipText = "";
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
                        this.Controls.Add(this.EntradaCajaOrigen);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.EntradaTotal);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.EntradaImpuestos);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaSubTotal);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaCantidad);
                        this.Controls.Add(this.lblLabel1);
                        this.Controls.Add(this.label7);
                        this.Name = "Pagar";
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.lblLabel1, 0);
                        this.Controls.SetChildIndex(this.EntradaCantidad, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaSubTotal, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaImpuestos, 0);
                        this.Controls.SetChildIndex(this.Label8, 0);
                        this.Controls.SetChildIndex(this.EntradaTotal, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaCajaOrigen, 0);
                        this.ResumeLayout(false);

                }
                #endregion

                private void Importes_TextChanged(object sender, System.EventArgs e)
                {
                        EntradaTotal.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(EntradaSubTotal.Text) + Lfx.Types.Parsing.ParseCurrency(EntradaImpuestos.Text), this.Workspace.CurrentConfig.Moneda.Decimales);
                }

                public System.Windows.Forms.DialogResult Mostrar(IList<string> chequesAPagar)
                {
                        this.Cheques = chequesAPagar;

                        foreach (string ChequeId in Cheques) {
                                if (ChequesIds == null)
                                        ChequesIds = ChequeId;
                                else
                                        ChequesIds += "," + ChequeId;
                        }

                        if (ChequesIds != null) {
                                decimal Total = this.Connection.FieldDecimal("SELECT SUM(importe) FROM bancos_cheques WHERE id_cheque IN (" + ChequesIds + ")");

                                EntradaCantidad.ValueInt = Cheques.Count;
                                EntradaSubTotal.ValueDecimal = Total;
                                return this.ShowDialog();
                        } else {
                                return DialogResult.Cancel;
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();
                        if (EntradaCajaOrigen.TextInt <= 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar la cuenta de origen." + Environment.NewLine;
                        }
                        if (Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text) <= 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "El importe total debe ser mayor o igual a cero." + Environment.NewLine;
                        }
                        if (aceptarReturn.Success == true) {
                                decimal Impuestos = EntradaImpuestos.ValueDecimal;

                                IDbTransaction Trans = this.Connection.BeginTransaction(IsolationLevel.Serializable);

                                string ChequesNum = null;
                                System.Data.DataTable TablaCheques = Connection.Select("SELECT * FROM bancos_cheques WHERE id_cheque IN (" + ChequesIds + ")");
                                Lbl.Cajas.Caja CajaOrigen = new Lbl.Cajas.Caja(Connection, EntradaCajaOrigen.TextInt);
                                foreach (System.Data.DataRow RowCheque in TablaCheques.Rows) {
                                        Lbl.Bancos.Cheque Cheque = new Lbl.Bancos.Cheque(this.Connection, (Lfx.Data.Row)RowCheque);
                                        Cheque.Pagar(CajaOrigen);
                                }

                                if (Impuestos != 0)
                                        CajaOrigen.Movimiento(true, new Lbl.Cajas.Concepto(this.Connection, 23030),
                                                "Impuestos Cheques",
                                                null,
                                                -Impuestos,
                                                "Cheques Nº " + ChequesNum, null, null, null);

                                Trans.Commit();
                        }
                        return aceptarReturn;
                }
        }
}