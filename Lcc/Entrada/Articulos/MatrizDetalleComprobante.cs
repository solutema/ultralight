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
using System.ComponentModel;
using System.Windows.Forms;
using Lui.Forms;

namespace Lcc.Entrada.Articulos
{
        public partial class MatrizDetalleComprobante : MatrizControlesEntrada<DetalleComprobante>
        {
                private Lbl.Comprobantes.ColeccionDetalleArticulos m_Articulos = null;

                private bool m_ShowStock;
                private string m_FreeTextCode = "";
                private bool m_LockText;
                private bool m_LockPrice;
                private bool m_LockQuantity;
                private int m_MaxLength = 200;
                private Precios m_Precio = Precios.Pvp;

                public event System.EventHandler TotalChanged;
                public event System.EventHandler ObtenerDatosSeguimiento;

                public MatrizDetalleComprobante()
                {
                        InitializeComponent();

                        PanelGrilla.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                        EtiquetaHeaderDetalle.BackColor = Lfx.Config.Display.CurrentTemplate.Header2Background;
                        EtiquetaHeaderDetalle.ForeColor = Lfx.Config.Display.CurrentTemplate.Header2Text;
                        EtiquetaHeaderUnitario.BackColor = EtiquetaHeaderDetalle.BackColor;
                        EtiquetaHeaderUnitario.ForeColor = EtiquetaHeaderDetalle.ForeColor;
                        EtiquetaHeaderCantidad.BackColor = EtiquetaHeaderDetalle.BackColor;
                        EtiquetaHeaderCantidad.ForeColor = EtiquetaHeaderDetalle.ForeColor;
                        EtiquetaHeaderImporte.BackColor = EtiquetaHeaderDetalle.BackColor;
                        EtiquetaHeaderImporte.ForeColor = EtiquetaHeaderDetalle.ForeColor;
                }


                // TODO: debería ser private o protected
                public System.Collections.Generic.List<DetalleComprobante> ChildControls
                {
                        get
                        {
                                return Controles;
                        }
                }

                public void CargarArticulos(List<Lbl.Comprobantes.DetalleArticulo> articulos)
                {
                        if (articulos == null || articulos.Count == 0) {
                                this.Count = 1;
                                this.ChildControls[0].TextInt = 0;
                                this.ChildControls[0].Cantidad = 1;
                        } else {
                                this.Count = articulos.Count;

                                for (int i = 0; i < articulos.Count; i++) {
                                        if (articulos[i].Articulo == null)
                                                this.ChildControls[i].Text = this.FreeTextCode;
                                        else
                                                this.ChildControls[i].Elemento = articulos[i].Articulo;

                                        this.ChildControls[i].TextDetail = articulos[i].Nombre;
                                        this.ChildControls[i].Cantidad = articulos[i].Cantidad;
                                        this.ChildControls[i].Unitario = articulos[i].Unitario;
                                        this.ChildControls[i].DatosSeguimiento = articulos[i].DatosSeguimiento;
                                }
                        }
                }

                public Lbl.Comprobantes.ColeccionDetalleArticulos ObtenerArticulos(Lfx.Data.Connection dataBase)
                {
                        m_Articulos = new Lbl.Comprobantes.ColeccionDetalleArticulos(dataBase);
                        int i = 1;
                        foreach (DetalleComprobante Pro in this.ChildControls) {
                                if (Pro.IsEmpty == false) {
                                        Lbl.Comprobantes.DetalleArticulo DetArt = new Lbl.Comprobantes.DetalleArticulo(dataBase);
                                        DetArt.Articulo = Pro.Elemento as Lbl.Articulos.Articulo;
                                        DetArt.Nombre = Pro.TextDetail;
                                        DetArt.Orden = i++;
                                        DetArt.Cantidad = Pro.Cantidad;
                                        DetArt.Unitario = Pro.Unitario;
                                        DetArt.DatosSeguimiento = Pro.DatosSeguimiento;
                                        m_Articulos.Add(DetArt);
                                }
                        }

                        return m_Articulos;
                }

                public Lbl.Comprobantes.ColeccionDetalleArticulos ObtenerArticulos(Lbl.Comprobantes.ComprobanteConArticulos comprobante)
                {
                        if (m_Articulos == null)
                                m_Articulos = new Lbl.Comprobantes.ColeccionDetalleArticulos(comprobante);
                        else
                                m_Articulos.Clear();

                        int i = 1;
                        foreach (DetalleComprobante Pro in this.ChildControls) {
                                if (Pro.IsEmpty == false) {
                                        Lbl.Comprobantes.DetalleArticulo DetArt = new Lbl.Comprobantes.DetalleArticulo(comprobante);
                                        DetArt.Articulo = Pro.Elemento as Lbl.Articulos.Articulo;
                                        DetArt.Nombre = Pro.TextDetail;
                                        DetArt.Orden = i++;
                                        DetArt.Cantidad = Pro.Cantidad;
                                        DetArt.Unitario = Pro.Unitario;
                                        DetArt.DatosSeguimiento = Pro.DatosSeguimiento;
                                        m_Articulos.Add(DetArt);
                                }
                        }
                        
                        return m_Articulos;
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public bool Changed
                {
                        get
                        {
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        if (Control.Changed)
                                                return true;
                                }
                                return false;
                        }
                        set
                        {
                                foreach (DetalleComprobante Control in this.ChildControls)
                                        Control.Changed = value;
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                override public bool ShowChanged
                {
                        set
                        {
                                foreach (DetalleComprobante Control in this.ChildControls)
                                        Control.ShowChanged = value;
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
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.Precio = m_Precio;
                                }
                        }
                }

                public int MaxLength
                {
                        get
                        {
                                return m_MaxLength;
                        }
                        set
                        {
                                m_MaxLength = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.MaxLength = m_MaxLength;
                                }
                        }
                }

