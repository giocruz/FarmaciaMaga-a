using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FarmaciaMagaña.Entities;
using System.Data.SqlClient;

namespace FarmaciaMagaña.DAL
{
    public class ProductosDAL
    {
        //Método tipo booleano para devolver si tuvo éxito o no (aplica para create, delete/recover, update)
        public bool createProducto(Productos ProductoEntitiy)
        { //Recibe un objeto del tipo correspondiente del proyecto Entities

            //Creamos un objeto de conexión para la BD, obteniendo la cadena de conexión del archivo web.config del proyecto
            SqlConnection conexionSQL = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ServidorSQL"].ConnectionString);
            //Creamos una sentencia SQL para mandar llamar el Stored Procedure
            SqlCommand comandoSQL = new SqlCommand();

            //Asignamos el nombre del StoredProcedure
            comandoSQL.CommandText = "createProducto";
            //Especificamos que será un stored Procedure
            comandoSQL.CommandType = CommandType.StoredProcedure;
            //Asignamos que se conectará usando el objeto de conexión previamente creado
            comandoSQL.Connection = conexionSQL;
            //Abrimos la conexión SQL
            conexionSQL.Open();

            //Agregar los parámetros del Stored Procedure (primero nombre del parámetro tal cual está en el StoredProcedure y el valor sacado de
            // la entidad que se recibe en este método (llamada ProductoEntity).
            comandoSQL.Parameters.AddWithValue("@ID", ProductoEntitiy.Id);
            comandoSQL.Parameters.AddWithValue("@Nombre", ProductoEntitiy.Nombre);
            comandoSQL.Parameters.AddWithValue("@Descripcion", ProductoEntitiy.Descripcion);
            comandoSQL.Parameters.AddWithValue("@CostoCompra", ProductoEntitiy.CostoCompra);
            comandoSQL.Parameters.AddWithValue("@PrecioVenta", ProductoEntitiy.PrecioVenta);
            comandoSQL.Parameters.AddWithValue("@Cantidad", ProductoEntitiy.Cantidad);
            comandoSQL.Parameters.AddWithValue("@Laboratorio", ProductoEntitiy.Laboratorio);
            comandoSQL.Parameters.AddWithValue("@IDCategoria", ProductoEntitiy.id_Categoria);
            comandoSQL.Parameters.AddWithValue("@Status", ProductoEntitiy.Status);

            //ejecutamos el comando en un try catch
            try
            {
                //se declara así porque no espera un resultado, solamente se agrega
                comandoSQL.ExecuteNonQuery();
                //Retornar éxito para saber que sí fue agregado el registro.
                return true;
            }catch(Exception exc)
            {
                //Cerrar la conexión en caso de error.
                conexionSQL.Close();
                //Arrojar la excepción para su manejo en el navegador
                throw exc;
                //retornamos false para avisar que hubo un error.
                return false;
            }

            //Cerramos la conexión al finalizar todo
            conexionSQL.Close();
            return true;

        }

        public List<Productos> getAllProductos()
        {
            List<Productos> todosProductos = new List<Productos>();
            Productos productos;
            //Creamos un objeto de conexión para la BD, obteniendo la cadena de conexión del archivo web.config del proyecto
            SqlConnection conexionSQL = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ServidorSQL"].ConnectionString);
            //Creamos una sentencia SQL para mandar llamar el Stored Procedure
            SqlCommand comandoSQL = new SqlCommand();
            SqlDataReader reader;

            comandoSQL.CommandText = "getAllProducto";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Connection = conexionSQL;

            conexionSQL.Open();

            reader = comandoSQL.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //obtenemos para la variable todos los campos por fila
                    productos = new Productos();
                    productos.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    productos.Nombre = reader.IsDBNull(1) ? null : reader.GetString(1);
                    productos.Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2);
                    productos.CostoCompra = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                    productos.PrecioVenta = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                    productos.Cantidad = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                    productos.Laboratorio = reader.IsDBNull(6) ? null : reader.GetString(6);
                    productos.id_Categoria = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                    productos.Status = reader.IsDBNull(8) ? 0 : reader.GetInt32(8); 
                    //Lo agregamos a la lista
                    todosProductos.Add(productos);
                }
            }else
            {
                Console.WriteLine("Vacío");
            }

            reader.Close();

            conexionSQL.Close();

            return todosProductos;
        }
    }
}
