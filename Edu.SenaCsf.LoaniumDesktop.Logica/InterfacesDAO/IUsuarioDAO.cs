using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO {
    interface IUsuarioDAO : IDAO<UsuarioDAO> {
        void IniciarSesion(TipoDocumentoDAO td, string documento, string clave);
        void CerrarSesion();
        void EditarPerfil(UsuarioDAO u);
        void CambiarClave(UsuarioDAO u, string claveActual, string claveNueva, string confirmacion);
        void SuspenderCuenta(UsuarioDAO u);
        void ReactivarCuenta(UsuarioDAO u);
        void SuspenderUsuario(UsuarioDAO u);
        void ReactivarUsuario(UsuarioDAO u);
        List<UsuarioDAO> MostrarNoSuspendidos(EstadoUsuarioDAO eu);
        List<UsuarioDAO> MostrarSuspendidos(EstadoUsuarioDAO eu);
    }
}
