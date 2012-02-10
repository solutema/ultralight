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

namespace Lbl.Tareas
{
        /// <summary>
        /// Representa una tarea.
        /// </summary>
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Tarea", Grupo = "Tareas")]
        [Lbl.Atributos.Datos(TablaDatos = "tickets", CampoId = "id_ticket")]
        [Lbl.Atributos.Presentacion()]
        public class Tarea : ElementoDeDatos
        {
                private Comprobantes.ColeccionDetalleArticulos m_Articulos = null;
                //private Lbl.ColeccionGenerica<Novedad> m_Novedades = null;

                public Lbl.Personas.Persona Cliente {get;set;}
                public Lbl.Personas.Persona Encargado { get; set; }
                public Lbl.Comprobantes.Presupuesto Presupuesto { get; set; }
                public Lbl.Comprobantes.ComprobanteFacturable Factura { get; set; }
                public Lbl.Tareas.Tipo Tipo;

                public Tarea(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Tarea(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Tarea(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public string Descripcion
                {
                        get
                        {
                                return this.GetFieldValue<string>("descripcion");
                        }
                        set
                        {
                                this.Registro["descripcion"] = value;
                        }
                }

                public int Prioridad
                {
                        get
                        {
                                return this.GetFieldValue<int>("prioridad");
                        }
                        set
                        {
                                this.Registro["prioridad"] = value;
                        }
                }

                public decimal ImportePresupuesto
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("presupuesto");
                        }
                        set
                        {
                                this.Registro["presupuesto"] = value;
                        }
                }

                public decimal DescuentoArticulos
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("articulos_descuento");
                        }
                        set
                        {
                                this.Registro["articulos_descuento"] = value;
                        }
                }


                public new DateTime Fecha
                {
                        get
                        {
                                return this.GetFieldValue<DateTime>("fecha_ingreso");
                        }
                        set
                        {
                                Registro["fecha_ingreso"] = value;
                        }
                }


                public NullableDateTime FechaEstimada
                {
                        get
                        {
                                return this.FieldDateTime("entrega_estimada");
                        }
                        set
                        {
                                this.Registro["entrega_estimada"] = value;
                        }
                }

                public NullableDateTime FechaLimite
                {
                        get
                        {
                                return this.FieldDateTime("entrega_limite");
                        }
                        set
                        {
                                this.Registro["entrega_limite"] = value;
                        }
                }

                public override void OnLoad()
                {
                        if (m_Registro != null) {
                                if (this.GetFieldValue<int>("id_tipo_ticket") != 0)
                                        this.Tipo = new Tipo(this.Connection, System.Convert.ToInt32(this.Registro["id_tipo_ticket"]));
                                else
                                        this.Tipo = null;

                                if (this.GetFieldValue<int>("id_persona") != 0)
                                        this.Cliente = new Personas.Persona(this.Connection, this.GetFieldValue<int>("id_persona"));
                                else
                                        this.Cliente = null;

                                if (this.GetFieldValue<int>("id_tecnico_recibe") != 0)
                                        this.Encargado = new Personas.Persona(this.Connection, this.GetFieldValue<int>("id_tecnico_recibe"));
                                else
                                        this.Encargado = null;

                                if (this.GetFieldValue<int>("id_presupuesto") != 0)
                                        this.Presupuesto = new Comprobantes.Presupuesto(this.Connection, this.GetFieldValue<int>("id_presupuesto"));
                                else
                                        this.Presupuesto = null;

                                if (this.GetFieldValue<int>("id_comprob") != 0)
                                        this.Factura = new Comprobantes.ComprobanteFacturable(this.Connection, this.GetFieldValue<int>("id_comprob"));
                                else
                                        this.Factura = null;
                        }
                        base.OnLoad();
                }


