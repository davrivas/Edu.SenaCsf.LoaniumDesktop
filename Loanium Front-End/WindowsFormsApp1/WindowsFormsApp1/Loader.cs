﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);
        }
    }
}
