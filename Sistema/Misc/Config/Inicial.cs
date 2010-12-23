using System;
using System.Windows.Forms;

namespace Lazaro.Misc.Config
{
        public partial class Inicial : Form
        {
                private int Paso = 1;
                private readonly int Pasos = 4;

                public Inicial()
                {
                        InitializeComponent();

                        LowerPanel.BackColor = Lfx.Config.Display.CurrentTemplate.FooterBackground;
                        EtiquetaTitulo.BackColor = Lfx.Config.Display.CurrentTemplate.HeaderBackground;
                        EtiquetaTitulo.ForeColor = Lfx.Config.Display.CurrentTemplate.HeaderText;

                        if (Lfx.Environment.SystemInformation.Platform == Lfx.Environment.SystemInformation.Platforms.Windows
                                && System.IO.File.Exists(@"C:\mysql\bin\mysqld.exe")) {
                                CheckEsteEquipo.Checked = true;
                        } else {
                                CheckOtroEquipo.Checked = true;
                        }

                        this.MostrarPaneles();
                }

                private void BotonSalir_Click(object sender, EventArgs e)
                {
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.Close();
                }

                private void MostrarPaneles()
                {
                        PanelBienvenido.Visible = Paso == 1;
                        PanelAlmacenDeDatos.Visible = Paso == 2;
                        PanelPruebaServidor.Visible = Paso == 3;
                        PanelFinal.Visible = Paso == Pasos;

                        if (PanelBienvenido.Visible)
                                EtiquetaTitulo.Text = PanelBienvenido.Tag.ToString();
                        if (PanelAlmacenDeDatos.Visible)
                                EtiquetaTitulo.Text = PanelAlmacenDeDatos.Tag.ToString();
                        if (PanelPruebaServidor.Visible)
                                EtiquetaTitulo.Text = PanelPruebaServidor.Tag.ToString();
                        if (PanelFinal.Visible)
                                EtiquetaTitulo.Text = PanelFinal.Tag.ToString();

                        if (Paso == Pasos)
                                BotonSiguiente.Text = "Finalizar";
                        else
                                BotonSiguiente.Text = "Siguiente";

                        BotonAnterior.Visible = Paso > 1;
                }

                private void PanelPruebaServidor_VisibleChanged(object sender, EventArgs e)
                {
                        if (PanelPruebaServidor.Visible) {
                                // Probar la conexión al servidor

                                if (CheckEsteEquipo.Checked)
                                        Lfx.Data.DataBaseCache.DefaultCache.ServerName = "localhost";
                                else
                                        Lfx.Data.DataBaseCache.DefaultCache.ServerName = EntradaServidor.Text;
                                
                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MySql;

                                Lfx.Data.DataBaseCache.DefaultCache.SlowLink = false;
                                Lfx.Data.DataBaseCache.DefaultCache.DataBaseName = "lazaro";
                                Lfx.Data.DataBaseCache.DefaultCache.UserName = "lazaro";
                                Lfx.Data.DataBaseCache.DefaultCache.Password = "";

                                try {
                                        EtiquetaPruebaResultado.Text = "Probando la conexión...";
                                        EtiquetaPruebaError.Text = "";
                                        System.Windows.Forms.Application.DoEvents();

                                        Lfx.Workspace.Master.MasterConnection.Open();

                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DataSource", Lfx.Data.DataBaseCache.DefaultCache.ServerName);
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "ConnectionType", "mysql");
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DatabaseName", Lfx.Data.DataBaseCache.DefaultCache.DataBaseName);
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "User", Lfx.Data.DataBaseCache.DefaultCache.UserName);
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "Password", Lfx.Data.DataBaseCache.DefaultCache.Password);
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "SlowLink", Lfx.Data.DataBaseCache.DefaultCache.SlowLink ? "1" : "0");
                                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Company", "Branch", 1);

                                        EtiquetaPruebaResultado.Text = "Se realizó una prueba de la configuración del almacén de datos. Todo parece estar en orden. Haga clic en 'Siguiente' para continuar.";
                                        if (CheckEsteEquipo.Checked)
                                                EtiquetaPruebaError.Text = "Si va a instalar Lázaro en otros equipos de la red, puede utilizar este equipo como servidor. El nombre de este equipo es " + System.Environment.MachineName;
                                        else
                                                EtiquetaPruebaError.Text = "";
                                        BotonSiguiente.Visible = true;
                                } catch (Exception ex) {
                                        EtiquetaPruebaResultado.Text = "No se pudo conectar al almacén de datos proporcionado. Haga clic en el botón 'Anterior' para ir a la pantalla anterior y volver a intentarlo.";
                                        EtiquetaPruebaError.Text = "El mensaje de error es: " + ex.Message;
                                        BotonSiguiente.Visible = true;
                                }
                        }
                }

                private void BotonSiguiente_Click(object sender, EventArgs e)
                {
                        switch (Paso) {
                                case 1:
                                        if (CheckEsteEquipo.Checked) {
                                                Paso = 3;
                                        } else if (CheckOtroEquipo.Checked) {
                                                Paso = 2;
                                        } else if (CheckInstalarAhora.Checked) {
                                                using (Misc.Config.ConfigurarBd ConfigBD = new Misc.Config.ConfigurarBd()) {
                                                        this.Hide();
                                                        if (ConfigBD.ShowDialog() == DialogResult.OK) {
                                                                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                                                this.Close();
                                                        } else {
                                                                this.Show();
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
                        }
                        this.MostrarPaneles();
                }

                private void BotonAnterior_Click(object sender, EventArgs e)
                {
                        switch (Paso) {
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
                        }
                        this.MostrarPaneles();
                }
        }
}
