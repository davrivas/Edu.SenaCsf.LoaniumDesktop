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

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class Loan : UserControl
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
