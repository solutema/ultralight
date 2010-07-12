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

namespace Lazaro.Principal
{
	partial class BarraInferior
	{
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (m_DataBase != null)
				m_DataBase.Dispose();
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarraInferior));
                        this.PanelReloj = new System.Windows.Forms.Panel();
                        this.RelojFecha = new System.Windows.Forms.Label();
                        this.RelojHora = new System.Windows.Forms.Label();
                        this.PanelArticulo = new System.Windows.Forms.Panel();
                        this.ArticuloNombre = new System.Windows.Forms.LinkLabel();
                        this.ArticuloStock = new System.Windows.Forms.Label();
                        this.label5 = new System.Windows.Forms.Label();
                        this.ArticuloPVP = new System.Windows.Forms.Label();
                        this.ArticuloPrecio = new System.Windows.Forms.Label();
                        this.ArticuloDescripcion = new System.Windows.Forms.Label();
                        this.ArticuloCodigos = new System.Windows.Forms.Label();
                        this.PanelAyuda = new System.Windows.Forms.Panel();
                        this.pictureBox1 = new System.Windows.Forms.PictureBox();
                        this.AyudaTitulo = new System.Windows.Forms.Label();
                        this.AyudaTexto = new System.Windows.Forms.Label();
                        this.TimerReloj = new System.Windows.Forms.Timer(this.components);
                        this.PanelPersona = new System.Windows.Forms.Panel();
                        this.EnlaceComentarios = new System.Windows.Forms.LinkLabel();
                        this.PersonaNombre = new System.Windows.Forms.LinkLabel();
                        this.label3 = new System.Windows.Forms.Label();
                        this.PersonaGrupo = new System.Windows.Forms.Label();
                        this.PersonaComentario = new System.Windows.Forms.Label();
                        this.label1 = new System.Windows.Forms.Label();
                        this.PersonaEmail = new System.Windows.Forms.Label();
                        this.label4 = new System.Windows.Forms.Label();
                        this.PersonaDomicilio = new System.Windows.Forms.Label();
                        this.PersonaTelefono = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.TimerSlowLink = new System.Windows.Forms.Timer(this.components);
                        this.PersonaImagen = new System.Windows.Forms.PictureBox();
                        this.PanelReloj.SuspendLayout();
                        this.PanelArticulo.SuspendLayout();
                        this.PanelAyuda.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                        this.PanelPersona.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.PersonaImagen)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // PanelReloj
                        // 
                        this.PanelReloj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelReloj.BackColor = System.Drawing.SystemColors.ControlDark;
                        this.PanelReloj.Controls.Add(this.RelojFecha);
                        this.PanelReloj.Controls.Add(this.RelojHora);
                        this.PanelReloj.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PanelReloj.Location = new System.Drawing.Point(724, 2);
                        this.PanelReloj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.PanelReloj.Name = "PanelReloj";
                        this.PanelReloj.Size = new System.Drawing.Size(74, 48);
                        this.PanelReloj.TabIndex = 0;
                        // 
                        // RelojFecha
                        // 
                        this.RelojFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.RelojFecha.BackColor = System.Drawing.SystemColors.Control;
                        this.RelojFecha.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.RelojFecha.Location = new System.Drawing.Point(2, 30);
                        this.RelojFecha.Name = "RelojFecha";
                        this.RelojFecha.Size = new System.Drawing.Size(70, 16);
                        this.RelojFecha.TabIndex = 1;
                        this.RelojFecha.Text = "00/00/00";
                        this.RelojFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.RelojFecha.UseMnemonic = false;
                        // 
                        // RelojHora
                        // 
                        this.RelojHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.RelojHora.BackColor = System.Drawing.SystemColors.Control;
                        this.RelojHora.Font = new System.Drawing.Font("Bitstream Vera Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.RelojHora.Location = new System.Drawing.Point(2, 2);
                        this.RelojHora.Name = "RelojHora";
                        this.RelojHora.Size = new System.Drawing.Size(70, 26);
                        this.RelojHora.TabIndex = 0;
                        this.RelojHora.Text = "00:00";
                        this.RelojHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.RelojHora.UseMnemonic = false;
                        // 
                        // PanelArticulo
                        // 
                        this.PanelArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelArticulo.Controls.Add(this.ArticuloNombre);
                        this.PanelArticulo.Controls.Add(this.ArticuloStock);
                        this.PanelArticulo.Controls.Add(this.label5);
                        this.PanelArticulo.Controls.Add(this.ArticuloPVP);
                        this.PanelArticulo.Controls.Add(this.ArticuloPrecio);
                        this.PanelArticulo.Controls.Add(this.ArticuloDescripcion);
                        this.PanelArticulo.Controls.Add(this.ArticuloCodigos);
                        this.PanelArticulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PanelArticulo.Location = new System.Drawing.Point(2, 2);
                        this.PanelArticulo.Name = "PanelArticulo";
                        this.PanelArticulo.Size = new System.Drawing.Size(720, 48);
                        this.PanelArticulo.TabIndex = 1;
                        this.PanelArticulo.Visible = false;
                        // 
                        // ArticuloNombre
                        // 
                        this.ArticuloNombre.AutoEllipsis = true;
                        this.ArticuloNombre.Location = new System.Drawing.Point(70, 0);
                        this.ArticuloNombre.Name = "ArticuloNombre";
                        this.ArticuloNombre.Size = new System.Drawing.Size(320, 16);
                        this.ArticuloNombre.TabIndex = 7;
                        this.ArticuloNombre.TabStop = true;
                        this.ArticuloNombre.Text = "Nombre del artículo de ejemplo";
                        this.ArticuloNombre.UseMnemonic = false;
                        this.ArticuloNombre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ArticuloNombre_LinkClicked);
                        // 
                        // ArticuloStock
                        // 
                        this.ArticuloStock.AutoEllipsis = true;
                        this.ArticuloStock.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ArticuloStock.Location = new System.Drawing.Point(536, 0);
                        this.ArticuloStock.Name = "ArticuloStock";
                        this.ArticuloStock.Size = new System.Drawing.Size(80, 16);
                        this.ArticuloStock.TabIndex = 6;
                        this.ArticuloStock.Text = "12.345.67";
                        this.ArticuloStock.UseMnemonic = false;
                        // 
                        // label5
                        // 
                        this.label5.AutoEllipsis = true;
                        this.label5.Location = new System.Drawing.Point(496, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(42, 16);
                        this.label5.TabIndex = 5;
                        this.label5.Text = "Stock";
                        this.label5.UseMnemonic = false;
                        // 
                        // ArticuloPVP
                        // 
                        this.ArticuloPVP.AutoEllipsis = true;
                        this.ArticuloPVP.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ArticuloPVP.Location = new System.Drawing.Point(416, 0);
                        this.ArticuloPVP.Name = "ArticuloPVP";
                        this.ArticuloPVP.Size = new System.Drawing.Size(80, 16);
                        this.ArticuloPVP.TabIndex = 4;
                        this.ArticuloPVP.Text = "12.345.67";
                        this.ArticuloPVP.UseMnemonic = false;
                        // 
                        // ArticuloPrecio
                        // 
                        this.ArticuloPrecio.AutoEllipsis = true;
                        this.ArticuloPrecio.Location = new System.Drawing.Point(388, 0);
                        this.ArticuloPrecio.Name = "ArticuloPrecio";
                        this.ArticuloPrecio.Size = new System.Drawing.Size(30, 16);
                        this.ArticuloPrecio.TabIndex = 3;
                        this.ArticuloPrecio.Text = "PVP";
                        this.ArticuloPrecio.UseMnemonic = false;
                        // 
                        // ArticuloDescripcion
                        // 
                        this.ArticuloDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ArticuloDescripcion.AutoEllipsis = true;
                        this.ArticuloDescripcion.Location = new System.Drawing.Point(70, 16);
                        this.ArticuloDescripcion.Name = "ArticuloDescripcion";
                        this.ArticuloDescripcion.Size = new System.Drawing.Size(650, 32);
                        this.ArticuloDescripcion.TabIndex = 2;
                        this.ArticuloDescripcion.Text = "Ejemplo de descripción de artículo";
                        this.ArticuloDescripcion.UseMnemonic = false;
                        // 
                        // ArticuloCodigos
                        // 
                        this.ArticuloCodigos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)));
                        this.ArticuloCodigos.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ArticuloCodigos.Location = new System.Drawing.Point(0, 0);
                        this.ArticuloCodigos.Name = "ArticuloCodigos";
                        this.ArticuloCodigos.Size = new System.Drawing.Size(68, 48);
                        this.ArticuloCodigos.TabIndex = 0;
                        this.ArticuloCodigos.Text = "00000000";
                        this.ArticuloCodigos.TextAlign = System.Drawing.ContentAlignment.TopRight;
                        this.ArticuloCodigos.UseMnemonic = false;
                        // 
                        // PanelAyuda
                        // 
                        this.PanelAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelAyuda.Controls.Add(this.pictureBox1);
                        this.PanelAyuda.Controls.Add(this.AyudaTitulo);
                        this.PanelAyuda.Controls.Add(this.AyudaTexto);
                        this.PanelAyuda.Location = new System.Drawing.Point(2, 2);
                        this.PanelAyuda.Name = "PanelAyuda";
                        this.PanelAyuda.Size = new System.Drawing.Size(720, 48);
                        this.PanelAyuda.TabIndex = 2;
                        // 
                        // pictureBox1
                        // 
                        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                        this.pictureBox1.Location = new System.Drawing.Point(0, 0);
                        this.pictureBox1.Name = "pictureBox1";
                        this.pictureBox1.Size = new System.Drawing.Size(48, 48);
                        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.pictureBox1.TabIndex = 2;
                        this.pictureBox1.TabStop = false;
                        // 
                        // AyudaTitulo
                        // 
                        this.AyudaTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.AyudaTitulo.Location = new System.Drawing.Point(52, 0);
                        this.AyudaTitulo.Name = "AyudaTitulo";
                        this.AyudaTitulo.Size = new System.Drawing.Size(670, 20);
                        this.AyudaTitulo.TabIndex = 0;
                        this.AyudaTitulo.Text = "Ayuda dinámica";
                        this.AyudaTitulo.UseMnemonic = false;
                        // 
                        // AyudaTexto
                        // 
                        this.AyudaTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.AyudaTexto.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.AyudaTexto.Location = new System.Drawing.Point(52, 18);
                        this.AyudaTexto.Name = "AyudaTexto";
                        this.AyudaTexto.Size = new System.Drawing.Size(670, 30);
                        this.AyudaTexto.TabIndex = 1;
                        this.AyudaTexto.Text = "...";
                        this.AyudaTexto.UseMnemonic = false;
                        // 
                        // TimerReloj
                        // 
                        this.TimerReloj.Enabled = true;
                        this.TimerReloj.Interval = 1000;
                        this.TimerReloj.Tick += new System.EventHandler(this.TimerReloj_Tick);
                        // 
                        // PanelPersona
                        // 
                        this.PanelPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelPersona.Controls.Add(this.PersonaImagen);
                        this.PanelPersona.Controls.Add(this.EnlaceComentarios);
                        this.PanelPersona.Controls.Add(this.PersonaNombre);
                        this.PanelPersona.Controls.Add(this.label3);
                        this.PanelPersona.Controls.Add(this.PersonaGrupo);
                        this.PanelPersona.Controls.Add(this.PersonaComentario);
                        this.PanelPersona.Controls.Add(this.label1);
                        this.PanelPersona.Controls.Add(this.PersonaEmail);
                        this.PanelPersona.Controls.Add(this.label4);
                        this.PanelPersona.Controls.Add(this.PersonaDomicilio);
                        this.PanelPersona.Controls.Add(this.PersonaTelefono);
                        this.PanelPersona.Controls.Add(this.label2);
                        this.PanelPersona.Location = new System.Drawing.Point(2, 2);
                        this.PanelPersona.Name = "PanelPersona";
                        this.PanelPersona.Size = new System.Drawing.Size(718, 48);
                        this.PanelPersona.TabIndex = 2;
                        // 
                        // EnlaceComentarios
                        // 
                        this.EnlaceComentarios.AutoEllipsis = true;
                        this.EnlaceComentarios.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EnlaceComentarios.Location = new System.Drawing.Point(612, 32);
                        this.EnlaceComentarios.Name = "EnlaceComentarios";
                        this.EnlaceComentarios.Size = new System.Drawing.Size(106, 16);
                        this.EnlaceComentarios.TabIndex = 14;
                        this.EnlaceComentarios.TabStop = true;
                        this.EnlaceComentarios.Text = "Comentarios...";
                        this.EnlaceComentarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EnlaceComentarios.UseMnemonic = false;
                        this.EnlaceComentarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnlaceEtiquetas_LinkClicked);
                        // 
                        // PersonaNombre
                        // 
                        this.PersonaNombre.AutoEllipsis = true;
                        this.PersonaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PersonaNombre.Location = new System.Drawing.Point(54, 2);
                        this.PersonaNombre.Name = "PersonaNombre";
                        this.PersonaNombre.Size = new System.Drawing.Size(250, 16);
                        this.PersonaNombre.TabIndex = 12;
                        this.PersonaNombre.TabStop = true;
                        this.PersonaNombre.Text = "Nombre de la persona de ejemplo";
                        this.PersonaNombre.UseMnemonic = false;
                        this.PersonaNombre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PersonaNombre_LinkClicked);
                        // 
                        // label3
                        // 
                        this.label3.AutoEllipsis = true;
                        this.label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label3.Location = new System.Drawing.Point(304, 34);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(62, 16);
                        this.label3.TabIndex = 10;
                        this.label3.Text = "Grupo";
                        this.label3.UseMnemonic = false;
                        // 
                        // PersonaGrupo
                        // 
                        this.PersonaGrupo.AutoEllipsis = true;
                        this.PersonaGrupo.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PersonaGrupo.Location = new System.Drawing.Point(364, 32);
                        this.PersonaGrupo.Name = "PersonaGrupo";
                        this.PersonaGrupo.Size = new System.Drawing.Size(232, 16);
                        this.PersonaGrupo.TabIndex = 11;
                        this.PersonaGrupo.Text = "-";
                        this.PersonaGrupo.UseMnemonic = false;
                        // 
                        // PersonaComentario
                        // 
                        this.PersonaComentario.AutoEllipsis = true;
                        this.PersonaComentario.BackColor = System.Drawing.SystemColors.Control;
                        this.PersonaComentario.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PersonaComentario.Location = new System.Drawing.Point(54, 16);
                        this.PersonaComentario.Name = "PersonaComentario";
                        this.PersonaComentario.Size = new System.Drawing.Size(248, 32);
                        this.PersonaComentario.TabIndex = 9;
                        this.PersonaComentario.Text = "Comentario sobre la persona.";
                        this.PersonaComentario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.PersonaComentario.UseMnemonic = false;
                        this.PersonaComentario.Visible = false;
                        // 
                        // label1
                        // 
                        this.label1.AutoEllipsis = true;
                        this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label1.Location = new System.Drawing.Point(304, 18);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(62, 16);
                        this.label1.TabIndex = 8;
                        this.label1.Text = "Correo-e";
                        this.label1.UseMnemonic = false;
                        // 
                        // PersonaEmail
                        // 
                        this.PersonaEmail.AutoEllipsis = true;
                        this.PersonaEmail.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PersonaEmail.Location = new System.Drawing.Point(364, 18);
                        this.PersonaEmail.Name = "PersonaEmail";
                        this.PersonaEmail.Size = new System.Drawing.Size(232, 16);
                        this.PersonaEmail.TabIndex = 9;
                        this.PersonaEmail.Text = "info@dominio.com";
                        this.PersonaEmail.UseMnemonic = false;
                        // 
                        // label4
                        // 
                        this.label4.AutoEllipsis = true;
                        this.label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label4.Location = new System.Drawing.Point(304, 2);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(62, 16);
                        this.label4.TabIndex = 3;
                        this.label4.Text = "Domicilio";
                        this.label4.UseMnemonic = false;
                        // 
                        // PersonaDomicilio
                        // 
                        this.PersonaDomicilio.AutoEllipsis = true;
                        this.PersonaDomicilio.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PersonaDomicilio.Location = new System.Drawing.Point(364, 2);
                        this.PersonaDomicilio.Name = "PersonaDomicilio";
                        this.PersonaDomicilio.Size = new System.Drawing.Size(232, 16);
                        this.PersonaDomicilio.TabIndex = 4;
                        this.PersonaDomicilio.Text = "12.345.67";
                        this.PersonaDomicilio.UseMnemonic = false;
                        // 
                        // PersonaTelefono
                        // 
                        this.PersonaTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.PersonaTelefono.AutoEllipsis = true;
                        this.PersonaTelefono.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PersonaTelefono.Location = new System.Drawing.Point(654, 2);
                        this.PersonaTelefono.Name = "PersonaTelefono";
                        this.PersonaTelefono.Size = new System.Drawing.Size(110, 16);
                        this.PersonaTelefono.TabIndex = 6;
                        this.PersonaTelefono.Text = "01234 555-12364";
                        this.PersonaTelefono.UseMnemonic = false;
                        // 
                        // label2
                        // 
                        this.label2.AutoEllipsis = true;
                        this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label2.Location = new System.Drawing.Point(596, 2);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(64, 16);
                        this.label2.TabIndex = 5;
                        this.label2.Text = "Tel.";
                        this.label2.UseMnemonic = false;
                        // 
                        // TimerSlowLink
                        // 
                        this.TimerSlowLink.Interval = 1000;
                        this.TimerSlowLink.Tick += new System.EventHandler(this.TimerSlowLink_Tick);
                        // 
                        // PersonaImagen
                        // 
                        this.PersonaImagen.Location = new System.Drawing.Point(0, 0);
                        this.PersonaImagen.Name = "PersonaImagen";
                        this.PersonaImagen.Size = new System.Drawing.Size(52, 48);
                        this.PersonaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        this.PersonaImagen.TabIndex = 15;
                        this.PersonaImagen.TabStop = false;
                        // 
                        // BarraInferior
                        // 
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                        this.Controls.Add(this.PanelReloj);
                        this.Controls.Add(this.PanelPersona);
                        this.Controls.Add(this.PanelAyuda);
                        this.Controls.Add(this.PanelArticulo);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.Name = "BarraInferior";
                        this.Size = new System.Drawing.Size(800, 52);
                        this.PanelReloj.ResumeLayout(false);
                        this.PanelArticulo.ResumeLayout(false);
                        this.PanelAyuda.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                        this.PanelPersona.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.PersonaImagen)).EndInit();
                        this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelReloj;
		private System.Windows.Forms.Label RelojFecha;
		private System.Windows.Forms.Label RelojHora;
		private System.Windows.Forms.Panel PanelArticulo;
		private System.Windows.Forms.Label ArticuloCodigos;
		private System.Windows.Forms.LinkLabel ArticuloNombre;
		private System.Windows.Forms.Label ArticuloStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label ArticuloPVP;
		private System.Windows.Forms.Label ArticuloPrecio;
		private System.Windows.Forms.Label ArticuloDescripcion;
		private System.Windows.Forms.Timer TimerReloj;
		private System.Windows.Forms.Panel PanelAyuda;
		private System.Windows.Forms.Label AyudaTexto;
		private System.Windows.Forms.Label AyudaTitulo;
		private System.Windows.Forms.Label PersonaTelefono;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label PersonaDomicilio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel PanelPersona;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label PersonaEmail;
		private System.Windows.Forms.Label PersonaComentario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label PersonaGrupo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel PersonaNombre;
                private System.Windows.Forms.Timer TimerSlowLink;
        private System.Windows.Forms.LinkLabel EnlaceComentarios;
        private System.Windows.Forms.PictureBox PersonaImagen;
	}
}
