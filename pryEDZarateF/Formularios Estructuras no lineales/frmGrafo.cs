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
        clsGrafoMatricial Grafo = new clsGrafoMatricial();

        public frmGrafo()
        {
            InitializeComponent();
        }

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            cmbCargaOrigen.SelectedIndex = 0;
            cmbCargaDestino.SelectedIndex = 0;
            cmbConsultaOrigen.SelectedIndex = 0;
            cmbConsultaDestino.SelectedIndex = 0;
            cmbDesde.SelectedIndex = 0;
            cmbHasta.SelectedIndex = 0;
            Grafo.MostrarTodo(dgvMatriz);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(txtCargaPrecio.Text, out Decimal p) || p <= 0)
            {
                MessageBox.Show("Ingresá un precio numérico válido.");
                return;
            }
            Int32 f = cmbCargaOrigen.SelectedIndex;
            Int32 c = cmbCargaDestino.SelectedIndex;
            if (f == c)
            {
                MessageBox.Show("El origen y el destino no pueden ser la misma ciudad.");
                return;
            }
            Grafo.Agregar(f, c, p);
            Grafo.MostrarTodo(dgvMatriz);
            lblMatrizTitulo.Text = "Listado completo de viajes";
            lblMatrizSub.Text = "Precios entre cada origen y destino";
            txtCargaPrecio.Text = "";
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Grafo.BorrarTodo();
            Grafo.MostrarTodo(dgvMatriz);
            lblMatrizTitulo.Text = "Matriz de viajes";
            lblMatrizSub.Text = "Precios entre cada origen y destino";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbConsultaOrigen.SelectedIndex;
            Int32 c = cmbConsultaDestino.SelectedIndex;
            Decimal precio = Grafo.Consultar(f, c);
            if (precio > 0)
                lblConsultaResultado.Text = precio.ToString();
            else
                lblConsultaResultado.Text = "No existe conexión";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbConsultaOrigen.SelectedIndex;
            Int32 c = cmbConsultaDestino.SelectedIndex;
            Grafo.Eliminar(f, c);
            Grafo.MostrarTodo(dgvMatriz);
            lblMatrizTitulo.Text = "Listado completo de viajes";
            lblMatrizSub.Text = "Precios entre cada origen y destino";
            lblConsultaResultado.Text = "";
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            Int32 f = cmbDesde.SelectedIndex;
            Grafo.MostrarDestinos(f, dgvMatriz);
            lblMatrizTitulo.Text = "Destinos desde " + cmbDesde.Text;
            lblMatrizSub.Text = "Viajes con origen en " + cmbDesde.Text;
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            Int32 c = cmbHasta.SelectedIndex;
            Grafo.MostrarOrigenes(c, dgvMatriz);
            lblMatrizTitulo.Text = "Orígenes hacia " + cmbHasta.Text;
            lblMatrizSub.Text = "Viajes con destino a " + cmbHasta.Text;
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            Grafo.MostrarTodo(dgvMatriz);
            lblMatrizTitulo.Text = "Matriz de viajes";
            lblMatrizSub.Text = "Precios entre cada origen y destino";
        }
    }
}
