using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

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
        public AutoDto Auto_Detalle(int id)
        {

            using (tallerMecanicoEntities db = new tallerMecanicoEntities())

            {
                AutoDto oAutoVM = new AutoDto()
                {
                    oAuto = new AUTO(),

                    oListaTecnico = db.Tecnico.Select(tecnico => new SelectListItem()
                    {
                        Text = tecnico.apellido,
                        Value = tecnico.id.ToString()
                    }).ToList(),
                    oListaEstado = db.Estado.Select(estado => new SelectListItem()
                    {
                        Text = estado.descripcion,
                        Value = estado.id.ToString()
                    }).ToList()

                };
                if (id != 0)
                {
                    oAutoVM.oAuto = db.Auto.Find(id);
                }
                return oAutoVM;

            }
        }
        public AutoDto Alta_Auto(AutoDto oAutoVM)
        {

            using (tallerMecanicoEntities db = new tallerMecanicoEntities())

            {
                if (oAutoVM.oAuto.id == 0)
                {
                    db.Auto.Add(oAutoVM.oAuto);
                }
                else
                {
                    //db.AUTO.Update(oAutoVM.oAuto);
                }
                db.SaveChanges();
                return oAutoVM;

            }
        }
        public void EliminarAuto(int id)
        {
            using (tallerMecanicoEntities db = new tallerMecanicoEntities())

            {
                var oAuto = db.Auto.FirstOrDefault(x => x.id == id);

                db.Auto.Remove(oAuto);
                db.SaveChanges();

            }

        }
    }
}
