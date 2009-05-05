// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Cuentas.Vencimientos
{
        public partial class Inicio : Lui.Forms.ListingForm
        {
                public Inicio()
                {
                        InitializeComponent();

                        DataTableName = "vencimientos";
                        KeyField = new Lfx.Data.FormField("vencimientos.id_vencimiento", "C�d.", Lfx.Data.InputFieldTypes.Serial, 20);
                        OrderBy = "vencimientos.fecha_proxima DESC";
                        FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("vencimientos.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("vencimientos.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("vencimientos.frecuencia", "Frecuencia", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("vencimientos.fecha_proxima", "Pr�xima Ocurrencia", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("vencimientos.id_concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 160),
				new Lfx.Data.FormField("vencimientos.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 96),
                                new Lfx.Data.FormField("vencimientos.obs", "Obs", Lfx.Data.InputFieldTypes.Memo, 320)
			};
                        Listado.CheckBoxes = true;
                        BotonFiltrar.Visible = true;
                }

                public override void ItemAdded(ListViewItem item)
                {
                        base.ItemAdded(item);

                        switch (Lfx.Types.Parsing.ParseInt(item.SubItems[6].Text)) {
                                case 1:
                                        item.SubItems[6].Text = "Activo";
                                        DateTime? Vencimiento = Lfx.Types.Parsing.ParseDate(item.SubItems[4].Text);
                                        if (Vencimiento.HasValue && Vencimiento <= DateTime.Now)
                                                item.ForeColor = System.Drawing.Color.Red;
                                        else if (Vencimiento.HasValue && Vencimiento <= DateTime.Now.AddDays(5))
                                                item.ForeColor = System.Drawing.Color.Orange;
                                        break;
                                case 2:
                                        item.SubItems[6].Text = "Inactivo";
                                        break;
                                case 100:
                                        item.SubItems[6].Text = "Terminado";
                                        break;
                        }

                        Lfx.Data.Row Concepto = this.DataView.Tables["cuentas_conceptos"].FastRows[Lfx.Types.Parsing.ParseInt(item.SubItems[5].Text)];
                        if (Concepto != null)
                                item.SubItems[5].Text = Concepto.Fields["nombre"].ToString();

                        
                }
        }
}