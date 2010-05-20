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
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Lfc.Articulos
{
        public partial class Editar : Lui.Forms.EditForm
        {
                private bool CustomName = false;
                private double Rendimiento;
                private string UnidadRendimiento = "";
                private int IgnorarCostoTextChanged;


                public Editar()
                        : base()
                {
                        InitializeComponent();
                }

                public override Lfx.Types.OperationResult Create()
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "products.create"))
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Articulos.Articulo Articulo = new Lbl.Articulos.Articulo(this.DataView);
                        Articulo.Crear();
                        Articulo.Tipo = Lbl.Articulos.Tipos.Regular;
                        EntradaTags.Elemento = Articulo;

                        this.FromRow(Articulo);
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override Lui.Printing.ItemPrint FormatForPrinting(Lui.Printing.ItemPrint ImprimirItem)
                {
                        ImprimirItem.Titulo = EntradaNombre.Text;
                        ImprimirItem.Imagen = EntradaImagen.Elemento.Imagen;
                        ImprimirItem.ParesAgregar(EtiquetaCodigo1.Text, EntradaCodigo1.Text, 1);
                        ImprimirItem.ParesAgregar(EtiquetaCodigo2.Text, EntradaCodigo2.Text, 1);
                        ImprimirItem.ParesAgregar(EtiquetaCodigo3.Text, EntradaCodigo3.Text, 1);
                        ImprimirItem.ParesAgregar(EtiquetaCodigo4.Text, EntradaCodigo4.Text, 1);
                        ImprimirItem.ParesAgregar("Rubro", EntradaCategoria.TextDetail, 1);
                        ImprimirItem.ParesAgregar("Marca", EntradaMarca.TextDetail, 1);
                        ImprimirItem.ParesAgregar("Modelo", EntradaModelo.Text, 1);
                        ImprimirItem.ParesAgregar("Serie", EntradaSerie.Text, 1);
                        ImprimirItem.ParesAgregar("Nombre Completo", EntradaNombre.Text, 1);

                        if (EntradaUrl.Text.Length > 0)
                                ImprimirItem.ParesAgregar("URL", EntradaUrl.Text, 1);

                        ImprimirItem.ParesAgregar("Proveedor", EntradaProveedor.TextDetail, 1);

                        if (EntradaDescripcion.Text.Length > 0)
                                ImprimirItem.ParesAgregar("Descripción", EntradaDescripcion.Text, 1);

                        ImprimirItem.ParesAgregar("Costo", Lfx.Types.Currency.CurrencySymbol + " " + EntradaCosto.Text, 1);
                        ImprimirItem.ParesAgregar("PVP", Lfx.Types.Currency.CurrencySymbol + " " + EntradaPvp.Text, 1);
                        ImprimirItem.ParesAgregar("Margen", EntradaMargen.Text, 1);
                        ImprimirItem.ParesAgregar("Usa Stock", EntradaUsaStock.Text, 1);

                        if (Lfx.Types.Parsing.ParseInt(EntradaUsaStock.TextKey) != 0) {
                                ImprimirItem.ParesAgregar("Stock Actual", EntradaStockActual.Text, 1);
                                ImprimirItem.ParesAgregar("Stock Mínimo", EntradaStockMinimo.Text, 1);
                        }

                        return ImprimirItem;
                }

                public override Lfx.Types.OperationResult Edit(int lId)
                {
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "products.read") == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        CustomName = true;

                        Lbl.Articulos.Articulo Articulo = new Lbl.Articulos.Articulo(this.DataView, lId);

                        if (Articulo.Cargar().Success == false) {
                                return new Lfx.Types.FailureOperationResult("Error al cargar el registro");
                        } else {
                                this.FromRow(Articulo);
                                return new Lfx.Types.SuccessOperationResult();
                        }
                }

                private void txtCategoriaMarcaModeloSerie_TextChanged(System.Object sender, System.EventArgs e)
                {
                        if (CustomName == false) {
                                string NombreSing = this.Workspace.DefaultDataBase.FieldString("SELECT nombresing FROM articulos_categorias WHERE id_categoria=" + EntradaCategoria.TextInt.ToString());
                                string Texto = (NombreSing + " " + EntradaMarca.TextDetail + " " + EntradaModelo.Text + " " + EntradaSerie.Text).Trim();
                                EntradaNombre.Text = Texto;
                        }
                }

                private void txtNombre_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                        CustomName = true;
                }

                private void FormArticulosEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.F1:
                                        e.Handled = true;
                                        if (BotonInfoCosto.Enabled && BotonInfoCosto.Visible)
                                                BotonInfoCosto.PerformClick();
                                        break;

                                case Keys.F7:
                                        e.Handled = true;
                                        if (cmdDescripcion.Enabled && cmdDescripcion.Visible)
                                                cmdDescripcion.PerformClick();
                                        break;
                        }
                }

                private void cmdInfo_Click(object sender, System.EventArgs e)
                {
                        Articulos.MasInfo OInfo = new Articulos.MasInfo();
                        OInfo.Articulo = m_Id;

                        if (OInfo.ShowDialog() == DialogResult.OK) {
                                // Guardar algo si fuera editable
                        }
                }

                private void txtCostoMargen_TextChanged(System.Object sender, System.EventArgs e)
                {
                        if (this.Workspace == null)
                                return;

                        if (Lfx.Types.Parsing.ParseCurrency(EntradaCosto.Text) < 0)
                                EntradaCosto.ErrorText = "El costo no debería ser menor que cero.";
                        else
                                EntradaCosto.ErrorText = "";

                        if (IgnorarCostoTextChanged <= 0) {
                                if (Lfx.Types.Strings.IsNumericInt(EntradaMargen.TextKey)) {
                                        Lfx.Data.Row Margen = this.DataView.Tables["margenes"].FastRows[Lfx.Types.Parsing.ParseInt(EntradaMargen.TextKey)];

                                        if (Margen != null) {
                                                double dPVP = Lfx.Types.Parsing.ParseCurrency(EntradaCosto.Text);
                                                dPVP += System.Convert.ToDouble(Margen["sumar"]);
                                                double MargenCompleto = System.Convert.ToDouble(Margen["porcentaje"]) + System.Convert.ToDouble(Margen["porcentaje2"]) + System.Convert.ToDouble(Margen["porcentaje3"]);
                                                dPVP *= (1 + MargenCompleto / 100);
                                                dPVP += System.Convert.ToDouble(Margen["sumar2"]);
                                                IgnorarCostoTextChanged++;
                                                EntradaPvp.Text = Lfx.Types.Formatting.FormatCurrency(dPVP, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto);
                                                IgnorarCostoTextChanged--;
                                        }
                                } else {
                                        IgnorarCostoTextChanged++;
                                        txtPVP_TextChanged(sender, e);
                                        IgnorarCostoTextChanged--;
                                }
                        }
                }

                private void txtPVP_TextChanged(object sender, System.EventArgs e)
                {
                        if (IgnorarCostoTextChanged <= 0) {
                                IgnorarCostoTextChanged++;
                                EntradaMargen.TextKey = "";

                                if (Lfx.Types.Parsing.ParseCurrency(EntradaCosto.Text) == 0)
                                        EntradaMargen.Text = "N/A";
                                else
                                        EntradaMargen.Text = "Otro (" + Lfx.Types.Formatting.FormatNumber(Lfx.Types.Parsing.ParseCurrency(EntradaPvp.Text) / Lfx.Types.Parsing.ParseCurrency(EntradaCosto.Text) * 100 - 100, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + "%)";

                                IgnorarCostoTextChanged--;
                        }
                }

                public override Lfx.Types.OperationResult ValidateData()
                {
                        Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();

                        if (EntradaNombre.Text.Length < 2) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Por favor escriba el nombre del artículo." + Environment.NewLine;
                        }

                        if (EntradaCodigo1.Text.Length > 0) {
                                Lfx.Data.Row Articulo = this.Workspace.DefaultDataBase.FirstRowFromSelect("SELECT id_articulo FROM articulos WHERE codigo1='" + EntradaCodigo1.Text + "' AND id_articulo<>" + m_Id.ToString());

                                if (Articulo != null) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "Ya existe un artículo con el mismo código (" + EtiquetaCodigo1.Text + " " + EntradaCodigo1.Text + ") en la base de datos." + Environment.NewLine;
                                }
                        }

                        if (EntradaCodigo2.Text.Length > 0) {
                                Lfx.Data.Row Articulo = this.Workspace.DefaultDataBase.FirstRowFromSelect("SELECT id_articulo FROM articulos WHERE codigo2='" + EntradaCodigo2.Text + "' AND id_articulo<>" + m_Id.ToString());

                                if (Articulo != null) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "Ya existe un artículo con el mismo código (" + EtiquetaCodigo2.Text + " " + EntradaCodigo2.Text + ") en la base de datos." + Environment.NewLine;
                                }
                        }

                        if (EntradaCodigo3.Text.Length > 0) {
                                Lfx.Data.Row Articulo = this.Workspace.DefaultDataBase.FirstRowFromSelect("SELECT id_articulo FROM articulos WHERE codigo3='" + EntradaCodigo3.Text + "' AND id_articulo<>" + m_Id.ToString());

                                if (Articulo != null) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "Ya existe un artículo con el mismo código (" + EtiquetaCodigo3.Text + " " + EntradaCodigo3.Text + ") en la base de datos." + Environment.NewLine;
                                }
                        }

                        if (EntradaCodigo4.Text.Length > 0) {
                                Lfx.Data.Row Articulo = this.Workspace.DefaultDataBase.FirstRowFromSelect("SELECT id_articulo FROM articulos WHERE codigo4='" + EntradaCodigo4.Text + "' AND id_articulo<>" + m_Id.ToString());

                                if (Articulo != null) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "Ya existe un artículo con el mismo código (" + EtiquetaCodigo4.Text + " " + EntradaCodigo4.Text + ") en la base de datos." + Environment.NewLine;
                                }
                        }

                        return validarReturn;
                }

                private void cmdArticulosMovimDetalles_GotFocus(object sender, System.EventArgs e)
                {
                        if (m_Id > 0 && this.Workspace.CurrentConfig.Products.StockMultideposito) {
                                DataTable Stocks = this.Workspace.DefaultDataBase.Select("SELECT id_articulo, id_situacion, cantidad FROM articulos_stock WHERE id_articulo=" + m_Id.ToString() + " AND cantidad<>0 AND id_situacion<>998 AND id_situacion<>999 ORDER BY id_situacion");

                                if (Stocks != null) {
                                        System.Text.StringBuilder Resultado = new System.Text.StringBuilder();

                                        foreach (System.Data.DataRow Stock in Stocks.Rows) {
                                                Lfx.Data.Row Situacion = this.Workspace.DefaultDataBase.Row("articulos_situaciones", "id_situacion", System.Convert.ToInt32(Stock["id_situacion"]));
                                                Resultado.Append(System.Convert.ToString(Situacion["nombre"]));

                                                if (System.Convert.ToInt32(Situacion["cuenta_stock"]) == 0)
                                                        Resultado.Append(" (N.C.S.)");

                                                Resultado.Append(": " + Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Stock["cantidad"]), this.Workspace.CurrentConfig.Products.StockDecimalPlaces) + Environment.NewLine);
                                        }

                                        if (Resultado.Length > 0) {
                                                string ResultadoString = Resultado.ToString();
                                                ResultadoString = ResultadoString.Substring(0, ResultadoString.Length - 2);
                                                BotonArticuloVerMovimientos.ShowBalloon(ResultadoString, "Conformación del Stock", 60);
                                        }
                                }
                        }
                }

                private void txtCosto_GotFocus(object sender, System.EventArgs e)
                {
                        if (m_Id > 0) {
                                string Res = "";

                                double PrecioUltComp = this.Workspace.DefaultDataBase.FieldDouble("SELECT comprob_detalle.precio FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.tipo_fac IN ('R', 'FA', 'FB', 'FC', 'FE', 'FM') AND comprob.compra=1 AND id_articulo=" + m_Id.ToString() + " GROUP BY comprob.id_comprob ORDER BY comprob_detalle.id_comprob_detalle DESC");
                                double PrecioUltFlete = this.Workspace.DefaultDataBase.FieldDouble("SELECT (comprob.gastosenvio+comprob.otrosgastos)*(comprob_detalle.precio/comprob.total) FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.tipo_fac IN ('R', 'FA', 'FB', 'FC', 'FE', 'FM') AND comprob.compra=1 AND id_articulo=" + m_Id.ToString() + " GROUP BY comprob.id_comprob ORDER BY comprob_detalle.id_comprob_detalle DESC");
                                Res += "Costo de la última compra (sin gastos): " + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(PrecioUltComp, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + Environment.NewLine;
                                Res += "Costo de la última compra (con gastos): " + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(PrecioUltComp + PrecioUltFlete, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + Environment.NewLine;

                                // Podra hacer esto con una subconsulta, pero la versión de MySql que estamos utilizando
                                // no permite la cláusula LIMIT dentro de una subconsulta IN ()
                                double PrecioUlt5Comps = 0;
                                System.Data.DataTable UltimasCompras = this.Workspace.DefaultDataBase.Select("SELECT comprob_detalle.precio, comprob.id_comprob FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.compra=1 AND comprob.tipo_fac IN ('R', 'FA', 'FB', 'FC', 'FE', 'FM') AND comprob.compra=1 AND comprob_detalle.id_articulo=" + m_Id.ToString() + " ORDER BY comprob.fecha DESC LIMIT 5");

                                if (UltimasCompras.Rows.Count > 0) {
                                        foreach (System.Data.DataRow Compra in UltimasCompras.Rows) {
                                                PrecioUlt5Comps += System.Convert.ToDouble(Compra["precio"]);
                                        }

                                        PrecioUlt5Comps = PrecioUlt5Comps / UltimasCompras.Rows.Count;
                                        Res += "Promedio de las últimas " + UltimasCompras.Rows.Count.ToString() + " compras (sin gastos): " + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(PrecioUlt5Comps, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto);
                                }

                                EntradaCosto.ShowBalloon(Res, "Precio de Compra", 60);
                        }
                }

                private void txtStockActual_TextChanged(object sender, System.EventArgs e)
                {
                        if (Lfx.Types.Parsing.ParseStock(EntradaStockActual.Text) < Lfx.Types.Parsing.ParseStock(EntradaStockMinimo.Text))
                                EntradaStockActual.ErrorText = "El stock actual está por debajo del mínimo.";
                        else
                                EntradaStockActual.ErrorText = "";
                }

                private void cmdDescripcion_Click(object sender, System.EventArgs e)
                {
                        Lui.Forms.AuxForms.TextEdit OFormObservacionesEditar = new Lui.Forms.AuxForms.TextEdit();
                        OFormObservacionesEditar.EditText = EntradaDescripcion2.Text;
                        OFormObservacionesEditar.ReadOnly = !SaveButton.Visible;
                        OFormObservacionesEditar.Text = "Descripción Extendida";

                        if (OFormObservacionesEditar.ShowDialog() == DialogResult.OK)
                                EntradaDescripcion2.Text = OFormObservacionesEditar.EditText;
                }

                private void txtNombre_TextChanged(object sender, System.EventArgs e)
                {
                        if (EntradaNombre.Text.Length > 0)
                                EntradaNombre.ErrorText = null;
                        else
                                EntradaNombre.ErrorText = "Debe escribir un nombre para el artículo.";
                }

                private void FormArticulosEditar_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        EntradaStockActual.DecimalPlaces = this.Workspace.CurrentConfig.Products.StockDecimalPlaces;
                        EntradaStockMinimo.DecimalPlaces = this.Workspace.CurrentConfig.Products.StockDecimalPlaces;
                        EntradaCosto.DecimalPlaces = this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto;
                        EntradaPvp.DecimalPlaces = this.Workspace.CurrentConfig.Currency.DecimalPlaces;

                        Lfx.Data.Row Nombre = null;

                        Nombre = this.Workspace.DefaultDataView.Tables["articulos_codigos"].FastRows[1];
                        if (Nombre != null)
                                EtiquetaCodigo1.Text = Nombre["nombre"].ToString();

                        Nombre = this.Workspace.DefaultDataView.Tables["articulos_codigos"].FastRows[2];
                        if (Nombre != null)
                                EtiquetaCodigo2.Text = Nombre["nombre"].ToString();

                        Nombre = this.Workspace.DefaultDataView.Tables["articulos_codigos"].FastRows[3];
                        if (Nombre != null)
                                EtiquetaCodigo3.Text = Nombre["nombre"].ToString();

                        Nombre = this.Workspace.DefaultDataView.Tables["articulos_codigos"].FastRows[4];
                        if (Nombre != null)
                                EtiquetaCodigo4.Text = Nombre["nombre"].ToString();

                        Lws.Data.Table TablaMargenes = this.Workspace.DefaultDataView.Tables["margenes"];
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

                private void cmdUnidad_Click(object sender, EventArgs e)
                {
                        Rendimiento FormRend = new Rendimiento();
                        FormRend.txtUnidad.TextKey = EntradaUnidad.TextKey;
                        FormRend.txtRendimiento.Text = Lfx.Types.Formatting.FormatNumber(Rendimiento);
                        FormRend.txtUnidadRend.TextKey = UnidadRendimiento;
                        if (FormRend.ShowDialog() == DialogResult.OK) {
                                EntradaUnidad.TextKey = FormRend.txtUnidad.TextKey;
                                Rendimiento = Lfx.Types.Parsing.ParseDouble(FormRend.txtRendimiento.Text);
                                UnidadRendimiento = FormRend.txtUnidadRend.TextKey;
                        }
                }

                private void txtPVP_Enter(object sender, EventArgs e)
                {
                        if (EntradaUnidad.TextKey.Length > 0 && UnidadRendimiento.Length > 0) {
                                EntradaPvp.ShowBalloon("En " + EntradaUnidad.TextKey + " de " + Lfx.Types.Formatting.FormatNumber(Rendimiento) + " " + UnidadRendimiento + " a razón de " + Lfx.Types.Currency.CurrencySymbol + Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(EntradaPvp.Text) / Rendimiento, this.Workspace.CurrentConfig.Currency.DecimalPlaces) + " (PVP) el " + UnidadRendimiento + ".");
                        }
                }

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Articulos.Articulo Item = row as Lbl.Articulos.Articulo;

                        EntradaCodigo1.Text = Item.Codigo1;
                        EntradaCodigo2.Text = Item.Codigo2;
                        EntradaCodigo3.Text = Item.Codigo3;
                        EntradaCodigo4.Text = Item.Codigo4;
                        if (Item.Categoria == null)
                                EntradaCategoria.TextInt = 0;
                        else
                                EntradaCategoria.TextInt = Item.Categoria.Id;
                        if (Item.Marca == null)
                                EntradaMarca.TextInt = 0;
                        else
                                EntradaMarca.TextInt = Item.Marca.Id;

                        if (Item.Caja == null)
                                EntradaCaja.TextInt = 0;
                        else
                                EntradaCaja.TextInt = Item.Caja.Id;

                        EntradaModelo.Text = Item.Modelo;
                        EntradaSerie.Text = Item.Serie;
                        EntradaNombre.Text = Item.Nombre;
                        EntradaUrl.Text = Item.Url;
                        if (Item.Proveedor == null)
                                EntradaProveedor.TextInt = 0;
                        else
                                EntradaProveedor.TextInt = Item.Proveedor.Id;
                        EntradaDescripcion.Text = Item.Descripcion;
                        EntradaDescripcion2.Text = Item.Descripcion2;
                        EntradaDestacado.TextKey = Item.Destacado ? "1" : "0";
                        EntradaWeb.TextKey = System.Convert.ToInt32(Item.Destacado).ToString();

                        IgnorarCostoTextChanged++;
                        EntradaCosto.Text = Lfx.Types.Formatting.FormatCurrency(Item.Costo, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto);
                        if (Item.Margen == null) {
                                EntradaMargen.TextKey = "";
                                EntradaMargen.Text = "Otro";
                        } else {
                                EntradaMargen.TextKey = Item.Margen.Id.ToString();
                        }
                        EntradaPvp.Text = Lfx.Types.Formatting.FormatCurrency(Item.PVP, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto);

                        IgnorarCostoTextChanged--;

                        EntradaUsaStock.TextKey = Item.ControlaStock ? "1" : "0";
                        EntradaStockActual.Text = Lfx.Types.Formatting.FormatNumber(Item.StockActual(), this.Workspace.CurrentConfig.Products.StockDecimalPlaces);
                        EntradaUnidad.TextKey = Item.Unidad;
                        Rendimiento = Item.Rendimiento;
                        UnidadRendimiento = Item.UnidadRendimiento;
                        EntradaStockMinimo.Text = Lfx.Types.Formatting.FormatNumber(Item.StockMinimo, this.Workspace.CurrentConfig.Products.StockDecimalPlaces);
                        EntradaGarantia.Text = Item.Garantia.ToString();
                        EntradaImagen.Elemento = Item;
                        EntradaTags.Elemento = Item;
                        EntradaEtiquetas.Elemento = Item;

                        SaveButton.Visible = Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "products.write");

                        if (this.CachedRow.Existe)
                                this.Text = "Artículos: " + Item.Nombre;
                        else
                                this.Text = "Artículos: Nuevo";
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Articulos.Articulo Item = this.CachedRow as Lbl.Articulos.Articulo;

                        Item.Codigo1 = EntradaCodigo1.Text;
                        Item.Codigo2 = EntradaCodigo2.Text;
                        Item.Codigo3 = EntradaCodigo3.Text;
                        Item.Codigo4 = EntradaCodigo4.Text;
                        if (EntradaCategoria.TextInt != 0)
                                Item.Categoria = new Lbl.Articulos.Categoria(Item.DataView, EntradaCategoria.TextInt);
                        else
                                Item.Categoria = null;
                        if (EntradaMarca.TextInt != 0)
                                Item.Marca = new Lbl.Articulos.Marca(Item.DataView, EntradaMarca.TextInt);
                        else
                                Item.Marca = null;
                        if (EntradaCaja.TextInt != 0)
                                Item.Caja = new Lbl.Cajas.Caja(Item.DataView, EntradaCaja.TextInt);
                        else
                                Item.Caja = null;

                        Item.Modelo = EntradaModelo.Text;
                        Item.Serie = EntradaSerie.Text;
                        Item.Nombre = EntradaNombre.Text;
                        Item.Url = EntradaUrl.Text;
                        if (EntradaProveedor.TextInt != 0)
                                Item.Proveedor = new Lbl.Personas.Persona(Item.DataView, EntradaProveedor.TextInt);
                        else
                                Item.Proveedor = null;
                        Item.Descripcion = EntradaDescripcion.Text;
                        Item.Descripcion2 = EntradaDescripcion2.Text;
                        Item.Destacado = Lfx.Types.Parsing.ParseInt(EntradaDestacado.TextKey) != 0;
                        Item.Costo = Lfx.Types.Parsing.ParseCurrency(EntradaCosto.Text);

                        if (Lfx.Types.Parsing.ParseInt(EntradaMargen.TextKey) != 0)
                                Item.Margen = new Lbl.Articulos.Margen(Item.DataView, Lfx.Types.Parsing.ParseInt(EntradaMargen.TextKey));
                        else
                                Item.Margen = null;

                        Item.PVP = Lfx.Types.Parsing.ParseCurrency(EntradaPvp.Text);
                        Item.ControlaStock = Lfx.Types.Parsing.ParseInt(EntradaUsaStock.TextKey) != 0;
                        Item.StockMinimo = Lfx.Types.Parsing.ParseStock(EntradaStockMinimo.Text);
                        Item.Unidad = EntradaUnidad.TextKey;
                        Item.Rendimiento = Rendimiento;
                        Item.UnidadRendimiento = UnidadRendimiento;
                        Item.Estado = 1;
                        Item.Garantia = Lfx.Types.Parsing.ParseInt(EntradaGarantia.Text);
                        Item.Publicacion = ((Lbl.Articulos.Publicacion)Lfx.Types.Parsing.ParseInt(EntradaWeb.TextKey));
                        EntradaTags.ActualizarElemento();
                        EntradaImagen.ActualizarElemento();

                        return base.ToRow();
                }


                private void BotonArticuloVerMovimientos_Click(object sender, System.EventArgs e)
                {
                        Articulos.VerMovimientos FormularioDetalles = new Articulos.VerMovimientos();
                        FormularioDetalles.MdiParent = this.MdiParent;
                        FormularioDetalles.Mostrar(this.CachedRow as Lbl.Articulos.Articulo);
                        FormularioDetalles.Show();
                }

                private void BotonArticuloVerConformación_Click(object sender, EventArgs e)
                {
                        Articulos.VerConformacion FormularioDetalles = new Articulos.VerConformacion();
                        FormularioDetalles.MdiParent = this.MdiParent;
                        FormularioDetalles.Mostrar(this.CachedRow as Lbl.Articulos.Articulo);
                        FormularioDetalles.Show();
                }
        }
}