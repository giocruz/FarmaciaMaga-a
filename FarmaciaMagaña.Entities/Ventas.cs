using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMagaña.Entities
{
    public class Ventas
    {

        public Ventas()
        {

        }

        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Usuario { get; set; }
        public int Status { get; set; }
    }
}
