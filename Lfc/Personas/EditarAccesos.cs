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
using System.Windows.Forms;

namespace Lfc.Personas
{
	public class EditarAccesos : Lui.Forms.EditForm
	{
                private Lui.Forms.ComboBox txtAcceso;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label label1;
		private Lui.Forms.TextBox txtContrasena;
		private System.Windows.Forms.TreeView Accesos;
                private Lui.Forms.ListView SubItems;
		private System.Windows.Forms.ColumnHeader Cod;
		private System.Windows.Forms.ColumnHeader Nombre;
		private System.ComponentModel.IContainer components = null;
                private Lui.Forms.ComboBox txtSubItems;
		internal System.Windows.Forms.Label lblNombreAcceso;
		private System.Data.DataTable AccessList;
		bool IgnorarEventos;

		class AccessListEntry
		{
			public string id_acceso, item;
			public AccessListEntry(string id_acceso, string item)
			{
				this.id_acceso = id_acceso;
				this.item = item;
			}
		}

		private System.Collections.ArrayList NewAccessList = new System.Collections.ArrayList();

		public EditarAccesos()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.Accesos = new System.Windows.Forms.TreeView();
                        this.txtAcceso = new Lui.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtContrasena = new Lui.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
                        this.SubItems = new Lui.Forms.ListView();
			this.Cod = new System.Windows.Forms.ColumnHeader();
			this.Nombre = new System.Windows.Forms.ColumnHeader();
                        this.txtSubItems = new Lui.Forms.ComboBox();
			this.lblNombreAcceso = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.DockPadding.All = 2;
			this.SaveButton.Location = new System.Drawing.Point(476, 8);
			this.SaveButton.Name = "SaveButton";
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.DockPadding.All = 2;
			this.CancelCommandButton.Location = new System.Drawing.Point(584, 8);
			this.CancelCommandButton.Name = "CancelCommandButton";
			// 
			// Accesos
			// 
			this.Accesos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				| System.Windows.Forms.AnchorStyles.Left)));
			this.Accesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Accesos.CheckBoxes = true;
			this.Accesos.ImageIndex = -1;
			this.Accesos.Location = new System.Drawing.Point(12, 76);
			this.Accesos.Name = "Accesos";
			this.Accesos.SelectedImageIndex = -1;
			this.Accesos.Size = new System.Drawing.Size(260, 328);
			this.Accesos.TabIndex = 4;
			this.Accesos.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.Accesos_AfterCheck);
			this.Accesos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Accesos_AfterSelect);
			// 
			// txtAcceso
			// 
			this.txtAcceso.AutoNav = true;
			this.txtAcceso.AutoTab = true;
			this.txtAcceso.DockPadding.All = 2;
			this.txtAcceso.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtAcceso.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtAcceso.Location = new System.Drawing.Point(140, 12);
			this.txtAcceso.MaxLenght = 32767;
			this.txtAcceso.Name = "txtAcceso";
			this.txtAcceso.ReadOnly = false;
			this.txtAcceso.SetData = new string[] {
													  "Si|1",
													  "No|0"};
			this.txtAcceso.Size = new System.Drawing.Size(72, 24);
			this.txtAcceso.TabIndex = 1;
			this.txtAcceso.Text = "Si";
			this.txtAcceso.TextKey = "1";
			this.txtAcceso.ToolTipText = "";
			this.txtAcceso.Workspace = null;
			// 
			// Label6
			// 
			this.Label6.Location = new System.Drawing.Point(12, 12);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(128, 24);
			this.Label6.TabIndex = 0;
			this.Label6.Text = "Permitir Acceso";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtContrasena
			// 
			this.txtContrasena.AutoNav = true;
			this.txtContrasena.AutoTab = true;
			this.txtContrasena.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtContrasena.DockPadding.All = 2;
			this.txtContrasena.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtContrasena.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtContrasena.Location = new System.Drawing.Point(140, 44);
			this.txtContrasena.MaxLenght = 32767;
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.PasswordChar = '*';
			this.txtContrasena.ReadOnly = false;
			this.txtContrasena.SelectOnFocus = false;
			this.txtContrasena.Size = new System.Drawing.Size(132, 24);
			this.txtContrasena.TabIndex = 3;
			this.txtContrasena.ToolTipText = "";
			this.txtContrasena.Workspace = null;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Contraseña";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SubItems
			// 
			this.SubItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				| System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.SubItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SubItems.CheckBoxes = true;
			this.SubItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.Cod,
																					   this.Nombre});
			this.SubItems.FullRowSelect = true;
			this.SubItems.GridLines = true;
			this.SubItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.SubItems.LabelWrap = false;
			this.SubItems.Location = new System.Drawing.Point(280, 132);
			this.SubItems.MultiSelect = false;
			this.SubItems.Name = "SubItems";
			this.SubItems.Size = new System.Drawing.Size(404, 272);
			this.SubItems.TabIndex = 104;
			this.SubItems.View = System.Windows.Forms.View.Details;
			this.SubItems.Visible = false;
			// 
			// Cod
			// 
			this.Cod.Text = "Cod";
			this.Cod.Width = 120;
			// 
			// Nombre
			// 
			this.Nombre.Text = "Nombre";
			this.Nombre.Width = 320;
			// 
			// txtSubItems
			// 
			this.txtSubItems.AutoNav = true;
			this.txtSubItems.AutoTab = true;
			this.txtSubItems.DockPadding.All = 2;
			this.txtSubItems.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSubItems.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtSubItems.Location = new System.Drawing.Point(280, 104);
			this.txtSubItems.MaxLenght = 32767;
			this.txtSubItems.Name = "txtSubItems";
			this.txtSubItems.ReadOnly = false;
			this.txtSubItems.SetData = new string[] {
														"Sin acceso|0",
														"Acceso total|*",
														"Acceso sólo a los siguientes elementos|1"};
			this.txtSubItems.Size = new System.Drawing.Size(304, 24);
			this.txtSubItems.TabIndex = 105;
			this.txtSubItems.Text = "Acceso sólo a los siguientes elementos";
			this.txtSubItems.TextKey = "1";
			this.txtSubItems.ToolTipText = "";
			this.txtSubItems.Visible = false;
			this.txtSubItems.Workspace = null;
			this.txtSubItems.TextChanged += new System.EventHandler(this.txtSubItems_TextChanged);
			// 
			// lblNombreAcceso
			// 
			this.lblNombreAcceso.Location = new System.Drawing.Point(280, 76);
			this.lblNombreAcceso.Name = "lblNombreAcceso";
			this.lblNombreAcceso.Size = new System.Drawing.Size(304, 24);
			this.lblNombreAcceso.TabIndex = 106;
			this.lblNombreAcceso.Text = "Habilitar Acceso";
			this.lblNombreAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNombreAcceso.Visible = false;
			// 
			// EditarAccesos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(692, 473);
			this.Controls.Add(this.lblNombreAcceso);
			this.Controls.Add(this.txtSubItems);
			this.Controls.Add(this.SubItems);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAcceso);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Accesos);
			this.Name = "EditarAccesos";
			this.Text = "Editar Accesos";
			this.Load += new System.EventHandler(this.EditarAccesos_Load);
			this.ResumeLayout(false);

		}
		#endregion

		public override Lfx.Types.OperationResult Edit(int iId)
		{
			m_Id = iId;

			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("personas", "id_persona", iId);
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
					FillSubItemsWithTable("cuentas", "id_cuenta", "nombre");
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
					FillSubItemsWithTable("cat_articulos", "id_cat_articulo", "nombre");
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

			System.Data.DataTable Cuentas = this.Workspace.DefaultDataBase.Select("SELECT " + keyName + ", " + valueName + " FROM " + tableName + " ORDER BY " + valueName);
			foreach(System.Data.DataRow Cuenta in Cuentas.Rows) {
				ListViewItem Itm = SubItems.Items.Add(Cuenta[keyName].ToString());
				Itm.SubItems.Add(Cuenta[valueName].ToString());
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