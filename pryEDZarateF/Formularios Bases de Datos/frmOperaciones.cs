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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();

        // Proyección SIMPLE: el SELECT muestra UNA sola columna de la tabla.
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            // Ojo con los espacios al concatenar: cada tramo debe empezar/terminar
            // con espacio, si no queda "libroORDER" y da error de sintaxis.
            String varInstruccionSQL = "SELECT Titulo" + " FROM Libro" + " ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }

        // Proyección MULTIATRIBUTO: el SELECT muestra VARIAS columnas de la tabla.
        private void btnProyeccionMulti_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT Titulo, Año, Cantidad, Precio" + " FROM Libro" + " ORDER BY Titulo ASC";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }
    }
}
