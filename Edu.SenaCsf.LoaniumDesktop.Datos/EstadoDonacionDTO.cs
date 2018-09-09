using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class EstadoDonacionDTO {
        private int id;
        private String estado;

        public EstadoDonacionDTO() {
        }

        public EstadoDonacionDTO(int id, string estado) {
            this.Id = id;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
