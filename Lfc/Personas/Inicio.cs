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
using System.Data;
using System.Windows.Forms;

namespace Lfc.Personas
{
        public partial class Inicio : Lfc.FormularioListado
        {
                public int m_Tipo;
                private int m_Localidad, m_Grupo, m_SubGrupo, m_Situacion, m_EstadoCredito = -1, m_Estado = 1;

                private string m_FechaAUsar = "fechaalta";
                private Lfx.Types.DateRange m_Fechas = new Lfx.Types.DateRange("*");

                public Inicio()
                {
                        this.Definicion = new Lfx.Data.Listing()
                        {
                                ElementoTipo = typeof(Lbl.Personas.Persona),

                                TableName = "personas",
                                KeyColumnName = new Lfx.Data.FormField("personas.id_persona", "Cód.", Lfx.Data.InputFieldTypes.Serial, 80),
                                DetailColumnName = "nombre_visible",
                                Joins =  new qGen.JoinCollection() { new qGen.Join("personas_grupos", "personas_grupos.id_grupo=personas.id_grupo"), new qGen.Join("ciudades", "personas.id_ciudad=ciudades.id_ciudad") },
                                OrderBy = "personas.nombre_visible",
                                Columns = new Lfx.Data.FormFieldCollection()
			        {
				        new Lfx.Data.FormField("personas.nombre_visible", "Nombre", Lfx.Data.InputFieldTypes.Text, 240),
				        new Lfx.Data.FormField("personas.telefono", "Teléfono", Lfx.Data.InputFieldTypes.Text, 140),
				        new Lfx.Data.FormField("personas.domicilio", "Domicilio", Lfx.Data.InputFieldTypes.Text, 160),
				        new Lfx.Data.FormField("personas.num_doc", "Núm. Doc.", Lfx.Data.InputFieldTypes.Text, 120),
				        new Lfx.Data.FormField("personas.cuit", "CUIT", Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lfx.Data.FormField("personas_grupos.nombre", "Grupo", Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lfx.Data.FormField("personas.id_subgrupo", "Sub-grupo", Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lfx.Data.FormField("ciudades.nombre AS ciudad", "Localidad", Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lfx.Data.FormField("personas.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 0),
                                        new Lfx.Data.FormField("personas.fechaalta", "Alta", Lfx.Data.InputFieldTypes.Date, 120),
                                        new Lfx.Data.FormField("personas.fechabaja", "Baja", Lfx.Data.InputFieldTypes.Date, 120)
			        },
                                ExtraSearchColumns = new Lfx.Data.FormFieldCollection()
			        {
				        new Lfx.Data.FormField("personas.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 0),
				        new Lfx.Data.FormField("personas.apellido", "Apellido", Lfx.Data.InputFieldTypes.Text, 0),
				        new Lfx.Data.FormField("personas.extra1", "Extra 1", Lfx.Data.InputFieldTypes.Text, 0),
				        new Lfx.Data.FormField("personas.numerocuenta", "Núm. Cuenta", Lfx.Data.InputFieldTypes.Text, 0)
			        }
                        };

                        this.HabilitarFiltrar = true;
                }

                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        base.OnItemAdded(item, row);

                        if (row.Fields["personas.estado"].ValueInt == 0)
                                item.ForeColor = System.Drawing.Color.Gray;

                        string Cuit = row.Fields["personas.cuit"].ValueString;
                        if (Cuit != null && Cuit.Length > 0 && Lfx.Types.Strings.EsCuitValido(Cuit) == false) {
                                item.UseItemStyleForSubItems = false;
                                item.SubItems["personas.cuit"].BackColor = System.Drawing.Color.Pink;
                        }

                        int IdSubGrupo = row.Fields["personas.id_subgrupo"].ValueInt;
                        if (IdSubGrupo != 0) {
                                Lfx.Data.Row SubGrupo = this.Connection.Tables["personas_grupos"].FastRows[IdSubGrupo];
                                if (SubGrupo != null)
                                        item.SubItems["personas.id_subgrupo"].Text = SubGrupo.Fields["personas.nombre"].ValueString;
                        }
                }

                protected override void OnBeginRefreshList()
                {
                        switch (m_Tipo) {
                                case 1:
                                        this.Text = "Clientes: Listado";
                                        break;
                                case 2:
                                        this.Text = "Proveedores: Listado";
                                        break;
                                default:
                                        this.Text = "Personas: Listado";
                                        break;
                        }

                        this.CustomFilters.Clear();

                        if (m_Tipo > 0)
                                this.CustomFilters.AddWithValue("(personas.tipo&" + m_Tipo.ToString() + "=" + m_Tipo.ToString() + " OR personas.tipo=0)");

                        if (m_SubGrupo > 0)
                                this.CustomFilters.AddWithValue("personas.id_subgrupo", m_SubGrupo);
                        else if (m_Grupo > 0)
                                this.CustomFilters.AddWithValue("personas.id_grupo", m_Grupo);

                        if (m_Situacion > 0)
                                this.CustomFilters.AddWithValue("personas.id_situacion", m_Situacion);

                        if (m_EstadoCredito >= 0)
                                this.CustomFilters.AddWithValue("personas.estadocredito", m_EstadoCredito);

                        if (m_Localidad > 0)
                                this.CustomFilters.AddWithValue("(personas.id_ciudad=" + m_Localidad.ToString() + " OR personas.id_ciudad IS NULL)");

                        if (m_Estado >= 0 && this.SearchText == null)
                                // Sólo filtro por estado si no estoy buscando
                                this.CustomFilters.AddWithValue("personas.estado", m_Estado);

                        if (m_Fechas.HasRange)
                                this.CustomFilters.AddWithValue(m_FechaAUsar, m_Fechas.From, m_Fechas.To);

                        // Cargo la tabla en memoria, ya que la voy a usar mucho
                        this.Connection.Tables["personas_grupos"].PreLoad();
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        using (Lfc.Personas.Filtros FormFiltros = new Lfc.Personas.Filtros()) {
                                FormFiltros.Connection = this.Connection;
                                FormFiltros.EntradaTipo.TextInt = m_Tipo;
                                FormFiltros.EntradaSituacion.TextInt = m_Situacion;
                                FormFiltros.EntradaGrupo.TextInt = m_Grupo;
                                FormFiltros.EntradaSubGrupo.TextInt = m_SubGrupo;
                                FormFiltros.EntradaLocalidad.TextInt = m_Localidad;
                                FormFiltros.EntradaEstado.TextKey = m_Estado.ToString();
                                FormFiltros.EntradaEstadoCredito.TextKey = m_EstadoCredito.ToString();
                                FormFiltros.EntradaFechaAUsar.TextKey = m_FechaAUsar;
                                FormFiltros.EntradaFechas.Rango = m_Fechas;

                                string[] Etiquetas = new string[1];
                                int i = 0;
                                Etiquetas[i++] = "Todas|0";
                                foreach (Lfx.Data.Row Lab in this.Connection.Tables["sys_labels"].FastRows.Values) {
                                        if (Lab["tablas"].ToString() == this.Definicion.TableName) {
                                                if (Etiquetas.Length < (i + 1))
                                                        Array.Resize<string>(ref Etiquetas, i + 2);

                                                Etiquetas[i++] = Lab["nombre"].ToString() + "|" + Lab["id_label"].ToString();
                                                Etiquetas[i++] = "No " + Lab["nombre"].ToString() + "|" + (-((int)(Lab["id_label"]))).ToString();
                                        }
                                }
                                FormFiltros.EntradaEtiquetas.SetData = Etiquetas;
                                if (this.Labels != null && this.Labels.Length > 0)
                                        FormFiltros.EntradaEtiquetas.TextKey = this.Labels[0].ToString();

                                if (FormFiltros.ShowDialog() == DialogResult.OK) {
                                        m_Tipo = FormFiltros.EntradaTipo.TextInt;
                                        m_Situacion = FormFiltros.EntradaSituacion.TextInt;
                                        m_Grupo = FormFiltros.EntradaGrupo.TextInt;
                                        m_SubGrupo = FormFiltros.EntradaSubGrupo.TextInt;
                                        m_Localidad = FormFiltros.EntradaLocalidad.TextInt;
                                        m_Estado = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaEstado.TextKey);
                                        m_EstadoCredito = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaEstadoCredito.TextKey);
                                        if (FormFiltros.EntradaEtiquetas.TextKey == "0")
                                                this.Labels = null;
                                        else
                                                this.Labels = new int[] { Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaEtiquetas.TextKey) };
                                        m_FechaAUsar = FormFiltros.EntradaFechaAUsar.TextKey;
                                        m_Fechas = FormFiltros.EntradaFechas.Rango;

                                        this.RefreshList();
                                        return new Lfx.Types.SuccessOperationResult();
                                } else {
                                        return new Lfx.Types.OperationResult(false);
                                }
                        }
                }

                public override Lfx.Types.OperationResult OnDelete(Lbl.ListaIds itemIds)
                {
                        IDbTransaction Trans = this.Connection.BeginTransaction();
                        foreach (int IdPersona in itemIds) {
                                qGen.Update DarDeBaja = new qGen.Update("personas");
                                DarDeBaja.Fields.AddWithValue("estado", 0);
                                DarDeBaja.Fields.AddWithValue("fechabaja", qGen.SqlFunctions.Now);
                                DarDeBaja.WhereClause = new qGen.Where();
                                DarDeBaja.WhereClause.AddWithValue("id_persona", IdPersona);
                                DarDeBaja.WhereClause.AddWithValue("estado", 1);
                                this.Connection.Execute(DarDeBaja);
                        }
                        Trans.Commit();
                        this.RefreshList();
                        return base.OnDelete(itemIds);
                }
        }
}