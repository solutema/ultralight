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

namespace Lbl.Personas
{
	public class Persona : ElementoDeDatos
	{
		//Heredar constructor
		public Persona(Lws.Data.DataView dataView) : base(dataView) { }

		public Entidades.Ciudad Ciudad;
		public Grupo Grupo, SubGrupo;
		public SituacionTributaria SituacionTributaria;
                private Lbl.Cuentas.CuentaCorriente m_CuentaCorriente = null;

		public Persona(Lws.Data.DataView dataView, int idPersona)
			:this(dataView, idPersona, true)
		{
		}

		public Persona(Lws.Data.DataView dataView, int idPersona, bool cargar)
			: this(dataView)
		{
			m_ItemId = idPersona;
                        m_CuentaCorriente = null;
			if(cargar)
				this.Cargar();
		}

                public override Lfx.Types.OperationResult Crear()
                {
                        m_CuentaCorriente = null;
                        Lfx.Types.OperationResult Res = base.Crear();
                        if (Res.Success) {
                                this.Tipo = 1;
                                this.Grupo = null;
                                this.TipoDocumento = 1;
                                this.SituacionTributaria = new SituacionTributaria(this.DataView, 1);
                                this.Ciudad = new Lbl.Entidades.Ciudad(this.DataView, this.Workspace.CurrentConfig.Company.idCiudad);
                        }
                        return Res;
                }


