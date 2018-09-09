using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
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

        public List<PrestamoDTO> MostrarTodos() {
            throw new NotImplementedException();
        }
    }
}
