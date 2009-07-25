using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Controles
{
        public abstract class TextBoxBase : System.Windows.Forms.TextBox, ILccControl
        {
                protected bool m_AutoNav = true;
                protected bool m_AutoHeight = true;
                protected bool m_ReadOnly = false;
                protected string m_ToolTipText = null, m_TipWhenBlank = null;
                protected Lui.Forms.DataTypes m_DataType = Lui.Forms.DataTypes.FreeText;

                protected internal bool m_SelectOnFocus = true;
                protected internal Lui.Forms.TextCasing m_ForceCase = Lui.Forms.TextCasing.None;
                protected internal int m_DecimalPlaces = -1;
                protected internal char m_PasswordChar = Lfx.Types.ControlChars.Null;

                protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case Keys.Up:
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                                break;

                                        case Keys.Down:
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                                break;
                                }
                        }
                        base.OnKeyDown(e);
                }

                public override bool AutoSize
                {
                        get
                        {
                                return false;
                        }
                        set
                        {
                                base.AutoSize = false;
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
                /// Indica si el control debe seleccionar todo el texto al recibir el foco.
                /// </summary>
                public virtual bool SelectOnFocus
                {
                        get
                        {
                                return m_SelectOnFocus;
                        }
                        set
                        {
                                m_SelectOnFocus = value;
                        }
                }

                /// <summary>
                /// Especifica un texto de ayuda para el campo.
                /// </summary>
                public virtual string ToolTipText
                {
                        get
                        {
                                return m_ToolTipText;
                        }
                        set
                        {
                                m_ToolTipText = value;
                        }
                }

                /// <summary>
                /// Especifica un texto a mostrar cuando el campo está vacío.
                /// </summary>
                public virtual string TipWhenBlank
                {
                        get
                        {
                                return m_TipWhenBlank;
                        }
                        set
                        {
                                m_TipWhenBlank = value;
                        }
                }

                [System.ComponentModel.Category("Comportamiento")]
                public virtual Lui.Forms.DataTypes DataType
                {
                        get
                        {
                                return m_DataType;
                        }
                        set
                        {
                                m_DataType = value;
                        }
                }
        }
}
