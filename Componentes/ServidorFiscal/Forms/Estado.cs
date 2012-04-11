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
using System.Windows.Forms;

namespace ServidorFiscal.Forms
{
        public partial class Estado : Lui.Forms.Form
        {
                public ServidorFiscal ServidorAsociado { get; set; }

                public Estado()
                {
                        this.DisplayStyle = Lazaro.Pres.DisplayStyles.Template.Current.White;
                        InitializeComponent();
                }


                private void FormEstado_Load(object sender, System.EventArgs e)
                {
                        this.MostrarEstado(null);
                }


                public void MostrarEstado(string texto)
                {
                        if (this.InvokeRequired) {
                                MethodInvoker Mi = delegate { this.MostrarEstado(texto); };
                                return;
                        }

                        if (string.IsNullOrEmpty(texto))
                                EtiquetaEstado.Text = "Preparado, esperando órdenes.";
                        else
                                EtiquetaEstado.Text = texto;

                        if (string.IsNullOrEmpty(this.EtiquetaVersion.Text))
                                this.EtiquetaVersion.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;

                        if (this.ServidorAsociado == null) {
                                this.IconoBandeja.Text = "No se cargó el servidor.";
                                this.EtiquetaPV.Text = "";
                                this.EtiquetaModeloImpresora.Text = "";
                        } else {
                                if (this.ServidorAsociado.PuntoDeVenta == null || this.ServidorAsociado.PuntoDeVenta.Numero == 0) {
                                        this.IconoBandeja.Text = "No hay definido un punto de venta para esta estación.";
                                        this.EtiquetaPV.Text = "";
                                        this.EtiquetaModeloImpresora.Text = "";
                                } else {
                                        this.IconoBandeja.Text = "Utilizando el punto de venta " + this.ServidorAsociado.PuntoDeVenta.Numero.ToString();
                                        this.EtiquetaPV.Text = this.ServidorAsociado.PuntoDeVenta.ToString();
                                        this.EtiquetaModeloImpresora.Text = this.ServidorAsociado.PuntoDeVenta.ModeloImpresoraFiscal.ToString() + " en puerto COM" + this.ServidorAsociado.PuntoDeVenta.Puerto.ToString() + " a " + this.ServidorAsociado.PuntoDeVenta.Bps.ToString() + " bps";
                                }
                        }

                        this.Refresh();
                }


                private void IconoBandeja_DoubleClick(object sender, System.EventArgs e)
                {
                        this.WindowState = FormWindowState.Normal;
                        this.Show();
                }


                private void MenuOcultar_Click(object sender, System.EventArgs e)
                {
                        if (this.Visible == false) {
                                MenuOcultar.Text = "&Ocultar";
                                this.Show();
                        } else {
                                MenuOcultar.Text = "&Mostrar";
                                this.Hide();
                        }
                }


                private void MenuReiniciar_Click(System.Object sender, System.EventArgs e)
                {
                        ServidorAsociado.Impresora.EstadoServidor = Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Reiniciando;
                }


                private void MenuCerrar_Click(System.Object sender, System.EventArgs e)
                {
                        ServidorAsociado.Impresora.EstadoServidor = Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Apagando;
                }


                public void QuitarIcono()
                {
                        try {
                                this.IconoBandeja.Visible = false;
                                this.IconoBandeja.Dispose();
                        } catch {
                                //Nada
                        }
                }


                protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
                {
                        if (this.Visible) {
                                this.Hide();
                                e.Cancel = true;
                        } else {
                                this.QuitarIcono();
                        }
                        base.OnClosing(e);
                }


                private void BotonCerrar_Click(object sender, EventArgs e)
                {
                        ServidorAsociado.Impresora.EstadoServidor = Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Apagando;
                }


                private void BotonReiniciar_Click(object sender, EventArgs e)
                {
                        ServidorAsociado.Impresora.EstadoServidor = Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Reiniciando;
                }

                private void BotonOcultar_Click(object sender, EventArgs e)
                {
                        this.Hide();
                }
        }
}