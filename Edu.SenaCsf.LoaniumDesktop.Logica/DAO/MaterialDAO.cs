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
                    material.Idioma = DAO.IDAO.BuscarPorId(iId);
                    material.TipoMaterial = DAO.TmDAO.BuscarPorId(tmId);
                    material.EstadoMaterial = DAO.EmDAO.BuscarPorId(emId);
                    material.Tematica = DAO.TDAO.BuscarPorId(tId);

                    switch (material.TipoMaterial.Id) { // Se revisa el tipo de material
                        case 1:
                            material.Isbn = reader["Isbn"].ToString().Trim();
                            material.Editorial = reader["Editorial"].ToString().Trim();
                            break;
                        case 2:
                            material.Issn = reader["Issn"].ToString().Trim();
                            break;
                        default:
                            material.Duracion = reader["Duracion"].ToString().Trim();
                            break;
                    }

                    return material;
                } else {
                    MessageBox.Show("No se encontró disco");
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

        public void Editar(MaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(MaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(MaterialDTO obj) {
            try {
                Conexion.Abrir();
                string sql = "INSERT INTO Material VALUES" +
                    "('" + obj.Titulo.Trim() + "', " +
                    "'"+ obj.Autor.Trim() +"', " +
                    "'" + obj.FechaPublicacion.ToShortDateString().Trim() + "', " +
                    "'" + obj.Descripcion.Trim() + "', " +
                    "'" + obj.Isbn.Trim() + "', " +
                    "'" + obj.Editorial.Trim() + "', " +
                    "'" + obj.Issn.Trim() + "', " +
                    "'" + obj.Duracion.Trim() + "', " +
                    obj.Idioma.Id + ", " +
                    obj.Tematica.Id + ", " +
                    obj.TipoMaterial.Id + ", " +
                    "1)";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                int cant = cmd.ExecuteNonQuery();

                if (cant == 1) {
                    MessageBox.Show(obj.TipoMaterial.Tipo + " registrado exitosamente");
                } else {
                    MessageBox.Show("ERROR: El " + obj.TipoMaterial.Tipo + " no fue registrado exitosamente");
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
