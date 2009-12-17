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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
	public partial class ProgressForm : Lui.Forms.Form
	{

		public string Titulo
		{
			get
			{
				return lblOperacionNombre.Text;
			}
			set
			{
				lblOperacionNombre.Text = value;
				this.Show();
				this.Refresh();
			}
		}

		public string Operacion
		{
			get
			{
				return lblOperacion.Text;
			}
			set
			{
				lblOperacion.Text = value;
				this.Show();
				this.Refresh();
			}
		}

		public string Texto
		{
			get
			{
				return lblTexto.Text;
			}
			set
			{
				lblTexto.Text = value;
				this.Show();
				this.Refresh();
			}
		}

		public int Progreso
		{
			get
			{
				return ProgressBar.Value;
			}
			set
			{
				ProgressBar.Value = value;
			}
		}

		public int Max
		{
			get
			{
				return ProgressBar.Maximum;
			}
			set
			{
				ProgressBar.Maximum = value;
			}
		}

		public ProgressBarStyle Style
		{
			get
			{
				return ProgressBar.Style;
			}
			set
			{
				ProgressBar.Style = value;
			}
		}

		public void Cerrar()
		{
			System.Threading.Thread.Sleep(500);
			this.Close();
		}

	}
}