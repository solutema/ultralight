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
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Plantillas
{
        public partial class EditarCampo : Lui.Forms.DialogForm
	{
                public Lbl.Impresion.Campo Campo { get; set; }

		public EditarCampo()
		{
			InitializeComponent();
                        this.CancelCommandButton.Visible = false;
		}


                public EditarCampo(Lbl.Impresion.Campo campo)
                        : this()
                {
                        this.Campo = campo;

                        this.EntradaTexto.Text = this.Campo.Valor;
                        if (this.Campo.Formato == null || this.Campo.Formato.Length == 0)
                                this.EntradaFormato.TextKey = "*";
                        else
                                this.EntradaFormato.TextKey = this.Campo.Formato;
                        this.EntradaX.ValueInt = this.Campo.Rectangle.X;
                        this.EntradaY.ValueInt = this.Campo.Rectangle.Y;
                        this.EntradaAncho.ValueInt = this.Campo.Rectangle.Width;
                        this.EntradaAlto.ValueInt = this.Campo.Rectangle.Height;
                        this.EntradaAlienacionHorizontal.TextKey = this.Campo.Alignment.ToString();
                        this.EntradaAlienacionVertical.TextKey = this.Campo.LineAlignment.ToString();
                        this.EntradaAjusteTexto.TextKey = this.Campo.Wrap ? "1" : "0";
                        this.EntradaAnchoBorde.ValueInt = this.Campo.AnchoBorde;
                        if (this.Campo.Font != null) {
                                this.EntradaFuenteNombre.TextKey = this.Campo.Font.Name;
                                this.EntradaFuenteTamano.Text = this.Campo.Font.Size.ToString("#.00");
                        } else {
                                this.EntradaFuenteNombre.TextKey = "*";
                                this.EntradaFuenteTamano.ValueDecimal = 10;
                        }

                        this.ActualizarMuestra();
                }
		

                private void EntradaFuenteFuenteTamano_TextChanged(object sender, EventArgs e)
                {
                        EntradaFuenteTamano.Enabled = (EntradaFuenteNombre.TextKey != "*");
                        if (this.EntradaFuenteNombre.TextKey != "*" && this.EntradaFuenteTamano.ValueDecimal > 1) {
                                this.Campo.Font = new Font(this.EntradaFuenteNombre.TextKey, ((float)(this.EntradaFuenteTamano.ValueDecimal)));
                        } else {
                                this.Campo.Font = null;
                        }
                        this.ActualizarMuestra();
                }

                private void BotonColorFondo_Click(object sender, EventArgs e)
                {
                        ColorDialog ColDlg = new ColorDialog();
                        ColDlg.Color = this.Campo.ColorFondo;
                        if (ColDlg.ShowDialog() == DialogResult.OK) {
                                this.Campo.ColorFondo = ColDlg.Color;
                                ActualizarMuestra();
                        }
                }

                private void BotonColorTexto_Click(object sender, EventArgs e)
                {
                        ColorDialog ColDlg = new ColorDialog();
                        ColDlg.Color = this.Campo.ColorTexto;
                        if (ColDlg.ShowDialog() == DialogResult.OK) {
                                this.Campo.ColorTexto = ColDlg.Color;
                                ActualizarMuestra();
                        }
                }

                private void BotonColorBorde_Click(object sender, EventArgs e)
                {
                        ColorDialog ColDlg = new ColorDialog();
                        ColDlg.Color = this.Campo.ColorBorde;
                        if (ColDlg.ShowDialog() == DialogResult.OK) {
                                this.Campo.ColorBorde = ColDlg.Color;
                                if (this.Campo.ColorBorde != Color.Transparent && this.Campo.AnchoBorde == 0)
                                        EntradaAnchoBorde.ValueInt = 1;
                                else
                                        ActualizarMuestra();
                        }
                }

                private void EntradaTexto_TextChanged(object sender, EventArgs e)
                {
                        EntradaFormato.Enabled = EntradaTexto.Text.StartsWith("{") && EntradaTexto.Text.EndsWith("}");
                }

                private void ActualizarMuestra()
                {
                        if (this.Campo.Font == null) {
                                EtiquetaMuestra.Font = PanelMuestra.Font;
                        } else {
                                EtiquetaMuestra.Font = this.Campo.Font;
                        }

                        PanelMuestraBorde.Padding = new Padding((this.Campo.AnchoBorde + 1) / 2);
                        PanelMuestraBorde.BackColor = this.Campo.ColorBorde;
                        if (this.Campo.ColorFondo == Color.Transparent || this.Campo.ColorFondo.A == 0)
                                // Esto es para simular el fondo blanco, ya que si le doy transparente se ve el PanelBorde
                                EtiquetaMuestra.BackColor = Color.White;
                        else
                                EtiquetaMuestra.BackColor = this.Campo.ColorFondo;
                        EtiquetaMuestra.ForeColor = this.Campo.ColorTexto;
                        switch(this.Campo.LineAlignment) {
                                case StringAlignment.Near:
                                        switch(this.Campo.Alignment) {
                                                case StringAlignment.Near:
                                                        EtiquetaMuestra.TextAlign = ContentAlignment.TopLeft;
                                                        break;
                                                case StringAlignment.Center:
                                                        EtiquetaMuestra.TextAlign = ContentAlignment.TopCenter;
                                                        break;
                                                case StringAlignment.Far:
                                                        EtiquetaMuestra.TextAlign = ContentAlignment.TopRight;
                                                        break;
                                        }
                                        break;

                                case StringAlignment.Center:
                                        switch (this.Campo.Alignment) {
                                                case StringAlignment.Near:
                                                        EtiquetaMuestra.TextAlign = ContentAlignment.MiddleLeft;
                                                        break;
                                                case StringAlignment.Center:
                                                        EtiquetaMuestra.TextAlign = ContentAlignment.MiddleCenter;
                                                        break;
                                                case StringAlignment.Far:
                                                        EtiquetaMuestra.TextAlign = ContentAlignment.MiddleRight;
                                                        break;
                                        }
                                        break;

                                case StringAlignment.Far:
                                        switch (this.Campo.Alignment) {
                                                case StringAlignment.Near:
                                                        EtiquetaMuestra.TextAlign = ContentAlignment.BottomLeft;
                                                        break;
                                                case StringAlignment.Center:
                                                        EtiquetaMuestra.TextAlign = ContentAlignment.BottomCenter;
                                                        break;
                                                case StringAlignment.Far:
                                                        EtiquetaMuestra.TextAlign = ContentAlignment.BottomRight;
                                                        break;
                                        }
                                        break;
                        }

                        if (this.Campo.Wrap) {
                                EtiquetaMuestra.Text = @"Lorem ipsum ad his scripta
blandit partiendo,
eum fastidii accumsan
euripidis in,
eum liber hendrerit an";
                        } else {
                                EtiquetaMuestra.Text = "Texto de muestra";
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        if (this.EntradaFormato.TextKey == "*")
                                this.Campo.Formato = null;
                        else
                                this.Campo.Formato = this.EntradaFormato.TextKey;
                        this.Campo.Rectangle = new Rectangle(this.EntradaX.ValueInt, this.EntradaY.ValueInt, this.EntradaAncho.ValueInt, this.EntradaAlto.ValueInt);
                        this.Campo.Valor = this.EntradaTexto.Text;
                        if (this.EntradaFuenteNombre.TextKey != "*" && this.EntradaFuenteTamano.ValueDecimal > 1) {
                                this.Campo.Font = new Font(this.EntradaFuenteNombre.TextKey, ((float)(this.EntradaFuenteTamano.ValueDecimal)));
                        } else {
                                this.Campo.Font = null;
                        }
                        switch (this.EntradaAlienacionHorizontal.TextKey) {
                                case "Far":
                                        this.Campo.Alignment = StringAlignment.Far;
                                        break;
                                case "Center":
                                        this.Campo.Alignment = StringAlignment.Center;
                                        break;
                                default:
                                        this.Campo.Alignment = StringAlignment.Near;
                                        break;
                        }
                        switch (this.EntradaAlienacionVertical.TextKey) {
                                case "Far":
                                        this.Campo.LineAlignment = StringAlignment.Far;
                                        break;
                                case "Center":
                                        this.Campo.LineAlignment = StringAlignment.Center;
                                        break;
                                default:
                                        this.Campo.LineAlignment = StringAlignment.Near;
                                        break;
                        }
                        this.Campo.Wrap = this.EntradaAjusteTexto.TextKey == "1";

                        return base.Ok();
                }

                private void EntradaAnchoBorde_TextChanged(object sender, EventArgs e)
                {
                        this.Campo.AnchoBorde = this.EntradaAnchoBorde.ValueInt;
                        this.ActualizarMuestra();
                }

                private void EntradaAlienacionHorizontalVertical_TextChanged(object sender, EventArgs e)
                {
                        switch (this.EntradaAlienacionHorizontal.TextKey) {
                                case "Far":
                                        this.Campo.Alignment = StringAlignment.Far;
                                        break;
                                case "Center":
                                        this.Campo.Alignment = StringAlignment.Center;
                                        break;
                                default:
                                        this.Campo.Alignment = StringAlignment.Near;
                                        break;
                        }
                        switch (this.EntradaAlienacionVertical.TextKey) {
                                case "Far":
                                        this.Campo.LineAlignment = StringAlignment.Far;
                                        break;
                                case "Center":
                                        this.Campo.LineAlignment = StringAlignment.Center;
                                        break;
                                default:
                                        this.Campo.LineAlignment = StringAlignment.Near;
                                        break;
                        }

                        this.ActualizarMuestra();
                }

                private void EntradaAjusteTexto_TextChanged(object sender, EventArgs e)
                {
                        this.Campo.Wrap = EntradaAjusteTexto.ValueInt == 1;
                        this.ActualizarMuestra();
                }


                private void BotonColorFondoPredet_Click(object sender, EventArgs e)
                {
                        this.Campo.ColorFondo = Color.Transparent;
                        this.ActualizarMuestra();
                }
	}
}

