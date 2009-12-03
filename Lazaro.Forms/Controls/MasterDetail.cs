using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms.Controls
{
        public class MasterDetail : EntryControl
        {
                public Lfx.Data.Relation Relation = null;

                public MasterDetail(string label, string columnName)
                        : base(label, columnName)
                {
                }
        }
}
