using System;
using System.Collections.Generic;
using System.Text;

namespace Lcc.Vista.Comprobantes
{
        public partial class ComprobanteConArticulos : ControlVista
        {
                public ComprobanteConArticulos()
                {
                        InitializeComponent();
                }

                public override void ActualizarControl()
                {
                        base.ActualizarControl();

                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        if(Comprob != null) {
                                EtiquetaNombreEmpresa.Text = this.Workspace.CurrentConfig.Company.Name;
                                EtiquetaCuit.Text = this.Workspace.CurrentConfig.Company.Cuit;

                                EtiquetaNumero.Text = Comprob.PV.ToString("0000") + "-" + Comprob.Numero.ToString("00000000");
                                EtiquetaTipo.Text = Comprob.Tipo.LetraSola;
                                if (Comprob.Tipo.EsNotaCredito)
                                        EtiquetaTipoLeyenda.Text = "Nota de Crédito".ToUpperInvariant();
                                else if (Comprob.Tipo.EsNotaDebito)
                                        EtiquetaTipoLeyenda.Text = "Nota de Débito".ToUpperInvariant();
                                else
                                        EtiquetaTipoLeyenda.Text = "";

                                EtiquetaFecha.Text = Comprob.Fecha.Value.ToString(Lfx.Types.Formatting.DateTime.DefaultDateFormat);

                                EtiquetaClienteNombre.Text = "Cliente: " + Comprob.Cliente.Nombre;
                                EtiquetaClienteDomicilio.Text = "Domicilio: " + Comprob.Cliente.Domicilio;
                                EtiquetaClienteSituacion.Text = "IVA: " + Comprob.Cliente.SituacionTributaria.Nombre;
                                EtiquetaClienteCuit.Text = "CUIT: " + Comprob.Cliente.Cuit;

                                EtiquetaSubtotal.Text = Lfx.Types.Formatting.FormatCurrency(Comprob.SubTotal, this.Workspace.CurrentConfig.Currency.DecimalPlacesFinal);
                                EtiquetaDescuento.Text = Lfx.Types.Formatting.FormatNumber(Comprob.Descuento, 2);
                                EtiquetaTotal.Text = Lfx.Types.Formatting.FormatCurrency(Comprob.Total, this.Workspace.CurrentConfig.Currency.DecimalPlacesFinal);

                                EtiquetaAnulado.Visible = Comprob.Anulado;
                        }
                }
        }
}
