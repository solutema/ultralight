using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Controles
{
        public class ListView : System.Windows.Forms.ListView
        {
                protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case Keys.Up:
                                                if (this.Items.Count == 0) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                                } else if (this.SelectedItems.Count > 0 && this.SelectedItems[0].Index == 0) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                                }
                                                break;

                                        case Keys.Down:
                                                if (this.Items.Count == 0) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                                } else if (this.SelectedItems.Count > 0 && this.SelectedItems[0].Index == this.Items.Count - 1) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                                }
                                                break;
                                }
                        }
                        base.OnKeyDown(e);
                }
        }
}
