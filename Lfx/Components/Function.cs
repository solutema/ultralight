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

namespace Lfx.Components
{
	/// <summary>
	/// Esqueleto del componente.
	/// </summary>
	public class Function
	{
                protected Lfx.Workspace m_Workspace;
		public string ExecutableName = null;
		public string[] CommandLineArgs = null;
                public Lfx.Components.FunctionTypes FunctionType = FunctionTypes.MdiChildren;
                public Type TipoRegistrado = null, Impresor = null, ControlEdicion = null, FormularioListado = null;

		public Function()
		{
		}

		public Lfx.Workspace Workspace
		{
			get
			{
				return m_Workspace;
			}
			set
			{
				m_Workspace = value;
			}
		}

		public virtual object Create(bool wait)
		{
			return null;
		}

		public virtual object Create()
		{
			return Create(false);
		}

		public virtual Lfx.Types.OperationResult Try()
		{
			return new Types.SuccessOperationResult();
		}

                /* public virtual Type FormularioListado()
                {
                        return null;
                }

                public virtual Type ControlEdicion()
                {
                        return null;
                } */
	}
}
