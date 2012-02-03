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
using System.Drawing;

namespace Lazaro.Pres.DisplayStyles
{
        public class Template
        {
                public static Template Current = new Template();

                public IDisplayStyle Default = new OldStyle();
                public IDisplayStyle EditForm = new OldStyle();

                public IDisplayStyle Generica = new Brown();
                public IDisplayStyle Articulos = new Articulos();
                public IDisplayStyle Comprobantes = new Comprobantes();
                public IDisplayStyle Personas = new Personas();
                public IDisplayStyle Cajas = new DarkColors();

                // Microsoft Sans Serif, Segoe UI, Bitstream Vera Sans
                public string DefaultFontName { get; set; }
                public string DefaultPrintFontName { get; set; }
                public string DefaultMonoFontName { get; set; }
                public System.Drawing.Font DefaultFont { get; set; }
                public System.Drawing.Font MenuFont { get; set; }
                public System.Drawing.Font SmallFont { get; set; }
                public System.Drawing.Font SmallerFont { get; set; }
                public System.Drawing.Font BigFont { get; set; }
                public System.Drawing.Font BiggerFont { get; set; }
                public System.Drawing.Font MainHeaderFont { get; set; }
                public System.Drawing.Font GroupHeaderFont { get; set; }
                public System.Drawing.Font GroupHeader2Font { get; set; }
                public System.Drawing.Font MonospacedFont { get; set; }

                public Color RedColor = Color.Firebrick;
                public Color BlueColor = Color.SteelBlue;
                public Color GreenColor = Color.SeaGreen;
                public Color OrangeColor = Color.DarkOrange;

                public Template()
                {
                        bool TengoSegoe = false;
                        if (System.Drawing.SystemFonts.MessageBoxFont.Name == "Segoe UI") {
                                TengoSegoe = true;
                        }

                        // Microsoft Sans Serif, Segoe UI, Bitstream Vera Sans
                        if (TengoSegoe) {
                                DefaultFontName = "Segoe UI";
                        } else {
                                DefaultFontName = "Bitstream Vera Sans";
                        }
                        DefaultPrintFontName = "Bitstream Vera Sans";
                        DefaultMonoFontName = "Bitstream Vera Sans Mono";
                        
                        DefaultFont = new System.Drawing.Font(DefaultFontName, 9.75F);
                        MenuFont = new System.Drawing.Font(DefaultFontName, 9.75F);
                        SmallFont = new System.Drawing.Font(DefaultFontName, 8F);
                        SmallerFont = new System.Drawing.Font(DefaultFontName, 6.75F);
                        BigFont = new System.Drawing.Font(DefaultFontName, 12F);
                        BiggerFont = new System.Drawing.Font(DefaultFontName, 14F);
                        MainHeaderFont = new System.Drawing.Font(DefaultFontName, 16F);
                        GroupHeaderFont = new System.Drawing.Font(DefaultFontName, 13F);
                        GroupHeader2Font = new System.Drawing.Font(DefaultFontName, 11F);
                        MonospacedFont = new System.Drawing.Font(DefaultMonoFontName, 10F);
                }
        }
}
