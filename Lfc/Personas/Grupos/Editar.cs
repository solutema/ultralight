#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
using System.Windows.Forms;

namespace Lfc.Personas.Grupos
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {

                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Personas.Grupo);

                        InitializeComponent();
                }

                public override void ActualizarControl()
                {
                        Lbl.Personas.Grupo Gru = this.Elemento as Lbl.Personas.Grupo;

                        EntradaNombre.Text = Gru.Nombre;
                        EntradaDescuento.ValueDecimal = Gru.Descuento;
                        EntradaPredet.TextKey = Gru.Predeterminado ? "1" : "0";
                        EntradaGrupo.Elemento = Gru.Parent;
                        if (this.Elemento.Existe)
                                EntradaGrupo.Filter = "id_grupo<>" + this.Elemento.Id;

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Personas.Grupo Gru = this.Elemento as Lbl.Personas.Grupo;

                        Gru.Nombre = EntradaNombre.Text;
                        Gru.Descuento = EntradaDescuento.ValueDecimal;
                        Gru.Predeterminado = EntradaPredet.TextKey == "1";
                        Gru.Parent = EntradaGrupo.Elemento as Lbl.Personas.Grupo;

                        base.ActualizarElemento();
                }
        }
}
