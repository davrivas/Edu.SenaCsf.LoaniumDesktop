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
    public class IdiomaDAO : IIdiomaDAO {
        public IdiomaDAO() {
        }

        public IdiomaDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Idioma " +
                    "WHERE IdiomaId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    IdiomaDTO i = new IdiomaDTO(
                        Convert.ToInt32(reader["IdiomaId"].ToString()),
                        reader["NombreIdioma"].ToString(),
                        reader["SiglaIdioma"].ToString()
                    );
                    return i;
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

        public void Editar(IdiomaDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(IdiomaDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(IdiomaDTO obj) {
            throw new NotImplementedException();
        }
    }
}
