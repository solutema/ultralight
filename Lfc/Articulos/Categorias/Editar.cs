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

namespace Lfc.Articulos.Categorias
{
        public partial class Editar : Lui.Forms.EditForm
        {

                public Editar()
                        : base()
                {
                        InitializeComponent();
                }

                public override Lfx.Types.OperationResult Edit(int lId)
                {
                        Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("articulos_categorias", "id_categoria", lId);

                        if (Registro == null) {
                                return new Lfx.Types.FailureOperationResult("El registro no existe.");
                        } else {
                                EntradaNombre.Text = System.Convert.ToString(Registro["nombre"]);
                                EntradaNombreSing.Text = System.Convert.ToString(Registro["nombresing"]);
                                EntradaStockMinimo.Text = Lfx.Types.Formatting.FormatStock(System.Convert.ToDouble(Registro["stock_minimo"]));
                                EntradaWeb.TextKey = System.Convert.ToInt32(Registro["web"]).ToString();
                                EntradaRequiereNS.TextKey = System.Convert.ToInt32(Registro["requierens"]).ToString();
                                EntradaItem.Text = Lfx.Types.Formatting.FormatStock(this.Workspace.DefaultDataBase.FieldDouble("SELECT COUNT(id_articulo) FROM articulos WHERE id_categoria=" + lId.ToString()));
                                EntradaItemStock.Text = Lfx.Types.Formatting.FormatStock(this.Workspace.DefaultDataBase.FieldDouble("SELECT COUNT(id_articulo) FROM articulos WHERE stock_actual>0 AND id_categoria=" + lId.ToString()));
                                EntradaStockActual.Text = Lfx.Types.Formatting.FormatStock(this.Workspace.DefaultDataBase.FieldDouble("SELECT SUM(stock_actual) FROM articulos WHERE id_categoria=" + lId.ToString()));
                                EntradaCosto.Text = Lfx.Types.Formatting.FormatStock(this.Workspace.DefaultDataBase.FieldDouble("SELECT SUM(costo) FROM articulos WHERE id_categoria=" + lId.ToString()));
                                EntradaGarantia.Text = Registro["garantia"].ToString();

                                if (Registro["imagen"] != null && ((byte[])(Registro["imagen"])).Length > 5) {
                                        byte[] ByteArr = ((byte[])(Registro["imagen"]));
                                        System.IO.MemoryStream loStream = new System.IO.MemoryStream(ByteArr);
                                        pctImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                                        pctImagen.Image = Image.FromStream(loStream);
                                        pctImagen.Tag = "*";
                                }

                                m_Id = lId;
                                m_Nuevo = false;

                                return new Lfx.Types.SuccessOperationResult();
                        }
                }

                public override Lfx.Types.OperationResult Save()
                {
                        Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

                        if (ResultadoGuardar.Success == true)
                        {
                                this.DataView.DataBase.BeginTransaction();

				Lbl.Articulos.Categoria Cat = new Lbl.Articulos.Categoria(DataView, m_Id);
				Cat.Nombre = EntradaNombre.Text;
	                        Cat.NombreSingular = EntradaNombreSing.Text;
	                        Cat.StockMinimo = Lfx.Types.Parsing.ParseStock(EntradaStockMinimo.Text);
	                        Cat.PublicacionWeb = Lfx.Types.Parsing.ParseInt(EntradaWeb.TextKey);
                                Cat.RequiereNS = Lfx.Types.Parsing.ParseInt(EntradaRequiereNS.TextKey) != 0;
                                Cat.Garantia = Lfx.Types.Parsing.ParseInt(EntradaGarantia.Text);
				Cat.Guardar();
				m_Id = Cat.Id;
				
                                switch (System.Convert.ToString(pctImagen.Tag))
                                {
                                        case "*":
                                                // Queda la que está
                                                break;

                                        case "":
                                                // Quitar imagen actual
                                                DataView.DataBase.Execute("UPDATE articulos_categorias SET imagen=NULL WHERE id_categoria=" + m_Id.ToString());
                                                break;

                                        default:
                                                // Guardar imagen nueva
                                                Lfx.Data.SqlInsertBuilder InsertarImagen = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "articulos_categorias");
                                                InsertarImagen.Fields.AddWithValue("id_categoria", m_Id);
                                                InsertarImagen.Fields.AddWithValue("imagen", pctImagen.Image);
                                                DataView.Execute(InsertarImagen);
                                                break;
                                }

                                this.DataView.DataBase.Commit();

                                if (m_Nuevo && ControlDestino != null) {
                                        ControlDestino.Text = m_Id.ToString();
                                        ControlDestino.Focus();
                                }

                                m_Nuevo = false;

                                ResultadoGuardar = base.Save();
                        }

                        return ResultadoGuardar;
                }

                private void FormArticulosCategEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode)
                        {
                                case Keys.F4:
                                        e.Handled = true;
                                        if (cmdImagen.Enabled && cmdImagen.Visible)
                                                cmdImagen.PerformClick();
                                        break;

                                case Keys.F5:
                                        e.Handled = true;
                                        if (cmdImagenQuitar.Enabled && cmdImagenQuitar.Visible)
                                                cmdImagenQuitar.PerformClick();
                                        break;
                        }
                }

                private void cmdImagenQuitar_Click(object sender, System.EventArgs e)
                {
                        pctImagen.Image = null;
                        pctImagen.Tag = string.Empty;
                }

                private void cmdImagen_Click(object sender, System.EventArgs e)
                {
                        OpenFileDialog Abrir = new OpenFileDialog();
                        Abrir.Filter = "Archivos JPEG|*.jpg";
                        Abrir.Multiselect = false;
                        Abrir.ValidateNames = true;

                        if (Abrir.ShowDialog() == DialogResult.OK)
                        {
                                pctImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                                pctImagen.Image = Image.FromFile(Abrir.FileName);
                                pctImagen.Tag = Abrir.FileName;
                        }
                }
        }
}
