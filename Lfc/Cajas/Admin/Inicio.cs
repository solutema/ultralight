#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Cajas.Admin
{
	public partial class Inicio : Lfc.FormularioListado
	{
                public Inicio()
                {
                        this.ElementoTipo = typeof(Lbl.Cajas.Caja);

                        this.NombreTabla = "cajas";
                        this.KeyField = new Lfx.Data.FormField("cajas.id_caja", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        Lbl.ColeccionCodigoDetalle SetTipos = new Lbl.ColeccionCodigoDetalle()
                        {
                                {0, "Efectivo"},
                                {1, "Caja de Ahorro"},
                                {2, "Cuenta Corriente"}
                        };

                        Lbl.ColeccionCodigoDetalle SetEstados = new Lbl.ColeccionCodigoDetalle()
                        {
                                {0, "Inactiva"},
                                {1, "Activa"}
                        };

                        this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("cajas.id_caja", "Cód.", Lfx.Data.InputFieldTypes.Relation, 96),
				new Lfx.Data.FormField("cajas.id_banco", "Banco", Lfx.Data.InputFieldTypes.Relation, 120),
				new Lfx.Data.FormField("cajas.numero", "Número", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("cajas.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("cajas.tipo", "Tipo", 80, SetTipos),
				new Lfx.Data.FormField("0", "Saldo Actual", Lfx.Data.InputFieldTypes.Currency, 120),
                                new Lfx.Data.FormField("1", "Saldo Futuro", Lfx.Data.InputFieldTypes.Currency, 120),
                                new Lfx.Data.FormField("estado", "Estado", 96, SetEstados),
			};

                        this.Contadores.Add(new Contador("Total", Lui.Forms.DataTypes.Currency, "$", null));
                        this.Contadores.Add(new Contador("Activos", Lui.Forms.DataTypes.Currency, "$", null));
                }

                public override void OnItemAdded(ListViewItem itm, Lfx.Data.Row row)
		{
                        int IdBanco = Lfx.Types.Parsing.ParseInt(itm.SubItems[2].Text);
                        if (IdBanco != 0)
                                itm.SubItems["id_banco"].Text = this.Connection.Tables["bancos"].FastRows[IdBanco].Fields["nombre"].ValueString;

                        int IdCaja = Lfx.Types.Parsing.ParseInt(itm.Text);
                        decimal Saldo = this.Connection.FieldDecimal("SELECT saldo FROM cajas_movim WHERE id_caja=" + IdCaja.ToString() + " ORDER BY id_movim DESC LIMIT 1");
                        decimal Pasivos = this.Connection.FieldDecimal("SELECT SUM(importe) FROM bancos_cheques WHERE estado IN (0, 5) AND emitido=1 AND id_chequera IN (SELECT chequeras.id_chequera FROM chequeras WHERE estado=1 AND id_caja=" + IdCaja.ToString() + ")");

                        this.Contadores[0].AddValue(Saldo);
			if (Saldo > 0)
                                this.Contadores[1].AddValue(Saldo);
			
                        itm.SubItems["0"].Text = Lfx.Types.Formatting.FormatCurrency(Saldo, this.Workspace.CurrentConfig.Moneda.Decimales);
                        itm.SubItems["1"].Text = Lfx.Types.Formatting.FormatCurrency(Saldo - Pasivos, this.Workspace.CurrentConfig.Moneda.Decimales);
		}
	}
}