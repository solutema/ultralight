#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace Lbl.Impresion
{
        /// <summary>
        /// Representa una impresora configurada en Lázaro. Puede ser una impresora de Windows,
        /// un controlador fiscal o una impresora nula.
        /// </summary>
        [Lbl.Atributos.NombreItem("Impresora")]
        public class Impresora : ElementoDeDatos
        {
                //Heredar constructor
		public Impresora(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Impresora(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Impresora(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public override string TablaDatos
                {
                        get
                        {
                                return "impresoras";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_impresora";
                        }
                }


                public override void Crear()
                {
                        base.Crear();
                        this.Clase = ClasesImpresora.Comun;
                }


                public bool EsVistaPrevia
                {
                        get
                        {
                                return this.Dispositivo == "lazaro!preview";
                        }
                }


                public bool EsLocalPredeterminada
                {
                        get
                        {
                                return this.Dispositivo == "lazaro!default";
                        }
                }

                public bool EsLocal
                {
                        get
                        {
                                return this.Estacion == null || this.Estacion.ToUpperInvariant() == System.Environment.MachineName.ToUpperInvariant();
                        }
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;
                        if (this.Existe == false) {
                                Comando = new qGen.Insert(Connection, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("estacion", this.Estacion);
                        Comando.Fields.AddWithValue("dispositivo", this.Dispositivo);
                        Comando.Fields.AddWithValue("bandeja", this.Bandeja);
                        Comando.Fields.AddWithValue("ubicacion", this.Ubicacion);
                        
                        Comando.Fields.AddWithValue("tipo", (int)this.Clase);
                        Comando.Fields.AddWithValue("carga", (int)this.CargaPapel);
                        Comando.Fields.AddWithValue("talonario", this.UsaTalonario ? 1 : 0);

                        Comando.Fields.AddWithValue("fiscal_modelo", (int)this.FiscalModelo);
                        Comando.Fields.AddWithValue("fiscal_bps", this.FiscalBps);
                        
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        this.AgregarTags(Comando);

                        Connection.Execute(Comando);

                        return base.Guardar();
                }


                public string Estacion
                {
                        get
                        {
                                return this.GetFieldValue<string>("estacion");
                        }
                        set
                        {
                                this.Registro["estacion"] = value;
                        }
                }

                public string Dispositivo
                {
                        get
                        {
                                return this.GetFieldValue<string>("dispositivo");
                        }
                        set
                        {
                                this.Registro["dispositivo"] = value;
                        }
                }


                public string DispositivoUnc
                {
                        get
                        {
                                if (this.Estacion != null)
                                        return @"\\" + this.Estacion + @"\" + this.Dispositivo;
                                else
                                        return this.Dispositivo;
                        }
                }


                public string Bandeja
                {
                        get
                        {
                                return this.GetFieldValue<string>("bandeja");
                        }
                        set
                        {
                                this.Registro["bandeja"] = value;
                        }
                }

                public string Ubicacion
                {
                        get
                        {
                                return this.GetFieldValue<string>("ubicacion");
                        }
                        set
                        {
                                this.Registro["ubicacion"] = value;
                        }
                }

                public bool UsaTalonario
                {
                        get
                        {
                                return this.GetFieldValue<int>("usatalonario") != 0;
                        }
                        set
                        {
                                this.Registro["usatalonario"] = value ? 1 : 0;
                        }
                }

                public ClasesImpresora Clase
                {
                        get
                        {
                                return (ClasesImpresora)this.GetFieldValue<int>("tipo");
                        }
                        set
                        {
                                this.Registro["tipo"] = (int)value;
                        }
                }

                public CargasPapel CargaPapel
                {
                        get
                        {
                                return (CargasPapel)this.GetFieldValue<int>("carga");
                        }
                        set
                        {
                                this.Registro["carga"] = (int)value;
                        }
                }

                public Lbl.Impresion.ModelosFiscales FiscalModelo
                {
                        get
                        {
                                return (Lbl.Impresion.ModelosFiscales)this.GetFieldValue<int>("fiscal_modelo");
                        }
                        set
                        {
                                this.Registro["fiscal_modelo"] = (int)value;
                        }
                }

                public int FiscalBps
                {
                        get
                        {
                                return this.GetFieldValue<int>("fiscal_bps");
                        }
                        set
                        {
                                this.Registro["fiscal_bps"] = value;
                        }
                }

                public static Lbl.Impresion.Impresora InstanciarImpresoraLocal(Lfx.Data.Connection dataBase, string nombreImpresora)
                {
                        Lbl.Impresion.Impresora Impr = new Lbl.Impresion.Impresora(dataBase);
                        Impr.Clase = Lbl.Impresion.ClasesImpresora.Comun;
                        Impr.Nombre = nombreImpresora;
                        Impr.Estacion = System.Environment.MachineName.ToUpperInvariant();
                        Impr.CargaPapel = Lbl.Impresion.CargasPapel.Automatica;
                        Impr.Dispositivo = nombreImpresora;
                        Impr.Estado = 1;

                        return Impr;
                }
        }
}
