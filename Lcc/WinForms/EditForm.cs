using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Lazaro.Forms;

namespace Lcc.WinForms
{
        public partial class EditForm : UserControl
        {
                private Lazaro.Forms.EditForm m_OriginalForm;
                private Size MinControlSize = new Size(96, 24);
                private Size NormalControlSize = new Size(96, 24);

                public EditForm()
                {
                        InitializeComponent();
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
                        LabelHeader.Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold);

                        if (form != null) {
                                LabelHeader.Text = form.Caption;

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
