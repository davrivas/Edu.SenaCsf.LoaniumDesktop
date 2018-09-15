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
        private TipoMaterialDAO tmDAO = new TipoMaterialDAO();
        private IdiomaDAO iDAO = new IdiomaDAO();
        private EstadoMaterialDAO emDAO = new EstadoMaterialDAO();
        private TematicaDAO tDAO = new TematicaDAO();

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
                    material.Idioma = iDAO.BuscarPorId(iId);
                    material.TipoMaterial = tmDAO.BuscarPorId(tmId);
                    material.EstadoMaterial = emDAO.BuscarPorId(emId);
                    material.Tematica = tDAO.BuscarPorId(tId);

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

        public void Editar(MaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(MaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(MaterialDTO obj) {
            throw new NotImplementedException();
        }
    }
}
