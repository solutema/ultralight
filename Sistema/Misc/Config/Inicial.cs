#region License
// Copyright 2004-2011 Ernesto N. Carrea
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

namespace Lazaro.WinMain.Misc.Config
{
        public partial class Inicial : Lui.Forms.Form
        {
                private int Paso = 0;
                private readonly int Pasos = 4;
                private string ServidorDetectado = null;
                private System.Threading.Thread ThreadBuscar = null, ThreadDescargar = null;

                public Inicial()
                {
                        InitializeComponent();

                        LowerPanel.BackColor = Lfx.Config.Display.CurrentTemplate.FooterBackground;
                }


                private void BotonSalir_Click(object sender, EventArgs e)
                {
                        if (this.ThreadBuscar != null) {
                                this.ThreadBuscar.Abort();
                                this.ThreadBuscar = null;
                        }

                        if (this.ThreadDescargar != null) {
                                this.ThreadDescargar.Abort();
                                this.ThreadDescargar = null;
                        }

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
                                        if (System.IO.File.Exists(@"C:\mysql\bin\mysqld.exe")) {
                                                EtiquetaBuscando.Text = "Lázaro detectó un servidor SQL en este equipo. Haga clic en el botón 'Siguiente' para revisar la configuración detectada.";
                                                EtiquetaBuscarEspere.Visible = false;
                                                ProgresoBuscar.Visible = false;
                                                EntradaServidor.Text = "localhost";
                                                CheckEsteEquipo.Checked = true;
                                        } else {
                                                Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Buscando un servidor", "Por favor aguarde mientras Lázaro busca un servidor en la red para utilizar como almacén de datos.");
                                                ProgresoBuscar.Visible = true;
                                                Progreso.Blocking = false;
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
                                        }
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
                        PanelBuscando.Visible = Paso == 0;
                        PanelBienvenido.Visible = Paso == 1;
                        PanelAlmacenDeDatos.Visible = Paso == 2;
                        PanelPruebaServidor.Visible = Paso == 3;
                        PanelInstalarAhora.Visible = Paso == 99;
                        PanelFinal.Visible = Paso == Pasos;

                        if (PanelBienvenido.Visible)
                                EtiquetaEncab.Text = PanelBienvenido.Tag.ToString();
                        else if (PanelAlmacenDeDatos.Visible)
                                EtiquetaEncab.Text = PanelAlmacenDeDatos.Tag.ToString();
                        else if (PanelPruebaServidor.Visible)
                                EtiquetaEncab.Text = PanelPruebaServidor.Tag.ToString();
                        else if (PanelFinal.Visible)
                                EtiquetaEncab.Text = PanelFinal.Tag.ToString();
                        else if (PanelBuscando.Visible)
                                EtiquetaEncab.Text = PanelBuscando.Tag.ToString();
                        else if (PanelInstalarAhora.Visible)
                                EtiquetaEncab.Text = PanelInstalarAhora.Tag.ToString();

                        if (Paso == Pasos)
                                BotonSiguiente.Text = "Finalizar";
                        else
                                BotonSiguiente.Text = "Siguiente";

                        BotonAnterior.Visible = Paso > 0;
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
                                                        Lfx.Workspace.Master.MasterConnection.ExecuteSql("CREATE DATABASE lazaro");
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

                                        EtiquetaPruebaResultado.Text = "Se realizó una prueba de la configuración del almacén de datos. Todo parece estar en orden. Haga clic en 'Siguiente' para continuar.";
                                        if (CheckEsteEquipo.Checked)
                                                EtiquetaPruebaError.Text = "Si va a instalar Lázaro en otros equipos de la red, puede utilizar este equipo como servidor. El nombre de este equipo es " + System.Environment.MachineName;
                                        else
                                                EtiquetaPruebaError.Text = "";
                                        BotonSiguiente.Visible = true;
                                } catch (Exception ex) {
                                        EtiquetaPruebaResultado.Text = "No se pudo conectar al almacén de datos proporcionado. Haga clic en el botón 'Anterior' para ir a la pantalla anterior y volver a intentarlo.";
                                        EtiquetaPruebaError.Text = "El mensaje de error es: " + ex.Message;
                                        BotonSiguiente.Visible = false;
                                }
                        }
                }

                private void BotonSiguiente_Click(object sender, EventArgs e)
                {
                        switch (Paso) {
                                case 0:
                                        Paso = 1;
                                        break;
                                case 1:
                                        if (CheckEsteEquipo.Checked) {
                                                Paso = 3;
                                        } else if (CheckOtroEquipo.Checked) {
                                                Paso = 2;
                                        } else if (CheckInstalarAhora.Checked) {
                                                Paso = 99;
                                        } else if (CheckConfigAvanzada.Checked) {
                                                using (Misc.Config.ConfigurarBd ConfigBD = new Misc.Config.ConfigurarBd()) {
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
                                case 2:
                                        if (EntradaServidor.Text.Length == 0) {
                                                Lui.Forms.MessageBox.Show("Debe ingresar el nombre del equipo", "Error");
                                        } else {
                                                Paso = 3;
                                        }
                                        break;
                                case 3:
                                        Paso = 4;
                                        break;
                                case 4:
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        this.Close();
                                        return;
                                case 99:
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
                                case  1:
                                        Paso = 0;
                                        break;
                                case 2:
                                        Paso = 1;
                                        break;
                                case 3:
                                        if (CheckEsteEquipo.Checked)
                                                Paso = 1;
                                        else if (CheckOtroEquipo.Checked)
                                                Paso = 2;
                                        break;
                                case 4:
                                        Paso = 3;
                                        break;
                                case 99:
                                        // Instalar un servidor SQL ahora.
                                        Paso = 0;
                                        break;
                        }
                        this.MostrarPaneles();
                }

                private void BotonGuiaInstalacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Help.ShowHelp(this, "http://www.sistemalazaro.com.ar/?q=node/19");
                }

                private void PanelInstalarAhora_VisibleChanged(object sender, EventArgs e)
                {
                        if (PanelInstalarAhora.Visible) {
                                BotonInstalar.Visible = true;
                                EtiquetaDescargando.Visible = false;
                                ProgresoDescargando.Visible = false;
                        } else {
                                if (this.ThreadDescargar != null) {
                                        this.ThreadDescargar.Abort();
                                        this.ThreadDescargar = null;
                                }
                        }
                }

                private void PanelBuscando_VisibleChanged(object sender, EventArgs e)
                {
                        if (PanelBuscando.Visible) {
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

                        Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Instalar servidor SQL", "Se está descargando e instalando un servidor SQL en este equipo");
                        Progreso.Advertise = false;
                        Progreso.Blocking = false;
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
                        EntradaServidor.Text = "localhost";
                        Paso = 3;
                        this.MostrarPaneles();
                }

                private void DescargarEInstalar(Lfx.Types.OperationProgress progreso)
                {
                        progreso.ChangeStatus("Descargando...");

                        string Instalador = "InstalarMySQL.exe";
                        using (WebClient Cliente = new WebClient()) {
                                Cliente.DownloadFile("http://www.sistemalazaro.com.ar/aslnlwc/" + Instalador, Lfx.Environment.Folders.TemporaryFolder + Instalador);
                        }
                        
                        progreso.ChangeStatus("Instalando...");
                        Lfx.Environment.Shell.Execute(Lfx.Environment.Folders.TemporaryFolder + Instalador, "/silent", System.Diagnostics.ProcessWindowStyle.Normal, true);

                        progreso.End();
                }
        }
}
