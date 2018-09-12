using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
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

        public List<TipoPQRSDTO> MostrarTodos() {
            try {
                Conexion.Abrir();
                List<TipoPQRSDTO> tipos = new List<TipoPQRSDTO>();
                string sql = "SELECT * " +
                    "FROM TipoPQRS";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    while (reader.Read()) {
                        TipoPQRSDTO tpqrs = new TipoPQRSDTO(
                            Convert.ToInt32(reader["TipoPQRSId"].ToString()),
                            reader["TipoPQRS"].ToString()
                        );
                        tipos.Add(tpqrs);
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
