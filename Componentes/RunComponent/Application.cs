using System;
using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RunComponent
{
	/// <summary>
	/// Permite ejecutar un componente Lfx desde la línea de comandos.
	/// </summary>
	public class Application
	{
		//[STAThread]
                public static void Main(string[] args)
                {

                        //Console.WriteLine("RunComponent");
                        //Console.WriteLine("    Ejecuta un componente Lfx fuera del entorno del sistema Lázaro.");
                        //Console.WriteLine("    Copyright 2004-2009 South Bridge S.R.L.");
                        //Console.WriteLine("");
                        System.Windows.Forms.Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ThreadExceptionHandler);
                        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);
                        System.Windows.Forms.Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                        string ComponentName = null, FunctionName = null;
                        if (args.Length == 2) {
                                ComponentName = args[0];
                                FunctionName = args[1];
                        } else if (args.Length == 1) {
                                ComponentName = args[0];
                                FunctionName = args[0];
                        } else if (args.Length == 0) {
                                ComponentName = System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetExecutingAssembly().Location);
                                FunctionName = ComponentName;
                        }

                        if (ComponentName != null && FunctionName != null) {
                                //Console.WriteLine("Ejecutando " + ComponentName + "." + FunctionName);
                                Lws.Components.Component Componente = null;
                                try {
                                        Componente = Lws.Components.ComponentManager.LoadComponent(ComponentName, FunctionName);
                                } catch (Exception ex) {
                                        System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
                                }
                                if (Componente != null) {
                                        Componente.Workspace = new Lws.Workspace("default");
                                        Componente.ExecutableName = System.Reflection.Assembly.GetExecutingAssembly().Location;
                                        Componente.CommandLineArgs = Environment.GetCommandLineArgs();
                                        Componente.Create(true);
                                } else {
                                        System.Windows.Forms.MessageBox.Show("No se puede ejecutar " + ComponentName + "." + FunctionName, "Error");
                                }
                        } else {
                                Console.WriteLine("Uso:");
                                Console.WriteLine("    RunComponent [NombreComponente] [NombreFuncion]");
                                Console.WriteLine("        Si no se especifica NombreFuncion, se asume igual que NombreComponente.");
                                Console.WriteLine("        Si no se especifica NombreComponente, se asume el nombre de este ejecutable.");
                        }
                }

                public static void ThreadExceptionHandler(object sender, System.Threading.ThreadExceptionEventArgs e)
                {
                        ExceptionHandler(e.Exception);
                }

                private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs args)
                {
                        ExceptionHandler(args.ExceptionObject as Exception);
                }

                public static void ExceptionHandler(Exception ex)
                {
                        System.Text.StringBuilder Texto = new System.Text.StringBuilder();
                        Texto.AppendLine("Lugar   : " + ex.Source);
                        try {
                                System.Diagnostics.StackTrace Traza = new System.Diagnostics.StackTrace(ex, true);
                                Texto.AppendLine("Línea   : " + Traza.GetFrame(0).GetFileLineNumber());
                                Texto.AppendLine("Columna : " + Traza.GetFrame(0).GetFileColumnNumber());
                        }
                        catch {
                                //Nada
                        }
                        Texto.AppendLine("Equipo  : " + System.Environment.MachineName.ToUpperInvariant());
                        Texto.AppendLine("Plataf. : " + Lfx.Environment.SystemInformation.Platform);
                        Texto.AppendLine("RunTime : " + Lfx.Environment.SystemInformation.RunTime);
                        Texto.AppendLine("Excepción no controlada: " + ex.ToString());
                        Texto.AppendLine("");

                        Texto.AppendLine("Lazaro versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").ProductVersion + " del " + new System.IO.FileInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                Texto.AppendLine(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
                        }

                        Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                Texto.AppendLine(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
                        }

                        Texto.AppendLine("Traza:");
                        Texto.AppendLine(ex.StackTrace);

                        MailMessage Mensaje = new MailMessage();
                        Mensaje.To.Add(new MailAddress("error@sistemalazaro.com.ar"));
                        Mensaje.From = new MailAddress(Lws.Workspace.Master.CurrentUser.Id.ToString() + "@" + System.Environment.MachineName.ToUpperInvariant(), Lws.Workspace.Master.CurrentUser.CompleteName + " en " + Lws.Workspace.Master.CurrentConfig.Company.Name);
                        try {
                                //No sé por qué, pero una vez dió un error al poner el asunto
                                Mensaje.Subject = ex.Message;
                        }
                        catch {
                                Mensaje.Subject = "Excepción no controlada";
                                Texto.Insert(0, ex.Message + System.Environment.NewLine);
                        }

                        Mensaje.Body = Texto.ToString();

                        SmtpClient Cliente = new SmtpClient("mail.sistemalazaro.com.ar");
                        try {
                                Cliente.Send(Mensaje);
                        }
                        catch {
                                // Nada
                        }

                }
	}
}
