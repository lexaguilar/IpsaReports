using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IpsaCoreReportsV4.Models
{
    public class ArqueoCaja
    {
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }

    public class ArqueoCajaRecibosViewModel
    {
        public ArqueoCaja ArqueoCaja { get; set; }
        public ArqueoCajaLista[] ArqueoCajaLista { get; set; }
    }
}