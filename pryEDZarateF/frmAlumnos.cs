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
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ingrese un mes");
                txtNombre.Text = "";
                return;
            }

        }


    }
}
