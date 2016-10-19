using FarmaciaMagaña.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaMagaña.Controllers
{
    public class HomeController : Controller
    {

        [AuthLog(Roles = "Sistema, Administrador, Empleado")]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }


       
    }
}