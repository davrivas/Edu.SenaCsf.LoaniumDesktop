using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO {
    public interface IUsuarioDAO : IDAO<UsuarioDTO> {
        void Registrarse(UsuarioDTO u);
        int IniciarSesion(TipoDocumentoDTO td, string documento, string clave);
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