                public bool LockText
                {
                        get
                        {
                                return m_LockText;
                        }
                        set
                        {
                                m_LockText = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.ProductoSoloLectura = m_LockText;
                                }
                        }
                }
                public bool LockQuantity
                {
                        get
                        {
                                return m_LockQuantity;
                        }
                        set
                        {
                                m_LockQuantity = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.CantidadSoloLectura = m_LockQuantity;
                                }
                        }
                }
                public bool LockPrice
                {
                        get
                        {
                                return m_LockPrice;
                        }
                        set
                        {
                                m_LockPrice = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.PrecioSoloLectura = m_LockPrice;
                                }
                        }
                }

                public bool ShowStock
                {
                        get
                        {
                                return m_ShowStock;
                        }
                        set
                        {
                                m_ShowStock = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.MuestraStock = m_ShowStock;
                                }
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string FreeTextCode
                {
                        get
                        {
                                return m_FreeTextCode;
                        }
                        set
                        {
                                m_FreeTextCode = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.FreeTextCode = m_FreeTextCode;
                                }
                        }
                }


                public decimal Total
                {
                        get
                        {
                                decimal m_Total = 0;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        m_Total += Control.Importe;
                                }
                                return m_Total;
                        }
                }


                public override bool ReadOnly
                {
                        get
                        {
                                return base.ReadOnly;
                        }
                        set
                        {
                                base.ReadOnly = value;
                                this.AutoAgregarOQuitar(false);
                        }
                }


                protected override DetalleComprobante Agregar()
                {
                        DetalleComprobante Ctrl = base.Agregar();

                        Ctrl.TextChanged += new System.EventHandler(Product_TextChanged);
                        Ctrl.PrecioCantidadChanged += new System.EventHandler(Product_PrecioCantidadChanged);
                        Ctrl.ObtenerDatosSeguimiento += new System.EventHandler(Product_ObtenerDatosSeguimiento);

                        return Ctrl;
                }


                private void Product_ObtenerDatosSeguimiento(object sender, System.EventArgs e)
                {
                        if (this.ObtenerDatosSeguimiento != null)
                                this.ObtenerDatosSeguimiento(sender, null);
                }

                private void ProductArray_Enter(object sender, System.EventArgs e)
                {
                        this.AutoAgregarOQuitar(false);
                }


                private void Product_TextChanged(object sender, System.EventArgs e)
                {
                        this.AutoAgregarOQuitar(false);
                        this.OnTextChanged(EventArgs.Empty);
                        if (null != TotalChanged)
                                TotalChanged(sender, e);
                }

                private void Product_PrecioCantidadChanged(object sender, System.EventArgs e)
                {
                        if (null != TotalChanged)
                                TotalChanged(sender, e);
                }


                private void ProductArray_Resize(object sender, System.EventArgs e)
                {
                        this.SuspendLayout();
                        foreach (DetalleComprobante Control in this.ChildControls) {
                                Control.Width = this.Width - 20;
                        }
                        this.ReubicarEncabs();
                        this.ResumeLayout();
                }

                protected override void ReubicarControles()
                {
                        if (this.ChildControls != null && this.ChildControls.Count > 0) {
                                base.ReubicarControles();
                                ReubicarEncabs();
                        }
                }

                private void ReubicarEncabs()
                {
                        this.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                        if (this.ChildControls != null && this.ChildControls.Count > 0) {
                                DetalleComprobante ctrl = this.ChildControls[0];
                                EtiquetaHeaderDetalle.Width = ctrl.UnitarioLeft - 2;
                                EtiquetaHeaderUnitario.Left = ctrl.UnitarioLeft;
                                EtiquetaHeaderUnitario.Width = ctrl.CantidadLeft - EtiquetaHeaderUnitario.Left - 2;
                                EtiquetaHeaderCantidad.Left = ctrl.CantidadLeft;
                                EtiquetaHeaderCantidad.Width = ctrl.ImporteLeft - EtiquetaHeaderCantidad.Left - 2;
                                EtiquetaHeaderImporte.Left = ctrl.ImporteLeft;
                                EtiquetaHeaderImporte.Width = ctrl.Width - ctrl.ImporteLeft - 2;
                        }
                }
        }
}