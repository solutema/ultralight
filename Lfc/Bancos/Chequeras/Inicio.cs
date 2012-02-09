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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Bancos.Chequeras
{
	public partial class Inicio: Lfc.FormularioListado
	{
		private enum Estados
		{
                        Todos = -1,
			FueraDeUso = 0,
			Activas = 1
		}
		
		private Estados m_Estado = Estados.Todos;
                private int m_Banco = 0, m_Caja = 0;

                public Inicio()
                {
                        this.Definicion = new Lazaro.Pres.Listings.Listing()
                        {
                                ElementoTipo = typeof(Lbl.Bancos.Chequera),

                                TableName = "chequeras",
                                KeyColumn = new Lazaro.Pres.Field("chequeras.id_chequera", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                Columns = new Lazaro.Pres.FieldCollection()
			        {
				        new Lazaro.Pres.Field("bancos.nombre", "Banco", 240, new Lfx.Data.Relation("chequeras.id_banco", "bancos", "id_banco")),
                                        new Lazaro.Pres.Field("chequeras.cheques_emitidos", "Emitidos", Lfx.Data.InputFieldTypes.Integer, 90),
				        new Lazaro.Pres.Field("chequeras.desde", "Desde", Lfx.Data.InputFieldTypes.Integer, 120),
				        new Lazaro.Pres.Field("chequeras.hasta", "Hasta", Lfx.Data.InputFieldTypes.Integer, 120),
				        new Lazaro.Pres.Field("cajas.nombre", "Caja", 240, new Lfx.Data.Relation("chequeras.id_caja", "cajas", "id_caja")),
				        new Lazaro.Pres.Field("chequeras.titular", "Titular", Lfx.Data.InputFieldTypes.Text, 240),
				        new Lazaro.Pres.Field("chequeras.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 80),
			        }
                        };
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfx.Types.OperationResult filtrarReturn = base.OnFilter();
                        if (filtrarReturn.Success == true) {
                                using (Bancos.Chequeras.Filtros FormFiltros = new Bancos.Chequeras.Filtros()) {
                                        FormFiltros.Connection = this.Connection;
                                        FormFiltros.EntradaEstado.TextKey = ((int)m_Estado).ToString();
                                        FormFiltros.EntradaBanco.TextInt = m_Banco;
                                        FormFiltros.EntradaCaja.TextInt = m_Caja;

                                        FormFiltros.ShowDialog();
                                        if (FormFiltros.DialogResult == DialogResult.OK) {
                                                m_Estado = (Estados)Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaEstado.TextKey);
                                                m_Banco = FormFiltros.EntradaBanco.TextInt;
                                                m_Caja = FormFiltros.EntradaCaja.TextInt;
                                                RefreshList();
                                                filtrarReturn.Success = true;
                                        } else {
                                                filtrarReturn.Success = false;
                                        }
                                }
                        }
                        return filtrarReturn;
                }

                protected override void OnBeginRefreshList()
                {
                        this.CustomFilters = new qGen.Where();

                        if (m_Estado != Estados.Todos)
                                this.CustomFilters.AddWithValue("chequeras.estado", (int)m_Estado);

                        if (m_Banco > 0)
                                this.CustomFilters.AddWithValue("chequeras.id_banco", m_Banco);

                        if (m_Caja > 0)
                                this.CustomFilters.AddWithValue("chequeras.id_caja", m_Caja);

                        base.OnBeginRefreshList();
                }

                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
		{
			switch(row.Fields["chequeras.estado"].ValueInt)
			{
				case 0:
                                        item.SubItems["chequeras.estado"].Text = "Fuera de uso";
                                        break;
				case 1:
                                        item.SubItems["chequeras.estado"].Text = "Activa";
					break;
				default:
                                        item.SubItems["chequeras.estado"].Text = "???";
					break;
			}

                        item.SubItems["chequeras.desde"].Text = row.Fields["chequeras.desde"].ValueInt.ToString("00000000");
                        item.SubItems["chequeras.hasta"].Text = row.Fields["chequeras.hasta"].ValueInt.ToString("00000000");
                        /* item.SubItems["chequeras.id_banco"].Text = this.Connection.Tables["bancos"].FastRows[System.Convert.ToInt32(row["chequeras.id_banco"])].Fields["nombre"].ToString();
                        int IdCaja = row.Fields["id_caja"].ValueInt;
                        if (IdCaja > 0)
                                item.SubItems["chequeras.id_caja"].Text = this.Connection.Tables["cajas"].FastRows[IdCaja].Fields["nombre"].ToString();
                         * */
		}
	}

}
