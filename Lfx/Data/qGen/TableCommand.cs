using System;

namespace qGen
{
        /// <summary>
        /// Comandos que operan sobre una o más tablas (SELECT, UPDATE, INSERT, DELETE, TRUNCATE, etc.)
        /// </summary>
        [Serializable]
        public abstract class TableCommand : Command, ITableCommand
        {
                public string Tables = "";

                protected TableCommand()
                        : base() { }

                protected TableCommand(SqlModes sqlMode)
                        : base(sqlMode) { }

                protected TableCommand(Lfx.Data.Connection dataBase, string tables)
                        : base(dataBase)
                {
                        this.Tables = tables;
                }

                protected TableCommand(string tables)
                        : this()
                {
                        this.Tables = tables;
                }

                protected TableCommand(string tables, Where whereClause)
                        : this(tables)
                {
                        this.WhereClause = whereClause;
                }
        }
}
