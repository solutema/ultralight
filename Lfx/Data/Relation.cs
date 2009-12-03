using System;
using System.Collections.Generic;
using System.Text;

namespace Lfx.Data
{
        public class Relation
        {
                public string Column, ReferenceTable, ReferenceColumn, DetailColumn;

                public Relation()
                {
                }

                public Relation(string column, string referenceTable, string referenceColumn)
                {
                        this.Column = column;
                        this.ReferenceTable = referenceTable;
                        this.ReferenceColumn = referenceColumn;
                }

                public Relation(string column, string referenceTable, string referenceColumn, string detailColumn)
                        : this (column, referenceTable, referenceColumn)
                {
                        this.DetailColumn = detailColumn;
                }
        }
}
