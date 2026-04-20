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
        private readonly string[] meses = new[]
        {
            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
        };

        private bool filtrando = false;

        public frmMeses()
        {
            InitializeComponent();
            cmbMeses.Items.AddRange(meses);
            ActualizarEstadoBotonGrabar();
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
        }

        private string MesValido()
        {
            return meses.FirstOrDefault(m =>
                m.Equals(cmbMeses.Text.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        private void ActualizarEstadoBotonGrabar()
        {
            btnGrabar.Enabled = MesValido() != null;
        }

        private void cmbMeses_TextChanged(object sender, EventArgs e)
        {
            if (filtrando) return;
            filtrando = true;
            try
            {
                string texto = cmbMeses.Text;
                int pos = cmbMeses.SelectionStart;

                var coincidencias = string.IsNullOrWhiteSpace(texto)
                    ? meses
                    : meses.Where(m => m.StartsWith(texto, StringComparison.OrdinalIgnoreCase)).ToArray();

                cmbMeses.BeginUpdate();
                cmbMeses.Items.Clear();
                cmbMeses.Items.AddRange(coincidencias);
                cmbMeses.EndUpdate();
                cmbMeses.Text = texto;
                cmbMeses.SelectionStart = pos;
                cmbMeses.SelectionLength = 0;

                if (!string.IsNullOrWhiteSpace(texto) && coincidencias.Length > 0)
                {
                    cmbMeses.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                    cmbMeses.SelectionStart = pos;
                }

                ActualizarEstadoBotonGrabar();
            }
            finally
            {
                filtrando = false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var mes = MesValido();
            if (mes == null)
            {
                MessageBox.Show("Seleccione un mes válido");
                return;
            }
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Meses.csv";
            x.Grabar(mes);
            MessageBox.Show("Mes grabado correctamente");
            cmbMeses.Text = "";
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Meses.csv";
            x.Recorrer(lstMeses);
        }
    }
}
