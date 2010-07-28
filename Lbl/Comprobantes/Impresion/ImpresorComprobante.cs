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

using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Lbl.Comprobantes.Impresion
{
        public class ImpresorComprobante : System.Drawing.Printing.PrintDocument
	{
		public Plantilla Plantilla = null;
		public Comprobante Comprobante = null;
		
		public ImpresorComprobante(Comprobante comprobante)
                        : base()
		{
			this.Comprobante = comprobante;
		}
		
		
		protected void ObtenerPlantilla()
		{
                        this.Plantilla = new Plantilla(this.DataBase, this.Comprobante.Tipo.Nomenclatura);
		}

                public Lfx.Data.DataBase DataBase
                {
                        get
                        {
                                if (this.Comprobante == null)
                                        return null;
                                else
                                        return this.Comprobante.DataBase;
                        }
                }
		
		public Lfx.Workspace Workspace
		{
			get
			{
				if (this.Comprobante == null || this.Comprobante.Workspace == null)
					return null;
				else
                                        return this.Comprobante.Workspace;
			}
		}

                protected override void OnBeginPrint(PrintEventArgs e)
                {
			base.OnBeginPrint(e);
                        this.DocumentName = Comprobante.ToString();
                }

                public virtual Lfx.Types.OperationResult Imprimir(string nombreImpresora)
                {
			if (this.Comprobante != null)
				this.Comprobante.Cargar();

			this.ObtenerPlantilla();
                        if (this.Plantilla == null)
                                return new Lfx.Types.FailureOperationResult("No se ha encontrado una plantilla adecuada (Lbl.Comprobantes.Impresion.ImpresorComprobante).");
                        
			//Elimina la ventana de "Imprimiendo página 1 de x"
			this.PrintController = new System.Drawing.Printing.StandardPrintController();
			try {
				if (nombreImpresora != null && nombreImpresora.Length > 0)
                                        this.PrinterSettings.PrinterName = nombreImpresora;
                                this.DefaultPageSettings.Landscape = Plantilla.Landscape;
				this.PrinterSettings.Copies = ((short)this.Plantilla.Copias);
                                this.Print();
                                return new Lfx.Types.SuccessOperationResult();
                        } catch (System.Exception Ex) {
                                return new Lfx.Types.FailureOperationResult(Ex.ToString());
                        }
                }

                protected override void OnPrintPage(PrintPageEventArgs e)
                {
			e.PageSettings.Landscape = Plantilla.Landscape;
                        e.Graphics.PageUnit = GraphicsUnit.Document;

                        this.ImprimirCampos(e);

                        base.OnPrintPage(e);
                }

                protected virtual void ImprimirCampos(PrintPageEventArgs e)
                {
                        ImprimirCampos(e, e.PageBounds, true);
                }

                protected virtual void ImprimirCampos(PrintPageEventArgs e, Rectangle recorte, bool imprimirEspejos)
                {
                        e.Graphics.TranslateTransform(recorte.X, recorte.Y);
                        foreach (Campo Cam in Plantilla.Campos) {
                                if (Cam.Valor.ToUpperInvariant() != "{ESPEJO}")
                                        this.ImprimirCampo(e, Cam);
                        }
                        foreach (Campo Cam in Plantilla.Campos) {
                                if (Cam.Valor.ToUpperInvariant() == "{ESPEJO}" && imprimirEspejos)
                                        this.ImprimirCampos(e, Cam.Rectangle, false);
                        }
                }

                protected virtual void ImprimirCampo(PrintPageEventArgs e, Campo Cam)
                {
                        if (Cam.AnchoBorde > 0)
                                e.Graphics.DrawRectangle(new Pen(Cam.ColorBorde, Cam.AnchoBorde), Cam.Rectangle);

                        if (Cam.ColorFondo != Color.Transparent)
                                e.Graphics.FillRectangle(new SolidBrush(Cam.ColorFondo), Cam.Rectangle);

                        //Imprimir texto
                        string Texto = Cam.Valor;
                        //Remplzado variables tipo {nombrecampo} por el valor del campo
                        Regex Rx = new Regex(@"\{[_\.0-9a-zA-Z]+\}", RegexOptions.ExplicitCapture | RegexOptions.Singleline);
                        MatchCollection NombresCampo = Rx.Matches(Texto);
                        foreach (Match Mt in NombresCampo) {
                                Texto = Texto.Replace(Mt.Value, ObtenerValorCampo(Mt.Value.Substring(1, Mt.Value.Length - 2).ToLowerInvariant()));
                        }

                        StringFormat Fmt = new StringFormat(); //StringFormatFlags.NoClip);
                        if (Cam.Wrap == false)
                                Fmt.FormatFlags |= StringFormatFlags.NoWrap;
                        Fmt.Alignment = Cam.Alignment;
                        Fmt.LineAlignment = Cam.LineAlignment;
                        Fmt.Trimming = StringTrimming.EllipsisCharacter;
                        e.Graphics.DrawString(Texto, Cam.Font == null ? Plantilla.Font : Cam.Font, new SolidBrush(Cam.ColorTexto), Cam.Rectangle, Fmt);
                }

                public virtual string ObtenerValorCampo(string nombreCampo)
                {
			if (Comprobante.Registro.Fields.Contains(nombreCampo)) {
				object Res = Comprobante.Registro[nombreCampo];
                                if (Res == null)
                                        return "";
				string ResType = Res.GetType().ToString();
				switch(ResType)
				{
					case "System.DateTime":
						return Lfx.Types.Formatting.FormatDate(Res);
					case "System.Decimal":
					case "System.Double":
						return Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Res), 2);
					default:
						if (Res == null)
							return "";
						else
							return Res.ToString();
				}
			}
			else {
                                switch (nombreCampo.ToUpperInvariant()) {
                                        case "CLIENTE":
                                                return this.Comprobante.Cliente.ToString();
                                        case "DOMICILIO":
                                        case "CLIENTE.DOMICILIO":
                                                if(this.Comprobante.Cliente.Domicilio != null && this.Comprobante.Cliente.Domicilio.Length > 0)
                                                        return this.Comprobante.Cliente.Domicilio;
                                                else
                                                        return this.Comprobante.Cliente.DomicilioLaboral;
                                        case "CLIENTE.DOCUMENTO":
                                                if (this.Comprobante.Cliente.Cuit != null && this.Comprobante.Cliente.Cuit.Length > 0)
                                                        return this.Comprobante.Cliente.Cuit;
                                                else
                                                        return this.Comprobante.Cliente.NumeroDocumento;
                                        case "CUIT":
                                                return this.Comprobante.Cliente.Cuit;
                                        case "IVA":
                                                return this.Comprobante.Cliente.SituacionTributaria.ToString();
                                        case "CLIENTE.ID":
                                                return this.Comprobante.Cliente.Id.ToString();

                                        case "EMPRESA":
                                                return this.Workspace.CurrentConfig.Empresa.Nombre;
                                        case "EMPRESA.DOMICILIO":
                                                return this.Workspace.CurrentConfig.Empresa.Domicilio;
                                        case "EMPRESA.TELEFONO":
                                                return this.Workspace.CurrentConfig.Empresa.Telefono;
                                        case "EMPRESA.CIUDAD":
                                                return this.Workspace.CurrentConfig.Empresa.NombreCiudad;
					
					case "VENDEDOR":
                                                return this.Comprobante.Vendedor.ToString();
                                        default:
						return "{" + nombreCampo + "}";
				}
			}
                }
	}
}
