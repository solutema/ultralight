#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Edicion
{
        public partial class Etiquetas : Lcc.Edicion.ControlEdicion
        {
                public Etiquetas()
                {
                        InitializeComponent();

                        this.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                        GroupLabel.BackColor = Lfx.Config.Display.CurrentTemplate.Header2Background;
                        GroupLabel.ForeColor = Lfx.Config.Display.CurrentTemplate.Header2Text;
                }

                public override string Text
                {
                        get
                        {
                                return GroupLabel.Text;
                        }
                        set
                        {
                                GroupLabel.Text = value;
                                base.Text = value;
                        }
                }

                private void Lista_ItemChecked(object sender, ItemCheckedEventArgs e)
                {
                        /* int ItemId = Lfx.Types.Parsing.ParseInt(e.Item.Text);
                        if (ItemId != 0) {
                                if(e.Item.Checked) {
                                        //Agrego
                                        if(Elemento.Etiquetas.Contains(ItemId) == false)
                                                m_Elemento.Etiquetas.Add(new Lbl.Etiqueta(m_Elemento.DataBase, ItemId));
                                } else {
                                        //Lo quito
                                        if (Elemento.Etiquetas.Contains(ItemId))
                                                m_Elemento.Etiquetas.RemoveById(ItemId);
                                }
                        } */
                }

                public override void ActualizarControl()
                {
                        Lista.SuspendLayout();
                        Lista.Items.Clear();
                        Lfx.Data.Table TablaEtiquetas = this.Connection.Tables["sys_labels"];
                        TablaEtiquetas.PreLoad();
                        foreach (Lfx.Data.Row Rw in TablaEtiquetas.FastRows.Values) {
                                Lbl.Etiqueta Eti = new Lbl.Etiqueta(this.Connection, Rw);
                                if (Eti.TablaReferencia == m_Elemento.TablaDatos) {
                                        ListViewItem Itm = Lista.Items.Add(Eti.Id.ToString());
                                        Itm.SubItems.Add(Eti.Nombre);
                                        if (Elemento.Etiquetas.Contains(Eti.Id))
                                                Itm.Checked = true;
                                }
                        }
                        Lista.ResumeLayout();

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        foreach (ListViewItem Itm in Lista.Items) {
                                int ItemId = Lfx.Types.Parsing.ParseInt(Itm.Text);
                                if (ItemId != 0) {
                                        if (Itm.Checked) {
                                                //Agrego
                                                if (Elemento.Etiquetas.Contains(ItemId) == false)
                                                        m_Elemento.Etiquetas.Add(new Lbl.Etiqueta(m_Elemento.Connection, ItemId));
                                        } else {
                                                //Lo quito
                                                if (Elemento.Etiquetas.Contains(ItemId))
                                                        m_Elemento.Etiquetas.RemoveById(ItemId);
                                        }
                                }
                        }
                        base.ActualizarElemento();
                }
        }
}
