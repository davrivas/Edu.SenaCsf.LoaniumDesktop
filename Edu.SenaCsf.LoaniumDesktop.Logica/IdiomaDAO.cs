using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
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

                if (reader.HasRows) {
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

        public void Editar(IdiomaDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(IdiomaDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(IdiomaDTO obj) {
            throw new NotImplementedException();
        }

        public List<IdiomaDTO> MostrarTodos() {
            try {
                Conexion.Abrir();
                List<IdiomaDTO> idiomas = new List<IdiomaDTO>();
                string sql = "SELECT * " +
                    "FROM Idioma";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.HasRows) {
                        IdiomaDTO i = new IdiomaDTO(
                            Convert.ToInt32(reader["IdiomaId"].ToString()),
                            reader["NombreIdioma"].ToString(),
                            reader["SiglaIdioma"].ToString()
                        );
                        idiomas.Add(i);
                    }
                    return idiomas;
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
