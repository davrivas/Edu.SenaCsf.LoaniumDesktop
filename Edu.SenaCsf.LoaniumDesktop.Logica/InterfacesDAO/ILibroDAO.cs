using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO {
    interface ILibroDAO : IDAO<LibroDAO> {
        List<LibroDAO> MostrarPorColeccion(ColeccionDAO c);
    }
}
