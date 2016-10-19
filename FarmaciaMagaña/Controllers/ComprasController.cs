using FarmaciaMagaña.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaMagaña.Controllers
{
    public class ComprasController : Controller
    {
        // GET: Compras
        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Index()
        {
            return View();
        }
    }
}