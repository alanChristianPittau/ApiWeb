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

        /// <summary>
        /// Elimina un registro de Auto
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ActionResult Eliminar(int Id)
        {
            AutoDto oAutoVM = new AutoDto();

            TallerServices tallerServices = new TallerServices();
            tallerServices.EliminarAuto(Id);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public ActionResult Alta_Auto(AutoDto oAutoVM)
        {

            TallerServices tallerServices = new TallerServices();

            oAutoVM = tallerServices.Alta_Auto(oAutoVM);
            return RedirectToAction("Index", "Home");

        }
    }
}
