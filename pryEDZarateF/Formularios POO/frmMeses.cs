using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDZarateF
{
    public partial class frmMeses : Form
    {
        private readonly string[] meses = new[]
        {
            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
        };

        public frmMeses()
        {
            InitializeComponent();
            cmbMeses.Items.AddRange(meses);
            ActualizarEstadoBotonGrabar();
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
        }

        private void ActualizarEstadoBotonGrabar()
        {
            btnGrabar.Enabled = cmbMeses.SelectedIndex >= 0;
        }

        private void cmbMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonGrabar();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (cmbMeses.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccioná un mes válido");
                return;
            }
            string mes = cmbMeses.SelectedItem.ToString();

            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Meses.csv";
            x.Grabar(mes);
            MessageBox.Show("Mes grabado correctamente");
            cmbMeses.SelectedIndex = -1;
            ActualizarEstadoBotonGrabar();
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Meses.csv";
            x.Recorrer(lstMeses);
        }
    }
}
