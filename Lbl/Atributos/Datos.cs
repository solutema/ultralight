using System;
using System.Collections.Generic;

namespace Lbl.Atributos
{
        public class Datos : System.Attribute
        {
                public string NombreSingular { get; set; }
                public string Grupo { get; set; }
                public string TablaDatos { get; set; }
                public string CampoId { get; set; }
                public string CampoNombre { get; set; }
                public string CampoImagen { get; set; }
                public string TablaImagenes { get; set; }

                public Datos()
                {
                        this.CampoNombre = "nombre";
                        this.CampoImagen = "imagen";
                }

                public Datos(string nombreSingular, string tablaDatos, string campoId, string campoNombre = "nombre", string campoImagen = null, string tablaImagenes = null)
                {
                        this.NombreSingular = nombreSingular;
                        this.TablaDatos = tablaDatos;
                        this.CampoId = campoId;
                        this.CampoNombre = campoNombre;
                        this.CampoImagen = CampoImagen;
                        this.TablaImagenes = tablaImagenes;
                }


                public string NombrePlural
                {
                        get
                        {
                                string Res = "";
                                string[] Palabras = this.NombreSingular.Split(new char[] { ' ', '-' });
                                foreach (string Palabra in Palabras) {
                                        if (Palabra == "de")
                                                Res += "de ";
                                        else if (Palabra == "del")
                                                Res += "de los ";
                                        else if ("aeiouáéíóúü".IndexOf(Palabra.Substring(Palabra.Length - 1, 1).ToLowerInvariant()) >= 0)
                                                Res += Palabra + "s ";
                                        else
                                                Res += Palabra + "es ";
                                }
                                return Res.Trim();
                        }
                }
        }
}
