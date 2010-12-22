namespace Lfc.Personas
{
        public interface IIdentificadorUnico
        {
                string Valor { get; set; }

                bool EsValido();
        }
}
