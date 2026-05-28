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
        private string CadenaConexion1 = "Provider= Microsoft.Jet.OleDB.4.0;Data Source=Libreria.mb";
        private string CadenaConexion2 = "Provider= Microsoft.Jet.OleDB.12.0;Data Source=Libreria.mb";
        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Libro"];

                conexion.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }




