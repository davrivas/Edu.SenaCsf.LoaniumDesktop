using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class PrestamoDTO {
        private int id;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private EstadoPrestamoDTO estadoPrestamo;
        private UsuarioDTO usuario;
        private List<EjemplarMaterialDTO> ejemplares;
        private List<ObservacionDTO> observaciones;
    }
}
