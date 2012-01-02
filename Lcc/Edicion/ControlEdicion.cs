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

using System.ComponentModel;
using System.Data;

namespace Lcc.Edicion
{
        public class ControlEdicion : Lcc.ControlDeDatos
        {
                [System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
                public event LccEventHandler SaveRequest;

                /// <summary>
                /// Actualiza el elemento con los datos del control.
                /// </summary>
                public virtual void ActualizarElemento()
                {
                }


                /// <summary>
                /// Se dispara cuando el elemento fue guardado.
                /// </summary>
                public virtual Lfx.Types.OperationResult BeforeSave()
                {
                        return new Lfx.Types.SuccessOperationResult();
                }

                /// <summary>
                /// Se dispara cuando el elemento fue guardado.
                /// </summary>
                public virtual void AfterSave(IDbTransaction transaction)
                {
                }


                public Lfx.Types.OperationResult Save()
                {
                        Lfx.Types.OperationResult Res = this.ValidarControl();
                        if (Res.Success == false)
                                return Res;

                        Res = this.BeforeSave();
                        if (Res.Success == false)
                                return Res;

                        if (this.SaveRequest != null) {
                                Lcc.LccEventArgs Args = new Lcc.LccEventArgs();
                                this.SaveRequest(this, ref Args);
                                if (Args.Result != null) {
                                        return Args.Result;
                                } else {
                                        return new Lfx.Types.SuccessOperationResult();
                                }
                        } else {
                                return new Lfx.Types.FailureOperationResult("No se puede grabar");
                        }
                }


                /// <summary>
                /// Valida los datos del control.
                /// </summary>
                public virtual Lfx.Types.OperationResult ValidarControl()
                {
                        return new Lfx.Types.SuccessOperationResult();
                }


                // Compatibilidad con Lfc.FormularioEdicion
                public void FromRow(Lbl.IElementoDeDatos row)
                {
                        // Si todavía no conozco el tipo de elemento de este formulario, lo tomo de row
                        if (this.ElementoTipo == null || this.ElementoTipo == typeof(Lbl.ElementoDeDatos))
                                this.ElementoTipo = row.GetType();

                        this.Elemento = row;
                        this.ActualizarControl();
                }

                // Compatibilidad con Lfc.FormularioEdicion
                public Lbl.IElementoDeDatos ToRow()
                {
                        this.ActualizarElemento();
                        return this.Elemento;
                }


                public virtual Lfx.Types.OperationResult BeforePrint()
                {
                        return new Lfx.Types.SuccessOperationResult();
                }


                public virtual void AfterPrint()
                {
                        return;
                }


                public override bool TemporaryReadOnly
                {
                        get
                        {
                                return base.TemporaryReadOnly;
                        }
                        set
                        {
                                base.TemporaryReadOnly = value;
                                this.SetControlsReadOnly(this.Controls, m_TemporaryReadOnly);
                        }
                }

                internal void SetControlsReadOnly(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
                {
                        // Pongo los Changed en False
                        foreach (System.Windows.Forms.Control ctl in controles) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is Lui.Forms.Control) {
                                        ((Lui.Forms.Control)ctl).TemporaryReadOnly = newValue;
                                } else if (ctl.Controls != null) {
                                        SetControlsReadOnly(ctl.Controls, newValue);
                                }

                        }
                }

                public virtual bool PuedeEditar()
                {
                        if (this.Elemento.Existe)
                                return Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(this.Elemento, Lbl.Sys.Permisos.Operaciones.Editar);
                        else
                                return Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(this.Elemento, Lbl.Sys.Permisos.Operaciones.Crear);
                }

                public virtual bool PuedeImprimir()
                {
                        return Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(this.Elemento, Lbl.Sys.Permisos.Operaciones.Imprimir);
                }
        }
}
