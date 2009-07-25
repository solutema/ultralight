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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Recibos
{
        public partial class Editar : Lui.Forms.EditForm
        {
                public bool CrearDePago = false;

                public Editar()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                        EtiquetaTitulo.Font = Lws.Config.Display.CurrentTemplate.DefaultHeaderFont;
                        EtiquetaTitulo.BackColor = Lws.Config.Display.CurrentTemplate.HeaderBackground;
                        EtiquetaTitulo.ForeColor = Lws.Config.Display.CurrentTemplate.HeaderText;
                        ListaValores.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                        ListaFacturas.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                }

                public override Lfx.Types.OperationResult Create()
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.create"))
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Comprobantes.Recibo Rec;
                        if (CrearDePago)
                                Rec = new Lbl.Comprobantes.ReciboDePago(this.DataView);
                        else
                                Rec = new Lbl.Comprobantes.ReciboDeCobro(this.DataView);
                        
                        this.FromRow(Rec);
                        return new Lfx.Types.SuccessOperationResult();
                }

                public bool DePago
                {
                        get
                        {
                                Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;
                                return Rec.DePago;
                        }
                }

                public override bool ReadOnly
                {
                        get
                        {
                                return base.ReadOnly;
                        }
                        set
                        {
                                base.ReadOnly = value;
                                SaveButton.Visible = !value;
                                BotonAgregarFactura.Enabled = !value;
                                BotonQuitarFactura.Enabled = !value;
                                BotonAgregarValor.Enabled = !value;
                                BotonQuitarValor.Enabled = !value;
                                if (value)
                                        CancelCommandButton.Text = "Volver";
                                else
                                        CancelCommandButton.Text = "Cancelar";
                                EntradaCliente.ReadOnly = value;
                                EntradaVendedor.ReadOnly = value;
                                EntradaNumero.ReadOnly = value;
                        }
                }


                public override Lfx.Types.OperationResult Edit(int Id)
                {
                        Lbl.Comprobantes.Recibo Rec = new Lbl.Comprobantes.Recibo(this.DataView, Id);
                        this.FromRow(Rec);
                        this.ReadOnly = true;
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;

                        EntradaPV.Text = Rec.PV.ToString();
                        EntradaNumero.Text = Rec.Numero.ToString();
                        if (Rec.Vendedor != null)
                                EntradaVendedor.TextInt = Rec.Vendedor.Id;
                        else
                                EntradaVendedor.TextInt = 0;
                        if (Rec.Cliente != null)
                                EntradaCliente.TextInt = Rec.Cliente.Id;
                        else
                                EntradaCliente.TextInt = 0;
                        if (Rec.Concepto != null)
                                EntradaConcepto.TextInt = Rec.Concepto.Id;
                        else
                                EntradaConcepto.TextInt = 0;
                        EntradaConceptoTexto.Text = Rec.ConceptoTexto;

                        if (Rec.DePago) {
                                BotonAgregarValor.Subtext = "F6";
                                BotonQuitarValor.Subtext = "F7";
                        } else {
                                BotonAgregarValor.Subtext = "F4";
                                BotonQuitarValor.Subtext = "F5";
                        }

                        this.MostrarFacturas();
                        this.MostrarValores();

                        if (Rec.Existe) {
                                EtiquetaTitulo.Text = Rec.ToString();
                                this.ReadOnly = true;
                        } else {
                                EtiquetaTitulo.Text = Rec.Tipo.Nombre;
                        }
                }


                public override Lfx.Types.OperationResult ValidateData()
                {
                        Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();
                        Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;

                        if (EntradaCliente.TextInt <= 0 || EntradaCliente.TextInt == 999) {
                                validarReturn.Success = false;
                                validarReturn.Message = "Por favor seleccione un cliente válido." + Environment.NewLine;
                        }
                        
                        if (this.DePago == false && Rec.Cobros.ImporteTotal() <= 0) {
                                validarReturn.Success = false;
                                validarReturn.Message = "Debe especificar los valores de cobro." + Environment.NewLine;
                        }

                        if (this.DePago && Rec.Pagos.ImporteTotal() <= 0) {
                                validarReturn.Success = false;
                                validarReturn.Message = "Debe especificar los valores de pago." + Environment.NewLine;
                        }

                        if (m_Nuevo && Lfx.Types.Strings.IsNumericInt(EntradaNumero.Text) && Lfx.Types.Parsing.ParseInt(EntradaNumero.Text) != 0) {
                                int bExiste = this.Workspace.DefaultDataBase.FieldInt("SELECT COUNT(id_recibo) FROM recibos WHERE numero=" + Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString());
                                if (bExiste != 0) {
                                        validarReturn.Success = false;
                                        validarReturn.Message = "Ya existe un Recibo con ese número." + Environment.NewLine;
                                }
                        }
                        return validarReturn;
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;
                        if (this.DePago) {
                                foreach (Lbl.Comprobantes.Pago Pg in Rec.Pagos) {
                                        if (this.EntradaConceptoTexto.Text.Length > 0)
                                                Pg.ConceptoTexto = this.EntradaConceptoTexto.Text;
                                        else
                                                Pg.ConceptoTexto = "Pago s/" + Rec.ToString();
                                }
                        } else {
                                foreach (Lbl.Comprobantes.Cobro Cb in Rec.Cobros) {
                                        if (this.EntradaConceptoTexto.Text.Length > 0)
                                                Cb.ConceptoTexto = this.EntradaConceptoTexto.Text;
                                        else
                                                Cb.ConceptoTexto = "Cobro s/" + Rec.ToString();
                                }
                        }

                        Rec.PV = Lfx.Types.Parsing.ParseInt(EntradaPV.Text);
                        Rec.Numero = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text);
                        Rec.Cliente = new Lbl.Personas.Persona(Rec.DataView, EntradaCliente.TextInt);
                        Rec.Vendedor = new Lbl.Personas.Persona(Rec.DataView, EntradaVendedor.TextInt);
                        Rec.ConceptoTexto = EntradaConceptoTexto.Text;
                        if (EntradaConcepto.TextInt > 0)
                                Rec.Concepto = new Lbl.Cuentas.Concepto(Rec.DataView, EntradaConcepto.TextInt);
                        else
                                Rec.Concepto = null;
                        Rec.Obs = null;
                        return Rec;
                }

                private void cmdFacturasAgregar_Click(object sender, System.EventArgs e)
                {
                        Comprobantes.Facturas.FormSeleccionarFactura FormularioSeleccionarFactura = new Comprobantes.Facturas.FormSeleccionarFactura();
                        FormularioSeleccionarFactura.Owner = this;
                        FormularioSeleccionarFactura.AceptarAnuladas = false;
                        FormularioSeleccionarFactura.AceptarCanceladas = false;
                        FormularioSeleccionarFactura.AceptarNoImpresas = false;
                        FormularioSeleccionarFactura.DeCompra = this.DePago;

                        if (EntradaCliente.TextInt > 0) {
                                FormularioSeleccionarFactura.txtCliente.TextInt = EntradaCliente.TextInt;
                                FormularioSeleccionarFactura.txtCliente.Enabled = false;
                        }

                        if (FormularioSeleccionarFactura.ShowDialog() == DialogResult.OK)
                                AgregarFactura(FormularioSeleccionarFactura.FacturaId);

                        FormularioSeleccionarFactura = null;
                }


                internal Lfx.Types.OperationResult AgregarFactura(int idFactura)
                {
                        Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;
                        if (Rec.Facturas == null) {
                                Rec.Facturas = new Lbl.Comprobantes.ColeccionComprobanteConArticulos();
                        } else {
                                foreach (Lbl.Comprobantes.Factura Fc in Rec.Facturas) {
                                        if (Fc.Id == idFactura)
                                                return new Lfx.Types.FailureOperationResult("La factura seleccionada ya está en la lista.");
                                }
                        }
                        Lbl.Comprobantes.Factura Fac = new Lbl.Comprobantes.Factura(Rec.DataView, idFactura);
                        Rec.Facturas.Add(Fac);

                        if (EntradaCliente.TextInt <= 0)
                                EntradaCliente.TextInt = Fac.Cliente.Id;

                        this.MostrarFacturas();

                        return new Lfx.Types.SuccessOperationResult();
                }

                public void MostrarFacturas()
                {
                        ListaFacturas.BeginUpdate();
                        ListaFacturas.Items.Clear();
                        Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;

                        foreach (Lbl.Comprobantes.Factura Fc in Rec.Facturas) {
                                ListViewItem AgregarFactura = ListaFacturas.Items.Add(Fc.GetHashCode().ToString());
                                AgregarFactura.SubItems.Add(new ListViewItem.ListViewSubItem(AgregarFactura, Fc.ToString()));
                                AgregarFactura.SubItems.Add(new ListViewItem.ListViewSubItem(AgregarFactura, Lfx.Types.Formatting.FormatDate(Fc.Fecha)));
                                AgregarFactura.SubItems.Add(new ListViewItem.ListViewSubItem(AgregarFactura, Lfx.Types.Formatting.FormatCurrency(Fc.Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                AgregarFactura.SubItems.Add(new ListViewItem.ListViewSubItem(AgregarFactura, Lfx.Types.Formatting.FormatCurrency(Fc.Total - Fc.ImporteCancelado, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                AgregarFactura.SubItems.Add(new ListViewItem.ListViewSubItem(AgregarFactura, Fc.Cliente.ToString()));

                        }

                        if (ListaFacturas.Items.Count > 0 && ListaFacturas.SelectedItems.Count == 0) {
                                ListaFacturas.Items[0].Selected = true;
                                ListaFacturas.Items[0].Focused = true;
                        }

                        EtiquetaFacturasImporte.Text = Lfx.Types.Formatting.FormatCurrency(Rec.Facturas.Total - Rec.Facturas.Cancelado, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        ListaFacturas.EndUpdate();
                }


                private void cmdFacturasQuitar_Click(object sender, System.EventArgs e)
                {
                        if (ListaFacturas.SelectedItems.Count == 0) {
                                Lui.Forms.MessageBox.Show("Debe seleccionar una factura para quitar.", "Error");
                        } else {
                                Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;
                                string HashFacturaSeleccionada = ListaFacturas.SelectedItems[0].Text;
                                for (int i = 0; i < Rec.Facturas.Count; i++) {
                                        if (Rec.Facturas[i].GetHashCode().ToString() == HashFacturaSeleccionada) {
                                                Rec.Facturas.RemoveAt(i);
                                                break;
                                        }
                                }
                                this.MostrarFacturas();
                                if (ListaFacturas.Items.Count == 1)
                                        ListaFacturas.Items[0].Selected = true;
                        }
                }


                private void cmdValoresAgregar_Click(object sender, System.EventArgs e)
                {
                        if (this.DePago) {
                                Comprobantes.Recibos.EditarPago FormularioEditarPago = new Comprobantes.Recibos.EditarPago();
                                FormularioEditarPago.Workspace = this.Workspace;
                                FormularioEditarPago.Owner = this;
                                FormularioEditarPago.Pago.FromPago(new Lbl.Comprobantes.Pago(this.DataView, Lbl.Comprobantes.FormasDePago.Efectivo));
                                FormularioEditarPago.Pago.ObsVisible = false;

                                if (FormularioEditarPago.ShowDialog() == DialogResult.OK) {
                                        Lbl.Comprobantes.Pago MiPago = FormularioEditarPago.Pago.ToPago(this.CachedRow.DataView);
                                        Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;
                                        Rec.Pagos.Add(MiPago);
                                        this.MostrarValores();
                                }
                        } else {
                                Comprobantes.Recibos.EditarCobro FormularioEditarCobro = new Comprobantes.Recibos.EditarCobro();
                                FormularioEditarCobro.Workspace = this.Workspace;
                                FormularioEditarCobro.Owner = this;
                                FormularioEditarCobro.Cobro.FromCobro(new Lbl.Comprobantes.Cobro(this.DataView, Lbl.Comprobantes.FormasDePago.Efectivo));
                                FormularioEditarCobro.Cobro.ObsVisible = false;

                                if (FormularioEditarCobro.ShowDialog() == DialogResult.OK) {
                                        Lbl.Comprobantes.Cobro MiCobro = FormularioEditarCobro.Cobro.ToCobro(this.CachedRow.DataView);
                                        Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;
                                        Rec.Cobros.Add(MiCobro);
                                        this.MostrarValores();
                                }
                        }
                }

                private void MostrarValores()
                {
                        ListaValores.BeginUpdate();
                        ListaValores.Items.Clear();
                        Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;

                        if (this.DePago) {
                                foreach (Lbl.Comprobantes.Pago Pg in Rec.Pagos) {
                                        ListViewItem itm = ListaValores.Items.Add(Pg.GetHashCode().ToString());
                                        switch (Pg.FormaDePago) {
                                                case Lbl.Comprobantes.FormasDePago.Efectivo:
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Efectivo"));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(Pg.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.Cheque:
                                                        itm.SubItems.Add("Cheque");
                                                        itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(Pg.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces));
                                                        itm.SubItems.Add(Pg.ToString());
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Débito de Cuenta"));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(Pg.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Débito desde Cuenta " + Pg.CuentaOrigen.ToString()));
                                                        break;
                                        }
                                }
                                EtiquetaValoresImporte.Text = Lfx.Types.Formatting.FormatCurrency(Rec.Cobros.ImporteTotal(), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        } else {
                                foreach (Lbl.Comprobantes.Cobro Cb in Rec.Cobros) {
                                        ListViewItem itm = ListaValores.Items.Add(Cb.GetHashCode().ToString());
                                        switch (Cb.FormaDePago) {
                                                case Lbl.Comprobantes.FormasDePago.Efectivo:
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Efectivo"));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(Cb.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.Cheque:
                                                        itm.SubItems.Add("Cheque");
                                                        itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(Cb.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces));
                                                        itm.SubItems.Add(Cb.ToString());
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Tarjeta de Crédito"));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(Cb.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Cupón Nº " + Cb.Cupon.Numero + " de " + Cb.Cupon.Tarjeta.ToString()));
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Tarjeta de Débito"));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(Cb.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Cupón Nº " + Cb.Cupon.Numero + " de " + Cb.Cupon.Tarjeta.ToString()));
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Acreditación en Cuenta"));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(Cb.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Depósito en Cuenta " + Cb.CuentaDestino.ToString()));
                                                        break;
                                        }
                                }
                                EtiquetaValoresImporte.Text = Lfx.Types.Formatting.FormatCurrency(Rec.Cobros.ImporteTotal(), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        }

                        if (ListaValores.Items.Count > 0 && ListaValores.SelectedItems.Count == 0) {
                                ListaValores.Items[0].Selected = true;
                                ListaValores.Items[0].Focused = true;
                        }
                        
                        ListaValores.EndUpdate();
                }


                private void cmdValoresQuitar_Click(object sender, System.EventArgs e)
                {
                        if (ListaValores.SelectedItems.Count == 0) {
                                Lui.Forms.MessageBox.Show("Debe seleccionar un valor para quitar.", "Error");
                        } else {
                                Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;
                                ListViewItem itm = ListaValores.SelectedItems[0];
                                for (int i = 0; i < Rec.Cobros.Count; i++) {
                                        if (Rec.Cobros[i].GetHashCode().ToString() == itm.Text) {
                                                Rec.Cobros.RemoveAt(i);
                                                break;
                                        }
                                }
                                this.MostrarValores();

                                if (ListaValores.Items.Count == 1)
                                        ListaValores.Items[0].Selected = true;
                        }
                }


                private void FormReciboEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.F2:
                                        e.Handled = true;
                                        if (BotonAgregarFactura.Enabled && BotonAgregarFactura.Visible)
                                                BotonAgregarFactura.PerformClick();
                                        break;
                                case Keys.F3:
                                        e.Handled = true;
                                        if (BotonQuitarFactura.Enabled && BotonQuitarFactura.Visible)
                                                BotonQuitarFactura.PerformClick();
                                        break;
                                case Keys.F4:
                                        e.Handled = true;
                                        if (this.DePago == false && BotonAgregarValor.Enabled && BotonAgregarValor.Visible)
                                                BotonAgregarValor.PerformClick();
                                        break;
                                case Keys.F5:
                                        e.Handled = true;
                                        if (this.DePago == false && BotonQuitarValor.Enabled && BotonQuitarValor.Visible)
                                                BotonQuitarValor.PerformClick();
                                        break;
                                case Keys.F6:
                                        e.Handled = true;
                                        if (this.DePago == true && BotonAgregarValor.Enabled && BotonAgregarValor.Visible)
                                                BotonAgregarValor.PerformClick();
                                        break;
                                case Keys.F7:
                                        e.Handled = true;
                                        if (this.DePago == true && BotonQuitarValor.Enabled && BotonQuitarValor.Visible)
                                                BotonQuitarValor.PerformClick();
                                        break;
                                case Keys.F8:
                                        e.Handled = true;
                                        if (PrintButton.Enabled && PrintButton.Visible)
                                                PrintButton.PerformClick();
                                        break;
                        }

                }


                private void lvFacturas_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Up:
                                        if (ListaFacturas.Items.Count == 0) {
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        } else if (ListaFacturas.SelectedItems.Count == 0) {
                                                ListaFacturas.Items[0].Selected = true;
                                                ListaFacturas.Items[0].Focused = true;
                                        } else if (ListaFacturas.SelectedItems[0].Index > 0) {
                                                ListaFacturas.Items[ListaFacturas.SelectedItems[0].Index - 1].Selected = true;
                                                ListaFacturas.Items[ListaFacturas.SelectedItems[0].Index].Focused = true;
                                        } else {
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        }
                                        e.Handled = true;
                                        break;
                                case Keys.Down:
                                        if (ListaFacturas.Items.Count == 0) {
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        } else if (ListaFacturas.SelectedItems.Count == 0) {
                                                ListaFacturas.Items[0].Selected = true;
                                                ListaFacturas.Items[0].Focused = true;
                                        } else if (ListaFacturas.SelectedItems[0].Index < ListaFacturas.Items.Count - 1) {
                                                ListaFacturas.Items[ListaFacturas.SelectedItems[0].Index + 1].Selected = true;
                                                ListaFacturas.Items[ListaFacturas.SelectedItems[0].Index].Focused = true;
                                        } else {
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        }
                                        e.Handled = true;
                                        break;
                                case Keys.Return:
                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                        e.Handled = true;
                                        break;
                        }

                }


                private void lvValores_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Up:
                                        if (ListaValores.Items.Count == 0) {
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        } else if (ListaValores.SelectedItems.Count == 0) {
                                                ListaValores.Items[0].Selected = true;
                                                ListaValores.Items[0].Focused = true;
                                        } else if (ListaValores.SelectedItems[0].Index > 0) {
                                                ListaValores.Items[ListaValores.SelectedItems[0].Index - 1].Selected = true;
                                                ListaValores.Items[ListaValores.SelectedItems[0].Index].Focused = true;
                                        } else {
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        }
                                        e.Handled = true;
                                        break;
                                case Keys.Down:
                                        if (ListaValores.Items.Count == 0) {
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        } else if (ListaValores.SelectedItems.Count == 0) {
                                                ListaValores.Items[0].Selected = true;
                                                ListaValores.Items[0].Focused = true;
                                        } else if (ListaValores.SelectedItems[0].Index < ListaValores.Items.Count - 1) {
                                                ListaValores.Items[ListaValores.SelectedItems[0].Index + 1].Selected = true;
                                                ListaValores.Items[ListaValores.SelectedItems[0].Index].Focused = true;
                                        } else {
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        }
                                        e.Handled = true;
                                        break;
                                case Keys.Return:
                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                        e.Handled = true;
                                        break;
                        }

                }


                private void lvFacturas_GotFocus(object sender, System.EventArgs e)
                {
                        ListaFacturas.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataareaActive;
                }

                private void lvFacturas_LostFocus(object sender, System.EventArgs e)
                {
                        ListaFacturas.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                }


                private void lvValores_GotFocus(object sender, System.EventArgs e)
                {
                        ListaValores.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataareaActive;
                }


                private void lvValores_LostFocus(object sender, System.EventArgs e)
                {
                        ListaValores.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                }


                private void cmdImprimir_Click(object sender, System.EventArgs e)
                {
                        Lfx.Types.OperationResult Res;

                        if (m_Id == 0)
                                Res = Save();
                        else
                                Res = new Lfx.Types.SuccessOperationResult();

                        if (Res.Success == true)
                                Res = this.Print(false);

                        if (Res.Success == false)
                                Lui.Forms.MessageBox.Show(Res.Message, "Error");
                }

                public override Lfx.Types.OperationResult Print(bool DejaSeleccionarImpresora)
                {
                        Lbl.Comprobantes.Recibo Rec = this.CachedRow as Lbl.Comprobantes.Recibo;
                        string Impresora = this.Workspace.CurrentConfig.Printing.PreferredPrinter(Rec.Tipo.Nomenclatura);
                        Lfx.Types.OperationResult Res = Rec.Imprimir(Impresora);
                        if (Res.Success)
                                this.ReadOnly = true;
                        return Res;
                }

                private void FormReciboEditar_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        EntradaVendedor.TextInt = this.Workspace.CurrentUser.UserId;
                }

        }
}