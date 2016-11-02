using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FarmaciaMagaña.Entities;
using FarmaciaMagaña.Models;
using FarmaciaMagaña.BLL;
using FarmaciaMagaña.DAL;

namespace FarmaciaMagaña.Controllers
{
    public class CategoriasController : Controller
    {
        List<Categoria> allCategorias;
        CategoriasBLL categoriabll = new CategoriasBLL();


        // GET: Categorias
        public ActionResult Index()
        {
            return View();
        }

        public List<Categoria> getCategorias()
        {
            allCategorias = new List<Categoria>();
            allCategorias = categoriabll.getAllCategorias();
            return allCategorias;
        }
    }
}