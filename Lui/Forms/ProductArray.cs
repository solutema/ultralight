// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lui.Forms
{
	public class ProductArray : System.Windows.Forms.UserControl
	{
                private System.Collections.Generic.List<Lbl.Comprobantes.DetalleArticulo> m_Articulos = null;
		public System.Collections.Generic.List<Product> m_ChildControls = new System.Collections.Generic.List<Product>();

		private bool m_AutoAgregar;
		private bool m_ShowStock;
		private string m_FreeTextCode = "";
		private bool m_LockText;
		private bool m_LockPrice;
		private bool m_LockQuantity;
		private int m_MaxLength = 200;
		private Product.Precios m_Precio = Product.Precios.PVP;
		private Lws.Workspace m_Workspace;

		public event System.EventHandler TotalChanged;
		public new event System.EventHandler TextChanged;
                public event System.EventHandler AskForSerials;

		#region Código generado por el Diseñador de Windows Forms

		public ProductArray()
			: base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			PanelGrilla.BackColor = Lws.Config.Display.CurrentTemplate.WindowBackground;
			lblHeaderDetalle.BackColor = Lws.Config.Display.CurrentTemplate.Header2Background;
			lblHeaderDetalle.ForeColor = Lws.Config.Display.CurrentTemplate.Header2Text;
			lblHeaderUnitario.BackColor = lblHeaderDetalle.BackColor;
			lblHeaderUnitario.ForeColor = lblHeaderDetalle.ForeColor;
			lblHeaderCantidad.BackColor = lblHeaderDetalle.BackColor;
			lblHeaderCantidad.ForeColor = lblHeaderDetalle.ForeColor;
			lblHeaderImporte.BackColor = lblHeaderDetalle.BackColor;
			lblHeaderImporte.ForeColor = lblHeaderDetalle.ForeColor;

		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private System.ComponentModel.Container components = null;

		internal System.Windows.Forms.Label lblHeaderDetalle;
		internal System.Windows.Forms.Label lblHeaderUnitario;
		internal System.Windows.Forms.Label lblHeaderCantidad;
		internal System.Windows.Forms.Label lblHeaderImporte;
		internal System.Windows.Forms.Panel PanelGrilla;

		private void InitializeComponent()
		{
                        this.lblHeaderDetalle = new System.Windows.Forms.Label();
                        this.lblHeaderUnitario = new System.Windows.Forms.Label();
                        this.lblHeaderCantidad = new System.Windows.Forms.Label();
                        this.lblHeaderImporte = new System.Windows.Forms.Label();
                        this.PanelGrilla = new System.Windows.Forms.Panel();
                        this.SuspendLayout();
                        // 
                        // lblHeaderDetalle
                        // 
                        this.lblHeaderDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.lblHeaderDetalle.Location = new System.Drawing.Point(0, 0);
                        this.lblHeaderDetalle.Name = "lblHeaderDetalle";
                        this.lblHeaderDetalle.Size = new System.Drawing.Size(176, 18);
                        this.lblHeaderDetalle.TabIndex = 999;
                        this.lblHeaderDetalle.Text = " Detalle";
                        this.lblHeaderDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeaderUnitario
                        // 
                        this.lblHeaderUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.lblHeaderUnitario.Location = new System.Drawing.Point(180, 0);
                        this.lblHeaderUnitario.Name = "lblHeaderUnitario";
                        this.lblHeaderUnitario.Size = new System.Drawing.Size(64, 18);
                        this.lblHeaderUnitario.TabIndex = 999;
                        this.lblHeaderUnitario.Text = " Precio";
                        this.lblHeaderUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeaderCantidad
                        // 
                        this.lblHeaderCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.lblHeaderCantidad.Location = new System.Drawing.Point(248, 0);
                        this.lblHeaderCantidad.Name = "lblHeaderCantidad";
                        this.lblHeaderCantidad.Size = new System.Drawing.Size(72, 18);
                        this.lblHeaderCantidad.TabIndex = 999;
                        this.lblHeaderCantidad.Text = " Cant";
                        this.lblHeaderCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeaderImporte
                        // 
                        this.lblHeaderImporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.lblHeaderImporte.Location = new System.Drawing.Point(324, 0);
                        this.lblHeaderImporte.Name = "lblHeaderImporte";
                        this.lblHeaderImporte.Size = new System.Drawing.Size(80, 18);
                        this.lblHeaderImporte.TabIndex = 999;
                        this.lblHeaderImporte.Text = " Importe";
                        this.lblHeaderImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelGrilla
                        // 
                        this.PanelGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelGrilla.AutoScroll = true;
                        this.PanelGrilla.AutoScrollMargin = new System.Drawing.Size(20, 0);
                        this.PanelGrilla.Location = new System.Drawing.Point(0, 20);
                        this.PanelGrilla.Name = "PanelGrilla";
                        this.PanelGrilla.Size = new System.Drawing.Size(536, 160);
                        this.PanelGrilla.TabIndex = 999;
                        // 
                        // ProductArray
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.BackColor = System.Drawing.SystemColors.Control;
                        this.Controls.Add(this.PanelGrilla);
                        this.Controls.Add(this.lblHeaderImporte);
                        this.Controls.Add(this.lblHeaderCantidad);
                        this.Controls.Add(this.lblHeaderUnitario);
                        this.Controls.Add(this.lblHeaderDetalle);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Name = "ProductArray";
                        this.Size = new System.Drawing.Size(536, 180);
                        this.Resize += new System.EventHandler(this.ProductArray_Resize);
                        this.Enter += new System.EventHandler(this.ProductArray_Enter);
                        this.ResumeLayout(false);

		}


		#endregion

                // TODO: debería ser private o protected
                public System.Collections.Generic.List<Product> ChildControls
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
                                foreach (Product Pro in this.ChildControls) {
                                        Lbl.Comprobantes.DetalleArticulo DetArt = new Lbl.Comprobantes.DetalleArticulo(this.Workspace.DefaultDataView, 0);
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

		public bool Changed
		{
			get
			{
                                foreach (Product Control in this.ChildControls)
				{
					if (Control.Changed)
						return true;
				}
				return false;
			}
			set
			{
                                foreach (Product Control in this.ChildControls)
					Control.Changed = value;
			}
		}


		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool ShowChanged
		{
			set
			{
                                foreach (Product Control in this.ChildControls)
					Control.ShowChanged = value;
			}
		}

		public Product.Precios Precio
		{
			get
			{
				return m_Precio;
			}
			set
			{
				m_Precio = value;
                                foreach (Product Control in this.ChildControls)
				{
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
                                foreach (Product Control in this.ChildControls)
				{
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
                                foreach (Product Control in this.ChildControls)
				{
					Control.LockText = m_LockText;
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
                                foreach (Product Control in this.ChildControls)
				{
					Control.LockQuantity = m_LockQuantity;
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
                                foreach (Product Control in this.ChildControls)
				{
					Control.LockPrice = m_LockPrice;
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
                                foreach (Product Control in this.ChildControls)
				{
					Control.ShowStock = m_ShowStock;
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
                                foreach (Product Control in this.ChildControls)
				{
					Control.FreeTextCode = m_FreeTextCode;
				}
			}
		}

		[System.ComponentModel.Browsable(false)]
		public int Count
		{
			get
			{
				if (m_AutoAgregar)
				{
                                        return this.ChildControls.Count - 1;
				}
				else
				{
                                        return this.ChildControls.Count;
				}
			}
			set
			{
				this.AutoAgregar = false;
                                int CantidadControles = this.ChildControls.Count;
				if (value < CantidadControles)
				{
					for (int i = CantidadControles - 1; i >= value; i--)
					{
						this.Quitar(i);
					}
				}
				else if (value > CantidadControles)
				{
					for (int i = CantidadControles; i < value; i++)
					{
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
                                foreach (Product Control in this.ChildControls)
				{
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
			Product ctrl = new Product();

			this.SuspendLayout();
			ctrl.Size = new Size(this.Width - 20, 24);
                        ctrl.Location = new Point(0, 24 * this.ChildControls.Count + this.PanelGrilla.AutoScrollPosition.Y);
                        ctrl.TabIndex = this.ChildControls.Count;
			ctrl.FreeTextCode = m_FreeTextCode;
			ctrl.LockText = m_LockText;
			ctrl.LockPrice = m_LockPrice;
			ctrl.LockQuantity = m_LockQuantity;
			ctrl.MaxLength = m_MaxLength;
			ctrl.ShowStock = m_ShowStock;
			ctrl.Required = true;
			ctrl.Precio = m_Precio;
			this.PanelGrilla.Controls.Add(ctrl);
                        this.ChildControls.Add(ctrl);
			this.ReubicarControles();

			// AddHandler ctrl.Enter, AddressOf Product_Enter
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
                        if (this.ChildControls != null && m_AutoAgregar)
			{
				Product Ultimo = null;
                                switch (this.ChildControls.Count)
				{
					case 0:
						this.Agregar();
						break;
					case 1:
						Ultimo = this.ChildControls[0];
						if (Ultimo.Text.Length > 0)
							this.Agregar();
						break;
					default:
						bool QuiteAlgo = false;
						if (QuitarDelMedio)
						{
							bool QuiteEnEstaPasada = false;
							do
							{
								QuiteEnEstaPasada = false;
                                                                for (int i = 0; i <= this.ChildControls.Count - 1; i++)
								{
									Product Control = this.ChildControls[i];
                                                                        if (i < this.ChildControls.Count - 1 && Control.Text.Length == 0)
									{
										this.Quitar(i);
										QuiteAlgo = true;
										QuiteEnEstaPasada = true;
										break;
									}
								}
							}
							while (QuiteEnEstaPasada);
						}
						if (QuiteAlgo)
						{
							this.ReubicarControles();
						}
						else
						{
							Product Penultimo = null;
                                                        Ultimo = this.ChildControls[this.ChildControls.Count - 1];
                                                        if (this.ChildControls.Count > 1)
                                                                Penultimo = this.ChildControls[this.ChildControls.Count - 2];
							if (Ultimo.Text.Length > 0 && Penultimo != null && Penultimo.Text.Length > 0)
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
                        foreach (Product Control in this.ChildControls)
			{
				Control.Width = this.Width - 20;
			}
			this.ReubicarEncabs();
			this.ResumeLayout();
		}

		private void ReubicarControles()
		{
                        if (this.ChildControls != null && this.ChildControls.Count > 0)
			{
				this.SuspendLayout();
				int ControlNumber = 0, AlturaActual = 0;
                                foreach (Product Control in this.ChildControls)
				{
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
			this.BackColor = Lws.Config.Display.CurrentTemplate.WindowBackground;
                        if (this.ChildControls != null && this.ChildControls.Count > 0)
			{
				Product ctrl = this.ChildControls[0];
				lblHeaderDetalle.Width = ctrl.UnitarioLeft - 2;
				lblHeaderUnitario.Left = ctrl.UnitarioLeft;
				lblHeaderUnitario.Width = ctrl.CantidadLeft - lblHeaderUnitario.Left - 2;
				lblHeaderCantidad.Left = ctrl.CantidadLeft;
				lblHeaderCantidad.Width = ctrl.ImporteLeft - lblHeaderCantidad.Left - 2;
				lblHeaderImporte.Left = ctrl.ImporteLeft;
				lblHeaderImporte.Width = ctrl.Width - ctrl.ImporteLeft - 2;
			}
		}

		public Lws.Workspace Workspace
		{
			get
			{
				//Busco un Workspace en mi parent
				if (m_Workspace == null)
					m_Workspace = FindMyWorkspace(this.Parent);
				return m_Workspace;
			}
			set
			{
				m_Workspace = value;
			}
		}

		private Lws.Workspace FindMyWorkspace(System.Windows.Forms.Control whereToFind)
		{
			if (whereToFind is Lui.Forms.Form)
			{
				return ((Lui.Forms.Form)whereToFind).Workspace;
			}
			else if (whereToFind != null && whereToFind.Parent != null)
			{
				return FindMyWorkspace(whereToFind.Parent);
			}
			else
			{
				return null;
			}
		}
	}
}