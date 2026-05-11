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
    public partial class frmListaDoble : Form
    {
        clsListaDoble lista = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
            radioAscendente.Checked = true;

        }
        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            ActualizarBotones();
        }
        private void ActualizarBotones()
        {
            bool camposCompletos = !string.IsNullOrWhiteSpace(txtCodigo.Text)
                                && !string.IsNullOrWhiteSpace(txtNombre.Text)
                                && !string.IsNullOrWhiteSpace(txtTramite.Text);
            btnGrabar.Enabled = camposCompletos;
            bool puedeEliminar = lista.Primero != null && cmbCodigo.SelectedIndex >= 0;
            btnEliminar.Enabled = puedeEliminar;
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e) => ActualizarBotones();
        private void txtNombre_TextChanged(object sender, EventArgs e) => ActualizarBotones();
        private void txtTramite_TextChanged(object sender, EventArgs e) => ActualizarBotones();
        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e) => ActualizarBotones();
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingresá un código numérico válido.");
                return;
            }
            clsNodo n = new clsNodo();
            n.Codigo = codigo;
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;
            lista.Agregar(n);
            ActualizarVistas();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            ActualizarBotones();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                Int32 codigo = Convert.ToInt32(cmbCodigo.Text);
                lista.Eliminar(codigo);
                MessageBox.Show("Elemento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarVistas();
                ActualizarBotones();
            }
        }
        private void radioAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVistas();
        }
        private void ActualizarVistas()
        {
            if (radioAscendente.Checked)
            {
                lista.Recorrer(dgvElementos);
                lista.Recorrer(lstElementos);
                lista.Recorrer(cmbCodigo);
            }
            else
            {
                lista.RecorrerDesc(dgvElementos);
                lista.RecorrerDesc(lstElementos);
                lista.RecorrerDesc(cmbCodigo);
            }
        }
    }
}
