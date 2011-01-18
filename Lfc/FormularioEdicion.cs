#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
using System.ComponentModel;
using System.Windows.Forms;

namespace Lfc
{
        public partial class FormularioEdicion : Lui.Forms.ChildForm
        {
                public Form FormOpener;
                public System.Windows.Forms.Control ControlDestino;
                public Lbl.IElementoDeDatos Elemento;
                public Type ElementoTipo = null;

                private bool MuestraPanel = true;
                private bool m_ReadOnly = false;

                public FormularioEdicion()
                {
                        InitializeComponent();

                        LowerPanel.BackColor = Lfx.Config.Display.CurrentTemplate.FooterBackground;
                }

                private Lcc.Edicion.ControlEdicion m_ControlUnico = null;

                public Lcc.Edicion.ControlEdicion ControlUnico
                {
                        get
                        {
                                return this.m_ControlUnico;
                        }
                        set
                        {
                                if (m_ControlUnico != null && this.Controls.Contains(m_ControlUnico))
                                        this.Controls.Remove(m_ControlUnico);

                                m_ControlUnico = value;
                                this.ElementoTipo = m_ControlUnico.ElementoTipo;

                                this.SuspendLayout();
                                this.SplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(12);
                                this.SplitContainer.Visible = true;
                                m_ControlUnico.TabIndex = 0;
                                m_ControlUnico.Dock = System.Windows.Forms.DockStyle.Fill;
                                this.SplitContainer.Panel1.AutoScrollMinSize = m_ControlUnico.MinimumSize;
                                this.SplitContainer.Panel1.Controls.Add(m_ControlUnico);
                                this.ResumeLayout();
                                this.PerformLayout();

                                m_ControlUnico.SaveRequest += new Lcc.LccEventHandler(this.ControlUnico_SaveRequest);
                        }
                }

