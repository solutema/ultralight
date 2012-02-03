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

namespace Lfc.Articulos
{
        public partial class Receta : Lui.Forms.ChildDialogForm
        {
                private Lbl.Articulos.Articulo m_Articulo;
                private bool m_ReadOnly = true;

                public Receta()
                {
                        InitializeComponent();
                }

                public bool ReadOnly
                {
                        get
                        {
                                return m_ReadOnly;
                        }
                        set
                        {
                                m_ReadOnly = value;
                                //ProductArray.Enabled = !this.ReadOnly;
                                MatrizArticulos.TemporaryReadOnly = m_ReadOnly;
                        }
                }

                public Lbl.Articulos.Articulo Articulo
                {
                        get
                        {
                                return m_Articulo;
                        }
                        set
                        {
                                m_Articulo = value;

                                if (m_Articulo != null) {
                                        MatrizArticulos.Count = Articulo.Receta.Count;

                                        for (int i = 0; i < Articulo.Receta.Count; i++) {
                                                if (Articulo.Receta[i].Articulo == null)
                                                        MatrizArticulos.ChildControls[i].Text = MatrizArticulos.FreeTextCode;
                                                else
                                                        MatrizArticulos.ChildControls[i].Elemento = Articulo.Receta[i].Articulo;

                                                MatrizArticulos.ChildControls[i].Cantidad = Articulo.Receta[i].Cantidad;
                                        }
                                }
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        this.Articulo.Receta.Clear();

                        for (int i = 0; i <= MatrizArticulos.Count - 1; i++) {
                                if (MatrizArticulos.ChildControls[i].Text == MatrizArticulos.FreeTextCode || MatrizArticulos.ChildControls[i].Elemento != null) {
                                        Lbl.Articulos.ItemReceta Itm = new Lbl.Articulos.ItemReceta(MatrizArticulos.ChildControls[i].Articulo, MatrizArticulos.ChildControls[i].Cantidad);
                                        this.Articulo.Receta.Add(Itm);
                                }
                        }

                        return base.Ok();
                }
        }
}
