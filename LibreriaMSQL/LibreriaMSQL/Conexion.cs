using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibreriaMSQL
{
    class Conexion
    {

       public  SqlConnection miConexion;

        public Conexion() //Creamos una Clase Conexion aparte del programa y posteriormente lo llamaremos.
        {
            try
            {
                miConexion = new SqlConnection("Data Source = WINAPWUMC1HYRCV\\SQLEXPRESS; Initial Catalog = Libreria; Integrated Security = True");// El Contenido de data source se obtiene de las propiedades de la base de datos. 
               
            }
            catch(Exception e)
            {
                MessageBox.Show("Error :" + e.Message, "Error inesperado", MessageBoxButtons.OK);
            }

           
        }
    }
}
