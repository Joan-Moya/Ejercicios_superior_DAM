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

    public partial class ventanaLogin : Form
    {
        public ventanaLogin()
        {
            InitializeComponent();
        }
        //en esta función creamos el login una vez se pulse el botón
        private void Entrar_MouseClick(object sender, MouseEventArgs e)
        {
            if((textoUsuario.Text == "Admin") && (textoContra.Text == "123"))
            {
                Form ir_a_menu = new menuAdministrador(); //creo el objeto de tipo "menu administrador"
                ir_a_menu.Show();//mostramos el menu
                this.Hide();//ocultamos este formulario que es el login
            }
            else
            {
                MessageBox.Show("El usuario es incorrecto");
            }
        }

        private void ventanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
