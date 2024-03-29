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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lazaro.WinMain.Config
{
        public partial class ConfigurarBd : Lui.Forms.Form
        {
                public ConfigurarBd()
                {
                        InitializeComponent();
                }

                private void ConfigBD_Load(object sender, System.EventArgs e)
                {
                        string Servidor = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "DataSource", null);
                        string Conexion = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "ConnectionType", null);
                        string BD = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "DatabaseName", null);
                        string Usuario = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "User", null);
                        string Contrasena = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "Password", null);
                        string Branch = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Company", "Branch", null);

                        if (Servidor == null)
                                EntradaServidor.Text = "localhost";
                        else
                                EntradaServidor.Text = Servidor;

                        if (Conexion == null)
                                EntradaConexion.TextKey = "mysql";
                        else
                                EntradaConexion.TextKey = Conexion;

                        if (BD == null)
                                EntradaBD.Text = "lazaro";
                        else
                                EntradaBD.Text = BD;

                        if (Usuario == null) {
                                if (EntradaServidor.Text == "localhost")
                                        EntradaUsuario.Text = "root";
                                else
                                        EntradaUsuario.Text = "lazaro";
                        } else {
                                EntradaUsuario.Text = Usuario;
                        }

                        if (Contrasena == null)
                                EntradaContrasena.Text = "";
                        else
                                EntradaContrasena.Text = Contrasena;

                        if (Branch == null)
                                EntradaSucursal.Text = "1";
                        else
                                EntradaSucursal.Text = Branch;
                }


                private void EntradaConexion_TextChanged(System.Object sender, System.EventArgs e)
                {
                        switch (EntradaConexion.TextKey) {
                                case "odbc":
                                        EtiquetaServidor.Text = "DSN";
                                        break;
                                default:
                                        EtiquetaServidor.Text = "Servidor";
                                        break;
                        }
                }


                private void BotonAceptar_Click(System.Object sender, System.EventArgs e)
                {
                        if (EntradaServidor.Text.Length == 0) {
                                Lui.Forms.MessageBox.Show("Por favor escriba el nombre del Servidor.", "Error");
                                return;
                        }
                        if (EntradaConexion.TextKey != "odbc" && EntradaUsuario.Text.Length == 0) {
                                Lui.Forms.MessageBox.Show("Por favor escriba el nombre del Usuario.", "Error");
                                return;
                        }

                        this.Hide();

                        Lfx.Data.DataBaseCache.DefaultCache.ServerName = EntradaServidor.Text;
                        switch (EntradaConexion.TextKey) {
                                case "odbc":
                                        Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.Odbc;
                                        break;
                                case "myodbc":
                                case "mysql":
                                        Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MySql;
                                        break;
                                case "npgsql":
                                        Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.Npgsql;
                                        break;
                                case "mssql":
                                        Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MSSql;
                                        break;
                                case "sqlite":
                                        Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.SQLite;
                                        break;
                        }

                        Lfx.Data.DataBaseCache.DefaultCache.DataBaseName = EntradaBD.Text;
                        Lfx.Data.DataBaseCache.DefaultCache.UserName = EntradaUsuario.Text;
                        Lfx.Data.DataBaseCache.DefaultCache.Password = EntradaContrasena.Text;

                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DataSource", Lfx.Data.DataBaseCache.DefaultCache.ServerName);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "ConnectionType", EntradaConexion.TextKey);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DatabaseName", EntradaBD.Text);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "User", EntradaUsuario.Text);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "Password", EntradaContrasena.Text);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "SlowLink", Lfx.Data.DataBaseCache.DefaultCache.SlowLink ? "1" : "0");
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Company", "Branch", EntradaSucursal.Text);

                        Aplicacion.AbrirConexion();
                        this.DialogResult = DialogResult.Retry;
                }


                private void BotonCancelar_Click(System.Object sender, System.EventArgs e)
                {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                }

                private void EntradaServidor_Leave(object sender, EventArgs e)
                {
                        if (EntradaServidor.Text == "localhost" || EntradaServidor.Text == "127.0.0.1") {
                                if (EntradaUsuario.Text == "lazaro" && EntradaContrasena.Text == "") {
                                        EntradaUsuario.Text = "root";
                                }
                        } else {
                                if (EntradaUsuario.Text == "root" && EntradaContrasena.Text == "") {
                                        EntradaUsuario.Text = "lazaro";
                                }
                        }
                }
        }
}