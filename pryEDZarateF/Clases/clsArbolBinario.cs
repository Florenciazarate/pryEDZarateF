using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDZarateF.Clases
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo Ant = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (Nuevo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                if (Nuevo.Codigo < Ant.Codigo) Ant.Izquierdo = Nuevo;
                else Ant.Derecho = Nuevo;
            }
        }

        public void RecorrerInOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            if (Raiz != null) InOrdenAsc(Grilla, Raiz);
        }
        public void RecorrerInOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            if (Raiz != null) InOrdenAsc(Lista, Raiz);
        }
        public void RecorrerInOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            if (Raiz != null) InOrdenAsc(Combo, Raiz);
        }
        public void RecorrerInOrden(clsNodo[] Vector, ref int Pos)
        {
            Pos = 0;
            if (Raiz != null) InOrdenAsc(Vector, ref Pos, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }
        private void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
        }
        private void InOrdenAsc(ComboBox Cmb, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Cmb, R.Izquierdo);
            Cmb.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Cmb, R.Derecho);
        }
        private void InOrdenAsc(clsNodo[] Vector, ref int Pos, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Vector, ref Pos, R.Izquierdo);
            Vector[Pos] = R;
            Pos++;
            if (R.Derecho != null) InOrdenAsc(Vector, ref Pos, R.Derecho);
        }

        private void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDesc(Lst, R.Derecho);
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenDesc(Lst, R.Izquierdo);
        }

        public void RecorrerInOrdenDesc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            if (Raiz != null) InOrdenDesc(Grilla, Raiz);
        }
        public void RecorrerInOrdenDesc(ComboBox Combo)
        {
            Combo.Items.Clear();
            if (Raiz != null) InOrdenDesc(Combo, Raiz);
        }

        private void InOrdenDesc(DataGridView Dgv, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDesc(Dgv, R.Derecho);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenDesc(Dgv, R.Izquierdo);
        }
        private void InOrdenDesc(ComboBox Cmb, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDesc(Cmb, R.Derecho);
            Cmb.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenDesc(Cmb, R.Izquierdo);
        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            if (Raiz != null) PreOrden(Grilla, Raiz);
        }
        public void RecorrerPreOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            if (Raiz != null) PreOrden(Lista, Raiz);
        }
        public void RecorrerPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            if (Raiz != null) PreOrden(Combo, Raiz);
        }

        private void PreOrden(DataGridView Dgv, clsNodo R)
        {
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrden(Dgv, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Dgv, R.Derecho);
        }
        private void PreOrden(ListBox Lst, clsNodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrden(Lst, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Lst, R.Derecho);
        }
        private void PreOrden(ComboBox Cmb, clsNodo R)
        {
            Cmb.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrden(Cmb, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Cmb, R.Derecho);
        }
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            if (Raiz != null) PostOrden(Grilla, Raiz);
        }
        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            if (Raiz != null) PostOrden(Lista, Raiz);
        }
        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            if (Raiz != null) PostOrden(Combo, Raiz);
        }

        private void PostOrden(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Dgv, R.Derecho);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
        private void PostOrden(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Lst, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Lst, R.Derecho);
            Lst.Items.Add(R.Codigo);
        }
        private void PostOrden(ComboBox Cmb, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Cmb, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Cmb, R.Derecho);
            Cmb.Items.Add(R.Codigo);
        }

        // ==================== TreeView ====================

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            if (Raiz != null)
            {
                TreeNode NodoPadre = new TreeNode(Raiz.Codigo.ToString());
                tree.Nodes.Add(NodoPadre);
                ArmarArbol(Raiz, NodoPadre);
            }
            tree.ExpandAll();
        }
        private void ArmarArbol(clsNodo R, TreeNode nodoTreeView)
        {
            if (R.Izquierdo != null)
            {
                TreeNode NodoIzq = new TreeNode(R.Izquierdo.Codigo.ToString());
                nodoTreeView.Nodes.Add(NodoIzq);
                ArmarArbol(R.Izquierdo, NodoIzq);
            }
            if (R.Derecho != null)
            {
                TreeNode NodoDer = new TreeNode(R.Derecho.Codigo.ToString());
                nodoTreeView.Nodes.Add(NodoDer);
                ArmarArbol(R.Derecho, NodoDer);
            }
        }
    }
}

    