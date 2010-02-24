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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Tareas
{
	public partial class Inicio : Lui.Forms.ListingForm
	{
		private int m_Tarea, m_Cliente, m_Sucursal;
                private string m_Estado = "sin_entregar";

                public Inicio() : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                        DataTableName = "tickets";
                        this.Joins.Add(new Lfx.Data.Join("personas", "tickets.id_persona=personas.id_persona"));
                        KeyField = new Lfx.Data.FormField("tickets.id_ticket", "Cód.", Lfx.Data.InputFieldTypes.Serial, 64);
                        FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("tickets.nombre", "Asunto", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("tickets.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 96),
				new Lfx.Data.FormField("tickets.fecha_ingreso", "Fecha", Lfx.Data.InputFieldTypes.DateTime, 120),
                                new Lfx.Data.FormField("tickets.id_tecnico_recibe", "Técnico", Lfx.Data.InputFieldTypes.Relation, 160)
			};
                        OrderBy = "tickets.id_ticket DESC";
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
			string TextoSql = "TRUE";
			if (m_Tarea > 0)
				TextoSql += " AND tickets.id_tipo_ticket=" + m_Tarea.ToString();

			if (m_Cliente > 0)
				TextoSql += " AND tickets.id_persona=" + m_Cliente.ToString();

			if (m_Sucursal > 0)
				TextoSql += " AND tickets.id_sucursal=" + m_Sucursal.ToString();

			switch (m_Estado)
			{
				case "0":
					// Nada
					break;
				case "presupuestados":
					TextoSql += " AND tickets.estado=10";
					break;
				case "sin_terminar":
					TextoSql += " AND tickets.estado<30";
					break;
				case "sin_verificar":
					TextoSql += " AND tickets.estado<40";
					break;
				case "sin_entregar":
					TextoSql += " AND tickets.estado<50";
					break;
				default:
					TextoSql += " AND tickets.estado=" + m_Estado.ToString();
					break;
			}

                        // Cargo la tabla en memoria, ya que la voy a usar mucho
                        this.DataView.Tables["tickets_estados"].PreLoad();

			this.CurrentFilter = TextoSql;
			base.BeginRefreshList();
		}


		public override Lfx.Types.OperationResult OnFilter()
		{
			Lfx.Types.OperationResult filtrarReturn = new Lfx.Types.SuccessOperationResult();

			Tareas.Filtros OFormFiltros = new Tareas.Filtros();
			OFormFiltros.Workspace = this.Workspace;
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


		public override void Fill(Lfx.Data.SqlSelectBuilder command)
		{
			base.Fill(command);
			foreach (System.Windows.Forms.ListViewItem itm in Listado.Items)
			{
				int IdEstado = Lfx.Types.Parsing.ParseInt(itm.SubItems[3].Text);
				switch (IdEstado)
				{
					case 0:
						itm.BackColor = System.Drawing.Color.FromArgb(255, 230, 230);
						break;
					case 5:
					case 20:
						itm.BackColor = System.Drawing.Color.FromArgb(240, 255, 240);
						break;
					case 10:
					case 35:
						itm.BackColor = System.Drawing.Color.LightSkyBlue;
						break;
					case 30:
					case 50:
						itm.ForeColor = System.Drawing.Color.Gray;
						break;
					case 90:
						itm.Font = new Font(itm.Font, FontStyle.Strikeout);
						break;
				}

                                Lfx.Data.Row Estado = this.DataView.Tables["tickets_estados"].FastRows[IdEstado];
				if (Estado != null)
					itm.SubItems[3].Text = Estado["nombre"].ToString();

                                Lfx.Data.Row Tecnico = this.DataView.Tables["personas"].FastRows[Lfx.Types.Parsing.ParseInt(itm.SubItems[5].Text)];
                                if (Tecnico != null)
                                        itm.SubItems[5].Text = Tecnico["nombre"].ToString();
			}
		}

		private void FormTicketsInicio_WorkspaceChanged(object sender, System.EventArgs e)
		{
			m_Sucursal = this.Workspace.CurrentConfig.Company.CurrentBranch;
		}
	}
}