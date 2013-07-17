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

namespace Lbl.Consultas
{
        /// <summary>
        /// Representa un parámetro de una Consulta.
        /// </summary>
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Parámetro")]
        [Lbl.Atributos.Datos(TablaDatos = "consultas_parametros", CampoId = "id_parametro")]
        [Lbl.Atributos.Presentacion()]
        public class Parametro : Lbl.ElementoDeDatos
        {
                private Consulta m_Consulta = null;

                //Heredar constructor
		public Parametro(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Parametro(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Parametro(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public override void OnLoad()
                {
                        m_Consulta = null;
                        base.OnLoad();
                }

                public Consulta Consulta
                {
                        get
                        {
                                if (m_Consulta == null)
                                        m_Consulta = this.GetFieldValue<Consulta>("id_consulta");
                                return m_Consulta;
                        }
                        set
                        {
                                m_Consulta = value;
                                this.SetFieldValue("id_consulta", value.Id);
                        }
                }


                public string Variable
                {
                        get
                        {
                                return this.GetFieldValue<string>("variable");
                        }
                        set
                        {
                                this.Registro["variable"] = value;
                        }
                }


                public Lfx.Data.InputFieldTypes TipoEntrada
                {
                        get
                        {
                                return (Lfx.Data.InputFieldTypes)(Enum.Parse(typeof(Lfx.Data.InputFieldTypes), this.GetFieldValue<string>("tipoentrada")));
                        }
                        set
                        {
                                this.Registro["tipoentrada"] = value.ToString();
                        }
                }


                public int Orden
                {
                        get
                        {
                                return this.GetFieldValue<int>("orden");
                        }
                        set
                        {
                                this.Registro["orden"] = value;
                        }
                }
        }
}
