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
    partial class Resultado
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelDetalles = new System.Windows.Forms.Label();
            this.LabelLineaAbajo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelNombre
            // 
            this.LabelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNombre.AutoEllipsis = true;
            this.LabelNombre.Location = new System.Drawing.Point(0, 0);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(480, 19);
            this.LabelNombre.TabIndex = 1;
            this.LabelNombre.Text = "...";
            this.LabelNombre.UseMnemonic = false;
            // 
            // LabelDetalles
            // 
            this.LabelDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDetalles.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetalles.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelDetalles.Location = new System.Drawing.Point(0, 20);
            this.LabelDetalles.Name = "LabelDetalles";
            this.LabelDetalles.Size = new System.Drawing.Size(480, 0);
            this.LabelDetalles.TabIndex = 2;
            // 
            // LabelLineaAbajo
            // 
            this.LabelLineaAbajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLineaAbajo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelLineaAbajo.Location = new System.Drawing.Point(0, 19);
            this.LabelLineaAbajo.Name = "LabelLineaAbajo";
            this.LabelLineaAbajo.Size = new System.Drawing.Size(480, 1);
            this.LabelLineaAbajo.TabIndex = 3;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelLineaAbajo);
            this.Controls.Add(this.LabelDetalles);
            this.Controls.Add(this.LabelNombre);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Resultado";
            this.Size = new System.Drawing.Size(480, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelDetalles;
        private System.Windows.Forms.Label LabelLineaAbajo;
    }
}
