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

    }
}
