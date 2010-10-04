#region License
// Copyright 2004-2010 South Bridge S.R.L.
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

        public enum ModelosImpresoraFiscal
        {
                Emulacion = 1,
                Hasar = 100,
                Epson = 300
        }

        public class PuntoDeVenta : ElementoDeDatos
        {
                public Lbl.Entidades.Sucursal Sucursal;

                public PuntoDeVenta(Lfx.Data.DataBase dataBase)
                        : base(dataBase) { }

                public PuntoDeVenta(Lfx.Data.DataBase dataBase, int itemId)
			: base(dataBase, itemId) { }

                public PuntoDeVenta(Lfx.Data.DataBase dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

                public override string TablaDatos
                {
                        get
                        {
                                return "pvs";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_pv";
                        }
                }

                public override void OnLoad()
                {
                        base.OnLoad();

                        if (this.FieldInt("id_sucursal") != 0)
                                this.Sucursal = new Entidades.Sucursal(this.DataBase, this.FieldInt("id_sucursal"));
                        else
                                this.Sucursal = null;
                }

                public TipoPv Tipo
                {
                        get
                        {
                                return (TipoPv)(this.FieldInt("tipo"));
                        }
                        set
                        {
                                this.Registro["tipo"] = (int)value;
                        }
                }

                public ModelosImpresoraFiscal ModeloImpresoraFiscal
                {
                        get
                        {
                                return (ModelosImpresoraFiscal)(this.FieldInt("modelo"));
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
                                return this.FieldInt("puerto");
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
                                return this.FieldInt("bps");
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
                                return this.FieldInt("numero");
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
                                return this.FieldString("tipo_fac");
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
                                return this.FieldString("estacion");
                        }
                        set
                        {
                                this.Registro["estacion"] = value;
                        }
                }

                public bool UsaTalonario
                {
                        get
                        {
                                return this.FieldInt("detalonario") != 0;
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
                                return this.FieldInt("carga") != 0;
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
                                Comando = new qGen.Insert(DataBase, "pvs");
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(DataBase, "pvs");
                                Comando.WhereClause = new qGen.Where("id_pv", this.Id);
                        }

                        Comando.Fields.AddWithValue("numero", this.Numero);
                        Comando.Fields.AddWithValue("id_sucursal", this.Sucursal);
                        Comando.Fields.AddWithValue("tipo", (int)(this.Tipo));
                        Comando.Fields.AddWithValue("tipo_fac", this.TipoFac);
                        Comando.Fields.AddWithValue("detalonario", this.UsaTalonario ? 1 : 0);
                        Comando.Fields.AddWithValue("estacion", this.Estacion);
                        Comando.Fields.AddWithValue("carga", this.CargaManual ? 1 : 0);
                        Comando.Fields.AddWithValue("modelo", (int)(this.ModeloImpresoraFiscal));
                        Comando.Fields.AddWithValue("puerto", this.Puerto);
                        Comando.Fields.AddWithValue("bps", this.Bps);

                        this.AgregarTags(Comando);

                        DataBase.Execute(Comando);

                        return base.Guardar();
                }
        }
}