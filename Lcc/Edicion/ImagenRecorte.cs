using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Edicion
{
        public partial class ImagenRecorte : Lui.Forms.Form
        {
                private System.Drawing.Rectangle CropRect = System.Drawing.Rectangle.Empty;
                private System.Drawing.Point StartPoint = System.Drawing.Point.Empty;
                private System.Drawing.Brush SelectionBrush = null;
                private System.Drawing.Image m_Imagen = null;
                private double SelectionRatio = 0;

                public ImagenRecorte()
                {
                        InitializeComponent();
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
                                        StartPoint = e.Location;
                                        break;
                                case MouseButtons.Middle:
                                        StartPoint.X = e.X - CropRect.X;
                                        StartPoint.Y = e.Y - CropRect.Y;
                                        break;
                        }
                }

                private void EntradaImagen_MouseMove(object sender, MouseEventArgs e)
                {
                        if (StartPoint != System.Drawing.Point.Empty) {
                                switch (e.Button) {
                                        case MouseButtons.Left:
                                                CropRect = RectangleFromPoints(StartPoint, e.Location);
                                                if (this.SelectionRatio != 0) {
                                                        CropRect.Width = System.Convert.ToInt32(CropRect.Height * SelectionRatio);
                                                }
                                                EntradaImagen.Invalidate();
                                                break;
                                        case MouseButtons.Middle:
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

                private void BotonCancelar_Click(object sender, EventArgs e)
                {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                }

                private void EntradaRatio_TextChanged(object sender, EventArgs e)
                {
                        this.SelectionRatio = Lfx.Types.Parsing.ParseDouble(EntradaRatio.TextKey);
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
        }
}
