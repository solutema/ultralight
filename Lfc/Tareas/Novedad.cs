#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Tareas
{
        public partial class Novedad : Lui.Forms.DialogForm
        {
                public Novedad()
                {
                        InitializeComponent();
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        if (EntradaTicket.TextInt == 0)
                                return new Lfx.Types.FailureOperationResult("Escriba el código de Ticket");

                        qGen.Insert InsertarNovedad = new qGen.Insert(Connection, "tickets_eventos");
                        InsertarNovedad.Fields.AddWithValue("id_ticket", EntradaTicket.TextInt);
                        InsertarNovedad.Fields.AddWithValue("id_tecnico", EntradaTecnico.TextInt);
                        InsertarNovedad.Fields.AddWithValue("minutos_tecnico", Lfx.Types.Parsing.ParseInt(EntradaMinutos.Text));
                        InsertarNovedad.Fields.AddWithValue("privado", EntradaCondicion.TextKey);
                        InsertarNovedad.Fields.AddWithValue("descripcion", EntradaDescripcion.Text);
                        InsertarNovedad.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        Connection.Execute(InsertarNovedad);

                        return base.Ok();
                }

                private void Novedad_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        EntradaTecnico.Elemento = Lbl.Sys.Config.Actual.UsuarioConectado.Persona;
                }
        }
}