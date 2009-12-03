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
                        System.Data.DataTable Situaciones = this.DataView.DataBase.Select("SELECT id_situacion, nombre FROM articulos_situaciones WHERE id_situacion IN (SELECT DISTINCT id_situacion FROM articulos_stock WHERE id_articulo=" + articulo.Id.ToString() + ")");
                        
                        foreach (System.Data.DataRow Situacion in Situaciones.Rows) {
                                ListViewGroup Grupo = ListaConformacion.Groups.Add(Situacion["id_situacion"].ToString(), Situacion["nombre"].ToString());
                                System.Data.DataTable Articulos = this.DataView.DataBase.Select("SELECT serie FROM articulos_series WHERE id_articulo=" + articulo.Id.ToString() + " AND id_situacion=" + Situacion["id_situacion"].ToString());
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
