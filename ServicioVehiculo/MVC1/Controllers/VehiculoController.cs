using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class VehiculoController : Controller
    {
        //
        // GET: /Vehiculo/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetPosicion()
        {
            ServiceV.VehiculoServiceClient getPosicion = new ServiceV.VehiculoServiceClient();
            string posicion = getPosicion.GetPosicion();
            return Json(posicion, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult PostConfiuracionMatriz(int n, int m)
        {
            ServiceV.VehiculoServiceClient getValidacionConfiguracion = new ServiceV.VehiculoServiceClient();
            string validacion = getValidacionConfiguracion.PostConfiguracion(n, m);
            return Json(validacion, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult PostComandoDesplazamiento(string comando, int n, int m, string posicion)
        {
            ServiceV.VehiculoServiceClient getValidacionComando = new ServiceV.VehiculoServiceClient();
            dynamic modelRtaServicio = getValidacionComando.PostValidarComando(comando, n, m, posicion);
            return Json(modelRtaServicio, JsonRequestBehavior.AllowGet);
        }
    }
}