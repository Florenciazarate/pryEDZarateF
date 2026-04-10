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
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text == "" || txtNombreCarrera.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ingrese una carrera valida");
                txtNombreCarrera.Text = "";
                return;
            }
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Carreras.txt";
            x.Grabar(txtNombreCarrera.Text);
            x.Recorrer(lstCarrera);
        }
    }
}
