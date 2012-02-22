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
using System.Data;
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

                public ImpresorElemento(Lbl.ElementoDeDatos elemento, IDbTransaction transaction)
                        : base(transaction)
		{
                        this.Elemento = elemento;
                        m_DataBase = elemento.Connection;
		}


                protected virtual Lbl.Impresion.Plantilla ObtenerPlantilla()
                {
                        return this.ObtenerPlantilla(this.Elemento.GetType());
                }


                protected virtual Lbl.Impresion.Plantilla ObtenerPlantilla(Type tipoElemento)
                {
                        string nombreTipo = tipoElemento.ToString();
                        if (Lbl.Impresion.Plantilla.TodasPorCodigo.ContainsKey(nombreTipo))
                                return Lbl.Impresion.Plantilla.TodasPorCodigo[nombreTipo];
                        else if (tipoElemento.BaseType != null) {
                                return this.ObtenerPlantilla(tipoElemento.BaseType);
                        } else {
                                Lbl.Impresion.Plantilla Res = new Lbl.Impresion.Plantilla(this.Connection);
                                Res.Crear();
                                return Res;
                        }
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
                                        && Impr.Sucursal != null && Impr.Sucursal.Id == Lbl.Sys.Config.Empresa.SucursalActual.Id)
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
                                        && Impr.Sucursal != null && Impr.Sucursal.Id == Lbl.Sys.Config.Empresa.SucursalActual.Id)
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

                        System.Data.IDbTransaction Trans = null;
                        if (this.Connection.InTransaction == false)
                                Trans = this.Connection.BeginTransaction();

                        if (Res.Success)
                                Lbl.Sys.Config.ActionLog(this.Connection, Lbl.Sys.Log.Acciones.Print, this.Elemento, null);
                        else
                                Lbl.Sys.Config.ActionLog(this.Connection, Lbl.Sys.Log.Acciones.PrintFail, this.Elemento, Res.Message);

                        if (Trans != null)
                                Trans.Commit();
                        
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
                                                throw new InvalidOperationException("El número de bandeja no es válido para esta impresora");
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
                                string ValorCampo = ObtenerValorCampo(Mt.Value.Substring(1, Mt.Value.Length - 2), Cam.Formato);
                                Texto = Texto.Replace(Mt.Value, ValorCampo);
                        }

                        StringFormat Fmt = new StringFormat(); //StringFormatFlags.NoClip);
                        if (Cam.Wrap == false)
                                Fmt.FormatFlags |= StringFormatFlags.NoWrap;
                        Fmt.Alignment = Cam.Alignment;
                        Fmt.LineAlignment = Cam.LineAlignment;
                        Fmt.Trimming = StringTrimming.EllipsisCharacter;
                        Font Fnt = Cam.Font;
                        if (Fnt == null)
                                Fnt = Plantilla.Font;
                        if (Fnt == null)
                                Fnt = Lazaro.Pres.DisplayStyles.Template.Current.DefaultFont;
                        e.Graphics.DrawString(Texto, Fnt, new SolidBrush(Cam.ColorTexto), Cam.Rectangle, Fmt);
                }

                public virtual string ObtenerValorCampo(string nombreCampo, string formato)
                {
                        switch (nombreCampo.ToUpperInvariant()) {
                                case "HOY":
                                        if (formato != null) {
                                                try {
                                                        return DateTime.Now.ToString(formato);
                                                } catch {
                                                        return "Formato no válido";
                                                }
                                        } else {
                                                return DateTime.Now.ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);
                                        }

                                case "EMPRESA":
                                case "EMPRESA.NOMBRE":
                                        return Lbl.Sys.Config.Empresa.Nombre;
                                case "EMPRESA.DOMICILIO":
                                        return Lfx.Workspace.Master.CurrentConfig.Empresa.Domicilio;
                                case "EMPRESA.CIUDAD":
                                case "EMPRESA.LOCALIDAD":
                                        return Lfx.Workspace.Master.CurrentConfig.Empresa.NombreLocalidad;
                                case "EMPRESA.TELEFONO":
                                        return Lfx.Workspace.Master.CurrentConfig.Empresa.Telefono;

                                default:
                                        // Intento obtener por nombre de propiedad del objeto
                                        object Val = ObtenerPropiedadElemento(this.Elemento, nombreCampo);
                                        if (Val == null) {
                                                // Intento obtener por nombre de campo
                                                Val = this.Elemento.GetFieldValue<object>(nombreCampo.ToLowerInvariant());
                                        }

                                        if (Val != null && Val is DateTime || Val is NullableDateTime) {
                                                if (Val is NullableDateTime)
                                                        Val = ((NullableDateTime)(Val)).Value;
                                                if (formato != null) {
                                                        try {
                                                                return ((DateTime)Val).ToString(formato);
                                                        } catch {
                                                                return "Formato no válido";
                                                        }
                                                } else {
                                                        return ((DateTime)Val).ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);
                                                }
                                        } else if (Val is decimal) {
                                                if (formato != null) {
                                                        try {
                                                                return ((decimal)Val).ToString(formato);
                                                        } catch {
                                                                return "Formato no válido";
                                                        }
                                                } else {
                                                        return ((decimal)Val).ToString("#.00");
                                                }
                                        } else if (Val is bool) {
                                                return (bool)Val ? "Sí" : "No";
                                        } else if (Val == null) {
                                                return "";
                                        } else {
                                                return Val.ToString();
                                        }
                        }
                }

                private object ObtenerPropiedadElemento(Lbl.ElementoDeDatos elemento, string nombrePropiedad)
                {
                        // Intento obtener una propiedad por su nombre
                        if (nombrePropiedad == null || nombrePropiedad.Length == 0)
                                return null;

                        string[] Partes = nombrePropiedad.Split(new char[] { '.' }, 2);
                        if(Partes.Length == 0)
                                return null;

                        System.Reflection.PropertyInfo Prop = elemento.GetType().GetProperty(Partes[0]);
                        object Val = null;

                        if (Prop != null) {
                                Val = Prop.GetValue(elemento, null);
                        } else {
                                // No hay propiedad... busco un miembro público
                                System.Reflection.FieldInfo Fi = elemento.GetType().GetField(Partes[0]);
                                try {
                                        Val = elemento.GetType().InvokeMember(Fi.Name, System.Reflection.BindingFlags.GetField, null, elemento, null);
                                } catch {
                                        Val = null;
                                }
                        }

                        
                        if (Val == null) {
                                return null;
                        } else if (Val is Lbl.ElementoDeDatos && Partes.Length > 1) {
                                return ObtenerPropiedadElemento(Val as Lbl.ElementoDeDatos, Partes[1]);
                        } else {
                                return Val;
                        }
                }
        }
}
