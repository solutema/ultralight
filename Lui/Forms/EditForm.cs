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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
	public partial class EditForm : Lui.Forms.ChildForm
	{
		public int m_Id;
		public bool m_Nuevo = true;
		public Form FormOpener;
		public System.Windows.Forms.Control ControlDestino;
		private bool m_ReadOnly = false;
                public Lbl.ElementoDeDatos CachedRow;

                public EditForm()
                        : base()
                {
                        InitializeComponent();

                        LowerPanel.BackColor = Lws.Config.Display.CurrentTemplate.FooterBackground;
                }

		public virtual bool ReadOnly
		{
			get
			{
				return m_ReadOnly;
			}
			set
			{
				m_ReadOnly = value;
				SaveButton.Visible = !m_ReadOnly;
                                if (value)
                                        CancelCommandButton.Text = "Cerrar";
                                else
                                        CancelCommandButton.Text = "Cancelar";
				this.SetControlsReadOnly(this.Controls, m_ReadOnly);
			}
		}

		public virtual Lfx.Types.OperationResult Create()
		{
			return new Lfx.Types.SuccessOperationResult();
		}

		public virtual Lfx.Types.OperationResult Edit(int itemId)
		{
			m_Nuevo = false;
                        m_Id = itemId;
			return new Lfx.Types.SuccessOperationResult();
		}

		public virtual Printing.ItemPrint FormatForPrinting(Printing.ItemPrint ImprimirItem)
		{
			ImprimirItem.Titulo = "ERROR: Formato no definido"; ImprimirItem.ParesAgregar("", "No se ha definido el formato de impresión para este tipo de elementos.", 1);
			return ImprimirItem;
		}

		public virtual Lfx.Types.OperationResult Print(bool DejaSeleccionarImpresora)
		{
			if (this.ValidateData().Success && this.Save().Success)
			{
				Printing.ItemPrint ImprimirItem = FormatForPrinting(new Printing.ItemPrint());

				// Determino la impresora que le corresponde
				string sImpresora = "";

				if (DejaSeleccionarImpresora)
				{
					Lui.Printing.PrinterSelectionDialog OSeleccionarImpresora = new Lui.Printing.PrinterSelectionDialog();
					OSeleccionarImpresora.VistaPrevia = true;

					if (OSeleccionarImpresora.ShowDialog() == DialogResult.OK)
						sImpresora = OSeleccionarImpresora.m_Resultado;

					OSeleccionarImpresora.Dispose();
				}
				else
				{
					sImpresora = this.Workspace.CurrentConfig.Printing.PreferredPrinter("Item");

					// Si es de carga manual, presento el formulario correspondiente
					if (this.Workspace.CurrentConfig.Printing.PrinterFeed("Item", "auto") == "auto")
					{
                                                Lbl.Impresion.ManualFeedDialog DialogCargaManual = new Lbl.Impresion.ManualFeedDialog();
						DialogCargaManual.DocumentName = "Item";

						// Muestro el nombre de la impresora
						if (sImpresora.Length > 0)
						{
							DialogCargaManual.PrinterName = sImpresora;
						}
						else
						{
							System.Drawing.Printing.PrinterSettings
								objPrint = new System.Drawing.Printing.PrinterSettings();
                                                        DialogCargaManual.PrinterName = objPrint.PrinterName;
						}

						if (DialogCargaManual.ShowDialog() == DialogResult.Cancel)
							return new Lfx.Types.FailureOperationResult("Operación cancelada");
					}
				}

				if (sImpresora == "lazaro!preview")
				{
					ImprimirItem.PrintController = new System.Drawing.Printing.PreviewPrintController();
					Lui.Printing.PrintPreviewForm VistaPrevia = new Lui.Printing.PrintPreviewForm();
					VistaPrevia.PrintPreview.Document = ImprimirItem;
					VistaPrevia.MdiParent = this.MdiParent;
					VistaPrevia.Show();
				}
				else
				{
					if (sImpresora.Length > 0)
					{
						ImprimirItem.PrinterSettings.PrinterName = sImpresora;
					}
					ImprimirItem.PrintController = new System.Drawing.Printing.StandardPrintController();
					ImprimirItem.Print();
				}

				ImprimirItem.Dispose();
			}

			return new Lfx.Types.SuccessOperationResult();
		}

		public virtual Lfx.Types.OperationResult ValidateData()
		{
			return new Lfx.Types.SuccessOperationResult();
		}

		public virtual Lfx.Types.OperationResult Save()
		{
                        if (this.ReadOnly)
                                return new Lfx.Types.FailureOperationResult("No se puede guardar porque es un formulario sólo-lectura");

                        Lfx.Types.OperationResult ValidateResult = this.ValidateData();
                        if (ValidateResult.Success == false)
                                return ValidateResult;

                        bool WasNew = m_Nuevo;
                        if (this.CachedRow != null) {
                                WasNew = !this.CachedRow.Existe;
                                this.CachedRow = this.ToRow();
                                bool WasInTransaction = this.CachedRow.DataView.InTransaction;
                                if (WasInTransaction == false)
                                        this.CachedRow.DataView.BeginTransaction();
                                ValidateResult = this.CachedRow.Guardar();
                                if (ValidateResult.Success) {
                                        if (WasInTransaction == false)
                                                this.CachedRow.DataView.Commit();
                                        m_Id = this.CachedRow.Id;
                                        m_Nuevo = false;
                                } else {
                                        if (WasInTransaction == false)
                                                this.CachedRow.DataView.RollBack();
                                }
                        } else if(Lfx.Environment.SystemInformation.DesignMode) {
                                // Devolver error para detectar código viejo (que no use CachedRow, ToFrom() y FromRow())
                                System.Console.WriteLine("Código obsoleto en " + this.Name);
                        }

                        if (ValidateResult.Success) {
                                SetControlsChanged(this.Controls, false);

                                if (WasNew && ControlDestino != null) {
                                        ControlDestino.Text = m_Id.ToString();
                                        ControlDestino.Focus();
                                }

                                if (FormOpener != null) {
                                        FormOpener.Focus();
                                        FormOpener.Activate();
                                }

                                this.DialogResult = DialogResult.OK;
                        }
                        return ValidateResult;
		}

		public virtual Lfx.Types.OperationResult Cancel()
		{
			this.Close();

			if (FormOpener != null)
			{
				FormOpener.Focus();
				FormOpener.Activate();
			}

			this.DialogResult = DialogResult.Cancel;
			return new Lfx.Types.SuccessOperationResult();
		}

                private void SaveButton_Click(object sender, System.EventArgs e)
                {
                        SaveButton.Enabled = false;

                        Lfx.Types.OperationResult Result = this.Save();

                        if (Result.Success == true) {
                                this.Close();
                        } else {
                                if (Result.Message != null && Result.Message.Length > 0)
                                        Lui.Forms.MessageBox.Show(Result.Message, "Error");
                                SaveButton.Enabled = true;
                        }
                }

		private void cmdCancelar_Click(object sender, System.EventArgs e)
		{
			Cancel();
		}

		private void FormTablaEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Alt == false && e.Control == false)
			{
				switch (e.KeyCode)
				{
					case Keys.F9:
						e.Handled = true;
						if (SaveButton.Enabled && SaveButton.Visible)
                                                        SaveButton.PerformClick();
						break;

					case Keys.Escape:
						e.Handled = true;
						Cancel();
						break;
				}
			}
			else if (e.Alt == false && e.Control == true)
			{
				// Teclas con Ctrl
				switch (e.KeyCode)
				{
					case Keys.R:
						e.Handled = true;
						Print(!e.Shift);
						break;
				}
			}
		}

		private void FormTablaEditar_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (SomethingChanged(this.Controls, true))
			{

				Lui.Forms.YesNoDialog OPreguna = new Lui.Forms.YesNoDialog("Si cierra el formulario en este momento, no se guardarán los cambios realizados (subrayados en color rojo). ¿Desea cerrar el formulario de todos modos y perder los cambios realizados?", "Hay cambios sin guardar");
				OPreguna.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;

				if (OPreguna.ShowDialog() == DialogResult.Cancel)
				{
					e.Cancel = true;
					SomethingChanged(this.Controls, false);
				}
				else
				{
					e.Cancel = false;
				}
			}
		}

		private bool SomethingChanged(System.Windows.Forms.Control.ControlCollection controls, bool showChanges)
		{
			bool Result = false;
			// Ver si algo cambió
			foreach (System.Windows.Forms.Control ctl in controls)
			{
				if (ctl == null)
				{
					//Nada
				}
				else if (ctl is Lui.Forms.ProductArray)
				{
					if (((Lui.Forms.ProductArray)ctl).Changed)
					{
						Result = true;
						((Lui.Forms.ProductArray)ctl).ShowChanged = showChanges;
					}
				}
				else if (ctl is Lui.Forms.Frame || ctl is System.Windows.Forms.Panel)
				{
					// Es un conteneder. Uso recursión
					if (SomethingChanged(ctl.Controls, showChanges))
					{
						Result = true;
					}
				}
				else if (ctl is Lui.Forms.Control)
				{
					if (((Lui.Forms.Control)ctl).Changed)
					{
						Result = true;
						((Lui.Forms.Control)ctl).ShowChanged = showChanges;
					}
				}
			}
			return Result;
		}

		internal void SetControlsReadOnly(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
		{
			// Pongo los Changed en False
			foreach (System.Windows.Forms.Control ctl in controles)
			{
				if (ctl == null)
				{
					//Nada
				}
				else if (ctl is Lui.Forms.Frame || ctl is System.Windows.Forms.Panel)
				{
					SetControlsReadOnly(ctl.Controls, newValue);
				}
				else if (ctl is Lui.Forms.Control)
				{
					((Lui.Forms.Control)ctl).ReadOnly = newValue;
				}

			}
		}

		internal void SetControlsChanged(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
		{
			// Pongo los Changed en False
			foreach (System.Windows.Forms.Control ctl in controles)
			{
				if (ctl == null)
				{
					//Nada
				}
				else if (ctl is Lui.Forms.ProductArray)
				{
					((Lui.Forms.ProductArray)ctl).Changed = newValue;
				}
				else if (ctl is Lui.Forms.Frame || ctl is System.Windows.Forms.Panel)
				{
					SetControlsChanged(ctl.Controls, newValue);
				}
				else if (ctl is Lui.Forms.Control)
				{
					((Lui.Forms.Control)ctl).Changed = newValue;
				}
			}
		}

		private void FormTablaEditar_Load(object sender, System.EventArgs e)
		{
                        if (this.MyToolBarButton != null)
                                this.MyToolBarButton.ImageIndex = 1;
		}

		private void EditForm_SizeChanged(object sender, System.EventArgs e)
		{
			CancelCommandButton.Left = LowerPanel.Width - CancelCommandButton.Width - 4;
			SaveButton.Left = CancelCommandButton.Left - SaveButton.Width - 4;
		}

                public virtual void FromRow(Lbl.ElementoDeDatos row)
                {
                        this.CachedRow = row;
                        this.m_Id = row.Id;
                }

                public virtual Lbl.ElementoDeDatos ToRow()
                {
                        return this.CachedRow;
                }
	}
}