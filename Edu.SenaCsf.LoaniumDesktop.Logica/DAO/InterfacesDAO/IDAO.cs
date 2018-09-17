﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO {
    public interface IDAO<T> {
        void Ingresar(T obj);
        void Editar(T obj);
        void Eliminar(T obj);
        T BuscarPorId(int id);
        int Contar();
    }
}
