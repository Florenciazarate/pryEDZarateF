using pryEDZarateF.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDZarateF
{
    public partial class frmArbol : Form

    {
        clsArbolBinario arbol = new clsArbolBinario();
        public frmArbol()
        {
            InitializeComponent();
            ConfigurarIconoArbol();
            radioAscendente.Checked = true;
        }
        private void ConfigurarIconoArbol()
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(16, 16);
            imgList.ColorDepth = ColorDepth.Depth32Bit;

            Bitmap hoja = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(hoja))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                GraphicsPath path = new GraphicsPath();
                path.AddBezier(8, 1, 15, 4, 15, 12, 8, 15);
                path.AddBezier(8, 15, 1, 12, 1, 4, 8, 1);
                g.FillPath(new SolidBrush(Color.FromArgb(34, 197, 94)), path);
                g.DrawLine(new Pen(Color.FromArgb(21, 128, 61), 1), 8, 4, 8, 13);
            }
            imgList.Images.Add("hoja", hoja);
            treeElementos.ImageList = imgList;
            treeElementos.ImageKey = "hoja";
            treeElementos.SelectedImageKey = "hoja";
        }
        private void ActualizarBotones()
        {
            bool camposCompletos = !string.IsNullOrWhiteSpace(txtCodigo.Text)
                                && !string.IsNullOrWhiteSpace(txtNombre.Text)
                                && !string.IsNullOrWhiteSpace(txtTramite.Text);
            btnGrabar.Enabled = camposCompletos;
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e) => ActualizarBotones();
        private void txtNombre_TextChanged(object sender, EventArgs e) => ActualizarBotones();
        private void txtTramite_TextChanged(object sender, EventArgs e) => ActualizarBotones();
        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e) => ActualizarBotones();

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingresá un código numérico válido.");
                return;
            }
            clsNodo n = new clsNodo();
            n.Codigo = codigo;
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;
            arbol.Agregar(n);
            ActualizarVistas();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            ActualizarBotones();
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {
            cmbCodigo.Items.Clear();
            ActualizarVistas();
        }
        private void radioAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVistas();
        }
        private void ActualizarVistas()
        {
            arbol.Recorrer(treeElementos);

            if (radioAscendente.Checked)
            {
                arbol.RecorrerInOrden(dgvElementos);
                arbol.RecorrerInOrden(cmbCodigo);
            }
            else if (radioDescendente.Checked)
            {
                arbol.RecorrerInOrdenDesc(dgvElementos);
                arbol.RecorrerInOrdenDesc(cmbCodigo);
            }
            else if (radioPostOrden.Checked)
            {
                arbol.RecorrerPostOrden(dgvElementos);
                arbol.RecorrerPostOrden(cmbCodigo);
            }
        }
    }
}
