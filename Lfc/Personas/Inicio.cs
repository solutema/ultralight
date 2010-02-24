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

namespace Lfc.Personas
{
        public partial class Inicio : Lui.Forms.ListingForm
        {
                public int m_Tipo;
                private int m_Ciudad, m_Grupo, m_SubGrupo, m_Situacion, m_EstadoCredito = -1;

                public Inicio()
                {
                        InitializeComponent();

                        DataTableName = "personas";
                        this.Joins.Add(new Lfx.Data.Join("personas_grupos", "personas_grupos.id_grupo=personas.id_grupo"));
                        this.Joins.Add(new Lfx.Data.Join("ciudades", "personas.id_ciudad=ciudades.id_ciudad"));
                        OrderBy = "personas.nombre_visible";
                        KeyField = new Lfx.Data.FormField("personas.id_persona", "Cód.", Lfx.Data.InputFieldTypes.Serial, 80);
                        FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("personas.nombre_visible", "Nombre", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("personas.telefono", "Teléfono", Lfx.Data.InputFieldTypes.Text, 140),
				new Lfx.Data.FormField("personas.domicilio", "Domicilio", Lfx.Data.InputFieldTypes.Text, 160),
				new Lfx.Data.FormField("personas.num_doc", "Núm. Doc.", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("personas.cuit", "CUIT", Lfx.Data.InputFieldTypes.Text, 120),
                                new Lfx.Data.FormField("personas_grupos.nombre", "Grupo", Lfx.Data.InputFieldTypes.Text, 120),
                                new Lfx.Data.FormField("personas.id_subgrupo", "Sub-grupo", Lfx.Data.InputFieldTypes.Text, 120),
                                new Lfx.Data.FormField("ciudades.nombre", "Ciudad", Lfx.Data.InputFieldTypes.Text, 120)
			};
                        ExtraSearchFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("personas.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("personas.apellido", "Apellido", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("personas.extra1", "Extra 1", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("personas.numerocuenta", "Núm. Cuenta", Lfx.Data.InputFieldTypes.Text, 0)
			};
                }

                public override void ItemAdded(ListViewItem item)
                {
                        if (item.SubItems[5].Text.Length > 0 && Lfx.Types.Strings.ValidCUIT(item.SubItems[5].Text) == false) {
                                item.UseItemStyleForSubItems = false;
                                item.SubItems[5].BackColor = System.Drawing.Color.Pink;
                        }

                        int IdSubGrupo = Lfx.Types.Parsing.ParseInt(item.SubItems[7].Text);
                        if (IdSubGrupo != 0) {
                                Lfx.Data.Row SubGrupo = this.DataView.Tables["personas_grupos"].FastRows[IdSubGrupo];
                                if (SubGrupo != null)
                                        item.SubItems[7].Text = SubGrupo["nombre"].ToString();
                        }
                        base.ItemAdded(item);
                }

                public override void RefreshList()
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

                        string TextoSql = "TRUE";

                        if (m_Tipo > 0)
                                TextoSql += " AND (personas.tipo&" + m_Tipo.ToString() + "=" + m_Tipo.ToString() + " OR personas.tipo=0)";

                        if (m_SubGrupo > 0)
                                TextoSql += " AND personas.id_subgrupo=" + m_SubGrupo.ToString();
                        else if (m_Grupo > 0)
                                TextoSql += " AND personas.id_grupo=" + m_Grupo.ToString();

                        if (m_Situacion > 0)
                                TextoSql += " AND personas.id_situacion=" + m_Situacion.ToString();

                        if (m_EstadoCredito >= 0)
                                TextoSql += " AND personas.estadocredito=" + m_EstadoCredito.ToString();

                        if (m_Ciudad > 0)
                                TextoSql += " AND (personas.id_ciudad=" + m_Ciudad.ToString() + " OR personas.id_ciudad IS NULL)";

                        CurrentFilter = TextoSql;

                        // Cargo la tabla en memoria, ya que la voy a usar mucho
                        this.DataView.Tables["personas_grupos"].PreLoad();

                        base.RefreshList();
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfc.Personas.Filtros FormFiltros = new Lfc.Personas.Filtros();
                        FormFiltros.Workspace = this.Workspace;
                        FormFiltros.EntradaTipo.TextInt = m_Tipo;
                        FormFiltros.EntradaSituacion.TextInt = m_Situacion;
                        FormFiltros.EntradaGrupo.TextInt = m_Grupo;
                        FormFiltros.EntradaSubGrupo.TextInt = m_SubGrupo;
                        FormFiltros.EntradaCiudad.TextInt = m_Ciudad;
                        FormFiltros.EntradaEstadoCredito.TextKey = m_EstadoCredito.ToString();

                        string[] Etiquetas = new string[1];
                        int i = 0;
                        Etiquetas[i++] = "Todas|0";
                        foreach (Lfx.Data.Row Lab in this.DataView.Tables["sys_labels"].FastRows.Values) {
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
                        if (m_Tipo > 0) {
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
        }
}