using FarmaciaMagaña.Entities;
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

        public ProductosBLL()
        {

        }

        public Productos getProducto(int IdProducto)
        {

            return producto;
        }

        public List<Productos> getAllProductos()
        {

            return listaProductos;
        }

        public Boolean createProducto(Productos producto)
        {

            return true;
        }

        public Boolean updateProducto()
        {

            return true;
        }

    }
}
