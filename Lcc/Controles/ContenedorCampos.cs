using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Controles
{
        public class ContenedorCampos : FlowLayoutPanel
        {
                private bool m_AutoHeight = true;

                protected override void OnControlAdded(ControlEventArgs e)
                {
                        base.OnControlAdded(e);
                        this.ReloateChildren();
                }

                protected override void OnSizeChanged(EventArgs e)
                {
                        base.OnSizeChanged(e);
                        this.ReloateChildren();
                }

                private void ReloateChildren()
                {
                        int TotalHeight = 0;
                        foreach (Control Ctl in this.Controls) {
                                Ctl.Width = this.Width - (Ctl.Left * 2);
                                TotalHeight += Ctl.Height + Ctl.Margin.Top + Ctl.Margin.Bottom;
                        }
                        
                        if (m_AutoHeight && TotalHeight > 0)
                                this.Height = TotalHeight + this.Padding.Top + this.Padding.Bottom;

                        // Igualo el ancho de todos los labels de los campos contenidos.
                        int MaxWidth = 0;
                        foreach (System.Windows.Forms.Control Ctl in this.Controls) {
                                if (Ctl is Lcc.Controles.Datos.Campo)
                                        if (((Lcc.Controles.Datos.Campo)Ctl).AutoLabelWidth > MaxWidth)
                                                MaxWidth = ((Lcc.Controles.Datos.Campo)Ctl).AutoLabelWidth;
                        }

                        if (MaxWidth > 0) {
                                foreach (System.Windows.Forms.Control Ctl in this.Controls) {
                                        if (Ctl is Lcc.Controles.Datos.Campo)
                                                ((Lcc.Controles.Datos.Campo)Ctl).LabelWidth = MaxWidth;
                                }
                        }
                }

                #region Propiedades

                public virtual bool AutoHeight
                {
                        get
                        {
                                return m_AutoHeight;
                        }
                        set
                        {
                                m_AutoHeight = value;
                        }
                }

                #endregion
        }
}
