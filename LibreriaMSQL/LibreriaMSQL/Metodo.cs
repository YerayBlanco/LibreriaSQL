using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaMSQL
{
    class Metodo
    {
        
        public static DataSet ObtenerLibros()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                comando.CommandText = "SELECT * FROM Libros";
                comando.Connection = conexion.miConexion;
                adaptador.SelectCommand = comando;
                conexion.miConexion.Open();
                adaptador.Fill(ds);
                conexion.miConexion.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }

        
        public static bool CrearLibros(Libros c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; INSERT INTO Libros VALUES ('" + c.Titulo + "', '" + c.FechaPublicacion + "', '" + c.Descripcion + "', '" + c.NumeroPaginas + "')";
                MessageBox.Show("El Libro se ha creado correctamente.");
                comando.Connection = conexion.miConexion;
                conexion.miConexion.Open();
                comando.ExecuteNonQuery();
                conexion.miConexion.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        
        public static bool EliminarLibros(Libros c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "DELETE FROM Libros WHERE Titulo = '" + c.Titulo + "'";
                MessageBox.Show("El Libro se ha eliminado correctamente.");
                comando.Connection = conexion.miConexion;
                conexion.miConexion.Open();
                comando.ExecuteNonQuery();
                conexion.miConexion.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        
        public static bool ModificarLibros(Libros c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "SET dateformat dmy; UPDATE libros SET Titulo = '" + c.Titulo + "', FechaPublicacion= '" + c.FechaPublicacion + "', " +
                    "NumeroPaginas = '" + c.NumeroPaginas + "', Descripcion = '" + c.Descripcion + "' " +
                    " WHERE ID = '" + c.ID + "'";
                MessageBox.Show("El Libro se ha modificado correctamente.");
                comando.Connection = conexion.miConexion;
                conexion.miConexion.Open();
                comando.ExecuteNonQuery();
                conexion.miConexion.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }
    }

}

