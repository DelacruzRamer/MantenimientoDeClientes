using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoDeClientes
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        //Este es el boton para salir del usuario y volver a la pagina de login//
        private void bntSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que quieres salir de tu usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Login pantalla = new Login();
                pantalla.Show();
            }
            }
    }
}
