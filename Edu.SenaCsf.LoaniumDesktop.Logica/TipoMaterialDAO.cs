﻿using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class TipoMaterialDAO : ITipoMaterialDAO {
        public TipoMaterialDAO() {
        }

        public TipoMaterialDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM TipoMaterial " +
                    "WHERE TipoMaterialId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    TipoMaterialDTO tm = new TipoMaterialDTO(
                        Convert.ToInt32(reader["TipoMaterialId"].ToString()),
                        reader["TipoMaterial"].ToString()
                    );
                    return tm;
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

        public void Editar(TipoMaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(TipoMaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(TipoMaterialDTO obj) {
            throw new NotImplementedException();
        }
    }
}
