using pryEDZarateF.Clases;
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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }
        clsGrafoMatricial Grafo = new clsGrafoMatricial();

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.MostrarCiudades(cmbOrigenA);
            grafo.MostrarCiudades(cmbOrigenE);
            grafo.MostrarCiudades(cmbOrigenC);
            grafo.MostrarCiudades(cmbDestinoA);
            grafo.MostrarCiudades(cmbDestinoE);
            grafo.MostrarCiudades(cmbDestinoC);
            grafo.MostrarTodo(Grilla);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigenA.SelectedIndex;
            Int32 c = cmbDestinoA.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtCargaPrecio.Text);
            grafo.Agregar(f, c, p);
            grafo.MostrarTodo(Grilla);
            lblTitulo.Text = "Listado completo de viajes";
            txtPrecio.Text = "";
        }
    }
}
