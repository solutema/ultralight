#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

using System.Collections.Generic;
using System.Xml;

namespace Lbl.Impresion
{
        /// <summary>
        /// Define una plantilla que se utiliza para imprimir un ElementoDeDatos.
        /// </summary>
        [Lbl.Atributos.NombreItem("Plantilla")]
	public class Plantilla : ElementoDeDatos
	{
                public System.Collections.Generic.List<Campo> Campos;
                public System.Drawing.Font Font;

		//Heredar constructor
		public Plantilla(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Plantilla(Lfx.Data.Connection dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

                public Plantilla(Lfx.Data.Connection dataBase, int itemId)
                        : base(dataBase, itemId) { }

                public Plantilla(Lfx.Data.Connection dataBase, System.Type tipoElemento)
                        : this(dataBase, tipoElemento.ToString()) { }

                public Plantilla(Lfx.Data.Connection dataBase, string tipoComprob)
                        : this(dataBase)
                {
                        string BuscarComprob = tipoComprob;

                        // Esta es una situación especial para los Lbl.Comprobantes.ComprobanteConArticulos
                        // Los busco por letra
                        switch (BuscarComprob) {
                                case "NDA":
                                case "NCA":
                                        m_ItemId = dataBase.FieldInt("SELECT id_plantilla FROM sys_plantillas WHERE codigo='FA'");
                                        break;
                                case "NDB":
                                case "NCB":
                                        m_ItemId = dataBase.FieldInt("SELECT id_plantilla FROM sys_plantillas WHERE codigo='FB'");
                                        break;
                                case "NDC":
                                case "NCC":
                                        m_ItemId = dataBase.FieldInt("SELECT id_plantilla FROM sys_plantillas WHERE codigo='FC'");
                                        break;
                                case "NDE":
                                case "NCE":
                                        m_ItemId = dataBase.FieldInt("SELECT id_plantilla FROM sys_plantillas WHERE codigo='FE'");
                                        break;
                                case "NDM":
                                case "NCM":
                                        m_ItemId = dataBase.FieldInt("SELECT id_plantilla FROM sys_plantillas WHERE codigo='FM'");
                                        break;
                        }

                        if (m_ItemId == 0) {
                                // Esta es una situación especial para los Lbl.Comprobantes.ComprobanteConArticulos
                                switch (BuscarComprob) {
                                        case "FB":
                                        case "FC":
                                        case "FE":
                                        case "FM":
                                                m_ItemId = dataBase.FieldInt("SELECT id_plantilla FROM sys_plantillas WHERE codigo='FA'");
                                                break;
                                }
                                m_ItemId = dataBase.FieldInt("SELECT id_plantilla FROM sys_plantillas WHERE codigo='" + BuscarComprob + "'");
                        }

                        if (m_ItemId == 0)
                                // Busco por el tipo de datos, literal (p. ej. Lbl.Comprobantes.Factura o Lbl.ElementoDeDatos) 
                                m_ItemId = dataBase.FieldInt("SELECT id_plantilla FROM sys_plantillas WHERE codigo='" + BuscarComprob + "'");

                        if (m_ItemId == 0)
                                // Busco una plantilla genérica
                                m_ItemId = dataBase.FieldInt("SELECT id_plantilla FROM sys_plantillas WHERE codigo='*'");

                        this.Cargar();
                }


                public override string TablaDatos
		{
			get
			{
				return "sys_plantillas";
			}
		}


                public override string CampoId
		{
			get
			{
				return "id_plantilla";
			}
		}


                public override void Crear()
                {
                        base.Crear();

                        this.TamanoPapel = "a4";
                        this.Campos = new List<Campo>();
                        this.Margenes = null;
                }


                public int Copias
                {
                        get
                        {
                                return System.Convert.ToInt32(this.Registro["copias"]);
                        }
                        set
                        {
                                this.Registro["copias"] = value;
                        }
                }


                public System.Drawing.Printing.Margins Margenes
                {
                        get
                        {
                                if (System.Convert.ToInt32(this.Registro["margen_izquierda"]) == -1)
                                        return null;
                                else
                                        return new System.Drawing.Printing.Margins(System.Convert.ToInt32(this.Registro["margen_izquierda"]),
                                                System.Convert.ToInt32(this.Registro["margen_derecha"]),
                                                System.Convert.ToInt32(this.Registro["margen_arriba"]),
                                                System.Convert.ToInt32(this.Registro["margen_abajo"]));
                        }
                        set
                        {
                                if (value == null) {
                                        this.Registro["margen_izquierda"] = -1;
                                        this.Registro["margen_derecha"] = -1;
                                        this.Registro["margen_arriba"] = -1;
                                        this.Registro["margen_abajo"] = -1;
                                } else {
                                        this.Registro["margen_izquierda"] = value.Left;
                                        this.Registro["margen_derecha"] = value.Right;
                                        this.Registro["margen_arriba"] = value.Top;
                                        this.Registro["margen_abajo"] = value.Bottom;
                                }
                        }
                }


                public int Membrete
                {
                        get
                        {
                                return System.Convert.ToInt32(this.Registro["membrete"]);
                        }
                        set
                        {
                                this.Registro["membrete"] = value;
                        }
                }


                public int Bandeja
                {
                        get
                        {
                                return System.Convert.ToInt32(this.Registro["bandeja"]);
                        }
                        set
                        {
                                this.Registro["bandeja"] = value;
                        }
                }


                public string Codigo
                {
                        get
                        {
                                return this.GetFieldValue<string>("codigo");
                        }
                        set
                        {
                                this.Registro["codigo"] = value;
                        }
                }


		public bool Landscape
		{
			get
			{
				return System.Convert.ToBoolean(this.Registro["landscape"]);
			}
			set
			{
				this.Registro["landscape"] = value ? 1 : 0;
			}
		}


                public string TamanoPapel
                {
                        get
                        {
                                return this.GetFieldValue<string>("tamanopapel");
                        }
                        set
                        {
                                this.Registro["tamanopapel"] = value;
                        }
                }


                public System.Xml.XmlDocument Definicion
                {
                        get
                        {
                                XmlDocument Res = new XmlDocument();
                                Res.LoadXml(this.Registro["defxml"].ToString());
                                return Res;
                        }
                        set
                        {
                                this.Registro["defxml"] = value.OuterXml;
                        }
                }


                public override Lfx.Types.OperationResult Guardar()
                {
                        XmlDocument XmlDef = new XmlDocument();
                        XmlElement Plant = XmlDef.CreateElement("Plantilla");
                        XmlDef.AppendChild(Plant);

                        XmlAttribute Attr = XmlDef.CreateAttribute("Copias");
                        Attr.Value = this.Copias.ToString();
                        Plant.Attributes.Append(Attr);

                        Attr = XmlDef.CreateAttribute("Membrete");
                        Attr.Value = this.Membrete.ToString();
                        Plant.Attributes.Append(Attr);

                        if (this.Font != null) {
                                Attr = XmlDef.CreateAttribute("Fuente");
                                Attr.Value = this.Font.Name;
                                Plant.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("TamanoFuente");
                                Attr.Value = this.Font.Size.ToString();
                                Plant.Attributes.Append(Attr);
                        }

                        foreach (Campo Cam in this.Campos) {
                                XmlElement CampoXml = XmlDef.CreateElement("Campo");
                                Plant.AppendChild(CampoXml);

                                Attr = XmlDef.CreateAttribute("Valor");
                                Attr.Value = Cam.Valor;
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("X");
                                Attr.Value = Cam.Rectangle.X.ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("Y");
                                Attr.Value = Cam.Rectangle.Y.ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("Ancho");
                                Attr.Value = Cam.Rectangle.Width.ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("Alto");
                                Attr.Value = Cam.Rectangle.Height.ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("Alineacion");
                                Attr.Value = Cam.Alignment.ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("AlineacionRenglon");
                                Attr.Value = Cam.LineAlignment.ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("AnchoBorde");
                                Attr.Value = Cam.AnchoBorde.ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("ColorBorde");
                                Attr.Value = Cam.ColorBorde.ToArgb().ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("ColorFondo");
                                Attr.Value = Cam.ColorFondo.ToArgb().ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("ColorTexto");
                                Attr.Value = Cam.ColorTexto.ToArgb().ToString();
                                CampoXml.Attributes.Append(Attr);

                                Attr = XmlDef.CreateAttribute("Wrap");
                                Attr.Value = Cam.Wrap ? "1" : "0";
                                CampoXml.Attributes.Append(Attr);

                                if (Cam.Font != null) {
                                        Attr = XmlDef.CreateAttribute("Fuente");
                                        Attr.Value = Cam.Font.Name;
                                        CampoXml.Attributes.Append(Attr);

                                        Attr = XmlDef.CreateAttribute("TamanoFuente");
                                        Attr.Value = Cam.Font.Size.ToString();
                                        CampoXml.Attributes.Append(Attr);
                                }
                        }

                        this.Definicion = XmlDef;

			qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("codigo", this.Codigo);
                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("defxml", this.Registro["defxml"]);
                        Comando.Fields.AddWithValue("tamanopapel", this.TamanoPapel);
			Comando.Fields.AddWithValue("landscape", this.Landscape ? 1 : 0);
                        Comando.Fields.AddWithValue("copias", this.Copias);
                        Comando.Fields.AddWithValue("membrete", this.Membrete);
                        Comando.Fields.AddWithValue("bandeja", this.Bandeja);
                        
                        System.Drawing.Printing.Margins Margen = this.Margenes;
                        if (Margen == null) {
                                Comando.Fields.AddWithValue("margen_izquierda", -1);
                                Comando.Fields.AddWithValue("margen_derecha", -1);
                                Comando.Fields.AddWithValue("margen_arriba", -1);
                                Comando.Fields.AddWithValue("margen_abajo", -1);
                        } else {
                                Comando.Fields.AddWithValue("margen_izquierda", Margen.Left);
                                Comando.Fields.AddWithValue("margen_derecha", Margen.Right);
                                Comando.Fields.AddWithValue("margen_arriba", Margen.Top);
                                Comando.Fields.AddWithValue("margen_abajo", Margen.Bottom);
                        }

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }

                public void CargarXml(string defXml)
                {
                        XmlDocument Doc = new XmlDocument();
                        Doc.LoadXml(defXml);
                        this.CargarXml(Doc);
                }

                public void CargarXml(XmlDocument xmlDoc)
                {
                        this.Campos.Clear();
                        XmlNode Plant = xmlDoc.SelectSingleNode("/Plantilla");
                        if (Plant.Attributes["Fuente"] != null && Plant.Attributes["TamanoFuente"] != null) {
                                this.Font = new System.Drawing.Font(Plant.Attributes["Fuente"].Value, Lfx.Types.Parsing.ParseInt(Plant.Attributes["TamanoFuente"].Value));
                        }
                        foreach (XmlNode Cam in Plant.ChildNodes) {
                                if (Cam.Name == "Campo") {
                                        Campo NuevoCampo = new Campo();
                                        NuevoCampo.Valor = Cam.Attributes["Valor"].Value;
                                        if (Cam.Attributes["AnchoBorde"] != null)
                                                NuevoCampo.AnchoBorde = Lfx.Types.Parsing.ParseInt(Cam.Attributes["AnchoBorde"].Value);
                                        if (Cam.Attributes["ColorBorde"] != null)
                                                NuevoCampo.ColorBorde = System.Drawing.Color.FromArgb(Lfx.Types.Parsing.ParseInt(Cam.Attributes["ColorBorde"].Value));
                                        if (Cam.Attributes["ColorTexto"] != null)
                                                NuevoCampo.ColorTexto = System.Drawing.Color.FromArgb(Lfx.Types.Parsing.ParseInt(Cam.Attributes["ColorTexto"].Value));
                                        if (Cam.Attributes["ColorFondo"] != null)
                                                NuevoCampo.ColorFondo = System.Drawing.Color.FromArgb(Lfx.Types.Parsing.ParseInt(Cam.Attributes["ColorFondo"].Value));
                                        NuevoCampo.Rectangle.X = Lfx.Types.Parsing.ParseInt(Cam.Attributes["X"].Value);
                                        NuevoCampo.Rectangle.Y = Lfx.Types.Parsing.ParseInt(Cam.Attributes["Y"].Value);
                                        NuevoCampo.Rectangle.Width = Lfx.Types.Parsing.ParseInt(Cam.Attributes["Ancho"].Value);
                                        NuevoCampo.Rectangle.Height = Lfx.Types.Parsing.ParseInt(Cam.Attributes["Alto"].Value);
                                        if (Cam.Attributes["AlineacionRenglon"] != null) {
                                                switch (Cam.Attributes["AlineacionRenglon"].Value) {
                                                        case "Far":
                                                                NuevoCampo.LineAlignment = System.Drawing.StringAlignment.Far;
                                                                break;
                                                        case "Center":
                                                                NuevoCampo.LineAlignment = System.Drawing.StringAlignment.Center;
                                                                break;
                                                        default:
                                                                NuevoCampo.LineAlignment = System.Drawing.StringAlignment.Near;
                                                                break;
                                                }
                                        }
                                        if (Cam.Attributes["Alineacion"] != null) {
                                                switch (Cam.Attributes["Alineacion"].Value) {
                                                        case "Far":
                                                                NuevoCampo.Alignment = System.Drawing.StringAlignment.Far;
                                                                break;
                                                        case "Center":
                                                                NuevoCampo.Alignment = System.Drawing.StringAlignment.Center;
                                                                break;
                                                        default:
                                                                NuevoCampo.Alignment = System.Drawing.StringAlignment.Near;
                                                                break;
                                                }
                                        }
                                        if (Cam.Attributes["Fuente"] != null && Cam.Attributes["TamanoFuente"] != null) {
                                                NuevoCampo.Font = new System.Drawing.Font(Cam.Attributes["Fuente"].Value, Lfx.Types.Parsing.ParseInt(Cam.Attributes["TamanoFuente"].Value));
                                        }
                                        if (Cam.Attributes["Wrap"] != null)
                                                NuevoCampo.Wrap = Lfx.Types.Parsing.ParseInt(Cam.Attributes["Ancho"].Value) != 0;
                                        this.Campos.Add(NuevoCampo);
                                }
                        }
                }

                public override Lfx.Types.OperationResult Cargar()
                {
                        Lfx.Types.OperationResult Res = base.Cargar();
                        if (Res.Success == false)
                                return Res;

                        this.Campos = new List<Campo>();
                        if (System.Convert.ToString(Registro["defxml"]).Length > 5) {
                                //Tiene definición XML... la cargo
                                this.CargarXml(Registro["defxml"].ToString());
                        } else if (System.Convert.ToString(Registro["definicion"]).Length > 5) {
                                //Tiene definición INI... la convierto
                                string Definicion = System.Convert.ToString(Registro["definicion"]);

                                string Fuente = Lfx.Types.Ini.ReadString(Definicion, "General", "Fuente", "Courier New");
                                int FuenteTamano = Lfx.Types.Ini.ReadInt(Definicion, "General", "FuenteTamano", 10);
                                this.Font = new System.Drawing.Font(Fuente, FuenteTamano);
                                this.Copias = Lfx.Types.Ini.ReadInt(Definicion, "General", "Copias");
                                int CantPasadas = Lfx.Types.Ini.ReadInt(Definicion, "General", "Pasadas");

                                //Calculo le ancho y alto de caracter
                                System.Drawing.Printing.PrintDocument DocuEjemplo = new System.Drawing.Printing.PrintDocument();
                                System.Drawing.Graphics GraficoEjemplo = DocuEjemplo.PrinterSettings.CreateMeasurementGraphics();
                                GraficoEjemplo.PageUnit = System.Drawing.GraphicsUnit.Document;
                                
                                System.Drawing.SizeF TamanoCaracter = GraficoEjemplo.MeasureString("H", new System.Drawing.Font( this.Font.Name, this.Font.Size * 0.85F));

                                System.Drawing.Rectangle PasadaXY = new System.Drawing.Rectangle();

                                for (int Pasada = 1; Pasada <= CantPasadas; Pasada++) {
                                        string[] NombresCampos = new string[] { "Fecha", "Cliente", "FormaPago", "Domicilio", "IVA", "CUIT", "Total", "Codigos", "Detalles", "Cantidades", "Importes", "SonPesos", "Texto1", "Texto2", "Texto3", "Texto4" };

                                        string NombrePasada = "Pasada" + Pasada.ToString();
                                        PasadaXY = Lfx.Types.Ini.ReadRectangle(Definicion, NombrePasada, "XY", PasadaXY);

                                        foreach (string NombreCampo in NombresCampos) {
                                                System.Drawing.Rectangle CampoXY = Lfx.Types.Ini.ReadRectangle(Definicion, NombrePasada, NombreCampo + "XY", new System.Drawing.Rectangle());
                                                if (CampoXY == new System.Drawing.Rectangle(0, 0, 0, 0) && Pasada > 1)
                                                        CampoXY = Lfx.Types.Ini.ReadRectangle(Definicion, "Pasada1", NombreCampo + "XY", new System.Drawing.Rectangle());

                                                string CampoTexto = Lfx.Types.Ini.ReadString(Definicion, NombrePasada, NombreCampo);
                                                if (CampoTexto.Length == 0 && Pasada > 1)
                                                        CampoTexto = Lfx.Types.Ini.ReadString(Definicion, "Pasada1", NombreCampo);

                                                CampoXY.X += PasadaXY.X;
                                                CampoXY.Y += PasadaXY.Y;

                                                Campo Cam = new Campo();
                                                if (NombreCampo.Length > 5 && NombreCampo.Substring(0, 5) == "Texto")
                                                        Cam.Valor = CampoTexto;
                                                else
                                                        Cam.Valor = "{" + NombreCampo + "}";

                                                if (CampoXY.Height == 0)
                                                        CampoXY.Height = 1;

                                                if (CampoXY.Width == 0) {
                                                        switch (NombreCampo.ToUpperInvariant()) {
                                                                case "CLIENTE.CUIT":
                                                                case "CUIT":
                                                                        CampoXY.Width = 13;
                                                                        break;
                                                                case "COMPROBANTE.TOTAL":
                                                                case "COMPROBANTE.SUBTOTAL":
                                                                case "ARTICULOS.CANTIDADES":
                                                                case "TOTAL":
                                                                case "SUBTOTAL":
                                                                case "CANTIDADES":
                                                                        CampoXY.Width = 16;
                                                                        break;
                                                                case "COMPROBANTE.FECHA":
                                                                case "FECHA":
                                                                        CampoXY.Width = 8;
                                                                        break;
                                                                case "IVA":
                                                                case "CLIENTE.IVA":
                                                                        CampoXY.Width = 20;
                                                                        break;
                                                                case "TEXT":
                                                                        if (CampoTexto.Length > 0)
                                                                                CampoXY.Width = CampoTexto.Length;
                                                                        else
                                                                                CampoXY.Width = 80;
                                                                        break;
                                                                default:
                                                                        CampoXY.Width = 40;
                                                                        break;
                                                        }
                                                }

                                                Cam.Rectangle = new System.Drawing.Rectangle(CampoXY.X * System.Convert.ToInt32(TamanoCaracter.Width),
                                                        CampoXY.Y * System.Convert.ToInt32(TamanoCaracter.Height),
                                                        CampoXY.Width * System.Convert.ToInt32(TamanoCaracter.Width),
                                                        CampoXY.Height * System.Convert.ToInt32(TamanoCaracter.Height));

                                                if (CampoTexto.Length > 0 || CampoXY.Location.X != 0 || CampoXY.Location.Y != 0)
                                                        this.Campos.Add(Cam);
                                        }
                                }
                                GraficoEjemplo.Dispose();
                                DocuEjemplo.Dispose();
                        } else {
                                this.Font = new System.Drawing.Font("Bitsream Vera Sans Mono", 10);
                        }

                        return Res;
                }
	}
}
