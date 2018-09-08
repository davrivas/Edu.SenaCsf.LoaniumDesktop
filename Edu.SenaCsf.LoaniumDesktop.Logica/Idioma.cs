﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Idioma {
        private int id;
        private string nombreIdioma;
        private string sigla;

        public Idioma() {
        }

        public Idioma(int id, string nombreIdioma, string sigla) {
            this.Id = id;
            this.NombreIdioma = nombreIdioma;
            this.Sigla = sigla;
        }

        public int Id { get => id; set => id = value; }
        public string NombreIdioma { get => nombreIdioma; set => nombreIdioma = value; }
        public string Sigla { get => sigla; set => sigla = value; }

        public void IngresarIdioma(Idioma i) { }

        public void ModificarIdioma(Idioma i) { }

        public void EliminarIdioma(Idioma i) { }

        public List<Idioma> MostrarTodos() {
            return new List<Idioma>();
        }
    }
}