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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Cajas
{
        public partial class Diaria : Lfc.FormularioCuenta
        {
                public Diaria()
                {
                        InitializeComponent();

                        this.GroupingColumnName = "cajas_movim.id_caja";
                        this.Fechas = new Lfx.Types.DateRange("dia-0");

                        this.Definicion = new Lfx.Data.Listing()
                        {
                                TableName = "cajas_movim",
                                KeyColumnName = new Lfx.Data.FormField("cajas_movim.id_movim", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                Joins = new qGen.JoinCollection() {new qGen.Join("personas", "cajas_movim.id_persona=personas.id_persona") },
                                Columns = new Lfx.Data.FormFieldCollection() {
                                        new Lfx.Data.FormField("cajas_movim.id_caja", "Caja", Lfx.Data.InputFieldTypes.Relation, 0),
                                        new Lfx.Data.FormField("cajas_movim.id_concepto", "Concepto", Lfx.Data.InputFieldTypes.Relation, 0),
                                        new Lfx.Data.FormField("cajas_movim.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 200),
                                        new Lfx.Data.FormField("cajas_movim.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 100),
                                        new Lfx.Data.FormField("cajas_movim.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
                                        new Lfx.Data.FormField("cajas_movim.saldo", "Saldo", Lfx.Data.InputFieldTypes.Currency, 96),
                                        new Lfx.Data.FormField("personas.nombre_visible", "Persona", Lfx.Data.InputFieldTypes.Text, 200),
                                        new Lfx.Data.FormField("cajas_movim.id_comprob", "Factura", Lfx.Data.InputFieldTypes.Relation, 0),
                                        new Lfx.Data.FormField("cajas_movim.id_recibo", "Recibo", Lfx.Data.InputFieldTypes.Relation, 0),
                                        new Lfx.Data.FormField("cajas_movim.obs", "Obs.", Lfx.Data.InputFieldTypes.Text, 320),
                                        new Lfx.Data.FormField("cajas_movim.comprob", "Comprobante", Lfx.Data.InputFieldTypes.Text, 160)
                                },
                                OrderBy = "cajas_movim.id_movim"
                        };

                        this.HabilitarFiltrar = true;
                        this.HabilitarImprimir = true;
                }

                protected override void OnBeginRefreshList()
                {
                        this.CustomFilters.Clear();

                        if (Fechas.HasRange)
                                this.CustomFilters.AddWithValue("cajas_movim.fecha", Fechas.From, Fechas.To);

                        base.OnBeginRefreshList();
                }
        }
}
