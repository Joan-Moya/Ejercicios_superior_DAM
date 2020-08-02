using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Actividad1.mysql
{
    class conexionbd
    {
        
        string cadena = "server=localhost; Database=apuestas; Uid=root; password=root;";//creamos la sentencia para la conexion
        public MySqlConnection conectarbd = new MySqlConnection();//creamos objeto para conectar


        public conexionbd()//creamos la funcion para conectar a la base de datos
        {
            conectarbd.ConnectionString = cadena;//hacemos conexion a la base de datos
        }
        public void Abrir()//notificamos si se ha abierto la conexion con exito
        {
            try{
                conectarbd.Open();
                Console.WriteLine("Conexion abierta");
            }catch(Exception ex)
            {
                Console.WriteLine("Error al abrir base de datos");
            }
        }
        public void Cerrar()//con esta clase cerramos la base de datos
        {
            conectarbd.Close();
        }
    }
}
