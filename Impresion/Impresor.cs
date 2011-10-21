#region License
// Copyright 2004-2011 Ernesto N. Carrea
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
using System.Data;
using System.Text;

namespace Lazaro.Impresion
{
        public class Impresor : System.Drawing.Printing.PrintDocument
        {
                public Lbl.Impresion.Impresora Impresora = null;
                protected const double mm = 3.937007874015748031496062992126;
                protected Lfx.Data.Connection m_DataBase = null;
                public IDbTransaction Transaction = null;

                public Impresor(IDbTransaction transaction)
                {
                        this.Transaction = transaction;
                }

                public Lfx.Data.Connection Connection
                {
                        get
                        {
                                if (m_DataBase == null)
                                        m_DataBase = Lfx.Workspace.Master.MasterConnection;
                                return m_DataBase;
                        }
                }

                public Lfx.Workspace Workspace
                {
                        get
                        {
                                return Lfx.Workspace.Master;
                        }
                }


                protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e)
                {
                        if (this.Impresora != null) {
                                if (Impresora.EsVistaPrevia)
                                        this.PrintController = new System.Drawing.Printing.PreviewPrintController();

                                if (this.Impresora.EsLocalPredeterminada == false) {
                                        if (this.Impresora.EsLocal)
                                                this.PrinterSettings.PrinterName = this.Impresora.Dispositivo;
                                        else
                                                this.PrinterSettings.PrinterName = this.Impresora.DispositivoUnc;
                                }
                        }

                        base.OnBeginPrint(e);
                }


                public virtual Lfx.Types.OperationResult Imprimir()
                {
                        try {
                                this.Print();
                        } catch (Exception ex) {
                                return new Lfx.Types.FailureOperationResult(ex.Message);
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }
        }
}
