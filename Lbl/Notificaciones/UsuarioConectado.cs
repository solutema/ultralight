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

namespace Lbl.Notificaciones
{
        public class UsuarioConectado
        {
                public int Id { get; set; }

                public Lbl.Personas.Persona Persona { get; set; }
                public string Estacion { get; set; }
                public string Nombre { get; set; }
                public DateTime Fecha { get; set; }

                public int Estado { get; set; }

                public UsuarioConectado(Lfx.Data.Row fromRow)
                {
                        this.FromRow(fromRow);
                }


                protected void FromRow(Lfx.Data.Row fromRow)
                {
                        this.Id = System.Convert.ToInt32(fromRow["id_mensajeria"]);

                        int IdUsuario = System.Convert.ToInt32(fromRow["id_usuario"]);
                        if (IdUsuario != 0)
                                this.Persona = new Personas.Persona(Lfx.Workspace.Master.MasterConnection, IdUsuario);

                        this.Nombre = fromRow["nombre"].ToString();
                        this.Estacion = fromRow["estacion"].ToString();
                        this.Estado = System.Convert.ToInt32(fromRow["estado"]);
                }
        }
}
