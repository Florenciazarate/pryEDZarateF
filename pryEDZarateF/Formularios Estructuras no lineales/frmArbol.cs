using pryEDZarateF.Clases;
using System;
using System.Collections;
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
    public partial class frmArbol : Form

    {
        clsArbolBinario arbol = new clsArbolBinario();
        public frmArbol()
        {
            InitializeComponent();
            radioAscendente.Checked = true;

        }
        private void ActualizarBotones()
        {
            bool camposCompletos = !string.IsNullOrWhiteSpace(txtCodigo.Text)
                                && !string.IsNullOrWhiteSpace(txtNombre.Text)
                                && !string.IsNullOrWhiteSpace(txtTramite.Text);
            btnGrabar.Enabled = camposCompletos;
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
            arbol.Agregar(n);
            ActualizarVistas();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            ActualizarBotones();
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {
            cmbCodigo.Items.Clear();
            ActualizarVistas();
        }
        private void radioAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVistas();
        }
        private void ActualizarVistas()
        {
        
            if (radioAscendente.Checked)
            {
                arbol.RecorrerInOrden(dgvElementos);
                arbol.RecorrerInOrden(lstElementos);
                arbol.RecorrerInOrden(cmbCodigo);
            }
            else if (radioDescendente.Checked)
            {
                arbol.RecorrerPreOrden(dgvElementos);
                arbol.RecorrerPreOrden(lstElementos);
                arbol.RecorrerPreOrden(cmbCodigo);

            }
            else if (radioPostOrden.Checked)        
            {
                arbol.RecorrerPostOrden(dgvElementos);
                arbol.RecorrerPostOrden(lstElementos);
                arbol.RecorrerPostOrden(cmbCodigo);
            }
        }
    }
}
