using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class EstadoPrestamoDAO : IEstadoPrestamoDAO {
        public EstadoPrestamoDAO() {
        }

        public EstadoPrestamoDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM EstadoPrestamo " +
                    "WHERE EstadoPrestamoId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    EstadoPrestamoDTO ep = new EstadoPrestamoDTO(
                        Convert.ToInt32(reader["EstadoPrestamoId"].ToString()),
                        reader["EstadoPrestamo"].ToString()
                    );
                    return ep;
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

        public void Editar(EstadoPrestamoDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(EstadoPrestamoDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(EstadoPrestamoDTO obj) {
            throw new NotImplementedException();
        }

        public List<EstadoPrestamoDTO> MostrarTodos() {
            try {
                Conexion.Abrir();
                List<EstadoPrestamoDTO> estados = new List<EstadoPrestamoDTO>();
                string sql = "SELECT * " +
                    "FROM EstadoPrestamo";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.HasRows) {
                        EstadoPrestamoDTO ep = new EstadoPrestamoDTO(
                            Convert.ToInt32(reader["EstadoPrestamoId"].ToString()),
                            reader["EstadoPrestamo"].ToString()
                        );
                        estados.Add(ep);
                    }
                    return estados;
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
    }
}
