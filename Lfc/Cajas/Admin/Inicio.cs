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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cajas.Admin
{
	public partial class Inicio : Lui.Forms.ListingForm
	{
                public Inicio()
                {
                        InitializeComponent();

                        DataTableName = "cajas";
                        KeyField = new Lfx.Data.FormField("cajas.id_caja", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("cajas.id_caja", "Cód.", Lfx.Data.InputFieldTypes.Relation, 96),
				new Lfx.Data.FormField("cajas.id_banco", "Banco", Lfx.Data.InputFieldTypes.Relation, 120),
				new Lfx.Data.FormField("cajas.numero", "Número", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("cajas.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("cajas.tipo", "Tipo", Lfx.Data.InputFieldTypes.Text, 80),
				new Lfx.Data.FormField("0", "Saldo Actual", Lfx.Data.InputFieldTypes.Currency, 120),
                                new Lfx.Data.FormField("0", "Saldo Futuro", Lfx.Data.InputFieldTypes.Currency, 120),
                                new Lfx.Data.FormField("estado", "Estado", Lfx.Data.InputFieldTypes.Text, 96),
			};
                }

		public override void BeginRefreshList()
		{
			txtTotal.Text = "0";
			txtActivos.Text = "0";
		}

                public override void ItemAdded(ListViewItem itm, Lfx.Data.Row row)
		{
			switch (itm.SubItems[5].Text)
			{
				case "0":
				case "-":
				case "":
                                        itm.SubItems[5].Text = "Efectivo";
					break;
				case "1":
					itm.SubItems[5].Text = "Caja de Ahorro";
					break;
				case "2":
					itm.SubItems[5].Text = "Cuenta Corriente";
					break;
				default:
					itm.SubItems[5].Text = "???";
					break;
			}

                        switch (itm.SubItems[8].Text)
                        {
                                case "0":
                                case "-":
                                case "":
                                        itm.SubItems[8].Text = "Inactiva";
                                        itm.ForeColor = Color.Gray;
                                        break;
                                default:
                                        itm.SubItems[8].Text = "Activa";
                                        break;
                        }

			itm.SubItems[2].Text = this.DataBase.FieldString("SELECT nombre FROM bancos WHERE id_banco=" + Lfx.Types.Parsing.ParseInt(itm.SubItems[2].Text).ToString());

                        int IdCaja = Lfx.Types.Parsing.ParseInt(itm.Text);
                        double Saldo = this.DataBase.FieldDouble("SELECT saldo FROM cajas_movim WHERE id_caja=" + IdCaja.ToString() + " ORDER BY id_movim DESC LIMIT 1");
                        double Pasivos = this.DataBase.FieldDouble("SELECT SUM(importe) FROM bancos_cheques WHERE estado IN (0, 5) AND emitido=1 AND id_chequera IN (SELECT chequeras.id_chequera FROM chequeras WHERE estado=1 AND id_caja=" + IdCaja.ToString() + ")");

			txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtTotal.Text) + Saldo, this.Workspace.CurrentConfig.Moneda.Decimales);
			if (Saldo > 0)
				txtActivos.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtActivos.Text) + Saldo, this.Workspace.CurrentConfig.Moneda.Decimales);
			
                        itm.SubItems[6].Text = Lfx.Types.Formatting.FormatCurrency(Saldo, this.Workspace.CurrentConfig.Moneda.Decimales);
                        itm.SubItems[7].Text = Lfx.Types.Formatting.FormatCurrency(Saldo - Pasivos, this.Workspace.CurrentConfig.Moneda.Decimales);
		}

		public override Lfx.Types.OperationResult OnCreate()
		{
			this.Workspace.RunTime.Execute("CREAR CAJA");
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult OnEdit(int lCodigo)
		{
			if (lCodigo < 1000)
				Lui.Forms.MessageBox.Show("No se puede editar la caja seleccionada", "Caja del Sistema");
			else
				this.Workspace.RunTime.Execute("EDITAR CAJA " + lCodigo.ToString());
			return new Lfx.Types.SuccessOperationResult();
		}

	}
}