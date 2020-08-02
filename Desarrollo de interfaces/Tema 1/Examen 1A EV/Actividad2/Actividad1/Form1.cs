using Actividad1.mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{

    public partial class ventanaLogin : Form
    {
        public ventanaLogin()
        {
            InitializeComponent();
        }
        //en esta función creamos el login una vez se pulse el botón
        private void Entrar_MouseClick(object sender, MouseEventArgs e){}

        private void ventanaLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //primero vamos a hacer la consulta con el correo que hemos puesto

            conexionbd conexion = new conexionbd();
            conexion.Abrir();

            String consulta = "select email, contraseña,rol from usuarios where email='" + ponerUsuario.Text + "'";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD

            MySqlDataReader reader = comando.ExecuteReader();//ejecutamos el reader 

            String email = "";
            String contraseña = "";
            String rol = "";

            while (reader.Read())
            {
                email = reader.GetString(0);
                contraseña = reader.GetString(1);
                rol = reader.GetString(2);
            }

            reader.Close();

            //vamos a comparar los campos del usuario que hemos puesto



            if ((email == ponerUsuario.Text) && (contraseña == ponerContraseña.Text) && (rol == "Administrador"))
            {
                Form ir_a_menu = new menuAdministrador(); //creo el objeto de tipo "menu administrador"
                ir_a_menu.Show();//mostramos el menu
                this.Hide();//ocultamos este formulario que es el login
            }
            else
            {
                MessageBox.Show("El usuario es incorrecto o no es administrador");
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
