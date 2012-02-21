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
using System.ComponentModel;
using System.Text;

namespace Lcc.Entrada
{
        public partial class Telefono : ControlEntrada
        {
                public Telefono()
                {
                        InitializeComponent();

                        EntradaNombre.AutoCompleteStringCollection = new System.Windows.Forms.AutoCompleteStringCollection() {
                                "Trabajo", "Casa", "Móvil", "Fax", "Celular"
                        };
                }

                public override string Text
                {
                        get
                        {
                                string Res = "";

                                if (EntradaNumero.Text.Length > 0) {

                                        if (EntradaNombre.Text.Length > 0)
                                                Res = EntradaNombre.Text + ": ";

                                        if (EntradaCaracteristica.Text.Length > 0)
                                                Res += "(" + EntradaCaracteristica.Text + ") ";

                                        Res += EntradaNumero.Text;
                                }

                                return Res.Trim();
                        }
                        set
                        {
                                if (value == null) {
                                        EntradaNombre.Text = "";
                                        EntradaCaracteristica.Text = "";
                                        EntradaNumero.Text = "";
                                } else {
                                        string[] NombreNumero = value.Split(new char[] { ':' }, 2, StringSplitOptions.RemoveEmptyEntries);
                                        
                                        // No hay nombre, sólo numero
                                        if (NombreNumero.Length < 2)
                                                NombreNumero = new string[] { "", value };

                                        EntradaNombre.Text = NombreNumero[0].Trim();

                                        string Numero = NombreNumero[1].Trim();

                                        string[] CaractNumero = Numero.Split(new char[] { ')' }, 2, StringSplitOptions.RemoveEmptyEntries);

                                        if (CaractNumero.Length < 2)
                                                // No hay característica, sólo numero
                                                CaractNumero = new string[] { "", Numero };
                                        else if (CaractNumero[0].Length >= 1 && CaractNumero[0][0] == '(')
                                                // Hay característica, quito el paréntesis que quedó del split de arriba
                                                CaractNumero[0] = CaractNumero[0].Substring(1, CaractNumero[0].Length - 1);

                                        EntradaCaracteristica.Text = CaractNumero[0].Trim();
                                        EntradaNumero.Text = CaractNumero[1].Trim();
                                }
                        }
                }

                private void Entradas_TextChanged(object sender, EventArgs e)
                {
                        this.OnTextChanged(EventArgs.Empty);
                }
        }
}
