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

namespace Lfc.Comprobantes.Facturas
{
	public partial class Anular : Lui.Forms.ChildDialogForm
	{
		System.Collections.Hashtable ProximosNumeros = new System.Collections.Hashtable();

                public Anular()
                        : base()
                {
                        InitializeComponent();

                        OkButton.Text = "Anular";
                        OkButton.Visible = false;
                }

		private void EntradaNumeroTipoPV_TextChanged(object sender, System.EventArgs e)
		{
			int PV = Lfx.Types.Parsing.ParseInt(EntradaPV.Text);
                        int Numero = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text);
                        string IncluyeTipos = "";

			switch (EntradaTipo.TextKey)
			{
				case "A":
					IncluyeTipos = "'FA', 'NCA', 'NDA'";
					break;

				case "B":
					IncluyeTipos = "'FB', 'NCB', 'NDB'";
					break;

                                case "C":
                                        IncluyeTipos = "'FC', 'NCC', 'NDC'";
                                        break;

                                case "E":
                                        IncluyeTipos = "'FE', 'NCE', 'NDE'";
                                        break;

                                case "M":
                                        IncluyeTipos = "'FM', 'NCM', 'NDM'";
                                        break;
			}

                        int IdFactura = 0;

                        if(PV > 0 && Numero > 0)
                                IdFactura = this.DataBase.FieldInt("SELECT id_comprob FROM comprob WHERE tipo_fac IN (" + IncluyeTipos + ") AND pv=" + PV.ToString() + " AND numero=" + Numero.ToString());

                        Lbl.Comprobantes.Factura Fac = null;
                        if (IdFactura > 0)
                                Fac = new Lbl.Comprobantes.Factura(this.DataBase, IdFactura);

                        if (Fac != null && Fac.Existe) {
                                //Lfx.Data.Row row = this.DataBase.FirstRowFromSelect("SELECT * FROM comprob WHERE tipo_fac IN (" + TipoReal + ") AND pv=" + PV.ToString() + " AND numero=" + Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString());
                                ComprobanteVistaPrevia.Elemento = Fac;
                                ComprobanteVistaPrevia.Visible = true;

                                if (Fac.Anulado) {
                                        EtiquetaAviso.Text = "El comprobante ya fue anulado y no puede anularse nuevamente.";
                                        OkButton.Visible = false;
                                } else if (Fac.Impreso == false) {
                                        EtiquetaAviso.Text = "El comprobante no puede anularse porque todavía no fue impreso.";
                                        OkButton.Visible = false;
                                } else {
                                        EtiquetaAviso.Text = "Recuerde que necesitar archivar todas las copias del comprobante anulado.";
                                        OkButton.Visible = true;
                                        if (Fac.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.CuentaCorriente) {
                                                EntradaAnularPagos.TextKey = "1";
                                        } else {
                                                EntradaAnularPagos.TextKey = "0";
                                        }
                                }
                        } else {
                                if (ProximosNumeros.ContainsKey(PV) == false)
                                        ProximosNumeros[PV] = this.DataBase.FieldInt("SELECT MAX(numero) FROM comprob WHERE tipo_fac IN (" + IncluyeTipos + ") AND impresa>0 AND pv=" + PV.ToString()) + 1;

                                if (Numero == ((int)(ProximosNumeros[PV]))) {
                                        EtiquetaAviso.Text = "El comprobante " + EntradaTipo.TextKey + " " + PV.ToString("0000") + "-" + Numero.ToString("00000000") + " aun no fue impreso, pero es el próximo en el talonario. Si lo anula, el sistema salteará dicho comprobante.";
                                        ComprobanteVistaPrevia.Elemento = null;
                                        ComprobanteVistaPrevia.Visible = false;
                                        OkButton.Visible = true;
                                } else {
                                        EtiquetaAviso.Text = "El comprobante " + EntradaTipo.TextKey + " " + PV.ToString("0000") + "-" + Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString("00000000") + " aun no fue impreso y no puede anularse.";
                                        EntradaAnularPagos.TextKey = "0";
                                        ComprobanteVistaPrevia.Elemento = null;
                                        ComprobanteVistaPrevia.Visible = false;
                                        OkButton.Visible = false;
                                }
                        }
		}

