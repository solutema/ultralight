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

namespace qGen
{
        /// <summary>
        /// Esta clase y sus derivadas se utilizan para evitar escribir los comandos SQL como literales de texto.
        /// Permite la creación de un objeto y asignación de propiedades que luego puede convertirse para su ejecución
        /// en texto SQL (mediante el método ToString()) o en un OdbcCommand (mediante el método ToOdbcCommand()).
        /// Se utilizan principalmente con dos objetivos:
        ///   1.- Solucionar problemas de léxico SQL.
        ///   2.- Agregar extensibilidad al acceso a datos. Así como hoy se implementa ToOdbcCommand() para acceso mediante ODBC, luego se
        ///       pueden implementar otros métodos para acceso mediante otros adaptadores (p. ej. MySQL Connector/Net).
        /// </summary>
        [Serializable]
        public class Command
        {
                internal SqlModes m_Mode = SqlModes.Ansi;

                public Where WhereClause = null;

                public Lfx.Data.FieldCollection Fields = new Lfx.Data.FieldCollection();

                [NonSerialized]
                public Lfx.Data.Connection DataBase = null;

                protected Command()
                {
                        // Nada
                }

                protected Command(Lfx.Data.Connection dataBase)
                        : this()
                {
                        this.DataBase = dataBase;
                        this.SqlMode = dataBase.SqlMode;
                }

                protected Command(SqlModes SqlMode)
                        : this()
                {
                        m_Mode = SqlMode;
                }

                public SqlModes SqlMode
                {
                        get
                        {
                                return m_Mode;
                        }
                        set
                        {
                                m_Mode = value;
                        }
                }

                public virtual void SetupDbCommand(ref System.Data.IDbCommand baseCommand)
                {
                        baseCommand.CommandText = this.ToString();
                }
        }
}
