using System;
using System.Collections.Generic;
using System.Text;

namespace Lbl.Bancos
{
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Banco", Grupo = "Bancos")]
        [Lbl.Atributos.Datos(TablaDatos = "bancos", CampoId = "id_banco")]
        [Lbl.Atributos.Presentacion()]
	public class Banco : ElementoDeDatos
	{
		//Heredar constructor
		public Banco(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Banco(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Banco(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }
	}
}
