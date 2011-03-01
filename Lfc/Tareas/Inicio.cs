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
using System.Windows.Forms;

namespace Lfc.Tareas
{
	public partial class Inicio : Lfc.FormularioListado
	{
		private int m_Tipo, m_Cliente, m_Sucursal;
                private string m_Estado = "sin_entregar";
                private int Activos, Terminados, Retrasados, Nuevos;

                public Inicio()
                {
                        this.ElementoTipo = typeof(Lbl.Tareas.Tarea);

                        this.NombreTabla = "tickets";
                        this.Joins.Add(new qGen.Join("personas", "tickets.id_persona=personas.id_persona"));
                        this.KeyField = new Lfx.Data.FormField("tickets.id_ticket", "Cód.", Lfx.Data.InputFieldTypes.Serial, 64);

                        Lbl.ColeccionCodigoDetalle EstadosTickets = null;
                        if (this.HasWorkspace) {
                                m_Sucursal = this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada;
                                EstadosTickets = new Lbl.ColeccionCodigoDetalle(this.Connection.Select("SELECT id_ticket_estado, nombre FROM tickets_estados"));
                        }

                        this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("tickets.nombre", "Asunto", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("tickets.estado", "Estado", 160, EstadosTickets),
				new Lfx.Data.FormField("tickets.fecha_ingreso", "Ingreso", Lfx.Data.InputFieldTypes.DateTime, 160),
                                new Lfx.Data.FormField("DATEDIFF(NOW(), tickets.fecha_ingreso) AS fechadiff", "Antigüedad", Lfx.Data.InputFieldTypes.Integer, 60)
			};
                        this.OrderBy = "tickets.id_ticket DESC";
                        this.HabilitarFiltrar = true;
                }

                public int Tipo
                {
                        get
                        {
                                return m_Tipo;
                        }
                        set
                        {
                                m_Tipo = value;
                        }
                }

		protected override void OnBeginRefreshList()
		{
                        Activos = 0;
                        Terminados = 0;
                        Retrasados = 0;

                        this.CustomFilters.Clear();

			if (m_Tipo > 0)
				this.CustomFilters.AddWithValue("tickets.id_tipo_ticket", m_Tipo);

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

			base.OnBeginRefreshList();
		}

                protected override void OnEndRefreshList()
                {
                        // EtiquetaNuevos.Text = Nuevos.ToString() + " nuevos";
                        // EtiquetaActivos.Text = Activos.ToString() + " activos";
                        // EtiquetaRetrasados.Text = Retrasados.ToString() + " retrasados";
                        // EtiquetasTerminados.Text = Terminados.ToString() + " terminados";
                        base.OnEndRefreshList();
                }


		public override Lfx.Types.OperationResult OnFilter()
		{
			Lfx.Types.OperationResult filtrarReturn = new Lfx.Types.SuccessOperationResult();

                        using (Tareas.Filtros FormFiltros = new Tareas.Filtros()) {
                                FormFiltros.Connection = this.Connection;
                                FormFiltros.EntradaSucursal.TextInt = m_Sucursal;
                                FormFiltros.EntradaTarea.TextInt = m_Tipo;
                                FormFiltros.EntradaCliente.TextInt = m_Cliente;
                                FormFiltros.EntradaEstado.TextKey = m_Estado;
                                FormFiltros.EntradaOrden.TextKey = OrderBy;
                                if (FormFiltros.ShowDialog() == DialogResult.OK) {
                                        m_Sucursal = FormFiltros.EntradaSucursal.TextInt;
                                        m_Tipo = FormFiltros.EntradaTarea.TextInt;
                                        m_Cliente = FormFiltros.EntradaCliente.TextInt;
                                        m_Estado = FormFiltros.EntradaEstado.TextKey;
                                        OrderBy = FormFiltros.EntradaOrden.TextKey;
                                        this.RefreshList();
                                        filtrarReturn.Success = true;
                                } else {
                                        filtrarReturn.Success = false;
                                }
                        }
			return filtrarReturn;
		}


                protected override void OnItemAdded(ListViewItem itm, Lfx.Data.Row row)
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
                }
	}
}