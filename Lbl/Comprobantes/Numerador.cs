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

namespace Lbl.Comprobantes
{
	public class Numerador
	{
                public static int ProximoNumero(Lbl.Comprobantes.Comprobante comprobante)
                {
                        string TipoReal = "";

                        // Las notas de crédito y débito comparten la numeración de las comprob
                        switch (comprobante.Tipo.Nomenclatura) {
                                case "A":
                                case "FA":
                                case "NCA":
                                case "NDA":
                                        TipoReal = "'FA', 'NCA', 'NDA'";
                                        break;

                                case "B":
                                case "FB":
                                case "NCB":
                                case "NDB":
                                        TipoReal = "'FB', 'NCB', 'NDB'";
                                        break;

                                case "C":
                                case "FC":
                                case "NCC":
                                case "NDC":
                                        TipoReal = "'FC', 'NCC', 'NDC'";
                                        break;

                                case "E":
                                case "FE":
                                case "NCE":
                                case "NDE":
                                        TipoReal = "'FE', 'NCE', 'NDE'";
                                        break;

                                case "M":
                                case "FM":
                                case "NCM":
                                case "NDM":
                                        TipoReal = "'FM', 'NCM', 'NDM'";
                                        break;

                                default:
                                        TipoReal = "'" + comprobante.Tipo.Nomenclatura + "'";
                                        break;
                        }

                        string SqlWhere = "pv=" + comprobante.PV.ToString() + " AND tipo_fac IN (" + TipoReal + ")";
                        if (comprobante is Lbl.Comprobantes.ComprobanteConArticulos) {
                                // Si es comprobante con artículos, agrego una condicion más para los comprobantes de compra
                                SqlWhere += " AND compra=" + (((Lbl.Comprobantes.ComprobanteConArticulos)(comprobante)).Compra ? "1" : "0");
                        }

                        return comprobante.Connection.FieldInt("SELECT MAX(numero) FROM " + comprobante.TablaDatos + " WHERE " + SqlWhere) + 1;
                }
	}
}
