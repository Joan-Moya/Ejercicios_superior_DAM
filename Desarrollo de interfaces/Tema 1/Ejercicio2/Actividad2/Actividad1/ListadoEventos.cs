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
    public partial class ListadoEventos : Form
    {
        public ListadoEventos()
        {
            InitializeComponent();
        }

        private void ListadoEventos_Load(object sender, EventArgs e) 
        {

            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            String consulta = "Select* from evento";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);//adaptamos el resultado
            DataTable tabla = new DataTable();//creamos una tabla
            adaptador.Fill(tabla);
            zonaListadoEventos.DataSource = tabla; //le pasamos la tabla adaptada al grid que se llama "zonalistadoEventos"
            conexion.Cerrar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void añadirEvento_MouseClick(object sender, MouseEventArgs e)
        {
            //vamos a hacer que si los campos estan vacios salte un mensaje de error
            if (escribeDia.Text == " ")
            {
                Console.Out.WriteLine("El dia no puede estar vacio");

            }
            else if (escribeDia.Text == "")
            {
                Console.Out.WriteLine("El dia no puede estar vacio");

            }
            else if (escribeHora.Text == "")
            {
                Console.Out.WriteLine("La hora no puede estar vacia");

            }
            else if (escribeEquipoLocal.Text == "")
            {
                Console.Out.WriteLine("El equipo local no puede estar vacio");

            }
            else if (EscribeEquipoVisitante.Text == "")
            {
                Console.Out.WriteLine("El equipo Visitante no puede estar vacio");

            }
            else
            {
                try
                {
                    conexionbd conexion = new conexionbd();
                    conexion.Abrir();
                    string consulta = "insert into evento values (" + escribeId.Text + ", " + escribeDia.Text + ", " + escribeHora.Text + ", '" + escribeEquipoLocal.Text + "', '" + EscribeEquipoVisitante.Text + "')";//definimos que queremos consultar
                    MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
                    comando.Connection = conexion.conectarbd;
                    comando.ExecuteNonQuery();
                    conexion.Cerrar();

                }catch(MySqlException)
                {
                    MessageBox.Show("Error de conxión");
                }

                //ahora vamos a hacer que se oculte esta ventana para volverla a cargar para que se reflejen los cambios
                this.Hide();//ocultamos este formulario
                Form ir_a_listadoEventos = new ListadoEventos(); //creo el objeto de tipo "listadoEventos"
                ir_a_listadoEventos.Show();//mostramos la pestaña donde se listaran los Eventos

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void eliminarID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            try { 

            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            string consulta = "DELETE FROM evento where id_evento="+ eliminarID.Text +";";//definimos que id queremos eliminar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
            comando.Connection = conexion.conectarbd;
            comando.ExecuteNonQuery();
            conexion.Cerrar();

            }catch(MySqlException)
            {
                   MessageBox.Show("Error de conexión");
            }

            //ahora vamos a hacer que se oculte esta ventana para volverla a cargar para que se reflejen los cambios
            this.Hide();//ocultamos este formulario
            Form ir_a_listadoEventos = new ListadoEventos(); //creo el objeto de tipo "listadoEventos"
            ir_a_listadoEventos.Show();//mostramos la pestaña donde se listaran los Eventos
        }
    }
}
