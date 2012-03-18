#region License
// Copyright 2004-2012 Ernesto N. Carrea
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// Este programa es software libre; puede distribuirlo y/o moficiarlo de
// acuerdo a los términos de la Licencia Pública General de GNU (GNU
// General Public License), como la publica la Fundación para el Software
// Libre (Free Software Foundation), tanto la versión 3 de la Licencia
// como (a su elección) cualquier versión posterior.
//
// Este programa se distribuye con la esperanza de que sea útil, pero SIN
// GARANTÍA ALGUNA; ni siquiera la garantía MERCANTIL implícita y sin
// garantizar su CONVENIENCIA PARA UN PROPÓSITO PARTICULAR. Véase la
// Licencia Pública General de GNU para más detalles. 
//
// Debería haber recibido una copia de la Licencia Pública General junto
// con este programa. Si no ha sido así, vea <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Lui.Forms
{
        public partial class SecondaryActionsPanel : UserControl, IControl, IDisplayStyleControl
        {
                public Lazaro.Pres.Forms.FormActionCollection FormActions { get; set; }
                public event EventHandler ButtonClick;

                public SecondaryActionsPanel()
                {
                        InitializeComponent();
                        base.BackColor = this.DisplayStyle.LightColor;
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Color BackColor
                {
                        get
                        {
                                return base.BackColor;
                        }
                }


                public void ActualizarControl()
                {
                        if (FormActions == null) {
                                PanelPrimario.Controls.Clear();
                                return;
                        }

                        this.SuspendLayout();
                        PanelPrimario.SuspendLayout();

                        // Primero elimino los botones que ya no están en la lista
                        foreach (System.Windows.Forms.Control btn in PanelPrimario.Controls) {
                                if (btn is Lui.Forms.LinkLabel) {
                                        if (FormActions.ContainsKey(btn.Name) == false) {
                                                // No existe... lo elimino
                                                PanelPrimario.Controls.Remove(btn);
                                                btn.Dispose();
                                        } else if (FormActions[btn.Name].Visibility != Lazaro.Pres.Forms.FormActionVisibility.Tertiary) {
                                                // Existe... pero no en el panel terciario
                                                PanelPrimario.Controls.Remove(btn);
                                                btn.Dispose();
                                        }
                                }
                        }

                        // Ahora agrego o actualizo los botones existentes
                        foreach (Lazaro.Pres.Forms.FormAction act in this.FormActions) {
                                if (act.Visibility == Lazaro.Pres.Forms.FormActionVisibility.Tertiary) {
                                        if (PanelPrimario.Controls.ContainsKey(act.Name)) {
                                                // Existe, lo actualizo
                                                Lui.Forms.LinkLabel Btn = PanelPrimario.Controls[act.Name] as Lui.Forms.LinkLabel;
                                                Btn.Text = act.Text;
                                                Btn.Enabled = act.Enabled;
                                        } else {
                                                // No existe, lo agrego
                                                Lui.Forms.LinkLabel Btn = new Lui.Forms.LinkLabel();
                                                Btn.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
                                                Btn.Name = act.Name;
                                                Btn.Text = act.Text;
                                                Btn.Enabled = act.Enabled;
                                                Btn.TabIndex = act.TabIndex;
                                                Btn.AutoSize = true;
                                                //Btn.Size = new System.Drawing.Size(96, PanelPrimario.ClientRectangle.Height);
                                                Btn.Visible = true;
                                                Btn.LinkClicked += new LinkLabelLinkClickedEventHandler(this.Btn_LinkClicked);

                                                PanelPrimario.Controls.Add(Btn);
                                        }
                                }
                        }

                        PanelPrimario.ResumeLayout(true);
                        this.ResumeLayout(true);
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public virtual Lazaro.Pres.DisplayStyles.IDisplayStyle DisplayStyle
                {
                        get
                        {
                                if (this.Parent is IForm)
                                        return ((IForm)(this.Parent)).DisplayStyle;
                                else if (this.Parent is IDisplayStyleControl)
                                        return ((IDisplayStyleControl)(this.Parent)).DisplayStyle;
                                else
                                        return Lazaro.Pres.DisplayStyles.Template.Current.Default;
                        }
                }

                private void Btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        if (this.ButtonClick != null)
                                this.ButtonClick(sender, e);
                }
        }
}
