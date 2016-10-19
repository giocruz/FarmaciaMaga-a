using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FarmaciaMagaña.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using FarmaciaMagaña.CustomFilters;

namespace FarmaciaMagaña.Models
{
    public class RoleController : Controller
    {
        ApplicationDbContext contexto;
        
        public RoleController()
        {
            contexto = new ApplicationDbContext();
        }


        [AuthLog(Roles = "Administrador")]
        [AuthLog(Roles = "Sistema")]
        //[AllowAnonymous]
        public ActionResult Index()
        {
            var Roles = contexto.Roles.ToList();
            return View(Roles);
        }


        [AuthLog(Roles = "Administrador")]
        [AuthLog(Roles = "Sistema")]
        //[AllowAnonymous]
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }


        [AuthLog(Roles = "Administrador")]
        [AuthLog(Roles = "Sistema")]
        //[AllowAnonymous]
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            contexto.Roles.Add(Role);
            contexto.SaveChanges();
            return RedirectToAction("Index","Home");
        }

    }
}