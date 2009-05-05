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
namespace Lazaro
{
    public class FormCuentasChequeras: Lfx.Forms.ListingForm
    {

        #region Código generado por el Diseñador de Windows Forms

        public FormCuentasChequeras()
            : base()
        {


            // Necesario para admitir el Diseñador de Windows Forms
            InitializeComponent();

            // TOZO: agregar código de constructor después de llamar a InitializeComponent
            m_Tabla = "chequeras";
            m_Orden = "chequeras.id_chequera";
            m_CampoId = "chequeras.id_chequera";
            m_Agrupar = m_CampoId;
            m_CamposDetalle = new string[4];
            m_CamposDetalle[0] = "chequeras.id_banco";
            m_CamposDetalle[1] = "chequeras.desde";
            m_CamposDetalle[2] = "chequeras.hasta";
            m_CamposDetalle[3] = "chequeras.id_cuenta";
            m_CamposBusqueda = new string[] { };

            lvItems.Columns[1].Text = "Banco";
            lvItems.Columns[1].Width = 240;
            lvItems.Columns[2].Text = "Desde";
            lvItems.Columns[2].Width = 120;
            lvItems.Columns[3].Text = "Hasta";
            lvItems.Columns[3].Width = 120;
            lvItems.Columns[4].Text = "Cuenta";
            lvItems.Columns[4].Width = 240;
        }

        // Limpiar los recursos que se estén utilizando.
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

		private Lfx.Controls.GTextBox txtTotal;


        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.Container components = null;

        // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
        // Puede modificarse utilizando el Diseñador de Windows Forms. 
        // No lo modifique con el editor de código.

        private void InitializeComponent()
        {
			this.txtTotal = new Lfx.Controls.GTextBox();
			this.SuspendLayout();
			// 
			// lvItems
			// 
			this.lvItems.Name = "lvItems";
			// 
			// FiltersButton
			// 
			this.FiltersButton.DockPadding.All = 2;
			this.FiltersButton.Name = "FiltersButton";
			// 
			// PrintButton
			// 
			this.PrintButton.DockPadding.All = 2;
			this.PrintButton.Name = "PrintButton";
			// 
			// txtTotal
			// 
			this.txtTotal.AutoNav = true;
			this.txtTotal.AutoTab = true;
			this.txtTotal.Datatype = Lfx.Controls.DataTypes.Money;
			this.txtTotal.DecimalPlaces = -1;
			this.txtTotal.DetailField = "";
			this.txtTotal.DockPadding.All = 2;
			this.txtTotal.Filter = "";
			this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTotal.ForceCase = Lfx.Controls.TextCasing.None;
			this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtTotal.KeyField = "";
			this.txtTotal.Location = new System.Drawing.Point(8, 92);
			this.txtTotal.MaxLenght = 32767;
			this.txtTotal.MultiLine = false;
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.PasswordChar = '\0';
			this.txtTotal.Prefijo = "";
			this.txtTotal.ReadOnly = false;
			this.txtTotal.SelectOnFocus = true;
			this.txtTotal.SetData = new string[] {
													 ""};
			this.txtTotal.Size = new System.Drawing.Size(128, 28);
			this.txtTotal.Sufijo = "";
			this.txtTotal.TabIndex = 52;
			this.txtTotal.Table = "";
			this.txtTotal.Text = "0.00";
			this.txtTotal.TextKey = "";
			this.txtTotal.ToolTipText = "";
			this.txtTotal.Workspace = null;
			// 
			// FormCuentasInicio
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(592, 373);
			this.Controls.Add(this.txtTotal);
			this.Name = "FormCuentasInicio";
			this.Controls.SetChildIndex(this.txtTotal, 0);
			this.Controls.SetChildIndex(this.lvItems, 0);
			this.ResumeLayout(false);

		}


        #endregion

		public override void RefreshList()
		{
			txtTotal.Text = "0";
			base.RefreshList();
		}

		public override void Find()
		{
			txtTotal.Text = "0";
			base.Find();
		}
/*
        public override void ItemAdded(ListViewItem itm)
        {
            switch(itm.SubItems[5].Text)
            {
                case "0":
                case "-":
                case "":
                    itm.SubItems[5].Text = "Efectivo";
                    break;
                case "1":
                    itm.SubItems[5].Text = "Caja de Ahorro";
                    break;
                case "2":
                    itm.SubItems[5].Text = "Cuenta Corriente";
                    break;
                default:
                    itm.SubItems[5].Text = "???";
                    break;
            }
*/
		public override void ItemAdded(ListViewItem itm)
		{
            itm.SubItems[1].Text = Aplicacion.EspacioTrabajo.DefaultDataBase.FieldString("SELECT nombre FROM bancos WHERE id_banco=" + Lfx.Types.ParseInt(itm.SubItems[1].Text).ToString());
			itm.SubItems[4].Text = Aplicacion.EspacioTrabajo.DefaultDataBase.FieldString("SELECT nombre FROM cuentas WHERE id_cuenta=" + Lfx.Types.ParseInt(itm.SubItems[4].Text).ToString());
            //double Saldo = Aplicacion.EspacioTrabajo.DefaultDataBase.FieldDouble("SELECT saldo FROM cuentas_movim WHERE id_cuenta=" + int.Parse(itm.Text).ToString() + " ORDER BY fecha DESC");
			//: que tome en cuenta la moneda
			//txtTotal.Text = Lfx.Types.FormatCurrency(Lfx.Types.ParseCurrency(txtTotal.Text) + Saldo, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
            //itm.SubItems[6].Text = Lfx.Types.FormatCurrency(Saldo, Aplicacion.EspacioTrabajo.CurrentConfig.Currency.DecimalPlaces);
			
        }

/*
        public override Lfx.Types.Operation Create()
        {
            Aplicacion.Exec("CREAR CUENTA");
			return new Lfx.Types.Operation(true);
        }


        public override Lfx.Types.Operation Edit(int lCodigo)
        {
            if(lCodigo < 1000)
                Lfx.Forms.MessageBox.Show("No se puede editar la cuenta seleccionada", "Cuenta del Sistema");
            else
                Aplicacion.Exec("EDITAR CUENTA " + lCodigo.ToString());
            return new Lfx.Types.Operation(true);
        }
*/
    }


}
