using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public interface IDAO<T> {
        void Ingresar(T clase);
        void Editar(T clase);
        void Eliminar(T clase);
        List<T> MostrarTodos();
        T BuscarPorId();
    }
}
