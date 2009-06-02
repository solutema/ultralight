// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.Misc.Backup
{
	public class Manager : Lui.Forms.DialogForm
	{
		#region Código generado por el Diseñador de Windows Forms

		public Manager()
			: base()
		{


			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
			OkButton.Visible = false;
			MostrarListaBackups();
		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.Container components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal Lui.Forms.Button cmdBackup;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ListView lvItems;
		internal System.Windows.Forms.ColumnHeader FechaYHora;
		internal System.Windows.Forms.ColumnHeader Usuario;
		internal System.Windows.Forms.ColumnHeader Carpeta;
		internal Lui.Forms.Button cmdEliminar;
		internal Lui.Forms.Button cmdRestaurar;
		internal System.Windows.Forms.ColumnHeader Numero;
		internal Lui.Forms.Button cmdWeb;
		internal Lui.Forms.Button cmdCopiar;
		private Lui.Forms.Note note1;
		internal System.Windows.Forms.PictureBox PictureBox1;

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
			this.cmdBackup = new Lui.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
                        this.lvItems = new Lui.Forms.ListView();
			this.Carpeta = new System.Windows.Forms.ColumnHeader();
			this.Numero = new System.Windows.Forms.ColumnHeader();
			this.FechaYHora = new System.Windows.Forms.ColumnHeader();
			this.Usuario = new System.Windows.Forms.ColumnHeader();
			this.Label2 = new System.Windows.Forms.Label();
			this.cmdEliminar = new Lui.Forms.Button();
			this.cmdRestaurar = new Lui.Forms.Button();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmdWeb = new Lui.Forms.Button();
			this.cmdCopiar = new Lui.Forms.Button();
			this.note1 = new Lui.Forms.Note();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(385, 8);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Location = new System.Drawing.Point(493, 8);
			// 
			// cmdBackup
			// 
			this.cmdBackup.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdBackup.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdBackup.Image = null;
			this.cmdBackup.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdBackup.Location = new System.Drawing.Point(144, 25);
			this.cmdBackup.Name = "cmdBackup";
			this.cmdBackup.Padding = new System.Windows.Forms.Padding(2);
			this.cmdBackup.ReadOnly = false;
			this.cmdBackup.Size = new System.Drawing.Size(108, 36);
			this.cmdBackup.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.cmdBackup.Subtext = "F8";
			this.cmdBackup.TabIndex = 0;
			this.cmdBackup.Text = "Respaldar";
			this.cmdBackup.ToolTipText = "";
			this.cmdBackup.Click += new System.EventHandler(this.cmdBackup_Click);
			// 
			// Label1
			// 
			this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(12, 88);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(577, 22);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Para hacer una copia de respaldo ahora, haga clic en el botón \"Respaldar\".";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lvItems
			// 
			this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Carpeta,
            this.Numero,
            this.FechaYHora,
            this.Usuario});
			this.lvItems.FullRowSelect = true;
			this.lvItems.GridLines = true;
			this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvItems.HideSelection = false;
			this.lvItems.Location = new System.Drawing.Point(12, 148);
			this.lvItems.Name = "lvItems";
			this.lvItems.Size = new System.Drawing.Size(456, 144);
			this.lvItems.TabIndex = 3;
			this.lvItems.UseCompatibleStateImageBehavior = false;
			this.lvItems.View = System.Windows.Forms.View.Details;
			// 
			// Carpeta
			// 
			this.Carpeta.Text = "Carpeta";
			this.Carpeta.Width = 0;
			// 
			// Numero
			// 
			this.Numero.Text = "#";
			this.Numero.Width = 30;
			// 
			// FechaYHora
			// 
			this.FechaYHora.Text = "Fecha y Hora";
			this.FechaYHora.Width = 204;
			// 
			// Usuario
			// 
			this.Usuario.Text = "Usuario";
			this.Usuario.Width = 171;
			// 
			// Label2
			// 
			this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(12, 125);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(456, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Copias de respaldo presentes en el sistema:";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdEliminar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdEliminar.Image = null;
			this.cmdEliminar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdEliminar.Location = new System.Drawing.Point(481, 148);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Padding = new System.Windows.Forms.Padding(2);
			this.cmdEliminar.ReadOnly = false;
			this.cmdEliminar.Size = new System.Drawing.Size(108, 36);
			this.cmdEliminar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.cmdEliminar.Subtext = "F3";
			this.cmdEliminar.TabIndex = 4;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.ToolTipText = "";
			this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
			// 
			// cmdRestaurar
			// 
			this.cmdRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRestaurar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRestaurar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdRestaurar.Image = null;
			this.cmdRestaurar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdRestaurar.Location = new System.Drawing.Point(481, 192);
			this.cmdRestaurar.Name = "cmdRestaurar";
			this.cmdRestaurar.Padding = new System.Windows.Forms.Padding(2);
			this.cmdRestaurar.ReadOnly = false;
			this.cmdRestaurar.Size = new System.Drawing.Size(108, 36);
			this.cmdRestaurar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.cmdRestaurar.Subtext = "F6";
			this.cmdRestaurar.TabIndex = 5;
			this.cmdRestaurar.Text = "Restaurar";
			this.cmdRestaurar.ToolTipText = "";
			this.cmdRestaurar.Click += new System.EventHandler(this.cmdRestaurar_Click);
			// 
			// PictureBox1
			// 
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(12, 12);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(126, 64);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 51;
			this.PictureBox1.TabStop = false;
			// 
			// cmdWeb
			// 
			this.cmdWeb.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdWeb.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdWeb.Image = null;
			this.cmdWeb.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdWeb.Location = new System.Drawing.Point(416, 8);
			this.cmdWeb.Name = "cmdWeb";
			this.cmdWeb.Padding = new System.Windows.Forms.Padding(2);
			this.cmdWeb.ReadOnly = false;
			this.cmdWeb.Size = new System.Drawing.Size(176, 28);
			this.cmdWeb.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.cmdWeb.Subtext = "Esc";
			this.cmdWeb.TabIndex = 10;
			this.cmdWeb.Text = "Exportar para la Web";
			this.cmdWeb.ToolTipText = "";
			this.cmdWeb.Visible = false;
			this.cmdWeb.Click += new System.EventHandler(this.cmdWeb_Click);
			// 
			// cmdCopiar
			// 
			this.cmdCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCopiar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCopiar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCopiar.Image = null;
			this.cmdCopiar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdCopiar.Location = new System.Drawing.Point(481, 236);
			this.cmdCopiar.Name = "cmdCopiar";
			this.cmdCopiar.Padding = new System.Windows.Forms.Padding(2);
			this.cmdCopiar.ReadOnly = false;
			this.cmdCopiar.Size = new System.Drawing.Size(108, 36);
			this.cmdCopiar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.cmdCopiar.Subtext = "F6";
			this.cmdCopiar.TabIndex = 6;
			this.cmdCopiar.Text = "Examinar";
			this.cmdCopiar.ToolTipText = "";
			this.cmdCopiar.Click += new System.EventHandler(this.cmdCopiar_Click);
			// 
			// note1
			// 
			this.note1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.note1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.note1.Location = new System.Drawing.Point(12, 304);
			this.note1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.note1.Name = "note1";
			this.note1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.note1.ReadOnly = false;
			this.note1.Size = new System.Drawing.Size(580, 72);
			this.note1.TabIndex = 52;
			this.note1.Text = "Se mantienen automáticamente las últimas 7 copias de respaldo. La copia en letra " +
			    "negrita es la más reciente.";
			this.note1.Title = "Información";
			this.note1.ToolTipText = "";
			// 
			// Manager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(601, 447);
			this.Controls.Add(this.note1);
			this.Controls.Add(this.cmdCopiar);
			this.Controls.Add(this.cmdWeb);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.cmdRestaurar);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.lvItems);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cmdBackup);
			this.Name = "Manager";
			this.Text = "Administrador de Copias de Respaldo";
			this.Controls.SetChildIndex(this.cmdBackup, 0);
			this.Controls.SetChildIndex(this.Label1, 0);
			this.Controls.SetChildIndex(this.lvItems, 0);
			this.Controls.SetChildIndex(this.Label2, 0);
			this.Controls.SetChildIndex(this.cmdEliminar, 0);
			this.Controls.SetChildIndex(this.cmdRestaurar, 0);
			this.Controls.SetChildIndex(this.PictureBox1, 0);
			this.Controls.SetChildIndex(this.cmdWeb, 0);
			this.Controls.SetChildIndex(this.cmdCopiar, 0);
			this.Controls.SetChildIndex(this.note1, 0);
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		public void MostrarListaBackups()
		{
			System.Collections.ArrayList Backups = Misc.Backup.Services.ListaBackups();
			string BackupMasNuevo = Misc.Backup.Services.BackupMasNuevo();

			lvItems.BeginUpdate();
			lvItems.Items.Clear();
			int i = 1;
			foreach (string NombreCarpeta in Backups)
			{
				string ArchivoIni = Lfx.Types.Strings.ReadTextFile(Misc.Backup.Services.BackupPath + NombreCarpeta + System.IO.Path.DirectorySeparatorChar + "info.txt");
				ListViewItem Itm = new ListViewItem();
				Itm = lvItems.Items.Add(NombreCarpeta);
				if (BackupMasNuevo == NombreCarpeta)
				{
					Itm.Font = new Font(Itm.Font, FontStyle.Bold);
					Itm.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataareaActive;
				}
				Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, System.Convert.ToString(i)));
				Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Ini.ReadString(ArchivoIni, "", "FechaYHora")));
				Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Ini.ReadString(ArchivoIni, "", "Usuario")));
				i++;
			}
			lvItems.Sorting = SortOrder.Descending;
			lvItems.Sort();
			lvItems.EndUpdate();
		}


		private void cmdBackup_Click(System.Object sender, System.EventArgs e)
		{
			cmdBackup.Enabled = false;
			Aplicacion.Exec("BACKUP NOW");
			MostrarListaBackups();
		}


		private void cmdEliminar_Click(object sender, System.EventArgs e)
		{
			if (lvItems.SelectedItems.Count > 0 && lvItems.SelectedItems[0] != null)
			{
				string NombreCarpeta = lvItems.SelectedItems[0].Text;
				Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Puede eliminar una copia de respaldo antigua o que ya no sea de utilidad. Al eliminar una copia de respaldo no se modifican los datos actualmente almacenados en el sistema, ni tampoco se impide que el sistema haga nuevas copias de respaldo.", "¿Desea eliminar la copia de respaldo seleccionada?");
				Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
				if (Pregunta.ShowDialog() == DialogResult.OK)
				{
					Misc.Backup.Services.DeleteBackup(NombreCarpeta);
					MostrarListaBackups();
				}
			}
		}


		private void cmdRestaurar_Click(object sender, System.EventArgs e)
		{
			if (lvItems.SelectedItems.Count > 0 && lvItems.SelectedItems[0] != null)
			{
				string NombreCarpeta = lvItems.SelectedItems[0].Text;
				string FechaYHora = lvItems.SelectedItems[0].SubItems[2].Text;

				Misc.Backup.Restore OPregunta = new Misc.Backup.Restore();
				OPregunta.lblFecha.Text = FechaYHora;
				if (OPregunta.ShowDialog() == DialogResult.OK)
				{
					Misc.Backup.Services.Restore(NombreCarpeta);
				}
			}
		}

		private void cmdWeb_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog DialogoGuardar = new SaveFileDialog();
			DialogoGuardar.Filter = "Archivos SQL|*.sql|Todos los archivos|*.*";
			DialogoGuardar.CheckPathExists = true;
			DialogoGuardar.OverwritePrompt = true;
			DialogoGuardar.FileName = "web";
			if (DialogoGuardar.ShowDialog() == DialogResult.OK)
			{
				string NombreArchivo = DialogoGuardar.FileName;

				System.IO.StreamWriter Writer = new System.IO.StreamWriter(NombreArchivo, false, System.Text.Encoding.Default);

				// Exportar artículos
				Writer.Write("DELETE FROM articulos;" + Environment.NewLine);
				Lfx.Data.SqlSelectBuilder ComandoSelect = new Lfx.Data.SqlSelectBuilder(Lfx.Data.SqlModes.MySql);
				ComandoSelect.Tables = "articulos";
				ComandoSelect.Fields = "id_articulo,id_marca,modelo,serie,nombre,url,descripcion,descripcion2,id_cat_articulo,pvp,stock_actual,pedido,destacado,web";
				Misc.Backup.Services.ExportTable(ComandoSelect, false, Writer);

				ComandoSelect = new Lfx.Data.SqlSelectBuilder(Lfx.Data.SqlModes.MySql);
				ComandoSelect.Tables = "articulos_imagenes";
				Misc.Backup.Services.ExportBlobs(ComandoSelect, System.IO.Path.GetDirectoryName(NombreArchivo));

				// Exportar cat_articulos
				Writer.Write("DELETE FROM cat_articulos;" + Environment.NewLine);
				ComandoSelect = new Lfx.Data.SqlSelectBuilder(Lfx.Data.SqlModes.MySql);
				ComandoSelect.Tables = "cat_articulos";
				ComandoSelect.Fields = "id_cat_articulo,nombre,imagen,web";
				Misc.Backup.Services.ExportTable(ComandoSelect, false, Writer);

				// Exportar marcas
				Writer.Write("DELETE FROM marcas;" + Environment.NewLine);
				ComandoSelect = new Lfx.Data.SqlSelectBuilder(Lfx.Data.SqlModes.MySql);
				ComandoSelect.Tables = "marcas";
				ComandoSelect.Fields = "id_marca,nombre,url";
                                Misc.Backup.Services.ExportTable(ComandoSelect, false, Writer);

				Writer.Close();
			}
		}

		private void cmdCopiar_Click(object sender, EventArgs e)
		{
			Lfx.Environment.Shell.Execute(Lfx.Environment.Folders.ApplicationDataFolder + @"Backup\", "", ProcessWindowStyle.Normal, false);
		}
	}
}
