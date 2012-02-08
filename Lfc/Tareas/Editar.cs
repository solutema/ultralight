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
                        Lbl.Tareas.Tarea Tarea = this.Elemento as Lbl.Tareas.Tarea;

                        EntradaAsunto.Text = Tarea.Nombre;
                        EntradaCliente.Elemento = Tarea.Cliente;
                        EntradaTecnico.Elemento = Tarea.Encargado;
                        EntradaTarea.Elemento = Tarea.Tipo;
                        EntradaPrioridad.TextKey = Tarea.Prioridad.ToString();
                        EntradaDescripcion.Text = Tarea.Descripcion;
                        EntradaEstado.TextInt = Tarea.Estado;
                        EntradaFechaIngreso.Text = Lfx.Types.Formatting.FormatDateAndTime(Tarea.Fecha);
                        EntradaEntregaEstimada.Text = Lfx.Types.Formatting.FormatDate(Tarea.FechaEstimada);
                        EntradaEntregaLimite.Text = Lfx.Types.Formatting.FormatDate(Tarea.FechaLimite);
                        EntradaPresupuesto.Text = Lfx.Types.Formatting.FormatCurrency(Tarea.Presupuesto, Lfx.Workspace.Master.CurrentConfig.Moneda.Decimales);
                        EntradaObs.Text = Tarea.Obs;

                        if (Tarea.Existe) {
                                MostrarPresupuesto2();
                                CargarHistorial();
                        }

                        base.ActualizarControl();

                        if (Tarea.Existe)
                                this.Text = Tarea.ToString() + " de " + Tarea.Cliente.ToString();
                        else
                                this.Text = "Creando nueva tarea";
                }


                public override Lfx.Types.OperationResult ValidarControl()
                {
                        if (EntradaAsunto.Text.Length == 0) 
                                return new Lfx.Types.FailureOperationResult("Debe escribir el nombre de la tarea.");

                        if (EntradaTecnico.Elemento == null)
                                return new Lfx.Types.FailureOperationResult("Debe seleccionar el Encargado.");

                        if (EntradaCliente.Elemento == null)
                                return new Lfx.Types.FailureOperationResult("Debe seleccionar el Cliente.");

                        if (EntradaTarea.Elemento == null)
                                return new Lfx.Types.FailureOperationResult("Debe seleccionar el tipo de Tarea.");

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


                private Lfx.Types.OperationResult CargarNovedad()
                {
                        if (this.Elemento.Existe == false) {
                                return new Lfx.Types.FailureOperationResult("No se puede cargar novedades en una Tarea que aun no ha sido creada.");
                        } else {
                                Tareas.Novedad FormularioNovedad = new Tareas.Novedad();
                                FormularioNovedad.EntradaTicket.Elemento = this.Elemento;
                                FormularioNovedad.EntradaTicket.Enabled = false;
                                if (FormularioNovedad.ShowDialog() == DialogResult.OK)
                                        this.CargarHistorial();
                                return new Lfx.Types.SuccessOperationResult();
                        }
                }

                private Lfx.Types.OperationResult Facturar()
                {
                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("¿Desea guardar los cambios realizados y generar una factura a partir de esta tarea?", "Facturar");
                        if (Pregunta.ShowDialog() != DialogResult.OK)
                                return new Lfx.Types.CancelOperationResult();

                        if (EntradaEstado.TextInt < 50)
                                EntradaEstado.TextInt = 50;

                        Lfx.Types.OperationResult Res = this.Save();
                        if (Res.Success == false)
                                return Res;

                        Lfx.Data.Connection ConnFacturaNueva = Lfx.Workspace.Master.GetNewConnection("Convertir tarea en factura");
                        Lbl.Comprobantes.Factura Factura;

                        int ComprobanteId = Lfx.Types.Parsing.ParseInt(EntradaComprobanteId.Text);
                        bool ComprobanteAnulado;
                        if (ComprobanteId > 0)
                                ComprobanteAnulado = System.Convert.ToBoolean(this.Connection.FieldInt("SELECT anulada FROM comprob WHERE id_comprob=" + ComprobanteId.ToString()));
                        else
                                ComprobanteAnulado = false;

                        if (ComprobanteId > 0 && ComprobanteAnulado == false) {
                                // Ya tiene un comprobante, pero fue anulado
                                Factura = new Lbl.Comprobantes.Factura(ConnFacturaNueva, ComprobanteId);
                        } else {
                                // No tiene comprobante, lo creo
                                Factura = new Lbl.Comprobantes.Factura(ConnFacturaNueva);

                                Factura.Crear();
                                Factura.Cliente = EntradaCliente.Elemento as Lbl.Personas.Persona;
                                Factura.Cliente.Connection = ConnFacturaNueva;
                                Factura.Tipo = Factura.Cliente.ObtenerTipoComprobante();
                                Factura.Tipo.Connection = ConnFacturaNueva;
                                Factura.Vendedor = EntradaTecnico.Elemento as Lbl.Personas.Persona;
                                Factura.Vendedor.Connection = ConnFacturaNueva;
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
                                if (EntradaPresupuesto.ValueDecimal > 0) {
                                        Lbl.Comprobantes.DetalleArticulo Art = new Lbl.Comprobantes.DetalleArticulo(Factura);

                                        Art.Nombre = this.Elemento.ToString();
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
                        return new Lfx.Types.SuccessOperationResult();
                }

                private void EntradaComprobanteId_TextChanged(object sender, System.EventArgs e)
                {
                        int ComprobanteId = Lfx.Types.Parsing.ParseInt(EntradaComprobanteId.Text);
                        if (ComprobanteId > 0) {
                                EntradaComprobante.Text = Lbl.Comprobantes.Comprobante.TipoYNumeroCompleto(this.Connection, ComprobanteId);
                                // Guardo el comprobante en la tarea (sólo si no tenía uno asociado)
                                System.Data.IDbTransaction Trans = this.Connection.BeginTransaction();
                                qGen.Update Actual = new qGen.Update("tickets");
                                Actual.Fields.Add(new Lfx.Data.Field("id_comprob", ComprobanteId));
                                Actual.WhereClause = new qGen.Where();
                                Actual.WhereClause.AddWithValue("id_comprob", 0);
                                Actual.WhereClause.AddWithValue("id_ticket", this.Elemento.Id);
                                this.Connection.Execute(Actual);
                                Trans.Commit();
                        } else {
                                EntradaComprobante.Text = "";
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


                private Lfx.Types.OperationResult EditarArticulos()
                {
                        Tareas.Articulos FormularioArticulos = new Tareas.Articulos();
                        FormularioArticulos.MdiParent = this.ParentForm.MdiParent;
                        FormularioArticulos.Tarea = this.Elemento as Lbl.Tareas.Tarea;
                        FormularioArticulos.Show();

                        return new Lfx.Types.SuccessOperationResult();
                }


                public void MostrarPresupuesto2()
                {
                        decimal ValorArticulos = this.Connection.FieldDecimal("SELECT SUM(cantidad*precio) FROM tickets_articulos WHERE id_ticket=" + this.Elemento.Id.ToString());
                        EntradaPresupuesto2.ValueDecimal = ValorArticulos * (1 - Descuento / 100);
                }


                private void ListaHistorial_SelectedIndexChanged(object sender, System.EventArgs e)
                {
                        if (ListaHistorial.SelectedItems.Count > 0)
                                ListaHistorial.SelectedItems[0].EnsureVisible();
                }


                public override Lazaro.Pres.Forms.FormActionCollection GetFormActions()
                {
                        Lazaro.Pres.Forms.FormActionCollection Res = base.GetFormActions();
                        Res.Add(new Lazaro.Pres.Forms.FormAction("Facturar", "F4", "facturar", 30, Lazaro.Pres.Forms.FormActionVisibility.Secondary));
                        Res.Add(new Lazaro.Pres.Forms.FormAction("Artículos", "F5", "articulos", 10, Lazaro.Pres.Forms.FormActionVisibility.Secondary));
                        Res.Add(new Lazaro.Pres.Forms.FormAction("Novedad", "F6", "novedad", 20, Lazaro.Pres.Forms.FormActionVisibility.Secondary));
                        return Res;
                }


                public override Lfx.Types.OperationResult PerformFormAction(string name)
                {
                        switch (name) {
                                case "facturar":
                                        return Facturar();
                                case "articulos":
                                        return EditarArticulos();
                                case "novedad":
                                        return CargarNovedad();
                                default:
                                        return base.PerformFormAction(name);
                        }
                }
        }
}