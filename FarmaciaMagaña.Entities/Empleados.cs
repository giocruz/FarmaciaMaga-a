using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMagaña.Entities
{
    public class Empleados
    {
        public Empleados()
        {

        }

        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string TipoUsuario { get; set; }
        public string Contraseña { get; set; }
        public int Status { get; set; }

    }
}
