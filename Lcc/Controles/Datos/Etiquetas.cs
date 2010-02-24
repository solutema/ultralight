using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Controles.Datos
{
        public partial class Etiquetas : ControlDatos
        {
                public Etiquetas()
                {
                        InitializeComponent();
                }

                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public override Lbl.ElementoDeDatos Elemento
                {
                        get
                        {
                                return base.Elemento;
                        }
                        set
                        {
                                base.Elemento = value;
                                //Cargo tags para la nueva tabla
                                Lista.SuspendLayout();
                                Lista.Items.Clear();
                                Lws.Data.Table TablaEtiquetas = this.DataView.Tables["sys_labels"];
                                TablaEtiquetas.PreLoad();
                                foreach (Lfx.Data.Row Rw in TablaEtiquetas.FastRows.Values) {
                                        Lbl.Etiqueta Eti = new Lbl.Etiqueta(Rw);
                                        if (Eti.TablaReferencia == m_Elemento.TablaDatos) {
                                                ListViewItem Itm = Lista.Items.Add(Eti.Id.ToString());
                                                Itm.SubItems.Add(Eti.Nombre);
                                                if (Elemento.Etiquetas.Contains(Eti.Id))
                                                        Itm.Checked = true;
                                        }
                                }
                                Lista.ResumeLayout();
                        }
                }

                private void Lista_ItemChecked(object sender, ItemCheckedEventArgs e)
                {
                        int ItemId = Lfx.Types.Parsing.ParseInt(e.Item.Text);
                        if (ItemId != 0) {
                                if(e.Item.Checked) {
                                        //Agrego
                                        if(Elemento.Etiquetas.Contains(ItemId) == false)
                                                m_Elemento.Etiquetas.Add(new Lbl.Etiqueta(m_Elemento.DataView, ItemId));
                                } else {
                                        //Lo quito
                                        if (Elemento.Etiquetas.Contains(ItemId))
                                                m_Elemento.Etiquetas.RemoveById(ItemId);
                                }
                        }
                }
        }
}
