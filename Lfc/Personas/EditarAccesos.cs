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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Personas
{
	public partial class EditarAccesos : Lui.Forms.EditForm
	{
		bool IgnorarEventos;
                private System.Collections.ArrayList NewAccessList = new System.Collections.ArrayList();

                public EditarAccesos()
                {
                        InitializeComponent();
                }


		class AccessListEntry
		{
			public string id_acceso, item;
			public AccessListEntry(string id_acceso, string item)
			{
				this.id_acceso = id_acceso;
				this.item = item;
			}
		}

		public override Lfx.Types.OperationResult Edit(int iId)
		{
			m_Id = iId;

			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("personas", "id_persona", iId);
                        if (Registro["contrasena"] != null)
                                txtContrasena.Text = System.Convert.ToString(Registro["contrasena"]);

			txtAcceso.Tag = System.Convert.ToInt32(Registro["tipo"]);
			if((System.Convert.ToInt32(Registro["tipo"]) & 4) == 4)
				txtAcceso.TextKey = "1";
			else
				txtAcceso.TextKey = "0";

			AccessList = this.Workspace.DefaultDataBase.Select("SELECT id_acceso, id_persona, item FROM sys_accesslist WHERE id_persona=" + iId.ToString());
			foreach(System.Data.DataRow Acceso in AccessList.Rows) {
				NewAccessList.Add(new AccessListEntry(Acceso["id_acceso"].ToString(), Acceso["item"].ToString()));
			}

			return ResultadoEditar;
		}

		private void FillAccessBaseList()
		{
			Accesos.Nodes.Clear();

			System.Data.DataTable AccessBase = this.Workspace.DefaultDataBase.Select("SELECT id_acceso, nombre FROM sys_accessbase WHERE parent IS NULL ORDER BY nombre");
			foreach(System.Data.DataRow Acceso in AccessBase.Rows) {
				System.Data.DataTable Hijos = this.Workspace.DefaultDataBase.Select("SELECT id_acceso, nombre FROM sys_accessbase WHERE parent='" + System.Convert.ToString(Acceso["id_acceso"]) + "' ORDER BY nombre");
				TreeNode[] NodosHijos = new TreeNode[Hijos.Rows.Count];
				int i = 0;
				foreach(System.Data.DataRow Hijo in Hijos.Rows) {
					NodosHijos[i] = new TreeNode(System.Convert.ToString(Hijo["nombre"]));
					NodosHijos[i].Tag = System.Convert.ToString(Hijo["id_acceso"]);
					string TempFilter = "id_acceso='" + Hijo["id_acceso"].ToString() + "' AND id_persona=" + m_Id.ToString() + " AND item='*'";
					NodosHijos[i].Checked = (AccessList.Select(TempFilter).Length > 0);
					i++;
				}
				TreeNode NodoPadre = new TreeNode(System.Convert.ToString(Acceso["nombre"]), NodosHijos);
				NodoPadre.Tag = System.Convert.ToString(Acceso["id_acceso"]);
				Accesos.Nodes.Add(NodoPadre);
			}
			Accesos.ExpandAll();
		}

		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true) {
                                DataView.BeginTransaction();

                                DataView.DataBase.Execute("DELETE FROM sys_accesslist WHERE id_persona=" + m_Id.ToString());
				foreach(AccessListEntry Acc in NewAccessList) {
                                        DataView.DataBase.Execute("INSERT INTO sys_accesslist (id_acceso, id_persona, item) VALUES ('" + Acc.id_acceso + "', " + m_Id.ToString() + ", '" + Acc.item + "')");
				}

                                Lfx.Data.SqlUpdateBuilder ActualizarAcceso = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "personas");
                                ActualizarAcceso.WhereClause = new Lfx.Data.SqlWhereBuilder("id_persona", m_Id);

        			int OldTipo = System.Convert.ToInt32(txtAcceso.Tag);
				if(txtAcceso.TextKey == "1")
					OldTipo = OldTipo | 4;
				else
					OldTipo = OldTipo & (~4);

                                ActualizarAcceso.Fields.AddWithValue("tipo", OldTipo);
                                ActualizarAcceso.Fields.AddWithValue("contrasena", txtContrasena.Text);

                                DataView.Execute(ActualizarAcceso);
                                DataView.Commit();
			}

			base.Save();
			return ResultadoGuardar;
		}

		private void EditarAccesos_Load(object sender, System.EventArgs e)
		{
			FillAccessBaseList();
		}

		private void Accesos_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			IgnorarEventos = true;
			lblNombreAcceso.Text = e.Node.Text;

			string NombreAcceso = System.Convert.ToString(e.Node.Tag);
			switch(NombreAcceso) {
				case "accounts.read":
				case "accounts.write":
					FillSubItemsWithTable("cajas", "id_caja", "nombre");
					break;
                                case "documents.create":
				case "documents.read":
				case "documents.write":
				case "documents.print":
					FillSubItemsWithTable("documentos_tipos", "id_tipo", "nombre");
					break;
				case "people.create":
				case "people.read":
				case "people.write":
					FillSubItemsWithTable("personas_tipos", "id_tipo_persona", "nombre");
					break;
				case "products.create":
				case "products.read":
				case "products.write":
					FillSubItemsWithTable("articulos_categorias", "id_categoria", "nombre");
					break;
			}

			/*
			System.Data.DataRow[] TipoAcceso = AccessBase.Select("id_acceso='" + NombreAcceso + "'");
			switch(System.Convert.ToInt32(TipoAcceso[0]["tipo"]))
			{
				case 0:
					//txtSubItems.Visible = false;
					txtSubItems.SetData = new string[] { "No|0" };
					txtSubItems.Tag = 0;
					txtSubItems.TextKey = "0";
					break;
				case 1:
					txtSubItems.SetData = new string[] { "Si|*", "No|1" };
					txtSubItems.Visible = true;
					txtSubItems.Tag = 1;
					break;
				case 2:
					txtSubItems.SetData = new string[] { "Sin acceso|0", "Acceso total|*", "Acceso sólo a los siguientes elementos|1" };
					txtSubItems.Visible = true;
					txtSubItems.Tag = 2;
					break;
			}
			*/

			if(System.Convert.ToInt32(txtSubItems.Tag) == 2) {
				//Borro las tildes
				foreach(ListViewItem Itm in SubItems.Items) {
					Itm.Checked = false;
				}

				//Busco los accesos y tildo
				bool TieneAcceso = false;
				foreach(AccessListEntry Acc in NewAccessList) {
					if(Acc.id_acceso == NombreAcceso) {
						TieneAcceso = true;
						if(Acc.item == "*") {
							//Encontré un acceso total
							txtSubItems.TextKey = "*";
							break;
						} else {
							//Encontré un acceso parcial
							txtSubItems.TextKey = "1";
							foreach(ListViewItem Itm in SubItems.Items) {
								if(Itm.Text == Acc.item) {
									Itm.Checked = true;
								}
							}
						}
					}
				}
				if(!TieneAcceso) {
					//No encontré ningún acceso
					txtSubItems.TextKey = "0";
				}
			}

			this.txtSubItems_TextChanged(null, null);
			IgnorarEventos = false;
		}

		private void FillSubItemsWithTable(string tableName, string keyName, string valueName)
		{
			SubItems.Items.Clear();

			System.Data.DataTable Cajas = this.Workspace.DefaultDataBase.Select("SELECT " + keyName + ", " + valueName + " FROM " + tableName + " ORDER BY " + valueName);
			foreach(System.Data.DataRow Caja in Cajas.Rows) {
				ListViewItem Itm = SubItems.Items.Add(Caja[keyName].ToString());
				Itm.SubItems.Add(Caja[valueName].ToString());
			}

			//Pongo las tildes de los accesos actuales
			string NombreAcceso = Accesos.SelectedNode.Tag.ToString();
			foreach(ListViewItem Itm in SubItems.Items) {
				foreach(AccessListEntry Acc in NewAccessList) {
					if(Acc.id_acceso == NombreAcceso && Acc.item == Itm.Text) {
						Itm.Checked = true;
						break;
					}
				}
			}
		}

		private void txtSubItems_TextChanged(object sender, System.EventArgs e)
		{
			SubItems.Visible = (txtSubItems.TextKey == "1" && System.Convert.ToInt32(txtSubItems.Tag) == 2);

			if(IgnorarEventos)
				return;

			string NombreAcceso = Accesos.SelectedNode.Tag.ToString();
			bool Modifique = false;
			do {
				Modifique = false;
				foreach(AccessListEntry Acc in NewAccessList) {
					if(Acc.id_acceso == NombreAcceso) {
						NewAccessList.Remove(Acc);
						Modifique = true;
						break;
					}
				}
			} while(Modifique);
			if(txtSubItems.TextKey == "*")
				NewAccessList.Add(new AccessListEntry(NombreAcceso, "*"));

		}

		/*
		private void SubItems_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			if(IgnorarEventos)
				return;

			string NombreAcceso = Accesos.SelectedNode.Tag.ToString();
			if(e.NewValue == System.Windows.Forms.CheckState.Checked) 
			{
				NewAccessList.Add(new AccessListEntry(NombreAcceso, SubItems.Items[e.Index].Text));
			}
			else
			{
				foreach(AccessListEntry Acc in NewAccessList)
				{
					if(Acc.id_acceso == NombreAcceso){
						NewAccessList.Remove(Acc);
						break;
					}
				}
			}
		}
		*/

		private void Accesos_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if(IgnorarEventos)
				return;

			string NombreAcceso = e.Node.Tag.ToString();

			bool Modifique = false;
			do {
				Modifique = false;
				foreach(AccessListEntry Acc in NewAccessList) {
					if(Acc.id_acceso == NombreAcceso) {
						NewAccessList.Remove(Acc);
						Modifique = true;
						break;
					}
				}
			} while(Modifique);

			if(e.Node.Checked == true)
				NewAccessList.Add(new AccessListEntry(NombreAcceso, "*"));
		}
	}
}