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

namespace Lfx.Types
{
        /// <summary>
        /// Representa el resultado de una operación.
        /// </summary>
	public class OperationResult
	{
		public bool Success = false;
		public string Message = null;
                public bool Cancel = false;

		public OperationResult()
		{
		}

		public OperationResult(bool success)
		{
			this.Success = success;
		}

		public OperationResult(bool success, string message)
		{
			this.Success = success;
			this.Message = message;
		}

                public override string ToString()
                {
                        string Res = this.GetType().ToString();
                        if (this.Message != null)
                                Res += ": " + this.Message;

                        return Res;
                }
	}
        
        /// <summary>
        /// Representa el resultado exitoso de una operación.
        /// </summary>
	public class SuccessOperationResult : OperationResult
	{
		public SuccessOperationResult()
			: base(true)
		{
		}
	}

        /// <summary>
        /// Representa la cancelación de una operación, pero sin un error.
        /// </summary>
        public class CancelOperationResult : OperationResult
        {
                public CancelOperationResult()
                        : base(false)
                {
                        this.Cancel = true;
                }
        }

        /// <summary>
        /// Representa un error en una operación.
        /// </summary>
	public class FailureOperationResult : OperationResult
	{
		public FailureOperationResult(string message)
			: base (false, message)
		{
		}
	}

	public class NoAccessOperationResult : FailureOperationResult
	{
		public NoAccessOperationResult()
			:base ("No tiene permiso para realizar la operación solicitada")
		{
		}
	}
}