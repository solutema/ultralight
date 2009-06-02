using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Controles
{
        public partial class Encabezado : LccControl
        {
                public Encabezado()
                {
                        InitializeComponent();
                }

                public override string Text
                {
                        get
                        {
                                return label1.Text;
                        }
                        set
                        {
                                label1.Text = value;
                                base.Text = value;
                        }
                }
        }
}
