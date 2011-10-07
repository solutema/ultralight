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

namespace Lfx
{
        /// <summary>
        /// Proporciona servicios de comunicación inter-proceso (entre el Lfx, la aplicación principal y los componentes)
        /// </summary>
        public class RunTimeServices
        {
                public class IpcEventArgs : System.EventArgs
                {
                        public enum EventTypes
                        {
                                Undefined,
                                Information,
                                Progress,
                                ActionRequest
                        }

                        public EventTypes EventType = EventTypes.Undefined;
                        public string Source;
                        public string Destination;
                        public string Verb;
                        public object[] Arguments;
                        public object ReturnValue;

                        public IpcEventArgs() { }
                        public IpcEventArgs(EventTypes eventType)
                        {
                                this.EventType = eventType;
                        }
                }

                public delegate void IpcEventHandler(object sender, ref IpcEventArgs e);
                public event IpcEventHandler IpcEvent;

                public object Execute(string verb)
                {
                        return this.Execute("lazaro", verb, null);
                }

                public object Execute(string verb, object[] arguments)
                {
                        return this.Execute("lazaro", verb, arguments);
                }

                public object Execute(string destination, string verb, object[] arguments)
                {
                        if (IpcEvent != null) {
                                IpcEventArgs e = new IpcEventArgs();
                                e.EventType = IpcEventArgs.EventTypes.ActionRequest;
                                e.Destination = destination;
                                e.Verb = verb;
                                e.Arguments = arguments;
                                this.IpcEvent(this, ref e);
                                return e.ReturnValue;
                        }
                        return null;
                }

                public void Info(string verb, string infoText)
                {
                        this.Info("lazaro", verb, new object[] { infoText });
                }


                public void Info(string verb, object[] arguments)
                {
                        this.Info("lazaro", verb, arguments);
                }

                public void Info(string destination, string verb, string infoText)
                {
                        this.Info(destination, verb, new object[] { infoText });
                }

                public void Info(string destination, string verb, object[] arguments)
                {
                        if (IpcEvent != null) {
                                IpcEventArgs e = new IpcEventArgs();
                                e.EventType = IpcEventArgs.EventTypes.Information;
                                e.Destination = destination;
                                e.Verb = verb;
                                e.Arguments = arguments;
                                this.IpcEvent(this, ref e);
                        }
                }

                public void NotifyProgress(Lfx.Types.OperationProgress progress)
                {
                        if (IpcEvent != null) {
                                IpcEventArgs e = new IpcEventArgs();
                                e.EventType = IpcEventArgs.EventTypes.Progress;
                                e.Destination = "lazaro";
                                e.Verb = "PROGRESS";
                                e.Arguments = new object[] { progress };
                                this.IpcEvent(this, ref e);
                        }
                }

                public void Message(string messageText)
                {
                        if (IpcEvent != null) {
                                IpcEventArgs e = new IpcEventArgs();
                                e.EventType = IpcEventArgs.EventTypes.Information;
                                e.Destination = "lazaro";
                                e.Verb = "MESSAGE";
                                e.Arguments = new object[] { messageText };
                                this.IpcEvent(this, ref e);
                        }
                }
        }
}
