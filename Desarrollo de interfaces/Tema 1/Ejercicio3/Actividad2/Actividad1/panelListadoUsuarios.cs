using Actividad1.mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class panelListadoUsuarios : Form
    {
        public panelListadoUsuarios()
        {
            InitializeComponent();
        }

        private void listado_cuentas_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            String consulta = "Select* from usuarios";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);//adaptamos el resultado
            DataTable tabla = new DataTable();//creamos una tabla
            adaptador.Fill(tabla);
            listado_cuentas_usuarios.DataSource = tabla; //le pasamos la tabla adaptada al grid que se llama "zonalistadoEventos"
            conexion.Cerrar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //aqui listaremos todos los usuarios
            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            String consulta = "Select* from usuarios";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);//adaptamos el resultado
            DataTable tabla = new DataTable();//creamos una tabla
            adaptador.Fill(tabla);
            listado_cuentas_usuarios.DataSource = tabla; //le pasamos la tabla adaptada al grid que se llama "zonalistadoEventos"
            conexion.Cerrar();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //aqui listaremos todos los usuarios administradores
            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            String consulta = "Select* from usuarios where rol='Administrador'";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);//adaptamos el resultado
            DataTable tabla = new DataTable();//creamos una tabla
            adaptador.Fill(tabla);
            listado_cuentas_usuarios.DataSource = tabla; //le pasamos la tabla adaptada al grid que se llama "zonalistadoEventos"
            conexion.Cerrar();

        }

        //creamos una funcion que recoja el ultimo ID del usuario y le sume uno para que sea autoincrementable
        public int verUltimoId()
        {
            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            String consulta = "SELECT id_usuario FROM usuarios ORDER by id_usuario DESC LIMIT 1";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD

            MySqlDataReader reader = comando.ExecuteReader();//ejecutamos el reader 
            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            conexion.Cerrar();
            return id + 1;
        }

        
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int id = verUltimoId();//obtenemos el id
            String rol = "";
            

            //vamos a comprobar el check para que tipo de usuario es
            if (checkAdministrador.Checked)
            {
                rol = "Adminsitrador";
            } else
            {
                rol = "usuario";
            }


            //si el usuario y la contraseña estan vacios que muestre la alerta de que son obligatorios y que la contraseña tenga minimo 6 caracteres
            if ((escribeEmail.Text == null && escribeContraseña.Text == null) || escribeContraseña.TextLength>6)//si email y contraseña son nulos o la contraseña tien menos de 6 caracteres...
            {
                validacionEmail.Show();
                validacionContraseña.Show();
                minimoCaracteres.Show();
                
            }
            else
            {

                conexionbd conexion = new conexionbd();
                conexion.Abrir();
                string consulta = "insert into usuarios (id_usuario, nombre, apellido, email, edad, rol, contraseña) values (" + id + ", @nombre, @apellido, @email, @edad,@rol, @contraseña)";//definimos que queremos consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD

                //definimos los campos que recogemos
                comando.Parameters.AddWithValue("@nombre", escribeNombre.Text);
                comando.Parameters.AddWithValue("@apellido", escribeApellido.Text);
                comando.Parameters.AddWithValue("@edad", escribeEdad.Text);
                comando.Parameters.AddWithValue("@email", escribeEmail.Text);
                comando.Parameters.AddWithValue("@contraseña", escribeContraseña.Text);
                comando.Parameters.AddWithValue("@rol", rol);

                comando.Connection = conexion.conectarbd;
                comando.ExecuteNonQuery();
                conexion.Cerrar();

                //ahora vamos a hacer que se oculte esta ventana para volverla a cargar para que se reflejen los cambios
                this.Hide();//ocultamos este formulario
                Form ir_a_listadoUsuarios = new panelListadoUsuarios();
                ir_a_listadoUsuarios.Show();

            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

                String idEliminar = eliminarID.Text;
                conexionbd conexion = new conexionbd();
                conexion.Abrir();
                string consulta = "DELETE FROM usuarios where id_usuario=" + idEliminar + ";";//definimos que id queremos eliminar
                MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
                comando.Connection = conexion.conectarbd;
                comando.ExecuteNonQuery();
                conexion.Cerrar();

                //ahora vamos a hacer que se oculte esta ventana para volverla a cargar para que se reflejen los cambios
                this.Hide();//ocultamos este formulario
                Form ir_a_listadoUsuarios = new panelListadoUsuarios();
                ir_a_listadoUsuarios.Show();
            }

        private void panelListadoUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
    }
}
