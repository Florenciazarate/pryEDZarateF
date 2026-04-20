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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
            ActualizarEstadoBotonGrabar();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text == "" || txtNombreCarrera.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ingrese una carrera valida");
                txtNombreCarrera.Text = "";
                return;
            }

            string nueva = txtNombreCarrera.Text.Trim();
            string archivo = "Carreras.csv";

            if (System.IO.File.Exists(archivo) &&
                System.IO.File.ReadAllLines(archivo)
                    .Any(l => l.Trim().Equals(nueva, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Esa carrera ya está cargada.");
                txtNombreCarrera.Text = "";
                return;
            }

            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = archivo;
            x.Grabar(nueva);
            x.Recorrer(lstCarreras);
        }

        private void ActualizarEstadoBotonGrabar()
        {
            btnGrabar.Enabled = txtNombreCarrera.Text.Trim() != "";
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonGrabar();
        }
    }
}
