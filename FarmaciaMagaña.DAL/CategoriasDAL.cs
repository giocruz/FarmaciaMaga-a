using FarmaciaMagaña.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMagaña.DAL
{


    public class CategoriasDAL
    {

        public List<Categoria> getAllCategorias()
        {
            List<Categoria> todasCategorias = new List<Categoria>();
            Categoria categoria;
            //Creamos un objeto de conexión para la BD, obteniendo la cadena de conexión del archivo web.config del proyecto
            SqlConnection conexionSQL = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ServidorSQL"].ConnectionString);
            //Creamos una sentencia SQL para mandar llamar el Stored Procedure
            SqlCommand comandoSQL = new SqlCommand();
            SqlDataReader reader;

            comandoSQL.CommandText = "getAllCategoria";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Connection = conexionSQL;

            conexionSQL.Open();

            reader = comandoSQL.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //obtenemos para la variable todos los campos por fila
                    categoria = new Categoria();
                    categoria.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    categoria.Nombre = reader.IsDBNull(1) ? null : reader.GetString(1);
                    categoria.Status = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    //Lo agregamos a la lista
                    todasCategorias.Add(categoria);
                }
            }
            else
            {
                Console.WriteLine("Vacío");
            }

            reader.Close();

            conexionSQL.Close();

            return todasCategorias;
        }

        public string nombreCategoria(int id)
        {
            //Creamos un objeto de conexión para la BD, obteniendo la cadena de conexión del archivo web.config del proyecto
            SqlConnection conexionSQL = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ServidorSQL"].ConnectionString);
            //Creamos una sentencia SQL para mandar llamar el Stored Procedure
            SqlCommand comandoSQL = new SqlCommand();
            SqlDataReader reader;
            string nombre = string.Empty;

            comandoSQL.CommandText = "getCategoria";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.AddWithValue("@ID",id);
            comandoSQL.Connection = conexionSQL;

            conexionSQL.Open();

            reader = comandoSQL.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //obtenemos únicamente el nombre y lo asignamos a la string
                    nombre = reader.IsDBNull(1) ? null : reader.GetString(1);
    
                }
            }
            else
            {
                Console.WriteLine("Vacío");
            }

            reader.Close();

            conexionSQL.Close();
            return nombre;
        }
    }
}
