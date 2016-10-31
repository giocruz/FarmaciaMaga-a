using FarmaciaMagaña.Entities;
using FarmaciaMagaña.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMagaña.BLL
{
    public class ProductosBLL
    {
        Productos producto = new Productos();
        List<Productos> listaProductos = new List<Productos>();
        ProductosDAL productosDAL = new ProductosDAL();

       

        public ProductosBLL()
        {

        }

        public Productos getProducto(int IdProducto)
        {

            return producto;
        }

        public List<Productos> getAllProductos()
        {
            listaProductos = productosDAL.getAllProductos();
            return listaProductos;
        }

        public Boolean createProducto(Productos producto)
        {
           

            Boolean success = productosDAL.createProducto(producto);
            return success;
        }

        public Boolean updateProducto()
        {

            return true;
        }

    }
}
