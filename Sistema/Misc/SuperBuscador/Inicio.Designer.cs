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

namespace Lazaro.Misc.SuperBuscador
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextoBuscar = new Lui.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelResultados = new System.Windows.Forms.FlowLayoutPanel();
            this.BotonBuscar = new Lui.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoBuscar
            // 
            this.TextoBuscar.AutoNav = true;
            this.TextoBuscar.AutoTab = true;
            this.TextoBuscar.DataType = Lui.Forms.DataTypes.FreeText;
            this.TextoBuscar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
            this.TextoBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextoBuscar.Location = new System.Drawing.Point(60, 12);
            this.TextoBuscar.MaxLenght = 32767;
            this.TextoBuscar.Name = "TextoBuscar";
            this.TextoBuscar.Padding = new System.Windows.Forms.Padding(2);
            this.TextoBuscar.ReadOnly = false;
            this.TextoBuscar.Size = new System.Drawing.Size(328, 24);
            this.TextoBuscar.TabIndex = 1;
            this.TextoBuscar.ToolTipText = "";
            this.TextoBuscar.TextChanged += new System.EventHandler(this.TextoBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelResultados
            // 
            this.PanelResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelResultados.AutoScroll = true;
            this.PanelResultados.BackColor = System.Drawing.Color.White;
            this.PanelResultados.Location = new System.Drawing.Point(12, 44);
            this.PanelResultados.Margin = new System.Windows.Forms.Padding(0);
            this.PanelResultados.Name = "PanelResultados";
            this.PanelResultados.Size = new System.Drawing.Size(784, 456);
            this.PanelResultados.TabIndex = 3;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
            this.BotonBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BotonBuscar.Image = null;
            this.BotonBuscar.ImagePos = Lui.Forms.ImagePositions.Top;
            this.BotonBuscar.Location = new System.Drawing.Point(392, 12);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Padding = new System.Windows.Forms.Padding(2);
            this.BotonBuscar.ReadOnly = false;
            this.BotonBuscar.Size = new System.Drawing.Size(64, 24);
            this.BotonBuscar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
            this.BotonBuscar.Subtext = "Tecla";
            this.BotonBuscar.TabIndex = 2;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.ToolTipText = "";
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 514);
            this.Controls.Add(this.TextoBuscar);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.PanelResultados);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Inicio";
            this.Text = "SuperBuscador";
            this.ResumeLayout(false);

        }

        #endregion

        private Lui.Forms.TextBox TextoBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel PanelResultados;
        private Lui.Forms.Button BotonBuscar;
    }
}