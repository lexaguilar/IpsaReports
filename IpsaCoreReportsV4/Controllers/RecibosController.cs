using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using IpsaCoreReportsV4.Models;
using IpsaCoreReportsV4.Reportes;

namespace IpsaCoreReportsV4.Controllers
{
    public class RecibosController : Controller
    {
        //
        // GET: /Recibos/

        public ActionResult Index()
        {
            var host = ConfigurationManager.AppSettings["host"];
            var url = ConfigurationManager.AppSettings["url"];
            HttpClient client = new HttpClient() { BaseAddress = new Uri(host) };
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var lista = response.Content.ReadAsAsync<List<ReciboGeneralViewModel>>().Result;
                var r = new xrRecibosConMonedaErronea()
                {
                    DataSource = lista
                };
                return View("RecibosMalIngresadosBancoMoneda", r);
            }
         
            return View();
        }

        
        //public ActionResult ConciliacionBanco(int id)
        //{
        //    var host = ConfigurationManager.AppSettings["host"];
        //    var url = ConfigurationManager.AppSettings["getConciliacionProcesoBanco"];
        //    HttpClient client = new HttpClient() { BaseAddress = new Uri(host) };
        //    HttpResponseMessage response = client.GetAsync(url+"/"+id).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var lista = response.Content.ReadAsAsync<AuxiliarAndBanco>().Result;
        //        var r = new EstadoCuentaBanco()
        //        {
        //            DataSource = lista.banco
        //        };
        //        r.Parameters["CuentaBancaria"].Value = lista.CuentaBancaria.Trim();
        //        r.Parameters["CuentaBancaria"].Visible = false;
        //        r.Parameters["Descripcion"].Value = lista.Descripcion;
        //        r.Parameters["Descripcion"].Visible = false;
        //        return View("StatusBankAccount", r);
        //    }

        //    return View();
        //}
        public ActionResult ConciliacionLibro(int id)
        {
            var host = ConfigurationManager.AppSettings["host"];
            var url = ConfigurationManager.AppSettings["getConciliacionProcesoLibro"];
            HttpClient client = new HttpClient() { BaseAddress = new Uri(host) };
            HttpResponseMessage response = client.GetAsync(url + "/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var lista = response.Content.ReadAsAsync<AuxiliarAndBanco>().Result;
                var r = new LibroAuxiliar()
                {
                    DataSource = lista.auxiliar
                };
                r.Parameters["CuentaBancaria"].Value = lista.CuentaBancaria.Trim();
                r.Parameters["CuentaBancaria"].Visible = false;
                r.Parameters["Descripcion"].Value = lista.Descripcion;
                r.Parameters["Descripcion"].Visible = false;
                return View("LibroAuxiliar", r);
            }

            return View();
        }

        
    }
}
