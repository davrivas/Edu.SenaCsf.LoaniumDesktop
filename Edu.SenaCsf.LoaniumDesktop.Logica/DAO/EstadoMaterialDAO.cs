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
    public class EstadoMaterialDAO : IEstadoMaterialDAO {
        public EstadoMaterialDAO() {
        }

        public EstadoMaterialDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM EstadoMaterial " +
                    "WHERE EstadoMaterialId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    EstadoMaterialDTO em = new EstadoMaterialDTO(
                        Convert.ToInt32(reader["EstadoMaterialId"].ToString()),
                        reader["EstadoMaterial"].ToString()
                    );
                    return em;
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

        public void Editar(EstadoMaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(EstadoMaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(EstadoMaterialDTO obj) {
            throw new NotImplementedException();
        }
    }
}
