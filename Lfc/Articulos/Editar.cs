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
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Lfc.Articulos
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                private bool CustomName = false;
                private decimal Rendimiento;
                private string UnidadRendimiento = "";
                private int IgnorarCostoTextChanged;

                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Articulos.Articulo);

                        InitializeComponent();
                }


                private void EntradaCategoriaMarcaModeloSerie_TextChanged(System.Object sender, System.EventArgs e)
                {
                        Lbl.Articulos.Categoria Cat = EntradaCategoria.Elemento as Lbl.Articulos.Categoria;
                        if (Cat != null) {
                                Lbl.Impuestos.Alicuota Alic = Cat.ObtenerAlicuota();
                                if (Alic != null)
                                        EtiquetaAlicuota.Text = "(más " + Alic.ToString() + ")";
                                else
                                        EtiquetaAlicuota.Text = "";
                        }

                        if (CustomName == false) {
                                string NombreSing = "";
                                if (Cat != null)
                                        NombreSing = Cat.NombreSingular;
                                string Texto = (NombreSing + " " + EntradaMarca.TextDetail + " " + EntradaModelo.Text + " " + EntradaSerie.Text).Trim();
                                if (Texto.Length > 0)
                                        EntradaNombre.Text = Texto;
                        }

                        EntradaSeguimiento_TextChanged(sender, e);
                }

                private void EntradaNombre_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                        CustomName = true;
                }


                private void BotonMasInfo_Click(object sender, System.EventArgs e)
                {
                        Articulos.MasInfo FormMasInfo = new Articulos.MasInfo();
                        FormMasInfo.Articulo = this.Elemento as Lbl.Articulos.Articulo;

                        if (FormMasInfo.ShowDialog() == DialogResult.OK) {
                                // Guardar algo si fuera editable
                        }
                }

                private void EntradaCostoMargen_TextChanged(System.Object sender, System.EventArgs e)
                {
                        if (this.Connection == null)
                                return;

                        if (EntradaCosto.ValueDecimal < 0)
                                EntradaCosto.ErrorText = "El costo no debería ser menor que cero.";
                        else
                                EntradaCosto.ErrorText = "";

                        if (IgnorarCostoTextChanged <= 0) {
                                if (EntradaMargen.TextKey.IsNumericInt()) {
                                        Lfx.Data.Row Margen = this.Connection.Tables["margenes"].FastRows[Lfx.Types.Parsing.ParseInt(EntradaMargen.TextKey)];

                                        if (Margen != null) {
                                                decimal Pvp = EntradaCosto.ValueDecimal;
                                                Pvp += System.Convert.ToDecimal(Margen["sumar"]);
                                                decimal MargenCompleto = System.Convert.ToDecimal(Margen["porcentaje"]) + System.Convert.ToDecimal(Margen["porcentaje2"]) + System.Convert.ToDecimal(Margen["porcentaje3"]);
                                                Pvp *= (1 + MargenCompleto / 100);
                                                Pvp += System.Convert.ToDecimal(Margen["sumar2"]);
                                                IgnorarCostoTextChanged++;
                                                EntradaPvp.ValueDecimal = Pvp;
                                                IgnorarCostoTextChanged--;
                                        }
                                } else {
                                        IgnorarCostoTextChanged++;
                                        EntradaPvp_TextChanged(sender, e);
                                        IgnorarCostoTextChanged--;
                                }
                        }
                }

                private void EntradaPvp_TextChanged(object sender, System.EventArgs e)
                {
                        if (IgnorarCostoTextChanged <= 0) {
                                IgnorarCostoTextChanged++;
                                EntradaMargen.TextKey = "";

                                if (EntradaCosto.ValueDecimal == 0)
                                        EntradaMargen.Text = "N/A";
                                else
                                        EntradaMargen.Text = "Otro (" + Lfx.Types.Formatting.FormatNumber(EntradaPvp.ValueDecimal / EntradaCosto.ValueDecimal * 100 - 100, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto) + "%)";

                                IgnorarCostoTextChanged--;
                        }
                }

                public override Lfx.Types.OperationResult ValidarControl()
                {
                        /* if (this.Elemento.Existe) {
                                Lbl.Articulos.Seguimientos Seg = (Lbl.Articulos.Seguimientos)(EntradaSeguimiento.ValueInt);
                                if (Seg == Lbl.Articulos.Seguimientos.Predeterminado) {
                                        Lbl.Articulos.Categoria Cat = EntradaCategoria.Elemento as Lbl.Articulos.Categoria;
                                        if (Cat != null)
                                                Seg = Cat.ObtenerSeguimiento();
                                }

                                decimal CantidadSeguimiento = this.Connection.FieldDecimal("SELECT SUM(cantidad) FROM articulos_series WHERE id_articulo=" + this.Elemento.Id);

                                if (Seg == Lbl.Articulos.Seguimientos.Ninguno && CantidadSeguimiento != 0) {
                                        // Se van a perder los datos de seguimiento
                                        Lui.Forms.YesNoDialog PregNuevo = new Lui.Forms.YesNoDialog("Al desactivar el seguimiento, se perderán los datos actuales de seguimiento (números de serie o talles y colores). ¿Está seguro de que desea continuar?", "Desactivar seguimiento");
                                        if (PregNuevo.ShowDialog() != DialogResult.OK)
                                                return new Lfx.Types.FailureOperationResult("Active nuevamente el seguimiento del artículo para no perder los datos actuales de seguimiento. Puede consultar los datos actuales en 'Conformación'.");
                                } else if (Seg != Lbl.Articulos.Seguimientos.Ninguno && CantidadSeguimiento != EntradaStockActual.ValueDecimal) {
                                        // Hay que ingresar nuevos datos de seguimiento
                                        Lui.Forms.YesNoDialog PregNuevo = new Lui.Forms.YesNoDialog("Al activar el seguimiento, deberá ingresar los datos de seguimiento (números de serie o talles y colores) para las existencias actuales. ¿Está seguro de que desea continuar?", "Activar seguimiento");
                                        if (PregNuevo.ShowDialog() != DialogResult.OK) {
                                                return new Lfx.Types.FailureOperationResult("Desactive nuevamente el seguimiento del artículo si no tiene los datos de seguimiento de las existencias actuales.");
                                        } else {
                                                Lbl.Articulos.Articulo Art = this.Elemento as Lbl.Articulos.Articulo;

                                                Lfc.Articulos.EditarSeguimiento EditarSeg = new EditarSeguimiento();
                                                EditarSeg.Articulo = Art;
                                                EditarSeg.Cantidad = Math.Abs(System.Convert.ToInt32(EntradaStockActual.ValueDecimal));
                                                EditarSeg.SituacionOrigen = new Lbl.Articulos.Situacion(this.Connection, 998);
                                                EditarSeg.DatosSeguimiento = EntradaArticulo.DatosSeguimiento;
                                                if (EditarSeg.ShowDialog() == DialogResult.OK) {
                                                        EntradaArticulo.DatosSeguimiento = EditarSeg.DatosSeguimiento;
                                                }
                                        }
                                }
                        } */


                        Lfx.Types.OperationResult Res = new Lfx.Types.SuccessOperationResult();

                        if (EntradaNombre.Text.Length < 2) {
                                Res.Success = false;
                                Res.Message += "Por favor escriba el nombre del artículo." + Environment.NewLine;
                        }

                        if (EntradaCodigo1.Text.Length > 0) {
                                Lfx.Data.Row Articulo = this.Connection.FirstRowFromSelect("SELECT id_articulo FROM articulos WHERE codigo1='" + EntradaCodigo1.Text + "' AND id_articulo<>" + this.Elemento.Id.ToString());

                                if (Articulo != null) {
                                        Res.Success = false;
                                        Res.Message += "Ya existe un artículo con el mismo código (" + EtiquetaCodigo1.Text + " " + EntradaCodigo1.Text + ") en la base de datos." + Environment.NewLine;
                                }
                        }

                        if (EntradaCodigo2.Text.Length > 0) {
                                Lfx.Data.Row Articulo = this.Connection.FirstRowFromSelect("SELECT id_articulo FROM articulos WHERE codigo2='" + EntradaCodigo2.Text + "' AND id_articulo<>" + this.Elemento.Id.ToString());

                                if (Articulo != null) {
                                        Res.Success = false;
                                        Res.Message += "Ya existe un artículo con el mismo código (" + EtiquetaCodigo2.Text + " " + EntradaCodigo2.Text + ") en la base de datos." + Environment.NewLine;
                                }
                        }

                        if (EntradaCodigo3.Text.Length > 0) {
                                Lfx.Data.Row Articulo = this.Connection.FirstRowFromSelect("SELECT id_articulo FROM articulos WHERE codigo3='" + EntradaCodigo3.Text + "' AND id_articulo<>" + this.Elemento.Id.ToString());

                                if (Articulo != null) {
                                        Res.Success = false;
                                        Res.Message += "Ya existe un artículo con el mismo código (" + EtiquetaCodigo3.Text + " " + EntradaCodigo3.Text + ") en la base de datos." + Environment.NewLine;
                                }
                        }

                        if (EntradaCodigo4.Text.Length > 0) {
                                Lfx.Data.Row Articulo = this.Connection.FirstRowFromSelect("SELECT id_articulo FROM articulos WHERE codigo4='" + EntradaCodigo4.Text + "' AND id_articulo<>" + this.Elemento.Id.ToString());

                                if (Articulo != null) {
                                        Res.Success = false;
                                        Res.Message += "Ya existe un artículo con el mismo código (" + EtiquetaCodigo4.Text + " " + EntradaCodigo4.Text + ") en la base de datos." + Environment.NewLine;
                                }
                        }

                        return Res;
                }


                private void EntradaCosto_GotFocus(object sender, System.EventArgs e)
                {
                        if (this.Elemento.Existe) {
                                string Res = "";

                                decimal PrecioUltComp = this.Connection.FieldDecimal("SELECT comprob_detalle.precio FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.tipo_fac IN ('R', 'FA', 'FB', 'FC', 'FE', 'FM') AND comprob.compra=1 AND id_articulo=" + this.Elemento.Id.ToString() + " GROUP BY comprob.id_comprob ORDER BY comprob_detalle.id_comprob_detalle DESC");
                                decimal PrecioUltFlete = this.Connection.FieldDecimal("SELECT (comprob.gastosenvio+comprob.otrosgastos)*(comprob_detalle.precio/comprob.total) FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.tipo_fac IN ('R', 'FA', 'FB', 'FC', 'FE', 'FM') AND comprob.compra=1 AND id_articulo=" + this.Elemento.Id.ToString() + " GROUP BY comprob.id_comprob ORDER BY comprob_detalle.id_comprob_detalle DESC");
                                Res += "Costo de la última compra (sin gastos): " + Lbl.Sys.Config.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(PrecioUltComp, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto) + Environment.NewLine;
                                Res += "Costo de la última compra (con gastos): " + Lbl.Sys.Config.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(PrecioUltComp + PrecioUltFlete, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto) + Environment.NewLine;

                                // Podría hacer esto con una subconsulta, pero la versión de MySql que estamos utilizando
                                // no permite la cláusula LIMIT dentro de una subconsulta IN ()
                                decimal PrecioUlt5Comps = 0;
                                System.Data.DataTable UltimasCompras = this.Connection.Select("SELECT comprob_detalle.precio, comprob.id_comprob FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.compra=1 AND comprob.tipo_fac IN ('R', 'FA', 'FB', 'FC', 'FE', 'FM') AND comprob.compra=1 AND comprob_detalle.id_articulo=" + this.Elemento.Id.ToString() + " ORDER BY comprob.fecha DESC LIMIT 5");

                                if (UltimasCompras.Rows.Count > 0) {
                                        foreach (System.Data.DataRow Compra in UltimasCompras.Rows) {
                                                PrecioUlt5Comps += System.Convert.ToDecimal(Compra["precio"]);
                                        }

                                        PrecioUlt5Comps = PrecioUlt5Comps / UltimasCompras.Rows.Count;
                                        Res += "Promedio de las últimas " + UltimasCompras.Rows.Count.ToString() + " compras (sin gastos): " + Lbl.Sys.Config.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(PrecioUlt5Comps, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto);
                                }

                                // TODO: EntradaCosto.ShowBalloon(Res, "Precio de Compra", 60);
                        }
                }

                private void EntradaStockActual_TextChanged(object sender, System.EventArgs e)
                {
                        if (Lfx.Types.Parsing.ParseStock(EntradaStockActual.Text) < Lfx.Types.Parsing.ParseStock(EntradaStockMinimo.Text))
                                EntradaStockActual.ErrorText = "El stock actual está por debajo del mínimo.";
                        else
                                EntradaStockActual.ErrorText = "";
                }


                private void BotonUnidad_Click(object sender, EventArgs e)
                {
                        Rendimiento FormRend = new Rendimiento();
                        FormRend.EntradaUnidad.TextKey = EntradaUnidad.TextKey;
                        FormRend.EntradaRendimiento.ValueDecimal = Rendimiento;
                        FormRend.EntradaUnidadRend.TextKey = UnidadRendimiento;
                        if (FormRend.ShowDialog() == DialogResult.OK) {
                                EntradaUnidad.TextKey = FormRend.EntradaUnidad.TextKey;
                                Rendimiento = FormRend.EntradaRendimiento.ValueDecimal;
                                UnidadRendimiento = FormRend.EntradaUnidadRend.TextKey;
                        }
                }

                private void EntradaPvp_Enter(object sender, EventArgs e)
                {
                        if (EntradaUnidad.TextKey.Length > 0 && UnidadRendimiento != null && UnidadRendimiento.Length > 0) {
                                // TODO: EntradaPvp.ShowBalloon("En " + EntradaUnidad.TextKey + " de " + Rendimiento.ToString() + " " + UnidadRendimiento + " a razón de " + Lbl.Sys.Config.Moneda.Simbolo + Lfx.Types.Formatting.FormatCurrency(EntradaPvp.ValueDecimal / Rendimiento, Lfx.Workspace.Master.CurrentConfig.Moneda.Decimales) + " (PVP) el " + UnidadRendimiento + ".");
                        }
                }

                public override void ActualizarControl()
                {
                        Lbl.Articulos.Articulo Art = this.Elemento as Lbl.Articulos.Articulo;

                        EntradaCodigo1.Text = Art.Codigo1;
                        EntradaCodigo2.Text = Art.Codigo2;
                        EntradaCodigo3.Text = Art.Codigo3;
                        EntradaCodigo4.Text = Art.Codigo4;
                        EntradaCategoria.Elemento = Art.Categoria;
                        EntradaMarca.Elemento = Art.Marca;
                        EntradaCaja.Elemento = Art.Caja;
                        EntradaModelo.Text = Art.Modelo;
                        EntradaSerie.Text = Art.Serie;
                        EntradaNombre.Text = Art.Nombre;
                        EntradaUrl.Text = Art.Url;
                        EntradaProveedor.Elemento = Art.Proveedor;
                        EntradaDescripcion.Text = Art.Descripcion;
                        EntradaDescripcion2.Text = Art.Descripcion2;
                        EntradaDestacado.ValueInt = Art.Destacado ? 1 : 0;
                        EntradaWeb.ValueInt = ((int)(Art.Publicacion));

                        IgnorarCostoTextChanged++;
                        EntradaCosto.Text = Lfx.Types.Formatting.FormatCurrency(Art.Costo, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto);
                        if (Art.Margen == null) {
                                EntradaMargen.TextKey = "";
                                EntradaMargen.Text = "Otro";
                        } else {
                                EntradaMargen.TextKey = Art.Margen.Id.ToString();
                        }
                        EntradaPvp.Text = Lfx.Types.Formatting.FormatCurrency(Art.Pvp, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto);

                        IgnorarCostoTextChanged--;

                        EntradaUsaStock.ValueInt = (int)(Art.TipoDeArticulo);
                        EntradaSeguimiento.ValueInt = (int)(Art.Seguimiento);
                        EntradaSeguimiento.ReadOnly = Art.Existe && Art.Existencias != 0;
                        EntradaStockActual.Text = Lfx.Types.Formatting.FormatNumber(Art.Existencias, Lbl.Sys.Config.Articulos.Decimales);
                        EntradaStockActual.ReadOnly = Art.Existe;
                        EntradaUnidad.TextKey = Art.Unidad;
                        Rendimiento = Art.Rendimiento;
                        UnidadRendimiento = Art.UnidadRendimiento;
                        EntradaStockMinimo.Text = Lfx.Types.Formatting.FormatNumber(Art.PuntoDeReposicion, Lbl.Sys.Config.Articulos.Decimales);
                        EntradaGarantia.Text = Art.Garantia.ToString();
                        CustomName = Art.Existe;

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Articulos.Articulo Art = this.Elemento as Lbl.Articulos.Articulo;

                        Art.Codigo1 = EntradaCodigo1.Text;
                        Art.Codigo2 = EntradaCodigo2.Text;
                        Art.Codigo3 = EntradaCodigo3.Text;
                        Art.Codigo4 = EntradaCodigo4.Text;
                        Art.Categoria = EntradaCategoria.Elemento as Lbl.Articulos.Categoria;
                        Art.Marca = EntradaMarca.Elemento as Lbl.Articulos.Marca;
                        Art.Caja = EntradaCaja.Elemento as Lbl.Cajas.Caja;
                        Art.Modelo = EntradaModelo.Text;
                        Art.Serie = EntradaSerie.Text;
                        Art.Nombre = EntradaNombre.Text;
                        Art.Url = EntradaUrl.Text;
                        Art.Proveedor = EntradaProveedor.Elemento as Lbl.Personas.Persona;
                        Art.Descripcion = EntradaDescripcion.Text;
                        Art.Descripcion2 = EntradaDescripcion2.Text;
                        Art.Destacado = Lfx.Types.Parsing.ParseInt(EntradaDestacado.TextKey) != 0;
                        Art.Costo = Lfx.Types.Parsing.ParseCurrency(EntradaCosto.Text);

                        if (Lfx.Types.Parsing.ParseInt(EntradaMargen.TextKey) > 0)
                                Art.Margen = new Lbl.Articulos.Margen(Art.Connection, EntradaMargen.ValueInt);
                        else
                                Art.Margen = null;

                        Art.Pvp = Lfx.Types.Parsing.ParseCurrency(EntradaPvp.Text);
                        Art.TipoDeArticulo = (Lbl.Articulos.TiposDeArticulo)(EntradaUsaStock.ValueInt);
                        Art.Seguimiento = (Lbl.Articulos.Seguimientos)(EntradaSeguimiento.ValueInt);
                        Art.PuntoDeReposicion = Lfx.Types.Parsing.ParseStock(EntradaStockMinimo.Text);
                        Art.Unidad = EntradaUnidad.TextKey;
                        Art.Rendimiento = Rendimiento;
                        Art.UnidadRendimiento = UnidadRendimiento;
                        Art.Estado = 1;
                        Art.Garantia = Lfx.Types.Parsing.ParseInt(EntradaGarantia.Text);
                        Art.Publicacion = ((Lbl.Articulos.Publicacion)(EntradaWeb.ValueInt));
                        if (Art.Existe == false)
                                Art.ExistenciasInicial = EntradaStockActual.ValueDecimal;

                        Lbl.Articulos.Seguimientos Seg = Art.ObtenerSeguimiento();
                        if (Seg != Lbl.Articulos.Seguimientos.Ninguno) {
                                // Verificar que los datos de seguimiento actual coincidan con el stock actual
                        }

                        base.ActualizarElemento();
                }


                private void EntradaUsaStock_TextChanged(object sender, EventArgs e)
                {
                        BotonReceta.Visible = EntradaUsaStock.TextKey == "2";
                        EntradaCosto.Enabled = EntradaUsaStock.TextKey != "2";
                        this.ActualizarCostoYStockSegunReceta();
                }

                private void BotonReceta_Click(object sender, EventArgs e)
                {
                        if (EntradaUsaStock.TextKey == "2") {
                                Lbl.Articulos.Articulo Art = this.Elemento as Lbl.Articulos.Articulo;
                                Receta FormReceta = new Receta();
                                FormReceta.ReadOnly = this.TemporaryReadOnly;
                                FormReceta.Articulo = Art;
                                if (FormReceta.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                                        this.Changed = true;
                                        this.ActualizarCostoYStockSegunReceta();
                                }
                        }
                }

                private void ActualizarCostoYStockSegunReceta()
                {
                        Lbl.Articulos.Articulo Art = this.Elemento as Lbl.Articulos.Articulo;

                        if (EntradaUsaStock.TextKey == "2") {
                                if (Art.Receta == null)
                                        EntradaCosto.Text = "0";
                                else
                                        EntradaCosto.Text = Lfx.Types.Formatting.FormatCurrency(Art.Receta.Costo, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto);

                                EntradaStockActual.Text = Lfx.Types.Formatting.FormatStock(Art.ObtenerExistencias());
                        }
                }

                protected override void OnLoad(EventArgs e)
                {
                        base.OnLoad(e);
                        if (this.Connection != null) {
                                EntradaStockActual.DecimalPlaces = Lbl.Sys.Config.Articulos.Decimales;
                                EntradaStockMinimo.DecimalPlaces = Lbl.Sys.Config.Articulos.Decimales;
                                EntradaCosto.DecimalPlaces = Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto;
                                EntradaPvp.DecimalPlaces = Lfx.Workspace.Master.CurrentConfig.Moneda.Decimales;

                                Lfx.Data.Row Nombre = null;

                                Nombre = this.Connection.Tables["articulos_codigos"].FastRows[1];
                                if (Nombre != null)
                                        EtiquetaCodigo1.Text = Nombre["nombre"].ToString();

                                Nombre = this.Connection.Tables["articulos_codigos"].FastRows[2];
                                if (Nombre != null)
                                        EtiquetaCodigo2.Text = Nombre["nombre"].ToString();

                                Nombre = this.Connection.Tables["articulos_codigos"].FastRows[3];
                                if (Nombre != null)
                                        EtiquetaCodigo3.Text = Nombre["nombre"].ToString();

                                Nombre = this.Connection.Tables["articulos_codigos"].FastRows[4];
                                if (Nombre != null)
                                        EtiquetaCodigo4.Text = Nombre["nombre"].ToString();

                                Lfx.Data.Table TablaMargenes = this.Connection.Tables["margenes"];
                                TablaMargenes.PreLoad();
                                int i = 0;
                                string[] ListaMargenes = new string[TablaMargenes.FastRows.Count + 1];

                                foreach (Lfx.Data.Row Margen in TablaMargenes.FastRows.Values) {
                                        ListaMargenes[i] = System.Convert.ToString(Margen["nombre"]) + " (" + Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Margen["porcentaje"]) + System.Convert.ToDouble(Margen["porcentaje2"]) + System.Convert.ToDouble(Margen["porcentaje3"]), 2) + "%)|" + System.Convert.ToInt32(Margen["id_margen"]);
                                        i++;
                                }

                                ListaMargenes[i] = "Otro|0";
                                EntradaMargen.SetData = ListaMargenes;
                        }
                }

                private void VerHistorial()
                {
                        Articulos.VerMovimientos FormularioDetalles = new Articulos.VerMovimientos();
                        FormularioDetalles.MdiParent = this.ParentForm.MdiParent;
                        FormularioDetalles.Mostrar(this.Elemento as Lbl.Articulos.Articulo);
                        FormularioDetalles.Show();
                }

                private void VerConformacion()
                {
                        Articulos.VerConformacion FormularioDetalles = new Articulos.VerConformacion();
                        FormularioDetalles.MdiParent = this.ParentForm.MdiParent;
                        FormularioDetalles.Mostrar(this.Elemento as Lbl.Articulos.Articulo);
                        FormularioDetalles.Show();
                }

                private void EntradaSeguimiento_TextChanged(object sender, EventArgs e)
                {
                        Lbl.Articulos.Seguimientos Seg = (Lbl.Articulos.Seguimientos)(EntradaSeguimiento.ValueInt);
                        if (Seg == Lbl.Articulos.Seguimientos.Predeterminado) {
                                Lbl.Articulos.Categoria Cat = EntradaCategoria.Elemento as Lbl.Articulos.Categoria;
                                if (Cat != null)
                                        Seg = Cat.ObtenerSeguimiento();
                        }

                        EntradaStockActual.ReadOnly = Seg == Lbl.Articulos.Seguimientos.Ninguno;
                        if(EntradaStockActual.ReadOnly) {
                                // El stock no editable
                                if (this.Elemento.Existe)
                                        // Para artículos existentes, muestro el stock actual real
                                        EntradaStockActual.ValueDecimal = this.Connection.FieldDecimal("SELECT stock_actual FROM articulos WHERE id_articulo=" + this.Elemento.Id.ToString());
                                else
                                        // Para artículos nuevos, muestro cero
                                        EntradaStockActual.ValueDecimal = 0;
                        }
                }


                public override Lazaro.Pres.Forms.FormActionCollection GetFormActions()
                {
                        Lazaro.Pres.Forms.FormActionCollection Res = base.GetFormActions();
                        if (this.Elemento != null && this.Elemento.Existe) {
                                Res.Add(new Lazaro.Pres.Forms.FormAction("Historial", "F7", "historial", 20, Lazaro.Pres.Forms.FormActionVisibility.Secondary));
                                Res.Add(new Lazaro.Pres.Forms.FormAction("Conformación", "F5", "conformacion", 10, Lazaro.Pres.Forms.FormActionVisibility.Secondary));
                        }
                        return Res;
                }


                public override Lfx.Types.OperationResult PerformFormAction(string name)
                {
                        switch (name) {
                                case "historial":
                                        VerHistorial();
                                        return new Lfx.Types.SuccessOperationResult();
                                case "conformacion":
                                        VerConformacion();
                                        return new Lfx.Types.SuccessOperationResult();
                                default:
                                        return base.PerformFormAction(name);
                        }
                }


                public override Lazaro.Pres.DisplayStyles.IDisplayStyle HeaderDisplayStyle
                {
                        get
                        {
                                return Lazaro.Pres.DisplayStyles.Template.Current.Articulos;
                        }
                }
        }
}