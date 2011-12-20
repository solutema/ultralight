#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace Lbl.Entidades
{

        /// <summary>
        /// Representa una País.
        /// </summary>
        [Lbl.Atributos.NombreItem("País")]
        public class Pais : ElementoDeDatos
        {
                private ClaveUnica m_ClavePersonasFisicas = null, m_ClavePersonasJuridicas = null;
                private Moneda m_Moneda = null;

                //Heredar constructor
                public Pais(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Pais(Lfx.Data.Connection dataBase, int itemId)
                        : base(dataBase, itemId) { }

                public Pais(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public override string TablaDatos
                {
                        get
                        {
                                return "paises";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_pais";
                        }
                }


                public string CodigoIso
                {
                        get
                        {
                                return this.GetFieldValue<string>("iso");
                        }
                        set
                        {
                                this.Registro["iso"] = value;
                        }
                }


                public ClaveUnica ClavePersonasFisicas
                {
                        get
                        {
                                if (m_ClavePersonasFisicas == null)
                                        m_ClavePersonasFisicas = new ClaveUnica(this.Connection, this.GetFieldValue<int>("clavefis"));
                                return m_ClavePersonasFisicas;
                        }
                }


                public ClaveUnica ClavePersonasJuridicas
                {
                        get
                        {
                                if (m_ClavePersonasJuridicas == null)
                                        m_ClavePersonasJuridicas = new ClaveUnica(this.Connection, this.GetFieldValue<int>("clavejur"));
                                return m_ClavePersonasJuridicas;
                        }
                }

                public Moneda Moneda
                {
                        get
                        {
                                if (m_Moneda == null)
                                        m_Moneda = new Moneda(this.Connection, this.GetFieldValue<int>("id_moneda"));
                                return m_Moneda;
                        }
                }
        }
}
