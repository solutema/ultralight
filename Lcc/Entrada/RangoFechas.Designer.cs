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

namespace Lcc.Entrada
{
        partial class RangoFechas
        {
                private System.ComponentModel.IContainer components = null;

                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de componentes

                private void InitializeComponent()
                {
                        this.EntradaTipoDeRango = new Lui.Forms.ComboBox();
                        this.EntradaDesde = new Lui.Forms.TextBox();
                        this.EntradaHasta = new Lui.Forms.TextBox();
                        this.EntradaRango = new Lui.Forms.ComboBox();
                        this.EtiquetaDesde = new System.Windows.Forms.Label();
                        this.EtiquetaHasta = new System.Windows.Forms.Label();
                        this.PanelCombos = new System.Windows.Forms.Panel();
                        this.PanelFechas = new System.Windows.Forms.Panel();
                        this.PanelCombos.SuspendLayout();
                        this.PanelFechas.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaTipoDeRango
                        // 
                        this.EntradaTipoDeRango.AutoHeight = false;
                        this.EntradaTipoDeRango.AutoNav = true;
                        this.EntradaTipoDeRango.AutoTab = true;
                        this.EntradaTipoDeRango.DetailField = null;
                        this.EntradaTipoDeRango.Filter = null;
                        this.EntradaTipoDeRango.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTipoDeRango.KeyField = null;
                        this.EntradaTipoDeRango.Location = new System.Drawing.Point(0, 0);
                        this.EntradaTipoDeRango.MaxLenght = 32767;
                        this.EntradaTipoDeRango.Name = "EntradaTipoDeRango";
                        this.EntradaTipoDeRango.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipoDeRango.ReadOnly = false;
                        this.EntradaTipoDeRango.SetData = new string[] {
        "Por día|dia",
        "Por semana|semana",
        "Por mes|mes",
        "Por rango|rango",
        "Todas|todas"};
                        this.EntradaTipoDeRango.Size = new System.Drawing.Size(124, 24);
                        this.EntradaTipoDeRango.TabIndex = 0;
                        this.EntradaTipoDeRango.Table = null;
                        this.EntradaTipoDeRango.Text = "Por semana";
                        this.EntradaTipoDeRango.TextKey = "semana";
                        this.EntradaTipoDeRango.TextRaw = "Por semana";
                        this.EntradaTipoDeRango.TipWhenBlank = "";
                        this.EntradaTipoDeRango.ToolTipText = "";
                        this.EntradaTipoDeRango.TextChanged += new System.EventHandler(this.EntradaTipoDeRango_TextChanged);
                        this.EntradaTipoDeRango.SizeChanged += new System.EventHandler(this.Combos_SizeChanged);
                        // 
                        // EntradaDesde
                        // 
                        this.EntradaDesde.AutoHeight = false;
                        this.EntradaDesde.AutoNav = true;
                        this.EntradaDesde.AutoTab = true;
                        this.EntradaDesde.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaDesde.DecimalPlaces = -1;
                        this.EntradaDesde.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDesde.Location = new System.Drawing.Point(120, 8);
                        this.EntradaDesde.MaxLenght = 32767;
                        this.EntradaDesde.MultiLine = false;
                        this.EntradaDesde.Name = "EntradaDesde";
                        this.EntradaDesde.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDesde.PasswordChar = '\0';
                        this.EntradaDesde.Prefijo = "";
                        this.EntradaDesde.ReadOnly = false;
                        this.EntradaDesde.SelectOnFocus = true;
                        this.EntradaDesde.Size = new System.Drawing.Size(108, 24);
                        this.EntradaDesde.Sufijo = "";
                        this.EntradaDesde.TabIndex = 1;
                        this.EntradaDesde.TextRaw = "";
                        this.EntradaDesde.TipWhenBlank = "";
                        this.EntradaDesde.ToolTipText = "";
                        this.EntradaDesde.TextChanged += new System.EventHandler(this.EntradaDesde_TextChanged);
                        // 
                        // EntradaHasta
                        // 
                        this.EntradaHasta.AutoHeight = false;
                        this.EntradaHasta.AutoNav = true;
                        this.EntradaHasta.AutoTab = true;
                        this.EntradaHasta.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaHasta.DecimalPlaces = -1;
                        this.EntradaHasta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaHasta.Location = new System.Drawing.Point(292, 8);
                        this.EntradaHasta.MaxLenght = 32767;
                        this.EntradaHasta.MultiLine = false;
                        this.EntradaHasta.Name = "EntradaHasta";
                        this.EntradaHasta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaHasta.PasswordChar = '\0';
                        this.EntradaHasta.Prefijo = "";
                        this.EntradaHasta.ReadOnly = false;
                        this.EntradaHasta.SelectOnFocus = true;
                        this.EntradaHasta.Size = new System.Drawing.Size(108, 24);
                        this.EntradaHasta.Sufijo = "";
                        this.EntradaHasta.TabIndex = 3;
                        this.EntradaHasta.TextRaw = "";
                        this.EntradaHasta.TipWhenBlank = "";
                        this.EntradaHasta.ToolTipText = "";
                        this.EntradaHasta.TextChanged += new System.EventHandler(this.EntradaHasta_TextChanged);
                        // 
                        // EntradaRango
                        // 
                        this.EntradaRango.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaRango.AutoHeight = false;
                        this.EntradaRango.AutoNav = true;
                        this.EntradaRango.AutoTab = true;
                        this.EntradaRango.DetailField = null;
                        this.EntradaRango.Filter = null;
                        this.EntradaRango.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaRango.KeyField = null;
                        this.EntradaRango.Location = new System.Drawing.Point(128, 0);
                        this.EntradaRango.MaxLenght = 32767;
                        this.EntradaRango.Name = "EntradaRango";
                        this.EntradaRango.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRango.ReadOnly = false;
                        this.EntradaRango.SetData = new string[] {
        "a|1"};
                        this.EntradaRango.Size = new System.Drawing.Size(311, 24);
                        this.EntradaRango.TabIndex = 1;
                        this.EntradaRango.Table = null;
                        this.EntradaRango.Text = "a|1";
                        this.EntradaRango.TextKey = "";
                        this.EntradaRango.TextRaw = "a|1";
                        this.EntradaRango.TipWhenBlank = "";
                        this.EntradaRango.ToolTipText = "";
                        this.EntradaRango.TextChanged += new System.EventHandler(this.EntradaRango_TextChanged);
                        this.EntradaRango.SizeChanged += new System.EventHandler(this.Combos_SizeChanged);
                        // 
                        // EtiquetaDesde
                        // 
                        this.EtiquetaDesde.Location = new System.Drawing.Point(64, 8);
                        this.EtiquetaDesde.Name = "EtiquetaDesde";
                        this.EtiquetaDesde.Size = new System.Drawing.Size(56, 24);
                        this.EtiquetaDesde.TabIndex = 0;
                        this.EtiquetaDesde.Text = "Desde";
                        this.EtiquetaDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaHasta
                        // 
                        this.EtiquetaHasta.Location = new System.Drawing.Point(236, 8);
                        this.EtiquetaHasta.Name = "EtiquetaHasta";
                        this.EtiquetaHasta.Size = new System.Drawing.Size(56, 24);
                        this.EtiquetaHasta.TabIndex = 2;
                        this.EtiquetaHasta.Text = "Hasta";
                        this.EtiquetaHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelCombos
                        // 
                        this.PanelCombos.Controls.Add(this.EntradaTipoDeRango);
                        this.PanelCombos.Controls.Add(this.EntradaRango);
                        this.PanelCombos.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelCombos.Location = new System.Drawing.Point(2, 2);
                        this.PanelCombos.Name = "PanelCombos";
                        this.PanelCombos.Size = new System.Drawing.Size(441, 26);
                        this.PanelCombos.TabIndex = 0;
                        this.PanelCombos.SizeChanged += new System.EventHandler(this.Paneles_SizeChanged);
                        // 
                        // PanelFechas
                        // 
                        this.PanelFechas.Controls.Add(this.EtiquetaDesde);
                        this.PanelFechas.Controls.Add(this.EntradaDesde);
                        this.PanelFechas.Controls.Add(this.EtiquetaHasta);
                        this.PanelFechas.Controls.Add(this.EntradaHasta);
                        this.PanelFechas.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelFechas.Location = new System.Drawing.Point(2, 28);
                        this.PanelFechas.Name = "PanelFechas";
                        this.PanelFechas.Size = new System.Drawing.Size(441, 32);
                        this.PanelFechas.TabIndex = 1;
                        this.PanelFechas.VisibleChanged += new System.EventHandler(this.Paneles_SizeChanged);
                        this.PanelFechas.SizeChanged += new System.EventHandler(this.Paneles_SizeChanged);
                        // 
                        // RangoFechas
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.PanelFechas);
                        this.Controls.Add(this.PanelCombos);
                        this.Name = "RangoFechas";
                        this.Size = new System.Drawing.Size(445, 62);
                        this.PanelCombos.ResumeLayout(false);
                        this.PanelFechas.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lui.Forms.ComboBox EntradaTipoDeRango;
                private Lui.Forms.TextBox EntradaDesde;
                private Lui.Forms.TextBox EntradaHasta;
                private Lui.Forms.ComboBox EntradaRango;
                private System.Windows.Forms.Label EtiquetaDesde;
                private System.Windows.Forms.Label EtiquetaHasta;
                private System.Windows.Forms.Panel PanelCombos;
                private System.Windows.Forms.Panel PanelFechas;
        }
}