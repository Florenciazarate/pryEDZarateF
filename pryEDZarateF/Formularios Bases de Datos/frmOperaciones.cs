using pryEDZarateF.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDZarateF.Formularios_Bases_de_Datos
{
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();

        // Esquema de la base Libreria.mdb:
        //   Libro (IdLibro, Titulo, IdAutor, Año, IdPais, IdIdioma, Cantidad, Precio)
        //   Autor (IdAutor, Nombre)   Idioma (IdIdioma, Nombre)   Pais (IdPais, Nombre)

        // ----------------------------------------------------------------------
        // PROYECCIÓN (SELECT) -> elegir QUÉ columnas se muestran
        // ----------------------------------------------------------------------

        // Proyección SIMPLE: el SELECT muestra UNA sola columna de la tabla.
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            // Ojo con los espacios al concatenar: cada tramo debe empezar/terminar
            // con espacio, si no queda "LibroORDER" y da error de sintaxis.
            String varInstruccionSQL = "SELECT Titulo" + " FROM Libro" + " ORDER BY 1 ASC";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }

        // Proyección MULTIATRIBUTO: el SELECT muestra VARIAS columnas de la tabla.
        private void btnProyeccionMulti_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT Titulo, Año" + " FROM Libro" + " ORDER BY Titulo ASC";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }

        // JUNTAR (JOIN): combina dos tablas relacionadas por su clave.
        // Libro.IdAutor apunta a la clave IdAutor de la tabla Autor.
        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT Libro.Titulo, Autor.Nombre" +
                                       " FROM Libro INNER JOIN Autor" +
                                       " ON Libro.IdAutor = Autor.IdAutor" +
                                       " ORDER BY Autor.Nombre ASC";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }

        // ----------------------------------------------------------------------
        // SELECCIÓN (WHERE) -> elegir QUÉ filas se muestran
        // ----------------------------------------------------------------------

        // Selección SIMPLE: filtra por UNA sola condición.
        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT * FROM Libro" +
                                       " WHERE IdAutor = 4";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }

        // Selección MULTIATRIBUTO: filtra combinando VARIAS condiciones (AND / OR).
        private void btnSeleccionMulti_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT * FROM Libro" +
                                       " WHERE IdAutor = 9 AND IdIdioma = 2";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }

        // Selección por CONVOLUCIÓN: búsqueda por PATRÓN con LIKE.
        // Trae todos los libros cuyo título contiene la letra 'a'.
        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT * FROM Libro" +
                                       " WHERE Titulo LIKE '%a%'";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }

        // ----------------------------------------------------------------------
        // OPERACIONES ALGEBRAICAS DE CONJUNTOS
        // Las tres se muestran sobre el MISMO par de conjuntos compatibles:
        //   A = libros con Precio > 500
        //   B = libros con Cantidad > 5
        // ----------------------------------------------------------------------

        // UNIÓN (A ∪ B): filas que están en A, en B o en ambos (sin repetir).
        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT Titulo, Precio FROM Libro WHERE Precio > 500" +
                                       " UNION " +
                                       "SELECT Titulo, Precio FROM Libro WHERE Cantidad > 5" +
                                       " ORDER BY Titulo ASC";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }

        // INTERSECCIÓN (A ∩ B): filas que están en AMBOS conjuntos.
        // Access (Jet/ACE) no tiene INTERSECT, así que se emula con IN.
        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT Titulo, Precio FROM Libro" +
                                       " WHERE Precio > 500" +
                                       " AND Titulo IN (SELECT Titulo FROM Libro WHERE Cantidad > 5)" +
                                       " ORDER BY Titulo ASC";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }

        // DIFERENCIA (A − B): filas que están en A pero NO en B.
        // Access no tiene EXCEPT/MINUS, así que se emula con NOT IN.
        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varInstruccionSQL = "SELECT Titulo, Precio FROM Libro" +
                                       " WHERE Precio > 500" +
                                       " AND Titulo NOT IN (SELECT Titulo FROM Libro WHERE Cantidad > 5)" +
                                       " ORDER BY Titulo ASC";
            objBaseDatos.Listar(dgvOperaciones, varInstruccionSQL);
        }
    }
}
