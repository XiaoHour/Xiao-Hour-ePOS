using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiao_Hour_ePOS
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

     

        private void btnExit_Click(object sender, EventArgs e)
        {
            MaterialDialog materialDialog = new MaterialDialog(this, "Bye bye!", "Are you sure you want to exit me?", "Exit Me", true, "Stay with Me");
            DialogResult result = materialDialog.ShowDialog(this);

            if (result.ToString() == "OK")
            {
                Application.Exit();
            }

         
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();

            frm.Show();

            Program.loginForm = this;

            Program.loginForm.Hide();
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Login successfully", "OK", true);
            SnackBarMessage.Show(this);
        }
    }
}
