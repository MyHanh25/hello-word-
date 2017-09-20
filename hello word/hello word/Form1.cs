using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hello_word
{
    public partial class frmhelloword : Form
    {
        public frmhelloword()
        {
            InitializeComponent();
        }

        private void frmhelloword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblhelloword_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblHelloWord.Text = "Hello Word!";
        }
    }
}
