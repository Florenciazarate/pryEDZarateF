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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola fila = new clsCola();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                MessageBox.Show("Se eliminó el elemento: " + fila.Primero.Nombre);
                lblCodigo22.Text = Convert.ToString(fila.Primero.Codigo);
                lblNombreEliminado.Text = fila.Primero.Nombre;
                lblTramiteEliminado.Text = fila.Primero.Tramite;
                fila.Eliminar();
                fila.Recorrer(dgvElementos);
                fila.Recorrer(lstElementos);
                fila.Recorrer();
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            fila.Agregar(n);
            fila.Recorrer(dgvElementos);
            fila.Recorrer(lstElementos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }
    }
}
