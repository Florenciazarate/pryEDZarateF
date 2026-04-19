using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDZarateF
{
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
            ActualizarEstadoBotonGrabar();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(txtNombreMes.Text == "" || txtNombreMes.Text.Any (char.IsDigit))
            {
                MessageBox.Show("Ingrese un mes");
                txtNombreMes.Text = "";
                return;
            }
            clsArchivoTexto x= new clsArchivoTexto();
            x.NombreArchivo = "Meses.csv";
            x.Grabar(txtNombreMes.Text);
            x.Recorrer(lstMeses);
            MessageBox.Show("Mes grabado correctamente");

        }
        private void ActualizarEstadoBotonGrabar()
        {
            btnGrabar.Enabled = txtNombreMes.Text.Trim() != "";
        }
        private void txtNombreMes_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonGrabar();
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Meses.csv";
            x.Recorrer(lstMeses);
        }
        private void frmMeses_Load(object sender, EventArgs e)
        {

        }
    }
}
