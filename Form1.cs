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
    public partial class Form1 : Form
    {
        acciones ACC = new acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            GVAutos.DataSource = ACC.MostrarAuto();
        }
    }
}
