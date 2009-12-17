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

namespace Lfc.Alicuotas
{
	public class Editar : Lui.Forms.EditForm
	{
		internal Lui.Forms.TextBox txtNombre;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label2;
		internal Lui.Forms.TextBox txtPorcentaje;
		internal Lui.Forms.TextBox txtImporteMinimo;
		private System.ComponentModel.IContainer components = null;

		public Editar()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNombre = new Lui.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtPorcentaje = new Lui.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtImporteMinimo = new Lui.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.DockPadding.All = 2;
			this.SaveButton.Location = new System.Drawing.Point(300, 10);
			this.SaveButton.Name = "SaveButton";
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.DockPadding.All = 2;
			this.CancelCommandButton.Location = new System.Drawing.Point(408, 10);
			this.CancelCommandButton.Name = "CancelCommandButton";
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.AutoNav = true;
			this.txtNombre.AutoTab = true;
			this.txtNombre.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtNombre.DockPadding.All = 2;
			this.txtNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtNombre.Location = new System.Drawing.Point(132, 16);
			this.txtNombre.MaxLenght = 32767;
			this.txtNombre.MultiLine = false;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.ReadOnly = false;
			this.txtNombre.SelectOnFocus = false;
			this.txtNombre.Size = new System.Drawing.Size(364, 24);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.ToolTipText = "";
			// 
			// Label5
			// 
			this.Label5.Location = new System.Drawing.Point(12, 16);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(112, 24);
			this.Label5.TabIndex = 0;
			this.Label5.Text = "Nombre";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPorcentaje
			// 
			this.txtPorcentaje.AutoNav = true;
			this.txtPorcentaje.AutoTab = true;
			this.txtPorcentaje.DataType = Lui.Forms.DataTypes.Float;
			this.txtPorcentaje.DockPadding.All = 2;
			this.txtPorcentaje.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPorcentaje.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPorcentaje.Location = new System.Drawing.Point(132, 48);
			this.txtPorcentaje.MaxLenght = 32767;
			this.txtPorcentaje.MultiLine = false;
			this.txtPorcentaje.Name = "txtPorcentaje";
			this.txtPorcentaje.ReadOnly = false;
			this.txtPorcentaje.Size = new System.Drawing.Size(100, 24);
			this.txtPorcentaje.Sufijo = "%";
			this.txtPorcentaje.TabIndex = 3;
			this.txtPorcentaje.Text = "0.00";
			this.txtPorcentaje.ToolTipText = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Porcentaje";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Importe Mínimo";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtImporteMinimo
			// 
			this.txtImporteMinimo.AutoNav = true;
			this.txtImporteMinimo.AutoTab = true;
			this.txtImporteMinimo.DataType = Lui.Forms.DataTypes.Money;
			this.txtImporteMinimo.DockPadding.All = 2;
			this.txtImporteMinimo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.txtImporteMinimo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtImporteMinimo.Location = new System.Drawing.Point(132, 80);
			this.txtImporteMinimo.MaxLenght = 32767;
			this.txtImporteMinimo.MultiLine = false;
			this.txtImporteMinimo.Name = "txtImporteMinimo";
			this.txtImporteMinimo.ReadOnly = false;
			this.txtImporteMinimo.Size = new System.Drawing.Size(100, 24);
			this.txtImporteMinimo.TabIndex = 5;
			this.txtImporteMinimo.Text = "0.00";
			this.txtImporteMinimo.ToolTipText = "";
			// 
			// FormAlicuotasEditar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(516, 321);
			this.Controls.Add(this.txtImporteMinimo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPorcentaje);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.Label5);
			this.Name = "FormAlicuotasEditar";
			this.Text = "Alícuotas: Editar";
			this.ResumeLayout(false);

		}
		#endregion

		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("alicuotas", "id_alicuota", lId);

			if(Registro == null)
			{
				return new Lfx.Types.FailureOperationResult("El registro no existe.");
			}
			else
			{
				txtNombre.Text = System.Convert.ToString(Registro["nombre"]);
				txtPorcentaje.Text = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Registro["porcentaje"]), 2);
				txtImporteMinimo.Text = Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Registro["importe_minimo"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces);

				m_Id = lId;
				m_Nuevo = false;

				return new Lfx.Types.SuccessOperationResult();
			}
		}

		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true)
			{
                                this.DataView.DataBase.BeginTransaction();

                                Lfx.Data.SqlTableCommandBuilder Comando;
                                if (m_Nuevo) {
                                        Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "alicuotas");
                                        Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                                } else {
                                        Comando = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "alicuotas");
                                        Comando.WhereClause = new Lfx.Data.SqlWhereBuilder("id_alicuota", m_Id);
                                }

				Comando.Fields.AddWithValue("nombre", txtNombre.Text);
				Comando.Fields.AddWithValue("porcentaje", Lfx.Types.Parsing.ParseDouble(txtPorcentaje.Text));
				Comando.Fields.AddWithValue("importe_minimo", Lfx.Types.Parsing.ParseDouble(txtImporteMinimo.Text));

                                this.DataView.Execute(Comando);
                                this.DataView.DataBase.Commit();

                                if (m_Nuevo)
                                        m_Id = DataView.DataBase.FieldInt("SELECT MAX(id_alicuota) FROM alicuotas");

				if(m_Nuevo && ControlDestino != null)
				{
					ControlDestino.Text = m_Id.ToString();
					ControlDestino.Focus();
				}

				m_Nuevo = false;

				ResultadoGuardar = base.Save();
			}
			return ResultadoGuardar;
		}

	
	}
}

