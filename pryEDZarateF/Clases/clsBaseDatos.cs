using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace pryEDZarateF.Clases
{
    internal class clsBaseDatos
    {
        // La cadena usa ruta relativa: la BD se copia a bin\Debug junto al .exe.
        private string CadenaConexion1 = "Provider=Microsoft.Jet.OleDB.4.0;Data Source=Libreria.mdb";

        // Lista una tabla completa por su nombre (TableDirect).
        public void Listar(string tabla, DataGridView Grilla)
        {
            try
            {
                // 'using' garantiza que la conexión se cierre y libere SIEMPRE,
                // incluso si hay una excepción. Así la BD nunca queda "abierta".
                using (OleDbConnection conexion = new OleDbConnection(CadenaConexion1))
                {
                    conexion.Open();

                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.TableDirect;
                    comando.CommandText = tabla;

                    DataSet DS = new DataSet();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(DS, tabla);

                    Grilla.DataSource = null;
                    Grilla.DataSource = DS.Tables[tabla];
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Lista directamente la tabla Libro.
        public void Listar(DataGridView Grilla)
        {
            Listar("Libro", Grilla);
        }

        // Ejecuta una instrucción SQL de texto (SELECT, etc.) y la muestra en la grilla.
        public void Listar(DataGridView Grilla, String varInstruccionSQL)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(CadenaConexion1))
                {
                    conexion.Open();

                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = varInstruccionSQL;

                    DataSet DS = new DataSet();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(DS, "Resultado");

                    Grilla.DataSource = null;
                    Grilla.DataSource = DS.Tables["Resultado"];
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public List<string> ListarTablas()
        {
            List<string> tablas = new List<string>();
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(CadenaConexion1))
                {
                    conexion.Open();
                    DataTable esquema = conexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                        new object[] { null, null, null, "TABLE" });
                    foreach (DataRow fila in esquema.Rows)
                        tablas.Add(fila["TABLE_NAME"].ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            return tablas;
        }
    }
}




