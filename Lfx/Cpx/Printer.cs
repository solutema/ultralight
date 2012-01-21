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
using System.Text;

namespace Lfx.Cpx
{
        public enum PrinterModels
        {
                Unknown,
                DataCard150i
        }

        public enum PriterStatusCodes
        {
                Ready,                  // A (Ack)
                WaitingForOperator,     // c
                CardComplete,           // C
                Busy,                   // NAK
                OtherError              // any other
        }

        public class Printer
        {
                private System.IO.Ports.SerialPort Impresora;
                private PrinterModels m_PrinterModel = PrinterModels.Unknown;

                public Printer(string portBame)
                {
                        Impresora = new System.IO.Ports.SerialPort(portBame);
                        Impresora.Encoding = System.Text.Encoding.ASCII;
                }

                public void SendCommands(CommandList commands)
                {
                        commands.Printer = this;
                        foreach (Command Cmd in commands) {
                                this.Send(Cmd.ToString());
                        }
                }

                public void SendCommand(Command command)
                {
                        command.Printer = this;
                        this.Send(command.ToString());
                }

                public void Open()
                {
                        Impresora.Open();
                        Impresora.DtrEnable = true;
                        Impresora.RtsEnable = true;
                        System.Threading.Thread.Sleep(100);
                }

                public void Close()
                {
                        Impresora.Close();
                }

                private void Send(string data)
                {
                        Impresora.Write(data);
                        System.Threading.Thread.Sleep(500);
                }

                public CommandResponse ReadResponse()
                {
                        System.Threading.Thread.Sleep(500);
                        DateTime Inicio = DateTime.Now;
                        while ((DateTime.Now - Inicio).TotalMilliseconds < 2000) {
                                string Res = Impresora.ReadExisting();
                                if (Res != null && Res.Length > 0)
                                        return new CommandResponse(Res);
                                System.Threading.Thread.Sleep(500);
                        }
                        return null;
                        
                        /* int ToRead = Impresora.BytesToRead;
                        DateTime Inicio = DateTime.Now;
                        while (ToRead == 0 && (DateTime.Now - Inicio).TotalMilliseconds < 5000) {
                                System.Threading.Thread.Sleep(100);
                        }
                        if (ToRead > 0) {
                                byte[] BytesRead = new byte[ToRead];
                                Impresora.Read(BytesRead, 0, ToRead);
                                CommandResponse Res = new CommandResponse(Impresora.Encoding.GetString(BytesRead));
                                return Res;
                        } else {
                                return null;
                        } */
                }

                public PrinterModels PrinterModel
                {
                        get
                        {
                                if (m_PrinterModel == PrinterModels.Unknown) {
                                        this.SendCommand(new CpxVersionCommand());
                                        CommandResponse Res = this.ReadResponse();
                                        if (Res != null && Res.PayLoad != null && Res.PayLoad.Length > 0) {
                                                switch (Res.PayLoad[0].Trim()) {
                                                        case "150i/CPX":
                                                        case "150i/CPX-DES":
                                                                m_PrinterModel = PrinterModels.DataCard150i;
                                                                break;
                                                }
                                        }
                                }
                                return m_PrinterModel;
                        }
                }

                public int ErrorStatus
                {
                        get
                        {
                                this.SendCommand(new ErrorStatusCommand());
                                CommandResponse Res = this.ReadResponse();
                                if (Res != null && Res.PayLoad != null && Res.PayLoad.Length > 0)
                                        return Lfx.Types.Parsing.ParseInt(Res.PayLoad[0]);
                                else
                                        return 0;
                        }
                }

                public PriterStatusCodes Status
                {
                        get
                        {
                                this.SendCommand(new EnquiryCommand());
                                CommandResponse Res = this.ReadResponse();
                                if (Res != null && Res.PayLoad != null && Res.PayLoad.Length > 0)
                                        switch (Res.PayLoad[0].Trim()) {
                                                case "A":
                                                        return PriterStatusCodes.Ready;
                                                case "C":
                                                        return PriterStatusCodes.CardComplete;
                                                case "NAK":
                                                case "\x15":
                                                        return PriterStatusCodes.Busy;
                                                case "b":
                                                        return PriterStatusCodes.WaitingForOperator;
                                                default:
                                                        return PriterStatusCodes.OtherError;
                                        }
                                else
                                        return PriterStatusCodes.OtherError;
                        }
                }
        }
}
