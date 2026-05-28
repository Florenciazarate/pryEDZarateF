using pryEDZarateF.Formularios_Bases_de_Datos;
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
        private void AbrirFormulario_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemPresionado = (ToolStripMenuItem)sender;
            string nombreFormulario = itemPresionado.Tag?.ToString();
            Form ventana = null;
            switch (nombreFormulario)
            {
                case "frmAlumnos": ventana = new frmAlumnos(); break;
                case "frmCarreras": ventana = new frmCarreras(); break;
                case "frmClientes": ventana = new frmClientes(); break;
                case "frmColores": ventana = new frmColores(); break;
                case "frmMeses": ventana = new frmMeses(); break;
                case "frmCola": ventana = new frmCola(); break;
                case "frmPila": ventana = new frmPila(); break;
                case "frmListaSimple": ventana = new frmListaSimple(); break;
                case "frmListaDoble": ventana = new frmListaDoble(); break;
                case "frmDatosDesarrollador": ventana = new frmDatosDesarrollador(); break;
                case "frmArbol": ventana = new frmArbol(); break;
                case "frmGrafo": ventana = new frmGrafo(); break;
                case "frmConsultaTabla": ventana = new frmConsultaTabla(); break;
                case "frmConsultaSQL": ventana = new frmConsultaSQL(); break;
                case "frmConsultasConOperaciones": ventana = new frmConsultasConOperaciones(); break;
                case "frmOperaciones": ventana = new frmOperaciones(); break;

                case "Salir":
                    Application.Exit();
                    return;
            }
            if (ventana != null)
            {
                ventana.ShowDialog();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }

}


