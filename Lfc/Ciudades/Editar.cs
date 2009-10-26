// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lfc.Ciudades
{
	public class Editar : Lui.Forms.EditForm
	{

		#region 'Windows Form Designer generated code'

		public Editar()
			: base()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call

		}

		// Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;

		// NOTE: The following procedure is required by the Windows Form Designer
		// It can be modified using the Windows Form Designer.  
		// Do not modify it using the code editor.
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal Lui.Forms.TextBox txtNombre;
		internal Lui.Forms.DetailBox txtParent;
		internal Label Label9;
		internal Lui.Forms.TextBox txtCP;

		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtNombre = new Lui.Forms.TextBox();
			this.txtCP = new Lui.Forms.TextBox();
			this.txtParent = new Lui.Forms.DetailBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(376, 10);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Location = new System.Drawing.Point(484, 10);
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(100, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Nombre";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(16, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(96, 24);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Código Postal";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.AutoNav = true;
			this.txtNombre.AutoTab = true;
			this.txtNombre.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtNombre.Location = new System.Drawing.Point(112, 16);
			this.txtNombre.MaxLenght = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Padding = new System.Windows.Forms.Padding(2);
			this.txtNombre.ReadOnly = false;
			this.txtNombre.SelectOnFocus = false;
			this.txtNombre.Size = new System.Drawing.Size(464, 24);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.TipWhenBlank = "";
			this.txtNombre.ToolTipText = "";
			// 
			// txtCP
			// 
			this.txtCP.AutoNav = true;
			this.txtCP.AutoTab = true;
			this.txtCP.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtCP.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCP.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCP.Location = new System.Drawing.Point(112, 48);
			this.txtCP.MaxLenght = 32767;
			this.txtCP.Name = "txtCP";
			this.txtCP.Padding = new System.Windows.Forms.Padding(2);
			this.txtCP.ReadOnly = false;
			this.txtCP.SelectOnFocus = false;
			this.txtCP.Size = new System.Drawing.Size(128, 24);
			this.txtCP.TabIndex = 3;
			this.txtCP.TipWhenBlank = "";
			this.txtCP.ToolTipText = "";
			// 
			// txtParent
			// 
			this.txtParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtParent.AutoTab = true;
			this.txtParent.CanCreate = true;
			this.txtParent.DetailField = "nombre";
			this.txtParent.ExtraDetailFields = null;
			this.txtParent.Filter = "parent IS NULL";
			this.txtParent.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtParent.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtParent.FreeTextCode = "";
			this.txtParent.KeyField = "id_ciudad";
			this.txtParent.Location = new System.Drawing.Point(112, 80);
			this.txtParent.MaxLength = 200;
			this.txtParent.Name = "txtParent";
			this.txtParent.Padding = new System.Windows.Forms.Padding(2);
			this.txtParent.ReadOnly = false;
			this.txtParent.Required = false;
			this.txtParent.SelectOnFocus = false;
			this.txtParent.Size = new System.Drawing.Size(464, 24);
			this.txtParent.TabIndex = 5;
			this.txtParent.Table = "ciudades";
			this.txtParent.TeclaDespuesDeEnter = "{tab}";
			this.txtParent.Text = "0";
			this.txtParent.TextDetail = "";
			this.txtParent.TextInt = 0;
			this.txtParent.TipWhenBlank = "Ninguna";
			this.txtParent.ToolTipText = "";
			// 
			// Label9
			// 
			this.Label9.Location = new System.Drawing.Point(16, 80);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(96, 24);
			this.Label9.TabIndex = 4;
			this.Label9.Text = "Provincia";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Editar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(592, 373);
			this.Controls.Add(this.txtParent);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.txtCP);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Name = "Editar";
			this.Text = "Editar: Ciudades";
			this.ResumeLayout(false);

		}


		#endregion

		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row row = this.Workspace.DefaultDataBase.Row("ciudades", "id_ciudad", lId);

			if (row == null)
			{
				ResultadoEditar.Success = false;
				ResultadoEditar.Message = "El registro no existe";
			}
			else
			{
				txtNombre.Text = System.Convert.ToString(row["nombre"]);
				txtCP.Text = System.Convert.ToString(row["cp"]);
				txtParent.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(row["parent"]);

				m_Id = lId;
				m_Nuevo = false;

				this.Text = "Ciudades: " + txtNombre.Text;
				ResultadoEditar.Success = true;
			}

			return ResultadoEditar;
		}


		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if (ResultadoGuardar.Success == true)
			{
                                this.DataView.DataBase.BeginTransaction();

                                Lfx.Data.SqlTableCommandBuilder Comando;
                                if (m_Nuevo) {
                                        Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "ciudades");
                                        Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                                } else {
                                        Comando = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "ciudades");
                                        Comando.WhereClause = new Lfx.Data.SqlWhereBuilder("id_ciudad", m_Id);
                                }

                                Comando.Fields.AddWithValue("nombre", txtNombre.Text);
                                Comando.Fields.AddWithValue("cp", txtCP.Text);
                                Comando.Fields.AddWithValue("parent", Lfx.Data.DataBase.ConvertZeroToDBNull(txtParent.TextInt));

				this.DataView.Execute(Comando);
                                this.DataView.DataBase.Commit();
                                
                                if (m_Nuevo) {
                                        m_Id = DataView.DataBase.FieldInt("SELECT MAX(id_ciudad) FROM ciudades");
                                        m_Nuevo = false;
                                        if (ControlDestino != null) {
                                                ControlDestino.Text = m_Id.ToString();
                                                ControlDestino.Focus();
                                        }
                                }

				ResultadoGuardar = base.Save();
			}

			return ResultadoGuardar;
		}
	}
}