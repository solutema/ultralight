#region License
// Copyright 2004-2010 South Bridge S.R.L.
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

namespace Lbl.Comprobantes.Impresion.Fiscal
{
        public class Comando
        {
                public CodigosComandosFiscales CodigoComando;
                public int Secuencia;
                public string[] Campos;
                private System.Text.Encoding DefaultEncoding = System.Text.Encoding.GetEncoding(1252);

                public Comando(CodigosComandosFiscales codigoComando, params string[] campos)
                {
                        CodigoComando = codigoComando;
                        Campos = campos;
                }

                public string ProtocoloBinario()
                {
                        System.Text.StringBuilder Comando = new System.Text.StringBuilder();
                        Comando.Append(CaracteresDeControl.PROTO_STX);      // STX Start of Frame

                        Comando.Append((char)Secuencia); // SN Sequence Number


                        byte[] cmd = new byte[1] { (byte)CodigoComando };
                        Comando.Append(DefaultEncoding.GetChars(cmd)); // Comando

                        if (Campos != null && Campos.Length > 0) {
                                // Params
                                foreach (string Param in Campos) {
                                        Comando.Append(CaracteresDeControl.PROTO_FS); // FS Field Separator
                                        Comando.Append(Param);
                                }
                        }

                        Comando.Append(CaracteresDeControl.PROTO_ETX);	// ETX End of Frame

                        //Calculo el BCC
                        long BCC = 0;
                        byte[] ComandoBytes = DefaultEncoding.GetBytes(Comando.ToString());
                        for (int n = 0; n < ComandoBytes.Length; n++) {
                                BCC += ComandoBytes[n];
                        }
                        Comando.Append(System.Convert.ToString(BCC, 16).ToUpper().PadLeft(4, '0'));

                        return Comando.ToString();
                }

                public override string ToString()
                {
                        string Res = "<Enviar" + System.Environment.NewLine;
                        Res += "  comando=" + this.CodigoComando.ToString() + System.Environment.NewLine;
                        Res += "  secuencia=" + this.Secuencia.ToString() + System.Environment.NewLine;
                        for (int i = 0; i < Campos.Length; i++) {
                                Res += "  campo_" + i.ToString() + "=" + this.Campos[i] + System.Environment.NewLine;
                        }
                        Res += "/>" + System.Environment.NewLine;
                        return Res;
                }
        }
}
