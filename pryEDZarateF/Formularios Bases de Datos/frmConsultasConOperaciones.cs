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

namespace pryEDZarateF.Formularios_Bases_de_Datos
{
    public partial class frmConsultasConOperaciones : Form
    {
        private clsBaseDatos bd = new clsBaseDatos();

        public frmConsultasConOperaciones()
        {
            InitializeComponent();
        }

        private void frmConsultasConOperaciones_Load(object sender, EventArgs e)
        {
            cmbOperacion.Items.Add("Todos los libros");
            cmbOperacion.Items.Add("Título y precio");
            cmbOperacion.Items.Add("Libros de más de 100");
            cmbOperacion.Items.Add("Libros con su autor");
        }

        // Según la operación elegida, muestra la consulta SQL en el cuadro de descripción.
        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOperacion.SelectedIndex)
            {
                case 0:
                    txtDescripcion.Text = "SELECT * FROM Libro";
                    break;
                case 1:
                    txtDescripcion.Text = "SELECT Titulo, Precio FROM Libro";
                    break;
                case 2:
                    txtDescripcion.Text = "SELECT Titulo, Precio FROM Libro WHERE Precio > 100";
                    break;
                case 3:
                    txtDescripcion.Text = "SELECT L.Titulo, A.Nombre FROM Libro L INNER JOIN Autor A ON L.IdAutor = A.IdAutor";
                    break;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cmbOperacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una operación.");
                return;
            }
            bd.Listar(dgvResultado, txtDescripcion.Text);
        }
    }
}
