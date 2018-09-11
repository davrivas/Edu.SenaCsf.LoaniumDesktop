using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class PQRSDAO : IPQRSDAO {
        public PQRSDAO() {
        }

        public PQRSDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM PQRS " +
                    "WHERE PQRSId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    PQRSDTO pqrs = new PQRSDTO(
                        Convert.ToInt32(reader["PQRSId"].ToString()),
                        reader["RemitentePQRS"].ToString(),
                        reader["MensajePQRS"].ToString(),
                        new TipoPQRSDAO().BuscarPorId(Convert.ToInt32(reader["TipoPQRSId"].ToString())),
                        new EstadoPQRSDAO().BuscarPorId(Convert.ToInt32(reader["EstadoPQRSId"].ToString()))
                    );
                    pqrs.Respuesta = (reader["RespuestaPQRS"] != null) ? reader["RespuestaPQRS"].ToString() : null;
                    pqrs.Usuario = (reader["UsuarioId"] != null) ? new UsuarioDAO().BuscarPorId(Convert.ToInt32(reader["UsuarioId"].ToString())) : null;
                    return pqrs;
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

        public void Editar(PQRSDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(PQRSDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(PQRSDTO obj) {
            throw new NotImplementedException();
        }

        public List<PQRSDTO> MostrarTodos() {
            try {
                Conexion.Abrir();
                List<PQRSDTO> listaPQRS = new List<PQRSDTO>();
                string sql = "SELECT * " +
                    "FROM PQRS";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.HasRows) {
                        PQRSDTO pqrs = new PQRSDTO(
                            Convert.ToInt32(reader["PQRSId"].ToString()),
                            reader["RemitentePQRS"].ToString(),
                            reader["MensajePQRS"].ToString(),
                            new TipoPQRSDAO().BuscarPorId(Convert.ToInt32(reader["TipoPQRSId"].ToString())),
                            new EstadoPQRSDAO().BuscarPorId(Convert.ToInt32(reader["EstadoPQRSId"].ToString()))
                        );
                        pqrs.Respuesta = (reader["RespuestaPQRS"] != null) ? reader["RespuestaPQRS"].ToString() : null;
                        pqrs.Usuario = (reader["UsuarioId"] != null) ? new UsuarioDAO().BuscarPorId(Convert.ToInt32(reader["UsuarioId"].ToString())) : null;
                        listaPQRS.Add(pqrs);
                    }
                    return listaPQRS;
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

        public void ResponderPQRS(PQRSDTO pqrs) {
            throw new NotImplementedException();
        }
    }
}
