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
using System.Text;
using System.Drawing;

namespace Lcc.Entrada
{
        /// <summary>
        /// Un control que contiene varios controles hijos que se van agregando automáticamente a medida que es necesario.
        /// </summary>
        /// <typeparam name="T">El tipo de control hijo.</typeparam>
        public partial class MatrizControlesEntrada<T> : ControlEntrada where T : IControlEntrada
        {
                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public List<T> Controles { get; set; }

                public MatrizControlesEntrada()
                {
                        this.ElementoTipo = typeof(T);
                        this.Controles = new List<T>();

                        InitializeComponent();
                }

                public override bool TemporaryReadOnly
                {
                        get
                        {
                                return base.TemporaryReadOnly;
                        }
                        set
                        {
                                base.TemporaryReadOnly = value;
                                this.AutoAgregarOQuitar(false);
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public int Count
                {
                        get
                        {
                                // Devuelvo sólo la cantidad de controles que no están vacíos
                                int Res = 0;
                                foreach (T Det in this.Controles) {
                                        if (Det.IsEmpty == false)
                                                Res++;
                                }
                                return Res;
                        }
                        set
                        {
                                int CantidadControles = this.Controles.Count;
                                if (value < CantidadControles) {
                                        for (int i = CantidadControles - 1; i >= value; i--) {
                                                this.Quitar(i);
                                        }
                                } else if (value > CantidadControles) {
                                        for (int i = CantidadControles; i < value; i++) {
                                                this.Agregar();
                                        }
                                }
                        }
                }

                /// <summary>
                /// Agregar un control a la matriz.
                /// </summary>
                /// <returns>El nuevo control.</returns>
                protected virtual T Agregar()
                {
                        T Ctrl = Activator.CreateInstance<T>();

                        this.SuspendLayout();
                        Ctrl.Size = new Size(this.Width - 20, 24);
                        Ctrl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
                        Ctrl.Location = new Point(0, Ctrl.Size.Height * this.Controles.Count + this.PanelGrilla.AutoScrollPosition.Y);
                        Ctrl.TabIndex = this.Controles.Count;
                        Ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
                        this.PanelGrilla.Controls.Add(Ctrl as System.Windows.Forms.Control);
                        this.Controles.Add(Ctrl);

                        this.ReubicarControles();
                        this.ResumeLayout();

                        System.Windows.Forms.Control WinCtrl = Ctrl as System.Windows.Forms.Control;
                        WinCtrl.TextChanged += new System.EventHandler(SubControl_TextChanged);
                        WinCtrl.SizeChanged += new System.EventHandler(SubControl_SizeChanged);
                        WinCtrl.Leave += new System.EventHandler(SubControl_Leave);

                        return Ctrl;
                }


                private void SubControl_SizeChanged(object sender, System.EventArgs e)
                {
                        if (this.Visible)
                                this.ReubicarControles();
                }

                private void SubControl_Leave(object sender, System.EventArgs e)
                {
                        if (this.Visible)
                                this.AutoAgregarOQuitar(true);
                }

                private void SubControl_TextChanged(object sender, System.EventArgs e)
                {
                        this.AutoAgregarOQuitar(false);
                        /* if (this.TextChanged != null)
                                TextChanged(this, e); */
                }

                /// <summary>
                /// Quitar un control de la matriz.
                /// </summary>
                /// <param name="index">El índice del control que se va a quitar.</param>
                protected void Quitar(int index)
                {
                        System.Windows.Forms.Control Ctl = this.Controles[index] as System.Windows.Forms.Control;
                        this.PanelGrilla.Controls.Remove(Ctl);
                        Ctl.Dispose();
                        this.Controles.RemoveAt(index);
                }

                /// <summary>
                /// Reubicar los controles hijos, en caso de que se hayan agregado o quitado algunos.
                /// </summary>
                protected virtual void ReubicarControles()
                {
                        if (this.Controles != null && this.Controles.Count > 0) {
                                this.SuspendLayout();
                                int ControlNumber = 0, AlturaActual = 0;
                                foreach (T Control in this.Controles) {
                                        Control.Location = new Point(Control.Location.X, AlturaActual + this.PanelGrilla.AutoScrollPosition.Y);
                                        AlturaActual += Control.Size.Height + Control.Margin.Vertical;
                                        Control.TabIndex = ControlNumber;
                                        Control.Size = new Size(this.Width - 20, Control.Size.Height);
                                        ControlNumber++;

                                        if (this.AutoSize) {
                                                System.Windows.Forms.Control WinCtrl = Control as System.Windows.Forms.Control;
                                                Point LocationOnForm = WinCtrl.FindForm().PointToClient(Control.Parent.PointToScreen(Control.Location));
                                                this.Height = Control.Size.Height + LocationOnForm.Y;
                                        }
                                }
                                this.ResumeLayout();
                        }
                }

                /// <summary>
                /// Quita controles vacíos si los hay, y agrega un nuevo control al final si hace falta.
                /// </summary>
                /// <param name="quitarDelMedio">Indica si es necesario quitar controles innecesarios en el medio de la matriz.</param>
                protected void AutoAgregarOQuitar(bool quitarDelMedio)
                {
                        if (this.Controles != null) {
                                T Ultimo = default(T);
                                switch (this.Controles.Count) {
                                        case 0:
                                                if (this.TemporaryReadOnly == false)
                                                        this.Agregar();
                                                break;
                                        case 1:
                                                if (this.TemporaryReadOnly == false) {
                                                        Ultimo = this.Controles[0];
                                                        if (Ultimo.IsEmpty == false)
                                                                this.Agregar();
                                                }
                                                break;
                                        default:
                                                bool QuiteAlgo = false;
                                                if (quitarDelMedio) {
                                                        bool QuiteEnEstaPasada = false;
                                                        do {
                                                                QuiteEnEstaPasada = false;
                                                                for (int i = 0; i <= this.Controles.Count - 1; i++) {
                                                                        T Control = this.Controles[i];
                                                                        if (i < this.Controles.Count - 1 && Control.IsEmpty) {
                                                                                this.Quitar(i);
                                                                                QuiteAlgo = true;
                                                                                QuiteEnEstaPasada = true;
                                                                                break;
                                                                        }
                                                                }
                                                        }
                                                        while (QuiteEnEstaPasada);
                                                }
                                                if (QuiteAlgo) {
                                                        this.ReubicarControles();
                                                } else {
                                                        T Penultimo = default(T);
                                                        Ultimo = this.Controles[this.Controles.Count - 1];
                                                        if (this.Controles.Count > 1)
                                                                Penultimo = this.Controles[this.Controles.Count - 2];
                                                        if (Ultimo.IsEmpty == false && Penultimo != null && Penultimo.IsEmpty == false && this.TemporaryReadOnly == false)
                                                                this.Agregar();
                                                }
                                                break;
                                }
                        }
                }
        }
}
