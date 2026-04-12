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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
            ActualizarEstadoBotonGrabar();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNombreColor.Text == "" || txtNombreColor.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ingrese un color valido");
                txtNombreColor.Text = "";
                return;
            }
            clsArchivoTexto x= new clsArchivoTexto();
            x.NombreArchivo = "Colores.csv";
            x.Grabar(txtNombreColor.Text);
            x.Recorrer(lstColor);
            MessageBox.Show("Color grabado correctamente");

        }

        private void ActualizarEstadoBotonGrabar()
        {
            btnGrabar.Enabled = txtNombreColor.Text.Trim() != "";
        }

        private void txtNombreColor_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonGrabar();
        }
    }
}
