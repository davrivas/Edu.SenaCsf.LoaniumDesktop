using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Edu.SenaCsf.LoaniumDesktop.Logica.UtilLogica;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class Home : Form
    {
        Client c;
        Administrator a;
        Util u;
        Loader l;
        //public bool isLoginSuccess = false;

        public Home()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            signUp1.Show();
            signUp1.BringToFront();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            l = new Loader();
            l.Show();
            this.Hide();
        }

        private void btn_closeWindow_Click(object sender, EventArgs e)
        {
            u = new Util();
            u.Exit();
        }

        private void btn_minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tb_document_Enter(object sender, EventArgs e)
        {
            if (tbDocument.Text == "Documento")
            {
                tbDocument.Text = "";
                tbDocument.ForeColor = Color.White;
            }
        }

        private void tb_document_Leave(object sender, EventArgs e)
        {
            if (tbDocument.Text == "")
            {
                tbDocument.Text = "Documento";
                tbDocument.ForeColor = Color.LightGray;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Contraseña")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.White;
                tbPassword.UseSystemPasswordChar = true;
            } /*else {
                backgroundWorker1.RunWorkerAsync();
                l = new Loader();
                l.Show();
                this.Hide();
            }*/
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Contraseña";
                tbPassword.ForeColor = Color.LightGray;
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        private void tbDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumber(e);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if (tbDocument.Text == "" || tbPassword.Text == "" || tbDocument.Text == "Documento" || tbPassword.Text == "Contraseña")
            {
                Thread.Sleep(0);
            }
            else if (tbDocument.Text != "" || tbPassword.Text != "" || tbDocument.Text != "Documento" || tbPassword.Text != "Contraseña")
            {
                Thread.Sleep(3000);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (tbDocument.Text != "" || tbPassword.Text != "") {
                int tipoDocumentoId = Convert.ToInt32(cb_docType.SelectedValue.ToString().Trim());
                string documento = tbDocument.Text.Trim(),
                    clave = tbPassword.Text.Trim();
                int usuario = DAO.UDAO.IniciarSesion(tipoDocumentoId, documento, clave);

                switch (usuario) {
                    case 1:
                        MessageBox.Show("Bienvenido " + UtilLogica.UsuarioSesion.TipoUsuario.Tipo + ": " + UtilLogica.UsuarioSesion.Nombres + " " + UtilLogica.UsuarioSesion.Apellidos, "Loanium - Inicio de Sesión");

                        switch (UtilLogica.UsuarioSesion.TipoUsuario.Id) {
                            case 1:
                                a = new Administrator();
                                a.Show();
                                break;
                            case 2:
                                c = new Client();
                                c.Show();
                                break;
                        }

                        this.Hide();
                        l.Close();
                        break;
                    case 2:
                        MessageBox.Show("ERROR: Usuario bloqueado", "Loanium - Inicio de Sesión");
                        l.Close();
                        this.Show();
                        break;
                    case 3:
                        // Mirar que se hace después
                        MessageBox.Show("ERROR: Has suspendido tu cuenta", "Loanium - Inicio de Sesión");
                        l.Close();
                        this.Show();
                        break;
                    case 0:
                        MessageBox.Show("ERROR: Usuario no encontrado", "Loanium - Inicio de Sesión");
                        l.Close();
                        this.Show();
                        break;
                }

            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablasDataSet.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.tablasDataSet.TipoDocumento);
            //cb_docType.
        }
    }
}
