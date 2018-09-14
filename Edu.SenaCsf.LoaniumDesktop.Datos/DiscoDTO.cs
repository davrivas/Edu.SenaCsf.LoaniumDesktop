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

        public DiscoDTO(int id, string titulo, string autor, DateTime fechaPublicacion, string descripcion, IdiomaDTO idioma, TipoMaterialDTO tipoMaterial, EstadoMaterialDTO estadoMaterial, string duracion) : base(id, titulo, autor, fechaPublicacion, descripcion, idioma, tipoMaterial, estadoMaterial) {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.FechaPublicacion = fechaPublicacion;
            this.Descripcion = descripcion;
            this.Idioma = idioma;
            this.TipoMaterial = tipoMaterial;
            this.EstadoMaterial = estadoMaterial;
            this.Duracion = duracion;
        }

        public string Duracion { get => duracion; set => duracion = value; }
    }
}
