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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Bancos.Chequeras
{
	public partial class Editar : Lui.Forms.EditForm
	{
		public Editar()
		{
			InitializeComponent();
		}

                public override Lfx.Types.OperationResult Create()
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "chequeras.create"))
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Bancos.Chequera Chequera = new Lbl.Bancos.Chequera(this.DataView);
                        Chequera.Crear();

                        this.FromRow(Chequera);
                        return new Lfx.Types.SuccessOperationResult();
                }

		public override Lfx.Types.OperationResult Edit(int lId)
		{
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "chequeras.read") == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Bancos.Chequera Chequera = new Lbl.Bancos.Chequera(this.DataView, lId);

                        if (Chequera.Cargar().Success == false) {
                                return new Lfx.Types.FailureOperationResult("Error al cargar el registro");
                        } else {
                                this.FromRow(Chequera);
                                return new Lfx.Types.SuccessOperationResult();
                        }
		}

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Bancos.Chequera Res = this.CachedRow as Lbl.Bancos.Chequera;

                        if (Res.Banco == null)
                                EntradaBanco.TextInt = 0;
                        else
                                EntradaBanco.TextInt = Res.Banco.Id;
                        EntradaDesde.Text = Res.Desde.ToString();
                        EntradaHasta.Text = Res.Hasta.ToString();
                        if (Res.Caja == null)
                                EntradaCaja.TextInt = 0;
                        else
                                EntradaCaja.TextInt = Res.Caja.Id;
                        EntradaTitular.Text = Res.Titular;
                        EntradaEstado.TextKey = Res.Estado.ToString();
                        if (Res.Sucursal == null)
                                EntradaSucursal.TextInt = 0;
                        else
                                EntradaSucursal.TextInt = Res.Sucursal.Id;

                        if (Res.Existe)
                                EntradaCaja.Filter = null;
                        else
                                EntradaCaja.Filter = "estado=1";

                        SaveButton.Visible = Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "chequeras.write");

                        if (this.CachedRow.Existe)
                                this.Text = Res.ToString();
                        else
                                this.Text = "Chequeras: Nueva";
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Bancos.Chequera Res = this.CachedRow as Lbl.Bancos.Chequera;

                        if (EntradaBanco.TextInt == 0)
                                Res.Banco = null;
                        else
                                Res.Banco = new Lbl.Bancos.Banco(Res.DataView, EntradaBanco.TextInt);

                        if (EntradaCaja.TextInt == 0)
                                Res.Caja = null;
                        else
                                Res.Caja = new Lbl.Cajas.Caja(Res.DataView, EntradaCaja.TextInt);

                        if (EntradaSucursal.TextInt == 0)
                                Res.Sucursal = null;
                        else
                                Res.Sucursal = new Lbl.Entidades.Sucursal(Res.DataView, EntradaSucursal.TextInt);

                        Res.Prefijo = Lfx.Types.Parsing.ParseInt(EntradaPrefijo.Text);
                        Res.Desde = Lfx.Types.Parsing.ParseInt(EntradaDesde.Text);
                        Res.Hasta = Lfx.Types.Parsing.ParseInt(EntradaHasta.Text);
                        Res.Titular = EntradaTitular.Text;
                        Res.Estado = Lfx.Types.Parsing.ParseInt(EntradaEstado.TextKey);

                        return base.ToRow();
                }
	}
}

