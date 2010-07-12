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

namespace Lui.Forms
{
	partial class ListingFormExport
	{
		#region Código generado por el Diseñador de Windows Forms

		public ListingFormExport()
			: base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();
		}

		private void InitializeComponent()
		{
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingFormExport));
                        this.label1 = new System.Windows.Forms.Label();
                        this.cmdImprimir = new Lui.Forms.Button();
                        this.cmdExcel = new Lui.Forms.Button();
                        this.cmdHTML = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(259, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(367, 8);
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label1.Location = new System.Drawing.Point(24, 24);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(428, 20);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Seleccione el formato en el que desea exportar los datos";
                        // 
                        // cmdImprimir
                        // 
                        this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdImprimir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
                        this.cmdImprimir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdImprimir.Location = new System.Drawing.Point(24, 256);
                        this.cmdImprimir.Name = "cmdImprimir";
                        this.cmdImprimir.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdImprimir.ReadOnly = false;
                        this.cmdImprimir.Size = new System.Drawing.Size(428, 88);
                        this.cmdImprimir.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.cmdImprimir.Subtext = "Envia los datos a la impresora (a través de OpenOffice.org).";
                        this.cmdImprimir.TabIndex = 3;
                        this.cmdImprimir.Text = "Imprimir";
                        this.cmdImprimir.ToolTipText = "";
                        this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
                        // 
                        // cmdExcel
                        // 
                        this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdExcel.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdExcel.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdExcel.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.Image")));
                        this.cmdExcel.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdExcel.Location = new System.Drawing.Point(24, 56);
                        this.cmdExcel.Name = "cmdExcel";
                        this.cmdExcel.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdExcel.ReadOnly = false;
                        this.cmdExcel.Size = new System.Drawing.Size(428, 88);
                        this.cmdExcel.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.cmdExcel.Subtext = "Exporta los datos a una hoja de Microsoft Excel XML para abrir con Microsoft Offi" +
                            "ce.";
                        this.cmdExcel.TabIndex = 1;
                        this.cmdExcel.Text = "Excel";
                        this.cmdExcel.ToolTipText = "";
                        this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
                        // 
                        // cmdHTML
                        // 
                        this.cmdHTML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdHTML.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdHTML.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdHTML.Image = ((System.Drawing.Image)(resources.GetObject("cmdHTML.Image")));
                        this.cmdHTML.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdHTML.Location = new System.Drawing.Point(24, 156);
                        this.cmdHTML.Name = "cmdHTML";
                        this.cmdHTML.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdHTML.ReadOnly = false;
                        this.cmdHTML.Size = new System.Drawing.Size(428, 88);
                        this.cmdHTML.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.cmdHTML.Subtext = "Exporta los datos a una página HTML para abrir con un navegador o publicar en la " +
                            "Web.";
                        this.cmdHTML.TabIndex = 2;
                        this.cmdHTML.Text = "HTML";
                        this.cmdHTML.ToolTipText = "";
                        this.cmdHTML.Click += new System.EventHandler(this.cmdHTML_Click);
                        // 
                        // ListingFormExport
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(475, 436);
                        this.Controls.Add(this.cmdImprimir);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.cmdExcel);
                        this.Controls.Add(this.cmdHTML);
                        this.Name = "ListingFormExport";
                        this.Text = "Exportar Datos";
                        this.Load += new System.EventHandler(this.FormTablaInicioExportar_Load);
                        this.ResumeLayout(false);

		}

        	#endregion

                internal System.Windows.Forms.Label label1;
                internal System.ComponentModel.Container components = null;
                internal Lui.Forms.Button cmdHTML;
                internal Lui.Forms.Button cmdExcel;
                internal Button cmdImprimir;

	}
}