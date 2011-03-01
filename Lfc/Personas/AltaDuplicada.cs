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
using System.Windows.Forms;

namespace Lfc.Personas
{
	public class AltaDuplicada : Lui.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
                public Lui.Forms.ListView ListaComparacion;
		private System.Windows.Forms.ColumnHeader NombreColumna;
		private System.Windows.Forms.ColumnHeader ColumnaActual;
		private System.Windows.Forms.ColumnHeader ColumnaNueva;
		private System.Windows.Forms.Label label3;
		private Lui.Forms.Button BotonContinuar;
		private Lui.Forms.Button BotonCorregir;
		private Lui.Forms.Button BotonCancelar;
		private System.ComponentModel.IContainer components = null;

		public AltaDuplicada()
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaDuplicada));
                        this.label1 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.ListaComparacion = new Lui.Forms.ListView();
                        this.NombreColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnaActual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnaNueva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.label3 = new System.Windows.Forms.Label();
                        this.BotonCancelar = new Lui.Forms.Button();
                        this.BotonContinuar = new Lui.Forms.Button();
                        this.BotonCorregir = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // label1
                        // 
                        this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label1.Location = new System.Drawing.Point(20, 20);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(552, 24);
                        this.label1.TabIndex = 3;
                        this.label1.Text = "Posible duplicación de datos";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(20, 48);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(552, 36);
                        this.label2.TabIndex = 4;
                        this.label2.Text = "Es posible que el cliente que intenta agregar ya haya sigo agregado con anteriori" +
                            "dad. Puede revisar las similitudes para decidir si se trata de la misma persona." +
                            "";
                        // 
                        // ListaComparacion
                        // 
                        this.ListaComparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaComparacion.BackColor = System.Drawing.SystemColors.Window;
                        this.ListaComparacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaComparacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreColumna,
            this.ColumnaActual,
            this.ColumnaNueva});
                        this.ListaComparacion.FullRowSelect = true;
                        this.ListaComparacion.GridLines = true;
                        this.ListaComparacion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaComparacion.LabelWrap = false;
                        this.ListaComparacion.Location = new System.Drawing.Point(20, 96);
                        this.ListaComparacion.Name = "ListaComparacion";
                        this.ListaComparacion.Size = new System.Drawing.Size(550, 125);
                        this.ListaComparacion.TabIndex = 5;
                        this.ListaComparacion.TabStop = false;
                        this.ListaComparacion.UseCompatibleStateImageBehavior = false;
                        this.ListaComparacion.View = System.Windows.Forms.View.Details;
                        // 
                        // NombreColumna
                        // 
                        this.NombreColumna.Text = "";
                        this.NombreColumna.Width = 100;
                        // 
                        // ColumnaActual
                        // 
                        this.ColumnaActual.Text = "Cliente actual";
                        this.ColumnaActual.Width = 220;
                        // 
                        // ColumnaNueva
                        // 
                        this.ColumnaNueva.Text = "Cliente nuevo";
                        this.ColumnaNueva.Width = 220;
                        // 
                        // label3
                        // 
                        this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label3.Location = new System.Drawing.Point(20, 229);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(552, 20);
                        this.label3.TabIndex = 6;
                        this.label3.Text = "¿Qué desea hacer con los datos cargados?";
                        // 
                        // BotonCancelar
                        // 
                        this.BotonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonCancelar.AutoSize = false;
                        this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCancelar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.BotonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCancelar.Image")));
                        this.BotonCancelar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCancelar.Location = new System.Drawing.Point(20, 401);
                        this.BotonCancelar.Name = "BotonCancelar";
                        this.BotonCancelar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCancelar.ReadOnly = false;
                        this.BotonCancelar.Size = new System.Drawing.Size(552, 68);
                        this.BotonCancelar.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonCancelar.Subtext = "No agrega ni actualiza ningún dato. Sólo vuelve al formulario de alta para contin" +
                            "uar con lo que estaba haciendo.";
                        this.BotonCancelar.TabIndex = 2;
                        this.BotonCancelar.Text = "Volver al formulario de alta";
                        this.BotonCancelar.ToolTipText = "";
                        this.BotonCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
                        // 
                        // BotonContinuar
                        // 
                        this.BotonContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonContinuar.AutoSize = false;
                        this.BotonContinuar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonContinuar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.BotonContinuar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonContinuar.Image = ((System.Drawing.Image)(resources.GetObject("BotonContinuar.Image")));
                        this.BotonContinuar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonContinuar.Location = new System.Drawing.Point(20, 325);
                        this.BotonContinuar.Name = "BotonContinuar";
                        this.BotonContinuar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonContinuar.ReadOnly = false;
                        this.BotonContinuar.Size = new System.Drawing.Size(552, 68);
                        this.BotonContinuar.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonContinuar.Subtext = "Seleccione esta opción si se trata de clientes diferentes o si intenta deliberada" +
                            "mente cargar un dato duplicado.";
                        this.BotonContinuar.TabIndex = 1;
                        this.BotonContinuar.Text = "Crear un cliente nuevo";
                        this.BotonContinuar.ToolTipText = "";
                        this.BotonContinuar.Click += new System.EventHandler(this.CmdCrearNuevo_Click);
                        // 
                        // BotonCorregir
                        // 
                        this.BotonCorregir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonCorregir.AutoSize = false;
                        this.BotonCorregir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCorregir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.BotonCorregir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCorregir.Image = ((System.Drawing.Image)(resources.GetObject("BotonCorregir.Image")));
                        this.BotonCorregir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCorregir.Location = new System.Drawing.Point(20, 249);
                        this.BotonCorregir.Name = "BotonCorregir";
                        this.BotonCorregir.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCorregir.ReadOnly = false;
                        this.BotonCorregir.Size = new System.Drawing.Size(552, 68);
                        this.BotonCorregir.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonCorregir.Subtext = "Seleccione esta opción si verificó que se trata del mismo cliente y no desea crea" +
                            "r datos duplicados.";
                        this.BotonCorregir.TabIndex = 0;
                        this.BotonCorregir.Text = "Actualizar los datos del cliente actual";
                        this.BotonCorregir.ToolTipText = "";
                        this.BotonCorregir.Click += new System.EventHandler(this.CmdActualizar_Click);
                        // 
                        // AltaDuplicada
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(592, 493);
                        this.Controls.Add(this.BotonCancelar);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.BotonContinuar);
                        this.Controls.Add(this.BotonCorregir);
                        this.Controls.Add(this.ListaComparacion);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "AltaDuplicada";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Posible duplicación de datos";
                        this.ResumeLayout(false);

		}
		#endregion

		private void CmdCrearNuevo_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Yes;
			this.Hide();
		}

		private void CmdCancelar_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Hide();
		}

		private void CmdActualizar_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			this.Hide();
		}
	}
}

