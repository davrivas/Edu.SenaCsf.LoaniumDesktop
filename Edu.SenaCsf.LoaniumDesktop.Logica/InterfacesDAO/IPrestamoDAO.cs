using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.Interfaces {
    interface IPrestamoDAO : IDAO<PrestamoDAO> {
        List<PrestamoDAO> MostrarPorUsuario(UsuarioDAO u);
    }
}
