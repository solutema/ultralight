#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
                {
                        InitializeComponent();

                        this.BorderStyle = BorderStyles.TextBox;
                        this.BackColor = TextBox1.BackColor;
                        TextBox1.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                        TextBox1.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;

                        EtiquetaPrefijo.Font = new Font(this.Font.Name, this.Font.Size * 0.8f);
                        EtiquetaSufijo.Font = EtiquetaPrefijo.Font;
                        EtiquetaPrefijo.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                        EtiquetaPrefijo.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                        EtiquetaSufijo.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                        EtiquetaSufijo.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                        
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
                                this.TextRaw = FormatearDatos(this.TextRaw);
                        }
                }

		public virtual string Prefijo
		{
			get
			{
				return EtiquetaPrefijo.Text;
			}
			set
			{
				this.SuspendLayout();
				EtiquetaPrefijo.Text = value;
				EtiquetaPrefijo.Visible = EtiquetaPrefijo.Text.Length > 0;
				TextBox_SizeChanged(this, null);
				this.ResumeLayout();
			}
		}

		public string Sufijo
		{
			get
			{
				return EtiquetaSufijo.Text;
			}
			set
			{
				this.SuspendLayout();
				EtiquetaSufijo.Text = value;
				EtiquetaSufijo.Visible = EtiquetaSufijo.Text.Length > 0;
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
				IgnoreChanges++;
                                this.TextRaw = FormatearDatos(this.TextRaw);
				IgnoreChanges--;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
				TextBox1.ReadOnly = (m_ReadOnly || m_TemporaryReadOnly || m_DataType == DataTypes.Set);
				switch (m_DataType)
				{
					case DataTypes.Float:
					case DataTypes.Integer:
					case DataTypes.Currency:
                                        case DataTypes.Stock:
						TextBox1.TextAlign = HorizontalAlignment.Right;
						break;
					default:
						TextBox1.TextAlign = HorizontalAlignment.Left;
						break;
				}
                                this.TextRaw = FormatearDatos(this.TextRaw);
			}
		}


                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public decimal ValueDecimal
                {
                        get
                        {
                                return this.Text.ParseDecimal();
                        }
                        set
                        {
                                this.TextRaw = FormatearDatos(value);
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public int ValueInt
                {
                        get
                        {
                                return Lfx.Types.Parsing.ParseInt(this.Text);
                        }
                        set
                        {
                                this.TextRaw = FormatearDatos(value);
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
                        try {
                                string DatosPortapapeles = System.Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text, true));
                                this.Text = FormatearDatos(DatosPortapapeles);
                        } catch {
                                // Nada
                        }
                }


		private void MenuItemCalculadora_Click(System.Object sender, System.EventArgs e)
		{
                        Lfx.Workspace.Master.RunTime.Execute("CALC", null);
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
			MenuItemCalendario.Visible = (this.TemporaryReadOnly == false && this.ReadOnly == false && (m_DataType == DataTypes.Date || m_DataType == DataTypes.DateTime));
			MenuItemHoy.Visible = MenuItemCalendario.Visible;
			MenuItemAyer.Visible = MenuItemCalendario.Visible;
			MenuItemCalculadora.Visible = (m_DataType == DataTypes.Float || m_DataType == DataTypes.Currency  || m_DataType == DataTypes.Stock || m_DataType == DataTypes.Integer);
			MenuItemCalculadora.Enabled = !(this.TemporaryReadOnly || this.ReadOnly);
			MenuItemEditor.Enabled = (this.TemporaryReadOnly == false && this.ReadOnly == false && m_DataType == DataTypes.FreeText && m_PasswordChar == Lfx.Types.ControlChars.Null);
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
						MenuItemPegar.Enabled = this.TemporaryReadOnly == false && this.ReadOnly == false && System.Text.RegularExpressions.Regex.IsMatch(DatosPortapapeles, @"^[0-3]\d(-|/)[0-1]\d(-|/)(\d{2}|\d{4})$");
					else if (m_DataType == DataTypes.Set)
						MenuItemPegar.Enabled = false;
					else
						MenuItemPegar.Enabled = this.TemporaryReadOnly == false && this.ReadOnly == false;
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
			this.Text = FormatearDatos(System.DateTime.Now);
		}


		private void MenuItemAyer_Click(System.Object sender, System.EventArgs e)
		{
			this.Text = FormatearDatos(System.DateTime.Now.AddDays(-1));
		}

		private void MostrarCalendario()
		{
			CalendarPopUp Calendario = new CalendarPopUp();
			if (this.Text.IsDate())
				Calendario.Calendar.CurrentDate = Lfx.Types.Parsing.ParseDate(this.Text).Value;
			if (Calendario.ShowDialog() == DialogResult.OK)
				this.Text = FormatearDatos(Calendario.Calendar.CurrentDate);
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
                        if (Lfx.Workspace.Master.MasterConnection != null) {
                                System.Data.DataTable QuickPastes = Lfx.Workspace.Master.MasterConnection.Select("SELECT texto FROM sys_quickpaste ORDER BY fecha DESC LIMIT 12");
                                foreach (System.Data.DataRow QuickPaste in QuickPastes.Rows) {
                                        System.Windows.Forms.MenuItem NuevoItem = new System.Windows.Forms.MenuItem();
                                        NuevoItem.Text = QuickPaste["texto"].ToString();
                                        NuevoItem.Click += new System.EventHandler(this.MenuItemPegadoRapidoTexto_Click);
                                        MenuItemPegadoRapido.MenuItems.Add(NuevoItem);
                                }
                        }
		}

		private void MenuItemPegadoRapidoAgregar_Click(object sender, System.EventArgs e)
		{
                        qGen.Insert Comando = new qGen.Insert("sys_quickpaste");
			Comando.Fields.AddWithValue("texto", this.Text);
			Comando.Fields.AddWithValue("estacion", System.Environment.MachineName.ToUpperInvariant());
			Comando.Fields.AddWithValue("usuario", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
			Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        this.Connection.Execute(Comando);
		}

		private void MenuItemPegadoRapidoTexto_Click(object sender, System.EventArgs e)
		{
			this.Text = FormatearDatos(((System.Windows.Forms.MenuItem)sender).Text);
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

                                if (m_SelectOnFocus && m_TemporaryReadOnly == false && this.ReadOnly == false) {
                                        TextBox1.SelectAll();
                                } else {
                                        TextBox1.SelectionStart = this.TextRaw.Length;
                                }
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public AutoCompleteStringCollection AutoCompleteStringCollection
                {
                        get
                        {
                                return TextBox1.AutoCompleteCustomSource;
                        }
                        set
                        {
                                TextBox1.AutoCompleteCustomSource = value;
                                if (value == null)
                                        TextBox1.AutoCompleteMode = AutoCompleteMode.None;
                                else
                                        TextBox1.AutoCompleteMode = AutoCompleteMode.Append;
                                TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        }
                }


                private string FormatearDatos(object datos)
                {
                        string Res = null;
                        switch (m_DataType) {
                                case DataTypes.Integer:
                                        long DatoInt;
                                        if (datos is Int16 || datos is Int32 || datos is Int64) {
                                                DatoInt = System.Convert.ToInt32(datos);
                                        } else {
                                                DatoInt = System.Convert.ToInt64(Lfx.Types.Evaluator.EvaluateDouble(datos.ToString()));
                                                
                                        }
                                        if (DatoInt > int.MaxValue || DatoInt < int.MinValue)
                                                Res = "0";
                                        else
                                                Res = System.Convert.ToInt32(DatoInt).ToString();
                                        break;

                                case DataTypes.Float:
                                        double DatoDouble;
                                        if (datos is double || datos is Single || datos is float)
                                                DatoDouble = System.Convert.ToDouble(datos);
                                        else
                                                DatoDouble = Lfx.Types.Evaluator.EvaluateDouble(datos.ToString());

                                        if (m_DecimalPlaces == -1)
                                                Res = Lfx.Types.Formatting.FormatNumber(DatoDouble, 4);
                                        else
                                                Res = Lfx.Types.Formatting.FormatNumber(DatoDouble, m_DecimalPlaces);
                                        break;

                                case DataTypes.Currency:
                                        decimal DatoDinero;
                                        if(datos is decimal || datos is double)
                                                DatoDinero = System.Convert.ToDecimal(datos);
                                        else
                                                DatoDinero =Lfx.Types.Evaluator.EvaluateDecimal(datos.ToString());

                                        if (m_DecimalPlaces == -1 && Lfx.Workspace.Master != null)
                                                Res = Lfx.Types.Formatting.FormatCurrency(DatoDinero, Lfx.Workspace.Master.CurrentConfig.Moneda.Decimales);
                                        else if (m_DecimalPlaces == -1)
                                                Res = Lfx.Types.Formatting.FormatCurrency(DatoDinero, 2);
                                        else
                                                Res = Lfx.Types.Formatting.FormatCurrency(DatoDinero, m_DecimalPlaces);
                                        break;

                                case DataTypes.Stock:
                                        decimal DatoStock;
                                        if(datos is decimal || datos is double)
                                                DatoStock = System.Convert.ToDecimal(datos);
                                        else
                                                DatoStock =Lfx.Types.Evaluator.EvaluateDecimal(datos.ToString());

                                        if (m_DecimalPlaces == -1 && Lfx.Workspace.Master != null)
                                                Res = Lfx.Types.Formatting.FormatCurrency(DatoStock, Lfx.Workspace.Master.CurrentConfig.Productos.DecimalesStock);
                                        else if (m_DecimalPlaces == -1)
                                                Res = Lfx.Types.Formatting.FormatCurrency(DatoStock, 2);
                                        else
                                                Res = Lfx.Types.Formatting.FormatCurrency(DatoStock, m_DecimalPlaces);
                                        break;

                                case DataTypes.Date:
                                        if (datos is DateTime) {
                                                Res = Lfx.Types.Formatting.FormatDate(System.Convert.ToDateTime(datos));
                                        } else {
                                                if (datos == null)
                                                        Res = "";
                                                else if (datos.ToString().IsDate())
                                                        // Reformateo la fecha
                                                        Res = Lfx.Types.Formatting.FormatDate(Lfx.Types.Parsing.ParseDate(datos.ToString()));
                                                else
                                                        Res = "";
                                        }
                                        break;

                                case DataTypes.DateTime:
                                        if (datos is DateTime) {
                                                Res = Lfx.Types.Formatting.FormatDateAndTime(System.Convert.ToDateTime(datos));
                                        } else {
                                                if (datos == null)
                                                        Res = "";
                                                else if (datos.ToString().IsDate())
                                                        // Reformateo la fecha
                                                        Res = Lfx.Types.Formatting.FormatDateAndTime(Lfx.Types.Parsing.ParseDate(datos.ToString()));
                                                else
                                                        Res = "";
                                        }
                                        break;

                                default:
                                        Res = datos.ToString().UnixToWindows();
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
                                        Res = Res.ToTitleCase();
                                        break;
                        }

                        return Res;
                }

                private void TextBox1_DoubleClick(object sender, System.EventArgs e)
                {
                        if (this.TemporaryReadOnly == false && this.ReadOnly == false) {
                                if (m_DataType == DataTypes.Date) {
                                        MostrarCalendario();
                                }
                        }
                }

                private void TextBox1_LostFocus(object sender, System.EventArgs e)
                {
                        if (IgnoreEvents == 0) {
                                string Res = FormatearDatos(this.TextRaw);
                                if (this.TextRaw != Res)
                                        this.TextRaw = Res;
                        }
                }

                private void TextBox1_GotFocus(object sender, System.EventArgs e)
                {
                        if (IgnoreEvents == 0 && this.TemporaryReadOnly == false && this.ReadOnly == false) {
                                if (m_SelectOnFocus && m_TemporaryReadOnly == false && this.ReadOnly == false)
                                        TextBox1.SelectAll();
                                else
                                        TextBox1.SelectionStart = this.TextRaw.Length;
                        }
                }


                private void TextBox_SizeChanged(object sender, System.EventArgs e)
                {
                        if (EtiquetaPrefijo.Visible) {
                                EtiquetaPrefijo.Top = (this.Height - EtiquetaPrefijo.Height) / 2;
                                TextBox1.Left = EtiquetaPrefijo.Left + EtiquetaPrefijo.Width + 2;
                        } else {
                                TextBox1.Left = 4;
                        }
                        if (EtiquetaSufijo.Visible) {
                                EtiquetaSufijo.Top = (this.Height - EtiquetaSufijo.Height) / 2;
                                EtiquetaSufijo.Left = this.Width - EtiquetaSufijo.Width - 4;
                        }
                        int SufijoWidth = 4;
                        if (EtiquetaSufijo.Visible)
                                SufijoWidth = EtiquetaSufijo.Width + 4;

                        TextBox1.Top = 4;
                        TextBox1.Width = this.Width - TextBox1.Left - SufijoWidth;
                        TextBox1.Height = this.Height - (TextBox1.Top * 2);
                }


                private void TextBox1_FontChanged(object sender, System.EventArgs e)
                {
                        EtiquetaPrefijo.Font = new Font(this.Font.Name, this.Font.Size * 0.8f);
                        EtiquetaSufijo.Font = EtiquetaPrefijo.Font;
                }


                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Font Font
                {
                        get
                        {
                                return TextBox1.Font;
                        }
                }

                
                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Font CustomFont
                {
                        get
                        {
                                return TextBox1.Font;
                        }
                        set
                        {
                                TextBox1.Font = value;
                        }
                }
	}
}
