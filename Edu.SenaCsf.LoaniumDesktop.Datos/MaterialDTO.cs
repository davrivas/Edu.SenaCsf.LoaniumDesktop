using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class MaterialDTO {
        private int id;
        private string titulo;
        private string autor;
        private DateTime fechaPublicacion;
        private string descripcion;
        private IdiomaDTO idioma;
        private TipoMaterialDTO tipoMaterial;
        private List<EjemplarMaterialDTO> ejemplares;

        public MaterialDTO() {
        }

        public MaterialDTO(int id, string titulo, string autor, DateTime fechaPublicacion, string descripcion, IdiomaDTO idioma, TipoMaterialDTO tipoMaterial, List<EjemplarMaterialDTO> ejemplares) {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.FechaPublicacion = fechaPublicacion;
            this.Descripcion = descripcion;
            this.Idioma = idioma;
            this.TipoMaterial = tipoMaterial;
            this.Ejemplares = ejemplares;
        }

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public IdiomaDTO Idioma { get => idioma; set => idioma = value; }
        public TipoMaterialDTO TipoMaterial { get => tipoMaterial; set => tipoMaterial = value; }
        public List<EjemplarMaterialDTO> Ejemplares { get => ejemplares; set => ejemplares = new List<EjemplarMaterialDTO>(); }
    }
}
