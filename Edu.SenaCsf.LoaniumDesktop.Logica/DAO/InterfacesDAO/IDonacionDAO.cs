using Edu.SenaCsf.LoaniumDesktop.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO {
    internal interface IDonacionDAO : IDAO<DonacionDTO> {
        void AprobarDonacion(DonacionDTO d);
        void RechazarDonacion(DonacionDTO d);
        List<DonacionDTO> MostrarPorUsuario(UsuarioDTO u);
        List<DonacionDTO> MostrarAprobadas(EstadoDonacionDTO ed);
        List<DonacionDTO> MostrarNoAprobadas(EstadoDonacionDTO ed);
    }
}
