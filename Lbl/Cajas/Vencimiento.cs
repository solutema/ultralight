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

namespace Lbl.Cajas
{
        public enum Frecuencias
        {
                Unica,
                Diaria,
                Semanal,
                Mensual,
                Bimestral,
                Trimestral,
                Cuatrimestral,
                Semestral,
                Anual
        }

        [Lbl.Atributos.Datos(NombreSingular = "Vencimiento",
                Grupo = "Cajas",
                TablaDatos = "vencimientos",
                CampoId = "id_vencimiento")]
        [Lbl.Atributos.Presentacion()]
        public class Vencimiento : ElementoDeDatos
        {
                public Cajas.Concepto Concepto;

                //Heredar constructor
                public Vencimiento(Lfx.Data.Connection dataBase)
                        : base(dataBase) {}

                public Vencimiento(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Vencimiento(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public override void Crear()
                {
                        base.Crear();
                        this.Estado = 1;
                        this.FechaInicio = System.DateTime.Now;
                        this.Frecuencia = Frecuencias.Diaria;
                }


                public decimal Importe
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("importe");
                        }
                        set
                        {
                                this.Registro["importe"] = value;
                        }
                }

                public int Repetir
                {
                        get
                        {
                                return this.GetFieldValue<int>("repetir");
                        }
                        set
                        {
                                this.Registro["repetir"] = value;
                        }
                }

                public int Ocurrencia
                {
                        get
                        {
                                return this.GetFieldValue<int>("ocurrencia");
                        }
                        set
                        {
                                this.Registro["ocurrencia"] = value;
                        }
                }

                public Frecuencias Frecuencia
                {
                        get
                        {
                                if (this.GetFieldValue<string>("frecuencia") == null)
                                        return Frecuencias.Unica;

                                switch (this.GetFieldValue<string>("frecuencia").ToUpperInvariant()) {
                                        case "UNICA":
                                                return Frecuencias.Unica;
                                        case "DIARIA":
                                                return Frecuencias.Diaria;
                                        case "SEMANAL":
                                                return Frecuencias.Semanal;
                                        case "MENSUAL":
                                                return Frecuencias.Mensual;
                                        case "BIMESTRAL":
                                                return Frecuencias.Bimestral;
                                        case "TRIMESTRAL":
                                                return Frecuencias.Trimestral;
                                        case "CUATRIMESTRAL":
                                                return Frecuencias.Cuatrimestral;
                                        case "SEMESTRAL":
                                                return Frecuencias.Semestral;
                                        case "ANUAL":
                                                return Frecuencias.Anual;
                                        default:
                                                return Frecuencias.Unica;
                                }
                        }
                        set
                        {
                                this.Registro["frecuencia"] = value.ToString().ToLowerInvariant();
                        }
                }

                public NullableDateTime FechaInicio
                {
                        get
                        {
                                return this.FieldDateTime("fecha_inicio");
                        }
                        set
                        {
                                this.Registro["fecha_inicio"] = value;
                        }
                }

                public NullableDateTime FechaProxima
                {
                        get
                        {
                                return this.FieldDateTime("fecha_proxima");
                        }
                        set
                        {
                                this.Registro["fecha_proxima"] = value;
                        }
                }

                public NullableDateTime FechaFin
                {
                        get
                        {
                                return this.FieldDateTime("fecha_fin");
                        }
                        set
                        {
                                this.Registro["fecha_fin"] = value;
                        }
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (Lfx.Data.Connection.ConvertDBNullToZero(Registro["id_concepto"]) > 0)
                                        this.Concepto = new Cajas.Concepto(this.Connection, System.Convert.ToInt32(Registro["id_concepto"]));
                                else
                                        this.Concepto = null;
                        }
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("fecha_inicio", this.FechaInicio);
                        Comando.Fields.AddWithValue("fecha_proxima", this.FechaProxima);
                        Comando.Fields.AddWithValue("fecha_fin", this.FechaFin);
                        switch(this.Frecuencia) {
                                case Frecuencias.Unica:
                                        Comando.Fields.AddWithValue("frecuencia", "unica");
                                        break;
                                case Frecuencias.Diaria:
                                        Comando.Fields.AddWithValue("frecuencia", "diaria");
                                        break;
                                case Frecuencias.Semanal:
                                        Comando.Fields.AddWithValue("frecuencia", "semanal");
                                        break;
                                case Frecuencias.Mensual:
                                        Comando.Fields.AddWithValue("frecuencia", "mensual");
                                        break;
                                case Frecuencias.Bimestral:
                                        Comando.Fields.AddWithValue("frecuencia", "bimestral");
                                        break;
                                case Frecuencias.Trimestral:
                                        Comando.Fields.AddWithValue("frecuencia", "trimestral");
                                        break;
                                case Frecuencias.Cuatrimestral:
                                        Comando.Fields.AddWithValue("frecuencia", "cuatrimestral");
                                        break;
                                case Frecuencias.Semestral:
                                        Comando.Fields.AddWithValue("frecuencia", "semestral");
                                        break;
                                case Frecuencias.Anual:
                                        Comando.Fields.AddWithValue("frecuencia", "anual");
                                        break;
                        }
                        Comando.Fields.AddWithValue("importe", this.Importe);
                        Comando.Fields.AddWithValue("repetir", this.Repetir);
                        Comando.Fields.AddWithValue("ocurrencia", this.Ocurrencia);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        if (this.Concepto == null)
                                Comando.Fields.AddWithValue("id_concepto", null);
                        else
                                Comando.Fields.AddWithValue("id_concepto", this.Concepto.Id);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return new Lfx.Types.SuccessOperationResult();
                }
        }
}
