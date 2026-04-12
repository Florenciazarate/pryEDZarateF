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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
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
            objCliente.NombreArchivo = "Clientes.csv";
            objCliente.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            MessageBox.Show("Cliente grabado correctamente");
            objCliente.Recorrer(dgvClientes);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private bool CamposCompletos()
        {
            return txtCodigo.Text.Trim() != "" &&
                   txtNombre.Text.Trim() != "" &&
                   txtDeuda.Text.Trim() != "";
        }

        private void ActualizarEstadoBotonGrabar()
        {
            btnGrabar.Enabled = CamposCompletos();
        }

        private void txtCampos_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonGrabar();
        }
    }
}
