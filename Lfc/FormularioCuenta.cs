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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc
{
        public partial class FormularioCuenta : FormularioListadoBase
        {
                private Lbl.Personas.Persona m_Cliente = null;
                private Lfx.Types.DateRange m_Fechas = new Lfx.Types.DateRange("dia-0");

                public FormularioCuenta()
                {
                        InitializeComponent();

                        //lblTitulo.Font = Lfx.Config.Display.CurrentTemplate.DefaultHeaderFont;
                        lblTitulo.BackColor = Lfx.Config.Display.CurrentTemplate.HeaderBackground;
                        lblTitulo.ForeColor = Lfx.Config.Display.CurrentTemplate.HeaderText;

                        this.Contadores.Add(new Contador("Transporte", Lui.Forms.DataTypes.Currency));
                        this.Contadores.Add(new Contador("Ingresos", Lui.Forms.DataTypes.Currency));
                        this.Contadores.Add(new Contador("Egresos", Lui.Forms.DataTypes.Currency));
                        this.Contadores.Add(new Contador("Saldo", Lui.Forms.DataTypes.Currency));
                }


                public Lfx.Types.DateRange Fechas
                {
                        get
                        {
                                return m_Fechas;
                        }
                        set
                        {
                                m_Fechas = value;
                                if (this.Definicion.Filters.ContainsKey("cajas_movim.fecha"))
                                        this.Definicion.Filters["cajas_movim.fecha"].Value = value;
                        }
                }


                public Lbl.Personas.Persona Cliente
                {
                        get
                        {
                                return m_Cliente;
                        }
                        set
                        {
                                m_Cliente = value;
                        }
                }

                protected override void OnTextChanged(EventArgs e)
                {
                        if (lblTitulo != null)
                                lblTitulo.Text = this.Text;
                        base.OnTextChanged(e);
                }
        }
}