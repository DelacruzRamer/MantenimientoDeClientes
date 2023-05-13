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

namespace MantenimientoDeClientes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Boton para salir//
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Boton de Login y conexion a la base de datos del login//
        SqlConnection coneccion = new SqlConnection("server=DESKTOP-F48AF9P\\SQLEXPRESS; database = login; INTEGRATED SECURITY = true");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASENA FROM persona WHERE USUARIO = @vusuario AND CONTRASENA = @vcontrasena", coneccion);
            comando.Parameters.AddWithValue("@vusuario",txtUsuario.Text);
            comando.Parameters.AddWithValue("@vcontrasena",txtContrasena.Text);

            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                coneccion.Close();
                Home pantalla = new Home();
                pantalla.Show();
                this.Hide();

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
