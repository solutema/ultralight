// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfx.Data
{
        public enum AccessModes
        {
                Undefined,
                ODBC,
                MyOdbc,         //MySQL Connector/ODBC
                MySql,          //MySQL Connector/NET
                Npgsql,
                MSSql,
                Oracle,
        }

        public enum InputFieldTypes
        {
                Serial,
                Relation,
                Integer,
                Numeric,
                Text,
                Memo,
                Currency,
                Date,
                DateTime,
                Image,
                Binary,
                Bool
        }

        public enum DbTypes
        {
                Serial,
                Integer,
                SmallInt,
                Numeric,
                Currency,
                VarChar,
                Text,
                Blob,
                DateTime,
                NonExactDecimal
        }

        public enum KeyActions
        {
                Unknown,
                None,
                Delete,
                Cascade,
                Restrict
        }

        public static class Types
        {
                public static DbTypes ToDbType(InputFieldTypes columnType)
                {
                        switch(columnType)
                        {
                                case InputFieldTypes.Currency:
                                        return DbTypes.Numeric;
                                case InputFieldTypes.Date:
                                case InputFieldTypes.DateTime:
                                        return DbTypes.DateTime;
                                case InputFieldTypes.Numeric:
                                        return DbTypes.Numeric;
                                case InputFieldTypes.Integer:
                                case InputFieldTypes.Serial:
                                        return DbTypes.Integer;
                                case InputFieldTypes.Text:
                                        return DbTypes.VarChar;
                                case InputFieldTypes.Memo:
                                        return DbTypes.Text;
                                case InputFieldTypes.Binary:
                                case InputFieldTypes.Image:
                                        return DbTypes.Blob;
                                case InputFieldTypes.Bool:
                                        return DbTypes.SmallInt;
                                default:
                                        throw new NotImplementedException();
                        }
                }

		public static DbTypes FromSQLType(string sqlType)
		{
			switch (sqlType.ToUpperInvariant()) {
                                case "VARCHAR":
				case "CHAR":
				case "NVARCHAR":
				case "NCHAR":
				case "CHARACTER VARYING":
                                        return Lfx.Data.DbTypes.VarChar;
                                case "SERIAL":
                                        return Lfx.Data.DbTypes.Serial;
                                case "INTEGER":
				case "BIGINT":
				case "INT":
                                        return Lfx.Data.DbTypes.Integer;
                                case "BOOL":
				case "BOOLEAN":
                                case "SMALLINT":
				case "TINYINT":
                                        return Lfx.Data.DbTypes.SmallInt;
                                case "DECIMAL":         // FIXME: DECIMAL no es lo mismo que NUMERIC, pero MySQL 5.0 los trata igual y reporta los numeric como decimal
                                case "NUMERIC":
                                        return Lfx.Data.DbTypes.Numeric;
                                case "DOUBLE":
                                case "DOUBLE PRECISION":
                                case "FLOAT":
                                case "SINGLE":
                                case "REAL":
                                        return Lfx.Data.DbTypes.NonExactDecimal;
                                case "BLOB":
				case "LONGBLOB":
				case "BYTEA":
                                        return Lfx.Data.DbTypes.Blob;
                                case "DATETIME":
				case "TIMESTAMP":
				case "TIMESTAMP WITHOUT TIME ZONE":
                                        return Lfx.Data.DbTypes.DateTime;
                                default:
                                        return Lfx.Data.DbTypes.Text;
                        }
		}
        }
}
