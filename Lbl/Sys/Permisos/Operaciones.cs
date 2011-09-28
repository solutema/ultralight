#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lbl.Sys.Permisos
{
        [Flags]
        public enum Operaciones
        {
                // Operaciones donde no se cambian los datos
                Ninguno = 0,
                Listar = 1,
                Ver = 2,
                Imprimir = 4,

                // Operaciones donde se cambian los datos en situaciones más bien cotidianas
                Crear = 8,
                Editar = 16,
                EditarAvanzado = 32,
                Mover = 64,

                // Operaciones donde se hacen cambios más importantes
                Eliminar = 128,
                Administrar = 256,
                Extra0 = 512,

                // Campos extra para uso de las implementaciones
                Extra1 = 1024,
                Extra2 = 2048,
                Extra3 = 4096,

                // Campos extra para uso de las implementaciones
                ExtraA = 8192,
                ExtraB = 16384,
                ExtraC = 32768,

                // Acceso total (incluye todas las anteriores)
                Total = 65536
        }
}
