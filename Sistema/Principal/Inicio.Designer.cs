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

namespace Lazaro.WinMain.Principal
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
                        if (disposing) {
                                if (components != null)
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
                        this.BarraTareas = new System.Windows.Forms.ToolStrip();
                        this.BarraInferior = new Lazaro.WinMain.Principal.BarraInferior();
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
                        this.BarraTareas.AllowItemReorder = true;
                        this.BarraTareas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
                        this.BarraTareas.Location = new System.Drawing.Point(0, 0);
                        this.BarraTareas.Name = "BarraTareas";
                        this.BarraTareas.Padding = new System.Windows.Forms.Padding(3);
                        this.BarraTareas.Size = new System.Drawing.Size(1008, 25);
                        this.BarraTareas.TabIndex = 17;
                        this.BarraTareas.Text = "Tareas";
                        this.BarraTareas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BarraTareas_ItemClicked);
                        // 
                        // BarraInferior
                        // 
                        this.BarraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.BarraInferior.Location = new System.Drawing.Point(0, 639);
                        this.BarraInferior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.BarraInferior.Name = "BarraInferior";
                        this.BarraInferior.Size = new System.Drawing.Size(1008, 57);
                        this.BarraInferior.TabIndex = 15;
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1024, 690);
                        this.Controls.Add(this.BarraTareas);
                        this.Controls.Add(this.BarraInferior);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
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
                private BarraInferior BarraInferior;
                public System.Windows.Forms.ToolStrip BarraTareas;
        }
}
