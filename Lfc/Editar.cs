using System;
using System.Collections.Generic;
using System.Text;

namespace Lfc
{
        public class Editar : Lui.Forms.EditForm
        {
                private Lcc.Edicion.ControlEdicion ControlUnico = null;
                
                public Lcc.Edicion.ControlEdicion Control
                {
                        get
                        {
                                return this.ControlUnico;
                        }
                        set
                        {
                                if (ControlUnico != null && this.Controls.Contains(ControlUnico))
                                        this.Controls.Remove(ControlUnico);

                                ControlUnico.Dock = System.Windows.Forms.DockStyle.Fill;
                                this.Controls.Add(ControlUnico);
                        }
                }
        }
}