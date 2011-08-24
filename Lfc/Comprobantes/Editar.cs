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
using System.ComponentModel;

namespace Lfc.Comprobantes
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                protected internal string TipoPredet = null;

                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Comprobantes.ComprobanteConArticulos);

                        InitializeComponent();

                        lblTitulo.Font = Lfx.Config.Display.CurrentTemplate.DefaultHeaderFont;
                        lblTitulo.BackColor = Lfx.Config.Display.CurrentTemplate.HeaderBackground;
                        lblTitulo.ForeColor = Lfx.Config.Display.CurrentTemplate.HeaderText;
                }


                public Editar(string tipo)
                        : this()
                {
                        TipoPredet = tipo;
                }

                private bool IgnorarEventos = false;

                public override void OnWorkspaceChanged()
                {
                        if (this.HasWorkspace) {
                                EntradaTotal.DecimalPlaces = this.Workspace.CurrentConfig.Moneda.DecimalesFinal;
                                ProductArray.LockPrice = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema", "Documentos.CambiaPrecioItemFactura", 0) == 0;
                        }
                        base.OnWorkspaceChanged();
                }

                public override Lfx.Types.OperationResult ValidarControl()
                {
                        Lfx.Types.OperationResult validarReturn = base.ValidarControl();

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

                        int PV = Lfx.Types.Parsing.ParseInt(EntradaPV.Text);
                        System.Data.DataTable PVAdmitidos = this.Connection.Select(@"SELECT * FROM pvs WHERE (
                                CONCAT(',', tipo_fac, ',') LIKE '%," + this.Tipo.LetraSola + @",%'
                                OR CONCAT(',', tipo_fac, ',') LIKE '%," + this.Tipo.TipoBase + @",%'
                                OR CONCAT(',', tipo_fac, ',') LIKE '%," + this.Tipo.Nomenclatura + @",%'
                                )AND tipo>0");
                        if (PVAdmitidos.Rows.Count > 0) {
                                bool Admitido = false;
                                foreach (System.Data.DataRow PVAdmitido in PVAdmitidos.Rows) {
                                        if (System.Convert.ToInt32(PVAdmitido["numero"]) == PV) {
                                                Admitido = true;
                                                break;
                                        }
                                }

                                if (Admitido == false) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "Seleccione un Punto de Venta (PV) válido para este tipo de comprobante." + Environment.NewLine;
                                }
                        }

                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                        if (Registro.Tipo.MueveStock) {
                                if (Registro.SituacionOrigen == null || Registro.SituacionDestino == null || Registro.SituacionOrigen.Id == Registro.SituacionDestino.Id) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "Seleccione la Situación de Origen y de Destino." + Environment.NewLine;
                                }
                        }

                        return validarReturn;
                }


                public override void ActualizarControl()
                {
                        IgnorarEventos = true;

                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        this.SuspendLayout();
                        EntradaPV.Text = Comprob.PV.ToString();
                        EntradaVendedor.Elemento = Comprob.Vendedor;

                        Ignorar_EntradaCliente_TextChanged = true;
                        EntradaCliente.Elemento = Comprob.Cliente;
                        Ignorar_EntradaCliente_TextChanged = false;

                        EntradaSubTotal.Text = Lfx.Types.Formatting.FormatCurrency(Comprob.SubTotal, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaDescuento.Text = Lfx.Types.Formatting.FormatNumber(Comprob.Descuento, 2);
                        EntradaInteres.Text = Lfx.Types.Formatting.FormatNumber(Comprob.Recargo, 2);
                        EntradaCuotas.Text = Comprob.Cuotas.ToString();

                        if (this.PuedeEditar() == false) {
                                // Sólo muestro IVA en facturas que fueron impresas
                                EntradaIva.ValueDecimal = Comprob.ImporteIva;
                                EntradaIva.Visible = true;
                                EtiquetaIva.Visible = true;
                        }
                        EntradaTotal.ValueDecimal = Comprob.Total;

                        if (this.Elemento.Existe == true || this.PuedeEditar() == false) {
                                // No actualizar automáticamente detalles
                                ProductArray.AutoUpdate = false;
                        }

                        // Cargo el detalle del comprobante
                        ProductArray.CargarArticulos(Comprob.Articulos);

                        this.PonerTitulo();
                        this.ResumeLayout();

                        base.ActualizarControl();

                        IgnorarEventos = false;
                }

                public override bool PuedeEditar()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        if (Comprob.Estado != 0)
                                return false;
                        else if (Comprob.Impreso && Comprob.Tipo != null && Comprob.Tipo.PermiteModificarImpresos == false)
                                return false;
                        else
                                return base.PuedeEditar();
                }

                public override bool PuedeImprimir()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        if (Comprob.Tipo != null && Comprob.Tipo.PermiteImprimirVariasVeces == false && Comprob.Impreso)
                                return false;
                        else
                                return base.PuedeImprimir();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        Comprob.PV = EntradaPV.ValueInt;
                        Comprob.Vendedor = new Lbl.Personas.Persona(Comprob.Connection, EntradaVendedor.TextInt);
                        Comprob.Cliente = new Lbl.Personas.Persona(Comprob.Connection, EntradaCliente.TextInt);

                        Comprob.Descuento = EntradaDescuento.ValueDecimal;
                        Comprob.Recargo = EntradaInteres.ValueDecimal;
                        Comprob.Cuotas = EntradaCuotas.ValueInt;

                        Comprob.Articulos = ProductArray.ObtenerArticulos(Comprob);

                        base.ActualizarElemento();
                }

                public override bool TemporaryReadOnly
                {
                        get
                        {
                                return base.TemporaryReadOnly;
                        }
                        set
                        {
                                ProductArray.TemporaryReadOnly = value;
                                base.TemporaryReadOnly = value;
                        }
                }

                private void PonerTitulo()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                        string NuevoTitulo = Lbl.Comprobantes.Comprobante.NombreTipo(Registro.Tipo.ToString());

                        if (Registro.Numero > 0) {
                                NuevoTitulo += " ";

                                if (Registro.PV > 0)
                                        NuevoTitulo += Registro.PV.ToString("0000") + "-";

                                NuevoTitulo += Registro.Numero.ToString("00000000");
                        } else {
                                if (Registro.PV > 0)
                                        NuevoTitulo += " PV " + Registro.PV.ToString("0000");
                        }

                        this.lblTitulo.Text = NuevoTitulo;
                        this.Text = "Comprob: " + NuevoTitulo;
                }


                private void BotonObs_Click(object sender, System.EventArgs e)
                {
                        Lui.Forms.AuxForms.TextEdit EditarObs = new Lui.Forms.AuxForms.TextEdit();
                        if (((Lbl.ICamposBaseEstandar)(this.Elemento)).Obs != null)
                                EditarObs.EditText = ((Lbl.ICamposBaseEstandar)(this.Elemento)).Obs;
                        else
                                EditarObs.EditText = "";
                        EditarObs.ReadOnly = EntradaCliente.TemporaryReadOnly;

                        if (EditarObs.ShowDialog() == DialogResult.OK) {
                                if (EditarObs.EditText.Length > 0)
                                        ((Lbl.ICamposBaseEstandar)(this.Elemento)).Obs = EditarObs.EditText;
                                else
                                        ((Lbl.ICamposBaseEstandar)(this.Elemento)).Obs = null;
                        }
                }

                private void BotonConvertir_Click(object sender, System.EventArgs e)
                {
                        Comprobantes.Convertir FormConvertir = new Comprobantes.Convertir();
                        FormConvertir.OrigenTipo = this.Tipo.Nomenclatura;
                        FormConvertir.DestinoTipo = "F";
                        FormConvertir.OrigenNombre = this.Elemento.ToString();

                        if (FormConvertir.ShowDialog() == DialogResult.OK) {
                                string ConvertirEnTipo = FormConvertir.DestinoTipo;
                                if (ConvertirEnTipo == "F" || ConvertirEnTipo == "NC" || ConvertirEnTipo == "ND") {
                                        if (this.Tipo.LetraSola.Length > 0 && "ABCEM".IndexOf(this.Tipo.LetraSola) >= 0) {
                                                ConvertirEnTipo += this.Tipo.LetraSola;
                                        } else {
                                                Lbl.Comprobantes.ComprobanteConArticulos Compr = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                                                if (Compr != null && Compr.Cliente != null && Compr.Cliente.LetraPredeterminada().Length > 0)
                                                        ConvertirEnTipo += Compr.Cliente.LetraPredeterminada();
                                                else
                                                        ConvertirEnTipo += "B";
                                        }
                                }
                                Lfx.Types.OperationResult Resultado = ConvertirEn(ConvertirEnTipo);

                                if (Resultado.Success == false)
                                        Lui.Forms.MessageBox.Show(Resultado.Message, "Error");
                        }
                }

                internal virtual Lfx.Types.OperationResult ConvertirEn(string tipoComprob)
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                        if (Comprob.Existe) {
                                Lbl.Comprobantes.Tipo NuevoTipo = Lbl.Comprobantes.Tipo.TodosPorLetra[tipoComprob];
                                Lbl.Comprobantes.ComprobanteConArticulos Nuevo = Comprob.ConvertirEn(NuevoTipo) as Lbl.Comprobantes.ComprobanteConArticulos;

                                FormularioEdicion NuevoComprob = Instanciador.InstanciarFormularioEdicion(Nuevo);
                                NuevoComprob.ControlDestino = EntradaComprobanteId;
                                NuevoComprob.MdiParent = this.ParentForm.MdiParent;
                                NuevoComprob.Show();
                                return new Lfx.Types.SuccessOperationResult();
                        } else {
                                return new Lfx.Types.FailureOperationResult("Debe guardar el comprobante antes de poder convertirlo.");
                        }
                }


                private void ProductArray_TotalChanged(System.Object sender, System.EventArgs e)
                {
                        if (this.TemporaryReadOnly == false)
                                EntradaSubTotal.Text = Lfx.Types.Formatting.FormatCurrency(ProductArray.Total, this.Workspace.CurrentConfig.Moneda.Decimales);
                }


                private bool Ignorar_EntradaCliente_TextChanged = false;
                private void EntradaCliente_TextChanged(object sender, System.EventArgs e)
                {
                        if (Ignorar_EntradaCliente_TextChanged)
                                return;

                        decimal Descuento = this.Connection.FieldDecimal("SELECT descuento FROM personas_grupos WHERE id_grupo=(SELECT id_grupo FROM personas WHERE id_persona=" + EntradaCliente.TextInt.ToString() + ")");

                        if (Descuento > 0 && EntradaDescuento.ValueDecimal == 0) {
                                EntradaDescuento.Text = Lfx.Types.Formatting.FormatNumber(Descuento, 2);
                                EntradaDescuento.ShowBalloon("Se aplicó el descuento que corresponde al tipo de cliente.");
                        }

                        if (this.Tipo != null && this.Tipo.EsFacturaNCoND && this.Elemento.Existe == false && EntradaCliente.TextInt > 0) {
                                Lbl.Personas.Persona Persona = EntradaCliente.Elemento as Lbl.Personas.Persona;

                                string LetraComprob = Persona.LetraPredeterminada();

                                switch (LetraComprob) {
                                        case "A":
                                        case "B":
                                        case "C":
                                        case "M":
                                        case "E":
                                                if (this.Tipo.EsNotaCredito)
                                                        this.Tipo = Lbl.Comprobantes.Tipo.TodosPorLetra["NC" + LetraComprob];
                                                else if (this.Tipo.EsNotaDebito)
                                                        this.Tipo = Lbl.Comprobantes.Tipo.TodosPorLetra["ND" + LetraComprob];
                                                else
                                                        this.Tipo = Lbl.Comprobantes.Tipo.TodosPorLetra["F" + LetraComprob];
                                                break;
                                }
                        }
                }

                private void BotonMasDatos_Click(System.Object sender, System.EventArgs e)
                {
                        Lbl.Comprobantes.Comprobante Registro = this.Elemento as Lbl.Comprobantes.Comprobante;
                        Comprobantes.FormComprobanteMasDatos OFormMasDatos = new Comprobantes.FormComprobanteMasDatos();
                        OFormMasDatos.Owner = this.ParentForm;
                        OFormMasDatos.EntradaDesdeSituacion.Elemento = Registro.SituacionOrigen;
                        OFormMasDatos.EntradaHaciaSituacion.Elemento = Registro.SituacionDestino;
                        OFormMasDatos.EntradaDesdeSituacion.TemporaryReadOnly = EntradaCliente.TemporaryReadOnly;
                        OFormMasDatos.EntradaHaciaSituacion.TemporaryReadOnly = EntradaCliente.TemporaryReadOnly;
                        OFormMasDatos.EntradaBloqueada.TextKey = ((Lbl.ICamposBaseEstandar)(this.Elemento)).Estado.ToString();

                        if (Registro.Tipo.EsFactura)
                                OFormMasDatos.EntradaDesdeSituacion.Filter = "facturable=1";
                        else
                                OFormMasDatos.EntradaDesdeSituacion.Filter = "";

                        if (OFormMasDatos.ShowDialog() == DialogResult.OK) {
                                Registro.SituacionOrigen = new Lbl.Articulos.Situacion(Registro.Connection, OFormMasDatos.EntradaDesdeSituacion.TextInt);
                                Registro.SituacionDestino = new Lbl.Articulos.Situacion(Registro.Connection, OFormMasDatos.EntradaHaciaSituacion.TextInt);
                                ((Lbl.ICamposBaseEstandar)(this.Elemento)).Estado = Lfx.Types.Parsing.ParseInt(OFormMasDatos.EntradaBloqueada.TextKey);
                                this.TemporaryReadOnly = Lfx.Types.Parsing.ParseInt(OFormMasDatos.EntradaBloqueada.TextKey) != 0;
                        }
                }


                protected internal virtual void CambioValores(object sender, System.EventArgs e)
                {
                        if (IgnorarEventos)
                                return;

                        IgnorarEventos = true;

                        decimal Descuento = EntradaDescuento.ValueDecimal / 100m;
                        decimal Recargo = EntradaInteres.ValueDecimal / 100m;

                        decimal SubTotal = EntradaSubTotal.ValueDecimal;
                        decimal Total;
                        if (this.Workspace.CurrentConfig.Moneda.Redondeo > 0)
                                Total = Math.Floor((SubTotal * (1 + Recargo - Descuento)) / this.Workspace.CurrentConfig.Moneda.Redondeo) * this.Workspace.CurrentConfig.Moneda.Redondeo;
                        else
                                Total = SubTotal * (1 + Recargo - Descuento);

                        int Cuotas = Lfx.Types.Parsing.ParseInt(EntradaCuotas.Text);
                        EntradaTotal.ValueDecimal = Total;

                        if (Cuotas > 0)
                                EntradaValorCuota.ValueDecimal = Total / Cuotas;
                        else
                                EntradaValorCuota.ValueDecimal = 0m;

                        IgnorarEventos = false;
                }

                private void EntradaTotal_TextChanged(object sender, System.EventArgs e)
                {
                        if (IgnorarEventos)
                                return;

                        IgnorarEventos = true;
                        if (EntradaSubTotal.ValueDecimal > 0) {
                                decimal Descuento = EntradaTotal.ValueDecimal / (EntradaSubTotal.ValueDecimal + EntradaIva.ValueDecimal);
                                if (Descuento < 1) {
                                        EntradaDescuento.ValueDecimal = (1 - Descuento) * 100m;
                                        EntradaInteres.ValueDecimal = 0m;
                                } else {
                                        EntradaInteres.ValueDecimal = (Descuento - 1) * 100m;
                                        EntradaDescuento.ValueDecimal = 0m;
                                        EntradaInteres.ShowBalloon("Se aplicó un recargo.");
                                }
                        }
                        IgnorarEventos = false;
                }

                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public virtual Lbl.Comprobantes.Tipo Tipo
                {
                        get
                        {
                                Lbl.Comprobantes.ComprobanteConArticulos Registro = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                                if (Registro == null)
                                        return null;
                                return Registro.Tipo;
                        }
                        set
                        {
                                if (this.Elemento != null) {
                                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                                        Registro.Tipo = value;
                                        PnlCuotas.Visible = value.EsPresupuesto;
                                        this.PonerTitulo();
                                }
                        }
                }

                private void ProductArray_ObtenerDatosSeguimiento(object sender, EventArgs e)
                {
                        Lcc.Entrada.Articulos.DetalleComprobante Prod = sender as Lcc.Entrada.Articulos.DetalleComprobante;

                        if (Prod == null)
                                return;

                        int IdArticulo = Prod.TextInt;

                        if (IdArticulo == 0)
                                return;

                        decimal Cant = Prod.Cantidad;

                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        EditarSeguimiento Editar = new EditarSeguimiento();
                        Editar.Connection = this.Connection;
                        Editar.Articulo = new Lbl.Articulos.Articulo(this.Connection, IdArticulo);
                        Editar.Cantidad = Math.Abs(System.Convert.ToInt32(Cant));
                        Editar.SituacionOrigen = Comprob.SituacionOrigen;
                        Editar.DatosSeguimiento = Prod.DatosSeguimiento;
                        if (Editar.ShowDialog() == DialogResult.OK) {
                                Prod.DatosSeguimiento = Editar.DatosSeguimiento;
                        }
                }
        }
}