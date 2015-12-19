using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Lui.Forms;

namespace Lcc.Entrada.Articulos
{
        public partial class MatrizDetalleComprobante : AuxiliarMatrizDetalleComprobante
        {
                private Lbl.Comprobantes.ColeccionDetalleArticulos m_Articulos = null;

                private bool m_ShowStock;
                private string m_FreeTextCode = "";
                private bool m_BloquearAtriculo;
                private bool m_BloquearPrecio;
                private bool m_AutoUpdate = true;
                private bool m_BloquearCantidad;
                private bool m_BloquearDescuento = false;
                private Precios m_Precio = Precios.Pvp;

                public event System.EventHandler TotalChanged;
                public event System.EventHandler ObtenerDatosSeguimiento;

                public MatrizDetalleComprobante()
                {
                        InitializeComponent();
                }


                // TODO: debería ser private o protected
                public System.Collections.Generic.List<DetalleComprobante> ChildControls
                {
                        get
                        {
                                return Controles;
                        }
                }


                protected override DetalleComprobante ObtenerControlNuevo()
                {
                        DetalleComprobante Ctrl = base.ObtenerControlNuevo();
                        Ctrl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
                        Ctrl.BloquearPrecio = this.BloquearPrecio;
                        Ctrl.BloquearDescuento = this.BloquearDescuento;
                        Ctrl.BloquearCantidad = this.BloquearCantidad;
                        Ctrl.BloquearAtriculo = this.BloquearAtriculo;
                        return Ctrl;
                }


                public void CargarArticulos(IList<Lbl.Comprobantes.DetalleArticulo> articulos)
                {
                        if (articulos == null || articulos.Count == 0) {
                                this.Count = 1;
                                this.ChildControls[0].ValueInt = 0;
                                this.ChildControls[0].Cantidad = 1;
                        } else {
                                this.Count = articulos.Count;

                                for (int i = 0; i < articulos.Count; i++) {
                                        if (articulos[i].Articulo == null)
                                                this.ChildControls[i].Text = this.FreeTextCode;
                                        else
                                                this.ChildControls[i].Articulo = articulos[i].Articulo;

                                        this.ChildControls[i].TextDetail = articulos[i].Nombre;
                                        this.ChildControls[i].Cantidad = articulos[i].Cantidad;
                                        this.ChildControls[i].Unitario = articulos[i].Unitario;
                                        this.ChildControls[i].Descuento = articulos[i].Descuento;
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
                                        DetArt.Descuento = Pro.Descuento;
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
                                        DetArt.Articulo = Pro.Articulo;
                                        DetArt.Nombre = Pro.TextDetail;
                                        DetArt.Orden = i++;
                                        DetArt.Cantidad = Pro.Cantidad;
                                        DetArt.Unitario = Pro.Unitario;
                                        DetArt.Descuento = Pro.Descuento;
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
                public bool AutoUpdate
                {
                        get
                        {
                                return m_AutoUpdate;
                        }
                        set
                        {
                                m_AutoUpdate = value;
                                foreach (DetalleComprobante Control in this.ChildControls)
                                        Control.AutoUpdate = m_AutoUpdate;
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


                public bool BloquearAtriculo
                {
                        get
                        {
                                return m_BloquearAtriculo;
                        }
                        set
                        {
                                m_BloquearAtriculo = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.BloquearAtriculo = m_BloquearAtriculo;
                                }
                        }
                }


                public bool BloquearCantidad
                {
                        get
                        {
                                return m_BloquearCantidad;
                        }
                        set
                        {
                                m_BloquearCantidad = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.BloquearCantidad = m_BloquearCantidad;
                                }
                        }
                }


                public bool BloquearPrecio
                {
                        get
                        {
                                return m_BloquearPrecio;
                        }
                        set
                        {
                                m_BloquearPrecio = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.BloquearPrecio = m_BloquearPrecio;
                                }
                        }
                }



                public bool BloquearDescuento
                {
                        get
                        {
                                return m_BloquearDescuento;
                        }
                        set
                        {
                                m_BloquearDescuento = value;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.BloquearDescuento = m_BloquearDescuento;
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
                                decimal Res = 0;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Res += Control.Importe;
                                }
                                return Res;
                        }
                }


                public decimal ImporteIva
                {
                        get
                        {
                                decimal Res = 0;
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Lbl.Impuestos.Alicuota Alic;
                                        if (Control.Articulo == null) {
                                                Alic = Lbl.Sys.Config.Empresa.AlicuotaPredeterminada;
                                        } else {
                                                Alic = Control.Articulo.ObtenerAlicuota();
                                        }

                                        if (Alic.Porcentaje > 0)
                                                Res += Control.Importe * Alic.Porcentaje / 100m;
                                }
                                return Res;
                        }
                }


