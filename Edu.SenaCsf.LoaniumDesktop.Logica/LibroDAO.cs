using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class LibroDAO : ILibroDAO {
        public LibroDAO() {
        }

        public LibroDTO BuscarPorId(int id) {
            throw new NotImplementedException();
        }

        public void Editar(LibroDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(LibroDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(LibroDTO obj) {
            throw new NotImplementedException();
        }

        public List<LibroDTO> MostrarPorColeccion(ColeccionDTO c) {
            throw new NotImplementedException();
        }

        public List<LibroDTO> MostrarTodos() {
            throw new NotImplementedException();
        }
    }
}
