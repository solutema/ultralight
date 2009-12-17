using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Lcc.Controles.Datos
{
        public class ControlDatos : Lcc.LccControl
        {
                protected Lbl.ElementoDeDatos m_Elemento = null;

                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public virtual Lbl.ElementoDeDatos Elemento
                {
                        get
                        {
                                return m_Elemento;
                        }
                        set
                        {
                                m_Elemento = value;
                                foreach (System.Windows.Forms.Control Ctl in this.Controls) {
                                        if (Ctl is ControlDatos)
                                                ((ControlDatos)Ctl).Elemento = value;
                                }
                                this.ActualizarControl();
                        }
                }

                public Lws.Workspace Workspace
                {
                        get
                        {
                                return m_Elemento.Workspace;
                        }
                }

                /// <summary>
                /// Actualiza el control con los datos del elemento.
                /// </summary>
                public virtual void ActualizarControl() 
                {
                }


                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lws.Data.DataView DataView
                {
                        get
                        {
                                if (m_Elemento == null)
                                        return null;
                                else
                                        return m_Elemento.DataView;
                        }
                }
        }
}
