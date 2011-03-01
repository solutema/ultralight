#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lcc.Edicion
{
        public partial class MatrizTags : MatrizCampos
        {
                public MatrizTags()
                {
                        InitializeComponent();
                }

                /// <summary>
                /// Actualiza el control con los datos del elemento.
                /// </summary>
                public override void ActualizarControl()
                {
                        this.FieldContainer.Controls.Clear();
                        //Tomos los tags del registro
                        Lfx.Data.Table Tabla = m_Elemento.Connection.Tables[m_Elemento.TablaDatos];
                        Tabla.DataBase = this.Connection;
                        if (Tabla.Tags != null) {
                                foreach (Lfx.Data.Tag Tg in Tabla.Tags) {
                                        Entrada.Campo Fld = new Entrada.Campo();
                                        Fld.Size = new Size(this.FieldContainer.ClientSize.Width, 24);
                                        Fld.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Top;
                                        Fld.FieldName = Tg.FieldName;
                                        Fld.Text = Tg.Label;
                                        Fld.FieldValue = m_Elemento.GetFieldValue<object>(Tg.FieldName);
                                        this.FieldContainer.Controls.Add(Fld);
                                }
                        }

                        base.ActualizarControl();
                }

                /// <summary>
                /// Actualiza el elemento con los datos del control.
                /// </summary>
                public override void ActualizarElemento()
                {
                        foreach (System.Windows.Forms.Control Ctl in FieldContainer.Controls) {
                                if (Ctl is Entrada.Campo) {
                                        this.Elemento.SetFieldValue(((Entrada.Campo)Ctl).FieldName, ((Entrada.Campo)Ctl).FieldValue);
                                }
                        }

                        base.ActualizarElemento();
                }
        }
}
