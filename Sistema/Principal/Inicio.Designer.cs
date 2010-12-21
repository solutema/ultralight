#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lazaro.Principal
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
                        if (disposing && (components != null)) {
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
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
                        this.TimerProgramador = new System.Windows.Forms.Timer(this.components);
                        this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
                        this.BarraTareas = new System.Windows.Forms.ToolBar();
                        this.BarraTareasImagenes = new System.Windows.Forms.ImageList(this.components);
                        this.ListaBd = new System.Windows.Forms.ListBox();
                        this.BarraInferior = new Lazaro.Principal.BarraInferior();
                        this.SuspendLayout();
                        // 
                        // TimerProgramador
                        // 
                        this.TimerProgramador.Enabled = true;
                        this.TimerProgramador.Interval = 5000;
                        this.TimerProgramador.Tick += new System.EventHandler(this.TimerProgramador_Tick);
                        // 
                        // BarraTareas
                        // 
                        this.BarraTareas.DropDownArrows = true;
                        this.BarraTareas.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BarraTareas.ImageList = this.BarraTareasImagenes;
                        this.BarraTareas.Location = new System.Drawing.Point(0, 0);
                        this.BarraTareas.Name = "BarraTareas";
                        this.BarraTareas.ShowToolTips = true;
                        this.BarraTareas.Size = new System.Drawing.Size(950, 28);
                        this.BarraTareas.TabIndex = 4;
                        this.BarraTareas.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
                        this.BarraTareas.Wrappable = false;
                        this.BarraTareas.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.BarraTareas_ButtonClick);
                        // 
                        // BarraTareasImagenes
                        // 
                        this.BarraTareasImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BarraTareasImagenes.ImageStream")));
                        this.BarraTareasImagenes.TransparentColor = System.Drawing.Color.Transparent;
                        this.BarraTareasImagenes.Images.SetKeyName(0, "inicio.gif");
                        this.BarraTareasImagenes.Images.SetKeyName(1, "editar.gif");
                        // 
                        // ListaBd
                        // 
                        this.ListaBd.Dock = System.Windows.Forms.DockStyle.Left;
                        this.ListaBd.FormattingEnabled = true;
                        this.ListaBd.IntegralHeight = false;
                        this.ListaBd.Location = new System.Drawing.Point(0, 28);
                        this.ListaBd.Name = "ListaBd";
                        this.ListaBd.Size = new System.Drawing.Size(232, 357);
                        this.ListaBd.TabIndex = 10;
                        this.ListaBd.Visible = false;
                        // 
                        // BarraInferior
                        // 
                        this.BarraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.BarraInferior.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BarraInferior.Location = new System.Drawing.Point(0, 385);
                        this.BarraInferior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.BarraInferior.Name = "BarraInferior";
                        this.BarraInferior.Size = new System.Drawing.Size(950, 52);
                        this.BarraInferior.TabIndex = 8;
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(950, 437);
                        this.Controls.Add(this.ListaBd);
                        this.Controls.Add(this.BarraInferior);
                        this.Controls.Add(this.BarraTareas);
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.IsMdiContainer = true;
                        this.KeyPreview = true;
                        this.Menu = this.MainMenu;
                        this.Name = "Inicio";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Lázaro";
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
                        this.Load += new System.EventHandler(this.FormPrincipal_Load);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal System.Windows.Forms.Timer TimerProgramador;
                internal System.Windows.Forms.MainMenu MainMenu;
                public System.Windows.Forms.ToolBar BarraTareas;
                private System.Windows.Forms.ImageList BarraTareasImagenes;
                internal BarraInferior BarraInferior;
                private System.Windows.Forms.ListBox ListaBd;
        }
}