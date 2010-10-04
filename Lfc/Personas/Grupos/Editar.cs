#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Personas.Grupos
{
	public class Editar : Lui.Forms.EditForm
	{
		internal System.Windows.Forms.Label label4;
		internal Lui.Forms.TextBox EntradaNombre;
		internal System.Windows.Forms.Label Label1;
		internal Lui.Forms.TextBox EntradaDescuento;
		internal Lui.Forms.ComboBox EntradaPredet;
		internal Label label2;
                internal Lcc.Entrada.CodigoDetalle EntradaGrupo;
                internal Label Label16;
		private System.ComponentModel.IContainer components = null;

		public Editar()
		{
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
                        this.EntradaDescuento = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaPredet = new Lui.Forms.ComboBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaGrupo = new Lcc.Entrada.CodigoDetalle();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // txtDescuento
                        // 
                        this.EntradaDescuento.AutoNav = true;
                        this.EntradaDescuento.AutoTab = true;
                        this.EntradaDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDescuento.Location = new System.Drawing.Point(140, 84);
                        this.EntradaDescuento.MaxLenght = 32767;
                        this.EntradaDescuento.Name = "txtDescuento";
                        this.EntradaDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescuento.ReadOnly = false;
                        this.EntradaDescuento.Size = new System.Drawing.Size(84, 24);
                        this.EntradaDescuento.Sufijo = "%";
                        this.EntradaDescuento.TabIndex = 5;
                        this.EntradaDescuento.Text = "0.00";
                        this.EntradaDescuento.TipWhenBlank = "";
                        this.EntradaDescuento.ToolTipText = "";
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
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNombre.Location = new System.Drawing.Point(140, 52);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.Name = "txtNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(364, 24);
                        this.EntradaNombre.TabIndex = 3;
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
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
                        this.EntradaPredet.AutoNav = true;
                        this.EntradaPredet.AutoTab = true;
                        this.EntradaPredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPredet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPredet.Location = new System.Drawing.Point(140, 116);
                        this.EntradaPredet.MaxLenght = 32767;
                        this.EntradaPredet.Name = "txtPredet";
                        this.EntradaPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPredet.ReadOnly = false;
                        this.EntradaPredet.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaPredet.Size = new System.Drawing.Size(84, 24);
                        this.EntradaPredet.TabIndex = 7;
                        this.EntradaPredet.Text = "No";
                        this.EntradaPredet.TextKey = "0";
                        this.EntradaPredet.TipWhenBlank = "";
                        this.EntradaPredet.ToolTipText = "";
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
                        this.EntradaGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaGrupo.AutoTab = true;
                        this.EntradaGrupo.CanCreate = true;
                        this.EntradaGrupo.DetailField = "nombre";
                        this.EntradaGrupo.ExtraDetailFields = null;
                        this.EntradaGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaGrupo.FreeTextCode = "";
                        this.EntradaGrupo.KeyField = "id_grupo";
                        this.EntradaGrupo.Location = new System.Drawing.Point(140, 20);
                        this.EntradaGrupo.MaxLength = 200;
                        this.EntradaGrupo.Name = "txtGrupo";
                        this.EntradaGrupo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGrupo.ReadOnly = false;
                        this.EntradaGrupo.Required = false;
                        this.EntradaGrupo.Size = new System.Drawing.Size(364, 24);
                        this.EntradaGrupo.TabIndex = 1;
                        this.EntradaGrupo.Table = "personas_grupos";
                        this.EntradaGrupo.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaGrupo.Text = "0";
                        this.EntradaGrupo.TextDetail = "";
                        this.EntradaGrupo.TipWhenBlank = "Ninguno";
                        this.EntradaGrupo.ToolTipText = "";
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
                        this.Controls.Add(this.EntradaGrupo);
                        this.Controls.Add(this.Label16);
                        this.Controls.Add(this.EntradaPredet);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaDescuento);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label1);
                        this.Name = "Editar";
                        this.ResumeLayout(false);

		}
		#endregion

	
		public override Lfx.Types.OperationResult Edit(int lId)
		{
			Lfx.Types.OperationResult ResultadoEditar = new Lfx.Types.SuccessOperationResult();

			Lfx.Data.Row Registro = this.DataBase.Row("personas_grupos", "id_grupo", lId);

			if(Registro == null)
			{
				ResultadoEditar.Success = false;
				ResultadoEditar.Message = "El registro no existe";
			}
			else
			{
				EntradaNombre.Text = System.Convert.ToString(Registro["nombre"]);
				EntradaDescuento.Text = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Registro["descuento"]), 2);
				EntradaPredet.TextKey = Registro["predet"].ToString();
                                EntradaGrupo.TextInt = Lfx.Data.DataBase.ConvertDBNullToZero(Registro["parent"]);
                                EntradaGrupo.Filter = "id_grupo<>" + lId;

				m_Id = lId;
				m_Nuevo = false;

				this.Text = "Grupos: " + EntradaNombre.Text;
				ResultadoEditar.Success = true;
			}
			return ResultadoEditar;
		}

		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true)
			{
                                DataBase.BeginTransaction(false);

                                qGen.TableCommand Comando;
                                if (m_Nuevo) {
                                        Comando = new qGen.Insert(DataBase, "personas_grupos");
                                        Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                } else {
                                        Comando = new qGen.Update(DataBase, "personas_grupos");
                                        Comando.WhereClause = new qGen.Where("id_grupo", m_Id);
                                }

                                Comando.Fields.AddWithValue("nombre", EntradaNombre.Text);
                                Comando.Fields.AddWithValue("descuento", Lfx.Types.Parsing.ParseDouble(EntradaDescuento.Text));
                                Comando.Fields.AddWithValue("predet", Lfx.Types.Parsing.ParseInt(EntradaPredet.TextKey));
                                Comando.Fields.AddWithValue("parent", Lfx.Data.DataBase.ConvertZeroToDBNull(EntradaGrupo.TextInt));

                                DataBase.Execute(Comando);
                                DataBase.Commit();

				if(m_Nuevo)
                                        m_Id = DataBase.FieldInt("SELECT LAST_INSERT_ID()");

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

