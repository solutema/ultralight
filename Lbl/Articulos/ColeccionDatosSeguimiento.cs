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

namespace Lbl.Articulos
{
        public class ColeccionDatosSeguimiento : List<DatosSeguimiento>
        {
                public ColeccionDatosSeguimiento()
                {
                }

                public ColeccionDatosSeguimiento(string rep)
                {
                        this.FromString(rep);
                }


                public DatosSeguimiento this[string variacion]
                {
                        get
                        {
                                foreach (DatosSeguimiento Dat in this) {
                                        if (Dat.Variacion == variacion)
                                                return Dat;
                                }

                                return null;
                        }
                }


                public void AddWithValue(string variacion, decimal cantidad)
                {
                        this.Add(new DatosSeguimiento(variacion, cantidad));
                }


                public decimal CantidadTotal
                {
                        get
                        {
                                decimal Res = 0;

                                foreach (DatosSeguimiento Dat in this) {
                                        Res += Dat.Cantidad;
                                }

                                return Res;
                        }
                }

                public bool ContainsKey(string variacion)
                {
                        foreach (DatosSeguimiento Dat in this) {
                                if (Dat.Variacion == variacion)
                                        return true;
                        }

                        return false;
                }


                public bool CantidadesSiempreUno()
                {
                        foreach (DatosSeguimiento Dat in this) {
                                if (Dat.Cantidad != 1)
                                        return false;
                        }

                        return true;
                }


                public override string ToString()
                {
                        System.Text.StringBuilder Res = new System.Text.StringBuilder();
                        bool MuestroCantidades = !this.CantidadesSiempreUno();
                        foreach (DatosSeguimiento Dat in this) {
                                if (MuestroCantidades) {
                                        if(Dat.Cantidad != (int)(Dat.Cantidad))
                                                // Cantidad con decimales
                                                Res.Append(Dat.Variacion + ": " + Dat.Cantidad.ToString() + "; ");
                                        else
                                                // Cantidad entera
                                                Res.Append(Dat.Variacion + ": " + ((int)(Dat.Cantidad)).ToString() + "; ");
                                } else {
                                        Res.Append(Dat.Variacion + "; ");
                                }
                        }
                        return Res.ToString().Trim(new char[] { ';', ' ' });
                }


                public void FromString(string rep)
                {
                        this.Clear();
                        if (rep != null) {
                                string[] Lines = rep.Split(new char[] { ';', ',', Lfx.Types.ControlChars.Cr, Lfx.Types.ControlChars.Lf }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string Line in Lines) {
                                        if (Line.Length > 0) {
                                                string[] Parts = Line.Split(new char[] { ':' }, 2, StringSplitOptions.RemoveEmptyEntries);
                                                if (Parts.Length > 0 && Parts[0].Trim().Length > 0) {
                                                        // Si hay al menos 1 parte, y no está en blanco
                                                        if (Parts.Length == 1) {
                                                                // Una parte, cantidad = 1
                                                                this.AddWithValue(Parts[0].Trim(), 1);
                                                        } else if (Parts.Length > 1) {
                                                                // Dos partes, la segunda es la cantidad
                                                                this.AddWithValue(Parts[0].Trim(), Lfx.Types.Parsing.ParseDecimal(Parts[1]));
                                                        }
                                                }
                                        }
                                }
                        }
                }
        }
}