                public override Lfx.Types.OperationResult Guardar()
                {
                        Lfx.Data.SqlTableCommandBuilder Comando;

                        if (this.Existe == false) {
                                Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.Fields.AddWithValue("fechaalta", Lfx.Data.SqlFunctions.Now);
                        } else {
                                Comando = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("tipo", this.Tipo);
                        if (this.Grupo == null)
                                Comando.Fields.AddWithValue("id_grupo", null);
                        else
                                Comando.Fields.AddWithValue("id_grupo", this.Grupo.Id);
                        if (this.SubGrupo == null)
                                Comando.Fields.AddWithValue("id_subgrupo", null);
                        else
                                Comando.Fields.AddWithValue("id_subgrupo", this.SubGrupo.Id);
                        Comando.Fields.AddWithValue("nombre", this.NombreSolo);
                        Comando.Fields.AddWithValue("apellido", this.Apellido);
                        Comando.Fields.AddWithValue("razon_social", this.RazonSocial);
                        Comando.Fields.AddWithValue("nombre_visible", this.Nombre);
                        if (this.Contrasena == null || this.Contrasena.Length == 0)
                                Comando.Fields.AddWithValue("contrasena", null);
                        else
                                Comando.Fields.AddWithValue("contrasena", this.Contrasena);
                        if (this.TipoDocumento == 0)
                                Comando.Fields.AddWithValue("id_tipo_doc", null);
                        else
                                Comando.Fields.AddWithValue("id_tipo_doc", this.TipoDocumento);
                        Comando.Fields.AddWithValue("num_doc", this.NumeroDocumento);
                        Comando.Fields.AddWithValue("cuit", this.CUIT);
                        if (this.SituacionTributaria == null)
                                Comando.Fields.AddWithValue("id_situacion", null);
                        else
                                Comando.Fields.AddWithValue("id_situacion", this.SituacionTributaria.Id);
                        Comando.Fields.AddWithValue("tipo_fac", this.FacturaPreferida);
                        Comando.Fields.AddWithValue("domicilio", this.Domicilio);
                        Comando.Fields.AddWithValue("domiciliotrabajo", this.DomicilioLaboral);
                        if (this.Ciudad == null)
                                Comando.Fields.AddWithValue("id_ciudad", null);
                        else
                                Comando.Fields.AddWithValue("id_ciudad", this.Ciudad.Id);
                        Comando.Fields.AddWithValue("telefono", this.Telefono);
                        Comando.Fields.AddWithValue("email", this.Email);
                        Comando.Fields.AddWithValue("url", this.Url);
                        Comando.Fields.AddWithValue("obs", this.Obs);
                        Comando.Fields.AddWithValue("estado", this.Estado);
                        Comando.Fields.AddWithValue("limitecredito", this.LimiteCredito);
                        Comando.Fields.AddWithValue("fechanac", this.FechaNacimiento);
                        Comando.Fields.AddWithValue("numerocuenta", this.NumeroCuenta);
                        Comando.Fields.AddWithValue("cbu", this.Cbu);
                        Comando.Fields.AddWithValue("estadocredito", this.EstadoCredito);

                        this.AgregarTags(Comando);

                        this.DataView.Execute(Comando);

                        if (this.Existe == false)
                                m_ItemId = this.DataView.DataBase.FieldInt("SELECT MAX(" + this.CampoId + ") FROM " + this.TablaDatos);

                        return base.Guardar();
                }

                public override string TablaDatos
		{
			get
			{
				return "personas";
			}
		}

                public override string CampoId
		{
			get
			{
				return "id_persona";
			}
		}

                public override string CampoNombre
		{
			get
			{
				return "nombre_visible";
			}
		}
		
		public string NumeroDocumento
		{
			get
			{
				return this.FieldString("num_doc");
			}
                        set
                        {
                                this.Registro["num_doc"] = value;
                        }
		}

		public string NumeroCuenta
		{
			get
			{
				return this.FieldString("numerocuenta");
			}
                        set
                        {
                                this.Registro["numerocuenta"] = value;
                        }
		}

                public string Cbu
                {
                        get
                        {
                                return this.FieldString("cbu");
                        }
                        set
                        {
                                this.Registro["cbu"] = value;
                        }
                }

		public string CUIT
		{
			get
			{
				return this.FieldString("cuit");
			}
                        set
                        {
                                this.Registro["cuit"] = value;
                        }
		}

		public EstadoCredito EstadoCredito
		{
			get
			{
				return (EstadoCredito)System.Convert.ToInt32(Registro["estadocredito"]);
			}
                        set
                        {
                                Registro["estadocredito"] = (int)value;
                        }
		}

		public string FacturaPreferida
		{
			get
			{
                                if (this.Registro["tipo_fac"] == null || this.Registro["tipo_fac"] == DBNull.Value || this.Registro["tipo_fac"].ToString().Length == 0)
                                        return null;
                                else
                                        return this.Registro["tipo_fac"].ToString();
			}
                        set
                        {
                                this.Registro["tipo_fac"] = value;
                        }
		}

		public int TipoDocumento
		{
			get
			{
				if(Registro["id_tipo_doc"] == null)
					return 0;
				else
					return this.FieldInt("id_tipo_doc");
			}
                        set
                        {
                                Registro["id_tipo_doc"] = value;
                        }
		}

                public int Tipo
                {
                        get
                        {
                                return this.FieldInt("tipo");
                        }
                        set
                        {
                                this.Registro["tipo"] = value;
                        }
                }

                public string Apellido
                {
                        get
                        {
                                return this.FieldString("apellido");
                        }
                        set
                        {
                                this.Registro["apellido"] = value;
                        }
                }

                public string NombreSolo
                {
                        get
                        {
                                return this.FieldString("nombre");
                        }
                        set
                        {
                                this.Registro["nombre"] = value;
                        }
                }

                public string RazonSocial
                {
                        get
                        {
                                return this.FieldString("razon_social");
                        }
                        set
                        {
                                this.Registro["razon_social"] = value;
                        }
                }

		public string Domicilio
		{
			get
			{
				return this.FieldString("domicilio");
			}
                        set
                        {
                                this.Registro["domicilio"] = value;
                        }
		}

		public string DomicilioLaboral
		{
			get
			{
                                return this.FieldString("domiciliotrabajo");
			}
                        set
                        {
                                this.Registro["domiciliotrabajo"] = value;
                        }
		}

		public string Telefono
		{
			get
			{
				return this.FieldString("telefono");
			}
                        set
                        {
                                this.Registro["telefono"] = value;
                        }
		}

		public string Email
		{
			get
			{
				return this.FieldString("email");
			}
                        set
                        {
                                this.Registro["email"] = value;
                        }
		}

                public string Url
                {
                        get
                        {
                                return this.FieldString("url");
                        }
                        set
                        {
                                this.Registro["url"] = value;
                        }
                }

                public string Contrasena
                {
                        get
                        {
                                return this.FieldString("contrasena");
                        }
                        set
                        {
                                this.Registro["contrasena"] = value;
                        }
                }

                public Lfx.Types.LDateTime FechaNacimiento
		{
			get
			{
				return this.FieldDateTime("fechanac");
			}
                        set
                        {
                                this.Registro["fechanac"] = value;
                        }
		}

		public string Extra1
		{
			get
			{
				return this.FieldString("extra1");
			}
                        set
                        {
                                this.Registro["extra1"] = value;
                        }
		}

		public double LimiteCredito
		{
			get
			{
				return this.FieldDouble("limitecredito");
			}
                        set
                        {
                                this.Registro["limitecredito"] = value;
                        }
		}

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (Lfx.Data.DataBase.ConvertDBNullToZero(m_Registro["id_grupo"]) > 0)
                                        this.Grupo = new Grupo(this.DataView, System.Convert.ToInt32(m_Registro["id_grupo"]));
                                else
                                        this.Grupo = null;

                                if (Lfx.Data.DataBase.ConvertDBNullToZero(m_Registro["id_subgrupo"]) > 0)
                                        this.SubGrupo = new Grupo(this.DataView, System.Convert.ToInt32(m_Registro["id_subgrupo"]));
                                else
                                        this.SubGrupo = null;

                                if (Lfx.Data.DataBase.ConvertDBNullToZero(m_Registro["id_ciudad"]) > 0)
                                        this.Ciudad = new Entidades.Ciudad(this.DataView, System.Convert.ToInt32(m_Registro["id_ciudad"]));
                                else
                                        this.Ciudad = null;

                                if (Lfx.Data.DataBase.ConvertDBNullToZero(m_Registro["id_situacion"]) > 0)
                                        this.SituacionTributaria = new SituacionTributaria(this.DataView, System.Convert.ToInt32(m_Registro["id_situacion"]));
                                else
                                        this.SituacionTributaria = null;

                        }
                        base.OnLoad();
                }

                public string TipoComprobantePredeterminado()
                {
                        if (this.FacturaPreferida == null) {
                                if (this.SituacionTributaria == null)
                                        return "B";
                                else
                                        return this.SituacionTributaria.TipoComprobantePredeterminado();
                        } else {
                                return this.FacturaPreferida;
                        }
                }

                public Lbl.Cuentas.CuentaCorriente CuentaCorriente
                {
                        get
                        {
                                if (m_CuentaCorriente == null)
                                        m_CuentaCorriente = new Lbl.Cuentas.CuentaCorriente(this.DataView, this.Id);
                                return m_CuentaCorriente;
                        }
                }
	}
}