                public override bool TemporaryReadOnly
                {
                        get
                        {
                                return base.TemporaryReadOnly;
                        }
                        set
                        {
                                base.TemporaryReadOnly = value;
                                this.AutoAgregarOQuitar(false);
                        }
                }


                protected override DetalleComprobante Agregar()
                {
                        DetalleComprobante Ctrl = base.Agregar();

                        Ctrl.TextChanged += new System.EventHandler(Product_TextChanged);
                        Ctrl.PrecioCantidadChanged += new System.EventHandler(Product_PrecioCantidadChanged);
                        Ctrl.ObtenerDatosSeguimiento += new System.EventHandler(Product_ObtenerDatosSeguimiento);
                        Ctrl.Precio = this.Precio;
                        Ctrl.AutoUpdate = m_AutoUpdate;
                        Ctrl.FreeTextCode = this.FreeTextCode;

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


                protected override void ReubicarControles()
                {
                        if (this.ChildControls != null && this.ChildControls.Count > 0) {
                                PanelGrilla.Top = EtiquetaHeaderDetalle.Height + 2;
                                PanelGrilla.Height = this.ClientSize.Height - PanelGrilla.Top;
                                base.ReubicarControles();
                        }
                }

                protected override void OnCreateControl()
                {
                        if (this.Created) 
                                this.ReubicarEncabs();

                        base.OnCreateControl();
                }


                protected override void OnResize(EventArgs e)
                {
                        if (this.Created) {
                                this.SuspendLayout();
                                foreach (DetalleComprobante Control in this.ChildControls) {
                                        Control.Width = this.Width - 20;
                                }
                                this.ReubicarEncabs();
                                this.ResumeLayout();
                        }
                        base.OnResize(e);
                }


                private void ReubicarEncabs()
                {
                        if (this.ChildControls != null && this.ChildControls.Count > 0) {
                                DetalleComprobante Ctrl = this.ChildControls[0];
                                EtiquetaHeaderDetalle.Width = Ctrl.UnitarioLeft - 1;

                                EtiquetaHeaderUnitario.Left = Ctrl.UnitarioLeft;
                                EtiquetaHeaderUnitario.Width = Ctrl.CantidadLeft - EtiquetaHeaderUnitario.Left - 1;
                                                                
                                EtiquetaHeaderCantidad.Left = Ctrl.CantidadLeft;
                                EtiquetaHeaderCantidad.Width = Ctrl.DescuentoLeft - EtiquetaHeaderCantidad.Left - 1;

                                EtiquetaHeaderDescuento.Left = Ctrl.DescuentoLeft;
                                EtiquetaHeaderDescuento.Width = Ctrl.ImporteLeft - EtiquetaHeaderDescuento.Left - 1;

                                EtiquetaHeaderImporte.Left = Ctrl.ImporteLeft;
                                EtiquetaHeaderImporte.Width = Ctrl.Width - Ctrl.ImporteLeft - 1;
                        }
                }


                public void BorrarDatosDeSeguimiento()
                {
                        foreach (DetalleComprobante Pro in this.ChildControls) {
                                Pro.DatosSeguimiento = null;
                        }
                }
        }
}