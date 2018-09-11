using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class ColeccionDAO : IColeccionDAO {
        public ColeccionDAO() {
        }

        public ColeccionDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Coleccion " +
                    "WHERE ColeccionId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    ColeccionDTO c = new ColeccionDTO(
                        Convert.ToInt32(reader["ColeccionId"].ToString()),
                        reader["Coleccion"].ToString(),
                        reader["IsbnColeccion"].ToString(),
                        new LibroDTO()
                    );
                    return c;
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

        public void Editar(ColeccionDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(ColeccionDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(ColeccionDTO obj) {
            throw new NotImplementedException();
        }

        public List<ColeccionDTO> MostrarTodos() {
            throw new NotImplementedException();
        }
    }
}
