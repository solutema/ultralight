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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes
{
        public class Convertir : Lui.Forms.DialogForm
        {
                private string m_OrigenTipo = "";

                #region Código generado por el Diseñador de Windows Forms

                public Convertir()
                        :
                    base()
                {

                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent

                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
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
                internal System.Windows.Forms.Label Label6;
                internal System.Windows.Forms.Label Label7;
                internal System.Windows.Forms.Label lblInfo;
                internal System.Windows.Forms.PictureBox PictureBox1;
                internal System.Windows.Forms.PictureBox PictureBox2;
                internal System.Windows.Forms.PictureBox PictureBox3;
                internal Lui.Forms.ComboBox txtDestinoTipo;
                internal System.Windows.Forms.Label lblOrigenTipo;
                internal System.Windows.Forms.Label lblDestinoTipo;
                internal System.Windows.Forms.Label lblDuplicado;
                internal Lui.Forms.TextBox txtOrigen;

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convertir));
                        this.txtOrigen = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.txtDestinoTipo = new Lui.Forms.ComboBox();
                        this.lblInfo = new System.Windows.Forms.Label();
                        this.lblOrigenTipo = new System.Windows.Forms.Label();
                        this.lblDestinoTipo = new System.Windows.Forms.Label();
                        this.lblDuplicado = new System.Windows.Forms.Label();
                        this.PictureBox2 = new System.Windows.Forms.PictureBox();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.PictureBox3 = new System.Windows.Forms.PictureBox();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(394, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(514, 8);
                        // 
                        // txtOrigen
                        // 
                        this.txtOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtOrigen.AutoHeight = false;
                        this.txtOrigen.AutoNav = true;
                        this.txtOrigen.AutoTab = true;
                        this.txtOrigen.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtOrigen.DecimalPlaces = -1;
                        this.txtOrigen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtOrigen.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtOrigen.Location = new System.Drawing.Point(300, 20);
                        this.txtOrigen.MaxLenght = 32767;
                        this.txtOrigen.MultiLine = false;
                        this.txtOrigen.Name = "txtOrigen";
                        this.txtOrigen.Padding = new System.Windows.Forms.Padding(2);
                        this.txtOrigen.PasswordChar = '\0';
                        this.txtOrigen.Prefijo = "";
                        this.txtOrigen.ReadOnly = true;
                        this.txtOrigen.SelectOnFocus = true;
                        this.txtOrigen.Size = new System.Drawing.Size(312, 24);
                        this.txtOrigen.Sufijo = "";
                        this.txtOrigen.TabIndex = 1;
                        this.txtOrigen.TabStop = false;
                        this.txtOrigen.TextRaw = "";
                        this.txtOrigen.TipWhenBlank = "";
                        this.txtOrigen.ToolTipText = "";
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(20, 20);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(280, 24);
                        this.Label6.TabIndex = 0;
                        this.Label6.Text = "A partir del comprobante de origen";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(20, 48);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(280, 24);
                        this.Label7.TabIndex = 2;
                        this.Label7.Text = "Se generará un nuevo comprobante tipo";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtDestinoTipo
                        // 
                        this.txtDestinoTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtDestinoTipo.AutoHeight = true;
                        this.txtDestinoTipo.AutoNav = true;
                        this.txtDestinoTipo.AutoTab = true;
                        this.txtDestinoTipo.DetailField = null;
                        this.txtDestinoTipo.Filter = null;
                        this.txtDestinoTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDestinoTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtDestinoTipo.KeyField = null;
                        this.txtDestinoTipo.Location = new System.Drawing.Point(300, 48);
                        this.txtDestinoTipo.MaxLenght = 32767;
                        this.txtDestinoTipo.Name = "txtDestinoTipo";
                        this.txtDestinoTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDestinoTipo.ReadOnly = false;
                        this.txtDestinoTipo.SetData = new string[] {
        "Factura|F",
        "Presupuesto|PS",
        "Remito|R",
        "Nota de Crédito|NC",
        "Nota de Débito B|ND"};
                        this.txtDestinoTipo.Size = new System.Drawing.Size(312, 24);
                        this.txtDestinoTipo.TabIndex = 3;
                        this.txtDestinoTipo.Table = null;
                        this.txtDestinoTipo.Text = "Factura";
                        this.txtDestinoTipo.TextKey = "F";
                        this.txtDestinoTipo.TextRaw = "Factura";
                        this.txtDestinoTipo.TipWhenBlank = "";
                        this.txtDestinoTipo.ToolTipText = "";
                        this.txtDestinoTipo.TextChanged += new System.EventHandler(this.txtDestinoTipo_TextChanged);
                        // 
                        // lblInfo
                        // 
                        this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblInfo.Location = new System.Drawing.Point(302, 248);
                        this.lblInfo.Name = "lblInfo";
                        this.lblInfo.Size = new System.Drawing.Size(260, 36);
                        this.lblInfo.TabIndex = 6;
                        this.lblInfo.Text = "El comprobante original queda sin cambios.";
                        // 
                        // lblOrigenTipo
                        // 
                        this.lblOrigenTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblOrigenTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblOrigenTipo.Location = new System.Drawing.Point(62, 180);
                        this.lblOrigenTipo.Name = "lblOrigenTipo";
                        this.lblOrigenTipo.Size = new System.Drawing.Size(84, 36);
                        this.lblOrigenTipo.TabIndex = 4;
                        this.lblOrigenTipo.Text = "Nota de Débito A";
                        this.lblOrigenTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDestinoTipo
                        // 
                        this.lblDestinoTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblDestinoTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblDestinoTipo.Location = new System.Drawing.Point(194, 180);
                        this.lblDestinoTipo.Name = "lblDestinoTipo";
                        this.lblDestinoTipo.Size = new System.Drawing.Size(84, 36);
                        this.lblDestinoTipo.TabIndex = 5;
                        this.lblDestinoTipo.Text = "Presupuesto";
                        this.lblDestinoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDuplicado
                        // 
                        this.lblDuplicado.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblDuplicado.Location = new System.Drawing.Point(302, 208);
                        this.lblDuplicado.Name = "lblDuplicado";
                        this.lblDuplicado.Size = new System.Drawing.Size(260, 36);
                        this.lblDuplicado.TabIndex = 58;
                        this.lblDuplicado.Text = "Se creará un duplicado del comprobante original.";
                        this.lblDuplicado.Visible = false;
                        // 
                        // PictureBox2
                        // 
                        this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
                        this.PictureBox2.Location = new System.Drawing.Point(154, 236);
                        this.PictureBox2.Name = "PictureBox2";
                        this.PictureBox2.Size = new System.Drawing.Size(32, 28);
                        this.PictureBox2.TabIndex = 57;
                        this.PictureBox2.TabStop = false;
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(62, 220);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(84, 64);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.PictureBox1.TabIndex = 56;
                        this.PictureBox1.TabStop = false;
                        // 
                        // PictureBox3
                        // 
                        this.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
                        this.PictureBox3.Location = new System.Drawing.Point(194, 220);
                        this.PictureBox3.Name = "PictureBox3";
                        this.PictureBox3.Size = new System.Drawing.Size(84, 64);
                        this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.PictureBox3.TabIndex = 57;
                        this.PictureBox3.TabStop = false;
                        // 
                        // Convertir
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.lblDuplicado);
                        this.Controls.Add(this.lblDestinoTipo);
                        this.Controls.Add(this.lblOrigenTipo);
                        this.Controls.Add(this.PictureBox2);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.lblInfo);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.txtDestinoTipo);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.txtOrigen);
                        this.Controls.Add(this.PictureBox3);
                        this.Name = "Convertir";
                        this.Text = "Convertir Comprobante";
                        this.Controls.SetChildIndex(this.PictureBox3, 0);
                        this.Controls.SetChildIndex(this.txtOrigen, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.txtDestinoTipo, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.lblInfo, 0);
                        this.Controls.SetChildIndex(this.PictureBox1, 0);
                        this.Controls.SetChildIndex(this.PictureBox2, 0);
                        this.Controls.SetChildIndex(this.lblOrigenTipo, 0);
                        this.Controls.SetChildIndex(this.lblDestinoTipo, 0);
                        this.Controls.SetChildIndex(this.lblDuplicado, 0);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                public string DestinoTipo
                {
                        get
                        {
                                return txtDestinoTipo.TextKey;
                        }
                        set
                        {
                                txtDestinoTipo.TextKey = value;
                        }
                }

                public string OrigenTipo
                {
                        get
                        {
                                return m_OrigenTipo;
                        }
                        set
                        {
                                m_OrigenTipo = value;
                                lblOrigenTipo.Text = Lbl.Comprobantes.Comprobante.NombreTipo(m_OrigenTipo);
                        }
                }

                public string OrigenNombre
                {
                        get
                        {
                                return txtOrigen.Text;
                        }
                        set
                        {
                                txtOrigen.Text = value;
                        }
                }

                private void txtDestinoTipo_TextChanged(object sender, System.EventArgs e)
                {
                        lblDestinoTipo.Text = Lbl.Comprobantes.Comprobante.NombreTipo(txtDestinoTipo.TextKey);
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        if (txtDestinoTipo.TextKey.Length == 0)
                                return new Lfx.Types.FailureOperationResult("Seleccione el tipo de comprobante de destino.");
                        else
                                return new Lfx.Types.SuccessOperationResult();
                }
        }
}