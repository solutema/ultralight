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

namespace Lfc.CuentasCorrientes
{
        public partial class Inicio : Lfc.FormularioCuenta
        {
                private int m_Grupo = 0, m_Localidad = 0;
                private decimal Transporte = 0;

                public Inicio()
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.CuentasCorrientes.CuentaCorriente), Lbl.Sys.Permisos.Operaciones.Listar) == false) {
                                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                                this.Close();
                                return;
                        }

                        InitializeComponent();

                        this.Definicion = new Lazaro.Pres.Listings.Listing()
                        {
                                TableName = "ctacte",
                                KeyColumnName = new Lazaro.Pres.Field("ctacte.id_movim", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                Joins = new qGen.JoinCollection() { new qGen.Join("personas", "ctacte.id_cliente=personas.id_persona") },
                                Columns = new Lazaro.Pres.FieldCollection() {
                                        new Lazaro.Pres.Field("personas.nombre_visible", "Persona", Lfx.Data.InputFieldTypes.Text, 320),
                                        new Lazaro.Pres.Field("ctacte.id_concepto", "Concepto", Lfx.Data.InputFieldTypes.Relation, 0),
                                        new Lazaro.Pres.Field("ctacte.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 320),
                                        new Lazaro.Pres.Field("ctacte.fecha", "Fecha.", Lfx.Data.InputFieldTypes.Date, 100),
                                        new Lazaro.Pres.Field("ctacte.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
                                        new Lazaro.Pres.Field("ctacte.saldo", "Saldo", Lfx.Data.InputFieldTypes.Currency, 96),
                                        new Lazaro.Pres.Field("ctacte.obs", "Obs.", Lfx.Data.InputFieldTypes.Text, 320),
                                        new Lazaro.Pres.Field("ctacte.comprob", "Comprobante", Lfx.Data.InputFieldTypes.Text, 160),
                                        new Lazaro.Pres.Field("ctacte.id_recibo", "Recibo", Lfx.Data.InputFieldTypes.Relation, 0)
                                },
                                Filters = new Lazaro.Pres.Filters.FilterCollection() {
                                        new Lazaro.Pres.Filters.RelationFilter("Cliente", new Lfx.Data.Relation("ctacte.id_cliente", "personas", "id_persona", "nombre_visible")),
                                        new Lazaro.Pres.Filters.RelationFilter("Grupo", new Lfx.Data.Relation("personas.id_grupo", "personas_grupos", "id_grupo")),
                                        new Lazaro.Pres.Filters.RelationFilter("Localidad", new Lfx.Data.Relation("personas.id_ciudad", "ciudades", "id_ciudad")),
                                        new Lazaro.Pres.Filters.DateRangeFilter("Fecha", "ctacte.fecha", new Lfx.Types.DateRange("*"))
                                },
                                OrderBy = "personas.nombre_visible"
                        };

                        this.Fechas = new Lfx.Types.DateRange("*");

                        this.HabilitarFiltrar = true;
                }


                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        decimal Importe = row.Fields["ctacte.importe"].ValueDecimal;
                        decimal Saldo = row.Fields["ctacte.saldo"].ValueDecimal;

                        if (this.Cliente == null) {
                                if (Saldo < 0) {
                                        this.Contadores[2].AddValue(-Saldo);          // Pasivos
                                        if (item.SubItems.ContainsKey("ctacte.saldo"))
                                                item.SubItems["ctacte.saldo"].ForeColor = Color.Red;
                                        item.UseItemStyleForSubItems = false;
                                } else if (Importe > 0) {
                                        this.Contadores[1].AddValue(Saldo);           // Crédito
                                }
                        } else {
                                if (Importe < 0) {
                                        this.Contadores[2].AddValue(-Importe);        // Egresos
                                        item.SubItems["ctacte.importe"].ForeColor = Color.Red;
                                        item.UseItemStyleForSubItems = false;
                                } else if (Importe > 0) {
                                        this.Contadores[1].AddValue(Importe);         // Ingresos
                                }
                        }

                        base.OnItemAdded(item, row);
                }


                protected override void OnBeginRefreshList()
                {
                        this.CustomFilters.Clear();

                        // TODO: si estoy usando rago de fechas, obtener el transporte
                        Transporte = 0;

                        if (this.Cliente == null) {
                                // Es para todas los clientes
                                this.Definicion.GroupBy = new Lazaro.Pres.Field("ctacte.id_cliente", "Cliente");
                                this.Definicion.OrderBy = "personas.nombre_visible";
                                this.Text = "Listado de Cuentas Corrientes";

                                this.Definicion.Columns["nombre_visible"].Visible = true;
                                this.Definicion.Columns["fecha"].Visible = false;
                                this.Definicion.Columns["concepto"].Visible = false;
                                this.Definicion.Columns["importe"].Visible = false;
                                this.Definicion.Columns["saldo"].Visible = true;
                                this.Definicion.Columns["obs"].Visible = false;
                                this.Definicion.Columns["comprob"].Visible = false;

                                this.Definicion.Columns["saldo"].MemberName = "SUM(ctacte.importe) AS saldo";
                                this.Definicion.Having = new qGen.Where("saldo", qGen.ComparisonOperators.NotEquals, 0);

                                this.UpdateFormFields();

                                this.Contadores[1].Etiqueta = "Créditos";
                                this.Contadores[2].Etiqueta = "Pasivos";

                                if (m_Grupo != 0)
                                        this.CustomFilters.AddWithValue("personas.id_grupo", m_Grupo);
                                
                                if (m_Localidad != 0)
                                        this.CustomFilters.AddWithValue("personas.id_ciudad", m_Localidad);
                        } else {
                                // Es un cliente en particular
                                this.CustomFilters.AddWithValue("ctacte.id_cliente", this.Cliente.Id);
                                this.Definicion.GroupBy = null;
                                this.Definicion.OrderBy = "ctacte.id_movim DESC";
                                this.Text = "Cuenta Corriente de " + this.Cliente.ToString();

                                this.Definicion.Columns["nombre_visible"].Visible = false;
                                this.Definicion.Columns["fecha"].Visible = true;
                                this.Definicion.Columns["concepto"].Visible = true;
                                this.Definicion.Columns["importe"].Visible = true;
                                this.Definicion.Columns["saldo"].Visible = true;
                                this.Definicion.Columns["obs"].Visible = true;
                                this.Definicion.Columns["comprob"].Visible = true;

                                this.Definicion.Columns["saldo"].MemberName = "ctacte.saldo";
                                this.Definicion.Having = null;

                                this.UpdateFormFields();

                                this.Contadores[1].Etiqueta = "Créditos";
                                this.Contadores[2].Etiqueta = "Débitos";
                        }

                        if (Fechas.HasRange)
                                this.CustomFilters.AddWithValue("ctacte.fecha", Fechas.From, Fechas.To);

                        base.OnBeginRefreshList();
                }


                protected override void OnEndRefreshList()
                {
                        this.Contadores[0].AddValue(Transporte);
                        this.Contadores[3].AddValue(Transporte + this.Contadores[1].Total - this.Contadores[2].Total);

                        base.OnEndRefreshList();
                }


                protected override Lfx.Types.OperationResult OnEdit(int itemId)
                {
                        Lfx.Data.Row Movim = this.Connection.Tables["ctacte"].FastRows[itemId];
                        if (this.Cliente == null) {
                                this.Cliente = new Lbl.Personas.Persona(this.Connection, System.Convert.ToInt32(Movim["id_cliente"]));
                                ((Lazaro.Pres.Filters.RelationFilter)(this.Definicion.Filters["ctacte.id_cliente"])).Value = this.Cliente;
                                RefreshList();
                        } else {
                                if (Movim != null) {
                                        if (Movim["id_recibo"] != null) {
                                                int IdRecibo = System.Convert.ToInt32(Movim["id_recibo"]);
                                                this.Workspace.RunTime.Execute("EDITAR Lbl.Comprobantes.Recibo " + IdRecibo.ToString());
                                        }
                                        if (Movim["id_comprob"] != null) {
                                                int IdFactura = System.Convert.ToInt32(Movim["id_comprob"]);
                                                this.Workspace.RunTime.Execute("EDITAR Lbl.Comprobantes.ComprobanteConArticulos " + IdFactura.ToString());
                                        }
                                }
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }


                public override void OnFiltersChanged(Lazaro.Pres.Filters.FilterCollection filters)
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.CuentasCorrientes.CuentaCorriente), Lbl.Sys.Permisos.Operaciones.Ver)) {
                                this.Cliente = filters["ctacte.id_cliente"].Value as Lbl.Personas.Persona;        
                        }
                        m_Grupo = ((Lazaro.Pres.Filters.RelationFilter)(filters["personas.id_grupo"])).ElementId;
                        m_Localidad = ((Lazaro.Pres.Filters.RelationFilter)(filters["personas.id_ciudad"])).ElementId;
                        Fechas = ((Lazaro.Pres.Filters.DateRangeFilter)(filters["ctacte.fecha"])).DateRange;

                        base.OnFiltersChanged(filters);
                }


                private void BotonNotaCred_Click(object sender, System.EventArgs e)
                {
                        if (this.Cliente != null) {
                                Lbl.Comprobantes.NotaDeCredito Nota = new Lbl.Comprobantes.NotaDeCredito(this.Connection);
                                Nota.Crear();
                                Nota.Cliente = this.Cliente;
                                Lfc.FormularioEdicion FormularioNota = Lfc.Instanciador.InstanciarFormularioEdicion(Nota);
                                FormularioNota.Connection = this.Connection;
                                FormularioNota.MdiParent = this.MdiParent;
                                FormularioNota.Show();
                        } else {
                                Lui.Forms.MessageBox.Show("Debe seleccionar una persona. Utilice la opción Filtros (tecla <F2>).", "Error");
                        }
                }


                private void BotonNotaDeb_Click(object sender, System.EventArgs e)
                {
                        if (this.Cliente != null) {
                                Lbl.Comprobantes.NotaDeDebito Nota = new Lbl.Comprobantes.NotaDeDebito(this.Connection);
                                Nota.Crear();
                                Nota.Cliente = this.Cliente;
                                Lfc.FormularioEdicion FormularioNota = Lfc.Instanciador.InstanciarFormularioEdicion(Nota);
                                FormularioNota.Connection = this.Connection;
                                FormularioNota.MdiParent = this.MdiParent;
                                FormularioNota.Show();
                        } else {
                                Lui.Forms.MessageBox.Show("Debe seleccionar una persona. Utilice la opción Filtros (tecla <F2>).", "Error");
                        }
                }


                protected override void OnKeyDown(KeyEventArgs e)
                {
                        if (e.Shift && e.Control) {
                                switch (e.KeyCode) {
                                        case Keys.F7:
                                                if (this.Cliente != null) {
                                                        // Recalculo la cuenta del cliente
                                                        Lui.Forms.MessageBox.Show("Se va a recalcular la Cuenta Corriente", "Aviso");
                                                        IDbTransaction Trans = this.Cliente.Connection.BeginTransaction();
                                                        this.Cliente.CuentaCorriente.Recalcular();
                                                        Trans.Commit();
                                                        this.RefreshList();
                                                }
                                                e.Handled = true;

                                                break;
                                }
                        }

                        if (e.Handled == false)
                                base.OnKeyDown(e);
                }


                private void BotonAjuste_Click(object sender, System.EventArgs e)
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.CuentasCorrientes.CuentaCorriente), Lbl.Sys.Permisos.Operaciones.Mover)) {
                                Ajuste FormAjuste = new Ajuste();
                                FormAjuste.Owner = this;
                                FormAjuste.SaldoActual = this.Contadores[3].Total;
                                if (FormAjuste.ShowDialog() == DialogResult.OK) {
                                        decimal Importe = FormAjuste.EntradaImporte.ValueDecimal;
                                        if (Importe == 0) {
                                                Lui.Forms.MessageBox.Show("El Importe debe ser mayor o menor que cero.", "Error");
                                        } else {
                                                int ClienteId = 0;
                                                if (this.Cliente != null)
                                                        ClienteId = this.Cliente.Id;
                                                else if (Listado.SelectedItems.Count == 1)
                                                        ClienteId = Lfx.Types.Parsing.ParseInt(Listado.SelectedItems[0].Text);
                                                else
                                                        Lui.Forms.MessageBox.Show("Debe seleccionar un cliente", "Ajuste");

                                                if (ClienteId > 0) {
                                                        Lbl.CuentasCorrientes.CuentaCorriente CtaCte = new Lbl.CuentasCorrientes.CuentaCorriente(new Lbl.Personas.Persona(this.Connection, ClienteId));
                                                        IDbTransaction Trans = CtaCte.Connection.BeginTransaction();
                                                        CtaCte.Movimiento(false,
                                                                FormAjuste.EntradaConcepto.Elemento as Lbl.Cajas.Concepto,
                                                                FormAjuste.EntradaConcepto.TextDetail,
                                                                Importe,
                                                                FormAjuste.EntradaObs.Text,
                                                                null,
                                                                null,
                                                                null,
                                                                false);
                                                        Trans.Commit();
                                                        this.RefreshList();
                                                }
                                        }
                                }
                        }
                }
        }
}