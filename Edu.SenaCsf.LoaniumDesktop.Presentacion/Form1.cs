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
            UsuarioDTO usuario = uDAO.IniciarSesion(tipoDocumento, documento, clave);

            if (usuario != null) {
                MessageBox.Show("Bienvenido " + usuario.Nombres + " " + usuario.Apellidos);
            } else {
                MessageBox.Show("ERROR: No se pudo iniciar sesión");
            }
        }
    }
}
