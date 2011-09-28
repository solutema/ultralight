#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lbl.Entidades
{
        /// <summary>
        /// Representa una sucursal de la empresa.
        /// </summary>
        [Lbl.Atributos.NombreItem("Sucursal")]
	public class Sucursal : ElementoDeDatos
	{
                private Lbl.Entidades.Localidad m_Localidad = null;
                private Lbl.Cajas.Caja m_CajaDiaria = null, m_CajaCheques = null;
                private Lbl.Articulos.Situacion m_SituacionOrigen = null;


		//Heredar constructor
		public Sucursal(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Sucursal(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Sucursal(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

		public override string TablaDatos
		{
			get
			{
				return "sucursales";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_sucursal";
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
                        Comando.Fields.AddWithValue("direccion", this.Direccion);
                        Comando.Fields.AddWithValue("telefono", this.Telefono);

                        if (this.Localidad == null)
                                Comando.Fields.AddWithValue("id_ciudad", null);
                        else
                                Comando.Fields.AddWithValue("id_ciudad", this.Localidad.Id);

                        if (this.CajaDiaria == null)
                                Comando.Fields.AddWithValue("id_caja_diaria", null);
                        else
                                Comando.Fields.AddWithValue("id_caja_diaria", this.CajaDiaria.Id);

                        if (this.CajaCheques == null)
                                Comando.Fields.AddWithValue("id_caja_cheques", null);
                        else
                                Comando.Fields.AddWithValue("id_caja_cheques", this.CajaCheques.Id);

                        if (this.SituacionOrigen == null)
                                Comando.Fields.AddWithValue("situacionorigen", null);
                        else
                                Comando.Fields.AddWithValue("situacionorigen", this.SituacionOrigen.Id);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }

                public override void Crear()
                {
                        base.Crear();

                        this.CajaDiaria = new Cajas.Caja(this.Connection, 999);
                        this.SituacionOrigen = new Articulos.Situacion(this.Connection, 1);
                        this.Localidad = new Localidad(this.Connection, this.Workspace.CurrentConfig.Empresa.IdLocalidad);
                }

                public Cajas.Caja CajaDiaria
                {
                        get
                        {
                                if (m_CajaDiaria == null && this.GetFieldValue<int>("id_caja_diaria") != 0)
                                        m_CajaDiaria = new Cajas.Caja(this.Connection, this.GetFieldValue<int>("id_caja_diaria"));
                                return m_CajaDiaria;
                        }
                        set
                        {
                                m_CajaDiaria = value;
                                this.SetFieldValue("id_caja_diaria", value);
                        }
                }

                public Cajas.Caja CajaCheques
                {
                        get
                        {
                                if (m_CajaCheques == null && this.GetFieldValue<int>("id_caja_cheques") != 0)
                                        m_CajaCheques = new Cajas.Caja(this.Connection, this.GetFieldValue<int>("id_caja_cheques"));
                                return m_CajaCheques;
                        }
                        set
                        {
                                m_CajaCheques = value;
                                this.SetFieldValue("id_caja_cheques", value);
                        }
                }

                public Articulos.Situacion SituacionOrigen
                {
                        get
                        {
                                if (m_SituacionOrigen == null && this.GetFieldValue<int>("situacionorigen") != 0)
                                        m_SituacionOrigen = new Articulos.Situacion(this.Connection, this.GetFieldValue<int>("situacionorigen"));
                                return m_SituacionOrigen;
                        }
                        set
                        {
                                m_SituacionOrigen = value;
                                this.SetFieldValue("situacionorigen", value);
                        }
                }

                public Lbl.Entidades.Localidad Localidad
                {
                        get
                        {
                                if (m_Localidad == null && this.GetFieldValue<int>("id_ciudad") > 0)
                                        m_Localidad = new Lbl.Entidades.Localidad(this.Connection, this.GetFieldValue<int>("id_ciudad"));

                                return m_Localidad;
                        }
                        set
                        {
                                m_Localidad = value;
                                this.SetFieldValue("id_ciudad", m_Localidad);
                        }
                }

                public string Direccion
                {
                        get
                        {
                                return this.GetFieldValue<string>("direccion");
                        }
                        set
                        {
                                this.Registro["direccion"] = value;
                        }
                }

                public string Telefono
                {
                        get
                        {
                                return this.GetFieldValue<string>("telefono");
                        }
                        set
                        {
                                this.Registro["telefono"] = value;
                        }
                }


	}
}
