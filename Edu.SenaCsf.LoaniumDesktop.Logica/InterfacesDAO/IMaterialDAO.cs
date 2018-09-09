using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.Interfaces {
    interface IMaterialDAO : IDAO<MaterialDAO> {
        List<MaterialDAO> BusquedaSimple(string texto);
        List<MaterialDAO> BusquedaAvanzada(string texto, IdiomaDAO i, TipoMaterialDAO tm);
    }
}
