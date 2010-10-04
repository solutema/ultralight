#region License
// Copyright 2004-2010 South Bridge S.R.L.
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
using System.ComponentModel;

namespace Lcc
{
        public class ControlDeDatos : Lcc.LccControl
        {
                public Type m_ElementType = null;
                protected Lbl.ElementoDeDatos m_Elemento = null;

                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Type ElementType
                {
                        get
                        {
                                return m_ElementType;
                        }
                        set
                        {
                                m_ElementType = value;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public virtual Lbl.ElementoDeDatos Elemento
                {
                        get
                        {
                                return m_Elemento;
                        }
                        set
                        {
                                m_Elemento = value;
                                if(m_Elemento != null && (m_ElementType == null || m_ElementType == typeof(Lbl.ElementoDeDatos)))
                                        this.ElementType = value.GetType();

                                foreach (System.Windows.Forms.Control Ctl in this.Controls) {
                                        if (Ctl is ControlDeDatos) {
                                                ((ControlDeDatos)Ctl).Elemento = value;
                                                ((ControlDeDatos)Ctl).ElementType = this.ElementType;
                                        }
                                }
                                this.ActualizarControl();
                        }
                }


                /// <summary>
                /// Actualiza el control con los datos del elemento.
                /// </summary>
                public virtual void ActualizarControl() 
                {
                }
        }
}
