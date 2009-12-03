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
	public partial class Product : System.Windows.Forms.UserControl
	{

		public enum Precios
		{
			Costo = 0,
			PVP = 1,
		}


		public enum ControlesSock
		{
			Ambos = 0,
			ConControlStock = 1,
			SinControlStock = 2,
		}


		protected bool m_ShowStock;
		protected Precios m_Precio = Precios.PVP;
		protected ControlesSock m_ControlStock = ControlesSock.Ambos;
		protected Lfx.Data.Row Articulo;
		protected int ArticuloId;
		protected string m_Serials = "";
		private Lws.Workspace m_Workspace;

		public new event System.EventHandler TextChanged;
		public new event System.Windows.Forms.KeyEventHandler KeyDown;
		public event System.EventHandler PrecioCantidadChanged;
                public event System.EventHandler AskForSerials;

                public Product()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();
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
		public bool ShowChanged
		{
			set
			{
				txtArticulo.ShowChanged = value;
				txtCantidad.ShowChanged = value;
				txtUnitario.ShowChanged = value;
			}
		}

		public bool CanCreate
		{
			get
			{
				return txtArticulo.CanCreate;
			}
			set
			{
				txtArticulo.CanCreate = value;
			}
		}

		public int TextInt
		{
			get
			{
				return txtArticulo.TextInt;
			}
			set
			{
				txtArticulo.TextInt = value;
			}
		}

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
                                        LabelSerials.Text = "NS: " + m_Serials.Replace(System.Environment.NewLine, ", ");
                                        LabelSerials.Visible = m_Serials.Length > 1;
                                }
			}
		}

		public bool ShowPrice
		{
			get
			{
				return txtUnitario.Visible;
			}
			set
			{
				txtUnitario.Visible = value;
				txtCantidad.Visible = value;
				txtImporte.Visible = value;
				if (value)
					txtArticulo.Width = txtUnitario.Left;
				else
					txtArticulo.Width = this.Width;
			}
		}

		public bool Changed
		{
			get
			{
				return txtArticulo.Changed || txtCantidad.Changed || txtUnitario.Changed;
			}
			set
			{
				txtArticulo.Changed = value;
				txtCantidad.Changed = value;
				txtUnitario.Changed = value;
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
				txtArticulo_TextChanged(null, null);
				this.Changed = false;
			}
		}

		public int MaxLength
		{
			get
			{
				return txtArticulo.MaxLength;
			}
			set
			{
				txtArticulo.MaxLength = value;
			}
		}

		public bool LockText
		{
			get
			{
				return txtArticulo.ReadOnly;
			}
			set
			{
				txtArticulo.ReadOnly = value;
			}
		}
		public bool LockQuantity
		{
			get
			{
				return txtCantidad.ReadOnly;
			}
			set
			{
				txtCantidad.ReadOnly = value;
			}
		}

		public bool LockPrice
		{
			get
			{
				return txtUnitario.ReadOnly;
			}
			set
			{
				txtUnitario.ReadOnly = value;
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
				VerificarStock();
			}
		}

		public bool Required
		{
			get
			{
				return txtArticulo.Required;
			}
			set
			{
				txtArticulo.Required = value;
			}
		}

		[System.ComponentModel.Category("Datos")]
		public string FreeTextCode
		{
			get
			{
				return txtArticulo.FreeTextCode;
			}
			set
			{
				txtArticulo.FreeTextCode = value;
			}
		}

		public int UnitarioLeft
		{
			get
			{
				return txtUnitario.Left;
			}
		}

		public int CantidadLeft
		{
			get
			{
				return txtCantidad.Left;
			}
		}

		public int ImporteLeft
		{
			get
			{
				return txtImporte.Left;
			}
		}

		public override string Text
		{
			get
			{
				if (txtArticulo.Text == txtArticulo.FreeTextCode && txtArticulo.FreeTextCode.Length > 0)
					return txtArticulo.Text;
				else if (ArticuloId == 0)
					return "";
				else
					return ArticuloId.ToString();
			}
			set
			{
				txtArticulo.Text = value;
				this.Changed = false;
			}
		}
		public string TextDetail
		{
			get
			{
				return txtArticulo.TextDetail;
			}
			set
			{
				txtArticulo.TextDetail = value;
				this.Changed = false;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public double Importe
		{
			get
			{
				return Lfx.Types.Parsing.ParseCurrency(txtImporte.Text);
			}
			set
			{
				txtImporte.Text = Lfx.Types.Formatting.FormatCurrency(value, txtImporte.DecimalPlaces);
				this.Changed = false;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public double Unitario
		{
			get
			{
				return Lfx.Types.Parsing.ParseCurrency(txtUnitario.Text);
			}
			set
			{
				txtUnitario.Text = Lfx.Types.Formatting.FormatCurrency(value, txtUnitario.DecimalPlaces);
				this.Changed = false;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public double Cantidad
		{
			get
			{
				if (this.EstoyUsandoUnidadPrimaria())
					return Lfx.Types.Parsing.ParseStock(txtCantidad.Text);
				else
					return Lfx.Types.Parsing.ParseStock(txtCantidad.Text) / System.Convert.ToDouble(Articulo["rendimiento"]);
			}
			set
			{
				if (this.EstoyUsandoUnidadPrimaria())
					txtCantidad.Text = Lfx.Types.Formatting.FormatStock(value, txtCantidad.DecimalPlaces);
				else
					txtCantidad.Text = Lfx.Types.Formatting.FormatStock(value * System.Convert.ToDouble(Articulo["rendimiento"]), txtCantidad.DecimalPlaces);
				this.Changed = false;
			}
		}

		private bool EstoyUsandoUnidadPrimaria()
		{
			return (Articulo == null || txtCantidad.Sufijo == Articulo["unidad_stock"].ToString() || (txtCantidad.Sufijo.Length == 0 && Articulo["unidad_stock"].ToString() == "u"));

		}

		private void txtArticulo_TextChanged(object sender, System.EventArgs e)
		{
			string sPrecio = null;
			switch (m_Precio)
			{
				case Precios.Costo:
					sPrecio = "costo";
					break;
				case Precios.PVP:
					sPrecio = "pvp";
					break;
			}

			string CodPredet = "id_articulo";
			if (this.Workspace != null)
				CodPredet = this.Workspace.CurrentConfig.Products.DefaultCode();
                        try {
                                ArticuloId = txtArticulo.TextInt;
                        } catch {
                                // Puede haber un overflow, si se escribe un código exageradamente largo
                                ArticuloId = 0;
                        }

			if (txtArticulo.Text.Trim().Length == 0 || txtArticulo.Text.Trim() == "0")
			{
				Articulo = null;
			}
			else if (CodPredet == "id_articulo")
			{
                                Articulo = this.Workspace.DefaultDataView.DataBase.Row("articulos", "id_articulo, costo, pvp, control_stock, stock_actual, unidad_stock, rendimiento, unidad_rend, pedido", "id_articulo", ArticuloId);
			}
			else
			{
                                Articulo = this.Workspace.DefaultDataView.DataBase.FirstRowFromSelect("SELECT id_articulo, costo, pvp, control_stock, stock_actual, unidad_stock, rendimiento, unidad_rend, pedido FROM articulos WHERE " + CodPredet + "='" + txtArticulo.Text.Trim() + "'");
				if (Articulo == null)
                                        Articulo = this.Workspace.DefaultDataView.DataBase.Row("articulos", "id_articulo, costo, pvp, control_stock, stock_actual, unidad_stock, rendimiento, unidad_rend, pedido", "id_articulo", ArticuloId);
			}

			if (Articulo != null)
			{
				ArticuloId = System.Convert.ToInt32(Articulo["id_articulo"]);
				txtUnitario.Enabled = true;
				txtCantidad.Enabled = true;
				txtImporte.Enabled = true;
				if (Articulo["unidad_stock"].ToString() != "u")
					txtCantidad.Sufijo = Articulo["unidad_stock"].ToString();
				else
					txtCantidad.Sufijo = "";
				txtUnitario.Text = Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Articulo[sPrecio]), txtUnitario.DecimalPlaces);

				if (m_ShowStock)
					VerificarStock();

				if (this.Cantidad == 0)
					this.Cantidad = 1;
			}
			else if (txtArticulo.Text == txtArticulo.FreeTextCode && txtArticulo.FreeTextCode.Length > 0)
			{
				ArticuloId = 0;
				txtUnitario.Enabled = true;
				txtCantidad.Enabled = true;
				txtImporte.Enabled = true;
				if (this.Cantidad == 0)
					this.Cantidad = 1;

			}
			else if (txtArticulo.Text.Length == 0 || (Lfx.Types.Strings.IsNumericInt(txtArticulo.Text) && txtArticulo.TextInt == 0))
			{
				ArticuloId = 0;
				txtUnitario.Text = "0";
				txtCantidad.Sufijo = "";
				txtCantidad.Text = "0";
				txtImporte.Text = "0";
				txtUnitario.Text = "0";
			}
			this.Changed = true;
			if (null != TextChanged)
				TextChanged(this, null);
		}


		private void CambioPrecioCantidad(object sender, System.EventArgs e)
		{
			if (this.Workspace != null)
			{
				txtImporte.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtUnitario.Text) * this.Cantidad, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto);
				VerificarStock();
				this.Changed = true;
				if (null != PrecioCantidadChanged)
					PrecioCantidadChanged(this, null);
			}
		}


		private void VerificarStock()
		{
			try
			{
				if (m_ShowStock && Articulo != null)
				{
					if (System.Convert.ToInt32(Articulo["control_stock"]) > 0 && System.Convert.ToDouble(Articulo["stock_actual"]) < this.Cantidad)
					{
						if (System.Convert.ToDouble(Articulo["stock_actual"]) + System.Convert.ToDouble(Articulo["pedido"]) >= this.Cantidad)
						{
							txtArticulo.Font = new Font("Bitstream Vera Sans", 10);
							txtArticulo.ForeColor = Color.OrangeRed;
						}
						else
						{
							txtArticulo.Font = new Font("Bitstream Vera Sans", 10, FontStyle.Strikeout);
							txtArticulo.ForeColor = Color.Red;
						}
					}
					else
					{
						txtArticulo.Font = new Font("Bitstream Vera Sans", 10);
						txtArticulo.ForeColor = Color.Black;
					}
				}
				else
				{
					txtArticulo.Font = new Font("Bitstream Vera Sans", 10);
					txtArticulo.ForeColor = Color.Black;
				}
			}
			catch
			{
				txtArticulo.Font = new Font("Bitstream Vera Sans", 10);
				txtArticulo.ForeColor = Color.Black;
			}
		}


		private void txtArticulo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Alt == false && e.Control == false && e.Shift == false)
			{
				switch (e.KeyCode)
				{
					case Keys.Right:
					case Keys.Return:
						e.Handled = true;
						if(txtUnitario.Visible) {
							if(this.LockPrice)
								txtCantidad.Focus();
							else
								txtUnitario.Focus();
						} else {
							System.Windows.Forms.SendKeys.Send("{tab}");
						}
						break;
					default:
						if (KeyDown != null) KeyDown(sender, e);
						break;
				}
			}
			if (e.Alt == false && e.Control == true && e.Shift == false)
			{
                                if (e.KeyCode == Keys.S) {
                                        if (this.AskForSerials != null)
                                                this.AskForSerials(this, null);
                                }
			}
		}

		private void txtUnitario_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.E:
					if (e.Control)
					{
						txtUnitario.SelectionLength = 0;
						txtUnitario.SelectionStart = txtUnitario.Text.Length;
						e.Handled = true;
					}
					break;
				case Keys.Left:
					if (txtUnitario.SelectionStart == 0)
					{
						e.Handled = true;
						txtArticulo.Focus();
					}
					break;
				case Keys.Right:
				case Keys.Return:
					if (txtUnitario.SelectionStart >= txtUnitario.TextRaw.Length || txtUnitario.SelectionLength > 0) {
						e.Handled = true;
						txtCantidad.Focus();
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


		private void txtCantidad_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Left:
					e.Handled = true;
					if(this.LockPrice)
						txtArticulo.Focus();
					else
						txtUnitario.Focus();
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
			if(txtArticulo.Focused == false)
				txtArticulo.Focus();
		}


		private void PonerFiltros()
		{
			string Filtros = "";
			switch (m_ControlStock)
			{
				case ControlesSock.ConControlStock:
					Filtros += "control_stock=1";
					break;
				case ControlesSock.SinControlStock:
					Filtros += "control_stock=0";
					break;
			}

			txtArticulo.Filter = Filtros;
		}

		private void Product_FontChanged(object sender, System.EventArgs e)
		{
			txtArticulo.Font = this.Font;
		}


		public Lws.Workspace Workspace
		{
			get
			{
				//Busco un Workspace en mi parent
				if (m_Workspace == null)
				{
					m_Workspace = FindMyWorkspace(this.Parent);
					if (m_Workspace != null)
					{
						this.WorkspaceChanged();
					}
				}
				return m_Workspace;
			}
			set
			{
				m_Workspace = value;
				this.WorkspaceChanged();
			}
		}

		public virtual void WorkspaceChanged()
		{
			if (m_Workspace != null)
			{
				switch (m_Precio)
				{
					case Precios.Costo:
						txtUnitario.DecimalPlaces = m_Workspace.CurrentConfig.Currency.DecimalPlacesCosto;
						txtImporte.DecimalPlaces = m_Workspace.CurrentConfig.Currency.DecimalPlacesCosto;
						break;
					case Precios.PVP:
						txtUnitario.DecimalPlaces = m_Workspace.CurrentConfig.Currency.DecimalPlaces;
						txtImporte.DecimalPlaces = m_Workspace.CurrentConfig.Currency.DecimalPlaces;
						break;
				}
				txtCantidad.DecimalPlaces = this.Workspace.CurrentConfig.Products.StockDecimalPlaces;
			}
		}


		private Lws.Workspace FindMyWorkspace(System.Windows.Forms.Control whereToFind)
		{
			if (whereToFind is Lui.Forms.Form)
			{
				return ((Lui.Forms.Form)whereToFind).Workspace;
			}
			else if (whereToFind is ProductArray)
			{
				return ((ProductArray)whereToFind).Workspace;
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

		private void RecalcularAltura(object sender, System.EventArgs e)
		{
			LabelSerialsCruz.Visible = LabelSerials.Visible;
			if (LabelSerials.Visible)
				this.Height = 44;
			else
				this.Height = 24;
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == ' ')
			{
				if(Articulo != null)
				{
					if (this.EstoyUsandoUnidadPrimaria())
					{
						//Cambio a unidad secundaria
						txtCantidad.Sufijo = Articulo["unidad_rend"].ToString();
						txtCantidad.Text = Lfx.Types.Formatting.FormatStock(Lfx.Types.Parsing.ParseStock(txtCantidad.Text) * System.Convert.ToDouble(Articulo["rendimiento"]));
					}
					else
					{
						//Cambio a unidad primaria
						txtCantidad.Sufijo = Articulo["unidad_stock"].ToString() == "u" ? "" : Articulo["unidad_stock"].ToString();
						txtCantidad.Text = Lfx.Types.Formatting.FormatStock(Lfx.Types.Parsing.ParseStock(txtCantidad.Text) / System.Convert.ToDouble(Articulo["rendimiento"]), 4);
					}
					e.Handled = true;
				}
			}
		}
	}
}
