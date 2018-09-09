using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class EstadoPrestamoDTO {
        private int id;
        private string estado;

        public EstadoPrestamoDTO() {
        }

        public EstadoPrestamoDTO(int id, string estado) {
            this.Id = id;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
