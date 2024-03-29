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
using System.Collections.Generic;
using System.Text;

namespace Lbl.Sys.Log
{
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Entrada de Registro de Actividades")]
        [Lbl.Atributos.Datos(TablaDatos = "sys_log", CampoId = "id_log")]
        [Lbl.Atributos.Presentacion()]
        public class Entrada : Lbl.ElementoDeDatos
        {
                //Heredar constructor
                public Entrada(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Entrada(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public string ComandoTexto
                {
                        get
                        {
                                return this.GetFieldValue<string>("comando");
                        }
                }


                public string Carga
                {
                        get
                        {
                                return this.GetFieldValue<string>("extra1");
                        }
                }


                public int IdUsuario
                {
                        get
                        {
                                return this.GetFieldValue<int>("usuario");
                        }
                }

                public string Tabla
                {
                        get
                        {
                                return this.GetFieldValue<string>("tabla");
                        }
                }

                public Acciones Comando
                {
                        get
                        {
                                string CmdTxt = this.GetFieldValue<string>("comando");
                                try {
                                        return (Acciones)(System.Enum.Parse(typeof(Acciones), CmdTxt));
                                } catch {
                                        return Acciones.Other;
                                }
                        }
                }


                public string ExplainSave(bool multiLine)
                {
                        string Cambios = this.GetFieldValue<string>("extra1");

                        if (this.Comando != Acciones.Save)
                                return Cambios == null ? "" : Cambios;

                        if (Cambios == null)
                                return "sin cambios";

                        IList<string> Campos = Lfx.Types.Strings.SplitDelimitedString(Cambios, ";", "\'" );
                        StringBuilder Res = new StringBuilder();

                        Lfx.Data.TableStructure EstrucTabla;
                        if (Lfx.Workspace.Master.Structure.Tables.ContainsKey(this.Tabla))
                                EstrucTabla = Lfx.Workspace.Master.Structure.Tables[this.Tabla];
                        else
                                EstrucTabla = null;

                        foreach (string Campo in Campos) {
                                IList<string> Partes = Campo.Split(new char[] { '=' });

                                if (Partes.Count == 1)
                                        Partes = new List<string>() { "", Campo };

                                string NombreCampo = Partes[0].Trim();

                                if (EstrucTabla != null && EstrucTabla.Columns.ContainsKey(NombreCampo)) {
                                        NombreCampo = EstrucTabla.Columns[NombreCampo].Label;
                                        if (NombreCampo == null || NombreCampo == string.Empty)
                                                NombreCampo = Partes[0];
                                } else {
                                        NombreCampo = NombreCampo.ToTitleCase();
                                }

                                string ValorCampo = Partes[1];
                                ValorCampo = ValorCampo.Replace("NULL->", "");
                                ValorCampo = ValorCampo.Replace("->", " se cambió por ");
                                if (multiLine)
                                        Res.AppendLine(NombreCampo + ": " + ValorCampo + ".");
                                else
                                        Res.Append(NombreCampo + ": " + ValorCampo + "; ");
                        }

                        return Res.ToString();
                }


                public override string ToString()
                {
                        string Res = this.GetFieldValue<string>("extra1");
                        if (Res == null) {
                                return "sin cambios";
                        } else {
                                Res = Res.Replace("NULL->", ": ");
                                Res = Res.Replace("->", " se cambió por ");
                        }
                        return Res;
                }
        }
}
