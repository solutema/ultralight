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
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Tareas
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                internal decimal Descuento = 0;
                
                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Tareas.Tarea);

                        InitializeComponent();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Tareas.Tarea Res = this.Elemento as Lbl.Tareas.Tarea;

                        Res.Cliente = EntradaCliente.Elemento as Lbl.Personas.Persona;
                        Res.Encargado = EntradaTecnico.Elemento as Lbl.Personas.Persona;
                        Res.Tipo = EntradaTarea.Elemento as Lbl.Tareas.Tipo;
                        Res.Prioridad = Lfx.Types.Parsing.ParseInt(EntradaPrioridad.TextKey);
                        Res.Nombre = EntradaAsunto.Text;
                        Res.Descripcion = EntradaDescripcion.Text;
                        Res.Estado = EntradaEstado.TextInt;
                        Res.FechaEstimada = Lfx.Types.Parsing.ParseDate(EntradaEntregaEstimada.Text);
                        Res.FechaLimite = Lfx.Types.Parsing.ParseDate(EntradaEntregaLimite.Text);
                        Res.Presupuesto = Lfx.Types.Parsing.ParseCurrency(EntradaPresupuesto.Text);
                        Res.Obs = EntradaObs.Text;

                        base.ActualizarElemento();
                }

                public override void ActualizarControl()
                {
                        Lbl.Tareas.Tarea Res = this.Elemento as Lbl.Tareas.Tarea;

                        EntradaNumero.Text = Res.Id.ToString();
                        EntradaAsunto.Text = Res.Nombre;
                        EntradaCliente.Elemento = Res.Cliente;
                        EntradaTecnico.Elemento = Res.Encargado;
                        EntradaTarea.Elemento = Res.Tipo;
                        EntradaPrioridad.TextKey = Res.Prioridad.ToString();
                        EntradaDescripcion.Text = Res.Descripcion;
                        EntradaEstado.TextInt = Res.Estado;
                        EntradaFechaIngreso.Text = Lfx.Types.Formatting.FormatDateAndTime(Res.Fecha);
                        EntradaEntregaEstimada.Text = Lfx.Types.Formatting.FormatDate(Res.FechaEstimada);
                        EntradaEntregaLimite.Text = Lfx.Types.Formatting.FormatDate(Res.FechaLimite);
                        EntradaPresupuesto.Text = Lfx.Types.Formatting.FormatCurrency(Res.Presupuesto, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaObs.Text = Res.Obs;

                        if (Res.Existe) {
                                MostrarPresupuesto2();
                                CargarHistorial();
                        }

                        base.ActualizarControl();
                }

                /* public override Lui.Printing.ItemPrint FormatForPrinting(Lui.Printing.ItemPrint ImprimirItem)
                {
                        ImprimirItem.Titulo = "Tarea Nº " + EntradaNumero.Text;
                        ImprimirItem.AgregarPar("Tipo de Tarea", EntradaTarea.TextDetail, 1);
                        ImprimirItem.AgregarPar("Asunto", txtAsunto.Text, 1);
                        ImprimirItem.AgregarPar("Cliente", EntradaCliente.TextDetail, 1);
                        // Datos del cliente
                        if (EntradaDescripcion.Text.Length > 0)
                                ImprimirItem.AgregarPar("Descripción", EntradaDescripcion.Text, 1);

                        ImprimirItem.AgregarPar("Encargado", EntradaTecnico.TextDetail, 1);
                        ImprimirItem.AgregarPar("Estado", EntradaEstado.TextDetail, 1);
                        ImprimirItem.AgregarPar("Fecha de Ingreso", EntradaFechaIngreso.Text, 1);
                        if (Lfx.Types.Parsing.ParseCurrency(EntradaPresupuesto.Text) != 0)
                                ImprimirItem.AgregarPar("Presupuesto", Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + EntradaPresupuesto.Text, 1);

                        if (Lfx.Types.Parsing.ParseCurrency(EntradaPresupuesto2.Text) != 0) {
                                ImprimirItem.AgregarPar("Artículos", Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + EntradaPresupuesto2.Text, 1);
                                //Detalle artículos
                                System.Data.DataTable Articulos = this.PrintDataBase.Select("SELECT * FROM tickets_articulos WHERE id_ticket=" + this.Elemento.Id.ToString() + " ORDER BY orden");
                                foreach (System.Data.DataRow Articulo in Articulos.Rows) {
                                        ImprimirItem.AgregarPar(Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Articulo["precio"]), this.Workspace.CurrentConfig.Moneda.Decimales), "[" + Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Articulo["cantidad"]), this.Workspace.CurrentConfig.Productos.DecimalesStock) + "] " + System.Convert.ToString(Articulo["nombre"]), 2);
                                }
                        }

                        System.Data.DataTable Eventos = this.PrintDataBase.Select("SELECT tickets_eventos.fecha, tickets_eventos.descripcion, personas.nombre FROM tickets_eventos, personas WHERE tickets_eventos.privado=0 AND tickets_eventos.id_tecnico=personas.id_persona AND id_ticket=" + this.Elemento.Id.ToString() + " ORDER BY id_evento DESC");
                        if (Eventos.Rows.Count > 0) {
                                ImprimirItem.AgregarPar("Historial", "", 1);
                                foreach (System.Data.DataRow Evento in Eventos.Rows) {
                                        ImprimirItem.AgregarPar(System.Convert.ToString(Evento["fecha"]), "[" + System.Convert.ToString(Evento["nombre"]) + "] " + System.Convert.ToString(Evento["descripcion"]), 2);
                                }
                        }
                        return ImprimirItem;
                } */

                public override Lfx.Types.OperationResult ValidarControl()
                {
                        Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();

                        if (EntradaTecnico.Elemento == null) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Debe seleccionar el Encargado." + Environment.NewLine;
                        }
                        if (EntradaCliente.Elemento == null) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Debe seleccionar el Cliente." + Environment.NewLine;
                        }
                        if (EntradaTarea.Elemento == null) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Debe seleccionar el tipo de Tarea." + Environment.NewLine;
                        }

                        return base.ValidarControl(); ;
                }


                private void CargarHistorial()
                {
                        ListaHistorial.BeginUpdate();
                        ListaHistorial.Items.Clear();

                        string TextoSql = "SELECT tickets_eventos.id_ticket, tickets_eventos.fecha, tickets_eventos.descripcion, personas.nombre FROM tickets_eventos, personas WHERE tickets_eventos.id_tecnico=personas.id_persona AND tickets_eventos.id_ticket IN (SELECT id_ticket FROM tickets WHERE id_persona=" + EntradaCliente.TextInt.ToString() + ") ORDER BY tickets_eventos.id_evento DESC";
                        System.Data.DataTable Eventos = this.Connection.Select(TextoSql);
                        if (Eventos.Rows.Count > 0) {
                                foreach (System.Data.DataRow Evento in Eventos.Rows) {
                                        ListViewItem itm = ListaHistorial.Items.Add(System.Convert.ToString(Evento["id_ticket"]));
                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Evento["nombre"].ToString()));
                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatDate(Evento["fecha"])));
                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Evento["descripcion"]).Replace(System.Convert.ToString(Lfx.Types.ControlChars.Cr), " ").Replace(System.Convert.ToString(Lfx.Types.ControlChars.Lf), "")));
                                        if (System.Convert.ToInt32(Evento["id_ticket"]) != this.Elemento.Id)
                                                itm.ForeColor = System.Drawing.Color.Gray;
                                }

                                if (ListaHistorial.Items.Count > 0) {
                                        ListaHistorial.Items[0].Focused = true;
                                        ListaHistorial.Items[0].Selected = true;
                                }
                        }

                        ListaHistorial.EndUpdate();

                        // Ancho automático para las columnas
                        foreach (System.Windows.Forms.ColumnHeader lvHeader in ListaHistorial.Columns) {
                                lvHeader.Width = -2;
                        }

                }


                private void BotonNovedad_Click(object sender, System.EventArgs e)
                {
                        if (this.Elemento.Existe == false) {
                                Lui.Forms.MessageBox.Show("No se puede cargar novedades en una Tarea que aun no ha sido creada.", "Error");
                        } else {
                                Tareas.Novedad FormularioNovedad = new Tareas.Novedad();
                                FormularioNovedad.EntradaTicket.Elemento = this.Elemento;
                                FormularioNovedad.EntradaTicket.Enabled = false;
                                if (FormularioNovedad.ShowDialog() == DialogResult.OK)
                                        this.CargarHistorial();
                        }
                }

                private void BotonFacturar_Click(object sender, System.EventArgs e)
                {
                        Lfx.Types.OperationResult Res = this.Save();
                        if (Res.Success == false) {
                                if (Res.Message != null)
                                        Lui.Forms.MessageBox.Show(Res.Message, "Error");
                                return;
                        }

                        Lbl.Comprobantes.ComprobanteFacturable Factura;

                        int ComprobanteId = Lfx.Types.Parsing.ParseInt(EntradaComprobanteId.Text);
                        bool ComprobanteAnulado = System.Convert.ToBoolean(this.Connection.FieldInt("SELECT anulada FROM comprob WHERE id_comprob=" + ComprobanteId.ToString()));

                        if (ComprobanteId > 0 && ComprobanteAnulado == false) {
                                // Ya tiene un comprobante, pero fue anulado
                                Factura = new Lbl.Comprobantes.ComprobanteFacturable(this.Connection, ComprobanteId);
                        } else {
                                // No tiene comprobante, lo creo
                                EntradaEstado.Text = "50";

                                Factura = new Lbl.Comprobantes.ComprobanteFacturable(this.Connection);

                                Factura.Crear();
                                Factura.Cliente = EntradaCliente.Elemento as Lbl.Personas.Persona;
                                Factura.Tipo = Factura.Cliente.ObtenerTipoComprobante();
                                Factura.Vendedor = EntradaTecnico.Elemento as Lbl.Personas.Persona;
                                Factura.Obs = EntradaTarea.TextDetail + " s/" + this.Elemento.ToString();

                                System.Data.DataTable Articulos = this.Connection.Select("SELECT * FROM tickets_articulos WHERE id_ticket=" + this.Elemento.Id.ToString() + " ORDER BY orden");
                                for (int i = 0; i <= Articulos.Rows.Count - 1; i++) {
                                        Lbl.Comprobantes.DetalleArticulo Art = new Lbl.Comprobantes.DetalleArticulo(Factura);
                                        Art.Articulo = new Lbl.Articulos.Articulo(Factura.Connection, System.Convert.ToInt32(Articulos.Rows[i]["id_articulo"]));
                                        Art.Cantidad = System.Convert.ToDecimal(Articulos.Rows[i]["cantidad"]);
                                        //TODO: Descuento por item
                                        Art.Unitario = System.Convert.ToDecimal(Articulos.Rows[i]["precio"]) * (1 - Descuento / 100);

                                        Factura.Articulos.Add(Art);
                                }
                                if (Lfx.Types.Parsing.ParseCurrency(EntradaPresupuesto.Text) > 0) {
                                        Lbl.Comprobantes.DetalleArticulo Art = new Lbl.Comprobantes.DetalleArticulo(Factura);

                                        Art.Articulo = new Lbl.Articulos.Articulo(this.Connection, 282);
                                        Art.Unitario = EntradaPresupuesto.ValueDecimal;
                                        Art.Cantidad = 1;

                                        Factura.Articulos.Add(Art);
                                }

                                if (Descuento > 0) {
                                        // Si hay descuento sobre los artículos, lo agrego en las observaciones
                                        Factura.Obs += " - Descuento Sobre Artículos: " + Descuento.ToString() + "%";
                                }
                        }

                        Lfc.FormularioEdicion FormularioFactura = Lfc.Instanciador.InstanciarFormularioEdicion(Factura);
                        FormularioFactura.MdiParent = this.ParentForm.MdiParent;        
                        FormularioFactura.ControlDestino = EntradaComprobanteId;

                        FormularioFactura.Show();
                }

                private void EntradaComprobanteId_TextChanged(object sender, System.EventArgs e)
                {
                        int intComprobanteId = Lfx.Types.Parsing.ParseInt(EntradaComprobanteId.Text);
                        if (intComprobanteId > 0) {
                                txtComprobante.Text = Lbl.Comprobantes.Comprobante.TipoYNumeroCompleto(this.Connection, intComprobanteId);
                                // Guardo el comprobante en la tarea (sólo si no tenía uno asociado)
                                qGen.Update Actual = new qGen.Update("tickets");
                                Actual.Fields.Add(new Lfx.Data.Field("id_comprob", intComprobanteId));
                                Actual.WhereClause = new qGen.Where();
                                Actual.WhereClause.AddWithValue("id_comprob", 0);
                                Actual.WhereClause.AddWithValue("id_ticket", this.Elemento.Id);
                                this.Connection.Execute(Actual);
                        } else {
                                txtComprobante.Text = "";
                        }
                }


                private void lvHistorial_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Enter:
                                        if (ListaHistorial.SelectedItems.Count > 0) {
                                                e.Handled = true;
                                                Lui.Forms.MessageBox.Show(ListaHistorial.SelectedItems[0].SubItems[3].Text, ListaHistorial.SelectedItems[0].SubItems[1].Text);
                                        }
                                        break;
                        }

                }


                private void BotonArticulos_Click(object sender, System.EventArgs e)
                {
                        Tareas.Articulos FormularioArticulos = new Tareas.Articulos();
                        FormularioArticulos.MdiParent = this.ParentForm.MdiParent;
                        FormularioArticulos.Tarea = this.Elemento as Lbl.Tareas.Tarea;
                        FormularioArticulos.Show();
                }


                public void MostrarPresupuesto2()
                {
                        decimal ValorArticulos = this.Connection.FieldDecimal("SELECT SUM(cantidad*precio) FROM tickets_articulos WHERE id_ticket=" + this.Elemento.Id.ToString());
                        EntradaPresupuesto2.ValueDecimal = ValorArticulos * (1 - Descuento / 100);
                }

                private void lvHistorial_SelectedIndexChanged(object sender, System.EventArgs e)
                {
                        if (ListaHistorial.SelectedItems.Count > 0)
                                ListaHistorial.SelectedItems[0].EnsureVisible();
                }
        }
}