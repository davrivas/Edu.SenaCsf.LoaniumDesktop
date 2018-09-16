using Edu.SenaCsf.LoaniumDesktop.Datos.Conexion;
using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.Sesion;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO {
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
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + u.Id + " " +
                    "AND Clave = '" + claveActual + "'";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    if (claveActual.Equals(confirmacion)) {
                        Conexion.Abrir();
                        sql = "UPDATE Usuario " +
                            "SET Clave = '" + claveNueva + "' " +
                            "WHERE UsuarioId = " + u.Id;
                        cmd = new SqlCommand(sql, Conexion.Conn);
                        reader = cmd.ExecuteReader();
                        int cant = cmd.ExecuteNonQuery();

                        if (cant == 1) {
                            MessageBox.Show("ERROR: Se cambió la contraseña correctamente");
                        } else {
                            MessageBox.Show("ERROR: No se pudo cambiar la contraseña");
                        }
                    } else {
                        MessageBox.Show("ERROR: No es posible cambiar la clave");
                    }
                } else {
                    MessageBox.Show("ERROR: La clave actual no coincide");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void CerrarSesion() {
            Sesion.Sesion.Usuario = null;
            //Redirigir
        }

        public void Editar(UsuarioDTO obj) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + obj.Id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    Conexion.Abrir();
                    sql = "UPDATE Usuario " +
                        "SET Nombres = '" + obj.Nombres.Trim() + "', " +
                        "Apellidos = '" + obj.Apellidos.Trim() + "', " +
                        "Documento = '" + obj.Documento.Trim() + "', " +
                        "FechaNacimiento = '" + obj.FechaNacimiento.ToShortDateString().Trim() + "', " +
                        "CorreoElectronico = '" + obj.CorreoElectronico.Trim() + "', " +
                        "Clave = '" + obj.Clave.Trim() + "', " +
                        "Telefono = '" + obj.Telefono.Trim() + "', " +
                        "TipoUsuarioId = " + obj.TipoUsuario.Id + ", " +
                        "TipoDocumentoId = " + obj.TipoDocumento.Id + ", " +
                        "WHERE UsuarioId = " + obj.Id;
                    cmd = new SqlCommand(sql, Conexion.Conn);
                    reader = cmd.ExecuteReader();
                    int cant = cmd.ExecuteNonQuery();

                    if (cant == 1) {
                        MessageBox.Show("Se editó el usuario correctamente");
                    } else {
                        MessageBox.Show("ERROR: No se editó el usuario correctamente");
                    }
                } else {
                    MessageBox.Show("ERROR: No es posible editar usuario");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void EditarPerfil(UsuarioDTO u) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + u.Id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    Conexion.Abrir();
                    sql = "UPDATE Usuario " +
                        "SET Nombres = '" + u.Nombres.Trim() + "', " +
                        "Apellidos = '" + u.Apellidos.Trim() + "', " +
                        "Documento = '" + u.Documento.Trim() + "', " +
                        "FechaNacimiento = '" + u.FechaNacimiento.ToShortDateString().Trim() + "', " +
                        "CorreoElectronico = '" + u.CorreoElectronico.Trim() + "', " +
                        "Telefono = '" + u.Telefono.Trim() + "' " +
                        "WHERE UsuarioId = " + u.Id;
                    cmd = new SqlCommand(sql, Conexion.Conn);
                    reader = cmd.ExecuteReader();
                    int cant = cmd.ExecuteNonQuery();

                    if (cant == 1) {
                        MessageBox.Show("Se editó el perfil correctamente");
                    } else {
                        MessageBox.Show("ERROR: No se editó el perfil correctamente");
                    }
                } else {
                    MessageBox.Show("ERROR: No es posible editar perfil");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void Eliminar(UsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(UsuarioDTO obj) {
            try {
                Conexion.Abrir();
                string sql = "INSERT INTO Usuario VALUES" +
                    "('" + obj.Nombres.Trim()  + "', " +
                    "'" + obj.Apellidos.Trim() +"', " +
                    "'" + obj.Documento.Trim() + "', " +
                    "'" + obj.FechaNacimiento.ToShortDateString().Trim() + "', " +
                    "'" + obj.CorreoElectronico.Trim() + "', " +
                    "'" + obj.Clave.Trim() + "', " +
                    "'" + obj.Telefono.Trim() + "', " +
                    obj.TipoUsuario.Id + ", " +
                    obj.TipoDocumento.Id + ", " +
                    "1)";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                int cant = cmd.ExecuteNonQuery();

                if (cant == 1) {
                    MessageBox.Show("Usuario registrado exitosamente");
                } else {
                    MessageBox.Show("ERROR: El usuario no fue registrado exitosamente");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public int IniciarSesion(TipoDocumentoDTO td, string documento, string clave) {
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
                    UsuarioDTO u = new UsuarioDTO (
                        Convert.ToInt32(reader["UsuarioId"].ToString().Trim()),
                        reader["Nombres"].ToString().Trim(),
                        reader["Apellidos"].ToString().Trim(),
                        reader["Documento"].ToString().Trim(),
                        Convert.ToDateTime(reader["FechaNacimiento"].ToString().Trim()),
                        reader["CorreoElectronico"].ToString().Trim(),
                        reader["Clave"].ToString().Trim(),
                        reader["Telefono"].ToString().Trim(),
                        td,
                        tuDAO.BuscarPorId(tuId),
                        euDAO.BuscarPorId(euId)
                    );

                    if (u.EstadoUsuario.Id == 1) {
                        Sesion.Sesion.Usuario = u;
                        return 1;
                    } if (u.EstadoUsuario.Id == 2) {
                        return 2;
                    } else { 
                        //ReactivarCuenta(u);
                        return 3;
                    }
                } else {
                    return 0;
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
                return 0;
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

        public void ReactivarCuenta(UsuarioDTO u) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + u.Id + " " +
                    "AND EstadoUsuarioId = 3";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    Conexion.Abrir();
                    sql = "UPDATE Usuario " +
                        "SET EstadoUsuarioId = 1";
                    cmd = new SqlCommand(sql, Conexion.Conn);
                    reader = cmd.ExecuteReader();
                    int cant = cmd.ExecuteNonQuery();

                    if (cant == 1) {
                        MessageBox.Show("Se reactivó la cuenta correctamente");
                    } else {
                        MessageBox.Show("ERROR: No se reactivó la cuenta correctamente");
                    }
                } else {
                    MessageBox.Show("ERROR: No es posible reactivar cuenta");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void ReactivarUsuario(UsuarioDTO u) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + u.Id + " " +
                    "AND EstadoUsuarioId = 2";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    Conexion.Abrir();
                    sql = "UPDATE Usuario " +
                        "SET EstadoUsuarioId = 1";
                    cmd = new SqlCommand(sql, Conexion.Conn);
                    reader = cmd.ExecuteReader();
                    int cant = cmd.ExecuteNonQuery();

                    if (cant == 1) {
                        MessageBox.Show("Se reactivó al usuario correctamente");
                    } else {
                        MessageBox.Show("ERROR: No se reactivó al usuario correctamente");
                    }
                } else {
                    MessageBox.Show("ERROR: No es posible reactivar al usuario");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void Registrarse(UsuarioDTO u) {
            try {
                Conexion.Abrir();
                string sql = "INSERT INTO Usuario VALUES" +
                    "('" + u.Nombres.Trim() + "', " +
                    "'" + u.Apellidos.Trim() + "', " +
                    "'" + u.Documento.Trim() + "', " +
                    "'" + u.FechaNacimiento.ToShortDateString().Trim() + "', " +
                    "'" + u.CorreoElectronico.Trim() + "', " +
                    "'" + u.Clave.Trim() + "', " +
                    "'" + u.Telefono.Trim() + "', " +
                    "2, " +
                    u.TipoDocumento.Id + ", " +
                    "1)";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                int cant = cmd.ExecuteNonQuery();

                if (cant == 1) {
                    MessageBox.Show("Registro realizado exitosamente");
                } else {
                    MessageBox.Show("ERROR: El registro no fue realizado exitosamente");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void SuspenderCuenta(UsuarioDTO u) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + u.Id + " " +
                    "AND EstadoUsuarioId = 1";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    Conexion.Abrir();
                    sql = "UPDATE Usuario " +
                        "SET EstadoUsuarioId = 3";
                    cmd = new SqlCommand(sql, Conexion.Conn);
                    reader = cmd.ExecuteReader();
                    int cant = cmd.ExecuteNonQuery();

                    if (cant == 1) {
                        MessageBox.Show("Se suspendió cuenta correctamente");
                        CerrarSesion();
                    } else {
                        MessageBox.Show("ERROR: No se suspendió cuenta correctamente");
                    }
                } else {
                    MessageBox.Show("ERROR: No es posible suspender cuenta");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void SuspenderUsuario(UsuarioDTO u) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + u.Id + " " +
                    "AND EstadoUsuarioId = 1";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    Conexion.Abrir();
                    sql = "UPDATE Usuario " +
                        "SET EstadoUsuarioId = 2";
                    cmd = new SqlCommand(sql, Conexion.Conn);
                    reader = cmd.ExecuteReader();
                    int cant = cmd.ExecuteNonQuery();

                    if (cant == 1) {
                        MessageBox.Show("Se suspendió al usuario correctamente");
                        CerrarSesion();
                    } else {
                        MessageBox.Show("ERROR: No se suspendió al usuario correctamente");
                    }
                } else {
                    MessageBox.Show("ERROR: No es posible suspender usuario");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }
    }
}
