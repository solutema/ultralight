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

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Plantillas
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                private Lbl.Impresion.Campo CampoSeleccionado;
                private int KnobSize = 32, GridSize = 10;
                private PointF Escala;
                private Point Desplazamiento = new Point(0, 0);
                private Point ButtonDown;
                private Rectangle CampoDown;
                private bool KnobGrabbed = false;
                private float Zoom = 100;
                private Size TamanoPapel;
                private PointF EscalaMm = new PointF(300f / 25.4f, 300f / 25.4f);
                private Font FieldInfoFont = new Font("Arial", 7);

                private System.Drawing.Pen LapizBordeCampos = new Pen(Color.Silver, 1);
                private Brush BrushSeleccion = new SolidBrush(Color.FromArgb(150, SystemColors.Highlight));
                private Brush BrushKnob = new SolidBrush(Color.FromArgb(200, Color.Black));
                private Pen BrushKnobBorder = new Pen(Color.FromArgb(100, Color.White));

                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Impresion.Plantilla);

                        InitializeComponent();

                        LapizBordeCampos.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                        ZoomBar_Scroll(null, null);
                }


                /// <summary>
                /// Clean up any resources being used.
                /// </summary>
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                                LapizBordeCampos.Dispose();
                                BrushSeleccion.Dispose();
                                BrushKnob.Dispose();
                                BrushKnobBorder.Dispose();
                                FieldInfoFont.Dispose();
                        }

                        base.Dispose(disposing);
                }


                public override void ActualizarControl()
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        EntradaCodigo.Text = Plantilla.Codigo;
                        EntradaCodigo.TemporaryReadOnly = !Plantilla.Existe;
                        EntradaNombre.Text = Plantilla.Nombre;
                        EntradaPapelTamano.TextKey = Plantilla.TamanoPapel;
                        if (Plantilla.Font != null) {
                                Ingorar_EntradaFuenteFuenteTamano_TextChanged++;
                                EntradaFuente.TextKey = Plantilla.Font.Name;
                                EntradaFuenteTamano.ValueDecimal = System.Convert.ToDecimal(Plantilla.Font.Size);
                                Ingorar_EntradaFuenteFuenteTamano_TextChanged--;
                        } else {
                                Ingorar_EntradaFuenteFuenteTamano_TextChanged++;
                                EntradaFuente.TextKey = "*";
                                EntradaFuenteTamano.ValueDecimal = 10;
                                Ingorar_EntradaFuenteFuenteTamano_TextChanged--;
                        }
                        EntradaLandscape.TextKey = Plantilla.Landscape ? "1" : "0";

                        System.Drawing.Printing.Margins Margen = Plantilla.Margenes;
                        if (Margen == null) {
                                EntradaMargenes.TextKey = "0";
                        } else {
                                EntradaMargenes.TextKey = "1";
                                EntradaMargenIzquierda.ValueInt = Margen.Left;
                                EntradaMargenDerecha.ValueInt = Margen.Right;
                                EntradaMargenArriba.ValueInt = Margen.Top;
                                EntradaMargenAbajo.ValueInt = Margen.Bottom;
                        }

                        EntradaFuenteFuenteTamano_TextChanged(this, null);

                        RecalcularTamanoVistaPrevia();
                        this.MostrarListaCampos();

                        base.ActualizarControl();
                }


                public override void ActualizarElemento()
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        if (EntradaFuente.TextKey == "*" && EntradaFuenteTamano.ValueDecimal > 1)
                                Plantilla.Font = null;
                        else
                                Plantilla.Font = new Font(EntradaFuente.TextKey, (float)(EntradaFuenteTamano.ValueDecimal));
                        Plantilla.Codigo = EntradaCodigo.Text;
                        Plantilla.Codigo = EntradaCodigo.Text;
                        Plantilla.Nombre = EntradaNombre.Text;
                        Plantilla.TamanoPapel = EntradaPapelTamano.TextKey;
                        Plantilla.Landscape = EntradaLandscape.TextKey == "1";
                        Plantilla.Copias = EntradaCopias.ValueInt;

                        if (EntradaMargenes.TextKey == "1") {
                                Plantilla.Margenes = new System.Drawing.Printing.Margins(
                                        EntradaMargenIzquierda.ValueInt,
                                        EntradaMargenDerecha.ValueInt,
                                        EntradaMargenArriba.ValueInt,
                                        EntradaMargenAbajo.ValueInt);
                        } else {
                                Plantilla.Margenes = null;
                        }

                        base.ActualizarElemento();
                }


                private void ImagePreview_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        e.Graphics.Clear(Color.Beige);
                        e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        e.Graphics.PageUnit = GraphicsUnit.Document;
                        e.Graphics.ScaleTransform(Zoom / 100f, Zoom / 100f);
                        e.Graphics.TranslateTransform(Desplazamiento.X, Desplazamiento.Y);

                        PointF[] Pts = new PointF[] { new Point(1000, 1000) };
                        e.Graphics.TransformPoints(System.Drawing.Drawing2D.CoordinateSpace.Device, System.Drawing.Drawing2D.CoordinateSpace.Page, Pts);
                        this.Escala = new PointF(1000f / Pts[0].X, 1000f / Pts[0].Y);

                        if (Plantilla == null || Plantilla.Campos == null)
                                return;

                        System.Drawing.RectangleF RectPagina = new System.Drawing.RectangleF(0 * this.EscalaMm.X, 0 * this.EscalaMm.Y, TamanoPapel.Width * this.EscalaMm.X, TamanoPapel.Height * this.EscalaMm.Y);
                        e.Graphics.FillRectangle(Brushes.DarkGray, new System.Drawing.RectangleF(2 * this.EscalaMm.X, 2 * this.EscalaMm.Y, TamanoPapel.Width * this.EscalaMm.X, TamanoPapel.Height * this.EscalaMm.Y));
                        if (Plantilla.Imagen != null)
                                e.Graphics.DrawImage(Plantilla.Imagen, RectPagina);
                        else
                                e.Graphics.FillRectangle(Brushes.White, RectPagina);

                        foreach (Lbl.Impresion.Campo Cam in Plantilla.Campos) {
                                Rectangle DrawRect = Cam.Rectangle;

                                //Invierto rectángulos con ancho o alto negativo, para poder dibujarlos
                                if (DrawRect.Width < 0) {
                                        DrawRect.Width = Math.Abs(DrawRect.Width);
                                        DrawRect.X -= DrawRect.Width;
                                }
                                if (DrawRect.Height < 0) {
                                        DrawRect.Height = Math.Abs(DrawRect.Height);
                                        DrawRect.Y -= DrawRect.Height;
                                }

                                if (Cam.AnchoBorde > 0)
                                        e.Graphics.DrawRectangle(new Pen(Cam.ColorBorde, Cam.AnchoBorde), DrawRect);
                                else
                                        e.Graphics.DrawRectangle(LapizBordeCampos, DrawRect);

                                if (Cam.ColorFondo != Color.Transparent)
                                        e.Graphics.FillRectangle(new SolidBrush(Cam.ColorFondo), DrawRect);

                                System.Drawing.Font FuenteItem;
                                if (Cam.Font != null)
                                        FuenteItem = Cam.Font;
                                else
                                        FuenteItem = Plantilla.Font;

                                string Texto = Cam.Valor;
                                Texto = Texto.Replace("{Cliente}", "Compañía La Estrella S.R.L.");
                                Texto = Texto.Replace("{Cliente.Nombre}", "Compañía La Estrella S.R.L.");
                                Texto = Texto.Replace("{Cliente.Documento}", "20-20123456-6");
                                Texto = Texto.Replace("{IVA}", "Responsable no inscripto");
                                Texto = Texto.Replace("{Cliente.Iva}", "Responsable no inscripto");
                                Texto = Texto.Replace("{CUIT}", "30-12345678-9");
                                Texto = Texto.Replace("{Cliente.Cuit}", "Responsable no inscripto");
                                Texto = Texto.Replace("{Domicilio}", "Avenida San Martín 1234, 3ro. B");
                                Texto = Texto.Replace("{Cliente.Domicilio}", "Avenida San Martín 1234, 3ro. B");
                                //Texto = Texto.Replace("{Fecha}", System.DateTime.Now.ToString("dd-MM-yyyy"));
                                Texto = Texto.Replace("{FormaPago}", "Cuenta corriente");
                                Texto = Texto.Replace("{Total}", "$ 123.456.789,00");
                                Texto = Texto.Replace("{Comprobante.Total}", "$ 123.456.789,00");
                                Texto = Texto.Replace("{Comprobante.IvaDiscriminado}", "$ 123.456,00");
                                Texto = Texto.Replace("{SubTotal}", "$ 123.456.789,00");
                                Texto = Texto.Replace("{SonPesos}", "ciento veintitres mil seiscientos setenta y ocho con 00/100");
                                Texto = Texto.Replace("{Codigos}", "00123456\r\n00123456\r\nABR012PM\r\nCODIGO99");
                                Texto = Texto.Replace("{Cantidades}", "1\r\n2\r\n1\r\n1");
                                Texto = Texto.Replace("{Precios}", "$ 123.456,00\r\n$ 123.456,00\r\n$ 123.456,00\r\n$ 123.456,00");
                                Texto = Texto.Replace("{Importes}", "$ 123.456,00\r\n$ 123.456,00\r\n$ 123.456,00\r\n$ 123.456,00");
                                Texto = Texto.Replace("{Detalles}", "Producto de ejemplo Nº 1\r\nProducto de ejemplo Nº 2\r\nProducto de ejemplo Nº 3\r\nProducto de ejemplo Nº 4");
                                Texto = Texto.Replace("{Valores}", "Efectivo        : $ 100.\r\nCheque          : $ 100.\r\nTarjeta de Déb. : $ 100.\r\nTarjeta de Cré. : $ 100.");
                                Texto = Texto.Replace("{Comprobante.Tipo}", "Nota de Crédito");

                                StringFormat StrFmt = new StringFormat(StringFormatFlags.NoClip);
                                StrFmt.Trimming = StringTrimming.None;
                                StrFmt.Alignment = Cam.Alignment;
                                StrFmt.LineAlignment = Cam.LineAlignment;

                                if (FuenteItem == null)
                                        FuenteItem = Lazaro.Pres.DisplayStyles.Template.Current.DefaultFont;
                                e.Graphics.DrawString(Texto, FuenteItem, new SolidBrush(Cam.ColorTexto), DrawRect, StrFmt);

                                if (CampoSeleccionado == Cam) {
                                        e.Graphics.FillRectangle(BrushSeleccion, DrawRect);

                                        string Lbl = DrawRect.Location.ToString();
                                        RectangleF LabelRect = new RectangleF(new PointF(DrawRect.X + 10, DrawRect.Y + DrawRect.Height + 11), e.Graphics.MeasureString(Lbl, FieldInfoFont));
                                        LabelRect.Inflate(10, 10);
                                        e.Graphics.FillRectangle(SystemBrushes.Info, LabelRect);
                                        StrFmt = new StringFormat(StringFormatFlags.NoClip);
                                        StrFmt.Alignment = StringAlignment.Center;
                                        StrFmt.LineAlignment = StringAlignment.Center;
                                        e.Graphics.DrawString(Lbl, FieldInfoFont, SystemBrushes.InfoText, LabelRect, StrFmt);

                                        Rectangle RectKnob = new Rectangle(Cam.Rectangle.Right - KnobSize / 2, Cam.Rectangle.Bottom - KnobSize / 2, KnobSize, KnobSize);
                                        e.Graphics.FillEllipse(BrushKnob, RectKnob);
                                        e.Graphics.DrawEllipse(BrushKnobBorder, RectKnob);
                                }
                        }
                }


                private void ListaCampos_SelectedIndexChanged(object sender, System.EventArgs e)
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        if (Plantilla.Campos != null && ListaCampos.SelectedItems.Count > 0) {
                                CampoSeleccionado = ListaCampos.SelectedItems[0].Tag as Lbl.Impresion.Campo;
                        } else {
                                CampoSeleccionado = null;
                        }

                        ImagePreview.Invalidate();
                }

                private Point PuntoDesdePantalla(Point pt)
                {
                        return PuntoDesdePantalla(pt, true);
                }

                private Point PuntoDesdePantalla(Point pt, bool usarGrilla)
                {
                        Point Res = new Point(System.Convert.ToInt32(pt.X * this.Escala.X / (this.Zoom / 100F)), System.Convert.ToInt32(pt.Y * this.Escala.Y / (this.Zoom / 100F)));
                        Res.Offset(-Desplazamiento.X, -Desplazamiento.Y);
                        if (usarGrilla) {
                                Res.X = System.Convert.ToInt32(Res.X / this.GridSize) * this.GridSize;
                                Res.Y = System.Convert.ToInt32(Res.Y / this.GridSize) * this.GridSize;
                        }
                        return Res;
                }

                private void ImagePreview_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
                {
                        if (e.Button == System.Windows.Forms.MouseButtons.Middle) {
                                ButtonDown = new Point(e.X, e.Y);
                        } else if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                                ButtonDown = PuntoDesdePantalla(new Point(e.X, e.Y));
                                Point MyButtonDown = PuntoDesdePantalla(new Point(e.X, e.Y), false);

                                Lbl.Impresion.Campo CampoSeleccionadoOriginal = CampoSeleccionado;
                                if (CampoSeleccionado != null) {
                                        Rectangle RectKnob = new Rectangle(CampoSeleccionado.Rectangle.Right - KnobSize / 2, CampoSeleccionado.Rectangle.Bottom - KnobSize / 2, KnobSize, KnobSize);
                                        if (CampoSeleccionado != null && RectKnob.Contains(MyButtonDown)) {
                                                //Agarró el knob
                                                KnobGrabbed = true;
                                                return;
                                        } else {
                                                KnobGrabbed = false;
                                        }
                                }

                                Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                                bool Select = false;
                                CampoSeleccionado = null;
                                foreach (Lbl.Impresion.Campo Cam in Plantilla.Campos) {
                                        //Busco el campo del clic (según coordenadas)
                                        if (Cam.Valor == null || Cam.Valor.Length == 0 && Cam.AnchoBorde > 0) {
                                                //En el caso particular de los rectángulos con borde y sin texto, tiene que hacer clic en el contorno
                                                if ((MyButtonDown.X >= (Cam.Rectangle.Left - 5) && (MyButtonDown.X <= (Cam.Rectangle.Left + 5)) ||
                                                        MyButtonDown.X >= (Cam.Rectangle.Right - 5) && (MyButtonDown.X <= (Cam.Rectangle.Right + 5)) ||
                                                        MyButtonDown.Y >= (Cam.Rectangle.Top - 5) && (MyButtonDown.Y <= (Cam.Rectangle.Top + 5)) ||
                                                        MyButtonDown.Y >= (Cam.Rectangle.Bottom - 5) && (MyButtonDown.Y <= (Cam.Rectangle.Bottom + 5))))
                                                        Select = true;
                                                else
                                                        Select = false;
                                                KnobGrabbed = false;
                                        } else if (Cam.Rectangle.Contains(MyButtonDown)) {
                                                //El resto de los campos, se seleccionan haciendo clic en cualquier parte del rectángulo
                                                Select = true;
                                                KnobGrabbed = false;
                                        }

                                        if (Select) {
                                                //Encontré el campo del Click
                                                //Lo selecciono mediante la listview
                                                CampoSeleccionado = Cam;
                                                this.SeleccionarCampo(Cam);
                                                break;
                                        }
                                }

                                //if (CampoSeleccionado == null)
                                //        CampoSeleccionado = CampoSeleccionadoOriginal;

                                if (CampoSeleccionado == null)
                                        this.SeleccionarCampo(null);
                                else
                                        CampoDown = CampoSeleccionado.Rectangle;
                        }
                }

                private void ImagePreview_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
                {
                        if (e.Button == System.Windows.Forms.MouseButtons.Middle) {
                                Point OldDesplazamiento = this.Desplazamiento;
                                this.Desplazamiento = new Point(0, 0);
                                Point Diferencia = PuntoDesdePantalla(new Point(e.X - ButtonDown.X, e.Y - ButtonDown.Y), false);
                                this.Desplazamiento = OldDesplazamiento;
                                this.Desplazamiento.Offset(Diferencia);
                                ButtonDown = new Point(e.X, e.Y);
                                ImagePreview.Invalidate();
                        } else if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                                if (CampoSeleccionado != null) {
                                        if (KnobGrabbed) {
                                                //Point NewCampoPos = new Point(CampoDown.Right, CampoDown.Bottom);
                                                Point PosCursor = PuntoDesdePantalla(new Point(e.X, e.Y));
                                                PosCursor.X -= CampoSeleccionado.Rectangle.Left;
                                                PosCursor.Y -= CampoSeleccionado.Rectangle.Top;
                                                CampoSeleccionado.Rectangle.Width = PosCursor.X;
                                                CampoSeleccionado.Rectangle.Height = PosCursor.Y;
                                        } else {
                                                Point NewCampoPos = CampoDown.Location;
                                                Point PosCursor = PuntoDesdePantalla(new Point(e.X, e.Y));
                                                NewCampoPos.Offset(PosCursor.X - ButtonDown.X, PosCursor.Y - ButtonDown.Y);
                                                CampoSeleccionado.Rectangle.Location = NewCampoPos;
                                        }
                                        ImagePreview.Invalidate();
                                }
                        }
                }

                private void EntradaPapelTamano_TextChanged(object sender, System.EventArgs e)
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        Plantilla.TamanoPapel = EntradaPapelTamano.TextKey;
                        Plantilla.Landscape = EntradaLandscape.TextKey == "1";

                        RecalcularTamanoVistaPrevia();
                }

                private static System.Drawing.Size ObtenerTamanoPapel(string tipoPapel)
                {
                        switch (tipoPapel.ToLower()) {
                                case "a4":
                                        return new System.Drawing.Size(210, 297);
                                case "a5":
                                        return new System.Drawing.Size(148, 210);
                                case "letter":
                                        return new System.Drawing.Size(216, 279);
                                case "legal":
                                        return new System.Drawing.Size(216, 356);
                                case "cont":
                                        return new System.Drawing.Size(216, 305);
                                default:
                                        //Predeterminado A4
                                        return new System.Drawing.Size(210, 297);
                        }
                }

                private void ListaCampos_DoubleClick(object sender, System.EventArgs e)
                {
                        EditarCampoSeleccionado();
                }


                private void ImagePreview_DoubleClick(object sender, System.EventArgs e)
                {
                        EditarCampoSeleccionado();
                }


                private void EditarCampoSeleccionado()
                {
                        if (CampoSeleccionado != null) {
                                EditarCampo FormEditarCampo = new EditarCampo(CampoSeleccionado);
                                if (FormEditarCampo.ShowDialog() == DialogResult.OK) {
                                        this.ActualizarCampos();
                                        ImagePreview.Invalidate();
                                }
                        }
                }


                private void BotonAgregar_Click(object sender, EventArgs e)
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        Lbl.Impresion.Campo Cam = new Lbl.Impresion.Campo();
                        Cam.Valor = "Nuevo campo";
                        Cam.Rectangle = new Rectangle(10, 10, 280, 52);
                        Plantilla.Campos.Add(Cam);
                        this.AgregarCampo(Cam);
                        this.SeleccionarCampo(Cam);
                        ListaCampos_DoubleClick(sender, e);
                        ImagePreview.Invalidate();
                }

                private void SeleccionarCampo(Lbl.Impresion.Campo campo)
                {
                        foreach (ListViewItem Itm in ListaCampos.Items) {
                                if (Itm.Tag == campo) {
                                        Itm.Selected = true;
                                        Itm.EnsureVisible();
                                } else {
                                        Itm.Selected = false;
                                }
                        }
                }

                private void MostrarListaCampos()
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        ListaCampos.BeginUpdate();
                        ListaCampos.Items.Clear();
                        if (Plantilla.Campos != null) {
                                foreach (Lbl.Impresion.Campo Cam in Plantilla.Campos) {
                                        AgregarCampo(Cam);
                                }
                        }
                        ListaCampos.EndUpdate();
                }

                private void AgregarCampo(Lbl.Impresion.Campo campo)
                {
                        ListViewItem Itm = ListaCampos.Items.Add(campo.Valor);
                        Itm.Tag = campo;
                }

                private void ActualizarCampos()
                {
                        foreach (ListViewItem Itm in ListaCampos.Items) {
                                Lbl.Impresion.Campo Cam = Itm.Tag as Lbl.Impresion.Campo;
                                if (Cam != null) {
                                        Itm.Text = Cam.Valor;
                                }
                        }
                }


                private void BotonQuitar_Click(object sender, EventArgs e)
                {
                        if (CampoSeleccionado != null) {
                                Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                                Plantilla.Campos.Remove(CampoSeleccionado);
                                this.MostrarListaCampos();
                                ImagePreview.Invalidate();
                        }
                }


                private int Ingorar_EntradaFuenteFuenteTamano_TextChanged = 0;
                private void EntradaFuenteFuenteTamano_TextChanged(object sender, EventArgs e)
                {
                        if (Ingorar_EntradaFuenteFuenteTamano_TextChanged > 0)
                                return;

                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        EntradaFuenteTamano.Enabled = (EntradaFuente.TextKey != "*");
                        if (EntradaFuente.TextKey != "*" && EntradaFuenteTamano.ValueDecimal > 0)
                                Plantilla.Font = new Font(EntradaFuente.TextKey, ((float)(EntradaFuenteTamano.ValueDecimal)));
                        else
                                Plantilla.Font = new Font("Courier New", 10);
                }

                private void ZoomBar_Scroll(object sender, EventArgs e)
                {
                        this.Zoom = ZoomBar.Value;
                        RecalcularTamanoVistaPrevia();
                }

                public void RecalcularTamanoVistaPrevia()
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        if (Plantilla == null)
                                return;

                        TamanoPapel = ObtenerTamanoPapel(Plantilla.TamanoPapel);
                        if (Plantilla.Landscape)
                                TamanoPapel = new Size(TamanoPapel.Height, TamanoPapel.Width);

                        ImagePreview.Invalidate();
                }

                private void Guardar()
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        SaveFileDialog FileDialog = new SaveFileDialog();
                        FileDialog.Filter = "Archivos de plantilla|*.ltx";
                        FileDialog.DefaultExt = "ltx";
                        FileDialog.FileName = Plantilla.ToString();
                        if (FileDialog.ShowDialog() == DialogResult.OK) {
                                System.IO.StreamWriter Str = new System.IO.StreamWriter(FileDialog.FileName, false);
                                Str.Write(Plantilla.Definicion.InnerXml);
                                Str.Close();
                        }
                }

                private void Cargar()
                {
                        Lbl.Impresion.Plantilla Plantilla = this.Elemento as Lbl.Impresion.Plantilla;

                        OpenFileDialog FileDialog = new OpenFileDialog();
                        FileDialog.Filter = "Archivos de plantilla|*.ltx";
                        FileDialog.DefaultExt = "ltx";
                        FileDialog.FileName = Plantilla.ToString();
                        if (FileDialog.ShowDialog() == DialogResult.OK) {
                                System.IO.StreamReader Str = new System.IO.StreamReader(FileDialog.FileName, true);
                                Plantilla.CargarXml(Str.ReadToEnd());
                                Str.Close();
                                this.MostrarListaCampos();
                        }
                }

                private void ImagePreview_MouseUp(object sender, MouseEventArgs e)
                {
                        if (CampoSeleccionado != null) {
                                if (CampoSeleccionado.Rectangle.Width < 0) {
                                        CampoSeleccionado.Rectangle.Width = Math.Abs(CampoSeleccionado.Rectangle.Width);
                                        CampoSeleccionado.Rectangle.X -= CampoSeleccionado.Rectangle.Width;
                                }
                                if (CampoSeleccionado.Rectangle.Height < 0) {
                                        CampoSeleccionado.Rectangle.Height = Math.Abs(CampoSeleccionado.Rectangle.Height);
                                        CampoSeleccionado.Rectangle.Y -= CampoSeleccionado.Rectangle.Height;
                                }
                                ImagePreview.Invalidate();
                        }
                }

                private void Editar_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Delete && e.Alt == false && e.Control == false && e.Shift == false) {
                                BotonQuitar.PerformClick();
                        }
                }

                private void EntradaMargenes_TextChanged(object sender, EventArgs e)
                {
                        EntradaMargenIzquierda.Visible = EntradaMargenes.TextKey == "1";
                        EntradaMargenDerecha.Visible = EntradaMargenIzquierda.Visible;
                        EntradaMargenArriba.Visible = EntradaMargenIzquierda.Visible;
                        EntradaMargenAbajo.Visible = EntradaMargenIzquierda.Visible;
                }


                public override Lazaro.Pres.DisplayStyles.IDisplayStyle HeaderDisplayStyle
                {
                        get
                        {
                                return Lazaro.Pres.DisplayStyles.Template.Current.Comprobantes;
                        }
                }


                public override Lazaro.Pres.Forms.FormActionCollection GetFormActions()
                {
                        Lazaro.Pres.Forms.FormActionCollection Res = base.GetFormActions();
                        Res.Add(new Lazaro.Pres.Forms.FormAction("Guardar", "F4", "guardar", 20, Lazaro.Pres.Forms.FormActionVisibility.Secondary));
                        Res.Add(new Lazaro.Pres.Forms.FormAction("Cargar", "F5", "cargar", 10, Lazaro.Pres.Forms.FormActionVisibility.Secondary));
                        return Res;
                }


                public override Lfx.Types.OperationResult PerformFormAction(string name)
                {
                        switch (name) {
                                case "guardar":
                                        Guardar();
                                        return new Lfx.Types.SuccessOperationResult();
                                case "cargar":
                                        Cargar();
                                        return new Lfx.Types.SuccessOperationResult();
                                default:
                                        return base.PerformFormAction(name);
                        }
                }

                private void BotonGeneral_Click(object sender, EventArgs e)
                {
                        PanelGeneral.Visible = true;
                        PanelDiseno.Visible = false;
                }

                private void BotonDiseno_Click(object sender, EventArgs e)
                {
                        PanelGeneral.Visible = false;
                        PanelDiseno.Visible = true;
                }
        }
}