using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class ObservacionDAO : IObservacionDAO {
        public ObservacionDAO() {
        }

        public ObservacionDTO BuscarPorId(int id) {
            throw new NotImplementedException();
        }

        public void Editar(ObservacionDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(ObservacionDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(ObservacionDTO obj) {
            throw new NotImplementedException();
        }

        public List<ObservacionDTO> MostrarPorPrestamo(PrestamoDTO p) {
            throw new NotImplementedException();
        }

        public List<ObservacionDTO> MostrarTodos() {
            throw new NotImplementedException();
        }
    }
}
