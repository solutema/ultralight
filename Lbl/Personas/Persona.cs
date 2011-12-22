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

namespace Lbl.Personas
{
        /// <summary>
        /// Representa una persona física o jurídica.
        /// </summary>
        [Lbl.Atributos.NombreItem("Persona")]
        public class Persona : ElementoDeDatos, IElementoConImagen, ICamposBaseEstandar
	{
                private Entidades.Localidad m_Localidad = null;
                private Grupo m_Grupo = null, m_SubGrupo = null;
                private Lbl.Impuestos.SituacionTributaria m_SituacionTributaria = null;

                //private Accesos.ListaDeAccesos m_Accesos = null;
                private Lbl.CuentasCorrientes.CuentaCorriente m_CuentaCorriente = null;
                private Lbl.Personas.Persona m_Vendedor = null;

                // Heredar constructores
                public Persona(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Persona(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Persona(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public override void Crear()
                {
                        base.Crear();
                        m_CuentaCorriente = null;

                        m_CuentaCorriente = null;
                        this.Vendedor = null;
                        this.Tipo = 1;
                        int IdGrupoPredet = this.Connection.FieldInt("SELECT id_grupo FROM personas_grupos WHERE predet=1");
                        if (IdGrupoPredet != 0)
                                this.Grupo = new Lbl.Personas.Grupo(this.Connection, IdGrupoPredet);
                        this.SubGrupo = null;
                        if (Lbl.Sys.Config.Actual.Empresa.Pais != null) {
                                if (Lbl.Sys.Config.Actual.Empresa.Pais.ClavePersonasFisicas != null)
                                        this.TipoDocumento = Lbl.Sys.Config.Actual.Empresa.Pais.ClavePersonasFisicas;
                                if (Lbl.Sys.Config.Actual.Empresa.Pais.ClavePersonasFisicas != null)
                                        this.TipoClaveTributaria = Lbl.Sys.Config.Actual.Empresa.Pais.ClavePersonasJuridicas;
                        }
                        this.SituacionTributaria = new Lbl.Impuestos.SituacionTributaria(this.Connection, 1);
                        this.Localidad = new Lbl.Entidades.Localidad(this.Connection, this.Workspace.CurrentConfig.Empresa.IdLocalidad);
                        this.Estado = 1;
                        //this.Contrasena = new System.Random().Next(100000, 999999).ToString();
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                Comando.Fields.AddWithValue("fechaalta", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
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
                        Comando.Fields.AddWithValue("nombre", this.Nombres);
                        Comando.Fields.AddWithValue("apellido", this.Apellido);
                        Comando.Fields.AddWithValue("razon_social", this.RazonSocial);
                        Comando.Fields.AddWithValue("nombre_visible", this.Nombre);
                        if (this.TipoDocumento == null)
                                Comando.Fields.AddWithValue("id_tipo_doc", null);
                        else
                                Comando.Fields.AddWithValue("id_tipo_doc", this.TipoDocumento.Id);
                        if (this.TipoClaveTributaria == null)
                                Comando.Fields.AddWithValue("id_tipo_cuit", null);
                        else
                                Comando.Fields.AddWithValue("id_tipo_cuit", this.TipoClaveTributaria.Id);
                        if (this.NumeroDocumento == null)
                                Comando.Fields.AddWithValue("num_doc", "");
                        else
                                Comando.Fields.AddWithValue("num_doc", this.NumeroDocumento.Replace(".", "").Replace(",", "").Replace(" ", ""));
                        if (this.ClaveTributaria == null)
                                Comando.Fields.AddWithValue("cuit", null);
                        else
                                Comando.Fields.AddWithValue("cuit", this.ClaveTributaria.Valor);
                        if (this.SituacionTributaria == null)
                                Comando.Fields.AddWithValue("id_situacion", null);
                        else
                                Comando.Fields.AddWithValue("id_situacion", this.SituacionTributaria.Id);
                        Comando.Fields.AddWithValue("tipo_fac", this.FacturaPreferida);
                        Comando.Fields.AddWithValue("domicilio", this.Domicilio);
                        Comando.Fields.AddWithValue("domiciliotrabajo", this.DomicilioLaboral);
                        if (this.Localidad == null)
                                Comando.Fields.AddWithValue("id_ciudad", null);
                        else
                                Comando.Fields.AddWithValue("id_ciudad", this.Localidad.Id);
                        if (this.Vendedor == null)
                                Comando.Fields.AddWithValue("id_vendedor", null);
                        else
                                Comando.Fields.AddWithValue("id_vendedor", this.Vendedor.Id);
                        Comando.Fields.AddWithValue("telefono", this.Telefono);
                        Comando.Fields.AddWithValue("email", this.Email);
                        Comando.Fields.AddWithValue("url", this.Url);
                        Comando.Fields.AddWithValue("obs", this.Obs);
                        Comando.Fields.AddWithValue("estado", this.Estado);
                        if (this.Estado == 0 && this.Existe && System.Convert.ToInt32(this.RegistroOriginal["estado"]) != 0)
                                // Esta dado de baja y antes no lo estaba
                                Comando.Fields.AddWithValue("fechabaja", qGen.SqlFunctions.Now);
                        Comando.Fields.AddWithValue("limitecredito", this.LimiteCredito);
                        Comando.Fields.AddWithValue("fechanac", this.FechaNacimiento);
                        Comando.Fields.AddWithValue("numerocuenta", this.NumeroCuenta);
                        Comando.Fields.AddWithValue("cbu", this.ClaveBancaria);
                        Comando.Fields.AddWithValue("estadocredito", this.EstadoCredito);

                        if (this.Existe == false) {
                                // Si estoy creando una persona, le asigno una contraseña aleatoria de 6 digitos
                                string Contrasena = new System.Random().Next(100000, 999999).ToString();
                                Comando.Fields.AddWithValue("contrasena", Contrasena);
                                Comando.Fields.AddWithValue("contrasena_sal", null);
                                Comando.Fields.AddWithValue("contrasena_fecha", qGen.SqlFunctions.Now);
                        }

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }


                public override string TablaDatos
		{
			get
			{
				return "personas";
			}
		}

                public override string TablaImagenes
                {
                        get
                        {
                                return "personas_imagenes";
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


                public override void OnLoad()
                {
                        m_CuentaCorriente = null;
                        m_Etiquetas = null;
                        m_EtiquetasOriginal = null;
                        m_Grupo = null;
                        m_Localidad = null;
                        m_SituacionTributaria = null;
                        m_SubGrupo = null;
                        m_Vendedor = null;
                        base.OnLoad();
                }


		public string NumeroCuenta
		{
			get
			{
				return this.GetFieldValue<string>("numerocuenta");
			}
                        set
                        {
                                this.Registro["numerocuenta"] = value;
                        }
		}

                public string ClaveBancaria
                {
                        get
                        {
                                return this.GetFieldValue<string>("cbu");
                        }
                        set
                        {
                                this.Registro["cbu"] = value;
                        }
                }


                public Lbl.Entidades.ClaveUnica TipoClaveTributaria
                {
                        get
                        {
                                if (Registro["id_tipo_cuit"] == null)
                                        return null;
                                else
                                        return new Entidades.ClaveUnica(this.Connection, this.GetFieldValue<int>("id_tipo_cuit"));
                        }
                        set
                        {
                                if (value == null)
                                        Registro["id_tipo_cuit"] = null;
                                else
                                        Registro["id_tipo_cuit"] = value.Id;
                        }
                }


                public string Cbu
                {
                        get
                        {
                                if (this.ClaveBancaria == null)
                                        return "";
                                else
                                        return this.ClaveBancaria.ToString();
                        }
                }


                public string Cuit
                {
                        get
                        {
                                if (this.ClaveTributaria == null)
                                        return "";
                                else
                                        return this.ClaveTributaria.ToString();
                        }
                }


                public IIdentificadorUnico ClaveTributaria
		{
			get
			{
                                if (this.GetFieldValue<string>("cuit") == null)
                                        return null;
                                else
				        return new Claves.Cuit(this.GetFieldValue<string>("cuit"));
			}
                        set
                        {
                                if (value == null)
                                        this.Registro["cuit"] = null;
                                else
                                        this.Registro["cuit"] = value.Valor;
                        }
		}

                public Impuestos.SituacionIva PagaIva
                {
                        get
                        {
                                if (this.Localidad == null)
                                        return Impuestos.SituacionIva.Predeterminado;
                                else
                                        return this.Localidad.Iva;
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

                public Comprobantes.Tipo ObtenerTipoComprobante()
                {
                        string TipoComprob;
                        if (this.FacturaPreferida != null) {
                                TipoComprob = "F" + this.FacturaPreferida;
                        } else if (this.SituacionTributaria != null) {
                                TipoComprob = "F" + this.SituacionTributaria.ObtenerLetraPredeterminada();
                        } else {
                                TipoComprob = "F" + this.LetraPredeterminada();
                        }

                        if (Lbl.Comprobantes.Tipo.TodosPorLetra.ContainsKey(TipoComprob))
                                return Lbl.Comprobantes.Tipo.TodosPorLetra[TipoComprob];
                        else
                                throw new InvalidOperationException("No se reconoce el tipo de comprobante " + TipoComprob + " para " + this.ToString());
                }


		public Lbl.Entidades.ClaveUnica TipoDocumento
		{
			get
			{
				if(Registro["id_tipo_doc"] == null)
					return null;
				else
					return new Entidades.ClaveUnica(this.Connection, this.GetFieldValue<int>("id_tipo_doc"));
			}
                        set
                        {
                                if (value == null)
                                        Registro["id_tipo_doc"] = null;
                                else
                                        Registro["id_tipo_doc"] = value.Id;
                        }
		}


                public string NumeroDocumento
                {
                        get
                        {
                                return this.GetFieldValue<string>("num_doc");
                        }
                        set
                        {
                                this.Registro["num_doc"] = value;
                        }
                }


                public int Tipo
                {
                        get
                        {
                                return this.GetFieldValue<int>("tipo");
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
                                return this.GetFieldValue<string>("apellido");
                        }
                        set
                        {
                                this.Registro["apellido"] = value;
                        }
                }

                public string Nombres
                {
                        get
                        {
                                return this.GetFieldValue<string>("nombre");
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
                                return this.GetFieldValue<string>("razon_social");
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
				return this.GetFieldValue<string>("domicilio");
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
                                return this.GetFieldValue<string>("domiciliotrabajo");
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
				return this.GetFieldValue<string>("telefono");
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
				return this.GetFieldValue<string>("email");
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
                                return this.GetFieldValue<string>("url");
                        }
                        set
                        {
                                this.Registro["url"] = value;
                        }
                }


                public NullableDateTime FechaNacimiento
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

                public NullableDateTime FechaAlta
                {
                        get
                        {
                                return this.FieldDateTime("fechaalta");
                        }
                        set
                        {
                                this.Registro["fechaalta"] = value;
                        }
                }

                public NullableDateTime FechaBaja
                {
                        get
                        {
                                return this.FieldDateTime("fechabaja");
                        }
                        set
                        {
                                this.Registro["fechabaja"] = value;
                        }
                }

		public string Extra1
		{
			get
			{
				return this.GetFieldValue<string>("extra1");
			}
                        set
                        {
                                this.Registro["extra1"] = value;
                        }
		}

		public decimal LimiteCredito
		{
			get
			{
                                return this.GetFieldValue<decimal>("limitecredito");
			}
                        set
                        {
                                this.Registro["limitecredito"] = value;
                        }
		}

                public Lbl.Personas.Grupo Grupo
                {
                        get
                        {
                                if (m_Grupo == null && this.GetFieldValue<int>("id_grupo") > 0)
                                        m_Grupo = new Grupo(this.Connection, this.GetFieldValue<int>("id_grupo"));

                                return m_Grupo;
                        }
                        set
                        {
                                m_Grupo = value;
                        }
                }

                public Lbl.Personas.Grupo SubGrupo
                {
                        get
                        {
                                if (m_SubGrupo == null && this.GetFieldValue<int>("id_subgrupo") > 0)
                                        m_SubGrupo = new Grupo(this.Connection, this.GetFieldValue<int>("id_subgrupo"));

                                return m_SubGrupo;
                        }
                        set
                        {
                                m_SubGrupo = value;
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

                public Lbl.Impuestos.SituacionTributaria SituacionTributaria
                {
                        get
                        {
                                if (m_SituacionTributaria == null && this.GetFieldValue<int>("id_situacion") > 0)
                                        m_SituacionTributaria = new Lbl.Impuestos.SituacionTributaria(this.Connection, this.GetFieldValue<int>("id_situacion"));

                                return m_SituacionTributaria;
                        }
                        set
                        {
                                m_SituacionTributaria = value;
                        }
                }

                public string LetraPredeterminada()
                {
                        if (this.FacturaPreferida == null) {
                                if (this.SituacionTributaria == null) {
                                        if (Lbl.Sys.Config.Actual.Empresa.SituacionTributaria == 4)
                                                // Soy monotributista
                                                return "C";
                                        else
                                                return "B";
                                } else {
                                        return this.SituacionTributaria.ObtenerLetraPredeterminada();
                                }
                        } else {
                                return this.FacturaPreferida;
                        }
                }

                public Lbl.CuentasCorrientes.CuentaCorriente CuentaCorriente
                {
                        get
                        {
                                if (m_CuentaCorriente == null)
                                        m_CuentaCorriente = new Lbl.CuentasCorrientes.CuentaCorriente(this);
                                return m_CuentaCorriente;
                        }
                }

                public Lbl.Personas.Persona Vendedor
                {
                        get
                        {
                                if (m_Vendedor == null && this.GetFieldValue<int>("id_vendedor") != 0)
                                        m_Vendedor = new Lbl.Personas.Persona(this.Connection, this.GetFieldValue<int>("id_vendedor"));
                                return m_Vendedor;
                        }
                        set
                        {
                                m_Vendedor = value;
                                if (m_Vendedor == null)
                                        this.Registro["id_vendedor"] = 0;
                                else
                                        this.Registro["id_vendedor"] = value.Id;
                        }
                }
	}
}