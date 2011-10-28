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

namespace Lfx.Backups
{
        public class BackupReader
        {
                System.IO.Stream inputStream;
                public BackupReader(string path)
                {
                        System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        int FirstPos = fs.ReadByte();
                        inputStream = fs;
                        inputStream.Seek(0, System.IO.SeekOrigin.Begin);
                }

                public string ReadString(int length)
                {
                        byte[] Res = new byte[length];
                        inputStream.Read(Res, 0, length);
                        return System.Text.Encoding.UTF8.GetString(Res);
                }

                public string ReadPrefixedString4()
                {
                        int Len = int.Parse(this.ReadString(4));
                        return this.ReadString(Len);
                }

                public object ReadField()
                {
                        string Type = this.ReadString(1);
                        string StrLen = this.ReadString(8);
                        int Len = int.Parse(StrLen);
                        switch (Type) {
                                case "I":
                                        return int.Parse(this.ReadString(Len));
                                case "N":
                                        return Lfx.Types.Parsing.ParseDecimal(this.ReadString(Len));
                                case "D":
                                        string FldVal = this.ReadString(Len);
                                        return DateTime.ParseExact(FldVal, Lfx.Types.Formatting.DateTime.SqlDateTimeFormat, null);
                                case "B":
                                        byte[] Res = new byte[Len];
                                        inputStream.Read(Res, 0, Len);
                                        return Res;
                                case "U":
                                        return null;
                                default:
                                        return this.ReadString(Len);

                        }
                }

                public void Close()
                {
                        inputStream.Close();
                }

                public long Length
                {
                        get
                        {
                                return inputStream.Length;
                        }
                }

                public long Position
                {
                        get
                        {
                                return inputStream.Position;
                        }
                }
        }
}
