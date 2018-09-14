using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class EjemplarMaterialDAO : IEjemplarMaterialDAO {
        public EjemplarMaterialDAO() {
        }

        public List<EjemplarMaterialDTO> BuscarEjemplares(MaterialDTO m) {
            try {
                Conexion.Abrir();
                EstadoMaterialDAO emDAO = new EstadoMaterialDAO();
                List<EjemplarMaterialDTO> ejemplares = new List<EjemplarMaterialDTO>();
                string sql = "SELECT * " +
                    "FROM EjemplarMaterial " +
                    "WHERE MaterialId = " + m.Id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    while (reader.Read()) {
                        int emId = Convert.ToInt32(reader["EstadoMaterialId"].ToString().Trim());
                        EjemplarMaterialDTO ej = new EjemplarMaterialDTO(
                            Convert.ToInt32(reader["EjemplarMaterialId"].ToString().Trim()),
                            reader["NumeroTopografico"].ToString().Trim(),
                            emDAO.BuscarPorId(emId)
                        );
                        ejemplares.Add(ej);
                    }

                    return ejemplares;
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

        public EjemplarMaterialDTO BuscarPorId(int id) {
            throw new NotImplementedException();
        }

        public void Editar(EjemplarMaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(EjemplarMaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(EjemplarMaterialDTO obj) {
            throw new NotImplementedException();
        }

        public List<EjemplarMaterialDTO> MostrarTodos() {
            throw new NotImplementedException();
        }
    }
}
