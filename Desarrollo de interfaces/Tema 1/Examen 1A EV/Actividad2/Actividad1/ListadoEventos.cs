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

        //creamos una funcion que recoja el ultimo ID del evento y le sume uno para que sea autoincrementable
        public int verUltimoId()
        {
            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            String consulta = "SELECT id_evento FROM evento ORDER by id_evento DESC LIMIT 1";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD

            MySqlDataReader reader = comando.ExecuteReader();//ejecutamos el reader 

            int id = 0;

            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            conexion.Cerrar();
            return id +1;
        }
        private void añadirEvento_MouseClick(object sender, MouseEventArgs e)
        {
            //vamos a hacer que si los campos estan vacios salte un mensaje de error
            if (escribeDia.Text == "")
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

                    int id = verUltimoId();
                    conexionbd conexion = new conexionbd();
                    conexion.Abrir();
                    string consulta = "insert into evento (id_evento, dia, hora, equipo_local, equipo_visitante, Fecha) values ("+id+", @dia, @hora, @equipoLocal, @equipoVisitante, @fecha)";//definimos que queremos consulta
                    MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD

                    comando.Parameters.AddWithValue("@dia", escribeDia.Text);
                    comando.Parameters.AddWithValue("@hora", escribeHora.Text);
                    comando.Parameters.AddWithValue("@equipoLocal", escribeEquipoLocal.Text);
                    comando.Parameters.AddWithValue("@equipoVisitante", EscribeEquipoVisitante.Text);
                    comando.Parameters.AddWithValue("@fecha", escribeFecha.Text);

                    comando.Connection = conexion.conectarbd;
                    comando.ExecuteNonQuery();
                    conexion.Cerrar();

                }
                catch(MySqlException)
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

            String idEliminar = eliminarID.Text;
            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            string consulta = "DELETE FROM evento where id_evento="+ idEliminar +";";//definimos que id queremos eliminar
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void vistaDeLosMercados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void vistaListadoMercados_Load(object sender, EventArgs e)
        {
            
        }

        private void vistaDeLosMercados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            String idEvento = IdEventoFiltrado.Text;
            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            String consulta = "Select* from evento where id_evento='"+ idEvento +"'";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);//adaptamos el resultado
            DataTable tabla = new DataTable();//creamos una tabla
            adaptador.Fill(tabla);
            buscarEvento.DataSource = tabla; //le pasamos la tabla adaptada al grid que se llama "zonalistadoEventos"
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
