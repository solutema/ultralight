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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lazaro.Principal
{
	public partial class BarraInferior : UserControl
	{
		private Lws.Workspace m_Workspace;
                private Lws.Data.DataView m_DataView;
		private int ItemActual, ItemSolicitado;
		private string TablaActual, TablaSolicitada;
                private Lbl.ElementoDeDatos ElementoActual = null;

		public BarraInferior()
		{
			InitializeComponent();

			TimerReloj_Tick(this, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Lws.Workspace Workspace
		{
			get
			{
				if (m_Workspace == null && this.Parent != null && this.Parent is Principal.Inicio)
					m_Workspace = ((Principal.Inicio)this.Parent).Workspace;
				return m_Workspace;
			}
			set
			{
				m_Workspace = value;
			}
		}

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lws.Data.DataView DataView
                {
                        get
                        {
                                if (m_DataView == null)
                                        m_DataView = this.Workspace.GetDataView(false);
                                return m_DataView;
                        }
                }

		private void TimerReloj_Tick(object sender, EventArgs e)
		{
			RelojHora.Text = System.DateTime.Now.ToString("HH:mm");
			RelojFecha.Text = System.DateTime.Now.ToString("dd/MM/yy");
		}

		private void TimerSlowLink_Tick(object sender, EventArgs e)
		{
			if (TablaActual != TablaSolicitada || ItemActual != ItemSolicitado)
				this.ActualizarBarra();
			TimerSlowLink.Stop();
		}


		public void MostrarItem(string tabla, int item)
		{
			if (this.Workspace == null)
				return;

			TablaSolicitada = tabla;
			ItemSolicitado = item;

                        if (this.Workspace.SlowLink) {
                                //Reinicio el contador
                                TimerSlowLink.Stop();
                                TimerSlowLink.Start();
                        } else {
                                ActualizarBarra();
                        }
		}

		private void ActualizarBarra()
		{
			this.SuspendLayout();

                        switch (TablaSolicitada)
			{
				case "articulo":
				case "articulos":
					PanelAyuda.Visible = false;
					PanelPersona.Visible = false;
                                        Lbl.Articulos.Articulo Art = new Lbl.Articulos.Articulo(this.DataView, ItemSolicitado);
                                        ElementoActual = Art;
                                        if (Art.Existe) {
                                                ItemActual = ItemSolicitado;
                                                TablaActual = TablaSolicitada;

                                                string Codigos = Art.Id.ToString();
                                                if (Art.Codigo1.Length > 0)
                                                        Codigos += System.Environment.NewLine + Art.Codigo1;
                                                if (Art.Codigo2.Length > 0)
                                                        Codigos += System.Environment.NewLine + Art.Codigo2;
                                                if (Art.Codigo3.Length > 0)
                                                        Codigos += System.Environment.NewLine + Art.Codigo3;
                                                if (Art.Codigo4.Length > 0)
                                                        Codigos += System.Environment.NewLine + Art.Codigo4;
                                                ArticuloCodigos.Text = Codigos;
                                                ArticuloNombre.Text = Art.ToString();
                                                ArticuloDescripcion.Text = Art.Descripcion;
                                                ArticuloPVP.Text = Lfx.Types.Formatting.FormatCurrency(Art.PVP, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                                ArticuloStock.Text = Lfx.Types.Formatting.FormatCurrency(Art.StockActual(), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                                PanelArticulo.Visible = true;
                                        }
					break;
				case "persona":
				case "personas":
					PanelAyuda.Visible = false;
					PanelArticulo.Visible = false;
                                        Lbl.Personas.Persona Per = new Lbl.Personas.Persona(this.DataView, ItemSolicitado);
                                        ElementoActual = Per;
                                        if (Per.Existe) {
                                                ItemActual = ItemSolicitado;
                                                TablaActual = TablaSolicitada;

                                                PersonaNombre.Text = Per.ToString();
                                                PersonaDomicilio.Text = Per.Domicilio;
                                                PersonaTelefono.Text = Per.Telefono;
                                                PersonaEmail.Text = Per.Email;
                                                if (Per.Grupo != null)
                                                        PersonaGrupo.Text = Per.Grupo.ToString();
                                                else
                                                        PersonaGrupo.Text = "-";
                                                double Saldo = Per.CuentaCorriente.Saldo();
                                                if (Saldo > 0) {
                                                        PersonaComentario.Text = "Esta persona registra saldo impago en cuenta corriente por " + Lfx.Types.Formatting.FormatCurrency(Saldo, this.Workspace.CurrentConfig.Currency.DecimalPlacesFinal);
                                                        PersonaComentario.BackColor = System.Drawing.Color.Tomato;
                                                        PersonaComentario.Visible = true;
                                                } else if (Saldo < 0) {
                                                        PersonaComentario.Text = "Esta persona registra saldo a favor en cuenta corriente por " + Lfx.Types.Formatting.FormatCurrency(-Saldo, this.Workspace.CurrentConfig.Currency.DecimalPlacesFinal);
                                                        PersonaComentario.BackColor = System.Drawing.SystemColors.Control;
                                                        PersonaComentario.Visible = true;
                                                } else {
                                                        PersonaComentario.Visible = false;
                                                }
                                                PersonaImagen.Image = Per.Imagen;
                                                PanelPersona.Visible = true;
                                        }
					break;
			}
			this.ResumeLayout();
		}

		public void MostrarAyuda(string titulo, string texto)
		{
			this.SuspendLayout();
			PanelArticulo.Visible = false;
			PanelPersona.Visible = false;
			AyudaTitulo.Text = titulo;
			AyudaTexto.Text = texto;
			PanelAyuda.Visible = true;
			this.ResumeLayout();
		}

		private void ArticuloNombre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Aplicacion.Exec("EDITAR " + TablaActual + " " + ItemActual.ToString());
		}

                private void PersonaNombre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Aplicacion.Exec("EDITAR " + TablaActual + " " + ItemActual.ToString());
                }

                private void EnlaceEtiquetas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        if (ElementoActual != null) {
                                Lfc.Etiquetas FormularioEtiquetas = new Lfc.Etiquetas();
                                FormularioEtiquetas.Workspace = this.Workspace;
                                FormularioEtiquetas.Elemento = ElementoActual;
                                FormularioEtiquetas.Show();
                        }
                }
	}
}
