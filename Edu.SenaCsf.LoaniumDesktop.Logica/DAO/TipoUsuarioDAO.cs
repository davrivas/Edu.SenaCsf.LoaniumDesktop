using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class TipoUsuarioDAO : ITipoUsuarioDAO {
        public TipoUsuarioDAO() {
        }

        public TipoUsuarioDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM TipoUsuario " +
                    "WHERE TipoUsuarioId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    TipoUsuarioDTO tu = new TipoUsuarioDTO(
                        Convert.ToInt32(reader["TipoUsuarioId"].ToString().Trim()),
                        reader["TipoUsuario"].ToString().Trim()
                    );
                    return tu;
                } else {
                    return null;
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
                return null;
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void Editar(TipoUsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(TipoUsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(TipoUsuarioDTO obj) {
            throw new NotImplementedException();
        }
    }
}
