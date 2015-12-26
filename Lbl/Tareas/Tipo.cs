using System;
using System.Collections.Generic;
using System.Text;

namespace Lbl.Tareas
{
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Tipo", Grupo = "Tareas")]
        [Lbl.Atributos.Datos(TablaDatos = "tickets_tipos", CampoId = "id_tipo_ticket")]
        [Lbl.Atributos.Presentacion()]
        public class Tipo : ElementoDeDatos
        {
                public Tipo(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Tipo(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Tipo(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public override void Crear()
                {
                        base.Crear();
                        this.Estado = 1;
                }


                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("obs", this.Obs);
                        Comando.Fields.AddWithValue("estado", this.Estado);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }
        }
}
