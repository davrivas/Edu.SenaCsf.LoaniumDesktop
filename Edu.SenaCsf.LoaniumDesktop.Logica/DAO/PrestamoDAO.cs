﻿using Edu.SenaCsf.LoaniumDesktop.Datos.Conexion;
using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO {
    public class PrestamoDAO : IPrestamoDAO {
        public PrestamoDAO() {
        }

        public PrestamoDTO BuscarPorId(int id) {
            throw new NotImplementedException();
        }

        public void Editar(PrestamoDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(PrestamoDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(PrestamoDTO obj) {
            throw new NotImplementedException();
        }

        public List<PrestamoDTO> MostrarPorUsuario(UsuarioDTO u) {
            throw new NotImplementedException();
        }
    }
}