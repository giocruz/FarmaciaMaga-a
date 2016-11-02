using FarmaciaMagaña.BLL;
using FarmaciaMagaña.CustomFilters;
using FarmaciaMagaña.Entities;
using FarmaciaMagaña.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FarmaciaMagaña.DAL;

namespace FarmaciaMagaña.Controllers
{
    public class ProductosController : Controller
    {

        ProductosBLL productosBLL = new ProductosBLL();
        CategoriasBLL categoriasBLL = new CategoriasBLL();
        Productos producto;
        private BaseDeDatos BD = new BaseDeDatos();

        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Index()
        {
            return View();
        }

        [AuthLog(Roles = "Sistema, Administrador")]
        public ActionResult Agregar()
        {
            //Armar una lista de categorias para el dropdown
            var categorias = categoriasBLL.getAllCategorias();
            List<SelectListItem> listaCategorias = new List<SelectListItem>();
            SelectListItem itemCategoria;
            

            foreach(var c in categorias)
            {
                itemCategoria = new SelectListItem();
                itemCategoria.Value = Convert.ToString(c.Id);
                itemCategoria.Text = c.Nombre;
                listaCategorias.Add(itemCategoria);
            }

            ViewBag.Categorias = listaCategorias;
            //productosBLL.createProducto(producto);
            return View("Agregar");
        }

        //Crear un nuevo producto
        [AuthLog(Roles = "Sistema, Administrador")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarProducto([Bind(Include = "ID,Nombre,Descripcion,CostoCompra,PrecioVenta,Cantidad,Laboratorio,IDCategoria")] ProductosModel productoModel)
        {
            //Es un método que recibe un objeto de tipo producto tipo modelo (agregar el Model al final del nombre)
            if (ModelState.IsValid)
            {
                //Creamos un objeto producto pero del tipo Entity (entidad) para que la BD lo pueda manejar
                Productos productoEntity = new Productos();
                //pasamos los parámetros del modelo a la entidad:
                productoEntity.Id = productoModel.Id;
                productoEntity.Nombre = productoModel.Nombre;
                productoEntity.Descripcion = productoModel.Descripcion;
                productoEntity.CostoCompra = productoModel.CostoCompra;
                productoEntity.PrecioVenta = productoModel.PrecioVenta;
                productoEntity.Cantidad = productoModel.Cantidad;
                productoEntity.Laboratorio = productoModel.Laboratorio;
                productoEntity.IDCategoria = productoModel.IDCategoria;

                //llamamos la lógica de negocios de Producto para mandar guardar el producto. Obvio pasándole la entidad como parámetro
                productosBLL.createProducto(productoEntity);
                //Hacemos que nos redirija al inventario
                return RedirectToAction("Inventario");
            }


            return View(productoModel);

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