using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryEDZarateF
{
    internal class clsArchivoTexto
    {
        public string NombreArchivo = "Colores.csv";

        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine();
            AD.Close();
        }
        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine(Dato);
            AD.Close();
        }
        public void Grabar(String Codigo, String Nombre)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(Codigo);
            AD.Write(";");
            AD.WriteLine(Nombre);
            AD.Close();
        }
        public void Recorrer(ListBox lstColor)
        {
            String DatoLeido;
            lst.Items.Clear();
            StreamReader AD = new StreamReader(NombreArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido !=null)
            {
                lst.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

    }
}