                public override void Crear()
                {
                        base.Crear();
                        this.Fecha = DateTime.Now;
                        this.Encargado = new Lbl.Personas.Persona(this.Connection, Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                        this.Estado = 1;
                        this.Tipo = new Lbl.Tareas.Tipo(this.Connection, 99);
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha_ingreso", qGen.SqlFunctions.Now);
                                Comando.Fields.AddWithValue("id_sucursal", Lfx.Workspace.Master.CurrentConfig.Empresa.SucursalPredeterminada);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("id_persona", this.Cliente.Id);
                        if (this.Tipo == null)
                                Comando.Fields.AddWithValue("id_tipo_ticket", null);
                        else
                                Comando.Fields.AddWithValue("id_tipo_ticket", this.Tipo.Id);
                        if (this.Encargado == null)
                                Comando.Fields.AddWithValue("id_tecnico_recibe", null);
                        else
                                Comando.Fields.AddWithValue("id_tecnico_recibe", this.Encargado.Id);
                        Comando.Fields.AddWithValue("prioridad", this.Prioridad);
                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("descripcion", this.Descripcion);
                        Comando.Fields.AddWithValue("estado", this.Estado);
                        Comando.Fields.AddWithValue("articulos_descuento", this.DescuentoArticulos);
                        Comando.Fields.AddWithValue("entrega_estimada", this.FechaEstimada);
                        Comando.Fields.AddWithValue("entrega_limite", this.FechaLimite);
                        Comando.Fields.AddWithValue("presupuesto", this.ImportePresupuesto);
                        if (this.Presupuesto == null)
                                Comando.Fields.AddWithValue("id_presupuesto", null);
                        else
                                Comando.Fields.AddWithValue("id_presupuesto", this.Presupuesto.Id);
                        if (this.Factura == null)
                                Comando.Fields.AddWithValue("id_comprob", null);
                        else
                                Comando.Fields.AddWithValue("id_comprob", this.Factura.Id);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);
                        this.ActualizarId();

                        if (this.RegistroOriginal != null && this.RegistroOriginal["estado"] != this.Registro["estado"])
                                this.AgregarComentario("Actualización de Estado: " + Lbl.Tareas.Estado.TodosPorNumero[this.Estado].ToString());

                        if (this.Articulos != null && this.Articulos.HayCambios) {
                                qGen.Delete EliminarArticulos = new qGen.Delete("tickets_articulos");
                                EliminarArticulos.WhereClause = new qGen.Where("id_ticket", this.Id);
                                this.Connection.Execute(EliminarArticulos);

                                int i = 1;
                                foreach (Lbl.Comprobantes.DetalleArticulo Det in this.Articulos) {
                                        qGen.Insert InsertarArticulo = new qGen.Insert(Connection, "tickets_articulos");
                                        InsertarArticulo.Fields.AddWithValue("id_ticket", this.Id);
                                        if (Det.Articulo == null) {
                                                InsertarArticulo.Fields.AddWithValue("id_articulo", null);
                                                InsertarArticulo.Fields.AddWithValue("nombre", Det.Descripcion);
                                        } else {
                                                InsertarArticulo.Fields.AddWithValue("id_articulo", Det.Articulo.Id);
                                                InsertarArticulo.Fields.AddWithValue("nombre", Det.Articulo.Nombre);
                                        }
                                        
                                        InsertarArticulo.Fields.AddWithValue("orden", i++);
                                        InsertarArticulo.Fields.AddWithValue("cantidad", Det.Cantidad);
                                        InsertarArticulo.Fields.AddWithValue("precio", Det.Unitario);
                                        Connection.Execute(InsertarArticulo);
                                }
                        }

                        return base.Guardar();
                }

                public Comprobantes.ColeccionDetalleArticulos Articulos
                {
                        get
                        {
                                if (m_Articulos == null) {
                                        m_Articulos = new Comprobantes.ColeccionDetalleArticulos(this);
                                        if (this.Existe) {
                                                System.Data.DataTable Arts = this.Connection.Select("SELECT * FROM tickets_articulos WHERE id_ticket=" + this.Id.ToString() + " ORDER BY orden");
                                                foreach (System.Data.DataRow Art in Arts.Rows) {
                                                        Lbl.Comprobantes.DetalleArticulo Det = new Comprobantes.DetalleArticulo(this.Connection);
                                                        Det.Articulo = new Articulos.Articulo(this.Connection, System.Convert.ToInt32(Art["id_articulo"]));
                                                        Det.Cantidad = System.Convert.ToDecimal(Art["cantidad"]);
                                                        Det.Unitario = System.Convert.ToDecimal(Art["precio"]);
                                                        m_Articulos.Add(Det);
                                                }
                                        }
                                        
                                }
                                return m_Articulos;
                        }
                        set
                        {
                                m_Articulos = value;
                        }
                }

                public override string ToString()
                {
                        return "Tarea Nº " + this.Id.ToString();
                }
        }
}
