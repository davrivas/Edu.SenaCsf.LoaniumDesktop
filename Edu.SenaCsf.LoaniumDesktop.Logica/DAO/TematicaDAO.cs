using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class TematicaDAO : ITematicaDAO {
        public TematicaDAO() {
        }

        public TematicaDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Tematica " +
                    "WHERE TematicaId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    TematicaDTO t = new TematicaDTO(
                        Convert.ToInt32(reader["TematicaId"].ToString()),
                        reader["NumeroDewey"].ToString(),
                        reader["Tematica"].ToString()
                    );
                    return t;
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

        public void Editar(TematicaDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(TematicaDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(TematicaDTO obj) {
            throw new NotImplementedException();
        }
    }
}
