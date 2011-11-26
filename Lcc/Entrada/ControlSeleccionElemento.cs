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
using System.Text;

namespace Lcc.Entrada
{
        /// <summary>
        /// Control de entrada que permite seleccionar un Lbl.ElementoDeDatos.
        /// </summary>
        public class ControlSeleccionElemento : ControlEntrada
        {
                public Lfx.Data.Relation Relation = new Lfx.Data.Relation();
                
                protected int m_ItemId;
                protected Lfx.Data.Row CurrentRow = null;

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public override Lbl.IElementoDeDatos Elemento
                {
                        get
                        {
                                if (this.TextInt == 0) {
                                        return null;
                                } else if (base.Elemento == null || base.Elemento.Id != this.TextInt) {
                                        if (this.CurrentRow != null) {
                                                if (this.ElementoTipo == null || this.ElementoTipo == typeof(Lbl.ElementoDeDatos))
                                                        this.ElementoTipo = Lbl.Instanciador.InferirTipo(this.Table);
                                                Lbl.IElementoDeDatos Elem = Lbl.Instanciador.Instanciar(this.ElementoTipo, this.Connection, CurrentRow);
                                                if (Elem != null && Elem.Existe)
                                                        base.Elemento = Elem;
                                        } else {
                                                base.Elemento = null;
                                        }
                                }
                                return base.Elemento;
                        }
                        set
                        {
                                base.Elemento = value;
                                if (value == null) {
                                        this.CurrentRow = null;
                                        m_ItemId = 0;
                                        if (this.TextInt != 0)
                                                this.TextInt = 0;
                                } else {
                                        this.CurrentRow = m_Elemento.Registro;
                                        m_ItemId = m_Elemento.Id;
                                        this.TextInt = base.Elemento.Id;
                                }
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public int TextInt
                {
                        get
                        {
                                return m_ItemId;
                        }
                        set
                        {
                                m_ItemId = value;
                                this.Text = value.ToString();
                        }
                }


                [System.ComponentModel.Category("Datos")]
                virtual public string Table
                {
                        get
                        {
                                return this.Relation.ReferenceTable;
                        }
                        set
                        {
                                this.Relation.ReferenceTable = value;
                        }
                }


                [System.ComponentModel.Category("Datos")]
                virtual public string DataValueField
                {
                        get
                        {
                                return this.Relation.ReferenceColumn;
                        }
                        set
                        {
                                this.Relation.ReferenceColumn = value;
                        }
                }


                [System.ComponentModel.Category("Datos")]
                virtual public string DataTextField
                {
                        get
                        {
                                return this.Relation.DetailColumn;
                        }
                        set
                        {
                                this.Relation.DetailColumn = value;
                        }
                }
        }
}
