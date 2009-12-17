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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Compra
{
        public class Listado : Lui.Forms.TextListingForm
        {

                internal string m_Tipo;
                internal Lfx.Types.DateRange m_Fecha;
                internal int m_Proveedor;
                internal string m_Agrupar = "";
                internal string Filtro;

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
                internal Lui.Forms.ComboBox txtMostrar;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox txtAgrupar;
                internal System.Windows.Forms.Label Label1;

                private void InitializeComponent()
                {
                        this.txtReporte = new Lui.Forms.TextBox();
                        this.txtMostrar = new Lui.Forms.ComboBox();
                        this.Label2 = new System.Windows.Forms.Label();
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
                        this.txtReporte.DockPadding.All = 2;
                        this.txtReporte.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtReporte.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtReporte.Location = new System.Drawing.Point(4, 32);
                        this.txtReporte.MaxLenght = 32767;
                        this.txtReporte.MultiLine = true;
                        this.txtReporte.Name = "txtReporte";
                        this.txtReporte.ReadOnly = true;
                        this.txtReporte.SelectOnFocus = false;
                        this.txtReporte.Size = new System.Drawing.Size(568, 284);
                        this.txtReporte.TabIndex = 51;
                        this.txtReporte.ToolTipText = "";
                        this.txtReporte.Workspace = null;
                        // 
                        // txtMostrar
                        // 
                        this.txtMostrar.AutoNav = true;
                        this.txtMostrar.AutoTab = true;
                        this.txtMostrar.DockPadding.All = 2;
                        this.txtMostrar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtMostrar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtMostrar.Location = new System.Drawing.Point(360, 4);
                        this.txtMostrar.MaxLenght = 32767;
                        this.txtMostrar.Name = "txtMostrar";
                        this.txtMostrar.ReadOnly = false;
                        this.txtMostrar.SetData = new string[] {
													   "Todo|1",
													   "Sólo los Subtotales|0"};
                        this.txtMostrar.Size = new System.Drawing.Size(196, 24);
                        this.txtMostrar.TabIndex = 55;
                        this.txtMostrar.Text = "Todo";
                        this.txtMostrar.TextKey = "1";
                        this.txtMostrar.ToolTipText = "";
                        this.txtMostrar.Workspace = null;
                        this.txtMostrar.TextChanged += new System.EventHandler(this.txtAgrupar_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(304, 4);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(56, 24);
                        this.Label2.TabIndex = 54;
                        this.Label2.Text = "Mostrar";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtAgrupar
                        // 
                        this.txtAgrupar.AutoNav = true;
                        this.txtAgrupar.AutoTab = true;
                        this.txtAgrupar.DockPadding.All = 2;
                        this.txtAgrupar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtAgrupar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtAgrupar.Location = new System.Drawing.Point(96, 4);
                        this.txtAgrupar.MaxLenght = 32767;
                        this.txtAgrupar.Name = "txtAgrupar";
                        this.txtAgrupar.ReadOnly = false;
                        this.txtAgrupar.SetData = new string[] {
													   "Sin Agrupar|*",
													   "Por Tipo de Comprobante|tipo_fac",
													   "Por Proveedor|id_proveedor",
													   "Por Día de la Semana|DAYOFWEEK(fecha)",
													   "Por Día del Mes|DAYOFMONTH(fecha)"};
                        this.txtAgrupar.Size = new System.Drawing.Size(196, 24);
                        this.txtAgrupar.TabIndex = 53;
                        this.txtAgrupar.Text = "Sin Agrupar";
                        this.txtAgrupar.TextKey = "*";
                        this.txtAgrupar.ToolTipText = "";
                        this.txtAgrupar.Workspace = null;
                        this.txtAgrupar.TextChanged += new System.EventHandler(this.txtAgrupar_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(8, 4);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(88, 24);
                        this.Label1.TabIndex = 52;
                        this.Label1.Text = "Agrupar Por";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FormPedidosListado
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(576, 377);
                        this.Controls.Add(this.txtMostrar);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtAgrupar);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtReporte);
                        this.Name = "FormPedidosListado";
                        this.ResumeLayout(false);

                }


                #endregion

                public override Lfx.Types.OperationResult RefreshList()
                {
                        Lfx.Types.OperationResult mostrarReturn = base.RefreshList();

                        if (mostrarReturn.Success == true) {
                                Filtro = "compra=1";
                                bool MostrarDetalles = System.Convert.ToBoolean(Lfx.Types.Parsing.ParseInt(txtMostrar.TextKey));
                                switch (m_Tipo) {
                                        case "":
                                                //Nana
                                                break;
                                        case "NP":
                                        case "PD":
                                                Filtro += " AND facturas.tipo_fac='" + m_Tipo + "'";
                                                break;
                                        case "RP":
                                        case "R":
                                                Filtro += " AND facturas.tipo_fac='R'";
                                                break;
                                        case "FP":
                                        case "A":
                                        case "B":
                                        case "C":
                                        case "E":
                                        case "M":
                                                Filtro += " AND facturas.tipo_fac IN ('A', 'B', 'C', 'E', 'M')";
                                                break;
                                        default:
                                                Filtro += " AND facturas.tipo_fac='" + m_Tipo + "'";
                                                break;
                                }


                                if (m_Proveedor > 0)
                                        Filtro += " AND (facturas.id_cliente='" + m_Proveedor.ToString() + "')";


                                Filtro += " AND total<>0";

                                if (m_Fecha.HasRange)
                                        Filtro += " AND (fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.To) + " 23:59:59')";


                                string TextoSql = null;

                                if (m_Agrupar.Length > 0) {
                                        TextoSql = "SELECT *, DAYOFWEEK(fecha), DAYOFMONTH(fecha) FROM facturas WHERE (" + Filtro + ") ORDER BY " + m_Agrupar + ", RIGHT(tipo_fac, 1), pv, numero";
                                } else {
                                        TextoSql = "SELECT * FROM facturas WHERE (" + Filtro + ") ORDER BY RIGHT(tipo_fac, 1), pv, numero";
                                }

                                System.Data.DataTable TmpTabla = this.Workspace.DefaultDataBase.Select(TextoSql);

                                ListingContent = new System.Text.StringBuilder();
                                ListingContent.Append("LISTADO DE COMPROBANTES DE COMPRA - Fecha " + m_Fecha.From.ToString(Lfx.Types.Formatting.DateTime.DefaultDateFormat));
                                if (m_Fecha.From != m_Fecha.To) {
                                        ListingContent.Append(" al " + m_Fecha.To.ToString(Lfx.Types.Formatting.DateTime.DefaultDateFormat));
                                }

                                ListingContent.Append(Environment.NewLine);
                                ListingContent.Append("-------------------------------------------------------------------------------" + Environment.NewLine);
                                ListingContent.Append("Fecha      T   Número        Proveedor                 CUIT               Total" + Environment.NewLine);
                                ListingContent.Append("===============================================================================" + Environment.NewLine);
                                ListingContent.Append(Environment.NewLine);

                                double dTotal = 0;
                                double dSubTotal = 0;
                                string LastAgrupar = "slfadf*af*df*asdf";
                                foreach (System.Data.DataRow row in TmpTabla.Rows) {
                                        if (m_Agrupar.Length > 0 && row[m_Agrupar].ToString() != LastAgrupar) {
                                                LastAgrupar = row[m_Agrupar].ToString();
                                                if (dSubTotal > 0) {
                                                        ListingContent.Append("                    SUBTOTAL: " + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(dSubTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces) + Environment.NewLine);
                                                        dSubTotal = 0;
                                                }
                                                switch (m_Agrupar) {
                                                        case "id_proveedor":
                                                                ListingContent.Append(Environment.NewLine + this.Workspace.DefaultDataBase.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + LastAgrupar) + Environment.NewLine);
                                                                break;
                                                        case "DAYOFWEEK(fecha)":
                                                                switch (System.Convert.ToInt32(row[m_Agrupar])) {
                                                                        case 1:
                                                                                ListingContent.Append(Environment.NewLine + "Domingo" + Environment.NewLine);
                                                                                break;
                                                                        case 2:
                                                                                ListingContent.Append(Environment.NewLine + "Lunes" + Environment.NewLine);
                                                                                break;
                                                                        case 3:
                                                                                ListingContent.Append(Environment.NewLine + "Martes" + Environment.NewLine);
                                                                                break;
                                                                        case 4:
                                                                                ListingContent.Append(Environment.NewLine + "Mircoles" + Environment.NewLine);
                                                                                break;
                                                                        case 5:
                                                                                ListingContent.Append(Environment.NewLine + "Jueves" + Environment.NewLine);
                                                                                break;
                                                                        case 6:
                                                                                ListingContent.Append(Environment.NewLine + "Viernes" + Environment.NewLine);
                                                                                break;
                                                                        case 7:
                                                                                ListingContent.Append(Environment.NewLine + "Sbado" + Environment.NewLine);
                                                                                break;
                                                                }

                                                                break;
                                                        case "DAYOFMONTH(fecha)":
                                                                ListingContent.Append(Environment.NewLine + System.Convert.ToDateTime(row["fecha"]).ToString("dd-MM-yyyy") + Environment.NewLine);
                                                                break;
                                                        default:
                                                                ListingContent.Append(LastAgrupar + Environment.NewLine);
                                                                break;
                                                }

                                                ListingContent.Append("-------------------------------------------------------------------------------" + Environment.NewLine);
                                        }

                                        System.Text.StringBuilder Renglon = new System.Text.StringBuilder();
                                        Renglon.Append(Lfx.Types.Formatting.FormatDate(row["fecha"]) + " ");
                                        Renglon.Append(System.Convert.ToString(row["tipo_fac"]).PadRight(3).Substring(0, 3) + " ");
                                        Renglon.Append(System.Convert.ToString(row["numero"]).PadRight(13).Substring(0, 13) + " ");
                                        int ProveedorId = System.Convert.ToInt32(row["id_cliente"]);
                                        if (ProveedorId != 0) {
                                                Lfx.Data.Row Proveedor = this.Workspace.DefaultDataBase.Row("personas", "id_persona", ProveedorId);
                                                Renglon.Append(System.Convert.ToString(Proveedor["nombre_visible"]).PadRight(25).Substring(0, 25) + " ");
                                                Renglon.Append(System.Convert.ToString(Proveedor["cuit"]).PadRight(13).Substring(0, 13) + " ");
                                        } else {
                                                Renglon.Append("".PadRight(25).Substring(0, 25) + " ");
                                                Renglon.Append("".PadRight(13).Substring(0, 13) + " ");
                                        }
                                        Renglon.Append(Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(row["total"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces).PadLeft(10));
                                        dTotal += System.Convert.ToDouble(row["total"]);
                                        dSubTotal += System.Convert.ToDouble(row["total"]);
                                        if (MostrarDetalles) {
                                                ListingContent.Append(Renglon.ToString() + Environment.NewLine);
                                        }

                                }
                                if (m_Agrupar.Length > 0 && dSubTotal > 0) {
                                        ListingContent.Append("                    SUBTOTAL: " + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(dSubTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces) + Environment.NewLine);
                                        dSubTotal = 0;
                                }

                                ListingContent.Append(Environment.NewLine);
                                ListingContent.Append("===============================================================================" + Environment.NewLine);
                                ListingContent.Append("            Total   : " + Lfx.Types.Formatting.FormatCurrency(dTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces) + Environment.NewLine);
                                txtReporte.Text = ListingContent.ToString();
                        }

                        return mostrarReturn;
                }


                private void txtAgrupar_TextChanged(System.Object sender, System.EventArgs e)
                {
                        string NuevoAgrupar = txtAgrupar.TextKey;
                        if (NuevoAgrupar == "*") {
                                NuevoAgrupar = "";
                        }

                        if (NuevoAgrupar != m_Agrupar) {
                                m_Agrupar = NuevoAgrupar;
                                this.RefreshList();
                        }
                }
        }
}