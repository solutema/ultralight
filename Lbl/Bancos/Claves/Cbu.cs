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

namespace Lbl.Bancos.Claves
{
        /// <summary>
        /// Clave Bancaria Uniforme (Argentina)
        /// http://www.clientebancario.gov.ar/default.asp
        /// </summary>
        public class Cbu : IdentificadorUnico
        {
                public override string Nombre
                {
                        get
                        {
                                return "CBU";
                        }
                }


                public static bool EsValido(string cbu)
                {
                        string MiCopia = cbu.Replace("-", "").Replace(" ", "").Replace(".", "").Replace("/", "");
                        if (MiCopia.Length != 22)
                                return false;

                        int[] Ponderador = { 3, 9, 7, 1 };
                        int Verificador;

                        Verificador = 0;
                        string Bloque1 = MiCopia.Substring(0, 8);
                        for (int i = 0; i < 7; i++) {
                                Verificador += Lfx.Types.Parsing.ParseInt(Bloque1.Substring(i, 1)) * Ponderador[i % 4];
                        }
                        Verificador = (Verificador % 10) % 10;
                        if (Lfx.Types.Parsing.ParseInt(Bloque1.Substring(7, 1)) != Verificador)
                                return false;

                        Verificador = 0;
                        string Bloque2 = MiCopia.Substring(8, 14);
                        for (int i = 0; i < 13; i++) {
                                Verificador += Lfx.Types.Parsing.ParseInt(Bloque2.Substring(i, 1)) * Ponderador[i % 4];
                        }
                        Verificador = (10 - (Verificador % 10)) % 10;
                        if (Lfx.Types.Parsing.ParseInt(Bloque2.Substring(13, 1)) != Verificador)
                                return false;

                        return true;
                }

                public override bool EsValido()
                {
                        return Lbl.Bancos.Claves.Cbu.EsValido(this.Valor);
                }
        }
}
