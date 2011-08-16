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

namespace Lfc.Cajas
{
        public partial class Inicio : Lfc.FormularioCuenta
        {
                private Lbl.Cajas.Caja m_Caja = null;
                public int m_ConceptoId, m_TipoConcepto, m_Direccion;
                protected string m_ConceptoStr;
                protected decimal Transporte = 0;

                public Inicio()
                {
                        InitializeComponent();

                        this.Fechas = new Lfx.Types.DateRange("dia-0");
                        this.NombreTabla = "cajas_movim";
                        this.KeyField = new Lfx.Data.FormField("cajas_movim.id_movim", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        this.Joins.Add(new qGen.Join("personas", "cajas_movim.id_persona=personas.id_persona"));
                        this.Joins.Add(new qGen.Join("cajas", "cajas_movim.id_caja=cajas.id_caja"));
                        this.FormFields = new Lfx.Data.FormFieldCollection() {
                                new Lfx.Data.FormField("cajas.nombre", "Caja", Lfx.Data.InputFieldTypes.Text, 120),
                                new Lfx.Data.FormField("cajas_movim.id_concepto", "Concepto", Lfx.Data.InputFieldTypes.Relation, 0),
                                new Lfx.Data.FormField("cajas_movim.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 320),
                                new Lfx.Data.FormField("cajas_movim.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 100),
                                new Lfx.Data.FormField("cajas_movim.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
                                new Lfx.Data.FormField("cajas_movim.saldo", "Saldo", Lfx.Data.InputFieldTypes.Currency, 96),
                                new Lfx.Data.FormField("personas.nombre_visible", "Persona", Lfx.Data.InputFieldTypes.Text, 200),
                                new Lfx.Data.FormField("cajas_movim.id_comprob", "Factura", Lfx.Data.InputFieldTypes.Relation, 0),
                                new Lfx.Data.FormField("cajas_movim.id_recibo", "Recibo", Lfx.Data.InputFieldTypes.Relation, 0),
                                new Lfx.Data.FormField("cajas_movim.obs", "Obs.", Lfx.Data.InputFieldTypes.Text, 240),
                                new Lfx.Data.FormField("cajas_movim.comprob", "Comprobante", Lfx.Data.InputFieldTypes.Text, 160)
                        };

                        this.FormFields["nombre"].Visible = false;
                        this.FormFields["nombre"].Printable = false;
                        this.FormFields["comprob"].Printable = false;

                        this.FormFields["concepto"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.TotalName;
                        this.FormFields["importe"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum;

                        this.OrderBy = "cajas_movim.id_movim DESC";

                        if (this.HasWorkspace) {
                                this.Caja = new Lbl.Cajas.Caja(this.Connection, 999);
                        }
                        
                        this.HabilitarFiltrar = true;
                }

                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        decimal Importe = row.Fields["importe"].ValueDecimal;
                        if (Importe < 0) {
                                this.Contadores[2].AddValue(-Importe);           // Egresos
                                item.SubItems["importe"].ForeColor = Color.Red;
                                item.UseItemStyleForSubItems = false;
                        } else if (Importe > 0) {
                                this.Contadores[1].AddValue(Importe);           // Ingresos
                        }

                        base.OnItemAdded(item, row);
                }

                public Lbl.Cajas.Caja Caja
                {
                        get
                        {
                                return m_Caja;
                        }
                        set
                        {
                                m_Caja = value;
                                if (m_Caja != null)
                                        m_Caja.Connection = this.Connection;
                        }
                }

                protected override void OnBeginRefreshList()
                {
                        this.CustomFilters.Clear();

                        System.DateTime FechaFrom = Fechas.HasRange ? Fechas.From : new System.DateTime(1900, 1, 1);
                        if (this.Caja == null) {
                                this.Text = "Caja";
                                // Es para todas las cajas
                                Transporte = 0;

                                if (this.Cliente == null && m_ConceptoId == 0 && m_TipoConcepto == 0) {
                                        // Calculo el transporte combinado de todas las cajas
                                        DataTable Cajas = this.Connection.Select("SELECT id_caja FROM cajas");
                                        foreach (System.Data.DataRow Caja in Cajas.Rows) {
                                                Transporte += Math.Round(this.Connection.FieldDecimal("SELECT saldo FROM " + this.NombreTabla + " WHERE  id_caja=" + Caja["id_caja"].ToString() + " AND fecha<'" + Lfx.Types.Formatting.FormatDateSql(FechaFrom).ToString() + " 00:00:00' ORDER BY id_movim DESC"), this.Workspace.CurrentConfig.Moneda.Decimales);
                                        }
                                }
                        } else {
                                this.Text = Caja.ToString();
                                // Calculo el transporte de una cuenta
                                Transporte = Math.Round(this.Connection.FieldDecimal("SELECT saldo FROM " + this.NombreTabla + " WHERE  id_caja=" + this.Caja.Id.ToString() + " AND fecha<'" + Lfx.Types.Formatting.FormatDateSql(FechaFrom) + " 00:00:00' ORDER BY id_movim DESC LIMIT 1"), this.Workspace.CurrentConfig.Moneda.Decimales);
                        }

                        if (m_Direccion == 1)
                                this.CustomFilters.AddWithValue("cajas_movim.importe", qGen.ComparisonOperators.GreaterThan, 0);
                        else if (m_Direccion == 2)
                                this.CustomFilters.AddWithValue("cajas_movim.importe", qGen.ComparisonOperators.LessThan, 0);

                        if (this.Caja != null) {
                                this.CustomFilters.AddWithValue("cajas_movim.id_caja", this.Caja.Id);
                                this.GroupingColumnName = null;
                                this.FormFields["saldo"].Visible = true;
                        } else {
                                this.GroupingColumnName = "nombre";
                                this.FormFields["saldo"].Visible = false;
                        }

                        if (this.Cliente != null)
                                this.CustomFilters.AddWithValue("cajas_movim.id_cliente", this.Cliente.Id);

                        if (m_ConceptoId > 0)
                                this.CustomFilters.AddWithValue("cajas_movim.id_concepto", m_ConceptoId);
                        else if (m_ConceptoId == -1 && m_ConceptoStr != null && m_ConceptoStr.Length > 0)
                                this.CustomFilters.AddWithValue("cajas_movim.concepto", qGen.ComparisonOperators.InsensitiveLike, "%" + m_ConceptoStr + "%");

                        if (m_TipoConcepto > 0)
                                this.CustomFilters.AddWithValue("conceptos.grupo", m_TipoConcepto);

                        if (Fechas.HasRange)
                                this.CustomFilters.AddWithValue("cajas_movim.fecha", Fechas.From, Fechas.To);

                        base.OnBeginRefreshList();
                }


                protected override void OnEndRefreshList()
                {
                        this.Contadores[0].AddValue(Transporte);
                        this.Contadores[3].AddValue(Transporte + this.Contadores[1].Total - this.Contadores[2].Total);

                        base.OnEndRefreshList();
                }


                public override Lfx.Types.OperationResult OnFilter()
                {
                        using (Cajas.Filtros FormFiltros = new Cajas.Filtros()) {
                                FormFiltros.Connection = this.Connection;
                                FormFiltros.EntradaCaja.Elemento = this.Caja;
                                FormFiltros.Fechas.Rango = Fechas;

                                FormFiltros.EntradaPersona.Elemento = this.Cliente;
                                if (m_ConceptoId == -1)
                                        FormFiltros.EntradaConcepto.Text = FormFiltros.EntradaConcepto.FreeTextCode;
                                else
                                        FormFiltros.EntradaConcepto.TextInt = m_ConceptoId;

                                FormFiltros.EntradaTipoConcepto.TextKey = m_TipoConcepto.ToString();

                                FormFiltros.EntradaDireccion.TextKey = m_Direccion.ToString();
                                if (m_ConceptoId == -1)
                                        FormFiltros.EntradaConcepto.TextDetail = m_ConceptoStr.ToString();

                                FormFiltros.Owner = this;
                                if (FormFiltros.ShowDialog() == DialogResult.OK) {
                                        this.Caja = FormFiltros.EntradaCaja.Elemento as Lbl.Cajas.Caja;
                                        Fechas = FormFiltros.Fechas.Rango;
                                        if (this.Caja != null)
                                                this.Text = Caja.ToString();
                                        else
                                                this.Text = "Movimientos de Cajas";

                                        if (FormFiltros.EntradaPersona.Text == FormFiltros.EntradaPersona.FreeTextCode)
                                                this.Cliente = null;
                                        else
                                                this.Cliente = FormFiltros.EntradaPersona.Elemento as Lbl.Personas.Persona;
                                        if (FormFiltros.EntradaConcepto.Text == FormFiltros.EntradaConcepto.FreeTextCode)
                                                m_ConceptoId = -1;
                                        else
                                                m_ConceptoId = FormFiltros.EntradaConcepto.TextInt;
                                        m_Direccion = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaDireccion.TextKey);
                                        if (m_ConceptoId == -1)
                                                m_ConceptoStr = FormFiltros.EntradaConcepto.TextDetail;

                                        m_TipoConcepto = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaTipoConcepto.TextKey);

                                        this.RefreshList();
                                }
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }


                private void BotonIngreso_Click(object sender, System.EventArgs e)
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(this.Caja, Lbl.Sys.Permisos.Operaciones.Mover)) {
                                Cajas.IngresoEgreso FormularioIngreso = new Cajas.IngresoEgreso();
                                FormularioIngreso.Caja = this.Caja;
                                if (this.Caja != null)
                                        FormularioIngreso.SaldoActual = this.Caja.Saldo(false);
                                FormularioIngreso.Ingreso = true;
                                if (FormularioIngreso.ShowDialog() == DialogResult.OK)
                                        this.RefreshList();
                        }
                }


                private void BotonEgreso_Click(object sender, System.EventArgs e)
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(this.Caja, Lbl.Sys.Permisos.Operaciones.Mover)) {
                                Cajas.IngresoEgreso FormularioEgreso = new Cajas.IngresoEgreso();
                                FormularioEgreso.Caja = this.Caja;
                                if (this.Caja != null)
                                        FormularioEgreso.SaldoActual = this.Caja.Saldo(false);
                                FormularioEgreso.Ingreso = false;
                                if (FormularioEgreso.ShowDialog() == DialogResult.OK)
                                        this.RefreshList();
                        }
                }


