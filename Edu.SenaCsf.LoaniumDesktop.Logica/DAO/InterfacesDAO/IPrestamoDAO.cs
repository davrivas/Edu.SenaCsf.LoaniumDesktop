using Edu.SenaCsf.LoaniumDesktop.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO {
    internal interface IPrestamoDAO : IDAO<PrestamoDTO> {
        List<PrestamoDTO> MostrarPorUsuario(UsuarioDTO u);
    }
}
