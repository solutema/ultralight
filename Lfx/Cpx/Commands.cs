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

namespace Lfx.Cpx
{
        public class Command
        {
                public Printer Printer = null;

                public override string ToString()
                {
                        throw new NotImplementedException();
                }
        }

        public class EmbossCommand : Command
        {

        }

        public class EncodeCommand : Command
        {

        }

        public class MessageCommand : Command
        {

        }

        public class ChangeFontCommand : Command
        {

        }

        public class RejectCardCommand : Command
        {

        }

        public class LineLocationDatacommand : Command
        {
                
        }

        /// <summary>
        /// Matches the data on the magnetic stripe before writing.
        /// </summary>
        public class DataMatchCompareCommand : Command
        {
                public string MatchData;

                public DataMatchCompareCommand(string matchData)
                {
                        this.MatchData = matchData;
                }

                public override string ToString()
                {
                        return "#CMP#" + this.MatchData;
                }
        }

        public class ReadMagneticsStripeCommand : Command
        {
                public override string ToString()
                {
                        return "#DCC##TRK##END#@@@@@@";
                }
        }

        public class CpxVersionCommand : Command
        {
                public override string ToString()
                {
                        return "#DCC##VER##END#@";
                }
        }

        public class ErrorStatusCommand : Command
        {
                public override string ToString()
                {
                        return "#DCC##ERR##END#@";
                }
        }

        public class EnquiryCommand : Command
        {
                public override string ToString()
                {
                        return ((char)(0x05)).ToString();
                }
        }

        /// <summary>
        /// 150i CPX Protocol/Setup Manual, 2-14 en adelante
        /// </summary>
        public class EmbossAndEncodeCommand1 : Command
        {
                public EmbossAndEncodeCommand1()
                {
                }

                public override string ToString()
                {
                        string LineLocationsBlock = @"#DCL##GTW#0""
0004,0002,0401,0843,0000,0000,0000,0000,0000,""
0004,0001,0600,0489,0000,0000,0000,0000,0000,""
0004,0001,0250,0332,0000,0000,0000,0000,0000,""
0004,0003,2353,1250,0000,0000,0000,0000,0000,""
#END#@@@@@@";
                        //0005,0002,0000,0000,0000,0000,0000,0000,0000,""
                        return LineLocationsBlock;
                }
        }

        /// <summary>
        /// 150i CPX Protocol/Setup Manual, 2-14 en adelante
        /// </summary>
        public class EmbossAndEncodeCommand2 : Command
        {
                public string CardNumber, ExpDate, CardOwner, Track2;
                public int Cvc;

                public EmbossAndEncodeCommand2(string cardNumber, string expDate, string cardOwner, int cvc, string track2)
                {
                        this.CardNumber = cardNumber;
                        this.ExpDate = expDate;
                        this.CardOwner = cardOwner;
                        this.Track2 = track2;
                        this.Cvc = cvc;
                }

                public override string ToString()
                {
                        if (this.CardOwner.Length > 23)
                                this.CardOwner = this.CardOwner.Substring(0, 23);

                        string DataBlock = @"#DCC##CMP#;" + Track2 + @"?#GRD#0""
" + CardNumber + @"""
" + ExpDate + @"""
" + CardOwner + @"""
" + CardNumber.Substring(CardNumber.Length - 4, 4) + " " + Cvc.ToString() + @"""
#END#@@@@@@";
                        //;" + Track2 + @"?""
                        return DataBlock;
                }
        }
}
