using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos.DTO {
    public class TematicaDTO {
        private int id;
        private string numeroDewey;
        private string nombreTematica;

        public TematicaDTO() {
        }

        public TematicaDTO(int id, string numeroDewey, string nombreTematica) {
            this.Id = id;
            this.NumeroDewey = numeroDewey;
            this.NombreTematica = nombreTematica;
        }

        public int Id { get => id; set => id = value; }
        public string NumeroDewey { get => numeroDewey; set => numeroDewey = value; }
        public string NombreTematica { get => nombreTematica; set => nombreTematica = value; }
    }
}
