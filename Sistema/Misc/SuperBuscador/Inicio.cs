// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lazaro.Misc.SuperBuscador
{
        public partial class Inicio : Lui.Forms.ChildForm
        {
                public Inicio()
                {
                        InitializeComponent();
                }

                internal void Buscar(string Texto)
                {
                        string ValorABuscar = "%" + Texto.Trim().ToLower() + "%";

                        Lfx.Data.SqlWhereBuilder ComandoWhere = null;

                        this.SuspendLayout();

                        PanelResultados.Controls.Clear();

                        ComandoWhere = new Lfx.Data.SqlWhereBuilder();
                        ComandoWhere.AndOr = Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandOr;
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("nombre_visible", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("num_doc", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("cuit", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("domicilio", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("telefono", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("email", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("obs", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        BuscarPersonas(PanelResultados, ComandoWhere, 0);

                        ComandoWhere = new Lfx.Data.SqlWhereBuilder();
                        ComandoWhere.AndOr = Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandOr;
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("nombre", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("codigo1", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("codigo2", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("codigo3", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("codigo4", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("descripcion", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("descripcion2", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("obs", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("modelo", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("serie", Lfx.Data.SqlCommandBuilder.SqlOperands.SoundsLike, ValorABuscar));
                        BuscarArticulos(PanelResultados, ComandoWhere, 0);

                        this.ResumeLayout();
                }


                internal int BuscarPersonas(FlowLayoutPanel controlDestino, Lfx.Data.SqlWhereBuilder comandoWhere, int sangria)
                {
                        Lfx.Data.SqlSelectBuilder ComandoSelect = new Lfx.Data.SqlSelectBuilder();
                        ComandoSelect = new Lfx.Data.SqlSelectBuilder(this.DataView.DataBase.SqlMode);
                        ComandoSelect.Tables = "personas";
                        ComandoSelect.Order = "nombre_visible";
                        if (sangria > 1)
                                ComandoSelect.Limit = 10;
                        else
                                ComandoSelect.Limit = 100;

                        ComandoSelect.WhereClause = comandoWhere;

                        DataTable Tabla = this.DataView.DataBase.Select(ComandoSelect.ToString());

                        int CantidadRegistros = 0;
                        foreach (System.Data.DataRow Persona in Tabla.Rows) {
                                Resultado Res = new Resultado();
                                Res.Codigo = System.Convert.ToInt32(Persona["id_persona"]);
                                Res.Text = Persona["nombre_visible"].ToString();
                                string Detalles = "";
                                if (Persona["domicilio"].ToString().Length > 0)
                                        Detalles += Persona["domicilio"].ToString();
                                if (Persona["telefono"].ToString().Length > 0) {
                                        if (Detalles.Length > 0)
                                                Detalles += System.Environment.NewLine;
                                        Detalles += Persona["telefono"].ToString();
                                }
                                Res.Detalles = Detalles;
                                AgregarResultado(controlDestino, Res, sangria);
                                CantidadRegistros++;

                                //Comprobantes de esta persona
                                Lfx.Data.SqlWhereBuilder ComandoWhere = new Lfx.Data.SqlWhereBuilder();
                                ComandoWhere.AndOr = Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandOr;
                                ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("id_cliente", Res.Codigo));
                                ComandoWhere.Conditions.Add(new Lfx.Data.SqlCondition("id_vendedor", Res.Codigo));
                                BuscarComprobantes(PanelResultados, ComandoWhere, sangria + 1);

                        }
                        return CantidadRegistros;
                }

                private void AgregarResultado(FlowLayoutPanel controlDestino, Resultado res, int sangria)
                {
                        res.Sangria = sangria;
                        res.Width = PanelResultados.Width - res.Left - 24;
                        res.Anchor = AnchorStyles.Right;
                        controlDestino.Controls.Add(res);
                }

                internal int BuscarArticulos(FlowLayoutPanel controlDestino, Lfx.Data.SqlWhereBuilder comandoWhere, int sangria)
                {
                        Lfx.Data.SqlSelectBuilder ComandoSelect = new Lfx.Data.SqlSelectBuilder();
                        ComandoSelect = new Lfx.Data.SqlSelectBuilder(this.DataView.DataBase.SqlMode);
                        ComandoSelect.Tables = "articulos";
                        ComandoSelect.Order = "nombre";
                        if (sangria > 1)
                                ComandoSelect.Limit = 10;
                        else
                                ComandoSelect.Limit = 100;

                        ComandoSelect.WhereClause = comandoWhere;

                        DataTable Tabla = this.DataView.DataBase.Select(ComandoSelect.ToString());

                        int CantidadRegistros = 0;
                        foreach (System.Data.DataRow Persona in Tabla.Rows) {
                                Resultado Res = new Resultado();
                                Res.Codigo = System.Convert.ToInt32(Persona["id_articulo"]);
                                Res.Text = Persona["nombre"].ToString();
                                Res.Detalles = Persona["descripcion"].ToString();
                                AgregarResultado(controlDestino, Res, sangria);
                                CantidadRegistros++;
                        }
                        return CantidadRegistros;
                }

                internal int BuscarComprobantes(FlowLayoutPanel controlDestino, Lfx.Data.SqlWhereBuilder comandoWhere, int sangria)
                {
                        Lfx.Data.SqlSelectBuilder ComandoSelect = new Lfx.Data.SqlSelectBuilder();
                        ComandoSelect = new Lfx.Data.SqlSelectBuilder(this.DataView.DataBase.SqlMode);
                        ComandoSelect.Tables = "facturas";
                        ComandoSelect.Order = "fecha DESC";
                        if (sangria > 1)
                                ComandoSelect.Limit = 10;
                        else
                                ComandoSelect.Limit = 100;

                        ComandoSelect.WhereClause = comandoWhere;

                        DataTable Tabla = this.DataView.DataBase.Select(ComandoSelect.ToString());

                        int CantidadRegistros = 0;
                        foreach (System.Data.DataRow Item in Tabla.Rows) {
                                Resultado Res = new Resultado();
                                Res.Codigo = System.Convert.ToInt32(Item["id_factura"]);
                                Res.Text = "Comprob. " + Item["tipo_fac"].ToString() + " " + System.Convert.ToInt32(Item["pv"]).ToString("0000") + "-" + System.Convert.ToInt32(Item["numero"]).ToString("00000000") + " del " + System.Convert.ToDateTime(Item["fecha"]).ToString(Lfx.Types.Formatting.DateTime.LongDateFormat);
                                AgregarResultado(controlDestino, Res, sangria);
                                CantidadRegistros++;
                        }
                        return CantidadRegistros;
                }

                private void BotonBuscar_Click(object sender, EventArgs e)
                {
                        this.Buscar(TextoBuscar.Text);
                }

                private void TextoBuscar_TextChanged(object sender, EventArgs e)
                {
                        BotonBuscar.Enabled = TextoBuscar.Text.Length > 3;
                }

        }
}