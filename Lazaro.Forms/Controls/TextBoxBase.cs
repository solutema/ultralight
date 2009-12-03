using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms.Controls
{
        public class TextBoxBase : EntryControl
        {
                public int MaxLenght = 20;

                public TextBoxBase(string label, string columnName)
                        : base(label, columnName)
                {
                }
        }
}
