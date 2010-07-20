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

namespace Lfc.Ciudades
{
	public partial class Editar : Lui.Forms.EditForm
	{
                public Editar()
                        : base()
                {
                        InitializeComponent();

                        this.ElementType = typeof(Lbl.Entidades.Localidad);
                }

                public override Lfx.Types.OperationResult ValidateData()
                {
                        if (EntradaNivel.TextKey != "0" && EntradaParent.TextInt == 0)
                                return new Lfx.Types.FailureOperationResult("Debe ingresar la Provincia o el Departamento");

                        return base.ValidateData();
                }

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Entidades.Localidad Ciudad = row as Lbl.Entidades.Localidad;

                        EntradaNombre.Text = Ciudad.Nombre;
                        EntradaCp.Text = Ciudad.CodigoPostal;
                        EntradaNivel.TextKey = Ciudad.Nivel.ToString();
                        EntradaNivel.ReadOnly = true;
                        EntradaNivel.TabStop = false;
                        if (Ciudad.Nivel == 0) {
                                EntradaParent.Enabled = false;
                                EntradaParent.TabStop = false;
                        }
                        if (Ciudad.Parent == null)
                                EntradaParent.TextInt = 0;
                        else
                                EntradaParent.TextInt = Ciudad.Parent.Id;

                        this.Text = "Ciudades: " + Ciudad.Nombre;

                        EntradaTags.Elemento = Ciudad;
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Entidades.Localidad Res = this.CachedRow as Lbl.Entidades.Localidad;

                        Res.Nombre = EntradaNombre.Text;
                        Res.CodigoPostal = EntradaCp.Text;
                        if (EntradaParent.TextInt == 0)
                                Res.Parent = null;
                        else
                                Res.Parent = new Lbl.Entidades.Localidad(Res.DataBase, EntradaParent.TextInt);

                        EntradaTags.ActualizarElemento();

                        return base.ToRow();
                }

                private void EntradaNivel_TextChanged(object sender, EventArgs e)
                {
                        switch(EntradaNivel.TextKey) {
                                case "0":
                                        EntradaParent.Enabled = false;
                                        EntradaParent.TextInt = 0;
                                        break;
                                case "1":
                                        EntradaParent.Enabled = true;
                                        EntradaParent.Filter = "nivel=0";
                                        EtiquetaParent.Text = "Provincia";
                                        break;
                                case "2":
                                        EntradaParent.Enabled = true;
                                        EntradaParent.Filter = "nivel=1";
                                        EtiquetaParent.Text = "Departamento";
                                        break;
                        }
                }
	}
}