using Edu.SenaCsf.LoaniumDesktop.Datos.Conexion;
using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO {
    public class EstadoUsuarioDAO : IEstadoUsuarioDAO {
        public EstadoUsuarioDAO() {
        }

        public EstadoUsuarioDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM EstadoUsuario " +
                    "WHERE EstadoUsuarioId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    EstadoUsuarioDTO eu = new EstadoUsuarioDTO(
                        Convert.ToInt32(reader["EstadoUsuarioId"].ToString().Trim()),
                        reader["EstadoUsuario"].ToString().Trim()
                    );
                    return eu;
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

        public void Editar(EstadoUsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(EstadoUsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(EstadoUsuarioDTO obj) {
            throw new NotImplementedException();
        }
    }
}
