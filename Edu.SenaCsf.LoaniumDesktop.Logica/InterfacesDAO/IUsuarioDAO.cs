using Edu.SenaCsf.LoaniumDesktop.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO {
    interface IUsuarioDAO : IDAO<UsuarioDTO> {
        UsuarioDTO IniciarSesion(int td, string documento, string clave);
        void CerrarSesion();
        void EditarPerfil(UsuarioDTO u);
        void CambiarClave(UsuarioDTO u, string claveActual, string claveNueva, string confirmacion);
        void SuspenderCuenta(UsuarioDTO u);
        void ReactivarCuenta(UsuarioDTO u);
        void SuspenderUsuario(UsuarioDTO u);
        void ReactivarUsuario(UsuarioDTO u);
        List<UsuarioDTO> MostrarNoSuspendidos(EstadoUsuarioDTO eu);
        List<UsuarioDTO> MostrarSuspendidos(EstadoUsuarioDTO eu);
    }
}
