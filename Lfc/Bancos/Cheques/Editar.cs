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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Bancos.Cheques
{
        public partial class Editar : Lui.Forms.EditForm
        {
                public Editar()
                {
                        InitializeComponent();

                        this.ElementType = typeof(Lbl.Bancos.Cheque);
                }

                public override Lfx.Types.OperationResult Create()
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "cheques.create"))
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Bancos.Cheque Cheque = new Lbl.Bancos.Cheque(this.DataBase);
                        Cheque.Crear();

                        this.FromRow(Cheque);
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override Lfx.Types.OperationResult Edit(int lId)
                {
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "cheques.read") == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        return base.Edit(lId);
                }

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Bancos.Cheque Res = this.CachedRow as Lbl.Bancos.Cheque;

                        EntradaEmisor.Text = Res.Emisor;
                        EntradaBanco.Elemento = Res.Banco;
                        EntradaNumero.Text = Res.Numero.ToString();
                        EntradaFechaCobro.Text = Lfx.Types.Formatting.FormatDate(Res.FechaCobro);
                        EntradaFechaEmision.Text = Lfx.Types.Formatting.FormatDate(Res.FechaEmision);
                        
                        this.ReadOnly = !Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "cheques.write");

                        if (this.CachedRow.Existe)
                                this.Text = Res.ToString();
                        else
                                this.Text = "Cheques: Nuevo";
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Bancos.Cheque Res = this.CachedRow as Lbl.Bancos.Cheque;

                        Res.Emisor =  EntradaEmisor.Text;
                        Res.Banco = EntradaBanco.Elemento as Lbl.Bancos.Banco;
                        Res.Numero = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text);
                        Res.FechaCobro = Lfx.Types.Parsing.ParseDate(EntradaFechaCobro.Text);
                        Res.FechaEmision = Lfx.Types.Parsing.ParseDate(EntradaFechaEmision.Text);

                        return base.ToRow();
                }
        }
}
