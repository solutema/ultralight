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
using System.Windows.Forms;

namespace Lfc.Tareas
{
	public partial class Inicio : Lui.Forms.ListingForm
	{
		private int m_Tarea, m_Cliente, m_Sucursal;
                private string m_Estado = "sin_entregar";
                private int Activos, Terminados, Retrasados, Nuevos;

                public Inicio()
                {
                        InitializeComponent();

                        DataTableName = "tickets";
                        this.Joins.Add(new qGen.Join("personas", "tickets.id_persona=personas.id_persona"));
                        KeyField = new Lfx.Data.FormField("tickets.id_ticket", "Cód.", Lfx.Data.InputFieldTypes.Serial, 64);
                        FormFields = new List<Lfx.Data.FormField>()
			{
				new Lfx.Data.FormField("tickets.nombre", "Asunto", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("tickets.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 96),
				new Lfx.Data.FormField("tickets.fecha_ingreso", "Fecha", Lfx.Data.InputFieldTypes.DateTime, 120),
                                new Lfx.Data.FormField("DATEDIFF(NOW(), tickets.fecha_ingreso) AS fechadiff", "Tiempo", Lfx.Data.InputFieldTypes.Relation, 160)
			};
                        OrderBy = "tickets.id_ticket DESC";
                        m_Sucursal = this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada;

                        // Cargo la tabla en memoria, ya que la voy a usar mucho
                        this.DataBase.Tables["tickets_estados"].PreLoad();

                        BotonFiltrar.Visible = true;
                }

                public int Tarea
                {
                        get
                        {
                                return m_Tarea;
                        }
                        set
                        {
                                m_Tarea = value;
                        }
                }

		public override Lfx.Types.OperationResult OnCreate()
		{
			this.Workspace.RunTime.Execute("CREAR TICKET");
			return new Lfx.Types.SuccessOperationResult();
		}


		public override Lfx.Types.OperationResult OnEdit(int lCodigo)
		{
			this.Workspace.RunTime.Execute("EDITAR TICKET " + lCodigo.ToString());
			return new Lfx.Types.SuccessOperationResult();
		}


		public override void BeginRefreshList()
		{
                        Activos = 0;
                        Terminados = 0;
                        Retrasados = 0;

                        this.CustomFilters.Clear();

			if (m_Tarea > 0)
				this.CustomFilters.AddWithValue("tickets.id_tipo_ticket", m_Tarea);

			if (m_Cliente > 0)
				this.CustomFilters.AddWithValue("tickets.id_persona", m_Cliente);

			if (m_Sucursal > 0)
				this.CustomFilters.AddWithValue("tickets.id_sucursal", m_Sucursal);

			switch (m_Estado)
			{
				case "todos":
					// Nada
					break;
				case "presupuestados":
					this.CustomFilters.AddWithValue("tickets.estado IN (10, 35)");
					break;
                                case "terminados":
                                        this.CustomFilters.AddWithValue("tickets.estado IN (30, 35, 40)");
                                        break;
				case "sin_terminar":
					this.CustomFilters.AddWithValue("tickets.estado<30");
					break;
				case "sin_verificar":
					this.CustomFilters.AddWithValue("tickets.estado IN (30, 35)");
					break;
				case "sin_entregar":
					this.CustomFilters.AddWithValue("tickets.estado<50");
					break;
				default:
					this.CustomFilters.AddWithValue("tickets.estado", m_Estado);
					break;
			}

			base.BeginRefreshList();
		}

                public override void EndRefreshList()
                {
                        EtiquetaNuevos.Text = Nuevos.ToString() + " nuevos";
                        EtiquetaActivos.Text = Activos.ToString() + " activos";
                        EtiquetaRetrasados.Text = Retrasados.ToString() + " retrasados";
                        EtiquetasTerminados.Text = Terminados.ToString() + " terminados";
                        base.EndRefreshList();
                }


		public override Lfx.Types.OperationResult OnFilter()
		{
			Lfx.Types.OperationResult filtrarReturn = new Lfx.Types.SuccessOperationResult();

			Tareas.Filtros OFormFiltros = new Tareas.Filtros();
			OFormFiltros.txtSucursal.TextInt = m_Sucursal;
			OFormFiltros.txtTarea.TextInt = m_Tarea;
			OFormFiltros.txtCliente.TextInt = m_Cliente;
			OFormFiltros.txtEstado.TextKey = m_Estado;
			OFormFiltros.txtOrden.TextKey = OrderBy;
			if (OFormFiltros.ShowDialog() == DialogResult.OK)
			{
				m_Sucursal = OFormFiltros.txtSucursal.TextInt;
				m_Tarea = OFormFiltros.txtTarea.TextInt;
				m_Cliente = OFormFiltros.txtCliente.TextInt;
				m_Estado = OFormFiltros.txtEstado.TextKey;
				OrderBy = OFormFiltros.txtOrden.TextKey;
				OFormFiltros = null;
				this.RefreshList();
				filtrarReturn.Success = true;
			}
			else
			{
				filtrarReturn.Success = false;
			}
			return filtrarReturn;
		}


                public override void ItemAdded(ListViewItem itm, Lfx.Data.Row row)
                {
                        int IdEstado = row.Fields["estado"].ValueInt;
                        int Dias = row.Fields["fechadiff"].ValueInt;
                        switch (IdEstado) {
                                case 0:
                                case 1:
                                        Nuevos++;
                                        if (Dias > 1) {
                                                itm.ForeColor = Color.Crimson;
                                                Retrasados++;
                                        }
                                        break;
                                case 5:
                                        Activos++;
                                        if (Dias > 3) {
                                                itm.ForeColor = Color.Crimson;
                                                Retrasados++;
                                        }
                                        break;
                                case 10:
                                case 20:
                                        Activos++;
                                        if (Dias > 4) {
                                                itm.ForeColor = Color.Crimson;
                                                Retrasados++;
                                        }
                                        break;
                                case 30:
                                case 35:
                                        itm.ForeColor = Color.DarkGreen;
                                        Terminados++;
                                        break;
                                case 50:
                                        itm.ForeColor = System.Drawing.Color.Gray;
                                        break;
                                case 80:
                                case 90:
                                        itm.Font = new Font(itm.Font, FontStyle.Strikeout);
                                        break;
                        }

                        Lfx.Data.Row Estado = this.DataBase.Tables["tickets_estados"].FastRows[IdEstado];
                        if (Estado != null)
                                itm.SubItems["estado"].Text = Estado.Fields["nombre"].ValueString;

                }
	}
}