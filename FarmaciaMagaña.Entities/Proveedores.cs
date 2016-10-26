using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMagaña.Entities
{
    public class Proveedores
    {

        public Proveedores()
        {

        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string Correo { get; set; }
        public int Status { get; set; }

    }
}
