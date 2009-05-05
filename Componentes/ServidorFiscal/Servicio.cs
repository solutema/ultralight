/*using System;
using System.ServiceProcess;
using System.Text;

namespace ServidorFiscal
{
        public class ServicioFiscal : ServiceBase
        {
                public ServicioFiscal()
                {
                        this.ServiceName = "Lázaro - Servidor Fiscal";
                        this.EventLog.Log = "Application";

                        this.CanHandlePowerEvent = false;
                        this.CanHandleSessionChangeEvent = false;
                        this.CanPauseAndContinue = false;
                        this.CanShutdown = true;
                        this.CanStop = true;
                }

                static void Main()
                {
                        ServiceBase.Run(new WindowsService());
                }

                protected override void Dispose(bool disposing)
                {
                        base.Dispose(disposing);
                }

                protected override void OnStart(string[] args)
                {
                        base.OnStart(args);
                }

                protected override void OnStop()
                {
                        base.OnStop();
                }

                protected override void OnShutdown()
                {
                        base.OnShutdown();
                }

        }
}*/