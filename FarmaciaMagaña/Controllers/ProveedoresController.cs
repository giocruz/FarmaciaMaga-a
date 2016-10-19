using FarmaciaMagaña.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaMagaña.Controllers
{
    public class ProveedoresController : Controller
    {

        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Index()
        {
            return View();
        }

        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Agregar()
        {
            return View();
        }

        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Modificar()
        {
            return View();
        }
    }
}