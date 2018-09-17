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
    public class TipoMaterialDAO : ITipoMaterialDAO {
        public TipoMaterialDAO() {
        }

        public TipoMaterialDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM TipoMaterial " +
                    "WHERE TipoMaterialId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    TipoMaterialDTO tm = new TipoMaterialDTO(
                        Convert.ToInt32(reader["TipoMaterialId"].ToString().Trim()),
                        reader["TipoMaterial"].ToString().Trim()
                    );
                    return tm;
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

        public void Editar(TipoMaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(TipoMaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(TipoMaterialDTO obj) {
            throw new NotImplementedException();
        }
    }
}
