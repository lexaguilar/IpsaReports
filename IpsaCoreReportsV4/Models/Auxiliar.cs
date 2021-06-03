using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IpsaCoreReportsV4.Models
{
    public class Auxiliar
    {
        public Auxiliar()
        {
            Estado = "Pendiente";
            EstadoId = -1;
            ck = false;
        }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        public int CajaId { get; set; }
        public string NumRecibo { get; set; }
        public int IdOrigen { get; set; }
        public int IdRef { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; }
        public bool ck { get; set; }
        public int TipoDocumento { get; set; }
        public string ID { get; set; }
        public int TipoMovimientoId { get; set; }
        public string TipoMovimiento { get; set; }
        public string UUID { get; set; }
        /// <summary>
        /// 1 si es de caja y 2 si es de banco para saber donde actualizaremos el regostro cuando se guarde la conciliacion
        /// </summary>
        public int TableInfo { get; set; }
        public string Caja { get; set; }
        public bool IsNew { get; set; }
        /// <summary>
        /// Id de la tabla conciliacion bancara, trae valor el id cuando es una valor arrastrado para poder actualizarlo, sino en 0
        /// </summary>
        public int Id { get; set; }
        public string EstadoRegistro { get; set; }
    }

    public class AuxiliarAndBanco
    {
        public string CuentaBancaria { get; set; }
        public string Descripcion { get; set; }
        public List<Auxiliar> auxiliar { get; set; }
        public List<EstadoCuentaBancoModel> banco { get; set; }
    }
}