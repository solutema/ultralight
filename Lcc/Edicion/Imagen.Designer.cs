using System;
using System.Collections.Generic;
using System.Text;

namespace Lcc.Edicion
{
        public partial class Imagen
        {
                private void InitializeComponent()
                {
                        this.Frame3 = new Lui.Forms.Frame();
                        this.EntradaImagen = new System.Windows.Forms.PictureBox();
                        this.BotonQuitarImagen = new Lui.Forms.Button();
                        this.BotonSeleccionarImagen = new Lui.Forms.Button();
                        this.Frame3.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.EntradaImagen)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // Frame3
                        // 
                        this.Frame3.AutoHeight = false;
                        this.Frame3.Controls.Add(this.EntradaImagen);
                        this.Frame3.Controls.Add(this.BotonQuitarImagen);
                        this.Frame3.Controls.Add(this.BotonSeleccionarImagen);
                        this.Frame3.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.Frame3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame3.Location = new System.Drawing.Point(0, 0);
                        this.Frame3.Name = "Frame3";
                        this.Frame3.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame3.ReadOnly = false;
                        this.Frame3.Size = new System.Drawing.Size(518, 292);
                        this.Frame3.TabIndex = 3;
                        this.Frame3.Text = "Imagen";
                        this.Frame3.ToolTipText = "";
                        // 
                        // EntradaImagen
                        // 
                        this.EntradaImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaImagen.BackColor = System.Drawing.Color.White;
                        this.EntradaImagen.Location = new System.Drawing.Point(10, 30);
                        this.EntradaImagen.Name = "EntradaImagen";
                        this.EntradaImagen.Size = new System.Drawing.Size(382, 252);
                        this.EntradaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.EntradaImagen.TabIndex = 100;
                        this.EntradaImagen.TabStop = false;
                        // 
                        // BotonQuitarImagen
                        // 
                        this.BotonQuitarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonQuitarImagen.AutoHeight = false;
                        this.BotonQuitarImagen.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitarImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonQuitarImagen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitarImagen.Image = null;
                        this.BotonQuitarImagen.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitarImagen.Location = new System.Drawing.Point(400, 250);
                        this.BotonQuitarImagen.Name = "BotonQuitarImagen";
                        this.BotonQuitarImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitarImagen.ReadOnly = false;
                        this.BotonQuitarImagen.Size = new System.Drawing.Size(108, 32);
                        this.BotonQuitarImagen.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonQuitarImagen.Subtext = "";
                        this.BotonQuitarImagen.TabIndex = 99;
                        this.BotonQuitarImagen.Text = "Quitar";
                        this.BotonQuitarImagen.ToolTipText = "";
                        this.BotonQuitarImagen.Click += new System.EventHandler(this.BotonQuitarImagen_Click);
                        // 
                        // BotonSeleccionarImagen
                        // 
                        this.BotonSeleccionarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonSeleccionarImagen.AutoHeight = false;
                        this.BotonSeleccionarImagen.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonSeleccionarImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonSeleccionarImagen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonSeleccionarImagen.Image = null;
                        this.BotonSeleccionarImagen.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonSeleccionarImagen.Location = new System.Drawing.Point(400, 214);
                        this.BotonSeleccionarImagen.Name = "BotonSeleccionarImagen";
                        this.BotonSeleccionarImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonSeleccionarImagen.ReadOnly = false;
                        this.BotonSeleccionarImagen.Size = new System.Drawing.Size(108, 32);
                        this.BotonSeleccionarImagen.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonSeleccionarImagen.Subtext = "";
                        this.BotonSeleccionarImagen.TabIndex = 98;
                        this.BotonSeleccionarImagen.Text = "Seleccionar";
                        this.BotonSeleccionarImagen.ToolTipText = "";
                        this.BotonSeleccionarImagen.Click += new System.EventHandler(this.BotonSeleccionarImagen_Click);
                        // 
                        // Imagen
                        // 
                        this.Controls.Add(this.Frame3);
                        this.Name = "Imagen";
                        this.Size = new System.Drawing.Size(518, 292);
                        this.Frame3.ResumeLayout(false);
                        this.Frame3.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.EntradaImagen)).EndInit();
                        this.ResumeLayout(false);
                }
        }
}
