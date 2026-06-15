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
        // Dos proveedores para la misma base. La ruta es relativa: el .mdb se copia
        // a bin\Debug junto al .exe.
        private string CadenaJet = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string CadenaAce = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        // Abre la conexión probando primero Jet (viene con Windows) y, si falla,
        // ACE (Access Database Engine). Devuelve la conexión ya abierta.
        private OleDbConnection AbrirConexion()
        {
            OleDbConnection conexion = new OleDbConnection();
            try
            {
                conexion.ConnectionString = CadenaJet;
                conexion.Open();
            }
            catch
            {
                conexion.ConnectionString = CadenaAce;
                conexion.Open();
            }
            return conexion;
        }

        // Lista una tabla completa por su nombre (TableDirect).
        public void Listar(string tabla, DataGridView Grilla)
        {
            try
            {
                // 'using' garantiza que la conexión se cierre y libere SIEMPRE,
                // incluso si hay una excepción. Así la BD nunca queda "abierta".
                using (OleDbConnection conexion = AbrirConexion())
                {
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
                using (OleDbConnection conexion = AbrirConexion())
                {
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
                using (OleDbConnection conexion = AbrirConexion())
                {
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
