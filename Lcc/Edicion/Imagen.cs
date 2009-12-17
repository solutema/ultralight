using System;
using System.Collections.Generic;
using System.Text;

namespace Lcc.Edicion
{
        public partial class Imagen : Lcc.Edicion.ControlEdicion
        {
                internal Lui.Forms.Frame Frame3;
                internal System.Windows.Forms.PictureBox EntradaImagen;
                internal Lui.Forms.Button BotonQuitarImagen;
                internal Lui.Forms.Button BotonSeleccionarImagen;

                public Imagen()
                {
                        InitializeComponent();
                }

                public override void ActualizarControl()
                {
                        if (this.Elemento == null)
                                EntradaImagen.Image = null;
                        else
                                EntradaImagen.Image = this.Elemento.Imagen;
                }

                public override void ActualizarElemento()
                {
                        this.Elemento.Imagen = EntradaImagen.Image;
                }

                private void BotonQuitarImagen_Click(object sender, EventArgs e)
                {
                        if (this.Elemento != null) {
                                EntradaImagen.Image = null;
                        }
                }

                private void BotonSeleccionarImagen_Click(object sender, EventArgs e)
                {
                        if (this.Elemento != null) {
                                System.Windows.Forms.OpenFileDialog Abrir = new System.Windows.Forms.OpenFileDialog();
                                Abrir.Filter = "Archivos JPEG|*.jpg";
                                Abrir.Multiselect = false;
                                Abrir.ValidateNames = true;

                                if (Abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                                        EntradaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                                        EntradaImagen.Image = System.Drawing.Image.FromFile(Abrir.FileName);
                                }
                        }
                }
        }
}
