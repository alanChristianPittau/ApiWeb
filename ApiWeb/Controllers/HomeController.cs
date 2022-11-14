using Data.Taller;
using Services.Taller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiWeb.Controllers
{   
    
    /// <summary>
     /// Obtenemos el path del archivo XML de documentacion
     /// </summary>
     /// <returns></returns>
    public class HomeController : Controller
    {

        /// <summary>
        /// Obtenemos el path del archivo XML de documentacion
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public ActionResult Index()
        {
            TallerServices tallerServices = new TallerServices();

            List<AUTO> auto = tallerServices.obtenerAutos();
            return View(auto);
        }
    }
}
