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

namespace Lfc.Comprobantes.Plantillas
{
        public partial class Editar : Lui.Forms.EditForm
        {
                Lbl.Comprobantes.Impresion.Plantilla Plantilla;
                Lbl.Comprobantes.Impresion.Campo CampoSeleccionado;

                private int KnobSize = 24, GridSize = 10;
                private PointF Escala;
                private Point Desplazamiento = new Point(0, 0);
                private Point ButtonDown;
                private Rectangle CampoDown;
                private bool KnobGrabbed = false;
                private float Zoom = 100;
                private Brush BrushSeleccion = new System.Drawing.SolidBrush(Color.FromArgb(100, SystemColors.Highlight));

                public Editar()
                {
                        InitializeComponent();
                        ZoomBar_Scroll(null, null);
                }

                public override Lfx.Types.OperationResult Create()
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.templates.create"))
                                return new Lfx.Types.NoAccessOperationResult();

                        this.Plantilla = new Lbl.Comprobantes.Impresion.Plantilla(this.DataView);
                        this.Plantilla.Crear();

                        this.Text = "Plantillas: Nueva";
                        return new Lfx.Types.SuccessOperationResult();
                }


                public override Lfx.Types.OperationResult Edit(int itemId)
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.templates.read"))
                                return new Lfx.Types.NoAccessOperationResult();

                        Plantilla = new Lbl.Comprobantes.Impresion.Plantilla(this.DataView, itemId);

