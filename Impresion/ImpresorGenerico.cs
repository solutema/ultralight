using System.Data;

namespace Lazaro.Impresion
{
        public class ImpresorGenerico : ImpresorElemento
        {
                public ImpresorGenerico(Lbl.ElementoDeDatos elemento, IDbTransaction transaction)
                        : base(elemento, transaction) { }
        }
}
