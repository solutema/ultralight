// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Comprobantes.Compra
{
	public partial class Editar : Lui.Forms.EditForm
	{
		protected internal string m_TipoComprob = "R";
		protected internal string m_Numero = "";
		protected internal int m_FacturaIdOrig;
                public string CrearTipo = "PD";
                System.Collections.Hashtable ArticulosCantidadesOriginales = new System.Collections.Hashtable();

		public Editar()
			: base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
			EtiquetaTitulo.Font = Lws.Config.Display.CurrentTemplate.DefaultHeaderFont;
			EtiquetaTitulo.BackColor = Lws.Config.Display.CurrentTemplate.HeaderBackground;
			EtiquetaTitulo.ForeColor = Lws.Config.Display.CurrentTemplate.HeaderText;
		}

		public override Lfx.Types.OperationResult Create()
		{
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.create") == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        EntradaHaciaSituacion.Visible = this.Workspace.CurrentConfig.Products.StockMultideposito;
                        lblHaciaSituacion.Visible = this.Workspace.CurrentConfig.Products.StockMultideposito;

                        Lbl.Comprobantes.ComprobanteConArticulos NewRow = new Lbl.Comprobantes.ComprobanteConArticulos(this.DataView);
                        NewRow.Crear(CrearTipo, true);
                        NewRow.FormaDePago = Lbl.Comprobantes.FormasDePago.CuentaCorriente;

                        this.FromRow(NewRow);

			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult ValidateData()
		{
			Lfx.Types.OperationResult Res = base.ValidateData();

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


		public override Lfx.Types.OperationResult Edit(int iId)
		{
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.write") == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Comprobantes.ComprobanteConArticulos NewRow = new Lbl.Comprobantes.ComprobanteConArticulos(this.DataView, iId);
                        this.FromRow(NewRow);

                        return new Lfx.Types.SuccessOperationResult();
		}

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Comprobantes.ComprobanteConArticulos Fac = row as Lbl.Comprobantes.ComprobanteConArticulos;
			this.SuspendLayout();
			this.TipoComprob = Fac.Tipo.Nomenclatura;
                        if (Fac.Cliente != null)
                                EntradaProveedor.TextInt = Fac.Cliente.Id;
                        else
                                EntradaProveedor.TextInt = 0;
                        EntradaFormaPago.TextKey = ((int)(Fac.FormaDePago)).ToString();
			EntradaPV.Text = Fac.PV.ToString("0000");
                        EntradaNumero.Text = Fac.Numero.ToString("00000000");

                        if (Fac.SituacionDestino != null)
                                EntradaHaciaSituacion.TextInt = Fac.SituacionDestino.Id;
                        else
                                EntradaHaciaSituacion.TextInt = 0;
			EntradaHaciaSituacion.ReadOnly = Fac.Existe;
			EntradaEstado.TextKey = Fac.Estado.ToString();
			EntradaTotal.Text = Lfx.Types.Formatting.FormatCurrency(Fac.Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
			EntradaCancelado.Text = Lfx.Types.Formatting.FormatCurrency(Fac.ImporteCancelado, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
			EntradaGastosEnvio.Text = Lfx.Types.Formatting.FormatCurrency(Fac.GastosDeEnvio, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EntradaOtrosGastos.Text = Lfx.Types.Formatting.FormatCurrency(Fac.OtrosGastos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EntradaFecha.Text = Lfx.Types.Formatting.FormatDate(Fac.Fecha);
                        EntradaObs.Text = Fac.Obs;

			// Cargo el detalle del comprobante
			EntradaProductos.Count = Fac.Articulos.Count;
                        int i = 0;
			foreach (Lbl.Comprobantes.DetalleArticulo Art in Fac.Articulos)
			{
				if(Art.IdArticulo == 0) {
					EntradaProductos.ChildControls[i].Text = EntradaProductos.FreeTextCode;
				} else {
                                        EntradaProductos.ChildControls[i].TextInt = Art.IdArticulo;
                                        if (ArticulosCantidadesOriginales.ContainsKey(Art.IdArticulo) == false)
                                                ArticulosCantidadesOriginales.Add(Art.IdArticulo, Art.Cantidad);
				}

				EntradaProductos.ChildControls[i].Serials = Art.Series;
				EntradaProductos.ChildControls[i].TextDetail = Art.Nombre;
				EntradaProductos.ChildControls[i].Cantidad = Art.Cantidad;
				EntradaProductos.ChildControls[i].Tag = "0";
				EntradaProductos.ChildControls[i].Unitario = Art.Unitario;
                                i++;
			}
                        EntradaProductos.AutoAgregar = true;
			EntradaProductos.Changed = false;
                        this.Titulo = Fac.ToString();

			this.ResumeLayout();
		}

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Res = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                        Res.Compra = true;
                        Res.Fecha = Lfx.Types.Parsing.ParseDate(EntradaFecha.Text);
                        Res.FormaDePago = ((Lbl.Comprobantes.FormasDePago)Lfx.Types.Parsing.ParseInt(EntradaFormaPago.TextKey));
                        if(m_FacturaIdOrig == 0)
                                Res.ComprobanteOriginal = null;
                        else
                                Res.ComprobanteOriginal = new Lbl.Comprobantes.ComprobanteConArticulos(Res.DataView, m_FacturaIdOrig);
                        Res.Vendedor = new Lbl.Personas.Persona(Res.DataView, this.Workspace.CurrentUser.UserId);
                        if (EntradaProveedor.TextInt == 0)
                                Res.Cliente = null;
                        else
                                Res.Cliente = new Lbl.Personas.Persona(Res.DataView, EntradaProveedor.TextInt);
                        Res.Tipo = new Lbl.Comprobantes.Tipo(Res.DataView, EntradaTipo.TextKey);
                        Res.PV = Lfx.Types.Parsing.ParseInt(EntradaPV.Text);
			Res.Numero = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text);
                        if (EntradaHaciaSituacion.TextInt == 0)
                                Res.SituacionDestino = null;
                        else
                                Res.SituacionDestino = new Lbl.Articulos.Situacion(Res.DataView, EntradaHaciaSituacion.TextInt);
			Res.GastosDeEnvio = Lfx.Types.Parsing.ParseCurrency(EntradaGastosEnvio.Text);
                        Res.OtrosGastos = Lfx.Types.Parsing.ParseCurrency(EntradaOtrosGastos.Text);
                        Res.Obs = EntradaObs.Text;

                        if (EntradaEstado.Enabled)
                                Res.Estado = Lfx.Types.Parsing.ParseInt(EntradaEstado.TextKey);
                        else
                                Res.Estado = 0;

                        Res.Articulos.Clear();
                        for (int i = 0; i <= EntradaProductos.Count - 1; i++) {
                                if (EntradaProductos.ChildControls[i].Text == EntradaProductos.FreeTextCode || EntradaProductos.ChildControls[i].TextInt > 0) {
                                        Lbl.Comprobantes.DetalleArticulo Art = new Lbl.Comprobantes.DetalleArticulo(Res.DataView);
                                        Art.Orden = i + 1;

                                        Art.IdArticulo = EntradaProductos.ChildControls[i].TextInt;
                                        Art.Nombre = EntradaProductos.ChildControls[i].TextDetail;
                                        Art.Cantidad = EntradaProductos.ChildControls[i].Cantidad;
                                        Art.Unitario = EntradaProductos.ChildControls[i].Unitario;
                                        Art.Series = EntradaProductos.ChildControls[i].Serials;
                                        Res.Articulos.Add(Art);
                                }
                        }

                        return Res;
		}


		public virtual string TipoComprob
		{
			get
			{
				return m_TipoComprob;
			}
			set
			{
				m_TipoComprob = value;
				switch (m_TipoComprob)
				{
					case "FP":
						EntradaTipo.TextKey = "A";
						break;
                                        case "RP":
                                                EntradaTipo.TextKey = "R";
                                                break;
					default:
						EntradaTipo.TextKey = m_TipoComprob;
						break;
				}

				switch (m_TipoComprob)
				{
					case "NP":
						EntradaEstado.SetData = new string[] {
							"A pedir|50",
							"Pedido|100",
							"Cancelado|200"
						};
						EntradaEstado.Enabled = true;
						break;
					case "PD":
						EntradaEstado.SetData = new string[] {
							"Sin especificar|0",
							"En camino|50",
							"Recibido|100",
							"Cancelado|200"
						};
						EntradaEstado.Enabled = true;
						break;
					default:
						EntradaEstado.SetData = new string[] { "N/A|0" };
						EntradaEstado.Enabled = false;
						break;
				}

				this.Titulo = Lbl.Comprobantes.Comprobante.NombreTipo(m_TipoComprob) + " " + EntradaNumero.Text;
				EntradaNumero.Enabled = (m_TipoComprob != "NP");
                                lblHaciaSituacion.Visible = m_TipoComprob == "FP" || m_TipoComprob == "A" || m_TipoComprob == "B" || m_TipoComprob == "C" || m_TipoComprob == "E" || m_TipoComprob == "M";
                                EntradaHaciaSituacion.Visible = m_TipoComprob == "FP" || m_TipoComprob == "A" || m_TipoComprob == "B" || m_TipoComprob == "C" || m_TipoComprob == "E" || m_TipoComprob == "M";
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

		private void cmdConvertir_Click(object sender, System.EventArgs e)
		{
			Lfc.Comprobantes.Compra.Crear FormularioConvertir = new Lfc.Comprobantes.Compra.Crear();
			if (FormularioConvertir.ShowDialog() == DialogResult.OK)
			{
                                Lbl.Comprobantes.ComprobanteConArticulos Fac = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                                if ((Fac.Tipo.Nomenclatura == "NP" || Fac.Tipo.Nomenclatura == "PD") && EntradaEstado.TextKey != "100") {
                                        EntradaEstado.TextKey = "100";
                                        EntradaEstado.Changed = true;
                                } else if ((Fac.Tipo.Nomenclatura == "PD" || FormularioConvertir.TipoComprob == "FP"
                                        || FormularioConvertir.TipoComprob == "A"
                                        || FormularioConvertir.TipoComprob == "B"
                                        || FormularioConvertir.TipoComprob == "C"
                                        || FormularioConvertir.TipoComprob == "E"
                                        || FormularioConvertir.TipoComprob == "M"
                                        || FormularioConvertir.TipoComprob == "R") && EntradaEstado.TextKey != "100") {
                                        EntradaEstado.TextKey = "100";
                                        EntradaEstado.Changed = true;
                                }

				Lfc.Comprobantes.Compra.Editar FormularioEdicion = new Lfc.Comprobantes.Compra.Editar();
				FormularioEdicion.Workspace = this.Workspace;
                                FormularioEdicion.MdiParent = this.MdiParent;
				FormularioEdicion.Create();
				FormularioEdicion.TipoComprob = FormularioConvertir.TipoComprob;
				FormularioEdicion.m_FacturaIdOrig = m_Id;
                                FormularioEdicion.EntradaGastosEnvio.Text = this.EntradaGastosEnvio.Text;
				FormularioEdicion.EntradaProveedor.Text = EntradaProveedor.Text;
				FormularioEdicion.EntradaObs.Text = "Según " + this.TipoComprob + " Nº " + EntradaNumero.Text;

				for (int i = 0; i <= EntradaProductos.Count - 1; i++)
				{
					FormularioEdicion.EntradaProductos.ChildControls[i].Text = EntradaProductos.ChildControls[i].Text;
					FormularioEdicion.EntradaProductos.ChildControls[i].Serials = EntradaProductos.ChildControls[i].Serials;
					FormularioEdicion.EntradaProductos.ChildControls[i].TextDetail = EntradaProductos.ChildControls[i].TextDetail;
					FormularioEdicion.EntradaProductos.ChildControls[i].Cantidad = EntradaProductos.ChildControls[i].Cantidad;
					FormularioEdicion.EntradaProductos.ChildControls[i].Unitario = EntradaProductos.ChildControls[i].Unitario;
				}
				FormularioEdicion.Show();
			}
			FormularioConvertir = null;
		}


		private void FormPedidosEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None)
			{
				switch (e.KeyCode)
				{
					case Keys.F4:
						if (cmdConvertir.Enabled && cmdConvertir.Visible) {
							e.Handled = true;
							cmdConvertir.PerformClick();
						}
						break;
					case Keys.F7:
						if (cmdObs.Enabled && cmdObs.Visible) {
							e.Handled = true;
							cmdObs.PerformClick();
						}
						break;
				}
			}
		}


		private void cmdObs_Click(object sender, System.EventArgs e)
		{
                        Lui.Forms.AuxForms.TextEdit FormularioObs = new Lui.Forms.AuxForms.TextEdit();
			FormularioObs.EditText = EntradaObs.Text;
			FormularioObs.ReadOnly = !SaveButton.Visible;
			if (FormularioObs.ShowDialog() == DialogResult.OK)
				EntradaObs.Text = FormularioObs.EditText;
		}


		private void RecalcularTotal(System.Object sender, System.EventArgs e)
		{
                        double GastosEnvio = Lfx.Types.Parsing.ParseCurrency(EntradaGastosEnvio.Text);
                        double OtrosGastos = Lfx.Types.Parsing.ParseCurrency(EntradaOtrosGastos.Text);
                        EntradaTotal.Text = Lfx.Types.Formatting.FormatCurrency(EntradaProductos.Total + GastosEnvio + OtrosGastos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
		}

		private void txtNumero_Leave(object sender, System.EventArgs e)
		{
			if (Lfx.Types.Parsing.ParseInt(EntradaNumero.Text) > 0)
				EntradaNumero.Text = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString("00000000");
		}
	}
}