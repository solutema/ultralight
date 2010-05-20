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

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Lbl.Cuotas
{
	public enum Estados
	{
		Nueva = 0,
                Autorizada = 1,
		Precancelada = 5,
		EnResumen = 10,
                Pagada = 50,
		Anulada = 90,
		Historico = 100
	}

	public class Cuota : ElementoDeDatos
	{
                public Estados[] EstadosCuotas = new Estados[120];
                public Estados[] EstadosCuotasComercio = new Estados[120];
                public Lbl.Comprobantes.Recibo Recibo;
                public Lbl.Personas.Persona Cliente, Comercio;

		//Heredar constructor
		public Cuota(Lws.Data.DataView dataView) : base(dataView)
                {
                        for (int i = 1; i < 120; i++) {
                                EstadosCuotas[i] = Estados.Nueva;
                                EstadosCuotasComercio[i] = Estados.Nueva;
                        }
                }

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

                public override Lfx.Types.OperationResult Crear()
                {
                        Lfx.Types.OperationResult Res = base.Crear();
                        this.Fecha = DateTime.Now;
                        if (Res.Success) {
                                for (int i = 1; i < 120; i++) {
                                        EstadosCuotas[i] = Estados.Nueva;
                                        EstadosCuotasComercio[i] = Estados.Nueva;
                                }
                        }
                        return Res;
                }

                public override Lfx.Types.OperationResult Cargar()
                {
                        if (m_ItemId == 0)
                                return this.Crear();

                        this.m_Registro = null;
                        this.m_RegistroOriginal = null;
                        Lfx.Data.Row Dummy = this.Registro;
                        if (Dummy != null && System.Convert.ToInt32(Dummy["cuota"]) != 1) {
                                //Busco la primera cuota
                                int RegistroUno = this.DataView.DataBase.FieldInt("SELECT id_cuota FROM ventas_cuotas WHERE cuota=1 AND prefijo=" + Dummy["prefijo"].ToString() + " AND operacion=" + Dummy["operacion"].ToString());
                                //Puede que no exista la cuota 1 (registros importados del sistema viejo)
                                if (RegistroUno > 0) {
                                        m_ItemId = RegistroUno;
                                        return this.Cargar();
                                }
                        }

                        //Pongo todos los estados en "histórico" (para los registros que no se encuentran en la consulta siguiente)
                        for (int i = 1; i < 120; i++)
                                EstadosCuotas[i] = Estados.Nueva;
                        //Cargo los estados de las cuotas
                        System.Data.IDataReader Cuotas = this.DataView.DataBase.GetReader("SELECT cuota, estado, estado_com FROM ventas_cuotas WHERE prefijo=" + Dummy["prefijo"].ToString() + " AND operacion=" + Dummy["operacion"].ToString());
                        while (Cuotas.Read()) {
                                EstadosCuotas[System.Convert.ToInt32(Cuotas["cuota"])] = (Estados)(System.Convert.ToInt32(Cuotas["estado"]));
                                EstadosCuotasComercio[System.Convert.ToInt32(Cuotas["cuota"])] = (Estados)(System.Convert.ToInt32(Cuotas["estado_com"]));
                        }
                        Cuotas.Close();

                        if (Dummy == null)
                                return new Lfx.Types.FailureOperationResult("No se pudo cargar el registro");
                        else
                                return new Lfx.Types.SuccessOperationResult();
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (this.FieldInt("id_cliente") != 0)
                                        Cliente = new Lbl.Personas.Persona(DataView, this.FieldInt("id_cliente"), false);

                                if (this.FieldInt("id_comercio") != 0)
                                        Comercio = new Lbl.Personas.Persona(DataView, this.FieldInt("id_comercio"), false);

                                if (this.FieldInt("id_recibo") != 0)
                                        Recibo = new Lbl.Comprobantes.Recibo(DataView, this.FieldInt("id_recibo"));
                        }
                        base.OnLoad();
                }

                public new Estados Estado
                {
                        get
                        {
                                throw new InvalidOperationException("No se puede acceder a la propiedad estado de una Operacion");
                        }
                        set
                        {
                                throw new InvalidOperationException("No se puede acceder a la propiedad estado de una Operacion");
                        }
                }

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

                public int Cuotas
                {
                        get
                        {
                                return this.FieldInt("cuotas");
                        }
                        set
                        {
                                Registro["cuotas"] = value;
                        }
                }

                public int Autorizacion
                {
                        get
                        {
                                return this.FieldInt("autorizacion");
                        }
                        set
                        {
                                this.Registro["autorizacion"] = value;
                        }
                }

                public double ImporteTotal
                {
                        get
                        {
                                return System.Convert.ToDouble(Registro["total"]);
                        }
                        set
                        {
                                Registro["total"] = value;
                                if (ImporteBruto == 0)
                                        ImporteBruto = value;
                        }
                }

                public double ImporteBruto
                {
                        get
                        {
                                return System.Convert.ToDouble(Registro["total_bruto"]);
                        }
                        set
                        {
                                Registro["total_bruto"] = value;
                        }
                }

                public double MontoCuota
                {
                        get
                        {
                                if (this.Cuotas == 1)
                                        return this.ImporteTotal;
                                else
                                        //Redondeo hacia abajo (100/6 = 16.66, no 16.67)
                                        return Math.Floor(this.ImporteTotal / this.Cuotas * 100) / 100;
                        }
                }
	}
}
