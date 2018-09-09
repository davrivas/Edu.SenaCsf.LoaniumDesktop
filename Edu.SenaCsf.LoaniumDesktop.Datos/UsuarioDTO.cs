using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class UsuarioDTO {
        private int id;
        private string nombres;
        private string apellidos;
        private string documento;
        private string correoElectronico;
        private string clave;
        private string telefono;
        private TipoDocumentoDTO tipoDocumento;
        private TipoUsuarioDTO tipoUsuario;
        private EstadoUsuarioDTO estadoUsuario;
    }
}
