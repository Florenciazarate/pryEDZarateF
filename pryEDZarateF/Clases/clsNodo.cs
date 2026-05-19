using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDZarateF
{
    internal class clsNodo
    {
        private Int32 cod;
        private String nom;
        private String tra;
        // campos para estructuras lineales
        private clsNodo sig;
        private clsNodo ant;
        // campos independientes para árbol binario
        private clsNodo izq;
        private clsNodo der;

        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        // Para estructuras lineales
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }
        // Para árbol binario
        public clsNodo Izquierdo
        {
            get { return izq; }
            set { izq = value; }
        }
        public clsNodo Derecho
        {
            get { return der; }
            set { der = value; }
        }
    }
}