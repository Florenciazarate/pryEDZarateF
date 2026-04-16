using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDZarateF
{
    internal class clsCola
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }
        public void Eliminar ()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }


        Public void Recorrer (DataGridView Grilla)
            { clsNodo aux = Primero;
                Grilla.Rows.Clear();
                while (aux != null)
                {
                    Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                    aux = aux.Siguiente;
                }
        }
            Public void Recorrer(ListBox list)
            {
                clsNodo aux = Primero;
                Lista.Items.Clear();
                while (aux != null)
                {
                    Lista.Items.Add(aux.Codigo);
                    aux = aux.Siguiente;
                }
            }
            Public void Recorrer(ComboBox Combo)
            {
                clsNodo aux = Primero;
                Combo.Items.Clear();
                while (aux != null)
                {
                    Combo.Items.Add(aux.Nombre);
                    aux = aux.Siguiente;
                }
            }
        }

