using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class ColeccionDTO {
        private int id;
        private string nombreColeccion;
        private string isbnColeccion;
        private List<Libro> libros;

        public ColeccionDTO() {
        }

        public ColeccionDTO(int id, string nombreColeccion, string isbnColeccion) {
            this.Id = id;
            this.NombreColeccion = nombreColeccion;
            this.IsbnColeccion = isbnColeccion;
        }

        public int Id { get => id; set => id = value; }
        public string NombreColeccion { get => nombreColeccion; set => nombreColeccion = value; }
        public string IsbnColeccion { get => isbnColeccion; set => isbnColeccion = value; }
        internal List<Libro> Libros { get => libros; set => libros = value; }
    }
}
