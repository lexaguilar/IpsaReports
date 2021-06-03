using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IpsaCoreReportsV4.Models
{
    public class ReciboGeneralViewModel
    {
        public string NumRecibo { get; set; }
        public string Caja { get; set; }
        public string Username { get; set; }
        public string Beneficiario { get; set; }
        public string Moneda { get; set; }
        public string Banco { get; set; }
        public DateTime FechaProceso { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}