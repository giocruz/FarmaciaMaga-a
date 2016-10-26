using FarmaciaMagaña.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMagaña.BLL
{
    public class RegCompraBLL
    {

        RegCompra registro = new RegCompra();
        List<RegCompra> registros = new List<RegCompra>();

        public RegCompraBLL()
        {

        }

        public RegCompra getRegCompra(int Id)
        {

            return registro;
        }

        public List<RegCompra> getAllRegsFromCompra(int IdCompra)
        {

            return registros;
        }

        public bool createRegCompra(RegCompra registro)
        {

            return true;
        }
    }
}
