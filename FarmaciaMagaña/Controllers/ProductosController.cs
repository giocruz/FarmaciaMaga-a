using FarmaciaMagaña.BLL;
using FarmaciaMagaña.CustomFilters;
using FarmaciaMagaña.Entities;
using FarmaciaMagaña.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaMagaña.Controllers
{
    public class ProductosController : Controller
    {

        ProductosBLL productosBLL = new ProductosBLL();
        Productos producto = new Productos();

        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Index()
        {
            return View();
        }

        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Agregar()
        {
            //producto.Id = 101010;
            //producto.Nombre = "Pepto Bismol";
            //producto.Laboratorio = "El Tacuache";
            //producto.id_Categoria = 2;
            //producto.PrecioVenta = 49.00M;
            //producto.CostoCompra = 30.50M;
            //producto.Status = 1;
            //producto.Cantidad = 2;
            //producto.Descripcion = "Pal chorriento de Giovani";
            productosBLL.createProducto(producto);
            return View();
        }

        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Modificar()
        {
            return View();
        }

        [AuthLog(Roles = "Sistema, Administrador, Empleado")]
        public ActionResult Inventario()
        {
            List<ProductosModel> allProductosModel = new List<ProductosModel>();

            allProductosModel = ProductosModel.listaProductos(productosBLL.getAllProductos());

            return View("Inventario", allProductosModel);
        }


        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Papelera()
        {
            return View();
        }

        [AuthLog(Roles ="Sistema, Administrador")]
        public ActionResult Categorias()
        {
            return View();
        }

    }
}