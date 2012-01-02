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
using System.Windows.Forms;

namespace Lfc.Personas
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Personas.Persona);

                        InitializeComponent();

                        EtiquetaClaveBancaria.Text = Lbl.Sys.Config.Actual.Empresa.Pais.ClaveBancaria.Nombre;
                }


                public override Lfx.Types.OperationResult ValidarControl()
                {
                        Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();

                        if (EntradaTipo.TextInt <= 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Seleccione el tipo de cliente" + Environment.NewLine;
                        }

                        Lbl.Personas.Persona Cliente = this.Elemento as Lbl.Personas.Persona;

                        if (EntradaRazonSocial.Text.Length == 0 && EntradaNombre.Text.Length == 0 && EntradaApellido.Text.Length == 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Escriba el Nombre y el Apellido o la Razón Social" + Environment.NewLine;
                        } else {
                                //Busco un cliente con datos similares
                                Lfx.Data.Row ClienteDup = null;
                                string Sql = @"SELECT id_persona, nombre_visible, domicilio, telefono, cuit, email FROM personas WHERE (";
                                if (EntradaNombreVisible.Text.Length > 0)
                                        Sql += @"nombre_visible LIKE '%" + this.Connection.EscapeString(EntradaNombreVisible.Text.Replace("%", "").Replace("_", "")) + @"%'";
                                if (EntradaDomicilio.Text.Length > 0)
                                        Sql += @" OR domicilio LIKE '%" + Workspace.MasterConnection.EscapeString(EntradaDomicilio.Text) + @"%'";

                                if (EntradaNumDoc.Text.Length > 0)
                                        Sql += @" OR REPLACE(num_doc, '.', '') LIKE '%" + Workspace.MasterConnection.EscapeString(EntradaNumDoc.Text.Replace(".", "")) + @"%'";

                                if (EntradaTelefono.Text.Length > 0) {
                                        string Telefono = EntradaTelefono.Text.Replace(" -", "").Replace("- ", "").Replace("/", " ").Replace(",", " ").Replace(".", " ").Replace("  ", " ").Replace("%", "").Replace("_", "");
                                        IList<string> Telefonos = Lfx.Types.Strings.SplitDelimitedString(Telefono, ';');
                                        if (Telefonos != null && Telefonos.Count > 0) {
                                                foreach (string Tel in Telefonos) {
                                                        if (Tel != null && Tel.Length > 4)
                                                                Sql += @" OR telefono LIKE '%" + Workspace.MasterConnection.EscapeString(Tel.Replace("%", "").Replace("_", "")) + @"%'";
                                                }
                                        }
                                }
                                if (EntradaEmail.Text.Length > 0)
                                        Sql += @" OR email LIKE '%" + Workspace.MasterConnection.EscapeString(EntradaEmail.Text.Replace("%", "").Replace("_", "")) + @"%'";
                                if (EntradaClaveTributaria.Text.Length > 0)
                                        Sql += @" OR cuit='" + Workspace.MasterConnection.EscapeString(EntradaClaveTributaria.Text.Replace("%", "").Replace("_", "")) + @"'";
                                Sql += @") AND id_persona<>" + this.Elemento.Id.ToString();

                                ClienteDup = this.Connection.FirstRowFromSelect(Sql);
                                if (ClienteDup != null) {
                                        if (Cliente != null && Cliente.Existe == false) {
                                                AltaDuplicada FormAltaDuplicada = new AltaDuplicada();
                                                ListViewItem itm;
                                                itm = FormAltaDuplicada.ListaComparacion.Items.Add("Nombre");
                                                itm.SubItems.Add(ClienteDup["nombre_visible"].ToString());
                                                itm.SubItems.Add(EntradaNombreVisible.Text);
                                                itm = FormAltaDuplicada.ListaComparacion.Items.Add("Domicilio");
                                                itm.SubItems.Add(ClienteDup["domicilio"].ToString());
                                                itm.SubItems.Add(EntradaDomicilio.Text);
                                                itm = FormAltaDuplicada.ListaComparacion.Items.Add("Teléfono");
                                                itm.SubItems.Add(ClienteDup["telefono"].ToString());
                                                itm.SubItems.Add(EntradaTelefono.Text);
                                                itm = FormAltaDuplicada.ListaComparacion.Items.Add(Lbl.Sys.Config.Actual.Empresa.Pais.ClavePersonasJuridicas.Nombre);
                                                if (ClienteDup["cuit"] != null)
                                                        itm.SubItems.Add(ClienteDup["cuit"].ToString());
                                                else
                                                        itm.SubItems.Add("");
                                                itm.SubItems.Add(EntradaClaveTributaria.Text);
                                                itm = FormAltaDuplicada.ListaComparacion.Items.Add("E-mail");
                                                itm.SubItems.Add(ClienteDup["email"].ToString());
                                                itm.SubItems.Add(EntradaEmail.Text);

                                                switch (FormAltaDuplicada.ShowDialog()) {
                                                        case DialogResult.Yes:
                                                                //Crear uno nuevo
                                                                return new Lfx.Types.SuccessOperationResult();
                                                        case DialogResult.No:
                                                                //Actualizar
                                                                //this.m_Id = System.Convert.ToInt32(rowVeriNombre["id_persona"]);
                                                                this.Elemento = new Lbl.Personas.Persona(this.Elemento.Connection, System.Convert.ToInt32(ClienteDup["id_persona"]));
                                                                return new Lfx.Types.SuccessOperationResult();
                                                        case DialogResult.Cancel:
                                                                //Volver a la edición
                                                                return new Lfx.Types.OperationResult(false);
                                                }
                                        }
                                }
                        }

                        switch (Lbl.Sys.Config.Actual.Empresa.Pais.ClaveBancaria.Nombre) {
                                case "CBU":
                                        if (EntradaClaveBancaria.Text.Length > 0 && Lbl.Bancos.Claves.Cbu.EsValido(EntradaClaveBancaria.Text) == false) {
                                                validarReturn.Success = false;
                                                validarReturn.Message += "La CBU es incorrecta." + Environment.NewLine;
                                        }
                                        break;
                        }

                        switch (Lbl.Sys.Config.Actual.Empresa.Pais.ClavePersonasJuridicas.Nombre) {
                                case "CUIT":
                                        if (EntradaClaveTributaria.Text.Length > 0) {
                                                if (EntradaSituacion.TextInt == 1) {
                                                        validarReturn.Success = false;
                                                        validarReturn.Message += @"Un Cliente con CUIT no debe estar en Situación de ""Consumidor Final""." + Environment.NewLine;
                                                }
                                                if (System.Text.RegularExpressions.Regex.IsMatch(EntradaClaveTributaria.Text, @"^\d{11}$")) {
                                                        EntradaClaveTributaria.Text = EntradaClaveTributaria.Text.Substring(0, 2) + "-" + EntradaClaveTributaria.Text.Substring(2, 8) + "-" + EntradaClaveTributaria.Text.Substring(10, 1);
                                                }

                                                //Agrego los guiones si no los tiene
                                                if (EntradaClaveTributaria.Text.Length == 11)
                                                        EntradaClaveTributaria.Text = EntradaClaveTributaria.Text.Substring(0, 2) + "-" + EntradaClaveTributaria.Text.Substring(2, 8) + "-" + EntradaClaveTributaria.Text.Substring(10, 1);

                                                if (Lbl.Personas.Claves.Cuit.EsValido(EntradaClaveTributaria.Text) == false) {
                                                        validarReturn.Success = false;
                                                        validarReturn.Message += "La CUIT no es correcta." + Environment.NewLine + "El sistema le permite dejar la CUIT en blanco, pero no aceptará una incorrecta." + Environment.NewLine;
                                                }
                                        }
                                        break;
                        }

                        if (EntradaClaveTributaria.Text.Length > 0) {
                                Lfx.Data.Row RowPersMismaClave = this.Connection.FirstRowFromSelect("SELECT id_persona FROM personas WHERE cuit='" + EntradaClaveTributaria.Text + "' AND id_persona<>" + this.Elemento.Id.ToString());
                                if (RowPersMismaClave != null) {
                                        if (Cliente.Existe == false || System.Convert.ToInt32(RowPersMismaClave["id_persona"]) != this.Elemento.Id) {
                                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Ya existe una empresa o persona con esa Clave Tributaria (" + Lbl.Sys.Config.Actual.Empresa.Pais.ClavePersonasJuridicas.Nombre + ") en la base de datos. ¿Desea continuar y crear una nueva de todos modos?", "Clave Tributaria duplicada");
                                                Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                                if (Pregunta.ShowDialog() != DialogResult.OK) {
                                                        validarReturn.Success = false;
                                                        validarReturn.Message += "Cambie la Clave Tributaria (" + Lbl.Sys.Config.Actual.Empresa.Pais.ClavePersonasJuridicas.Nombre + ") para antes de continuar." + Environment.NewLine;
                                                }
                                        }
                                }
                        }

                        return validarReturn;
                }

                public override void ActualizarControl()
                {
                        Lbl.Personas.Persona Cliente = this.Elemento as Lbl.Personas.Persona;

                        bool PermitirEdicionAvanzada = Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(Cliente, Lbl.Sys.Permisos.Operaciones.EditarAvanzado);
                        bool PermitirEdicionCredito = Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(Cliente, Lbl.Sys.Permisos.Operaciones.Extra1);

                        EntradaNombre.Text = Cliente.Nombres;
                        EntradaNombre.Enabled = PermitirEdicionAvanzada;
                        EntradaApellido.Text = Cliente.Apellido;
                        EntradaApellido.Enabled = PermitirEdicionAvanzada;
                        EntradaNombreVisible.Text = Cliente.Nombre;
                        EntradaTipoDoc.Elemento = Cliente.TipoDocumento;
                        EntradaTipoDoc.Enabled = PermitirEdicionAvanzada;
                        EntradaNumDoc.Text = Cliente.NumeroDocumento;
                        EntradaNumDoc.Enabled = PermitirEdicionAvanzada;

                        EntradaRazonSocial.Text = Cliente.RazonSocial;
                        EntradaRazonSocial.Enabled = PermitirEdicionAvanzada;

                        if (Cliente.TipoClaveTributaria != null)
                                EtiquetaClaveTributaria.Text = Cliente.TipoClaveTributaria.Nombre;

                        if (Cliente.ClaveTributaria != null)
                                EntradaClaveTributaria.Text = Cliente.ClaveTributaria.ToString();
                        else
                                EntradaClaveTributaria.Text = "";
                        EntradaClaveTributaria.Enabled = PermitirEdicionAvanzada;
                        EntradaSituacion.Elemento = Cliente.SituacionTributaria;
                        EntradaSituacion.Enabled = PermitirEdicionAvanzada;
                        if (Cliente.FacturaPreferida == null || Cliente.FacturaPreferida.Length == 0)
                                EntradaTipoFac.TextKey = "*";
                        else
                                EntradaTipoFac.TextKey = Cliente.FacturaPreferida;
                        EntradaTipoFac.Enabled = PermitirEdicionAvanzada;

                        EntradaTipo.TextInt = Cliente.Tipo;
                        EntradaTipo.Enabled = PermitirEdicionAvanzada;
                        EntradaGrupo.Elemento = Cliente.Grupo;
                        EntradaSubGrupo.Elemento = Cliente.SubGrupo;
                        EntradaGrupo.Enabled = PermitirEdicionAvanzada;
                        EntradaDomicilio.Text = Cliente.Domicilio;
                        EntradaDomicilioTrabajo.Text = Cliente.DomicilioLaboral;
                        EntradaLocalidad.Elemento = Cliente.Localidad;
                        EntradaTelefono.Text = Cliente.Telefono;
                        EntradaEmail.Text = Cliente.Email;
                        EntradaVendedor.Elemento = Cliente.Vendedor;
                        EntradaLimiteCredito.Text = Lfx.Types.Formatting.FormatCurrency(Cliente.LimiteCredito, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaLimiteCredito.Enabled = PermitirEdicionCredito;
                        if (Cliente.FechaNacimiento == null)
                                EntradaFechaNac.Text = "";
                        else
                                EntradaFechaNac.Text = Lfx.Types.Formatting.FormatDate(Cliente.FechaNacimiento);
                        EntradaFechaNac.Enabled = PermitirEdicionAvanzada;

                        EntradaEstadoCredito.TextKey = ((int)(Cliente.EstadoCredito)).ToString();
                        EntradaEstadoCredito.Enabled = PermitirEdicionCredito;
                        EntradaNumeroCuenta.Text = Cliente.NumeroCuenta;
                        EntradaNumeroCuenta.Enabled = PermitirEdicionAvanzada;

                        string CBU = Cliente.GetFieldValue<string>("cbu");
                        if (CBU == null)
                                EntradaClaveBancaria.Text = "";
                        else if (CBU.Length == 22)
                                EntradaClaveBancaria.Text = CBU.Substring(0, 8) + "-" + CBU.Substring(8, 14);
                        else
                                EntradaClaveBancaria.Text = CBU;
                        EntradaClaveBancaria.Enabled = PermitirEdicionAvanzada;
                        EntradaObs.Text = Cliente.Obs;
                        EntradaObs.Enabled = PermitirEdicionAvanzada;

                        EntradaEstado.TextKey = Cliente.Estado.ToString();

                        if (Cliente.FechaAlta == null)
                                EntradaFechaAlta.Text = "";
                        else
                                EntradaFechaAlta.Text = Cliente.FechaAlta.Value.ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);

                        EntradaFechaAlta.TemporaryReadOnly = true;
                        EntradaFechaBaja.TemporaryReadOnly = true;

                        if (Cliente.FechaBaja == null)
                                EntradaFechaBaja.Text = "";
                        else
                                EntradaFechaBaja.Text = Cliente.FechaBaja.Value.ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);

                        // TODO: pasar esto al formulario parent
                        //EntradaImagen.Enabled = PermitirEdicionAvanzada;
                        //EntradaTags.Enabled = PermitirEdicionAvanzada;

                        EntradaEstado.Enabled = Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(Cliente, Lbl.Sys.Permisos.Operaciones.Eliminar);
                        BotonPermisos.Visible = Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(Cliente, Lbl.Sys.Permisos.Operaciones.Administrar);

                        base.ActualizarControl();
                }

                private void GenerarNombreVisible(System.Object sender, System.EventArgs e)
                {

                        EntradaNombreVisible.Text = "";
                        if (EntradaRazonSocial.Text.Length > 0) {
                                EntradaNombreVisible.Text += EntradaRazonSocial.Text.Trim().ToTitleCase();
                        } else {
                                if (EntradaApellido.Text.Length > 0) {
                                        EntradaNombreVisible.Text += EntradaApellido.Text.Trim();
                                        if (EntradaNombre.Text.Length > 0)
                                                EntradaNombreVisible.Text += ", " + EntradaNombre.Text.Trim();
                                } else {
                                        if (EntradaNombre.Text.Length > 0)
                                                EntradaNombreVisible.Text += EntradaNombre.Text.Trim();
                                }
                        }

                }


                private void EntradaClaveTributaria_Leave(object sender, System.EventArgs e)
                {
                        if (EntradaClaveTributaria.Text.Length == 11)
                                EntradaClaveTributaria.Text = EntradaClaveTributaria.Text.Substring(0, 2) + "-" + EntradaClaveTributaria.Text.Substring(2, 8) + "-" + EntradaClaveTributaria.Text.Substring(10, 1);

                        if (EntradaClaveTributaria.Text.Length == 13 && Lbl.Personas.Claves.Cuit.EsValido(EntradaClaveTributaria.Text) == false)
                                EntradaClaveTributaria.ErrorText = "La CUIT ingresada no es válida.";
                        else if (EntradaClaveTributaria.Text.Length > 0 && EntradaClaveTributaria.Text.Length != 13)
                                EntradaClaveTributaria.ErrorText = "La CUIT ingresada no es válida.";
                        else
                                EntradaClaveTributaria.ErrorText = null;
                }


                private void EntradaSituacion_Leave(object sender, System.EventArgs e)
                {
                        if (EntradaClaveTributaria.Text.Length > 0) {
                                if (EntradaSituacion.TextInt == 1)
                                        EntradaSituacion.ErrorText = "La Situación Tributaria del cliente no se corresponde con la CUIT.";
                                else
                                        EntradaSituacion.ErrorText = "";
                        }
                }


                private void BotonPermisos_Click(object sender, System.EventArgs e)
                {
                        if (Lui.LogOn.LogOnData.ValidateAccess(this.Elemento, Lbl.Sys.Permisos.Operaciones.Administrar)) {
                                if (this.Changed || this.Elemento.Existe == false) {
                                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Antes de editar los permisos debe guardar los cambios en este formulario. ¿Desea guardar ahora?", "Editar Permisos");
                                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                        if (this.Elemento.Existe)
                                                this.ShowChanged = true;
                                        DialogResult Res = Pregunta.ShowDialog();
                                        this.ShowChanged = false;
                                        if (Res != DialogResult.OK)
                                                return;
                                        else
                                                this.Save();
                                }
                                this.Workspace.RunTime.Execute("EDITAR Lbl.Personas.Usuario " + this.Elemento.Id.ToString());
                        }
                }

                public override void ActualizarElemento()
                {
                        Lbl.Personas.Persona Res = this.Elemento as Lbl.Personas.Persona;

                        Res.Tipo = EntradaTipo.TextInt;
                        Res.Grupo = EntradaGrupo.Elemento as Lbl.Personas.Grupo;
                        Res.SubGrupo = EntradaSubGrupo.Elemento as Lbl.Personas.Grupo;
                        Res.Nombres = EntradaNombre.Text.Trim();
                        Res.Apellido = EntradaApellido.Text.Trim();
                        Res.RazonSocial = EntradaRazonSocial.Text.Trim();
                        Res.Nombre = EntradaNombreVisible.Text;
                        Res.TipoDocumento = EntradaTipoDoc.Elemento as Lbl.Entidades.ClaveUnica;
                        Res.NumeroDocumento = EntradaNumDoc.Text;
                        if (EntradaClaveTributaria.Text.Length > 0)
                                Res.ClaveTributaria = new Lbl.Personas.Claves.Cuit(EntradaClaveTributaria.Text);
                        else
                                Res.ClaveTributaria = null;
                        Res.Estado = Lfx.Types.Parsing.ParseInt(EntradaEstado.TextKey);
                        Res.SituacionTributaria = EntradaSituacion.Elemento as Lbl.Impuestos.SituacionTributaria;

                        if (EntradaTipoFac.TextKey == "*")
                                Res.FacturaPreferida = null;
                        else
                                Res.FacturaPreferida = EntradaTipoFac.TextKey;

                        Res.Domicilio = EntradaDomicilio.Text;
                        Res.DomicilioLaboral = EntradaDomicilioTrabajo.Text;
                        Res.Localidad = EntradaLocalidad.Elemento as Lbl.Entidades.Localidad;
                        Res.Telefono = EntradaTelefono.Text;
                        Res.Email = EntradaEmail.Text;
                        Res.Vendedor = EntradaVendedor.Elemento as Lbl.Personas.Persona;
                        Res.Obs = EntradaObs.Text;
                        Res.LimiteCredito = Lfx.Types.Parsing.ParseCurrency(EntradaLimiteCredito.Text);
                        Res.FechaNacimiento = Lfx.Types.Parsing.ParseDate(EntradaFechaNac.Text);
                        Res.NumeroCuenta = EntradaNumeroCuenta.Text;
                        Res.ClaveBancaria = EntradaClaveBancaria.Text.Replace("-", "").Replace(" ", "").Replace("/", "").Replace(".", "");
                        Res.EstadoCredito = ((Lbl.Personas.EstadoCredito)(Lfx.Types.Parsing.ParseInt(EntradaEstadoCredito.TextKey)));
                        Res.Estado = Lfx.Types.Parsing.ParseInt(EntradaEstado.TextKey);

                        base.ActualizarElemento();
                }

                private void EntradaGrupo_TextChanged(object sender, EventArgs e)
                {
                        if (EntradaGrupo.TextInt == 0) {
                                EntradaSubGrupo.TextInt = 0;
                                EntradaSubGrupo.Enabled = false;
                        } else {
                                EntradaSubGrupo.Enabled = true;
                                EntradaSubGrupo.Filter = "parent=" + EntradaGrupo.TextInt.ToString();
                        }
                }

                private void EntradaEmail_Leave(object sender, EventArgs e)
                {
                        EntradaEmail.Text = EntradaEmail.Text.Replace(" ", "").Replace("/", ", ").Replace(";", ", ");
                }

                private void EntradaTipo_TextChanged(object sender, EventArgs e)
                {
                        BotonPermisos.Visible = (EntradaTipo.TextInt & 4) == 4;
                }
        }
}