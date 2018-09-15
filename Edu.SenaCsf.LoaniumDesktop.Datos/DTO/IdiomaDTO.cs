using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos.DTO {
    public class IdiomaDTO {
        private int id;
        private string nombreIdioma;
        private string sigla;

        public IdiomaDTO() {
        }

        public IdiomaDTO(int id, string nombreIdioma, string sigla) {
            this.Id = id;
            this.NombreIdioma = nombreIdioma;
            this.Sigla = sigla;
        }

        public int Id { get => id; set => id = value; }
        public string NombreIdioma { get => nombreIdioma; set => nombreIdioma = value; }
        public string Sigla { get => sigla; set => sigla = value; }
    }
}
