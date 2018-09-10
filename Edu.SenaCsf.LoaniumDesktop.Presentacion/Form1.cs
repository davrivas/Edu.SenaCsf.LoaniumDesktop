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
            int tipoDocumento = Convert.ToInt32(comboBoxTipoDocumento.SelectedValue);
            string documento = textBoxDocumento.Text;
            string clave = textBoxClave.Text;

            if (uDAO.IniciarSesion(tipoDocumento, documento, clave)) {
                MessageBox.Show("Inicio de sesión con éxito!");
            } else {
                MessageBox.Show("ERROR: No se pudo iniciar sesión");
            }
        }
    }
}
