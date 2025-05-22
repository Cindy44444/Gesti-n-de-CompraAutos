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

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if(ACC.ImportarExcel())
            {
                MessageBox.Show("Importando con exito...");
                GVAutos.DataSource = null;;
            }
            else
            {
                MessageBox.Show("Error al importar (Esta mal... en algo)");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            int anio = Convert.ToInt32(txtAnio.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);

            if (ACC.Agregar(id,txtMarca.Text,txtModelo.Text,anio,txtColor.Text,precio,txtEstado.Text))
            {
                MessageBox.Show("Agregado con exito");
                GVAutos.DataSource=null;
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            int idactu = Convert.ToInt32(txtID.Text);
            int anioactu = Convert.ToInt32(txtAnio.Text);
            double precioactu = Convert.ToDouble(txtPrecio.Text);

            if (ACC.Actualizar(idactu, txtMarca.Text, txtModelo.Text, anioactu, txtColor.Text, precioactu, txtEstado.Text))
            {
                MessageBox.Show("Actualizado con exito");
                GVAutos.DataSource = null;
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            if (ACC.Eliminar(id))
            {
                MessageBox.Show("Eliminado con exito");
                GVAutos.DataSource = null;
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtAnio.Text = "";
            txtColor.Text = "";
            txtPrecio.Text = "";
            txtEstado.Text = "";
        }
    }
}
