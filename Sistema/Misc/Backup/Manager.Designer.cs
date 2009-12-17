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

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.Misc.Backup
{
        public partial class Manager
        {
                #region Código generado por el Diseñador de Windows Forms

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

                private System.ComponentModel.Container components = null;

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
                        this.cmdBackup = new Lui.Forms.Button();
                        this.lvItems = new Lui.Forms.ListView();
                        this.Carpeta = new System.Windows.Forms.ColumnHeader();
                        this.Numero = new System.Windows.Forms.ColumnHeader();
                        this.FechaYHora = new System.Windows.Forms.ColumnHeader();
                        this.Usuario = new System.Windows.Forms.ColumnHeader();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.cmdEliminar = new Lui.Forms.Button();
                        this.cmdRestaurar = new Lui.Forms.Button();
                        this.cmdCopiar = new Lui.Forms.Button();
                        this.note1 = new Lui.Forms.Note();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(554, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(674, 8);
                        // 
                        // cmdBackup
                        // 
                        this.cmdBackup.AutoHeight = false;
                        this.cmdBackup.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdBackup.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdBackup.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdBackup.Image = ((System.Drawing.Image)(resources.GetObject("cmdBackup.Image")));
                        this.cmdBackup.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdBackup.Location = new System.Drawing.Point(20, 16);
                        this.cmdBackup.Name = "cmdBackup";
                        this.cmdBackup.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdBackup.ReadOnly = false;
                        this.cmdBackup.Size = new System.Drawing.Size(632, 68);
                        this.cmdBackup.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.cmdBackup.Subtext = "Haga clic aquí para dejar en este equipo una copia completa de los datos del sist" +
                            "ema.";
                        this.cmdBackup.TabIndex = 0;
                        this.cmdBackup.Text = "Crear una Copia de Respaldo ahora";
                        this.cmdBackup.ToolTipText = "";
                        this.cmdBackup.Click += new System.EventHandler(this.cmdBackup_Click);
                        // 
                        // lvItems
                        // 
                        this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Carpeta,
            this.Numero,
            this.FechaYHora,
            this.Usuario});
                        this.lvItems.FullRowSelect = true;
                        this.lvItems.GridLines = true;
                        this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvItems.HideSelection = false;
                        this.lvItems.Location = new System.Drawing.Point(24, 120);
                        this.lvItems.Name = "lvItems";
                        this.lvItems.Size = new System.Drawing.Size(628, 176);
                        this.lvItems.TabIndex = 3;
                        this.lvItems.UseCompatibleStateImageBehavior = false;
                        this.lvItems.View = System.Windows.Forms.View.Details;
                        // 
                        // Carpeta
                        // 
                        this.Carpeta.Text = "Carpeta";
                        this.Carpeta.Width = 0;
                        // 
                        // Numero
                        // 
                        this.Numero.Text = "#";
                        this.Numero.Width = 30;
                        // 
                        // FechaYHora
                        // 
                        this.FechaYHora.Text = "Fecha y Hora";
                        this.FechaYHora.Width = 204;
                        // 
                        // Usuario
                        // 
                        this.Usuario.Text = "Usuario";
                        this.Usuario.Width = 171;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label2.Location = new System.Drawing.Point(24, 96);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(628, 20);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Copias de respaldo presentes en el sistema:";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // cmdEliminar
                        // 
                        this.cmdEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdEliminar.AutoHeight = false;
                        this.cmdEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdEliminar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdEliminar.Image = null;
                        this.cmdEliminar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdEliminar.Location = new System.Drawing.Point(660, 196);
                        this.cmdEliminar.Name = "cmdEliminar";
                        this.cmdEliminar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdEliminar.ReadOnly = false;
                        this.cmdEliminar.Size = new System.Drawing.Size(108, 28);
                        this.cmdEliminar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdEliminar.Subtext = "F3";
                        this.cmdEliminar.TabIndex = 4;
                        this.cmdEliminar.Text = "Eliminar";
                        this.cmdEliminar.ToolTipText = "";
                        this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
                        // 
                        // cmdRestaurar
                        // 
                        this.cmdRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdRestaurar.AutoHeight = false;
                        this.cmdRestaurar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdRestaurar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdRestaurar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdRestaurar.Image = null;
                        this.cmdRestaurar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdRestaurar.Location = new System.Drawing.Point(660, 232);
                        this.cmdRestaurar.Name = "cmdRestaurar";
                        this.cmdRestaurar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdRestaurar.ReadOnly = false;
                        this.cmdRestaurar.Size = new System.Drawing.Size(108, 28);
                        this.cmdRestaurar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdRestaurar.Subtext = "F6";
                        this.cmdRestaurar.TabIndex = 5;
                        this.cmdRestaurar.Text = "Restaurar";
                        this.cmdRestaurar.ToolTipText = "";
                        this.cmdRestaurar.Click += new System.EventHandler(this.cmdRestaurar_Click);
                        // 
                        // cmdCopiar
                        // 
                        this.cmdCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdCopiar.AutoHeight = false;
                        this.cmdCopiar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdCopiar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdCopiar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdCopiar.Image = null;
                        this.cmdCopiar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdCopiar.Location = new System.Drawing.Point(660, 268);
                        this.cmdCopiar.Name = "cmdCopiar";
                        this.cmdCopiar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdCopiar.ReadOnly = false;
                        this.cmdCopiar.Size = new System.Drawing.Size(108, 28);
                        this.cmdCopiar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdCopiar.Subtext = "F6";
                        this.cmdCopiar.TabIndex = 6;
                        this.cmdCopiar.Text = "Examinar";
                        this.cmdCopiar.ToolTipText = "";
                        this.cmdCopiar.Click += new System.EventHandler(this.cmdCopiar_Click);
                        // 
                        // note1
                        // 
                        this.note1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.note1.AutoHeight = false;
                        this.note1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.note1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.note1.Location = new System.Drawing.Point(24, 308);
                        this.note1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.note1.Name = "note1";
                        this.note1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.note1.ReadOnly = false;
                        this.note1.Size = new System.Drawing.Size(748, 56);
                        this.note1.TabIndex = 52;
                        this.note1.TabStop = false;
                        this.note1.Text = "Se mantienen automáticamente las últimas 7 copias de respaldo. La copia en letra " +
                            "negrita es la más reciente.";
                        this.note1.Title = "Información";
                        this.note1.ToolTipText = "";
                        // 
                        // Manager
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(794, 452);
                        this.Controls.Add(this.note1);
                        this.Controls.Add(this.cmdCopiar);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.cmdRestaurar);
                        this.Controls.Add(this.cmdEliminar);
                        this.Controls.Add(this.lvItems);
                        this.Controls.Add(this.cmdBackup);
                        this.Name = "Manager";
                        this.Text = "Administrador de Copias de Respaldo";
                        this.Controls.SetChildIndex(this.cmdBackup, 0);
                        this.Controls.SetChildIndex(this.lvItems, 0);
                        this.Controls.SetChildIndex(this.cmdEliminar, 0);
                        this.Controls.SetChildIndex(this.cmdRestaurar, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.cmdCopiar, 0);
                        this.Controls.SetChildIndex(this.note1, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.Button cmdBackup;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ListView lvItems;
                internal System.Windows.Forms.ColumnHeader FechaYHora;
                internal System.Windows.Forms.ColumnHeader Usuario;
                internal System.Windows.Forms.ColumnHeader Carpeta;
                internal Lui.Forms.Button cmdEliminar;
                internal Lui.Forms.Button cmdRestaurar;
                internal System.Windows.Forms.ColumnHeader Numero;
                internal Lui.Forms.Button cmdCopiar;
                private Lui.Forms.Note note1;
        }
}
