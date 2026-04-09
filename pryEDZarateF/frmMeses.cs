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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(txtNombreMes.Text == "" || txtNombreMes.Text == "Ingrese un mes")
            {
                MessageBox.Show("Ingrese un mes");
                txtNombreMes.Text = "";
                return;
            }
            clsArchivoTexto x= new clsArchivoTexto();
            x.NombreArchivo = "Meses.txt";
            x.Grabar(txtNombreMes.Text);
            x.Recorrer(lstMeses);
        }
    }
}
