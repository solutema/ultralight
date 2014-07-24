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

namespace Lbl.Personas
{
        /// <summary>
        /// Describe un usuario del sistema. En realidad es una vista diferente de un registro de la tabla de personas.
        /// </summary>
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Usuario")]
        [Lbl.Atributos.Datos(TablaDatos = "personas", CampoNombre = "nombre_visible", CampoId = "id_persona")]
        [Lbl.Atributos.Presentacion()]
        public class Usuario : ElementoDeDatos
        {
                private bool CambioContrasena = false;

                public Sys.Permisos.ListaDePermisos Pemisos = null;

                // Heredar constructores
                public Usuario(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Usuario(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Usuario(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public string NombreUsuario
                {
                        get
                        {
                                return this.GetFieldValue<string>("nombreusuario");
                        }
                        set
                        {
                                this.Registro["nombreusuario"] = value;
                        }
                }

                public string Contrasena
                {
                        get
                        {
                                return this.GetFieldValue<string>("contrasena");
                        }
                        set
                        {
                                if (this.Contrasena != value) {
                                        CambioContrasena = true;
                                        this.ContrasenaSal = GenerarSal();
                                }
                                this.Registro["contrasena"] = value;
                        }
                }


                public string ContrasenaSal
                {
                        get
                        {
                                return this.GetFieldValue<string>("contrasena_sal");
                        }
                        set
                        {
                                this.Registro["contrasena_sal"] = value;
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

                public override void Crear()
                {
                        throw new InvalidOperationException("No se pueden crear permisos. Sólo se pueden editar permisos de personas existentes");
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                System.Data.DataTable AccList = null;
                                try {
                                        AccList = this.Connection.Select("SELECT * FROM sys_permisos WHERE id_persona=" + this.Id.ToString());
                                } catch {
                                        // Si dió un error, asumo que no existe la tabla, y doy momentáneamente permiso total
                                        Lbl.Sys.Permisos.Objeto Obj = new Sys.Permisos.Objeto(this.Connection);
                                        Obj.Crear();
                                        Obj.Tipo = "Global";
                                        Obj.Nombre = "Global";
                                        this.Pemisos = new Sys.Permisos.ListaDePermisos(this);
                                        this.Pemisos.Add(new Sys.Permisos.Permiso(this,
                                                Obj,
                                                Sys.Permisos.Operaciones.Total, null));
                                }

                                if (AccList != null)
                                        this.Pemisos = new Sys.Permisos.ListaDePermisos(this, AccList);
                        }
                }


                public bool ContrasenaValida(string contrasena)
                {
                        if (this.ContrasenaSal == null || this.ContrasenaSal.Length == 0) {
                                // Es una contraseña en texto plano
                                return this.Contrasena == contrasena;
                        } else {
                                // Es una contraseña encriptada
                                if (Lfx.Types.Strings.SHA256(contrasena + this.ContrasenaSal) == this.Contrasena)
                                        return true;
                                else if (Lfx.Types.Strings.SHA256(contrasena + "{" + this.ContrasenaSal + "}") == this.Contrasena)
                                        return true;
                                else
                                        return false;
                        }
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                throw new InvalidOperationException("Sólo se pueden editar permisos de personas existentes");
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        if (string.IsNullOrEmpty(this.NombreUsuario)) {
                                Comando.Fields.AddWithValue("nombreusuario", null);
                        } else {
                                Comando.Fields.AddWithValue("nombreusuario", this.NombreUsuario);
                        }

                        if (this.CambioContrasena) {
                                if (this.Contrasena == null || this.Contrasena.Length < 6 || this.Contrasena.Length > 32)
                                        throw new InvalidOperationException("La contraseña debe tener entre 6 y 32 caracteres");

                                if (this.ContrasenaSal == null || this.ContrasenaSal.Length == 0) {
                                        // Guardo la contraseña en texto plano
                                        Comando.Fields.AddWithValue("contrasena", Contrasena);
                                } else {
                                        // Guardo un hash SHA256 de la contraseña
                                        Comando.Fields.AddWithValue("contrasena", Lfx.Types.Strings.SHA256(Contrasena + "{" + this.ContrasenaSal + "}"));
                                }
                                Comando.Fields.AddWithValue("contrasena_sal", this.ContrasenaSal);
                                Comando.Fields.AddWithValue("contrasena_fecha", qGen.SqlFunctions.Now);
                        }

                        Comando.Fields.AddWithValue("tipo", this.Tipo);

                        this.Connection.Execute(Comando);

                        // Eliminar todos los permisos asociados con el usuario
                        qGen.Delete EliminarPermisosActuales = new qGen.Delete("sys_permisos");
                        EliminarPermisosActuales.WhereClause = new qGen.Where("id_persona", this.Id);
                        this.Connection.Execute(EliminarPermisosActuales);
                        
                        // Guardar la nueva lista de permisos del usuario
                        foreach (Sys.Permisos.Permiso Perm in this.Pemisos) {
                                qGen.Insert InsertarPermiso = new qGen.Insert("sys_permisos");
                                InsertarPermiso.Fields.AddWithValue("id_persona", this.Id);
                                InsertarPermiso.Fields.AddWithValue("id_objeto", Perm.Objeto.Id);
                                if (Perm.Item == null)
                                        InsertarPermiso.Fields.AddWithValue("items", null);
                                else
                                        InsertarPermiso.Fields.AddWithValue("items", Perm.Item.ToString());
                                InsertarPermiso.Fields.AddWithValue("ops", (int)(Perm.Operaciones));
                                this.Connection.Execute(InsertarPermiso);
                        }

                        return base.Guardar();
                }

                public static string GenerarSal()
                {
                        StringBuilder builder = new StringBuilder();
                        Random random = new Random();
                        char ch;
                        for (int i = 0; i < 100; i++) {
                                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                                builder.Append(ch);
                        }

                        return builder.ToString();
                }
        }
}
