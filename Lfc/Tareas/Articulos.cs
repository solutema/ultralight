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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Tareas
{
        public partial class Articulos : Lui.Forms.DialogForm
        {
                private Lbl.Tareas.Tarea m_Tarea;

                public Articulos()
                {
                        InitializeComponent();

                        EtiquetaTitulo.BackColor = Lfx.Config.Display.CurrentTemplate.HeaderBackground;
                        EtiquetaTitulo.ForeColor = Lfx.Config.Display.CurrentTemplate.HeaderText;
                }

                public void ActualizarElemento()
                {
                        m_Tarea.Articulos = MatrizArticulos.ObtenerArticulos(m_Tarea.Connection);
                        m_Tarea.Articulos.HayCambios = true;
                        m_Tarea.DescuentoArticulos = EntradaDescuento.ValueDecimal;
                }

                public void ActualizarControl()
                {
                        EtiquetaTitulo.Text = "Artículos de " + m_Tarea.ToString();
                        this.Text = EtiquetaTitulo.Text;
                        MatrizArticulos.CargarArticulos(m_Tarea.Articulos);
                        EntradaDescuento.ValueDecimal = m_Tarea.DescuentoArticulos;
                }

                public Lbl.Tareas.Tarea Tarea
                {
                        get
                        {
                                return m_Tarea;
                        }
                        set
                        {
                                m_Tarea = value;
                                this.ActualizarControl();
                        }
                }


                private void ProductArray_TotalChanged(System.Object sender, System.EventArgs e)
                {
                        EntradaSubTotal.Text = Lfx.Types.Formatting.FormatCurrency(MatrizArticulos.Total, this.Workspace.CurrentConfig.Moneda.Decimales);
                }


                private void EntradaSubTotal_TextChanged(object sender, System.EventArgs e)
                {
                        EntradaTotal.ValueDecimal = EntradaSubTotal.ValueDecimal * (1 - EntradaDescuento.ValueDecimal / 100);
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        this.ActualizarElemento();
                        return base.Ok();
                }
        }
}