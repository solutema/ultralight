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
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace Lcc.Entrada.Articulos
{
        public partial class DetalleComprobante : ControlSeleccionElemento
        {

                protected bool m_ShowStock;
                protected Precios m_Precio = Precios.Pvp;
                protected ControlesSock m_ControlStock = ControlesSock.Ambos;
                protected string m_Serials = "";

                new public event System.EventHandler TextChanged;
                new public event System.Windows.Forms.KeyEventHandler KeyDown;
                public event System.EventHandler PrecioCantidadChanged;
                public event System.EventHandler AskForSerials;

                public DetalleComprobante()
                {
                        InitializeComponent();

                        this.ElementType = typeof(Lbl.Articulos.Articulo);

                        if (this.Workspace != null) {
                                switch (m_Precio) {
                                        case Precios.Costo:
                                                EntradaUnitario.DecimalPlaces = this.Workspace.CurrentConfig.Moneda.DecimalesCosto;
                                                EntradaImporte.DecimalPlaces = this.Workspace.CurrentConfig.Moneda.DecimalesCosto;
                                                break;
                                        case Precios.Pvp:
                                                EntradaUnitario.DecimalPlaces = this.Workspace.CurrentConfig.Moneda.Decimales;
                                                EntradaImporte.DecimalPlaces = this.Workspace.CurrentConfig.Moneda.Decimales;
                                                break;
                                }
                        }

                }

                public ControlesSock ControlStock
                {
                        get
                        {
                                return m_ControlStock;
                        }
                        set
                        {
                                m_ControlStock = value;
                                PonerFiltros();
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                override public bool ShowChanged
                {
                        set
                        {
                                base.ShowChanged = value;
                                EntradaArticulo.ShowChanged = value;
                                EntradaCantidad.ShowChanged = value;
                                EntradaUnitario.ShowChanged = value;
                        }
                }

                public bool PermiteCrear
                {
                        get
                        {
                                return EntradaArticulo.CanCreate;
                        }
                        set
                        {
                                EntradaArticulo.CanCreate = value;
                        }
                }

                public bool IsEmpty
                {
                        get
                        {
                                return EntradaArticulo.IsEmpty;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public int TextInt
                {
                        get
                        {
                                return EntradaArticulo.TextInt;
                        }
                        set
                        {
                                EntradaArticulo.TextInt = value;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public string Series
                {
                        get
                        {
                                return m_Serials;
                        }
                        set
                        {
                                m_Serials = value;
                                if (m_Serials == null) {
                                        LabelSerials.Visible = false;
                                } else {
                                        LabelSerials.Text = "Seguimiento: " + m_Serials.Replace(System.Environment.NewLine, ", ");
                                        LabelSerials.Visible = m_Serials.Length > 1;
                                }
                        }
                }

                public bool MuestraPrecio
                {
                        get
                        {
                                return EntradaUnitario.Visible;
                        }
                        set
                        {
                                EntradaUnitario.Visible = value;
                                EntradaCantidad.Visible = value;
                                EntradaImporte.Visible = value;
                                if (value)
                                        EntradaArticulo.Width = EntradaUnitario.Left;
                                else
                                        EntradaArticulo.Width = this.Width;
                        }
                }


                // Oculta al changed de abajo
                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public bool Changed
                {
                        get
                        {
                                return EntradaArticulo.Changed || EntradaCantidad.Changed || EntradaUnitario.Changed;
                        }
                        set
                        {
                                EntradaArticulo.Changed = value;
                                EntradaCantidad.Changed = value;
                                EntradaUnitario.Changed = value;
                        }
                }

                public Precios Precio
                {
                        get
                        {
                                return m_Precio;
                        }
                        set
                        {
                                m_Precio = value;
                                EntradaArticulo_TextChanged(null, null);
                                this.Changed = false;
                        }
                }

                public int MaxLength
                {
                        get
                        {
                                return EntradaArticulo.MaxLength;
                        }
                        set
                        {
                                EntradaArticulo.MaxLength = value;
                        }
                }

                public bool ProductoSoloLectura
                {
                        get
                        {
                                return EntradaArticulo.ReadOnly;
                        }
                        set
                        {
                                EntradaArticulo.ReadOnly = value;
                        }
                }

                public bool CantidadSoloLectura
                {
                        get
                        {
                                return EntradaCantidad.ReadOnly;
                        }
                        set
                        {
                                EntradaCantidad.ReadOnly = value;
                        }
                }

                public bool PrecioSoloLectura
                {
                        get
                        {
                                return EntradaUnitario.ReadOnly;
                        }
                        set
                        {
                                EntradaUnitario.ReadOnly = value;
                        }
                }

                public bool MuestraStock
                {
                        get
                        {
                                return m_ShowStock;
                        }
                        set
                        {
                                m_ShowStock = value;
                                VerificarStock();
                        }
                }

                public bool Required
                {
                        get
                        {
                                return EntradaArticulo.Required;
                        }
                        set
                        {
                                EntradaArticulo.Required = value;
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string FreeTextCode
                {
                        get
                        {
                                return EntradaArticulo.FreeTextCode;
                        }
                        set
                        {
                                EntradaArticulo.FreeTextCode = value;
                        }
                }

                public int UnitarioLeft
                {
                        get
                        {
                                return EntradaUnitario.Left;
                        }
                }

                public int CantidadLeft
                {
                        get
                        {
                                return EntradaCantidad.Left;
                        }
                }

                public int ImporteLeft
                {
                        get
                        {
                                return EntradaImporte.Left;
                        }
                }

                public override string Text
                {
                        get
                        {
                                if (EntradaArticulo.Text == EntradaArticulo.FreeTextCode && EntradaArticulo.FreeTextCode.Length > 0)
                                        return EntradaArticulo.Text;
                                else
                                        return EntradaArticulo.TextInt.ToString();
                        }
                        set
                        {
                                if(EntradaArticulo.Text != value)
                                        EntradaArticulo.Text = value;
                                this.Changed = false;
                        }
                }
                public string TextDetail
                {
                        get
                        {
                                return EntradaArticulo.TextDetail;
                        }
                        set
                        {
                                EntradaArticulo.TextDetail = value;
                                this.Changed = false;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public double Importe
                {
                        get
                        {
                                return Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                        }
                        set
                        {
                                EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(value, EntradaImporte.DecimalPlaces);
                                this.Changed = false;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public double Unitario
                {
                        get
                        {
                                return Lfx.Types.Parsing.ParseCurrency(EntradaUnitario.Text);
                        }
                        set
                        {
                                EntradaUnitario.Text = Lfx.Types.Formatting.FormatCurrency(value, EntradaUnitario.DecimalPlaces);
                                this.Changed = false;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lbl.Articulos.Articulo Articulo
                {
                        get
                        {
                                return EntradaArticulo.Elemento as Lbl.Articulos.Articulo;
                        }
                        /* set
                        {
                                EntradaArticulo.Elemento = value;
                        } */
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public double Cantidad
                {
                        get
                        {
                                if (this.EstoyUsandoUnidadPrimaria())
                                        return EntradaCantidad.ValueDouble;
                                else
                                        return EntradaCantidad.ValueDouble / Articulo.Rendimiento;
                        }
                        set
                        {
                                if (this.EstoyUsandoUnidadPrimaria())
                                        EntradaCantidad.ValueDouble = value;
                                else
                                        EntradaCantidad.ValueDouble = value * this.Articulo.Rendimiento;
                                this.Changed = false;
                        }
                }

                private bool EstoyUsandoUnidadPrimaria()
                {
                        return (this.Articulo == null || Articulo.Unidad == null || EntradaCantidad.Sufijo == Articulo.Unidad || (EntradaCantidad.Sufijo.Length == 0 && Articulo.Unidad == "u"));

                }

                private void EntradaArticulo_TextChanged(object sender, System.EventArgs e)
                {
                        if (this.Workspace == null)
                                return;

                        this.Elemento = EntradaArticulo.Elemento;

                        string CodPredet = this.Workspace.CurrentConfig.Productos.CodigoPredeterminado();
                        /* try {
                                ArticuloId = EntradaArticulo.TextInt;
                        } catch {
                                // Puede haber un overflow, si se escribe un código exageradamente largo
                                ArticuloId = 0;
                        }

                        if (EntradaArticulo.Text.Trim().Length == 0 || EntradaArticulo.Text.Trim() == "0") {
                                Articulo = null;
                        } else if (CodPredet == "id_articulo") {
                                Articulo = this.DataBase.Row("articulos", "id_articulo, costo, pvp, control_stock, stock_actual, unidad_stock, rendimiento, unidad_rend, pedido", "id_articulo", ArticuloId);
                        } else {
                                Articulo = this.DataBase.FirstRowFromSelect("SELECT id_articulo, costo, pvp, control_stock, stock_actual, unidad_stock, rendimiento, unidad_rend, pedido FROM articulos WHERE " + CodPredet + "='" + EntradaArticulo.Text.Trim() + "'");
                                if (Articulo == null)
                                        Articulo = this.DataBase.Row("articulos", "id_articulo, costo, pvp, control_stock, stock_actual, unidad_stock, rendimiento, unidad_rend, pedido", "id_articulo", ArticuloId);
                        } */

                        if (this.Articulo != null) {
                                EntradaUnitario.Enabled = true;
                                EntradaCantidad.Enabled = true;
                                EntradaImporte.Enabled = true;
                                if (this.Articulo.Unidad != "u")
                                        EntradaCantidad.Sufijo = Articulo.Unidad;
                                else
                                        EntradaCantidad.Sufijo = "";

                                if (m_Precio == Precios.Costo)
                                        EntradaUnitario.ValueDouble = Articulo.Costo;
                                else
                                        EntradaUnitario.ValueDouble = Articulo.Pvp;

                                if (m_ShowStock)
                                        VerificarStock();

                                if (this.Cantidad == 0)
                                        this.Cantidad = 1;
                        } else if (EntradaArticulo.Text == EntradaArticulo.FreeTextCode && EntradaArticulo.FreeTextCode.Length > 0) {
                                EntradaUnitario.Enabled = true;
                                EntradaCantidad.Enabled = true;
                                EntradaImporte.Enabled = true;
                                if (this.Cantidad == 0)
                                        this.Cantidad = 1;
                        } else if (EntradaArticulo.Text.Length == 0 || (Lfx.Types.Strings.IsNumericInt(EntradaArticulo.Text) && EntradaArticulo.TextInt == 0)) {
                                EntradaUnitario.Text = "0";
                                EntradaCantidad.Sufijo = "";
                                EntradaCantidad.Text = "0";
                                EntradaImporte.Text = "0";
                                EntradaUnitario.Text = "0";
                        }
                        this.Changed = true;
                        if (null != TextChanged)
                                TextChanged(this, null);
                }


                private void EntradaPrecioCantidad_TextChanged(object sender, System.EventArgs e)
                {
                        if (this.Workspace != null) {
                                EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(EntradaUnitario.Text) * this.Cantidad, this.Workspace.CurrentConfig.Moneda.DecimalesCosto);
                                VerificarStock();
                                this.Changed = true;
                                if (null != PrecioCantidadChanged)
                                        PrecioCantidadChanged(this, null);
                        }
                }


                private void VerificarStock()
                {
                        try {
                                if (m_ShowStock && Articulo != null) {
                                        if (this.Articulo.ControlStock != Lbl.Articulos.ControlStock.No && this.Articulo.StockActual < this.Cantidad) {
                                                if (this.Articulo.StockActual + this.Articulo.Pedido >= this.Cantidad) {
                                                        EntradaArticulo.Font = new Font("Bitstream Vera Sans", 10);
                                                        EntradaArticulo.ForeColor = Color.OrangeRed;
                                                } else {
                                                        EntradaArticulo.Font = new Font("Bitstream Vera Sans", 10, FontStyle.Strikeout);
                                                        EntradaArticulo.ForeColor = Color.Red;
                                                }
                                        } else {
                                                EntradaArticulo.Font = new Font("Bitstream Vera Sans", 10);
                                                EntradaArticulo.ForeColor = Color.Black;
                                        }
                                } else {
                                        EntradaArticulo.Font = new Font("Bitstream Vera Sans", 10);
                                        EntradaArticulo.ForeColor = Color.Black;
                                }
                        } catch {
                                EntradaArticulo.Font = new Font("Bitstream Vera Sans", 10);
                                EntradaArticulo.ForeColor = Color.Black;
                        }
                }


                private void EntradaArticulo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == false && e.Shift == false) {
                                switch (e.KeyCode) {
                                        case Keys.Right:
                                        case Keys.Return:
                                                e.Handled = true;
                                                if (EntradaUnitario.Visible) {
                                                        if (this.PrecioSoloLectura)
                                                                EntradaCantidad.Focus();
                                                        else
                                                                EntradaUnitario.Focus();
                                                } else {
                                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                                }
                                                break;
                                        default:
                                                if (KeyDown != null) KeyDown(sender, e);
                                                break;
                                }
                        }
                        if (e.Alt == false && e.Control == true && e.Shift == false) {
                                if (e.KeyCode == Keys.S) {
                                        if (this.AskForSerials != null)
                                                this.AskForSerials(this, null);
                                }
                        }
                }

                private void EntradaUnitario_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.E:
                                        if (e.Control) {
                                                EntradaUnitario.SelectionLength = 0;
                                                EntradaUnitario.SelectionStart = EntradaUnitario.Text.Length;
                                                e.Handled = true;
                                        }
                                        break;
                                case Keys.Left:
                                        if (EntradaUnitario.SelectionStart == 0) {
                                                e.Handled = true;
                                                EntradaArticulo.Focus();
                                        }
                                        break;
                                case Keys.Right:
                                case Keys.Return:
                                        if (EntradaUnitario.SelectionStart >= EntradaUnitario.TextRaw.Length || EntradaUnitario.SelectionLength > 0) {
                                                e.Handled = true;
                                                EntradaCantidad.Focus();
                                        }
                                        break;
                                case Keys.Up:
                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                        break;
                                case Keys.Down:
                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                        break;
                                default:
                                        if (null != KeyDown)
                                                KeyDown(sender, e);
                                        break;
                        }

                }


                private void EntradaCantidad_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Left:
                                        e.Handled = true;
                                        if (this.PrecioSoloLectura)
                                                EntradaArticulo.Focus();
                                        else
                                                EntradaUnitario.Focus();
                                        break;
                                case Keys.Up:
                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                        break;
                                case Keys.Down:
                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                        break;
                                default:
                                        if (KeyDown != null)
                                                KeyDown(sender, e);
                                        break;
                        }
                }


                private void Product_Enter(object sender, System.EventArgs e)
                {
                        if (EntradaArticulo.Focused == false)
                                EntradaArticulo.Focus();
                }


                private void PonerFiltros()
                {
                        string Filtros = "";
                        switch (m_ControlStock) {
                                case ControlesSock.ConControlStock:
                                        Filtros += "control_stock=1";
                                        break;
                                case ControlesSock.SinControlStock:
                                        Filtros += "control_stock=0";
                                        break;
                        }

                        EntradaArticulo.Filter = Filtros;
                }

                private void Product_FontChanged(object sender, System.EventArgs e)
                {
                        EntradaArticulo.Font = this.Font;
                }


                private void RecalcularAltura(object sender, System.EventArgs e)
                {
                        LabelSerialsCruz.Visible = LabelSerials.Visible;
                        if (LabelSerials.Visible)
                                this.Height = 44;
                        else
                                this.Height = 24;
                }

                private void EntradaCantidad_KeyPress(object sender, KeyPressEventArgs e)
                {
                        if (e.KeyChar == ' ') {
                                if (Articulo != null) {
                                        if (this.EstoyUsandoUnidadPrimaria()) {
                                                //Cambio a unidad secundaria
                                                EntradaCantidad.Sufijo = Articulo.UnidadRendimiento;
                                                EntradaCantidad.Text = Lfx.Types.Formatting.FormatStock(Lfx.Types.Parsing.ParseStock(EntradaCantidad.Text) * this.Articulo.Rendimiento);
                                        } else {
                                                //Cambio a unidad primaria
                                                EntradaCantidad.Sufijo = Articulo.Unidad == "u" ? "" : Articulo.Unidad;
                                                EntradaCantidad.Text = Lfx.Types.Formatting.FormatStock(Lfx.Types.Parsing.ParseStock(EntradaCantidad.Text) / this.Articulo.Rendimiento, 4);
                                        }
                                        e.Handled = true;
                                }
                        }
                }
        }
}