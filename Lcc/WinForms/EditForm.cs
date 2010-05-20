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
using System.Windows.Forms;
using Lazaro.Forms;

namespace Lcc.WinForms
{
        public partial class EditForm : ActionForm
        {
                private Lazaro.Forms.EditForm m_OriginalForm;
                private Size MinControlSize = new Size(96, 24);
                private Size NormalControlSize = new Size(96, 24);

                public EditForm()
                {
                        InitializeComponent();

                        this.Body.Controls.Add(DataArea);
                }

                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lazaro.Forms.EditForm OriginalForm
                {
                        get
                        {
                                return m_OriginalForm;
                        }
                        set
                        {
                                m_OriginalForm = value;
                                this.LoadForm(m_OriginalForm);
                        }
                }

                private void LoadForm(Lazaro.Forms.EditForm form)
                {
                        // Cargar el formulario
                        DataArea.Controls.Clear();
                        DataArea.ColumnStyles[0].SizeType = SizeType.AutoSize;
                        DataArea.ColumnStyles[0].Width = 20;
                        DataArea.ColumnStyles[1].SizeType = SizeType.AutoSize;
                        DataArea.ColumnStyles[1].Width = 80;

                        if (form != null) {
                                this.FormHeader.Text = form.Caption;
                                int CurrentRow = 0;

                                foreach (FormSection Sect in form.Sections) {
                                        if (form.Sections.Count > 1) {
                                                // Si tiene más de una sección, agrego encabezados de sección
                                                if (DataArea.RowCount < (CurrentRow + 1))
                                                        DataArea.RowCount += 1;

                                                if (DataArea.RowStyles.Count < (CurrentRow + 1))
                                                        DataArea.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                                                else
                                                        DataArea.RowStyles[CurrentRow].SizeType = SizeType.AutoSize;


                                                System.Windows.Forms.Label SectionLabel = new Label();
                                                SectionLabel.Text = Sect.Name;
                                                SectionLabel.AutoEllipsis = false;
                                                SectionLabel.UseMnemonic = false;
                                                SectionLabel.AutoSize = false;
                                                SectionLabel.Dock = DockStyle.Fill;
                                                SectionLabel.TextAlign = ContentAlignment.MiddleLeft;
                                                DataArea.Controls.Add(SectionLabel, 1, CurrentRow);

                                                CurrentRow++;
                                        }

                                        foreach (Lazaro.Forms.Controls.Control Ctl in Sect.Controls) {
                                                System.Windows.Forms.Label Lab = new Label();
                                                if (Ctl.Label != null)
                                                        Lab.Text = Ctl.Label;
                                                else
                                                        Lab.Text = "";
                                                Lab.AutoEllipsis = false;
                                                Lab.UseMnemonic = false;
                                                Lab.AutoSize = false;
                                                Lab.Dock = DockStyle.Fill;
                                                Lab.TextAlign = ContentAlignment.MiddleLeft;

                                                if (DataArea.RowCount < (CurrentRow + 1))
                                                        DataArea.RowCount += 1;

                                                if (DataArea.RowStyles.Count < (CurrentRow + 1))
                                                        DataArea.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                                                else
                                                        DataArea.RowStyles[CurrentRow].SizeType = SizeType.AutoSize;

                                                Control NewCtl = null;
                                                if (Ctl is Lazaro.Forms.Controls.SimpleTextBox) {
                                                        Lazaro.Forms.Controls.SimpleTextBox MiCtl = Ctl as Lazaro.Forms.Controls.SimpleTextBox;
                                                        Lui.Forms.TextBox NewTxt = new Lui.Forms.TextBox();
                                                        NewTxt.MinimumSize = new Size(10 * (MiCtl.MaxLenght > 60 ? 60 : MiCtl.MaxLenght), MinControlSize.Height);
                                                        NewTxt.MaximumSize = new Size(480, NormalControlSize.Height);
                                                        NewTxt.Size = new Size(NewTxt.MinimumSize.Height, NormalControlSize.Height); ;
                                                        NewTxt.SelectOnFocus = false;
                                                        NewTxt.MaxLenght = MiCtl.MaxLenght;
                                                        NewTxt.Text = MiCtl.Value.ToString();
                                                        NewCtl = NewTxt;
                                                        //NewCtl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                                                } if (Ctl is Lazaro.Forms.Controls.MasterDetail) {
                                                        Lazaro.Forms.Controls.MasterDetail MiCtl = Ctl as Lazaro.Forms.Controls.MasterDetail;
                                                        Lui.Forms.DetailBox NewDet = new Lui.Forms.DetailBox();
                                                        NewDet.MaximumSize = new Size(480, NormalControlSize.Height);
                                                        NewDet.Table = MiCtl.Relation.ReferenceTable;
                                                        NewDet.KeyField = MiCtl.Relation.ReferenceColumn;
                                                        NewDet.DetailField = MiCtl.Relation.DetailColumn;
                                                        NewDet.TextInt = System.Convert.ToInt32(MiCtl.Value);
                                                        NewCtl = NewDet;
                                                }

                                                DataArea.Controls.Add(Lab, 0, CurrentRow);
                                                if(NewCtl != null)
                                                        DataArea.Controls.Add(NewCtl, 1, CurrentRow);

                                                CurrentRow++;
                                        }
                                }
                        }
                }
        }
}
