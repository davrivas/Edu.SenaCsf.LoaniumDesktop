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

        public static SqlConnection Conn { get => conn; set => conn = value; }

        public static void Abrir() {
            try {
                Conn.Open();
            } catch (SqlException e) {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }
        }

        public static void Cerrar() {
            try {
                Conn.Close();
            } catch (SqlException e) {
                MessageBox.Show("No se pudo terminar la conexión a la base de datos");
            }
        }
    }
}
