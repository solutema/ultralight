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

namespace Lazaro.Mensajeria
{

        /// <summary>
        /// La función Try se usa para decidir si cargar el componente o no.
        /// </summary>
        public class Try : Lfx.Components.TryFunction
        {
                public override object Run()
                {
                        Notify.FormChat = new Chat.Inicio();
                        // Accedo a la propiedad handle para forzar la creación del mismo
                        IntPtr Dummy = Notify.FormChat.Handle;
                        return new Lfx.Types.SuccessOperationResult();
                }
        }


        /// <summary>
        /// La función Notify se usa para recibir notificaciones locales o remotas.
        /// </summary>
        public class Notify : Lfx.Components.Function
        {
                public static Chat.Inicio FormChat = null;

                public override object Run()
                {
                        // Suscribo a esto via Runtime.Ipc (en Lfx)

                        /* Lbl.Notificaciones.INotificacion Notif = this.Arguments[0] as Lbl.Notificaciones.INotificacion;
                        if (Notif != null) {
                                if (FormChat != null)
                                        FormChat.MensajeRecibido(Notif);
                        } */

                        return new Lfx.Types.SuccessOperationResult();
                }
        }


        /// <summary>
        /// La función Notify se usa para recibir notificaciones locales o remotas.
        /// </summary>
        public class Show : Lfx.Components.Function
        {
                public override object Run()
                {
                        Notify.FormChat.Show();
                        return new Lfx.Types.SuccessOperationResult();
                }
        }
}