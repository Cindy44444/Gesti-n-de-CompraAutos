using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_CompraAutos
{
    public partial class Loggin: Form
    {
        Usuarios nose = new Usuarios();
        public Loggin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string user = txtUsuario.Text;
            string Password = txtContrasenia.Text;

            var lista = nose.ObtenerUsuarios();
            var valida = lista.FirstOrDefault(u => u.user == user && u.password == Password);
            if (valida != null)
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Esta mal.... en algo");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
