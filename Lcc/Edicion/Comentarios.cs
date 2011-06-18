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
        public partial class Comentarios : ControlDeDatos
        {
                public Comentarios()
                {
                        InitializeComponent();

                        this.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                        GroupLabel.BackColor = Lfx.Config.Display.CurrentTemplate.Header2Background;
                        GroupLabel.ForeColor = Lfx.Config.Display.CurrentTemplate.Header2Text;
                }

                public override void ActualizarControl()
                {
                        ListaComentarios.BeginUpdate();
                        ListaComentarios.Items.Clear();
                        qGen.Select SelectComentarios = new qGen.Select("sys_comments");
                        SelectComentarios.WhereClause = new qGen.Where();
                        SelectComentarios.WhereClause.Add(new qGen.ComparisonCondition("tablas", this.Elemento.TablaDatos));
                        SelectComentarios.WhereClause.Add(new qGen.ComparisonCondition("item_id", this.Elemento.Id));
                        SelectComentarios.Order = "fecha DESC";

                        System.Data.DataTable Comentarios = Elemento.Connection.Select(SelectComentarios);
                        foreach (System.Data.DataRow Com in Comentarios.Rows) {
                                ListViewItem Itm = ListaComentarios.Items.Add(Com["id_comment"].ToString());
                                Itm.SubItems.Add(Lfx.Types.Formatting.FormatShortSmartDateAndTime(System.Convert.ToDateTime(Com["fecha"])));
                                Itm.SubItems.Add(this.Elemento.Connection.Tables["personas"].FastRows[System.Convert.ToInt32(Com["id_persona"])].Fields["nombre_visible"].Value.ToString());
                                Itm.SubItems.Add(Com["obs"].ToString());
                        }

                        ListaComentarios.EndUpdate();

                        EntradaComentario.Enabled = this.Elemento.Existe;

                        base.ActualizarControl();
                }

                private void EntradaComentario_TextChanged(object sender, EventArgs e)
                {
                        BotonAgregar.Enabled = EntradaComentario.Text.Length > 5;
                }

                private void BotonAgregar_Click(object sender, EventArgs e)
                {
                        this.Elemento.Connection.BeginTransaction();
                        this.Elemento.AgregarComentario(EntradaComentario.Text);
                        this.Elemento.Connection.Commit();

                        ListaComentarios.BeginUpdate();
                        ListViewItem Itm = ListaComentarios.Items.Insert(0, new ListViewItem(new System.Random().Next().ToString()));
                        Itm.SubItems.Add(Lfx.Types.Formatting.FormatSmartDateAndTime(System.DateTime.Now));
                        Itm.SubItems.Add(Lbl.Sys.Config.Actual.UsuarioConectado.Persona.Nombre);
                        Itm.SubItems.Add(EntradaComentario.Text);
                        ListaComentarios.EndUpdate();

                        EntradaComentario.Text = "";
                }

                private void EntradaComentario_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Return) {
                                e.Handled = true;
                                BotonAgregar.PerformClick();
                        }
                }

                private void ListaComentarios_SizeChanged(object sender, EventArgs e)
                {
                        ColComentario.Width = -2;
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

                public override bool TemporaryReadOnly
                {
                        get
                        {
                                return base.TemporaryReadOnly;
                        }
                        set
                        {
                                // Los comentarios nunca son ReadOnly
                                base.TemporaryReadOnly = false;
                        }
                }
        }
}
