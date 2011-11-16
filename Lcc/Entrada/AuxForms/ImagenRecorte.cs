#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Entrada.AuxForms
{
        public partial class ImagenRecorte : Lui.Forms.Form
        {
                public enum MouseActions
                {
                        None,
                        Draw,
                        Drag
                }

                private System.Drawing.Rectangle CropRect = System.Drawing.Rectangle.Empty;
                private System.Drawing.Point StartPoint = System.Drawing.Point.Empty;
                private System.Drawing.Brush SelectionBrush = null;
                private System.Drawing.Image m_Imagen = null;
                private decimal SelectionRatio = 0;
                private MouseActions MouseAction = MouseActions.None;

                public ImagenRecorte()
                {
                        InitializeComponent();
                }


                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null)
                                        components.Dispose();
                                if (SelectionBrush != null)
                                        SelectionBrush.Dispose();
                        }
                        base.Dispose(disposing);
                }


                public System.Drawing.Image Imagen
                {
                        set
                        {
                                m_Imagen = value;
                                Size NewSize;
                                if(Imagen.Size.Width > Imagen.Size.Height) {
                                        double Ratio = System.Convert.ToDouble(m_Imagen.Width) / System.Convert.ToDouble(m_Imagen.Height);
                                        NewSize = new Size(((int)(EntradaImagen.Height * Ratio)), EntradaImagen.Height);
                                } else {
                                        double Ratio = System.Convert.ToDouble(m_Imagen.Width) / System.Convert.ToDouble(m_Imagen.Height);
                                        NewSize = new Size(((int)(EntradaImagen.Width * Ratio)), EntradaImagen.Width);
                                }
                                EntradaImagen.Size = NewSize;
                                this.ClientSize = new Size(EntradaImagen.Width + EntradaImagen.Left * 2, EntradaImagen.Height + EntradaImagen.Top + BotonGuardar.Height + 20);
                                EntradaImagen.Left = (this.ClientSize.Width - EntradaImagen.Width) / 2;
                        }
                        get
                        {
                                return this.m_Imagen;
                        }
                }

                private void EntradaImagen_MouseDown(object sender, MouseEventArgs e)
                {
                        switch (e.Button) {
                                case MouseButtons.Left:
                                        if (CropRect.Contains(e.Location)) {
                                                MouseAction = MouseActions.Drag;
                                                StartPoint.X = e.X - CropRect.X;
                                                StartPoint.Y = e.Y - CropRect.Y;
                                        } else {
                                                MouseAction = MouseActions.Draw;
                                                StartPoint = e.Location;
                                        }
                                        break;
                                case MouseButtons.Middle:
                                        MouseAction = MouseActions.Drag;
                                        StartPoint.X = e.X - CropRect.X;
                                        StartPoint.Y = e.Y - CropRect.Y;
                                        break;
                        }
                }

                private void EntradaImagen_MouseMove(object sender, MouseEventArgs e)
                {
                        if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Middle) {
                                switch (MouseAction) {
                                        case MouseActions.Draw:
                                                CropRect = RectangleFromPoints(StartPoint, e.Location);
                                                if (this.SelectionRatio != 0) {
                                                        CropRect.Width = System.Convert.ToInt32(CropRect.Height * SelectionRatio);
                                                }
                                                EntradaImagen.Invalidate();
                                                break;
                                        case MouseActions.Drag:
                                                CropRect.X = e.X - StartPoint.X;
                                                CropRect.Y = e.Y - StartPoint.Y;
                                                EntradaImagen.Invalidate();
                                                break;
                                }
                        }
                }

                private System.Drawing.Rectangle RectangleFromPoints(Point p1, Point p2) 
                {
                        int X, Y;

                        if(p1.X <= p2.X)
                            X = p1.X;
                        else
                            X = p2.X;

                        if(p1.Y <= p2.Y)
                            Y = p1.Y;
                        else
                            Y = p2.Y;

                        return new Rectangle(X, Y, Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
                }

                private void EntradaImagen_Paint(object sender, PaintEventArgs e)
                {
                        if (Imagen != null) {
                                if (SelectionBrush == null)
                                        SelectionBrush = new SolidBrush(Color.FromArgb(50, Color.White));
                                e.Graphics.DrawImage(Imagen, new Rectangle(0,0, EntradaImagen.ClientSize.Width, EntradaImagen.ClientSize.Height));
                                if (CropRect != System.Drawing.Rectangle.Empty) {
                                        e.Graphics.FillRectangle(SelectionBrush, CropRect);
                                        e.Graphics.DrawRectangle(Pens.Black, CropRect);
                                        BotonSinRecorte.Visible = true;
                                } else {
                                        BotonSinRecorte.Visible = false;
                                }
                        }
                }

                private void BotonGuardar_Click(object sender, EventArgs e)
                {
                        if(CropRect != System.Drawing.Rectangle.Empty) {
                                double ZoomX = System.Convert.ToDouble(m_Imagen.Width) / System.Convert.ToDouble(EntradaImagen.ClientSize.Width);
                                double ZoomY = System.Convert.ToDouble(m_Imagen.Height) / System.Convert.ToDouble(EntradaImagen.ClientSize.Height);
                                Bitmap Target = new Bitmap(System.Convert.ToInt32(CropRect.Width * ZoomX), System.Convert.ToInt32(CropRect.Height * ZoomY));
                                System.Drawing.Rectangle CropRectZoomed = new System.Drawing.Rectangle(
                                        System.Convert.ToInt32(CropRect.X * ZoomX), System.Convert.ToInt32(CropRect.Y * ZoomY),
                                        System.Convert.ToInt32(CropRect.Width * ZoomX), System.Convert.ToInt32(CropRect.Height * ZoomY)
                                        );
                                using (Graphics g = Graphics.FromImage(Target)) {
                                        Bitmap Source = m_Imagen as Bitmap;
                                        g.DrawImage(Source, new Rectangle(0, 0, Target.Width, Target.Height), CropRectZoomed, GraphicsUnit.Pixel);
                                }

                                m_Imagen = Target;
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                }

                private void EntradaRatio_TextChanged(object sender, EventArgs e)
                {
                        this.SelectionRatio = Lfx.Types.Parsing.ParseDecimal(EntradaRatio.TextKey);
                }

                private void BotonSinRecorte_Click(object sender, EventArgs e)
                {
                        this.CropRect = System.Drawing.Rectangle.Empty;
                        EntradaImagen.Invalidate();
                        BotonGuardar.Focus();
                }

                private void copiarAlPortapapelesToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        System.Windows.Forms.Clipboard.SetData(System.Windows.Forms.DataFormats.Bitmap, EntradaImagen.Image);
                }

                private void guardarEnUnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        System.Windows.Forms.SaveFileDialog Guardar = new SaveFileDialog();
                        Guardar.DefaultExt = ".jpg";
                        Guardar.Filter = "Imagen JPEG|*.jpg";
                        if (Guardar.ShowDialog() == DialogResult.OK) {
                                EntradaImagen.Image.Save(Guardar.FileName);
                        }
                }

                private void EntradaImagen_MouseUp(object sender, MouseEventArgs e)
                {
                        MouseAction = MouseActions.None;
                }
        }
}
