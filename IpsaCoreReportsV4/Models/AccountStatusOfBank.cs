using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IpsaCoreReportsV4.Models
{
    public class AccountStatusOfBank
    {
        public DateTime Fecha { get; set; }
        public bool ck { get; set; }
        public string _Fecha { get; set; }
        public string Referencia { get; set; }
        public int TipoMovimientoId { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal Debito { get; set; }

        public decimal Credito { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; }

        public string UUID { get; set; }
        public string TipoDocumento { get; set; }
        public bool IsNew { get; set; }
        public string EstadoRegistro { get; set; }

        /// <summary>
        /// Id de la tabla conciliacion bancara, trae valor el id cuando es una valor arrastrado para poder actualizarlo, sino en 0
        /// </summary>
        public int Id { get; set; }
    }
}