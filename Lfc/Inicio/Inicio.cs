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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Inicio
{
        public partial class Inicio : Lui.Forms.ChildForm
        {
                public Inicio()
                {
                        InitializeComponent();
                        this.StockImage = "inicio";
                }


                protected override void OnLoad(EventArgs e)
                {
                        base.OnLoad(e);
                        MostrarConsejo();
                }

                private void BotonWebComo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Help.ShowHelp(this, "http://www.lazarogestion.com/?q=node/33");
                }

                private void BotonWebContacto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Help.ShowHelp(this, "http://www.lazarogestion.com/?q=contact");
                }

                private void BotonWebInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Help.ShowHelp(this, "http://www.lazarogestion.com");
                }


                protected override void OnFormClosing(FormClosingEventArgs e)
                {
                        if (e.CloseReason == CloseReason.UserClosing)
                                e.Cancel = true;
                        base.OnFormClosing(e);
                }

                private void BotonWebPrimerosPasos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Help.ShowHelp(this, "http://www.lazarogestion.com/?q=node/44");
                }

                private void BotonWebAltaArticulo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Help.ShowHelp(this, "http://www.lazarogestion.com/?q=node/35");
                }

                private void BotonWebComoFactura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Help.ShowHelp(this, "http://www.lazarogestion.com/?q=node/34");
                }

                private void PanelConsejo_DoubleClick(object sender, EventArgs e)
                {
                        MostrarConsejo();
                }

                private void MostrarConsejo()
                {
                        int Rnd = new Random().Next(0, 10);

                        switch (Rnd) {
                                case 0:
                                case 1:
                                case 2:
                                        PanelConsejo.Descripcion = "Puede hacer cuentas al escribir números en Lázaro. Al ingresar datos en cualquier campo numérico puede hacer cálculos como 2+2 o 7*5 y Lázaro calculará automáticamente el resultado cuando se desplace al campo siguiente.";
                                        break;
                                case 3:
                                case 4:
                                case 5:
                                        PanelConsejo.Descripcion = "Al buscar no necesita recordar el nombre completo. Cuando selecciona de una lista de clientes o artículos puede escribir cualquier parte del nombre y Lázaro mostrará una lista de sugerencias. Por ejemplo escriba 'mar fer' para encontrar 'Marcelo Fernández'.";
                                        break;
                                case 6:
                                        PanelConsejo.Descripcion = "Puede navegar todos los formularios usando sólo el teclado. Utilice las teclas 'Arriba' y 'Abajo' para moverse al campo anterior o siguiente, la tecla 'Esc' para cerrar un formulario o la tecla 'Entrar' para seleccionar un elemento de una lista.";
                                        break;
                                case 7:
                                        PanelConsejo.Descripcion = "Lázaro recibe actualizaciones y mejoras frecuentemente. Si cuenta con una conexión a Internet en este equipo las actualizaciones se descargan e instalan automáticamente.";
                                        break;
                                case 8:
                                case 9:
                                case 10:
                                        PanelConsejo.Descripcion = "Lázaro tiene un sistema de gestión de tareas pendientes. Puede ser útil para gestionar trabajos pendientes con los clientes o para el control de quehaceres internos de su empresa. Para más información vea el menú 'Tareas'.";
                                        break;
                        }
                }
        }
}
