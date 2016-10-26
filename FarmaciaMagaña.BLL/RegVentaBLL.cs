using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmaciaMagaña.Entities;

namespace FarmaciaMagaña.BLL
{
    public class RegVentaBLL
    {

        RegVenta registro = new RegVenta();
        List<RegVenta> registros = new List<RegVenta>();

        public RegVentaBLL()
        {

        }

        public RegVenta getRegVenta(int Id)
        {

            return registro;
        }

        public List<RegVenta> getAllRegsFromVenta(int IdVenta)
        {

            return registros;
        }

        public bool createRegVenta(RegVenta registro)
        {

            return true;
        }
    }
}
