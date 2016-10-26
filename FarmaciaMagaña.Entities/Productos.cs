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

        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public string Laboratorio { get; set; }
        public int id_Categoria { get; set; }
        public int Status { get; set; }

    }
}
