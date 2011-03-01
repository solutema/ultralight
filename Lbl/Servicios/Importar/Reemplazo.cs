#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lbl.Servicios.Importar
{
        public class Reemplazo
        {
                public object Buscar, ReemplazarCon;
                public bool MatchSubString = false;
                public string NombreCampo = null;
                public Lfx.Data.DbTypes Tipo = Lfx.Data.DbTypes.VarChar;

                public Reemplazo(object buscar, object reemplazarCon)
                {
                        this.Buscar = buscar;
                        this.ReemplazarCon = reemplazarCon;

                        if(buscar is int)
                                this.Tipo = Lfx.Data.DbTypes.Integer;
                        else if (buscar is double || buscar is decimal)
                                this.Tipo = Lfx.Data.DbTypes.Numeric;
                        else if (buscar is DateTime)
                                this.Tipo = Lfx.Data.DbTypes.DateTime;
                }

                public Reemplazo(object buscar, object reemplazarCon, string nombreCampo)
                        : this(buscar, reemplazarCon)
                {
                        this.NombreCampo = nombreCampo;
                }

                public object Reemplazar(object value)
                {
                        if (this.MatchSubString == false) {
                                // Reemplazo de valores completos
                                if (Lfx.Types.Object.CompareByValue(value, this.Buscar) == 0)
                                        return this.ReemplazarCon;
                                else
                                        return value;
                        } else {
                                // Reemplazo de subcadenas
                                return ((string)value).Replace(((string)(this.Buscar)), ((string)(this.ReemplazarCon)));
                        }
                }
        }

        public class ReemplazoSubCadenas : Reemplazo
        {
                public ReemplazoSubCadenas(string buscar, string reemplazarCon)
                        : base(buscar, reemplazarCon)
                {
                        this.MatchSubString = true;
                }
        }
}
