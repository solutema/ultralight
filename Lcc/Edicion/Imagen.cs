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
#if Windows
using WIA;
#endif

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
#if Windows
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
#endif
                }

                private void guardarEnarchivoToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        System.Windows.Forms.SaveFileDialog DialogoGuardar = new System.Windows.Forms.SaveFileDialog();
                        DialogoGuardar.DefaultExt = ".jpg";
                        DialogoGuardar.AddExtension = true;
                        DialogoGuardar.AutoUpgradeEnabled = true;
                        DialogoGuardar.CheckPathExists = true;
                        DialogoGuardar.CreatePrompt = false;
                        DialogoGuardar.Filter = "Imagen JPEG|*.jpg";
                        DialogoGuardar.OverwritePrompt = true;
                        DialogoGuardar.Title = "Guardar en archivo";
                        DialogoGuardar.ValidateNames = true;
                        if (DialogoGuardar.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                                EntradaImagen.Image.Save(DialogoGuardar.FileName);
                        }
                }

                private void copiarAlPortapapelesToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        System.Windows.Forms.Clipboard.SetData(System.Windows.Forms.DataFormats.Bitmap, EntradaImagen.Image);
                }
        }
}
