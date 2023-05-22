using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatProject
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin fLogin = new frmLogin();
            Boolean flag = true;

            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                if (fLogin.Textb() != "")
                {
                    flag = false;
                    frmMain form = new frmMain();
                    form.setName(fLogin.Textb());
                    Application.Run(form);
                }
                else
                {
                    fLogin.slblU("Please enter");
                    //MessageBox.Show("Please enter");
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
