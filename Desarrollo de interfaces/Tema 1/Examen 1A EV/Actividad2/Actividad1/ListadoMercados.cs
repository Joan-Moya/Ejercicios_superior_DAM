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
    public partial class ListadoMercados : Form
    {
        public ListadoMercados()
        {
            InitializeComponent();
        }

        private void ListadoMercados_Load(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            String consulta = "Select* from mercados";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);//adaptamos el resultado
            DataTable tabla = new DataTable();//creamos una tabla
            adaptador.Fill(tabla);
            zonaListadoMercados.DataSource = tabla; //le pasamos la tabla adaptada al grid que se llama "zonalistadoEventos"

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void añadirMercado_Click(object sender, EventArgs e)
        {
            try
            {

                /*
                conexionbd conexion = new conexionbd();
                conexion.Abrir();
                string consulta = "insert into mercados values ('" + escribeTipoMercado.Text + "'," + escribeInformacionCuotaOver.Text + ", " + escribeInformacionCuotaUnder.Text + ", " + escribeDineroApostadoOver.Text + ", " + escribeDineroApostadoUnder.Text + ", " + escribeIdMercado.Text + ", " + escribeIdEvento.Text + ")";//definimos que queremos consultar
                MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
                comando.Connection = conexion.conectarbd;
                comando.ExecuteNonQuery();
                conexion.Cerrar();
                */
                
               

                conexionbd conexion = new conexionbd();
                conexion.Abrir();
                string consulta = "insert into mercados (tipo_de_mercado, informacion_cuota_under, informacion_cuota_over, dinero_apostado_a_under, dinero_apostado_over, id_mercado, id_evento)  values (@tipoDeMercado, @informacionCuotaUnder ,@informacionCuotaOver, @dineroApostadoUnder, @dineroApostadoOver, @idMercado, @idEvento)";//definimos que queremos consultar
                MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD

                comando.Parameters.AddWithValue("@tipoDeMercado", escribeTipoMercado.Text);
                comando.Parameters.AddWithValue("@informacionCuotaOver", escribeInformacionCuotaOver.Text);
                comando.Parameters.AddWithValue("@informacionCuotaUnder", escribeInformacionCuotaUnder.Text);
                comando.Parameters.AddWithValue("@dineroApostadoUnder", escribeDineroApostadoUnder.Text);
                comando.Parameters.AddWithValue("@dineroApostadoOver", escribeDineroApostadoOver.Text);
                comando.Parameters.AddWithValue("@idMercado", escribeIdMercado.Text);
                comando.Parameters.AddWithValue("@idEvento", escribeIdEvento.Text);
                
                 

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conxión");
            }

            //ahora vamos a hacer que se oculte esta ventana para volverla a cargar para que se reflejen los cambios
            this.Hide();//ocultamos este formulario
            Form ir_a_listadoMercados = new ListadoMercados(); //creo el objeto de tipo "listadoMercados"
            ir_a_listadoMercados.Show();//mostramos la pestaña donde se listaran los Mercados
        }

        private void botonEliminarMercado_Click(object sender, EventArgs e)
        {
            try
            {
                String eliminarId = escribeEliminarId.Text;
                conexionbd conexion = new conexionbd();
                conexion.Abrir();
                string consulta = "DELETE FROM mercados where id_mercado=" + eliminarId + ";";//definimos que id queremos eliminar
                MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
                comando.Connection = conexion.conectarbd;
                comando.ExecuteNonQuery();
                conexion.Cerrar();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexión");
            }

            //ahora vamos a hacer que se oculte esta ventana para volverla a cargar para que se reflejen los cambios
            this.Hide();//ocultamos este formulario
            Form ir_a_listadoMercados = new ListadoMercados(); //creo el objeto de tipo "listadoMercados"
            ir_a_listadoMercados.Show();//mostramos la pestaña donde se listaran los Mercados
        }

        private void zonaListadoMercados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.Abrir();
            String consulta = "Select* from mercados";//definimos que queremos consultar
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conectarbd); //consultamos la sentencia "consulta" a la BD
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);//adaptamos el resultado
            DataTable tabla = new DataTable();//creamos una tabla
            adaptador.Fill(tabla);
            verListadoEventos.DataSource = tabla; //le pasamos la tabla adaptada al grid que se llama "zonalistadoEventos"

        }
    }
}
