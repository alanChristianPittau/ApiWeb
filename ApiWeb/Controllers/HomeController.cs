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
        ///uuuuuuu
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
        [HttpGet]
        public ActionResult Auto_Detalle(int id)
        {
            AutoDto oAutoVM = new AutoDto();

            TallerServices tallerServices = new TallerServices();
            oAutoVM = tallerServices.Auto_Detalle(id);
            return View(oAutoVM);

        }
    }
}
