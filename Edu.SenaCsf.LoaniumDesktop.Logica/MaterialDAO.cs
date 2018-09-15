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
    public class MaterialDAO : IMaterialDAO {
        public MaterialDAO() {
        }

        public MaterialDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                DiscoDTO disco = new DiscoDTO();
                TipoMaterialDAO tmDAO = new TipoMaterialDAO();
                IdiomaDAO iDAO = new IdiomaDAO();
                EstadoMaterialDAO emDAO = new EstadoMaterialDAO();
                string sql = "SELECT * " +
                    "FROM Material " +
                    "WHERE MaterialId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    int iId = Convert.ToInt32(reader["IdiomaId"].ToString().Trim()),
                        tmId = Convert.ToInt32(reader["TipoMaterialId"].ToString().Trim()),
                        emId = Convert.ToInt32(reader["EstadoMaterialId"].ToString().Trim());
                    disco.Id = Convert.ToInt32(reader["MaterialId"].ToString().Trim());
                    disco.Titulo = reader["TituloMaterial"].ToString().Trim();
                    disco.Autor = reader["AutorMaterial"].ToString().Trim();
                    disco.FechaPublicacion = Convert.ToDateTime(reader["FechaPublicacion"].ToString().Trim());
                    disco.Descripcion = reader["DescripcionMaterial"].ToString().Trim();
                    disco.Idioma = iDAO.BuscarPorId(iId);
                    disco.TipoMaterial = tmDAO.BuscarPorId(tmId);
                    disco.EstadoMaterial = emDAO.BuscarPorId(emId);

                    Conexion.Abrir();
                    sql = "SELECT * " +
                        "FROM Disco " +
                        "WHERE DiscoId = " + id;
                    cmd = new SqlCommand(sql, Conexion.Conn);
                    reader = cmd.ExecuteReader();
                    if (reader.Read()) {
                        disco.Duracion = reader["DuracionDisco"].ToString().Trim();
                        return disco;
                    } else {
                        MessageBox.Show("No se encontró disco");
                        return null;
                    }
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
