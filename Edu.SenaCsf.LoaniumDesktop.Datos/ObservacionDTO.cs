using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class ObservacionDTO {
        private int id;
        private string detalle;

        public ObservacionDTO() {
        }

        public ObservacionDTO(int id, string detalle) {
            this.Id = id;
            this.Detalle = detalle;
        }

        public int Id { get => id; set => id = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}
