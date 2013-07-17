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
        /// Representa una consulta parametrizable, que acepta parámetros y devuelve como resultado una tabla o conjunto de registros.
        /// </summary>
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Consulta")]
        [Lbl.Atributos.Datos(TablaDatos = "consultas", CampoId = "id_consulta")]
        [Lbl.Atributos.Presentacion()]
        public class Consulta : Lbl.ElementoDeDatos
        {
                private Lbl.ColeccionGenerica<Parametro> m_Parametros = null;

                //Heredar constructor
		public Consulta(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Consulta(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Consulta(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public string Query
                {
                        get
                        {
                                return this.GetFieldValue<string>("query");
                        }
                        set
                        {
                                this.Registro["query"] = value;
                        }
                }


                public Lbl.ColeccionGenerica<Parametro> Parametros
                {
                        get
                        {
                                if (m_Parametros == null) {
                                        // Obtener los params de la base de datos
                                        qGen.Select SelParams = new qGen.Select("consultas_parametros");
                                        SelParams.Fields = "*";
                                        SelParams.WhereClause = new qGen.Where("id_consulta", this.Id);
                                        System.Data.DataTable TablaParams = this.Connection.Select(SelParams);

                                        m_Parametros = new Lbl.ColeccionGenerica<Parametro>(this.Connection, TablaParams);
                                }
                                return m_Parametros;
                        }
                        set
                        {
                                m_Parametros = value;
                        }
                }


                public Lazaro.Pres.Spreadsheet.Sheet Ejecutar(Dictionary<string, object> valores)
                {
                        Lazaro.Pres.Spreadsheet.Sheet Res = new Lazaro.Pres.Spreadsheet.Sheet();

                        string Select = this.Query;
                        // Remplazar variables por sus valores

                        // Ejecutar consulta

                        // Llenar la planilla

                        return Res;
                }
        }
}
