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
using System.Collections.Generic;
using System.Text;

namespace Lfc.Personas
{
        public partial class EditarAccesos
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

                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
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
        }
}
