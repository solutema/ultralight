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
	public class AltaDuplicada : Lui.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ListView ListaComparacion;
		private System.Windows.Forms.ColumnHeader NombreColumna;
		private System.Windows.Forms.ColumnHeader ColumnaActual;
		private System.Windows.Forms.ColumnHeader ColumnaNueva;
		private System.Windows.Forms.Label label3;
		private Lui.Forms.Button CmdCrearNuevo;
		private Lui.Forms.Button CmdActualizar;
		private Lui.Forms.Button CmdCancelar;
		private System.ComponentModel.IContainer components = null;

		public AltaDuplicada()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ListaComparacion = new System.Windows.Forms.ListView();
			this.NombreColumna = new System.Windows.Forms.ColumnHeader();
			this.ColumnaActual = new System.Windows.Forms.ColumnHeader();
			this.ColumnaNueva = new System.Windows.Forms.ColumnHeader();
			this.label3 = new System.Windows.Forms.Label();
			this.CmdCancelar = new Lui.Forms.Button();
			this.CmdCrearNuevo = new Lui.Forms.Button();
			this.CmdActualizar = new Lui.Forms.Button();
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
			this.label2.Location = new System.Drawing.Point(20, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(552, 48);
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
			// CmdCancelar
			// 
			this.CmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CmdCancelar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdCancelar.Image = global::Lfc.Properties.Resources.edit_undo;
			this.CmdCancelar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.CmdCancelar.Location = new System.Drawing.Point(20, 401);
			this.CmdCancelar.Name = "CmdCancelar";
			this.CmdCancelar.Padding = new System.Windows.Forms.Padding(2);
			this.CmdCancelar.ReadOnly = false;
			this.CmdCancelar.Size = new System.Drawing.Size(552, 68);
			this.CmdCancelar.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
			this.CmdCancelar.Subtext = "No agrega ni actualiza ningún dato. Sólo vuelve al formulario de alta para contin" +
			    "uar con lo que estaba haciendo.";
			this.CmdCancelar.TabIndex = 2;
			this.CmdCancelar.Text = "Volver al formulario de alta";
			this.CmdCancelar.ToolTipText = "";
			this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
			// 
			// CmdCrearNuevo
			// 
			this.CmdCrearNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CmdCrearNuevo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.CmdCrearNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdCrearNuevo.Image = global::Lfc.Properties.Resources.edit_copy;
			this.CmdCrearNuevo.ImagePos = Lui.Forms.ImagePositions.Top;
			this.CmdCrearNuevo.Location = new System.Drawing.Point(20, 325);
			this.CmdCrearNuevo.Name = "CmdCrearNuevo";
			this.CmdCrearNuevo.Padding = new System.Windows.Forms.Padding(2);
			this.CmdCrearNuevo.ReadOnly = false;
			this.CmdCrearNuevo.Size = new System.Drawing.Size(552, 68);
			this.CmdCrearNuevo.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
			this.CmdCrearNuevo.Subtext = "Seleccione esta opción si se trata de clientes diferentes o si intenta deliberada" +
			    "mente cargar un dato duplicado.";
			this.CmdCrearNuevo.TabIndex = 1;
			this.CmdCrearNuevo.Text = "Crear un cliente nuevo";
			this.CmdCrearNuevo.ToolTipText = "";
			this.CmdCrearNuevo.Click += new System.EventHandler(this.CmdCrearNuevo_Click);
			// 
			// CmdActualizar
			// 
			this.CmdActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CmdActualizar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.CmdActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CmdActualizar.Image = global::Lfc.Properties.Resources.contact_new;
			this.CmdActualizar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.CmdActualizar.Location = new System.Drawing.Point(20, 249);
			this.CmdActualizar.Name = "CmdActualizar";
			this.CmdActualizar.Padding = new System.Windows.Forms.Padding(2);
			this.CmdActualizar.ReadOnly = false;
			this.CmdActualizar.Size = new System.Drawing.Size(552, 68);
			this.CmdActualizar.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
			this.CmdActualizar.Subtext = "Seleccione esta opción si verificó que se trata del mismo cliente y no desea crea" +
			    "r datos duplicados.";
			this.CmdActualizar.TabIndex = 0;
			this.CmdActualizar.Text = "Actualizar los datos del cliente actual";
			this.CmdActualizar.ToolTipText = "";
			this.CmdActualizar.Click += new System.EventHandler(this.CmdActualizar_Click);
			// 
			// AltaDuplicada
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(592, 493);
			this.Controls.Add(this.CmdCancelar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CmdCrearNuevo);
			this.Controls.Add(this.CmdActualizar);
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

