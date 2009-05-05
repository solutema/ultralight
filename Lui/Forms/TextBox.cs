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
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
	[System.ComponentModel.DefaultEvent("TextChanged")]
        public partial class TextBox : TextBoxBase
	{
		protected internal bool m_SelectOnFocus = true;
                protected internal TextCasing m_ForceCase = TextCasing.None;
		protected internal char m_PasswordChar = Lfx.Types.ControlChars.Null;
		protected internal DataTypes m_DataType = DataTypes.FreeText;
		protected internal int m_DecimalPlaces = -1;

		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem MenuItemPegadoRapido;
		private System.Windows.Forms.MenuItem MenuItemPegadoRapidoAgregar;

                public TextBox()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        this.BorderStyle = BorderStyles.TextBox;
                        this.BackColor = TextBox1.BackColor;
                        TextBox1.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                        TextBox1.ForeColor = Lws.Config.Display.CurrentTemplate.ControlText;
                        lblPrefijo.ForeColor = Lws.Config.Display.CurrentTemplate.ControlText;
                        lblPrefijo.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                        lblSufijo.ForeColor = Lws.Config.Display.CurrentTemplate.ControlText;
                        lblSufijo.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                        this.SizeChanged += new System.EventHandler(this.TextBox_SizeChanged);
                        this.TextBox1.ContextMenu = this.MiContextMenu;
                        this.TextBox1.DoubleClick += new System.EventHandler(this.TextBox1_DoubleClick);
                        this.TextBox1.LostFocus += new System.EventHandler(this.TextBox1_LostFocus);
                        this.TextBox1.GotFocus += new System.EventHandler(this.TextBox1_GotFocus);
                }


                [System.ComponentModel.Category("Comportamiento")]
                public TextCasing ForceCase
                {
                        get
                        {
                                return m_ForceCase;
                        }
                        set
                        {
                                m_ForceCase = value;
                                TextBox1.Text = FormatearDatos(TextBox1.Text);
                        }
                }

		public virtual string Prefijo
		{
			get
			{
				return lblPrefijo.Text;
			}
			set
			{
				this.SuspendLayout();
				lblPrefijo.Text = value;
				lblPrefijo.Visible = lblPrefijo.Text.Length > 0;
				TextBox_SizeChanged(this, null);
				this.ResumeLayout();
			}
		}

		public string Sufijo
		{
			get
			{
				return lblSufijo.Text;
			}
			set
			{
				this.SuspendLayout();
				lblSufijo.Text = value;
				lblSufijo.Visible = lblSufijo.Text.Length > 0;
				TextBox_SizeChanged(this, null);
				this.ResumeLayout();
			}
		}

		public int DecimalPlaces
		{
			get
			{
				return m_DecimalPlaces;
			}
			set
			{
				m_DecimalPlaces = value;
				m_IgnoreChanges++;
				TextBox1.Text = FormatearDatos(TextBox1.Text);
				m_IgnoreChanges--;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int SelectionStart
		{
			get
			{
				return TextBox1.SelectionStart;
			}
			set
			{
				TextBox1.SelectionStart = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int SelectionLength
		{
			get
			{
				return TextBox1.SelectionLength;
			}
			set
			{
				TextBox1.SelectionLength = value;
			}
		}

		[System.ComponentModel.Category("Comportamiento")]
		public char PasswordChar
		{
			get
			{
				return m_PasswordChar;
			}
			set
			{
				m_PasswordChar = value;
				TextBox1.PasswordChar = m_PasswordChar;
                                if (m_PasswordChar != Lfx.Types.ControlChars.Null)
                                        this.MultiLine = false;
			}
		}

		[System.ComponentModel.Category("Comportamiento")]
		public bool MultiLine
		{
			get
			{
                                return TextBox1.Multiline;
			}
			set
			{
                                TextBox1.Multiline = value;
                                if (value)
                                        TextBox_SizeChanged(this, null);
			}
		}

		[System.ComponentModel.Category("Comportamiento")]
		public bool SelectOnFocus
		{
			get
			{
				return m_SelectOnFocus;
			}
			set
			{
				m_SelectOnFocus = value;
			}
		}

		[System.ComponentModel.Category("Comportamiento")]
		public virtual DataTypes DataType
		{
			get
			{
				return m_DataType;
			}
			set
			{
				m_DataType = value;
				TextBox1.ReadOnly = (m_ReadOnly || m_DataType == DataTypes.Set);
				switch (m_DataType)
				{
					case DataTypes.Float:
					case DataTypes.Integer:
					case DataTypes.Money:
						TextBox1.TextAlign = HorizontalAlignment.Right;
						break;
					default:
						TextBox1.TextAlign = HorizontalAlignment.Left;
						break;
				}
				TextBox1.Text = FormatearDatos(TextBox1.Text);
			}
		}

                private void MenuItemCopiar_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.SelectionLength > 0)
				Clipboard.SetDataObject(TextBox1.SelectedText);
			else
				Clipboard.SetDataObject(this.Text);
		}


		private void MenuItemPegar_Click(System.Object sender, System.EventArgs e)
		{
			string DatosPortapapeles = System.Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text, true));
			if (DatosPortapapeles != null)
				this.Text = DatosPortapapeles;
		}


		private void MenuItemCalculadora_Click(System.Object sender, System.EventArgs e)
		{
			this.Workspace.RunTime.Execute("CALC", null);
		}


		private void MenuItemEditor_Click(System.Object sender, System.EventArgs e)
		{
			Lui.Forms.AuxForms.TextEdit OFormEditorExtendido = new Lui.Forms.AuxForms.TextEdit();
			OFormEditorExtendido.Text = "Números de serie";
			OFormEditorExtendido.EditText = this.Text;
			if (OFormEditorExtendido.ShowDialog() == DialogResult.OK)
				this.Text = OFormEditorExtendido.EditText;
		}


		private void MiContextMenu_Popup(object sender, System.EventArgs e)
		{
			string DatosPortapapeles = System.Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text, true));
			MenuItemCalendario.Visible = (this.ReadOnly == false && (m_DataType == DataTypes.Date || m_DataType == DataTypes.DateTime));
			MenuItemHoy.Visible = MenuItemCalendario.Visible;
			MenuItemAyer.Visible = MenuItemCalendario.Visible;
			MenuItemCalculadora.Visible = (m_DataType == DataTypes.Float || m_DataType == DataTypes.Money || m_DataType == DataTypes.Integer);
			MenuItemCalculadora.Enabled = !this.ReadOnly;
			MenuItemEditor.Enabled = (this.ReadOnly == false && m_DataType == DataTypes.FreeText && m_PasswordChar == Lfx.Types.ControlChars.Null);
			MenuItemCopiar.Enabled = m_PasswordChar == Lfx.Types.ControlChars.Null && this.Text.Length > 0;
			if (m_PasswordChar == Lfx.Types.ControlChars.Null)
			{
				if (DatosPortapapeles == null || DatosPortapapeles.Length == 0)
				{
					MenuItemPegar.Enabled = false;
				}
				else
				{
					if (DatosPortapapeles.Length > 32)
						DatosPortapapeles = DatosPortapapeles.Substring(0, 32) + "...";

					MenuItemPegar.Text = @"Pegar """ + DatosPortapapeles + @"""";
					if (m_DataType == DataTypes.Date)
						MenuItemPegar.Enabled = this.ReadOnly == false && System.Text.RegularExpressions.Regex.IsMatch(DatosPortapapeles, @"^[0-3]\d(-|/)[0-1]\d(-|/)(\d{2}|\d{4})$");
					else if (m_DataType == DataTypes.Set)
						MenuItemPegar.Enabled = false;
					else
						MenuItemPegar.Enabled = this.ReadOnly == false;
				}
				MenuItemPegadoRapido.Enabled = this.MultiLine;
			}
			else
			{
				MenuItemPegar.Enabled = false;
				MenuItemPegadoRapido.Enabled = false;
			}
		}

		private void MenuItemHoy_Click(object sender, System.EventArgs e)
		{
			this.Text = Lfx.Types.Formatting.FormatDate(System.DateTime.Now);
		}


		private void MenuItemAyer_Click(System.Object sender, System.EventArgs e)
		{
			this.Text = Lfx.Types.Formatting.FormatDate(System.DateTime.Now.AddDays(-1));
		}

		private void MostrarCalendario()
		{
			CalendarPopUp Calendario = new CalendarPopUp();
			if (Lfx.Types.Strings.IsDate(this.Text))
				Calendario.Calendar.CurrentDate = Lfx.Types.Parsing.ParseDate(this.Text).Value;
			if (Calendario.ShowDialog() == DialogResult.OK)
				this.Text = Lfx.Types.Formatting.FormatDate(Calendario.Calendar.CurrentDate);
			Calendario.Close();
			Calendario = null;
		}



		private void MenuItemPegadoRapido_Popup(object sender, System.EventArgs e)
		{
			if (this.Text.Length == 0)
			{
				MenuItemPegadoRapidoAgregar.Text = "Agregar al menú";
				MenuItemPegadoRapidoAgregar.Enabled = false;
			}
			else
			{
				string MuestraTexto;
				if (this.TextBox1.SelectionLength > 0)
					MuestraTexto = this.TextBox1.SelectedText;
				else
					MuestraTexto = this.Text.Replace(System.Environment.NewLine, "");

				if (MuestraTexto.Length > 30)
					MuestraTexto = MuestraTexto.Substring(0, 30) + "...";
				MenuItemPegadoRapidoAgregar.Text = "Agregar \"" + MuestraTexto + "\" a este menú";
				MenuItemPegadoRapidoAgregar.Enabled = true;
			}

			for (int i = MenuItemPegadoRapido.MenuItems.Count - 1; i > 0; i--)
			{
				MenuItemPegadoRapido.MenuItems.RemoveAt(i);
			}
			if (this.Workspace != null)
			{
                                System.Data.DataTable QuickPastes = this.Workspace.DefaultDataView.DataBase.Select("SELECT texto FROM sys_quickpaste ORDER BY fecha DESC LIMIT 12");
				foreach (System.Data.DataRow QuickPaste in QuickPastes.Rows)
				{
					System.Windows.Forms.MenuItem NuevoItem = new System.Windows.Forms.MenuItem();
					NuevoItem.Text = QuickPaste["texto"].ToString();
					NuevoItem.Click += new System.EventHandler(this.MenuItemPegadoRapidoTexto_Click);
					MenuItemPegadoRapido.MenuItems.Add(NuevoItem);
				}
			}
		}

		private void MenuItemPegadoRapidoAgregar_Click(object sender, System.EventArgs e)
		{
			Lfx.Data.SqlInsertBuilder Comando = new Lfx.Data.SqlInsertBuilder(this.Workspace.DefaultDataView.DataBase, "sys_quickpaste");
			Comando.Fields.AddWithValue("texto", this.Text);
			Comando.Fields.AddWithValue("estacion", Lfx.Environment.SystemInformation.ComputerName);
			Comando.Fields.AddWithValue("usuario", this.Workspace.CurrentUser.UserId);
			Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
			this.Workspace.DefaultDataView.DataBase.Execute(Comando);
		}

		private void MenuItemPegadoRapidoTexto_Click(object sender, System.EventArgs e)
		{
			this.Text = ((System.Windows.Forms.MenuItem)sender).Text;
		}

                public override System.String Text
                {
                        get
                        {
                                return FormatearDatos(base.Text);
                        }
                        set
                        {
                                if (value == null)
                                        base.Text = FormatearDatos("");
                                else
                                        base.Text = FormatearDatos(value);

                                if (m_SelectOnFocus) {
                                        TextBox1.SelectionStart = 0;
                                        TextBox1.SelectionLength = TextBox1.Text.Length;
                                } else {
                                        TextBox1.SelectionStart = TextBox1.Text.Length;
                                }
                        }
                }

                private string FormatearDatos(string Dato)
                {
                        // IgnorarEventos++
                        string Res = null;
                        switch (m_DataType) {
                                case DataTypes.Integer:
                                        Res = System.Convert.ToInt32(Lfx.Types.Evaluator.EvaluateDouble(Dato)).ToString();
                                        break;
                                case DataTypes.Float:
                                        if (m_DecimalPlaces == -1)
                                                Res = Lfx.Types.Formatting.FormatNumber(Lfx.Types.Evaluator.EvaluateDouble(Dato), 2);
                                        else
                                                Res = Lfx.Types.Formatting.FormatNumber(Lfx.Types.Evaluator.EvaluateDouble(Dato), m_DecimalPlaces);
                                        break;
                                case DataTypes.Money:
                                        if (m_DecimalPlaces == -1 && this.Workspace != null)
                                                Res = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Evaluator.EvaluateDouble(Dato), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                        else if (m_DecimalPlaces == -1)
                                                Res = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Evaluator.EvaluateDouble(Dato), 2);
                                        else
                                                Res = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Evaluator.EvaluateDouble(Dato), m_DecimalPlaces);
                                        break;
                                case DataTypes.Date:
                                        Res = Lfx.Types.Formatting.FormatDate(Dato);
                                        break;
                                case DataTypes.DateTime:
                                        Res = Lfx.Types.Formatting.FormatDateAndTime(Dato);
                                        break;
                                default:
                                        Res = Dato;
                                        break;
                        }

                        switch (m_ForceCase) {
                                case TextCasing.LowerCase:
                                        Res = Res.ToLower();
                                        break;
                                case TextCasing.UpperCase:
                                        Res = Res.ToUpper();
                                        break;
                                case TextCasing.Caption:
                                        Res = Lfx.Types.Strings.ULCase(Res);
                                        break;
                        }

                        // IgnorarEventos--
                        return Res;
                }

                private void TextBox1_DoubleClick(object sender, System.EventArgs e)
                {
                        if (this.ReadOnly == false) {
                                if (m_DataType == DataTypes.Date) {
                                        MostrarCalendario();
                                }
                        }
                }

                private void TextBox1_LostFocus(object sender, System.EventArgs e)
                {
                        if (IgnorarEventos == 0) {
                                string Res = FormatearDatos(TextBox1.Text);
                                TextBox1.Text = Res;
                        }
                }

                private void TextBox1_GotFocus(object sender, System.EventArgs e)
                {
                        if (IgnorarEventos == 0 && this.ReadOnly == false) {
                                if (m_SelectOnFocus)
                                        TextBox1.SelectAll();
                                else
                                        TextBox1.SelectionStart = TextBox1.Text.Length;
                        }
                }

                private void TextBox_FontChanged(object sender, System.EventArgs e)
                {
                        lblPrefijo.Font = new Font(this.Font.Name, this.Font.Size * 0.8F);
                        lblSufijo.Font = new Font(this.Font.Name, this.Font.Size * 0.8F);
                }

                private void TextBox_SizeChanged(object sender, System.EventArgs e)
                {
                        if (lblPrefijo.Visible) {
                                lblPrefijo.Top = (this.Height - lblPrefijo.Height) / 2;
                                TextBox1.Left = lblPrefijo.Left + lblPrefijo.Width + 2;
                        } else {
                                TextBox1.Left = 4;
                        }
                        if (lblSufijo.Visible) {
                                lblSufijo.Top = (this.Height - lblSufijo.Height) / 2;
                                lblSufijo.Left = this.Width - lblSufijo.Width - 4;
                        }
                        int SufijoWidth = 4;
                        if (lblSufijo.Visible)
                                SufijoWidth = lblSufijo.Width + 4;

                        TextBox1.Top = 4;
                        TextBox1.Width = this.Width - TextBox1.Left - SufijoWidth;
                        TextBox1.Height = this.Height - (TextBox1.Top * 2);
                }
	}
}
