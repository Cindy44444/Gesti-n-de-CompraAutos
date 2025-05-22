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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(ACC.ExportarExcel())
            {
                MessageBox.Show("Exportando con exito fuaaaa.....");
                GVAutos.DataSource = null;
            }
            else
            {
                MessageBox.Show("Fallo al exportar (Esta mal...en algo)");
            }
        }
    }
}
