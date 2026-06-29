using pryEDZarateF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDZarateF
{
    internal class clsListaDoble : clsEstructurasLineales
    {
        private clsNodo ult;
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
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo Ant = Primero;
                        while (aux.Codigo < Nuevo.Codigo)
                        {
                            Ant = aux;
                            aux = aux.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Anterior = Ant;
                        Nuevo.Siguiente = aux;
                        aux.Anterior = Nuevo;
                    }
                }
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            // Lista vacía: no hay nada que eliminar.
            if (Primero == null) return;

            // Único nodo y es el buscado.
            if (Primero == Ultimo && Primero.Codigo == Codigo)
            {
                Primero = null;
                Ultimo = null;
            }
            // Es el primero.
            else if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
                Primero.Anterior = null;
            }
            // Es el último.
            else if (Ultimo.Codigo == Codigo)
            {
                Ultimo = Ultimo.Anterior;
                Ultimo.Siguiente = null;
            }
            // Está en el medio: busco el nodo EXACTO.
            else
            {
                clsNodo aux = Primero;
                while (aux != null && aux.Codigo != Codigo)
                {
                    aux = aux.Siguiente;
                }
                if (aux == null) return; // el código no existe: no toco nada.
                // aux está en el medio, así que Anterior y Siguiente no son null.
                aux.Anterior.Siguiente = aux.Siguiente;
                aux.Siguiente.Anterior = aux.Anterior;
            }
        }
        public void RecorrerDesc(ListBox combo)
        {
            clsNodo aux = Ultimo;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add($" Código: {aux.Codigo}, Nombre: {aux.Nombre}, Trámite: {aux.Tramite}");
                aux = aux.Anterior;
            }
        }
        public void RecorrerDesc(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDesc(ComboBox combo)
        {
            clsNodo aux = Ultimo;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDesc()
        {
            clsNodo aux = Ultimo;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista doble\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.Tramite);
                aux = aux.Anterior;
            }
            AD.Close();
        }
        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista doble\n");
            AD.WriteLine("Código;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}

