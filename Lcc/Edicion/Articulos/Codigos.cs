using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Edicion.Articulos
{
        public partial class Codigos : Lcc.Edicion.ControlEdicion
        {
                public Codigos()
                {
                        InitializeComponent();
                }

                public override void ActualizarControl()
                {
                        Lbl.Articulos.Articulo Art = this.Elemento as Lbl.Articulos.Articulo;

                        EntradaCodigo1.Text = Art.Codigo1;
                        EntradaCodigo2.Text = Art.Codigo2;
                        EntradaCodigo3.Text = Art.Codigo3;
                        EntradaCodigo4.Text = Art.Codigo4;
                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Articulos.Articulo Art = this.Elemento as Lbl.Articulos.Articulo;

                        Art.Codigo1 = EntradaCodigo1.Text;
                        Art.Codigo2 = EntradaCodigo2.Text;
                        Art.Codigo3 = EntradaCodigo3.Text;
                        Art.Codigo4 = EntradaCodigo4.Text;
                        base.ActualizarElemento();
                }
        }
}
