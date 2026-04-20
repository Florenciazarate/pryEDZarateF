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
        public List<string> ObtenerCarreras()
        {
            List<string> lista = new List<string>();

            using (StreamReader sr = new StreamReader("Carreras.csv"))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    lista.Add(linea);
                }
            }

            return lista;
        }
        private bool CamposCompletos()
        {
            return txtCodigo.Text.Trim() != "" &&
                   txtNombre.Text.Trim() != "";
        } 

        private void ActualizarEstadoBotonGrabar()
        {
            btnGrabar.Enabled = CamposCompletos();
        }

        private void txtCampos_TextChanged(object sender, EventArgs e)
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
                clsArchivoTexto objCliente = new clsArchivoTexto();
                objCliente.NombreArchivo = "Alumnos.csv";
                objCliente.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
                MessageBox.Show("Alumno grabado correctamente");
                objCliente.Recorrer(dgvAlumnos);
            }

        private void frmClientes_Load(object sender, EventArgs e)
        {

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


