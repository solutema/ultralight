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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.Misc.Backup
{
    public class Restore : Lui.Forms.DialogForm
    {

        #region Código generado por el Diseñador de Windows Forms

        public Restore()
            : base()
        {


            // Necesario para admitir el Diseñador de Windows Forms
            InitializeComponent();

            // agregar código de constructor después de llamar a InitializeComponent
            OkButton.Visible = false;

        }

        // Limpiar los recursos que se estén utilizando.
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


        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.Container components = null;

        // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
        // Puede modificarse utilizando el Diseñador de Windows Forms. 
        // No lo modifique con el editor de código.
        internal System.Windows.Forms.PictureBox pctExclamation;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal Lui.Forms.TextBox txtConfirmar;
        internal System.Windows.Forms.PictureBox PictureBox1;

        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Restore));
            this.pctExclamation = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtConfirmar = new Lui.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.DockPadding.All = 2;
            this.OkButton.Name = "OkButton";
            // 
            // CancelCommandButton
            // 
            this.CancelCommandButton.DockPadding.All = 2;
            this.CancelCommandButton.Name = "CancelCommandButton";
            // 
            // pctExclamation
            // 
            this.pctExclamation.Image = ((System.Drawing.Image)(resources.GetObject("pctExclamation.Image")));
            this.pctExclamation.Location = new System.Drawing.Point(80, 84);
            this.pctExclamation.Name = "pctExclamation";
            this.pctExclamation.Size = new System.Drawing.Size(52, 52);
            this.pctExclamation.TabIndex = 56;
            this.pctExclamation.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Label1.Location = new System.Drawing.Point(80, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(496, 24);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "Restaurar Copia de Seguridad";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Red;
            this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Snow;
            this.Label2.Location = new System.Drawing.Point(80, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 20);
            this.Label2.TabIndex = 58;
            this.Label2.Text = "ATENCIÓN!";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.Location = new System.Drawing.Point(136, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(444, 32);
            this.Label3.TabIndex = 59;
            this.Label3.Text = "Si continúa con esta acción, llevará el estado del sistema completo atrás en el t" +
                "iempo al:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.Location = new System.Drawing.Point(344, 124);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(236, 15);
            this.lblFecha.TabIndex = 60;
            this.lblFecha.Text = "01-01-2001 a las 00:00:00";
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.Location = new System.Drawing.Point(80, 152);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(500, 52);
            this.Label4.TabIndex = 61;
            this.Label4.Text = "Lea atentamente la sección \"Restaurar Copia de Seguridad\" en el \"Manual del Admin" +
                "istrador\" y asegúrese de comprender las implicaciones de la acción que está a pu" +
                "nto de realizar.";
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.Location = new System.Drawing.Point(80, 216);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(500, 20);
            this.Label5.TabIndex = 62;
            this.Label5.Text = "Para continuar con el proceso, escriba \"si\" en el cuadro:";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmar.AutoNav = true;
            this.txtConfirmar.AutoTab = false;
            this.txtConfirmar.DataType = Lui.Forms.DataTypes.FreeText;
            this.txtConfirmar.DockPadding.All = 2;
            this.txtConfirmar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtConfirmar.ForceCase = Lui.Forms.TextCasing.LowerCase;
            this.txtConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirmar.Location = new System.Drawing.Point(500, 236);
            this.txtConfirmar.MaxLenght = 32767;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.ReadOnly = false;
            this.txtConfirmar.Size = new System.Drawing.Size(80, 24);
            this.txtConfirmar.TabIndex = 0;
            this.txtConfirmar.ToolTipText = "Escriba el texto de confirmación para poder continuar";
            this.txtConfirmar.Workspace = null;
            this.txtConfirmar.TextChanged += new System.EventHandler(this.txtConfirmar_TextChanged);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(16, 16);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(48, 68);
            this.PictureBox1.TabIndex = 63;
            this.PictureBox1.TabStop = false;
            // 
            // Restore
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.ClientSize = new System.Drawing.Size(594, 375);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pctExclamation);
            this.Name = "Restore";
            this.Text = "Restaurar Copia de Seguridad";
            this.Controls.SetChildIndex(this.pctExclamation, 0);
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.Label2, 0);
            this.Controls.SetChildIndex(this.Label3, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.txtConfirmar, 0);
            this.Controls.SetChildIndex(this.PictureBox1, 0);
            this.ResumeLayout(false);

        }


        #endregion

        private void txtConfirmar_TextChanged(object sender, System.EventArgs e)
        {
            OkButton.Visible = (txtConfirmar.Text == "si");
        }
    }
}
