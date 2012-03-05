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
using System.Windows.Forms;

namespace Lfc
{
        public enum FormatoExportar
        {
                Html,
                Excel,
                ExcelXml,
                Imprimir,
                ImprimirAvanzado
        }

	public partial class FormularioListadoExportar : Lui.Forms.Form
	{
                public FormatoExportar SaveFormat = FormatoExportar.Html;

                public FormularioListadoExportar()
                {
                        InitializeComponent();
                }

		private void BotonHtml_Click(object sender, System.EventArgs e)
		{
                        this.SaveFormat = FormatoExportar.Html;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Hide();
		}


		private void BotonExcel_Click(object sender, System.EventArgs e)
		{
                        this.SaveFormat = FormatoExportar.ExcelXml;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Hide();
		}

                private void BotonImprimir_Click(object sender, EventArgs e)
                {
                        this.SaveFormat = FormatoExportar.Imprimir;
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                }

                private void BotonCancelar_Click(object sender, EventArgs e)
                {
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.Hide();
                }

                private void BotonImprimirAvanzado_Click(object sender, EventArgs e)
                {
                        this.SaveFormat = FormatoExportar.ImprimirAvanzado;
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                }
	}
}