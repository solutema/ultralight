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
using System.ComponentModel;

namespace Lfx.Types
{
        public delegate void ShowProgressDelegate(Lfx.Types.OperationProgress progreso);

        /// <summary>
        /// Describe el progreso de una operación.
        /// </summary>
        public class OperationProgress
        {

                public string Name { get; set; }

                public string Status { get; set; }

                public string Description { get; set; }

                public string EndMessage { get; set; }

                public int Value { get; set; }

                public int Max { get; set; }

                public bool Blocking { get; set; }

                public bool IsRunning { get; set; }

                public bool IsDone { get; set; }

                public bool Advertise { get; set; }

                public OperationProgress(string name, string description)
                {
                        this.Blocking = true;
                        this.Max = 100;
                        this.Advertise = true;
                        this.Name = name;
                        this.Description = description;
                        this.Advertise = true;
                }

                public void Begin()
                {
                        this.IsDone = false;
                        this.IsRunning = true;
                        this.Value = 0;
                        this.Status = "Iniciando...";
                        if (Lfx.Workspace.Master != null)
                                Lfx.Workspace.Master.RunTime.NotifyProgress(this);
                        Console.WriteLine("Inicio: " + this.Name);
                }

                public void Begin(int maxValue)
                {
                        this.Max = maxValue;
                        this.Begin();
                }

                public void ChangeStatus(int newValue, string newStatus)
                {
                        this.Value = newValue;
                        this.ChangeStatus(newStatus);
                }

                public void ChangeStatus(int newValue)
                {
                        this.Value = newValue;
                        if (Lfx.Workspace.Master != null)
                                Lfx.Workspace.Master.RunTime.NotifyProgress(this);
                }

                public void ChangeStatus(string newStatus)
                {
                        this.Status = newStatus;
                        Console.WriteLine(newStatus);
                        if (Lfx.Workspace.Master != null)
                                Lfx.Workspace.Master.RunTime.NotifyProgress(this);
                }

                public void Advance(int newValue)
                {
                        this.Value += newValue;
                        if (Lfx.Workspace.Master != null)
                                Lfx.Workspace.Master.RunTime.NotifyProgress(this);
                }

                public void End(string message)
                {
                        this.EndMessage = message;
                        this.End();
                }

                public void End()
                {
                        Console.WriteLine("Fin: " + this.Name);
                        this.IsDone = true;
                        this.IsRunning = false;
                        this.Status = "Terminado.";
                        if (Lfx.Workspace.Master != null)
                                Lfx.Workspace.Master.RunTime.NotifyProgress(this);
                }


                public int PercentDone
                {
                        get
                        {
                                if (this.Value > this.Max)
                                        return 100;

                                if (this.Max <= 0)
                                        return 0;

                                return System.Convert.ToInt32(System.Convert.ToDouble(this.Value) / System.Convert.ToDouble(this.Max) * 100d);
                        }
                }
        }
}
