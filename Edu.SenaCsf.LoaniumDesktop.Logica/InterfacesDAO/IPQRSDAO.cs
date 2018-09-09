using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO {
    interface IPQRSDAO : IDAO<PQRSDAO> {
        void ResponderPQRS(PQRSDAO pqrs);
    }
}
