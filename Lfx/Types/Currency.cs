using System;
using System.Collections.Generic;
using System.Text;

namespace Lfx.Types
{
	public static class Currency
	{
                public static decimal Truncate(decimal number, int decimals)
		{
			long Expo = System.Convert.ToInt64(Math.Pow(10, decimals));
			return Math.Truncate(number * Expo) / Expo;
		}


                /// <summary>
                /// Quita el IVA de un importe IVA incluído.
                /// Por ejemplo, para un importe de $ 121 con una alícuota del 21%, devuelve $ 100.
                /// </summary>
                /// <param name="importe">El importe IVA incluído.</param>
                /// <param name="alicuota">La tasa de IVA aplicada.</param>
                /// <returns>El importe original, sin el IVA</returns>
                public static decimal QuitarIva(decimal importe, decimal alicuota)
                {
                        decimal ImporteOriginal = importe / (1 + alicuota / 100);
                        decimal Iva = Math.Floor((importe - ImporteOriginal) * 100) / 100;

                        return Math.Floor((importe - Iva) * 100) / 100;
                }
	}
}
