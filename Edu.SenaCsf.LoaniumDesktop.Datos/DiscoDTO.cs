using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class DiscoDTO : MaterialDTO {
        private string duracion;

        public DiscoDTO() : base() {
        }

        public DiscoDTO(int id, string titulo, string autor, DateTime fechaPublicacion, string descripcion, IdiomaDTO idioma, TipoMaterialDTO tipoMaterial, List<EjemplarMaterialDTO> ejemplares, string duracion) : base(id, titulo, autor, fechaPublicacion, descripcion, tipoMaterial, ejemplares) {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.FechaPublicacion = fechaPublicacion;
            this.Descripcion = descripcion;
            this.TipoMaterial = tipoMaterial;
            this.Ejemplares = ejemplares;
            this.Duracion = duracion;
        }

        public string Duracion { get => duracion; set => duracion = value; }
    }
}
