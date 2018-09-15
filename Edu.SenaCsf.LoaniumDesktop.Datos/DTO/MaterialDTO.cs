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
        private string isbn; //Libro
        private string editorial; //Libro
        private string issn; //Revista
        private string duracion; //Disco (DVD / CD)
        private IdiomaDTO idioma;
        private TipoMaterialDTO tipoMaterial;
        private EstadoMaterialDTO estadoMaterial;
        private TematicaDTO tematica;

        public MaterialDTO() {
        }

        public MaterialDTO(int id, string titulo, string autor, DateTime fechaPublicacion, string descripcion, string isbn, string editorial, string issn, string duracion, IdiomaDTO idioma, TipoMaterialDTO tipoMaterial, EstadoMaterialDTO estadoMaterial, TematicaDTO tematica) {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.FechaPublicacion = fechaPublicacion;
            this.Descripcion = descripcion;
            this.Isbn = isbn;
            this.Editorial = editorial;
            this.Issn = issn;
            this.Duracion = duracion;
            this.Idioma = idioma;
            this.TipoMaterial = tipoMaterial;
            this.EstadoMaterial = estadoMaterial;
            this.Tematica = tematica;
        }

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Issn { get => issn; set => issn = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public IdiomaDTO Idioma { get => idioma; set => idioma = value; }
        public TipoMaterialDTO TipoMaterial { get => tipoMaterial; set => tipoMaterial = value; }
        public EstadoMaterialDTO EstadoMaterial { get => estadoMaterial; set => estadoMaterial = value; }
        public TematicaDTO Tematica { get => tematica; set => tematica = value; }
    }
}
