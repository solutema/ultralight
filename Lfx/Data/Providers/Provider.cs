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

using System.Data;
using System.Reflection;

namespace qGen.Providers
{
        /// <summary>
        /// Representa un proveedor ADO.NET, el cual se carga en tiempo de ejecución a través de System.Reflection para no
        /// agregar dependencias en tiempo de diseño. La única dependencia en tiempo de diseño es System.Data.Odbc.
        /// </summary>
        public abstract class Provider : IProvider
        {
                public string AssemblyName = null;
                public string NameSpace = null;
                public string ConnectionClass = null;
                public string CommandClass = null;
                public string AdapterClass = null;
                public string ParameterClass = null;
                public string TransactionClass = null;

                public ProviderSettings Settings { get; set; }

                protected internal Assembly m_Assembly = null;

                public Provider(string assemblyName, string nameSpace, string connectionClass, string commandClass, string adapterClass, string parameterClass, string transactionClass)
                {
                        this.AssemblyName = assemblyName;
                        this.NameSpace = nameSpace;
                        this.ConnectionClass = connectionClass;
                        this.CommandClass = commandClass;
                        this.AdapterClass = adapterClass;
                        this.ParameterClass = parameterClass;
                        this.TransactionClass = transactionClass;
                }

                protected Assembly Assembly
                {
                        get
                        {
                                if (m_Assembly == null) {
                                        if (System.IO.File.Exists(Lfx.Environment.Folders.ApplicationFolder + this.AssemblyName + ".dll"))
                                                m_Assembly = Assembly.LoadFrom(Lfx.Environment.Folders.ApplicationFolder + this.AssemblyName + ".dll");
                                        else if (System.IO.File.Exists(this.AssemblyName + ".dll"))
                                                m_Assembly = Assembly.LoadFrom(this.AssemblyName + ".dll");
                                        else
                                                throw new System.IO.FileNotFoundException("No se encuentra " + this.AssemblyName + ".dll");
                                }
                                return m_Assembly;
                        }
                }

                public virtual IDbConnection GetConnection()
                {
                        return ((System.Data.IDbConnection)(this.Assembly.CreateInstance(this.NameSpace + "." + this.ConnectionClass)));
                }

                public virtual IDbCommand GetCommand()
                {
                        return ((System.Data.IDbCommand)(this.Assembly.CreateInstance(this.NameSpace + "." + this.CommandClass)));
                }

                public virtual IDbDataAdapter GetAdapter(string commandText, IDbConnection connection)
                {
                        object[] Params = new object[] { commandText, connection };
                        return ((System.Data.IDbDataAdapter)(this.Assembly.CreateInstance(this.NameSpace + "." + this.AdapterClass, false, BindingFlags.Default, null, Params, System.Globalization.CultureInfo.CurrentCulture, null)));
                }

                public virtual IDbDataParameter GetParameter()
                {
                        return ((System.Data.IDbDataParameter)(this.Assembly.CreateInstance(this.NameSpace + "." + this.ParameterClass)));
                }
        }
}