                        if (Plantilla.Existe == false) {
                                return new Lfx.Types.FailureOperationResult("El registro no existe");
                        } else {
                                txtMembrete.TextKey = Plantilla.Membrete.ToString();
                                txtCodigo.Text = Plantilla.Codigo;
                                txtNombre.Text = Plantilla.Nombre;
                                txtPapelTamano.TextKey = Plantilla.TamanoPapel;
                                txtFuente.TextKey = Plantilla.Font.Name;
                                txtFuenteTamano.Text = Plantilla.Font.Size.ToString();
				txtLandscape.TextKey = Plantilla.Landscape ? "1" : "0";

                                this.ActualizarListaCampos();

                                m_Id = itemId;
                                m_Nuevo = false;

                                SaveButton.Visible = Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.templates.write");

                                this.Text = "Plantilla: " + txtNombre.Text;
                                return new Lfx.Types.SuccessOperationResult();
                        }
                }

                public override Lfx.Types.OperationResult Save()
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.templates.write"))
                                return new Lfx.Types.NoAccessOperationResult();

                        Plantilla.Codigo = txtCodigo.Text;
                        Plantilla.Nombre = txtNombre.Text;
                        Plantilla.TamanoPapel = txtPapelTamano.TextKey;
			Plantilla.Landscape = txtLandscape.TextKey == "1";
			Plantilla.Copias = Lfx.Types.Parsing.ParseInt(txtCopias.Text);
                        Plantilla.Membrete = Lfx.Types.Parsing.ParseInt(txtMembrete.TextKey);
                        Plantilla.Guardar();
                        return new Lfx.Types.SuccessOperationResult();
                }

                private void pctPreview_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
                {
                        e.Graphics.Clear(Color.Ivory);
                        e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        e.Graphics.PageUnit = GraphicsUnit.Document;
                        e.Graphics.ScaleTransform(Zoom / 100F, Zoom / 100F);
                        e.Graphics.TranslateTransform(Desplazamiento.X, Desplazamiento.Y);

                        PointF[] Pts = new PointF[] { new Point(1000, 1000) };
                        e.Graphics.TransformPoints(System.Drawing.Drawing2D.CoordinateSpace.Device, System.Drawing.Drawing2D.CoordinateSpace.Page, Pts);
                        this.Escala = new PointF(1000F / Pts[0].X, 1000F / Pts[0].Y);

                        PointF EscalaMm = new PointF(300F / 25.4F, 300F / 25.4F);

                        Size TamPap = TamanoPapel(txtPapelTamano.TextKey);
			if (Plantilla.Landscape)
				TamPap = new Size(TamPap.Height, TamPap.Width);

                        e.Graphics.FillRectangle(Brushes.DarkGray, new System.Drawing.RectangleF(2 * EscalaMm.X, 2 * EscalaMm.Y, TamPap.Width * EscalaMm.X, TamPap.Height * EscalaMm.Y));
                        e.Graphics.FillRectangle(Brushes.White, new System.Drawing.RectangleF(0 * EscalaMm.X, 0 * EscalaMm.Y, TamPap.Width * EscalaMm.X, TamPap.Height * EscalaMm.Y));
                        //e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.RectangleF(0 * EscalaMm.X, 0 * EscalaMm.Y, TamPap.Width * EscalaMm.X, TamPap.Height * EscalaMm.Y));
                        //e.Graphics.Clip = new Region(new System.Drawing.Rectangle(new Point(0, 0), TamanoPapel(txtPapelTamano.TextKey)));

                        if (Plantilla == null || Plantilla.Campos == null)
                                return;

                        foreach (Lbl.Comprobantes.Impresion.Campo Cam in Plantilla.Campos) {
                                Rectangle DrawRect = Cam.Rectangle;

                                //Invierto rectángulos con ancho o alto negativo, para poder dibujarlos
                                if (DrawRect.Width < 0) {
                                        DrawRect.Width = Math.Abs(DrawRect.Width);
                                        DrawRect.X -= DrawRect.Width;
                                }
                                if (DrawRect.Height < 0) {
                                        DrawRect.Height = Math.Abs(DrawRect.Height);
                                        DrawRect.Y -= DrawRect.Height;
                                }

                                if (Cam.AnchoBorde > 0)
                                        e.Graphics.DrawRectangle(new Pen(Cam.ColorBorde, Cam.AnchoBorde), DrawRect);

                                if(Cam.ColorFondo != Color.Transparent)
                                        e.Graphics.FillRectangle(new SolidBrush(Cam.ColorFondo), DrawRect);

                                if (Cam == CampoSeleccionado) {
                                        e.Graphics.FillRectangle(BrushSeleccion, DrawRect);
                                }

                                System.Drawing.Font FuenteItem;
                                if (Cam.Font != null)
                                        FuenteItem = Cam.Font;
                                else
                                        FuenteItem = Plantilla.Font;

                                string Texto = Cam.Valor;
                                Texto = Texto.Replace("{Cliente}", "Compañía La Estrella S.R.L.");
                                Texto = Texto.Replace("{Cliente.Documento}", "20-20123456-6");
                                Texto = Texto.Replace("{IVA}", "Responsable no inscripto");
                                Texto = Texto.Replace("{CUIT}", "30-12345678-9");
                                Texto = Texto.Replace("{Domicilio}", "Avenida San Martín 1234, 3ro. B");
                                Texto = Texto.Replace("{Cliente.Domicilio}", "Avenida San Martín 1234, 3ro. B");
                                Texto = Texto.Replace("{Fecha}", System.DateTime.Now.ToString("dd-MM-yyyy"));
                                Texto = Texto.Replace("{FormaPago}", "Cuenta corriente");
                                Texto = Texto.Replace("{Total}", "$ 123.456.789,00");
                                Texto = Texto.Replace("{SubTotal}", "$ 123.456.789,00");
                                Texto = Texto.Replace("{SonPesos}", "ciento veintitres mil seiscientos setenta y ocho con 00/100");
                                Texto = Texto.Replace("{Codigos}", "00123456\r\n00123456\r\nABR012PM\r\nCODIGO99");
                                Texto = Texto.Replace("{Cantidades}", "1\r\n2\r\n1\r\n1");
                                Texto = Texto.Replace("{Precios}", "$ 123.456,00\r\n$ 123.456,00\r\n$ 123.456,00\r\n$ 123.456,00");
                                Texto = Texto.Replace("{Importes}", "$ 123.456,00\r\n$ 123.456,00\r\n$ 123.456,00\r\n$ 123.456,00");
                                Texto = Texto.Replace("{Detalles}", "Producto de ejemplo Nº 1\r\nProducto de ejemplo Nº 2\r\nProducto de ejemplo Nº 3\r\nProducto de ejemplo Nº 4");
                                Texto = Texto.Replace("{Valores}", "Efectivo        : $ 100.\r\nCheque          : $ 100.\r\nTarjeta de Déb. : $ 100.\r\nTarjeta de Cré. : $ 100.");

                                StringFormat StrFmt = new StringFormat(StringFormatFlags.NoClip);
                                StrFmt.Trimming = StringTrimming.None;
                                StrFmt.Alignment = Cam.Alignment;
                                StrFmt.LineAlignment = Cam.LineAlignment;
                                e.Graphics.DrawString(Texto, FuenteItem, new SolidBrush(Cam.ColorTexto), DrawRect, StrFmt);

                                if (CampoSeleccionado == Cam) {
                                        string Lbl = DrawRect.Location.ToString();
                                        Font LblFont = new Font("Arial", 7);
                                        RectangleF LabelRect = new RectangleF(new PointF(DrawRect.X + 10, DrawRect.Y + DrawRect.Height + 11), e.Graphics.MeasureString(Lbl, LblFont));
                                        LabelRect.Inflate(10, 10);
                                        e.Graphics.FillRectangle(SystemBrushes.Info, LabelRect);
                                        StrFmt = new StringFormat(StringFormatFlags.NoClip);
                                        StrFmt.Alignment = StringAlignment.Center;
                                        StrFmt.LineAlignment = StringAlignment.Center;
                                        e.Graphics.DrawString(Lbl, LblFont, SystemBrushes.InfoText, LabelRect, StrFmt);

                                        Rectangle RectKnob = new Rectangle(Cam.Rectangle.Right - KnobSize / 2, Cam.Rectangle.Bottom - KnobSize / 2, KnobSize, KnobSize);
                                        e.Graphics.FillRectangle(Brushes.Black, RectKnob);
                                }
                        }
                }

                private void lvCampos_SelectedIndexChanged(object sender, System.EventArgs e)
                {
                        if (Plantilla.Campos != null && lvCampos.SelectedItems.Count > 0) {
                                foreach (Lbl.Comprobantes.Impresion.Campo Cam in Plantilla.Campos) {
                                        if (Cam.GetHashCode().ToString() == lvCampos.SelectedItems[0].Text) {
                                                CampoSeleccionado = Cam;
                                                break;
                                        }
                                }
                        } else {
                                CampoSeleccionado = null;
                        }

                        pctPreview.Invalidate();
                }

                private Point PuntoDesdePantalla(Point pt)
                {
                        return PuntoDesdePantalla(pt, true);
                }
                private Point PuntoDesdePantalla(Point pt, bool usarGrilla)
                {
                        Point Res = new Point(System.Convert.ToInt32(pt.X * this.Escala.X / (this.Zoom / 100F)), System.Convert.ToInt32(pt.Y * this.Escala.Y / (this.Zoom / 100F)));
                        Res.Offset(-Desplazamiento.X, -Desplazamiento.Y);
                        if (usarGrilla) {
                                Res.X = System.Convert.ToInt32(Res.X / this.GridSize) * this.GridSize;
                                Res.Y = System.Convert.ToInt32(Res.Y / this.GridSize) * this.GridSize;
                        }
                        return Res;
                }

                private void pctPreview_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
                {
                        if (e.Button == System.Windows.Forms.MouseButtons.Middle) {
                                ButtonDown = new Point(e.X, e.Y);
                        } else if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                                ButtonDown = PuntoDesdePantalla(new Point(e.X, e.Y));
                                Point MyButtonDown = PuntoDesdePantalla(new Point(e.X, e.Y), false);

                                if (CampoSeleccionado != null) {
                                        Rectangle RectKnob = new Rectangle(CampoSeleccionado.Rectangle.Right - KnobSize / 2, CampoSeleccionado.Rectangle.Bottom - KnobSize / 2, KnobSize, KnobSize);
                                        if (CampoSeleccionado != null && RectKnob.Contains(MyButtonDown)) {
                                                //Agarró el knob
                                                KnobGrabbed = true;
                                                return;
                                        }
                                }

                                bool Select = false;
                                foreach (Lbl.Comprobantes.Impresion.Campo Cam in Plantilla.Campos) {
                                        //Busco el campo del clic (según coordenadas)
                                        if (Cam.Valor == null || Cam.Valor.Length == 0 && Cam.AnchoBorde > 0) {
                                                //En el caso particular de los rectángulos con borde y sin texto, tiene que hacer clic en el contorno
                                                if ((MyButtonDown.X >= (Cam.Rectangle.Left - 5) && (MyButtonDown.X <= (Cam.Rectangle.Left + 5)) ||
                                                        MyButtonDown.X >= (Cam.Rectangle.Right - 5) && (MyButtonDown.X <= (Cam.Rectangle.Right + 5)) ||
                                                        MyButtonDown.Y >= (Cam.Rectangle.Top - 5) && (MyButtonDown.Y <= (Cam.Rectangle.Top + 5)) ||
                                                        MyButtonDown.Y >= (Cam.Rectangle.Bottom - 5) && (MyButtonDown.Y <= (Cam.Rectangle.Bottom + 5))))
                                                        Select = true;
                                                else
                                                        Select = false;
                                                KnobGrabbed = false;
                                        } else if (Cam.Rectangle.Contains(MyButtonDown)) {
                                                //El resto de los campos, se seleccionan haciendo clic en cualquier parte del rectángulo
                                                Select = true;
                                                KnobGrabbed = false;
                                        }

                                        if (Select) {
                                                //Encontré el campo del Click
                                                //Lo selecciono mediante la listview
                                                CampoSeleccionado = Cam;
                                                foreach (ListViewItem itm in lvCampos.Items) {
                                                        itm.Selected = (itm.Text == CampoSeleccionado.GetHashCode().ToString());
                                                }
                                                break;
                                        } else {
                                                while (lvCampos.SelectedItems.Count > 0) {
                                                        lvCampos.SelectedItems[0].Selected = false;
                                                }
                                        }
                                }

                                if (CampoSeleccionado != null)
                                        CampoDown = CampoSeleccionado.Rectangle;
                        }
                }

                private void pctPreview_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
                {
                        if (e.Button == System.Windows.Forms.MouseButtons.Middle) {
                                Point OldDesplazamiento = this.Desplazamiento;
                                this.Desplazamiento = new Point(0, 0);
                                Point Diferencia = PuntoDesdePantalla(new Point(e.X - ButtonDown.X, e.Y - ButtonDown.Y), false);
                                this.Desplazamiento = OldDesplazamiento;
                                this.Desplazamiento.Offset(Diferencia);
                                ButtonDown = new Point(e.X, e.Y);
                                pctPreview.Invalidate();
                        } else if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                                if (CampoSeleccionado != null) {
                                        if (KnobGrabbed) {
                                                //Point NewCampoPos = new Point(CampoDown.Right, CampoDown.Bottom);
                                                Point PosCursor = PuntoDesdePantalla(new Point(e.X, e.Y));
                                                PosCursor.X -= CampoDown.Left;
                                                PosCursor.Y -= CampoDown.Top;
                                                CampoSeleccionado.Rectangle.Width = PosCursor.X;
                                                CampoSeleccionado.Rectangle.Height = PosCursor.Y;
                                        } else {
                                                Point NewCampoPos = CampoDown.Location;
                                                Point PosCursor = PuntoDesdePantalla(new Point(e.X, e.Y));
                                                NewCampoPos.Offset(PosCursor.X - ButtonDown.X, PosCursor.Y - ButtonDown.Y);
                                                CampoSeleccionado.Rectangle.Location = NewCampoPos;
                                        }
                                        pctPreview.Invalidate();
                                }
                        }
                }

                private void txtPapelTamano_TextChanged(object sender, System.EventArgs e)
                {
                        Plantilla.TamanoPapel = txtPapelTamano.TextKey;
			Plantilla.Landscape = txtLandscape.TextKey == "1";
                        pctPreview.Invalidate();
                }

                private static System.Drawing.Size TamanoPapel(string tipoPapel)
                {
                        switch (tipoPapel.ToLower()) {
                                case "a4":
                                        return new System.Drawing.Size(210, 297);
                                case "a5":
                                        return new System.Drawing.Size(148, 210);
                                case "letter":
                                        return new System.Drawing.Size(216, 279);
                                case "legal":
                                        return new System.Drawing.Size(216, 356);
                                case "cont":
                                        return new System.Drawing.Size(216, 305);
                                default:
                                        //Predeterminado A4
                                        return new System.Drawing.Size(210, 297);
                        }
                }

                private void lvCampos_DoubleClick(object sender, System.EventArgs e)
                {
                        if (CampoSeleccionado != null) {
                                EditarCampo FormEditarCampo = new EditarCampo();
                                //FormEditarCampo.EntradaTipo.TextKey = SelectedField.Attributes["type"].Value;
                                FormEditarCampo.txtX.Text = CampoSeleccionado.Rectangle.X.ToString();
                                FormEditarCampo.txtY.Text = CampoSeleccionado.Rectangle.Y.ToString();
                                FormEditarCampo.txtW.Text = CampoSeleccionado.Rectangle.Width.ToString();
                                FormEditarCampo.txtH.Text = CampoSeleccionado.Rectangle.Height.ToString();
                                FormEditarCampo.txtTexto.Text = CampoSeleccionado.Valor;
                                FormEditarCampo.txtAlign.TextKey = CampoSeleccionado.Alignment.ToString();
                                FormEditarCampo.txtLineAlign.TextKey = CampoSeleccionado.LineAlignment.ToString();
                                FormEditarCampo.txtWrap.TextKey = CampoSeleccionado.Wrap ? "1" : "0";
                                FormEditarCampo.txtAnchoBorde.Text = CampoSeleccionado.AnchoBorde.ToString();
                                FormEditarCampo.ColorBorde.BackColor = CampoSeleccionado.ColorBorde;
                                FormEditarCampo.ColorFondo.BackColor = CampoSeleccionado.ColorFondo;
                                FormEditarCampo.ColorTexto.BackColor = CampoSeleccionado.ColorTexto;
                                if (CampoSeleccionado.Font != null) {
                                        FormEditarCampo.txtFuente.TextKey = CampoSeleccionado.Font.Name;
                                        FormEditarCampo.txtFuenteTamano.Text = CampoSeleccionado.Font.Size.ToString();
                                } else {
                                        FormEditarCampo.txtFuente.TextKey = "*";
                                        FormEditarCampo.txtFuenteTamano.Text = "0";
                                }
                                if (FormEditarCampo.ShowDialog() == DialogResult.OK) {
                                        CampoSeleccionado.Rectangle.X = Lfx.Types.Parsing.ParseInt(FormEditarCampo.txtX.Text);
                                        CampoSeleccionado.Rectangle.Y = Lfx.Types.Parsing.ParseInt(FormEditarCampo.txtY.Text);
                                        CampoSeleccionado.Rectangle.Width = Lfx.Types.Parsing.ParseInt(FormEditarCampo.txtW.Text);
                                        CampoSeleccionado.Rectangle.Height = Lfx.Types.Parsing.ParseInt(FormEditarCampo.txtH.Text);
                                        CampoSeleccionado.Valor = FormEditarCampo.txtTexto.Text;
                                        CampoSeleccionado.AnchoBorde = Lfx.Types.Parsing.ParseInt(FormEditarCampo.txtAnchoBorde.Text);
                                        CampoSeleccionado.ColorBorde = FormEditarCampo.ColorBorde.BackColor;
                                        CampoSeleccionado.ColorFondo = FormEditarCampo.ColorFondo.BackColor;
                                        CampoSeleccionado.ColorTexto = FormEditarCampo.ColorTexto.BackColor;
                                        if (FormEditarCampo.txtFuente.TextKey != "*" && Lfx.Types.Parsing.ParseInt(FormEditarCampo.txtFuenteTamano.Text) > 0) {
                                                CampoSeleccionado.Font = new Font(FormEditarCampo.txtFuente.TextKey, Lfx.Types.Parsing.ParseInt(FormEditarCampo.txtFuenteTamano.Text));
                                        } else {
                                                CampoSeleccionado.Font = null;
                                        }
                                        switch(FormEditarCampo.txtAlign.TextKey)
                                        {
                                                case "Far":
                                                        CampoSeleccionado.Alignment = StringAlignment.Far;
                                                        break;
                                                case "Center":
                                                        CampoSeleccionado.Alignment = StringAlignment.Center;
                                                        break;
                                                default:
                                                        CampoSeleccionado.Alignment = StringAlignment.Near;
                                                        break;
                                        }
                                        switch (FormEditarCampo.txtLineAlign.TextKey) {
                                                case "Far":
                                                        CampoSeleccionado.LineAlignment = StringAlignment.Far;
                                                        break;
                                                case "Center":
                                                        CampoSeleccionado.LineAlignment = StringAlignment.Center;
                                                        break;
                                                default:
                                                        CampoSeleccionado.LineAlignment = StringAlignment.Near;
                                                        break;
                                        }
                                        CampoSeleccionado.Wrap = FormEditarCampo.txtWrap.TextKey == "1";
                                        pctPreview.Invalidate();
                                }
                        }
                }

                private void pctPreview_DoubleClick(object sender, System.EventArgs e)
                {
                        lvCampos_DoubleClick(sender, e);
                }

                private void cmdAgregar_Click(object sender, EventArgs e)
                {
                        Lbl.Comprobantes.Impresion.Campo Cam = new Lbl.Comprobantes.Impresion.Campo();
                        Cam.Valor = "Nuevo campo";
                        Cam.Rectangle = new Rectangle(10, 10, 280, 52);
                        Plantilla.Campos.Add(Cam);
                        this.ActualizarListaCampos();
                        lvCampos.FindItemWithText(Cam.GetHashCode().ToString()).Selected = true;
                        lvCampos_DoubleClick(sender, e);
                        pctPreview.Invalidate();
                }

                private void ActualizarListaCampos()
                {
                        lvCampos.Items.Clear();
                        if (Plantilla.Campos != null) {
                                foreach (Lbl.Comprobantes.Impresion.Campo Cam in Plantilla.Campos) {
                                        ListViewItem itm = lvCampos.Items.Add(new ListViewItem(Cam.GetHashCode().ToString()));
                                        itm.SubItems.Add(Cam.Valor);
                                }
                        }
                }

                private void cmdQuitar_Click(object sender, EventArgs e)
                {
                        if (CampoSeleccionado != null) {
                                Plantilla.Campos.Remove(CampoSeleccionado);
                                this.ActualizarListaCampos();
                                pctPreview.Invalidate();
                        }
                }

                private void txtFuenteFuenteTamano_TextChanged(object sender, EventArgs e)
                {
                        txtFuenteTamano.Enabled = (txtFuente.TextKey != "*");
                        if(txtFuente.TextKey != "*" && Lfx.Types.Parsing.ParseInt(txtFuenteTamano.Text) > 0)
                                Plantilla.Font = new Font(txtFuente.TextKey, Lfx.Types.Parsing.ParseInt(txtFuenteTamano.Text));
                        else
                                Plantilla.Font = new Font("Courier New", 10);
                }

                private void ZoomBar_Scroll(object sender, EventArgs e)
                {
                        this.Zoom = ZoomBar.Value;
                        pctPreview.Invalidate();
                }

                private void cmdGuardar_Click(object sender, EventArgs e)
                {
                        SaveFileDialog FileDialog = new SaveFileDialog();
                        FileDialog.Filter = "Archivos de plantilla|*.ltx";
                        FileDialog.DefaultExt = "ltx";
                        FileDialog.FileName = Plantilla.ToString();
                        if(FileDialog.ShowDialog() == DialogResult.OK) {
                                System.IO.StreamWriter Str = new System.IO.StreamWriter(FileDialog.FileName, false);
                                Str.Write(Plantilla.Definicion.InnerXml);
                                Str.Close();
                        }
                }

                private void cmdCargar_Click(object sender, EventArgs e)
                {
                        OpenFileDialog FileDialog = new OpenFileDialog();
                        FileDialog.Filter = "Archivos de plantilla|*.ltx";
                        FileDialog.DefaultExt = "ltx";
                        FileDialog.FileName = Plantilla.ToString();
                        if (FileDialog.ShowDialog() == DialogResult.OK) {
                                System.IO.StreamReader Str = new System.IO.StreamReader(FileDialog.FileName, true);
                                Plantilla.CargarXml(Str.ReadToEnd());
                                Str.Close();
                        }
                }

                private void pctPreview_MouseUp(object sender, MouseEventArgs e)
                {
                        if (CampoSeleccionado != null) {
                                if (CampoSeleccionado.Rectangle.Width < 0) {
                                        CampoSeleccionado.Rectangle.Width = Math.Abs(CampoSeleccionado.Rectangle.Width);
                                        CampoSeleccionado.Rectangle.X -= CampoSeleccionado.Rectangle.Width;
                                }
                                if (CampoSeleccionado.Rectangle.Height < 0) {
                                        CampoSeleccionado.Rectangle.Height = Math.Abs(CampoSeleccionado.Rectangle.Height);
                                        CampoSeleccionado.Rectangle.Y -= CampoSeleccionado.Rectangle.Height;
                                }
                                pctPreview.Invalidate();
                        }
                }

                private void Editar_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Delete && e.Alt == false && e.Control == false && e.Shift == false) {
                                cmdQuitar.PerformClick();
                        }
                }
        }
}