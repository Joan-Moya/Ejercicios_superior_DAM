using Actividad1.Reports;
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
    public partial class menuAdministrador : Form
    {
        public menuAdministrador()
        {

            InitializeComponent();
            
        }
        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void botonEventos_MouseClick(object sender, MouseEventArgs e)
        {
            Form ir_a_listadoEventos = new ListadoEventos(); //creo el objeto de tipo "listadoEventos"
            ir_a_listadoEventos.Show();//mostramos la pestaña donde se listaran los Eventos
            
        }

       
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form ir_a_vista_report_usuarios = new VistaUsuarios(); //creo el objeto de usuarios
            ir_a_vista_report_usuarios.Show();//mostramos la vista usuarios
        }

        private void boton_eventos_actuales_Click(object sender, EventArgs e)
        {
            Form ir_a_vista_report_eventosActuales = new EventosActuales(); //creo el objeto eventos actuales
            ir_a_vista_report_eventosActuales.Show();//mostramos la vista eventos actuales

        }

        private void eventos_entre_fechas_Click(object sender, EventArgs e)
        {
            Form ir_a_vista_report_eventos_entre_fechas= new EventosEntreFechas(); //creo el objeto eventos entre fechas
            ir_a_vista_report_eventos_entre_fechas.Show();//mostramos el panel de eventos entre fechas
        }

        private void boton_apuestas_por_eventos_Click(object sender, EventArgs e)
        {
            Form ir_a_vista_report_apuestas_por_eventos = new EventosEntreFechas(); //creo el objeto apuestas por eventos
            ir_a_vista_report_apuestas_por_eventos.Show();//mostramos el panel de apuestas por eventos
        }

        private void boton_apuestas_por_usuario_Click(object sender, EventArgs e)
        {
            Form ir_a_vista_report_apuestas_por_usuarios = new EventosEntreFechas(); //creo el objeto apuestas por usuarios
            ir_a_vista_report_apuestas_por_usuarios.Show();//mostramos el panel de apuestas por usuarios
        }

        private void boton_vista_mercados_Click(object sender, EventArgs e)
        {
            Form ir_a_vista_report_mercados = new Mercados(); //creo el objeto mercados
            ir_a_vista_report_mercados.Show();//mostramos el panel de mercados

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form ir_a_login = new ventanaLogin(); //creo el objeto de tipo "login"
            ir_a_login.Show();//mostramos el login
            this.Hide();//ocultamos este formulario
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void botonImagenInformes_Click(object sender, EventArgs e)
        {
            Form ir_a_informes = new MenuInformes(); //creo el objeto informes
            ir_a_informes.Show();//mostramos el panel de informes
        }

       
        private void botonIconoEventos_Click(object sender, EventArgs e)
        {
            Form ir_a_listadoEventos = new ListadoEventos(); //creo el objeto de tipo "listadoEventos"
            ir_a_listadoEventos.Show();//mostramos la pestaña donde se listaran los Eventos
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form ir_a_listadoMercados = new ListadoMercados(); //creo el objeto de tipo "listadoMercados"
            ir_a_listadoMercados.Show();//mostramos la pestaña donde se listaran los Mercados
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form ir_a_listadoUsuarios = new panelListadoUsuarios(); //creo el objeto de tipo "listadoMercados"
            ir_a_listadoUsuarios.Show();//mostramos la pestaña donde se listaran los Mercados
        }
    }
}
