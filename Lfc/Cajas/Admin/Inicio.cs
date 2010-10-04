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

                        Dictionary<int, string> SetTipos = new Dictionary<int, string>()
                        {
                                {0, "Efectivo"},
                                {1, "Caja de Ahorro"},
                                {2, "Cuenta Corriente"}
                        };

                        Dictionary<int, string> SetEstados = new Dictionary<int, string>()
                        {
                                {0, "Inactiva"},
                                {1, "Activa"}
                        };

                        FormFields = new List<Lfx.Data.FormField>()
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
                }

		public override void BeginRefreshList()
		{
			EntradaTotal.Text = "0";
			EntradaActivos.Text = "0";
		}

                public override void ItemAdded(ListViewItem itm, Lfx.Data.Row row)
		{
			itm.SubItems["id_banco"].Text = this.DataBase.FieldString("SELECT nombre FROM bancos WHERE id_banco=" + Lfx.Types.Parsing.ParseInt(itm.SubItems[2].Text).ToString());

                        int IdCaja = Lfx.Types.Parsing.ParseInt(itm.Text);
                        double Saldo = this.DataBase.FieldDouble("SELECT saldo FROM cajas_movim WHERE id_caja=" + IdCaja.ToString() + " ORDER BY id_movim DESC LIMIT 1");
                        double Pasivos = this.DataBase.FieldDouble("SELECT SUM(importe) FROM bancos_cheques WHERE estado IN (0, 5) AND emitido=1 AND id_chequera IN (SELECT chequeras.id_chequera FROM chequeras WHERE estado=1 AND id_caja=" + IdCaja.ToString() + ")");

			EntradaTotal.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text) + Saldo, this.Workspace.CurrentConfig.Moneda.Decimales);
			if (Saldo > 0)
				EntradaActivos.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(EntradaActivos.Text) + Saldo, this.Workspace.CurrentConfig.Moneda.Decimales);
			
                        itm.SubItems["0"].Text = Lfx.Types.Formatting.FormatCurrency(Saldo, this.Workspace.CurrentConfig.Moneda.Decimales);
                        itm.SubItems["1"].Text = Lfx.Types.Formatting.FormatCurrency(Saldo - Pasivos, this.Workspace.CurrentConfig.Moneda.Decimales);
		}

		public override Lfx.Types.OperationResult OnCreate()
		{
                        if (Lui.Login.LoginData.ValidateAccess(Lfx.Workspace.Master.CurrentUser, "global.admin")) {
                                this.Workspace.RunTime.Execute("CREAR CAJA");
                                return new Lfx.Types.SuccessOperationResult();
                        } else {
                                return new Lfx.Types.NoAccessOperationResult();
                        }
		}


		public override Lfx.Types.OperationResult OnEdit(int lCodigo)
		{
                        if (Lui.Login.LoginData.ValidateAccess(Lfx.Workspace.Master.CurrentUser, "global.admin")) {
                                if (lCodigo < 1000) {
                                        return new Lfx.Types.FailureOperationResult("No se puede editar la caja seleccionada");
                                } else {
                                        this.Workspace.RunTime.Execute("EDITAR CAJA " + lCodigo.ToString());
                                        return new Lfx.Types.SuccessOperationResult();
                                }
                        } else {
                                return new Lfx.Types.NoAccessOperationResult();
                        }
		}

	}
}