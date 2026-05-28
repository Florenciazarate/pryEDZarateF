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
    public partial class frmConsultaTabla : Form
    {
        private clsBaseDatos bd = new clsBaseDatos();

        public frmConsultaTabla()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cmbTabla.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una tabla.");
                return;
            }
            bd.Listar(cmbTabla.Text, dgvTabla);
        }

        private void frmConsultaTabla_Load(object sender, EventArgs e)
        {
            cmbTabla.DataSource = bd.ListarTablas();
        }
    }
}
