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

using System.ComponentModel;
using System.Drawing;
using Lui.Forms;

namespace Lcc.Entrada.Articulos
{
        public partial class MatrizDetalleComprobante : ControlEntrada
        {
                private System.Collections.Generic.List<Lbl.Comprobantes.DetalleArticulo> m_Articulos = null;
                public System.Collections.Generic.List<DetalleComprobante> m_ChildControls = new System.Collections.Generic.List<DetalleComprobante>();

                private bool m_AutoAgregar;
                private bool m_ShowStock;
                private string m_FreeTextCode = "";
                private bool m_LockText;
                private bool m_LockPrice;
                private bool m_LockQuantity;
                private int m_MaxLength = 200;
                private Precios m_Precio = Precios.Pvp;

                public event System.EventHandler TotalChanged;
                new public event System.EventHandler TextChanged;
                public event System.EventHandler AskForSerials;

                public MatrizDetalleComprobante()
                {
                        InitializeComponent();

                        PanelGrilla.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                        lblHeaderDetalle.BackColor = Lfx.Config.Display.CurrentTemplate.Header2Background;
                        lblHeaderDetalle.ForeColor = Lfx.Config.Display.CurrentTemplate.Header2Text;
                        lblHeaderUnitario.BackColor = lblHeaderDetalle.BackColor;
                        lblHeaderUnitario.ForeColor = lblHeaderDetalle.ForeColor;
                        lblHeaderCantidad.BackColor = lblHeaderDetalle.BackColor;
                        lblHeaderCantidad.ForeColor = lblHeaderDetalle.ForeColor;
                        lblHeaderImporte.BackColor = lblHeaderDetalle.BackColor;
                        lblHeaderImporte.ForeColor = lblHeaderDetalle.ForeColor;

                }


                // TODO: debería ser private o protected
                public System.Collections.Generic.List<DetalleComprobante> ChildControls
                {
                        get
                        {
                                return m_ChildControls;
                        }
                }

                public System.Collections.Generic.List<Lbl.Comprobantes.DetalleArticulo> ObtenerArticulos()
                {
                        if (m_Articulos == null) {
                                m_Articulos = new System.Collections.Generic.List<Lbl.Comprobantes.DetalleArticulo>();
                                int i = 1;
                                foreach (DetalleComprobante Pro in this.ChildControls) {
                                        Lbl.Comprobantes.DetalleArticulo DetArt = new Lbl.Comprobantes.DetalleArticulo(this.DataBase, 0);
                                        DetArt.IdArticulo = Pro.TextInt;
                                        DetArt.Orden = i++;
                                        DetArt.Cantidad = Pro.Cantidad;
                                        DetArt.Unitario = Pro.Unitario;
                                        DetArt.Nombre = Pro.TextDetail;
                                        m_Articulos.Add(DetArt);
                                }
                        }
                        return m_Articulos;
                }


                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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


                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

                [System.ComponentModel.Browsable(false)]
                public int Count
                {
                        get
                        {
                                if (m_AutoAgregar) {
                                        return this.ChildControls.Count - 1;
                                } else {
                                        return this.ChildControls.Count;
                                }
                        }
                        set
                        {
                                this.AutoAgregar = false;
                                int CantidadControles = this.ChildControls.Count;
                                if (value < CantidadControles) {
                                        for (int i = CantidadControles - 1; i >= value; i--) {
                                                this.Quitar(i);
                                        }
                                } else if (value > CantidadControles) {
                                        for (int i = CantidadControles; i < value; i++) {
                                                this.Agregar();
                                        }
                                }
                        }
                }

                public double Total
                {
                        get
                        {
                                double m_Total = 0;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        m_Total += Control.Importe;
                                }
                                return m_Total;
                        }
                }

                public bool AutoAgregar
                {
                        get
                        {
                                return m_AutoAgregar;
                        }
                        set
                        {
                                m_AutoAgregar = value;
                                this.AutoAgregarOQuitar(false);
                        }
                }

                public void Agregar()
                {
                        DetalleComprobante ctrl = new DetalleComprobante();

                        this.SuspendLayout();
                        ctrl.Size = new Size(this.Width - 20, 24);
                        ctrl.Location = new Point(0, 24 * this.ChildControls.Count + this.PanelGrilla.AutoScrollPosition.Y);
                        ctrl.TabIndex = this.ChildControls.Count;
                        ctrl.FreeTextCode = m_FreeTextCode;
                        ctrl.ProductoSoloLectura = m_LockText;
                        ctrl.PrecioSoloLectura = m_LockPrice;
                        ctrl.CantidadSoloLectura = m_LockQuantity;
                        ctrl.MaxLength = m_MaxLength;
                        ctrl.MuestraStock = m_ShowStock;
                        ctrl.Required = true;
                        ctrl.Precio = m_Precio;
                        this.PanelGrilla.Controls.Add(ctrl);
                        this.ChildControls.Add(ctrl);
                        this.ReubicarControles();

                        ctrl.TextChanged += new System.EventHandler(Product_TextChanged);
                        ctrl.PrecioCantidadChanged += new System.EventHandler(Product_PrecioCantidadChanged);
                        ctrl.Leave += new System.EventHandler(Product_Leave);
                        ctrl.SizeChanged += new System.EventHandler(Product_SizeChanged);
                        ctrl.AskForSerials += new System.EventHandler(Product_AskForSerials);
                        this.ResumeLayout();
                }


