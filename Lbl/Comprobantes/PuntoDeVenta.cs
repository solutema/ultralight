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

namespace Lbl.Comprobantes
{
        public enum TipoPv
        {
                Inactivo = 0,
                Normal = 1,
                Fiscal = 2
        }

        [Lbl.Atributos.Datos(NombreSingular = "Punto de Venta",
                TablaDatos = "pvs",
                CampoId = "id_pv",
                CampoNombre = "numero")]
        [Lbl.Atributos.Presentacion()]
        public class PuntoDeVenta : ElementoDeDatos
        {
                public Lbl.Entidades.Sucursal Sucursal;
                public Lbl.Impresion.Impresora Impresora;

                public PuntoDeVenta(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public PuntoDeVenta(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public PuntoDeVenta(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public override void Crear()
                {
                        base.Crear();
                        this.Numero = this.Connection.FieldInt("SELECT MAX(id_pv)+1 FROM pvs");
                }

                public override void OnLoad()
                {
                        base.OnLoad();

                        if (this.GetFieldValue<int>("id_sucursal") != 0)
                                this.Sucursal = new Entidades.Sucursal(this.Connection, this.GetFieldValue<int>("id_sucursal"));
                        else
                                this.Sucursal = null;

                        if (this.GetFieldValue<int>("id_impresora") != 0)
                                this.Impresora = new Lbl.Impresion.Impresora(this.Connection, this.GetFieldValue<int>("id_impresora"));
                        else
                                this.Impresora = null;
                }

                public TipoPv Tipo
                {
                        get
                        {
                                return (TipoPv)(this.GetFieldValue<int>("tipo"));
                        }
                        set
                        {
                                this.Registro["tipo"] = (int)value;
                        }
                }

                public Lbl.Impresion.ModelosFiscales ModeloImpresoraFiscal
                {
                        get
                        {
                                return (Lbl.Impresion.ModelosFiscales)(this.GetFieldValue<int>("modelo"));
                        }
                        set
                        {
                                this.Registro["modelo"] = (int)value;
                        }
                }

                public int Puerto
                {
                        get
                        {
                                return this.GetFieldValue<int>("puerto");
                        }
                        set
                        {
                                this.Registro["puerto"] = value;
                        }
                }

                public int Bps
                {
                        get
                        {
                                return this.GetFieldValue<int>("bps");
                        }
                        set
                        {
                                this.Registro["bps"] = value;
                        }
                }

                public int Numero
                {
                        get
                        {
                                return this.GetFieldValue<int>("numero");
                        }
                        set
                        {
                                this.Registro["numero"] = value;
                        }
                }

                public string TipoFac
                {
                        get
                        {
                                return this.GetFieldValue<string>("tipo_fac");
                        }
                        set
                        {
                                this.Registro["tipo_fac"] = value;
                        }
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

                public bool CuentaIva
                {
                        get
                        {
                                return this.GetFieldValue<int>("cuenta_iva") != 0;
                        }
                        set
                        {
                                this.Registro["cuenta_iva"] = value;
                        }
                }

                public bool CuentaIngresosBrutos
                {
                        get
                        {
                                return this.GetFieldValue<int>("cuenta_iibb") != 0;
                        }
                        set
                        {
                                this.Registro["cuenta_iibb"] = value;
                        }
                }

                public bool UsaTalonario
                {
                        get
                        {
                                return this.GetFieldValue<int>("detalonario") != 0;
                        }
                        set
                        {
                                this.Registro["detalonario"] = value ? 1 : 0;
                        }
                }

                public bool CargaManual
                {
                        get
                        {
                                return this.GetFieldValue<int>("carga") != 0;
                        }
                        set
                        {
                                this.Registro["carga"] = value ? 1 : 0;
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

                        Comando.Fields.AddWithValue("numero", this.Numero);
                        
                        if (this.Sucursal == null)
                                Comando.Fields.AddWithValue("id_sucursal", null);
                        else
                                Comando.Fields.AddWithValue("id_sucursal", this.Sucursal.Id);
                        
                        if (this.Impresora == null)
                                Comando.Fields.AddWithValue("id_impresora", null);
                        else
                                Comando.Fields.AddWithValue("id_impresora", this.Impresora.Id);
                        Comando.Fields.AddWithValue("tipo", (int)(this.Tipo));
                        Comando.Fields.AddWithValue("tipo_fac", this.TipoFac);
                        Comando.Fields.AddWithValue("detalonario", this.UsaTalonario ? 1 : 0);
                        Comando.Fields.AddWithValue("estacion", this.Estacion);
                        Comando.Fields.AddWithValue("carga", this.CargaManual ? 1 : 0);
                        Comando.Fields.AddWithValue("modelo", (int)(this.ModeloImpresoraFiscal));
                        Comando.Fields.AddWithValue("puerto", this.Puerto);
                        Comando.Fields.AddWithValue("bps", this.Bps);

                        this.AgregarTags(Comando);

                        Connection.Execute(Comando);

                        return base.Guardar();
                }

                public override string ToString()
                {
                        return "Punto de Venta Nº " + base.ToString();
                }

                private static Dictionary<int, PuntoDeVenta> m_TodosPorNumero = null;
                public static Dictionary<int, PuntoDeVenta> TodosPorNumero
                {
                        get
                        {
                                if (m_TodosPorNumero == null) {
                                        m_TodosPorNumero = new Dictionary<int, PuntoDeVenta>();
                                        System.Data.DataTable TablaPvs = Lfx.Workspace.Master.MasterConnection.Select("SELECT * FROM pvs WHERE numero>0");
                                        foreach (System.Data.DataRow RegPv in TablaPvs.Rows) {
                                                m_TodosPorNumero.Add(System.Convert.ToInt32(RegPv["numero"]), new Lbl.Comprobantes.PuntoDeVenta(Lfx.Workspace.Master.MasterConnection, (Lfx.Data.Row)RegPv));
                                        }
                                }
                                return m_TodosPorNumero;
                        }
                }
        }
}