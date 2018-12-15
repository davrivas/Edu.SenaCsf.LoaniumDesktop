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
    public class MaterialDAO : IMaterialDAO {
        public MaterialDAO() {
        }

        public MaterialDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                MaterialDTO material = new MaterialDTO();
                string sql = "SELECT * " +
                    "FROM Material " +
                    "WHERE MaterialId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    int iId = Convert.ToInt32(reader["IdiomaId"].ToString().Trim()),
                        tmId = Convert.ToInt32(reader["TipoMaterialId"].ToString().Trim()),
                        emId = Convert.ToInt32(reader["EstadoMaterialId"].ToString().Trim()),
                        tId = Convert.ToInt32(reader["TematicaId"].ToString().Trim());
                    material.Id = Convert.ToInt32(reader["MaterialId"].ToString().Trim());
                    material.Titulo = reader["TituloMaterial"].ToString().Trim();
                    material.Autor = reader["AutorMaterial"].ToString().Trim();
                    material.FechaPublicacion = Convert.ToDateTime(reader["FechaPublicacion"].ToString().Trim());
                    material.Descripcion = reader["DescripcionMaterial"].ToString().Trim();
                    material.Isbn = reader["Isbn"].ToString().Trim();
                    material.Editorial = reader["Editorial"].ToString().Trim();
                    material.Issn = reader["Issn"].ToString().Trim();
                    material.Duracion = reader["Duracion"].ToString().Trim();
                    material.Idioma = DAO.IDAO.BuscarPorId(iId);
                    material.TipoMaterial = DAO.TmDAO.BuscarPorId(tmId);
                    material.EstadoMaterial = DAO.EmDAO.BuscarPorId(emId);
                    material.Tematica = DAO.TDAO.BuscarPorId(tId);

                    return material;
                } else {
                    MessageBox.Show("No se encontró material");
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

        public List<MaterialDTO> BusquedaAvanzada(string texto, IdiomaDTO i, TipoMaterialDTO tm) {
            throw new NotImplementedException();
        }

        public List<MaterialDTO> BusquedaSimple(string texto) {
            throw new NotImplementedException();
        }

        public int Contar() {
            throw new NotImplementedException();
        }

        public int ContarDiscos() {
            try {
                Conexion.Abrir();
                string sql = "SELECT COUNT(*) AS Discos " +
                    "FROM Material " +
                    "WHERE TipoMaterialId = 3 OR TipoMaterialId = 4";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    int cont = 0;
                    while (reader.Read()) {
                        cont++;
                    }
                    return cont;
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

        public int ContarLibros() {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Material " +
                    "WHERE TipoMaterialId = 1";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    int cont = 0;
                    while (reader.Read()) {
                        cont++;
                    }
                    return cont;
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

        public int ContarRevistas() {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Material " +
                    "WHERE TipoMaterialId = 2";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    int cont = 0;
                    while (reader.Read()) {
                        cont++;
                    }
                    return cont;
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

        public void Editar(MaterialDTO obj) {
            try {
                Conexion.Abrir();
                MaterialDTO nuevoMaterial = obj;
                string sql = "UPDATE Material VALUES" +
                    "('" + nuevoMaterial.Titulo.Trim() + "', " +
                    "'" + nuevoMaterial.Autor.Trim() + "', " +
                    "'" + nuevoMaterial.FechaPublicacion.ToShortDateString().Trim() + "', " +
                    "'" + nuevoMaterial.Descripcion.Trim() + "', " +
                    (nuevoMaterial.Isbn.Trim().Equals("") ? "NULL" : "'" + nuevoMaterial.Isbn.Trim() + "'") + ", " +
                    (nuevoMaterial.Editorial.Trim().Equals("") ? "NULL" : "'" + nuevoMaterial.Editorial.Trim() + "'") + ", " +
                    (nuevoMaterial.Issn.Trim().Equals("") ? "NULL" : "'" + nuevoMaterial.Issn.Trim() + "'") + ", " +
                    (nuevoMaterial.Duracion.Trim().Equals("") ? "NULL" : "'" + nuevoMaterial.Duracion.Trim() + "'") + ", " +
                    nuevoMaterial.Idioma.Id + ", " +
                    nuevoMaterial.Tematica.Id + ", " +
                    nuevoMaterial.TipoMaterial.Id + ", " +
                    "1) " +
                    "WHERE MaterialId = " + obj.Id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                int cant = cmd.ExecuteNonQuery();

                if (cant == 1) {
                    MessageBox.Show(nuevoMaterial.TipoMaterial.Tipo + " editado exitosamente");
                } else {
                    MessageBox.Show("ERROR: El " + nuevoMaterial.TipoMaterial.Tipo + " no fue editado exitosamente");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void Eliminar(MaterialDTO obj) {
            try {
                Conexion.Abrir();
                MaterialDTO nuevoMaterial = obj;
                string sql = "DELETE FROM Material " +
                    "WHERE MaterialId = " + obj.Id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                int cant = cmd.ExecuteNonQuery();

                if (cant == 1) {
                    MessageBox.Show(nuevoMaterial.TipoMaterial.Tipo + " eliminado exitosamente");
                } else {
                    MessageBox.Show("ERROR: El " + nuevoMaterial.TipoMaterial.Tipo + " no fue eliminado exitosamente");
                }
            } catch (SqlException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                if (Conexion.Conn != null) {
                    Conexion.Cerrar();
                }
            }
        }

        public void Ingresar(MaterialDTO obj) {
            try {
                Conexion.Abrir();
                MaterialDTO nuevoMaterial = obj;
                string sql = "INSERT INTO Material VALUES" +
                    "('" + nuevoMaterial.Titulo.Trim() + "', " +
                    "'"+ nuevoMaterial.Autor.Trim() +"', " +
                    "'" + nuevoMaterial.FechaPublicacion.ToShortDateString().Trim() + "', " +
                    "'" + nuevoMaterial.Descripcion.Trim() + "', " +
                    (nuevoMaterial.Isbn.Trim().Equals("") ? "NULL" : "'" + nuevoMaterial.Isbn.Trim() + "'") + ", " +
                    (nuevoMaterial.Editorial.Trim().Equals("") ? "NULL" : "'" + nuevoMaterial.Editorial.Trim() + "'") + ", " +
                    (nuevoMaterial.Issn.Trim().Equals("") ? "NULL" : "'" + nuevoMaterial.Issn.Trim() + "'") + ", " +
                    (nuevoMaterial.Duracion.Trim().Equals("") ? "NULL" : "'" + nuevoMaterial.Duracion.Trim() + "'") + ", " +
                    nuevoMaterial.Idioma.Id + ", " +
                    nuevoMaterial.Tematica.Id + ", " +
                    nuevoMaterial.TipoMaterial.Id + ", " +
                    "1)";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                int cant = cmd.ExecuteNonQuery();

                if (cant == 1) {
                    MessageBox.Show(nuevoMaterial.TipoMaterial.Tipo + " registrado exitosamente");
                } else {
                    MessageBox.Show("ERROR: El " + nuevoMaterial.TipoMaterial.Tipo + " no fue registrado exitosamente");
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
