#region License
// Copyright 2004-2010 Ernesto N. Carrea
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
using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Lazaro.Impresion
{
        public class ImpresorElemento : Impresor
        {
                public Lbl.ElementoDeDatos Elemento = null;
                public Lbl.Impresion.Plantilla Plantilla = null;
                private Lbl.Comprobantes.Tipo Tipo = null;

                public ImpresorElemento(Lbl.ElementoDeDatos elemento)
                        : base()
		{
                        this.Elemento = elemento;
                        m_DataBase = elemento.Connection;
		}


                protected virtual Lbl.Impresion.Plantilla ObtenerPlantilla()
                {
                        return new Lbl.Impresion.Plantilla(this.Connection, this.Elemento.GetType());
                }

                public virtual Lbl.Comprobantes.Tipo ObtenerTipo()
                {
                        int TipoId = this.Connection.FieldInt("SELECT id_tipo FROM documentos_tipos WHERE letra='" + this.Elemento.GetType().ToString() + "'");

                        if (TipoId > 0)
                                return new Lbl.Comprobantes.Tipo(this.Connection, TipoId);
                        else
                                return null;
                }

                protected virtual Lbl.Impresion.Impresora ObtenerImpresora()
                {
                        if (this.Tipo == null)
                                this.Tipo = this.ObtenerTipo();

                        if (this.Tipo == null)
                                return null;

                        // Intento obtener una impresora para esta susursal, para esta estación
                        foreach (Lbl.Impresion.TipoImpresora Impr in this.Tipo.Impresoras) {
                                if (Impr.Estacion != null && Impr.Estacion.ToUpperInvariant() == System.Environment.MachineName.ToUpperInvariant()
                                        && Impr.Sucursal != null && Impr.Sucursal.Id == Lbl.Sys.Config.Actual.Empresa.SucursalPredeterminada.Id)
                                        return Impr.Impresora;
                        }

                        // Intento obtener una impresora para esta estación, cualquier sucursal
                        foreach (Lbl.Impresion.TipoImpresora Impr in this.Tipo.Impresoras) {
                                if (Impr.Estacion != null && Impr.Estacion.ToUpperInvariant() == System.Environment.MachineName.ToUpperInvariant()
                                        && Impr.Sucursal == null)
                                        return Impr.Impresora;
                        }

                        // Intento obtener una impresora para esta sucursal, cualquier estacion
                        foreach (Lbl.Impresion.TipoImpresora Impr in this.Tipo.Impresoras) {
                                if (Impr.Estacion == null
                                        && Impr.Sucursal != null && Impr.Sucursal.Id == Lbl.Sys.Config.Actual.Empresa.SucursalPredeterminada.Id)
                                        return Impr.Impresora;
                        }

                        // Intento obtener una impresora para cual sucursal, cualquier estacion
                        foreach (Lbl.Impresion.TipoImpresora Impr in this.Tipo.Impresoras) {
                                if (Impr.Estacion == null && Impr.Sucursal == null)
                                        return Impr.Impresora;
                        }

                        return null;
                }

                public override Lfx.Types.OperationResult Imprimir()
                {
                        // Determino la impresora que le corresponde
                        if (this.Impresora == null)
                                this.Impresora = this.ObtenerImpresora();

                        if (this.Plantilla == null)
                                this.Plantilla = this.ObtenerPlantilla();

                        Lfx.Types.OperationResult Res = base.Imprimir();
                        if (Res.Success)
                                Lbl.Sys.Config.ActionLog(this.Connection, Lbl.Sys.Log.Acciones.Print, this.Elemento, null);
                        else
                                Lbl.Sys.Config.ActionLog(this.Connection, Lbl.Sys.Log.Acciones.PrintFail, this.Elemento, Res.Message);
                        
                        return Res;

                }

                protected override void OnBeginPrint(PrintEventArgs e)
                {
                        if (this.DocumentName == null || this.DocumentName.Length == 0 || this.DocumentName == "document")
                                this.DocumentName = this.Elemento.ToString();

                        if (this.Plantilla != null) {
                                if (this.Plantilla.Margenes != null)
                                        this.DefaultPageSettings.Margins = this.Plantilla.Margenes;
                                else
                                        this.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);

                                if (this.Plantilla.Bandeja > 0) {
                                        if (this.Plantilla.Bandeja > this.PrinterSettings.PaperSources.Count)
                                                throw new ArgumentOutOfRangeException("El número de bandeja no es válido para esta impresora");
                                        else
                                                this.DefaultPageSettings.PaperSource = this.PrinterSettings.PaperSources[this.Plantilla.Bandeja - 1];
                                }
                        }

                        base.OnBeginPrint(e);
                }

                protected override void OnPrintPage(PrintPageEventArgs e)
                {
                        e.Graphics.PageUnit = GraphicsUnit.Document;
                        if (this.Plantilla != null) {
                                e.PageSettings.Landscape = Plantilla.Landscape;

                                this.ImprimirCampos(e);
                        }
                        base.OnPrintPage(e);
                }

                protected virtual void ImprimirCampos(PrintPageEventArgs e)
                {
                        ImprimirCampos(e, e.PageBounds, true);
                }

                protected virtual void ImprimirCampos(PrintPageEventArgs e, Rectangle recorte, bool imprimirEspejos)
                {
                        e.Graphics.TranslateTransform(recorte.X, recorte.Y);
                        foreach (Lbl.Impresion.Campo Cam in this.Plantilla.Campos) {
                                if (Cam.Valor.ToUpperInvariant() != "{ESPEJO}")
                                        this.ImprimirCampo(e, Cam);
                        }
                        foreach (Lbl.Impresion.Campo Cam in this.Plantilla.Campos) {
                                if (Cam.Valor.ToUpperInvariant() == "{ESPEJO}" && imprimirEspejos)
                                        this.ImprimirCampos(e, Cam.Rectangle, false);
                        }
                }

                protected virtual void ImprimirCampo(PrintPageEventArgs e, Lbl.Impresion.Campo Cam)
                {
                        if (Cam.ColorFondo != Color.Transparent)
                                e.Graphics.FillRectangle(new SolidBrush(Cam.ColorFondo), Cam.Rectangle);

                        if (Cam.AnchoBorde > 0)
                                e.Graphics.DrawRectangle(new Pen(Cam.ColorBorde, Cam.AnchoBorde), Cam.Rectangle);

                        // Imprimir texto
                        string Texto = Cam.Valor;
                        // Expando variables tipo {nombrecampo} por el valor del campo
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
                        object Res = this.Elemento.GetFieldValue<object>(nombreCampo);
                        if (Res != null)
                                return Res.ToString();

                        switch (nombreCampo.ToUpperInvariant()) {
                                case "NOMBRE":
                                        return (this.Elemento as Lbl.ICamposBaseEstandar).Nombre;

                                case "EMPRESA":
                                case "EMPRESA.NOMBRE":
                                        return Lbl.Sys.Config.Actual.Empresa.Nombre;
                                case "EMPRESA.DOMICILIO":
                                        return this.Workspace.CurrentConfig.Empresa.Domicilio;
                                case "EMPRESA.CIUDAD":
                                case "EMPRESA.LOCALIDAD":
                                        return this.Workspace.CurrentConfig.Empresa.NombreLocalidad;
                                case "EMPRESA.TELEFONO":
                                        return this.Workspace.CurrentConfig.Empresa.Telefono;

                                default:
                                        // Intento obtener una propiedad por su nombre
                                        // TODO: implementar propiedades de propiedades (ejemplo "Cliente.Ciudad")
                                        System.Reflection.PropertyInfo Prop = this.Elemento.GetType().GetProperty(nombreCampo);
                                        if (Prop != null) {
                                                object Val = Prop.GetValue(this.Elemento, null);
                                                return Val.ToString();
                                        } else {
                                                return "{" + nombreCampo + "}";
                                        }
                        }
                }
        }
}
