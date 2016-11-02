using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMagaña.Entities
{
    public class Productos
    {
        public Productos()
        {
            Id = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            CostoCompra = 0;
            PrecioVenta = 0;
            Cantidad = 0;
            Laboratorio = string.Empty;
            IDCategoria = 1;
            Status = 1;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public string Laboratorio { get; set; }
        public int IDCategoria { get; set; }
        public int Status { get; set; }

    }
}
