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
                        InitializeComponent();

                        this.NombreTabla = "ctacte";
                        this.KeyField = new Lfx.Data.FormField("ctacte.id_movim", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        this.Joins.Add(new qGen.Join("personas", "ctacte.id_cliente=personas.id_persona"));
                        this.FormFields = new Lfx.Data.FormFieldCollection() {
                                new Lfx.Data.FormField("personas.nombre_visible", "Persona", Lfx.Data.InputFieldTypes.Text, 320),
                                new Lfx.Data.FormField("ctacte.id_concepto", "Concepto", Lfx.Data.InputFieldTypes.Relation, 0),
                                new Lfx.Data.FormField("ctacte.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 320),
                                new Lfx.Data.FormField("ctacte.fecha", "Fecha.", Lfx.Data.InputFieldTypes.Date, 100),
                                new Lfx.Data.FormField("ctacte.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
                                new Lfx.Data.FormField("ctacte.saldo", "Saldo", Lfx.Data.InputFieldTypes.Currency, 96),
                                new Lfx.Data.FormField("ctacte.obs", "Obs.", Lfx.Data.InputFieldTypes.Text, 320),
                                new Lfx.Data.FormField("ctacte.comprob", "Comprobante", Lfx.Data.InputFieldTypes.Text, 160),
                                new Lfx.Data.FormField("ctacte.id_recibo", "Recibo", Lfx.Data.InputFieldTypes.Relation, 0)
                        };
                        this.OrderBy = "personas.nombre_visible";

                        this.Fechas = new Lfx.Types.DateRange("*");

                        this.HabilitarFiltrar = true;
                }


                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        decimal Importe = row.Fields["importe"].ValueDecimal;
                        decimal Saldo = row.Fields["saldo"].ValueDecimal;

                        if (this.Cliente == null) {
                                if (Saldo < 0) {
                                        this.Contadores[2].AddValue(-Saldo);          // Pasivos
                                        if (item.SubItems.ContainsKey("saldo"))
                                                item.SubItems["saldo"].ForeColor = Color.Red;
                                        item.UseItemStyleForSubItems = false;
                                } else if (Importe > 0) {
                                        this.Contadores[1].AddValue(Saldo);           // Crédito
                                }
                        } else {
                                if (Importe < 0) {
                                        this.Contadores[2].AddValue(-Importe);        // Egresos
                                        item.SubItems["importe"].ForeColor = Color.Red;
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
                                this.GroupBy = new Lfx.Data.FormField("ctacte.id_cliente", "Cliente");
                                this.OrderBy = "personas.nombre_visible";
                                this.Text = "Listado de Cuentas Corrientes";

                                this.FormFields["nombre_visible"].Visible = true;
                                this.FormFields["fecha"].Visible = false;
                                this.FormFields["concepto"].Visible = false;
                                this.FormFields["importe"].Visible = false;
                                this.FormFields["saldo"].Visible = true;
                                this.FormFields["obs"].Visible = false;
                                this.FormFields["comprob"].Visible = false;

                                this.FormFields["saldo"].ColumnName = "SUM(ctacte.importe) AS saldo";
                                this.Having = new qGen.Where("saldo", qGen.ComparisonOperators.NotEquals, 0);

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
                                this.GroupBy = null;
                                this.OrderBy = "ctacte.id_movim DESC";
                                this.Text = "Cuenta Corriente de " + this.Cliente.ToString();

                                this.FormFields["nombre_visible"].Visible = false;
                                this.FormFields["fecha"].Visible = true;
                                this.FormFields["concepto"].Visible = true;
                                this.FormFields["importe"].Visible = true;
                                this.FormFields["saldo"].Visible = true;
                                this.FormFields["obs"].Visible = true;
                                this.FormFields["comprob"].Visible = true;

                                this.FormFields["saldo"].ColumnName = "ctacte.saldo";
                                this.Having = null;

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


                public override Lfx.Types.OperationResult OnFilter()
                {
                        using (Filtros FormFiltros = new Filtros()) {
                                FormFiltros.Connection = this.Connection;
                                FormFiltros.EntradaCliente.Elemento = this.Cliente;
                                FormFiltros.EntradaGrupo.TextInt = m_Grupo;
                                FormFiltros.EntradaLocalidad.TextInt = m_Localidad;
                                FormFiltros.EntradaFechas.Rango = Fechas;

                                FormFiltros.ShowDialog();
                                if (FormFiltros.DialogResult == DialogResult.OK) {
                                        this.Cliente = FormFiltros.EntradaCliente.Elemento as Lbl.Personas.Persona;
                                        m_Grupo = FormFiltros.EntradaGrupo.TextInt;
                                        m_Localidad = FormFiltros.EntradaLocalidad.TextInt;
                                        Fechas = FormFiltros.EntradaFechas.Rango;
                                        this.RefreshList();
                                        return base.OnFilter();
                                } else {
                                        return new Lfx.Types.CancelOperationResult();
                                }
                        }
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


                private void Inicio_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Shift) {
                                switch (e.KeyCode) {
                                        case Keys.F7:
                                                if (this.Cliente != null) {
                                                        // Recalculo la cuenta del cliente
                                                        Lui.Forms.MessageBox.Show("Se va a recalcular la Cuenta Corriente", "Aviso");
                                                        this.Cliente.Connection.BeginTransaction();
                                                        this.Cliente.CuentaCorriente.Recalcular();
                                                        this.Cliente.Connection.Commit();
                                                        this.RefreshList();
                                                }
                                                e.Handled = true;

                                                break;
                                }
                        }
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
                                                        CtaCte.Connection.BeginTransaction();
                                                        CtaCte.Movimiento(false,
                                                                FormAjuste.EntradaConcepto.Elemento as Lbl.Cajas.Concepto,
                                                                FormAjuste.EntradaConcepto.TextDetail,
                                                                Importe,
                                                                FormAjuste.EntradaObs.Text,
                                                                null,
                                                                null,
                                                                null,
                                                                false);
                                                        CtaCte.Connection.Commit();
                                                        this.RefreshList();
                                                }
                                        }
                                }
                        }
                }
        }
}