                private void BotonMovimiento_Click(object sender, System.EventArgs e)
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(this.Caja, Lbl.Sys.Permisos.Operaciones.Mover)) {
                                Cajas.Movimiento FormularioMovimiento = new Cajas.Movimiento();
                                FormularioMovimiento.EntradaOrigen.Elemento = this.Caja;
                                FormularioMovimiento.EntradaConcepto.TextInt = 30000;
                                if (FormularioMovimiento.ShowDialog() == DialogResult.OK)
                                        this.RefreshList();
                        }
                }


                private void BotonArqueo_Click(object sender, System.EventArgs e)
                {
                        if(this.Caja == null || this.Cliente != null || m_ConceptoId != 0 || m_Direccion != 0) {
                                Lui.Forms.MessageBox.Show("Sólo puede realizar arqueos cuando está visualizando una sola caja y no está utilizando filtros.", "Arqueo");
                                return;
                        }

                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Si confirma que el saldo de la cuenta es el indicado se asentará una marca de 'Arqueo', para su propio control.", "¿Confirma que el saldo de la cuenta es de $ " + Lfx.Types.Formatting.FormatCurrency(this.Contadores[3].Total) + "?");
                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                this.Caja.Connection.BeginTransaction();
                                this.Caja.Arqueo();
                                this.Caja.Connection.Commit();
                                this.RefreshList();
                        } else {
                                Lui.Forms.MessageBox.Show("Verifique el saldo de la cuenta y si es necesario realice un ajuste.", "Arqueo");
                        }
                }

                protected override Lfx.Types.OperationResult OnEdit(int itemId)
                {
                        Lfx.Data.Row Movim = this.Connection.Tables["cajas_movim"].FastRows[itemId];
                        if (Movim != null) {
                                if (Movim.Fields["id_recibo"].Value != null) {
                                        int IdRecibo = Movim.Fields["id_recibo"].ValueInt;
                                        Type TipoRecibo = typeof(Lbl.Comprobantes.Recibo);
                                        Lfx.Data.Connection NuevaDb = this.Workspace.GetNewConnection("Editar " + TipoRecibo.ToString() + " " + IdRecibo);
                                        Lbl.IElementoDeDatos Elem = Lbl.Instanciador.Instanciar(TipoRecibo, NuevaDb, IdRecibo);
                                        Lfc.FormularioEdicion FormNuevo = Lfc.Instanciador.InstanciarFormularioEdicion(Elem);
                                        FormNuevo.DisposeConnection = true;
                                        FormNuevo.MdiParent = this.MdiParent;
                                        FormNuevo.Show();

                                        return new Lfx.Types.SuccessOperationResult();
                                } else if (Movim.Fields["id_comprob"].Value != null) {
                                        int IdComprob = Movim.Fields["id_comprob"].ValueInt;
                                        Type TipoRecibo = typeof(Lbl.Comprobantes.ComprobanteConArticulos);
                                        Lfx.Data.Connection NuevaDb = this.Workspace.GetNewConnection("Editar " + TipoRecibo.ToString() + " " + IdComprob);
                                        Lbl.IElementoDeDatos Elem = Lbl.Instanciador.Instanciar(TipoRecibo, NuevaDb, IdComprob);
                                        Lfc.FormularioEdicion FormNuevo = Lfc.Instanciador.InstanciarFormularioEdicion(Elem);
                                        FormNuevo.DisposeConnection = true;
                                        FormNuevo.MdiParent = this.MdiParent;
                                        FormNuevo.Show();

                                        return new Lfx.Types.SuccessOperationResult();
                                } else {
                                        return new Lfx.Types.CancelOperationResult();
                                }
                        } else {
                                return new Lfx.Types.CancelOperationResult();
                        }
                }


                protected override void OnKeyDown(KeyEventArgs e)
                {
                        if (e.Shift && e.Control) {
                                switch (e.KeyCode) {
                                        case Keys.F7:
                                                if (this.Caja != null) {
                                                        // Recalculo la cuenta del cliente
                                                        Lui.Forms.MessageBox.Show("Se va a recalcular el transporte de la Caja", "Aviso");
                                                        this.Caja.Connection.BeginTransaction();
                                                        this.Caja.Recalcular();
                                                        this.Caja.Connection.Commit();
                                                        this.RefreshList();
                                                }
                                                e.Handled = true;

                                                break;
                                }
                        }

                        if (e.Handled == false)
                                base.OnKeyDown(e);
                }
        }
}