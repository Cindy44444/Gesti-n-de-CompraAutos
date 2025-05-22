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
        public Loggin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios(txtUsuario.Text, txtContrasenia.Text);
            if (true)
            {
                Form form = new Form();
                form.Visible = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fallaste jajajaja");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