                private void ControlUnico_SaveRequest(object sender, ref Lcc.LccEventArgs e)
                {
                        e.Result = this.Save();
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public virtual bool SaveEnable
                {
                        get
                        {
                                return BotonGuardar.Visible && BotonGuardar.Enabled;
                        }
                        set
                        {
                                this.BotonGuardar.Visible = value;
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public virtual bool ReadOnly
                {
                        get
                        {
                                return m_ReadOnly;
                        }
                        set
                        {
                                m_ReadOnly = value;
                                this.SaveEnable = !m_ReadOnly;
                                if (value)
                                        BotonCancelar.Text = "Cerrar";
                                else
                                        BotonCancelar.Text = "Cancelar";
                                this.SetControlsReadOnly(this.Controls, m_ReadOnly);
                        }
                }


                public Lfx.Types.OperationResult Save()
                {
                        if (this.ReadOnly)
                                return new Lfx.Types.FailureOperationResult("No se puede guardar porque es un formulario sólo-lectura");

                        Lfx.Types.OperationResult Resultado = this.ControlUnico.ValidarControl();
                        if (Resultado.Success == false)
                                return Resultado;

                        Resultado = this.ControlUnico.BeforeSave();
                        if (Resultado.Success == false)
                                return Resultado;

                        bool WasNew = !this.Elemento.Existe;
                        this.Elemento = this.ToRow();
                        if (this.GetControlsChanged(this.Controls, false) || this.Elemento.Modificado) {
                                // Guardo sólo si hubo cambios
                                bool WasInTransaction = this.Elemento.Connection.InTransaction;
                                if (WasInTransaction == false)
                                        this.Elemento.Connection.BeginTransaction(true);
                                try {
                                        Resultado = this.Elemento.Guardar();
                                } catch {
                                        this.Elemento.Connection.RollBack();
                                        throw;
                                }
                                if (Resultado.Success) {
                                        this.ControlUnico.AfterSave();
                                        if (WasInTransaction == false)
                                                this.Elemento.Connection.Commit();
                                } else {
                                        if (WasInTransaction == false)
                                                this.Elemento.Connection.RollBack();
                                }
                        }

                        if (Resultado.Success) {
                                this.SetControlsChanged(this.Controls, false);

                                if (WasNew) {
                                        if (ControlDestino != null) {
                                                ControlDestino.Text = this.Elemento.Id.ToString();
                                                ControlDestino.Focus();
                                        }

                                        Lbl.Atributos.MuestraMensajeAlCrear AttrMuestraMsg = this.ElementoTipo.GetAttribute<Lbl.Atributos.MuestraMensajeAlCrear>();
                                        if (AttrMuestraMsg != null && AttrMuestraMsg.Muestra)
                                                Lui.Forms.MessageBox.Show("Acaba de crear " + this.Elemento.ToString(), "Crear");
                                }

                                if (FormOpener != null) {
                                        FormOpener.Focus();
                                        FormOpener.Activate();
                                }

                                this.DialogResult = DialogResult.OK;
                        }
                        return Resultado;
                }

                public virtual Lfx.Types.OperationResult Cancel()
                {
                        this.Close();

                        if (FormOpener != null) {
                                FormOpener.Focus();
                                FormOpener.Activate();
                        }

                        this.DialogResult = DialogResult.Cancel;
                        return new Lfx.Types.SuccessOperationResult();
                }

                private void SaveButton_Click(object sender, System.EventArgs e)
                {
                        if (BotonGuardar.Visible && BotonGuardar.Enabled) {
                                BotonGuardar.Enabled = false;

                                Lfx.Types.OperationResult Result = this.Save();

                                if (Result.Success == true) {
                                        this.Close();
                                } else {
                                        if (Result.Message != null && Result.Message.Length > 0)
                                                Lui.Forms.MessageBox.Show(Result.Message, "Error");
                                        BotonGuardar.Enabled = true;
                                }
                        }
                }

                private void CancelButton_Click(object sender, System.EventArgs e)
                {
                        Cancel();
                }

                private void EditForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == true) {
                                // Teclas con Ctrl
                                switch (e.KeyCode) {
                                        case Keys.R:
                                                e.Handled = true;
                                                // TODO: Print(!e.Shift);
                                                break;
                                }
                        }
                }

                private void EditForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
                {
                        if (this.GetControlsChanged(this.Controls, true)) {
                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Si cierra el formulario en este momento, no se guardarán los cambios realizados (subrayados en color rojo). ¿Desea cerrar el formulario de todos modos y perder los cambios realizados?", "Hay cambios sin guardar");
                                Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;

                                if (Pregunta.ShowDialog() == DialogResult.Cancel) {
                                        e.Cancel = true;
                                        this.GetControlsChanged(this.Controls, false);
                                } else {
                                        e.Cancel = false;
                                }
                        }
                }

                /// <summary>
                /// Pongo la propiedad ReadOnly de los controles hijos en cascada.
                /// </summary>
                internal void SetControlsReadOnly(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
                {
                        if (controles == null)
                                return;

                        foreach (System.Windows.Forms.Control ctl in controles) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is Lui.Forms.Control) {
                                        ((Lui.Forms.Control)ctl).ReadOnly = newValue;
                                } else if (ctl.Controls != null && ctl.Controls.Count > 0) {
                                        SetControlsReadOnly(ctl.Controls, newValue);
                                }
                        }
                }

                private void EditForm_Load(object sender, System.EventArgs e)
                {
                        if (this.MyToolBarButton != null)
                                this.MyToolBarButton.ImageIndex = 1;
                }

