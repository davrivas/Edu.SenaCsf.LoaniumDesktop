﻿using Edu.SenaCsf.LoaniumDesktop.Datos.Conexion;
using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO {
    public class EstadoPrestamoDAO : IEstadoPrestamoDAO {
        public EstadoPrestamoDAO() {
        }

        public EstadoPrestamoDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT TOP(1) * " +
                    "FROM EstadoPrestamo " +
                    "WHERE EstadoPrestamoId = " + id;
                SqlCommand cmd = new SqlCommand(sql, Conexion.Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    EstadoPrestamoDTO ep = new EstadoPrestamoDTO(
                        Convert.ToInt32(reader["EstadoPrestamoId"].ToString()),
                        reader["EstadoPrestamo"].ToString()
                    );
                    return ep;
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

        public int Contar() {
            throw new NotImplementedException();
        }

        public void Editar(EstadoPrestamoDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(EstadoPrestamoDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(EstadoPrestamoDTO obj) {
            throw new NotImplementedException();
        }
    }
}
