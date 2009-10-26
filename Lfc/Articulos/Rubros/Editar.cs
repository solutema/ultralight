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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Articulos.Rubros
{
	public class Editar : Lui.Forms.EditForm
	{
		internal System.Windows.Forms.Label label9;
		internal Lui.Forms.TextBox txtNombre;
		internal System.Windows.Forms.Label Label5;
		private Lui.Forms.DetailBox txtAlicuota;
		private System.ComponentModel.IContainer components = null;

		public Editar()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

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
			this.label9 = new System.Windows.Forms.Label();
			this.txtAlicuota = new Lui.Forms.DetailBox();
			this.txtNombre = new Lui.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(272, 8);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Location = new System.Drawing.Point(380, 8);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 24);
			this.label9.TabIndex = 2;
			this.label9.Text = "Alícuota";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtAlicuota
			// 
			this.txtAlicuota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAlicuota.AutoTab = true;
			this.txtAlicuota.CanCreate = true;
			this.txtAlicuota.DetailField = "nombre";
			this.txtAlicuota.ExtraDetailFields = "";
			this.txtAlicuota.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.txtAlicuota.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtAlicuota.FreeTextCode = "";
			this.txtAlicuota.KeyField = "id_alicuota";
			this.txtAlicuota.Location = new System.Drawing.Point(116, 48);
			this.txtAlicuota.MaxLength = 200;
			this.txtAlicuota.Name = "txtAlicuota";
			this.txtAlicuota.Padding = new System.Windows.Forms.Padding(2);
			this.txtAlicuota.ReadOnly = false;
			this.txtAlicuota.Required = true;
			this.txtAlicuota.SelectOnFocus = false;
			this.txtAlicuota.Size = new System.Drawing.Size(356, 24);
			this.txtAlicuota.TabIndex = 3;
			this.txtAlicuota.Table = "alicuotas";
			this.txtAlicuota.TeclaDespuesDeEnter = "{tab}";
			this.txtAlicuota.Text = "0";
			this.txtAlicuota.TextDetail = "";
			this.txtAlicuota.TextInt = 0;
			this.txtAlicuota.TipWhenBlank = "Sin especificar";
			this.txtAlicuota.ToolTipText = "";
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
			this.txtNombre.Location = new System.Drawing.Point(116, 16);
			this.txtNombre.MaxLenght = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Padding = new System.Windows.Forms.Padding(2);
			this.txtNombre.ReadOnly = false;
			this.txtNombre.SelectOnFocus = false;
			this.txtNombre.Size = new System.Drawing.Size(356, 24);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.TipWhenBlank = "";
			this.txtNombre.ToolTipText = "";
			// 
			// Label5
			// 
			this.Label5.Location = new System.Drawing.Point(12, 16);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(104, 24);
			this.Label5.TabIndex = 0;
			this.Label5.Text = "Nombre";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Editar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(488, 237);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtAlicuota);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.Label5);
			this.Name = "Editar";
			this.Text = "Artículos: Rubros: Editar";
			this.ResumeLayout(false);

		}
		#endregion

		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Data.SqlSelectBuilder ComandoSelect = new Lfx.Data.SqlSelectBuilder();
			ComandoSelect.WhereClause = new Lfx.Data.SqlWhereBuilder("id_rubro", lId);

			Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("articulos_rubros", "id_rubro", lId);

			if(Registro == null) {
				return new Lfx.Types.FailureOperationResult("El registro no existe.");
			} else {
				txtNombre.Text = System.Convert.ToString(Registro["nombre"]);
				txtAlicuota.TextInt = System.Convert.ToInt32(Registro["id_alicuota"]);

				m_Id = lId;
				m_Nuevo = false;

				return new Lfx.Types.SuccessOperationResult();
			}
		}

		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true) {
                                Lfx.Data.SqlTableCommandBuilder Comando;

                                if (m_Nuevo) {
                                        Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "articulos_rubros");
                                } else {
                                        Comando = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "articulos_rubros");
                                        Comando.WhereClause = new Lfx.Data.SqlWhereBuilder("id_rubro", m_Id);
                                }

                                Comando.Fields.AddWithValue("nombre", txtNombre.Text);
                                Comando.Fields.AddWithValue("id_alicuota", Lfx.Data.DataBase.ConvertZeroToDBNull(txtAlicuota.TextInt));
                                DataView.Execute(Comando);

				if(m_Nuevo && ControlDestino != null) {
                                        m_Nuevo = false;
					ControlDestino.Text = m_Id.ToString();
					ControlDestino.Focus();
				}

				ResultadoGuardar = base.Save();
			}
			return ResultadoGuardar;
		}

	}
}