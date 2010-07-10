#region License
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
#endregion

using System;
using System.Collections;
using System.Drawing;

namespace Lfx.Printing
{
        public class TextPrint : System.Drawing.Printing.PrintDocument
        {
                private Font PrintFont;
                private string TextToPrint = "";

                public TextPrint(string Text)
                        : base()
                {
                        TextToPrint = Text;
                }

                public string Text
                {
                        get
                        {
                                return TextToPrint;
                        }
                        set
                        {
                                TextToPrint = value;
                        }
                }

                protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs ev)
                {
                        base.OnBeginPrint(ev);
                        if (PrintFont == null)
                                PrintFont = new Font("Courier New", 9);
                }

                public Font Font
                {
                        get
                        {
                                return PrintFont;
                        }
                        set
                        {
                                PrintFont = value;
                        }
                }

                private int OnPrintPage_CurrentChar;

                protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs ev)
                {
                        base.OnPrintPage(ev);
                        int PrintAreaHeight = 0, PrintAreaWidth = 0, MarginLeft = 0, MarginTop = 0;

                        PrintAreaHeight = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top - base.DefaultPageSettings.Margins.Bottom;
                        PrintAreaWidth = base.DefaultPageSettings.PaperSize.Width - base.DefaultPageSettings.Margins.Left - base.DefaultPageSettings.Margins.Right;
                        MarginLeft = base.DefaultPageSettings.Margins.Left; // X
                        MarginTop = base.DefaultPageSettings.Margins.Top;   // Y

                        if (base.DefaultPageSettings.Landscape) {
                                int TempInt = 0;
                                TempInt = PrintAreaHeight;
                                PrintAreaHeight = PrintAreaWidth;
                                PrintAreaWidth = TempInt;
                        }

                        RectangleF PrintingArea = new RectangleF(MarginLeft, MarginTop, PrintAreaWidth, PrintAreaHeight);
                        StringFormat objSF = new StringFormat(StringFormatFlags.LineLimit);
                        Int32 intLinesFilled = 0, intCharsFitted = 0;
                        string StrPageText = TextToPrint.Substring(OnPrintPage_CurrentChar, TextToPrint.Length - OnPrintPage_CurrentChar);
                        ev.Graphics.MeasureString(StrPageText, Font, new SizeF(PrintAreaWidth, PrintAreaHeight), objSF, out intCharsFitted, out intLinesFilled);
                        ev.Graphics.DrawString(StrPageText, Font, Brushes.Black, PrintingArea, objSF);
                        //  Increase current char count
                        OnPrintPage_CurrentChar += intCharsFitted;

                        if (OnPrintPage_CurrentChar < TextToPrint.Length) {
                                ev.HasMorePages = true;
                        } else {
                                ev.HasMorePages = false;
                                OnPrintPage_CurrentChar = 0;
                        }
                }
        }
}