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

namespace Lfx.Types
{
        public enum DateRangeTypes
        {
                All,
                Day,
                Week,
                Month,
                Range
        }

        public class DateRange
        {
                public string Rep = "*";
                private DateTime m_From, m_To;

                public DateRange(string rep)
                {
                        this.Rep = rep;
                }

                public bool HasRange
                {
                        get
                        {
                                return this.Type != DateRangeTypes.All;
                        }
                }

                public TimeSpan Diff
                {
                        get
                        {
                                TimeSpan Diff = this.To - this.From;
                                return Diff;
                        }
                }

                public DateRangeTypes Type
                {
                        get
                        {
                                switch (this.Rep) {
                                        case "dia-0":
                                        case "dia-1":
                                        case "dia-2":
                                        case "dia-3":
                                        case "dia-4":
                                        case "dia-5":
                                        case "dia":
                                                return DateRangeTypes.Day;

                                        case "semana-0":
                                        case "semana-1":
                                        case "semana-2":
                                        case "semana-3":
                                        case "semana":
                                                return DateRangeTypes.Week;

                                        case "mes-0":
                                        case "mes-1":
                                        case "mes-2":
                                        case "mes-3":
                                        case "mes-4":
                                        case "mes-5":
                                        case "mes-6":
                                        case "mes-7":
                                        case "mes-8":
                                                return DateRangeTypes.Month;

                                        case "*":
                                                return DateRangeTypes.All;

                                        case "-":
                                                return DateRangeTypes.Range;

                                        default:
                                                throw new Exception("DateRange: representación inválida (" + this.Rep + ")");
                                }
                        }
                }

                public DateTime From
                {
                        get
                        {
                                switch(this.Rep) {
                                        case "dia-0":
                                                return DateTime.Now;
                                        case "dia-1":
                                                return DateTime.Now.AddDays(-1);
                                        case "dia-2":
                                                return DateTime.Now.AddDays(-2);
                                        case "dia-3":
                                                return DateTime.Now.AddDays(-3);
                                        case "dia-4":
                                                return DateTime.Now.AddDays(-4);
                                        case "dia-5":
                                                return DateTime.Now.AddDays(-5);
                                        case "dia":
                                                return m_From;

                                        case "semana-0":
                                                return DateTime.Now.AddDays(-((int)(DateTime.Now.DayOfWeek)));

                                        case "semana-1":
                                                return DateTime.Now.AddDays(-((int)(DateTime.Now.DayOfWeek)) - 7);

                                        case "semana-2":
                                                return DateTime.Now.AddDays(-((int)(DateTime.Now.DayOfWeek)) - 14);

                                        case "semana-3":
                                                return DateTime.Now.AddDays(-((int)(DateTime.Now.DayOfWeek)) - 21);

                                        case "semana":
                                                return m_From.AddDays(-((int)(m_From.DayOfWeek)));

                                        case "mes-0":
                                                return new DateTime(DateTime.Now.Year,DateTime.Now.Month, 1);
                                        case "mes-1":
                                                return new DateTime(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month, 1);
                                        case "mes-2":
                                                return new DateTime(DateTime.Now.AddMonths(-2).Year, DateTime.Now.AddMonths(-2).Month, 1);
                                        case "mes-3":
                                                return new DateTime(DateTime.Now.AddMonths(-3).Year, DateTime.Now.AddMonths(-3).Month, 1);
                                        case "mes-4":
                                                return new DateTime(DateTime.Now.AddMonths(-4).Year, DateTime.Now.AddMonths(-4).Month, 1);
                                        case "mes-5":
                                                return new DateTime(DateTime.Now.AddMonths(-5).Year, DateTime.Now.AddMonths(-5).Month, 1);
                                        case "mes-6":
                                                return new DateTime(DateTime.Now.AddMonths(-6).Year, DateTime.Now.AddMonths(-6).Month, 1);
                                        case "mes-7":
                                                return new DateTime(DateTime.Now.AddMonths(-7).Year, DateTime.Now.AddMonths(-7).Month, 1);
                                        case "mes-8":
                                                return new DateTime(DateTime.Now.AddMonths(-8).Year, DateTime.Now.AddMonths(-8).Month, 1);

                                        case "*":
                                                return m_From;

                                        default:
                                                return m_From;
                                }
                        }
                        set
                        {
                                m_From = value;
                        }
                }

                public DateTime To
                {
                        get
                        {
                                switch (this.Rep) {
                                        case "dia-0":
                                        case "dia-1":
                                        case "dia-2":
                                        case "dia-3":
                                        case "dia-4":
                                        case "dia-5":
                                        case "dia":
                                                return this.From;

                                        case "semana-0":
                                        case "semana-1":
                                        case "semana-2":
                                        case "semana-3":
                                        case "semana":
                                                return this.From.AddDays(7);

                                        case "mes-0":
                                        case "mes-1":
                                        case "mes-2":
                                        case "mes-3":
                                        case "mes-4":
                                        case "mes-5":
                                        case "mes-6":
                                        case "mes-7":
                                        case "mes-8":
                                                return new DateTime(this.From.Year, this.From.Month, System.DateTime.DaysInMonth(this.From.Year, this.From.Month));

                                        case "*":
                                                return m_To;

                                        default:
                                                return m_To;
                                }
                        }
                        set
                        {
                                m_To = value;
                        }
                }
        }
}