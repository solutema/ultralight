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

namespace Lcc.Entrada.Articulos
{
        public partial class VariacionCantidad : ControlEntrada
        {
                public VariacionCantidad()
                {
                        InitializeComponent();

                        if (this.Workspace != null) {
                                EntradaCantidad.DecimalPlaces = this.Workspace.CurrentConfig.Productos.DecimalesStock;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public string Variacion
                {
                        get
                        {
                                return EntradaVariacion.Text;
                        }
                        set
                        {
                                EntradaVariacion.Text = value;
                        }
                }


                public bool EsNumeroDeSerie
                {
                        get
                        {
                                return EntradaCantidad.ReadOnly;
                        }
                        set
                        {
                                EntradaCantidad.ReadOnly = value;
                                EntradaCantidad.Enabled = !value;
                                if (value) {
                                        EntradaCantidad.Text = "1";
                                        EntradaVariacion.ForceCase = Lui.Forms.TextCasing.UpperCase;
                                } else {
                                        EntradaVariacion.ForceCase = Lui.Forms.TextCasing.Caption;
                                }
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public decimal Cantidad
                {
                        get
                        {
                                return Lfx.Types.Parsing.ParseStock(EntradaCantidad.Text);
                        }
                        set
                        {
                                EntradaCantidad.Text = Lfx.Types.Formatting.FormatStock(value);
                        }
                }

                public override bool IsEmpty
                {
                        get
                        {
                                return this.Variacion.Length == 0;
                        }
                }

                private void EntradaVariacionCantidad_TextChanged(object sender, EventArgs e)
                {
                        this.Text = EntradaVariacion.Text + ": " + EntradaCantidad.Text;
                        EntradaCantidad.TabStop = EntradaVariacion.Text.Length > 0;
                        this.OnTextChanged(e);
                }
        }

}