using System;
using System.Collections.Generic;
using System.Text;
using WIA;

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
                        if (this.Elemento != null)
                                EntradaImagen.Image = null;
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
                                        
                                        ImagenRecorte Recorte = new ImagenRecorte();
                                        Recorte.Imagen = System.Drawing.Image.FromFile(Abrir.FileName);
                                        if (Recorte.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                                EntradaImagen.Image = Recorte.Imagen;
                                        Recorte.Dispose();
                                }
                        }
                }

                private void BotonCapturarImagen_Click(object sender, EventArgs e)
                {
                        CommonDialogClass WiaDialog = new CommonDialogClass();
                        WIA.ImageFile WiaImage = null;

                        try {
                                WiaImage = WiaDialog.ShowAcquireImage(
                                        WiaDeviceType.UnspecifiedDeviceType,
                                        WiaImageIntent.ColorIntent,
                                        WiaImageBias.MaximizeQuality,
                                        System.Drawing.Imaging.ImageFormat.Jpeg.Guid.ToString("B"), true, false, false);

                                if (WiaImage != null) {
                                        WIA.Vector vector = WiaImage.FileData;
                                        ImagenRecorte Recorte = new ImagenRecorte();
                                        Recorte.Imagen = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])vector.get_BinaryData()));
                                        if (Recorte.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                                EntradaImagen.Image = Recorte.Imagen;
                                        Recorte.Dispose();
                                }
                        } catch (Exception ex) {
                                Lui.Forms.MessageBox.Show("No se puede conectar con el dispositivo de captura. " + ex.Message, "Error");
                        }
                }
        }
}
