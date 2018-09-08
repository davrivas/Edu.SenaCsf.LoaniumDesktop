using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    abstract class Material {
        private int id;
        private string titulo;
        private string autor;
        private DateTime fechaPublicacion;
        private string descripcion;
        private Idioma idioma;
        private TipoMaterial tipoMaterial;
        private List<EjemplarMaterial> ejemplares;
        private List<Tematica> tematicas;

        protected Material() {
        }

        protected Material(int id, string titulo, string autor, DateTime fechaPublicacion, string descripcion, Idioma idioma, TipoMaterial tipoMaterial, List<EjemplarMaterial> ejemplares) {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.FechaPublicacion = fechaPublicacion;
            this.Descripcion = descripcion;
            this.Idioma = idioma;
            this.TipoMaterial = tipoMaterial;
            this.Ejemplares = ejemplares;
        }

        protected int Id { get => id; set => id = value; }
        protected string Titulo { get => titulo; set => titulo = value; }
        protected string Autor { get => autor; set => autor = value; }
        protected DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        protected string Descripcion { get => descripcion; set => descripcion = value; }
        protected Idioma Idioma { get => idioma; set => idioma = value; }
        protected TipoMaterial TipoMaterial { get => tipoMaterial; set => tipoMaterial = value; }
        protected List<EjemplarMaterial> Ejemplares { get => ejemplares; set => ejemplares = value; }
        protected List<Tematica> Tematicas { get => tematicas; set => tematicas = value; }
        

        public abstract void IngresarMaterial(Material m);
        public abstract void ModificarMaterial(Material m);
        public abstract void EliminarMaterial(Material m);

        public List<Material> MostrarTodosLosMateriales() {
            return new List<Material>();
        }

        public List<Material> BusquedaSimple(string texto) {
            return new List<Material>();
        }

        public List<Material> BusquedaAvanzada(string texto, TipoMaterial tm) {
            return new List<Material>();
        }
    }
}
