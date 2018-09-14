using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica;
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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'loaniumDataSet.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.loaniumDataSet.TipoDocumento);

        }
        
        private void ButtonIniciar_Click(object sender, EventArgs e) {
            UsuarioDAO uDAO = new UsuarioDAO();
            TipoDocumentoDAO tdDAO = new TipoDocumentoDAO();
            int td = Convert.ToInt32(comboBoxTipoDocumento.SelectedValue);
            TipoDocumentoDTO tipoDocumento = tdDAO.BuscarPorId(td);
            string documento = textBoxDocumento.Text;
            string clave = textBoxClave.Text;
            int usuario = uDAO.IniciarSesion(tipoDocumento, documento, clave);

            switch (usuario) {
                case 1:
                    MessageBox.Show("Bienvenido " + Sesion.Usuario.Nombres + " " + Sesion.Usuario.Apellidos);
                    break;
                case 2:
                    MessageBox.Show("ERROR: Usuario suspendido");
                    break;
                case 0:
                    MessageBox.Show("ERROR: No se pudo iniciar sesión");
                    break;
            }
        }
    }
}
