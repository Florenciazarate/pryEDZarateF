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
            if (lista.Primero != null)
            {
                lblCodigo.Text = Convert.ToString(lista.Primero.Codigo);
                lblNombre.Text = lista.Primero.Nombre;
                lblTramite.Text = lista.Primero.Tramite;
                lista.Eliminar(lista.Primero.Codigo); 
                lista.Recorrer(dgvElementos);
                lista.Recorrer(lstElementos);
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar.");
                lblTramite.Text = "";
                lblNombre.Text = "";
                lblCodigo.Text = "";
            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;
            lista.Agregar(n);
            lista.Recorrer(dgvElementos);
            lista.Recorrer(lstElementos);
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

        }

        private void radioAscendente_CheckedChanged(object sender, EventArgs e)
            {
            if (radioAscendente.Checked)
            {
                lista.Recorrer(dgvElementos);
                lista.Recorrer(lstElementos);
            }
            else
            {
                lista.RecorrerDesc(dgvElementos);
                lista.RecorrerDesc(lstElementos);
            }
        }
    }
    }

