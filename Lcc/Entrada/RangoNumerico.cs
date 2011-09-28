#region License
// Copyright 2004-2011 Ernesto N. Carrea
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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Entrada
{
        public partial class RangoNumerico : Lui.Forms.Control
        {
                public decimal Min { get; set; }
                public decimal Max { get; set; }


                public RangoNumerico()
                {
                        InitializeComponent();
                }


                public int DecimalPlaces
                {
                        get
                        {
                                return EntradaValor1.DecimalPlaces;
                        }
                        set
                        {
                                EntradaValor1.DecimalPlaces = value;
                                EntradaValor2.DecimalPlaces = value;
                                if (value == 0) {
                                        EntradaValor1.DataType = Lui.Forms.DataTypes.Integer;
                                        EntradaValor2.DataType = Lui.Forms.DataTypes.Integer;
                                } else {
                                        EntradaValor1.DataType = Lui.Forms.DataTypes.Float;
                                        EntradaValor2.DataType = Lui.Forms.DataTypes.Float;
                                }
                        }
                }


                public decimal Valule1
                {
                        get
                        {
                                return EntradaValor1.ValueDecimal;
                        }
                        set
                        {
                                EntradaValor1.ValueDecimal = value;
                        }
                }


                public decimal Valule2
                {
                        get
                        {
                                return EntradaValor2.ValueDecimal;
                        }
                        set
                        {
                                EntradaValor2.ValueDecimal = value;
                        }
                }
        }
}
