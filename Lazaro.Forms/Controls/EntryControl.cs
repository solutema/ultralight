using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms.Controls
{
        public class EntryControl : Control
        {
                public object Value = null;
                public string ColumnName = null;

                public EntryControl(string label, string columnName)
                        : base(label)
                {
                        this.ColumnName = columnName;
                }
        }
}
