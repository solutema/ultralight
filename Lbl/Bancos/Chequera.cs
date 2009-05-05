// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lbl.Bancos
{
        public class Chequera : ElementoDeDatos
        {
                public Bancos.Banco Banco;
                public Lbl.Cuentas.CuentaRegular Cuenta;
                public Lbl.Entidades.Sucursal Sucursal;

                //Heredar constructor
                public Chequera(Lws.Data.DataView dataView)
                        : base(dataView)
                {
                        this.Estado = 1;
                }

                public Chequera(Lws.Data.DataView dataView, int idChequera)
			: this(dataView)
		{
			m_ItemId = idChequera;
                        this.Cargar();
		}

                public override string TablaDatos
                {
                        get
                        {
                                return "chequeras";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_chequera";
                        }
                }

                public string Titular
                {
                        get
                        {
                                return this.FieldString("titular");
                        }
                        set
                        {
                                this.Registro["titular"] = value;
                        }
                }

                public int Prefijo
                {
                        get
                        {
                                return this.FieldInt("prefijo");
                        }
                        set
                        {
                                this.Registro["prefijo"] = value;
                        }
                }

                public int Desde
                {
                        get
                        {
                                return this.FieldInt("desde");
                        }
                        set
                        {
                                this.Registro["desde"] = value;
                        }
                }

                public int Hasta
                {
                        get
                        {
                                return this.FieldInt("hasta");
                        }
                        set
                        {
                                this.Registro["hasta"] = value;
                        }
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (this.FieldInt("id_banco") > 0)
                                        this.Banco = new Bancos.Banco(this.DataView, this.FieldInt("id_banco"));
                                else
                                        this.Banco = null;

                                if (this.FieldInt("id_cuenta") > 0)
                                        this.Cuenta = new Cuentas.CuentaRegular(this.DataView, this.FieldInt("id_cuenta"));
                                else
                                        this.Cuenta = null;

                                if (this.FieldInt("id_sucursal") > 0)
                                        this.Sucursal = new Lbl.Entidades.Sucursal(this.DataView, this.FieldInt("id_sucursal"));
                                else
                                        this.Sucursal = null;
                        }
                        base.OnLoad();
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        Lfx.Data.SqlTableCommandBuilder Comando;
                        if (this.Existe == false) {
                                Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "chequeras");
                                Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                        } else {
                                Comando = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "chequeras");
                                Comando.WhereClause = new Lfx.Data.SqlWhereBuilder("id_chequera=" + m_ItemId.ToString());
                        }

                        if (this.Banco == null)
                                Comando.Fields.AddWithValue("id_banco", null);
                        else
                                Comando.Fields.AddWithValue("id_banco", this.Banco.Id);
                        Comando.Fields.AddWithValue("prefijo", this.Prefijo);
                        Comando.Fields.AddWithValue("desde", this.Desde);
                        Comando.Fields.AddWithValue("hasta", this.Hasta);
                        if (this.Cuenta == null)
                                Comando.Fields.AddWithValue("id_cuenta", null);
                        else
                                Comando.Fields.AddWithValue("id_cuenta", this.Cuenta.Id);
                        if (this.Sucursal == null)
                                Comando.Fields.AddWithValue("id_sucursal", null);
                        else
                                Comando.Fields.AddWithValue("id_sucursal", this.Sucursal.Id);
                        Comando.Fields.AddWithValue("titular", this.Titular);
                        Comando.Fields.AddWithValue("estado", this.Estado);

                        DataView.DataBase.Execute(Comando);

                        if (m_ItemId == 0)
                                m_ItemId = DataView.DataBase.FieldInt("SELECT MAX(id_chequera) FROM chequeras");

                        if (this.Desde > 0 && this.Hasta > 0 && this.Hasta > this.Desde) {
                                DataView.DataBase.Execute("UPDATE bancos_cheques SET id_chequera=" + this.Id.ToString() + " WHERE emitido=1 AND numero BETWEEN " + this.Desde.ToString() + " AND " + this.Hasta.ToString());
                                DataView.DataBase.Execute("UPDATE bancos_cheques SET id_chequera=NULL WHERE emitido=1 AND id_chequera=" + this.Id.ToString() + " AND (numero<" + this.Desde.ToString() + " OR numero>" + this.Hasta.ToString() + ")");
                        }

                        return base.Guardar();
                }

                public override string ToString()
                {
                        String Res = "Chequera ";
                        if (Banco != null)
                                Res += " del " + Banco.ToString();
                        return Res;
                }
        }
}
