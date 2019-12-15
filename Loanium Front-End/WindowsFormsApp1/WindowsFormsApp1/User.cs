using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            List<Label> lbls = this.Controls.OfType<Label>().ToList();
            foreach (var lbl in lbls)
            {
                lbl.Parent = iMBTest;
                lbl.BackColor = Color.Transparent;
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            signUp1.Show();
            signUp1.BringToFront();
            signUp1.lblSignUp.Text = "Registro de Usuario";
            signUp1.btnRegister.Text = "Registrar Usuario";
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            signUp1.Show();
            signUp1.BringToFront();
            signUp1.lblSignUp.Text = "Editar Usuario";
            signUp1.btnRegister.Text = "Editar Usuario";
        }
    }
}
