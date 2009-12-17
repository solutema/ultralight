using System;
using System.Collections.Generic;
using System.Text;

namespace Lcc.Edicion
{
        public class ControlEdicion : Lcc.Controles.Datos.ControlDatos
        {
                /// <summary>
                /// Actualiza el elemento con los datos del control.
                /// </summary>
                public virtual void ActualizarElemento()
                {
                }

                /// <summary>
                /// Valida los datos del control.
                /// </summary>
                public virtual Lfx.Types.OperationResult ValidarControl()
                {
                        return new Lfx.Types.SuccessOperationResult();
                }
        }
}
