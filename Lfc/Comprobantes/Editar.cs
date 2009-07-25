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
using System.ComponentModel;

namespace Lfc.Comprobantes
{
	public partial class Editar : Lui.Forms.EditForm
	{
                protected internal string TipoPredet = null;
                public Editar(string tipo) : this()
                {
                        TipoPredet = tipo;
                }

		private bool IgnorarEventos = false;

                public override Lfx.Types.OperationResult ValidateData()
                {
                        Lfx.Types.OperationResult validarReturn = base.ValidateData();

                        if (EntradaVendedor.TextInt == 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Seleccione un Vendedor." + Environment.NewLine;
                        }

                        if (EntradaCliente.TextInt == 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Seleccione un Cliente." + Environment.NewLine;
                        }

                        if (Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text) <= 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "El comprobante debe tener un Importe superior a $ 0.00." + Environment.NewLine;
                        }

                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.ToRow() as Lbl.Comprobantes.ComprobanteConArticulos;
                        if (Registro.Tipo.MueveStock) {
                                if (Registro.SituacionOrigen == null || Registro.SituacionDestino == null || Registro.SituacionOrigen.Id == Registro.SituacionDestino.Id) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "Seleccione la Situación de Origen y de Destino." + Environment.NewLine;
                                }
                        }

                        return validarReturn;
                }

		public override Lfx.Types.OperationResult Edit(int iId)
		{
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.write") == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Comprobantes.ComprobanteConArticulos NewRow = new Lbl.Comprobantes.ComprobanteConArticulos(this.DataView, iId);
                        this.FromRow(NewRow);

			return new Lfx.Types.SuccessOperationResult();
		}

                public override Lfx.Types.OperationResult Print(bool DejaSeleccionarImpresora)
                {
                        Lfx.Types.OperationResult ResultadoImprimir = new Lfx.Types.SuccessOperationResult();

                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.ToRow() as Lbl.Comprobantes.ComprobanteConArticulos;
                        if (Registro.Impreso && Registro.Tipo.PermiteImprimirVariasVeces == false) {
                                ResultadoImprimir.Success = false;
                                ResultadoImprimir.Message = "Este comprobante ya fue impreso." + Environment.NewLine;
                        } else {
                                if (Registro.PV == 0)
                                        return new Lfx.Types.FailureOperationResult("Por favor seleccione un punto de venta apropiado");

                                ResultadoImprimir = this.Save();
                                if (ResultadoImprimir.Success) {
                                        string NombreImpresora = null;
                                        if (DejaSeleccionarImpresora) {
                                                Lui.Printing.PrinterSelectionDialog OSeleccionarImpresora = new Lui.Printing.PrinterSelectionDialog();
                                                if (OSeleccionarImpresora.ShowDialog() == DialogResult.OK)
                                                        NombreImpresora = OSeleccionarImpresora.SelectedPrinter;
                                        }

                                        CachedRow.BeginTransaction();
                                        ResultadoImprimir = ((Lbl.Comprobantes.Comprobante)CachedRow).Imprimir(NombreImpresora);

                                        if (ResultadoImprimir.Success) {
                                                //Registro.Impreso = true;
                                                //Registro.Guardar();
                                                CachedRow.Commit();
                                                if (Registro.Tipo.PermiteModificarImpresos == false)
                                                        this.ReadOnly = true;
                                                if (Registro.Tipo.PermiteImprimirVariasVeces == false)
                                                        PrintButton.Visible = false;
                                        } else {
                                                CachedRow.RollBack();
                                        }
                                }
                        }
                        return ResultadoImprimir;
                }

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;

                        this.SuspendLayout();
                        txtPV.Text = Registro.PV.ToString();
                        if (Registro.Vendedor != null)
                                EntradaVendedor.TextInt = Registro.Vendedor.Id;
                        else
                                EntradaVendedor.TextInt = 0;

                        Ignorar_txtCliente_TextChanged = true;
                        if (Registro.Cliente != null)
                                EntradaCliente.TextInt = Registro.Cliente.Id;
                        else
                                EntradaCliente.TextInt = 0;

                        Ignorar_txtCliente_TextChanged = false;
                        txtSubTotal.Text = Lfx.Types.Formatting.FormatCurrency(Registro.SubTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        txtDescuento.Text = Lfx.Types.Formatting.FormatNumber(Registro.Descuento, 2);
                        txtInteres.Text = Lfx.Types.Formatting.FormatNumber(Registro.Recargo, 2);
                        txtCuotas.Text = Registro.Cuotas.ToString();
                        if (Registro.Impreso == true && Registro.Tipo.PermiteModificarImpresos == false)
                                this.ReadOnly = true;
                        else
                                this.ReadOnly = Registro.Estado != 0;
                        this.PrintButton.Visible = Registro.Impreso == false || Registro.Tipo.PermiteImprimirVariasVeces;

                        // Cargo el detalle del comprobante
                        ProductArray.AutoAgregar = false;
                        ProductArray.Count = Registro.Articulos.Count;

                        for (int i = 0; i < Registro.Articulos.Count; i++) {
                                if (Registro.Articulos[i].Articulo == null)
                                        ProductArray.ChildControls[i].Text = ProductArray.FreeTextCode;
                                else
                                        ProductArray.ChildControls[i].TextInt = Registro.Articulos[i].Articulo.Id;

                                ProductArray.ChildControls[i].TextDetail = Registro.Articulos[i].Nombre;
                                ProductArray.ChildControls[i].Cantidad = Registro.Articulos[i].Cantidad;
                                ProductArray.ChildControls[i].Unitario = Registro.Articulos[i].Unitario;
                        }

                        if (Registro.Estado == 1)
                                SaveButton.Visible = false;
                        else
                                ProductArray.AutoAgregar = true;

                        this.PonerTitulo();
                        this.ResumeLayout();
                        
                }
                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Res = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                        Res.PV = Lfx.Types.Parsing.ParseInt(txtPV.Text);
                        Res.Vendedor = new Lbl.Personas.Persona(Res.DataView, EntradaVendedor.TextInt);
                        Res.Cliente = new Lbl.Personas.Persona(Res.DataView, EntradaCliente.TextInt);

                        Res.Descuento = Lfx.Types.Parsing.ParseDouble(txtDescuento.Text);
                        Res.Recargo = Lfx.Types.Parsing.ParseDouble(txtInteres.Text);
                        Res.Cuotas = Lfx.Types.Parsing.ParseInt(txtCuotas.Text);

                        int i = 0;

                        Res.Articulos.Clear();
                        for (i = 0; i <= ProductArray.Count - 1; i++) {
                                if (ProductArray.ChildControls[i].Text == ProductArray.FreeTextCode || ProductArray.ChildControls[i].TextInt > 0) {
                                        Lbl.Comprobantes.DetalleArticulo Art = new Lbl.Comprobantes.DetalleArticulo(Res.DataView);
                                        Art.Orden = i + 1;

                                        Art.IdArticulo = ProductArray.ChildControls[i].TextInt;
                                        Art.Nombre = ProductArray.ChildControls[i].TextDetail;
                                        Art.Cantidad = ProductArray.ChildControls[i].Cantidad;
                                        Art.Unitario = ProductArray.ChildControls[i].Unitario;
                                        Res.Articulos.Add(Art);
                                }
                        }
                        return Res;
                }

                public override bool ReadOnly
                {
                        get
                        {
                                return base.ReadOnly;
                        }
                        set
                        {
                                (CachedRow as Lbl.Comprobantes.ComprobanteConArticulos).Estado = value ? 1 : 0;

                                ProductArray.LockText = value;
                                ProductArray.LockQuantity = value;
                                ProductArray.LockPrice = value;

                                base.ReadOnly = value;
                        }
                }

		private void PonerTitulo()
		{
                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                        string NuevoTitulo = Lbl.Comprobantes.Comprobante.NombreTipo(Registro.Tipo.ToString());

                        if (Registro.Numero > 0)
			{
				NuevoTitulo += " ";

                                if (Registro.PV > 0)
                                        NuevoTitulo += Registro.PV.ToString("0000") + "-";

                                NuevoTitulo += Registro.Numero.ToString("00000000");
			}
			else
			{
                                if (Registro.PV > 0)
                                        NuevoTitulo += " PV " + Registro.PV.ToString("0000");
			}

			this.lblTitulo.Text = NuevoTitulo;
                        this.Text = "Comprob: " + NuevoTitulo;
		}

                private void FormComprobanteEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case Keys.F4:
                                                e.Handled = true;
                                                if (cmdConvertir.Enabled && cmdConvertir.Visible)
                                                        cmdConvertir.PerformClick();
                                                break;

                                        case Keys.F5:
                                                e.Handled = true;
                                                if (cmdMasDatos.Enabled && cmdMasDatos.Visible)
                                                        cmdMasDatos.PerformClick();
                                                break;

                                        case Keys.F7:
                                                e.Handled = true;
                                                if (cmdObs.Enabled && cmdObs.Visible)
                                                        cmdObs.PerformClick();
                                                break;

                                        case Keys.F8:
                                                e.Handled = true;
                                                if (PrintButton.Enabled && PrintButton.Visible)
                                                        PrintButton.PerformClick();
                                                break;
                                }
                        }
                }

		private void cmdObs_Click(object sender, System.EventArgs e)
		{
                        Lui.Forms.AuxForms.TextEdit EditarObs = new Lui.Forms.AuxForms.TextEdit();
			if (CachedRow.Obs != null)
                        	EditarObs.EditText = CachedRow.Obs;
			else
				EditarObs.EditText = "";
                        EditarObs.ReadOnly = EntradaCliente.ReadOnly;

                        if (EditarObs.ShowDialog() == DialogResult.OK) {
				if (EditarObs.EditText.Length > 0)
                                	CachedRow.Obs = EditarObs.EditText;
				else
					CachedRow.Obs = null;
                        }
		}

		private void cmdConvertir_Click(object sender, System.EventArgs e)
		{
			Comprobantes.Convertir FormConvertir = new Comprobantes.Convertir();
                        FormConvertir.OrigenTipo = this.Tipo.Nomenclatura;
                        FormConvertir.DestinoTipo = "B";
                        FormConvertir.OrigenNombre = this.CachedRow.ToString();

                        if (FormConvertir.ShowDialog() == DialogResult.OK) {
                                Lfx.Types.OperationResult Resultado = ConvertirEn(FormConvertir.DestinoTipo);

                                if (Resultado.Success == false)
                                        Lui.Forms.MessageBox.Show(Resultado.Message, "Error");
                        }
		}

                internal virtual Lfx.Types.OperationResult ConvertirEn(string tipoComprob)
                {
                        Lfx.Types.OperationResult convertirEnPresupuestoReturn = new Lfx.Types.SuccessOperationResult();

                        Comprobantes.Editar NuevoComprob;
                        switch (tipoComprob) {
                                case "A":
                                case "B":
                                case "C":
                                case "E":
                                case "M":

                                case "NCA":
                                case "NCB":
                                case "NCC":
                                case "NCE":
                                case "NCM":

                                case "NDA":
                                case "NDB":
                                case "NDC":
                                case "NDE":
                                case "NDM":
                                        NuevoComprob = new Comprobantes.Facturas.Editar(tipoComprob);
                                        break;

                                case "PS":
                                        NuevoComprob = new Comprobantes.Presupuestos.Editar(tipoComprob);
                                        break;

                                default:
                                        NuevoComprob = new Comprobantes.Editar(tipoComprob);
                                        break;
                        }

                        NuevoComprob.Workspace = this.Workspace;
                        NuevoComprob.MdiParent = this.MdiParent;
                        NuevoComprob.ControlDestino = txtComprobanteID;

                        if (this.Save().Success == true) {
                                NuevoComprob.Create(tipoComprob);
                                ((Lbl.Comprobantes.ComprobanteConArticulos)(NuevoComprob.CachedRow)).ComprobanteOriginal = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;

                                NuevoComprob.EntradaCliente.Text = EntradaCliente.Text;
                                NuevoComprob.EntradaVendedor.Text = EntradaVendedor.Text;
                                NuevoComprob.txtDescuento.Text = txtDescuento.Text;
                                NuevoComprob.txtInteres.Text = txtInteres.Text;
                                NuevoComprob.ProductArray.Count = ProductArray.Count;
                                if (this is Facturas.Editar && NuevoComprob is Facturas.Editar) {
                                        ((Facturas.Editar)NuevoComprob).EntradaRemito.Text = ((Facturas.Editar)this).EntradaRemito.Text;
                                        ((Facturas.Editar)NuevoComprob).EntradaFormaPago.Text = ((Facturas.Editar)this).EntradaFormaPago.Text;
                                }

                                for (int n = 0; n <= ProductArray.Count - 1; n++) {
                                        NuevoComprob.ProductArray.ChildControls[n].Text = ProductArray.ChildControls[n].Text;
                                        NuevoComprob.ProductArray.ChildControls[n].Cantidad = ProductArray.ChildControls[n].Cantidad;
                                        NuevoComprob.ProductArray.ChildControls[n].Unitario = ProductArray.ChildControls[n].Unitario;
                                }

                                ((Lbl.Comprobantes.Comprobante)NuevoComprob.CachedRow).Obs = ((Lbl.Comprobantes.Comprobante)CachedRow).Obs;

                                NuevoComprob.Show();
                        }

                        convertirEnPresupuestoReturn.Success = true;
                        return convertirEnPresupuestoReturn;
                }

		private void ProductArray_TotalChanged(System.Object sender, System.EventArgs e)
		{
			txtSubTotal.Text = Lfx.Types.Formatting.FormatCurrency(ProductArray.Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
		}

                public override Lfx.Types.OperationResult Create()
                {
                        return this.Create(TipoPredet);
                }

		public virtual Lfx.Types.OperationResult Create(string letra)
		{
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.create") == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Comprobantes.ComprobanteConArticulos NewRow = new Lbl.Comprobantes.ComprobanteConArticulos(this.DataView);
                        if (letra == null)
                                NewRow.Crear();
                        else
                                NewRow.Crear(letra);
                        
                        int ClientePredet = this.Workspace.CurrentConfig.ReadGlobalSettingInt(null, "Sistema.Documentos.ClientePredet", 0);
                        if (ClientePredet != 0)
                                NewRow.Cliente = new Lbl.Personas.Persona(NewRow.DataView, ClientePredet);

                        this.FromRow(NewRow);
			return new Lfx.Types.SuccessOperationResult();
		}

                private void cmdImprimir_Click(object sender, System.EventArgs e)
                {
                        Lfx.Types.OperationResult Res = Print((Control.ModifierKeys & Keys.Shift) == Keys.Shift);

                        if (Res.Success == true) {
                                switch (this.Tipo.Nomenclatura) {
                                        case "A":
                                        case "B":
                                        case "C":
                                        case "E":
                                        case "M":

                                        case "NCA":
                                        case "NCB":
                                        case "NCC":
                                        case "NCE":
                                        case "NCM":

                                        case "NDA":
                                        case "NDB":
                                        case "NDC":
                                        case "NDE":
                                        case "NDM":

                                        case "R":
                                        case "RC":
                                                this.Close();
                                                break;
                                }
                        } else {
                                Lui.Forms.MessageBox.Show(Res.Message, "Aviso");
                        }
                }

                private bool Ignorar_txtCliente_TextChanged = false;
                private void txtCliente_TextChanged(object sender, System.EventArgs e)
                {
                        if (Ignorar_txtCliente_TextChanged)
                                return;

                        double Descuento = this.Workspace.DefaultDataBase.FieldDouble("SELECT descuento FROM personas_grupos WHERE id_grupo=(SELECT id_grupo FROM personas WHERE id_persona=" + EntradaCliente.TextInt.ToString() + ")");

                        if (Descuento > 0 && Lfx.Types.Parsing.ParseDouble(txtDescuento.Text) == 0) {
                                txtDescuento.Text = Lfx.Types.Formatting.FormatNumber(Descuento, 2);
                                txtDescuento.ShowBalloon("Se aplicó el descuento que corresponde al tipo de cliente.");
                        }

                        if (this.Tipo.EsFacturaNCoND && this.CachedRow.Existe == false && EntradaCliente.TextInt > 0) {
                                Lbl.Personas.Persona Persona = new Lbl.Personas.Persona(CachedRow.DataView, EntradaCliente.TextInt, true);
                                string TipoComprob = Persona.TipoComprobantePredeterminado();

                                switch (TipoComprob) {
                                        case "A":
                                        case "B":
                                        case "C":
                                        case "M":
                                        case "E":
                                                if (this.Tipo.EsNotaCredito)
                                                        this.Tipo = new Lbl.Comprobantes.Tipo(this.CachedRow.DataView, "NC" + TipoComprob);
                                                else if (this.Tipo.EsNotaDebito)
                                                        this.Tipo = new Lbl.Comprobantes.Tipo(this.CachedRow.DataView, "ND" + TipoComprob);
                                                else
                                                        this.Tipo = new Lbl.Comprobantes.Tipo(this.CachedRow.DataView, TipoComprob);
                                                break;
                                }
                        }
                }

		private void cmdMasDatos_Click(System.Object sender, System.EventArgs e)
		{
                        Lbl.Comprobantes.Comprobante Registro = this.CachedRow as Lbl.Comprobantes.Comprobante;
			Comprobantes.FormComprobanteMasDatos OFormMasDatos = new Comprobantes.FormComprobanteMasDatos();
			OFormMasDatos.Owner = this;
                        if (Registro.SituacionOrigen != null)
                                OFormMasDatos.txtDesdeSituacion.TextInt = Registro.SituacionOrigen.Id;
                        if (Registro.SituacionDestino != null)
                                OFormMasDatos.txtHaciaSituacion.TextInt = Registro.SituacionDestino.Id;
                        OFormMasDatos.txtDesdeSituacion.ReadOnly = EntradaCliente.ReadOnly;
                        OFormMasDatos.txtHaciaSituacion.ReadOnly = EntradaCliente.ReadOnly;
                        OFormMasDatos.txtBloqueada.TextKey = this.CachedRow.Registro["estado"].ToString();
                        if (Registro.Tipo.EsFactura)
                                OFormMasDatos.txtDesdeSituacion.Filter = "facturable=1";
                        else
                                OFormMasDatos.txtDesdeSituacion.Filter = "";

                        if (OFormMasDatos.ShowDialog() == DialogResult.OK) {
                                Registro.SituacionOrigen = new Lbl.Articulos.Situacion(Registro.DataView, OFormMasDatos.txtDesdeSituacion.TextInt);
                                Registro.SituacionDestino = new Lbl.Articulos.Situacion(Registro.DataView, OFormMasDatos.txtHaciaSituacion.TextInt);
                                this.CachedRow.Registro["estado"] = Lfx.Types.Parsing.ParseInt(OFormMasDatos.txtBloqueada.TextKey);
                                this.ReadOnly = Lfx.Types.Parsing.ParseInt(OFormMasDatos.txtBloqueada.TextKey) != 0;
                        }
		}

		private void FormComprobanteEditar_WorkspaceChanged(object sender, System.EventArgs e)
		{
			EntradaTotal.DecimalPlaces = this.Workspace.CurrentConfig.Currency.DecimalPlacesFinal;
			ProductArray.LockPrice = this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos.CambiaPrecioItemFactura", 0) == 0;
		}

		private void FormComprobanteEditar_Load(object sender, System.EventArgs e)
		{
			ProductArray.AutoAgregar = true;
		}

		protected internal virtual void CambioValores(object sender, System.EventArgs e)
		{
        		if (IgnorarEventos)
				return;

			IgnorarEventos = true;

                        double Descuento = Lfx.Types.Parsing.ParseDouble(txtDescuento.Text) / 100;
                        double Recargo = Lfx.Types.Parsing.ParseDouble(txtInteres.Text) / 100;

                        double SubTotal = Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text);
                        double Total;
                        if(this.Workspace.CurrentConfig.Currency.Rounding >0)
                                Total = Math.Floor((SubTotal * (1 + Recargo - Descuento)) / this.Workspace.CurrentConfig.Currency.Rounding) * this.Workspace.CurrentConfig.Currency.Rounding;
                        else
                                Total = SubTotal * (1 + Recargo - Descuento);

                        int Cuotas = Lfx.Types.Parsing.ParseInt(txtCuotas.Text);
                        EntradaTotal.Text = Lfx.Types.Formatting.FormatCurrency(Total, this.Workspace.CurrentConfig.Currency.DecimalPlacesFinal, false);

			if (Cuotas > 0)
                                txtValorCuota.Text = Lfx.Types.Formatting.FormatCurrency(Total / Cuotas, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
			else
				txtValorCuota.Text = "0";

			IgnorarEventos = false;
		}

                private void txtTotal_TextChanged(object sender, System.EventArgs e)
                {
                        if (IgnorarEventos)
                                return;

                        IgnorarEventos = true;
                        if (Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text) > 0) {
                                double Descuento = Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text) / Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text);
                                if (Descuento < 1) {
                                        txtDescuento.Text = Lfx.Types.Formatting.FormatNumber((1 - Descuento) * 100, 2);
                                        txtInteres.Text = "0";
                                } else {
                                        txtInteres.Text = Lfx.Types.Formatting.FormatNumber((Descuento - 1) * 100, 2);
                                        txtDescuento.Text = "0";
                                        txtInteres.ShowBalloon("Se aplicó un recargo.");
                                }
                        }
                        IgnorarEventos = false;
                }

                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public virtual Lbl.Comprobantes.Tipo Tipo
                {
                        get
                        {
                                Lbl.Comprobantes.ComprobanteConArticulos Registro = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                                return Registro.Tipo;
                        }
                        set
                        {
                                if (this.CachedRow != null) {
                                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                                        Registro.Tipo = value;
                                        PnlCuotas.Visible = value.EsPresupuesto;
                                        this.PonerTitulo();
                                }
                        }
                }
	}
}