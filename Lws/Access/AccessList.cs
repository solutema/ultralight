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
using System.Text;

namespace Lws.Access
{
        public class AccessList : System.Collections.Generic.List<Access>
        {
                Lws.Workspace Workspace;
                private int m_HasGlobalAccess = -1;

                public AccessList(Lws.Workspace workspace)
                {
                        this.Workspace = workspace;
                }

                public bool HasAccess(string accessName, int itemId)
                {
                        if (this.Count == 0)
                                this.Load();

                        if (this.HasGlobalAcccess())
                                return true;

                        foreach (Access Acc in this) {
                                if (Lfx.Types.Strings.Like(Acc.Name, accessName) &&
                                        (Acc.Item == 0 || Acc.Item == itemId)) {
                                        return true;
                                }
                        }

                        return false;
                }

                public bool HasGlobalAcccess()
                {
                        if (this.m_HasGlobalAccess == -1) {
                                if (this.Count == 0)
                                        this.Load();

                                foreach (Access Acc in this) {
                                        if (Acc.Name == "global.total") {
                                                m_HasGlobalAccess = 1;
                                                break;
                                        }
                                }
                                if (m_HasGlobalAccess == -1) {
                                        m_HasGlobalAccess = 0;
                                }
                        }

                        return m_HasGlobalAccess == 1;
                }

                private void Load()
                {
                        System.Data.DataTable AccList = this.Workspace.DefaultDataView.DataBase.Select("SELECT * FROM sys_accesslist WHERE id_persona=" + this.Workspace.CurrentUser.Id.ToString());
                        foreach (System.Data.DataRow Acc in AccList.Rows) {
                                string AccName = Acc["id_acceso"].ToString();
                                int AccItem = 0;
                                if(Acc["item"].ToString() != "*")
                                        AccItem = Lfx.Types.Parsing.ParseInt(Acc["item"].ToString());
                                this.Add(new Access(AccName, AccItem));
                        }
                }
        }
}
