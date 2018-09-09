using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class SuspensionDTO {
        private int id;
        private DateTime fecha;
        private string detalle;
        private List<PrestamoDTO> prestamos;
    }
}