                public void Quitar(int iIndex)
                {
                        this.PanelGrilla.Controls.Remove(this.ChildControls[iIndex]);
                        this.ChildControls.RemoveAt(iIndex);
                }


                private void Product_AskForSerials(object sender, System.EventArgs e)
                {
                        if (this.AskForSerials != null)
                                this.AskForSerials(sender, null);
                }

                private void ProductArray_Enter(object sender, System.EventArgs e)
                {
                        this.AutoAgregarOQuitar(false);
                }


                internal void AutoAgregarOQuitar(bool QuitarDelMedio)
                {
                        // Agrega o quita controles al final segn corresponda
                        // sólo si el AutoAgregar está en True
                        if (this.ChildControls != null && m_AutoAgregar) {
                                DetalleComprobante Ultimo = null;
                                switch (this.ChildControls.Count) {
                                        case 0:
                                                this.Agregar();
                                                break;
                                        case 1:
                                                Ultimo = this.ChildControls[0];
                                                if (Ultimo.IsEmpty == false)
                                                        this.Agregar();
                                                break;
                                        default:
                                                bool QuiteAlgo = false;
                                                if (QuitarDelMedio) {
                                                        bool QuiteEnEstaPasada = false;
                                                        do {
                                                                QuiteEnEstaPasada = false;
                                                                for (int i = 0; i <= this.ChildControls.Count - 1; i++) {
                                                                        DetalleComprobante Control = this.ChildControls[i];
                                                                        if (i < this.ChildControls.Count - 1 && Control.Text.Length == 0) {
                                                                                this.Quitar(i);
                                                                                QuiteAlgo = true;
                                                                                QuiteEnEstaPasada = true;
                                                                                break;
                                                                        }
                                                                }
                                                        }
                                                        while (QuiteEnEstaPasada);
                                                }
                                                if (QuiteAlgo) {
                                                        this.ReubicarControles();
                                                } else {
                                                        DetalleComprobante Penultimo = null;
                                                        Ultimo = this.ChildControls[this.ChildControls.Count - 1];
                                                        if (this.ChildControls.Count > 1)
                                                                Penultimo = this.ChildControls[this.ChildControls.Count - 2];
                                                        if (Ultimo.IsEmpty == false && Penultimo != null && Penultimo.IsEmpty == false)
                                                                this.Agregar();
                                                }
                                                break;
                                }
                        }
                }


                private void Product_TextChanged(object sender, System.EventArgs e)
                {
                        this.AutoAgregarOQuitar(false);
                        if (null != TextChanged) TextChanged(sender, e);
                        if (null != TotalChanged) TotalChanged(sender, e);
                }

                private void Product_PrecioCantidadChanged(object sender, System.EventArgs e)
                {
                        if (null != TotalChanged)
                                TotalChanged(sender, e);
                }


                private void Product_SizeChanged(object sender, System.EventArgs e)
                {
                        if (this.Visible)
                                this.ReubicarControles();
                }

                private void Product_Leave(object sender, System.EventArgs e)
                {
                        this.AutoAgregarOQuitar(true);
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

                private void ReubicarControles()
                {
                        if (this.ChildControls != null && this.ChildControls.Count > 0) {
                                this.SuspendLayout();
                                int ControlNumber = 0, AlturaActual = 0;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.Top = AlturaActual + this.PanelGrilla.AutoScrollPosition.Y;
                                        AlturaActual += Control.Height;
                                        Control.TabIndex = ControlNumber;
                                        Control.Width = this.Width - 20;
                                        ControlNumber++;
                                }
                                ReubicarEncabs();
                                this.ResumeLayout();
                        }
                }

                private void ReubicarEncabs()
                {
                        this.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                        if (this.ChildControls != null && this.ChildControls.Count > 0) {
                                DetalleComprobante ctrl = this.ChildControls[0];
                                lblHeaderDetalle.Width = ctrl.UnitarioLeft - 2;
                                lblHeaderUnitario.Left = ctrl.UnitarioLeft;
                                lblHeaderUnitario.Width = ctrl.CantidadLeft - lblHeaderUnitario.Left - 2;
                                lblHeaderCantidad.Left = ctrl.CantidadLeft;
                                lblHeaderCantidad.Width = ctrl.ImporteLeft - lblHeaderCantidad.Left - 2;
                                lblHeaderImporte.Left = ctrl.ImporteLeft;
                                lblHeaderImporte.Width = ctrl.Width - ctrl.ImporteLeft - 2;
                        }
                }
        }
}