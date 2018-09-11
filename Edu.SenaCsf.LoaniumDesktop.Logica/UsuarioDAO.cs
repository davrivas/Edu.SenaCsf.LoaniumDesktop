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
                string sql = "SELECT TOP (1) * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return new UsuarioDTO {
                        Id = Convert.ToInt32(reader["UsuarioId"].ToString()),
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Documento = reader["Documento"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"].ToString()),
                        CorreoElectronico = reader["CorreoElectronico"].ToString(),
                        Clave = reader["Clave"].ToString(),
                        Telefono = (reader["Telefono"] == null) ? null : reader["Telefono"].ToString(),
                        TipoDocumento = new TipoDocumentoDAO().BuscarPorId(Convert.ToInt32(reader["TipoDocumentoId"].ToString())),
                        TipoUsuario = new TipoUsuarioDAO().BuscarPorId(Convert.ToInt32(reader["TipoUsuarioId"].ToString())),
                        EstadoUsuario = new EstadoUsuarioDAO().BuscarPorId(Convert.ToInt32(reader["EstadoUsuarioId"].ToString()))
                    };
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

        public bool /*UsuarioDTO*/ IniciarSesion(int td, string documento, string clave) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP (1) * " +
                    "FROM Usuario " +
                    "WHERE TipoDocumentoId = " + td +" " +
                    "AND Documento = '" + documento + "' " +
                    "AND Clave = '" + clave + "'";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    /*UsuarioDTO u = new UsuarioDTO {
                        Id = Convert.ToInt32(reader["UsuarioId"].ToString()),
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Documento = reader["Documento"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"].ToString()),
                        CorreoElectronico = reader["CorreoElectronico"].ToString(),
                        Clave = reader["Clave"].ToString(),
                        Telefono = (reader["Telefono"] == null) ? null : reader["Telefono"].ToString(),
                        TipoDocumento = new TipoDocumentoDAO().BuscarPorId(Convert.ToInt32(reader["TipoDocumentoId"].ToString())),
                        TipoUsuario = new TipoUsuarioDAO().BuscarPorId(Convert.ToInt32(reader["TipoUsuarioId"].ToString())),
                        EstadoUsuario = new EstadoUsuarioDAO().BuscarPorId(Convert.ToInt32(reader["EstadoUsuarioId"].ToString()))
                    };
                    MessageBox.Show("Bienvenido " + u.Nombres + " " + u.Apellidos);
                    return u;*/
                    return true;
                } else {
                    //return null;
                    return false;
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
                //return null;
                return false;
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
