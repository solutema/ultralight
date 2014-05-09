#region License
// Copyright 2004-2012 Ernesto N. Carrea
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
        public partial class FormularioListado : FormularioListadoBase
        {
                public FormularioListado()
                {
                        InitializeComponent();

                        Listado.BackColor = this.DisplayStyle.DataAreaColor;
                        Listado.BackColor = this.DisplayStyle.DataAreaColor;
                        Listado.ForeColor = this.DisplayStyle.TextColor;
                }


                public FormularioListado(Lazaro.Pres.Listings.Listing definicion)
                        : this()
                {
                        this.Definicion = definicion;
                }


                protected override void OnCreateControl()
                {
                        if (this.HabilitarBusqueda == true && Lfx.Workspace.Master != null && Lfx.Workspace.Master.RunTime != null)
                                Lfx.Workspace.Master.RunTime.Hint("Utilice el cuadro que se encuentra arriba a la izquierda para encontrar rápidamente un elemento.", this.Text);
                        base.OnCreateControl();
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool HabilitarBusqueda
                {
                        get
                        {
                                return EntradaBuscar.Visible;
                        }
                        set
                        {
                                EntradaBuscar.Visible = value;
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool HabilitarCrear
                {
                        get
                        {
                                return BotonCrear.Visible;
                        }
                        set
                        {
                                BotonCrear.Visible = value;
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool CheckBoxes
                {
                        get
                        {
                                return Listado.CheckBoxes;
                        }
                        set
                        {
                                Listado.CheckBoxes = value;
                                if (Listado.Columns.Count > 0)
                                        Listado.Columns[0].Width = value ? 24 : 0;
                        }
                }


                public virtual Lbl.IElementoDeDatos Crear()
                {
                        Lbl.IElementoDeDatos El = Lbl.Instanciador.Instanciar(this.Definicion.ElementoTipo, Lfx.Workspace.Master.GetNewConnection("Crear " + this.Definicion.ElementoTipo.ToString()));
                        El.Crear();
                        return El;
                }


                public virtual Lfx.Types.OperationResult OnCreate()
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(this.Definicion.ElementoTipo, Lbl.Sys.Permisos.Operaciones.Crear)) {
                                Lbl.IElementoDeDatos NuevoElem = this.Crear();
                                if (NuevoElem == null)
                                        return new Lfx.Types.CancelOperationResult();

                                Lfc.FormularioEdicion FormNuevo = Lfc.Instanciador.InstanciarFormularioEdicion(NuevoElem);
                                if (FormNuevo != null) {
                                        FormNuevo.MdiParent = this.MdiParent;
                                        FormNuevo.Show();

                                        return new Lfx.Types.SuccessOperationResult();
                                } else {
                                        return new Lfx.Types.FailureOperationResult("No se puede crear el elemento");
                                }
                        } else {
                                return new Lfx.Types.NoAccessOperationResult();
                        }
                }


                private void BotonCrear_Click(object sender, System.EventArgs e)
                {
                        Lfx.Types.OperationResult Res = this.OnCreate();
                        if (Res.Success == false && Res.Message != null)
                                Lui.Forms.MessageBox.Show(Res.Message, "Error");
                }

                private void Listado_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Shift == false && e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case Keys.F3:
                                                e.Handled = true;
                                                EntradaBuscar.Focus();
                                                break;
                                }
                        }
                }


                private void Listado_SelectedIndexChanged(object sender, System.EventArgs e)
                {
                        this.ItemSelected(this.Listado.SelectedItems[0]);
                }

                public virtual void ItemSelected(ListViewItem itm)
                {
                        Lfx.Workspace.Master.RunTime.Info("ITEMFOCUS", new string[] { "TABLE", this.Definicion.TableName, itm.Text });
                }


                private void EntradaBuscar_KeyDown(object sender, KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Return:
                                        e.Handled = true;
                                        // Fuerzo volver a cargar el listado
                                        this.SearchText = null;
                                        this.Search(EntradaBuscar.Text);
                                        break;
                        }
                }

                private void EntradaBuscar_TextChanged(object sender, System.EventArgs e)
                {
                        TimerBuscar.Stop();
                        TimerBuscar.Start();
                }

                private void TimerBuscar_Tick(object sender, System.EventArgs e)
                {
                        TimerBuscar.Stop();
                        if (EntradaBuscar.Text.Length == 0 || EntradaBuscar.Text.Length > 5 || this.SearchText.Length > 0){
                                // Si el texto a buscar está en blaco, o es de más de 5 caracteres,
                                // o es de menos de 5 pero hay un texto previo (vengo borrando con backspace)
                                if (EntradaBuscar.Text != this.SearchText) {
                                        this.Search(EntradaBuscar.Text);
                                }
                        }
                }


                protected override void OnBeginRefreshList()
                {
                        EtiquetaListadoVacio.Visible = false;
                        base.OnBeginRefreshList();
                }


                protected override void OnEndRefreshList()
                {
                        if (Listado.Items.Count == 0) {
                                if (this.HabilitarCrear)
                                        EtiquetaListadoVacio.Text = "El listado no contiene datos." + System.Environment.NewLine + "Haga clic en el botón 'Crear' para crear uno nuevo";
                                else
                                        EtiquetaListadoVacio.Text = "El listado no contiene datos.";

                                EtiquetaListadoVacio.Visible = true;
                                EtiquetaListadoVacio.BringToFront();
                        }
                        base.OnEndRefreshList();
                }

                private void EtiquetaListadoVacio_Click(object sender, System.EventArgs e)
                {
                        if (BotonCrear.Visible && BotonCrear.Enabled)
                                BotonCrear.PerformClick();
                }
        }
}