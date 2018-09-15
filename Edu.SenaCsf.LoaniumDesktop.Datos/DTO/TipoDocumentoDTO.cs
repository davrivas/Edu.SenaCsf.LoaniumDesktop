using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class TipoDocumentoDTO {
        private int id;
        private string tipo;
        private string sigla;

        public TipoDocumentoDTO() {
        }

        public TipoDocumentoDTO(int id, string tipo, string sigla) {
            this.Id = id;
            this.Tipo = tipo;
            this.Sigla = sigla;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Sigla { get => sigla; set => sigla = value; }
    }
}
