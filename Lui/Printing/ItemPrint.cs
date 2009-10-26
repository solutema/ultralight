// Copyright 2004-2009 South Bridge S.R.L.
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
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Lui.Printing
{
    public class ItemPrint:
        System.Drawing.Printing.PrintDocument
    {
        private string m_Titulo = "Item";
        private int m_TamanoFuente;
        private Image m_Imagen;
        private System.Collections.ArrayList m_Pares;

        public void ParesAgregar(string Nombre, string Valor, int Nivel)
        {
            if(m_Pares == null)
            {
                m_Pares = new System.Collections.ArrayList();
            }

            System.Collections.ArrayList Par = new System.Collections.ArrayList();
            Par.Add(Nombre);
            Par.Add(Valor);
            Par.Add(Nivel);
            m_Pares.Add(Par);
        }

        public int TamanoFuente
        {
            get
            {
                return m_TamanoFuente;
            }
            set
            {
                m_TamanoFuente = value;
            }
        }

        public Image Imagen
        {
            get
            {
                return m_Imagen;
            }
            set
            {
                m_Imagen = value;
            }
        }

        public string Titulo
        {
            get
            {
                return m_Titulo;
            }
            set
            {
                m_Titulo = value;
            }
        }

        protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs ev)
        {
            base.OnBeginPrint(ev);

            this.DocumentName = m_Titulo;
            DefaultPageSettings.Margins.Bottom = 60;
            DefaultPageSettings.Margins.Top = 140;
            DefaultPageSettings.Margins.Left = 100;
            DefaultPageSettings.Margins.Right = 50;
        }

        protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs ev)
        {
            base.OnPrintPage(ev);

            int intPrintAreaHeight = 0, intPrintAreaWidth = 0, intMarginLeft = 0, intMarginTop = 0;
            intPrintAreaHeight = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top
                                     - base.DefaultPageSettings.Margins.Bottom;
            intPrintAreaWidth = base.DefaultPageSettings.PaperSize.Width - base.DefaultPageSettings.Margins.Left
                                    - base.DefaultPageSettings.Margins.Right;
            intMarginLeft = base.DefaultPageSettings.Margins.Left;
            intMarginTop = base.DefaultPageSettings.Margins.Top;

            // intMarginBottom = MyBase.DefaultPageSettings.Margins.Bottom
            if(base.DefaultPageSettings.Landscape)
            {
                int intTemp = 0;
                intTemp = intPrintAreaHeight;
                intPrintAreaHeight = intPrintAreaWidth;
                intPrintAreaWidth = intTemp;
            }

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
            RectangleF Rect = new System.Drawing.RectangleF();
            int iTop = intMarginTop;

            // Imagen
            if(m_Imagen != null)
            {
                Rect = new RectangleF(intMarginLeft, iTop, 120, 80);
                ev.Graphics.DrawImage(m_Imagen, Rect);
                iTop += 50; // Dejo que el título (32 de alto) se superponga un poco con la imagen (80 de alto)
            }

            // Ttulo
            if(m_TamanoFuente == -1)
            {
                Fuente = new Font("Arial", 16, FontStyle.Bold);
            }
            else if(m_TamanoFuente == -2)
            {
                Fuente = new Font("Arial", 14, FontStyle.Bold);
            }
            else
            {
                Fuente = new Font("Arial", 20, FontStyle.Bold);
            }

            Rect = new RectangleF(intMarginLeft + 128, iTop, intPrintAreaWidth - 128, 32);
            ev.Graphics.DrawString(m_Titulo, Fuente, Brushes.SteelBlue, Rect, FormatoLC);
            iTop += System.Convert.ToInt32(Rect.Height + 2);
            Rect = new RectangleF(intMarginLeft, iTop, intPrintAreaWidth, 32);
            ev.Graphics.DrawRectangle(new Pen(Color.SteelBlue, 2), Rect.X, iTop, Rect.Width, 1);
            iTop += 20;

            // Detalles
            Font FuenteNombre = null;
            RectangleF Rect2 = new System.Drawing.RectangleF();

            foreach(System.Collections.ArrayList Par in m_Pares)
            {
                string Nombre = System.Convert.ToString(Par[0]);
                string Valor = System.Convert.ToString(Par[1]);
                int Nivel = System.Convert.ToInt32(Par[2]);

                if(Nivel == 1)
                {
                    if(m_TamanoFuente == -1)
                    {
                        FuenteNombre = new Font("Arial", 9, FontStyle.Bold);
                        Fuente = new Font("Arial", 9);
                    }
                    else if(m_TamanoFuente == -2)
                    {
                        FuenteNombre = new Font("Arial", 8, FontStyle.Bold);
                        Fuente = new Font("Arial", 8);
                    }
                    else
                    {
                        FuenteNombre = new Font("Arial", 10, FontStyle.Bold);
                        Fuente = new Font("Arial", 10);
                    }

                    Rect = new RectangleF(intMarginLeft, iTop, 160, 320);
                }
                else
                {
                    if(m_TamanoFuente == -1)
                    {
                        FuenteNombre = new Font("Arial", 8);
                        Fuente = new Font("Arial", 8);
                    }
                    else if(m_TamanoFuente == -2)
                    {
                        FuenteNombre = new Font("Arial", 7);
                        Fuente = new Font("Arial", 7);
                    }
                    else
                    {
                        FuenteNombre = new Font("Arial", 9);
                        Fuente = new Font("Arial", 9);
                    }

                    Rect = new RectangleF(intMarginLeft + 20, iTop, 140, 320);
                }

                SizeF Tamano1 = ev.Graphics.MeasureString(Nombre, FuenteNombre, Rect.Size, FormatoLT);
                Rect2 = new RectangleF(intMarginLeft + 168, iTop, intPrintAreaWidth - 168, 320);
                SizeF Tamano2 = ev.Graphics.MeasureString(Valor, Fuente, Rect2.Size, FormatoLT);

                if(Tamano1.Height > Tamano2.Height)
                {
                    Rect.Height = Tamano1.Height;
                    Rect2.Height = Tamano1.Height;
                }
                else
                {
                    Rect.Height = Tamano2.Height;
                    Rect2.Height = Tamano2.Height;
                }

                if(Valor.Length == 0)
                {
                    Valor = "-";
                }

                if(Nombre == "-" && Valor == "-")
                {
                    iTop += System.Convert.ToInt32(Rect.Height + 4);
                    // No imprimo nada
                }
                else
                {
                    ev.Graphics.DrawString(Nombre, FuenteNombre, Brushes.Black, Rect, FormatoLT);
                    ev.Graphics.DrawString(Valor, Fuente, Brushes.Black, Rect2, FormatoLT);
                    iTop += System.Convert.ToInt32(Rect.Height + 4);
                    ev.Graphics.DrawLine(Pens.Silver, Rect.X, iTop, Rect.X + Rect.Width + Rect2.Width + 8, iTop);
                }

                iTop += 8;
            }
        }
    }
}
