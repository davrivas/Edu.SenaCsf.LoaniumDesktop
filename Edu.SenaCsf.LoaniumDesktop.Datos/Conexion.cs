using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class Conexion {
        private static string cadenaConexion = "Data Source=DESKTOP-0S26F42\\SQLEXPRESS;Initial Catalog=Loanium;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(cadenaConexion);

        public static SqlConnection Abrir() {
            try {
                conn.Open();
            } catch (SqlException e) {
                conn.Close();
                MessageBox.Show("Error al conectar a la base de datos");
                
            }

            return conn;
        }

        public static void Cerrar() {
            try {
                conn.Close();
            } catch (SqlException e) {
                MessageBox.Show("No se pudo cerrar la conexión");
            }
        }
    }
}