                public void FromRow(Lbl.IElementoDeDatos row)
                {
                        // Si todavía no conozco el tipo de elemento de este formulario, lo tomo de row
                        if (this.ElementoTipo == null || this.ElementoTipo == typeof(Lbl.ElementoDeDatos))
                                this.ElementoTipo = row.GetType();

                        this.ReadOnly = true;
                        this.Connection = row.Connection;
                        this.Elemento = row;

                        BotonHistorial.Visible = this.Elemento.Existe && Lbl.Sys.Config.Actual.UsuarioConectado.TieneAccesoGlobal();
                        BotonComentarios.Visible = this.Elemento.Existe;

                        Lbl.Atributos.MuestraPanelExtendido AttrMuestraPanel = this.ElementoTipo.GetAttribute<Lbl.Atributos.MuestraPanelExtendido>();
                        if (AttrMuestraPanel != null)
                                MuestraPanel = AttrMuestraPanel.Muestra;

                        if (this.ControlUnico != null) {
                                this.ControlUnico.FromRow(row);
                                if (this.MuestraPanel) {
                                        SplitContainer.Panel2Collapsed = false;
                                        SplitContainer.Panel2.Show();
                                        if (row is Lbl.IElementoConImagen) {
                                                EntradaImagen.Elemento = row;
                                                EntradaImagen.ActualizarControl();
                                                EntradaImagen.Visible = true;
                                        } else {
                                                EntradaImagen.Visible = false;
                                        }

                                        EntradaComentarios.Elemento = row;
                                        EntradaTags.Elemento = row;

                                        EntradaComentarios.ActualizarControl();
                                        EntradaTags.ActualizarControl();
                                } else {
                                        SplitContainer.Panel2Collapsed = true;
                                        SplitContainer.Panel2.Hide();
                                }
                        }

                        if (row != null && row.Existe) {
                                this.Text = row.ToString();
                        } else {
                                Lbl.Atributos.NombreItem Attr = this.ElementoTipo.GetAttribute<Lbl.Atributos.NombreItem>();
                                if (Attr != null)
                                        this.Text = Attr.Nombre + " nuevo";
                                else
                                        this.Text = row.GetType().ToString() + " nuevo";
                        }

                        this.ReadOnly = !this.PuedeEditar();
                        BotonImprimir.Visible = this.PuedeImprimir();
                        this.SetControlsChanged(this.Controls, false);
                }

                public virtual Lbl.IElementoDeDatos ToRow()
                {
                        if (this.ControlUnico != null) {
                                Lbl.IElementoDeDatos Res = this.ControlUnico.ToRow();
                                if (this.MuestraPanel) {
                                        if (Res is Lbl.IElementoConImagen)
                                                EntradaImagen.ActualizarElemento();
                                        //EntradaComentarios.ActualizarElemento();
                                        EntradaTags.ActualizarElemento();
                                }
                                return Res;
                        } else {
                                return this.Elemento;
                        }
                }

                private void BotonHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        this.Workspace.RunTime.Execute("HISTORIAL", new string[] { this.Elemento.TablaDatos, this.Elemento.Id.ToString() });
                }

                public virtual bool PuedeEditar()
                {
                        if (this.ControlUnico == null)
                                return false;
                        else
                                return this.ControlUnico.PuedeEditar();
                }

                public virtual bool PuedeImprimir()
                {
                        if (this.ControlUnico == null)
                                return false;
                        else
                                return this.ControlUnico.PuedeImprimir();
                }

