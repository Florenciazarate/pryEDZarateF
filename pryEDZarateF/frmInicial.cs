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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador x = new frmDatosDesarrollador();
            x.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores x = new frmColores();
            x.ShowDialog();
        }

        private void mesesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMeses x = new frmMeses();
            x.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes x = new frmClientes();
            x.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras x = new frmCarreras();
            x.ShowDialog();
        }
        private void alumnosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAlumnos x = new frmAlumnos();
            x.ShowDialog();
        }
    }
}
