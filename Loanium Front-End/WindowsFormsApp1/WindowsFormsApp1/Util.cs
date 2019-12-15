using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class Util : UserControl
    {
        Home h;
        public Util()
        {
            InitializeComponent();
        }

        public void LogOut()
        {
            DialogResult logout = MessageBox.Show("¿Seguro desea cerrar sesión?", "Loanium - Cerrar sesión",
           MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (logout == DialogResult.Yes)
            {
                DAO.UDAO.CerrarSesion();
                h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        public void Exit()
        {
            DialogResult exit = MessageBox.Show("¿Seguro desea Salir?", "Loanium - Salir",
           MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        public void Info()
        {
            MessageBox.Show
   ("Loanium - Biblioteca virtual\n" +
   "\nEsta aplicación está diseñada para cualquier biblioteca" +
   " que necesite mejorar sus procesos.\n" +
   "Loanium permitirá tener una base de datos organizada, además," +
   " agilizará el proceso de gestión del préstamo y donación de elementos" +
   " relacionados al entorno bibliotecario, optimizando el manejo de los" +
   " procesos de la empresa.\n\n" +
   "\nEquipo de desarrollo\n" +
   "\nDavid Santiago Rivas Agudelo\n" +
   "dsrivas2@misena.edu.co\n\n" +
    "Juan Alexander Vargas Ramos\n" +
    "javargas708@misena.edu.co", "Loanium - Ayuda",
   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }

        public void HelpA()
        {
            MessageBox.Show
("Loanium - Biblioteca Virtual\n" +
"\nEn el rol Administrador podrás interactuar con las siguientes opciones:\n\n\n" +
"Perfil\n\n" +
"En esta sección, puedes editar tus datos personales.\n\n\n" +
"Usuarios\n\n" +
"Módulo de gestión de usuarios, " +
"puedes agregar, editar o bloquear/desbloquear usuarios.\n\n\n" +
"Catalogo\n\n" +
"Se mostrará todo el material disponible en nuestra biblioteca virtual " +
"asi como las opciones de adición o edición del mismo.\n\n\n" +
"Mensajes\n\n" +
"En esta sección recibiras peticiones, quejas, " +
"reclamos y sugerencias por parte de los demás " +
"usuarios que interactuan en la Aplicación.\n\n\n" +
"Reportes\n\n" +
"Informe de donaciones/prestamos y el sumario del sistema " +
"hacen parte de este área de sistema.\n\n\n" +
"¡Esperamos que disfrutes de la aplicación!", "Loanium - Ayuda",
MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        public void HelpC()
        {
            MessageBox.Show
    ("Loanium - Biblioteca Virtual\n" +
    "\nEn el rol Cliente podrás interactuar con las siguientes opciones:\n\n\n" +
    "Perfil\n\n" +
    "En esta sección, puedes editar tus datos personales.\n\n\n" +
    "Buscar\n\n" +
    "Filtro global - puedes buscar lo que necesites en toda la aplicación.\n\n\n" +
    "Catalogo\n\n" +
    "Se mostrará todo el material disponible en nuestra biblioteca virtual.\n\n\n" +
    "Donaciones\n\n" +
    "Libros, Discos y Revistas podrán ser donadas desde este módulo; !Que esperas¡\n\n\n" +
     "PQRS (Peticiones Quejas, Reclamos y sugerencias)\n\n" +
     "Todo usuario tiene derecho a presentar ante peticiones, quejas, reclamos y sugerencias," +
     " por eso Loanium te brinda la posibilidad de interactuar con los " +
     "administradores mediante este módulo.\n\n\n" +
     "¡Esperamos que disfrutes de la aplicación!", "Loanium - Ayuda",
    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
    }
}
