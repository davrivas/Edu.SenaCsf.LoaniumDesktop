using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class TipoDocumentoDAO : ITipoDocumentoDAO {
        public TipoDocumentoDAO() {
        }

        public TipoDocumentoDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM TipoDocumento " +
                    "WHERE TipoDocumentoId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    TipoDocumentoDTO td = new TipoDocumentoDTO(
                        Convert.ToInt32(reader["TipoDocumentoId"].ToString()),
                        reader["TipoDocumento"].ToString(),
                        reader["SiglaTipoDocumento"].ToString()
                    );
                    return td;
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

        public void Editar(TipoDocumentoDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(TipoDocumentoDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(TipoDocumentoDTO obj) {
            throw new NotImplementedException();
        }

        public List<TipoDocumentoDTO> MostrarTodos() {
            try {
                Conexion.Abrir();
                List<TipoDocumentoDTO> tipos = new List<TipoDocumentoDTO>();
                string sql = "SELECT * " +
                    "FROM TipoDocumento";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.HasRows) {
                        TipoDocumentoDTO td = new TipoDocumentoDTO(
                            Convert.ToInt32(reader["TipoDocumentoId"].ToString()),
                            reader["TipoDocumento"].ToString(),
                            reader["SiglaTipoDocumento"].ToString()
                        );
                        tipos.Add(td);
                    }
                    return tipos;
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
