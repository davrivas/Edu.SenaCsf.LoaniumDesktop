using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class ColeccionDTO {
        private int id;
        private string nombreColeccion;
        private string isbnColeccion;
        private LibroDTO libro;

        public ColeccionDTO() {
        }

        public ColeccionDTO(int id, string nombreColeccion, string isbnColeccion, LibroDTO libro) {
            this.Id = id;
            this.NombreColeccion = nombreColeccion;
            this.IsbnColeccion = isbnColeccion;
            this.Libro = libro;
        }

        public int Id { get => id; set => id = value; }
        public string NombreColeccion { get => nombreColeccion; set => nombreColeccion = value; }
        public string IsbnColeccion { get => isbnColeccion; set => isbnColeccion = value; }
        public LibroDTO Libro { get => libro; set => libro = value; }
    }
}
