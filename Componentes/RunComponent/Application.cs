using System;
using System.Runtime.InteropServices;

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
                        //Console.WriteLine("    Copyright © 2004-2009 Carrea Ernesto, Martínez Miguel");
			//Console.WriteLine("");

			string ComponentName = null, FunctionName = null;
			if(args.Length == 2)
			{
				ComponentName = args[0];
				FunctionName = args[1];
			}
			else if(args.Length == 1)
			{
				ComponentName = args[0];
				FunctionName = args[0];
			}
			else if(args.Length == 0)
			{
				ComponentName = System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetExecutingAssembly().Location);
				FunctionName = ComponentName;
			}

			if(ComponentName != null && FunctionName != null) 
			{
				//Console.WriteLine("Ejecutando " + ComponentName + "." + FunctionName);
				Lws.Components.Component Componente = null;
				try
				{
					Componente = Lws.Components.ComponentManager.LoadComponent(ComponentName, FunctionName);
				}
				catch(Exception ex)
				{
					System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
				}
				if(Componente != null)
				{
					Componente.Workspace = new Lws.Workspace("default");
					Componente.ExecutableName = System.Reflection.Assembly.GetExecutingAssembly().Location;
					Componente.CommandLineArgs = Environment.GetCommandLineArgs();
					Componente.Create(true);
				}
				else
				{
					System.Windows.Forms.MessageBox.Show("No se puede ejecutar " + ComponentName + "." + FunctionName, "Error");
				}
			}
			else
			{
				Console.WriteLine("Uso:");
				Console.WriteLine("    RunComponent [NombreComponente] [NombreFuncion]");
				Console.WriteLine("        Si no se especifica NombreFuncion, se asume igual que NombreComponente.");
				Console.WriteLine("        Si no se especifica NombreComponente, se asume el nombre de este ejecutable.");
			}
		}
	}
}
