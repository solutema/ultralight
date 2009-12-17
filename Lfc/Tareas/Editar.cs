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

namespace Lfc.Tareas
{
        public partial class Editar : Lui.Forms.EditForm
        {
                internal int iEstadoOriginal = 0;
                internal double Descuento = 0;
                
                public Editar() : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                }

                public override Lfx.Types.OperationResult Create()
                {
                        Lbl.Tareas.Tarea Tarea = new Lbl.Tareas.Tarea(this.DataView);
                        Tarea.Crear();
                        Tarea.Encargado = new Lbl.Personas.Persona(Tarea.DataView, this.Workspace.CurrentUser.Id);
                        Tarea.Estado = 1;
                        Tarea.Tipo = new Lbl.Tareas.Tipo(Tarea.DataView, 1);
                        this.FromRow(Tarea);
                        return base.Create();
                }

                public override Lfx.Types.OperationResult Edit(int itemId)
                {
                        Lbl.Tareas.Tarea Tarea = new Lbl.Tareas.Tarea(this.DataView, itemId);
                        this.FromRow(Tarea);
                        return base.Edit(itemId);
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Tareas.Tarea Res = this.CachedRow as Lbl.Tareas.Tarea;

                        if (txtCliente.TextInt == 0)
                                Res.Cliente = null;
                        else
                                Res.Cliente = new Lbl.Personas.Persona(Res.DataView, txtCliente.TextInt);

                        if (txtTecnico.TextInt == 0)
                                Res.Encargado = null;
                        else
                                Res.Encargado = new Lbl.Personas.Persona(Res.DataView, txtTecnico.TextInt);
                        
                        Res.Tipo = new Lbl.Tareas.Tipo(Res.DataView, txtTarea.TextInt);
                        Res.Prioridad = Lfx.Types.Parsing.ParseInt(txtPrioridad.TextKey);
                        Res.Nombre = txtAsunto.Text;
                        Res.Descripcion = txtDescripcion.Text;
                        Res.Estado = txtEstado.TextInt;
                        Res.FechaEstimada = Lfx.Types.Parsing.ParseDate(txtEntregaEstimada.Text);
                        Res.FechaLimite = Lfx.Types.Parsing.ParseDate(txtEntregaLimite.Text);
                        Res.Presupuesto = Lfx.Types.Parsing.ParseCurrency(txtPresupuesto.Text);
                        Res.Obs = txtObs.Text;

                        return base.ToRow();
                }

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Tareas.Tarea Res = row as Lbl.Tareas.Tarea;

                        txtNumero.Text = Res.Id.ToString();
                        txtAsunto.Text = Res.Nombre;
                        if (Res.Cliente == null)
                                txtCliente.TextInt = 0;
                        else
                                txtCliente.TextInt = Res.Cliente.Id;

                        if (Res.Encargado == null)
                                txtTecnico.TextInt = 0;
                        else
                                txtTecnico.TextInt = Res.Encargado.Id;

                        if (Res.Tipo == null)
                                txtTarea.TextInt = 0;
                        else
                                txtTarea.TextInt = Res.Tipo.Id;

                        txtPrioridad.TextKey = Res.Prioridad.ToString();
                        txtDescripcion.Text = Res.Descripcion;
                        txtEstado.TextInt = Res.Estado;
                        txtFechaIngreso.Text = Lfx.Types.Formatting.FormatDateAndTime(Res.Fecha);
                        txtEntregaEstimada.Text = Lfx.Types.Formatting.FormatDate(Res.FechaEstimada);
                        txtEntregaLimite.Text = Lfx.Types.Formatting.FormatDate(Res.FechaLimite);
                        txtPresupuesto.Text = Lfx.Types.Formatting.FormatCurrency(Res.Presupuesto, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        txtObs.Text = Res.Obs;

                        if (Res.Existe) {
                                this.Text = "Tareas: " + Res.ToString();
                                MostrarPresupuesto2();
                                CargarHistorial();
                        } else {
                                this.Text = "Tareas: nueva";
                        }
                }

