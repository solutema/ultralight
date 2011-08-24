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

using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace Lfc.Tareas
{
	public partial class Inicio : Lfc.FormularioListado
	{
                public int Tipo { get; set; }
                public int Grupo { get; set; }
                public int Cliente { get; set; }
                public int Localidad { get; set; }
                [DefaultValue("<50")]
                public string Estado { get; set; }

                protected int Activos;
                protected int Terminados;
                protected int Retrasados;
                protected int Nuevos;
                protected Lbl.ColeccionCodigoDetalle EstadosTickets = null;

                public Inicio()
                {
                        if (this.HasWorkspace) {
                                // Localidad = Lbl.Sys.Config.Actual.Empresa.SucursalPredeterminada.Localidad.Id;
                                EstadosTickets = new Lbl.ColeccionCodigoDetalle(this.Connection.Select("SELECT id_ticket_estado, nombre FROM tickets_estados"));
                        }

                        this.Definicion = new Lbl.Listados.Listado()
                        {
                                ElementoTipo = typeof(Lbl.Tareas.Tarea),

                                NombreTabla = "tickets",
                                Joins = new qGen.JoinCollection() { new qGen.Join("personas", "tickets.id_persona=personas.id_persona") },
                                KeyField = new Lfx.Data.FormField("tickets.id_ticket", "Cód.", Lfx.Data.InputFieldTypes.Serial, 64),

                                FormFields = new Lfx.Data.FormFieldCollection()
			        {
				        new Lfx.Data.FormField("tickets.nombre", "Asunto", Lfx.Data.InputFieldTypes.Text, 320),
				        new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 240),
				        new Lfx.Data.FormField("tickets.estado", "Estado", 160, EstadosTickets),
				        new Lfx.Data.FormField("tickets.fecha_ingreso", "Ingreso", Lfx.Data.InputFieldTypes.DateTime, 160),
                                        new Lfx.Data.FormField("tickets.id_tecnico_recibe", "Encargado", Lfx.Data.InputFieldTypes.Text, 240),
                                        new Lfx.Data.FormField("DATEDIFF(NOW(), tickets.fecha_ingreso) AS fechadiff", "Antigüedad", Lfx.Data.InputFieldTypes.Integer, 60)
			        },
                                OrderBy = "tickets.id_ticket DESC",
                        };

                        this.HabilitarFiltrar = true;
                }


		protected override void OnBeginRefreshList()
		{
                        Activos = 0;
                        Terminados = 0;
                        Retrasados = 0;

                        this.CustomFilters.Clear();

			if (Tipo > 0)
				this.CustomFilters.AddWithValue("tickets.id_tipo_ticket", Tipo);

			if (Cliente > 0)
				this.CustomFilters.AddWithValue("tickets.id_persona", Cliente);

                        if (Grupo > 0)
                                this.CustomFilters.AddWithValue("personas.id_grupo", Grupo);

			if (Localidad > 0)
				this.CustomFilters.AddWithValue("personas.id_ciudad", Localidad);

			switch (this.Estado)
			{
				case "todos":
					// Nada
					break;
				case "<30":
					this.CustomFilters.AddWithValue("tickets.estado<30");
					break;
				case "<35":
					this.CustomFilters.AddWithValue("tickets.estado IN (30, 35)");
					break;
                                case null:
				case "<50":
					this.CustomFilters.AddWithValue("tickets.estado<50");
					break;
				default:
					this.CustomFilters.AddWithValue("tickets.estado", Lfx.Types.Parsing.ParseInt(Estado));
					break;
			}

			base.OnBeginRefreshList();
		}


		public override Lfx.Types.OperationResult OnFilter()
		{
			Lfx.Types.OperationResult filtrarReturn = new Lfx.Types.SuccessOperationResult();

                        using (Tareas.Filtros FormFiltros = new Tareas.Filtros()) {
                                FormFiltros.Connection = this.Connection;
                                FormFiltros.EntradaCliente.TextInt = Cliente;
                                FormFiltros.EntradaGrupo.TextInt = Grupo;
                                FormFiltros.EntradaLocalidad.TextInt = Localidad;
                                FormFiltros.EntradaTarea.TextInt = Tipo;
                                FormFiltros.EntradaEstado.TextKey = Estado;
                                FormFiltros.EntradaOrden.TextKey = this.Definicion.OrderBy;

                                // Agrego los estados de los tickets que figuran en la base de datos
                                string[] SetData1 = FormFiltros.EntradaEstado.SetData;
                                List<string> SetData2 = new List<string>();
                                foreach (string Dat in SetData1) {
                                        SetData2.Add(Dat);
                                }
                                foreach (int IdEstado in EstadosTickets.Keys) {
                                        SetData2.Add(EstadosTickets[IdEstado] + "|" + IdEstado.ToString());
                                }
                                FormFiltros.EntradaEstado.SetData = SetData2.ToArray();

                                if (FormFiltros.ShowDialog() == DialogResult.OK) {
                                        Cliente = FormFiltros.EntradaCliente.TextInt;
                                        Grupo = FormFiltros.EntradaGrupo.TextInt;
                                        Localidad = FormFiltros.EntradaLocalidad.TextInt;
                                        Tipo = FormFiltros.EntradaTarea.TextInt;
                                        Estado = FormFiltros.EntradaEstado.TextKey;
                                        this.Definicion.OrderBy = FormFiltros.EntradaOrden.TextKey;
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
                        int IdEncargado = row.Fields["id_tecnico_recibe"].ValueInt;
                        if (IdEncargado > 0)
                                itm.SubItems["id_tecnico_recibe"].Text = this.Connection.Tables["personas"].FastRows[IdEncargado].Fields["nombre"].ValueString;

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