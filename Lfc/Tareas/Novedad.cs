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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Tareas
{
        public class Novedad : Lui.Forms.EditForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public Novedad()
                        : base()
                {


                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent

                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
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
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.DetailBox txtTecnico;
                internal Lui.Forms.TextBox txtDescripcion;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.TextBox txtMinutos;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.ComboBox txtCondicion;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.DetailBox txtTicket;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtTecnico = new Lui.Forms.DetailBox();
                        this.txtDescripcion = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtMinutos = new Lui.Forms.TextBox();
                        this.txtCondicion = new Lui.Forms.ComboBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtTicket = new Lui.Forms.DetailBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(418, 10);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(526, 10);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(12, 212);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(72, 24);
                        this.Label1.TabIndex = 8;
                        this.Label1.Text = "Persona";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTecnico
                        // 
                        this.txtTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTecnico.AutoHeight = false;
                        this.txtTecnico.AutoTab = true;
                        this.txtTecnico.CanCreate = true;
                        this.txtTecnico.DetailField = "nombre_visible";
                        this.txtTecnico.ExtraDetailFields = null;
                        this.txtTecnico.Filter = "(tipo&4)=4";
                        this.txtTecnico.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTecnico.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTecnico.FreeTextCode = "";
                        this.txtTecnico.KeyField = "id_persona";
                        this.txtTecnico.Location = new System.Drawing.Point(84, 212);
                        this.txtTecnico.MaxLength = 200;
                        this.txtTecnico.Name = "txtTecnico";
                        this.txtTecnico.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTecnico.ReadOnly = false;
                        this.txtTecnico.Required = true;
                        this.txtTecnico.SelectOnFocus = true;
                        this.txtTecnico.Size = new System.Drawing.Size(540, 24);
                        this.txtTecnico.TabIndex = 9;
                        this.txtTecnico.Table = "personas";
                        this.txtTecnico.TeclaDespuesDeEnter = "{tab}";
                        this.txtTecnico.Text = "0";
                        this.txtTecnico.TextDetail = "";
                        this.txtTecnico.TextInt = 0;
                        this.txtTecnico.TipWhenBlank = "";
                        this.txtTecnico.ToolTipText = "";
                        // 
                        // txtDescripcion
                        // 
                        this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtDescripcion.AutoHeight = false;
                        this.txtDescripcion.AutoNav = true;
                        this.txtDescripcion.AutoTab = true;
                        this.txtDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtDescripcion.DecimalPlaces = -1;
                        this.txtDescripcion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDescripcion.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtDescripcion.Location = new System.Drawing.Point(84, 44);
                        this.txtDescripcion.MaxLenght = 32767;
                        this.txtDescripcion.MultiLine = true;
                        this.txtDescripcion.Name = "txtDescripcion";
                        this.txtDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDescripcion.PasswordChar = '\0';
                        this.txtDescripcion.Prefijo = "";
                        this.txtDescripcion.ReadOnly = false;
                        this.txtDescripcion.SelectOnFocus = true;
                        this.txtDescripcion.Size = new System.Drawing.Size(540, 124);
                        this.txtDescripcion.Sufijo = "";
                        this.txtDescripcion.TabIndex = 3;
                        this.txtDescripcion.TextRaw = "";
                        this.txtDescripcion.TipWhenBlank = "";
                        this.txtDescripcion.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(268, 180);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(68, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Tiempo";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtMinutos
                        // 
                        this.txtMinutos.AutoHeight = false;
                        this.txtMinutos.AutoNav = true;
                        this.txtMinutos.AutoTab = true;
                        this.txtMinutos.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtMinutos.DecimalPlaces = -1;
                        this.txtMinutos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtMinutos.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtMinutos.Location = new System.Drawing.Point(336, 180);
                        this.txtMinutos.MaxLenght = 32767;
                        this.txtMinutos.MultiLine = false;
                        this.txtMinutos.Name = "txtMinutos";
                        this.txtMinutos.Padding = new System.Windows.Forms.Padding(2);
                        this.txtMinutos.PasswordChar = '\0';
                        this.txtMinutos.Prefijo = "";
                        this.txtMinutos.ReadOnly = false;
                        this.txtMinutos.SelectOnFocus = true;
                        this.txtMinutos.Size = new System.Drawing.Size(76, 24);
                        this.txtMinutos.Sufijo = "";
                        this.txtMinutos.TabIndex = 5;
                        this.txtMinutos.TextRaw = "";
                        this.txtMinutos.TipWhenBlank = "";
                        this.txtMinutos.ToolTipText = "";
                        // 
                        // txtCondicion
                        // 
                        this.txtCondicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCondicion.AutoHeight = false;
                        this.txtCondicion.AutoNav = true;
                        this.txtCondicion.AutoTab = true;
                        this.txtCondicion.DetailField = null;
                        this.txtCondicion.Filter = null;
                        this.txtCondicion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCondicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCondicion.KeyField = null;
                        this.txtCondicion.Location = new System.Drawing.Point(84, 180);
                        this.txtCondicion.MaxLenght = 32767;
                        this.txtCondicion.Name = "txtCondicion";
                        this.txtCondicion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCondicion.ReadOnly = false;
                        this.txtCondicion.SetData = new string[] {
        "Publica|0",
        "Interna|1"};
                        this.txtCondicion.Size = new System.Drawing.Size(168, 24);
                        this.txtCondicion.TabIndex = 7;
                        this.txtCondicion.Table = null;
                        this.txtCondicion.Text = "Publica";
                        this.txtCondicion.TextKey = "0";
                        this.txtCondicion.TextRaw = "Publica";
                        this.txtCondicion.TipWhenBlank = "";
                        this.txtCondicion.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(12, 180);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(72, 24);
                        this.Label3.TabIndex = 6;
                        this.Label3.Text = "Novedad";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(12, 44);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(72, 24);
                        this.Label4.TabIndex = 2;
                        this.Label4.Text = "Asunto";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTicket
                        // 
                        this.txtTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTicket.AutoHeight = false;
                        this.txtTicket.AutoTab = true;
                        this.txtTicket.CanCreate = true;
                        this.txtTicket.DetailField = "nombre";
                        this.txtTicket.ExtraDetailFields = null;
                        this.txtTicket.Filter = "";
                        this.txtTicket.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTicket.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTicket.FreeTextCode = "";
                        this.txtTicket.KeyField = "id_ticket";
                        this.txtTicket.Location = new System.Drawing.Point(84, 12);
                        this.txtTicket.MaxLength = 200;
                        this.txtTicket.Name = "txtTicket";
                        this.txtTicket.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTicket.ReadOnly = false;
                        this.txtTicket.Required = true;
                        this.txtTicket.SelectOnFocus = true;
                        this.txtTicket.Size = new System.Drawing.Size(540, 24);
                        this.txtTicket.TabIndex = 1;
                        this.txtTicket.Table = "tickets";
                        this.txtTicket.TeclaDespuesDeEnter = "{tab}";
                        this.txtTicket.Text = "0";
                        this.txtTicket.TextDetail = "";
                        this.txtTicket.TextInt = 0;
                        this.txtTicket.TipWhenBlank = "";
                        this.txtTicket.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(12, 12);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(72, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Tarea";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Novedad
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.ControlBox = false;
                        this.Controls.Add(this.txtMinutos);
                        this.Controls.Add(this.txtTicket);
                        this.Controls.Add(this.txtCondicion);
                        this.Controls.Add(this.txtDescripcion);
                        this.Controls.Add(this.txtTecnico);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "Novedad";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Novedad: Cargar";
                        this.WorkspaceChanged += new System.EventHandler(this.Novedad_WorkspaceChanged);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.txtTecnico, 0);
                        this.Controls.SetChildIndex(this.txtDescripcion, 0);
                        this.Controls.SetChildIndex(this.txtCondicion, 0);
                        this.Controls.SetChildIndex(this.txtTicket, 0);
                        this.Controls.SetChildIndex(this.txtMinutos, 0);
                        this.ResumeLayout(false);

                }


                #endregion

                public override Lfx.Types.OperationResult Save()
                {
                        Lfx.Types.OperationResult ResultadoGuardar = new Lfx.Types.SuccessOperationResult();

                       ResultadoGuardar = ValidateData();

                        if (ResultadoGuardar.Success == true) {
                                Lfx.Data.SqlInsertBuilder InsertarNovedad = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "tickets_eventos");
                                InsertarNovedad.Fields.AddWithValue("id_ticket", txtTicket.TextInt);
                                InsertarNovedad.Fields.AddWithValue("id_tecnico", txtTecnico.Text);
                                InsertarNovedad.Fields.AddWithValue("minutos_tecnico", Lfx.Types.Parsing.ParseInt(txtMinutos.Text));
                                InsertarNovedad.Fields.AddWithValue("privado", txtCondicion.TextKey);
                                InsertarNovedad.Fields.AddWithValue("descripcion", txtDescripcion.Text);
                                InsertarNovedad.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                                DataView.Execute(InsertarNovedad);

                                ResultadoGuardar = base.Save();
                        }

                        return ResultadoGuardar;
                }


                public override Lfx.Types.OperationResult ValidateData()
                {
                        Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();

                        if (txtTicket.TextInt == 0) {
                                validarReturn.Success = false;
                                validarReturn.Message = "Escriba el código de Ticket" + Environment.NewLine;
                        }
                        return validarReturn;
                }

                private void Novedad_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        txtTecnico.TextInt = this.Workspace.CurrentUser.Id;
                        txtCondicion.TextKey = "0";
                }
        }
}