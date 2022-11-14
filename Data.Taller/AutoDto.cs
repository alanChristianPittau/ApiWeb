using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Data.Taller
{
    public class AutoDto
    {
        public AUTO oAuto { get; set; }
        public List<SelectListItem> oListaTecnico { get; set; }
        public List<SelectListItem> oListaEstado { get; set; }

    }
}
