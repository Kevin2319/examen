using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetAuto(string id)
        {
            try
            {
                Models.Logica logica = new Models.Logica();
                Models.AUTOMOVIL atri = logica.auto(id);
                return Json(new { status = true, Items = atri }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult GetCP(string id)
        {
            try
            {
                Models.Logica logica = new Models.Logica();
                Models.DIRECCIONES atri = logica.codigo(id);
                return Json(new { status = true, Items = atri }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Insert(Models.ADMINISTRADOR ObjContrato)
        {
            
            try
            {
                Models.Logica model = new Models.Logica();
                model.InsertCoche(ObjContrato);

                return Json(new { status = true, message = "Exito" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { status = false, message = "Ocurrio un Error, vuelva a intentarlo" }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}