using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lbl.Cuotas
{
        public class EstadoCuota
        {
                [DefaultValue(Estados.Nueva)]
                public Estados EstadoComercio { get; set; }

                [DefaultValue(Estados.Nueva)]
                public Estados EstadoCliente { get; set; }

                public int Id { get; set; }
        }
}
