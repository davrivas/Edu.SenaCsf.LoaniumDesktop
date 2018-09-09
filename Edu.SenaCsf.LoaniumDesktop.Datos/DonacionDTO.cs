using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class DonacionDTO {
        private int id;
        private DateTime fecha;
        private string otroMotivoRechazo;
        private EstadoDonacionDTO estadoDonacion;
        private List<EjemplarMaterialDTO> ejemplares;
        private List<MotivoRechazoDTO> motivosRechazo;
    }
}
