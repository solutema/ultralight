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
using System.Text;

namespace Lfx.Config
{
        public static class Display
        {
                public static Templates.Template CurrentTemplate = new Lfx.Config.Templates.Default();

                // Microsoft Sans Serif, Segoe UI, Bitstream Vera Sans
                public static string DefaultFontName = "Bitstream Vera Sans";
                public static string DefaultPrintFontName = "Bitstream Vera Sans";
                public static string DefaultMonoFontName = "Bitstream Vera Sans Mono";
                public static System.Drawing.Font DefaultFont = new System.Drawing.Font(DefaultFontName, 9.75F);
                public static System.Drawing.Font MenuFont = new System.Drawing.Font(DefaultFontName, 9.75F);
                public static System.Drawing.Font SmallFont = new System.Drawing.Font(DefaultFontName, 8F);
                public static System.Drawing.Font SmallerFont = new System.Drawing.Font(DefaultFontName, 6.75F);
                public static System.Drawing.Font BigFont = new System.Drawing.Font(DefaultFontName, 12F);
                public static System.Drawing.Font BiggerFont = new System.Drawing.Font(DefaultFontName, 14F);
                public static System.Drawing.Font TitleFont = new System.Drawing.Font(DefaultFontName, 10.5F, System.Drawing.FontStyle.Bold);
                public static System.Drawing.Font HeaderFont = new System.Drawing.Font(DefaultFontName, 16F, System.Drawing.FontStyle.Bold);
                public static System.Drawing.Font Header2Font = new System.Drawing.Font(DefaultFontName, 10F, System.Drawing.FontStyle.Bold);
                public static System.Drawing.Font MonospacedFont = new System.Drawing.Font(DefaultMonoFontName, 10F);

        }
}
