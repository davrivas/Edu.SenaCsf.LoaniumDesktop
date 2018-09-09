using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.Interfaces {
    interface ILibroDAO : IDAO<LibroDAO> {
        List<LibroDAO> MostrarPorColeccion(ColeccionDAO c);
    }
}
