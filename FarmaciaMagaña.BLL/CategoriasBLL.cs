using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmaciaMagaña.Entities;
using FarmaciaMagaña.DAL;

namespace FarmaciaMagaña.BLL
{
    public class CategoriasBLL
    {
        List<Categoria> todasCategorias;
        CategoriasDAL categoriasdal = new CategoriasDAL();

        public CategoriasBLL()
        {

        }

        public List<Categoria> getAllCategorias()
        {
            todasCategorias = new List<Categoria>();
            todasCategorias = categoriasdal.getAllCategorias();
            return todasCategorias;
        }

        public string nombreCategoria(int id)
        {

            string nombre = categoriasdal.nombreCategoria(id);
            return nombre;
        }

    }
}
