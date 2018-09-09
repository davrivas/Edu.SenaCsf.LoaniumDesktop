using Edu.SenaCsf.LoaniumDesktop.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO {
    internal interface IObservacionDAO : IDAO<ObservacionDTO> {
        List<ObservacionDTO> MostrarPorPrestamo(PrestamoDTO p);
    }
}
