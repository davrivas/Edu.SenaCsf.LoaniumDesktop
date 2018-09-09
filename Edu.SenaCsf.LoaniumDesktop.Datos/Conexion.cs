using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class Conexion {
        private static string cadenaConexion = "";
        private static SqlConnection conexion = new SqlConnection(cadenaConexion);
    }
}
