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
    public partial class Messages : UserControl
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void Catalogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_send_mail_Click(object sender, EventArgs e)
        {

        }

        private void Messages_Load(object sender, EventArgs e)
        {
            List<Label> lbls = this.Controls.OfType<Label>().ToList();
            foreach (var lbl in lbls)
            {
                lbl.Parent = iMBTest;
                lbl.BackColor = Color.Transparent;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

        }

        private void rtbPQRS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}