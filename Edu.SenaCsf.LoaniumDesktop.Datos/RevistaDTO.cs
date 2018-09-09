using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class RevistaDTO : MaterialDTO {
        private string issn;

        public RevistaDTO() : base() {
        }

        public RevistaDTO(int id, string titulo, string autor, DateTime fechaPublicacion, string descripcion, IdiomaDTO idioma, TipoMaterialDTO tipoMaterial, List<EjemplarMaterialDTO> ejemplares, string issn) : base(id, titulo, autor, fechaPublicacion, descripcion, idioma, tipoMaterial, ejemplares) {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.FechaPublicacion = fechaPublicacion;
            this.Descripcion = descripcion;
            this.Idioma = idioma;
            this.TipoMaterial = tipoMaterial;
            this.Ejemplares = ejemplares;
            this.Issn = issn;
        }

        public string Issn { get => issn; set => issn = value; }
    }
}
