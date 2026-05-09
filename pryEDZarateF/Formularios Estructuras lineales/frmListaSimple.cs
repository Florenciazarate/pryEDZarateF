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
    public partial class frmListaSimple : Form
    {
        clsListaSimple Lista = new clsListaSimple();

        public frmListaSimple()
        {
            InitializeComponent();
        }
        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            ActualizarBotones();
        }
        private void ActualizarBotones()
        {
            bool camposCompletos = !string.IsNullOrWhiteSpace(txtCodigo.Text)
                                && !string.IsNullOrWhiteSpace(txtNombre.Text)
                                && !string.IsNullOrWhiteSpace(txtTramite.Text);
            btnGrabar.Enabled = camposCompletos;

            bool puedeEliminar = Lista.Primero != null && cmbCodigo.SelectedIndex >= 0;
            btnEliminar.Enabled = puedeEliminar;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotones();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotones();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotones();
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBotones();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingresá un código numérico válido.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = codigo;
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvElementos);
            Lista.Recorrer(lstElementos);
            Lista.Recorrer(cmbCodigo);
            Lista.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            ActualizarBotones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero == null)
            {
                MessageBox.Show("No hay elementos para eliminar.");
                return;
            }
            if (cmbCodigo.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un código para eliminar.");
                return;
            }
            Int32 x = Convert.ToInt32(cmbCodigo.SelectedItem);
            Lista.Eliminar(x);
            Lista.Recorrer(dgvElementos);
            Lista.Recorrer(lstElementos);
            Lista.Recorrer(cmbCodigo);
            Lista.Recorrer();
            ActualizarBotones();
        }
    }
}