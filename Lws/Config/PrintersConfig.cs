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
using System.Text;

namespace Lws.Config
{
        public class PrintersConfig
        {
                private ConfigManager ConfigManager;

                public PrintersConfig(ConfigManager configManager)
                {
                        this.ConfigManager = configManager;
                }

                public string PreferredPrinter(string sTipo)
                {
                        string res = ConfigManager.ReadGlobalSettingString("", "Sistema.Documentos." + sTipo + ".Impresora", "");
                        if (res != null && res.Length == 0) {
                                // Si NO hay una impresora definida para este documento,
                                // busco alternativas
                                if (sTipo == "NCA" || sTipo == "NDA") {
                                        // La impresora predeterminada para las notas de débito y 
                                        // crédito "A" es la misma que para las comprob "A"
                                        res = PreferredPrinter("FA");
                                } else if (sTipo == "NCB" || sTipo == "NDB") {
                                        // Lo mismo con las "B"
                                        res = PreferredPrinter("FB");
                                } else if (sTipo.Length >= 8 && sTipo.Substring(0, 8) == "Listado.") {
                                        // Si no hay impresora para este listado en particular,
                                        // busco la impresora definida para listados en general
                                        res = PreferredPrinter("Listados");
                                }
                        }
                        if (res != null && res.Length > System.Environment.MachineName.ToUpperInvariant().Length + 3 && string.Compare(res.Substring(0, System.Environment.MachineName.ToUpperInvariant().Length + 3), System.Convert.ToString(System.IO.Path.DirectorySeparatorChar) + System.IO.Path.DirectorySeparatorChar + System.Environment.MachineName.ToUpperInvariant() + System.IO.Path.DirectorySeparatorChar, true) == 0) {
                                // Si el nombre de la impresora incluye el nombre de la PC
                                // y resulta que es esta misma PC, asumo que es una impresora local
                                // y le quito el nombre de la estación

                                // Por ejemplo, si la impresora es "\\Oficina1\hp1010", la dejo
                                // en "hp1010" cuando imprimo desde "Oficina1"
                                res = res.Substring(System.Environment.MachineName.ToUpperInvariant().Length + 3, res.Length - (System.Environment.MachineName.ToUpperInvariant().Length + 3));
                        }
                        return res;
                }

                public string PrinterFeed(string sTipo)
                {
                        return PrinterFeed(sTipo, "auto");
                }

                public string PrinterFeed(string sTipo, string sPredet)
                {
                        string res = ConfigManager.ReadGlobalSettingString("", "Sistema.Documentos." + sTipo + ".Carga", sPredet);
                        if (res == null || res.Length == 0) {
                                // Si NO hay una impresora definida para este documento,
                                // busco alternativas
                                if (sTipo == "NCA" || sTipo == "NDA") {
                                        // La impresora predeterminada para las notas de débito y 
                                        // crédito "A" es la misma que para las comprob "A"
                                        res = PrinterFeed("FA");
                                } else if (sTipo == "NCB" || sTipo == "NDB") {
                                        // Lo mismo con las "B"
                                        res = PrinterFeed("FB");
                                } else if (sTipo.Length >= 8 && sTipo.Substring(0, 8) == "Listado.") {
                                        // Si no hay impresora para este listado en particular,
                                        // busco la impresora definida para listados en general
                                        res = PrinterFeed("Listados");
                                }
                        }
                        return res;
                }
        }
}
