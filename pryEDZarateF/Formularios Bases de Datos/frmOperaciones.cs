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
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT TITULO" + " FROM libro" + "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }
    }
}
