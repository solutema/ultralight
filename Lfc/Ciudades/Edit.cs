using System;
using System.Collections.Generic;
using System.Text;

namespace Lfc.Ciudades
{
        public class Edit : Lazaro.Forms.EditForm
        {
                public Edit(Lbl.Entidades.Ciudad ciudad)
                {
                        this.LoadFromElement(ciudad);
                }
        }
}
