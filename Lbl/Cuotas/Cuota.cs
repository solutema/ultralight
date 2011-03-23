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

namespace Lbl.Cuotas
{
        [Lbl.Atributos.NombreItem("Cuota"), Lbl.Atributos.MuestraMensajeAlCrear(true), Lbl.Atributos.MuestraPanelExtendido(false)]
	public class Cuota : ElementoDeDatos
	{
                public EstadoCuota[] EstadosCuotas = new EstadoCuota[120];
                private Lbl.Comprobantes.Recibo m_Recibo;
                public Lbl.Personas.Persona Cliente, Comercio;

		//Heredar constructores
		public Cuota(Lfx.Data.Connection dataBase)
                        : base(dataBase)
                {
                        for (int i = 1; i < 120; i++) {
                                EstadosCuotas[i] = new EstadoCuota();
                                EstadosCuotas[i].EstadoCliente = Estados.Nueva;
                                EstadosCuotas[i].EstadoComercio = Estados.Nueva;
                        }
                }

                public Cuota(Lfx.Data.Connection dataBase, int itemId)
                        : base(dataBase, itemId) { }

                public Cuota(Lfx.Data.Connection dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

		public override string TablaDatos
		{
			get
			{
				return "ventas_cuotas";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_cuota";
			}
		}

                public override void Crear()
                {
                        base.Crear();

                        this.Cuotas = 1;
                        this.Fecha = this.Connection.ServerDateTime;

                        for (int i = 1; i < 120; i++) {
                                EstadosCuotas[i] = new EstadoCuota();
                                EstadosCuotas[i].EstadoCliente = Estados.Nueva;
                                EstadosCuotas[i].EstadoComercio = Estados.Nueva;
                        }
                }

                public override Lfx.Types.OperationResult Cargar()
                {
                        Lfx.Types.OperationResult Res = base.Cargar();

                        if (Res.Success == false)
                                return Res;

                        if (this.GetFieldValue<int>("cuota") != 1) {
                                //Busco la primera cuota
                                int RegistroUno = this.Connection.FieldInt("SELECT id_cuota FROM ventas_cuotas WHERE cuota=1 AND prefijo=" + this.GetFieldValue<int>("prefijo").ToString() + " AND operacion=" + this.GetFieldValue<int>("operacion").ToString());
                                //Puede que no exista la cuota 1 (registros importados del sistema viejo)
                                if (RegistroUno > 0) {
                                        m_ItemId = RegistroUno;
                                        return this.Cargar();
                                }
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                //Cargo los estados de las cuotas
                                using (System.Data.DataTable Cuotas = this.Connection.Select("SELECT id_cuota, cuota, estado, estado_com FROM ventas_cuotas WHERE prefijo=" + this.GetFieldValue<int>("prefijo").ToString() + " AND operacion=" + this.GetFieldValue<int>("operacion").ToString())) {
                                        foreach (System.Data.DataRow Cuota in Cuotas.Rows) {
                                                int CuotaNum = System.Convert.ToInt32(Cuota["cuota"]);
                                                EstadosCuotas[CuotaNum] = new EstadoCuota();
                                                EstadosCuotas[CuotaNum].Id = System.Convert.ToInt32(Cuota["id_cuota"]);
                                                EstadosCuotas[CuotaNum].EstadoCliente = (Estados)(System.Convert.ToInt32(Cuota["estado"]));
                                                EstadosCuotas[CuotaNum].EstadoComercio = (Estados)(System.Convert.ToInt32(Cuota["estado_com"]));
                                        }
                                }

                                if (this.GetFieldValue<int>("id_cliente") != 0)
                                        this.Cliente = new Lbl.Personas.Persona(Connection, this.GetFieldValue<int>("id_cliente"));

                                if (this.GetFieldValue<int>("id_comercio") != 0)
                                        this.Comercio = new Lbl.Personas.Persona(Connection, this.GetFieldValue<int>("id_comercio"));
                        }
                        base.OnLoad();
                }


                public Lbl.Comprobantes.Recibo Recibo
                {
                        get
                        {
                                if (m_Recibo == null && this.GetFieldValue<int>("id_recibo") != 0)
                                        this.m_Recibo = new Lbl.Comprobantes.Recibo(Connection, this.GetFieldValue<int>("id_recibo"));
                                return m_Recibo;
                        }
                        set
                        {
                                m_Recibo = value;
                        }
                }

                new public Estados Estado
                {
                        get
                        {
                                throw new InvalidOperationException("No se puede acceder a la propiedad estado de una Operacion. Se debe acceder al estado de cada cuota.");
                        }
                        set
                        {
                                throw new InvalidOperationException("No se puede acceder a la propiedad estado de una Operacion, Se debe acceder al estado de cada cuota.");
                        }
                }

                /// <summary>
                /// Devuelve o establece la fecha en la que se realiza la operación.
                /// </summary>
                public DateTime Fecha
                {
                        get
                        {
                                return System.Convert.ToDateTime(Registro["fecha"]);
                        }
                        set
                        {
                                Registro["fecha"] = value;
                        }
                }

                /// <summary>
                /// Devuelve o establece el vencimiento de la primera cuota. El resto de las cuotas vencen el mismo día de los meses sucesivos.
                /// </summary>
                public DateTime Vencimiento
                {
                        get
                        {
                                return System.Convert.ToDateTime(Registro["vencimiento"]);
                        }
                        set
                        {
                                Registro["vencimiento"] = value;
                        }
                }

                /// <summary>
                /// Devuelve o establece la cantidad de cuotas en las que se paga esta operación.
                /// </summary>
                public int Cuotas
                {
                        get
                        {
                                return this.GetFieldValue<int>("cuotas");
                        }
                        set
                        {
                                if (value < 1 || value > 24)
                                        throw new ArgumentException("El número de cuotas debe estar entre 1 y 24");
                                Registro["cuotas"] = value;

                                // Agrego los estados que faltan
                                for (int Cuota = 1; Cuota <= value; Cuota++) {
                                        if (EstadosCuotas[Cuota] == null)
                                                EstadosCuotas[Cuota] = new Lbl.Cuotas.EstadoCuota();
                                }
                        }
                }

                /// <summary>
                /// Devuelve o establece la cantidad de cuotas que aun no fueron liquidadas al cliente.
                /// </summary>
                public int CuotasPendientesCliente
                {
                        get
                        {
                                int Res = 0;
                                for (int Cuota = 1; Cuota <= this.Cuotas; Cuota++) {
                                        if (this.EstadosCuotas[Cuota].EstadoCliente == Estados.Autorizada || this.EstadosCuotas[Cuota].EstadoCliente == Estados.Nueva)
                                                Res++;
                                }
                                return Res;
                        }
                }

                /// <summary>
                /// Devuelve o establece el número de autorizacón para esta operación.
                /// </summary>
                public int Autorizacion
                {
                        get
                        {
                                return this.GetFieldValue<int>("autorizacion");
                        }
                        set
                        {
                                this.Registro["autorizacion"] = value;
                        }
                }

                /// <summary>
                /// Devuelve o establece el importe total de la operación, incluyendo los intereses.
                /// </summary>
                public decimal ImporteTotal
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("total");
                        }
                        set
                        {
                                if (value < -300000 || value > 300000)
                                        throw new ArgumentException("El importe no puede ser mayor que 300,000.00");
                                Registro["total"] = value;
                                if (ImporteBruto == 0)
                                        ImporteBruto = value;
                        }
                }

