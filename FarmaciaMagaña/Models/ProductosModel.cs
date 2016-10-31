using FarmaciaMagaña.BLL;
using FarmaciaMagaña.DAL;
using FarmaciaMagaña.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FarmaciaMagaña.Models
{
    public class ProductosModel
    {
        public ProductosModel()
        {
            Id = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            CostoCompra = 0;
            PrecioVenta = 0;
            Cantidad = 0;
            Laboratorio = string.Empty;
            id_Categoria = 0;
            Status = 0;
        }

        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display (Name = "Nombre")]
        public string Nombre { get; set; }
        [Display (Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display (Name = "Costo de compra")]
        public decimal CostoCompra { get; set; }
        [Display (Name = "Precio de venta al público")]
        public decimal PrecioVenta { get; set; }
        [Display (Name = "Existencia")]
        public int Cantidad { get; set; }
        [Display (Name = "Laboratorio de origen")]
        public string Laboratorio { get; set; }
        [Display (Name = "Categoría")]
        public int id_Categoria { get; set; }
        public int Status { get; set; }


        public static List<ProductosModel> listaProductos(List<Productos> productos)
        {
            List<ProductosModel> allProductos = new List<ProductosModel>();

            foreach ( var entity in productos)
            {
                allProductos.Add(prepararProducto(entity));
            }

            return allProductos;
        }

        public static ProductosModel prepararProducto(Productos producto)
        {
            ProductosBLL productosbll = new ProductosBLL();
            BaseDeDatos BDcontexto = new BaseDeDatos();
            ProductosModel productosModel;

            productosModel = new ProductosModel();
            productosModel.Id = producto.Id;
            productosModel.Descripcion = producto.Descripcion;
            productosModel.Nombre = producto.Nombre;
            productosModel.CostoCompra = producto.CostoCompra;
            productosModel.PrecioVenta = producto.PrecioVenta;
            productosModel.Cantidad = producto.Cantidad;
            productosModel.Laboratorio = producto.Laboratorio;
            productosModel.id_Categoria = producto.id_Categoria;
            productosModel.Status = producto.Status;


            return productosModel;
        }
    }
}