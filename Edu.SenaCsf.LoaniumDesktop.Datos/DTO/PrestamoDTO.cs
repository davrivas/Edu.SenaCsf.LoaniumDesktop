﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos.DTO {
    public class PrestamoDTO {
        private int id;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private EstadoPrestamoDTO estadoPrestamo;
        private UsuarioDTO usuario;
        private MaterialDTO material;

        public PrestamoDTO() {
        }

        public PrestamoDTO(int id, DateTime fechaPrestamo, DateTime fechaDevolucion, EstadoPrestamoDTO estadoPrestamo, UsuarioDTO usuario, MaterialDTO material) {
            this.Id = id;
            this.FechaPrestamo = fechaPrestamo;
            this.FechaDevolucion = fechaDevolucion;
            this.EstadoPrestamo = estadoPrestamo;
            this.Usuario = usuario;
            this.Material = material;
        }

        public int Id { get => id; set => id = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public EstadoPrestamoDTO EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
        public UsuarioDTO Usuario { get => usuario; set => usuario = value; }
        public MaterialDTO Material { get => material; set => material = value; }
    }
}
