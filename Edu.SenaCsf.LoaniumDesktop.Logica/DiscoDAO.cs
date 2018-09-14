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
    public class DiscoDAO : IDiscoDAO {
        public DiscoDAO() {
        }

        public DiscoDTO BuscarPorId(int id) {
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

        public void Editar(DiscoDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(DiscoDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(DiscoDTO obj) {
            try {
                Conexion.Abrir();
                string sql = "INSERT INTO Material VALUES " +
                    "('" + obj.Titulo.Trim() + "', " +
                    "'" + obj.Autor.Trim() + "', " +
                    "'" + obj.FechaPublicacion.ToShortDateString().Trim() +"', " +
                    "'" + obj.Descripcion + "', " +
                    obj.Idioma.Id + ", " +
                    "3)";
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                int cant = cmd.ExecuteNonQuery();

                if (cant == 1) {
                    Conexion.Abrir();
                    int random = new Random().Next(9999);
                    sql = "INSERT INTO Disco VALUES " +
                        "('" + obj.TipoMaterial.Sigla + "')";// Generar número aleatorio
                } else {
                    MessageBox.Show("No es posible insertar material");
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
