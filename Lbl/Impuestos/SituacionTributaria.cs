#region License
// Copyright 2004-2012 Ernesto N. Carrea
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// Este programa es software libre; puede distribuirlo y/o moficiarlo de
// acuerdo a los términos de la Licencia Pública General de GNU (GNU
// General Public License), como la publica la Fundación para el Software
// Libre (Free Software Foundation), tanto la versión 3 de la Licencia
// como (a su elección) cualquier versión posterior.
//
// Este programa se distribuye con la esperanza de que sea útil, pero SIN
// GARANTÍA ALGUNA; ni siquiera la garantía MERCANTIL implícita y sin
// garantizar su CONVENIENCIA PARA UN PROPÓSITO PARTICULAR. Véase la
// Licencia Pública General de GNU para más detalles. 
//
// Debería haber recibido una copia de la Licencia Pública General junto
// con este programa. Si no ha sido así, vea <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Lbl.Impuestos
{
        /// <summary>
        /// Representa la situación de una persona frente al fisco.
        /// </summary>
        [Lbl.Atributos.Datos(NombreSingular = "Situación Tributaria",
                Grupo = "Impuestos",
                TablaDatos = "situaciones",
                CampoId = "id_situacion")]
        [Lbl.Atributos.Presentacion()]
	public class SituacionTributaria : ElementoDeDatos
	{
		public SituacionTributaria(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public SituacionTributaria(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

		public SituacionTributaria(Lfx.Data.Connection dataBase, int itemId)
                        : base(dataBase, itemId) { }


                public string Abreviatura
                {
                        get
                        {
                                return this.GetFieldValue<string>("abrev");
                        }
                        set
                        {
                                this.Registro["abrev"] = value;
                        }
                }

                public string Comprobante
                {
                        get
                        {
                                return this.GetFieldValue<string>("comprob");
                        }
                        set
                        {
                                this.Registro["comprob"] = value;
                        }
                }

                public string Comprobante2
                {
                        get
                        {
                                return this.GetFieldValue<string>("comprob2");
                        }
                        set
                        {
                                this.Registro["comprob2"] = value;
                        }
                }

                public string ObtenerLetraPredeterminada()
                {
                        if (Lbl.Sys.Config.Actual.Empresa.SituacionTributaria == 2) {
                                //Si soy responsable inscripto, facturo según la siguiente tabla
                                switch (this.Id) {
                                        case 2:
                                        case 3:
                                                return "A";
                                        default:
                                                return "B";
                                }
                        } else {
                                //De lo contrario, C para todo el mundo
                                return "C";
                        }
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
                        Comando.Fields.AddWithValue("abrev", this.Abreviatura);
                        Comando.Fields.AddWithValue("comprob", this.Comprobante);
                        Comando.Fields.AddWithValue("comprob2", this.Comprobante2);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }

                private static Lbl.ColeccionGenerica<SituacionTributaria> m_Todas = null;
                public static Lbl.ColeccionGenerica<SituacionTributaria> Todas
                {
                        get
                        {
                                if (m_Todas == null)
                                        m_Todas = new Lbl.ColeccionGenerica<SituacionTributaria>(Lfx.Workspace.Master.MasterConnection, Lfx.Workspace.Master.MasterConnection.Select("SELECT * FROM situaciones"));

                                return m_Todas;
                        }
                }
	}
}
