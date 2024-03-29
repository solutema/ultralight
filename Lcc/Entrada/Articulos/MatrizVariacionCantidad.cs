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
using System.Text;
using System.Windows.Forms;

namespace Lcc.Entrada.Articulos
{
        public partial class MatrizVariacionCantidad : MatrizControlesEntrada<VariacionCantidad>
        {
                private bool m_EsNumeroDeSerie = false;

                public MatrizVariacionCantidad()
                {
                        InitializeComponent();
                }

                /// <summary>
                /// Determina si se está ingresando un número de serie.
                /// Cuando se ingresa un número de serie, sólo se permiten letras mayúsculas y sólo se admite cantidad 1 (1 elemento por número).
                /// En caso contrario, se trata de variaciones, donde se permiten minúsculas y más de 1 por variación (p. ej. 2 rojos, 4 azules, etc.)
                /// </summary>
                public bool EsNumeroDeSerie
                {
                        get
                        {
                                return m_EsNumeroDeSerie;
                        }
                        set
                        {
                                m_EsNumeroDeSerie = value;
                        }
                }

                protected override VariacionCantidad Agregar()
                {
                        VariacionCantidad Ctrl = base.Agregar();

                        Ctrl.EsNumeroDeSerie = m_EsNumeroDeSerie;

                        return Ctrl;
                }


                public Lbl.Articulos.ColeccionDatosSeguimiento DatosSeguimiento
                {
                        get
                        {
                                Lbl.Articulos.ColeccionDatosSeguimiento Res = new Lbl.Articulos.ColeccionDatosSeguimiento();
                                foreach (VariacionCantidad Ctrl in this.Controles) {
                                        if (Ctrl.IsEmpty == false)
                                                Res.AddWithValue(Ctrl.Variacion, Ctrl.Cantidad);
                                }

                                return Res;
                        }
                        set
                        {
                                this.Controles.Clear();
                                if (value != null) {
                                        foreach (Lbl.Articulos.DatosSeguimiento Dat in value) {
                                                VariacionCantidad Ctl = this.Agregar();
                                                Ctl.Variacion = Dat.Variacion;
                                                Ctl.Cantidad = Dat.Cantidad;
                                        }
                                }
                                this.AutoAgregarOQuitar(true);
                        }
                }
        }
}
