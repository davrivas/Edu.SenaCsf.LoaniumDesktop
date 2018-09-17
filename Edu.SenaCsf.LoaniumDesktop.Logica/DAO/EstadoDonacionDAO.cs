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

                if (reader.Read()) {
                    EstadoDonacionDTO ed = new EstadoDonacionDTO(
                        Convert.ToInt32(reader["EstadoDonacionId"].ToString()),
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

        public int Contar() {
            throw new NotImplementedException();
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
    }
}
