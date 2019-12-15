using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO;
using Edu.SenaCsf.LoaniumDesktop.Logica.UtilLogica;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class SignUp : UserControl {
        Loader l = new Loader();
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        public SignUp() {
            InitializeComponent();
            try {
                this.tipoDocumentoTableAdapter.Fill(this.tablasDataSet.TipoDocumento);
                this.tipoUsuarioTableAdapter.Fill(this.tablasDataSet.TipoUsuario);
            } catch (System.Exception ex) {
                MessageBox.Show(ex.Message);
            }

            if (UtilLogica.UsuarioSesion != null) {
                if (UtilLogica.UsuarioSesion.TipoUsuario.Id == 1) {
                    lblUserType.Show();
                    cbUserType.Show();
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e) {
            btnRegister.Enabled = false;
            lblSignUp.Text = "Registro de Usuario";
            btnRegister.Text = "Registrarse";
        }

        private void btn_close_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void tbNames_KeyPress(object sender, KeyPressEventArgs e) {
            Validation.OnlyText(e);
            if ((!string.IsNullOrEmpty(tbNames.Text))) {
                epNames.Icon = Properties.Resources.x24Check;
                epNames.SetError(tbNames, "OK");
                return;
            }
        }

        private void tbNames_Leave(object sender, EventArgs e) {
            if ((string.IsNullOrEmpty(tbNames.Text))) {
                epNames.Icon = Properties.Resources.x24Warning;
                epNames.SetError(tbNames, "Ingresa tu(s) nombre(s)");
                return;
            }
        }

        private void tbSNames_KeyPress(object sender, KeyPressEventArgs e) {
            Validation.OnlyText(e);
            if ((!string.IsNullOrEmpty(tbSNames.Text))) {
                epSNames.Icon = Properties.Resources.x24Check;
                epSNames.SetError(tbSNames, "OK");
                return;
            }
        }

        private void tbSNames_Leave(object sender, EventArgs e) {
            if ((string.IsNullOrEmpty(tbSNames.Text))) {
                epSNames.Icon = Properties.Resources.x24Warning;
                epSNames.SetError(tbSNames, "Ingresa tu(s) apellidos(s)");
                return;
            }
        }

        private void tbDocument_KeyPress(object sender, KeyPressEventArgs e) {
            Validation.OnlyNumber(e);
            if ((!string.IsNullOrEmpty(tbDocument.Text))) {
                epNames.Icon = Properties.Resources.x24Check;
                epNames.SetError(tbDocument, "OK");
                return;
            }
        }

        private void tbDocument_Leave(object sender, EventArgs e) {
            if ((string.IsNullOrEmpty(tbDocument.Text))) {
                epNames.Icon = Properties.Resources.x24Warning;
                epNames.SetError(tbDocument, "Ingresa tu documento");
                return;
            }
        }

        private void tbMail_KeyPress(object sender, KeyPressEventArgs e) {
            if (Regex.IsMatch(tbMail.Text, pattern)) {
                epEmail.Icon = Properties.Resources.x24Check;
                epEmail.SetError(this.tbMail, "OK");
            } else {
                epEmail.Icon = Properties.Resources.x24Waiting;
                epEmail.SetError(this.tbMail, "Example@example.ex");
                return;
            }
        }

        private void tbMail_Leave(object sender, EventArgs e) {
            if (!Regex.IsMatch(tbMail.Text, pattern)) {
                epEmail.Icon = Properties.Resources.x24Warning;
                epEmail.SetError(this.tbMail, "Ingresa una dirección de correo valida");
            } else {
                return;
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if ((!string.IsNullOrEmpty(tbPassword.Text)) && tbPassword.Text.Length >= 5) {
                epPassword.Icon = Properties.Resources.x24Check;
                epPassword.SetError(tbPassword, "OK");
                return;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e) {
            if ((string.IsNullOrEmpty(tbDocument.Text))) {
                epPassword.Icon = Properties.Resources.x24Warning;
                epPassword.SetError(tbPassword, "La contraseña debe tener 6 o más caracteres");
                return;
            }
        }

        private void tbCPassword_TextChanged(object sender, EventArgs e) {
            if (!tbCPassword.Text.Equals(string.Empty) && tbCPassword.Text.Equals(tbPassword.Text)) {
                epCPassword.Icon = Properties.Resources.x24Check;
                epCPassword.SetError(this.tbCPassword, "OK");
            } else {
                epCPassword.Icon = Properties.Resources.x24Warning;
                epCPassword.SetError(this.tbCPassword, "Las contraseñas no coinciden");
            }
        }

        private void tbTel_KeyPress(object sender, KeyPressEventArgs e) {
            Validation.OnlyNumber(e);
            epTel.Icon = Properties.Resources.x24Check;
            epTel.SetError(tbTel, "OK");

        }

        private void chkTerms_CheckedChanged(object sender, EventArgs e) {
            foreach (Control _textbox in Controls) {
                if (_textbox is TextBox && string.IsNullOrEmpty(_textbox.Text)) {
                    btnRegister.Enabled = false;
                } else if (chkTerms.Checked && _textbox is TextBox && !string.IsNullOrEmpty(_textbox.Text) && Regex.IsMatch(tbMail.Text, pattern)) {
                    btnRegister.Enabled = true;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            bwRegister.RunWorkerAsync();
            l.Show();
            this.Hide();
        }

        private void bwRegister_DoWork(object sender, DoWorkEventArgs e) {
            foreach (Control _textbox in Controls) {
                if (_textbox is TextBox && string.IsNullOrEmpty(_textbox.Text)) {
                Thread.Sleep(0);
            } else if (chkTerms.Checked && _textbox is TextBox && !string.IsNullOrEmpty(_textbox.Text) && Regex.IsMatch(tbMail.Text, pattern)) {
                Thread.Sleep(500);
            }
        }
    }

        private void bwRegister_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            UsuarioDTO usuario = new UsuarioDTO {
                Nombres = tbNames.Text.Trim(),
                Apellidos = tbSNames.Text.Trim(),
                Documento = tbDocument.Text.Trim(),
                FechaNacimiento = Convert.ToDateTime(dtpDateBirth.Value.ToString().Trim()),
                CorreoElectronico = tbMail.Text.Trim(),
                Clave = tbPassword.Text.Trim(),
                Telefono = tbTel.Text.Trim(),
                TipoDocumento = DAO.TdDAO.BuscarPorId(Convert.ToInt32(cbDocumentType.SelectedValue.ToString().Trim()))
            };

            l.Show();

            int cant = DAO.UDAO.Registrarse(usuario);

            if (cant == 1) {
                MessageBox.Show("Registro de usuario realizado exitosamente");
                tbNames.Text = "";
                tbSNames.Text = "";
                tbDocument.Text = "";
                cbDocumentType.SelectedValue = 1;
                tbDocument.Text = "";
                dtpDateBirth.Value = DateTime.Now;
                tbMail.Text = "";
                tbPassword.Text = "";
                tbCPassword.Text = "";
                tbTel.Text = "";
                chkTerms.Checked = false;
            } else {
                MessageBox.Show("ERROR: El registro no fue realizado");
            }

            l.Hide();
        }
    }
}
