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
        public frmListaDoble()
        {
            InitializeComponent();
            radioAscendente.Checked = true;

        }
        clsListaDoble lista = new clsListaDoble();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lista.Primero == null)
            {
                MessageBox.Show("No hay elementos para eliminar.");
                return;
            }
            if (cmbCodigo.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un código para eliminar.");
                return;
            }
            int codigo = Convert.ToInt32(cmbCodigo.SelectedItem);
            lista.Eliminar(codigo);
            ActualizarVistas();
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
            clsNodo n = new clsNodo();
            n.Codigo = codigo;
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;
            lista.Agregar(n);
            ActualizarVistas();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
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
