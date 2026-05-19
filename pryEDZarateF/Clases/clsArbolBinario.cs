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

        // Compatibilidad: Recorrer = In-Orden
        public void Recorrer(DataGridView Grilla)
        {
            RecorrerInOrden(Grilla);
        }
        public void Recorrer(ListBox Lista)
        {
            RecorrerInOrden(Lista);
        }
        public void Recorrer(ComboBox Combo)
        {
            RecorrerInOrden(Combo);
        }

        // ---------------- IN-ORDEN ----------------
        public void RecorrerInOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrden(Grilla, Raiz);
        }
        private void InOrden(DataGridView dgv, clsNodo nodo)
        {
            if (nodo == null) return;
            if (nodo.Izquierdo != null) InOrden(dgv, nodo.Izquierdo);
            dgv.Rows.Add(nodo.Codigo, nodo.Nombre, nodo.Tramite);
            if (nodo.Derecho != null) InOrden(dgv, nodo.Derecho);
        }

        public void RecorrerInOrden(ListBox lista)
        {
            lista.Items.Clear();
            InOrden(lista, Raiz);
        }
        private void InOrden(ListBox lb, clsNodo nodo)
        {
            if (nodo == null) return;
            if (nodo.Izquierdo != null) InOrden(lb, nodo.Izquierdo);
            lb.Items.Add($" Código: {nodo.Codigo}, Nombre: {nodo.Nombre}, Trámite: {nodo.Tramite}");
            if (nodo.Derecho != null) InOrden(lb, nodo.Derecho);
        }

        public void RecorrerInOrden(ComboBox combo)
        {
            combo.Items.Clear();
            InOrden(combo, Raiz);
        }
        private void InOrden(ComboBox cb, clsNodo nodo)
        {
            if (nodo == null) return;
            if (nodo.Izquierdo != null) InOrden(cb, nodo.Izquierdo);
            cb.Items.Add(nodo.Codigo);
            if (nodo.Derecho != null) InOrden(cb, nodo.Derecho);
        }

        // ---------------- PRE-ORDEN ----------------
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }
        private void PreOrden(DataGridView dgv, clsNodo nodo)
        {
            if (nodo == null) return;
            dgv.Rows.Add(nodo.Codigo, nodo.Nombre, nodo.Tramite);
            if (nodo.Izquierdo != null) PreOrden(dgv, nodo.Izquierdo);
            if (nodo.Derecho != null) PreOrden(dgv, nodo.Derecho);
        }

        public void RecorrerPreOrden(ListBox lista)
        {
            lista.Items.Clear();
            PreOrden(lista, Raiz);
        }
        private void PreOrden(ListBox lb, clsNodo nodo)
        {
            if (nodo == null) return;
            lb.Items.Add($" Código: {nodo.Codigo}, Nombre: {nodo.Nombre}, Trámite: {nodo.Tramite}");
            if (nodo.Izquierdo != null) PreOrden(lb, nodo.Izquierdo);
            if (nodo.Derecho != null) PreOrden(lb, nodo.Derecho);
        }

        public void RecorrerPreOrden(ComboBox combo)
        {
            combo.Items.Clear();
            PreOrden(combo, Raiz);
        }
        private void PreOrden(ComboBox cb, clsNodo nodo)
        {
            if (nodo == null) return;
            cb.Items.Add(nodo.Codigo);
            if (nodo.Izquierdo != null) PreOrden(cb, nodo.Izquierdo);
            if (nodo.Derecho != null) PreOrden(cb, nodo.Derecho);
        }

        // ---------------- POST-ORDEN ----------------
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        private void PostOrden(DataGridView dgv, clsNodo nodo)
        {
            if (nodo == null) return;
            if (nodo.Izquierdo != null) PostOrden(dgv, nodo.Izquierdo);
            if (nodo.Derecho != null) PostOrden(dgv, nodo.Derecho);
            dgv.Rows.Add(nodo.Codigo, nodo.Nombre, nodo.Tramite);
        }

        public void RecorrerPostOrden(ListBox lista)
        {
            lista.Items.Clear();
            PostOrden(lista, Raiz);
        }
        private void PostOrden(ListBox lb, clsNodo nodo)
        {
            if (nodo == null) return;
            if (nodo.Izquierdo != null) PostOrden(lb, nodo.Izquierdo);
            if (nodo.Derecho != null) PostOrden(lb, nodo.Derecho);
            lb.Items.Add($" Código: {nodo.Codigo}, Nombre: {nodo.Nombre}, Trámite: {nodo.Tramite}");
        }

        public void RecorrerPostOrden(ComboBox combo)
        {
            combo.Items.Clear();
            PostOrden(combo, Raiz);
        }
        private void PostOrden(ComboBox cb, clsNodo nodo)
        {
            if (nodo == null) return;
            if (nodo.Izquierdo != null) PostOrden(cb, nodo.Izquierdo);
            if (nodo.Derecho != null) PostOrden(cb, nodo.Derecho);
            cb.Items.Add(nodo.Codigo);
        }
    }
}
