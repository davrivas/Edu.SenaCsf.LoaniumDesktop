using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class MotivoRechazoDAO : IMotivoRechazoDAO {
        public MotivoRechazoDAO() {
        }

        public MotivoRechazoDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM MotivoRechazo " +
                    "WHERE MotivoRechazoId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    MotivoRechazoDTO mr = new MotivoRechazoDTO(
                        Convert.ToInt32(reader["MotivoRechazoId"].ToString()),
                        reader["MotivoRechazo"].ToString()
                    );
                    return mr;
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

        public void Editar(MotivoRechazoDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(MotivoRechazoDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(MotivoRechazoDTO obj) {
            throw new NotImplementedException();
        }

        public List<MotivoRechazoDTO> MostrarTodos() {
            try {
                Conexion.Abrir();
                List<MotivoRechazoDTO> motivos = new List<MotivoRechazoDTO>();
                string sql = "SELECT * " +
                    "FROM MotivoRechazo";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.HasRows) {
                        MotivoRechazoDTO mr = new MotivoRechazoDTO(
                            Convert.ToInt32(reader["MotivoRechazoId"].ToString()),
                            reader["MotivoRechazo"].ToString()
                        );
                        motivos.Add(mr);
                    }
                    return motivos;
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
