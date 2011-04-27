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
using System.Windows.Forms;

namespace Lfc.Personas
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                public Editar()
                {
                        this.ElementoTipo = typeof(Lbl.Personas.Persona);

                        InitializeComponent();
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
                                        List<string> Telefonos = Lfx.Types.Strings.SplitDelimitedString(Telefono, ' ');
                                        if (Telefonos != null && Telefonos.Count > 0) {
                                                foreach (string Tel in Telefonos) {
                                                        if (Tel != null && Tel.Length > 4)
                                                                Sql += @" OR telefono LIKE '%" + Workspace.MasterConnection.EscapeString(Tel.Replace("%", "").Replace("_", "")) + @"%'";
                                                }
                                        }
                                }
                                if (EntradaEmail.Text.Length > 0)
                                        Sql += @" OR email LIKE '%" + Workspace.MasterConnection.EscapeString(EntradaEmail.Text.Replace("%", "").Replace("_", "")) + @"%'";
                                if (EntradaCuit.Text.Length > 0)
                                        Sql += @" OR cuit='" + Workspace.MasterConnection.EscapeString(EntradaCuit.Text.Replace("%", "").Replace("_", "")) + @"'";
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
                                                itm = FormAltaDuplicada.ListaComparacion.Items.Add("CUIT");
                                                if (ClienteDup["cuit"] != null)
                                                        itm.SubItems.Add(ClienteDup["cuit"].ToString());
                                                else
                                                        itm.SubItems.Add("");
                                                itm.SubItems.Add(EntradaCuit.Text);
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

                        if (EntradaCbu.Text.Length > 0) {
                                if (Lfx.Types.Strings.EsCbuValida(EntradaCbu.Text) == false) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "La CBU no es correcta." + Environment.NewLine + "El sistema le permite dejar la CBU en blanco, pero no aceptará una incorrecta." + Environment.NewLine;
                                }
                        }

                        if (EntradaVendedor.TextInt == 0 && this.Elemento.Existe == false) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Debe ingresar un vendedor.";
                        }


                        if (EntradaCuit.Text.Length > 0) {
                                if (EntradaSituacion.TextInt == 1) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += @"Un Cliente con CUIT no debe estar en Situación de ""Consumidor Final""." + Environment.NewLine;
                                }
                                if (System.Text.RegularExpressions.Regex.IsMatch(EntradaCuit.Text, @"^\d{11}$")) {
                                        EntradaCuit.Text = EntradaCuit.Text.Substring(0, 2) + "-" + EntradaCuit.Text.Substring(2, 8) + "-" + EntradaCuit.Text.Substring(10, 1);
                                }

                                if (Lfx.Types.Strings.EsCuitValido(EntradaCuit.Text)) {
                                        //Agrego los guiones si no los tiene
                                        if (EntradaCuit.Text.Length == 11)
                                                EntradaCuit.Text = EntradaCuit.Text.Substring(0, 2) + "-" + EntradaCuit.Text.Substring(2, 8) + "-" + EntradaCuit.Text.Substring(10, 1);

                                        Lfx.Data.Row rowVeriCUIT = this.Connection.FirstRowFromSelect("SELECT id_persona FROM personas WHERE cuit='" + EntradaCuit.Text + "' AND id_persona<>" + this.Elemento.Id.ToString());
                                        if (rowVeriCUIT != null) {
                                                if (Cliente.Existe == false) {
                                                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Ya existe una empresa o persona con esa CUIT en la base de datos. ¿Desea continuar y crear una nueva de todos modos?", "CUIT duplicada");
                                                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                                        if (Pregunta.ShowDialog() != DialogResult.OK) {
                                                                validarReturn.Success = false;
                                                                validarReturn.Message += "Cambie la CUIT para antes de continuar." + Environment.NewLine;
                                                        }
                                                } else {
                                                        if (System.Convert.ToInt32(rowVeriCUIT["id_persona"]) != this.Elemento.Id) {
                                                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Ya existe una empresa o persona con esa CUIT en la base de datos. ¿Desea continuar y crear una nueva de todos modos?", "CUIT duplicada");
                                                                Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                                                if (Pregunta.ShowDialog() != DialogResult.OK) {
                                                                        validarReturn.Success = false;
                                                                        validarReturn.Message += "Cambie la CUIT para antes de continuar." + Environment.NewLine;
                                                                }
                                                        }
                                                }
                                        }
                                } else {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "La CUIT no es correcta." + Environment.NewLine + "El sistema le permite dejar la CUIT en blanco, pero no aceptará una incorrecta." + Environment.NewLine;
                                }
                        }

                        return validarReturn;
                }

                public override void ActualizarControl()
                {
                        Lbl.Personas.Persona Cliente = this.Elemento as Lbl.Personas.Persona;

                        bool PermitirEdicionAvanzada = Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(Cliente, Lbl.Sys.Permisos.Operaciones.EditarAvanzado);
                        bool PermitirEdicionCredito = Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(Cliente, Lbl.Sys.Permisos.Operaciones.Extra1);

                        EntradaNombre.Text = Cliente.NombreSolo;
                        EntradaNombre.Enabled = PermitirEdicionAvanzada;
                        EntradaApellido.Text = Cliente.Apellido;
                        EntradaApellido.Enabled = PermitirEdicionAvanzada;
                        EntradaNombreVisible.Text = Cliente.Nombre;
                        EntradaTipoDoc.TextInt = Cliente.TipoDocumento;
                        EntradaTipoDoc.Enabled = PermitirEdicionAvanzada;
                        EntradaNumDoc.Text = Cliente.NumeroDocumento;
                        EntradaNumDoc.Enabled = PermitirEdicionAvanzada;

                        EntradaRazonSocial.Text = Cliente.RazonSocial;
                        EntradaRazonSocial.Enabled = PermitirEdicionAvanzada;
                        if (Cliente.Cuit != null)
                                EntradaCuit.Text = Cliente.Cuit.ToString();
                        else
                                EntradaCuit.Text = "";
                        EntradaCuit.Enabled = PermitirEdicionAvanzada;
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
                                EntradaCbu.Text = "";
                        else if (CBU.Length == 22)
                                EntradaCbu.Text = CBU.Substring(0, 8) + "-" + CBU.Substring(8, 14);
                        else
                                EntradaCbu.Text = CBU;
                        EntradaCbu.Enabled = PermitirEdicionAvanzada;
                        EntradaObs.Text = Cliente.Obs;
                        EntradaObs.Enabled = PermitirEdicionAvanzada;

                        EntradaEstado.TextKey = Cliente.Estado.ToString();

                        if (Cliente.FechaAlta == null)
                                EntradaFechaAlta.Text = "";
                        else
                                EntradaFechaAlta.Text = Cliente.FechaAlta.Value.ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);

                        EntradaFechaAlta.ReadOnly = true;
                        EntradaFechaBaja.ReadOnly = true;

                        if (Cliente.FechaBaja == null)
                                EntradaFechaBaja.Text = "";
                        else
                                EntradaFechaBaja.Text = Cliente.FechaBaja.Value.ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);

                        EntradaImagen.Enabled = PermitirEdicionAvanzada;
                        EntradaImagen.Elemento = Cliente;
                        EntradaTags.Elemento = Cliente;
                        EntradaTags.Enabled = PermitirEdicionAvanzada;

                        EntradaEstado.Enabled = Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(Cliente, Lbl.Sys.Permisos.Operaciones.Eliminar);
                        BotonAcceso.Visible = Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(Cliente, Lbl.Sys.Permisos.Operaciones.Eliminar);

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


                private void EntradaCuit_Leave(object sender, System.EventArgs e)
                {
                        if (EntradaCuit.Text.Length == 11)
                                EntradaCuit.Text = EntradaCuit.Text.Substring(0, 2) + "-" + EntradaCuit.Text.Substring(2, 8) + "-" + EntradaCuit.Text.Substring(10, 1);

                        if (EntradaCuit.Text.Length == 13 && Lfx.Types.Strings.EsCuitValido(EntradaCuit.Text) == false)
                                EntradaCuit.ErrorText = "La CUIT ingresada no es válida.";
                        else if (EntradaCuit.Text.Length > 0 && EntradaCuit.Text.Length != 13)
                                EntradaCuit.ErrorText = "La CUIT ingresada no es válida.";
                        else
                                EntradaCuit.ErrorText = null;
                }


                private void EntradaSituacion_Leave(object sender, System.EventArgs e)
                {
                        if (EntradaCuit.Text.Length > 0) {
                                if (EntradaSituacion.TextInt == 1)
                                        EntradaSituacion.ErrorText = "La Situación Tributaria del cliente no se corresponde con la CUIT.";
                                else
                                        EntradaSituacion.ErrorText = "";
                        }
                }


                private void BotonAcceso_Click(object sender, System.EventArgs e)
                {
                        if (this.Elemento.Existe == false) {
                                Lui.Forms.MessageBox.Show("No puede editar el acceso del usuario porque aun no ha sido guardado.", "Error");
                        } else {
                                if (Lui.Login.LoginData.ValidateAccess(this.Elemento, Lbl.Sys.Permisos.Operaciones.Administrar))
                                        this.Workspace.RunTime.Execute("EDITAR Lbl.Personas.Usuario " + this.Elemento.Id.ToString());
                        }
                }

                public override void ActualizarElemento()
                {
                        Lbl.Personas.Persona Res = this.Elemento as Lbl.Personas.Persona;

                        Res.Tipo = EntradaTipo.TextInt;
                        Res.Grupo = EntradaGrupo.Elemento as Lbl.Personas.Grupo;
                        Res.SubGrupo = EntradaSubGrupo.Elemento as Lbl.Personas.Grupo;
                        Res.NombreSolo = EntradaNombre.Text.Trim();
                        Res.Apellido = EntradaApellido.Text.Trim();
                        Res.RazonSocial = EntradaRazonSocial.Text.Trim();
                        Res.Nombre = EntradaNombreVisible.Text;
                        Res.TipoDocumento = EntradaTipoDoc.TextInt;
                        Res.NumeroDocumento = EntradaNumDoc.Text;
                        if (EntradaCuit.Text.Length > 0)
                                Res.Cuit = new Lbl.Personas.Cuit(EntradaCuit.Text);
                        else
                                Res.Cuit = null;
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
                        Res.Cbu = EntradaCbu.Text.Replace("-", "").Replace(" ", "").Replace("/", "").Replace(".", "");
                        Res.EstadoCredito = ((Lbl.Personas.EstadoCredito)(Lfx.Types.Parsing.ParseInt(EntradaEstadoCredito.TextKey)));
                        Res.Estado = Lfx.Types.Parsing.ParseInt(EntradaEstado.TextKey);

                        EntradaTags.ActualizarElemento();
                        EntradaImagen.ActualizarElemento();

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
        }
}