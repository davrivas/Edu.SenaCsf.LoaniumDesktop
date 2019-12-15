using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class Administrator : Form
    {
        Util u;
        Home h;

        public Administrator()
        {
            InitializeComponent();
            sidePanel.Height = btn_profile.Height;
            sidePanel.Top = btn_profile.Top;
            catalog1.BringToFront();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_profile_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_profile.Height;
            sidePanel.Top = btn_profile.Top;
            profile1.BringToFront();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_user.Height;
            sidePanel.Top = btn_user.Top;
            user1.BringToFront();
        }

        private void btn_messages_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_messages.Height;
            sidePanel.Top = btn_messages.Top;
            messages1.BringToFront();
        }

        private void btn_catalog_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_catalog.Height;
            sidePanel.Top = btn_catalog.Top;
            catalog1.BringToFront();
        }

        private void btn_closeWindow_Click(object sender, EventArgs e)
        {
            u = new Util();
            u.Exit();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("¿Seguro desea cerrar sesión?", "Loanium - Cerrar sesión",
            MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (logout == DialogResult.Yes)
            {
                h = new Home();
                h.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btn_minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            u = new Util();
            u.HelpA();
        }

        private void btn_donate_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_messages.Height;
            sidePanel.Top = btn_messages.Top;
            donate1.BringToFront();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_profile.Height;
            sidePanel.Top = btn_profile.Top;
            profile1.BringToFront();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            u = new Util();
            u.Info();
        }
        private void Client_Load(object sender, EventArgs e)
        {
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            game1.BringToFront();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_reports.Height;
            sidePanel.Top = btn_reports.Top;
            reports1.BringToFront();
        }
    }
}