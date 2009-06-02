using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lcc
{
        public partial class LccControl : UserControl, ILccControl
        {
                private bool m_AutoNav = true;
                private bool m_AutoHeight = true;
                private bool m_ReadOnly = false;

                #region Propiedades

                [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
                public override string Text
                {
                        get
                        {
                                return base.Text;
                        }
                        set
                        {
                                base.Text = value;
                        }
                }

                /// <summary>
                /// Indica si el control permite navegación mejorada.
                /// </summary>
                [System.ComponentModel.Category("Comportamiento")]
                public bool AutoNav
                {
                        get
                        {
                                return m_AutoNav;
                        }
                        set
                        {
                                m_AutoNav = value;
                        }
                }

                /// <summary>
                /// Indica si el control debe cambiar automáticamente su altura.
                /// </summary>
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

                /// <summary>
                /// Indica si el control es sólo de lectura.
                /// </summary>
                public virtual bool ReadOnly
                {
                        get
                        {
                                return m_ReadOnly;
                        }
                        set
                        {
                                m_ReadOnly = value;
                        }
                }

                #endregion
        }
}
