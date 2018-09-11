using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class LibroDTO : MaterialDTO {
        private string isbn;
        private string editorial;
        private TematicaDTO tematica;

        public LibroDTO() : base() {
        }

        public LibroDTO(int id, string titulo, string autor, DateTime fechaPublicacion, string descripcion, TipoMaterialDTO tipoMaterial, List<EjemplarMaterialDTO> ejemplares, string isbn, string editorial, TematicaDTO tematica) : base(id, titulo, autor, fechaPublicacion, descripcion, tipoMaterial, ejemplares) {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.FechaPublicacion = fechaPublicacion;
            this.Descripcion = descripcion;
            this.TipoMaterial = tipoMaterial;
            this.Ejemplares = ejemplares;
            this.Isbn = isbn;
            this.Editorial = editorial;
            this.Tematica = tematica;
        }

        public string Isbn { get => isbn; set => isbn = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public TematicaDTO Tematica { get => tematica; set => tematica = value; }
    }
}
