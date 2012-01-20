#region License
// Copyright 2004-2012 Ernesto N. Carrea
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
using System.Windows.Forms;

namespace Lfc.Comprobantes.Compra
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                private IDictionary<int, decimal> ArticulosCantidadesOriginales = new Dictionary<int, decimal>();

                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Comprobantes.ComprobanteDeCompra);

                        InitializeComponent();

                        EntradaTotal.CustomFont = new System.Drawing.Font(this.Font.Name, 14);
                        EntradaCancelado.CustomFont = new System.Drawing.Font(this.Font.Name, 12);
                }


                public override void OnWorkspaceChanged()
                {
                        if (this.HasWorkspace) {
                                EntradaHaciaSituacion.Visible = this.Workspace.CurrentConfig.Productos.StockMultideposito;
                                EtiquetaHaciaSituacion.Visible = this.Workspace.CurrentConfig.Productos.StockMultideposito;
                        }
                        base.OnWorkspaceChanged();
                }


                public override Lfx.Types.OperationResult ValidarControl()
                {
                        Lfx.Types.OperationResult Res = base.ValidarControl();

                        if (EntradaHaciaSituacion.Visible && EntradaHaciaSituacion.TextInt == 0) {
                                Res.Success = false;
                                Res.Message += "Seleccione un Depósito." + Environment.NewLine;
                        }

                        if (EntradaProveedor.TextInt == 0) {
                                Res.Success = false;
                                Res.Message += "Seleccione un Proveedor." + Environment.NewLine;
                        }

                        return Res;
                }


                public override void ActualizarControl()
                {
                        Lbl.Comprobantes.ComprobanteDeCompra Fac = this.Elemento as Lbl.Comprobantes.ComprobanteDeCompra;
                        this.SuspendLayout();
                        this.TipoComprob = Fac.Tipo;

                        EntradaProveedor.Elemento = Fac.Cliente;

                        if (Fac.FormaDePago != null)
                                EntradaFormaPago.TextKey = Fac.FormaDePago.Id.ToString();
                        else
                                EntradaFormaPago.TextKey = "0";

                        EntradaFormaPago.Enabled = Fac.Tipo.EsFactura;

                        EntradaPV.Text = Fac.PV.ToString("0000");
                        EntradaNumero.Text = Fac.Numero.ToString("00000000");
                        EntradaHaciaSituacion.Elemento = Fac.SituacionDestino;
                        EntradaHaciaSituacion.TemporaryReadOnly = Fac.Existe;
                        EntradaTipo.TextKey = Fac.Tipo.Nomenclatura;
                        EntradaEstado.TextKey = Fac.Estado.ToString();
                        EntradaTotal.Text = Lfx.Types.Formatting.FormatCurrency(Fac.Total, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaCancelado.Text = Lfx.Types.Formatting.FormatCurrency(Fac.ImporteCancelado, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaGastosEnvio.Text = Lfx.Types.Formatting.FormatCurrency(Fac.GastosDeEnvio, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaOtrosGastos.Text = Lfx.Types.Formatting.FormatCurrency(Fac.OtrosGastos, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaFecha.Text = Lfx.Types.Formatting.FormatDate(Fac.Fecha);
                        EntradaObs.Text = Fac.Obs;

                        EntradaProductos.CargarArticulos(Fac.Articulos);
                        foreach (Lbl.Comprobantes.DetalleArticulo Det in Fac.Articulos) {
                                if (Det.Articulo != null && ArticulosCantidadesOriginales.ContainsKey(Det.Articulo.Id) == false) {
                                        ArticulosCantidadesOriginales.Add(Det.Articulo.Id, Det.Cantidad);
                                }
                        }

                        EntradaProductos.Changed = false;
                        BotonConvertir.Visible = this.Elemento.Existe;

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Comprobantes.ComprobanteDeCompra Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteDeCompra;

                        Comprob.Compra = true;
                        Comprob.Fecha = Lfx.Types.Parsing.ParseDate(EntradaFecha.Text);
                        if (EntradaFormaPago.TextKey != "0")
                                Comprob.FormaDePago = new Lbl.Pagos.FormaDePago(Comprob.Connection, Lfx.Types.Parsing.ParseInt(EntradaFormaPago.TextKey));
                        else
                                Comprob.FormaDePago = null;

                        Comprob.Vendedor = Lbl.Sys.Config.Actual.UsuarioConectado.Persona;
                        Comprob.Cliente = EntradaProveedor.Elemento as Lbl.Personas.Persona;
                        Comprob.Tipo = Lbl.Comprobantes.Tipo.TodosPorLetra[EntradaTipo.TextKey];
                        Comprob.PV = Lfx.Types.Parsing.ParseInt(EntradaPV.Text);
                        Comprob.Numero = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text);
                        Comprob.SituacionDestino = EntradaHaciaSituacion.Elemento as Lbl.Articulos.Situacion;
                        Comprob.GastosDeEnvio = Lfx.Types.Parsing.ParseCurrency(EntradaGastosEnvio.Text);
                        Comprob.OtrosGastos = Lfx.Types.Parsing.ParseCurrency(EntradaOtrosGastos.Text);
                        Comprob.Obs = EntradaObs.Text;

                        if (EntradaEstado.Enabled && EntradaEstado.Visible)
                                Comprob.Estado = EntradaEstado.ValueInt;
                        else
                                Comprob.Estado = 0;

                        Comprob.Articulos = EntradaProductos.ObtenerArticulos(Comprob);

                        base.ActualizarControl();
                }


                public override bool PuedeEditar()
                {
                        return !this.Elemento.Existe;
                }


                public virtual Lbl.Comprobantes.Tipo TipoComprob
                {
                        get
                        {
                                Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                                return Comprob.Tipo;
                        }
                        set
                        {
                                Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                                Comprob.Tipo = value;
                                EntradaTipo.TextKey = Comprob.Tipo.Nomenclatura;

                                switch (Comprob.Tipo.Nomenclatura) {
                                        case "NP":
                                                EntradaEstado.SetData = new string[] {
							"A pedir|50",
							"Pedido|100",
							"Cancelado|200"
						};
                                                EntradaEstado.Visible = true;
                                                EtiquetaEstado.Visible = true;
                                                break;
                                        case "PD":
                                                EntradaEstado.SetData = new string[] {
							"Sin especificar|0",
							"En camino|50",
							"Recibido|100",
							"Cancelado|200"
						};
                                                EntradaEstado.Visible = true;
                                                EtiquetaEstado.Visible = true;
                                                break;
                                        default:
                                                EntradaEstado.SetData = new string[] { "N/A|1" };
                                                EntradaEstado.Visible = false;
                                                EtiquetaEstado.Visible = false;
                                                break;
                                }

                                EtiquetaHaciaSituacion.Visible = Comprob.Tipo.EsFactura;
                                EntradaHaciaSituacion.Visible = Comprob.Tipo.EsFactura;
                        }
                }


                public string Titulo
                {
                        get
                        {
                                return EtiquetaTitulo.Text;
                        }
                        set
                        {
                                EtiquetaTitulo.Text = value;
                        }
                }

                private void BotonObs_Click(object sender, EventArgs e)
                {
                        Lui.Forms.AuxForms.TextEdit FormularioObs = new Lui.Forms.AuxForms.TextEdit();
                        FormularioObs.EditText = EntradaObs.Text;
                        FormularioObs.ReadOnly = this.TemporaryReadOnly;
                        if (FormularioObs.ShowDialog() == DialogResult.OK)
                                EntradaObs.Text = FormularioObs.EditText;
                }


                private void BotonConvertir_Click(object sender, EventArgs e)
                {
                        using (Lfc.Comprobantes.Compra.Crear FormularioConvertir = new Lfc.Comprobantes.Compra.Crear()) {
                                if (FormularioConvertir.ShowDialog() == DialogResult.OK) {
                                        Lbl.Comprobantes.ComprobanteDeCompra Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteDeCompra;
                                        if ((Comprob.Tipo.Nomenclatura == "NP" || Comprob.Tipo.Nomenclatura == "PD") && EntradaEstado.TextKey != "100") {
                                                EntradaEstado.TextKey = "100";
                                                EntradaEstado.Changed = true;
                                        } else if ((Comprob.Tipo.EsPedido || FormularioConvertir.TipoComprob == "F"
                                                || FormularioConvertir.TipoComprob == "FP"
                                                || FormularioConvertir.TipoComprob == "R") && EntradaEstado.TextKey != "100") {
                                                EntradaEstado.TextKey = "100";
                                                EntradaEstado.Changed = true;
                                        }

                                        Lbl.Comprobantes.ComprobanteDeCompra NuevoComprob;
                                        if (FormularioConvertir.TipoComprob == "FP") {
                                                Lbl.Comprobantes.Tipo NuevoTipo = Lbl.Comprobantes.Tipo.TodosPorLetra["FA"];
                                                NuevoComprob = Comprob.Convertir(NuevoTipo);
                                                NuevoComprob.FormaDePago = new Lbl.Pagos.FormaDePago(this.Connection, 3);
                                        } else if (FormularioConvertir.TipoComprob == "RP") {
                                                Lbl.Comprobantes.Tipo NuevoTipo = Lbl.Comprobantes.Tipo.TodosPorLetra["R"];
                                                NuevoComprob = Comprob.Convertir(NuevoTipo);
                                                NuevoComprob.FormaDePago = new Lbl.Pagos.FormaDePago(this.Connection, 3);
                                        } else {
                                                Lbl.Comprobantes.Tipo NuevoTipo = Lbl.Comprobantes.Tipo.TodosPorLetra[FormularioConvertir.TipoComprob];
                                                NuevoComprob = Comprob.Convertir(NuevoTipo);
                                        }

                                        Lfc.FormularioEdicion FormularioEdicion = Lfc.Instanciador.InstanciarFormularioEdicion(NuevoComprob);
                                        FormularioEdicion.MdiParent = this.ParentForm.MdiParent;
                                        FormularioEdicion.Show();
                                }
                        }
                }


                private void RecalcularTotal(System.Object sender, System.EventArgs e)
                {
                        decimal GastosEnvio = Lfx.Types.Parsing.ParseCurrency(EntradaGastosEnvio.Text);
                        decimal OtrosGastos = Lfx.Types.Parsing.ParseCurrency(EntradaOtrosGastos.Text);
                        EntradaTotal.Text = Lfx.Types.Formatting.FormatCurrency(EntradaProductos.Total + GastosEnvio + OtrosGastos, this.Workspace.CurrentConfig.Moneda.Decimales);
                }


                private void EntradaNumero_Leave(object sender, EventArgs e)
                {
                        if (EntradaNumero.ValueInt > 0)
                                EntradaNumero.Text = EntradaNumero.ValueInt.ToString("00000000");
                }


                private void EntradaProductos_ObtenerDatosSeguimiento(object sender, EventArgs e)
                {
                        Lcc.Entrada.Articulos.DetalleComprobante Prod = ((Lcc.Entrada.Articulos.DetalleComprobante)(sender));
                        Lbl.Articulos.Articulo Articulo = Prod.Elemento as Lbl.Articulos.Articulo;
                        decimal Cant = Prod.Cantidad;

                        if (Cant != 0) {
                                Lbl.Comprobantes.ComprobanteDeCompra Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteDeCompra;

                                Lfc.Articulos.EditarSeguimiento Editar = new Lfc.Articulos.EditarSeguimiento();
                                Editar.Articulo = Articulo;
                                Editar.Cantidad = Math.Abs(System.Convert.ToInt32(Cant));
                                Editar.SituacionOrigen = Comprob.SituacionOrigen;
                                Editar.DatosSeguimiento = Prod.DatosSeguimiento;
                                if (Editar.ShowDialog() == DialogResult.OK) {
                                        Prod.DatosSeguimiento = Editar.DatosSeguimiento;
                                }
                        }
                }

                private void EntradaTipoPvNumero_TextChanged(object sender, EventArgs e)
                {
                        Lbl.Comprobantes.Tipo Tipo = Lbl.Comprobantes.Tipo.TodosPorLetra[EntradaTipo.TextKey];
                        if (Tipo.Existe)
                                EntradaFormaPago.Enabled = Tipo.EsFacturaNCoND;
                        else
                                EntradaFormaPago.Enabled = false;

                        if(EntradaNumero.ValueInt > 0)
                                this.Titulo = Tipo.ToString() + " " + this.EntradaPV.ValueInt.ToString("0000") + "-" + EntradaNumero.ValueInt.ToString("00000000");
                        else
                                this.Titulo = Tipo.ToString() + " " + this.EntradaPV.ValueInt.ToString("0000");

                        if (Tipo.EsNotaCredito)
                                EtiquetaHaciaSituacion.Text = "Origen";
                        else
                                EtiquetaHaciaSituacion.Text = "Destino";
                }


                protected override void OnResize(EventArgs e)
                {
                        if (this.Created)
                                Contenedor.Size = this.ClientSize;

                        base.OnResize(e);
                }
        }
}
