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

namespace Lfc.Articulos
{
        public partial class VerConformacion : TablaDetalles
        {
                public VerConformacion()
                {
                        InitializeComponent();
                }

                public void Mostrar(Lbl.Articulos.Articulo articulo)
                {
                        ListaConformacion.BeginUpdate();
                        ListaConformacion.Items.Clear();
                        System.Data.DataTable Situaciones = this.DataBase.Select("SELECT id_situacion, nombre FROM articulos_situaciones WHERE id_situacion IN (SELECT DISTINCT id_situacion FROM articulos_stock WHERE id_articulo=" + articulo.Id.ToString() + ")");
                        
                        foreach (System.Data.DataRow Situacion in Situaciones.Rows) {
                                ListViewGroup Grupo = ListaConformacion.Groups.Add(Situacion["id_situacion"].ToString(), Situacion["nombre"].ToString());
                                System.Data.DataTable Articulos = this.DataBase.Select("SELECT serie FROM articulos_series WHERE id_articulo=" + articulo.Id.ToString() + " AND id_situacion=" + Situacion["id_situacion"].ToString());
                                foreach(System.Data.DataRow Articulo in Articulos.Rows){
                                        string Serie = Articulo["serie"].ToString();
                                        ListViewItem Itm = ListaConformacion.Items.Add(Serie);
                                        Itm.SubItems[0].Text = articulo.Nombre;
                                        Itm.SubItems.Add(Serie);
                                        Itm.Group = Grupo;
                                }
                        }
                        ListaConformacion.EndUpdate();
                }
        }
}
