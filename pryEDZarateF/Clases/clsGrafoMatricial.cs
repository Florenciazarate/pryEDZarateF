using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDZarateF.Clases
{
    internal class clsGrafoMatricial
    {
        private String[] Ciudades = new String[] { "Córdoba", "Mendoza", "Buenos Aires", "Bariloche", "Ushuaia" };
        private Decimal[,] Precio = new decimal[5, 5];

        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }
        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }
        public Decimal Consultar(Int32 f, Int32 c)
        {
            return Precio[f, c];
        }
        public void BorrarTodo()
        {
            for (Int32 f = 0; f < 5; f++)
            {
                for (Int32 c = 0; c < 5; c++)
                {
                    Precio[f, c] = 0;
                }
            }
        }
        public void MostrarDestinos(Int32 f, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Rows.Add("Col1", "Destino");
            Grilla.Rows.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;
            Grilla.Rows.Clear();
            for (Int32 c = 0; c < 5; c++)
            {
                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[c], Precio[f, c]);
                }
            }
        }
        public void MostrarOrigenes(Int32 c, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Rows.Add("Col1", "Origen");
            Grilla.Rows.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;
            Grilla.Rows.Clear();
            for (Int32 f = 0; f < 5; f++)
            {

                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[f], Precio[f, c]);
                }
            }
        }
        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("NomOrigen", "Origen");
            for (Int32 i = 0; i < 5; i++)
            {
                Grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }
            for (Int32 f = 0; f < 5; f++)
            {
                Grilla.Rows.Add(Ciudades[f]);
            }
            for (Int32 c = 0; c < 5; c++)
            {
                Grilla.Rows[f].Cells[c + 1].Value = Precio[f, c];
            }
        }
    }
}
