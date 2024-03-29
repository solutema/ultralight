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

namespace Lbl.Sys.Permisos
{
        /// <summary>
        /// Describe un tipo de acceso que puede tener una persona.
        /// </summary>
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Objeto de Permiso")]
        [Lbl.Atributos.Datos(TablaDatos = "sys_permisos_objetos", CampoId = "id_objeto")]
        [Lbl.Atributos.Presentacion()]
        public class Objeto : ElementoDeDatos
        {
                //Heredar constructor
		public Objeto(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Objeto(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Objeto(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public string Tipo
                {
                        get
                        {
                                return this.GetFieldValue<string>("tipo");
                        }
                        set
                        {
                                this.SetFieldValue("tipo", value);
                        }
                }


                public string NombreExtra1
                {
                        get
                        {
                                return this.GetFieldValue<string>("extra1_nombre");
                        }
                        set
                        {
                                this.SetFieldValue("extra1_nombre", value);
                        }
                }

                public string NombreExtra2
                {
                        get
                        {
                                return this.GetFieldValue<string>("extra2_nombre");
                        }
                        set
                        {
                                this.SetFieldValue("extra2_nombre", value);
                        }
                }

                public string NombreExtra3
                {
                        get
                        {
                                return this.GetFieldValue<string>("extra3_nombre");
                        }
                        set
                        {
                                this.SetFieldValue("extra3_nombre", value);
                        }
                }

                public string NombreExtraA
                {
                        get
                        {
                                return this.GetFieldValue<string>("extraa_nombre");
                        }
                        set
                        {
                                this.SetFieldValue("extraa_nombre", value);
                        }
                }

                public string NombreExtraB
                {
                        get
                        {
                                return this.GetFieldValue<string>("extrab_nombre");
                        }
                        set
                        {
                                this.SetFieldValue("extrab_nombre", value);
                        }
                }

                public string NombreExtraC
                {
                        get
                        {
                                return this.GetFieldValue<string>("extrac_nombre");
                        }
                        set
                        {
                                this.SetFieldValue("extrac_nombre", value);
                        }
                }
        }
}
