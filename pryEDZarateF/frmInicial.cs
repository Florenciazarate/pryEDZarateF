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
            menu.Renderer = new ToolStripProfessionalRenderer(new MenuColors());
        }

        private class MenuColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected => Color.FromArgb(241, 245, 249);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(71, 85, 105);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(71, 85, 105);
            public override Color MenuItemBorder => Color.FromArgb(203, 213, 225);
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(71, 85, 105);
            public override Color MenuItemPressedGradientMiddle => Color.FromArgb(71, 85, 105);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(71, 85, 105);
            public override Color MenuBorder => Color.FromArgb(30, 41, 59);
            public override Color ToolStripDropDownBackground => Color.White;
            public override Color ImageMarginGradientBegin => Color.White;
            public override Color ImageMarginGradientMiddle => Color.White;
            public override Color ImageMarginGradientEnd => Color.White;
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

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola x = new frmCola();
            x.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila x = new frmPila();
            x.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple x= new frmListaSimple();
            x.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble x  = new frmListaDoble();
            x.ShowDialog();
        }
    }
}
