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

namespace Lfc.Comprobantes.Presupuestos
{
        public partial class Editar : Lfc.Comprobantes.Editar
	{
		//private bool Ticker_IgnorarEventos;

                public Editar(string tipo) : this()
                {
                        TipoPredet = tipo;
                }

                public Editar() : base()
                {
                        InitializeComponent();

                        //this.ProductArray.LostFocus += new System.EventHandler(this.ProductArray_LostFocus);
			//this.ProductArray.TotalChanged += new System.EventHandler(this.ProductArray_TotalChanged);
                }

		/* TODO: obsolete private void ProductArray_LostFocus(object sender, System.EventArgs e)
		{
			if (Ticker_IgnorarEventos == false && Lfc.Misc.Estaticos.FormularioTickerPresupuestos != null)
                                Lfc.Misc.Estaticos.FormularioTickerPresupuestos.MostrarPresupuesto(this);
		}


		private void ProductArray_TotalChanged(System.Object sender, System.EventArgs e)
		{
			if (Ticker_IgnorarEventos == false && Lfc.Misc.Estaticos.FormularioTickerPresupuestos != null)
				Lfc.Misc.Estaticos.FormularioTickerPresupuestos.MostrarPresupuestoValores(this);
		} */


		public override Lfx.Types.OperationResult Edit(int iId)
		{
			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();
			//Ticker_IgnorarEventos = true;
			ResultadoEditar = base.Edit(iId);
			//Ticker_IgnorarEventos = false;
			ProductArray.ShowStock = true;
			/* TODO: obsolete
			if (Lfc.Misc.Estaticos.FormularioTickerPresupuestos != null)
				Lfc.Misc.Estaticos.FormularioTickerPresupuestos.MostrarPresupuesto(this);
			*/
                        return ResultadoEditar;
		}


                public override Lfx.Types.OperationResult Print(bool DejaSeleccionarImpresora)
                {
                        if (ValidateData().Success == true) {
                                if (Save().Success == true) {
                                        Comprobantes.Presupuestos.Imprimir ImprimirPresupuesto = new Comprobantes.Presupuestos.Imprimir(this.Workspace, this.CachedRow.Id);

                                        // Determino la impresora que le corresponde
                                        string sImpresora = "";
                                        if (DejaSeleccionarImpresora) {
                                                Lui.Printing.PrinterSelectionDialog OSeleccionarImpresora = new Lui.Printing.PrinterSelectionDialog();
                                                OSeleccionarImpresora.VistaPrevia = true;
                                                if (OSeleccionarImpresora.ShowDialog() == DialogResult.OK)
                                                        sImpresora = OSeleccionarImpresora.SelectedPrinter;
                                        } else {
                                                sImpresora = this.Workspace.CurrentConfig.Printing.PreferredPrinter(this.Tipo.Nomenclatura);
                                                // Si es de carga manual, presento el formulario correspondiente
                                                if (this.Workspace.CurrentConfig.Printing.PrinterFeed(this.Tipo.Nomenclatura, "auto") == "manual") {
                                                        Lbl.Impresion.ManualFeedDialog OFormFacturaCargaManual = new Lbl.Impresion.ManualFeedDialog();
                                                        OFormFacturaCargaManual.DocumentName = Lbl.Comprobantes.Comprobante.NumeroCompleto(this.DataView, m_Id);
                                                        // Muestro el nombre de la impresora
                                                        if (sImpresora.Length > 0) {
                                                                OFormFacturaCargaManual.PrinterName = sImpresora;
                                                        } else {
                                                                System.Drawing.Printing.PrinterSettings objPrint = new System.Drawing.Printing.PrinterSettings();
                                                                OFormFacturaCargaManual.PrinterName = objPrint.PrinterName;
                                                        }
                                                        if (OFormFacturaCargaManual.ShowDialog() == DialogResult.Cancel)
                                                                return new Lfx.Types.FailureOperationResult("Operación cancelada");
                                                }
                                        }

                                        if (sImpresora == "lazaro!preview") {
                                                ImprimirPresupuesto.PrintController = new System.Drawing.Printing.PreviewPrintController();
                                                Lui.Printing.PrintPreviewForm VistaPrevia = new Lui.Printing.PrintPreviewForm();
                                                VistaPrevia.PrintPreview.Document = ImprimirPresupuesto;
                                                VistaPrevia.MdiParent = this.MdiParent;
                                                VistaPrevia.Show();
                                        } else {
                                                if (sImpresora.Length > 0)
                                                        ImprimirPresupuesto.PrinterSettings.PrinterName = sImpresora;

                                                ImprimirPresupuesto.Print();
                                        }
                                }
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }

		/* TODO: obsolete
		private void FormPresupuestosEditar_Closed(object sender, System.EventArgs e)
		{
			Ticker_IgnorarEventos = true;
			
			if (Lfc.Misc.Estaticos.FormularioTickerPresupuestos != null)
				Lfc.Misc.Estaticos.FormularioTickerPresupuestos.Modo = Lfc.Comprobantes.Ticker.TickerPresupuestos.Modos.Inicio;
		}
		*/

		override protected internal void CambioValores(object sender, System.EventArgs e)
		{
			base.CambioValores(sender, e);
			/* TODO: obsolete
			if (this.Visible && Ticker_IgnorarEventos == false && Lfc.Misc.Estaticos.FormularioTickerPresupuestos != null)
				Lfc.Misc.Estaticos.FormularioTickerPresupuestos.MostrarPresupuestoValores(this);
			*/
		}

		/* TODO: obsolete
		private void ProductArray_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (this.Visible && Ticker_IgnorarEventos == false && Lfc.Misc.Estaticos.FormularioTickerPresupuestos != null)
				Lfc.Misc.Estaticos.FormularioTickerPresupuestos.MostrarArticulo(((Lui.Forms.Product)(sender)).TextInt);
		}


		private void ProductArray_Leave(object sender, System.EventArgs e)
		{
			if (this.Visible && Ticker_IgnorarEventos == false && Lfc.Misc.Estaticos.FormularioTickerPresupuestos != null)
				Lfc.Misc.Estaticos.FormularioTickerPresupuestos.MostrarPresupuesto(this);
		}
		*/
	}
}