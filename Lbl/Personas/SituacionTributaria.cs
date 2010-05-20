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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lbl.Personas
{
	public class SituacionTributaria : ElementoDeDatos
	{
		public SituacionTributaria(Lws.Data.DataView dataView) : base(dataView) { }

		public SituacionTributaria(Lws.Data.DataView dataView, int idSituacion)
			: this(dataView)
		{
			m_ItemId = idSituacion;
		}

		public override string TablaDatos
		{
			get
			{
				return "situaciones";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_situacion";
			}
		}

                public string LetraPredeterminada()
                {
                        if (Workspace.CurrentConfig.Company.SituacionTributaria == 2) {
                                //Si soy responsable inscripto, facturo según la siguiente tabla
                                switch (this.Id) {
                                        case 2:
                                        case 3:
                                                return "A";
                                        default:
                                                return "B";
                                }
                        } else {
                                //De lo contrario, C para todo el mundo
                                return "C";
                        }
                }
	}
}
