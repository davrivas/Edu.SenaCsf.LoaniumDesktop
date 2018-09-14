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
    public class UsuarioDAO : IUsuarioDAO {
        public UsuarioDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                TipoDocumentoDAO tdDAO = new TipoDocumentoDAO();
                TipoUsuarioDAO tuDAO = new TipoUsuarioDAO();
                EstadoUsuarioDAO euDAO = new EstadoUsuarioDAO();
                string sql = "SELECT TOP (1) * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    int tdId = Convert.ToInt32(reader["TipoDocumentoId"].ToString().Trim()),
                        tuId = Convert.ToInt32(reader["TipoUsuarioId"].ToString().Trim()),
                        euId = Convert.ToInt32(reader["EstadoUsuarioId"].ToString().Trim());
                    return new UsuarioDTO ( 
                        Convert.ToInt32(reader["UsuarioId"].ToString()),
                        reader["Nombres"].ToString().Trim(),
                        reader["Apellidos"].ToString().Trim(),
                        reader["Documento"].ToString().Trim(),
                        Convert.ToDateTime(reader["FechaNacimiento"].ToString().Trim()),
                        reader["CorreoElectronico"].ToString().Trim(),
                        reader["Clave"].ToString().Trim(),
                        reader["Telefono"].ToString().Trim(),
                        tdDAO.BuscarPorId(tdId),
                        tuDAO.BuscarPorId(tuId),
                        euDAO.BuscarPorId(euId)
                    );
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

        public void CambiarClave(UsuarioDTO u, string claveActual, string claveNueva, string confirmacion) {
            throw new NotImplementedException();
        }

        public void CerrarSesion() {
            throw new NotImplementedException();
        }

        public void Editar(UsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void EditarPerfil(UsuarioDTO u) {
            throw new NotImplementedException();
        }

        public void Eliminar(UsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(UsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public UsuarioDTO IniciarSesion(TipoDocumentoDTO td, string documento, string clave) {
            try {
                Conexion.Abrir();
                TipoUsuarioDAO tuDAO = new TipoUsuarioDAO();
                EstadoUsuarioDAO euDAO = new EstadoUsuarioDAO();
                string sql = "SELECT TOP (1) * " +
                    "FROM Usuario " +
                    "WHERE TipoDocumentoId = " + td.Id +" " +
                    "AND Documento = '" + documento + "' " +
                    "AND Clave = '" + clave + "'";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    int tuId = Convert.ToInt32(reader["TipoUsuarioId"].ToString().Trim());
                    int euId = Convert.ToInt32(reader["EstadoUsuarioId"].ToString().Trim());
                    UsuarioDTO u = new UsuarioDTO {
                        Id = Convert.ToInt32(reader["UsuarioId"].ToString().Trim()),
                        Nombres = reader["Nombres"].ToString().Trim(),
                        Apellidos = reader["Apellidos"].ToString().Trim(),
                        Documento = reader["Documento"].ToString().Trim(),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"].ToString().Trim()),
                        CorreoElectronico = reader["CorreoElectronico"].ToString().Trim(),
                        Clave = reader["Clave"].ToString().Trim(),
                        Telefono = reader["Telefono"].ToString().Trim(),
                        TipoDocumento = td,
                        TipoUsuario = tuDAO.BuscarPorId(tuId),
                        EstadoUsuario = euDAO.BuscarPorId(euId)
                    };
                    return u;
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

        public List<UsuarioDTO> MostrarNoSuspendidos(EstadoUsuarioDTO eu) {
            throw new NotImplementedException();
        }

        public List<UsuarioDTO> MostrarSuspendidos(EstadoUsuarioDTO eu) {
            throw new NotImplementedException();
        }

        public List<UsuarioDTO> MostrarTodos() {
            throw new NotImplementedException();
        }

        public void ReactivarCuenta(UsuarioDTO u) {
            throw new NotImplementedException();
        }

        public void ReactivarUsuario(UsuarioDTO u) {
            throw new NotImplementedException();
        }

        public void SuspenderCuenta(UsuarioDTO u) {
            throw new NotImplementedException();
        }

        public void SuspenderUsuario(UsuarioDTO u) {
            throw new NotImplementedException();
        }
    }
}