                /// <summary>
                /// Devuelve o establece el importe bruto de la operación, sin incluir intereses.
                /// </summary>
                public decimal ImporteBruto
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("total_bruto");
                        }
                        set
                        {
                                Registro["total_bruto"] = value;
                        }
                }

                /// <summary>
                /// Devuelve el monto total de intereses aplicado a esta operación.
                /// </summary>
                public decimal InteresTotal
                {
                        get
                        {
                                return this.ImporteTotal - this.ImporteBruto;
                        }
                }

                /// <summary>
                /// Devuelve el porcentaje de interés total aplicado a esta operación.
                /// </summary>
                public decimal TasaInteresTotal
                {
                        get
                        {
                                if (this.ImporteBruto == 0)
                                        return 0;
                                else
                                        return Math.Round(this.InteresTotal / this.ImporteBruto * 100, 4);
                        }
                }

                public decimal TasaNominalAnual
                {
                        get
                        {
                                if (this.ImporteBruto == 0)
                                        return 0;
                                else
                                        return Math.Round(this.TasaInteresTotal / this.Cuotas * 12, 4);
                        }
                }

                public decimal TasaEfectivaAnual
                {
                        get
                        {
                                return this.TasaNominalAnual;
                        }
                }

                public decimal InteresMensual
                {
                        get
                        {
                                int DifMeses = this.DiferenciaMeses;
                                if (DifMeses >= 1) {
                                        return Math.Round(this.TasaInteresTotal / System.Convert.ToDecimal(this.Cuotas + DifMeses), 4);
                                } else {
                                        // Es una operación normal a 30 días
                                        return Math.Round(this.TasaInteresTotal / System.Convert.ToDecimal(this.Cuotas), 4);
                                }
                        }
                }

                /// <summary>
                /// Devuelve la "diferencia" en las operaciones "diferidas".
                /// </summary>
                public TimeSpan Diferencia
                {
                        get
                        {
                                return this.Vencimiento - this.Fecha;
                        }
                }

                /// <summary>
                /// Devuelve la "diferencia" (en meses) en las operaciones "diferidas".
                /// </summary>
                public int DiferenciaMeses
                {
                        get
                        {
                                return System.Convert.ToInt32(Math.Round(this.Diferencia.TotalDays / 30.41D));
                        }
                }

                /// <summary>
                /// Devuelve la "diferencia" desde hoy (y no desde la fecha de la operación) en las operaciones "diferidas".
                /// </summary>
                public TimeSpan DiferenciaDesdeHoy
                {
                        get
                        {
                                return this.Vencimiento - System.DateTime.Now;
                        }
                }

                /// <summary>
                /// Devuelve la "diferencia" (en meses) desde hoy (y no desde la fecha de la operación) hasta la fecha del primer pago (especialmente para las precancelaciones).
                /// </summary>
                public int DiferenciaMesesDesdeHoy
                {
                        get
                        {
                                return System.Convert.ToInt32(Math.Round(this.DiferenciaDesdeHoy.TotalDays / 30.41D));
                        }
                }

                /// <summary>
                /// Devuelve el monto de la cuota (es el importe total dividido por la cantidad de cuotas).
                /// </summary>
                public decimal ImporteCuota
                {
                        get
                        {
                                if (this.Cuotas == 1)
                                        return this.ImporteTotal;
                                else
                                        // Redondeo hacia abajo (100/6 = 16.66, no 16.67)
                                        return Math.Floor(this.ImporteTotal / this.Cuotas * 100) / 100;
                        }
                }
	}
}
