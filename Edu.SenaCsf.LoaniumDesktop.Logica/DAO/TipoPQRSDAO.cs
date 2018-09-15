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
    public class TipoPQRSDAO : ITipoPQRSDAO {
        public TipoPQRSDAO() {
        }

        public TipoPQRSDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM TipoPQRS " +
                    "WHERE TipoPQRSId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    TipoPQRSDTO tpqrs = new TipoPQRSDTO(
                        Convert.ToInt32(reader["TipoPQRSId"].ToString()),
                        reader["TipoPQRS"].ToString()
                    );
                    return tpqrs;
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

        public void Editar(TipoPQRSDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(TipoPQRSDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(TipoPQRSDTO obj) {
            throw new NotImplementedException();
        }
    }
}
