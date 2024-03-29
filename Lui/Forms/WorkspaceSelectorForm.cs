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
using System.Windows.Forms;

namespace Lui.Forms
{
        public partial class WorkspaceSelectorForm : Lui.Forms.DialogForm
        {
                private string m_WorkspaceName = null;

                public WorkspaceSelectorForm()
                {
                        InitializeComponent();
                        CancelCommandButton.Text = "Cancelar";
                        Espacios.Font = Lazaro.Pres.DisplayStyles.Template.Current.DefaultFont;
                }


                protected override void OnActivated(EventArgs e)
                {
                        base.OnActivated(e);

                        Espacios.Items.Clear();
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationDataFolder);
                        foreach (System.IO.FileInfo NombreEspacio in Dir.GetFiles("*.lwf")) {
                                string Nombre = NombreEspacio.Name.Replace(".lwf", "");
                                if (Nombre == "default")
                                        Nombre = "Predeterminado";
                                if (Nombre == Nombre.ToLower() || Nombre == Nombre.ToUpper())
                                        Nombre = Nombre.ToTitleCase();

                                Espacios.Items.Add(Nombre);
                                if (Nombre == "Predeterminado")
                                        Espacios.SelectedIndex = Espacios.Items.Count - 1;
                        }
                        if (Espacios.Items.Count > 0 && Espacios.SelectedIndex < 0)
                                Espacios.SelectedIndex = 0;
                }


                private void Espacios_SelectedValueChanged(object sender, System.EventArgs e)
                {
                        if (Espacios.SelectedItem != null) {
                                m_WorkspaceName = Espacios.SelectedItem.ToString();
                                this.OkButton.Enabled = true;
                        } else {
                                this.OkButton.Enabled = false;
                        }
                }


                public string WorkspaceName
                {
                        get
                        {
                                if (m_WorkspaceName == "Predeterminado")
                                        return "default";
                                else
                                        return m_WorkspaceName;
                        }
                }


                private void Espacios_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.Control == false && e.Alt == false) {
                                switch (e.KeyCode) {
                                        case Keys.Return:
                                                e.Handled = true;
                                                if (OkButton.Enabled && OkButton.Visible)
                                                        OkButton.PerformClick();
                                                break;
                                }
                        }
                }
        }
}