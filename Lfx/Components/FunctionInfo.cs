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

namespace Lfx.Components
{
        public class FunctionInfo
        {
                public IComponent ComponentInfo;
                public string Nombre;
                public bool AutoRun = false;
                public Lfx.Components.Function Instancia = null;
                public bool Ready = false;

                public FunctionInfo(IComponent compInfo)
                {
                        this.ComponentInfo = compInfo;
                }

                public void Load()
                {
                        if (this.Instancia == null)
                                this.Instancia = (Lfx.Components.Function)this.ComponentInfo.Assembly.CreateInstance(this.ComponentInfo.EspacioNombres + "." + this.Nombre);

                        if (Instancia != null) {
                                this.Instancia.Workspace = Lfx.Workspace.Master;
                                Lfx.Types.OperationResult Res = this.Instancia.Try();
                                if (Res.Success) {
                                        this.Ready = true;
                                        //this.TipoRegistrado = this.Instancia.RegisteredType;
                                } else {
                                        this.Ready = false;
                                }
                        } else {
                                this.Ready = false;
                        }
                }

                public object Run()
                {
                        if (this.Instancia == null)
                                this.Load();

                        if (this.Instancia == null)
                                return null;
                        else
                                return this.Instancia.Run();
                }

                public override string ToString()
                {
                        if (this.Instancia == null)
                                return this.Nombre;
                        else
                                return Instancia.ToString();
                }
        }
}
