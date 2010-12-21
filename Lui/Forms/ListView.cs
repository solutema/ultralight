#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
using System.Text;
using System.Windows.Forms;

namespace Lui.Forms
{
        /// <summary>
        /// Provee un ListView mejorado que permite que se pase al siguiente control cuando se llega hasta el último ítem con la tecla cursor-abajo.
        /// </summary>
        public class ListView : System.Windows.Forms.ListView
        {
                protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case System.Windows.Forms.Keys.Up:
                                                if (this.Items.Count == 0) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                                } else if (this.SelectedItems.Count > 0 && this.SelectedItems[0].Index == 0) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                                }
                                                break;

                                        case System.Windows.Forms.Keys.Down:
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

                public ListView()
                {
                        this.DoubleBuffered = true;

                        // Enable the OnNotifyMessage event so we get a chance to filter out 
                        // Windows messages before they get to the form's WndProc
                        this.SetStyle(ControlStyles.EnableNotifyMessage, true);
                }

                /* protected override void OnNotifyMessage(Message m)
                {
                        //Filter out the WM_ERASEBKGND message
                        if (m.Msg != 0x14) {
                                base.OnNotifyMessage(m);
                        }
                } */
        }
}