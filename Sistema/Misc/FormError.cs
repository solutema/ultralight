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
namespace Lazaro
{
    public class FormError: Lui.Forms.Form
    {

        #region Código generado por el Diseñador de Windows Forms

        public FormError()
            : base()
        {


            // Necesario para admitir el Diseñador de Windows Forms
            InitializeComponent();

            // agregar código de constructor después de llamar a InitializeComponent

        }

        // Limpiar los recursos que se estén utilizando.
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(components != null)
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
        internal System.Windows.Forms.Label Label1;
        internal Lui.Forms.TextBox txtMensaje;
        internal Lui.Forms.TextBox txtUbicacion;
        internal System.Windows.Forms.Label Label2;
        internal Lui.Forms.Button cmdCerrar;
        internal Lui.Forms.TextBox txtSitio;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal Lui.Forms.TextBox txtExtra;

        private void InitializeComponent()
        {
			this.Label1 = new System.Windows.Forms.Label();
			this.txtMensaje = new Lui.Forms.TextBox();
			this.txtUbicacion = new Lui.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtSitio = new Lui.Forms.TextBox();
			this.cmdCerrar = new Lui.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtExtra = new Lui.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(16, 60);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(112, 24);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Mensaje";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label1.UseMnemonic = false;
			// 
			// txtMensaje
			// 
			this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMensaje.AutoNav = true;
			this.txtMensaje.AutoTab = true;
			this.txtMensaje.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtMensaje.DockPadding.All = 2;
			this.txtMensaje.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtMensaje.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtMensaje.Location = new System.Drawing.Point(128, 60);
			this.txtMensaje.MaxLenght = 32767;
			this.txtMensaje.MultiLine = true;
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.ReadOnly = true;
			this.txtMensaje.Size = new System.Drawing.Size(416, 80);
			this.txtMensaje.TabIndex = 2;
			this.txtMensaje.TabStop = false;
			this.txtMensaje.ToolTipText = "";
			this.txtMensaje.Workspace = null;
			// 
			// txtUbicacion
			// 
			this.txtUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUbicacion.AutoNav = true;
			this.txtUbicacion.AutoTab = true;
			this.txtUbicacion.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtUbicacion.DockPadding.All = 2;
			this.txtUbicacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUbicacion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtUbicacion.Location = new System.Drawing.Point(128, 148);
			this.txtUbicacion.MaxLenght = 32767;
			this.txtUbicacion.MultiLine = true;
			this.txtUbicacion.Name = "txtUbicacion";
			this.txtUbicacion.ReadOnly = true;
			this.txtUbicacion.Size = new System.Drawing.Size(416, 80);
			this.txtUbicacion.TabIndex = 4;
			this.txtUbicacion.TabStop = false;
			this.txtUbicacion.ToolTipText = "";
			this.txtUbicacion.Workspace = null;
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(17, 148);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(112, 24);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Ubicación";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label2.UseMnemonic = false;
			// 
			// txtSitio
			// 
			this.txtSitio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSitio.AutoNav = true;
			this.txtSitio.AutoTab = true;
			this.txtSitio.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtSitio.DockPadding.All = 2;
			this.txtSitio.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSitio.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtSitio.Location = new System.Drawing.Point(128, 236);
			this.txtSitio.MaxLenght = 32767;
			this.txtSitio.Name = "txtSitio";
			this.txtSitio.ReadOnly = true;
			this.txtSitio.Size = new System.Drawing.Size(416, 24);
			this.txtSitio.TabIndex = 6;
			this.txtSitio.TabStop = false;
			this.txtSitio.ToolTipText = "";
			this.txtSitio.Workspace = null;
			// 
			// cmdCerrar
			// 
			this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCerrar.DockPadding.All = 2;
			this.cmdCerrar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCerrar.Location = new System.Drawing.Point(436, 308);
			this.cmdCerrar.Name = "cmdCerrar";
			this.cmdCerrar.ReadOnly = false;
			this.cmdCerrar.Size = new System.Drawing.Size(108, 28);
			this.cmdCerrar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.cmdCerrar.Subtext = "F6";
			this.cmdCerrar.TabIndex = 7;
			this.cmdCerrar.Text = "Cerrar";
			this.cmdCerrar.ToolTipText = "";
			this.cmdCerrar.Workspace = null;
			this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(16, 236);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(112, 24);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Sitio";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label3.UseMnemonic = false;
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(16, 12);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(528, 20);
			this.Label4.TabIndex = 0;
			this.Label4.Text = "Ha sucedido un error grave y la operación no podrá completarse.";
			this.Label4.UseMnemonic = false;
			// 
			// Label5
			// 
			this.Label5.Location = new System.Drawing.Point(16, 264);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(112, 24);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Extra";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label5.UseMnemonic = false;
			// 
			// txtExtra
			// 
			this.txtExtra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtExtra.AutoNav = true;
			this.txtExtra.AutoTab = true;
			this.txtExtra.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtExtra.DockPadding.All = 2;
			this.txtExtra.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtExtra.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtExtra.Location = new System.Drawing.Point(128, 264);
			this.txtExtra.MaxLenght = 32767;
			this.txtExtra.Name = "txtExtra";
			this.txtExtra.ReadOnly = true;
			this.txtExtra.Size = new System.Drawing.Size(416, 24);
			this.txtExtra.TabIndex = 9;
			this.txtExtra.TabStop = false;
			this.txtExtra.ToolTipText = "";
			this.txtExtra.Workspace = null;
			// 
			// FormError
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(562, 355);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.txtExtra);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.cmdCerrar);
			this.Controls.Add(this.txtSitio);
			this.Controls.Add(this.txtUbicacion);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.txtMensaje);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormError";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Error";
			this.ResumeLayout(false);

		}


        #endregion

        public void MostrarError(Exception ex, string Extra)
        {
            txtMensaje.Text = ex.Message;

            System.Text.StringBuilder Traza = new System.Text.StringBuilder(); StackTrace st = new StackTrace();
            Traza.Append("StackTrace:");
            for(int i = 0; i <= st.FrameCount - 1; i++)
            {
                StackFrame sf = st.GetFrame(i);
                Traza.Append(" " + sf.GetMethod().Name);
                try
                {
                    Traza.Append("(" + sf.GetFileLineNumber().ToString() + ")");
                }
                catch
                {
                    // Fall al agregar el número de lnea
                    // No lo pongo y listo
                }
            }
            txtUbicacion.Text = ex.Source + " / " + Traza.ToString();
            txtSitio.Text = ex.TargetSite.Name;
            txtExtra.Text = Extra;
        }


        private void cmdCerrar_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }


    }


}
