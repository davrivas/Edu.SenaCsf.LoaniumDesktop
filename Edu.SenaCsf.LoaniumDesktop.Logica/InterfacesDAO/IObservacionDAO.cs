using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.Interfaces {
    interface IObservacionDAO : IDAO<ObservacionDAO> {
        List<ObservacionDAO> MostrarPorPrestamo(PrestamoDAO p);
    }
}
