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

namespace Lcc.Edicion
{
        public partial class MatrizTags : MatrizCampos
        {
                Lfx.Data.Table Tabla;

                public MatrizTags()
                {
                        InitializeComponent();
                }

                /// <summary>
                /// Actualiza el control con los datos del elemento.
                /// </summary>
                public override void ActualizarControl()
                {
                        Lazaro.Pres.Forms.Section Sect = new Lazaro.Pres.Forms.Section("Campos adicionales");
                        this.Tabla = m_Elemento.Connection.Tables[m_Elemento.TablaDatos];
                        Tabla.Connection = this.Connection;
                        if (Tabla.Tags != null) {
                                foreach (Lfx.Data.Tag Tg in Tabla.Tags) {
                                        if (Tg.Internal == false) {
                                                Lazaro.Pres.Field Fld = new Lazaro.Pres.Field(Tg.FieldName, Tg.Label, Tg.InputFieldType);
                                                if (string.IsNullOrEmpty(Tg.LblType) == false) {
                                                        Fld.LblType = Lbl.Instanciador.InferirTipo(Tg.LblType);
                                                }
                                                if (Tg.Access > 0) {
                                                        Lbl.Sys.Permisos.Operaciones Oper = (Lbl.Sys.Permisos.Operaciones)(Tg.Access);
                                                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(m_Elemento, Oper) == false) {
                                                                Fld.ReadOnly = true;
                                                        }
                                                }
                                                Fld.Relation = Tg.Relation;
                                                Sect.Fields.Add(Fld);
                                        }
                                }
                        }

                        this.FromSection(Sect);

                        base.ActualizarControl();
                }

                /// <summary>
                /// Actualiza el elemento con los datos del control.
                /// </summary>
                public override void ActualizarElemento()
                {
                        if (Tabla.Tags != null) {
                                foreach (Campo Cmp in this.Campos) {
                                        object FieldValue = null;
                                        switch (Tabla.Tags[Cmp.ControlEntrada.FieldName].InputFieldType) {
                                                case Lfx.Data.InputFieldTypes.Bool:
                                                        FieldValue = ((Lui.Forms.YesNo)(Cmp.ControlEntrada)).Value ? 1 : 0;
                                                        break;
                                                case Lfx.Data.InputFieldTypes.Set:
                                                        FieldValue = ((Lui.Forms.ComboBox)(Cmp.ControlEntrada)).TextKey;
                                                        break;
                                                case Lfx.Data.InputFieldTypes.Relation:
                                                        FieldValue = ((Entrada.CodigoDetalle)(Cmp.ControlEntrada)).ValueInt;
                                                        if (object.Equals(FieldValue, 0))
                                                                FieldValue = null;
                                                        break;
                                                default:
                                                        Lui.Forms.TextBox TextField = Cmp.ControlEntrada as Lui.Forms.TextBox;
                                                        switch (Tabla.Tags[Cmp.ControlEntrada.FieldName].InputFieldType) {
                                                                case Lfx.Data.InputFieldTypes.Currency:
                                                                        FieldValue = TextField.ValueDecimal;
                                                                        break;
                                                                case Lfx.Data.InputFieldTypes.Date:
                                                                        FieldValue = Lfx.Types.Parsing.ParseDate(TextField.Text);
                                                                        break;
                                                                case Lfx.Data.InputFieldTypes.DateTime:
                                                                        FieldValue = Lfx.Types.Parsing.ParseDate(TextField.Text);
                                                                        break;
                                                                case Lfx.Data.InputFieldTypes.Numeric:
                                                                        FieldValue = TextField.ValueDecimal;
                                                                        break;
                                                                case Lfx.Data.InputFieldTypes.Integer:
                                                                        FieldValue = TextField.ValueInt;
                                                                        break;
                                                                default:
                                                                        FieldValue = TextField.Text;
                                                                        break;
                                                        }
                                                        break;
                                        }

                                        this.Elemento.SetFieldValue(Cmp.ControlEntrada.FieldName, FieldValue);
                                }
                        }

                        base.ActualizarElemento();
                }
        }
}
