using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Controles.Datos
{
        [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
        public partial class Campo : LccControl
        {
                private int m_LabelWidth = 80;
                private System.Windows.Forms.Orientation m_Orientation = Orientation.Horizontal;

                public Campo()
                {
                        InitializeComponent();
                }

                protected override bool IsInputKey(Keys keyData)
                {
                        switch (keyData) {
                                case Keys.Up:
                                case Keys.Down:
                                case Keys.Left:
                                case Keys.Right:
                                        return true;
                                default:
                                        return base.IsInputKey(keyData);
                        }
                }

                protected override void OnSizeChanged(EventArgs e)
                {
                        base.OnSizeChanged(e);
                        this.UbicarControles();
                }

                protected override void OnControlAdded(ControlEventArgs e)
                {
                        base.OnControlAdded(e);
                        this.UbicarControles();
                }

                private void UbicarControles()
                {
                        int MaxBottom = 0;
                        foreach (System.Windows.Forms.Control Ctl in this.Controls) {
                                if (Ctl != NombreCampo) {
                                        if (this.m_Orientation == Orientation.Horizontal) {
                                                Ctl.Top = NombreCampo.Top;
                                                Ctl.Anchor = AnchorStyles.Left;
                                                Ctl.Left = m_LabelWidth;
                                                Ctl.Dock = DockStyle.Right;
                                                Ctl.Width = this.Width - m_LabelWidth;
                                        } else {
                                                Ctl.Top = NombreCampo.Bottom + NombreCampo.Margin.Bottom;
                                                Ctl.Anchor = AnchorStyles.Bottom;
                                                Ctl.Left = this.Padding.Left + Ctl.Margin.Left;
                                                Ctl.Dock = DockStyle.Bottom;
                                                Ctl.Width = this.Width - this.Padding.Left - this.Padding.Right;
                                        }
                                        if(Ctl.Bottom > MaxBottom)
                                                MaxBottom = Ctl.Bottom;
                                }
                        }
                        if (this.AutoHeight && MaxBottom > 0) {
                                this.Height = MaxBottom + this.Padding.Bottom;
                        }
                }

                #region Propiedades

                [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
                public override string Text
                {
                        get
                        {
                                return NombreCampo.Text;
                        }
                        set
                        {
                                NombreCampo.Text = value;
                                this.UbicarControles();
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public int AutoLabelWidth
                {
                        get
                        {
                                return NombreCampo.Width;
                        }
                }

                public int LabelWidth
                {
                        get
                        {
                                return m_LabelWidth;
                        }
                        set
                        {
                                m_LabelWidth = value;
                                foreach (System.Windows.Forms.Control Ctl in this.Controls) {
                                        if (Ctl != NombreCampo) {
                                                Ctl.Width = this.Width - m_LabelWidth;
                                                Ctl.Left = m_LabelWidth;
                                        }
                                }
                                this.UbicarControles();
                        }
                }

                public virtual System.Windows.Forms.Orientation Orientation
                {
                        get
                        {
                                return m_Orientation;
                        }
                        set
                        {
                                m_Orientation = value;
                                this.UbicarControles();
                        }
                }

                public override bool AutoHeight
                {
                        get
                        {
                                return base.AutoHeight;
                        }
                        set
                        {
                                base.AutoHeight = value;
                                this.UbicarControles();
                        }
                }

                #endregion
        }
}