                private void BotonComentarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        if (this.Elemento != null && this.Elemento.Existe) {
                                Lfc.Etiquetas FormularioEtiquetas = new Lfc.Etiquetas();
                                FormularioEtiquetas.Elemento = this.Elemento;
                                FormularioEtiquetas.Show();
                        }
                }

                private void BotonImprimir_Click(object sender, EventArgs e)
                {
                        Lfx.Types.OperationResult Res;
                        if (this.ReadOnly) {
                                Res = new Lfx.Types.SuccessOperationResult();
                        } else {
                                if (this.Elemento.Existe == false) {
                                        // Si es nuevo, lo guardo sin preguntar.
                                        Res = this.Save();
                                } else if (this.Changed) {
                                        // Si es edición, y hay cambios, pregunto si quiere guardar
                                        using (Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Hay modificaciones sin guardar. Antes de imprimir el elemento, se guardarán las modificaciones automáticamente. ¿Desea continuar?", "Imprimir")) {
                                                if (Pregunta.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                                                        Res = this.Save();
                                                } else {
                                                        Res = new Lfx.Types.CancelOperationResult();
                                                }
                                        }
                                } else {
                                        // Es edición y no hay cambios... continúo
                                        Res = new Lfx.Types.SuccessOperationResult();
                                }
                        }

                        if (Res.Success)
                                Res = this.ControlUnico.BeforePrint();

                        if (Res.Success) {
                                Lbl.Impresion.Impresora Impresora = null;
                                if ((System.Windows.Forms.Control.ModifierKeys & Keys.Shift) == Keys.Shift) {
                                        using (Lui.Printing.PrinterSelectionDialog FormularioSeleccionarImpresora = new Lui.Printing.PrinterSelectionDialog()) {
                                                if (FormularioSeleccionarImpresora.ShowDialog() == DialogResult.OK) {
                                                        Impresora = FormularioSeleccionarImpresora.SelectedPrinter;
                                                } else {
                                                        return;
                                                }
                                        }
                                }

                                if (Impresora != null && Impresora.CargaPapel == Lbl.Impresion.CargasPapel.Manual) {
                                        Lui.Printing.ManualFeedDialog FormularioCargaManual = new Lui.Printing.ManualFeedDialog();
                                        FormularioCargaManual.DocumentName = Elemento.ToString();
                                        // Muestro el nombre de la impresora
                                        if (Impresora != null) {
                                                FormularioCargaManual.PrinterName = Impresora.Nombre;
                                        } else {
                                                System.Drawing.Printing.PrinterSettings objPrint = new System.Drawing.Printing.PrinterSettings();
                                                FormularioCargaManual.PrinterName = objPrint.PrinterName;
                                        }
                                        if (FormularioCargaManual.ShowDialog() == DialogResult.Cancel)
                                                return;
                                }

                                Lazaro.Impresion.ImpresorElemento Impresor = Lazaro.Impresion.Instanciador.InstanciarImpresor(this.Elemento);

                                if (Impresora != null && Impresora.EsVistaPrevia) {
                                        Impresor.PrintController = new System.Drawing.Printing.PreviewPrintController();
                                        Lui.Printing.PrintPreviewForm VistaPrevia = new Lui.Printing.PrintPreviewForm();
                                        VistaPrevia.MdiParent = this.ParentForm.MdiParent;
                                        VistaPrevia.PrintPreview.Document = Impresor;
                                        VistaPrevia.Show();
                                } else {
                                        Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Imprimiendo", "El documento se está enviando a la impresora.");
                                        if (Impresora != null)
                                                Progreso.Description = "El documento se está enviando a la impresora " + Impresora.ToString();
                                        Progreso.Begin();

                                        Impresor.Impresora = Impresora;
                                        this.Elemento.Connection.BeginTransaction();
                                        Res = Impresor.Imprimir();
                                        Progreso.End();
                                        if (Res.Success == false) {
                                                if (this.Elemento.Connection.InTransaction)
                                                        // Puede que la transacción ya haya sido finalizada por el impresor
                                                        this.Elemento.Connection.RollBack();
                                                Lui.Forms.MessageBox.Show(Res.Message, "Error");
                                        } else {
                                                if (this.Elemento.Connection.InTransaction)
                                                        // Puede que la transacción ya haya sido finalizada por el impresor
                                                        this.Elemento.Connection.Commit();
                                                this.Elemento.Cargar();
                                                this.FromRow(this.Elemento);
                                                this.ControlUnico.AfterPrint();
                                        }
                                }
                        } else if (Res.Message != null) {
                                Lui.Forms.MessageBox.Show(Res.Message, "Imprimir");
                        }
                }
        }
}