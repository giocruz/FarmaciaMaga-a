using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMagaña.Entities
{
    public class Compras
    {

        public Compras()
        {

        }

        public int Id { get; set; }
        public int Id_Proveedor { get; set; }
        public decimal TotalCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int Status { get; set; }
    }
}
