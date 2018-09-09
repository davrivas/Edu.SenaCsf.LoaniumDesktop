using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public interface IDAO<T> {
        void Ingresar(T obj);
        void Editar(T obj);
        void Eliminar(T obj);
        List<T> MostrarTodos();
        T BuscarPorId(int id);
    }
}
