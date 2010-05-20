using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lazaro.Misc
{
        public partial class Verificador : Lui.Forms.Form
        {
                public Verificador()
                {
                        InitializeComponent();
                }

                private void OkButton_Click(object sender, EventArgs e)
                {
                        LowerPanel.Enabled = false;
                        this.Verificar();
                        LowerPanel.Enabled = true;
                }

                public string Estado
                {
                        get
                        {
                                return EtiquetaEstado.Text;
                        }
                        set
                        {
                                EtiquetaEstado.Text = value;
                                this.Refresh();
                        }
                }

                public void Verificar()
                {
                        this.Estado = "Verificando existencias...";
                        Lbl.ColeccionGenerica<Lbl.Articulos.Situacion> Situaciones = new Lbl.ColeccionGenerica<Lbl.Articulos.Situacion>(this.DataView.Tables["articulos_situaciones"]);

                        Lbl.ColeccionGenerica<Lbl.Articulos.Articulo> Articulos = new Lbl.ColeccionGenerica<Lbl.Articulos.Articulo>(this.DataView.Tables["articulos"]);
                        foreach (Lbl.Articulos.Articulo Art in Articulos.List) {
                                this.Estado = Art.ToString();
                        }
                }
        }
}
