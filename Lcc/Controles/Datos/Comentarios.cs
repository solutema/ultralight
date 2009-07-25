using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Controles.Datos
{
        public partial class Comentarios : ControlDatos
        {
                public Comentarios()
                {
                        InitializeComponent();
                }

                public override void ActualizarControl()
                {
                        ListaComentarios.BeginUpdate();
                        ListaComentarios.Items.Clear();
                        Lfx.Data.SqlSelectBuilder SelectComentarios = new Lfx.Data.SqlSelectBuilder("sys_comments");
                        SelectComentarios.WhereClause = new Lfx.Data.SqlWhereBuilder();
                        SelectComentarios.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("tablas", this.Elemento.TablaDatos));
                        SelectComentarios.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("item_id", this.Elemento.Id));
                        SelectComentarios.Order = "fecha DESC";

                        System.Data.DataTable Comentarios = Elemento.DataView.DataBase.Select(SelectComentarios);
                        foreach (System.Data.DataRow Com in Comentarios.Rows) {
                                ListViewItem Itm = ListaComentarios.Items.Add(Com["id_comment"].ToString());
                                Itm.SubItems.Add(Lfx.Types.Formatting.FormatShortestDateAndTime(System.Convert.ToDateTime(Com["fecha"])));
                                Itm.SubItems.Add(this.Elemento.DataView.Tables["personas"].FastRows[System.Convert.ToInt32(Com["id_persona"])].Fields["nombre_visible"].Value.ToString());
                                Itm.SubItems.Add(Com["obs"].ToString());
                        }

                        ListaComentarios.EndUpdate();
                        base.ActualizarControl();
                }

                private void EntradaComentario_TextChanged(object sender, EventArgs e)
                {
                        BotonAgregar.Enabled = EntradaComentario.Text.Length > 5;
                }

                private void BotonAgregar_Click(object sender, EventArgs e)
                {
                        Lfx.Data.SqlInsertBuilder InsertarComentario = new Lfx.Data.SqlInsertBuilder("sys_comments");
                        InsertarComentario.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                        InsertarComentario.Fields.AddWithValue("tablas", this.Elemento.TablaDatos);
                        InsertarComentario.Fields.AddWithValue("item_id", this.Elemento.Id);
                        InsertarComentario.Fields.AddWithValue("id_persona", this.Workspace.CurrentUser.UserId);
                        InsertarComentario.Fields.AddWithValue("obs", EntradaComentario.Text);
                        this.Elemento.DataView.Execute(InsertarComentario);

                        ListaComentarios.BeginUpdate();
                        ListViewItem Itm = ListaComentarios.Items.Insert(0, new ListViewItem(new System.Random().Next().ToString()));
                        Itm.SubItems.Add(Lfx.Types.Formatting.FormatShortestDateAndTime(System.DateTime.Now));
                        Itm.SubItems.Add(this.Workspace.CurrentUser.UserCompleteName);
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
        }
}
