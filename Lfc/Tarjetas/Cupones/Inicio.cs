#region License
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
#endregion

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Tarjetas.Cupones
{
	public partial class Inicio : Lui.Forms.ChildForm
	{
                protected internal string m_Tabla = "tarjetas_cupones";
		protected internal int m_Cliente, m_Tarjeta, m_Plan, m_Estado = -2;
                protected internal Lfx.Types.DateRange m_Fecha = new Lfx.Types.DateRange("*");
                protected internal qGen.Select m_SelectCommand;
                
                public Inicio() : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        LowerPanel.BackColor = Lfx.Config.Display.CurrentTemplate.FooterBackground;
                }

		public Lfx.Types.OperationResult RefreshList()
		{
			if (m_Tabla.Length > 0)
			{
                                m_SelectCommand = new qGen.Select(m_Tabla);
                                m_SelectCommand.Fields = "id_cupon,fecha,concepto,id_tarjeta,numero,importe,estado,id_plan";
                                m_SelectCommand.WhereClause = new qGen.Where();
                                m_SelectCommand.WhereClause.Operator = qGen.AndOr.And;

				if (m_Cliente > 0)
                                        m_SelectCommand.WhereClause.Add(new qGen.ComparisonCondition("id_cliente", m_Cliente));

				if (m_Tarjeta > 0)
                                        m_SelectCommand.WhereClause.Add(new qGen.ComparisonCondition("id_tarjeta", m_Tarjeta));

                                if (m_Estado >= 0)
                                        m_SelectCommand.WhereClause.Add(new qGen.ComparisonCondition("estado", m_Estado));
                                else if (m_Estado == -2)
                                        m_SelectCommand.WhereClause.Add(new qGen.ComparisonCondition("estado", qGen.ComparisonOperators.In, new int[] { 0, 10 }));

                                if (m_Fecha.HasRange)
                                        m_SelectCommand.WhereClause.Add(new qGen.ComparisonCondition("fecha", m_Fecha.From, m_Fecha.To));
                         
                                m_SelectCommand.Order = "fecha DESC";

				System.Data.DataTable dt = this.DataBase.Select(this.SelectCommand());
				double Total = 0, SinPresentar = 0, Presentados = 0, Acreditados = 0, Cancelados = 0, Rechazados = 0;
                                int CantidadSinPresentar = 0, CantidadPresentados = 0, CantidadAcreditados = 0;

				ListViewItem CurItem = null;
				if (ItemList.SelectedItems.Count > 0)
					CurItem = ((ListViewItem)(ItemList.SelectedItems[0].Clone()));
				else
					CurItem = null;

				ItemList.BeginUpdate();
				ItemList.Items.Clear();

				if (dt.Rows.Count > 0)
				{
					foreach (System.Data.DataRow row in dt.Rows)
					{
						ListViewItem itm = null;
						itm = ItemList.Items.Add(System.Convert.ToString(row["id_cupon"]));
						itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatDate(row["fecha"])));
						itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(row["concepto"])));
						itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, this.DataBase.FieldString("SELECT nombre FROM tarjetas WHERE id_tarjeta=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_tarjeta"]).ToString())));
						itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(row["numero"])));
						Total += System.Convert.ToDouble(row["importe"]);
						itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(row["importe"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
						switch (((Lbl.Tarjetas.Estado)System.Convert.ToInt32(row["estado"])))
						{
							case Lbl.Tarjetas.Estado.SinPresentar:
								SinPresentar += System.Convert.ToDouble(row["importe"]);
                                                                CantidadSinPresentar++;
								itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Sin Presentar"));
								break;
							case Lbl.Tarjetas.Estado.Anulado:
								Cancelados += System.Convert.ToDouble(row["importe"]);
								itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Anulado"));
                                                                itm.ForeColor = Color.Gray;
                                                                itm.Font = new Font(itm.Font, FontStyle.Strikeout);
								break;
							case Lbl.Tarjetas.Estado.Rechazaro:
								Rechazados += System.Convert.ToDouble(row["importe"]);
								itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Rechazado"));
                                                                itm.ForeColor = Color.Gray;
                                                                itm.Font = new Font(itm.Font, FontStyle.Strikeout);
								break;
							case Lbl.Tarjetas.Estado.Presentado:
								Presentados += System.Convert.ToDouble(row["importe"]);
                                                                CantidadPresentados++;
								itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Presentado"));
                                                                itm.ForeColor = Color.DarkGreen;
								break;
							case Lbl.Tarjetas.Estado.Acreditado:
                                                                CantidadAcreditados++;
								Acreditados += System.Convert.ToDouble(row["importe"]);
								itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "Acreditado"));
                                                                itm.ForeColor = Color.Gray;
								break;
						}

                                                int IdPlan = Lfx.Data.DataBase.ConvertDBNullToZero(row["id_plan"]);
                                                if (IdPlan != 0)
                                                        itm.SubItems.Add(this.DataBase.Tables["tarjetas_planes"].FastRows[IdPlan].Fields["nombre"].ToString());
                                                else
                                                        itm.SubItems.Add("");

                                                if (CurItem != null) {
                                                        if (itm.Text == CurItem.Text)
                                                                itm.Selected = true; itm.Focused = true;
                                                }
					}
				}

                                EtiquetaImporteSinPresentar.Text = Lfx.Types.Formatting.FormatCurrency(SinPresentar, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                EtiquetaCantidadSinPresentar.Text = CantidadSinPresentar.ToString();
                                EtiquetaImportePresentados.Text = Lfx.Types.Formatting.FormatCurrency(Presentados, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                EtiquetaCantidadPresentados.Text = CantidadPresentados.ToString();
                                EtiquetaImporteAcreditados.Text = Lfx.Types.Formatting.FormatCurrency(Acreditados, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                EtiquetaCantidadAcreditados.Text = CantidadAcreditados.ToString();

				ItemList.EndUpdate();
				ItemList.Focus();

                                if (ItemList.Items.Count > 0) {
                                        ItemList.Items[0].Focused = true;
                                        ItemList.Items[0].Selected = true;
                                }

				cmdPresentar.Visible = true;
                                cmdAcreditar.Visible = true;
			}

			return new Lfx.Types.SuccessOperationResult();
		}



		internal virtual Lfx.Types.OperationResult Imprimir()
		{
			return new Lfx.Types.SuccessOperationResult();
		}


		internal virtual void Cancelar()
		{
			this.Dispose();
		}


                internal virtual Lfx.Types.OperationResult Filtrar()
                {
                        Lfx.Types.OperationResult filtrarReturn = new Lfx.Types.SuccessOperationResult();
                        Lfc.Tarjetas.Cupones.Filtros FormFiltros = new Lfc.Tarjetas.Cupones.Filtros();
                        FormFiltros.txtTarjeta.Text = m_Tarjeta.ToString();
                        FormFiltros.txtPlan.Text = m_Plan.ToString();
                        FormFiltros.txtEstado.TextKey = m_Estado.ToString();
                        FormFiltros.txtCliente.Text = m_Cliente.ToString();
                        FormFiltros.EntradaFechas.Rango = m_Fecha;
                        if (FormFiltros.ShowDialog() == DialogResult.OK) {
                                m_Tarjeta = FormFiltros.txtTarjeta.TextInt;
                                m_Plan = FormFiltros.txtPlan.TextInt;
                                m_Estado = Lfx.Types.Parsing.ParseInt(FormFiltros.txtEstado.TextKey);
                                m_Cliente = FormFiltros.txtCliente.TextInt;
                                m_Fecha = FormFiltros.EntradaFechas.Rango;
                                this.RefreshList();
                                filtrarReturn.Success = true;
                        } else {
                                filtrarReturn.Success = false;
                        }
                        return filtrarReturn;
                }


		private void cmdImprimir_Click(object sender, System.EventArgs e)
		{
			Imprimir();
		}

		private void cmdFiltros_Click(object sender, System.EventArgs e)
		{
			Filtrar();
		}

		private void cmdMostrar_Click(object sender, System.EventArgs e)
		{
			RefreshList();
		}

		private void cmdCancelar_Click(object sender, System.EventArgs e)
		{
			Cancelar();
		}


		private void Inicio_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Alt == false && e.Control == false)
			{
				switch (e.KeyCode)
				{
					case Keys.Escape:
						e.Handled = true;
						if (CancelCommandButton.Enabled && CancelCommandButton.Visible)
							CancelCommandButton.PerformClick();
						break;
					case Keys.F2:
						e.Handled = true;
						if (FilterButton.Enabled && FilterButton.Visible)
							FilterButton.PerformClick();
						break;
					case Keys.F4:
						e.Handled = true;
						if (cmdAcreditar.Enabled && cmdAcreditar.Visible)
							cmdAcreditar.PerformClick();
						break;
					case Keys.F6:
						e.Handled = true;
						if (cmdAnular.Enabled && cmdAnular.Visible)
							cmdAnular.PerformClick();
						break;
					case Keys.F9:
						e.Handled = true;
						if (cmdMostrar.Enabled && cmdMostrar.Visible)
							cmdMostrar.PerformClick();
						break;
					case Keys.F8:
						e.Handled = true;
						if (PrintButton.Enabled && PrintButton.Visible)
							PrintButton.PerformClick();
						break;
				}

			}
			else if (e.Control == true && e.Alt == false)
			{
				// Teclas con Ctrl
                                switch (e.KeyCode) {
                                        case Keys.R:
                                                if (e.Control == true && e.Shift == false && e.Alt == false) {
                                                        e.Handled = true;
                                                        Lui.Forms.ListingFormExport OFormExportar = new Lui.Forms.ListingFormExport();
                                                        OFormExportar.Nombre = this.Text.Replace(":", "");
                                                        OFormExportar.SelectCommand = this.SelectCommand();
                                                        OFormExportar.FormFields = new Lfx.Data.FormField[] {
			                                        new Lfx.Data.FormField("id_cupon", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
			                                        new Lfx.Data.FormField("fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 120),
                                                                new Lfx.Data.FormField("concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 320),
                                                                new Lfx.Data.FormField("id_tarjeta", "Tarjeta", Lfx.Data.InputFieldTypes.Relation, 320),
                                                                new Lfx.Data.FormField("numero", "Cupón", Lfx.Data.InputFieldTypes.Text, 160),
                                                                new Lfx.Data.FormField("importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 160),
                                                                new Lfx.Data.FormField("estado", "Estado", Lfx.Data.InputFieldTypes.Text, 320),
                                                                new Lfx.Data.FormField("id_plan", "Plan", Lfx.Data.InputFieldTypes.Relation, 120)
		                                        };
                                                        OFormExportar.ShowDialog();
                                                }
                                                break;
                                }

			}
		}

                public qGen.Select SelectCommand()
                {
                        return m_SelectCommand;
                }


		private void lvItems_DoubleClick(object sender, System.EventArgs e)
		{
			Editar(CodigoSeleccionado());
		}


		private void lvItems_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(e.KeyChar))[0] == System.Convert.ToByte(Keys.Return))
			{
				e.Handled = true;
				Editar(CodigoSeleccionado());
			}
		}


		internal int CodigoSeleccionado()
		{
			if (ItemList.SelectedItems.Count > 0)
			{
				return Lfx.Types.Parsing.ParseInt(ItemList.SelectedItems[0].Text);
			}
			return 0;
		}


		internal virtual Lfx.Types.OperationResult Editar(int lCodigo)
		{
			return new Lfx.Types.SuccessOperationResult();
		}


		private void BotonAcreditar_Click(object sender, System.EventArgs e)
		{
			Lfc.Tarjetas.Cupones.Acreditar FormularioAcreditacion = new Lfc.Tarjetas.Cupones.Acreditar();

			Lui.Forms.ProgressForm Progreso = new Lui.Forms.ProgressForm();

			double Total = 0;
			double dTotalAcreditar = 0;
			int iCantidad = 0;

			System.Text.StringBuilder Cupones = new System.Text.StringBuilder();
			double ComisionTarjeta = 0;
			double ComisionPlan = 0;
			double dGestionDeCobro = 0;

			Progreso.Titulo = "Analizando...";
			Progreso.Max = ItemList.Items.Count + 2;
			Progreso.Show();

                        Lbl.Tarjetas.Tarjeta Tarjeta = null;
			foreach (System.Windows.Forms.ListViewItem itm in ItemList.Items)
			{
				if (itm.Checked)
				{
					iCantidad++;
					Lbl.Tarjetas.Cupon Cupon = new Lbl.Tarjetas.Cupon(DataBase, Lfx.Types.Parsing.ParseInt(itm.Text));
                                        Total += Cupon.Importe;
					if (Cupones.Length > 0)
						Cupones.Append("," + Cupon.Numero);
					else
						Cupones.Append(Cupon.Numero);

                                        if (Cupon.Tarjeta != null) {
                                                if(Tarjeta == null) {
                                                        Tarjeta = Cupon.Tarjeta;
                                                } else if (Tarjeta.Id != Cupon.Tarjeta.Id) {
                                                        //Mezcla de tarjetas
                                                        Progreso.Close();
                                                        Progreso = null;
                                                        Lui.Forms.MessageBox.Show("No todos los cupones seleccionados pertenecen a la misma tarjeta", "Error");
                                                        return;
                                                }

                                                ComisionTarjeta += Cupon.Importe * (Tarjeta.Comision / 100);
                                                if (Cupon.Plan != null) {
                                                        ComisionPlan += Cupon.Importe * (Cupon.Plan.Comision / 100);
                                                }
                                        }
				}
				Progreso.Progreso = itm.Index;
			}

			FormularioAcreditacion.IgnorarCambios = true;
			FormularioAcreditacion.txtCupones.Text = iCantidad.ToString();
			FormularioAcreditacion.txtSubTotal.Text = Lfx.Types.Formatting.FormatCurrency(Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
			FormularioAcreditacion.txtComisionTarjeta.Text = Lfx.Types.Formatting.FormatCurrency(ComisionTarjeta, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
			FormularioAcreditacion.txtComisionPlan.Text = Lfx.Types.Formatting.FormatCurrency(ComisionPlan, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
			FormularioAcreditacion.txtComisionUsuario.Text = "0";
			FormularioAcreditacion.txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(Total - ComisionTarjeta - ComisionPlan, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
			FormularioAcreditacion.IgnorarCambios = false;

			Progreso.Progreso = Progreso.Max;
			Progreso.Visible = false;

			bool bAceptar = false;
                        Lfc.Comprobantes.Recibos.EditarCobro FormularioPago = new Lfc.Comprobantes.Recibos.EditarCobro();
			do
			{
				if (FormularioAcreditacion.ShowDialog() == DialogResult.OK)
				{
					dTotalAcreditar = Lfx.Types.Parsing.ParseCurrency(FormularioAcreditacion.txtTotal.Text);
					dGestionDeCobro = Total - dTotalAcreditar;
                                        FormularioPago.Cobro.FromCobro(new Lbl.Comprobantes.Cobro(this.DataBase, ((Lbl.Comprobantes.TipoFormasDePago)(Lfx.Types.Parsing.ParseInt(FormularioAcreditacion.txtFormaPago.TextKey)))));
                                        FormularioPago.Cobro.FormaDePagoEditable = false;
					FormularioPago.Cobro.Importe = dTotalAcreditar;
					FormularioPago.Cobro.ImporteEditable = false;
                                        if (Tarjeta != null && Tarjeta.Caja != null)
                                                FormularioPago.Cobro.EntradaCaja.TextInt = Tarjeta.Caja.Id;
					FormularioPago.Cobro.Obs = "Cupones Nº " + Cupones.ToString();
                                        FormularioPago.Cobro.ObsEditable = false;
					if (FormularioPago.ShowDialog() == DialogResult.OK)
					{
						bAceptar = true;
						break;
					}
				}
				else
				{
					bAceptar = false;
					break;
				}
			}
			while (true);
			if (bAceptar)
			{
				DataBase.BeginTransaction(true);

				Progreso.Titulo = "Asentando el Movimiento...";
				Progreso.Progreso = 0;
				Progreso.Max = ItemList.Items.Count + 2;
				Progreso.Show();

				// Marcar los cupones como acreditados
				foreach (System.Windows.Forms.ListViewItem itm in ItemList.Items)
				{
					if (itm.Checked)
						DataBase.Execute("UPDATE tarjetas_cupones SET estado=20, fecha_acred=NOW() WHERE id_cupon=" + itm.Text);
					Progreso.Progreso = itm.Index;
				}

				// Acreditar el dinero
                                Lbl.Comprobantes.Cobro MiCobro = FormularioPago.Cobro.ToCobro(DataBase);
				switch (FormularioPago.Cobro.FormaDePago.Tipo)
				{
                                        case Lbl.Comprobantes.TipoFormasDePago.Efectivo:
						Lbl.Cajas.Caja CajaDiaria = new Lbl.Cajas.Caja(DataBase, this.Workspace.CurrentConfig.Company.CajaDiaria);
						CajaDiaria.Movimiento(true, 11000, "Acreditación Tarjetas", 0, Total, "Cupones Nº " + Cupones.ToString(), 0, 0, "");
						CajaDiaria.Movimiento(true, 24010, "Gestión de Cobro Tarjetas", 0, -dGestionDeCobro, "Cupones Nº " + Cupones.ToString(), 0, 0, "");
						break;
                                        case Lbl.Comprobantes.TipoFormasDePago.ChequePropio:
                                                Lbl.Bancos.Cheque Cheque = MiCobro.Cheque;
                                                Cheque.Concepto = new Lbl.Cajas.Concepto(DataBase, 11000);
                                                Cheque.ConceptoTexto = "Acreditación Tarjetas";
                                                Cheque.Guardar();
						break;
                                        case Lbl.Comprobantes.TipoFormasDePago.Caja:
                                                MiCobro.CajaDestino.Movimiento(true, 11000, "Acreditación Tarjetas", 0, Total, "Cupones Nº " + Cupones.ToString(), 0, 0, "");
                                                MiCobro.CajaDestino.Movimiento(true, 24010, "Gestión de Cobro Tarjetas", 0, -dGestionDeCobro, "Cupones Nº " + Cupones.ToString(), 0, 0, "");
						break;
				}


				DataBase.Commit();
				Progreso.Cerrar();
			}
			FormularioAcreditacion = null;
			this.RefreshList();
		}

		private void cmdAnular_Click(object sender, System.EventArgs e)
		{

			int CantidadCupones = 0;
			foreach (System.Windows.Forms.ListViewItem itm in ItemList.Items)
			{
				if (itm.Checked)
				{
					CantidadCupones++;
					if (itm.SubItems[6].Text != "Sin Presentar" && itm.SubItems[6].Text != "Presentado")
					{
						Lui.Forms.MessageBox.Show("Sólo se pueden anular cupones que no han sido acreditados o rechazados.", "Anular de cupones");
						return;
					}
				}
			}

			if (CantidadCupones == 0)
			{
				Lui.Forms.MessageBox.Show("Debe seleccionar uno o más cupones para anular.", "Anular de cupones");
				return;
			}


			Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("¿Desea eliminar de manera permanente los cupones seleccionados?", "Anular cupones");
			Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
			if (Pregunta.ShowDialog() == DialogResult.OK)
			{
				Lui.Forms.ProgressForm Progreso = new Lui.Forms.ProgressForm();
				Progreso.Max = CantidadCupones;
				Progreso.Progreso = 0;
				Progreso.Style = ProgressBarStyle.Continuous;
				Progreso.Operacion = "Anulando cupones...";
				Progreso.Show();
				foreach (System.Windows.Forms.ListViewItem itm in ItemList.Items)
				{
					if (itm.Checked)
					{
						Progreso.Progreso++;
						Lfx.Data.Row Cupon = this.DataBase.Row("tarjetas_cupones", "id_cupon", Lfx.Types.Parsing.ParseInt(itm.Text));
						if (System.Convert.ToInt32(Cupon["estado"]) == 0 || System.Convert.ToInt32(Cupon["estado"]) == 10)
						{
							this.DataBase.Execute("UPDATE tarjetas_cupones SET estado=1 WHERE id_cupon=" + itm.Text);
							System.Threading.Thread.Sleep(50);
						}
					}
				}
				Progreso.Dispose();
				this.RefreshList();
			}
		}

                private void BotonPresentar_Click(object sender, EventArgs e)
                {
                        int CantidadCupones = 0;
                        foreach (System.Windows.Forms.ListViewItem itm in ItemList.Items) {
                                if (itm.Checked) {
                                        CantidadCupones++;
                                        if (itm.SubItems[6].Text != "Sin Presentar") {
                                                Lui.Forms.MessageBox.Show("Sólo se pueden hacer presentaciones de cupones que no han sido presentados.", "Presentación de cupones");
                                                return;
                                        }
                                }
                        }

                        if (CantidadCupones == 0) {
                                Lui.Forms.MessageBox.Show("Debe seleccionar uno o más cupones para presentar.", "Presentación de cupones");
                                return;
                        }


                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("¿Desea marcar los cupones seleccionados como presentados?", "Presentación de cupones");
                        Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                Lui.Forms.ProgressForm Progreso = new Lui.Forms.ProgressForm();
                                Progreso.Max = CantidadCupones;
                                Progreso.Progreso = 0;
                                Progreso.Style = ProgressBarStyle.Continuous;
                                Progreso.Operacion = "Presentación de cupones...";
                                Progreso.Show();
                                foreach (System.Windows.Forms.ListViewItem itm in ItemList.Items) {
                                        if (itm.Checked) {
                                                Progreso.Progreso++;
                                                Lfx.Data.Row Cupon = this.DataBase.Row("tarjetas_cupones", "id_cupon", Lfx.Types.Parsing.ParseInt(itm.Text));
                                                if (System.Convert.ToInt32(Cupon["estado"]) == 0) {
                                                        this.DataBase.Execute("UPDATE tarjetas_cupones SET estado=10, fecha_pres=NOW() WHERE id_cupon=" + itm.Text);
                                                        System.Threading.Thread.Sleep(50);
                                                }
                                        }
                                }
                                Progreso.Dispose();
                                this.RefreshList();
                        }
                }
	}
}