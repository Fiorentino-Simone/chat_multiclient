using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnAccedi.Enabled = false;
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            //vuoto
        }

        public String Textb()
        {
            return txtNome.Text;
        }

        public void slblU(String v)
        {
            label1.Text = v;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if(txtNome.Text.Length > 0) btnAccedi.Enabled = true;
        }

    }
}
