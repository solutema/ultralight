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

namespace Lfc.Bancos.Chequeras
{
	public partial class Inicio: Lui.Forms.ListingForm
	{
		private enum Estados
		{
                        Todos = -1,
			FueraDeUso = 0,
			Activas = 1
		}
		
		private Estados m_Estado = Estados.Todos;
                private int m_Banco = 0, m_Cuenta = 0;

                public Inicio()
                {
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                        DataTableName = "chequeras";
                        KeyField = new Lfx.Data.FormField("chequeras.id_chequera", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("chequeras.id_banco", "Banco", Lfx.Data.InputFieldTypes.Relation, 240),
                                new Lfx.Data.FormField("chequeras.prefijo", "Prefijo", Lfx.Data.InputFieldTypes.Integer, 90),
				new Lfx.Data.FormField("chequeras.desde", "Desde", Lfx.Data.InputFieldTypes.Integer, 120),
				new Lfx.Data.FormField("chequeras.hasta", "Hasta", Lfx.Data.InputFieldTypes.Integer, 120),
				new Lfx.Data.FormField("chequeras.id_cuenta", "Cuenta", Lfx.Data.InputFieldTypes.Relation, 240),
				new Lfx.Data.FormField("chequeras.titular", "Titular", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("chequeras.estado", "Estado", Lfx.Data.InputFieldTypes.Text,80),
			};
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfx.Types.OperationResult filtrarReturn = base.OnFilter();
                        if (filtrarReturn.Success == true) {
                                Bancos.Chequeras.Filtros FormularioFiltros = new Bancos.Chequeras.Filtros();
                                FormularioFiltros.Workspace = this.Workspace;
                                FormularioFiltros.EntradaEstado.TextKey = ((int)m_Estado).ToString();
                                FormularioFiltros.EntradaBanco.TextInt = m_Banco;
                                FormularioFiltros.EntradaCuenta.TextInt = m_Cuenta;

                                FormularioFiltros.ShowDialog();
                                if (FormularioFiltros.DialogResult == DialogResult.OK) {
                                        m_Estado = (Estados)Lfx.Types.Parsing.ParseInt(FormularioFiltros.EntradaEstado.TextKey);
                                        m_Banco = FormularioFiltros.EntradaBanco.TextInt;
                                        m_Cuenta = FormularioFiltros.EntradaCuenta.TextInt;
                                        RefreshList();
                                        filtrarReturn.Success = true;
                                } else {
                                        filtrarReturn.Success = false;
                                }
                        }
                        return filtrarReturn;
                }
		
		public override void RefreshList()
		{
			string TextoSql;

                        if (m_Estado == Estados.Todos)
                                TextoSql = "TRUE";
                        else
                                TextoSql = "estado=" + ((int)m_Estado).ToString();
                        
                        if(m_Banco > 0)
                                TextoSql += " AND id_banco=" + m_Banco.ToString();

                        if (m_Cuenta > 0)
                                TextoSql += " AND id_cuenta=" + m_Cuenta.ToString();

			CurrentFilter = TextoSql;
			base.RefreshList();
		}

		public override void ItemAdded(ListViewItem itm)
		{
			switch(itm.SubItems[7].Text)
			{
				case "0":
				case "-":
                                        itm.SubItems[7].Text = "Fuera de uso";
                                        break;
				case "1":
					itm.SubItems[7].Text = "Activa";
					break;
				default:
					itm.SubItems[7].Text = "???";
					break;
			}

                        itm.SubItems[1].Text = this.DataView.Tables["bancos"].FastRows[Lfx.Types.Parsing.ParseInt(itm.SubItems[1].Text)].Fields["nombre"].ToString();
                        itm.SubItems[2].Text = Lfx.Types.Parsing.ParseInt(itm.SubItems[2].Text).ToString("0000");
                        itm.SubItems[3].Text = Lfx.Types.Parsing.ParseInt(itm.SubItems[3].Text).ToString("00000000");
                        itm.SubItems[4].Text = Lfx.Types.Parsing.ParseInt(itm.SubItems[4].Text).ToString("00000000");
                        int IdCuenta = Lfx.Types.Parsing.ParseInt(itm.SubItems[5].Text);
                        if (IdCuenta > 0)
                                itm.SubItems[5].Text = this.DataView.Tables["cuentas"].FastRows[IdCuenta].Fields["nombre"].ToString();
		}

		public override Lfx.Types.OperationResult OnEdit(int lCodigo)
		{
			this.Workspace.RunTime.Execute("EDITAR CHEQUERA " + lCodigo.ToString());
			return new Lfx.Types.SuccessOperationResult();
		}

	}

}
