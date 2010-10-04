using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lui.Forms
{
        public class ButtonCollection : List<Button>
        {
                ButtonGroup Parent = null;

                public ButtonCollection(ButtonGroup parent)
                {
                        this.Parent = parent;
                }
        }
}
