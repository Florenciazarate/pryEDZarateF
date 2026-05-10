using pryEDZarateF;
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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
            ActualizarEstadoBotonGrabar();

        }
        private bool CamposCompletos()
        {
            return txtCodigo.Text.Trim() != "" &&
                   txtNombre.Text.Trim() != "" &&
                   cmbCarrera.SelectedIndex >= 0;
        }
        private void ActualizarEstadoBotonGrabar()
        {
            btnGrabar.Enabled = CamposCompletos();
        }
        private void txtCampos_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonGrabar();
        }
        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonGrabar();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!CamposCompletos())
            {
                MessageBox.Show("Complete todos los campos antes de grabar.");
                return;
            }
            string archivo = "Alumnos.csv";
            string codigoNuevo = txtCodigo.Text.Trim();

            if (File.Exists(archivo))
            {
                var lineas = File.ReadAllLines(archivo);
                if (lineas.Any(l => l.Split(';').FirstOrDefault()?.Trim() == codigoNuevo))
                {
                    MessageBox.Show("Ya existe un alumno con ese código.");
                    return;
                }
            }
            clsArchivoTexto objCliente = new clsArchivoTexto();
            objCliente.NombreArchivo = archivo;
            objCliente.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            MessageBox.Show("Alumno grabado correctamente");
            objCliente.Recorrer(dgvAlumnos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbCarrera.SelectedIndex = -1;
            ActualizarEstadoBotonGrabar();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            {
                clsArchivoTexto x = new clsArchivoTexto();
                x.NombreArchivo = "Carreras.csv";
                x.Recorrer(cmbCarrera);
            }
        }
    }
}


