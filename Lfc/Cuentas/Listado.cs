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

namespace Lfc.Cuentas
{
        public class Listado : Lui.Forms.TextListingForm
        {
                internal int m_Cuenta = 999;
                protected internal int m_TipoConcepto;
                internal Lfx.Types.DateRange m_Fechas;
                internal int m_Concepto = 0, m_Persona = 0, m_Direccion = 0;
                internal string m_Agrupar = "";

                #region Código generado por el Diseñador de Windows Forms

                public Listado()
                        : base()
                {


                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent

                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
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
                internal Lui.Forms.TextBox txtReporte;
                internal Lui.Forms.ComboBox txtAgrupar;
                internal System.Windows.Forms.Label Label1;

                private void InitializeComponent()
                {
                        this.txtReporte = new Lui.Forms.TextBox();
                        this.txtAgrupar = new Lui.Forms.ComboBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // txtReporte
                        // 
                        this.txtReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtReporte.AutoNav = true;
                        this.txtReporte.AutoTab = true;
                        this.txtReporte.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtReporte.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtReporte.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtReporte.Location = new System.Drawing.Point(8, 32);
                        this.txtReporte.MaxLenght = 32767;
                        this.txtReporte.MultiLine = true;
                        this.txtReporte.Name = "txtReporte";
                        this.txtReporte.Padding = new System.Windows.Forms.Padding(2);
                        this.txtReporte.ReadOnly = true;
                        this.txtReporte.SelectOnFocus = false;
                        this.txtReporte.Size = new System.Drawing.Size(708, 308);
                        this.txtReporte.TabIndex = 2;
                        this.txtReporte.TipWhenBlank = "";
                        this.txtReporte.ToolTipText = "";
                        // 
                        // txtAgrupar
                        // 
                        this.txtAgrupar.AutoNav = true;
                        this.txtAgrupar.AutoTab = true;
                        this.txtAgrupar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtAgrupar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtAgrupar.Location = new System.Drawing.Point(100, 8);
                        this.txtAgrupar.MaxLenght = 32767;
                        this.txtAgrupar.Name = "txtAgrupar";
                        this.txtAgrupar.Padding = new System.Windows.Forms.Padding(2);
                        this.txtAgrupar.ReadOnly = false;
                        this.txtAgrupar.SetData = new string[] {
        "Sin Agrupar|*",
        "Por Concepto|id_concepto",
        "Por Persona|id_cliente",
        "Por Día|dia"};
                        this.txtAgrupar.Size = new System.Drawing.Size(196, 24);
                        this.txtAgrupar.TabIndex = 1;
                        this.txtAgrupar.Text = "Sin Agrupar";
                        this.txtAgrupar.TextKey = "*";
                        this.txtAgrupar.TipWhenBlank = "";
                        this.txtAgrupar.ToolTipText = "";
                        this.txtAgrupar.TextChanged += new System.EventHandler(this.txtAgrupar_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(8, 8);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(92, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Agrupar por";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FormCuentaCajaListadoIE
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(724, 409);
                        this.Controls.Add(this.txtAgrupar);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtReporte);
                        this.Name = "FormCuentaCajaListadoIE";
                        this.Controls.SetChildIndex(this.txtReporte, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.txtAgrupar, 0);
                        this.ResumeLayout(false);

                }


                #endregion

                public override Lfx.Types.OperationResult RefreshList()
                {
                        Lfx.Types.OperationResult mostrarReturn = new Lfx.Types.SuccessOperationResult();

                        mostrarReturn = base.RefreshList();

                        if (mostrarReturn.Success == true) {
                                string sFecha1 = Lfx.Types.Formatting.FormatDateSql(m_Fechas.From);
                                string sFecha2 = Lfx.Types.Formatting.FormatDateSql(m_Fechas.To);
                                string TextoSql = null;

                                TextoSql = "SELECT cuentas_movim.* FROM cuentas_movim";

                                if (m_TipoConcepto > 0)
                                        TextoSql += " LEFT JOIN cuentas_conceptos ON cuentas_movim.id_concepto=cuentas_conceptos.id_concepto";

                                TextoSql += " WHERE (TRUE";
                                if (m_Cuenta > 0)
                                        TextoSql += " AND cuentas_movim.id_cuenta = " + m_Cuenta.ToString();

                                TextoSql += " AND cuentas_movim.fecha BETWEEN '" + sFecha1 + " 00:00:00' AND '" + sFecha2 + " 23:59:59'";
                                if (m_Concepto > 0)
                                        TextoSql += " AND cuentas_movim.id_concepto=" + m_Concepto.ToString();

                                if (m_Persona > 0)
                                        TextoSql += " AND cuentas_movim.id_cliente=" + m_Persona.ToString();

                                if (m_TipoConcepto > 0)
                                        TextoSql += " AND cuentas_conceptos.grupo=" + m_TipoConcepto.ToString();


                                if (m_Direccion == 1)
                                        TextoSql += " AND cuentas_movim.importe>=0";
                                else if (m_Direccion == 2)
                                        TextoSql += " AND cuentas_movim.importe<0";

                                if (m_Agrupar.Length > 0 && m_Agrupar != "dia")
                                        TextoSql += ") ORDER BY " + m_Agrupar + ", fecha";
                                else
                                        TextoSql += ") ORDER BY cuentas_movim.fecha";

                                System.Data.DataTable TmpTabla = this.Workspace.DefaultDataBase.Select(TextoSql);

                                ListingContent = new System.Text.StringBuilder();
                                ListingContent.Append(this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM cuentas WHERE id_cuenta=" + m_Cuenta.ToString()) + " - Fecha " + m_Fechas.From);
                                if (m_Fechas.Diff.Days > 0)
                                        ListingContent.Append(" al " + m_Fechas.To);

                                ListingContent.AppendLine();
                                ListingContent.AppendLine("-------------------------------------------------------------------------------");
                                ListingContent.AppendLine("Fecha       Concepto                                          Débito    Crédito");
                                ListingContent.AppendLine("===============================================================================");
                                ListingContent.AppendLine();

                                double Transporte = Math.Round(this.Workspace.DefaultDataBase.FieldDouble("SELECT saldo FROM cuentas_movim WHERE  id_cuenta=" + m_Cuenta.ToString() + " AND fecha<'" + Lfx.Types.Formatting.FormatDateTimeSql(m_Fechas.From).ToString() + "' ORDER BY id_movim DESC"), this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                                double SubTotal = 0; double Ingresos = 0; double Egresos = 0; string LastAgrupar = "slfadf*af*df*asdf";
                                foreach (System.Data.DataRow row in TmpTabla.Rows) {
                                        if (m_Agrupar.Length > 0) {
                                                string NuevoAgrupar = null;
                                                if (m_Agrupar == "dia")
                                                        NuevoAgrupar = Lfx.Types.Formatting.FormatDate(row["fecha"]).Substring(0, 2);
                                                else
                                                        NuevoAgrupar = row[m_Agrupar].ToString();
                                                if (NuevoAgrupar != LastAgrupar) {
                                                        LastAgrupar = NuevoAgrupar;
                                                        if (SubTotal != 0) {
                                                                ListingContent.AppendLine("                    SUBTOTAL: " + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(SubTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces));
                                                                SubTotal = 0;
                                                        }
                                                        switch (m_Agrupar) {
                                                                case "id_vendedor":
                                                                case "id_cliente":
                                                                case "id_persona":
                                                                        ListingContent.AppendLine(Environment.NewLine + this.Workspace.DefaultDataBase.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + LastAgrupar));
                                                                        break;
                                                                case "id_concepto":
                                                                        if (LastAgrupar.Length > 0) {
                                                                                string Concepto = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM cuentas_conceptos WHERE id_concepto=" + LastAgrupar);
                                                                                if (Concepto.Length > 0)
                                                                                        ListingContent.AppendLine(Environment.NewLine + Concepto);
                                                                                else
                                                                                        ListingContent.AppendLine(Environment.NewLine + "(Sin Concepto)");
                                                                        }
                                                                        break;
                                                                case "dia":
                                                                        ListingContent.AppendLine(Environment.NewLine + Lfx.Types.Formatting.FormatDate(row["fecha"]));
                                                                        break;
                                                                default:
                                                                        ListingContent.AppendLine(LastAgrupar);
                                                                        break;
                                                        }

                                                        ListingContent.AppendLine("-------------------------------------------------------------------------------");
                                                }
                                        }

                                        string sRenglon = null;
                                        sRenglon = Lfx.Types.Formatting.FormatDate(row["fecha"]);

                                        System.Text.StringBuilder Detalle = new System.Text.StringBuilder();
                                        if (m_Agrupar != "id_concepto") {
                                                string NombreConcepto = null;
                                                if (Lfx.Data.DataBase.ConvertDBNullToZero(row["id_concepto"]) > 0)
                                                        NombreConcepto = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM cuentas_conceptos WHERE id_concepto=" + row["id_concepto"].ToString());
                                                else if (System.Convert.ToString(row["concepto"]).Length > 0)
                                                        NombreConcepto = System.Convert.ToString(row["concepto"]);
                                                Detalle.Append(NombreConcepto.PadRight(20).Substring(0, 20) + ". ");
                                        }
                                        if (Lfx.Data.DataBase.ConvertDBNullToZero(row["id_factura"]) > 0)
                                                Detalle.Append(Lbl.Comprobantes.Comprobante.NumeroCompleto(this.Workspace.DefaultDataView, Lfx.Data.DataBase.ConvertDBNullToZero(row["id_factura"])));

                                        if (Lfx.Data.DataBase.ConvertDBNullToZero(row["id_cliente"]) > 0) {
                                                string NombreCliente = this.Workspace.DefaultDataBase.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + row["id_cliente"].ToString());
                                                int ObsWidth = 32;
                                                if (System.Convert.ToString(row["obs"]).Length > 5)
                                                        ObsWidth = 14;

                                                Detalle.Append((" (" + NombreCliente + ") ").PadRight(32).Substring(0, ObsWidth));
                                        }
                                        if (System.Convert.ToString(row["obs"]).Length > 0)
                                                Detalle.Append(" " + System.Convert.ToString(row["obs"]).Replace(Environment.NewLine, " "));

                                        if (System.Convert.ToString(row["comprob"]).Length > 0) {
                                                if (Detalle.Length > 0)
                                                        Detalle.Append(" / ");

                                                Detalle.Append(System.Convert.ToString(row["comprob"]).Replace(Environment.NewLine, " "));
                                        }

                                        sRenglon += ("  " + Detalle.ToString().Replace("  ", " ").Trim() + "                                                      ").Substring(0, 47);

                                        if (System.Convert.ToDouble(row["importe"]) < 0) {
                                                Egresos += Math.Abs(System.Convert.ToDouble(row["importe"]));
                                                sRenglon += " " + Lfx.Types.Formatting.FormatCurrency(Math.Abs(System.Convert.ToDouble(row["importe"])), this.Workspace.CurrentConfig.Currency.DecimalPlaces).PadLeft(10);
                                                sRenglon += " " + "          ";
                                        } else {
                                                Ingresos += System.Convert.ToDouble(row["importe"]);
                                                sRenglon += " " + "          ";
                                                sRenglon += " " + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(row["importe"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces).PadLeft(10);
                                        }
                                        SubTotal += System.Convert.ToDouble(row["importe"]);

                                        ListingContent.AppendLine(sRenglon);
                                }
                                if (m_Agrupar.Length > 0 && SubTotal != 0) {
                                        ListingContent.AppendLine("                    SUBTOTAL: " + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(SubTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces));
                                        SubTotal = 0;
                                }
                                // If dSubTotal Then ListingContent.Append(environment.NewLine & "            SUBTOTAL: " & Lfx.Types.Formatting.FormatCurrency(dSubTotal) & environment.NewLine & environment.NewLine)
                                ListingContent.AppendLine();
                                ListingContent.AppendLine("===============================================================================");
                                ListingContent.AppendLine("            Transporte: $ " + Lfx.Types.Formatting.FormatCurrency(Transporte, this.Workspace.CurrentConfig.Currency.DecimalPlaces));
                                ListingContent.AppendLine("            Ingresos  : $ " + Lfx.Types.Formatting.FormatCurrency(Ingresos, this.Workspace.CurrentConfig.Currency.DecimalPlaces));
                                ListingContent.AppendLine("            Egresos   : $ " + Lfx.Types.Formatting.FormatCurrency(Egresos, this.Workspace.CurrentConfig.Currency.DecimalPlaces));
                                ListingContent.AppendLine("            Saldo     : $ " + Lfx.Types.Formatting.FormatCurrency(Transporte + Ingresos - Egresos, this.Workspace.CurrentConfig.Currency.DecimalPlaces));
                                txtReporte.Text = ListingContent.ToString();
                        }

                        return mostrarReturn;
                }


                private void txtAgrupar_TextChanged(System.Object sender, System.EventArgs e)
                {
                        string NuevoAgrupar = txtAgrupar.TextKey;
                        if (NuevoAgrupar == "*")
                                NuevoAgrupar = "";

                        if (NuevoAgrupar != m_Agrupar) {
                                m_Agrupar = NuevoAgrupar;
                                this.RefreshList();
                        }
                }


        }
}