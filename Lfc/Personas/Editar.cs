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

using System;
using System.Windows.Forms;

namespace Lfc.Personas
{
        public partial class Editar : Lui.Forms.EditForm
        {
                public Editar()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();
                }

                public override Lfx.Types.OperationResult Create()
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "people.create"))
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Personas.Persona Cliente = new Lbl.Personas.Persona(this.DataView);
                        Cliente.Crear();
                        Cliente.Grupo = new Lbl.Personas.Grupo(Cliente.DataView, this.Workspace.DefaultDataBase.FieldInt("SELECT id_grupo FROM personas_grupos WHERE predet=1"));
                        this.FromRow(Cliente);

                        this.Text = "Clientes: Nuevo";
                        return base.Create();
                }


                public override Lui.Printing.ItemPrint FormatForPrinting(Lui.Printing.ItemPrint ImprimirItem)
                {
                        ImprimirItem.Titulo = EntradaNombreVisible.Text;
                        ImprimirItem.ParesAgregar("Tipo", EntradaTipo.TextDetail, 1);
                        if (EntradaNombre.Text.Length > 0)
                                ImprimirItem.ParesAgregar("Nombres", EntradaNombre.Text, 1);

                        if (EntradaApellido.Text.Length > 0)
                                ImprimirItem.ParesAgregar("Apellidos", EntradaApellido.Text, 1);

                        if (EntradaRazonSocial.Text.Length > 0)
                                ImprimirItem.ParesAgregar("Razón Social", EntradaRazonSocial.Text, 1);

                        ImprimirItem.ParesAgregar("Situación Tributaria", EntradaSituacion.TextDetail, 1);
                        if (EntradaCuit.Text.Length > 0)
                                ImprimirItem.ParesAgregar("CUIT", EntradaCuit.Text, 1);

                        ImprimirItem.ParesAgregar("Nombre Visible", EntradaNombreVisible.Text, 1);
                        ImprimirItem.ParesAgregar("Domicilio", EntradaDomicilio.Text, 1);
                        ImprimirItem.ParesAgregar("", EntradaCiudad.TextDetail, 1);
                        ImprimirItem.ParesAgregar("Teléfono", EntradaTelefono.Text, 1);
                        if (EntradaEmail.Text.Length > 0)
                                ImprimirItem.ParesAgregar("E-mail", EntradaEmail.Text, 1);

                        if (EntradaObs.Text.Length > 0)
                                ImprimirItem.ParesAgregar("Observaciones", EntradaObs.Text, 1);

                        return ImprimirItem;
                }


                public override Lfx.Types.OperationResult Edit(int iId)
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "people.read"))
                                return new Lfx.Types.NoAccessOperationResult();

                        if (iId == 999) {
                                return new Lfx.Types.FailureOperationResult("No se pueden cambiar los datos de \"Consumidor Final\"");
                        } else {
                                Lbl.Personas.Persona Persona = new Lbl.Personas.Persona(this.DataView, iId);
                                this.FromRow(Persona);
                                return new Lfx.Types.SuccessOperationResult();
                        }
                }

                public override Lfx.Types.OperationResult ValidateData()
                {
                        Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();

                        if (EntradaTipo.TextInt <= 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Seleccione el tipo de cliente" + Environment.NewLine;
                        }

                        Lbl.Personas.Persona Cliente = this.CachedRow as Lbl.Personas.Persona;

                        if (EntradaRazonSocial.Text.Length == 0 && EntradaNombre.Text.Length == 0 && EntradaApellido.Text.Length == 0) {
                                validarReturn.Success = false;
                                validarReturn.Message += "Escriba el Nombre y el Apellido o la Razón Social" + Environment.NewLine;
                        } else {
                                //Busco un cliente con datos similares
                                Lfx.Data.Row rowVeriNombre = null;
                                string Sql = @"SELECT id_persona, nombre_visible, domicilio, telefono, cuit, email FROM personas WHERE (";
                                if (EntradaNombreVisible.Text.Length > 0)
                                        Sql += @"nombre_visible LIKE '%" + this.Workspace.DefaultDataBase.EscapeString(EntradaNombreVisible.Text.Replace("%", "").Replace("_", "")) + @"%'";
                                if (EntradaDomicilio.Text.Length > 0)
                                        Sql += @" OR domicilio LIKE '%" + Workspace.DefaultDataBase.EscapeString(EntradaDomicilio.Text) + @"%'";

                                if (EntradaNumDoc.Text.Length > 0)
                                        Sql += @" OR REPLACE(num_doc, '.', '') LIKE '%" + Workspace.DefaultDataBase.EscapeString(EntradaNumDoc.Text.Replace(".", "")) + @"%'";

                                if (EntradaTelefono.Text.Length > 0) {
                                        string Telefono = EntradaTelefono.Text.Replace(" -", "").Replace("- ", "").Replace("/", " ").Replace(",", " ").Replace(".", " ").Replace("  ", " ").Replace("%", "").Replace("_", "");
                                        System.Collections.ArrayList Telefonos = Lfx.Types.Strings.SplitDelimitedString(Telefono, ' ');
                                        if (Telefonos != null && Telefonos.Count > 0) {
                                                foreach (string Tel in Telefonos) {
                                                        if (Tel != null && Tel.Length > 4)
                                                                Sql += @" OR telefono LIKE '%" + Workspace.DefaultDataBase.EscapeString(Tel.Replace("%", "").Replace("_", "")) + @"%'";
                                                }
                                        }
                                }
                                if (EntradaEmail.Text.Length > 0)
                                        Sql += @" OR email LIKE '%" + Workspace.DefaultDataBase.EscapeString(EntradaEmail.Text.Replace("%", "").Replace("_", "")) + @"%'";
                                if (EntradaCuit.Text.Length > 0)
                                        Sql += @" OR cuit='" + Workspace.DefaultDataBase.EscapeString(EntradaCuit.Text.Replace("%", "").Replace("_", "")) + @"'";
                                Sql += @") AND id_persona<>" + m_Id.ToString();

                                rowVeriNombre = this.Workspace.DefaultDataBase.FirstRowFromSelect(Sql);
                                if (rowVeriNombre != null) {
                                        if (Cliente != null && Cliente.Existe == false) {
                                                AltaDuplicada CliDup = new AltaDuplicada();
                                                ListViewItem itm;
                                                itm = CliDup.ListaComparacion.Items.Add("Nombre");
                                                itm.SubItems.Add(rowVeriNombre["nombre_visible"].ToString());
                                                itm.SubItems.Add(EntradaNombreVisible.Text);
                                                itm = CliDup.ListaComparacion.Items.Add("Domicilio");
                                                itm.SubItems.Add(rowVeriNombre["domicilio"].ToString());
                                                itm.SubItems.Add(EntradaDomicilio.Text);
                                                itm = CliDup.ListaComparacion.Items.Add("Teléfono");
                                                itm.SubItems.Add(rowVeriNombre["telefono"].ToString());
                                                itm.SubItems.Add(EntradaTelefono.Text);
                                                itm = CliDup.ListaComparacion.Items.Add("CUIT");
                                                itm.SubItems.Add(rowVeriNombre["cuit"].ToString());
                                                itm.SubItems.Add(EntradaCuit.Text);
                                                itm = CliDup.ListaComparacion.Items.Add("E-mail");
                                                itm.SubItems.Add(rowVeriNombre["email"].ToString());
                                                itm.SubItems.Add(EntradaEmail.Text);

                                                switch (CliDup.ShowDialog()) {
                                                        case DialogResult.Yes:
                                                                //Crear uno nuevo
                                                                return new Lfx.Types.SuccessOperationResult();
                                                        case DialogResult.No:
                                                                //Actualizar
                                                                this.m_Id = System.Convert.ToInt32(rowVeriNombre["id_persona"]);
                                                                this.CachedRow = new Lbl.Personas.Persona(this.CachedRow.DataView, m_Id);
                                                                return new Lfx.Types.SuccessOperationResult();
                                                        case DialogResult.Cancel:
                                                                //Volver a la edición
                                                                return new Lfx.Types.OperationResult(false);
                                                }
                                        }
                                }
                        }

                        if (EntradaCbu.Text.Length > 0) {
                                if (Lfx.Types.Strings.ValidCBU(EntradaCbu.Text) == false) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "La CBU no es correcta." + Environment.NewLine + "El sistema le permite dejar la CBU en blanco, pero no aceptará una incorrecta." + Environment.NewLine;
                                }
                        }


                        if (EntradaCuit.Text.Length > 0) {
                                if (EntradaSituacion.TextInt == 1) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += @"Un Cliente con CUIT no debe estar en Situación de ""Consumidor Final""." + Environment.NewLine;
                                }
                                if (System.Text.RegularExpressions.Regex.IsMatch(EntradaCuit.Text, @"^\d{11}$")) {
                                        EntradaCuit.Text = EntradaCuit.Text.Substring(0, 2) + "-" + EntradaCuit.Text.Substring(2, 8) + "-" + EntradaCuit.Text.Substring(10, 1);
                                }

                                if (Lfx.Types.Strings.ValidCUIT(EntradaCuit.Text)) {
                                        //Agrego los guiones si no los tiene
                                        if (EntradaCuit.Text.Length == 11)
                                                EntradaCuit.Text = EntradaCuit.Text.Substring(0, 2) + "-" + EntradaCuit.Text.Substring(2, 8) + "-" + EntradaCuit.Text.Substring(10, 1);

                                        Lfx.Data.Row rowVeriCUIT = this.Workspace.DefaultDataBase.FirstRowFromSelect("SELECT id_persona FROM personas WHERE cuit='" + EntradaCuit.Text + "' AND id_persona<>" + m_Id.ToString());
                                        if (rowVeriCUIT != null) {
                                                if (Cliente.Existe == false) {
                                                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Ya existe una empresa o persona con esa CUIT en la base de datos. ¿Desea continuar y crear una nueva de todos modos?", "CUIT duplicada");
                                                        Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                                                        if (Pregunta.ShowDialog() != DialogResult.OK) {
                                                                validarReturn.Success = false;
                                                                validarReturn.Message += "Cambie la CUIT para antes de continuar." + Environment.NewLine;
                                                        }
                                                } else {
                                                        if (System.Convert.ToInt32(rowVeriCUIT["id_persona"]) != m_Id) {
                                                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Ya existe una empresa o persona con esa CUIT en la base de datos. ¿Desea continuar y crear una nueva de todos modos?", "CUIT duplicada");
                                                                Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
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

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Personas.Persona Cliente = row as Lbl.Personas.Persona;

                        bool NegarEdicionAvanzada = !Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "people.write");
                        EntradaNombre.Text = Cliente.NombreSolo;
                        EntradaNombre.ReadOnly = NegarEdicionAvanzada;
                        EntradaApellido.Text = System.Convert.ToString(Cliente.Registro["apellido"]);
                        EntradaApellido.ReadOnly = NegarEdicionAvanzada;
                        EntradaNombreVisible.Text = Cliente.Nombre;
                        EntradaTipoDoc.TextInt = Cliente.TipoDocumento;
                        EntradaTipoDoc.ReadOnly = NegarEdicionAvanzada;
                        EntradaNumDoc.Text = Cliente.NumeroDocumento;
                        EntradaNumDoc.ReadOnly = NegarEdicionAvanzada;

                        EntradaRazonSocial.Text = Cliente.RazonSocial;
                        EntradaRazonSocial.ReadOnly = NegarEdicionAvanzada;
                        EntradaCuit.Text = Cliente.Cuit;
                        EntradaCuit.ReadOnly = NegarEdicionAvanzada;

                        if (Cliente.SituacionTributaria == null)
                                EntradaSituacion.TextInt = 0;
                        else
                                EntradaSituacion.TextInt = Cliente.SituacionTributaria.Id;
                        EntradaSituacion.ReadOnly = NegarEdicionAvanzada;
                        if (Cliente.Registro["tipo_fac"] == null || Cliente.Registro["tipo_fac"].ToString().Length == 0)
                                EntradaTipoFac.TextKey = "*";
                        else
                                EntradaTipoFac.TextKey = System.Convert.ToString(Cliente.Registro["tipo_fac"]);
                        EntradaTipoFac.ReadOnly = NegarEdicionAvanzada;

                        EntradaTipo.TextInt = Cliente.Tipo;
                        EntradaTipo.ReadOnly = NegarEdicionAvanzada;
                        if (Cliente.Grupo == null)
                                EntradaGrupo.TextInt = 0;
                        else
                                EntradaGrupo.TextInt = Cliente.Grupo.Id;
                        if (Cliente.SubGrupo == null)
                                EntradaSubGrupo.TextInt = 0;
                        else
                                EntradaSubGrupo.TextInt = Cliente.SubGrupo.Id;
                        EntradaGrupo.ReadOnly = NegarEdicionAvanzada;
                        EntradaDomicilio.Text = Cliente.Domicilio;
                        EntradaDomicilioTrabajo.Text = Cliente.DomicilioLaboral;
                        if (Cliente.Ciudad == null)
                                EntradaCiudad.TextInt = 0;
                        else
                                EntradaCiudad.TextInt = Cliente.Ciudad.Id;
                        EntradaTelefono.Text = Cliente.Telefono;
                        EntradaEmail.Text = Cliente.Email;

                        EntradaLimiteCredito.Text = Lfx.Types.Formatting.FormatCurrency(Cliente.LimiteCredito, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EntradaLimiteCredito.ReadOnly = NegarEdicionAvanzada;
                        if (Cliente.Registro["fechanac"] == null || Cliente.Registro["fechanac"] is DBNull)
                                EntradaFechaNac.Text = "";
                        else
                                EntradaFechaNac.Text = Lfx.Types.Formatting.FormatDate(Cliente.FechaNacimiento);
                        EntradaFechaNac.ReadOnly = NegarEdicionAvanzada;

                        EntradaEstadoCredito.TextKey = ((int)(Cliente.EstadoCredito)).ToString();
                        EntradaEstadoCredito.ReadOnly = NegarEdicionAvanzada;
                        EntradaNumeroCuenta.Text = Cliente.NumeroCuenta;
                        EntradaNumeroCuenta.ReadOnly = NegarEdicionAvanzada;

                        string CBU = System.Convert.ToString(Cliente.Registro["cbu"]);
                        if (CBU.Length == 22)
                                EntradaCbu.Text = CBU.Substring(0, 8) + "-" + CBU.Substring(8, 14);
                        else
                                EntradaCbu.Text = CBU;
                        EntradaCbu.ReadOnly = NegarEdicionAvanzada;
                        EntradaObs.Text = System.Convert.ToString(Cliente.Registro["obs"]);
                        EntradaObs.ReadOnly = NegarEdicionAvanzada;
                        
                        EntradaTags.Elemento = Cliente;
                        EntradaTags.Enabled = !NegarEdicionAvanzada;

                        this.Text = "Clientes: " + EntradaNombreVisible.Text;
                        BotonAcceso.Visible = Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "people.access");
                        SaveButton.Visible = Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "people.basicwrite") || !NegarEdicionAvanzada;
                }

                private void GenerarNombreVisible(System.Object sender, System.EventArgs e)
                {

                        EntradaNombreVisible.Text = "";
                        if (EntradaRazonSocial.Text.Length > 0) {
                                EntradaNombreVisible.Text += Lfx.Types.Strings.ULCase(EntradaRazonSocial.Text.Trim());
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


                private void txtCUIT_Leave(object sender, System.EventArgs e)
                {
                        if (EntradaCuit.Text.Length == 11)
                                EntradaCuit.Text = EntradaCuit.Text.Substring(0, 2) + "-" + EntradaCuit.Text.Substring(2, 8) + "-" + EntradaCuit.Text.Substring(10, 1);

                        if (EntradaCuit.Text.Length == 13 && Lfx.Types.Strings.ValidCUIT(EntradaCuit.Text) == false)
                                EntradaCuit.ErrorText = "La CUIT ingresada no es válida.";
                        else if (EntradaCuit.Text.Length > 0 && EntradaCuit.Text.Length != 13)
                                EntradaCuit.ErrorText = "La CUIT ingresada no es válida.";
                        else
                                EntradaCuit.ErrorText = null;
                }


                private void txtSituacion_Leave(object sender, System.EventArgs e)
                {
                        if (EntradaCuit.Text.Length > 0) {
                                if (EntradaSituacion.TextInt == 1)
                                        EntradaSituacion.ErrorText = "La Situación Tributaria del cliente no se corresponde con la CUIT.";
                                else
                                        EntradaSituacion.ErrorText = "";
                        }
                }

                private void FormClientesEditar_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        EntradaCiudad.TextInt = this.Workspace.CurrentConfig.Company.idCiudad;
                }

                private void FormClientesEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case Keys.F2:
                                                e.Handled = true;
                                                if (BotonAcceso.Enabled && BotonAcceso.Visible)
                                                        BotonAcceso.PerformClick();
                                                break;
                                }

                        }
                }

                private void BotonAcceso_Click(object sender, System.EventArgs e)
                {
                        if (m_Id == 1) {
                                Lui.Forms.MessageBox.Show("No puede editar el acceso del usuario Administrador.", "Error");
                        } else {
                                if (Lui.Login.LoginData.ValidateAccess(this.Workspace.CurrentUser, "people.access") && Lui.Login.LoginData.RevalidateAccess(this.Workspace.CurrentUser))
                                        this.Workspace.RunTime.Execute("EDIT ACCESS " + m_Id.ToString());
                        }
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Personas.Persona Res = this.CachedRow as Lbl.Personas.Persona;

                        Res.Tipo = EntradaTipo.TextInt;
                        if (EntradaGrupo.TextInt == 0)
                                Res.Grupo = null;
                        else
                                Res.Grupo = new Lbl.Personas.Grupo(Res.DataView, EntradaGrupo.TextInt);
                        if (EntradaSubGrupo.TextInt == 0)
                                Res.SubGrupo = null;
                        else
                                Res.SubGrupo = new Lbl.Personas.Grupo(Res.DataView, EntradaSubGrupo.TextInt);
                        Res.NombreSolo = EntradaNombre.Text.Trim();
                        Res.Apellido = EntradaApellido.Text.Trim();
                        Res.RazonSocial = EntradaRazonSocial.Text.Trim();
                        Res.Nombre = EntradaNombreVisible.Text;
                        Res.TipoDocumento = EntradaTipoDoc.TextInt;
                        Res.NumeroDocumento = EntradaNumDoc.Text;
                        Res.Cuit = EntradaCuit.Text;
                        if (EntradaSituacion.TextInt == 0)
                                Res.SituacionTributaria = null;
                        else
                                Res.SituacionTributaria = new Lbl.Personas.SituacionTributaria(Res.DataView, EntradaSituacion.TextInt);

                        if (EntradaTipoFac.TextKey == "*")
                                Res.FacturaPreferida = null;
                        else
                                Res.FacturaPreferida = EntradaTipoFac.TextKey;

                        Res.Domicilio = EntradaDomicilio.Text;
                        Res.DomicilioLaboral = EntradaDomicilioTrabajo.Text;
                        if (EntradaCiudad.TextInt == 0)
                                Res.Ciudad = null;
                        else
                                Res.Ciudad = new Lbl.Entidades.Ciudad(Res.DataView, EntradaCiudad.TextInt);
                        Res.Telefono = EntradaTelefono.Text;
                        Res.Email = EntradaEmail.Text;
                        Res.Obs = EntradaObs.Text;
                        Res.Estado = 1;
                        Res.LimiteCredito = Lfx.Types.Parsing.ParseCurrency(EntradaLimiteCredito.Text);
                        Res.FechaNacimiento = Lfx.Types.Parsing.ParseDate(EntradaFechaNac.Text);
                        Res.NumeroCuenta = EntradaNumeroCuenta.Text;
                        Res.Cbu = EntradaCbu.Text.Replace("-", "").Replace(" ", "").Replace("/", "").Replace(".", "");
                        Res.EstadoCredito = ((Lbl.Personas.EstadoCredito)(Lfx.Types.Parsing.ParseInt(EntradaEstadoCredito.TextKey)));

                        EntradaTags.ActualizarElemento();

                        return base.ToRow();
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