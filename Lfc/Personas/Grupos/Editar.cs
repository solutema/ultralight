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

namespace Lfc.Personas.Grupos
{
	public class Editar : Lui.Forms.EditForm
	{
		internal System.Windows.Forms.Label label4;
		internal Lui.Forms.TextBox txtNombre;
		internal System.Windows.Forms.Label Label1;
		internal Lui.Forms.TextBox txtDescuento;
		internal Lui.Forms.ComboBox txtPredet;
		internal Label label2;
                internal Lui.Forms.DetailBox txtGrupo;
                internal Label Label16;
		private System.ComponentModel.IContainer components = null;

		public Editar()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
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
                        this.txtDescuento = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.txtNombre = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtPredet = new Lui.Forms.ComboBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.txtGrupo = new Lui.Forms.DetailBox();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(301, 10);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(409, 10);
                        // 
                        // txtDescuento
                        // 
                        this.txtDescuento.AutoNav = true;
                        this.txtDescuento.AutoTab = true;
                        this.txtDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.txtDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtDescuento.Location = new System.Drawing.Point(140, 84);
                        this.txtDescuento.MaxLenght = 32767;
                        this.txtDescuento.Name = "txtDescuento";
                        this.txtDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDescuento.ReadOnly = false;
                        this.txtDescuento.Size = new System.Drawing.Size(84, 24);
                        this.txtDescuento.Sufijo = "%";
                        this.txtDescuento.TabIndex = 5;
                        this.txtDescuento.Text = "0.00";
                        this.txtDescuento.TipWhenBlank = "";
                        this.txtDescuento.ToolTipText = "";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(20, 84);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(120, 24);
                        this.label4.TabIndex = 4;
                        this.label4.Text = "Descuento";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtNombre
                        // 
                        this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtNombre.AutoNav = true;
                        this.txtNombre.AutoTab = true;
                        this.txtNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtNombre.Location = new System.Drawing.Point(140, 52);
                        this.txtNombre.MaxLenght = 32767;
                        this.txtNombre.Name = "txtNombre";
                        this.txtNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.txtNombre.ReadOnly = false;
                        this.txtNombre.SelectOnFocus = false;
                        this.txtNombre.Size = new System.Drawing.Size(364, 24);
                        this.txtNombre.TabIndex = 3;
                        this.txtNombre.TipWhenBlank = "";
                        this.txtNombre.ToolTipText = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 52);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(120, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Nombre";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPredet
                        // 
                        this.txtPredet.AutoNav = true;
                        this.txtPredet.AutoTab = true;
                        this.txtPredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPredet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPredet.Location = new System.Drawing.Point(140, 116);
                        this.txtPredet.MaxLenght = 32767;
                        this.txtPredet.Name = "txtPredet";
                        this.txtPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPredet.ReadOnly = false;
                        this.txtPredet.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.txtPredet.Size = new System.Drawing.Size(84, 24);
                        this.txtPredet.TabIndex = 7;
                        this.txtPredet.Text = "No";
                        this.txtPredet.TextKey = "0";
                        this.txtPredet.TipWhenBlank = "";
                        this.txtPredet.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(20, 116);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(120, 24);
                        this.label2.TabIndex = 6;
                        this.label2.Text = "Predeterminado";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtGrupo
                        // 
                        this.txtGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtGrupo.AutoTab = true;
                        this.txtGrupo.CanCreate = true;
                        this.txtGrupo.DetailField = "nombre";
                        this.txtGrupo.ExtraDetailFields = null;
                        this.txtGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtGrupo.FreeTextCode = "";
                        this.txtGrupo.KeyField = "id_grupo";
                        this.txtGrupo.Location = new System.Drawing.Point(140, 20);
                        this.txtGrupo.MaxLength = 200;
                        this.txtGrupo.Name = "txtGrupo";
                        this.txtGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtGrupo.ReadOnly = false;
                        this.txtGrupo.Required = false;
                        this.txtGrupo.SelectOnFocus = false;
                        this.txtGrupo.Size = new System.Drawing.Size(364, 24);
                        this.txtGrupo.TabIndex = 1;
                        this.txtGrupo.Table = "personas_grupos";
                        this.txtGrupo.TeclaDespuesDeEnter = "{tab}";
                        this.txtGrupo.Text = "0";
                        this.txtGrupo.TextDetail = "";
                        this.txtGrupo.TextInt = 0;
                        this.txtGrupo.TipWhenBlank = "Ninguno";
                        this.txtGrupo.ToolTipText = "";
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(20, 20);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(120, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Depende de";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(520, 277);
                        this.Controls.Add(this.txtGrupo);
                        this.Controls.Add(this.Label16);
                        this.Controls.Add(this.txtPredet);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.txtDescuento);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.txtNombre);
                        this.Controls.Add(this.Label1);
                        this.Name = "Editar";
                        this.ResumeLayout(false);

		}
		#endregion

	
		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("personas_grupos", "id_grupo", lId);

			if(Registro == null)
			{
				ResultadoEditar.Success = false;
				ResultadoEditar.Message = "El registro no existe";
			}
			else
			{
				txtNombre.Text = System.Convert.ToString(Registro["nombre"]);
				txtDescuento.Text = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Registro["descuento"]), 2);
				txtPredet.TextKey = Registro["predet"].ToString();
                                txtGrupo.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(Registro["parent"]);
                                txtGrupo.Filter = "id_grupo<>" + lId;

				m_Id = lId;
				m_Nuevo = false;

				this.Text = "Grupos: " + txtNombre.Text;
				ResultadoEditar.Success = true;
			}
			return ResultadoEditar;
		}

		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true)
			{
                                DataView.DataBase.BeginTransaction();

                                Lfx.Data.SqlTableCommandBuilder Comando;
                                if (m_Nuevo) {
                                        Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "personas_grupos");
                                        Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                                } else {
                                        Comando = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "personas_grupos");
                                        Comando.WhereClause = new Lfx.Data.SqlWhereBuilder("id_grupo", m_Id);
                                }

                                Comando.Fields.AddWithValue("nombre", txtNombre.Text);
                                Comando.Fields.AddWithValue("descuento", Lfx.Types.Parsing.ParseDouble(txtDescuento.Text));
                                Comando.Fields.AddWithValue("predet", Lfx.Types.Parsing.ParseInt(txtPredet.TextKey));
                                Comando.Fields.AddWithValue("parent", Lfx.Data.DataBase.ConvertZeroToDBNull(txtGrupo.TextInt));

                                DataView.Execute(Comando);
                                DataView.DataBase.Commit();

				if(m_Nuevo)
                                        m_Id = DataView.DataBase.FieldInt("SELECT MAX(id_grupo) FROM personas_grupos");

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

