using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class TipoUsuarioDTO {
        private int id;
        private string tipo;

        public TipoUsuarioDTO() {
        }

        public TipoUsuarioDTO(int id, string tipo) {
            this.Id = id;
            this.Tipo = tipo;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
