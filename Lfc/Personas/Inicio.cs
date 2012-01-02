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
using System.Data;
using System.Windows.Forms;

namespace Lfc.Personas
{
        public partial class Inicio : Lfc.FormularioListado
        {
                private int m_Tipo = 1;

                public Lbl.Personas.Grupo Grupo { get; set; }
                public Lbl.Personas.Grupo SubGrupo { get; set; }
                public Lbl.Entidades.Localidad Localidad { get; set; }
                public Lbl.Impuestos.SituacionTributaria Situacion { get; set; }
                public int EstadoCredito { get; set; }
                public int Estado { get; set; }

                private Lfx.Types.DateRange FechaAlta { get; set; }
                private Lfx.Types.DateRange FechaBaja { get; set; }

                public Inicio()
                {
                        Lbl.ColeccionCodigoDetalle SetEstados = new Lbl.ColeccionCodigoDetalle() {
                                { 0, "Inactivo" },
                                { 1, "Normal" }
                        };

                        this.Definicion = new Lazaro.Pres.Listings.Listing()
                        {
                                ElementoTipo = typeof(Lbl.Personas.Persona),

                                TableName = "personas",
                                KeyColumnName = new Lazaro.Pres.Field("personas.id_persona", "Cód.", Lfx.Data.InputFieldTypes.Serial, 80),
                                DetailColumnName = "nombre_visible",
                                Joins = new qGen.JoinCollection() { new qGen.Join("personas_grupos", "personas_grupos.id_grupo=personas.id_grupo"), new qGen.Join("ciudades", "personas.id_ciudad=ciudades.id_ciudad") },
                                OrderBy = "personas.nombre_visible",
                                Columns = new Lazaro.Pres.FieldCollection()
			        {
				        new Lazaro.Pres.Field("personas.nombre_visible", "Nombre", Lfx.Data.InputFieldTypes.Text, 240),
				        new Lazaro.Pres.Field("personas.telefono", "Teléfono", Lfx.Data.InputFieldTypes.Text, 140),
				        new Lazaro.Pres.Field("personas.domicilio", "Domicilio", Lfx.Data.InputFieldTypes.Text, 160),
				        new Lazaro.Pres.Field("personas.num_doc", "Núm. Doc.", Lfx.Data.InputFieldTypes.Text, 120),
				        new Lazaro.Pres.Field("personas.cuit", Lbl.Sys.Config.Actual.Empresa.Pais.ClavePersonasJuridicas.Nombre, Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lazaro.Pres.Field("personas_grupos.nombre", "Grupo", Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lazaro.Pres.Field("personas.id_subgrupo", "Sub-grupo", Lfx.Data.InputFieldTypes.Relation, 120),
                                        new Lazaro.Pres.Field("ciudades.nombre AS ciudad", "Localidad", Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lazaro.Pres.Field("personas.estado", "Estado", 0, SetEstados),
                                        new Lazaro.Pres.Field("personas.fechaalta", "Alta", Lfx.Data.InputFieldTypes.Date, 120),
                                        new Lazaro.Pres.Field("personas.fechabaja", "Baja", Lfx.Data.InputFieldTypes.Date, 120),
                                        new Lazaro.Pres.Field("personas.numerocuenta", "Cuenta", Lfx.Data.InputFieldTypes.Text, 120)
			        },
                                ExtraSearchColumns = new Lazaro.Pres.FieldCollection()
			        {
				        new Lazaro.Pres.Field("personas.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 0),
				        new Lazaro.Pres.Field("personas.apellido", "Apellido", Lfx.Data.InputFieldTypes.Text, 0),
				        new Lazaro.Pres.Field("personas.extra1", "Extra 1", Lfx.Data.InputFieldTypes.Text, 0),
				        new Lazaro.Pres.Field("personas.numerocuenta", "Núm. Cuenta", Lfx.Data.InputFieldTypes.Text, 0)
			        },
                                Filters = new Lazaro.Pres.Filters.FilterCollection()
                                {
                                        new Lazaro.Pres.Filters.SetFilter("Categoría", "personas.tipo", new string[] { "Todos|0", "Clientes|1", "Proveedores|2", "Usuarios del sistema|4" }, "1"),
                                        new Lazaro.Pres.Filters.RelationFilter("Grupo", new Lfx.Data.Relation("personas.id_grupo", "personas_grupos", "id_grupo")),
                                        new Lazaro.Pres.Filters.RelationFilter("Sub-grupo", new Lfx.Data.Relation("personas.id_subgrupo", "personas_grupos", "id_grupo")),
                                        new Lazaro.Pres.Filters.RelationFilter("Situación", new Lfx.Data.Relation("personas.id_situacion", "situaciones", "id_situacion")),
                                        new Lazaro.Pres.Filters.RelationFilter("Localidad", new Lfx.Data.Relation("personas.id_ciudad", "ciudades", "id_ciudad"), new qGen.Where("id_provincia", qGen.ComparisonOperators.NotEquals, null)),
                                        new Lazaro.Pres.Filters.SetFilter("Estado", "personas.estado", new string[] {"Todos|-1", "Activos|1", "Inactivos|0"}, "1"),
                                        new Lazaro.Pres.Filters.SetFilter("Estado de Crédito", "personas.estadocredito", new string[] { "Cualquiera|-1", "Normal|0", "En plan de pagos|5", "Suspendido|10" }, "-1"),
                                        new Lazaro.Pres.Filters.DateRangeFilter("Fecha de Alta", "personas.fechaalta", new Lfx.Types.DateRange("*")),
                                        new Lazaro.Pres.Filters.DateRangeFilter("Fecha de Baja", "personas.fechabaja", new Lfx.Types.DateRange("*"))
                                }
                        };

                        this.HabilitarFiltrar = true;

                        this.Estado = 1;
                        this.EstadoCredito = -1;
                        this.FechaAlta = new Lfx.Types.DateRange("*");
                        this.FechaBaja = new Lfx.Types.DateRange("*");

                        if (this.HasWorkspace) {
                                Lfx.Data.TagCollection Tags = this.Connection.Tables["personas"].Tags;
                                foreach (Lfx.Data.Tag Tg in Tags) {
                                        if (Tg.FieldType == Lfx.Data.DbTypes.Text || Tg.FieldType == Lfx.Data.DbTypes.VarChar)
                                                this.Definicion.ExtraSearchColumns.Add(new Lazaro.Pres.Field(Tg.FieldName, Tg.Label, Tg.InputFieldType));
                                }
                        }
                }


                public Inicio(string comando)
                        : this()
                {
                        this.Tipo = Lfx.Types.Parsing.ParseInt(comando);
                }


                public int Tipo {
                        get
                        {
                                return m_Tipo;
                        }
                        set
                        {
                                m_Tipo = value;
                                this.Definicion.Filters["personas.tipo"].Value = m_Tipo;
                        }
                }



                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        base.OnItemAdded(item, row);

                        if (row.Fields["personas.estado"].ValueInt == 0)
                                item.ForeColor = System.Drawing.Color.Gray;

                        int IdSubGrupo = row.Fields["personas.id_subgrupo"].ValueInt;
                        if (IdSubGrupo != 0) {
                                Lfx.Data.Row SubGrupo = this.Connection.Tables["personas_grupos"].FastRows[IdSubGrupo];
                                if (SubGrupo != null)
                                        item.SubItems["personas.id_subgrupo"].Text = SubGrupo.Fields["personas.nombre"].ValueString;
                        }
                }

                protected override void OnBeginRefreshList()
                {
                        switch (Tipo) {
                                case 1:
                                        this.Text = "Clientes: Listado";
                                        break;
                                case 2:
                                        this.Text = "Proveedores: Listado";
                                        break;
                                case 4:
                                        this.Text = "Usuarios: Listado";
                                        break;
                                default:
                                        this.Text = "Personas: Listado";
                                        break;
                        }

                        this.CustomFilters.Clear();

                        if (Tipo > 0)
                                this.CustomFilters.AddWithValue("(personas.tipo&" + Tipo.ToString() + "=" + Tipo.ToString() + " OR personas.tipo=0)");

                        if (SubGrupo != null)
                                this.CustomFilters.AddWithValue("personas.id_subgrupo", SubGrupo.Id);
                        else if (Grupo != null)
                                this.CustomFilters.AddWithValue("personas.id_grupo", Grupo.Id);

                        if (Situacion != null)
                                this.CustomFilters.AddWithValue("personas.id_situacion", Situacion.Id);

                        if (EstadoCredito >= 0)
                                this.CustomFilters.AddWithValue("personas.estadocredito", EstadoCredito);

                        if (Localidad != null)
                                this.CustomFilters.AddWithValue("personas.id_ciudad", Localidad.Id);

                        if (Estado >= 0)
                                this.CustomFilters.AddWithValue("personas.estado", Estado);

                        if (FechaAlta.HasRange)
                                this.CustomFilters.AddWithValue("fechaalta", FechaAlta.From, FechaAlta.To);

                        if (FechaBaja.HasRange)
                                this.CustomFilters.AddWithValue("fechabaja", FechaBaja.From, FechaBaja.To);

                        // Cargo la tabla en memoria, ya que la voy a usar mucho
                        this.Connection.Tables["personas_grupos"].PreLoad();

                        base.OnBeginRefreshList();
                }


                public override void OnFiltersChanged(Lazaro.Pres.Filters.FilterCollection filters)
                {
                        this.Tipo = Lfx.Types.Parsing.ParseInt(this.Definicion.Filters["personas.tipo"].Value as string);
                        this.Grupo = this.Definicion.Filters["personas.id_grupo"].Value as Lbl.Personas.Grupo;
                        this.SubGrupo = this.Definicion.Filters["personas.id_subgrupo"].Value as Lbl.Personas.Grupo;
                        this.Situacion = this.Definicion.Filters["personas.id_situacion"].Value as Lbl.Impuestos.SituacionTributaria;
                        this.Localidad = this.Definicion.Filters["personas.id_ciudad"].Value as Lbl.Entidades.Localidad;
                        this.Estado = Lfx.Types.Parsing.ParseInt(this.Definicion.Filters["personas.estado"].Value as string);
                        this.EstadoCredito = Lfx.Types.Parsing.ParseInt(this.Definicion.Filters["personas.estadocredito"].Value as string);
                        this.FechaAlta = this.Definicion.Filters["personas.fechaalta"].Value as Lfx.Types.DateRange;
                        this.FechaBaja = this.Definicion.Filters["personas.fechabaja"].Value as Lfx.Types.DateRange;

                        base.OnFiltersChanged(filters);
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