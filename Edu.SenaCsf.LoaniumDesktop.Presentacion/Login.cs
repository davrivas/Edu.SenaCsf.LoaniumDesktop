using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO;
using Edu.SenaCsf.LoaniumDesktop.Logica.Sesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'tipoDocumentoDataSet.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.tipoDocumentoDataSet.TipoDocumento);

        }

        private void button1_Click(object sender, EventArgs e) {
            UsuarioDAO uDAO = new UsuarioDAO();
            TipoDocumentoDAO tdDAO = new TipoDocumentoDAO();
            int tdId = Convert.ToInt32(comboBox1.SelectedValue.ToString().Trim());
            TipoDocumentoDTO td = tdDAO.BuscarPorId(tdId);
            string documento = textBox1.Text.Trim(),
                clave = textBox2.Text.Trim();
            int usuario = uDAO.IniciarSesion(td, documento, clave);

            switch (usuario) {
                case 1:
                    MessageBox.Show("Bienvenido " + Sesion.Usuario.Nombres + " " + Sesion.Usuario.Apellidos + "\n" +
                        "Será dirigido a la página de " + Sesion.Usuario.TipoUsuario.Tipo);
                    break;
                case 2:
                    MessageBox.Show("ERROR: Usuario bloqueado");
                    break;
                case 3:
                    MessageBox.Show("ERROR: Usted se ha dado de baja"); // Mirar que se hace después
                    break;
                case 0:
                    MessageBox.Show("ERROR: Usuario no encontrado");
                    break;
            }
        }
    }
}