                public override Lui.Printing.ItemPrint FormatForPrinting(Lui.Printing.ItemPrint ImprimirItem)
                {
                        ImprimirItem.Titulo = "Tarea Nº " + txtNumero.Text;
                        ImprimirItem.ParesAgregar("Tipo de Tarea", txtTarea.TextDetail, 1);
                        ImprimirItem.ParesAgregar("Asunto", txtAsunto.Text, 1);
                        ImprimirItem.ParesAgregar("Cliente", txtCliente.TextDetail, 1);
                        // Datos del cliente
                        if (txtDescripcion.Text.Length > 0)
                                ImprimirItem.ParesAgregar("Descripción", txtDescripcion.Text, 1);

                        ImprimirItem.ParesAgregar("Encargado", txtTecnico.TextDetail, 1);
                        ImprimirItem.ParesAgregar("Estado", txtEstado.TextDetail, 1);
                        ImprimirItem.ParesAgregar("Fecha de Ingreso", txtFechaIngreso.Text, 1);
                        if (Lfx.Types.Parsing.ParseCurrency(txtPresupuesto.Text) != 0)
                                ImprimirItem.ParesAgregar("Presupuesto", Lfx.Types.Currency.CurrencySymbol + " " + txtPresupuesto.Text, 1);

                        if (Lfx.Types.Parsing.ParseCurrency(txtPresupuesto2.Text) != 0) {
                                ImprimirItem.ParesAgregar("Artículos", Lfx.Types.Currency.CurrencySymbol + " " + txtPresupuesto2.Text, 1);
                                //Detalle artículos
                                System.Data.DataTable Articulos = this.Workspace.DefaultDataBase.Select("SELECT * FROM tickets_articulos WHERE id_ticket=" + m_Id.ToString() + " ORDER BY orden");
                                foreach (System.Data.DataRow Articulo in Articulos.Rows) {
                                        ImprimirItem.ParesAgregar(Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Articulo["precio"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces), "[" + Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Articulo["cantidad"]), this.Workspace.CurrentConfig.Products.StockDecimalPlaces) + "] " + System.Convert.ToString(Articulo["nombre"]), 2);
                                }
                        }

                        System.Data.DataTable Eventos = this.Workspace.DefaultDataBase.Select("SELECT tickets_eventos.fecha, tickets_eventos.descripcion, personas.nombre FROM tickets_eventos, personas WHERE tickets_eventos.privado=0 AND tickets_eventos.id_tecnico=personas.id_persona AND id_ticket=" + m_Id.ToString() + " ORDER BY id_evento DESC");
                        if (Eventos.Rows.Count > 0) {
                                ImprimirItem.ParesAgregar("Historial", "", 1);
                                foreach (System.Data.DataRow Evento in Eventos.Rows) {
                                        ImprimirItem.ParesAgregar(System.Convert.ToString(Evento["fecha"]), "[" + System.Convert.ToString(Evento["nombre"]) + "] " + System.Convert.ToString(Evento["descripcion"]), 2);
                                }
                        }
                        return ImprimirItem;
                }



                public override Lfx.Types.OperationResult ValidateData()
                {
                        Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();

                        if (txtTecnico.TextInt == 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Debe seleccionar el Encargado." + Environment.NewLine;
                        }
                        if (txtCliente.TextInt == 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Debe seleccionar el Cliente." + Environment.NewLine;
                        }
                        if (txtTarea.TextInt == 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Debe seleccionar el tipo de Tarea." + Environment.NewLine;
                        }
                        return validarReturn;
                }


                public override Lfx.Types.OperationResult Save()
                {
                        bool Existia = this.CachedRow.Existe;
                        int EstadoOriginal = this.CachedRow.Estado;

                        Lfx.Types.OperationResult ResultadoGuardar = base.Save();

                        if (ResultadoGuardar.Success) {
                                if (Existia == false) {
                                        Lui.Forms.MessageBox.Show("Acaba de crear y guardar la Tarea Nº " + m_Id.ToString(), "Tarea Nº " + m_Id.ToString());
                                } else if (this.CachedRow.Estado != EstadoOriginal) {
                                        Lbl.Tareas.Tarea Tar = this.CachedRow as Lbl.Tareas.Tarea;
                                        Lfx.Data.SqlInsertBuilder InsertarNovedad = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "tickets_eventos");
                                        InsertarNovedad.Fields.AddWithValue("id_ticket", Tar.Id);
                                        InsertarNovedad.Fields.AddWithValue("id_tecnico", this.Workspace.CurrentUser.Id);
                                        InsertarNovedad.Fields.AddWithValue("minutos_tecnico", 0);
                                        InsertarNovedad.Fields.AddWithValue("privado", 1);
                                        InsertarNovedad.Fields.AddWithValue("descripcion", "Est:" + Tar.Estado.ToString());
                                        InsertarNovedad.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                                        DataView.Execute(InsertarNovedad);
                                }
                        }
                        return ResultadoGuardar;
                }


                private void CargarHistorial()
                {
                        lvHistorial.BeginUpdate();
                        lvHistorial.Items.Clear();

                        string TextoSql = "SELECT tickets_eventos.id_ticket, tickets_eventos.fecha, tickets_eventos.descripcion, personas.nombre FROM tickets_eventos, personas WHERE tickets_eventos.id_tecnico=personas.id_persona AND tickets_eventos.id_ticket IN (SELECT id_ticket FROM tickets WHERE id_persona=" + txtCliente.TextInt.ToString() + ") ORDER BY id_ticket DESC";
                        System.Data.DataTable Eventos = this.Workspace.DefaultDataBase.Select(TextoSql);
                        if (Eventos.Rows.Count > 0) {

                                foreach (System.Data.DataRow Evento in Eventos.Rows) {
                                        ListViewItem itm = lvHistorial.Items.Add(System.Convert.ToString(Evento["id_ticket"]));
                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Evento["nombre"].ToString()));
                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatDate(Evento["fecha"])));
                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Evento["descripcion"]).Replace(System.Convert.ToString(Lfx.Types.ControlChars.Cr), " ").Replace(System.Convert.ToString(Lfx.Types.ControlChars.Lf), "")));
                                        if (System.Convert.ToInt32(Evento["id_ticket"]) != this.m_Id)
                                                itm.ForeColor = System.Drawing.Color.Gray;
                                }

                                if (lvHistorial.Items.Count > 0) {
                                        lvHistorial.Items[0].Focused = true;
                                        lvHistorial.Items[0].Selected = true;
                                }
                        }

                        lvHistorial.EndUpdate();

                        // Ancho automático para las columnas
                        foreach (System.Windows.Forms.ColumnHeader lvHeader in lvHistorial.Columns) {
                                lvHeader.Width = -2;
                        }

                }


                private void FormTicketsEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.F4:
                                        e.Handled = true;
                                        if (cmdFacturar.Enabled && cmdFacturar.Visible)
                                                cmdFacturar.PerformClick();
                                        break;
                                case Keys.F5:
                                        e.Handled = true;
                                        if (cmdArticulos.Enabled && cmdArticulos.Visible)
                                                cmdArticulos.PerformClick();
                                        break;
                                case Keys.F6:
                                        e.Handled = true;
                                        if (cmdNovedad.Enabled && cmdNovedad.Visible)
                                                cmdNovedad.PerformClick();
                                        break;
                        }


                }


                private void cmdNovedad_Click(object sender, System.EventArgs e)
                {
                        if (m_Nuevo) {
                                Lui.Forms.MessageBox.Show("No se puede cargar novedades en una Tarea que aun no ha sido creada.", "Error");
                        } else {
                                Tareas.Novedad OFormNovedadCargar = new Tareas.Novedad();
                                OFormNovedadCargar.Workspace = this.Workspace;
                                OFormNovedadCargar.Create();
                                OFormNovedadCargar.txtTicket.TextInt = m_Id;
                                OFormNovedadCargar.txtTicket.Enabled = false;
                                if (OFormNovedadCargar.ShowDialog() == DialogResult.OK)
                                        this.CargarHistorial();
                        }
                }

                private void cmdFacturar_Click(object sender, System.EventArgs e)
                {
                        Comprobantes.Facturas.Editar FacturaNueva = (Comprobantes.Facturas.Editar)this.Workspace.RunTime.Execute("CREAR B");

                        FacturaNueva.ControlDestino = txtComprobanteId;

                        int intComprobanteId = Lfx.Types.Parsing.ParseInt(txtComprobanteId.Text);
                        bool bAnulada = System.Convert.ToBoolean(this.Workspace.DefaultDataBase.FieldInt("SELECT anulada FROM facturas WHERE id_factura=" + intComprobanteId.ToString()));

                        if (intComprobanteId > 0 && bAnulada == false) {
                                FacturaNueva.Edit(intComprobanteId);
                                FacturaNueva.Show();
                        } else {
                                if (this.Save().Success == true) {
                                        FacturaNueva.Create("B");

                                        FacturaNueva.EntradaCliente.Text = txtCliente.Text;
                                        FacturaNueva.EntradaVendedor.Text = txtTecnico.Text;
                                        ((Lbl.Comprobantes.Comprobante)FacturaNueva.CachedRow).Obs = txtTarea.TextDetail + " s/tarea #" + m_Id.ToString();

                                        System.Data.DataTable Articulos = this.Workspace.DefaultDataBase.Select("SELECT * FROM tickets_articulos WHERE id_ticket=" + m_Id.ToString() + " ORDER BY orden");
                                        FacturaNueva.ProductArray.Count = Articulos.Rows.Count;
                                        for (int i = 0; i <= Articulos.Rows.Count - 1; i++) {
                                                FacturaNueva.ProductArray.ChildControls[i].TextInt = System.Convert.ToInt32(Articulos.Rows[i]["id_articulo"]);
                                                FacturaNueva.ProductArray.ChildControls[i].TextDetail = System.Convert.ToString(Articulos.Rows[i]["nombre"]);
                                                FacturaNueva.ProductArray.ChildControls[i].Cantidad = System.Convert.ToDouble(Articulos.Rows[i]["cantidad"]);
                                                //TODO: Descuento por item
                                                FacturaNueva.ProductArray.ChildControls[i].Unitario = System.Convert.ToDouble(Articulos.Rows[i]["precio"]) * (1 - Descuento / 100);
                                        }
                                        if (Lfx.Types.Parsing.ParseCurrency(txtPresupuesto.Text) > 0) {
                                                FacturaNueva.ProductArray.Count++;
                                                int i = FacturaNueva.ProductArray.Count - 1;
                                                FacturaNueva.ProductArray.ChildControls[i].TextInt = 282;
                                                FacturaNueva.ProductArray.ChildControls[i].Cantidad = 1;
                                                FacturaNueva.ProductArray.ChildControls[i].Unitario = Lfx.Types.Parsing.ParseCurrency(txtPresupuesto.Text);
                                        }
                                        FacturaNueva.ProductArray.AutoAgregar = true;

                                        if (Descuento > 0) {
                                                // Si hay descuento sobre los artículos, lo agrego en las observaciones
                                                ((Lbl.Comprobantes.Comprobante)FacturaNueva.CachedRow).Obs += " - Descuento Sobre Artículos: " + Lfx.Types.Formatting.FormatNumber(Descuento) + "%";
                                        }
                                        FacturaNueva.Show();

                                }
                        }
                }

                private void txtComprobanteId_TextChanged(object sender, System.EventArgs e)
                {
                        int intComprobanteId = Lfx.Types.Parsing.ParseInt(txtComprobanteId.Text);
                        if (intComprobanteId > 0) {
                                txtComprobante.Text = Lbl.Comprobantes.Comprobante.NumeroCompleto(this.DataView, intComprobanteId);
                                // Guardo el comprobante en la tarea (sólo si no tenía uno asociado)
                                //this.Workspace.DefaultDataView.Execute("UPDATE tickets SET id_factura=" + intComprobanteId.ToString() + " WHERE id_factura=0 AND id_ticket=" + m_Id.ToString());
                                Lfx.Data.SqlUpdateBuilder Actual = new Lfx.Data.SqlUpdateBuilder("tickets");
                                Actual.Fields.Add(new Lfx.Data.SqlField("id_factura", intComprobanteId));
                                Actual.WhereClause = new Lfx.Data.SqlWhereBuilder("id_factura=0 AND id_ticket=" + m_Id.ToString());
                                this.DataView.Execute(Actual);
                        } else {
                                txtComprobante.Text = "";
                        }
                }


                private void lvHistorial_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Enter:
                                        if (lvHistorial.SelectedItems.Count > 0) {
                                                e.Handled = true;
                                                Lui.Forms.MessageBox.Show(lvHistorial.SelectedItems[0].SubItems[3].Text, lvHistorial.SelectedItems[0].SubItems[1].Text);
                                        }
                                        break;
                        }

                }


                private void cmdArticulos_Click(object sender, System.EventArgs e)
                {
                        if (m_Nuevo) {
                                Lui.Forms.MessageBox.Show("No se puede cargar artículos en una Tarea que aun no ha sido creada.", "Error");
                        } else {
                                Tareas.Articulos OFormTicketsArticulos = new Tareas.Articulos();
                                OFormTicketsArticulos.Workspace = this.Workspace;
                                OFormTicketsArticulos.MdiParent = this.MdiParent;
                                OFormTicketsArticulos.Edit(m_Id);
                                OFormTicketsArticulos.Show();
                        }
                }


                public void MostrarPresupuesto2()
                {
                        double ValorArticulos = this.Workspace.DefaultDataBase.FieldDouble("SELECT SUM(cantidad*precio) FROM tickets_articulos WHERE id_ticket=" + m_Id.ToString());
                        txtPresupuesto2.Text = Lfx.Types.Formatting.FormatCurrency(ValorArticulos * (1 - Descuento / 100), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                }


                private void FormTicketsEditar_Activated(object sender, System.EventArgs e)
                {
                        MostrarPresupuesto2();
                }


                private void lvHistorial_SelectedIndexChanged(object sender, System.EventArgs e)
                {
                        if (lvHistorial.SelectedItems.Count > 0)
                                lvHistorial.SelectedItems[0].EnsureVisible();
                }
        }
}