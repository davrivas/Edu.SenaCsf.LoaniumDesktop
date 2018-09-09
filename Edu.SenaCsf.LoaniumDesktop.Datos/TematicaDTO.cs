using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class TematicaDTO {
        private int id;
        private int numeroDewey;
        private string nombreTematica;

        public TematicaDTO() {
        }

        public TematicaDTO(int id, int numeroDewey, string nombreTematica) {
            this.Id = id;
            this.NumeroDewey = numeroDewey;
            this.NombreTematica = nombreTematica;
        }

        public int Id { get => id; set => id = value; }
        public int NumeroDewey { get => numeroDewey; set => numeroDewey = value; }
        public string NombreTematica { get => nombreTematica; set => nombreTematica = value; }
    }
}
