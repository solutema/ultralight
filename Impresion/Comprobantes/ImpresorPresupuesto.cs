#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

using System.Data;
using System.Drawing;

namespace Lazaro.Impresion.Comprobantes
{
        public class ImpresorPresupuesto : ImpresorComprobante
        {
                private int m_Pagina;

                public ImpresorPresupuesto(Lbl.ElementoDeDatos elemento, IDbTransaction transaction)
                        : base(elemento, transaction) { }

                public Lbl.Comprobantes.Presupuesto Presupuesto
                {
                        get
                        {
                                return this.Elemento as Lbl.Comprobantes.Presupuesto;
                        }
                }

                protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e)
                {
                        // Abro el Comprobante
                        m_Pagina = 0;

                        DefaultPageSettings.Margins.Bottom = 60;
                        DefaultPageSettings.Margins.Top = 140;
                        DefaultPageSettings.Margins.Left = 100;
                        DefaultPageSettings.Margins.Right = 80;

                        base.OnBeginPrint(e);
                }

                protected override Lbl.Impresion.Plantilla ObtenerPlantilla()
                {
                        // Los presupuestos no usan plantilla por ahora
                        return null;
                }

                protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e)
                {
                        e.PageSettings.Landscape = false;
                        e.Graphics.PageUnit = GraphicsUnit.Display;

                        m_Pagina++;

                        int PrintAreaHeight = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top - base.DefaultPageSettings.Margins.Bottom,
                                PrintAreaWidth = base.DefaultPageSettings.PaperSize.Width - base.DefaultPageSettings.Margins.Left - base.DefaultPageSettings.Margins.Right,
                                MarginLeft = base.DefaultPageSettings.Margins.Left,
                                MarginTop = base.DefaultPageSettings.Margins.Top;

                        // intMarginBottom = MyBase.DefaultPageSettings.Margins.Bottom
                        if (base.DefaultPageSettings.Landscape) {
                                int intTemp = 0;
                                intTemp = PrintAreaHeight;
                                PrintAreaHeight = PrintAreaWidth;
                                PrintAreaWidth = intTemp;
                        }

                        //RectangleF PrintingArea = new RectangleF(MarginLeft, MarginTop, PrintAreaWidth, PrintAreaHeight);

                        StringFormat FormatoCC = new StringFormat();
                        FormatoCC.Alignment = StringAlignment.Center;
                        FormatoCC.LineAlignment = StringAlignment.Center;
                        StringFormat FormatoLC = new StringFormat();
                        FormatoLC.Alignment = StringAlignment.Near;
                        FormatoLC.LineAlignment = StringAlignment.Center;
                        FormatoLC.FormatFlags = StringFormatFlags.NoWrap;
                        FormatoLC.Trimming = StringTrimming.EllipsisCharacter;
                        StringFormat FormatoRC = new StringFormat();
                        FormatoRC.Alignment = StringAlignment.Far;
                        FormatoRC.LineAlignment = StringAlignment.Center;
                        StringFormat FormatoLT = new StringFormat();
                        FormatoLT.Alignment = StringAlignment.Near;
                        FormatoLT.LineAlignment = StringAlignment.Near;
                        FormatoLT.FormatFlags = StringFormatFlags.LineLimit;
                        FormatoLT.Trimming = StringTrimming.EllipsisWord;

                        Font Fuente = null;
                        Font FuentePequena = new Font("Arial", 7);
                        RectangleF Rect = new System.Drawing.RectangleF();
                        int iTop = MarginTop;

                        // Título: PRESUPUESTO
                        Fuente = new Font("Arial Black", 20);
                        Rect = new RectangleF(MarginLeft, iTop, PrintAreaWidth, 32);
                        e.Graphics.DrawString("PRESUPUESTO", Fuente, Brushes.SteelBlue, Rect, FormatoCC);
                        // ev.Graphics.DrawRectangle(Pens.Silver, Rect.X, Rect.Y, Rect.Width, Rect.Height)
                        iTop += System.Convert.ToInt32(Rect.Height);

                        // Fecha
                        Fuente = new Font("Arial", 9);
                        Rect = new RectangleF(MarginLeft, iTop, PrintAreaWidth, 18);
                        e.Graphics.DrawString(System.DateTime.Now.ToString(Lfx.Types.Formatting.DateTime.LongDatePattern), Fuente, Brushes.Black, Rect,
                                               FormatoCC);
                        // ev.Graphics.DrawRectangle(Pens.Red, Rect.X, Rect.Y, Rect.Width, Rect.Height)
                        iTop += System.Convert.ToInt32(Rect.Height + 4);

                        // Cliente
                        Rect = new RectangleF(MarginLeft, iTop, PrintAreaWidth - 100, 20);
                        e.Graphics.DrawString("Para: " + this.Presupuesto.Cliente.Nombre, Fuente, Brushes.Black, Rect, FormatoLC);
                        // ev.Graphics.DrawRectangle(Pens.Blue, Rect.X, Rect.Y, Rect.Width, Rect.Height)

                        // Nº PS
                        Rect = new RectangleF(MarginLeft + PrintAreaWidth - 100, iTop, 100, 20);
                        e.Graphics.DrawString("PS" + this.Presupuesto.Numero.ToString("000000"), Fuente,
                                               Brushes.Black, Rect,
                                               FormatoRC);
                        // ev.Graphics.DrawRectangle(Pens.Green, Rect.X, Rect.Y, Rect.Width, Rect.Height)
                        iTop += System.Convert.ToInt32(Rect.Height + 4);

                        // Encab
                        Fuente = new Font("Arial", 10, FontStyle.Bold);
                        Rect = new RectangleF(MarginLeft, iTop, PrintAreaWidth, 20);
                        e.Graphics.FillRectangle(Brushes.Wheat, Rect.X, Rect.Y, Rect.Width, Rect.Height);
                        Rect = new RectangleF(MarginLeft, iTop, 20, 20);
                        e.Graphics.DrawString("#", Fuente, Brushes.DimGray, Rect, FormatoRC);
                        Rect = new RectangleF(MarginLeft + 26, iTop, 40, 20);
                        e.Graphics.DrawString("Cant", Fuente, Brushes.Black, Rect, FormatoRC);
                        Rect = new RectangleF(MarginLeft + 70, iTop, PrintAreaWidth - MarginLeft - 160, 20);
                        e.Graphics.DrawString("Detalle", Fuente, Brushes.Black, Rect, FormatoLC);
                        // ev.Graphics.DrawRectangle(Pens.Violet, Rect.X, Rect.Y, Rect.Width, Rect.Height)
                        Rect = new RectangleF(MarginLeft + PrintAreaWidth - 200, iTop, 100, 20);
                        e.Graphics.DrawString("Precio", Fuente, Brushes.Black, Rect, FormatoRC);
                        Rect = new RectangleF(MarginLeft + PrintAreaWidth - 100, iTop, 100, 20);
                        e.Graphics.DrawString("Importe", Fuente, Brushes.Black, Rect, FormatoRC);
                        // ev.Graphics.DrawRectangle(Pens.Violet, Rect.X, Rect.Y, Rect.Width, Rect.Height)
                        iTop += System.Convert.ToInt32(Rect.Height + 4);

                        // Obs
                        int AlturaPie = 0;

                        if (this.Elemento.Obs != null && this.Elemento.Obs.Length > 0) {
                                Rect = new RectangleF(MarginLeft, 0, PrintAreaWidth, 500);
                                SizeF Tamano = e.Graphics.MeasureString("Obs: " + this.Elemento.Obs,
                                                                         FuentePequena,
                                                                         Rect.Size,
                                                                         FormatoLT);
                                Rect.Height = Tamano.Height;
                                Rect.Y = MarginTop + PrintAreaHeight - 20 - Rect.Height;
                                e.Graphics.DrawString("Obs: " + this.Elemento.Obs, FuentePequena,
                                                       Brushes.Black, Rect,
                                                       FormatoLT);
                                AlturaPie += System.Convert.ToInt32(Rect.Height);
                        }

                        AlturaPie += 24;

                        // Detalle
                        Fuente = new Font("Bitstream Vera Sans", 10);
                        int RowNumber = 0;

                        foreach (Lbl.Comprobantes.DetalleArticulo Detalle in this.Presupuesto.Articulos) {
                                RowNumber++;

                                Rect = new RectangleF(MarginLeft, iTop, 20, 20);
                                e.Graphics.DrawString(RowNumber.ToString(), Fuente, Brushes.DarkGray, Rect, FormatoRC);
                                Rect = new RectangleF(MarginLeft + 26, iTop, 40, 20);
                                e.Graphics.DrawString(
                                    Lfx.Types.Formatting.FormatNumber(Detalle.Cantidad, this.Workspace.CurrentConfig.Productos.DecimalesStock),
                                    Fuente,
                                    Brushes.Black, Rect, FormatoRC);
                                Rect = new RectangleF(MarginLeft + 70, iTop, PrintAreaWidth - MarginLeft - 160, 20);
                                e.Graphics.DrawString(Detalle.Nombre, Fuente, Brushes.Black, Rect, FormatoLC);
                                Rect = new RectangleF(MarginLeft + PrintAreaWidth - 200, iTop, 100, 20);
                                e.Graphics.DrawString(Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatNumber(Detalle.Unitario, this.Workspace.CurrentConfig.Moneda.DecimalesCosto), Fuente, Brushes.Black, Rect, FormatoRC);
                                Rect = new RectangleF(MarginLeft + PrintAreaWidth - 100, iTop, 100, 20);
                                e.Graphics.DrawString(Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatNumber(Detalle.Importe, this.Workspace.CurrentConfig.Moneda.DecimalesCosto), Fuente, Brushes.Black, Rect, FormatoRC);
                                iTop += 20;

                                if (Detalle.Articulo != null) {
                                        Rect = new RectangleF(MarginLeft + 70, iTop, PrintAreaWidth - MarginLeft - 140, 100);
                                        if (Detalle.Articulo.Descripcion != null && Detalle.Articulo.Descripcion.Length > 0) {
                                                SizeF Tamano = e.Graphics.MeasureString(Detalle.Articulo.Descripcion, FuentePequena, Rect.Size, FormatoLT);

                                                if (Tamano.Height > 50) {
                                                        Tamano.Height = 50;
                                                }

                                                Rect.Height = Tamano.Height;
                                                e.Graphics.DrawString(Detalle.Articulo.Descripcion, FuentePequena, Brushes.Black, Rect, FormatoLT);
                                                iTop += System.Convert.ToInt32(Rect.Height);
                                        }
                                }

                                Rect = new RectangleF(MarginLeft, iTop, PrintAreaWidth, 4);
                                e.Graphics.DrawLine(Pens.Gray, Rect.X, Rect.Y, Rect.X + Rect.Width, Rect.Y);
                                iTop += System.Convert.ToInt32(Rect.Height);

                                if (iTop > PrintAreaHeight - AlturaPie - 52) {
                                        // Los 52 son para Subtotal y total
                                        break;
                                }
                        }

                        if (RowNumber < this.Presupuesto.Articulos.Count) {
                                //No es última página
                                // Pie Der
                                Fuente = new Font("Arial", 8, FontStyle.Italic);
                                iTop = MarginTop + PrintAreaHeight - 24;
                                Rect = new RectangleF(MarginLeft + PrintAreaWidth - 160, iTop, 160, 12);
                                e.Graphics.DrawString("Página " + m_Pagina.ToString(), Fuente, Brushes.Black, Rect, FormatoRC);
                                iTop += System.Convert.ToInt32(Rect.Height);
                                Rect = new RectangleF(MarginLeft + PrintAreaWidth - 160, iTop, 160, 12);
                                e.Graphics.DrawString("Continúa en pág. " + (m_Pagina + 1).ToString(), Fuente, Brushes.Black, Rect, FormatoRC);
                                e.HasMorePages = true;
                        } else {
                                iTop += 10;
                                int iTopOld = iTop; // Guardo el iTop. Imprimo a la iquierda, vuelvo arriba e imprimo a la derecha

                                if (this.Presupuesto.Descuento > 0) {
                                        Rect = new RectangleF(MarginLeft, iTop, 240, 14);
                                        e.Graphics.DrawString("Descuento: " + Lfx.Types.Formatting.FormatNumber(this.Presupuesto.Descuento, 2) + "%", Fuente, Brushes.Black, Rect, FormatoLC);
                                        iTop += System.Convert.ToInt32(Rect.Height);
                                }

                                if (this.Presupuesto.Recargo > 0) {
                                        Rect = new RectangleF(MarginLeft, iTop, 240, 14);
                                        e.Graphics.DrawString("Recargo: " + Lfx.Types.Formatting.FormatNumber(this.Presupuesto.Recargo, 2) + "%", Fuente, Brushes.Black, Rect, FormatoLC);
                                        iTop += System.Convert.ToInt32(Rect.Height);
                                }

                                if (this.Presupuesto.Cuotas > 0) {
                                        Rect = new RectangleF(MarginLeft, iTop, 240, 14);
                                        e.Graphics.DrawString(this.Presupuesto.Cuotas.ToString() + " cuotas de " + Lbl.Sys.Config.Actual.Moneda.Simbolo + Lfx.Types.Formatting.FormatCurrency(this.Presupuesto.Total / this.Presupuesto.Cuotas, this.Workspace.CurrentConfig.Moneda.Decimales), Fuente, Brushes.Black, Rect, FormatoLC);
                                        iTop += System.Convert.ToInt32(Rect.Height);
                                }

                                iTop = iTopOld;
                                Fuente = new Font("Arial", 12);
                                Rect = new RectangleF(MarginLeft + PrintAreaWidth - 200, iTop, 200, 20);
                                e.Graphics.DrawString("Subtotal: " + Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(this.Presupuesto.SubTotal, this.Workspace.CurrentConfig.Moneda.Decimales), Fuente, Brushes.Black, Rect, FormatoRC);
                                iTop += System.Convert.ToInt32(Rect.Height + 4);

                                Fuente = new Font("Arial Black", 14);
                                Rect = new RectangleF(MarginLeft + PrintAreaWidth - 220, iTop, 220, 28);
                                string Total = "Total: " + Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(this.Presupuesto.Total, this.Workspace.CurrentConfig.Moneda.Decimales);
                                SizeF Tamano = e.Graphics.MeasureString(Total, Fuente, Rect.Location, FormatoLT);
                                Rect.Width = Tamano.Width + 20;
                                Rect.Height = Tamano.Height + 10;
                                Rect.X = MarginLeft + PrintAreaWidth - Rect.Width;
                                e.Graphics.DrawRectangle(new Pen(Color.Gray, 2), Rect.X, Rect.Y, Rect.Width, Rect.Height);
                                e.Graphics.DrawString(Total, Fuente, Brushes.Black, Rect, FormatoCC);

                                Fuente = new Font("Arial", 8, FontStyle.Italic);
                                iTop = MarginTop + PrintAreaHeight - 24;
                                Rect = new RectangleF(MarginLeft + PrintAreaWidth - 160, iTop, 160, 12);
                                e.Graphics.DrawString("Página " + m_Pagina.ToString(), Fuente, Brushes.Black, Rect, FormatoRC);
                                iTop += System.Convert.ToInt32(Rect.Height);

                                if (m_Pagina == 1) {
                                        Rect = new RectangleF(MarginLeft + PrintAreaWidth - 160, iTop, 160, 12);
                                        e.Graphics.DrawString("de 1.", Fuente, Brushes.Black, Rect, FormatoRC);
                                } else {
                                        Rect = new RectangleF(MarginLeft + PrintAreaWidth - 160, iTop, 160, 12);
                                        e.Graphics.DrawString("Esta es la última página.", Fuente, Brushes.Black, Rect, FormatoRC);
                                }

                                e.HasMorePages = false;
                        }

                        // Pie Izq
                        Fuente = new Font("Arial", 9);
                        iTop = MarginTop + PrintAreaHeight - 12;
                        Rect = new RectangleF(MarginLeft, iTop, PrintAreaWidth - 160, 12);
                        e.Graphics.DrawString("Lo atendió: " + this.Presupuesto.Vendedor.Nombre, Fuente, Brushes.Black, Rect, FormatoLC);

                        base.OnPrintPage(e);
                }
        }
}