using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDZarateF
{
    internal class clsListaSimple : clsEstructurasLineales
    {
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else if (Nuevo.Codigo <= Primero.Codigo)
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
            else
            {
                clsNodo aux = Primero;
                clsNodo ant = Primero;
                while (Nuevo.Codigo > aux.Codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                    if (aux == null)
                    {
                        break;
                    }
                }
                ant.Siguiente = Nuevo;
                Nuevo.Siguiente = aux;
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero == null) return;
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo aux1 = Primero;
                clsNodo aux2 = Primero;
                while (aux1 != null && aux1.Codigo != Codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;
                }
                if (aux1 == null) return;
                aux2.Siguiente = aux1.Siguiente;
            }
        }
        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista Simple\n");
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
