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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Pvs
{
	public class Editar : Lui.Forms.EditForm
	{
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label2;
		internal Lui.Forms.TextBox txtPV;
                internal Lui.Forms.ComboBox txtTipo;
		internal Lui.Forms.TextBox txtEstacion;
		internal Lui.Forms.ComboBox txtCarga;
		internal Lui.Forms.Button cmdEstacionSeleccionar;
		internal Lui.Forms.DetailBox txtSucursal;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label label7;
                internal Lui.Forms.ComboBox txtModelo;
                internal Lui.Forms.ComboBox txtPuerto;
		internal Lui.Forms.ComboBox txtBps;
		private Lui.Forms.Note note1;
		private System.ComponentModel.IContainer components = null;

		public Editar()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Label3 = new System.Windows.Forms.Label();
			this.txtPV = new Lui.Forms.TextBox();
                        this.txtTipo = new Lui.Forms.ComboBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEstacion = new Lui.Forms.TextBox();
                        this.txtCarga = new Lui.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmdEstacionSeleccionar = new Lui.Forms.Button();
			this.txtSucursal = new Lui.Forms.DetailBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
                        this.txtModelo = new Lui.Forms.ComboBox();
                        this.txtPuerto = new Lui.Forms.ComboBox();
                        this.txtBps = new Lui.Forms.ComboBox();
			this.note1 = new Lui.Forms.Note();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(409, 7);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Location = new System.Drawing.Point(517, 7);
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(20, 20);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(140, 24);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "Punto de Venta";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPV
			// 
			this.txtPV.AutoNav = true;
			this.txtPV.AutoTab = true;
			this.txtPV.DataType = Lui.Forms.DataTypes.Integer;
			this.txtPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPV.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPV.Location = new System.Drawing.Point(160, 20);
			this.txtPV.MaxLenght = 32767;
			this.txtPV.Name = "txtPV";
			this.txtPV.Padding = new System.Windows.Forms.Padding(2);
			this.txtPV.ReadOnly = false;
			this.txtPV.Size = new System.Drawing.Size(72, 24);
			this.txtPV.TabIndex = 1;
			this.txtPV.Text = "0";
			this.txtPV.TipWhenBlank = "";
			this.txtPV.ToolTipText = "";
			// 
			// EntradaTipo
			// 
			this.txtTipo.AutoNav = true;
			this.txtTipo.AutoTab = true;
			this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtTipo.Location = new System.Drawing.Point(160, 76);
			this.txtTipo.MaxLenght = 32767;
			this.txtTipo.Name = "EntradaTipo";
			this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
			this.txtTipo.ReadOnly = false;
			this.txtTipo.SetData = new string[] {
        "Inactivo|0",
        "Impresora Normal|1",
        "Impresora Fiscal|2"};
			this.txtTipo.Size = new System.Drawing.Size(208, 24);
			this.txtTipo.TabIndex = 5;
			this.txtTipo.Text = "Impresora Normal";
			this.txtTipo.TextKey = "1";
			this.txtTipo.TipWhenBlank = "";
			this.txtTipo.ToolTipText = "";
			this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
			// 
			// Label16
			// 
			this.Label16.Location = new System.Drawing.Point(20, 76);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(140, 24);
			this.Label16.TabIndex = 4;
			this.Label16.Text = "Tipo";
			this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Estación";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEstacion
			// 
			this.txtEstacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEstacion.AutoNav = true;
			this.txtEstacion.AutoTab = true;
			this.txtEstacion.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtEstacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstacion.ForceCase = Lui.Forms.TextCasing.UpperCase;
			this.txtEstacion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtEstacion.Location = new System.Drawing.Point(160, 104);
			this.txtEstacion.MaxLenght = 32767;
			this.txtEstacion.Name = "txtEstacion";
			this.txtEstacion.Padding = new System.Windows.Forms.Padding(2);
			this.txtEstacion.ReadOnly = false;
			this.txtEstacion.Size = new System.Drawing.Size(409, 24);
			this.txtEstacion.TabIndex = 7;
			this.txtEstacion.TipWhenBlank = "";
			this.txtEstacion.ToolTipText = "";
			// 
			// txtCarga
			// 
			this.txtCarga.AutoNav = true;
			this.txtCarga.AutoTab = true;
			this.txtCarga.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCarga.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCarga.Location = new System.Drawing.Point(184, 224);
			this.txtCarga.MaxLenght = 32767;
			this.txtCarga.Name = "txtCarga";
			this.txtCarga.Padding = new System.Windows.Forms.Padding(2);
			this.txtCarga.ReadOnly = false;
			this.txtCarga.SetData = new string[] {
        "Automática|0",
        "Manual|1"};
			this.txtCarga.Size = new System.Drawing.Size(208, 24);
			this.txtCarga.TabIndex = 15;
			this.txtCarga.Text = "Automática";
			this.txtCarga.TextKey = "0";
			this.txtCarga.TipWhenBlank = "";
			this.txtCarga.ToolTipText = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(44, 224);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 24);
			this.label2.TabIndex = 14;
			this.label2.Text = "Carga de Papel";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmdEstacionSeleccionar
			// 
			this.cmdEstacionSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdEstacionSeleccionar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEstacionSeleccionar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdEstacionSeleccionar.Image = null;
			this.cmdEstacionSeleccionar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdEstacionSeleccionar.Location = new System.Drawing.Point(573, 104);
			this.cmdEstacionSeleccionar.Name = "cmdEstacionSeleccionar";
			this.cmdEstacionSeleccionar.Padding = new System.Windows.Forms.Padding(2);
			this.cmdEstacionSeleccionar.ReadOnly = false;
			this.cmdEstacionSeleccionar.Size = new System.Drawing.Size(28, 24);
			this.cmdEstacionSeleccionar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.cmdEstacionSeleccionar.Subtext = "";
			this.cmdEstacionSeleccionar.TabIndex = 8;
			this.cmdEstacionSeleccionar.Text = "...";
			this.cmdEstacionSeleccionar.ToolTipText = "Ver historial de movimientos de stock";
			this.cmdEstacionSeleccionar.Click += new System.EventHandler(this.cmdEstacionSeleccionar_Click);
			// 
			// txtSucursal
			// 
			this.txtSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSucursal.AutoTab = true;
			this.txtSucursal.CanCreate = true;
			this.txtSucursal.DetailField = "nombre";
			this.txtSucursal.ExtraDetailFields = null;
			this.txtSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtSucursal.FreeTextCode = "";
			this.txtSucursal.KeyField = "id_sucursal";
			this.txtSucursal.Location = new System.Drawing.Point(160, 48);
			this.txtSucursal.MaxLength = 200;
			this.txtSucursal.Name = "txtSucursal";
			this.txtSucursal.Padding = new System.Windows.Forms.Padding(2);
			this.txtSucursal.ReadOnly = false;
			this.txtSucursal.Required = true;
			this.txtSucursal.SelectOnFocus = false;
			this.txtSucursal.Size = new System.Drawing.Size(409, 24);
			this.txtSucursal.TabIndex = 3;
			this.txtSucursal.Table = "sucursales";
			this.txtSucursal.TeclaDespuesDeEnter = "{tab}";
			this.txtSucursal.Text = "0";
			this.txtSucursal.TextDetail = "";
			this.txtSucursal.TextInt = 0;
			this.txtSucursal.TipWhenBlank = "";
			this.txtSucursal.ToolTipText = "Rubro o categoría";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "Sucursal";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(44, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(140, 24);
			this.label5.TabIndex = 8;
			this.label5.Text = "Modelo";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(44, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(140, 24);
			this.label6.TabIndex = 10;
			this.label6.Text = "Puerto";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(44, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(140, 24);
			this.label7.TabIndex = 12;
			this.label7.Text = "Velocidad";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtModelo
			// 
			this.txtModelo.AutoNav = true;
			this.txtModelo.AutoTab = true;
			this.txtModelo.Enabled = false;
			this.txtModelo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModelo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtModelo.Location = new System.Drawing.Point(184, 136);
			this.txtModelo.MaxLenght = 32767;
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Padding = new System.Windows.Forms.Padding(2);
			this.txtModelo.ReadOnly = false;
			this.txtModelo.SetData = new string[] {
        "Hasar|100",
        "Epson|300",
        "Emulación|1"};
			this.txtModelo.Size = new System.Drawing.Size(136, 24);
			this.txtModelo.TabIndex = 9;
			this.txtModelo.Text = "Epson";
			this.txtModelo.TextKey = "300";
			this.txtModelo.TipWhenBlank = "";
			this.txtModelo.ToolTipText = "";
			// 
			// txtPuerto
			// 
			this.txtPuerto.AutoNav = true;
			this.txtPuerto.AutoTab = true;
			this.txtPuerto.Enabled = false;
			this.txtPuerto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPuerto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPuerto.Location = new System.Drawing.Point(184, 164);
			this.txtPuerto.MaxLenght = 32767;
			this.txtPuerto.Name = "txtPuerto";
			this.txtPuerto.Padding = new System.Windows.Forms.Padding(2);
			this.txtPuerto.ReadOnly = false;
			this.txtPuerto.SetData = new string[] {
        "COM1|1",
        "COM2|2"};
			this.txtPuerto.Size = new System.Drawing.Size(136, 24);
			this.txtPuerto.TabIndex = 11;
			this.txtPuerto.Text = "COM1";
			this.txtPuerto.TextKey = "1";
			this.txtPuerto.TipWhenBlank = "";
			this.txtPuerto.ToolTipText = "";
			// 
			// txtBps
			// 
			this.txtBps.AutoNav = true;
			this.txtBps.AutoTab = true;
			this.txtBps.Enabled = false;
			this.txtBps.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBps.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtBps.Location = new System.Drawing.Point(184, 192);
			this.txtBps.MaxLenght = 32767;
			this.txtBps.Name = "txtBps";
			this.txtBps.Padding = new System.Windows.Forms.Padding(2);
			this.txtBps.ReadOnly = false;
			this.txtBps.SetData = new string[] {
        "9600 bps|9600",
        "19200 bps|19200"};
			this.txtBps.Size = new System.Drawing.Size(136, 24);
			this.txtBps.TabIndex = 13;
			this.txtBps.Text = "9600 bps";
			this.txtBps.TextKey = "9600";
			this.txtBps.TipWhenBlank = "";
			this.txtBps.ToolTipText = "";
			// 
			// note1
			// 
			this.note1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.note1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.note1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.note1.Location = new System.Drawing.Point(12, 324);
			this.note1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.note1.Name = "note1";
			this.note1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.note1.ReadOnly = false;
			this.note1.Size = new System.Drawing.Size(600, 72);
			this.note1.TabIndex = 104;
			this.note1.Text = "Si desea cambiar el punto de venta predeterminado para las facturas u otros docum" +
			    "entos, utilice la opción Preferencias del menú Sistema.";
			this.note1.Title = "Información";
			this.note1.ToolTipText = "";
			// 
			// Editar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(625, 467);
			this.Controls.Add(this.note1);
			this.Controls.Add(this.txtBps);
			this.Controls.Add(this.txtPuerto);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtSucursal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmdEstacionSeleccionar);
			this.Controls.Add(this.txtCarga);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEstacion);
			this.Controls.Add(this.txtTipo);
			this.Controls.Add(this.Label16);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.txtPV);
			this.Name = "Editar";
			this.ResumeLayout(false);

		}
		#endregion

		public override Lfx.Types.OperationResult Edit(int lId)
		{
			if(!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "global.admin"))
				return new Lfx.Types.NoAccessOperationResult();

			Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("pvs", "id_pv", lId);

			if(Registro == null)
			{
				return new Lfx.Types.FailureOperationResult("El registro no existe");
			}
			else
			{
				m_Nuevo = false;

				txtPV.Text = System.Convert.ToString(Registro["id_pv"]);
				m_Id = System.Convert.ToInt32(Registro["id_pv"]);

				txtTipo.TextKey = System.Convert.ToString(Registro["tipo"]);
				txtSucursal.TextInt = System.Convert.ToInt32(Registro["id_sucursal"]);
				txtEstacion.Text = System.Convert.ToString(Registro["estacion"]);
				txtCarga.TextKey = System.Convert.ToString(Registro["carga"]);

				txtModelo.TextKey = System.Convert.ToString(Registro["modelo"]);
				txtPuerto.TextKey = System.Convert.ToString(Registro["puerto"]);
				txtBps.TextKey = System.Convert.ToString(Registro["bps"]);

				this.Text = "Punto de Venta " + txtPV.Text;
				return new Lfx.Types.SuccessOperationResult();
			}
		}

		public override Lfx.Types.OperationResult Create()
		{
			txtPV.Text = this.Workspace.DefaultDataBase.FieldInt("SELECT MAX(id_pv)+1 FROM pvs").ToString();
			return new Lfx.Types.SuccessOperationResult();
		}

		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = new Lfx.Types.SuccessOperationResult();

			ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true)
			{
                                DataView.DataBase.BeginTransaction();

                                Lfx.Data.SqlTableCommandBuilder Comando;
                                if (m_Nuevo) {
                                        Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "pvs");
                                        Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                                } else {
                                        Comando = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "pvs");
                                        Comando.WhereClause = new Lfx.Data.SqlWhereBuilder("id_pv", m_Id);
                                }

				Comando.Fields.AddWithValue("id_pv", Lfx.Types.Parsing.ParseInt(txtPV.Text));
				Comando.Fields.AddWithValue("id_sucursal", Lfx.Data.DataBase.ConvertZeroToDBNull(txtSucursal.TextInt));
				Comando.Fields.AddWithValue("tipo", Lfx.Types.Parsing.ParseInt(txtTipo.TextKey));
				Comando.Fields.AddWithValue("estacion", txtEstacion.Text);
				Comando.Fields.AddWithValue("carga", Lfx.Types.Parsing.ParseInt(txtCarga.TextKey));
				Comando.Fields.AddWithValue("modelo", Lfx.Types.Parsing.ParseInt(txtModelo.TextKey));
				Comando.Fields.AddWithValue("puerto", Lfx.Types.Parsing.ParseInt(txtPuerto.TextKey));
				Comando.Fields.AddWithValue("bps", Lfx.Types.Parsing.ParseInt(txtBps.TextKey));

				try
				{
                                        DataView.Execute(Comando);
				}
				catch(Exception ex)
				{
					return new Lfx.Types.FailureOperationResult(ex.ToString());
				}

				if(m_Nuevo)
                                        m_Id = DataView.DataBase.FieldInt("SELECT MAX(id_pv) FROM pvs");

                                DataView.DataBase.Commit();

                                if (m_Nuevo && ControlDestino != null) {
                                        ControlDestino.Text = m_Id.ToString();
                                        ControlDestino.Focus();
                                }

				m_Nuevo = false;
				ResultadoGuardar = base.Save();
			}
			
			return ResultadoGuardar;
		}

		private void cmdEstacionSeleccionar_Click(object sender, System.EventArgs e)
		{
                        Lui.Forms.WorkstationSelectorForm SelEst = new Lui.Forms.WorkstationSelectorForm();
			SelEst.Estacion = txtEstacion.Text;
			SelEst.Workspace = this.Workspace;
			if(SelEst.ShowDialog() == DialogResult.OK)
				txtEstacion.Text = SelEst.Estacion;
		}

		private void txtTipo_TextChanged(object sender, System.EventArgs e)
		{
			if(txtTipo.TextKey == "2")
			{
				txtModelo.Enabled = true;
				txtPuerto.Enabled = true;
				txtBps.Enabled = true;
				txtCarga.Enabled = false;
			}
			else
			{
				txtModelo.Enabled = false;
				txtPuerto.Enabled = false;
				txtBps.Enabled = false;
				txtCarga.Enabled = true;
			}
		}
	}
}

