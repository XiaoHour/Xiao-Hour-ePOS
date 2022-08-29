using MaterialSkin;
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
using Xiao_Hour_ePOS.Models;

namespace Xiao_Hour_ePOS
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.is_exit = true;
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

          
            if (txtUsername.Text == "")
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Please enter your username", "OK", true);
                SnackBarMessage.Show(this);
                return;
            } 
            if (txtPassword.Text == "")
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Please enter your password", "OK", true);
                SnackBarMessage.Show(this);
                return;
            }

            MyDBContext db = new MyDBContext();

            List<UserModel> users = new List<UserModel>();
            users = db.Users.Where(r => r.username == txtUsername.Text && r.password == txtPassword.Text).ToList();


            if(users.Any())
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Login successfully", "OK", true);
                SnackBarMessage.Show(this);

                Program.currentLoginUsername = txtUsername.Text;

               
                //hide login form
                Program.loginForm = this;
                Program.loginForm.Hide();

                //open form home
                if (Program.homeForm == null)
                {
                    frmHome frmHome = new frmHome();
                    Program.homeForm = frmHome;

                }
                Program.homeForm.Show();




                //clear login form
                txtUsername.Text = "";
                txtPassword.Text = "";

            }else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Invalid username or password", "OK", true);
                SnackBarMessage.Show(this);

            }

            db.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MyDBContext db = new MyDBContext();

            List<UserModel> users = new List<UserModel>();
            users = db.Users.Where(r => r.username == txtUsername.Text && r.password == txtPassword.Text).ToList();

            db.Dispose();
            
        }
    }
}
