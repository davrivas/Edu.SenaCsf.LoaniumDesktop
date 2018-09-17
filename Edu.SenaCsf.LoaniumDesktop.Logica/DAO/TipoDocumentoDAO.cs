using Edu.SenaCsf.LoaniumDesktop.Datos.Conexion;
using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO {
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

                if (reader.Read()) {
                    TipoDocumentoDTO td = new TipoDocumentoDTO(
                        Convert.ToInt32(reader["TipoDocumentoId"].ToString().Trim()),
                        reader["TipoDocumento"].ToString().Trim(),
                        reader["SiglaTipoDocumento"].ToString().Trim()
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

        public int Contar() {
            throw new NotImplementedException();
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
    }
}
