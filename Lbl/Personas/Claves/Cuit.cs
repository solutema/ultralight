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

namespace Lbl.Personas.Claves
{
        /// <summary>
        /// Clave Única de Identificación Tributaria (Argentina)
        /// </summary>
        public class Cuit : IdentificadorUnico
        {
                public Cuit(string valor)
                {
                        string Res = valor;

                        Res = Res.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "").Replace("_", "");

                        if (Res.Length == 11)
                                this.Valor = Res.Substring(0, 2) + "-" + Res.Substring(2, 8) + "-" + Res.Substring(10, 1);
                        else
                                this.Valor = Res;
                }


                public override string Nombre
                {
                        get
                        {
                                return "CUIT";
                        }
                }


                public static bool EsValido(string valor)
                {
                        // Utiliza el digito verificador para determinar la validez de una CUIT
                        // Devuelve Verdadero si la CUIT es válida
                        // Espera la CUIT en formato XX-XXXXXXXX-X
                        if (System.Text.RegularExpressions.Regex.IsMatch(valor, @"^\d{2}-\d{8}-\d{1}$")
                                || System.Text.RegularExpressions.Regex.IsMatch(valor, @"^\d{11}$")) {
                                        string ValorPlano = valor.Replace("-", "");
                                int Suma = 0;
                                Suma += int.Parse(ValorPlano.Substring(0, 1)) * 5;
                                Suma += int.Parse(ValorPlano.Substring(1, 1)) * 4;
                                Suma += int.Parse(ValorPlano.Substring(2, 1)) * 3;
                                Suma += int.Parse(ValorPlano.Substring(3, 1)) * 2;
                                Suma += int.Parse(ValorPlano.Substring(4, 1)) * 7;
                                Suma += int.Parse(ValorPlano.Substring(5, 1)) * 6;
                                Suma += int.Parse(ValorPlano.Substring(6, 1)) * 5;
                                Suma += int.Parse(ValorPlano.Substring(7, 1)) * 4;
                                Suma += int.Parse(ValorPlano.Substring(8, 1)) * 3;
                                Suma += int.Parse(ValorPlano.Substring(9, 1)) * 2;
                                // El digito verificador es 11 menos el mdulo de la suma y 11
                                int Verificador = 11 - (Suma % 11);

                                switch (Verificador) {
                                        case 11:
                                                Verificador = 0;
                                                break;
                                        case 10:
                                                Verificador = 9;
                                                break;
                                }
                                return int.Parse(ValorPlano.Substring(10, 1)) == Verificador;
                        } else {
                                return false;
                        }
                }

                public override bool EsValido()
                {
                        return Lbl.Personas.Claves.Cuit.EsValido(this.Valor);
                }
        }
}
