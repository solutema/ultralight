#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Lazaro.Principal
{
        public partial class Inicio : Form
        {
                private class MenuItemInfo
                {
                        public MenuItem Item;
                        public string Text;
                        public string Funcion;
                        public string ParentText;

                        public string FullPath
                        {
                                get
                                {
                                        return this.ParentText + @"\" + this.Text;
                                }
                        }

                        public override string ToString()
                        {
                                return this.FullPath;
                        }
                }

                private static System.Collections.Generic.Dictionary<string, MenuItemInfo> MenuItemInfoTable = null;

                public Inicio()
                {
                        InitializeComponent();
                }

                private void FormPrincipal_Load(object sender, EventArgs e)
                {
                        this.CargarMenuPrincipal();

                        //De forma predeterminada, se usa modo maximizado
                        string ModoPredeterminado = "maximizado";
                        if (Lfx.Environment.SystemInformation.RunTime != Lfx.Environment.SystemInformation.RunTimes.DotNet) {
                                //Pero se usa el modo flotante fuera del entorno .NET ya que Mono no tiene buen soporte MDI
                                //y en Linux el modo MDI no es bienvenido
                                ModoPredeterminado = "flotante";
                        }
                              
                        switch (this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Apariencia.ModoPantalla", ModoPredeterminado))
                        {
                                case "normal":
                                        this.Text = "Lázaro - " + Lfx.Types.Strings.ULCase(this.Workspace.CurrentUser.UserName) + " en " + Lfx.Workspace.Master.ToString();
                                        break;
                                case "maximizado":
                                        this.WindowState = FormWindowState.Maximized;
                                        this.Text = "Lázaro - " + Lfx.Types.Strings.ULCase(this.Workspace.CurrentUser.UserName) + " en " + this.Workspace.ToString();
                                        break;
                                case "completo":
                                        this.Text = "";
                                        this.ControlBox = false;
                                        this.WindowState = FormWindowState.Maximized;
                                        break;
                                case "flotante":
					Aplicacion.Flotante = true;
                                        this.BarraTareas.Visible = false;
                                        this.Height = 108;
                                        this.MinimumSize = new Size(128, 108);
                                        this.MaximumSize = new Size(8192, 108);
					if (Lfx.Environment.SystemInformation.Platform == Lfx.Environment.SystemInformation.Platforms.Windows)
                                        	//Sólo Windows permite la combinación de MaximumSize y Maximized
						this.WindowState = FormWindowState.Maximized;
					else
						this.Top = 20;
                                        break;
                        }
                        MostrarAyuda("Bienvenido a Lázaro", "Pulse la tecla <F12> para activar el menú.");
                }

                private void Actualizar()
                {
                        if (this.Workspace.DefaultDataBase != null) {
                                int ActualizarAhora = 0;

                                // Busco actualizaciones cada 20 minutos
                                // 1 de cada 3 veces lo hago desde la web, el resto desde bd
                                string MinSec = System.DateTime.Now.ToString("mm:ss");
                                if (MinSec == "00:00")
                                        ActualizarAhora = 2;
                                else if (MinSec == "20:00" || MinSec == "40:00")
                                        ActualizarAhora = 1;

                                if (ActualizarAhora == 1 && this.Workspace.SlowLink == false) {
                                        // Actualizar desde la BD
                                        Lfx.Updater.Master.UpdateAllFromDbCache();
                                } else if (ActualizarAhora == 2) {
                                        // Actualizar desde la web
                                        System.Threading.Thread TareaActualizador = new System.Threading.Thread(new System.Threading.ThreadStart(Lfx.Updater.Master.UpdateAll));
                                        TareaActualizador.Start();
                                }

                                if (Aplicacion.ReinicioPendiente && Aplicacion.FormularioPrincipal.MdiChildren.Length == 0) {
                                        Aplicacion.ReinicioPendiente = false;
                                        // Si hay actualizaciones pendientes y no se está relizando una tarea
                                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Existe una nueva versión del sistema Lázaro. Debe reiniciar la aplicación para instalar la actualización.", "¿Desea reiniciar ahora?");
                                        Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                                        DialogResult Respuesta = Pregunta.ShowDialog();
                                        if (Respuesta == DialogResult.OK)
                                                Aplicacion.Exec("REBOOT");
                                }
                        }
                }

                private void TimerReloj_Tick(object sender, EventArgs e)
                {
                        TimerReloj.Enabled = false;

                        if (this.Visible)
                        {
                                //Ejecuto tareas del programador
                                Lfx.Services.Task ProximaTarea = null;
                                //En conexiones lentas, 1 vez por minuto
                                //De lo contrario, cada vez que se activa el timer
                                if (this.Workspace.SlowLink == false || (this.Workspace.DefaultScheduler.LastGetTask == System.DateTime.MinValue && (DateTime.Now - this.Workspace.DefaultScheduler.LastGetTask).Minutes >= 1))
                                        ProximaTarea = this.Workspace.DefaultScheduler.GetNextTask("lazaro");

                                if (ProximaTarea != null)
                                {
                                        object Resultado = Aplicacion.Exec(ProximaTarea.Command, ProximaTarea.CreatorComputerName);
                                        if ((Resultado) is Lfx.Types.OperationResult)
                                        {
                                                if (((Lfx.Types.OperationResult)(Resultado)).Success != true)
                                                        Lui.Forms.MessageBox.Show("Hubo un error al ejecutar la tarea " + ProximaTarea.Command, "Programador");
                                        }
                                }
                        }

                        if(Lfx.Environment.SystemInformation.DesignMode == false)
                                Actualizar();

                        TimerReloj.Enabled = true;
                }

                private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
                {
                        switch (e.KeyCode)
                        {
                                case Keys.F10:
                                case Keys.F12:
                                        if (e.Shift == false && e.Alt == false && e.Shift == false)
                                        {
                                                e.Handled = true;
                                                MostrarAyuda("Menú principal", "Utilice las teclas de cursor (flechas) para navegar el menú. Pulse <Intro> (o <Enter>) para ejecutar una opción.");
						System.Windows.Forms.SendKeys.Send("%S");
                                        }
                                        break;
                                case Keys.I:
                                        if (e.Control == true && e.Alt == true && this.Workspace.CurrentUser.Id == 1)
                                        {
                                                e.Handled = true;
                                                System.Windows.Forms.OpenFileDialog DialogoArchivo = new System.Windows.Forms.OpenFileDialog();
                                                DialogoArchivo.DefaultExt = "sql";
                                                DialogoArchivo.Filter = "Archivo SQL|*.sql";
                                                DialogoArchivo.Multiselect = false;
                                                DialogoArchivo.Title = "Inyectar SQL";
                                                if (DialogoArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                                {
                                                        System.IO.Stream Archivo = System.IO.File.OpenRead(DialogoArchivo.FileName);
                                                        System.IO.StreamReader Lector = new System.IO.StreamReader(Archivo, System.Text.Encoding.Default);

                                                        using (Lfx.Data.DataBase ConexionActualizar = this.Workspace.GetDataBase("Inyectar SQL")) {
                                                                ConexionActualizar.BeginTransaction(false);
                                                                string SqlActualizacion = ConexionActualizar.CustomizeSql(Lector.ReadToEnd());
                                                                do {
                                                                        string Comando = Datos.GetNextCommand(ref SqlActualizacion);
                                                                        System.Windows.Forms.Clipboard.SetDataObject(Comando, true);
                                                                        try {
                                                                                ConexionActualizar.Execute(Comando);
                                                                        } catch (Exception ex) {
                                                                                System.Windows.Forms.MessageBox.Show(Comando + System.Environment.NewLine + System.Environment.NewLine + ex.Message, "Lazaro.Datos.Iniciar");
                                                                        }
                                                                }
                                                                while (SqlActualizacion.Length > 0);
                                                                ConexionActualizar.Commit();
                                                                Lector.Dispose();
                                                                Archivo.Dispose();
                                                        }
                                                }
                                        }
                                        break;
                                case Keys.R:
                                        if (e.Control == true && e.Alt == false && e.Shift == false)
                                        {
                                                e.Handled = true;
                                                string Cmd = Lui.Forms.InputBox.ShowInputBox("Comando");
                                                if (Cmd != null && Cmd.Length > 0)
                                                        Aplicacion.Exec(Cmd);
                                        }
                                        break;
                                case Keys.F:
                                        if (e.Control == true && e.Alt == false && e.Shift == false)
                                        {
                                                e.Handled = true;
                                                Aplicacion.Exec("CREAR FB");
                                        }
                                        break;
                                case Keys.T:
                                        if (e.Control == true && e.Alt == false && e.Shift == false)
                                        {
                                                e.Handled = true;
                                                Aplicacion.Exec("CREAR T");
                                        }
                                        break;
                                case Keys.P:
                                        if (e.Control == true && e.Alt == false && e.Shift == false)
                                        {
                                                e.Handled = true;
                                                Aplicacion.Exec("CREAR PS");
                                        }
                                        break;
                                case Keys.L:
                                        if (e.Control == true && e.Alt == false && e.Shift == false)
                                        {
                                                e.Handled = true;
                                                Aplicacion.Exec("CALC");
                                        }
                                        break;
                        }
                }

                private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
                {
                        if (this.Visible) {
                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Está a punto de cerrar completamente la aplicación.", "¿Desea cerrar el sistema Lázaro?");
                                Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                                if (Pregunta.ShowDialog() != DialogResult.OK) {
                                        e.Cancel = true;
                                } else {
                                        this.Workspace.CurrentConfig.WriteGlobalSetting("", "Sistema.Ingreso.UltimoEgreso", Lfx.Types.Formatting.FormatDateTimeSql(System.DateTime.Now), "");
                                        System.Environment.Exit(0);
                                }
                        }
                }

                private void BarraTareas_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
                {
                        int FormId = ((int)e.Button.Tag);
                        bool Encontre = false;
                        foreach (Form Frm in this.MdiChildren) {
                                Lui.Forms.ChildForm Frm2 = Frm as Lui.Forms.ChildForm;
                                if (Frm2 != null && Frm2.Uid == FormId) {
                                        Encontre = true;
                                        Frm.Visible = true;
                                        Frm.Show();
                                        Frm.Activate();
                                        break;
                                }
                        }
                        if (Encontre == false)
                                BarraTareas.Buttons.Remove(e.Button);
                }


                // **************************************************************************************************
                // **************************************************************************************************
                // **************************************************************************************************
                // Ayuda Dinámica
                // **************************************************************************************************
                // **************************************************************************************************
                // **************************************************************************************************

                public void MostrarItem(string tabla, int item)
                {
                        BarraInferior.MostrarItem(tabla, item);
                }

                public void MostrarAyuda(string titulo, string texto)
                {
                        BarraInferior.MostrarAyuda(titulo, texto);
                }


                // **************************************************************************************************
                // **************************************************************************************************
                // **************************************************************************************************
                // Sistema de Menú
                // **************************************************************************************************
                // **************************************************************************************************
                // **************************************************************************************************

                private void CargarMenuComponentes()
                {
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.cif"))
                        {
                                string ComponentName = System.IO.Path.GetFileNameWithoutExtension(DirItem.FullName);
                                string ComponentConfigFileName = Lfx.Environment.Folders.ComponentsFolder + ComponentName + ".cif";
                                System.IO.TextReader ComponentConfigFile = new System.IO.StreamReader(ComponentConfigFileName, true);
                                if (System.IO.File.Exists(ComponentConfigFileName) && (DirItem.Attributes & System.IO.FileAttributes.Hidden) != System.IO.FileAttributes.Hidden)
                                {
                                        System.Xml.XmlDocument ConfigDocument = new System.Xml.XmlDocument();
                                        ConfigDocument.Load(ComponentConfigFile);
                                        System.Xml.XmlNodeList ListaComponentes = ConfigDocument.GetElementsByTagName("Component");
                                        //Abro el/los nodo(s) de componentes
                                        foreach (System.Xml.XmlNode Componente in ListaComponentes)
                                        {
                                                if (Componente.Attributes["Disabled"] == null || Componente.Attributes["Disabled"].Value != "1")
                                                {
                                                        System.Xml.XmlNodeList ListaFunciones = ConfigDocument.GetElementsByTagName("Function");
                                                        //Abro los nodos de funciones
                                                        foreach (System.Xml.XmlNode Funcion in ListaFunciones)
                                                        {
                                                                if (Funcion.Attributes["autorun"] != null && Funcion.Attributes["autorun"].Value == "1")
                                                                        Aplicacion.Exec("RUNCOMPONENT " + ComponentName + " " + Funcion.Attributes["name"].Value);

                                                                System.Xml.XmlNode MenuItem = Funcion.SelectSingleNode("MenuItem");
                                                                if (MenuItem != null)
                                                                {
                                                                        string MenuItemPosition;
                                                                        if (MenuItem.Attributes["position"] == null)
                                                                                MenuItemPosition = "Componentes";
                                                                        else
                                                                                MenuItemPosition = MenuItem.Attributes["position"].Value;

                                                                        //Busco el Parent
                                                                        MenuItem ColgarDe = null;
                                                                        MenuItemInfo ItmInfo;
                                                                        foreach (MenuItemInfo ItemInfo in MenuItemInfoTable.Values)
                                                                        {
                                                                                if (ItemInfo.ParentText + "." + ItemInfo.Text == Lfx.Types.Strings.SimplifyText("Menu." + MenuItemPosition))
                                                                                {
                                                                                        ColgarDe = ItemInfo.Item;
                                                                                        break;
                                                                                }
                                                                        }
                                                                        if (ColgarDe == null)
                                                                        {
                                                                                //Si no hay de donde colgarlo, lo creo
                                                                                ColgarDe = new MenuItem(MenuItemPosition, new System.EventHandler(MnuClick));
                                                                                ItmInfo = new MenuItemInfo();
                                                                                ItmInfo.Item = ColgarDe;
                                                                                ItmInfo.Funcion = "";
                                                                                ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu");
                                                                                ItmInfo.Text = Lfx.Types.Strings.SimplifyText(MenuItemPosition);

                                                                                AgregarAlMenu(this.MainMenu, ColgarDe, ItmInfo);
                                                                        }

                                                                        MenuItem Itm = new MenuItem(MenuItem.Attributes["name"].Value, new System.EventHandler(MnuClick));
                                                                        ItmInfo = new MenuItemInfo();
                                                                        ItmInfo.Item = Itm;
                                                                        ItmInfo.Funcion = "RUNCOMPONENT " + ComponentName + " " + Funcion.Attributes["name"].Value;
                                                                        ItmInfo.ParentText = "Menu." + Lfx.Types.Strings.SimplifyText(MenuItemPosition);
                                                                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(MenuItem.Attributes["name"].Value);
                                                                        AgregarAlMenu(ColgarDe, Itm, ItmInfo);
                                                                }
                                                        }
                                                }
                                        }
                                }
                        }

                }

                // Sub: CargarMenuPrincipal
                // Descripción:
                //    Crea el men principal y algunas opciones fijas (Sistema, Acerca de..., Salir, etc)
                //    Y carga el resto del men desde la BD mediante la función CargarMenu()
                private void CargarMenuPrincipal()
                {
                        // Vacío el menú
                        MenuItemInfoTable = new Dictionary<string, MenuItemInfo>();
                        Aplicacion.FormularioPrincipal.MainMenu.MenuItems.Clear();

                        // Creo el menú del sistema
                        MenuItem ItmSistema = new MenuItem("&Sistema", new System.EventHandler(MnuClick));
                        MenuItemInfo ItmInfo = new MenuItemInfo();
                        ItmInfo.Item = ItmSistema;
                        ItmInfo.Funcion = "";
                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu");
                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(ItmSistema.Text);
                        AgregarAlMenu(Aplicacion.FormularioPrincipal.MainMenu, ItmSistema, ItmInfo);

                        MenuItem ItmTmp = null;

                        // Creo la opción de Acerca de ...
                        ItmTmp = new MenuItem("&Acerca del sistema Lázaro", new System.EventHandler(MnuClick));
                        ItmInfo = new MenuItemInfo();
                        ItmInfo.Item = ItmTmp;
                        ItmInfo.Funcion = "VER";
                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu.&Sistema");
                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(ItmTmp.Text);
                        AgregarAlMenu(ItmSistema, ItmTmp, ItmInfo);

                        // Creo la opción de Calculadora ...
                        ItmTmp = new MenuItem("&Calculadora", new System.EventHandler(MnuClick));
                        ItmInfo = new MenuItemInfo();
                        ItmInfo.Item = ItmTmp;
                        ItmInfo.Funcion = "CALC";
                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu.&Sistema");
                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(ItmTmp.Text);
                        AgregarAlMenu(ItmSistema, ItmTmp, ItmInfo);

                        // Creo la opción de Fiscal
                        ItmTmp = new MenuItem("&Fiscal", new System.EventHandler(MnuClick));
                        ItmInfo = new MenuItemInfo();
                        ItmInfo.Item = ItmTmp;
                        ItmInfo.Funcion = "FISCAL PANEL";
                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu.&Sistema");
                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(ItmTmp.Text);
                        AgregarAlMenu(ItmSistema, ItmTmp, ItmInfo);

                        // Creo la opción de Copia de Respaldo
                        ItmTmp = new MenuItem("&Copia de Respaldo", new System.EventHandler(MnuClick));
                        ItmInfo = new MenuItemInfo();
                        ItmInfo.Item = ItmTmp;
                        ItmInfo.Funcion = "BACKUP MANAGER";
                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu.&Sistema");
                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(ItmTmp.Text);
                        AgregarAlMenu(ItmSistema, ItmTmp, ItmInfo);

                        // Creo la opción de Preferencias
                        ItmTmp = new MenuItem("&Preferencias", new System.EventHandler(MnuClick));
                        ItmInfo = new MenuItemInfo();
                        ItmInfo.Item = ItmTmp;
                        ItmInfo.Funcion = "CONFIG";
                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu.&Sistema");
                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(ItmTmp.Text);
                        AgregarAlMenu(ItmSistema, ItmTmp, ItmInfo);

                        // Creo la opción de Preferencias
                        ItmTmp = new MenuItem("&Usuarios", new System.EventHandler(MnuClick));
                        ItmInfo = new MenuItemInfo();
                        ItmInfo.Item = ItmTmp;
                        ItmInfo.Funcion = "ACCESSMGR";
                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu.&Sistema");
                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(ItmTmp.Text);
                        AgregarAlMenu(ItmSistema, ItmTmp, ItmInfo);

                        // Separador
                        ItmTmp = new MenuItem("-", new System.EventHandler(MnuClick));
                        ItmInfo = new MenuItemInfo();
                        ItmInfo.Item = ItmTmp;
                        ItmInfo.Funcion = "";
                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu.&Sistema");
                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(ItmTmp.Text);
                        AgregarAlMenu(ItmSistema, ItmTmp, ItmInfo);

                        // Salir
                        ItmTmp = new MenuItem("&Salir", new System.EventHandler(MnuClick));
                        ItmInfo = new MenuItemInfo();
                        ItmInfo.Item = ItmTmp;
                        ItmInfo.Funcion = "QUIT";
                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText("Menu.&Sistema");
                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(ItmTmp.Text);
                        AgregarAlMenu(ItmSistema, ItmTmp, ItmInfo);

                        System.Xml.XmlDocument MenuXml = new XmlDocument();
                        MenuXml.Load(Aplicacion.ObtenerRecurso(@"Data.menu.xml"));
                        CargarMenuXml(MenuXml.GetElementsByTagName("Menu").Item(0), Aplicacion.FormularioPrincipal.MainMenu, "Menu");

                        CargarMenuComponentes();
                }

                /// <summary>
                /// Carga un menú desde un documento Xml.
                /// </summary>
                private void CargarMenuXml(XmlNode node, Menu colgarDe, string parentText)
                {
                        if (node.ChildNodes.Count > 0) {
                                foreach (XmlNode opcion in node.ChildNodes) {
                                        MenuItem Itm = new MenuItem(opcion.Attributes["Nombre"].Value, new System.EventHandler(MnuClick));

                                        if (opcion.Attributes["Funcion"].Value == "MDILIST")
                                                Itm.MdiList = true;

                                        MenuItemInfo ItmInfo = new MenuItemInfo();
                                        ItmInfo.Item = Itm;
                                        ItmInfo.Funcion = opcion.Attributes["Funcion"].Value;
                                        ItmInfo.ParentText = Lfx.Types.Strings.SimplifyText(parentText);
                                        ItmInfo.Text = Lfx.Types.Strings.SimplifyText(opcion.Attributes["Nombre"].Value);

                                        AgregarAlMenu(colgarDe, Itm, ItmInfo);

                                        if (opcion.Attributes["Funcion"].Value == "CAJAS" && Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "accounts.read")) {
                                                DataTable Cajas = this.Workspace.DefaultDataBase.Select("SELECT id_caja, nombre FROM cajas WHERE estado>0 ORDER BY nombre");

                                                foreach (System.Data.DataRow Caja in Cajas.Rows) {
                                                        MenuItem ItmH = new MenuItem(Caja["nombre"].ToString(), new System.EventHandler(MnuClick));
                                                        MenuItemInfo ItmInfoH = new MenuItemInfo();
                                                        ItmInfoH.Item = ItmH;
                                                        ItmInfoH.Funcion = "CAJA " + Caja["id_caja"].ToString();
                                                        ItmInfoH.ParentText = ItmInfo.Text;
                                                        ItmInfoH.Text = Lfx.Types.Strings.SimplifyText(System.Convert.ToString(Caja["nombre"]));
                                                        AgregarAlMenu(Itm, ItmH, ItmInfoH);
                                                }
                                        } else if (opcion.Attributes["Funcion"].Value == "LISTADO TICKETS") {
                                                MenuItem ItmH = null;
                                                MenuItemInfo ItmInfoH = new MenuItemInfo();
                                                DataTable Tipos = this.Workspace.DefaultDataBase.Select("SELECT id_tipo_ticket, nombre FROM tickets_tipos ORDER BY nombre");

                                                if (Tipos.Rows.Count > 10) {
                                                        ItmH = new MenuItem("Todos", new System.EventHandler(MnuClick));
                                                        ItmInfoH = new MenuItemInfo();
                                                        ItmInfoH.Item = ItmH;
                                                        ItmInfoH.Funcion = "LISTADO TICKETS";
                                                        ItmInfoH.ParentText = ItmInfo.Text;
                                                        ItmInfoH.Text = Lfx.Types.Strings.SimplifyText("Todos");
                                                        AgregarAlMenu(Itm, ItmH, ItmInfoH);
                                                }

                                                foreach (System.Data.DataRow Tipo in Tipos.Rows) {
                                                        ItmH = new MenuItem(Tipo["nombre"].ToString(), new System.EventHandler(MnuClick));
                                                        ItmInfoH = new MenuItemInfo();
                                                        ItmInfoH.Item = ItmH;
                                                        ItmInfoH.Funcion = "LISTADO TICKETS " + Tipo["id_tipo_ticket"].ToString();
                                                        ItmInfoH.ParentText = ItmInfo.Text;
                                                        ItmInfoH.Text = Lfx.Types.Strings.SimplifyText(Tipo["nombre"].ToString());

                                                        if (Tipos.Rows.Count > 10)
                                                                AgregarAlMenu(Itm, ItmH, ItmInfoH);
                                                        else
                                                                AgregarAlMenu(colgarDe, ItmH, ItmInfoH);
                                                }
                                        } else {
                                                string NuevoParentText = null;

                                                if (parentText.Length > 0)
                                                        NuevoParentText = parentText + "." + opcion.Attributes["Nombre"].Value;
                                                else
                                                        NuevoParentText = opcion.Attributes["Funcion"].Value;

                                                CargarMenuXml(opcion, Itm, NuevoParentText);
                                        }
                                }
                        }
                }

                /// <summary>
                /// Agrega un ítem a un menú y lo hace OwnerDraw.
                /// </summary>
                /// <param name="ColgarDe">Objeto Menu del cual colgar este menú.</param>
                /// <param name="Itm">Objeto Menu que se quiere agregar</param>
                /// <param name="ItmInfo">Estructura con información extendida sobre Itm</param>
                private void AgregarAlMenu(Menu ColgarDe, MenuItem Itm, MenuItemInfo ItmInfo)
                {
                        // Para los tem OwnerDraw, ver las funciones Menu_Select, Menu_MeasureItem y Menu_DrawItem más abajo
                        Itm.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.Menu_MeasureItem);
                        Itm.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Menu_DrawItem);
                        Itm.OwnerDraw = true;
                        Itm.Tag = Itm.GetHashCode();
                        Itm.Select += new System.EventHandler(this.Menu_Select);
                        ColgarDe.MenuItems.Add(Itm);
                        MenuItemInfoTable.Add(Itm.Tag.ToString(), ItmInfo);
                }

                // Las siguientes constantes y funciones (Menu_Select, Menu_MeasureItem, Menu_DrawItem)
                // dibujan los mens de la aplicación (mediante OwnerDraw)
                // Se utilizan exclusivamente para poder dibujar mens con la fuetne Bitstream
                private const string FONT_NAME = "Bitstream Vera Sans";
                private const float FONT_SIZE = 9;
                private const FontStyle FONT_STYLE = FontStyle.Regular;

                private void Menu_Select(object sender, System.EventArgs e)
                {
                        //MenuItem MiItem = ((MenuItem)(sender));
                }

                private void Menu_MeasureItem(System.Object sender, System.Windows.Forms.MeasureItemEventArgs e)
                {
                        MenuItem MiItem = ((MenuItem)(sender));

                        if (MiItem.Text == "-")
                        {
                                e.ItemHeight = 4;
                                e.ItemWidth = 24;
                        }
                        else
                        {
                                Font ItemFont = new Font(FONT_NAME, FONT_SIZE, FONT_STYLE);
                                SizeF ItemSize = e.Graphics.MeasureString(MiItem.Text.Replace("&", ""), ItemFont);

                                if (MiItem.Parent == this.MainMenu)
                                {
                                        e.ItemHeight = System.Convert.ToInt32(ItemSize.Height + 2);
                                        e.ItemWidth = System.Convert.ToInt32(ItemSize.Width);
                                }
                                else
                                {
                                        e.ItemHeight = System.Convert.ToInt32(ItemSize.Height + 8);
                                        e.ItemWidth = System.Convert.ToInt32(ItemSize.Width + 16);

                                        if (e.ItemWidth < 64)
                                                e.ItemWidth = 64;
                                }
                        }
                }

                private void Menu_DrawItem(System.Object sender, System.Windows.Forms.DrawItemEventArgs e)
                {
                        Font ItemFont = new Font(FONT_NAME, FONT_SIZE, FONT_STYLE);
                        MenuItem MiItem = ((MenuItem)(sender));
                        float MargenX = 12;
                        float MargenY = 4;

                        if (MiItem.Parent == Aplicacion.FormularioPrincipal.MainMenu)
                        {
                                MargenX = 6;
                                MargenY = 2;
                        }

                        StringFormat FormatoTexto = new StringFormat();
                        FormatoTexto.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
                        SolidBrush Fondo = new SolidBrush(System.Drawing.SystemColors.Menu);
                        e.Graphics.FillRectangle(Fondo, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                        // e.Graphics.FillRectangle(New SolidBrush(PaletaCambiarBrillo(SystemColors.Menu, -40)), e.Bounds.X + 1, e.Bounds.Y, 20, e.Bounds.Height - 1)

                        if (MiItem.Text == "-")
                        {
                                e.Graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.SystemColors.ControlDark), e.Bounds.X + 3, e.Bounds.Y + 1, e.Bounds.Width - 6, e.Bounds.Height - 3);
                        }
                        else if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        {
                                SolidBrush Resalte = new SolidBrush(System.Drawing.SystemColors.Highlight);
                                Pen Recuadro = new Pen(System.Drawing.SystemColors.Highlight);
                                SolidBrush Texto = new SolidBrush(System.Drawing.SystemColors.HighlightText);
                                // e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.None
                                e.Graphics.FillRectangle(Resalte, e.Bounds.X + 1, e.Bounds.Y, e.Bounds.Width - 2, e.Bounds.Height - 1);
                                // e.Graphics.FillRectangle(New SolidBrush(PaletaCambiarBrillo(SystemColors.Highlight, 40)), e.Bounds.X + 1, e.Bounds.Y, 20, e.Bounds.Height - 1)
                                e.Graphics.DrawRectangle(Recuadro, e.Bounds.X + 1, e.Bounds.Y, e.Bounds.Width - 2, e.Bounds.Height - 1);
                                e.Graphics.DrawString(MiItem.Text, ItemFont, Texto, e.Bounds.X + MargenX, e.Bounds.Y + MargenY,
                                    FormatoTexto);
                        }
                        else if ((e.State & DrawItemState.Disabled) == DrawItemState.Disabled)
                        {
                                SolidBrush Texto = new SolidBrush(System.Drawing.SystemColors.GrayText);
                                // e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.None
                                e.Graphics.DrawString(MiItem.Text, ItemFont, Texto, e.Bounds.X + MargenX, e.Bounds.Y + MargenY,
                                    FormatoTexto);
                        }
                        else
                        {
                                SolidBrush Texto = new SolidBrush(System.Drawing.SystemColors.MenuText);
                                // e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.None
                                e.Graphics.DrawString(MiItem.Text, ItemFont, Texto, e.Bounds.X + MargenX, e.Bounds.Y + MargenY,
                                    FormatoTexto);
                        }
                }

                /// <summary>
                /// Maneja los eventos Click de los menús
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void MnuClick(object sender, System.EventArgs e)
                {
                        MenuItem ItemClicked = (MenuItem)sender;
                        MenuItemInfo ItmInfo = MenuItemInfoTable[ItemClicked.Tag.ToString()];

                        int Hits = this.Workspace.CurrentConfig.ReadLocalSettingInt("MenuStats", ItmInfo.FullPath, 0);
                        this.Workspace.CurrentConfig.WriteLocalSetting("MenuStats", ItmInfo.FullPath, Hits + 1);

                        Aplicacion.Exec(ItmInfo.Funcion);
                }

                public Lfx.Workspace Workspace
                {
                        get
                        {
                                return Lfx.Workspace.Master;
                        }
                }
        }
}