using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Taller
{
    public class TallerDataServices
    {
        private tallerMecanicoEntities Context = new tallerMecanicoEntities();
        public List<AUTO> obtenerAutos()
        {

            using (tallerMecanicoEntities db = new tallerMecanicoEntities())

            {
                List<AUTO> lista = db.Auto.Include("ESTADO").Include("TECNICO").ToList();
                return lista;

            }
        }
    }
}
