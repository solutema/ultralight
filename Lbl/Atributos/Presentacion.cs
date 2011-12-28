using System;
using System.Collections.Generic;

namespace Lbl.Atributos
{
        public class Presentacion : System.Attribute
        {
                public bool MensajeAlCrear { get; set; }
                public bool PanelExtendido { get; set; }

                public Presentacion()
                {
                        this.PanelExtendido = true;
                }

                public Presentacion(bool mensajeAlCrear = false, bool panelExtendido = true)
                {
                        this.MensajeAlCrear = mensajeAlCrear;
                        this.PanelExtendido = panelExtendido;
                }
        }
}
