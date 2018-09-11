using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class EstadoDonacionDAO : IEstadoDonacionDAO {
        public EstadoDonacionDAO() {
        }

        public EstadoDonacionDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM EstadoDonacion " +
                    "WHERE EstadoDonacionId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    EstadoDonacionDTO ed = new EstadoDonacionDTO(
                        Convert.ToInt32(reader["EstadoDonacionId"]),
                        reader["EstadoDonacion"].ToString()
                    );
                    return ed;
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

        public void Editar(EstadoDonacionDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(EstadoDonacionDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(EstadoDonacionDTO obj) {
            throw new NotImplementedException();
        }

        public List<EstadoDonacionDTO> MostrarTodos() {
            try {
                Conexion.Abrir();
                List<EstadoDonacionDTO> estados = new List<EstadoDonacionDTO>();
                string sql = "SELECT * " +
                    "FROM EstadoDonacion";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.HasRows) {
                    EstadoDonacionDTO ed = new EstadoDonacionDTO (
                        Convert.ToInt32(reader["EstadoDonacionId"]),
                        reader["EstadoDonacion"].ToString()
                    );
                    estados.Add(ed);
                }
                return estados;
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
                return null;
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }
    }
}
