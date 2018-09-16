using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO {
    public class DAO {
        //Solo dejo los objetos DAO para no tener que instanciar objetos a cada rato
        private static DonacionDAO dDAO = new DonacionDAO();
        private static EstadoDonacionDAO edDAO = new EstadoDonacionDAO();
        private static EstadoMaterialDAO emDAO = new EstadoMaterialDAO();
        private static EstadoPQRSDAO epqrsDAO = new EstadoPQRSDAO();
        private static EstadoPrestamoDAO epDAO = new EstadoPrestamoDAO();
        private static EstadoUsuarioDAO euDAO = new EstadoUsuarioDAO();
        private static IdiomaDAO iDAO = new IdiomaDAO();
        private static PQRSDAO pqrsDAO = new PQRSDAO();
        private static PrestamoDAO pDAO = new PrestamoDAO();
        private static SuspensionDAO sDAO = new SuspensionDAO();
        private static TematicaDAO tDAO = new TematicaDAO();
        private static TipoDocumentoDAO tdDAO = new TipoDocumentoDAO();
        private static TipoMaterialDAO tmDAO = new TipoMaterialDAO();
        private static TipoPQRSDAO tpqrsDAO = new TipoPQRSDAO();
        private static TipoUsuarioDAO tuDAO = new TipoUsuarioDAO();
        private static UsuarioDAO uDAO = new UsuarioDAO();

        public static DonacionDAO DDAO { get => dDAO; set => dDAO = value; }
        public static EstadoDonacionDAO EdDAO { get => edDAO; set => edDAO = value; }
        public static EstadoMaterialDAO EmDAO { get => emDAO; set => emDAO = value; }
        public static EstadoPQRSDAO EpqrsDAO { get => epqrsDAO; set => epqrsDAO = value; }
        public static EstadoPrestamoDAO EpDAO { get => epDAO; set => epDAO = value; }
        public static EstadoUsuarioDAO EuDAO { get => euDAO; set => euDAO = value; }
        public static IdiomaDAO IDAO { get => iDAO; set => iDAO = value; }
        public static PQRSDAO PqrsDAO { get => pqrsDAO; set => pqrsDAO = value; }
        public static PrestamoDAO PDAO { get => pDAO; set => pDAO = value; }
        public static SuspensionDAO SDAO { get => sDAO; set => sDAO = value; }
        public static TematicaDAO TDAO { get => tDAO; set => tDAO = value; }
        public static TipoDocumentoDAO TdDAO { get => tdDAO; set => tdDAO = value; }
        public static TipoMaterialDAO TmDAO { get => tmDAO; set => tmDAO = value; }
        public static TipoPQRSDAO TpqrsDAO { get => tpqrsDAO; set => tpqrsDAO = value; }
        public static TipoUsuarioDAO TuDAO { get => tuDAO; set => tuDAO = value; }
        public static UsuarioDAO UDAO { get => uDAO; set => uDAO = value; }
    }
}
