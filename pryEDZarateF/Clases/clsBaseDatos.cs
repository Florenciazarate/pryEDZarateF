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
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string CadenaConexion1 = "Provider= Microsoft.Jet.OleDB.4.0;Data Source=Libreria.mdb";
        private string CadenaConexion2 = "Provider= Microsoft.Jet.OleDB.12.0;Data Source=Libreria.mdb";
        public void Listar(string tabla, DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables[tabla];

                conexion.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public void Listar (DataGridView Grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];
                conexion.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                conexion.Close();
            }
        }
        public List<string> ListarTablas()
        {
            List<string> tablas = new List<string>();
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();
                DataTable esquema = conexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });
                foreach (DataRow fila in esquema.Rows)
                    tablas.Add(fila["TABLE_NAME"].ToString());
                conexion.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            return tablas;
        }
    }
}




