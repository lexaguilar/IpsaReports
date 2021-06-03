using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IpsaCoreReportsV4.Models
{
    public class ArqueoCajaLista
    {
        public DateTime FechaProceso { get; set; }
        public string Cuenta { get; set; }
        public string NumRecibo { get; set; }
        public string Beneficiario { get; set; }
        public decimal Cordoba { get; set; }
        public decimal Dolar { get; set; }
        public decimal TotalCordoba { get; set; }
    }
}