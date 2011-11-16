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
using System.Text;

namespace Lbl.Servicios.Importar
{
        /// <summary>
        /// Describe un filtro de importación desde archivos DBF.
        /// </summary>
        public class FiltroDbf : FiltroArchivos
        {
                private System.Data.Odbc.OdbcConnection ConexionExterna;

                public FiltroDbf(Lfx.Data.Connection dataBase, Opciones opciones)
                        : base(dataBase, opciones)
                {
                }


                public override void PreImportar()
                {
                        if (ConexionExterna != null) {
                                if (ConexionExterna.State == System.Data.ConnectionState.Open)
                                        ConexionExterna.Close();
                                ConexionExterna.Dispose();
                        }

                        ConexionExterna = new System.Data.Odbc.OdbcConnection();
                        if (this.Dsn != null && this.Dsn.Length > 0)
                                ConexionExterna.ConnectionString = @"dsn=" + this.Dsn + ";";
                        else
                                ConexionExterna.ConnectionString = @"Driver={Microsoft Access dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + this.Carpeta + ";Exclusive=No;Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";

                        ConexionExterna.Open();

                        base.PreImportar();
                }



                public override void PostImportar()
                {
                        if (ConexionExterna != null) {
                                if (ConexionExterna.State == System.Data.ConnectionState.Open)
                                        ConexionExterna.Close();
                                ConexionExterna.Dispose();
                        }

                        base.PostImportar();
                }


                public override IList<Lfx.Data.Row> CargarTabla(MapaDeTabla mapa)
                {
                        Progreso.Value = 0;
                        Progreso.ChangeStatus("Leyendo " + mapa.ToString());

                        IList<Lfx.Data.Row> Res = new List<Lfx.Data.Row>();

                        string SqlSelect = @"SELECT 0 as lazaro_recno, * FROM " + this.Carpeta + mapa.Archivo;
                        if (mapa.Where != null)
                                SqlSelect += " WHERE " + mapa.Where;

                        // Hago un SELECT de la tabla
                        System.Data.Odbc.OdbcCommand TableCommand = ConexionExterna.CreateCommand();
                        TableCommand.CommandText = SqlSelect;
                        System.Data.DataTable ReadTable = new System.Data.DataTable();
                        ReadTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                        ReadTable.Load(TableCommand.ExecuteReader());

                        Progreso.ChangeStatus("Cargando " + mapa.ToString() + " en memoria (" + ReadTable.Rows.Count.ToString() + " registros)");
                        Progreso.Max = ReadTable.Rows.Count;
                        // Navegar todos los registros
                        int lazaro_recno = 0;
                        foreach (System.Data.DataRow Rw in ReadTable.Rows) {
                                Rw["lazaro_recno"] = ++lazaro_recno;
                                Lfx.Data.Row Lrw = this.ProcesarRegistro(mapa, Rw);
                                Lrw["lazaro_recno"] = lazaro_recno;
                                Res.Add(Lrw);
                                Progreso.Advance(1);
                                if (mapa.Limite > 0 && lazaro_recno > mapa.Limite)
                                        break;
                        }

                        return Res;
                }
        }
}
