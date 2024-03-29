#region License
// Copyright 2004-2012 Ernesto N. Carrea
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

namespace Lfc.Comprobantes
{
        public partial class Listado
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                    this.Label1 = new Lui.Forms.Label();
                    this.EntradaAgrupar = new Lui.Forms.ComboBox();
                    this.ReportListView = new Lui.Forms.ListView();
                    this.SuspendLayout();
                    // 
                    // Label1
                    // 
                    this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    this.Label1.Location = new System.Drawing.Point(312, 4);
                    this.Label1.Name = "Label1";
                    this.Label1.Size = new System.Drawing.Size(88, 24);
                    this.Label1.TabIndex = 0;
                    this.Label1.Text = "Agrupar Por";
                    this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    // 
                    // EntradaAgrupar
                    // 
                    this.EntradaAgrupar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    this.EntradaAgrupar.AutoSize = false;
                    this.EntradaAgrupar.Location = new System.Drawing.Point(400, 4);
                    this.EntradaAgrupar.Name = "EntradaAgrupar";
                    this.EntradaAgrupar.SetData = new string[] {
        "Sin agrupar|*",
        "Por tipo de comprobante|comprob.tipo_fac",
        "Por vendedor|comprob.id_vendedor",
        "Por cliente|comprob.id_cliente",
        "Por forma de pago|comprob.id_formapago",
        "Por día de la semana|DAYOFWEEK(comprob.fecha)",
        "Por día del mes|DAYOFMONTH(comprob.fecha)",
        "Por marca|articulos.id_marca",
        "Por proveedor|articulos.id_proveedor",
        "Por artículo|articulos.id_articulo",
        "Por categoría|articulos.id_categoria"};
                    this.EntradaAgrupar.Size = new System.Drawing.Size(196, 24);
                    this.EntradaAgrupar.TabIndex = 1;
                    this.EntradaAgrupar.TextKey = "*";
                    this.EntradaAgrupar.TextChanged += new System.EventHandler(this.EntradaAgrupar_TextChanged);
                    // 
                    // ReportListView
                    // 
                    this.ReportListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
                    this.ReportListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    this.ReportListView.FullRowSelect = true;
                    this.ReportListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                    this.ReportListView.LabelWrap = false;
                    this.ReportListView.Location = new System.Drawing.Point(8, 36);
                    this.ReportListView.Name = "ReportListView";
                    this.ReportListView.Size = new System.Drawing.Size(588, 316);
                    this.ReportListView.TabIndex = 2;
                    this.ReportListView.UseCompatibleStateImageBehavior = false;
                    this.ReportListView.View = System.Windows.Forms.View.Details;
                    // 
                    // FormComprobantesListado
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                    this.ClientSize = new System.Drawing.Size(604, 421);
                    this.Controls.Add(this.EntradaAgrupar);
                    this.Controls.Add(this.ReportListView);
                    this.Controls.Add(this.Label1);
                    this.Name = "FormComprobantesListado";
                    this.Controls.SetChildIndex(this.Label1, 0);
                    this.Controls.SetChildIndex(this.ReportListView, 0);
                    this.Controls.SetChildIndex(this.EntradaAgrupar, 0);
                    this.ResumeLayout(false);

                }
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.ComboBox EntradaAgrupar;

                #endregion
                private Lui.Forms.ListView ReportListView;

        }
}
