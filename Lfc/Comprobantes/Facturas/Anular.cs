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
                        string TipoReal = "";

			switch (EntradaTipo.TextKey)
			{
				case "A":
					TipoReal = "'A', 'NCA', 'NDA'";
					break;

				case "B":
					TipoReal = "'B', 'NCB', 'NDB'";
					break;

                                case "C":
                                        TipoReal = "'C', 'NCC', 'NDC'";
                                        break;

                                case "E":
                                        TipoReal = "'E', 'NCE', 'NDE'";
                                        break;

                                case "M":
                                        TipoReal = "'M', 'NCM', 'NDM'";
                                        break;
			}

                        int IdFactura = 0;

                        if(PV > 0 && Numero > 0)
                                IdFactura = this.DataView.DataBase.FieldInt("SELECT id_factura FROM facturas WHERE tipo_fac IN (" + TipoReal + ") AND pv=" + PV.ToString() + " AND numero=" + Numero.ToString());

                        Lbl.Comprobantes.Factura Fac = null;
                        if (IdFactura > 0)
                                Fac = new Lbl.Comprobantes.Factura(this.DataView, IdFactura);

                        if (Fac != null && Fac.Existe) {
                                //Lfx.Data.Row row = this.Workspace.DefaultDataBase.FirstRowFromSelect("SELECT * FROM facturas WHERE tipo_fac IN (" + TipoReal + ") AND pv=" + PV.ToString() + " AND numero=" + Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString());
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
                                }
                        } else {
                                if (ProximosNumeros.ContainsKey(PV) == false)
                                        ProximosNumeros[PV] = this.DataView.DataBase.FieldInt("SELECT MAX(numero) FROM facturas WHERE tipo_fac IN (" + TipoReal + ") AND impresa>0 AND pv=" + PV.ToString()) + 1;

                                if (Numero == ((int)(ProximosNumeros[PV]))) {
                                        EtiquetaAviso.Text = "El comprobante " + EntradaTipo.TextKey + " " + PV.ToString("0000") + "-" + Numero.ToString("00000000") + " aun no fue impreso, pero es el próximo en el talonario. Si lo anula, el sistema salteará dicho comprobante.";
                                        ComprobanteVistaPrevia.Elemento = null;
                                        ComprobanteVistaPrevia.Visible = false;
                                        OkButton.Visible = true;
                                } else {
                                        EtiquetaAviso.Text = "El comprobante " + EntradaTipo.TextKey + " " + PV.ToString("0000") + "-" + Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString("00000000") + " aun no fue impreso y no puede anularse.";
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

				this.DataView.BeginTransaction();
				int m_Id = 0;
				string TipoReal = "";

				switch (EntradaTipo.TextKey)
				{
					case "A":
						TipoReal = "'A', 'NCA', 'NDA'";
						break;

					case "B":
						TipoReal = "'B', 'NCB', 'NDB'";
						break;

                                        case "C":
                                                TipoReal = "'C', 'NCC', 'NDC'";
                                                break;

                                        case "E":
                                                TipoReal = "'E', 'NCE', 'NDE'";
                                                break;

                                        case "M":
                                                TipoReal = "'M', 'NCM', 'NDM'";
                                                break;
				}

				int IdFactura = DataView.DataBase.FieldInt("SELECT id_factura FROM facturas WHERE tipo_fac IN (" + TipoReal + ") AND pv=" + PV.ToString() + " AND numero=" + Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString());

                                if (IdFactura == 0) {
                                        // Es una factura que todava no existe
                                        // Tengo que crear la factura y anularla
                                        DataView.DataBase.Execute("INSERT INTO facturas (tipo_fac, id_formapago, id_sucursal, pv, fecha, id_vendedor, id_cliente, obs, impresa, anulada) VALUES ('" + EntradaTipo.TextKey + "', 3, " + this.Workspace.CurrentConfig.Company.CurrentBranch.ToString() + ", " + EntradaPV.Text + ", NOW(), " + this.Workspace.CurrentUser.Id.ToString() + ", " + this.Workspace.CurrentUser.Id.ToString() + ", 'Comprobante anulado antes de ser impreso.', 1, 1)");
                                        m_Id = DataView.DataBase.FieldInt("SELECT MAX(id_factura) AS id_factura FROM facturas WHERE tipo_fac='" + EntradaTipo.TextKey + "'");
                                        Lbl.Comprobantes.Numerador.Numerar(DataView, m_Id);
                                        Lui.Forms.MessageBox.Show("Se anuló el comprobante " + Lbl.Comprobantes.Comprobante.NumeroCompleto(DataView, m_Id) + ". Recuerde archivar ambas copias.", "Aviso");
                                } else {
                                        Lbl.Comprobantes.Factura Fac = new Lbl.Comprobantes.Factura(DataView, IdFactura);
                                        Fac.Anular(AnularPagos);
                                        Lui.Forms.MessageBox.Show("Se anuló el comprobante " + Fac.ToString() + ". Recuerde archivar ambas copias.", "Aviso");
                                }

				this.DataView.Commit();

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