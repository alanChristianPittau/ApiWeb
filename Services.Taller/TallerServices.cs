using Data.Taller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Taller
{
    public class TallerServices
    {
        public List<AUTO> obtenerAutos()
        {
            TallerDataServices tallerDataService = new TallerDataServices();

            return tallerDataService.obtenerAutos();
        }
        public AutoDto Auto_Detalle(int id)
        {
            TallerDataServices tallerDataService = new TallerDataServices();

            return tallerDataService.Auto_Detalle(id);
        }
        public void EliminarAuto(int id)
        {
            TallerDataServices tallerDataService = new TallerDataServices();

            tallerDataService.EliminarAuto(id);
        }
        public AutoDto Alta_Auto(AutoDto oAutoVM)
        {
            TallerDataServices tallerDataService = new TallerDataServices();

            return tallerDataService.Alta_Auto(oAutoVM);
        }
    }
}
