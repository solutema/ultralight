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
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Lazaro.WinMain.Config
{
        public partial class Inicial : Lui.Forms.Form
        {
                public enum Pasos
                {
                        Inicio,
                        Deteccion,
                        SeleccionarAlmacen,
                        InstalarServidor,
                        NombreServidor,
                        PruebaServidor,
                        Final
                }

                private Pasos Paso = Pasos.Inicio;
                private string ServidorDetectado = null;
                private System.Threading.Thread ThreadBuscar = null, ThreadDescargar = null;

                public Inicial()
                {
                        InitializeComponent();
                }


                protected override void OnFormClosing(FormClosingEventArgs e)
                {
                        if (this.ThreadBuscar != null) {
                                this.ThreadBuscar.Abort();
                                this.ThreadBuscar = null;
                        }

                        if (this.ThreadDescargar != null) {
                                this.ThreadDescargar.Abort();
                                this.ThreadDescargar = null;
                        }
                        base.OnFormClosing(e);
                }


                private void BotonSalir_Click(object sender, EventArgs e)
                {
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.Close();
                }


                private void DetectarConfig()
                {
                        if (this.ThreadBuscar != null) {
                                this.ThreadBuscar.Abort();
                                this.ThreadBuscar = null;
                        }

                        switch (Lfx.Environment.SystemInformation.Platform) {
                                case Lfx.Environment.SystemInformation.Platforms.Windows:
                                        /* if (System.IO.File.Exists(@"C:\mysql\bin\mysqld.exe")) {
                                                EtiquetaBuscando.Text = "Lázaro detectó un servidor SQL en este equipo. Haga clic en el botón 'Siguiente' para revisar la configuración detectada.";
                                                EtiquetaBuscarEspere.Visible = false;
                                                ProgresoBuscar.Visible = false;
                                                EntradaServidor.Text = "localhost";
                                                CheckEsteEquipo.Checked = true;
                                        } else { */
                                                Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Buscando un servidor", "Por favor aguarde mientras Lázaro busca un servidor en la red para utilizar como almacén de datos.");
                                                ProgresoBuscar.Visible = true;
                                                Progreso.Modal = false;
                                                Progreso.Advertise = false;
                                                Progreso.Begin();

                                                System.Threading.ThreadStart Buscar = delegate { this.BuscarServidor(Progreso); };
                                                this.ThreadBuscar = new System.Threading.Thread(Buscar);
                                                this.ThreadBuscar.IsBackground = true;
                                                this.ThreadBuscar.Start();

                                                EtiquetaBuscarEspere.Visible = true;
                                                while (Progreso != null && Progreso.IsRunning) {
                                                        System.Threading.Thread.Sleep(100);
                                                        EtiquetaBuscando.Text = Progreso.Status;
                                                        System.Windows.Forms.Application.DoEvents();
                                                        if (this.ThreadBuscar == null)
                                                                return;
                                                }
                                                EtiquetaBuscarEspere.Visible = false;
                                                ProgresoBuscar.Visible = false;

                                                if (ServidorDetectado == null) {
                                                        CheckInstalarAhora.Checked = true;
                                                        EtiquetaBuscando.Text = "Lázaro no pudo encontrar un servidor SQL en la red. Si desea, puede instalar un servidor SQL en este equipo. Haga clic en 'Siguiente' para continuar.";
                                                } else {
                                                        EtiquetaBuscando.Text = "Lázaro detectó un servidor SQL en la red. Haga clic en el botón 'Siguiente' para revisar la configuración detectada.";
                                                        CheckOtroEquipo.Checked = true;
                                                        EntradaServidor.Text = ServidorDetectado;
                                                }
                                        /* } */
                                        break;
                                default:
                                        // No es Windows
                                        CheckInstalarAhora.Enabled = false;
                                        break;
                        }
                }


                /// <summary>
                /// Busco un servidor en la red loca.
                /// </summary>
                /// <returns></returns>
                private void BuscarServidor(Lfx.Types.OperationProgress progreso)
                {
                        foreach (NetworkInterface Intrfc in NetworkInterface.GetAllNetworkInterfaces()) {
                                progreso.ChangeStatus("Buscando en " + Intrfc.Name);
                                if (Intrfc.OperationalStatus == OperationalStatus.Up) {
                                        foreach (UnicastIPAddressInformation MiDireccion in Intrfc.GetIPProperties().UnicastAddresses) {
                                                byte FirstByte = MiDireccion.Address.GetAddressBytes()[0];
                                                if (FirstByte == 192 || FirstByte == 10) {
                                                        byte SecondByte = MiDireccion.Address.GetAddressBytes()[1];
                                                        byte ThirdByte = MiDireccion.Address.GetAddressBytes()[2];
                                                        for (byte i = 1; i < 255; i++) {
                                                                try {
                                                                        IPAddress DireccionServidor = new IPAddress(new byte[] { FirstByte, SecondByte, ThirdByte, i });
                                                                        if (DireccionServidor.Equals(MiDireccion.Address) == false) {
                                                                                Ping Pp = new Ping();
                                                                                PingReply Pr = Pp.Send(DireccionServidor, 100);
                                                                                if (Pr.Status == IPStatus.Success) {
                                                                                        try {
                                                                                                System.Net.Sockets.TcpClient Cliente = new System.Net.Sockets.TcpClient();
                                                                                                Cliente.Connect(DireccionServidor, 3306);
                                                                                                Cliente.Close();
                                                                                                this.ServidorDetectado = DireccionServidor.ToString();

                                                                                                System.Net.IPHostEntry DireccionServidorDetectado = System.Net.Dns.GetHostEntry(ServidorDetectado);
                                                                                                this.ServidorDetectado = DireccionServidorDetectado.HostName;

                                                                                                progreso.End();
                                                                                        } catch {
                                                                                                // Nada
                                                                                        }
                                                                                }
                                                                        }
                                                                } catch {
                                                                        // Ignoro esa IP
                                                                }
                                                        }
                                                }
                                        }
                                }
                        }

                        this.ServidorDetectado = null;
                        progreso.End();
                }


                private void MostrarPaneles()
                {

                        if (Paso == Pasos.Final)
                                BotonSiguiente.Text = "Finalizar";
                        else
                                BotonSiguiente.Text = "Siguiente";

                        BotonAnterior.Enabled = Paso != Pasos.Inicio;

                        PanelInicio.Visible = Paso == Inicial.Pasos.Inicio;
                        PanelDeteccion.Visible = Paso == Inicial.Pasos.Deteccion;
                        PanelSeleccionarAlmacen.Visible = Paso == Inicial.Pasos.SeleccionarAlmacen;
                        PanelNombreServidor.Visible = Paso == Inicial.Pasos.NombreServidor;
                        PanelPruebaServidor.Visible = Paso == Inicial.Pasos.PruebaServidor;
                        PanelInstalacion.Visible = Paso == Inicial.Pasos.InstalarServidor;
                        PanelFinal.Visible = Paso == Inicial.Pasos.Final;
                }

                private void PanelPruebaServidor_VisibleChanged(object sender, EventArgs e)
                {
                        if (PanelPruebaServidor.Visible) {
                                // Probar la conexión al servidor
                                if (CheckEsteEquipo.Checked) {
                                        Lfx.Data.DataBaseCache.DefaultCache.ServerName = "localhost";
                                        Lfx.Data.DataBaseCache.DefaultCache.UserName = "root";
                                        Lfx.Data.DataBaseCache.DefaultCache.Password = "";
                                } else {
                                        Lfx.Data.DataBaseCache.DefaultCache.ServerName = EntradaServidor.Text;
                                        Lfx.Data.DataBaseCache.DefaultCache.UserName = "lazaro";
                                        Lfx.Data.DataBaseCache.DefaultCache.Password = "";
                                }
                                
                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MySql;
                                Lfx.Data.DataBaseCache.DefaultCache.SlowLink = false;
                                Lfx.Data.DataBaseCache.DefaultCache.DataBaseName = "";

                                Lfx.Types.OperationResult Res = this.ProbarServidor();
                                EtiquetaPruebaResultado.Text = Res.Message;
                                BotonSiguiente.Enabled = Res.Success;
                        }
                }


                private Lfx.Types.OperationResult ProbarServidor()
                {
                        try {
                                EtiquetaPruebaResultado.Text = "Probando la conexión...";
                                EtiquetaPruebaError.Text = "";
                                System.Windows.Forms.Application.DoEvents();

                                Lfx.Workspace.Master.MasterConnection.Open();

                                bool TengoDb = false;
                                try {
                                        Lfx.Workspace.Master.MasterConnection.ExecuteSql("USE lazaro");
                                        TengoDb = true;
                                } catch {
                                        try {
                                                Lfx.Workspace.Master.MasterConnection.ExecuteSql("CREATE DATABASE lazaro DEFAULT CHARACTER SET utf8");
                                                Lfx.Workspace.Master.MasterConnection.ExecuteSql("USE lazaro");
                                                TengoDb = true;
                                        } catch {
                                                TengoDb = false;
                                        }
                                }

                                Lfx.Data.DataBaseCache.DefaultCache.DataBaseName = "lazaro";
                                Lfx.Workspace.Master.MasterConnection.Close();
                                Lfx.Workspace.Master.MasterConnection.Open();
                                if (TengoDb) {
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DataSource", Lfx.Data.DataBaseCache.DefaultCache.ServerName);
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "ConnectionType", "mysql");
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DatabaseName", Lfx.Data.DataBaseCache.DefaultCache.DataBaseName);
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "User", Lfx.Data.DataBaseCache.DefaultCache.UserName);
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "Password", Lfx.Data.DataBaseCache.DefaultCache.Password);
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "SlowLink", Lfx.Data.DataBaseCache.DefaultCache.SlowLink ? "1" : "0");
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Company", "Branch", 1);

                                        try {
                                                Lfx.Workspace.Master.MasterConnection.ExecuteSql("GRANT ALL ON lazaro.* TO 'lazaro'@'localhost' IDENTIFIED BY ''");
                                                Lfx.Workspace.Master.MasterConnection.ExecuteSql("GRANT ALL ON lazaro.* TO 'lazaro'@'%' IDENTIFIED BY ''");
                                        } catch {
                                                // No pude crear el acceso para otros usuarios... supongo que no importa
                                        }
                                } else {
                                }

                                if (CheckEsteEquipo.Checked)
                                        EtiquetaPruebaError.Text = "Si va a instalar Lázaro en otros equipos de la red, puede utilizar este equipo como servidor. El nombre de este equipo es " + System.Environment.MachineName;
                                else
                                        EtiquetaPruebaError.Text = "";
                                return new Lfx.Types.SuccessOperationResult("Se realizó una prueba de la configuración del almacén de datos. Todo parece estar en orden. Haga clic en 'Siguiente' para continuar.");
                        } catch (Exception ex) {
                                EtiquetaPruebaError.Text = "El mensaje de error es: " + ex.Message;
                                return new Lfx.Types.SuccessOperationResult("No se pudo conectar al almacén de datos proporcionado. Haga clic en el botón 'Anterior' para ir a la pantalla anterior y volver a intentarlo.");
                        }
                }


                private void BotonSiguiente_Click(object sender, EventArgs e)
                {
                        switch (Paso) {
                                case Inicial.Pasos.Inicio:
                                        if (RadioInicioInstalacionLocal.Checked)
                                                Paso = Inicial.Pasos.InstalarServidor;
                                        else if (RadioInicioConexionRemota.Checked)
                                                Paso = Inicial.Pasos.Deteccion;
                                        break;
                                case Inicial.Pasos.Deteccion:
                                        Paso = Inicial.Pasos.SeleccionarAlmacen;
                                        break;
                                case Inicial.Pasos.SeleccionarAlmacen:
                                        if (CheckEsteEquipo.Checked) {
                                                Paso = Inicial.Pasos.PruebaServidor;
                                        } else if (CheckOtroEquipo.Checked) {
                                                Paso = Inicial.Pasos.NombreServidor;
                                        } else if (CheckInstalarAhora.Checked) {
                                                Paso = Inicial.Pasos.InstalarServidor;
                                        } else if (CheckConfigAvanzada.Checked) {
                                                using (Config.ConfigurarBd ConfigBD = new Config.ConfigurarBd()) {
                                                        this.Hide();
                                                        if (ConfigBD.ShowDialog() == DialogResult.Cancel) {
                                                                this.Show();
                                                        } else {
                                                                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                                                this.Close();
                                                        }
                                                }
                                        }
                                        break;
                                case Inicial.Pasos.NombreServidor:
                                        if (EntradaServidor.Text.Length == 0) {
                                                Lui.Forms.MessageBox.Show("Debe ingresar el nombre del equipo", "Error");
                                        } else {
                                                Paso = Inicial.Pasos.PruebaServidor;
                                        }
                                        break;
                                case Inicial.Pasos.PruebaServidor:
                                        Paso = Inicial.Pasos.Final;
                                        break;
                                case Inicial.Pasos.Final:
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        this.Close();
                                        return;
                                case Inicial.Pasos.InstalarServidor:
                                        if (BotonInstalar.Enabled)
                                                BotonInstalar.PerformClick();
                                        else
                                                this.Paso = 0;
                                        break;
                        }
                        this.MostrarPaneles();
                }

                private void BotonAnterior_Click(object sender, EventArgs e)
                {
                        BotonSiguiente.Visible = true;
                        switch (Paso) {
                                case Inicial.Pasos.Deteccion:
                                        Paso = Inicial.Pasos.Inicio;
                                        break;
                                case Inicial.Pasos.NombreServidor:
                                        Paso = Inicial.Pasos.SeleccionarAlmacen;
                                        break;
                                case Inicial.Pasos.PruebaServidor:
                                        if (RadioInicioInstalacionLocal.Checked)
                                                Paso = Inicial.Pasos.Inicio;
                                        else if (CheckEsteEquipo.Checked)
                                                Paso = Inicial.Pasos.SeleccionarAlmacen;
                                        else if (CheckOtroEquipo.Checked)
                                                Paso = Inicial.Pasos.NombreServidor;
                                        break;
                                case Inicial.Pasos.Final:
                                        Paso = Inicial.Pasos.Inicio;
                                        break;
                                case Inicial.Pasos.InstalarServidor:
                                        // Instalar un servidor SQL ahora.
                                        Paso = Inicial.Pasos.Inicio;
                                        break;
                                default:
                                        Paso = Inicial.Pasos.Inicio;
                                        break;
                        }
                        this.MostrarPaneles();
                }

                private void BotonConfiguracionAvanzada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        using (Config.ConfigurarBd ConfigBD = new Config.ConfigurarBd()) {
                                this.Hide();
                                if (ConfigBD.ShowDialog() == DialogResult.Cancel) {
                                        this.Show();
                                } else {
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        this.Close();
                                }
                        }
                }

                private void PanelInstalarAhora_VisibleChanged(object sender, EventArgs e)
                {
                        if (PanelInstalacion.Visible) {
                                BotonInstalar.Enabled = true;
                                BotonInstalar.Visible = true;
                                EtiquetaDescargando.Text = "Haga clic en el botón 'Instalar' para descargar e instalar un servidor SQL en este equipo.";
                                ProgresoDescargando.Visible = false;
                                if (System.IO.File.Exists(Lfx.Environment.Folders.ApplicationFolder + @"..\WebInstall\InstalarMySQL.exe"))
                                        BotonInstalar.PerformClick();
                        } else {
                                if (this.ThreadDescargar != null) {
                                        this.ThreadDescargar.Abort();
                                        this.ThreadDescargar = null;
                                }
                        }
                }

                private void PanelDeteccion_VisibleChanged(object sender, EventArgs e)
                {
                        if (PanelDeteccion.Visible) {
                                EtiquetaBuscando.Text = "Detectando configuración...";
                                this.DetectarConfig();
                        } else {
                                if (this.ThreadBuscar != null) {
                                        this.ThreadBuscar.Abort();
                                        this.ThreadBuscar = null;
                                }
                        }
                }

                private bool Inited = false;
                private void Inicial_Activated(object sender, EventArgs e)
                {
                        if (Inited == false) {
                                Inited = true;
                                this.MostrarPaneles();
                        }
                }

                private void BotonInstalar_Click(object sender, EventArgs e)
                {
                        BotonInstalar.Enabled = false;
                        EtiquetaDescargando.Text = "Descargando...";
                        EtiquetaDescargando.Visible = true;
                        ProgresoDescargando.Visible = true;

                        if (this.ThreadDescargar != null) {
                                this.ThreadDescargar.Abort();
                                this.ThreadDescargar = null;
                        }

                        Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Instalar servidor SQL", "Se está descargando, instalando y configurando un servidor SQL en este equipo");
                        Progreso.Advertise = false;
                        Progreso.Modal = false;
                        Progreso.Begin();

                        System.Threading.ThreadStart Buscar = delegate { this.DescargarEInstalar(Progreso); };
                        this.ThreadDescargar = new System.Threading.Thread(Buscar);
                        this.ThreadDescargar.IsBackground = true;
                        this.ThreadDescargar.Start();

                        while (Progreso != null && Progreso.IsRunning) {
                                System.Threading.Thread.Sleep(100);
                                EtiquetaDescargando.Text = Progreso.Status;
                                System.Windows.Forms.Application.DoEvents();
                                if (this.ThreadDescargar == null)
                                        // Cancelar
                                        return;
                        }

                        EtiquetaDescargando.Text = "Reiniciando el asistente...";
                        //EntradaServidor.Text = "localhost";
                        Paso = Inicial.Pasos.Final;
                        this.MostrarPaneles();
                }

                private void DescargarEInstalar(Lfx.Types.OperationProgress progreso)
                {
                        string InstaladorMySQL = "InstalarMySQL.exe";
                        string CarpetaDescarga;

                        if (System.IO.File.Exists(Lfx.Environment.Folders.ApplicationFolder + @"..\WebInstall\" + InstaladorMySQL)) {
                                CarpetaDescarga = Lfx.Environment.Folders.ApplicationFolder + @"..\WebInstall\";
                        } else {
                                progreso.ChangeStatus("Descargando...");
                                CarpetaDescarga = Lfx.Environment.Folders.TemporaryFolder;
                                Lfx.Environment.Folders.EnsurePathExists(CarpetaDescarga);
                                using (WebClient Cliente = new WebClient()) {
                                        try {
                                                Cliente.DownloadFile("http://www.sistemalazaro.com.ar/aslnlwc/" + InstaladorMySQL, CarpetaDescarga + InstaladorMySQL);
                                        } catch (Exception ex) {
                                                progreso.ChangeStatus("Error al descargar " + ex.Message);
                                        }
                                }
                        }

                        progreso.ChangeStatus("Instalando...");
                        Lfx.Environment.Shell.Execute(CarpetaDescarga + InstaladorMySQL, "/verysilent /sp- /norestart", System.Diagnostics.ProcessWindowStyle.Normal, true);

                        Lfx.Data.DataBaseCache.DefaultCache.ServerName = "localhost";
                        Lfx.Data.DataBaseCache.DefaultCache.UserName = "root";
                        Lfx.Data.DataBaseCache.DefaultCache.Password = "";
                        Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MySql;
                        Lfx.Data.DataBaseCache.DefaultCache.SlowLink = false;
                        Lfx.Data.DataBaseCache.DefaultCache.DataBaseName = "";
                        
                        Lfx.Types.OperationResult Res = this.ProbarServidor();
                        if (Res.Success) {
                                if (Lfx.Workspace.Master.IsPrepared() == false)
                                        Lfx.Workspace.Master.Prepare(progreso);
                        }

                        progreso.End();
                }

                private void BotonDetectar_Click(object sender, EventArgs e)
                {
                        Paso = Pasos.Deteccion;
                        this.MostrarPaneles();
                }

                private void BotonConfiguracionAvanzada2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Paso = Pasos.SeleccionarAlmacen;
                        MostrarPaneles();
                }
        }
}
