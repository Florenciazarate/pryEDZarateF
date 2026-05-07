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
    internal class clsListaDoble: clsEstructurasLineales
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
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo Ant = Primero;
                        while (aux.Codigo < Codigo)
                        {
                            Ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux = aux.Siguiente;
                        aux.Anterior = Ant;
                        Ant.Siguiente = aux;
                    }
                }
            }
        }
        public void RecorrerDesc(ListBox combo)
        {
            clsNodo aux = Ultimo;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add ($" Código: {aux.Codigo}, Nombre: {aux.Nombre}, Trámite: {aux.Tramite}"); 
                aux = aux.Anterior;
            }
        }
        public void RecorrerDesc(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add( aux.Codigo,aux.Nombre,aux.Tramite);
                aux = aux.Anterior;
            }
        }


        public void RecorrerDesc(ComboBox combo)
        {
            clsNodo aux = Ultimo;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Anterior;
            }
        }

        public void RecorrerDesc()
        {
            clsNodo aux = Ultimo;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", true, Encoding.UTF8);
            AD.WriteLine("Lista doble\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.Tramite);
                aux = aux.Anterior;
            }
            AD.Close();
        }
    }
}

        