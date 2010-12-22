namespace Lbl.Personas
{
        public class Cuit : IIdentificadorUnico
        {
                public string Valor { get; set; }

                public Cuit(string valor)
                {
                        string Res = valor;

                        if (Res != null)
                                Res = Res.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "").Replace("_", "");

                        if (Res.Length == 11)
                                this.Valor = Res.Substring(0, 2) + "-" + Res.Substring(2, 8) + "-" + Res.Substring(10, 1);
                        else
                                this.Valor = Res;
                }

                public bool EsValido()
                {
                        return Lfx.Types.Strings.EsCuitValido(this.Valor);
                }

                public override string ToString()
                {
                        return this.Valor;
                }
        }
}
