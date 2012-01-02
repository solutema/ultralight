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
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lfx.Config.Templates
{
        public class Template
        {
                public System.Drawing.Color WindowBackground = System.Drawing.SystemColors.Control;
                public System.Drawing.Color WindowText = System.Drawing.SystemColors.ControlText;
                public System.Drawing.Color ButtonBorder = System.Drawing.SystemColors.ControlDark;
                public System.Drawing.Color ButtonFace = System.Drawing.SystemColors.ControlLight;
                public System.Drawing.Color ButtonBackground = System.Drawing.SystemColors.ControlDark;
                public System.Drawing.Color ButtonText = System.Drawing.SystemColors.ControlText;
                public System.Drawing.Color ButtonSubBackground = System.Drawing.SystemColors.ControlLightLight;
                public System.Drawing.Color ButtonSubText = System.Drawing.SystemColors.ControlText;
                public System.Drawing.Color ControlBackground = System.Drawing.SystemColors.Control;
                public System.Drawing.Color ControlDataarea = System.Drawing.SystemColors.Window;
                public System.Drawing.Color ControlText = System.Drawing.SystemColors.ControlText;
                public System.Drawing.Color ControlGrayText = System.Drawing.SystemColors.GrayText;
                public System.Drawing.Color ControlBorder = System.Drawing.SystemColors.ControlDark;
                public System.Drawing.Color ControlDataareaActive = System.Drawing.SystemColors.Window;
                public System.Drawing.Color ControlDataareaError = System.Drawing.SystemColors.Info;
                public System.Drawing.Color Selection = System.Drawing.SystemColors.Highlight;
                public System.Drawing.Color SelectionError = System.Drawing.Color.BlueViolet;
                public System.Drawing.Color SelectionDisabled = System.Drawing.SystemColors.ControlDarkDark;
                public System.Drawing.Color SelectionText = System.Drawing.SystemColors.HighlightText;
                public System.Drawing.Color TitleBackground = System.Drawing.SystemColors.Control;
                public System.Drawing.Color TitleText = System.Drawing.Color.DarkCyan;
                public System.Drawing.Color HeaderBackground = System.Drawing.SystemColors.ActiveCaption;
                public System.Drawing.Color HeaderText = System.Drawing.SystemColors.ActiveCaptionText;
                public System.Drawing.Color Header2Background = System.Drawing.SystemColors.ActiveCaption;
                public System.Drawing.Color Header2Text = System.Drawing.SystemColors.ActiveCaptionText;
                public System.Drawing.Color FooterBackground = System.Drawing.SystemColors.AppWorkspace;
                public System.Drawing.Color ToolBarBackground = System.Drawing.SystemColors.Info;
                public System.Drawing.Color ToolBarText = System.Drawing.SystemColors.InfoText;

                public Template()
                {
                        WindowBackground = System.Drawing.SystemColors.Control;
                        WindowText = System.Drawing.SystemColors.ControlText;
                        ButtonBorder = System.Drawing.SystemColors.ControlDark;
                        ButtonFace = CambiarBrillo(System.Drawing.SystemColors.Control, -10);
                        ButtonBackground = System.Drawing.SystemColors.ControlDark;
                        ButtonText = System.Drawing.SystemColors.ControlText;
                        ButtonSubBackground = CambiarBrillo(System.Drawing.SystemColors.Control, -20);
                        ButtonSubText = System.Drawing.SystemColors.ControlText;
                        ControlBackground = System.Drawing.SystemColors.Control;
                        ControlDataarea = System.Drawing.SystemColors.Window;
                        ControlText = System.Drawing.SystemColors.ControlText;
                        ControlGrayText = System.Drawing.SystemColors.GrayText;
                        ControlBorder = System.Drawing.SystemColors.ControlDark;
                        ControlDataareaActive = System.Drawing.SystemColors.Window;
                        ControlDataareaError = System.Drawing.SystemColors.Info;
                        Selection = System.Drawing.SystemColors.Highlight;
                        SelectionError = System.Drawing.Color.BlueViolet;
                        SelectionDisabled = System.Drawing.SystemColors.ControlDarkDark;
                        SelectionText = System.Drawing.SystemColors.HighlightText;
                        TitleBackground = this.WindowBackground;
                        TitleText = System.Drawing.Color.DarkCyan;
                        HeaderBackground = System.Drawing.SystemColors.ActiveCaption;
                        HeaderText = System.Drawing.SystemColors.ActiveCaptionText;
                        Header2Background = CambiarBrillo(System.Drawing.SystemColors.ActiveCaption, 20);
                        Header2Text = CambiarBrillo(System.Drawing.SystemColors.ActiveCaptionText, 20);
                        FooterBackground = System.Drawing.SystemColors.AppWorkspace;
                        ToolBarBackground = System.Drawing.SystemColors.Info;
                        ToolBarText = System.Drawing.SystemColors.InfoText;
                }

                // Función: PaletaCambiarBrillo
                // Parámetros:
                //    Color   El color que se desea cambiar
                //    Brillo  Un valor porcentual de birllo positivo (aumentar) o negativo (disminuir)
                // Descripción:
                //    Sube o baja el brillo de un color, segn un porcentaje (de -100 a 100)
                public static System.Drawing.Color CambiarBrillo(System.Drawing.Color colorOrigen, int Brillo)
                {
                        int rgb = colorOrigen.ToArgb();
                        int r = (rgb & 0XFF0000) / 0XFF00;
                        int g = (rgb & 0XFF00) / 0XFF;
                        int b = rgb & 0XFF;
                        r = r * 1 + (Brillo / 100);
                        g = g * 1 + (Brillo / 100);
                        b = b * 1 + (Brillo / 100);

                        if (r > 255)
                                r = 255;

                        if (g > 255)
                                g = 255;

                        if (b > 255)
                                b = 255;

                        if (r < 0)
                                r = 0;

                        if (g < 0)
                                g = 0;

                        if (b < 0)
                                b = 0;

                        return System.Drawing.Color.FromArgb(r, g, b);
                }
        }

        public class Default : Template
        {
                public Default()
                {
                        this.WindowBackground = System.Drawing.Color.FromArgb(236, 234, 229);

                        this.WindowText = System.Drawing.Color.Black;
                        this.ButtonFace = CambiarBrillo(this.WindowBackground, 5);
                        this.ButtonBackground = System.Drawing.Color.FromArgb(250, 250, 250);
                        this.ButtonBorder = System.Drawing.Color.FromArgb(83, 113, 149);
                        this.ButtonText = System.Drawing.Color.FromArgb(7, 2, 25);
                        this.ButtonSubBackground = System.Drawing.Color.FromArgb(225, 225, 225);
                        this.ButtonSubText = System.Drawing.Color.FromArgb(12, 69, 136);
                        this.ControlBackground = System.Drawing.Color.FromArgb(238, 238, 238);
                        this.ControlDataarea = System.Drawing.Color.FromArgb(250, 250, 250);
                        this.ControlText = System.Drawing.Color.FromArgb(7, 2, 25);
                        this.ControlGrayText = System.Drawing.SystemColors.GrayText;
                        this.ControlBorder = System.Drawing.Color.FromArgb(193, 200, 219);
                        this.ControlDataareaActive = System.Drawing.Color.FromArgb(238, 241, 250);
                        this.ControlDataareaError = System.Drawing.Color.FromArgb(254, 245, 12);
                        this.Selection = System.Drawing.Color.FromArgb(228, 109, 10);
                        this.SelectionError = System.Drawing.Color.BlueViolet;
                        this.SelectionDisabled = System.Drawing.Color.DarkGray;
                        this.SelectionText = System.Drawing.Color.White;
                        this.TitleBackground = this.WindowBackground;
                        this.TitleText = System.Drawing.Color.FromArgb(40, 68, 98);
                        this.HeaderBackground = System.Drawing.Color.FromArgb(214, 202, 174);
                        this.HeaderText = this.ControlText;             // System.Drawing.Color.White;
                        this.Header2Background = System.Drawing.Color.FromArgb(200, 206, 220);
                        this.Header2Text = System.Drawing.Color.FromArgb(27, 68, 115);
                        this.FooterBackground = System.Drawing.Color.FromArgb(207, 205, 187);
                        this.ToolBarBackground = System.Drawing.Color.FromArgb(190, 196, 209);
                        this.ToolBarText = System.Drawing.Color.FromArgb(71, 76, 101);
                }
        }
}
