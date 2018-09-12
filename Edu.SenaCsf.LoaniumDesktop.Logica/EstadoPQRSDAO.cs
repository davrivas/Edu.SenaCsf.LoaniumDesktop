using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class EstadoPQRSDAO : IEstadoPQRSDAO {
        public EstadoPQRSDAO() {
        }

        public EstadoPQRSDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM EstadoPQRS " +
                    "WHERE EstadoPQRSId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    EstadoPQRSDTO epqrs = new EstadoPQRSDTO(
                        Convert.ToInt32(reader["EstadoPQRSId"].ToString()),
                        reader["EstadoPQRS"].ToString()
                    );
                    return epqrs;
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

        public void Editar(EstadoPQRSDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(EstadoPQRSDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(EstadoPQRSDTO obj) {
            throw new NotImplementedException();
        }

        public List<EstadoPQRSDTO> MostrarTodos() {
            try {
                Conexion.Abrir();
                List<EstadoPQRSDTO> estados = new List<EstadoPQRSDTO>();
                string sql = "SELECT * " +
                    "FROM EstadoPQRS";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    while (reader.Read()) {
                        EstadoPQRSDTO epqrs = new EstadoPQRSDTO(
                            Convert.ToInt32(reader["EstadoPQRSId"].ToString()),
                            reader["EstadoPQRS"].ToString()
                        );
                        estados.Add(epqrs);
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