		public override Lfx.Types.OperationResult Ok()
		{
			Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Una vez anulado, el comprobante deberá ser archivado en todas sus copias y no podrá ser rehabilitado ni reutilizado.", "¿Está seguro de que desea anular el comprobante?");
			Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;

			if (Pregunta.ShowDialog() == DialogResult.OK)
			{
				int PV = Lfx.Types.Parsing.ParseInt(EntradaPV.Text);
                                bool AnularPagos = Lfx.Types.Parsing.ParseInt(EntradaAnularPagos.TextKey) != 0;

				this.DataBase.BeginTransaction(true);
				int m_Id = 0;
				string IncluyeTipos = "";

				switch (EntradaTipo.TextKey)
				{
					case "A":
						IncluyeTipos = "'FA', 'NCA', 'NDA'";
						break;

					case "B":
						IncluyeTipos = "'FB', 'NCB', 'NDB'";
						break;

                                        case "C":
                                                IncluyeTipos = "'FC', 'NCC', 'NDC'";
                                                break;

                                        case "E":
                                                IncluyeTipos = "'FE', 'NCE', 'NDE'";
                                                break;

                                        case "M":
                                                IncluyeTipos = "'FM', 'NCM', 'NDM'";
                                                break;
				}

				int IdFactura = DataBase.FieldInt("SELECT id_comprob FROM comprob WHERE tipo_fac IN (" + IncluyeTipos + ") AND pv=" + PV.ToString() + " AND numero=" + Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString());

                                if (IdFactura == 0) {
                                        // Es una factura que todava no existe
                                        // Tengo que crear la factura y anularla
                                        qGen.Insert InsertarComprob = new qGen.Insert("comprob");
                                        InsertarComprob.Fields.AddWithValue("tipo_fac", "F" + EntradaTipo.TextKey);
                                        InsertarComprob.Fields.AddWithValue("id_formapago", 3);
                                        InsertarComprob.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Company.CurrentBranch);
                                        InsertarComprob.Fields.AddWithValue("pv", Lfx.Types.Parsing.ParseInt(EntradaPV.Text));
                                        InsertarComprob.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                        InsertarComprob.Fields.AddWithValue("id_vendedor", this.Workspace.CurrentUser.Id);
                                        InsertarComprob.Fields.AddWithValue("id_cliente", this.Workspace.CurrentUser.Id);
                                        InsertarComprob.Fields.AddWithValue("obs", "Comprobante anulado antes de ser impreso.");
                                        InsertarComprob.Fields.AddWithValue("impresa", 1);
                                        InsertarComprob.Fields.AddWithValue("anulada", 1);
                                        DataBase.Execute(InsertarComprob);
                                        m_Id = DataBase.FieldInt("SELECT LAST_INSERT_ID()");
                                        Lbl.Comprobantes.Numerador.Numerar(DataBase, m_Id);
                                        Lui.Forms.MessageBox.Show("Se anuló el comprobante " + Lbl.Comprobantes.Comprobante.NumeroCompleto(DataBase, m_Id) + ". Recuerde archivar ambas copias.", "Aviso");
                                } else {
                                        Lbl.Comprobantes.Factura Fac = new Lbl.Comprobantes.Factura(DataBase, IdFactura);
                                        Fac.Anular(AnularPagos);
                                        Lui.Forms.MessageBox.Show("Se anuló el comprobante " + Fac.ToString() + ". Recuerde archivar ambas copias.", "Aviso");
                                }

                                ProximosNumeros.Clear();

				this.DataBase.Commit();

				EntradaNumero.Text = "";
				EntradaNumero.Focus();

				return new Lfx.Types.OperationResult(false);
			}
			else
			{
				return new Lfx.Types.FailureOperationResult("La operación fue cancelada.");
			}
		}
	}
}