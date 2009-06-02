using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Edicion.Articulos
{
        public partial class Denominacion : Lcc.Edicion.ControlEdicion
        {
                public Denominacion()
                {
                        InitializeComponent();
                }

                public override void ActualizarControl()
                {
                        Lbl.Articulos.Articulo Art = this.Elemento as Lbl.Articulos.Articulo;

                        EntradaCategoria.TextInt = Art.Categoria.Id;
                        EntradaDescripcion.Text = Art.Descripcion;
                        EntradaMarca.TextInt = Art.Marca.Id;
                        EntradaModelo.Text = Art.Modelo;
                        EntradaNombre.Text = Art.Nombre;
                        EntradaSerie.Text = Art.Serie;
                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Articulos.Articulo Art = this.Elemento as Lbl.Articulos.Articulo;

                        Art.Categoria = new Lbl.Articulos.Categoria(Elemento.DataView, EntradaCategoria.TextInt);
                        
                        base.ActualizarElemento();
                }
        }
}
