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

using System.Collections.Generic;
using System.Windows.Forms;

namespace Lfc.Personas.Usuarios
{
	public partial class Editar : Lcc.Edicion.ControlEdicion
	{
                private int TipoOriginal = 0;

                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Personas.Usuario);

                        InitializeComponent();
                }

                public override void ActualizarControl()
                {
                        Lbl.Personas.Usuario Usu = this.Elemento as Lbl.Personas.Usuario;

                        EntradaContrasena.Text = "";

                        TipoOriginal = Usu.Tipo;
                        if ((Usu.Tipo & 4) == 4)
                                EntradaAcceso.TextKey = "1";
                        else
                                EntradaAcceso.TextKey = "0";

                        // No se pueden agregar o quitar permisos del usuario Administrador, sólo cambiar la contraseña
                        EntradaAcceso.TemporaryReadOnly = Usu.Id == 1;
                        BotonAgregar.Enabled = Usu.Id != 1;
                        BotonQuitar.Enabled = Usu.Id != 1;

                        this.MostrarPermisos(Usu);

                        base.ActualizarControl();
                }


                private void MostrarPermisos(Lbl.Personas.Usuario usuario)
                {
                        Listado.SuspendLayout();
                        Listado.Items.Clear();

                        foreach (Lbl.Sys.Permisos.Permiso Perm in usuario.Pemisos) {
                                this.MostrarPermiso(Perm);
                        }

                        Listado.Sorting = SortOrder.Ascending;
                        Listado.Sort();

                        Listado.ResumeLayout();
                }

                private void MostrarPermiso(Lbl.Sys.Permisos.Permiso permiso)
                {
                        Lbl.Sys.Permisos.Operaciones Nivel = permiso.Operaciones;
                        string Key = permiso.GetHashCode().ToString();
                        ListViewItem Itm = Listado.Items.Add(Key, Key, 0);
                        Itm.Tag = permiso;
                        Itm.SubItems.Add(permiso.Objeto.Nombre);
                        Itm.SubItems.Add(Nivel.ToString());
                        if (permiso.Item == null)
                                Itm.SubItems.Add("Todos");
                        else
                                Itm.SubItems.Add(permiso.Item.ToString());
                }

	
                public override void ActualizarElemento()
                {
                        Lbl.Personas.Usuario Pers = this.Elemento as Lbl.Personas.Usuario;

                        int Tipo = TipoOriginal;
                        if (EntradaAcceso.TextKey == "1")
                                Tipo = Tipo | 4;
                        else
                                Tipo = Tipo & (~4);

                        Pers.Tipo = Tipo;

                        if (EntradaContrasena.Text.Length > 0)
                                Pers.Contrasena = EntradaContrasena.Text;

                        base.ActualizarElemento();
                }


                public override Lfx.Types.OperationResult ValidarControl()
                {
                        if (EntradaContrasena.Text.Length > 0) {
                                if (EntradaContrasena.Text.Length < 6 || EntradaContrasena.Text.Length > 32)
                                        return new Lfx.Types.FailureOperationResult("La contraseña debe tener entre 6 y 32 caracteres");

                        }

                        return base.ValidarControl();
                }

                private void QuitarPermiso(Lbl.Sys.Permisos.Permiso permiso)
                {
                        Lbl.Personas.Usuario Usu = this.Elemento as Lbl.Personas.Usuario;

                        Usu.Pemisos.Remove(permiso);
                        Listado.Items.RemoveByKey(permiso.GetHashCode().ToString());
                }


                private void BotonQuitar_Click(object sender, System.EventArgs e)
                {
                        if (Listado.SelectedItems.Count > 0) {
                                Lbl.Sys.Permisos.Permiso Perm = Listado.SelectedItems[0].Tag as Lbl.Sys.Permisos.Permiso;
                                if(Perm != null)
                                        QuitarPermiso(Perm);
                        }
                }


                private void BotonAgregar_Click(object sender, System.EventArgs e)
                {
                        Lbl.Personas.Usuario Usu = this.Elemento as Lbl.Personas.Usuario;
                        EditarPermiso FormularioAgregar = new EditarPermiso();
                        FormularioAgregar.Usuario = Usu;

                        if (FormularioAgregar.ShowDialog() == DialogResult.OK) {
                                Lbl.Sys.Permisos.Permiso NuevoPerm = FormularioAgregar.Permiso;
                                Usu.Pemisos.Add(NuevoPerm);
                                this.MostrarPermiso(NuevoPerm);
                        }
                }

                private void Listado_DoubleClick(object sender, System.EventArgs e)
                {
                        if(Listado.SelectedItems.Count > 0) {
                                ListViewItem Itm = Listado.SelectedItems[0];
                                Lbl.Sys.Permisos.Permiso Perm = Itm.Tag as Lbl.Sys.Permisos.Permiso;
                                if (Perm != null) {
                                        Lbl.Personas.Usuario Usu = this.Elemento as Lbl.Personas.Usuario;
                                        EditarPermiso FormularioAgregar = new EditarPermiso();
                                        FormularioAgregar.Usuario = Usu;
                                        FormularioAgregar.Permiso = Perm;

                                        if (FormularioAgregar.ShowDialog() == DialogResult.OK) {
                                                // Elimino el permiso viejo
                                                Listado.Items.Remove(Itm);
                                                Usu.Pemisos.Remove(Perm);

                                                // Agrego el nuevo
                                                Lbl.Sys.Permisos.Permiso NuevoPerm = FormularioAgregar.Permiso;
                                                Usu.Pemisos.Add(NuevoPerm);
                                                this.MostrarPermiso(NuevoPerm);
                                        }
                                }
                        }
                }
	}
}