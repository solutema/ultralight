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
using System.Windows.Forms;

namespace Lfc.Personas
{
        public partial class Inicio : Lui.Forms.ListingForm
        {
                public int m_Tipo;
                private int m_Ciudad, m_Grupo, m_SubGrupo, m_Situacion, m_EstadoCredito = -1, m_Estado = 1;

                public Inicio()
                {
                        InitializeComponent();

                        DataTableName = "personas";
                        this.Joins.Add(new qGen.Join("personas_grupos", "personas_grupos.id_grupo=personas.id_grupo"));
                        this.Joins.Add(new qGen.Join("ciudades", "personas.id_ciudad=ciudades.id_ciudad"));
                        OrderBy = "personas.nombre_visible";
                        KeyField = new Lfx.Data.FormField("personas.id_persona", "Cód.", Lfx.Data.InputFieldTypes.Serial, 80);
                        FormFields = new List<Lfx.Data.FormField>()
			{
				new Lfx.Data.FormField("personas.nombre_visible", "Nombre", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("personas.telefono", "Teléfono", Lfx.Data.InputFieldTypes.Text, 140),
				new Lfx.Data.FormField("personas.domicilio", "Domicilio", Lfx.Data.InputFieldTypes.Text, 160),
				new Lfx.Data.FormField("personas.num_doc", "Núm. Doc.", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("personas.cuit", "CUIT", Lfx.Data.InputFieldTypes.Text, 120),
                                new Lfx.Data.FormField("personas_grupos.nombre", "Grupo", Lfx.Data.InputFieldTypes.Text, 120),
                                new Lfx.Data.FormField("personas.id_subgrupo", "Sub-grupo", Lfx.Data.InputFieldTypes.Text, 120),
                                new Lfx.Data.FormField("ciudades.nombre", "Ciudad", Lfx.Data.InputFieldTypes.Text, 120),
                                new Lfx.Data.FormField("personas.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 0)
			};
                        ExtraSearchFields = new List<Lfx.Data.FormField>()
			{
				new Lfx.Data.FormField("personas.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("personas.apellido", "Apellido", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("personas.extra1", "Extra 1", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("personas.numerocuenta", "Núm. Cuenta", Lfx.Data.InputFieldTypes.Text, 0)
			};
                }

                public override void ItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        base.ItemAdded(item, row);

                        if (row.Fields["estado"].ValueInt == 0)
                                item.ForeColor = System.Drawing.Color.Gray;

                        string Cuit = row.Fields["cuit"].ValueString;
                        if (Cuit != null && Cuit.Length > 0 && Lfx.Types.Strings.ValidCUIT(Cuit) == false) {
                                item.UseItemStyleForSubItems = false;
                                item.SubItems["cuit"].BackColor = System.Drawing.Color.Pink;
                        }

                        int IdSubGrupo = row.Fields["id_subgrupo"].ValueInt;
                        if (IdSubGrupo != 0) {
                                Lfx.Data.Row SubGrupo = this.DataBase.Tables["personas_grupos"].FastRows[IdSubGrupo];
                                if (SubGrupo != null)
                                        item.SubItems["id_subgrupo"].Text = SubGrupo.Fields["nombre"].ValueString;
                        }
                }

                public override void BeginRefreshList()
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

                        if (m_Ciudad > 0)
                                this.CustomFilters.AddWithValue("(personas.id_ciudad=" + m_Ciudad.ToString() + " OR personas.id_ciudad IS NULL)");

                        if (m_Estado >= 0 && this.SearchText == null)
                                // Sólo filtro por estado si no estoy buscando
                                this.CustomFilters.AddWithValue("personas.estado", m_Estado);

                        // Cargo la tabla en memoria, ya que la voy a usar mucho
                        this.DataBase.Tables["personas_grupos"].PreLoad();
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfc.Personas.Filtros FormFiltros = new Lfc.Personas.Filtros();
                        FormFiltros.EntradaTipo.TextInt = m_Tipo;
                        FormFiltros.EntradaSituacion.TextInt = m_Situacion;
                        FormFiltros.EntradaGrupo.TextInt = m_Grupo;
                        FormFiltros.EntradaSubGrupo.TextInt = m_SubGrupo;
                        FormFiltros.EntradaCiudad.TextInt = m_Ciudad;
                        FormFiltros.EntradaEstado.TextKey = m_Estado.ToString();
                        FormFiltros.EntradaEstadoCredito.TextKey = m_EstadoCredito.ToString();

                        string[] Etiquetas = new string[1];
                        int i = 0;
                        Etiquetas[i++] = "Todas|0";
                        foreach (Lfx.Data.Row Lab in this.DataBase.Tables["sys_labels"].FastRows.Values) {
                                if (Lab["tablas"].ToString() == this.DataTableName) {
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
                                m_Ciudad = FormFiltros.EntradaCiudad.TextInt;
                                m_Estado = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaEstado.TextKey);
                                m_EstadoCredito = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaEstadoCredito.TextKey);
                                if (FormFiltros.EntradaEtiquetas.TextKey == "0")
                                        this.Labels = null;
                                else
                                        this.Labels = new int[] { Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaEtiquetas.TextKey) };
                                
                                FormFiltros = null;
                                this.RefreshList();
                                return new Lfx.Types.SuccessOperationResult();
                        } else {
                                return new Lfx.Types.OperationResult(false);
                        }
                }

                public override Lfx.Types.OperationResult OnCreate()
                {
                        object OFormNuevoCliente = this.Workspace.RunTime.Execute("CREAR CLIENTE");
                        if (m_Tipo > 0 && OFormNuevoCliente != null) {
                                if (OFormNuevoCliente.GetType().ToString() == "Lfc.Personas.Editar")
                                        ((Lfc.Personas.Editar)OFormNuevoCliente).EntradaTipo.TextInt = m_Tipo;
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override Lfx.Types.OperationResult OnEdit(int lCodigo)
                {
                        this.Workspace.RunTime.Execute("EDITAR CLIENTE " + lCodigo.ToString());
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override Lfx.Types.OperationResult OnDelete(int[] itemIds)
                {
                        if (Lui.Login.LoginData.ValidateAccess(Lfx.Workspace.Master.CurrentUser, "people.delete")) {
                                foreach (int IdPersona in itemIds) {
                                        qGen.Update DarDeBaja = new qGen.Update("personas");
                                        DarDeBaja.Fields.AddWithValue("estado", 0);
                                        DarDeBaja.Fields.AddWithValue("fechabaja", qGen.SqlFunctions.Now);
                                        DarDeBaja.WhereClause = new qGen.Where();
                                        DarDeBaja.WhereClause.AddWithValue("id_persona", IdPersona);
                                        DarDeBaja.WhereClause.AddWithValue("estado", 1);
                                        this.DataBase.Execute(DarDeBaja);
                                }
                                this.RefreshList();
                                return base.OnDelete(itemIds);
                        } else {
                                return new Lfx.Types.CancelOperationResult();
                        }
                }
        }
}