using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmaciaMagaña.Entities;

namespace FarmaciaMagaña.DAL
{
    public class VentasDAL
    {
        Ventas venta = new Ventas();
        List<Ventas> ventas = new List<Ventas>();

        public VentasDAL()
        {

        }

        public List<Ventas> getAllVentas()
        {

            return ventas;
        } 

        public Ventas getVenta(int idVenta)
        {

            return venta;  
        }

        public Boolean createVenta(Ventas venta)
        {

            return true;
        }



        public Boolean deleteVenta(int idVenta)
        {

            return true;
        }
    }
}
