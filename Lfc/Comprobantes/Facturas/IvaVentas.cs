#region License
// Copyright 2004-2010 Ernesto N. Carrea
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
using System.Linq;
using System.Text;

namespace Lfc.Comprobantes.Facturas
{
        public class IvaVentas : Lfc.FormularioListado
        {
                protected internal Lfx.Types.DateRange m_Fecha = new Lfx.Types.DateRange("mes-1");
                protected internal int m_Sucursal, m_Anuladas = 1, m_PV = 0;

                public IvaVentas()
                {
                        this.ElementoTipo = typeof(Lbl.Comprobantes.ComprobanteConArticulos);

                        this.NombreTabla = "comprob";
                        this.KeyField = new Lfx.Data.FormField("comprob.id_comprob", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        this.Joins.Add(new qGen.Join("personas", "comprob.id_cliente=personas.id_persona"));
                        this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("comprob.tipo_fac", "Tipo", Lfx.Data.InputFieldTypes.Text, 40),
				new Lfx.Data.FormField("CONCAT(LPAD(comprob.pv, 4, '0'), '-', LPAD(comprob.numero, 8, '0')) AS numero", "Número", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("comprob.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("personas.cuit", "CUIT", Lfx.Data.InputFieldTypes.Text, 140),
				new Lfx.Data.FormField("personas.id_situacion", "Situacion", Lfx.Data.InputFieldTypes.Text, 140),
				new Lfx.Data.FormField("comprob.total", "Total", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("comprob.impresa", "Impresa", Lfx.Data.InputFieldTypes.Bool, 0),
				new Lfx.Data.FormField("comprob.anulada", "Anulada", Lfx.Data.InputFieldTypes.Bool, 0),
                                
			};

                        this.FormFields["total"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum;

                        this.OrderBy = "comprob.id_comprob DESC";

                        this.Contadores.Add(new Lfc.Contador("Total", Lui.Forms.DataTypes.Currency));

                        this.HabilitarFiltrar = true;
                        this.HabilitarImprimir = true;
                        this.HabilitarBusqueda = false;

                        if (this.HasWorkspace)
                                m_Sucursal = this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada;
                }
        }

}
