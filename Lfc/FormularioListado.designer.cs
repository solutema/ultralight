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

namespace Lfc
{
        partial class FormularioListado
        {
                #region Código generado por el Diseñador de Windows Forms

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.IContainer components = null;

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

                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        this.EntradaBuscar = new Lui.Forms.TextBox();
                        this.BotonCrear = new Lui.Forms.Button();
                        this.TimerBuscar = new System.Windows.Forms.Timer(this.components);
                        this.EtiquetaListadoVacio = new Lui.Forms.Label();
                        this.PanelContadores.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.PicEsperar)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // Listado
                        // 
                        this.Listado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Listado_KeyDown);
                        // 
                        // EntradaBuscar
                        // 
                        this.EntradaBuscar.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.DataEntry;
                        this.EntradaBuscar.Location = new System.Drawing.Point(8, 8);
                        this.EntradaBuscar.Name = "EntradaBuscar";
                        this.EntradaBuscar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBuscar.PlaceholderText = "Buscar (F3)";
                        this.EntradaBuscar.Size = new System.Drawing.Size(212, 24);
                        this.EntradaBuscar.TabIndex = 1;
                        this.EntradaBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaBuscar_KeyDown);
                        this.EntradaBuscar.TextChanged += new System.EventHandler(this.EntradaBuscar_TextChanged);
                        // 
                        // BotonCrear
                        // 
                        this.BotonCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonCrear.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCrear.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCrear.Image = null;
                        this.BotonCrear.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCrear.Location = new System.Drawing.Point(180, 137);
                        this.BotonCrear.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
                        this.BotonCrear.Name = "BotonCrear";
                        this.BotonCrear.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCrear.Size = new System.Drawing.Size(136, 40);
                        this.BotonCrear.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonCrear.Subtext = "F6";
                        this.BotonCrear.TabIndex = 3;
                        this.BotonCrear.Text = "Crear";
                        this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
                        // 
                        // TimerBuscar
                        // 
                        this.TimerBuscar.Interval = 500;
                        this.TimerBuscar.Tick += new System.EventHandler(this.TimerBuscar_Tick);
                        // 
                        // EtiquetaListadoVacio
                        // 
                        this.EtiquetaListadoVacio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaListadoVacio.AutoEllipsis = true;
                        this.EtiquetaListadoVacio.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Info;
                        this.EtiquetaListadoVacio.Location = new System.Drawing.Point(332, 192);
                        this.EtiquetaListadoVacio.Margin = new System.Windows.Forms.Padding(0);
                        this.EtiquetaListadoVacio.Name = "EtiquetaListadoVacio";
                        this.EtiquetaListadoVacio.Size = new System.Drawing.Size(380, 80);
                        this.EtiquetaListadoVacio.TabIndex = 70;
                        this.EtiquetaListadoVacio.Text = "El listado no contiene datos.\r\nHaga clic en el botón \'Crear\' para añadir nuevos e" +
    "lementos.";
                        this.EtiquetaListadoVacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaListadoVacio.UseMnemonic = false;
                        this.EtiquetaListadoVacio.Visible = false;
                        this.EtiquetaListadoVacio.Click += new System.EventHandler(this.EtiquetaListadoVacio_Click);
                        // 
                        // FormularioListado
                        // 
                        this.Controls.Add(this.EtiquetaListadoVacio);
                        this.Controls.Add(this.EntradaBuscar);
                        this.PanelAcciones.Controls.Add(BotonCrear);
                        this.Name = "FormularioListado";
                        this.Text = "Listado";
                        this.Controls.SetChildIndex(this.PanelContadores, 0);
                        this.Controls.SetChildIndex(this.PicEsperar, 0);
                        this.Controls.SetChildIndex(this.EntradaBuscar, 0);
                        this.Controls.SetChildIndex(this.EtiquetaCantidad, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.EtiquetaListadoVacio, 0);
                        this.PanelContadores.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.PicEsperar)).EndInit();
                        this.ResumeLayout(false);
                }

                #endregion

                protected Lui.Forms.TextBox EntradaBuscar;
                protected Lui.Forms.Button BotonCrear;
                protected System.Windows.Forms.Timer TimerBuscar;
                protected Lui.Forms.Label EtiquetaListadoVacio;
        }
}
