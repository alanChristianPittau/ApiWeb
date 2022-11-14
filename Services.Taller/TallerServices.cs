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
    }
}
