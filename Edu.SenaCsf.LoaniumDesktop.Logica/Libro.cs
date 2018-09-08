using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Libro : Material {
        private string isbn;
        private string editorial;

        public Libro() : base() {
        }

        public Libro(string isbn, string editorial) /*const padre*/ {
            this.Isbn = isbn;
            this.Editorial = editorial;
        }

        public string Isbn { get => isbn; set => isbn = value; }
        public string Editorial { get => editorial; set => editorial = value; }

        public override void EliminarMaterial(Material m) {
            throw new NotImplementedException();
        }

        public override void IngresarMaterial(Material m) {
            throw new NotImplementedException();
        }

        public override void ModificarMaterial(Material m) {
            throw new NotImplementedException();
        }

        public List<Libro> MostrarTodos() {
            return new List<Libro>();
        }
    }
}
