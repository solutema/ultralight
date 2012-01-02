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
using System.Data;
using System.Text;

namespace Lazaro.Impresion
{
        public class Instanciador
        {
                public static ImpresorElemento InstanciarImpresor(Lbl.IElementoDeDatos elemento, IDbTransaction transaction)
                {
                        Type tipo = InferirImpresor(elemento.GetType());
                        System.Reflection.ConstructorInfo TConstr = tipo.GetConstructor(new Type[] { typeof(Lbl.ElementoDeDatos), typeof(IDbTransaction) });
                        return (ImpresorElemento)(TConstr.Invoke(new object[] { elemento, transaction }));
                }

                public static Type InferirImpresor(Type tipo)
                {
                        Type Res = Lfx.Components.Manager.RegisteredTypes.GetHandler(tipo, "print");

                        if (Res != null) {
                                return Res;
                        } else {
                                Res = InferirImpresor(tipo.ToString());

                                if (Res == typeof(Lazaro.Impresion.ImpresorElemento) && tipo.BaseType != null)
                                        // Intento buscar un impresora para la clase base
                                        Res = InferirImpresor(tipo.BaseType);
                        }
                        return Res;
                }

                private static Type InferirImpresor(string tipoOTabla)
                {
                        switch (tipoOTabla) {
                                case "Lbl.Comprobantes.Comprobante":
                                        return typeof(Impresion.Comprobantes.ImpresorComprobante);
                                case "Lbl.Comprobantes.Presupuesto":
                                        return typeof(Impresion.Comprobantes.ImpresorPresupuesto);
                                case "Lbl.Comprobantes.Recibo":
                                case "Lbl.Comprobantes.ReciboDeCobro":
                                case "Lbl.Comprobantes.ReciboDePago":
                                        return typeof(Impresion.Comprobantes.ImpresorRecibo);
                                case "Lbl.Comprobantes.ComprobanteConArticulo":
                                case "Lbl.Comprobantes.ComprobanteFacturable":
                                case "Lbl.Comprobantes.Factura":
                                case "Lbl.Comprobantes.NotaDeDebito":
                                case "Lbl.Comprobantes.NotaDeCredito":
                                case "Lbl.Comprobantes.Remito":
                                        return typeof(Impresion.Comprobantes.ImpresorComprobanteConArticulos);
                                default:
                                        return typeof(ImpresorElemento);
                        }
                }
        }
}
