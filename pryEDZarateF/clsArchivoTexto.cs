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
            using (StreamWriter AD = new StreamWriter(NombreArchivo, true))
            {
                AD.WriteLine();
            }
        }
        public void Grabar(String Dato)
        {
            using (StreamWriter AD = new StreamWriter(NombreArchivo, true))
            {
                AD.WriteLine(Dato);
            }
        }
        public void Grabar(String Codigo, String Nombre)
        {
            using (StreamWriter AD = new StreamWriter(NombreArchivo, true))
            {
                AD.Write(Codigo);
                AD.Write(";");
                AD.WriteLine(Nombre);
            }
        }
        public void Grabar(String Dato1, String Dato2, String Dato3)
        {
            using (StreamWriter AD = new StreamWriter(NombreArchivo, true))
            {
                AD.Write(Dato1);
                AD.Write(";");
                AD.Write(Dato2);
                AD.Write(";");
                AD.WriteLine(Dato3);
            }
        }
        public void Recorrer(ListBox lst)
        {
            if (!File.Exists(NombreArchivo))
                return;

            string DatoLeido;
            lst.Items.Clear();
            using (StreamReader AD = new StreamReader(NombreArchivo))
            {
                DatoLeido = AD.ReadLine();
                while (DatoLeido != null)
                {
                    lst.Items.Add(DatoLeido);
                    DatoLeido = AD.ReadLine();
                }
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            String DatoLeido;
            Grilla.Rows.Clear();
            StreamReader AD = new StreamReader(NombreArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                Grilla.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(ComboBox cmb)
        {
            String dato;
            cmb.Items.Clear();
            StreamReader AD = new StreamReader(NombreArchivo); //Abrir
            dato = AD.ReadLine(); //Leer

            while (dato != null)
            {
                cmb.Items.Add(dato);
                dato = AD.ReadLine();
            }

            AD.Close(); //Cerrar
        }
    }
}























