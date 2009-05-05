// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lazaro.Misc.SuperBuscador
{
    public partial class Resultado : UserControl
    {
        private int m_Sangria = 0;
        private int m_Codigo = 0;

        public Resultado()
        {
            InitializeComponent();
        }

        public int Codigo
        {
            get
            {
                return m_Codigo;
            }
            set
            {
                m_Codigo = value;
            }
        }

        public override string Text
        {
            get
            {
                return LabelNombre.Text;
            }
            set
            {
                LabelNombre.Text = value;
            }
        }

        public string Detalles
        {
            get
            {
                return LabelDetalles.Text;
            }
            set
            {
                LabelDetalles.Text = value;
                if (value != null && value.Length > 0)
                {
                    //Hay detalles... calculo el alto según las líneas del detalle
                    int Renglones = (value.Length - value.Replace(System.Environment.NewLine, "").Length) / System.Environment.NewLine.Length + 1;
                    this.Height = 20 + 16 * Renglones;
                }
                else
                {
                    this.Height = 20;
                }
            }
        }

        public int Sangria
        {
            get
            {
                return m_Sangria;
            }
            set
            {
                m_Sangria = value;
                LabelNombre.Left = m_Sangria * 24;
                LabelNombre.Width = this.Width - LabelNombre.Left;
                LabelDetalles.Left = LabelNombre.Left;
                LabelDetalles.Width = this.Width - LabelDetalles.Left;
            }
        }
    }
}
