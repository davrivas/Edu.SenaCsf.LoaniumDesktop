using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.Interfaces {
    interface IDonacionDAO : IDAO<DonacionDAO> {
        void AprobarDonacion(DonacionDAO d);
        void RechazarDonacion(DonacionDAO d);
        List<DonacionDAO> MostrarPorUsuario(UsuarioDAO u);
    }
}
