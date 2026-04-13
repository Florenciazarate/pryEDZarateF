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

        private void frmAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
